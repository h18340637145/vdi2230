using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R13
    {
        public double da { get; set; }
        public double ukmin { get; set; }
        public double ugmin { get; set; }
        public double fmzul { get; set; }
        public BoltClass bolt { get; set; }

        public R13(BoltClass bolt, double da, double ukmin, double ugmin, double fmzul)
        {
            this.bolt = bolt;
            this.da = da;
            this.ukmin = ukmin;
            this.ugmin = ugmin;
            this.fmzul = fmzul;
        }

        public R13()
        {
        }

        public double getMA()
        {
            double dkm = (Math.Max(bolt.BoreD_dh, da) + bolt.BoltHeadOutD_dw) / 2;
            return fmzul * (0.16 * bolt.ScrewP_P + 0.58 * bolt.ScrewMidD_d2 * ugmin + dkm / 2 * ukmin);
        }
    }
}
