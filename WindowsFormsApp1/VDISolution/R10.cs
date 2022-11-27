using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R10
    {
        public BoltClass bolt { get; set; }
        public double fmzul { get; set; }
        public double pG { get; set; }
        public double alpha { get; set; }
        public double FZ { get; set; }
        public double f_sa_max { get; set; } // fao

        //// 装配
        //public double sp { get; set; } // 螺栓
        //public double sp_load { get; set; } // 螺栓

        //// 工作
        //public double spn { get; set; } // 螺母
        //public double spn_load { get; set; } // 螺母

        public R10(BoltClass bolt, double fmzul, double pG, double alpha, double FZ, double f_sa_max)
        {
            this.bolt = bolt;
            this.fmzul = fmzul;
            this.pG = pG;
            this.alpha = alpha;
            this.FZ = FZ;
            this.f_sa_max = f_sa_max;
        }

        public R10()
        {
        }

        public double getSp(double hs, NutClass nut)
        {
            double outR = bolt.BoltHeadOutD_dw + 1.6 * hs;
            double innerR = Math.Max(bolt.BoreD_dh, nut.NutBearMinD);
            double Apmmin = Math.PI * (outR * outR - innerR * innerR) / 4;
            double pMMumax = fmzul / Apmmin;
            double Apkmin = Math.PI * (bolt.BoltHeadOutD_dw * bolt.BoltHeadOutD_dw - bolt.BoreD_dh * bolt.BoreD_dh) / 4;
            double pMKmax = fmzul / Apkmin;
            return pG / pMKmax;
        }

        public double getSpn(double hs, NutClass nut)
        {
            double outR = bolt.BoltHeadOutD_dw + 1.6 * hs;
            double innerR = Math.Max(bolt.BoreD_dh, nut.NutBearMinD);
            double Apmmin = Math.PI * (outR * outR - innerR * innerR) / 4;
            double pMMumax = fmzul / Apmmin;
            double Apkmin = Math.PI * (bolt.BoltHeadOutD_dw * bolt.BoltHeadOutD_dw - bolt.BoreD_dh * bolt.BoreD_dh) / 4;
            double pMKmax = fmzul / Apkmin;
            return  pG / pMMumax;
        }

        public double getSp_load(double hs, NutClass nut)
        {
            double outR = bolt.BoltHeadOutD_dw + 1.6 * hs;
            double innerR = Math.Max(bolt.BoreD_dh, nut.NutBearMinD);
            double Apmmin = Math.PI * (outR * outR - innerR * innerR) / 4;
            double pMMumax = fmzul / Apmmin;
            double Apkmin = Math.PI * (bolt.BoltHeadOutD_dw * bolt.BoltHeadOutD_dw - bolt.BoreD_dh * bolt.BoreD_dh) / 4;
            double pMKmax = fmzul / Apkmin;

            double Fv = fmzul / alpha - FZ;
            if (f_sa_max <= 0)
            {
                f_sa_max = 0;
            }
            // bolt
            double pKBmax = (Fv + f_sa_max) / Apkmin;
            // 螺母
            double pMmmax = (Fv + f_sa_max) / Apmmin;
            Console.WriteLine("f_samax:" + f_sa_max);
            double res = pG / pMKmax;
            return res;
        }

        public double getSpn_load(double hs, NutClass nut)
        {
            double outR = bolt.BoltHeadOutD_dw + 1.6 * hs;
            double innerR = Math.Max(bolt.BoreD_dh, nut.NutBearMinD);
            double Apmmin = Math.PI * (outR * outR - innerR * innerR) / 4;
            double pMMumax = fmzul / Apmmin;
            double Apkmin = Math.PI * (bolt.BoltHeadOutD_dw * bolt.BoltHeadOutD_dw - bolt.BoreD_dh * bolt.BoreD_dh) / 4;
            double pMKmax = fmzul / Apkmin;

            double Fv = fmzul / alpha - FZ;
            if (f_sa_max <= 0)
            {
                f_sa_max = 0;
            }
            // bolt
            double pKBmax = (Fv + f_sa_max) / Apkmin;
            // 螺母
            double pMmmax = (Fv + f_sa_max) / Apmmin;

            return pG / pMmmax;
        }

        // no nut
        public double getSp_nonut()
        {
            // 装配
            double dh = bolt.BoreD_dh;
            double dw = bolt.BoltHeadOutD_dw;
            double Apkmin = Math.PI * (dw * dw - dh * dh) / 4;
            double pMKmax = fmzul / Apkmin;

            return pG / pMKmax;
        }

        public double getSp_load_nonut()
        {
            // 装配
            double dh = bolt.BoreD_dh;
            double dw = bolt.BoltHeadOutD_dw;
            double Apkmin = Math.PI * (dw * dw - dh * dh) / 4;
            double pMKmax = fmzul / Apkmin;

            // 工作
            double Fv = fmzul / alpha - FZ;
            if (f_sa_max <= 0)
            {
                f_sa_max = 0;
            }

            // bolt
            double pKBmax = (Fv + f_sa_max) / Apkmin;
            Console.WriteLine("螺栓承载面面积:" + Apkmin.ToString());
            Console.WriteLine("装配:");
            Console.WriteLine("螺栓头pMKmax:" + pMKmax.ToString());
            Console.WriteLine("工作:");
            Console.WriteLine("螺栓头pKBmax:" + pKBmax.ToString());
            return pG / pKBmax;
        }
    }
}
