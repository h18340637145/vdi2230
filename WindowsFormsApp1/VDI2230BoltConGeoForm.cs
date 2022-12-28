using CreateBotSpring;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Translators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Login;
using WindowsFormsApp1.ManagementBoltConn.Dialog;

namespace WindowsFormsApp1
{
    public partial class VDI2230BoltConGeoForm : Form
    {

        BoltChooseClass boltChooseClass;
        Bolt bolt;
        NutClass nut;
        GasketClass gasket;
        GasketClass gasket2;

        Entity _boltEntity;

        private string flag;

        public VDI2230BoltConGeoForm()
        {
            InitializeComponent();
        }

        public VDI2230BoltConGeoForm(string  flag)
        {
            this.flag = flag;
            InitializeComponent();
            AdminOrUser();
        }

        private void VDI2230BoltConGeoForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet22.dbo_screwTypeTable”中。您可以根据需要移动或删除它。
            this.dbo_screwTypeTableTableAdapter1.Fill(this.boltConnectionSystemDataSet22.dbo_screwTypeTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet13.dbo_boltStdTable”中。您可以根据需要移动或删除它。
            this.dbo_boltStdTableTableAdapter.Fill(this.boltConnectionSystemDataSet13.dbo_boltStdTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet12.dbo_boltSpeciTable”中。您可以根据需要移动或删除它。
            this.dbo_boltSpeciTableTableAdapter.Fill(this.boltConnectionSystemDataSet12.dbo_boltSpeciTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet11.dbo_boltTypeTable”中。您可以根据需要移动或删除它。
            this.dbo_boltTypeTableTableAdapter.Fill(this.boltConnectionSystemDataSet11.dbo_boltTypeTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet10.dbo_screwTypeTable”中。您可以根据需要移动或删除它。
            this.dbo_screwTypeTableTableAdapter.Fill(this.boltConnectionSystemDataSet10.dbo_screwTypeTable);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet6.boltStdTable”中。您可以根据需要移动或删除它。
            //this.boltStdTableTableAdapter.Fill(this.boltConnectionSystemDataSet6.boltStdTable);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet5.screwTypeTable”中。您可以根据需要移动或删除它。
            //this.screwTypeTableTableAdapter1.Fill(this.boltConnectionSystemDataSet5.screwTypeTable);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet4.boltTypeTable”中。您可以根据需要移动或删除它。
            //this.boltTypeTableTableAdapter1.Fill(this.boltConnectionSystemDataSet4.boltTypeTable);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet3.BoltTable”中。您可以根据需要移动或删除它。
            //this.boltTableTableAdapter.Fill(this.boltConnectionSystemDataSet3.BoltTable);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet2.boltSpeciTable”中。您可以根据需要移动或删除它。
            //this.boltSpeciTableTableAdapter.Fill(this.boltConnectionSystemDataSet2.boltSpeciTable);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet1.boltTypeTable”中。您可以根据需要移动或删除它。
            //this.boltTypeTableTableAdapter.Fill(this.boltConnectionSystemDataSet1.boltTypeTable);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet.screwTypeTable”中。您可以根据需要移动或删除它。
            //this.screwTypeTableTableAdapter.Fill(this.boltConnectionSystemDataSet.screwTypeTable);
            SelScrewType();
            SelBoltType();
            SelBoltSpeci();
            SelBoltStd();
        }

        private void SelBoltStd()
        {
            string sql = "select boltstd from dbo_boltStdTable";
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string boltStdValue = dr["boltStd"].ToString();
                boltStd.Items.Add(boltStdValue);
            }
            dr.Close();
        }

        private void SelBoltSpeci()
        {
            string sql = "select boltspeci from dbo_boltSpeciTable";
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string boltspeciValue = dr["boltspeci"].ToString();
                boltSpeci.Items.Add(boltspeciValue);
            }
            dr.Close();
        }

        private void SelBoltType()
        {
            string sql = "select bolttype from dbo_boltTypeTable";
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string bolttypeValue = dr["bolttype"].ToString();
                boltType.Items.Add(bolttypeValue);
            }
            dr.Close();
        }

        private void SelScrewType()
        {
            string sql = "select screwType from dbo_screwTypeTable";
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string screwTypeValue = dr["screwType"].ToString();
                screwType.Items.Add(screwTypeValue);
            }
            dr.Close();
        }

        private void AdminOrUser()
        {
            if (flag.Equals("1"))
            {
                // 管理员
                screwTypeBtn.Visible = true;
                boltTypeBtn.Visible = true;
                boltSpeciBtn.Visible = true;
                boltStdBtn.Visible = true;
                addBtn.Visible = true;

                // 文本可编辑
                TextEnable();
            }
            else
            {

            }
        }

        private void TextEnable()
        {
            gasketGroup.Visible = true;
            nutGroup.Visible = true;

            boltLen.ReadOnly = false;
            normalD.ReadOnly = false;
            screwP.ReadOnly = false;
            boreD.ReadOnly = false;
            boltHeadOutD.ReadOnly = false;
            boltHeadInnerD.ReadOnly = false;
            screwMidD.ReadOnly = false;
            screwMinD.ReadOnly = false;
            polishRodLen.ReadOnly = false;
            boltNutSideWid.ReadOnly = false;
            boltNutScrewMinD.ReadOnly = false;

            nutSpeci.ReadOnly = false;
            nutStd.ReadOnly = false;
            nutNutSideWid.ReadOnly = false;
            nutBearMinD.ReadOnly = false;
            nutBearMaxD.ReadOnly = false;
            nutBearOutD.ReadOnly = false;
            nutHeight.ReadOnly = false;

            gasketstd.ReadOnly = false;
            gasketinnerD_dhas.ReadOnly = false;
            gasketoutD_DA.ReadOnly = false;
            boltheaddowngasketheight_hs1.ReadOnly = false;
            nutdowngasketheight_hs2.ReadOnly = false;
            //10377
        }

        private void seeButton_Click(object sender, EventArgs e)
        {
            string screwTypeString = screwType.Text;
            string boltTypeString = boltType.Text;
            string boltSpeciString = boltSpeci.Text;
            string boltStdString = boltStd.Text;

            boltLen.Clear();
            normalD.Clear();
            screwP.Clear();
            boreD.Clear();
            boltHeadOutD.Clear();
            boltHeadInnerD.Clear();
            screwMidD.Clear();
            screwMinD.Clear();
            polishRodLen.Clear();
            boltNutSideWid.Clear();
            boltNutScrewMinD.Clear();
            nutSpeci.Clear();
            nutStd.Clear();
            nutNutSideWid.Clear();
            nutBearMinD.Clear();
            nutBearMaxD.Clear();
            nutBearOutD.Clear();
            nutHeight.Clear();
            gasketstd.Clear();
            gasketinnerD_dhas.Clear();
            gasketoutD_DA.Clear();
            boltheaddowngasketheight_hs1.Clear();
            nutdowngasketheight_hs2.Clear();


            if (screwTypeString == null || boltTypeString == null || boltSpeciString == null || boltStdString == null)
            {
                MessageBox.Show("数据不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (screwTypeString == "" || boltTypeString == "" || boltSpeciString == "" || boltStdString == "" )
            {
                MessageBox.Show("数据不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string sql = "select * from ((((((dbo_BoltTable inner join dbo_boltSpeciTable on dbo_boltSpeciTable.boltSpeciIndex=dbo_BoltTable.boltSpeci) " +
                    "inner join dbo_boltStdTable on dbo_boltStdTable.boltStdIndex=dbo_BoltTable.boltStd) " +
                    "inner join dbo_boltTypeTable on dbo_boltTypeTable.boltTypeIndex=dbo_BoltTable.boltType) " +
                    "inner join dbo_screwTypeTable on dbo_screwTypeTable.screwTypeIndex=dbo_BoltTable.screwType) " +
                    "inner join dbo_nutTable on dbo_nutTable.nutIndex=dbo_BoltTable.nutIndex) " +
                    "inner join dbo_gasketTable on dbo_gasketTable.gasketIndex=dbo_BoltTable.gasketIndex) " +
                    "where dbo_screwTypeTable.screwType='" + screwTypeString + "' and dbo_boltTypeTable.boltType='" + boltTypeString + "' and dbo_boltSpeciTable.boltSpeci='"
                    + boltSpeciString + "' and dbo_boltStdTable.boltStd='" + boltStdString + "'";
                MessageBox.Show(sql);
                DaoAccess dao = new DaoAccess();
                IDataReader dr = dao.read(sql);
                if (dr.Read())
                {
                    string normalD_d, screwP_P, boltLen_ls, boreD_dh, boltHeadOutD_dw, boltHeadInnerD_da,
                        screwMidD_d2, screwMinD_d3, polishRodLen_l1, boltNutSideWid_s, boltNutScrewMinD_D1;
                    string isnut, isgasket, nutIndex , gasketIndex;
                    normalD_d = dr["normalD_d"].ToString();
                    screwP_P = dr["screwP_P"].ToString();
                    boltLen_ls = dr["boltLen_ls"].ToString();
                    boreD_dh = dr["boreD_dh"].ToString();
                    boltHeadOutD_dw = dr["boltHeadOutD_dw"].ToString();
                    boltHeadInnerD_da = dr["boltHeadInnerD_da"].ToString();
                    screwMidD_d2 = dr["screwMidD_d2"].ToString();
                    screwMinD_d3 = dr["screwMinD_d3"].ToString();
                    polishRodLen_l1 = dr["polishRodLen_l1"].ToString();
                    boltNutSideWid_s = dr["boltNutSideWid_s"].ToString();
                    boltNutScrewMinD_D1 = dr["boltNutScrewMinD_D1"].ToString();
                    gasketIndex = dr["dbo_gaskettable.gasketIndex"].ToString();
                    nutIndex = dr["dbo_nuttable.nutIndex"].ToString();
                    isnut = dr["isnut"].ToString();
                    isgasket = dr["isgasket"].ToString();

                    boltChooseClass = new BoltChooseClass();
                    boltChooseClass.NormalD_d = double.Parse(normalD_d);
                    boltChooseClass.ScrewP_P = double.Parse(screwP_P);
                    boltChooseClass.BoltLen_ls = double.Parse(boltLen_ls);
                    boltChooseClass.BoreD_dh = double.Parse(boreD_dh);
                    boltChooseClass.BoltHeadOutD_dw = double.Parse(boltHeadOutD_dw);
                    boltChooseClass.BoltHeadInnerD_da = double.Parse(boltHeadInnerD_da);
                    boltChooseClass.ScrewMidD_d2 = double.Parse(screwMidD_d2);
                    boltChooseClass.ScrewMinD_d3 = double.Parse(screwMinD_d3);
                    boltChooseClass.PolishRodLen_l1 = double.Parse(polishRodLen_l1);
                    boltChooseClass.BoltNutSideWid_s = double.Parse(boltNutSideWid_s);
                    boltChooseClass.BoltNutScrewMinD_D1 = double.Parse(boltNutScrewMinD_D1);

                    string[] str = { normalD_d, screwP_P, boltLen_ls, boreD_dh, boltHeadOutD_dw, boltHeadInnerD_da,
                        screwMidD_d2, screwMinD_d3, polishRodLen_l1, boltNutSideWid_s, boltNutScrewMinD_D1 };
                    

                    if (isnut.Equals("1"))
                    {
                        nutGroup.Visible = true;
                        nut = new NutClass();
                        //有螺母的
                        string sql2 = "select * from dbo_nutTable where nutIndex=" + nutIndex;
                        IDataReader dr2 = dao.read(sql2);
                        if (dr2.Read())
                        {
                            string nutSpeci, nutStd, nutNutSideWid, nutBearMinD, nutBearMaxD, nutBearOutD, nutHeight;
                            nutSpeci = dr["nutSpeci"].ToString();
                            nutStd = dr["nutStd"].ToString();
                            nutNutSideWid = dr["nutNutSideWid_s"].ToString();
                            nutBearMinD = dr["nutBearMinD_Damin"].ToString();
                            nutBearMaxD = dr["nutBearMaxD_Damax"].ToString();
                            nutBearOutD = dr["nutBearOutD_dwmu"].ToString();
                            nutHeight = dr["nutHeight_m"].ToString();

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
                    else
                    {
                        nutGroup.Visible = false;
                        nut = null;
                    }
                    if (isgasket.Equals("1"))
                    {
                        gasket = new GasketClass();
                        gasketGroup.Visible = true;
                        //有垫片的
                        string sql3 = "select * from dbo_gasketTable where gasketindex=" + gasketIndex;
                        IDataReader dr3 = dao.read(sql3);
                        if (dr3.Read())
                        {
                            string gasketstd, gasketinnerD_dhas, gasketoutD_DA, boltheaddowngasketheight_hs1, nutdowngasketheight_hs2;
                            gasketstd = dr["gasketstd"].ToString();
                            gasketinnerD_dhas = dr["gasketinnerD_dhas"].ToString();
                            gasketoutD_DA = dr["gasketoutD_DA"].ToString();
                            boltheaddowngasketheight_hs1 = dr["boltheaddowngasketheight_hs1"].ToString();
                            nutdowngasketheight_hs2 = dr["nutdowngasketheight_hs2"].ToString();

                            gasket.Gasketstd = gasketstd;
                            gasket.GasketinnerD_dhas = double.Parse(gasketinnerD_dhas);
                            gasket.GasketoutD_DA = double.Parse(gasketoutD_DA);
                            gasket.Boltheaddowngasketheight_hs1 = double.Parse(boltheaddowngasketheight_hs1);
                            gasket.Nutdowngasketheight_hs2 = double.Parse(nutdowngasketheight_hs2);
                        }
                        dr3.Close();
                        gasket.offsetz = boltChooseClass.BoltLen_ls - gasket.Boltheaddowngasketheight_hs1;
                        if (nut != null)
                        {
                            gasket2 = new GasketClass(gasket);
                            gasket2.offsetz = boltChooseClass.BoltLen_ls - gasket.Boltheaddowngasketheight_hs1 * 2;
                        }
                    }
                    else
                    {
                        gasket = null;
                        gasket2 = null;
                        gasketGroup.Visible = false;
                    }
                }
                dr.Close();//关闭连接
                ShowText();
            }

            if (nut != null)
            {
                if (gasket != null)
                {
                    nut.Offsetz = boltChooseClass.BoltLen_ls - gasket.Boltheaddowngasketheight_hs1 - nut.NutHeight;
                }
                else
                {
                    nut.Offsetz = boltChooseClass.BoltLen_ls - nut.NutHeight;
                }
            }

            showBoltModel(Color.Red);
            showGasketModel(gasket, Color.Cyan);
            if (gasket2 != null)
            {
                showGasketModel(gasket2, Color.Cyan);
            }
            showNutModel(Color.Red);
        }

        private void ShowText()
        {
            boltLen.Text = boltChooseClass.BoltLen_ls.ToString();
            normalD.Text = boltChooseClass.NormalD_d.ToString();
            screwP.Text = boltChooseClass.ScrewP_P.ToString(); 
            boreD.Text = boltChooseClass.BoreD_dh.ToString(); 
            boltHeadOutD.Text = boltChooseClass.BoltHeadOutD_dw.ToString(); 
            boltHeadInnerD.Text = boltChooseClass.BoltHeadInnerD_da.ToString(); 
            screwMidD.Text = boltChooseClass.ScrewMidD_d2.ToString(); 
            screwMinD.Text = boltChooseClass.BoltNutScrewMinD_D1.ToString(); 
            polishRodLen.Text = boltChooseClass.PolishRodLen_l1.ToString(); 
            boltNutSideWid.Text = boltChooseClass.BoltNutSideWid_s.ToString(); 
            boltNutScrewMinD.Text = boltChooseClass.BoltNutScrewMinD_D1.ToString();

            if (nutGroup.Visible == true)
            {
                this.nutSpeci.Text = nut.NutSpeci;
                this.nutStd.Text = nut.NutStd;
                this.nutNutSideWid.Text = nut.NutNutSideWid.ToString();
                this.nutBearMinD.Text = nut.NutBearMinD.ToString();
                this.nutBearMaxD.Text = nut.NutBearMaxD.ToString();
                this.nutBearOutD.Text = nut.NutBearOutD.ToString();
                this.nutHeight.Text = nut.NutHeight.ToString();
            }
            else
            {

            }

            if (gasketGroup.Visible == true)
            {
                this.gasketstd.Text = gasket.Gasketstd;
                this.gasketinnerD_dhas.Text = gasket.GasketinnerD_dhas.ToString();
                this.gasketoutD_DA.Text = gasket.GasketoutD_DA.ToString();
                this.boltheaddowngasketheight_hs1.Text = gasket.Boltheaddowngasketheight_hs1.ToString();
                this.nutdowngasketheight_hs2.Text = gasket.Nutdowngasketheight_hs2.ToString();
            }
            else
            {

            }
        }

        // 螺栓模型 换螺栓
        private void showBoltModel(Color color)
        {
            bolt = new Bolt(this.boltChooseClass);
            // 第一次调用是在update  选择螺栓数据中new的Bolt(boltChooseClass)
            if (boltChooseClass == null)
            {
                throw new Exception("bolt is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;
            try
            {
                _boltEntity = bolt.GetEntity();
                model1.Entities.Add(_boltEntity, color);
                model1.ZoomFit();
                model1.Invalidate();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }

            
        }

        private void showNutModel(Color color)
        {
            if (nut == null )
            {
                throw new Exception("nut is null");
            }
            //model1.Entities.Clear();
            //model1.Enabled = true;
            try
            {
                Entity nutEntity = nut.GetEntity();
                model1.Entities.Add(nutEntity, color);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }

        private void showGasketModel(GasketClass myGasket, Color color)
        {
            // 只有螺栓头，一个垫片
            if (myGasket == null)
            {
                throw new Exception("_gasket is null");
            }
            try
            {
                Entity entity = myGasket.GetEntity();
                model1.Entities.Add(entity, color);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void screwTypeBtn_Click(object sender, EventArgs e)
        {
            ScrewTypeFrm s = new ScrewTypeFrm();
            s.Show();
        }

        private void boltTypeBtn_Click(object sender, EventArgs e)
        {
            BoltTypeFrm s = new BoltTypeFrm();
            s.Show();

        }

        private void boltSpeciBtn_Click(object sender, EventArgs e)
        {
            BoltSpeciFrm s = new BoltSpeciFrm();
            s.Show();
        }

        private void boltStdBtn_Click(object sender, EventArgs e)
        {
            BoltStdFrm s = new BoltStdFrm();
            s.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            BoltClass boltClass = new BoltClass();
            GasketClass gasketClass = new GasketClass();
            NutClass nutClass = new NutClass();
            int screwIdx = screwType.SelectedIndex + 1;
            int boltTypeIdx = boltType.SelectedIndex + 1;
            int boltSpecIdx = boltSpeci.SelectedIndex + 1;
            int boltStdIdx = boltStd.SelectedIndex + 1;

            boltClass.NormalD_d = double.Parse(normalD.Text);
            boltClass.BoltLen_ls = double.Parse(boltLen.Text);
            boltClass.ScrewP_P = double.Parse(screwP.Text);
            boltClass.BoreD_dh = double.Parse(boreD.Text);
            boltClass.BoltHeadOutD_dw = double.Parse(boltHeadOutD.Text);
            boltClass.BoltHeadInnerD_da = double.Parse(boltHeadInnerD.Text);
            boltClass.ScrewMidD_d2 = double.Parse(screwMidD.Text);
            boltClass.ScrewMinD_d3 = double.Parse(screwMinD.Text);
            boltClass.PolishRodLen_l1 = double.Parse(polishRodLen.Text);
            boltClass.BoltNutSideWid_s = double.Parse(boltNutSideWid.Text);
            boltClass.BoltNutScrewMinD_D1 = double.Parse(boltNutScrewMinD.Text);

            gasketClass.Gasketstd = gasketstd.Text;
            gasketClass.GasketinnerD_dhas = double.Parse(gasketinnerD_dhas.Text);
            gasketClass.GasketoutD_DA = double.Parse(gasketoutD_DA.Text);
            gasketClass.Boltheaddowngasketheight_hs1 = double.Parse(boltheaddowngasketheight_hs1.Text);
            gasketClass.Nutdowngasketheight_hs2 = double.Parse(nutdowngasketheight_hs2.Text);

            nutClass.NutSpeci = nutSpeci.Text;
            nutClass.NutStd = nutStd.Text;
            nutClass.NutNutSideWid = double.Parse(nutNutSideWid.Text);
            nutClass.NutBearMinD = double.Parse(nutBearMinD.Text);
            nutClass.NutBearMaxD = double.Parse(nutBearMaxD.Text);
            nutClass.NutBearOutD = double.Parse(nutBearOutD.Text);
            nutClass.NutHeight = double.Parse(nutHeight.Text);

            DaoAccess daoAccess = new DaoAccess();
            string sql2 = "insert into dbo_gaskettable(gasketstd,gasketinnerD_dhas,gasketoutD_DA,boltheaddowngasketheight_hs1,nutdowngasketheight_hs2) " +
                    "values('" + gasketClass.Gasketstd + "'," + gasketClass.GasketinnerD_dhas + "," + gasketClass.GasketoutD_DA + "," 
                    + gasketClass.Boltheaddowngasketheight_hs1 +","+
                    gasketClass.Nutdowngasketheight_hs2 + ")";
            int i = daoAccess.Excute(sql2);
            if (i != 0)
            {
                MessageBox.Show("插入垫片成功");
            }

            string sql3 = "insert into dbo_NUTtable(nutSpeci,nutStd,nutNutSideWid_s,nutBearMinD_Damin,nutBearMaxD_Damax,nutBearOutD_dwmu,nutHeight_m) " +
                "values('" + nutClass.NutSpeci + "','" + nutClass.NutStd + "'," + nutClass.NutNutSideWid + "," 
                + nutClass.NutBearMinD + "," + nutClass.NutBearMaxD + "," + 
                nutClass.NutBearOutD + "," + nutClass.NutHeight + ")";
            i = daoAccess.Excute(sql3);
            if (i != 0)
            {
                MessageBox.Show("插入螺母成功");
            }




            if (gasketstd.Text != "" && nutSpeci.Text != null)
            {
                int isnut = 1;
                int isgasket = 1;
                string sql_nut = "select nutindex from dbo_NUTtable where nutSpeci='" + nutClass.NutSpeci + "' and nutStd='" 
                    + nutClass.NutStd + "' and nutNutSideWid_s=" +
                    nutClass.NutNutSideWid + " and nutBearMinD_Damin=" + nutClass.NutBearMinD + " and nutBearMaxD_Damax=" 
                    + nutClass.NutBearMaxD + " and nutHeight_m=" + nutClass.NutHeight;
                string sql_gasket = "select gasketindex from dbo_gaskettable where gasketstd='" + gasketClass.Gasketstd 
                    + "' and gasketinnerD_dhas=" + gasketClass.GasketinnerD_dhas +
                    " and gasketoutD_DA=" + gasketClass.GasketoutD_DA + " and nutdowngasketheight_hs2=" +
                    gasketClass.Nutdowngasketheight_hs2;

                IDataReader dr3 = daoAccess.read(sql_nut);
                string nutIndex = "";
                string gasketIndex = "";
                while (dr3.Read())
                {
                    nutIndex = dr3["nutindex"].ToString();
                }
                dr3.Close();
                dr3 = daoAccess.read(sql_gasket);
                while (dr3.Read())
                {
                    gasketIndex = dr3["gasketindex"].ToString();
                }
                dr3.Close();

                string sql = "insert into dbo_BoltTable(screwType,boltType,boltSpeci,boltStd," +
                    "normalD_d,screwP_P,boltLen_ls,boreD_dh,boltHeadOutD_dw,boltHeadInnerD_da," +
                    "screwMidD_d2,screwMinD_d3,polishRodLen_l1,boltNutSideWid_s,boltNutScrewMinD_D1," +
                    "isnut,isgasket,nutindex,gasketindex) values(" +
                    screwIdx + "," + boltTypeIdx + "," + boltSpecIdx + "," + boltStdIdx + "," +
                    boltClass.NormalD_d + "," + boltClass.ScrewP_P + "," + boltClass.BoltLen_ls + "," + boltClass.BoreD_dh + "," + boltClass.BoltHeadOutD_dw + "," +
                    boltClass.BoltHeadInnerD_da + "," + boltClass.ScrewMidD_d2 + "," + boltClass.ScrewMinD_d3 + "," + boltClass.PolishRodLen_l1 + "," +
                    boltClass.BoltNutSideWid_s + "," + boltClass.BoltNutScrewMinD_D1 + "," + isnut + "," + isgasket + "," + nutIndex + "," + gasketIndex + ")";
                int k = daoAccess.Excute(sql);
                if (k != 0)
                {
                    MessageBox.Show("插入螺栓成功");
                }

            }
        }

        private void 读取ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             JavaScriptSerializer serializer = new JavaScriptSerializer();

        // strFileName 是文件的路径+文件名
        string strFileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON文件(*.json)|*.json";
            ofd.ValidateNames = true; // 验证用户输入是否是一个有效的Windows文件名
            ofd.CheckFileExists = true; //验证路径的有效性
            ofd.CheckPathExists = true;//验证路径的有效性
            if (ofd.ShowDialog() == DialogResult.OK) //用户点击确认按钮，发送确认消息
            {
                strFileName = ofd.FileName;//获取在文件对话框中选定的路径或者字符串
            }
            try
            {
                string JSONstring = File.ReadAllText(strFileName);
                VdiSaveClass s = serializer.Deserialize<VdiSaveClass>(JSONstring);
                screwType.Text = s.screwType;
                boltType.Text = s.boltType;
                boltSpeci.Text = s.boltSpeci;
                boltStd.Text = s.boltStd;
                boltLen.Text = s.boltLen;
                normalD.Text = s.normalD;
                screwP.Text = s.screwP;
                boreD.Text = s.boreD;
                boltHeadOutD.Text = s.boltHeadOutD;
                boltHeadInnerD.Text = s.boltHeadInnerD;
                screwMidD.Text = s.screwMidD;
                screwMinD.Text = s.screwMinD;
                polishRodLen.Text = s.polishRodLen;
                boltNutSideWid.Text = s.boltNutSideWid;
                boltNutScrewMinD.Text = s.boltNutScrewMinD;
                gasketstd.Text = s.gasketstd;
                gasketinnerD_dhas.Text = s.gasketinnerD_dhas;
                gasketoutD_DA.Text = s.gasketoutD_DA;
                boltheaddowngasketheight_hs1.Text = s.boltheaddowngasketheight_hs1;
                nutdowngasketheight_hs2.Text = s.nutdowngasketheight_hs2;
                nutSpeci.Text = s.nutSpeci;
                nutStd.Text = s.nutStd;
                nutNutSideWid.Text = s.nutNutSideWid;
                nutBearMinD.Text = s.nutBearMinD;
                nutBearMaxD.Text = s.nutBearMaxD;
                nutBearOutD.Text = s.nutBearOutD;
                nutHeight.Text = s.nutHeight;
            }
            catch (Exception)
            {
                MessageBox.Show("未读取数据,请重新输入");
                return;
            }
        }

        private void 暂存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // strFileName 是文件的路径+文件名
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON文件(*.json)|*.json";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //设置默认的文件名
            sfd.FileName = "YourFileName";
            string localFilePath = "";
            string fileNameExt = "";
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径
            }

            VdiSaveClass s = new VdiSaveClass();
            s.screwType = screwType.Text;
            s.boltType = boltType.Text;
            s.boltSpeci = boltSpeci.Text;
            s.boltStd = boltStd.Text;
            s.boltLen = boltLen.Text;
            s.normalD = normalD.Text;
            s.screwP = screwP.Text;
            s.boreD = boreD.Text;
            s.boltHeadOutD = boltHeadOutD.Text;
            s.boltHeadInnerD = boltHeadInnerD.Text;
            s.screwMidD = screwMidD.Text;
            s.screwMinD = screwMinD.Text;
            s.polishRodLen = polishRodLen.Text;
            s.boltNutSideWid = boltNutSideWid.Text;
            s.boltNutScrewMinD = boltNutScrewMinD.Text;
            s.gasketstd = gasketstd.Text;
            s.gasketinnerD_dhas = gasketinnerD_dhas.Text;
            s.gasketoutD_DA = gasketoutD_DA.Text;
            s.boltheaddowngasketheight_hs1 = boltheaddowngasketheight_hs1.Text;
            s.nutdowngasketheight_hs2 = nutdowngasketheight_hs2.Text;
            s.nutSpeci = nutSpeci.Text;
            s.nutStd = nutStd.Text;
            s.nutNutSideWid = nutNutSideWid.Text;
            s.nutBearMinD = nutBearMinD.Text;
            s.nutBearMaxD = nutBearMaxD.Text;
            s.nutBearOutD = nutBearOutD.Text;
            s.nutHeight = nutHeight.Text;

            try
            {
                string out1 = serializer.Serialize(s);
                File.WriteAllText(localFilePath, out1);
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败，请检查！");
                return;
            }
        }
    }
}
