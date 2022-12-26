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
    public partial class R13MAForm : BaseForm   
    {
        R13 r13 = new R13();
        public R13MAForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("da", 12, "头部支撑面内径");
            dataGridView1.Rows.Add("ukmin", 0.1, "螺栓头承载面最小摩擦系数");
            dataGridView1.Rows.Add("ugmin", 0.1, "螺纹接触面最小摩擦系数");
            dataGridView1.Rows.Add("fmzul", 75947, "许用装配预紧力");

            chooseMaterialBtn.Visible = false;

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
            
            R13 res = new R13(bolt, r13.da, r13.ukmin, r13.ugmin, r13.fmzul);
            Result obj = new Result();
            obj.Ma = res.getMA();
            resGrid.SelectedObject = null;
            resGrid.SelectedObject = obj;
        }

        private void _setEveryPropFieldFromDataGridView()
        {
            foreach (var f in r13.GetType().GetProperties())
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
                        f.SetValue(r13, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private class Result
        {
            [Category("计算结果")]
            [DisplayName("R13必要拧紧力矩")]
            [Description("必要拧紧力矩R13")]
            public double Ma { get; set; }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
