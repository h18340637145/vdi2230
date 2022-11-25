using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ComputeResult
    {
        [Category("计算结果")]
        [DisplayName("R2Fkerf")]
        [Description("")]
        public double Fkerf { get; set; }

        [Category("计算结果")]
        [DisplayName("R3回弹量s")]
        [Description("")]
        public double deltas { get; set; }

        [Category("计算结果")]
        [DisplayName("R3回弹量p")]
        [Description("")]
        public double deltap { get; set; }

        [Category("计算结果")]
        [DisplayName("R3载荷系数")]
        [Description("")]
        public double phi { get; set; }

        // 应力结果
        [Category("计算结果")]
        [DisplayName("R4预紧力缺失")]
        [Description("预紧力缺失R4")]
        public double Fz { get; set; }

        [Category("计算结果")]
        [DisplayName("R5最小预紧力")]
        [Description("最小预紧力R5")]
        public double Fmmin { get; set; }

        [Category("计算结果")]
        [DisplayName("R6最大预紧力")]
        [Description("最大预紧力R6")]
        public double Fmmax { get; set; }

        [Category("计算结果")]
        [DisplayName("R7装配应力大小")]
        [Description("装配应力大小R7")]
        public double Fmzul { get; set; }

        [Category("计算结果")]
        [DisplayName("R11最小啮合长度")]
        [Description("不必再确定最小啮合长度，因为在计算过程中默认使用和螺栓同等级的标准螺母")]
        public double Meff { get; set; }

        [Category("计算结果")]
        [DisplayName("R13必要拧紧力矩")]
        [Description("必要拧紧力矩R13")]
        public double Ma { get; set; }

        // 安全系数
        [Category("安全系数")]
        [DisplayName("R8抗屈服安全系数")]
        [Description("抗屈服安全系数R8")]

        public double Sf { get; set; }

        [Category("安全系数")]
        [DisplayName("R9抗疲劳安全系数")]
        [Description("静态加载无需验证疲劳安全性")]
        public double Sd { get; set; }


        // 一般就是装配和工作，螺栓头的两个即可
        [Category("安全系数")]
        [DisplayName("R10螺栓头承载面表面压力安全系数")]
        [Description("装配状态螺栓头承载面表面压力安全系数R10")]
        public double Sp { get; set; }

        [Category("安全系数")]
        [DisplayName("R10螺栓头承载面压力安全系数")]
        [Description("螺栓头承载面工作状态表面压力安全系数R10")]
        public double Sp_load { get; set; }

        // 通孔螺栓的时候，在上述两个螺栓头之外，还有两个螺母的
        [Category("安全系数")]
        [DisplayName("R10表螺母面压力安全系数")]
        [Description("装配状态螺母表面压力安全系数R10")]
        public double Spn { get; set; }


        [Category("安全系数")]
        [DisplayName("R10螺母接触面表面压力安全系数")]
        [Description("螺母接触面工作状态表面压力安全系数R10")]
        public double Spn_load { get; set; }

        //[Category("安全系数")]
        //[DisplayName("R12滑动安全系数")]
        //[Description("无剪力的时候可以忽略")]
        //public double Sg { get; set; }

        [Category("安全系数")]
        [DisplayName("R12滑动安全系数")]
        [Description("抗滑移安全验证")]
        public double sgoll { get; set; }

        [Category("安全系数")]
        [DisplayName("R12剪切安全系数")]
        [Description("抗剪切安全验证，无剪力的时候可以忽略")]
        public double Sa { get; set; }
    }
}
