using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VDISolution
{
    public class R3
    {
        public R3(BoltClass bolt, R2 r2)
        {
            this.bolt = bolt;
            this.r2 = r2;
        }

        public BoltClass bolt { get; set; }
        public R2 r2 { get; set; }
        public double Nn { set; get; }
        public double phi { set; get; }

        // 几何参数
        public double G { set; get; }
        public double lM { set; get; }
        public double lGew { set; get; }
        public double lsk { set; get; }

        public double I3 { set; get; }
        public double In { set; get; }

        public double Ad3 { set; get; }
        public double AN { set; get; }
        public double I_bers { set; get; }

        // deltas
        public double deltaS { set; get; }
        public double deltaM { set; get; }
        public double deltaG { set; get; }
        public double deltaGM { set; get; }
        public double deltaGew { set; get; }
        public double deltaS1 { set; get; }
        public double deltaS2 { set; get; }
        public double deltaSK { set; get; }

        // deltap
        public double deltaP { set; get; }
        public double deltaPzu { set; get; }
        public double deltaP_star { set; get; }
        public double deltaP_star_star { set; get; }

        // beltaS
        public double betaGEW { set; get; }
        public double beta1 { set; get; }
        public double beta2 { set; get; }
        public double betaSK { set; get; }
        public double betaG { set; get; }
        public double betaM { set; get; }
        public double betaGM { set; get; }
        public double betaS { set; get; }
        public double phi_m_star { set; get; }

        public void setN(string nText)
        {
            Nn = Convert.ToDouble(nText);
        }

        public double getN(string SV, string la, string ak, double H)
        {
            double LA = Convert.ToDouble(la);
            double Ak = Convert.ToDouble(ak);
            #region 计算n表格
            // Nn表格
            if (LA / H >= 0 && LA / H < 0.1)
            {
                if (Ak / H >= 0 && Ak / H < 0.1)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.7f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.57f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.44f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.42f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.30f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.15f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.1 && Ak / H < 0.3)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.55f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.46f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.37f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.34f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.25f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.14f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.3 && Ak / H < 0.5)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.3f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.3f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.26f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.25f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.22f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.14f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.5)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.13f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.13f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.12f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.12f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.1f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.07f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

            }
            else if (LA / H >= 0.1 && LA / H < 0.2)
            {
                if (Ak / H >= 0 && Ak / H < 0.1)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.52f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.44f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.35f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.33f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.24f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.13f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.1 && Ak / H < 0.3)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.41f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.36f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.30f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.27f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.21f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.12f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.3 && Ak / H < 0.5)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.22f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.21f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.20f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.15f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.1f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.5)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.1f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.1f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.09f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.08f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.07f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.06f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

            }
            else if (LA / H >= 0.2 && LA / H < 0.3)
            {
                if (Ak / H >= 0 && Ak / H < 0.1)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.34f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.3f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.26f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.23f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.19f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.11f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.1 && Ak / H < 0.3)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.28f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.25f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.23f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.19f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.17f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.11f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.3 && Ak / H < 0.5)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.15f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.12f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.12f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.09f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.5)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.14f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.14f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.10f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

            }
            else if (LA / H >= 0.3)
            {
                if (Ak / H >= 0 && Ak / H < 0.1)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.16f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.14f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.14f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.1f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.1 && Ak / H < 0.3)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.14f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.14f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.14f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.13f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.13f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.1f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.3 && Ak / H < 0.5)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.12f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.12f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.12f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.1f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.1f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.08f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }

                if (Ak / H >= 0.5)
                {
                    if (SV == "sv1")
                    {
                        Nn = 0.04f;
                    }
                    else if (SV == "sv2")
                    {
                        Nn = 0.04f;
                    }
                    else if (SV == "sv3")
                    {
                        Nn = 0.04f;
                    }
                    else if (SV == "sv4")
                    {
                        Nn = 0.03f;
                    }
                    else if (SV == "sv5")
                    {
                        Nn = 0.03f;
                    }
                    else if (SV == "sv6")
                    {
                        Nn = 0.03f;
                    }
                    else
                    {
                        Nn = 0;
                    }
                }
            }
            else
            {
                Nn = 0;
            }
            #endregion

            return Nn;
        }

        public void setLm()
        {
            int w = r2.w;
            if (w == 1)
            {
                // s
                lM = 0.4 * bolt.NormalD_d;
            }
            else
            {
                // w
                lM = 0.33 * bolt.NormalD_d;
            }
        }
        
        #region deltas_betas
        internal void setDeltaM(string es)
        {
            deltaM = lM / Convert.ToDouble(es) / AN;
            deltaPzu = (r2.w - 1) * deltaM;
        }
        internal void setDeltaG(string es)
        {
            deltaG = 0.5*bolt.NormalD_d / Convert.ToDouble(es) / Ad3;
        }

        internal void setDeltaGM(string es)
        {
            setDeltaG(es);
            setDeltaM(es);
            deltaGM = deltaG + deltaM;
        }

        internal void setDeltaS(string es)
        {
            setDeltaGM(es);
            lGew = r2.Lk - bolt.PolishRodLen_l1 - bolt.PolishRodLen_l2;
            deltaGew = lGew / double.Parse(es) / Ad3;
            if (lGew <= 0)
            {
                deltaGew = 0;
            }
            deltaS1 = bolt.PolishRodLen_l1 / double.Parse(es) / AN;
            deltaS2 = bolt.PolishRodLen_l2 / double.Parse(es) / AN;
            lsk = 0.5 * bolt.NormalD_d;
            deltaSK = lsk / double.Parse(es) / AN;
            deltaS = deltaSK + deltaS1 + deltaS2 + deltaGew + deltaGM;
        }

        internal void setBetaS(string es)
        {
            if (r2.s_sym == 0)
            {
                betaS = 0;
            }
            else
            {
                setBetaGM(es);
                betaGEW = lGew / Convert.ToDouble(es) / I3;
                if (lGew <= 0)
                {
                    betaGEW = 0;
                }
                beta1 = bolt.PolishRodLen_l1 / Convert.ToDouble(es) / In;
                beta2 = bolt.PolishRodLen_l2 / Convert.ToDouble(es) / In;
                betaSK = lsk / Convert.ToDouble(es) / In;
                betaS = betaGM + beta1 + beta2 + betaSK + betaGEW;
            }
        }

        private void setBetaGM(string es)
        {
            setBetaG(es);
            setBetaM(es);
            betaGM = betaG + betaM;
        }

        private void setBetaM(string es)
        {
            In = (Math.PI * Math.Pow(bolt.NormalD_d, 4) / 64);
            betaM = lM / Convert.ToDouble(es) / In;
        }

        private void setBetaG(string es)
        {
            I3 = (Math.PI * Math.Pow(bolt.ScrewMinD_d3, 4) / 64);
            betaG = 0.5 * (bolt.NormalD_d) / Convert.ToDouble(es) / I3;
        }
        #endregion

        #region deltap
        public void setDeltaP(string ep)
        {

            if (r2.D_A >= r2.DAGr)
            {
                double dw = bolt.BoltHeadOutD_dw;
                double dh = bolt.BoreD_dh;
                double w = r2.w;
                double TanPhi = r2.tanPhi_D;
                double Lk = r2.Lk;
                double Ep = Convert.ToDouble(ep);
                double pi = Math.PI;
                deltaP = 2 * Math.Log(((dw + dh) * (dw + w * Lk * TanPhi - dh)) / ((dw - dh) * (dw + w * Lk * TanPhi + dh))) / (w * Ep * pi * dh * TanPhi);
                //Console.WriteLine("dw:" + dw);
                //Console.WriteLine("dh:" + dh);
                //Console.WriteLine("Ep:" + Ep);

            }
            else
            {
                double da = r2.D_A;
                double log = Math.Log(((bolt.BoltHeadOutD_dw + bolt.BoreD_dh) * (da - bolt.BoreD_dh)) / ((bolt.BoltHeadOutD_dw - bolt.BoreD_dh) * (da + bolt.BoreD_dh)));
                double left = 2 * log / (r2.w * bolt.BoreD_dh * r2.tanPhi_D);
                double right = 4 * (r2.Lk - (da - bolt.BoltHeadOutD_dw) / r2.w / r2.tanPhi_D) / (da * da - bolt.BoreD_dh * bolt.BoreD_dh);
                deltaP = (left + right) / Double.Parse(ep) / Math.PI;
            }
            Console.WriteLine("r2.D_A:"+r2.D_A);
            Console.WriteLine("r2.DAGr:" + r2.DAGr);
            Console.WriteLine("r2.w:" + r2.w);
            Console.WriteLine("r2.Lk:" + r2.Lk);
            Console.WriteLine("r2.tanPhi_D:" + r2.tanPhi_D);
            Console.WriteLine("r2.deltaP:" + deltaP);
        }

        public void setDeltaP_star(string ep)
        {
            if (r2.D_A >= r2.DAGr)
            {
                r2.D_A = r2.DAGr;
            }

            setI_V_Bers();
            if (r2.s_sym != 0)
            {
                I_ve_bers = I_V_Bers + Math.Pow(r2.s_sym, 2) * Math.PI * Math.Pow(r2.D_A, 2) / 4;
                //if (r2.Fau == 0 || r2.a == 0)
                //{
                //    r2.a = 0;
                //    Nn = 1;
                //}

                if (r2.a != 0)
                {
                    // a
                    if (r2.DAGr > r2.D_A)
                    {
                        double d_a = r2.D_A;
                        I_ve_bers = I_V_Bers + r2.s_sym * r2.s_sym * Math.PI * d_a * d_a / 4;
                        I_h_bers = r2.b * Math.Pow(r2.ct, 3) / 12;
                        l_v = d_a - bolt.BoltHeadOutD_dw / (2 * r2.tanPhi_D);
                        l_H = r2.Lk - 2 * l_v / r2.w;
                        I_bers = r2.Lk / (2 * l_v / r2.w / I_ve_bers) + l_H / I_h_bers;
                        deltaP_star =
                                    deltaP + r2.s_sym * r2.s_sym * r2.Lk / Convert.ToDouble(ep) / I_bers;
                        deltaP_star_star =
                            deltaP + r2.s_sym * r2.a * r2.Lk / Convert.ToDouble(ep) / I_bers;
                    }
                    else
                    {
                        l_v = (r2.D_A - bolt.BoltHeadOutD_dw) / (2 * r2.tanPhi_D);
                        if (r2.w == 1)
                        {
                            Console.WriteLine("l_v = " + l_v);
                            // 只有变形锥的I_Bers
                            I_bers = I_ve_bers;
                            deltaP_star = deltaP + r2.s_sym * r2.s_sym * r2.Lk / Convert.ToDouble(ep) / I_bers;
                            deltaP_star_star = deltaP + r2.a * r2.s_sym * r2.Lk / Convert.ToDouble(ep) / I_bers;
                            Console.WriteLine("I_Bers = " + I_bers);
                            Console.WriteLine("deltaP = " + deltaP);
                            Console.WriteLine("deltaP_star = " + deltaP_star);
                            Console.WriteLine("deltaP_star_star = " + deltaP_star_star);
                        }
                    }
                }
                else
                {
                    // a = 0
                    if (r2.DAGr > r2.D_A)
                    {
                        double d_a = r2.D_A;
                        I_V_Bers = 0.147 * (d_a - bolt.BoltHeadOutD_dw) * Math.Pow(bolt.BoltHeadOutD_dw, 3) * d_a * d_a * d_a / (d_a * d_a * d_a - Math.Pow(bolt.BoltHeadOutD_dw, 3));

                        I_ve_bers = I_V_Bers + r2.s_sym * r2.s_sym * Math.PI * d_a * d_a / 4;
                        I_h_bers = r2.b * Math.Pow(r2.ct, 3) / 12;
                        l_v = d_a - bolt.BoltHeadOutD_dw / (2 * r2.tanPhi_D);
                        l_H = r2.Lk - 2 * l_v / r2.w;
                        I_bers = r2.Lk / (2 * l_v / r2.w / I_ve_bers) + l_H / I_h_bers;
                        deltaP_star =
                                    deltaP + r2.s_sym * r2.s_sym * r2.Lk / Convert.ToDouble(ep) / I_bers;
                    }
                    else
                    {
                        l_v = (r2.D_A - bolt.BoltHeadOutD_dw) / (2 * r2.tanPhi_D);
                        if (r2.w == 1)
                        {
                            Console.WriteLine("l_v = " + l_v);
                            // 只有变形锥的I_Bers
                            I_bers = I_ve_bers;
                            deltaP_star = deltaP + r2.s_sym * r2.s_sym * r2.Lk / Convert.ToDouble(ep) / I_bers;
                            Console.WriteLine("I_Bers = " + I_bers);
                            Console.WriteLine("deltaP = " + deltaP);
                            Console.WriteLine("deltaP_star = " + deltaP_star);
                        }
                    }
                }
            }
        }
        
        private void setI_V_Bers()
        {
            I_V_Bers = 0.147 * (r2.D_A - bolt.BoltHeadOutD_dw) * Math.Pow(bolt.BoltHeadOutD_dw, 3) * Math.Pow(r2.D_A, 3) / (Math.Pow(r2.D_A, 3) - Math.Pow(bolt.BoltHeadOutD_dw, 3));
            if (r2.s_sym != 0)
            {
                I_ve_bers = I_V_Bers + Math.Pow(r2.s_sym, 2) * Math.PI * Math.Pow(r2.D_A, 2) / 4;
            }
            else
            {
                I_ve_bers = I_V_Bers;
            }
        }
        #endregion

        public double getPhi()
        {
            if (r2.a > 0 && r2.s_sym != 0)
            {
                phi = Nn * (deltaP_star_star + deltaPzu) / (deltaP_star + deltaS);
            }
            else if (r2.a == 0 && r2.s_sym != 0)
            {
                phi = Nn * (deltaP + deltaPzu) / (deltaP_star + deltaS);
            }
            else if (r2.a == r2.s_sym && r2.a != 0 && r2.s_sym != 0)
            {
                phi = Nn * (deltaP_star + deltaPzu) / (deltaS + deltaP_star);
            }
            else if (r2.a == 0 && r2.s_sym == 0)
            {
                phi = Nn * (deltaP + deltaPzu) / (deltaP + deltaS);
            }
            Console.WriteLine("Nn:" + Nn);
            Console.WriteLine("deltaPzu:" + deltaPzu);
            Console.WriteLine("deltaP:" + deltaP);
            Console.WriteLine("deltaP_star:" + deltaP_star);
            Console.WriteLine("phi:" + phi);

            return phi;
        }

        public void setMB(string ep)
        {
            if (r2.a != 0)
            {
                r2.Mb += r2.a * r2.Fao;
            }
            phi_m_star =
                        Nn * r2.s_sym * r2.s_sym * r2.Lk /
                        ((deltaS + deltaP) * Convert.ToSingle(ep) * r2.ibt + r2.s_sym * r2.s_sym * r2.Lk);
        }

        public double I_V_Bers { set; get; }
        public double I_ve_bers { set; get; }
        public double I_h_bers { set; get; }
        public double l_v { set; get; }
        public double l_H { set; get; }
    }
}
