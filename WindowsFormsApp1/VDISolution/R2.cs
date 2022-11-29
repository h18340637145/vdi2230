using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.VDISolution
{
    public class R2
    {
        BoltClass bolt { set; get; }
        public double D_A { set; get; }
        public int w { set; get; }
        public double Lk { set; get; }
        public double tanPhi_D { set; get; }
        public double hmin { set; get; }
        public double DAGr { set; get; }
        public double Fao { set; get; } // max
        public double Fau { set; get; }
        public double UGmin { set; get; }
        public double UKmin { set; get; }
        public double Tp { set; get; }
        public double Ts { set; get; }
        public double v { set; get; }
        public double Fmzul { set; get; }

        public double f_kerf { set; get; }

        public R2(BoltClass bolts)
        {
            this.bolt = bolts;
        }
        public double Mb { set; get; }

        //偏心参数
        public double s_sym { set; get; }
        public double u { set; get; }
        public double a { set; get; }
        public double cb { set; get; }
        public double ct { set; get; }
        public double b { set; get; }
        public double bt { set; get; }
        public double ibt { set; get; }
        public double e { set; get; }

        public void setMB(string mb)
        {
            if (mb == "")
            {
                Mb = 0;
            }
            Mb = Convert.ToDouble(mb);
        }

        // 剪力参数
        #region jianli
        public double f_qmax { set; get; }
        public double q_f { set; get; }
        public double q_m { set; get; }
        public double dtau { set; get; }

        public double u_Tmin { set; get; }
        public double sgsoll { set; get; }
        public double M_t { set; get; }
        public double r_a { set; get; }
        public double Dhamax { set; get; }

        public double p_imax { set; get; }
        public double AD { set; get; }
        public double f_kq { set; get; }
        public double f_kp { set; get; }
        public double f_ka { set; get; }
        #endregion
        #region pianxin
        public void setSsym(string ssym)
        {
            if (ssym == "")
            {
                s_sym = 0;
            }
            s_sym = Convert.ToDouble(ssym);
        }
        public void setU(string U)
        {
            if (U == "")
            {
                u = 0;
            }
            u = Convert.ToDouble(U);
        }
        public void setCb(string Cb)
        {
            if (Cb == "")
            {
                cb = 0;
            }
            cb = Convert.ToDouble(Cb);
        }
        public void setCt(string Ct)
        {
            if (Ct == "")
            {
                ct = 0;
            }
            ct = Convert.ToDouble(Ct);
        }
        public void setB(string B)
        {
            if (B == "")
            {
                b = 0;
            }
            b = Convert.ToDouble(B);
        }
        public void setBt(string Bt)
        {
            if (Bt == "")
            {
                bt = 0;
            }
            bt = Convert.ToDouble(Bt);
        }
        public void setE(string E)
        {
            if (E == "")
            {
                e = 0;
            }
            e = Convert.ToDouble(E);
        }
        public void setIbt(string Ibt)
        {
            if (Ibt == "")
            {
                ibt = 0;
            }
            ibt = Convert.ToDouble(Ibt);
        }
        #endregion
        public void setA(string A)
        {
            if (A == "")
            {
                a = 0;
            }
            a = Convert.ToDouble(A);
        }
        public void setDA(string DAText)
        {
            if (DAText == "")
            {
                return ;
            }

            D_A =  Convert.ToDouble(DAText);
        }

        public void setW(string BoltConnectTypeText)
        {
            if (BoltConnectTypeText == "")
            {
                return ;
            }

            if (BoltConnectTypeText == "盲孔螺栓连接")
            {
                w = 2;
            }
            else
            {
                w = 1;
            }
        }

        public void setLk(double H, string Rows0Cells5Value)
        {
            Lk = H;
            if (Rows0Cells5Value == null || Rows0Cells5Value == "")
            {
                return ;
            }
            else
            {
                if (w == 2)
                {
                    Lk = Convert.ToDouble(Rows0Cells5Value);
                }
            }
        }

        public void setTanPhi_D()
        {
            double Ddwm = bolt.BoltHeadOutD_dw;
            double BL = Lk / Ddwm;
            double y = D_A / Ddwm;
            if (w == 1)
            {
                tanPhi_D = 0.362 + 0.032 * Math.Log(BL / 2) + 0.153 * Math.Log(y);
            }
            else if (w == 2)
            {
                tanPhi_D = 0.348 + 0.013 * Math.Log(BL) + 0.193 * Math.Log(y);
            }
        }

        public void setDAGr()
        {
            double Ddwm = bolt.BoltHeadOutD_dw;
            DAGr = Ddwm + w * Lk * tanPhi_D;
        }

        public void setP_imax(string pimax)
        {
            if (pimax == "")
            {
                return ;
            }
            p_imax = Convert.ToDouble(pimax);
        }
        public void setF_kerf(string f)
        {
            if (f != null || f != "")
            {
                f_kerf = Convert.ToDouble(f);
            }
            else
            {
                f_kerf = 0;
                return;
            }
        }
        
        // 不带扭矩
        public void setFkq(string FQText, string qFText, string UTminText)
        {
            if (FQText == null || FQText == "")
            {
                f_qmax = 0;
                return ;
            }
            else
            {
                f_qmax = Convert.ToDouble(FQText);
            }

            if (qFText == "")
            {
                q_f = 1;
            }
            else
            {
                q_f = Convert.ToDouble(qFText);
            }

            if (UTminText == "")
            {
                return ;
            }
            else
            {
                u_Tmin = Convert.ToDouble(UTminText);
            }
            f_kq = f_qmax / (q_f * u_Tmin);
        }

        // 有扭矩  加摩擦半径1  不加摩擦半径用dhmax0
        public void setFkq(string FQText, string qFText, string UTminText, string mt, string qm, string Dhamax_ra, int flag)
        {
            if (FQText == null || FQText == "")
            {
                f_qmax = 0;
                return ;
            }
            else
            {
                f_qmax = Convert.ToDouble(FQText);
            }

            if (qFText == "")
            {
                q_f = 1;
            }
            else
            {
                q_f = Convert.ToDouble(qFText);
            }

            if (UTminText == "")
            {
                return ;
            }
            else
            {
                u_Tmin = Convert.ToDouble(UTminText);
            }

            if (mt == "")
            {
                return ;
            }
            else
            {
                M_t = Convert.ToDouble(mt);
            }

            if (qm == "")
            {
                return ;
            }
            else
            {
                q_m = Convert.ToDouble(qm);
            }

            if (Dhamax_ra == "")
            {
                return ;
            }
            else
            {
                if (flag == 0)
                {
                    r_a = (D_A + Convert.ToDouble(Dhamax_ra)) / 4;
                }
                else
                {
                    r_a = Convert.ToDouble(Dhamax_ra);
                }
            }
            f_kq = f_qmax / (q_f * u_Tmin) + M_t / (q_m * r_a * u_Tmin);
        }

        public void setFka()
        {
            f_ka = Fao * AD * (a * u - s_sym * u)
                        / ((bt * Math.Pow(ct, 3) / 12) + s_sym * u * AD) +
                        Mb * u * AD / ((bt * Math.Pow(ct, 3) / 12) + s_sym * u * AD);
        }

        public void setF_kp(string pimax)
        {
            if (pimax == "")
            {
                p_imax = 0;
            }
            else
            {
                p_imax = Convert.ToDouble(pimax);
            }
            f_kp = p_imax * AD;
        }

        public void setF_kerf()
        {
            f_kerf = Math.Max(f_kq, f_kp + f_ka);
        }
        // 重载多螺栓输入螺栓个数
        public void setF_kerf(int num)
        {
            f_kerf = Math.Max(f_kq  / num, f_kp + f_ka);
        }
        internal void setFao(string fao)
        {
            if (fao == "")
            {
                Fao = 0;
            }
            Fao = Convert.ToDouble(fao);
        }

        internal void setFau(string fau)
        {
            if (fau == "")
            {
                Fau = 0;
            }
            Fau = Convert.ToDouble(fau);
        }

        internal void setFkerf(string fkerf)
        {
            if (fkerf == "")
            {
                f_kerf = 0;
            }
            f_kerf = Convert.ToDouble(fkerf);
        }

        internal void setUTmin(string text)
        {
            UGmin = Convert.ToDouble(text);
        }

        internal void setUKmin(string text)
        {
            UKmin = Convert.ToDouble(text);
        }

        internal void setTs(string text)
        {
            Ts = Convert.ToDouble(text);
        }

        internal void setTp(string text)
        {
            Tp = Convert.ToDouble(text);
        }

        internal void setV(string text)
        {
            v = Convert.ToDouble(text);
        }

        internal void setFmzul(string text)
        {
            Fmzul = Convert.ToDouble(text);
        }

        internal bool checkClampedLs(double height)
        {
            if (w == 2)
            {
                if (bolt.BoltLen_ls <= Lk + height)
                {
                    MessageBox.Show("预期输入：ls > lk + m");
                    return false;
                }
            }
            else if (w == 1)
            {
                if (bolt.PolishRodLen_l1 > Lk)
                {
                    MessageBox.Show("请检查螺栓尺寸！光杆长度l1 必须小于夹持长度lk！");
                    return false;
                }
            }
            return true;
        }
    }
}
