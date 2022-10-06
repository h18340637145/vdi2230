using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devDept.Eyeshot.Entities;

namespace WindowsFormsApp1
{
    public class GasketClass : IModelEntity
    {
        // 垫片数据
        //private string gasketstd;
        //private double gasketinnerD_dhas;
        //private double gasketoutD_DA;
        //private double boltheaddowngasketheight_hs1;
        //private double nutdowngasketheight_hs2;

        public string Gasketstd { get; set; }
        public double GasketinnerD_dhas { get; set; } // 内径
        public double GasketoutD_DA { get; set; } // 外径
        public double Boltheaddowngasketheight_hs1 { get; set; } // 头垫圈厚度
        public double Nutdowngasketheight_hs2 { get; set; } // 螺母垫圈厚度

        public double offsetz { get; set; }

        private const int _slice = 100;
        private const double _tol = .1;

        public GasketClass()
        {

        }

        public GasketClass(GasketClass gasketClass)
        {
            this.Gasketstd = gasketClass.Gasketstd;
            this.GasketinnerD_dhas = gasketClass.GasketinnerD_dhas;
            this.GasketoutD_DA = gasketClass.GasketoutD_DA;
            this.Boltheaddowngasketheight_hs1 = gasketClass.Boltheaddowngasketheight_hs1;
            this.Nutdowngasketheight_hs2 = gasketClass.Nutdowngasketheight_hs2;
        }

        public Entity GetEntity()
        {
            return GetGasket(1);
        }

        private Entity GetGasket(int v)
        {
            var cyc = Solid.CreateCylinder(GasketoutD_DA / 2, Nutdowngasketheight_hs2, _slice);

            var empty = Solid.CreateCylinder(GasketinnerD_dhas / 2, Nutdowngasketheight_hs2, _slice);

            var gasket = Solid.Difference(cyc, empty);
            var res = gasket[0];
            res.Translate(0, 0, offsetz);
            return res;
        }
    }
}
