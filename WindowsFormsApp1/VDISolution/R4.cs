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
        public R4(R3 r3)
        {
            this.r3 = r3;
            this.ffz = ffz;
        }

        public void setFz()
        {
            FZ = ffz / (r3.deltaS + r3.deltaP);
        }
        public double table5(double R_z, double w, double fq)
        {
            double ffz = 0;
            if (R_z < 10)
            {
                if (fq == 0)
                {
                    ffz = 7;
                    if (w == 2)
                    {
                        ffz = ffz + 2.5;
                    }
                }
                else if (fq != 0)
                {
                    ffz = 8;
                    if (w == 2)
                    {
                        ffz = ffz + 3;
                    }
                }
            }
            else if (R_z >= 10 && R_z < 40)
            {
                if (fq == 0)
                {
                    ffz = 8;
                    if (w == 2)
                    {
                        ffz = ffz + 3;
                    }
                }
                else if (fq != 0)
                {
                    ffz = 10;
                    if (w == 2)
                    {
                        ffz = ffz + 4.5;
                    }
                }
            }
            else if (R_z >= 40 && R_z < 160)
            {
                if (fq == 0)
                {
                    ffz = 10;
                    if (w == 2)
                    {
                        ffz = ffz + 4;
                    }
                }
                else if (fq != 0)
                {
                    ffz = 13;
                    if (w == 2)
                    {
                        ffz = ffz + 6.5;
                    }
                }
            }
            else
            {
                return 0;
            }
            return ffz / 1000;
        }


    }
}
