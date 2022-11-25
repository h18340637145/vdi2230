using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R6
    {
        public double alpha { get; set; }
        public double fmmin { get; set; }
        public double Fmmax { get; set; }

        public R6(double alpha, double fmmin)
        {
            this.alpha = alpha;
            this.fmmin = fmmin;
            setFmmax();
        }

        private void setFmmax()
        {
            Fmmax = alpha * fmmin;
        }
    }
}
