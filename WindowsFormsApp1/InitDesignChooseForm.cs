using CreateBotSpring;
using devDept.Eyeshot.Entities;
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
    public partial class InitDesignChooseForm : Form
    {
        // 模型相关
        BoltChooseClass boltChooseClass;
        Bolt bolt;
        private Entity _boltEntity;

        public InitDesignChooseForm()
        {
            InitializeComponent();
        }
        // 强度等级和直径
        string[] initstr = new string[2];
        // 螺纹类型，螺栓类型，螺栓规格
        string[] type = new string[4];

        public InitDesignChooseForm(string[] str, string[] type_copy)
        {
            InitializeComponent();
            // 接受参数， 强度等级和直径
            for (int i = 0; i < 2; i++)
            {
                initstr[i] = str[i];
            }
            for (int i = 0; i < 4; i++)
            {
                type[i] = type_copy[i];
            }
            dataGridView1.Rows.Clear();
            //string sql = "select * from strengthGradeAndDN where force=" + force;
            // 根据传入的信息 ， 查数据库  显示数据的名称，标准  d ls  l1  l2 dt  dh
            string sql = "select dbo_boltSpeciTable.boltSpeci as speci,dbo_boltStdTable.boltStd as std,dbo_BoltTable.normalD_d as DN, " +
                "dbo_BoltTable.boltLen_ls as ls,dbo_BoltTable.polishRodLen_l1 as l1,boreD_dh as dh " +
                "from ((dbo_boltSpeciTable inner join dbo_BoltTable on dbo_boltSpeciTable.boltSpeciIndex=dbo_BoltTable.boltSpeci) " +
                "inner join dbo_boltStdTable on dbo_boltStdTable.boltStdIndex=dbo_BoltTable.boltStd) " +
                "where dbo_boltSpeciTable.boltSpeci like 'M" + str[1] + "%%'";
            MessageBox.Show(sql, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string speci, std, DN, ls, l1, dh;
                speci = dr["speci"].ToString();// 把强度等级
                std = dr["std"].ToString();// 
                DN = dr["DN"].ToString();//
                ls = dr["ls"].ToString();// 
                l1 = dr["l1"].ToString();//
                dh = dr["dh"].ToString();//
                string[] strs = { speci, std, DN, ls, l1, dh };
                dataGridView1.Rows.Add(strs);
            }
            dr.Close(); // 关闭连接
        }

        private void optBtn_Click_1(object sender, EventArgs e)
        {
            boltChooseClass = new BoltChooseClass();
            if (dataGridView1.RowCount == 0 || dataGridView1.ColumnCount == 0)
            {
                MessageBox.Show("没有对应的数据信息");
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有对应的数据信息");
                return;
            }
            // 几何尺寸
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(), // name
                dataGridView1.SelectedCells[1].Value.ToString(), // std
                dataGridView1.SelectedCells[2].Value.ToString(), // d
                dataGridView1.SelectedCells[3].Value.ToString(), // ls
                dataGridView1.SelectedCells[4].Value.ToString(), // l1
                dataGridView1.SelectedCells[5].Value.ToString(), // dh
            };
            string boltConTypeString = type[0]; // 单螺栓连接
            string screwTypeString = type[1]; // 标准螺纹
            string boltTypeString = type[2]; // 内六角
            string boltSpeciString = str[0]; // 12 * 60
            string boltStdString = str[1]; // DIN en iso 4762
            string sql = "select * from ((((((dbo_BoltTable inner join dbo_boltSpeciTable on dbo_boltSpeciTable.boltSpeciIndex=dbo_BoltTable.boltSpeci) " +
                    "inner join dbo_boltStdTable on dbo_boltStdTable.boltStdIndex=dbo_BoltTable.boltStd) " +
                    "inner join dbo_boltTypeTable on dbo_boltTypeTable.boltTypeIndex=dbo_BoltTable.boltType) " +
                    "inner join dbo_screwTypeTable on dbo_screwTypeTable.screwTypeIndex=dbo_BoltTable.screwType) " +
                    "inner join dbo_nutTable on dbo_nutTable.nutIndex=dbo_BoltTable.nutIndex) " +
                    "inner join dbo_gasketTable on dbo_gasketTable.gasketIndex=dbo_BoltTable.gasketIndex) " +
                    "where dbo_screwTypeTable.screwType='" + screwTypeString + "' and dbo_boltTypeTable.boltType='" + boltTypeString + "' and dbo_boltSpeciTable.boltSpeci='"
                    + boltSpeciString + "' and dbo_boltStdTable.boltStd='" + boltStdString + "'";
            //MessageBox.Show(sql);
            try
            {
                boltChooseClass.std = boltStdString;
                boltChooseClass.speci = boltSpeciString;
            }
            catch (Exception)
            {
                MessageBox.Show("std speci error!");
                throw new Exception("参数错误！请仔细检查");
            }
            

            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            if (dr.Read())
            {
                string normalD_d, screwP_P, boltLen_ls, boreD_dh, boltHeadOutD_dw, boltHeadInnerD_da,
                    screwMidD_d2, screwMinD_d3, polishRodLen_l1, boltNutScrewMinD_D1, boltNutSideWid_s;
                normalD_d = dr["normalD_d"].ToString();// d
                screwP_P = dr["screwP_P"].ToString(); // p
                boltLen_ls = dr["boltLen_ls"].ToString(); // ls
                boreD_dh = dr["boreD_dh"].ToString(); // dh
                boltHeadOutD_dw = dr["boltHeadOutD_dw"].ToString(); // dw
                boltHeadInnerD_da = dr["boltHeadInnerD_da"].ToString(); // da
                screwMidD_d2 = dr["screwMidD_d2"].ToString(); // d2
                screwMinD_d3 = dr["screwMinD_d3"].ToString();// d3
                polishRodLen_l1 = dr["polishRodLen_l1"].ToString(); // l1
                boltNutSideWid_s = dr["boltNutSideWid_s"].ToString(); // s
                boltNutScrewMinD_D1 = dr["boltNutScrewMinD_D1"].ToString(); // D1

                boltChooseClass.NormalD_d = double.Parse(normalD_d);
                boltChooseClass.ScrewP_P = double.Parse(screwP_P);
                boltChooseClass.BoltLen_ls = double.Parse(boltLen_ls);
                boltChooseClass.BoreD_dh = double.Parse(boreD_dh);
                boltChooseClass.BoltHeadOutD_dw = double.Parse(boltHeadOutD_dw);
                boltChooseClass.BoltHeadInnerD_da = double.Parse(boltHeadInnerD_da);
                boltChooseClass.ScrewMidD_d2 = double.Parse(screwMidD_d2);
                boltChooseClass.ScrewMinD_d3 = double.Parse(screwMinD_d3);
                boltChooseClass.PolishRodLen_l1 = double.Parse(polishRodLen_l1);
                boltChooseClass.BoltNutScrewMinD_D1 = double.Parse(boltNutScrewMinD_D1);
                boltChooseClass.BoltNutSideWid_s = double.Parse(boltNutSideWid_s);
            }
           
            boltStdDimStrengthValue.Text = boltStdString + "-" + boltSpeciString + "-" + initstr[0];
            dr.Close();//关闭连接

            // 材料数据
            IDataReader dr2 = dao.read(sql);
            string materialSql = "select * from dbo_materialBolt where BoltMaterialLevel=" + initstr[0];
            dr2 = dao.read(materialSql);
            if (dr2.Read())
            {
                string ESRT, Rm, Rpmin;
                ESRT = dr2["BoltMatrialEs_yangshi"].ToString();// ESRT
                Rm = dr2["BoltMaterialRm_kangla"].ToString(); // Rm
                Rpmin = dr2["BoltMatrialRpmin_qufu"].ToString(); // Rpmin

                boltChooseClass.boltMaterial.BoltMaterialEs = double.Parse(ESRT);
                boltChooseClass.boltMaterial.BoltMaterialRm = double.Parse(Rm);
                boltChooseClass.boltMaterial.BoltMaterialRpmin = double.Parse(Rpmin);

            }
           
            dr2.Close();
            showText(boltChooseClass);
            showBoltModel(Color.Cyan);
        }

        private void showText(BoltChooseClass boltChooseClass)
        {
            dres.Text = boltChooseClass.NormalD_d.ToString();
            Pres.Text = boltChooseClass.ScrewP_P.ToString();
            dhres.Text = boltChooseClass.BoreD_dh.ToString();
            dwres.Text = boltChooseClass.BoltHeadOutD_dw.ToString();
            dares.Text = boltChooseClass.BoltHeadInnerD_da.ToString();
            d2res.Text = boltChooseClass.ScrewMidD_d2.ToString();
            d3res.Text = boltChooseClass.ScrewMinD_d3.ToString();
            lsres.Text = boltChooseClass.BoltLen_ls.ToString();
            D1res.Text = boltChooseClass.BoltNutScrewMinD_D1.ToString();

            ESRTres.Text = boltChooseClass.boltMaterial.BoltMaterialEs.ToString();
            Rmres.Text = boltChooseClass.boltMaterial.BoltMaterialRm.ToString();
            Rpminres.Text = boltChooseClass.boltMaterial.BoltMaterialRpmin.ToString();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
