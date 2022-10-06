using CreateBotSpring;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Translators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Entity _nutEntity;
        Entity _gaskEntity;

        public VDI2230BoltConGeoForm()
        {
            InitializeComponent();
        }

        private void VDI2230BoltConGeoForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet6.boltStdTable”中。您可以根据需要移动或删除它。
            this.boltStdTableTableAdapter.Fill(this.boltConnectionSystemDataSet6.boltStdTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet5.screwTypeTable”中。您可以根据需要移动或删除它。
            this.screwTypeTableTableAdapter1.Fill(this.boltConnectionSystemDataSet5.screwTypeTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet4.boltTypeTable”中。您可以根据需要移动或删除它。
            this.boltTypeTableTableAdapter1.Fill(this.boltConnectionSystemDataSet4.boltTypeTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet3.BoltTable”中。您可以根据需要移动或删除它。
            this.boltTableTableAdapter.Fill(this.boltConnectionSystemDataSet3.BoltTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet2.boltSpeciTable”中。您可以根据需要移动或删除它。
            this.boltSpeciTableTableAdapter.Fill(this.boltConnectionSystemDataSet2.boltSpeciTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet1.boltTypeTable”中。您可以根据需要移动或删除它。
            this.boltTypeTableTableAdapter.Fill(this.boltConnectionSystemDataSet1.boltTypeTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet.screwTypeTable”中。您可以根据需要移动或删除它。
            this.screwTypeTableTableAdapter.Fill(this.boltConnectionSystemDataSet.screwTypeTable);

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
                string sql = "select * from BoltTable join boltSpeciTable on boltSpeciTable.boltSpeciIndex=BoltTable.boltSpeci " +
                    "join boltStdTable on boltStdTable.boltStdIndex=BoltTable.boltStd " +
                    "join boltTypeTable on boltTypeTable.boltTypeIndex=BoltTable.boltType " +
                    "join screwTypeTable on screwTypeTable.screwTypeIndex=BoltTable.screwType " +
                    "join nutTable on nutTable.nutIndex=BoltTable.nutIndex " +
                    "join gasketTable on gasketTable.gasketIndex=BoltTable.gasketIndex " +
                    "where screwTypeTable.screwType='" + screwTypeString + "' and boltTypeTable.boltType='" + boltTypeString + "' and boltSpeciTable.boltSpeci='"
                    + boltSpeciString + "' and boltStdTable.boltStd='" + boltStdString + "'";
                MessageBox.Show(sql);
                Dao dao = new Dao();
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
                    
                    isnut = dr["isnut"].ToString();
                    isgasket = dr["isgasket"].ToString();
                    if (isnut.Equals("1"))
                    {
                        nutGroup.Visible = true;
                        nut = new NutClass();
                        //有螺母的
                        nutIndex = dr["nutIndex"].ToString();
                        string sql2 = "select * from nutTable where nutIndex='" + nutIndex + "'";
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
                        gasketIndex = dr["gasketIndex"].ToString();
                        string sql3 = "select * from gasketTable where gasketindex='" + gasketIndex + "'";
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
    }
}
