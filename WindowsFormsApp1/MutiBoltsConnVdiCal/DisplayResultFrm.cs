using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.VDISolution;
using System.Windows.Documents;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    public partial class DisplayResultFrm : Form
    {
        Solution solution;
        ComputeResult rs;
        public DisplayResultFrm(Solution solution, ComputeResult rs)
        {
            InitializeComponent();
            this.solution = solution;
            this.rs = rs;
            resGrid.SelectedObject = rs;

            ShowDataChartForOpResult();
        }

        /*
        private object QuickExtractValueFromDGV(string name)
        {
            object rowValue = null;
            foreach (DataGridViewRow row in _twoStepsOpParamDataGridView.Rows)
            {
                var prope = row.Cells["PropeField"].Value as string;
                if (prope.Equals(name))
                {
                    rowValue = row.Cells["ValueField"].Value;
                    break;
                }
            }
            if (rowValue == null)
            {
                return null;
            }
            if (name == "C")
            {
                string vs = rowValue as string;
                var ss = vs.Split(',');
                double[] re = new double[ss.Length];
                for (int i = 0; i < re.Length; i++)
                {
                    re[i] = Convert.ToDouble(ss[i]);
                }
                return re;
            }
            else return rowValue;
        }
        */

        private void ShowDataChartForOpResult()
        {
            lineChart.Series.Clear();
            Series blackLine = new Series("Screw characteristic");
            Series redLine = new Series("characteristic strutted part(Fmzul)");
            blackLine.ChartType = SeriesChartType.Line;
            redLine.ChartType = SeriesChartType.Line;
            blackLine.IsValueShownAsLabel = true;
            redLine.IsValueShownAsLabel = true;

            lineChart.ChartAreas[0].AxisX.Title = "load F, kN";
            lineChart.ChartAreas[0].AxisY.Title = "Displacement f, mm";
            lineChart.ChartAreas[0].AxisY.MajorGrid.Interval = 1;//ChartAreas[0]想要获取或设置的元素从0开始的索引
            lineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightBlue;
            lineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightBlue;
            lineChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;//虚线
            lineChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            //lineChart.ChartAreas[0].AxisX.MajorGrid.Interval = 400;
            //lineChart.ChartAreas[0].AxisY.MajorGrid.Interval = 50;
            lineChart.ChartAreas[0].AxisX.Interval = 0.025;
            lineChart.ChartAreas[0].AxisY.Interval = 5; //设置Y轴的刻度间距

            //Y轴范围0-Fmzul  X轴范围0~deltaS + deltaP
            lineChart.ChartAreas[0].AxisX.Minimum = 0;
            lineChart.ChartAreas[0].AxisX.Maximum = (rs.Fmzul * rs.deltas + rs.Fmzul * rs.deltap) * 1.2;
            lineChart.ChartAreas[0].AxisY.Minimum = 0;
            lineChart.ChartAreas[0].AxisY.Maximum = rs.Fmzul * 1.25 / 1000;

            lineChart.ChartAreas[0].Area3DStyle.Enable3D = false;//启用3D显示
            //设置空数据时显示坐标轴
            lineChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            lineChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;

            blackLine.Points.AddXY(0, 0);
            blackLine.Points.AddXY(rs.Fmzul * rs.deltas, rs.Fmzul / 1000);
            redLine.Points.AddXY(rs.Fmzul * rs.deltas, rs.Fmzul / 1000);
            redLine.Points.AddXY(rs.Fmzul * rs.deltas + rs.Fmzul * rs.deltap, 0);

            // 有问题
            Series buleLine = new Series("characteristic strutted part(FMmin)");
            buleLine.Points.AddXY(lineFunc(rs.Fmmin / 1000), rs.Fmmin / 1000);
            buleLine.Points.AddXY(rs.Fmmin * rs.deltas, 0);

            MessageBox.Show("point1:" + lineFunc(rs.Fmmin / 1000) + " " + rs.Fmmin / 1000);
            MessageBox.Show("point2:" + rs.Fmmin * rs.deltas + " 0");

            Series greenLine = new Series("characteristic strutted part(FMmax)");
            greenLine.Points.AddXY(lineFunc(rs.Fmmax / 1000), rs.Fmmax / 1000);
            greenLine.Points.AddXY(rs.Fmmax * rs.deltas, 0);

            //把series添加到chart上
            lineChart.Series.Add(blackLine);
            lineChart.Series.Add(redLine);
            lineChart.Series.Add(buleLine);
            lineChart.Series.Add(greenLine);

        }

        double lineFunc(double y)
        {
            double k = (rs.Fmzul / 1000) / (rs.Fmzul * rs.deltas);
            return y / k;
        }
    }
}
