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
    public partial class R6FMmaxForm : BaseForm
    {
        R6 r6 = new R6();
        public R6FMmaxForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("alpha", 1.5, "拧紧系数");
            dataGridView1.Rows.Add("fmmin", 27668, "N最小夹紧载荷");
            chooseBoltBtn.Visible = false;
            chooseMaterialBtn.Visible = false;
            CalBtn.Click += CalBtn_Click1;
        }

        private void CalBtn_Click1(object sender, EventArgs e)
        {
            _setEveryPropFieldFromDataGridView();
            R6 res = new R6(this.r6.alpha, this.r6.fmmin);
            Result obj = new Result();
            obj.Fmmax = res.getFmmax();
            resGrid.SelectedObject = null;
            resGrid.SelectedObject = obj;
        }

        private void _setEveryPropFieldFromDataGridView()
        {
            foreach (var f in r6.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(r6, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private class Result
        {
            [Category("计算结果")]
            [DisplayName("R6最大夹紧载荷FMmax")]
            [Description("")]
            public double Fmmax { get; set; }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
