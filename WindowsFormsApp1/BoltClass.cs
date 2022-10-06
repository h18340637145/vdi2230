using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double BoltHeadOutD_dw { get; set; }
        public double BoltHeadInnerD_da { get; set; }
        public double ScrewMidD_d2 { get; set; }
        public double ScrewMinD_d3 { get; set; }
        public double PolishRodLen_l1 { get; set; }
        public double BoltNutSideWid_s { get; set; }
        public double BoltNutScrewMinD_D1 { get; set; }

        public BoltMaterialClass boltMaterial { get; set; }

        public BoltClass()
        {
            boltMaterial = new BoltMaterialClass();
        }
    }
}
