using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;

namespace WindowsFormsApp1
{
    class HKFDJClamped : IModelEntity, IModelFemMesh
    {
        #region PropeField
        //public double A { set; get; }
        //public double B { set; get; }
        //public double C { set; get; }
        //public double d { set; get; }
        //public double n { set; get; }
        //public double tg { set; get; }
        //public double tc { set; get; }
        //public double th { set; get; }
        //public double tf { set; get; }
        //public double Ag { set; get; } // 垫片外径
        //public double Bg { set; get; } // 垫片内径
        //public double L { set; get; }
        //public double h { set; get; }

        public double outer_A { set; get; }
        public double inner_B { set; get; }
        public double C { set; get; } // 对称孔的距离
        public double d { set; get; } // 孔高度
        public double n { set; get; } // 孔个数
        public double tf { set; get; } // 连接件高度
        public Model Mode { set; get; }
        //public double ddz = 1;  // 垫片厚
        public double ddx = 1;
        // 弹性模量
        public double TanXingMoLiang { set; get; }
        #endregion  

        private const int _slice = 100;
        private const double _tol = 0.1;

        // 孔个数？
        private List<Tuple<Point3D, Point3D>> _boundingBoxOfBoltHole = new List<Tuple<Point3D, Point3D>>();
        private FemMesh _flangeFMCache; // 有限元连接件

        public Entity GetEntity()
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

        // 画图  有限元盘
        public FemMesh GetFemMesh()
        {
            // 底部
            ICurve baseCircle = new Circle(Plane.XY, outer_A / 2);
            ICurve slotCircle = new Circle(Plane.XY, inner_B / 2);
            var baseReg = new devDept.Eyeshot.Entities.Region(new List<ICurve>() { baseCircle, slotCircle });

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

                baseReg = devDept.Eyeshot.Entities.Region.Difference(baseReg, new devDept.Eyeshot.Entities.Region(boltCircle))[0];
                boltCircle.Rotate(deltAngle, Vector3D.AxisZ);
            }
            var mesh = baseReg.Triangulate(10);
            _flangeFMCache = mesh.ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            _flangeFMCache.Extrude(new Vector3D(0, 0, tf ));//  + ddz
            _flangeFMCache.FixAll(Plane.XY, 0.1);
            return _flangeFMCache;
        }

        private Solid GetFlange()
        {
            var section = new LinearPath(GetSectionPoints());
            var r = new devDept.Eyeshot.Entities.Region(section);

            var genus = r.RevolveAsSolid(0, Math.PI * 2, Vector3D.AxisZ, Point3D.Origin, _slice, _tol);
            var pl = Plane.XY;
            pl.Translate(0, 0, 0);//ddz
            var boltHole = devDept.Eyeshot.Entities.Region.CreateCircle(pl, d / 2);
            boltHole.Translate(C / 2, 0, 0);
            double deltAngle = Math.PI * 2 / n;
            for (int i = 0; i < n; i++)
            {
                boltHole.Rotate(deltAngle, Vector3D.AxisZ);
                genus.ExtrudeRemove(boltHole, tf, _tol);
            }
            return genus;
        }


        //private Point3D[] GetSectionPoints()
        //{
        //    Point3D[] p = new Point3D[10];
        //    p[0] = new Point3D(B / 2, 0, L + h + tf + ddz);
        //    p[1] = new Point3D(B / 2 + tc, 0, L + h + tf + ddz);
        //    p[2] = new Point3D(B / 2 + tc, 0, h + tf + ddz);
        //    p[3] = new Point3D(B / 2 + th, 0, tf + ddz);
        //    p[4] = new Point3D(A / 2, 0, tf + ddz);
        //    p[5] = new Point3D(A / 2, 0, ddz);
        //    p[6] = new Point3D(Ag / 2 + ddx, 0, ddz);
        //    p[7] = new Point3D(Ag / 2 + ddx, 0, 0);
        //    p[8] = new Point3D(B / 2, 0, 0);
        //    p[9] = new Point3D(B / 2, 0, L + h + tf + ddz);
        //    return p;
        //}
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
    }

    internal interface IModelFemMesh
    {

        FemMesh GetFemMesh();
    }
}
