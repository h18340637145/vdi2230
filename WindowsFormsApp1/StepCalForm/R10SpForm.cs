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
    public partial class R10SpForm : BaseForm
    {
        R10 r10 = new R10();
        //BoltClass bolt;
        public R10SpForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("fmzul", 74947, "N许用装配预紧力");
            dataGridView1.Rows.Add("pG", 1300, "螺纹接触面最小摩擦系数");
            dataGridView1.Rows.Add("alpha", 1.5, "拧紧系数");
            dataGridView1.Rows.Add("FZ", 3073, "N嵌入损失载荷");
            dataGridView1.Rows.Add("f_sa_max", 24900, "N轴向载荷上限");

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
            R10 res = new R10(bolt, r10.fmzul, r10.pG, r10.alpha, r10.FZ, r10.f_sa_max);
            Result obj = new Result();

            // 添加选择框逻辑
            if (ifNut.Checked == true)
            {
                // 有nut
                // 查找当前螺栓的螺母
                NutClass nut = getNut(bolt);


                // 检查垫圈
                double hs = 0;
                if (ifGasket.Checked == true)
                {
                    // 有垫圈，需要填写垫圈厚度
                    if (HS.Text == "")
                    {
                        MessageBox.Show("请输入垫圈厚度");
                        return;
                    }
                    else
                    {
                        hs = Convert.ToDouble(HS.Text);
                    }
                }
                obj.Sp = res.getSp(hs, nut);
                obj.Spn = res.getSpn(hs, nut);
                obj.Sp_load = res.getSp_load(hs, nut);
                obj.Spn_load = res.getSpn_load(hs, nut);
            }
            else
            {
                // 没有螺母
                obj.Sp = res.getSp_nonut();
                obj.Sp_load = res.getSp_load_nonut();
            }

            resGrid.SelectedObject = null;
            resGrid.SelectedObject = obj;
        }

        private NutClass getNut(BoltClass bolt)
        {
            NutClass nut = new NutClass();
            string sql = "select dbo_BoltTable.isnut,dbo_BoltTable.nutIndex from dbo_BoltTable" +
                " where dbo_BoltTable.normalD_d=" + bolt.NormalD_d +
                " and dbo_BoltTable.screwP_P=" + bolt.ScrewP_P +
                " and dbo_BoltTable.boltLen_ls=" + bolt.BoltLen_ls +
                " and dbo_BoltTable.boreD_dh=" + bolt.BoreD_dh +
                " and dbo_BoltTable.boltHeadOutD_dw=" + bolt.BoltHeadOutD_dw +
                " and dbo_BoltTable.boltHeadInnerD_da=" + bolt.BoltHeadInnerD_da +
                " and dbo_BoltTable.screwMidD_d2=" + bolt.ScrewMidD_d2;
            MessageBox.Show(sql);
            Console.WriteLine(sql);
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            if (dr.Read())
            {
                string isnut, nutIndex;
                nutIndex = dr["nutIndex"].ToString();
                isnut = dr["isnut"].ToString();

                if (isnut.Equals("1"))
                {
                    //有螺母的
                    string sql2 = "select * from dbo_nutTable where nutIndex=" + nutIndex;
                    IDataReader dr2 = dao.read(sql2);

                    if (dr2.Read())
                    {
                        string nutSpeci, nutStd, nutNutSideWid, nutBearMinD, nutBearMaxD, nutBearOutD, nutHeight;
                        nutSpeci = dr2["nutSpeci"].ToString();
                        nutStd = dr2["nutStd"].ToString();
                        nutNutSideWid = dr2["nutNutSideWid_s"].ToString();
                        nutBearMinD = dr2["nutBearMinD_Damin"].ToString();
                        nutBearMaxD = dr2["nutBearMaxD_Damax"].ToString();
                        nutBearOutD = dr2["nutBearOutD_dwmu"].ToString();
                        nutHeight = dr2["nutHeight_m"].ToString();
                        nut.NutSpeci = nutSpeci;
                        nut.NutStd = nutStd;
                        nut.NutNutSideWid = double.Parse(nutNutSideWid);
                        nut.NutBearMinD = double.Parse(nutBearMinD);
                        nut.NutBearMaxD = double.Parse(nutBearMaxD);
                        nut.NutBearOutD = double.Parse(nutBearOutD);
                        nut.NutHeight = double.Parse(nutHeight);
                    }
                    dr2.Close();
                }
                dr.Close();
            }
            return nut;
        }

        private void _setEveryPropFieldFromDataGridView()
        {
            foreach (var f in r10.GetType().GetProperties())
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
                        f.SetValue(r10, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }
        private class Result
        {
            // 一般就是装配和工作，螺栓头的两个即可
            [Category("安全系数")]
            [DisplayName("R10螺栓头承载面表面压力安全系数")]
            [Description("装配状态螺栓头承载面表面压力安全系数R10")]
            public double Sp { get; set; }

            [Category("安全系数")]
            [DisplayName("R10螺栓头承载面压力安全系数")]
            [Description("螺栓头承载面工作状态表面压力安全系数R10")]
            public double Sp_load { get; set; }

            // 通孔螺栓的时候，在上述两个螺栓头之外，还有两个螺母的
            [Category("安全系数")]
            [DisplayName("R10表螺母面压力安全系数")]
            [Description("装配状态螺母表面压力安全系数R10")]
            public double Spn { get; set; }

            [Category("安全系数")]
            [DisplayName("R10螺母接触面表面压力安全系数")]
            [Description("螺母接触面工作状态表面压力安全系数R10")]
            public double Spn_load { get; set; }
        }

        private void ifGasket_CheckedChanged(object sender, EventArgs e)
        {
            if (ifGasket.Checked == true)
            {
                HS.Visible = true;
                label1.Visible = true;
            }
            else
            {
                HS.Visible = false;
                label1.Visible = false;

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
