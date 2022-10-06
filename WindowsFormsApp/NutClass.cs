using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class NutClass : IModelEntity
    {
        // 螺母数据
        //private string nutSpeci; // 规格
        //private string nutStd; // 标准
        //private double nutNutSideWid;// 对边宽度
        //private double nutBearMinD; // 承载面最小内径
        //private double nutBearMaxD; // 承载面最大内径
        //private double nutBearOutD; // 承载面外径
        //private double nutHeight; // 高度

        public string NutSpeci { get; set; }
        public string NutStd { get; set; }
        public double NutNutSideWid { get; set; }
        public double NutBearMinD { get; set; }
        public double NutBearMaxD { get; set; }
        public double NutBearOutD { get; set; }
        public double NutHeight { get; set; }

        // 画图在z轴上的偏移
        public double Offsetz { get; set; }



        private const int _slice = 100;
        private const double _tol = .1;

        public Entity GetEntity()
        {
            return GetNut(1);
        }

        private Entity GetNut(int type)
        {
            var nut = NutModel(type);

            return nut;
        }

        private Solid NutModel(int type)
        {
            // 常规光滑
            Point3D[] points = GetLuoMaoPoints();
            var r = devDept.Eyeshot.Entities.Region.CreatePolygon(points);
            var luoMao = r.ExtrudeAsSolid(0, 0, NutHeight, _tol);
            var cyc = Solid.CreateCylinder(NutBearMinD / 2, NutHeight, _slice);
            var nut = Solid.Difference(luoMao, cyc);
            return nut[0];
        }

        /// <summary>
        /// 计算螺帽正六边形的7个顶点（封闭）
        /// </summary>
        /// <returns></returns>
        private Point3D[] GetLuoMaoPoints()
        {
            Point3D[] points = new Point3D[6];
            double s = NutNutSideWid;
            double e = s * 1.155;
            points[0] = new Point3D(0, e / 2, Offsetz);
            points[1] = new Point3D(s / 2, e / 2 - s / 2 * Math.Tan(Math.PI / 6), Offsetz);
            points[2] = new Point3D(s / 2, -(e / 2 - s / 2 * Math.Tan(Math.PI / 6)), Offsetz);
            points[3] = new Point3D(0, -e / 2, Offsetz);
            points[4] = new Point3D(-s / 2, -(e / 2 - s / 2 * Math.Tan(Math.PI / 6)), Offsetz);
            points[5] = new Point3D(-s / 2, e / 2 - s / 2 * Math.Tan(Math.PI / 6), Offsetz);
            return points;
        }
    }
}
