using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R4
    {
        public double FZ { set; get; }
        public double ffz { set; get; }
        public R3 r3 { set; get; }
        public R4(R3 r3, double ffz)
        {
            this.r3 = r3;
            this.ffz = ffz;
            setFz();
        }

        private void setFz()
        {
            FZ = ffz / (r3.deltaS + r3.deltaP);
        }
    }
}
