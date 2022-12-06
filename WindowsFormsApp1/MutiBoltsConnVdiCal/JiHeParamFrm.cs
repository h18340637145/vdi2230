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

            dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
            dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
            dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
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

        private void _setEveryPropFieldFromDataGridViewNeiYa()
        {
            if (jiHeParameters.neiya == null)
            {
                jiHeParameters.neiya = new NeiYa();
            }
            foreach (var f in jiHeParameters.neiya.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(jiHeParameters.neiya, obj is string ? Convert.ToDouble(obj) : obj);
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
            if (neiyaBtn.Checked == true)
            {
                // 有内压 显示
                if (pianxinBtn.Checked == true)
                {
                    // 显示内压和偏心
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
                    dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
                    dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
                    dataGridView1.Rows.Add("n", 0.07, "mm载荷系数");
                    dataGridView1.Rows.Add("pimax", 0, "内压强度");

                    dataGridView1.Rows.Add("ssym", 5, "mm偏心距");
                    dataGridView1.Rows.Add("u", 2, "mm0-0轴到开口处的距离");
                    dataGridView1.Rows.Add("cB", 20, "mm受弯体长度");
                    dataGridView1.Rows.Add("cT", 20, "mm被连接件接合面长度");
                    dataGridView1.Rows.Add("b", 20, "mm受弯体宽度");
                    dataGridView1.Rows.Add("bT", 20, "mm被连接件接合面宽度");
                    dataGridView1.Rows.Add("e", 2, "mm从接合面带有张开风险的边缘至螺栓轴的距离");
                    dataGridView1.Rows.Add("a", 5, "mm偏心轴向载荷");
                    dataGridView1.Rows.Add("AD", 70, "mm2内压面积");

                }
                else
                {
                    //显示内压不显示偏心
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
                    dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
                    dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
                    dataGridView1.Rows.Add("n", 0.07, "载荷系数");
                    dataGridView1.Rows.Add("pimax", 0, "内压强度");
                }
            }
            else
            {
                // 无内压 不显示
                if (pianxinBtn.Checked == true)
                {
                    // 不显示内压， 显示偏心
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
                    dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
                    dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
                    dataGridView1.Rows.Add("n", 0.07, "载荷系数");

                    dataGridView1.Rows.Add("ssym", 5, "mm偏心距");
                    dataGridView1.Rows.Add("u", 2, "mm0-0轴到开口处的距离");
                    dataGridView1.Rows.Add("cB", 20, "mm受弯体长度");
                    dataGridView1.Rows.Add("cT", 20, "mm被连接件接合面长度");
                    dataGridView1.Rows.Add("b", 20, "mm受弯体宽度");
                    dataGridView1.Rows.Add("bT", 20, "mm被连接件接合面宽度");
                    dataGridView1.Rows.Add("e", 2, "mm从接合面带有张开风险的边缘至螺栓轴的距离");
                    dataGridView1.Rows.Add("a", 5, "mm偏心轴向载荷");
                    dataGridView1.Rows.Add("AD", 70, "mm2内压面积");

                }
                else
                {
                    // 不显示内压， 不显示偏心
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
                    dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
                    dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
                    dataGridView1.Rows.Add("n", 0.07, "载荷系数");

                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            _setEveryPropFieldFromDataGridViewJiHe();
            if (pianxinBtn.Checked == true)
            {
                // 偏心
                _setEveryPropFieldFromDataGridViewPianXin();
                if (neiyaBtn.Checked == true)
                {
                    _setEveryPropFieldFromDataGridViewNeiYa();
                }
            }
            else
            {
                // 同心
            }
            Hide();

        }

        public JiHeParameters GetJiheParams()
        {
            return jiHeParameters;
        }

        private void neiyaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (neiyaBtn.Checked == true)
            {
                // 有内压 显示
                if (pianxinBtn.Checked == true)
                {
                    // 显示内压和偏心
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
                    dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
                    dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
                    dataGridView1.Rows.Add("n", 0.07, "载荷系数");
                    dataGridView1.Rows.Add("pimax", 0, "N/mm2内压强度");

                    dataGridView1.Rows.Add("ssym", 5, "mm偏心距");
                    dataGridView1.Rows.Add("u", 2, "mm0-0轴到开口处的距离");
                    dataGridView1.Rows.Add("cB", 20, "mm受弯体长度");
                    dataGridView1.Rows.Add("cT", 20, "mm被连接件接合面长度");
                    dataGridView1.Rows.Add("b", 20, "mm受弯体宽度");
                    dataGridView1.Rows.Add("bT", 20, "mm被连接件接合面宽度");
                    dataGridView1.Rows.Add("e", 2, "mm从接合面带有张开风险的边缘至螺栓轴的距离");
                    dataGridView1.Rows.Add("a", 5, "mm偏心轴向载荷");
                    dataGridView1.Rows.Add("AD", 70, "mm2内压面积");

                }
                else
                {
                    //显示内压不显示偏心
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
                    dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
                    dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
                    dataGridView1.Rows.Add("n", 0.07, "载荷系数");
                    dataGridView1.Rows.Add("pimax", 0, "N/mm2内压强度");
                }
            }
            else
            {
                // 无内压 不显示
                if (pianxinBtn.Checked == true)
                {
                    // 不显示内压， 显示偏心
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
                    dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
                    dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
                    dataGridView1.Rows.Add("n", 0.07, "载荷系数");

                    dataGridView1.Rows.Add("ssym", 5, "mm偏心距");
                    dataGridView1.Rows.Add("u", 2, "mm0-0轴到开口处的距离");
                    dataGridView1.Rows.Add("cB", 20, "mm受弯体长度");
                    dataGridView1.Rows.Add("cT", 20, "mm被连接件接合面长度");
                    dataGridView1.Rows.Add("b", 20, "mm受弯体宽度");
                    dataGridView1.Rows.Add("bT", 20, "mm被连接件接合面宽度");
                    dataGridView1.Rows.Add("e", 2, "mm从接合面带有张开风险的边缘至螺栓轴的距离");
                    dataGridView1.Rows.Add("a", 5, "mm偏心轴向载荷");
                    dataGridView1.Rows.Add("AD", 70, "mm2内压面积");

                }
                else
                {
                    // 不显示内压， 不显示偏心
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add("DA", 80, "mm接合面等效外径");
                    dataGridView1.Rows.Add("DA_", 80, "mm接合面上的面的等效外径");
                    dataGridView1.Rows.Add("fz", 0.008, "um嵌入深度");
                    dataGridView1.Rows.Add("n", 0.07, "载荷系数");

                }
            }
        }
    }
    public class JiHeParameters
    {
        public double DA { get; set; }
        public double DA_ { get; set; }
        public double fz { get; set; }
        public double n { get; set; }
        public NeiYa neiya;
        public PianXin PianXin;
    }

    public class NeiYa
    {
        public double pimax { get; set; }
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
        public double AD { get; set; }
    }
}
