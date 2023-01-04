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

namespace WindowsFormsApp1.StepCalForm
{
    public partial class R11MeffForm : BaseForm
    {
        R11 r11 = new R11();
        public R11MeffForm()
        {
            InitializeComponent();

            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("Lk", 30, "mm夹持长度");
            dataGridView1.Rows.Add("fbm", 0.85, "连接件剪切系数");
            dataGridView1.Rows.Add("Rmmin", 1000, "N/mm2连接件最小抗拉强度");

            CalBtn.Click += CalBtn_Click;
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            _setEveryPropFieldFromDataGridView();
            if (bolt == null)
            {
                MessageBox.Show("请选择螺栓");
                return;
            }
            if (material == null)
            {
                MessageBox.Show("请选择材料");
                return;
            }
            R11 res = new R11(bolt, r11.Lk, r11.fbm, r11.Rmmin);
            Result obj = new Result();
            obj.Meff = res.getMeff();
            resGrid.SelectedObject = null;
            resGrid.SelectedObject = obj;
        }

        private void _setEveryPropFieldFromDataGridView()
        {
            foreach (var f in r11.GetType().GetProperties())
            {
                var propName = f.Name;
                if (propName == "bolt")
                {
                    continue;
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(r11, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private class Result
        {
            [Category("计算结果")]
            [DisplayName("R11最小啮合长度")]
            [Description("不必再确定最小啮合长度，因为在计算过程中默认使用和螺栓同等级的标准螺母")]

            public double Meff { get; set; }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
