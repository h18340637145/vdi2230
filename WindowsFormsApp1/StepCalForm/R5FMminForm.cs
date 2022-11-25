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
    public partial class R5FMminForm : BaseForm
    {
        R5 r5 = new R5();
        public R5FMminForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("f_kerf", 0, "最小夹紧力");
            dataGridView1.Rows.Add("phi", 0.013, "载荷系数" );
            dataGridView1.Rows.Add("fao", 24900 , "轴向载荷上限值");
            dataGridView1.Rows.Add("fZ", 3073, "嵌入损失");
            chooseBoltBtn.Visible = false;
            chooseMaterialBtn.Visible = false;
            CalBtn.Click += CalBtn_Click;

        }
        private void _setEveryPropFieldFromDataGridView()
        {
            foreach (var f in r5.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(r5, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }
        private void CalBtn_Click(object sender, EventArgs e)
        {
            _setEveryPropFieldFromDataGridView();
            R5 res = new R5(this.r5.f_kerf, this.r5.phi , this.r5.fao, this.r5.fZ);
            Result obj = new Result();
            obj.Fmmin = res.getFmmin();
            resGrid.SelectedObject = obj;
        }

        private class Result
        {
            [Category("计算结果")]
            [DisplayName("R5最小夹紧载荷FMmin")]
            [Description("")]
            public double Fmmin { get; set; }
        }
    }
}
