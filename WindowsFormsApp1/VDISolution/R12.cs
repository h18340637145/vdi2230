using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R12
    {
        public double fmzul { get; set; }
        public double alpha { get; set; }
        public double phi { get; set; }
        public double fao { get; set; }
        public double fZ { get; set; }
        public double sg { get; set; }
        public double sa { get; set; }
        public BoltClass bolt { get; set; }

        public R12(BoltClass bolt, double fmzul, double alpha, double phi, double fao, double fZ)
        {
            this.bolt = bolt;
            this.fmzul = fmzul;
            this.alpha = alpha;
            this.phi = phi;
            this.fao = fao;
            this.fZ = fZ;

        }

        public double getFKRmin()
        {
            double FKRmin = fmzul / alpha - (1 - phi) * fao - fZ;
            
            return FKRmin;
        }

        internal double getSg(double f_qmax, double q_f, double u_Tmin, double m_t, double q_m)
        {
            double fkqerf =  f_qmax / q_f / u_Tmin + m_t  / q_m / u_Tmin;
            double FKRmin = getFKRmin();
            sg = FKRmin / fkqerf;
            return sg;
        }

        public double getSa( double rm, double FQmax)
        {
            double At = Math.PI * bolt.NormalD_d * bolt.NormalD_d / 4;
            double T_bs = bolt.boltMaterial.BoltMaterialRatio_fB * rm;
            sa = At * T_bs / FQmax;
            return sa;
        }
        public double getSa(double rm, double FQmax, double dt)
        {
            double At = Math.PI * dt * dt / 4;
            double T_bs = bolt.boltMaterial.BoltMaterialRatio_fB * rm;
            sa = At * T_bs / FQmax;
            return sa;
        }
    }
}
