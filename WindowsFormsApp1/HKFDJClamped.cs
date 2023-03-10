using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using devDept.Graphics;
using WindowsFormsApp1.ClampedModel;

namespace WindowsFormsApp1
{
    public class HKFDJClamped : ClampedHeight, IModelEntityClampeds, IModelFemMesh
    {
        #region PropeField
        
        // 连接件个数
        public double num { set; get; }

        public double outer_A { set; get; }
        public double inner_B { set; get; }
        public double C { set; get; } // 对称孔的距离
        public double d { set; get; } // 孔高度
        public double n { set; get; } // 孔个数
        // 连接件高度
        public double tf { set; get; } 
        public Model Mode { set; get; }
        //public double ddz = 1;  // 垫片厚
      
        // 弹性模量
        public double TanXingMoLiang { set; get; }
        #endregion  

        private const int _slice = 100;
        private const double _tol = 0.1;
        
        public HKFDJClamped(SelfAssClamped a)
        {
            outer_A = a.falan.A;
            inner_B = a.falan.B;
            C = a.falan.C;
            d = a.falan.d;
            n = a.falan.n;
            tf = a.feilun.tf * 2;
        }

        public HKFDJClamped()
        {
        }

        // 孔个数？
        private List<Tuple<Point3D, Point3D>> _boundingBoxOfBoltHole = new List<Tuple<Point3D, Point3D>>();
        private List<Tuple<Point3D, Point3D>> _lastHole = new List<Tuple<Point3D, Point3D>>();
        private FemMesh _flangeFMCache; // 有限元连接件

        public override Entity GetEntity()
        {
            return GetFlange();
        }

        public void SetForceFor(int index, double fz, double fx = 0, double fy = 0)
        {
            if (_flangeFMCache == null)
            {
                GetFemMesh();
            }
            var box = _boundingBoxOfBoltHole[index];
            _flangeFMCache.SetForce(box.Item1, box.Item2, .1, new Vector3D(fx, fy, -fz));
        }

        public void SetForceForSub(int index, double fz, double fx = 0, double fy = 0)
        {
            if (_flangeFMCache == null)
            {
                GetFemMesh();
            }
            var box = _lastHole[index];
            _flangeFMCache.SetForce(box.Item1, box.Item2, .1, new Vector3D(fx, fy, -fz));
        }
        public FemMesh GetFemMesh()
        {
            // 底部
            ICurve baseCircle = new Circle(Plane.XY, outer_A / 2);
            ICurve slotCircle = new Circle(Plane.XY, inner_B / 2);
            var baseReg = new Region(new List<ICurve>() { baseCircle, slotCircle });

            _boundingBoxOfBoltHole.Clear();
            Circle boltCircle = new Circle(new Point3D(C / 2, 0, 0), d / 2);
            double deltAngle = Math.PI * 2 / n;
            // 螺栓孔
            for (int i = 0; i < n; i++)
            {
                // 单元体选择区间
                double kd = 1.3 * d;
                var box = Solid.CreateBox(kd, kd, tf);
                box.Translate(boltCircle.Center.X - kd / 2, boltCircle.Center.Y - kd / 2, .5 * tf);
                _boundingBoxOfBoltHole.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));

                baseReg = Region.Difference(baseReg, new Region(boltCircle))[0];
                boltCircle.Rotate(deltAngle, Vector3D.AxisZ);
            }
            var mesh = baseReg.Triangulate(5);
            _flangeFMCache = mesh.ConvertToFemMesh(Material.StainlessSteel, false);
            _flangeFMCache.Extrude(new Vector3D(0, 0, tf));
            _flangeFMCache.FixAll(Plane.XY, 0.1);
            return _flangeFMCache;
        }

        /*
        //画图 有限元盘
        public FemMesh GetFemMesh()
        {
            // 底部
            ICurve baseCircle = new Circle(Plane.XY, outer_A / 2);
            ICurve slotCircle = new Circle(Plane.XY, inner_B / 2);
            var baseReg = new Region(new List<ICurve>() { baseCircle, slotCircle });

            _boundingBoxOfBoltHole.Clear();

            Circle boltCircle = new Circle(new Point3D(C / 2, 0, 0), d / 2);
            double deltAngle = Math.PI * 2 / n;
            // 螺栓孔
            for (int i = 0; i < n; i++)
            {
                // 单元体选择区间
                double kd = 1.3 * d;
                var box = Solid.CreateBox(kd, kd, tf);
                box.Translate(boltCircle.Center.X - kd / 2, boltCircle.Center.Y - kd / 2,  .5 * tf);
                _boundingBoxOfBoltHole.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));

                baseReg = Region.Difference(baseReg, new Region(boltCircle))[0];
                boltCircle.Rotate(deltAngle, Vector3D.AxisZ);
            }
            var mesh = baseReg.Triangulate(5);
            _flangeFMCache = mesh.ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            _flangeFMCache.Extrude(new Vector3D(0, 0, tf));//  + ddz  高度上扩展
            _flangeFMCache.Translate(0, 0, tf);//  + ddz  高度上扩展
            for (int i = 1; i < num - 1; i++)
            {
                var meshtemp = baseReg.Triangulate(5);
                var femmeshtemp = meshtemp.ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
                femmeshtemp.Extrude(new Vector3D(0, 0, tf));//  + ddz  高度上扩展
                femmeshtemp.Translate(0, 0, tf * (i + 1));
                _flangeFMCache.MergeWith(femmeshtemp, true);
            }
            _flangeFMCache.MergeWith(GetFemLastClamped(), true);

            _flangeFMCache.FixAll(Plane.XY, 0.1);
            return _flangeFMCache;
        }
        */
        private FemMesh GetFemLastClamped()
        {
            // 底部
            ICurve baseCircle = new Circle(Plane.XY, outer_A / 2);
            ICurve slotCircle = new Circle(Plane.XY, inner_B / 2);
            var baseReg = new Region(new List<ICurve>() { baseCircle, slotCircle });

            _lastHole.Clear();

            Circle boltCircle = new Circle(new Point3D(C / 2, 0, 0), d / 2);
            double deltAngle = Math.PI * 2 / n;
            // 螺栓孔
            for (int i = 0; i < n; i++)
            {
                // 单元体选择区间
                double kd = 1.3 * d;
                var box = Solid.CreateBox(kd, kd, tf);
                box.Translate(boltCircle.Center.X - kd / 2, boltCircle.Center.Y - kd / 2, (num ) * tf + 0.5 * tf);
                _lastHole.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));

                baseReg = Region.Difference(baseReg, new Region(boltCircle))[0];
                boltCircle.Rotate(deltAngle, Vector3D.AxisZ);
            }
            var mesh = baseReg.Triangulate(5);
            var res = mesh.ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            res.Extrude(new Vector3D(0, 0, tf));//  + ddz  高度上扩展
            res.Translate(0, 0, tf * (num ));
            return res;
        }

        private Solid GetFlange()
        {
            var section = new LinearPath(GetSectionPoints());
            var r = new Region(section);

            var genus = r.RevolveAsSolid(0, Math.PI * 2, Vector3D.AxisZ, Point3D.Origin, _slice, _tol);
            var pl = Plane.XY;
            pl.Translate(0, 0, 0);//ddz
            var boltHole = Region.CreateCircle(pl, d / 2);
            boltHole.Translate(C / 2, 0, 0);
            double deltAngle = Math.PI * 2 / n;
            for (int i = 0; i < n; i++)
            {
                boltHole.Rotate(deltAngle, Vector3D.AxisZ);
                genus.ExtrudeRemove(boltHole, tf, _tol);
            }
            return genus;
        }

        private Point3D[] GetSectionPoints()
        {
            Point3D[] p = new Point3D[5];
            p[0] = new Point3D(inner_B / 2, 0, tf);
            p[1] = new Point3D(outer_A / 2, 0, tf);
            p[2] = new Point3D(outer_A / 2, 0, 0);
            p[3] = new Point3D(inner_B / 2, 0, 0);
            p[4] = new Point3D(inner_B / 2, 0, tf);
            return p;
        }

        List<Entity> entities = new List<Entity>();
        EntityList list;
        public List<Entity> GetEntitys()
        {
            entities.Clear();
            var clamped1 = GetEntity();
            entities.Add(clamped1);

            for (int i = 1; i < num; i++)
            {
                var temp = clamped1.Clone() as Solid;
                temp.Translate(0, 0, tf * i);
                entities.Add(temp);
            }
            return entities;
        }

        public override double GetHeight()
        {
            return tf * num;
        }

        public override EntityList GetEntitilist()
        {
            if (list == null)
            {
                list = new EntityList();
                
            }
            var clamped1 = GetEntity();
            list.Add(clamped1);

            for (int i = 1; i < num; i++)
            {
                var temp = clamped1.Clone() as Solid;
                temp.Translate(0, 0, tf * i);
                list.Add(temp);
            }

            return list;
        }
    }

    internal interface IModelFemMesh
    {
        FemMesh GetFemMesh();
    }
}
