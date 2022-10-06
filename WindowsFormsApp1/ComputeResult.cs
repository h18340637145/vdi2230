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
        
        //private double fz;      // 预紧力缺失R4
        //private double fmmin;   // 最小预紧力R5
        //private double fmmax;   // 最大预紧力R6
        //private double fmzul;   // 装配应力大小R7

        //private double sf;      // 抗屈服安全系数R8
        //private double sd;      // 抗疲劳安全系数R9
        //private double sp;      // 装配状态表面压力安全系数R10
        //private double sg;      // 滑动安全系数R12
        //private double sa;      // 滑动安全系数R12

        //// R11 不用计算。螺母螺栓使用同样的材料计算`
        //private double meff;    // 最小啮合长度R11
        //private double ma;      // 必要拧紧力矩R13

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
        [DisplayName("R13必要拧紧力矩")]
        [Description("必要拧紧力矩R13")]
        public double Ma { get; set; }

        [Category("计算结果")]
        [DisplayName("R11最小啮合长度")]
        [Description("不必再确定最小啮合长度，因为在计算过程中默认使用和螺栓同等级的标准螺母")]
        public double Meff { get; set; }

        // 安全系数
        [Category("安全系数")]
        [DisplayName("R8抗屈服安全系数")]
        [Description("抗屈服安全系数R8")]

        public double Sf { get; set; }

        [Category("安全系数")]
        [DisplayName("R9抗疲劳安全系数")]
        [Description("抗疲劳安全系数R9")]
        public double Sd { get; set; }

        [Category("安全系数")]
        [DisplayName("R10装配状态表面压力安全系数")]
        [Description("装配状态表面压力安全系数R10")]
        public double Sp { get; set; }

        [Category("安全系数")]
        [DisplayName("R12滑动安全系数")]
        [Description("无剪力的时候可以忽略")]
        public double Sg { get; set; }

        [Category("安全系数")]
        [DisplayName("R12滑动安全系数")]
        [Description("无剪力的时候可以忽略")]
        public double Sa { get; set; }
    }
}
