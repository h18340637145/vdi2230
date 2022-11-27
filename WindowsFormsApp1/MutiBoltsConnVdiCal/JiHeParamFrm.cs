using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    public partial class JiHeParamFrm : ParamBaseFrm
    {
        JiHeParameters jiHeParameters;
        public JiHeParamFrm()
        {
            InitializeComponent();
            pianxinBtn.Visible = true;

            dataGridView1.Rows.Add("DA", 80, "接合面等效外径");
            dataGridView1.Rows.Add("DA_", 80, "接合面上的面的等效外径");
            dataGridView1.Rows.Add("fz", 0.008, "嵌入深度");
            dataGridView1.Rows.Add("n", 0.07, "载荷系数");

            //CalBtn.Click += CalBtn_Click;
            pianxinBtn.Click += pianxinBtn_Click;
        }

        private void _setEveryPropFieldFromDataGridViewJiHe()
        {
            if (jiHeParameters == null)
            {
                jiHeParameters = new JiHeParameters();
            }
            foreach (var f in jiHeParameters.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(jiHeParameters, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void _setEveryPropFieldFromDataGridViewPianXin()
        {
            if (jiHeParameters.PianXin == null)
            {
                jiHeParameters.PianXin = new PianXin();
            }
            foreach (var f in jiHeParameters.PianXin.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(jiHeParameters.PianXin, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void pianxinBtn_Click(object sender, EventArgs e)
        {
            if (pianxinBtn.Checked == true)
            {
                // 使用偏心参数
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("DA", 80, "接合面等效外径");
                dataGridView1.Rows.Add("DA_", 80, "接合面上的面的等效外径");
                dataGridView1.Rows.Add("fz", 0.008, "嵌入深度");
                dataGridView1.Rows.Add("n", 0.07, "载荷系数");

                dataGridView1.Rows.Add("ssym", 5, "偏心距");
                dataGridView1.Rows.Add("u", 2, "0-0轴到开口处的距离");
                dataGridView1.Rows.Add("cB", 20, "受弯体长度");
                dataGridView1.Rows.Add("cT", 20, "被连接件接合面长度");
                dataGridView1.Rows.Add("b", 20, "受弯体宽度");
                dataGridView1.Rows.Add("bT", 20, "被连接件接合面宽度");
                dataGridView1.Rows.Add("e", 2, "从接合面带有张开风险的边缘至螺栓轴的距离");
                dataGridView1.Rows.Add("a", 5, "偏心轴向载荷");
            }
            else
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("DA", 80, "接合面等效外径");
                dataGridView1.Rows.Add("DA_", 80, "接合面上的面的等效外径");
                dataGridView1.Rows.Add("fz", 0.008, "嵌入深度");
                dataGridView1.Rows.Add("n", 0.07, "载荷系数");

            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            _setEveryPropFieldFromDataGridViewJiHe();
            if (pianxinBtn.Checked == true)
            {
                // 偏心
                _setEveryPropFieldFromDataGridViewPianXin();
            }
            else
            {
                // 同心
            }
        }

        public JiHeParameters GetJiheParams()
        {
            return jiHeParameters;
        }
    }
    public class JiHeParameters
    {
        public double DA { get; set; }
        public double DA_ { get; set; }
        public double fz { get; set; }
        public double n { get; set; }
        public PianXin PianXin;
    }

    public class PianXin
    {
        public double ssym { get; set; }
        public double u { get; set; }
        public double cB { get; set; }
        public double cT { get; set; }
        public double b { get; set; }
        public double bT { get; set; }
        public double e { get; set; }
        public double a { get; set; }
    }
}
