using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{

    public class R11
    {
        public BoltClass bolt { get; set; }
        public double meff { get; set; }
        public double Lk { get; set; }
        public double mges_vorh { get; set; }

        public R11(BoltClass bolt, double Lk)
        {
            this.bolt = bolt;
            this.Lk = Lk;
            this.mges_vorh = mges_vorh;
        }

        public double getMeff(double rmmin, double rmkangla,  double tbm, double s)
        {
            double d_ = bolt.NormalD_d;
            double p_ = bolt.ScrewP_P;
            double d2_ = bolt.ScrewMidD_d2;
            double d1_ = bolt.BoltNutScrewMinD_D1;
            double tan30_ = Math.Tan(Math.PI * 30 / 180);
            double Rmm_Rms = rmmin / rmkangla;
            double Rs_ = Rmm_Rms * d_ * (p_ / 2 + (d_ - d1_) * tan30_) / (d1_ * (p_ / 2) + (d2_ - d1_) * tan30_);
            
            Console.WriteLine("Rs_:" + Rs_);
            Console.WriteLine("tbm_:" + tbm);

            double meff_d = 0;
            if (bolt.boltMaterial.BoltMaterialLevel == "12.9")
            {
                meff_d = f129(tbm);
            }
            else if (bolt.boltMaterial.BoltMaterialLevel == "10.9")
            {
                meff_d = f109(tbm);
            }
            else if (bolt.boltMaterial.BoltMaterialLevel == "8.8")
            {

                meff_d = f88(tbm);
            }
            Console.WriteLine("meff_d:" + tbm);

            meff = meff_d * d_;
            mges_vorh = bolt.BoltLen_ls - Lk;
            mges_vorh -= 2 * bolt.ScrewP_P;
            return meff;
        }

        private double f88(double rs_)
        {
            return 6.22 * Math.Exp(-0.01166 * rs_) + 0.8552 * Math.Exp(-0.0007668 * rs_);
        }

        private double f109(double rs_)
        {
            return 7.425 * Math.Exp(-0.01147 * rs_) + 1.273 * Math.Exp(-0.001167 * rs_);
        }

        private double f129(double rs_)
        {
            return 8.478 * Math.Exp(-0.01111 * rs_) + 1.375 * Math.Exp(-0.0009947 * rs_);
        }


    }
}
