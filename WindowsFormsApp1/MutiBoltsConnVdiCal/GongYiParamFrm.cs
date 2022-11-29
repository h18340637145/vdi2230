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
    public partial class GongYiParamFrm : ParamBaseFrm
    {
        GongYiParameters gongYiParameters;
        public static string zhazhi;

        public GongYiParamFrm()
        {
            InitializeComponent();
            pianxinBtn.Visible = false;
            zhazhiBtn.Visible = true;

            dataGridView1.Rows.Add("Rz", 16, "um平均表面粗糙度");
            dataGridView1.Rows.Add("alphaA", 1, "拧紧系数");
            dataGridView1.Rows.Add("Ugmin", 0.1, "螺纹接触面最小摩擦系数Ugmin");
            dataGridView1.Rows.Add("UTmin", 0.1, "被连接件接合面间最小摩擦系数UTmin");
            dataGridView1.Rows.Add("Ukmin", 0.1, "螺栓头接触面最小摩擦系数Ukmin");

            label1.Visible = false;
            N.Visible = false;
        }

        public GongYiParameters GetGongYiParams()
        {
            return gongYiParameters;
        }

        private void ifN_CheckedChanged(object sender, EventArgs e)
        {
            if (ifN.Checked == true)
            {
                label1.Visible = true;
                N.Visible = true;
            }
            else
            {
                label1.Visible = false;
                N.Clear();
                N.Visible = false;
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("Rz", 16, "um平均表面粗糙度");
                dataGridView1.Rows.Add("alphaA", 1, "拧紧系数");
                dataGridView1.Rows.Add("Ugmin", 0.1, "螺纹接触面最小摩擦系数Ugmin");
                dataGridView1.Rows.Add("UTmin", 0.1, "被连接件接合面间最小摩擦系数UTmin");
                dataGridView1.Rows.Add("Ukmin", 0.1, "螺栓头接触面最小摩擦系数Ukmin");
            }
        }

        private void _setEveryPropFieldFromDataGridViewGongYi()
        {
            if (gongYiParameters == null)
            {
                gongYiParameters = new GongYiParameters();
            }
            foreach (var f in gongYiParameters.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(gongYiParameters, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        // 类成员必须写成 public double A{get;set;} 形式
        private void _setEveryPropFieldFromDataGridViewN()
        { 
            if (gongYiParameters.jiaoBian == null)
            {
                gongYiParameters.jiaoBian = new JiaoBian();
            }
            foreach (var f in gongYiParameters.jiaoBian.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(gongYiParameters.jiaoBian, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
            //if (N.Text == "")
            //{
            //    MessageBox.Show("请输入N");
            //    return;
            //}
            //gongYiParameters.jiaoBian.N = Convert.ToDouble(N.Text);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            // 参数包装到gongYiParameters 中
            _setEveryPropFieldFromDataGridViewGongYi();
            if (ifN.Checked == true)
            {
                // 有交变次数 包装到jiaobian 对象中
                _setEveryPropFieldFromDataGridViewN();
            }
            else
            {
            }
            this.Hide();
        }

        private void N_TextChanged(object sender, EventArgs e)
        {
            if (ifN.Checked == false)
            {
                dataGridView1.Rows.Clear();
                return;
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Rz", 16, "um平均表面粗糙度");
            dataGridView1.Rows.Add("alphaA", 1, "拧紧系数");
            dataGridView1.Rows.Add("Ugmin", 0.1, "螺纹接触面最小摩擦系数Ugmin");
            dataGridView1.Rows.Add("UTmin", 0.1, "被连接件接合面间最小摩擦系数UTmin");
            dataGridView1.Rows.Add("Ukmin", 0.1, "螺栓头接触面最小摩擦系数Ukmin");

            if (N.Text == "")
            {
                MessageBox.Show("请输入N");
                return;
            }
            else
            {
                dataGridView1.Rows.Add("N", Convert.ToDouble(N.Text), "循环周期数");
            }
        }

        private void zhazhiBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (zhazhiBtn.Checked == true)
            {
                zhazhi = "热处理前轧制";
            }
            else
            {
                zhazhi = "热处理后轧制";
            }
        }
    }

    public class GongYiParameters
    {
        public double Rz { get; set; }
        public double alphaA { get; set; }
        public double Ugmin { get; set; }
        public double UTmin { get; set; }
        public double Ukmin { get; set; }

        public JiaoBian jiaoBian;
    }

    public class JiaoBian
    {
        public double N { get; set; }
    }
}
