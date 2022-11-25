using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R7
    {
        public R7() { }
        public R7(BoltClass bolt, double uGmin, double v)
        {
            this.bolt = bolt;
            this.Ugmin = uGmin;
            this.v = v;
            //setFmzul();
            //setF_mtb();
        }

        public double Ugmin { get; set; }
        public double v { get; set; }
        public BoltClass bolt { get; set; }

        public double getFmzul()
        {
            double d0 = (bolt.ScrewMidD_d2 + bolt.ScrewMinD_d3) / 2;
            double A0 = Math.PI * d0 * d0 / 4;
            double Rp = bolt.boltMaterial.BoltMaterialRpmin;
            double Pp = (bolt.ScrewP_P);
            double d2 = (bolt.ScrewMidD_d2);
            double d2_3_2d0 = 3 * d2 / (2 * d0);
            double p_pid_2 = Pp / Math.PI / d2;
            double square = (d2_3_2d0 * (p_pid_2 + 1.155 * Ugmin)) * (d2_3_2d0 * (p_pid_2 + 1.155 * Ugmin));
            Console.WriteLine("A0:" + A0.ToString());
            Console.WriteLine("square:" + square.ToString());
            double Fmzul = A0 * v * Rp / Math.Sqrt(1 + 3 * square);
            return Fmzul;
        }

        //public double Fmzul { get; set; }
        //public double f_mtb { get; set; }

        public double getF_mtb()
        {
            return 1000 * table1();
        }

        private double table1()
        {
            int d = Convert.ToInt32(bolt.NormalD_d);
            string level = bolt.boltMaterial.BoltMaterialLevel;
            double u_G = Ugmin;

            int level_index = 0;
            int ug_index = 0;
            if (u_G == 0.08)
            {
                ug_index = 0;
            }
            else if (u_G == 0.1)
            {
                ug_index = 1;
            }
            else if (u_G == 0.12)
            {
                ug_index = 2;
            }
            else if (u_G == 0.14)
            {
                ug_index = 3;
            }
            else if (u_G == 0.16)
            {
                ug_index = 4;
            }
            else if (u_G == 0.2)
            {
                ug_index = 5;
            }
            else if (u_G == 0.24)
            {
                ug_index = 6;
            }

            if (level == "8.8")
            {
                level_index = 0;
            }
            else if (level == "10.9")
            {
                level_index = 1;
            }
            else if (level == "12.9")
            {
                level_index = 2;
            }

            double Ftb = 0;
            switch (d)
            {
                case 4:
                    double[,] arr4 = new double[3, 7] {
                        { 4.6, 4.5, 4.4, 4.3, 4.2, 3.9, 3.7 },
                        { 6.8, 6.7, 6.5, 6.3, 6.1, 5.7, 5.4 },
                        { 8,   7.8, 7.6, 7.4, 7.1, 6.7, 6.3}
                    };
                    Ftb = arr4[level_index, ug_index];
                    break;
                case 5:
                    double[,] arr5 = new double[3, 7] {
                        { 7.6, 7.4, 7.2, 7.0, 6.8, 6.4, 6 },
                        { 11.1,10.8,10.6,10.3,10.0,9.4, 8.8 },
                        { 13,  12.7,12.4,12.0,11.7,11.0,10.3}
                    };
                    Ftb = arr5[level_index, ug_index];
                    break;
                case 6:
                    double[,] arr6 = new double[3, 7] {
                        { 10.7, 10.4, 10.2, 9.9, 9.6, 9.0, 8.4 },
                        { 15.7, 15.3, 14.9, 14.5,14.1,13.2,12.4 },
                        { 18.4, 17.9, 17.5, 17.0,16.5, 15.5, 14.5}
                    };
                    Ftb = arr6[level_index, ug_index];
                    break;
                case 7:
                    double[,] arr7 = new double[3, 7] {
                        { 15.5, 15.1, 14.8, 14.4, 14.0, 13.1, 12.3 },
                        { 22.7, 22.5, 21.7, 21.1, 20.5, 19.3, 18.1 },
                        { 26.6, 26.0, 25.4, 24.7, 24.0, 22.6, 21.2}
                    };
                    Ftb = arr7[level_index, ug_index];
                    break;
                case 8:
                    double[,] arr8 = new double[3, 7] {
                        { 19.5, 19.1, 18.6, 18.1, 17.6, 16.5, 15.5 },
                        { 28.7, 28.0, 27.3, 26.6, 25.8, 24.3, 22.7 },
                        { 33.6, 32.8, 32.0, 31.1, 30.2, 28.4, 26.6}
                    };
                    Ftb = arr8[level_index, ug_index];
                    break;
                case 10:
                    double[,] arr10 = new double[3, 7] {
                        { 31.0, 30.3, 29.6, 28.8, 27.9, 26.3, 24.7 },
                        { 45.6, 44.5, 43.4, 42.2, 41.0, 38.6, 36.2 },
                        { 53.3, 52.1, 50.8, 49.4, 48.0, 45.2, 42.4}
                    };
                    Ftb = arr10[level_index, ug_index];
                    break;
                case 12:
                    double[,] arr12 = new double[3, 7] {
                        { 45.2, 44.1, 43.0, 41.9, 40.7, 38.3, 35.9 },
                        { 66.3, 64.8, 63.2, 61.5, 59.8, 56.3, 52.8 },
                        { 77.6, 75.9, 74.0, 72.0, 70.0, 65.8, 61.8}
                    };
                    Ftb = arr12[level_index, ug_index];
                    break;
                case 14:
                    double[,] arr14 = new double[3, 7] {
                        { 62.0, 60.6, 59.1, 57.5, 55.9, 52.6, 49.3 },
                        { 91.0, 88.9 ,86.7, 84.4, 82.1, 77.2, 72.5 },
                        { 106.5,104.1,101.5,98.8, 96.0, 90.4, 84.8}
                    };
                    Ftb = arr14[level_index, ug_index];
                    break;
                case 16:
                    double[,] arr16 = new double[3, 7] {
                        { 62.0, 60.6, 59.1, 57.5, 55.9, 52.6, 49.3 },
                        { 91.0, 88.9 ,86.7, 84.4, 82.1, 77.2, 72.5 },
                        { 106.5,104.1,101.5,98.8, 96.0, 90.4, 84.8}
                    };
                    Ftb = arr16[level_index, ug_index];
                    break;
                case 18:
                    double[,] arr18 = new double[3, 7] {
                        { 107, 104, 102, 99, 96, 91, 85 },
                        { 152, 149, 145, 141, 137, 129, 121},
                        { 178, 174, 170, 165, 160, 151 , 142}
                    };
                    Ftb = arr18[level_index, ug_index];
                    break;
                case 20:
                    double[,] arr20 = new double[3, 7] {
                        { 136, 134, 130, 127, 123, 116, 109 },
                        { 194, 190, 186, 181, 176, 166, 156},
                        { 227, 223, 217, 212, 206, 194, 182}
                    };
                    Ftb = arr20[level_index, ug_index];
                    break;
                case 22:
                    double[,] arr22 = new double[3, 7] {
                        { 170, 166, 162, 158, 154, 145, 137 },
                        { 242, 237, 231, 225, 219, 207, 194},
                        { 283, 277, 271, 264, 257, 242, 228}
                    };
                    Ftb = arr22[level_index, ug_index];
                    break;
                case 24:
                    double[,] arr24 = new double[3, 7] {
                        { 196, 192, 188, 183, 178 ,168, 157},
                        { 280, 274, 267, 260, 253, 239, 224},
                        { 327, 320 , 313 ,305, 296 ,279, 262}
                    };
                    Ftb = arr24[level_index, ug_index];
                    break;
                case 27:
                    double[,] arr27 = new double[3, 7] {
                        { 257, 252, 246, 240 ,234, 220, 207},
                        { 367, 359, 351, 342, 333 ,314, 295},
                        { 429, 420 ,410 ,400 ,389 ,367, 345}
                    };
                    Ftb = arr27[level_index, ug_index];
                    break;
                case 30:
                    double[,] arr30 = new double[3, 7] {
                        { 313, 307, 300, 292, 284 ,268,252},
                        { 446, 437, 427, 416, 405, 382 ,359},
                        { 522, 511 ,499, 487 ,474 ,447 ,420}
                    };
                    Ftb = arr30[level_index, ug_index];
                    break;
                case 33:
                    double[,] arr33 = new double[3, 7] {
                        { 389, 381, 373 ,363 ,354 ,334 ,314},
                        { 554 ,543 ,531 ,517 ,504 ,475 ,447},
                        { 649 ,635 ,621 ,605 ,589 ,556 ,523}
                    };
                    Ftb = arr33[level_index, ug_index];
                    break;
                case 36:
                    double[,] arr36 = new double[3, 7] {
                        { 458, 448 ,438 ,427 ,415 ,392 ,368},
                        { 652 ,638, 623 ,608 ,591 ,558 ,524},
                        { 763 ,747 ,729 ,711 ,692 ,653, 614}
                    };
                    Ftb = arr36[level_index, ug_index];
                    break;
                case 39:
                    double[,] arr39 = new double[3, 7] {
                        { 548, 537, 525 ,512 ,498 ,470 ,443},
                        { 781 ,765 ,748 ,729 ,710 ,670 ,630},
                        { 914 ,895 ,875 ,853 ,831 ,784 ,738}
                    };
                    Ftb = arr39[level_index, ug_index];
                    break;
            }
            return Ftb;
        }

    }
}
