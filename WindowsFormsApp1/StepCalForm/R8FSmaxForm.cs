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
    public partial class R8FSmaxForm : BaseForm
    {
        R8 r8 = new R8();

        public R8FSmaxForm()
        {
            InitializeComponent();

            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("Fmzul", 75947, "N许用装配预紧力");
            dataGridView1.Rows.Add("fao", 24900, "N轴向载荷上限值");
            dataGridView1.Rows.Add("phi", 0.012, "载荷系数");
            dataGridView1.Rows.Add("ugmin", 0.1, "螺纹接触面最小摩擦系数");

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
            R8 res = new R8(bolt, r8.Fmzul, r8.fao, r8.phi, r8.ugmin);
            Result obj = new Result();
            obj.FSmax = res.getFSmax();
            obj.Sf = res.getSf();
            resGrid.SelectedObject = null;
            resGrid.SelectedObject = obj;
        }

        private void _setEveryPropFieldFromDataGridView()
        {
            foreach (var f in r8.GetType().GetProperties())
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
                        f.SetValue(r8, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private class Result
        {
            [Category("计算结果")]
            [DisplayName("R8服役最大螺栓力FSmax")]
            [Description("")]
            public double FSmax { get; set; }

            [Category("计算结果")]
            [DisplayName("R8抗屈服安全系数Sp")]
            [Description("")]
            public double Sf { get; set; }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
