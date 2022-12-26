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
    public partial class R7FMzulForm :  BaseForm
    {
        R7 r7 = new R7();
        //BoltClass bolt;
        public R7FMzulForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("v", 0.9, "拧紧时材料的屈服点利用率");
            dataGridView1.Rows.Add("Ugmin", 0.1, "螺纹接触面最小摩擦系数");

            CalBtn.Click += CalBtn_Click;
        }

        private void CalBtn_Click(object sender, EventArgs e)
        {
            _setEveryPropFieldFromDataGridView();
            if (bolt == null)
            {
                MessageBox.Show("请选择螺栓");
                return ;
            }
            if (material == null)
            {
                MessageBox.Show("请选择材料");
                return;
            }
            R7 res = new R7(bolt, r7.Ugmin, r7.v);
            Result obj = new Result();
            obj.Fmzul = res.getFmzul();
            obj.Ftab = res.getF_mtb();
            resGrid.SelectedObject = null;
            resGrid.SelectedObject = obj;
        }

        private void _setEveryPropFieldFromDataGridView()
        {
            foreach (var f in r7.GetType().GetProperties())
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
                        f.SetValue(r7, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private class Result
        {
            [Category("计算结果")]
            [DisplayName("R7许用装配预紧力Fmzul")]
            [Description("")]
            public double Fmzul { get; set; }

            [Category("计算结果")]
            [DisplayName("R7查表结果Fmzul")]
            [Description("")]
            public double Ftab { get; set; }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
