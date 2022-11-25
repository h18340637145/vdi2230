using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R5
    {
        public double f_kerf { set; get; }
        public double phi { set; get; }
        public double fao { set; get; }
        public double fZ { set; get; }
        //public double Fmmin { set; get; }
        public R5()
        { }
        public R5(double f_kerf, double phi, double fao, double fZ)
        {
            this.f_kerf = f_kerf;
            this.phi = phi;
            this.fao = fao;
            this.fZ = fZ;
        }

        public double getFmmin()
        {
            return  f_kerf + (1 - phi) * fao + fZ;
        }
    }
}
