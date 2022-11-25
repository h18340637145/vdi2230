using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R13
    {
        public BoltClass bolt { get; set; }
        public R13(BoltClass bolt)
        {
            this.bolt = bolt;
        }

        public double getMA(double da, double ukmin, double ugmin, double fmzul)
        {
            double dkm = (Math.Max(bolt.BoreD_dh, da) + bolt.BoltHeadOutD_dw) / 2;
            double MA = fmzul * (0.16 * bolt.ScrewP_P + 0.58 * bolt.ScrewMidD_d2 * ugmin + dkm / 2 * ukmin);
            return MA;
        }
    }
}
