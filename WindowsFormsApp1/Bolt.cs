using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devDept.Eyeshot.Converters;
using WindowsFormsApp1;
using Region = devDept.Eyeshot.Entities.Region;
using TriangleNet.Geometry;

namespace CreateBotSpring
{
    public class Bolt : IModelEntity, IModelFemMesh/**/
    {
        #region PropeField
        /// <summary>
        /// 螺栓大径
        /// </summary>
        public double d { set; get; }  // d

        /// <summary>
        /// 螺栓小径
        /// </summary>
        public double d1 { set; get; } // d3

        /// <summary>
        /// 螺距
        /// </summary>
        public double p { set; get; } // p

        /// <summary>
        /// 公称长度(螺杆总长度)
        /// </summary>
        public double l { set; get; } // ls

        /// <summary>
        /// 光杆长度
        /// </summary>
        public double l1 { set; get; } // l1

        /// <summary>
        /// 螺纹长度
        /// </summary>
        public double b { set; get; } // ls - l1 / ls - l2

        /// <summary>
        /// 螺帽宽
        /// </summary>
        public double s { set; get; } // 螺母对边宽度 s短对边
        /// <summary>
        /// 螺帽高
        /// </summary>
        public double e { set; get; } // 标准中没有螺帽的概念  用螺母替代尝试   长对边
        /// <summary>
        /// 螺帽长
        /// </summary>
        public double k { set; get; }  // 这个才是高度

        // 非尺寸属性
        /// <summary>
        /// 螺栓显示模式
        /// </summary>
        public int ShowType { set; get; }
        private FemMesh _boltMesh; // 有限元连接件

        const int liujiao = 6;
        List<Tuple<Point3D, Point3D>> luomaoTop = new List<Tuple<Point3D, Point3D>>();
        List<Tuple<Point3D, Point3D>> luomaoBottom_luoganTop = new List<Tuple<Point3D, Point3D>>();
        List<Tuple<Point3D, Point3D>> luoganBottom_luowenTop = new List<Tuple<Point3D, Point3D>>();
        // 构造器
        public Bolt()
        {

        }

        public Bolt(BoltClass dataBolt)
        {
            this.d = dataBolt.NormalD_d;
            this.d1 = dataBolt.ScrewMinD_d3;
            this.p = dataBolt.ScrewP_P;
            this.l = dataBolt.BoltLen_ls;
            this.l1 = dataBolt.BoltLen_ls;
            this.b = this.l - dataBolt.PolishRodLen_l1 - dataBolt.PolishRodLen_l2;
            this.s = dataBolt.BoltNutSideWid_s;
            this.e = this.s * 1.155;
            this.k = this.s / 2; 
        }
        #endregion

        private const int _slice = 100;
        private const double _tol = .1;

        public Entity GetEntity()
        {
            return GetBolt(1);
            //return CombineCybineAndSpring();
        }

        private Solid GetLuoMao()
        {
            Point3D[] points = GetLuoMaoPoints();
            var r = devDept.Eyeshot.Entities.Region.CreatePolygon(points);
            var luoMao = r.ExtrudeAsSolid(0, 0, k, _tol);
            return luoMao;
        }

        private Solid GetLuoMaoAndLoad()
        {
            Point3D[] points = GetLuoMaoPoints();
            var r = Region.CreatePolygon(points);

            Circle boltCircle = new Circle(new Point3D(0, 0, 0), 1);

            double kd = 3;
            var box = Solid.CreateBox(kd, kd, k / 2);
            box.Translate(boltCircle.Center.X - kd / 2, boltCircle.Center.Y - kd / 2, l + k / 2); // 螺帽力箭头的位置
            luomaoTop.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));
            r = Region.Difference(r, new Region(boltCircle))[0];
            var luoMao = r.ExtrudeAsSolid(0, 0, k, _tol);
            return luoMao;
        }
        /// <summary>
        /// 获取不同表达形式的螺栓Solid对象
        /// </summary>
        /// <param name="type">
        /// 0： 螺纹以圆柱表达
        /// 1： 螺纹以等距牙型圈表达
        /// 其他：螺纹以等距螺旋线扫描表达，在一些给定的参数下，表达不一定成功
        /// </param>
        /// <returns></returns>
        private Entity GetBolt(int type = 1)
        {
            Solid bolt;
            // 最简单表达方式
            if (type == 0)
            {
                var luoGan = Solid.CreateCylinder(d / 2, l - b, _slice);
                var luoWen = Solid.CreateCylinder(d / 2, b, _slice);
                luoGan.Translate(0, 0, b);
                var luoMao = GetLuoMao();
                var result = Solid.Union(new List<Solid> { luoGan, luoWen, luoMao });

                if (result == null || result.Length != 1)
                {
                    throw new Exception($"实体合并结果异常, 合并结果={result.Length}");
                }

                return bolt = result[0];
            }

            // 圈式螺纹表达方式
            if (type == 1)
            {
                var section = new LinearPath(GetPointsForCybine9());
                section.Rotate(Math.PI / 2, new Vector3D(0, 1, 0));
                devDept.Eyeshot.Entities.Region r = new devDept.Eyeshot.Entities.Region(section);
                var sectionSlice = r.RevolveAsSolid(0, 2 * Math.PI, Vector3D.AxisZ, Point3D.Origin, _slice, _tol);
                List<Solid> listOfSlice = new List<Solid>();
                for (int i = 0; i < b / p + 1; i++)
                {
                    Solid s = sectionSlice.Clone() as Solid;
                    s.Translate(0, 0, p * i);
                    listOfSlice.Add(s);
                }
                var luoGan = Solid.CreateCylinder(d / 2, l - b, _slice);
                var luoMao = GetLuoMao();
                luoGan.Translate(0, 0, b);
                var luoGanTop = Solid.CreateCylinder(d * 1.2 / 2, 1, _slice);
                luoGanTop.Translate(0, 0, l - 1);
                luoGan = Solid.Union(luoGan, luoGanTop)[0];
                
                listOfSlice.Add(luoGan);
                listOfSlice.Add(luoMao);
                var result = Solid.Union(listOfSlice);
                if (result == null || result.Length != 1)
                {
                    throw new Exception($"实体合并结果异常, 合并结果={result.Length}");
                }

                return bolt = result[0];
            }
            Brep spring = CombineCybineAndSpring();
            // 螺旋扫描表达方式
            spring.Regen(.1);
            return spring.ConvertToSolid();
        }
        private Brep CombineCybineAndSpring()
        {
            LinearPath path = new LinearPath(GetPoints());
            // 旋转至关于X轴对称
            path.Rotate(Math.PI / 2, Vector3D.AxisY);

            // 旋转扫描螺旋线
            double turns = b / p;
            LinearPath lp = LinearPath.CreateHelix(1, p, turns, false, 0.25);
            Curve rail = Curve.CubicSplineInterpolation(lp.Vertices);
            Plane normalToRail = new Plane(rail.StartPoint, rail.StartTangent);
            // 旋转面
            devDept.Eyeshot.Entities.Region sectionReg = new devDept.Eyeshot.Entities.Region(path);
            var spring = sectionReg.SweepAsBrep(rail, .1, sweepMethodType.RoadlikeTop);

            devDept.Eyeshot.Entities.Region r;
            // 切除底部多余牙
            r = devDept.Eyeshot.Entities.Region.CreateCircle(Plane.XY, d / 2);
            spring.ExtrudeRemove(r, new Interval(0, -p / 2));

            // 螺杆
            r = devDept.Eyeshot.Entities.Region.CreateCircle(Plane.XY, d / 2);
            spring.ExtrudeAdd(r, new Interval(b, l));
            r = devDept.Eyeshot.Entities.Region.CreateCircle(Plane.XY, d1 / 2);
            spring.ExtrudeAdd(r, new Interval(0, b));

            // 螺帽
            Point3D[] points = GetLuoMaoPoints();
            r = devDept.Eyeshot.Entities.Region.CreatePolygon(points);
            spring.ExtrudeAdd(r, new Interval(0, -k));
            return spring;

            // 螺帽倒角
            // todo 
        }
        /// <summary>
        /// 计算螺帽正六边形的7个顶点（封闭）
        /// </summary>
        /// <returns></returns>
        private Point3D[] GetLuoMaoPoints()
        {
            Point3D[] points = new Point3D[6];

            points[0] = new Point3D(0, e / 2, l);
            points[1] = new Point3D(s / 2, e / 2 - s / 2 * Math.Tan(Math.PI / 6), l );
            points[2] = new Point3D(s / 2, -(e / 2 - s / 2 * Math.Tan(Math.PI / 6)), l );
            points[3] = new Point3D(0, -e / 2, l );
            points[4] = new Point3D(-s / 2, -(e / 2 - s / 2 * Math.Tan(Math.PI / 6)), l );
            points[5] = new Point3D(-s / 2, e / 2 - s / 2 * Math.Tan(Math.PI / 6), l );
            //points[6] = new Point3D(0, e / 2, l);
            return points;
        }

        /// <summary>
        /// 获取牙型坐标，该坐标包含大径部分，共9个点
        /// </summary>
        /// <returns></returns>
        private Point3D[] GetPointsForCybine9()
        {
            Point3D[] result = new Point3D[9];
            result[0] = new Point3D(p / 8, 0, d / 2);
            result[1] = new Point3D(3 * p / 8, 0, d1 / 2);
            result[2] = new Point3D(p / 2, 0, d1 / 2);
            result[3] = new Point3D(p / 2, 0, 0);
            result[4] = new Point3D(-p / 2, 0, 0);
            result[5] = new Point3D(-p / 2, 0, d1 / 2);
            result[6] = new Point3D(-3 * p / 8, 0, d1 / 2);
            result[7] = new Point3D(-p / 8, 0, d / 2);
            result[8] = new Point3D(p / 8, 0, d / 2);
            return result;
        }

        /// <summary>
        /// 获取该螺栓牙型的ZX面的5个顺时针坐标
        /// </summary>
        /// <returns></returns>
        private Point3D[] GetPoints()
        {
            Point3D[] result = new Point3D[5];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Point3D();
            }

            // 0-3 与 4-7 关于Z轴对称
            result[0].X = p / 8; result[3].X = -p / 8;
            result[0].Z = d / 2; result[3].Z = d / 2;

            result[1].X = 3 * p / 8; result[2].X = -3 * p / 8;
            result[1].Z = d1 / 2; result[2].Z = d1 / 2;

            // 封闭点
            result[4].X = p / 8;
            result[4].Z = d / 2;

            return result;
        }

        public Entity GetEntity(double height)
        {
            throw new NotImplementedException();
        }

        public void SetForceFor(int index, double fz, double fx = 0, double fy = 0)
        {
            if (_boltMesh == null)
            {
                GetFemMesh();
            }
            var box = luomaoTop[index];
            _boltMesh.SetForce(box.Item1, box.Item2, .1, new Vector3D(fx, fy, -fz));
        }

       

        public void SetForceForLuoGan(int index,  double fz, double fx = 0, double fy = 0)
        {
            if (_boltMesh == null)
            {
                GetFemMesh();
            }
            var box = luomaoBottom_luoganTop[index];
            _boltMesh.SetForce(box.Item1, box.Item2, .1, new Vector3D(fx , fy , fz));
        }

        /*
        // 实现网格的螺栓
        public FemMesh GetFemMesh()
        {
            luomaoTop.Clear();
            luomaoBottom_luoganTop.Clear();

            //// 六个角
            ICurve curve = new LinearPath(GetLuoMaoPoints3D());
            var baseReg = new Region(new List<ICurve>() { curve });

            // 螺杆圆
            ICurve ridusCurve = new Circle(new Point3D(0, 0, 0), d / 2);
            var baseRegBottom = new Region(new List<ICurve>() { ridusCurve });

            Circle boltCircle = new Circle(new Point3D(0, 0, 0), 0.1);

            double kd = 3;
            var box = Solid.CreateBox(kd, kd, k / 2);
            box.Translate(boltCircle.Center.X - kd / 2, boltCircle.Center.Y - kd / 2, l + k / 2); // 力箭头的位置
            luomaoTop.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));
            baseReg = Region.Difference(baseReg, new Region(boltCircle))[0];


            Circle luoganLoadCircle = new Circle(new Point3D(d / 2, 0, 0), 0.1);

            double angle = Math.PI * 2 / liujiao;
            for (int i = 0; i < liujiao; i++)
            {
                double x = 3;
                var b = Solid.CreateBox(x, x, k / 2);
                b.Translate(luoganLoadCircle.Center.X - x / 2, luoganLoadCircle.Center.Y - x / 2, l - k / 2); // 力箭头的位置
                luomaoBottom_luoganTop.Add(new Tuple<Point3D, Point3D>(b.BoxMin, b.BoxMax));
                baseReg = Region.Difference(baseReg, new Region(luoganLoadCircle))[0];
                luoganLoadCircle.Rotate(angle, Vector3D.AxisZ);
            }

            var mesh = baseReg.Triangulate(5);
            var luomaoFemMesh = mesh.ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            luomaoFemMesh.Extrude(new Vector3D(0, 0, k)); //  + ddz
            luomaoFemMesh.Translate(0, 0, l);


            // 螺杆无螺纹
            ICurve midCircle = new Circle(new Point3D(0, 0, 0), d / 2);
            var midRegion = new Region(midCircle);
            var midMesh = midRegion.Triangulate(3);
            var midFemMesh = midMesh.ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            midFemMesh.Extrude(new Vector3D(0, 0, l - b));
            midFemMesh.Translate(0, 0, b);


            ICurve bottomCircle = new Circle(new Point3D(0, 0, 0), d1 / 2);
            var bRegion = new Region(bottomCircle);
            var bMesh = bRegion.Triangulate(3);
            _boltMesh = bMesh.ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            _boltMesh.Extrude(new Vector3D(0, 0, l));
            
            _boltMesh.MergeWith(midFemMesh, true);
            _boltMesh.MergeWith(luomaoFemMesh, true);

            _boltMesh.FixAll(Plane.XY, 0.1);

            return _boltMesh;
        }
        */

        public FemMesh GetFemMesh()
        {
            var section = new LinearPath(GetPointsForCybine9());
            section.Rotate(Math.PI / 2, new Vector3D(0, 1, 0));
            devDept.Eyeshot.Entities.Region r = new devDept.Eyeshot.Entities.Region(section);

            var sectionSlice = r.RevolveAsSolid(0, 2 * Math.PI, Vector3D.AxisZ, Point3D.Origin, _slice, _tol);
            List<Solid> listOfSlice = new List<Solid>();
            for (int i = 0; i < b / p + 1; i++)
            {
                Solid s = sectionSlice.Clone() as Solid;
                s.Translate(0, 0, p * i);
                listOfSlice.Add(s);
            }
            var luoGan = Solid.CreateCylinder(d / 2, l - b, _slice);
            var luoMao = GetLuoMao();
            luoGan.Translate(0, 0, b);
            listOfSlice.Add(luoGan);
            listOfSlice.Add(luoMao);
            var result = Solid.Union(listOfSlice);
            if (result == null || result.Length != 1)
            {
                throw new Exception($"实体合并结果异常, 合并结果={result.Length}");
            }
            var solid = result[0];


            //// 做力的施加点
            //ICurve curve = new LinearPath(GetLuoMaoPoints3D());
            //var baseReg = new Region(new List<ICurve>() { curve });
            //Circle boltCircle = new Circle(new Point3D(0, 0, 0), d / 2);

            //double kd = 3;
            //var box = Solid.CreateBox(kd, kd, k / 2);
            //box.Translate(boltCircle.Center.X - kd / 2, boltCircle.Center.Y - kd / 2, l + k / 2); // 螺帽力箭头的位置
            //luomaoTop.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));
            //baseReg = Region.Difference(baseReg, new Region(boltCircle))[0];



            double kd = 3;
            var cylinder = Solid.CreateBox(3,3,l+k);
            var res = Solid.Difference(solid, cylinder)[0];
            var box = Solid.CreateBox(kd, kd, k / 2);
            box.Translate(0, 0, l+k/2);
            luomaoTop.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));

            _boltMesh = res.ConvertToMesh().ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            _boltMesh.FixAll(Plane.XY, 0.1);
            return _boltMesh;
        }

        private FemMesh GetFemLuoWen()
        {
            List<Solid> listOfSlice = new List<Solid>();
            var section = new LinearPath(GetPointsForCybine9());
            section.Rotate(Math.PI / 2, new Vector3D(0, 1, 0));
            Region r = new Region(section);
            var sectionSlice = r.RevolveAsSolid(0, 2 * Math.PI, Vector3D.AxisZ, Point3D.Origin, _slice, _tol);
            for (int i = 0; i < b / p; i++)
            {
                Solid s = sectionSlice.Clone() as Solid;
                s.Translate(0, 0, p * i);
                listOfSlice.Add(s);
            }
            return (Solid.Union(listOfSlice)[0]).ConvertToMesh().ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
        }

        // test only
        public Model model { set; get; }
    }

    
}
