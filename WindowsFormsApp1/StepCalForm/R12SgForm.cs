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
    
    public partial class R12SgForm : Form
    {
        R12 r12 = new R12();
        JianLi jianli = new JianLi();

        public R12SgForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("fmzul", 74947, "许用装配预紧力");
            dataGridView1.Rows.Add("alpha", 1.5, "拧紧系数");
            dataGridView1.Rows.Add("phi", 0.014, "载荷系数");
            dataGridView1.Rows.Add("fao", 24900, "拧紧时材料的屈服点利用率");
            dataGridView1.Rows.Add("fZ", 4420, "螺纹接触面最小摩擦系数");

            dataGridView2.Rows.Add("f_qmax", 200, "横向剪力");
            dataGridView2.Rows.Add("q_f", 1, "接合面数量");
            dataGridView2.Rows.Add("u_Tmin", 0.1, "连接件间最小摩擦系数");
            dataGridView2.Rows.Add("m_t", 20, "绕螺栓轴扭矩");
            dataGridView2.Rows.Add("q_m", 1, "转矩传递结合面数量");
            dataGridView2.Rows.Add("ra", 25, "摩擦半径");

            CalBtn.Click += CalBtn_Click;
            chooseBoltBtn.Click += chooseBoltBtn_Click;
            chooseMaterialBtn.Click += chooseMaterialBtn_Click;
        }
        public BoltClass bolt;
        public BoltMaterialClass material;
        BoltChooseForm boltfrm;
        StrengthGradeForm materialFrm;
        private void chooseBoltBtn_Click(object sender, EventArgs e)
        {
            if (boltfrm == null)
            {
                boltfrm = new BoltChooseForm();
            }

            boltfrm.ShowDialog();
            bolt = boltfrm.getBolt();
            if (bolt == null)
            {
                return;
            }
        }

        private void chooseMaterialBtn_Click(object sender, EventArgs e)
        {
            if (bolt == null)
            {
                MessageBox.Show("请先选择螺栓");
                return;
            }
            if (materialFrm == null)
            {
                materialFrm = new StrengthGradeForm();
            }

            materialFrm.ShowDialog();
            material = materialFrm.getMaterial();
            if (material == null)
            {
                return;
            }
            bolt.boltMaterial = material;
        }
        private void CalBtn_Click(object sender, EventArgs e)
        {
            _setEveryPropFieldFromDataGridView();
            _setEveryPropFieldFromDataGridView2();
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
            R12 res = new R12(bolt, r12.fmzul, r12.alpha, r12.phi, r12.fao, r12.fZ);
            Result obj = new Result();
            obj.sgoll = res.getSg(jianli.f_qmax, jianli.q_f,jianli.u_Tmin, jianli.m_t,jianli.q_m, jianli.ra);
            obj.Sa = res.getSa(bolt.boltMaterial.BoltMaterialRm, jianli.f_qmax);
            //obj.sgoll = res.sgoll();
            //obj.Ftab = res.getF_mtb();
            resGrid.SelectedObject = null;
            resGrid.SelectedObject = obj;
        }

        private void _setEveryPropFieldFromDataGridView2()
        {
            foreach (var f in jianli.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["parameters"] != null && (string)row.Cells["parameters"].Value == propName)
                    {
                        var obj = row.Cells["values"].Value;
                        f.SetValue(jianli, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void _setEveryPropFieldFromDataGridView()
        {
            foreach (var f in r12.GetType().GetProperties())
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
                        f.SetValue(r12, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }
        private class Result
        {
            [Category("安全系数")]
            [DisplayName("R12滑动安全系数")]
            [Description("抗滑移安全验证")]
            public double sgoll { get; set; }

            [Category("安全系数")]
            [DisplayName("R12剪切安全系数")]
            [Description("抗剪切安全验证，无剪力的时候可以忽略")]
            public double Sa { get; set; }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
