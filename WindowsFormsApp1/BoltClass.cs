using CreateBotSpring;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BoltModel;

namespace WindowsFormsApp1
{
    public class BoltMaterialClass
    {
        public string BoltMaterialLevel { get; set; }
        public double BoltMaterialRatio { get; set; }
        public double BoltMaterialRatio_fB { get; set; }
        public double BoltMaterialEs { get; set; }
        public double BoltMaterialRpmin { get; set; }
        public double BoltMaterialRm { get; set; }
        public double BoltMaterialA { get; set; }
        public double BoltMaterialTmax { get; set; }
    }

    public class BoltClass : BoltParameter, IModelEntity, IModelFemMesh/**/
    {
        
        
        // 螺栓数据
        public double NormalD_d { get; set; }
        public double ScrewP_P { get; set; }
        public double BoltLen_ls { get; set; }
        public double BoreD_dh { get; set; }
        public double BoreD_dT { get; set; }
        public double BoltHeadOutD_dw { get; set; }
        public double BoltHeadInnerD_da { get; set; }
        public double ScrewMidD_d2 { get; set; }
        public double ScrewMinD_d3 { get; set; }
        public double PolishRodLen_l1 { get; set; }
        public double PolishRodLen_l2 { get; set; }
        public double BoltNutSideWid_s { get; set; }
        public double BoltNutScrewMinD_D1 { get; set; }

        public BoltMaterialClass boltMaterial { get; set; }

        public BoltClass()
        {
            boltMaterial = new BoltMaterialClass();
        }

        public BoltClass(Bolt bolt)
        {
            // sel db
            selDb(bolt);
            boltMaterial = new BoltMaterialClass();
        }

        private void selDb(Bolt bolt)
        {
            string sql = "select * from dbo_BoltTable " +
                   "where normalD=" + bolt.d + " and " + "ScrewMinD_d3=" + bolt.d1 + " and ScrewP_P=" + bolt.p + 
                   " and BoltLen_ls=" + bolt.l + " and PolishRodLen_l1=" + bolt.l1 + " and BoltNutSideWid_s=" + bolt.s;

            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            if (dr.Read())
            {
                string normalD_d, screwP_P, boltLen_ls, boreD_dh, BoreD_dT, boltHeadOutD_dw, boltHeadInnerD_da,
                    screwMidD_d2, screwMinD_d3, polishRodLen_l1, polishRodLen_l2, boltNutSideWid_s, boltNutScrewMinD_D1;
                string nutIndex, gasketIndex;
                normalD_d = dr["normalD_d"].ToString();
                screwP_P = dr["screwP_P"].ToString();
                boltLen_ls = dr["boltLen_ls"].ToString();
                boreD_dh = dr["boreD_dh"].ToString();
                BoreD_dT = dr["dT"].ToString();
                boltHeadOutD_dw = dr["boltHeadOutD_dw"].ToString();
                boltHeadInnerD_da = dr["boltHeadInnerD_da"].ToString();
                screwMidD_d2 = dr["screwMidD_d2"].ToString();
                screwMinD_d3 = dr["screwMinD_d3"].ToString();
                polishRodLen_l1 = dr["polishRodLen_l1"].ToString();
                polishRodLen_l2 = dr["polishRodLen_l2"].ToString();
                boltNutSideWid_s = dr["boltNutSideWid_s"].ToString();
                boltNutScrewMinD_D1 = dr["boltNutScrewMinD_D1"].ToString();
                nutIndex = dr["dbo_bolttable.nutIndex"].ToString();
                gasketIndex = dr["dbo_bolttable.gasketIndex"].ToString();

                string[] str = { normalD_d, screwP_P, boltLen_ls, boreD_dh, BoreD_dT, boltHeadOutD_dw, boltHeadInnerD_da,
                        screwMidD_d2, screwMinD_d3, polishRodLen_l1, boltNutSideWid_s, boltNutScrewMinD_D1 };

                this.BoltLen_ls = double.Parse(boltLen_ls);
                this.NormalD_d = double.Parse(normalD_d);
                this.ScrewP_P = double.Parse(screwP_P);
                this.BoreD_dh = double.Parse(boreD_dh);
                this.BoreD_dT = double.Parse(BoreD_dT);
                this.BoltHeadOutD_dw = double.Parse(boltHeadOutD_dw);
                this.BoltHeadInnerD_da = double.Parse(boltHeadInnerD_da);
                this.ScrewMidD_d2 = double.Parse(screwMidD_d2);
                this.ScrewMinD_d3 = double.Parse(screwMinD_d3);
                this.PolishRodLen_l1 = double.Parse(polishRodLen_l1);
                this.BoltNutSideWid_s = double.Parse(boltNutSideWid_s);
                this.BoltNutScrewMinD_D1 = double.Parse(boltNutScrewMinD_D1);
            }
            else
            {
                MessageBox.Show("不存在标准螺栓");
                return;
            }
            dr.Close();
        }


        protected const int _slice = 100;
        protected const double _tol = .1;

        public override Entity GetEntity()
        {
            return GetBolt(1);
            //return CombineCybineAndSpring();
        }

        private Solid GetLuoMao()
        {
            Point3D[] points = GetLuoMaoPoints();
            var r = devDept.Eyeshot.Entities.Region.CreatePolygon(points);
            var luoMao = r.ExtrudeAsSolid(0, 0, BoltNutSideWid_s / 2, _tol);
            return luoMao;
        }

        private Entity GetBolt(int type = 1)
        {
            Solid bolt;
            // 最简单表达方式
            if (type == 0)
            {
                var luoGan = Solid.CreateCylinder(NormalD_d / 2, BoltLen_ls - (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                var luoWen = Solid.CreateCylinder(NormalD_d / 2, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                luoGan.Translate(0, 0, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2));
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
                Region r = new Region(section);
                var sectionSlice = r.RevolveAsSolid(0, 2 * Math.PI, Vector3D.AxisZ, Point3D.Origin, _slice, _tol);
                List<Solid> listOfSlice = new List<Solid>();
                for (int i = 0; i < (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2) / ScrewP_P  + 1; i++)
                {
                    Solid s = sectionSlice.Clone() as Solid;
                    s.Translate(0, 0, ScrewP_P * i);
                    listOfSlice.Add(s);
                }
                var luoGan = Solid.CreateCylinder(NormalD_d / 2, BoltLen_ls - (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                var luoMao = GetLuoMao();
                luoGan.Translate(0, 0, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2));
                var luoGanTop = Solid.CreateCylinder(NormalD_d * 1.2 / 2, 1, _slice);
                luoGanTop.Translate(0, 0, BoltLen_ls - 1);
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
        private Point3D[] GetPoints()
        {
            Point3D[] result = new Point3D[5];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Point3D();
            }

            // 0-3 与 4-7 关于Z轴对称
            result[0].X = ScrewP_P / 8; result[3].X = -ScrewP_P / 8;
            result[0].Z = NormalD_d / 2; result[3].Z = NormalD_d / 2;

            result[1].X = 3 * ScrewP_P / 8; result[2].X = -3 * ScrewP_P / 8;
            result[1].Z = BoltNutScrewMinD_D1 / 2; result[2].Z = BoltNutScrewMinD_D1 / 2;

            // 封闭点
            result[4].X = ScrewP_P / 8;
            result[4].Z = NormalD_d / 2;

            return result;
        }
        protected Brep CombineCybineAndSpring()
        {
            LinearPath path = new LinearPath(GetPoints());
            // 旋转至关于X轴对称
            path.Rotate(Math.PI / 2, Vector3D.AxisY);

            // 旋转扫描螺旋线
            double turns = (BoltLen_ls-PolishRodLen_l1-PolishRodLen_l2) / ScrewP_P;
            LinearPath lp = LinearPath.CreateHelix(1, ScrewP_P, turns, false, 0.25);
            Curve rail = Curve.CubicSplineInterpolation(lp.Vertices);
            Plane normalToRail = new Plane(rail.StartPoint, rail.StartTangent);
            // 旋转面
            devDept.Eyeshot.Entities.Region sectionReg = new devDept.Eyeshot.Entities.Region(path);
            var spring = sectionReg.SweepAsBrep(rail, .1, sweepMethodType.RoadlikeTop);

            devDept.Eyeshot.Entities.Region r;
            // 切除底部多余牙
            r = devDept.Eyeshot.Entities.Region.CreateCircle(Plane.XY, NormalD_d / 2);
            spring.ExtrudeRemove(r, new Interval(0, -ScrewP_P / 2));

            // 螺杆
            r = devDept.Eyeshot.Entities.Region.CreateCircle(Plane.XY, NormalD_d / 2);
            spring.ExtrudeAdd(r, new Interval(BoltLen_ls-PolishRodLen_l1-PolishRodLen_l2, BoltLen_ls));
            r = devDept.Eyeshot.Entities.Region.CreateCircle(Plane.XY, BoltNutScrewMinD_D1 / 2);
            spring.ExtrudeAdd(r, new Interval(0, BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2));

            // 螺帽
            Point3D[] points = GetLuoMaoPoints();
            r = devDept.Eyeshot.Entities.Region.CreatePolygon(points);
            spring.ExtrudeAdd(r, new Interval(0, -BoltNutSideWid_s/ 2));
            return spring;

            // 螺帽倒角
            // todo 
        }
        private Point3D[] GetLuoMaoPoints()
        {
            Point3D[] points = new Point3D[6];

            points[0] = new Point3D(0, 1.155 * BoltNutSideWid_s / 2, BoltLen_ls);
            points[1] = new Point3D(BoltNutSideWid_s / 2, BoltNutSideWid_s * 1.155 / 2 - BoltNutSideWid_s / 2 * Math.Tan(Math.PI / 6), BoltLen_ls);
            points[2] = new Point3D(BoltNutSideWid_s / 2, -(BoltNutSideWid_s * 1.155 / 2 - BoltNutSideWid_s / 2 * Math.Tan(Math.PI / 6)), BoltLen_ls);
            points[3] = new Point3D(0, -1.155 * BoltNutSideWid_s / 2, BoltLen_ls);
            points[4] = new Point3D(-BoltNutSideWid_s / 2, -(BoltNutSideWid_s * 1.155 / 2 - BoltNutSideWid_s / 2 * Math.Tan(Math.PI / 6)), BoltLen_ls);
            points[5] = new Point3D(-BoltNutSideWid_s / 2, BoltNutSideWid_s * 1.155 / 2 - BoltNutSideWid_s / 2 * Math.Tan(Math.PI / 6), BoltLen_ls);
            //points[6] = new Point3D(0, e / 2, l);
            return points;
        }

        protected Point3D[] GetPointsForCybine9()
        {
            Point3D[] result = new Point3D[9];
            result[0] = new Point3D(ScrewP_P / 8, 0, NormalD_d / 2);
            result[1] = new Point3D(3 * ScrewP_P / 8, 0, ScrewMinD_d3 / 2);
            result[2] = new Point3D(ScrewP_P / 2, 0, ScrewMinD_d3 / 2);
            result[3] = new Point3D(ScrewP_P / 2, 0, 0);
            result[4] = new Point3D(-ScrewP_P / 2, 0, 0);
            result[5] = new Point3D(-ScrewP_P / 2, 0, ScrewMinD_d3 / 2);
            result[6] = new Point3D(-3 * ScrewP_P / 8, 0, ScrewMinD_d3 / 2);
            result[7] = new Point3D(-ScrewP_P / 8, 0, NormalD_d / 2);
            result[8] = new Point3D(ScrewP_P / 8, 0, NormalD_d / 2);
            return result;
        }

        public FemMesh GetFemMesh()
        {
            var section = new LinearPath(GetPointsForCybine9());
            section.Rotate(Math.PI / 2, new Vector3D(0, 1, 0));
            devDept.Eyeshot.Entities.Region r = new devDept.Eyeshot.Entities.Region(section);

            var sectionSlice = r.RevolveAsSolid(0, 2 * Math.PI, Vector3D.AxisZ, Point3D.Origin, _slice, _tol);
            List<Solid> listOfSlice = new List<Solid>();
            for (int i = 0; i < (BoltLen_ls-PolishRodLen_l1-PolishRodLen_l2) / ScrewP_P + 1; i++)
            {
                Solid s = sectionSlice.Clone() as Solid;
                s.Translate(0, 0, ScrewP_P * i);
                listOfSlice.Add(s);
            }
            var luoGan = Solid.CreateCylinder(NormalD_d / 2, BoltLen_ls - (BoltLen_ls-PolishRodLen_l1-PolishRodLen_l2), _slice);
            var luoMao = GetLuoMao();
            luoGan.Translate(0, 0, BoltLen_ls-PolishRodLen_l1-PolishRodLen_l2);
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
            var cylinder = Solid.CreateBox(3, 3, BoltLen_ls + BoltNutSideWid_s / 2);
            var res = Solid.Difference(solid, cylinder)[0];
            var box = Solid.CreateBox(kd, kd, BoltNutSideWid_s / 2 / 2);
            box.Translate(0, 0, BoltLen_ls + BoltNutSideWid_s / 2 / 2);
            luomaoTop.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));

            _boltMesh = res.ConvertToMesh().ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            _boltMesh.FixAll(Plane.XY, 0.1);
            return _boltMesh;
        }

        //public override Entity GetEntity()
        //{
        //    throw new NotImplementedException();
        //}


        public void SetForceFor(int index, double fz, double fx = 0, double fy = 0)
        {
            if (_boltMesh == null)
            {
                GetFemMesh();
            }
            var box = luomaoTop[index];
            _boltMesh.SetForce(box.Item1, box.Item2, .1, new Vector3D(fx, fy, -fz));
        }



        public void SetForceForLuoGan(int index, double fz, double fx = 0, double fy = 0)
        {
            if (_boltMesh == null)
            {
                GetFemMesh();
            }
            var box = luomaoBottom_luoganTop[index];
            _boltMesh.SetForce(box.Item1, box.Item2, .1, new Vector3D(fx, fy, fz));
        }


        public int ShowType { set; get; }
        private FemMesh _boltMesh; // 有限元连接件

        const int liujiao = 6;
        List<Tuple<Point3D, Point3D>> luomaoTop = new List<Tuple<Point3D, Point3D>>();
        List<Tuple<Point3D, Point3D>> luomaoBottom_luoganTop = new List<Tuple<Point3D, Point3D>>();
        List<Tuple<Point3D, Point3D>> luoganBottom_luowenTop = new List<Tuple<Point3D, Point3D>>();
    }


    public class BoltInner6 : BoltClass, IModelEntity, IModelFemMesh/**/
    {
        public BoltInner6(BoltChooseClass boltChooseClass)
        {
            NormalD_d = boltChooseClass.NormalD_d;
            ScrewP_P = boltChooseClass.ScrewP_P;
            BoltLen_ls = boltChooseClass.BoltLen_ls;
            BoreD_dh = boltChooseClass.BoreD_dh;
            BoreD_dT = boltChooseClass.BoreD_dT;
            BoltHeadOutD_dw = boltChooseClass.BoltHeadOutD_dw;
            BoltHeadInnerD_da = boltChooseClass.BoltHeadInnerD_da;
            ScrewMidD_d2 = boltChooseClass.ScrewMidD_d2;
            ScrewMinD_d3 = boltChooseClass.ScrewMinD_d3;
            PolishRodLen_l1 = boltChooseClass.PolishRodLen_l1;
            PolishRodLen_l2 = boltChooseClass.PolishRodLen_l2;
            BoltNutSideWid_s = boltChooseClass.BoltNutSideWid_s;
            BoltNutScrewMinD_D1 = boltChooseClass.BoltNutScrewMinD_D1;
        }

        public BoltInner6()
        {
        }

        public override Entity GetEntity()
        {
            return this.GetBolt(1);
            //return CombineCybineAndSpring();
        }
        //public Entity GetEntityInner()
        //{
        //    return this.GetBolt(1);
        //}
        public Entity GetBolt(int type = 1)
        {
            Solid bolt;
            // 最简单表达方式
            if (type == 0)
            {
                var luoGan = Solid.CreateCylinder(NormalD_d / 2, BoltLen_ls - (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                var luoWen = Solid.CreateCylinder(NormalD_d / 2, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                luoGan.Translate(0, 0, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2));
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
                for (int i = 0; i < (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2) / ScrewP_P + 1; i++)
                {
                    Solid s = sectionSlice.Clone() as Solid;
                    s.Translate(0, 0, ScrewP_P * i);
                    listOfSlice.Add(s);
                }
                var luoGan = Solid.CreateCylinder(NormalD_d / 2, BoltLen_ls - (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                var luoMao = GetLuoMao();
                luoGan.Translate(0, 0, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2));
                var luoGanTop = Solid.CreateCylinder(NormalD_d * 1.2 / 2, 1, _slice);
                luoGanTop.Translate(0, 0, BoltLen_ls - 1);
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
        // 六个节点创建六边形
        private Point3D[] GetLuoMaoPoints()
        {
            Point3D[] points = new Point3D[6];

            points[0] = new Point3D(0, NormalD_d / 2, BoltLen_ls);
            points[1] = new Point3D(Math.Sqrt(3) * NormalD_d / 4, NormalD_d / 4 , BoltLen_ls);
            points[2] = new Point3D(Math.Sqrt(3) * NormalD_d / 4, -NormalD_d / 4 , BoltLen_ls);
            points[3] = new Point3D(0, -NormalD_d / 2, BoltLen_ls);
            points[4] = new Point3D(-Math.Sqrt(3) * NormalD_d / 4, -NormalD_d / 4, BoltLen_ls);
            points[5] = new Point3D(-Math.Sqrt(3) * NormalD_d / 4, NormalD_d / 4, BoltLen_ls);
            return points;
        }
        private Solid GetLuoMao()
        {
            Point3D[] points = GetLuoMaoPoints();
            var r = Region.CreatePolygon(points);
            var inner6 = r.ExtrudeAsSolid(0, 0, BoltNutSideWid_s * 1.155 / 4, _tol);
            inner6.Translate(0, 0, BoltNutSideWid_s * 1.155 / 4);
            var luoMao = Solid.CreateCylinder(BoltNutSideWid_s / 2, BoltNutSideWid_s * 1.155 / 2, _slice);
            luoMao.Translate(0, 0, BoltLen_ls);
            return Solid.Difference(luoMao, inner6)[0];
        }
    }

    public class BoltFaLan : BoltClass, IModelEntity, IModelFemMesh
    {
        public BoltFaLan(BoltChooseClass boltChooseClass)
        {
            NormalD_d = boltChooseClass.NormalD_d;
            ScrewP_P = boltChooseClass.ScrewP_P;
            BoltLen_ls = boltChooseClass.BoltLen_ls;
            BoreD_dh = boltChooseClass.BoreD_dh;
            BoreD_dT = boltChooseClass.BoreD_dT;
            BoltHeadOutD_dw = boltChooseClass.BoltHeadOutD_dw;
            BoltHeadInnerD_da = boltChooseClass.BoltHeadInnerD_da;
            ScrewMidD_d2 = boltChooseClass.ScrewMidD_d2;
            ScrewMinD_d3 = boltChooseClass.ScrewMinD_d3;
            PolishRodLen_l1 = boltChooseClass.PolishRodLen_l1;
            PolishRodLen_l2 = boltChooseClass.PolishRodLen_l2;
            BoltNutSideWid_s = boltChooseClass.BoltNutSideWid_s;
            BoltNutScrewMinD_D1 = boltChooseClass.BoltNutScrewMinD_D1;
        }

        public BoltFaLan()
        {
        }

        public override Entity GetEntity()
        {
            return this.GetBolt(1);
        }
        
        public Entity GetBolt(int type = 1)
        {
            Solid bolt;
            // 最简单表达方式
            if (type == 0)
            {
                var luoGan = Solid.CreateCylinder(NormalD_d / 2, BoltLen_ls - (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                var luoWen = Solid.CreateCylinder(NormalD_d / 2, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                luoGan.Translate(0, 0, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2));
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
                for (int i = 0; i < (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2) / ScrewP_P + 1; i++)
                {
                    Solid s = sectionSlice.Clone() as Solid;
                    s.Translate(0, 0, ScrewP_P * i);
                    listOfSlice.Add(s);
                }
                var luoGan = Solid.CreateCylinder(NormalD_d / 2, BoltLen_ls - (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2), _slice);
                var luoMao = GetLuoMao();
                luoGan.Translate(0, 0, (BoltLen_ls - PolishRodLen_l1 - PolishRodLen_l2));
                var luoGanTop = Solid.CreateCylinder(NormalD_d * 1.2 / 2, 1, _slice);
                luoGanTop.Translate(0, 0, BoltLen_ls + 1);
                luoMao = Solid.Union(luoMao, luoGanTop)[0];
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
        // 六个节点创建六边形
        
        private Solid GetLuoMao()
        {
            Point3D[] points = GetLuoMaoPoints();
            var r = devDept.Eyeshot.Entities.Region.CreatePolygon(points);
            var luoMao = r.ExtrudeAsSolid(0, 0, BoltNutSideWid_s / 2, _tol);
            var falan = Solid.CreateCylinder(BoltNutSideWid_s * 1.25 / 2, 1, _slice);
            falan.Translate(0, 0, BoltLen_ls);
            return Solid.Union(luoMao, falan)[0];
        }

        private Point3D[] GetLuoMaoPoints()
        {
            Point3D[] points = new Point3D[6];

            points[0] = new Point3D(0, 1.155 * BoltNutSideWid_s / 2, BoltLen_ls);
            points[1] = new Point3D(BoltNutSideWid_s / 2, BoltNutSideWid_s * 1.155 / 2 - BoltNutSideWid_s / 2 * Math.Tan(Math.PI / 6), BoltLen_ls);
            points[2] = new Point3D(BoltNutSideWid_s / 2, -(BoltNutSideWid_s * 1.155 / 2 - BoltNutSideWid_s / 2 * Math.Tan(Math.PI / 6)), BoltLen_ls);
            points[3] = new Point3D(0, -1.155 * BoltNutSideWid_s / 2, BoltLen_ls);
            points[4] = new Point3D(-BoltNutSideWid_s / 2, -(BoltNutSideWid_s * 1.155 / 2 - BoltNutSideWid_s / 2 * Math.Tan(Math.PI / 6)), BoltLen_ls);
            points[5] = new Point3D(-BoltNutSideWid_s / 2, BoltNutSideWid_s * 1.155 / 2 - BoltNutSideWid_s / 2 * Math.Tan(Math.PI / 6), BoltLen_ls);
            //points[6] = new Point3D(0, e / 2, l);
            return points;
        }
    }
}
