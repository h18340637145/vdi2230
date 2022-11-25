using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R9
    {
        //public string zhazhi { get; set; }
        public double zhouqiN { get; set; }

        public double deltaASV { get; set; }
        public double deltaASG { get; set; }

        public double f_sa { get; set; }
        public double fsm { get; set; }

        public double delta { get; set; }
        public double deltaAZSV { get; set; }
        public double deltaAZSG { get; set; }

        public double sd { get; set; }

        public double delta_sabo { get; set; }
        public double delta_sabu { get; set; }
        public double delta_ab { get; set; }

        public double l_ers { get; set; }
        
        
        public BoltClass bolt { get; set; }
        public double a { get; set; }
        public double ssym { get; set; }
        public double phi { get; set; }
        public double fmzul { get; set; }
        public double rpmin { get; set; }
        public double fau { get; set; }
        public double fao { get; set; }
        public double As { get; set; }


        const double ND = 2000000;
        const double one_three = 1.0 / 3.0;
        const double one_six = 1.0 / 6.0;

        // famax = fao
        public R9(BoltClass bolt, double a, double ssym, double phi, double fmzul, double rpmin, double famax, double famin = 0)
        {
            this.bolt = bolt;
            this.ssym = ssym;
            this.fmzul = fmzul;
            this.rpmin = rpmin;
            this.fao = famax;
            this.fau = famin;
            this.a = a;

            As = Math.PI * ((bolt.ScrewMidD_d2 + bolt.ScrewMinD_d3) / 2) * ((bolt.ScrewMidD_d2 + bolt.ScrewMinD_d3) / 2) / 4;
            delta = phi * (famax - famin) / 2 / As;
            deltaASV = 0.85 * (150 / bolt.NormalD_d + 45);
            f_sa = phi * famax;
            fsm = f_sa / 2 + fmzul;
            deltaASG = (2 - fsm / As / rpmin) * deltaASV;
        }


        public double getSd(string zhazhi)
        {
            // 同心调用 
            if (zhouqiN != 0)
            {
                if (zhouqiN >= 2000000)
                {
                    if (zhazhi == "热处理前轧制" || zhazhi == "")
                    {
                        sd = deltaASV / delta;
                    }
                    else if (zhazhi == "热处理后轧制")
                    {
                        sd = deltaASG / delta;
                    }
                }
                else
                {
                    if (zhazhi == "热处理前轧制" || zhazhi == "")
                    {
                        deltaAZSV = deltaASV * Math.Pow(ND / zhouqiN, one_three);
                        sd = deltaAZSV / delta;
                        Console.WriteLine("deltaASV:" + deltaASV.ToString());
                        Console.WriteLine("Math.Pow(ND / NZ, 1 / 3):" + Math.Pow(ND / zhouqiN, one_three).ToString());
                        Console.WriteLine("deltaAZSV:" + deltaAZSV.ToString());
                        Console.WriteLine("sd:" + sd.ToString());
                    }
                    else if (zhazhi == "热处理后轧制")
                    {
                        deltaAZSG = deltaASG * Math.Pow(ND / zhouqiN, one_six);
                        sd = deltaAZSG / delta;
                        Console.WriteLine("deltaASV:" + deltaASV.ToString());
                        Console.WriteLine("f_sa:" + f_sa.ToString());
                        Console.WriteLine("fsm:" + fsm.ToString());
                        Console.WriteLine("deltaASG:" + deltaASG.ToString());
                        Console.WriteLine("deltaAZSG:" + deltaAZSG.ToString());
                        Console.WriteLine("sd:" + sd.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("同心-不存在nz");
                if (zhazhi == "热处理前轧制" || zhazhi == "")
                {
                    sd = deltaASV / delta;
                    Console.WriteLine("deltaASV:" + deltaASV.ToString());
                    Console.WriteLine("delta:" + delta.ToString());
                    Console.WriteLine("sd:" + sd.ToString());
                }
                else if (zhazhi == "热处理后轧制")
                {
                    sd = deltaASG / delta;
                    Console.WriteLine("f_sa:" + f_sa.ToString());
                    Console.WriteLine("fsm:" + fsm.ToString());
                    Console.WriteLine("deltaASG:" + deltaASG.ToString());
                    Console.WriteLine("sd:" + sd.ToString());
                }
            }
            return sd;
        }

        public double getSd(string zhazhi,double phi, double mb, double Lk, double es, double ep, double d0, double I_bers)
        {
            // 偏心用
            if (mb == 0)
            {
                double f_sa_max = phi * fau;
                double f_sa_min = phi * fao;

                delta_sabo = f_sa_max / As;
                delta_sabu = f_sa_min / As;
                delta_ab = (delta_sabo - delta_sabu) / 2;
                fsm = (f_sa_max + f_sa_min) / 2 + fmzul;

                Console.WriteLine("f_sa_max:" + f_sa_max.ToString());
                Console.WriteLine("f_sa_min:" + f_sa_min.ToString());
                Console.WriteLine("delta_sabo:" + delta_sabo.ToString());
                Console.WriteLine("delta_sabu:" + delta_sabu.ToString());
                Console.WriteLine("delta_ab:" + delta_ab.ToString());
                Console.WriteLine("f_sm:" + fsm.ToString());
                if (zhazhi == "热处理前轧制" || zhazhi == "")
                {
                    deltaASV = 0.85 * (150 / bolt.NormalD_d + 45);
                    sd = deltaASV / delta_ab;

                    Console.WriteLine("deltaASV:" + deltaASV.ToString());
                    Console.WriteLine("sd:" + sd.ToString());
                }
                else if (zhazhi == "热处理后轧制")
                {
                    deltaASV = 0.85 * (150 / bolt.NormalD_d + 45);
                    deltaASG = (2 - fsm / rpmin / As) * deltaASV;
                    sd = deltaASG / delta_ab;
                    Console.WriteLine("deltaASG:" + deltaASG.ToString());
                    Console.WriteLine("sd:" + sd.ToString());
                }
            }
            else
            {
                // mb != 0
                double delta_sabo = 0; // max
                double delta_sabu = 0; // min
                if (a == 0)
                {
                    delta_sabo = phi * fao / As;
                    delta_sabu = phi * fau  / As;
                }
                else
                {
                    //a != 0
                    double l_ers = compute_lers(Lk);
                    double up = Lk * es * Math.PI * a * Math.Pow(d0, 3);
                    double down = (l_ers * ep * 8 *I_bers);
                    double x = up / down;
                    double param = (1 + (1 / phi - ssym / a) * x);
                    delta_sabo = param * phi * fao / As;
                    double famin = fau;
                        
                    delta_sabu = param * phi * famin / As;
                }

                double delta_ab = (delta_sabo - delta_sabu) / 2;
                double f_sm = (fau + fao) * phi / 2 + fmzul;

                Console.WriteLine("delta_sabo:" + delta_sabo.ToString());
                Console.WriteLine("delta_sabu:" + delta_sabu.ToString());
                Console.WriteLine("delta_ab:" + delta_ab.ToString());
                Console.WriteLine("f_sm:" + f_sm.ToString());
                if (zhazhi == "热处理前轧制" || zhazhi == "")
                {
                    deltaASV = 0.85 * (150 / bolt.NormalD_d + 45);
                    sd = deltaASV / delta_ab;

                    Console.WriteLine("deltaASV:" + deltaASV.ToString());
                    Console.WriteLine("sd:" + sd.ToString());
                }
                else if (zhazhi == "热处理后轧制")
                {
                    deltaASV = 0.85 * (150 / bolt.NormalD_d + 45);
                    deltaASG = (2 - f_sm / rpmin / As) * deltaASV;
                    sd = deltaASG / delta_ab;
                    Console.WriteLine("deltaASG:" + deltaASG.ToString());
                    Console.WriteLine("sd:" + sd.ToString());
                }
            }
                
            return sd;
        }
        private double compute_lers(double lk)
        {
            double d_3 = bolt.ScrewMinD_d3;
            double d = bolt.NormalD_d;
            double d_T = d;
            double l1 = bolt.PolishRodLen_l1;
            double l2 = bolt.PolishRodLen_l2;
            double lGew = lk - bolt.PolishRodLen_l1 - bolt.PolishRodLen_l2;

            double lers = Math.Pow(d, 4) * 
                (
                0.5 / Math.Pow(d, 3) + 
                l1 / Math.Pow(d_T, 4) +
                lGew / Math.Pow(d_3, 4) + 
                0.4 / Math.Pow(d, 3)
                );
            return lers;
        }
    }
}
