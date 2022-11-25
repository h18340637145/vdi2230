using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R8
    {
        public BoltClass bolt { get; set; }
        public double Fmzul { get; set; }
        public double fao { get; set; }
        public double phi { get; set; }
        public double ugmin { get; set; }
        public double sf { get; set; }
        public double FSmax { get; set; }

        public R8(BoltClass bolt, double Fmzul, double fao, double phi, double ugmin)
        {
            this.bolt = bolt;
            this.Fmzul = Fmzul;
            this.fao = fao;
            this.phi = phi;
            this.ugmin = ugmin;
            setSf();
        }

        public void setSf()
        {
            double deltaFv = 0;
            double Pp = (bolt.ScrewP_P);
            double d2 = (bolt.ScrewMidD_d2);
            double d0 = (bolt.ScrewMidD_d2 + bolt.ScrewMinD_d3) / 2;
            double A0 = Math.PI * d0 * d0 / 4;

            FSmax = Fmzul + phi * fao + deltaFv;
            double delta_z_max = FSmax / A0;
            double kt = 0.5;
            double M_G = Fmzul * d2 * ((Pp / Math.PI / d2) + 1.155 * ugmin) / 2;
            double W_P = ((Math.PI * Math.Pow(d0, 3) / 16));
            double tmax = M_G / W_P;
            double delta_Red_B = Math.Sqrt(Math.Pow(delta_z_max, 2) + 3 * Math.Pow((kt * tmax), 2));
            sf = bolt.boltMaterial.BoltMaterialRpmin / delta_Red_B;
            Console.WriteLine("FSmax:" + FSmax.ToString());
            Console.WriteLine("M_G:" + M_G.ToString());
            Console.WriteLine("delta_z_max:" + delta_z_max.ToString());
            Console.WriteLine("W_P:" + W_P.ToString());
            Console.WriteLine("tmax:" + tmax.ToString());
            Console.WriteLine("delta_Red_B:" + delta_Red_B.ToString());
        }
    }
}
