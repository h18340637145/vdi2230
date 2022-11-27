using CreateBotSpring;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class BoltMaterialClass
    {
        public string BoltMaterialLevel { get; set; }
        public double BoltMaterialRatio { get; set; }
        public double BoltMaterialRatio_fB { get; set; }
        public double BoltMaterialEs { get; set; }
        public double BoltMaterialRpmin { get; set; }
        public double BoltMaterialRm { get; set; }
        public double BoltMaterialA { get; set; }
        public double BoltMaterialTmax { get; set; }
    }

    public class BoltClass
    {
        // 螺栓数据
        public double NormalD_d { get; set; }
        public double ScrewP_P { get; set; }
        public double BoltLen_ls { get; set; }
        public double BoreD_dh { get; set; }
        public double BoreD_dT { get; set; }
        public double BoltHeadOutD_dw { get; set; }
        public double BoltHeadInnerD_da { get; set; }
        public double ScrewMidD_d2 { get; set; }
        public double ScrewMinD_d3 { get; set; }
        public double PolishRodLen_l1 { get; set; }
        public double PolishRodLen_l2 { get; set; }
        public double BoltNutSideWid_s { get; set; }
        public double BoltNutScrewMinD_D1 { get; set; }

        public BoltMaterialClass boltMaterial { get; set; }

        public BoltClass()
        {
            boltMaterial = new BoltMaterialClass();
        }

        public BoltClass(Bolt bolt)
        {
            // sel db
            selDb(bolt);
            boltMaterial = new BoltMaterialClass();
        }

        private void selDb(Bolt bolt)
        {
            string sql = "select * from dbo_BoltTable " +
                   "where normalD=" + bolt.d + " and " + "ScrewMinD_d3=" + bolt.d1 + " and ScrewP_P=" + bolt.p + 
                   " and BoltLen_ls=" + bolt.l + " and PolishRodLen_l1=" + bolt.l1 + " and BoltNutSideWid_s=" + bolt.s;

            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            if (dr.Read())
            {
                string normalD_d, screwP_P, boltLen_ls, boreD_dh, BoreD_dT, boltHeadOutD_dw, boltHeadInnerD_da,
                    screwMidD_d2, screwMinD_d3, polishRodLen_l1, polishRodLen_l2, boltNutSideWid_s, boltNutScrewMinD_D1;
                string nutIndex, gasketIndex;
                normalD_d = dr["normalD_d"].ToString();
                screwP_P = dr["screwP_P"].ToString();
                boltLen_ls = dr["boltLen_ls"].ToString();
                boreD_dh = dr["boreD_dh"].ToString();
                BoreD_dT = dr["dT"].ToString();
                boltHeadOutD_dw = dr["boltHeadOutD_dw"].ToString();
                boltHeadInnerD_da = dr["boltHeadInnerD_da"].ToString();
                screwMidD_d2 = dr["screwMidD_d2"].ToString();
                screwMinD_d3 = dr["screwMinD_d3"].ToString();
                polishRodLen_l1 = dr["polishRodLen_l1"].ToString();
                polishRodLen_l2 = dr["polishRodLen_l2"].ToString();
                boltNutSideWid_s = dr["boltNutSideWid_s"].ToString();
                boltNutScrewMinD_D1 = dr["boltNutScrewMinD_D1"].ToString();
                nutIndex = dr["dbo_bolttable.nutIndex"].ToString();
                gasketIndex = dr["dbo_bolttable.gasketIndex"].ToString();

                string[] str = { normalD_d, screwP_P, boltLen_ls, boreD_dh, BoreD_dT, boltHeadOutD_dw, boltHeadInnerD_da,
                        screwMidD_d2, screwMinD_d3, polishRodLen_l1, boltNutSideWid_s, boltNutScrewMinD_D1 };

                this.BoltLen_ls = double.Parse(boltLen_ls);
                this.NormalD_d = double.Parse(normalD_d);
                this.ScrewP_P = double.Parse(screwP_P);
                this.BoreD_dh = double.Parse(boreD_dh);
                this.BoreD_dT = double.Parse(BoreD_dT);
                this.BoltHeadOutD_dw = double.Parse(boltHeadOutD_dw);
                this.BoltHeadInnerD_da = double.Parse(boltHeadInnerD_da);
                this.ScrewMidD_d2 = double.Parse(screwMidD_d2);
                this.ScrewMinD_d3 = double.Parse(screwMinD_d3);
                this.PolishRodLen_l1 = double.Parse(polishRodLen_l1);
                this.BoltNutSideWid_s = double.Parse(boltNutSideWid_s);
                this.BoltNutScrewMinD_D1 = double.Parse(boltNutScrewMinD_D1);
            }
            else
            {
                MessageBox.Show("不存在标准螺栓");
                return;
            }
            dr.Close();
        }
    }
}
