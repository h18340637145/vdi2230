using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.VDISolution
{
    public class R1
    {
        public double alpha { set; get; }

        public double getAlpha(string tightenText, string tightenCoefText)
        {
            if (tightenText == "自定义输入")
            {
                alpha = Convert.ToDouble(tightenCoefText);
            }
            else if (tightenText == "伸长量控制或超声波监测拧紧")
            {
                alpha = (1.1 + 1.2) / 2;
            }
            else if (tightenText == "机械伸长量测量或监测拧紧")
            {
                alpha = (1.1 + 1.5) / 2;
            }
            else if (tightenText == "液压无摩擦和无扭转拧紧")
            {
                alpha = (1.1 + 1.4) / 2;
            }
            else if (tightenText == "液压脉冲发生器的脉冲驱动器、扭矩和或转角控制")
            {
                alpha = (1.2 + 2) / 2;
            }
            else if (tightenText == "屈服点控制拧紧，电动或手动")
            {
                alpha = (1.2 + 1.4) / 2;
            }
            else if (tightenText == "转角控制拧紧，电动或手动")
            {
                alpha = (1.2 + 1.4) / 2;
            }
            else if (tightenText == "使用液压工具扭矩控制拧紧")
            {
                alpha = (1.4 + 1.6) / 2;
            }
            else if (tightenText == "扭矩扳手、信号扳手或带动态扭矩测量的电动螺母扳手扭矩控制拧紧")
            {
                alpha = (1.4 + 1.6) / 2;
            }
            else if (tightenText == "扭矩扳手、信号扳手或带动态扭矩测量的电动螺母扳手扭矩控制拧紧B")
            {
                alpha = (1.6 + 2) / 2;
            }
            else if (tightenText == "扭矩扳手、信号扳手或带动态扭矩测量的电动螺母扳手扭矩控制拧紧A")
            {
                alpha = (1.7 + 2.5) / 2;
            }
            else if (tightenText == "冲击扳手或脉冲扳手拧紧；用手拧紧")
            {
                alpha = (2.5 + 4) / 2;
            }
            return alpha;
        }
    }
}
