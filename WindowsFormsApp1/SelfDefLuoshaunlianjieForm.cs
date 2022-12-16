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
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SelfDefLuoshaunlianjieForm : Form
    {

        BoltClass _bolt;
        GasketClass _gasket;
        NutClass _nut;
        Entity _boltEntity;
        Entity _gasketEntity;
        Entity _nutEntity;
        public SelfDefLuoshaunlianjieForm()
        {
            InitializeComponent();

            boltModel.Grid.Visible = false;
            boltModel.ToolBar.Visible = false;
            boltModel.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            boltModel.OriginSymbol.Visible = false;
            boltModel.CoordinateSystemIcon.Visible = false;
            boltModel.Enabled = false;
            boltModel.ViewCubeIcon.Visible = false;

            dataGridView1.Columns["ValueField"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["PropeField"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            dataGridView1.Rows.Add("NormalD_d", 12);
            dataGridView1.Rows.Add("ScrewP_P", 1.75);
            dataGridView1.Rows.Add("BoltLen_ls", 60);
            dataGridView1.Rows.Add("BoreD_dh", 13.5);
            dataGridView1.Rows.Add("BoreD_dT", 0);
            dataGridView1.Rows.Add("BoltHeadOutD_dw", 16.47);
            dataGridView1.Rows.Add("BoltHeadInnerD_da", 13.7);
            dataGridView1.Rows.Add("ScrewMidD_d2", 10.863);
            dataGridView1.Rows.Add("ScrewMinD_d3", 9.853);
            dataGridView1.Rows.Add("PolishRodLen_l1", 30);
            dataGridView1.Rows.Add("PolishRodLen_l2", 0);
            dataGridView1.Rows.Add("BoltNutSideWid_s", 18);
            dataGridView1.Rows.Add("BoltNutScrewMinD_D1", 10.11);

            gasketModel.Grid.Visible = false;
            gasketModel.ToolBar.Visible = false;
            gasketModel.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            gasketModel.OriginSymbol.Visible = false;
            gasketModel.CoordinateSystemIcon.Visible = false;
            gasketModel.Enabled = false;
            gasketModel.ViewCubeIcon.Visible = false;

            //dataGridView2.Columns["ValueField"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridView2.Columns["PropeField"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.CellValueChanged += DataGridView2_CellValueChanged;

            dataGridView2.Rows.Add("Gasketstd", "EN ISO 7089");
            dataGridView2.Rows.Add("GasketinnerD_dhas", 13);
            dataGridView2.Rows.Add("GasketoutD_DA", 24);
            dataGridView2.Rows.Add("Boltheaddowngasketheight_hs1", 2.5);
            dataGridView2.Rows.Add("Nutdowngasketheight_hs2", 2.5);


            nutModel.Grid.Visible = false;
            nutModel.ToolBar.Visible = false;
            nutModel.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            nutModel.OriginSymbol.Visible = false;
            nutModel.CoordinateSystemIcon.Visible = false;
            nutModel.Enabled = false;
            nutModel.ViewCubeIcon.Visible = false;

            //dataGridView3.Columns["ValueField"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //dataGridView3.Columns["PropeField"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView3.CellValueChanged += DataGridView3_CellValueChanged;

            dataGridView3.Rows.Add("NutSpeci", "M12");
            dataGridView3.Rows.Add("NutStd", "DIN EN ISO ");
            dataGridView3.Rows.Add("NutNutSideWid", 18);
            dataGridView3.Rows.Add("NutBearMinD", 12);
            dataGridView3.Rows.Add("NutBearMaxD", 13);
            dataGridView3.Rows.Add("NutBearOutD", 16.6);
            dataGridView3.Rows.Add("NutHeight", 10.8);

        }

        private void DataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_nut == null)
            {
                return;
            }

            _nut = new NutClass();
            _setEveryPropFieldFromDataGridViewDataNut();
            _showNutToModel(Color.LightCyan);
        }

        private void _showNutToModel(Color blue)
        {
            if (_nut == null)
            {
                throw new Exception("_nut is null");
            }
            nutModel.Entities.Clear();
            nutModel.Enabled = true;

            try
            {
                _nutEntity = _nut.GetEntity();
                nutModel.Entities.Add(_nutEntity, blue);
                nutModel.ZoomFit();
                nutModel.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void _setEveryPropFieldFromDataGridViewDataNut()
        {
            foreach (var f in _nut.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells["NutProp"] != null && (string)row.Cells["NutProp"].Value == propName)
                    {
                        if (propName.Equals("NutSpeci") || propName.Equals("NutStd"))
                        {
                            var t = row.Cells["NutValue"].Value;
                            f.SetValue(_nut, Convert.ToString(t));
                            break;
                        }
                        var obj = row.Cells["NutValue"].Value;
                        f.SetValue(_nut, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void DataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_gasket == null)
            {
                return;
            }

            _gasket = new GasketClass();
            _setEveryPropFieldFromDataGridViewDataGasket();
            _showGasketToModel(Color.Blue);
        }

        private void _showGasketToModel(Color blue)
        {
            if (_gasket == null)
            {
                throw new Exception("_gasket is null");
            }
            gasketModel.Entities.Clear();
            gasketModel.Enabled = true;

            try
            {
                _gasketEntity = _gasket.GetEntity();
                gasketModel.Entities.Add(_gasketEntity, blue);
                gasketModel.ZoomFit();
                gasketModel.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void _setEveryPropFieldFromDataGridViewDataGasket()
        {
            foreach (var f in _gasket.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["GasketProp"] != null && (string)row.Cells["GasketProp"].Value == propName)
                    {
                        if (propName.Equals("Gasketstd"))
                        {
                            var t = row.Cells["GasketValue"].Value;
                            f.SetValue(_gasket, Convert.ToString(t));
                            break;
                        }
                        var obj = row.Cells["GasketValue"].Value;
                        f.SetValue(_gasket, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_bolt == null)
            {
                return;
            }

            _bolt = new BoltClass();
            _setEveryPropFieldFromDataGridViewData();
            _showBoltToModel(Color.Red);
        }

        private void _setEveryPropFieldFromDataGridViewData()
        {
            foreach (var f in _bolt.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["PropeField"] != null && (string)row.Cells["PropeField"].Value == propName)
                    {
                        var obj = row.Cells["ValueField"].Value;
                        f.SetValue(_bolt, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void _showBoltToModel(Color red)
        {
            if (_bolt == null)
            {
                throw new Exception("bolt is null");
            }
            boltModel.Entities.Clear();
            boltModel.Enabled = true;

            try
            {
                _boltEntity = _bolt.GetEntity();
                boltModel.Entities.Add(_boltEntity, red);
                boltModel.ZoomFit();
                boltModel.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        // 渲染
        private void BoltBtn_Click(object sender, EventArgs e)
        {
            BoltOk.Enabled = true;
            _bolt = new BoltClass();
            _setEveryPropFieldFromDataGridViewData();
            _showBoltToModel(Color.Red);
        }

        private void GasketBtn_Click(object sender, EventArgs e)
        {
            GasketOk.Enabled = true;
            _gasket = new GasketClass();
            _setEveryPropFieldFromDataGridViewDataGasket();
            _showGasketToModel(Color.Blue);
        }

        private void NutBtn_Click(object sender, EventArgs e)
        {
            NutOk.Enabled = true;
            _nut = new NutClass();
            _setEveryPropFieldFromDataGridViewDataNut();
            _showNutToModel(Color.LightCyan);
        }


        // 完成
        private void BoltOk_Click(object sender, EventArgs e)
        {
            if (_nutEntity == null && _gasketEntity == null)
            {
                ShowBoltToModel1(Color.Red);
            }
            else if (_nutEntity == null && _gasketEntity != null)
            {
                ShowBoltGasketModel();
            }
            else if (_nutEntity != null && _gasketEntity == null)
            {
                ShowBoltNutModel();
            }
            else
            {
                ShowAllToModel1();
            }
            BoltOk.Enabled = false;
        }

        private void ShowBoltNutModel()
        {
            model1.Entities.Clear();
            model1.Enabled = true;
            try
            {
                _nutEntity = _nut.GetEntity();
                _boltEntity = _bolt.GetEntity();
                model1.Entities.Add(_boltEntity, Color.Red);
                model1.Entities.Add(_nutEntity, Color.LightCyan);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (ArgumentException en)
            {
                Console.WriteLine(en);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void GasketOk_Click(object sender, EventArgs e)
        {
            if (_nutEntity == null && _bolt == null)
                ShowGasketToModel1(Color.Blue);
            else if (_nutEntity == null && _bolt != null)
            {
                ShowBoltGasketModel();
            }
            else if (_nutEntity != null && _bolt == null)
            {
                ShowBoltNutModel();
            }
            else
            {
                ShowAllToModel1();
            }
            GasketOk.Enabled = false;
        }

        private void NutOk_Click(object sender, EventArgs e)
        {
            if (_gasketEntity == null && _bolt == null)
                ShowNutToModel1(Color.LightCyan);
            else if (_gasketEntity == null && _bolt != null)
            {
                ShowBoltNutModel();
            }
            else if (_nutEntity != null && _bolt == null)
            {
                model1.Entities.Clear();
                model1.Enabled = true;

                try
                {
                    _gasket.offsetz = _nut.NutHeight;
                    _gasketEntity = _gasket.GetEntity();
                    _nutEntity = _nut.GetEntity();
                    model1.Entities.Add(_nutEntity, Color.LightCyan);
                    model1.Entities.Add(_gasketEntity, Color.Blue);
                    model1.ZoomFit();
                    model1.Invalidate();
                }
                catch (ArgumentException en)
                {
                    Console.WriteLine(en);
                    throw new Exception("输入参数错误，请仔细检查");
                }
            }
            else
            {
                ShowAllToModel1();
            }
            GasketOk.Enabled = false;
            NutOk.Enabled = false;
        }

        private void ShowNutToModel1(Color color)
        {
            if (_nut == null)
            {
                throw new Exception("_nut is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                _nutEntity = _nut.GetEntity();
                model1.Entities.Add(_nutEntity, color);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void ShowGasketToModel1(Color color)
        {
            if (_gasket == null)
            {
                throw new Exception("_gasket is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                _gasketEntity = _gasket.GetEntity();
                model1.Entities.Add(_gasketEntity, color);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void ShowBoltToModel1(Color color)
        {
            if (_bolt == null)
            {
                throw new Exception("bolt is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                _boltEntity = _bolt.GetEntity();
                model1.Entities.Add(_boltEntity, color);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void ShowBoltGasketModel()
        {
            model1.Entities.Clear();
            model1.Enabled = true;
            try
            {
                _gasket.offsetz = _bolt.BoltLen_ls - _gasket.Boltheaddowngasketheight_hs1;
                _gasketEntity = _gasket.GetEntity();
                _boltEntity = _bolt.GetEntity();
                model1.Entities.Add(_boltEntity, Color.Red);
                model1.Entities.Add(_gasketEntity, Color.Blue);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (ArgumentException en)
            {
                Console.WriteLine(en);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }
        private void ShowAllToModel1()
        {
            if (_nut == null || _bolt == null || _gasket == null)
            {
                throw new Exception("_nut _bolt _gasket is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                _nutEntity = _nut.GetEntity();
                _gasket.offsetz = _bolt.BoltLen_ls - _gasket.Boltheaddowngasketheight_hs1;
                _gasketEntity = _gasket.GetEntity();
                _boltEntity = _bolt.GetEntity();
                model1.Entities.Add(_boltEntity, Color.Red);
                model1.Entities.Add(_nutEntity, Color.LightCyan);
                model1.Entities.Add(_gasketEntity, Color.Blue);
                _gasket.offsetz = _nut.NutHeight;
                model1.Entities.Add(_gasket.GetEntity(), Color.Blue);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            model1.Entities.Clear();
            model1.ZoomFit();
            model1.Invalidate();
            boltModel.Entities.Clear();
            boltModel.ZoomFit();
            boltModel.Invalidate();
            nutModel.Entities.Clear();
            nutModel.ZoomFit();
            nutModel.Invalidate();
            gasketModel.Entities.Clear();
            gasketModel.ZoomFit();
            gasketModel.Invalidate();

            BoltBtn.Enabled = true;
            GasketBtn.Enabled = true;
            NutBtn.Enabled = true;

            BoltOk.Enabled = false;
            GasketOk.Enabled = false;
            NutOk.Enabled = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // 数据库操作
            // 将此螺栓连接结构插入到本地库中
            SelfDao dao = new SelfDao();
            string sql = "insert into bolt(NormalD_d,ScrewP_P,BoltLen_ls,BoreD_dh,dT,BoltHeadOutD_dw,BoltHeadInnerD_da,ScrewMidD_d2,ScrewMinD_d3,PolishRodLen_l1,PolishRodLen_l2,BoltNutSideWid_s,BoltNutScrewMinD_D1) values(" +
                _bolt.NormalD_d + "," + _bolt.ScrewP_P + "," + _bolt.BoltLen_ls + "," + _bolt.BoreD_dh + "," + _bolt.BoreD_dT + "," + _bolt.BoltHeadOutD_dw + "," +
                _bolt.BoltHeadInnerD_da + "," + _bolt.ScrewMidD_d2 + "," + _bolt.ScrewMinD_d3 + "," + _bolt.PolishRodLen_l1 + "," + _bolt.PolishRodLen_l2 + "," + _bolt.BoltNutSideWid_s + "," + 
                _bolt.BoltNutScrewMinD_D1  + ")";

            if (_bolt != null)
            {
                int num = dao.Excute(sql);
                if (num > 0)
                {
                    // 插入成功
                    Console.WriteLine("插入" + num + "条数据");
                    MessageBox.Show("插入成功");

                }
                else
                {
                    MessageBox.Show("插入失败，请检查");
                    return;
                }
            }

            if (_nut != null)
            {
                sql = "insert into nut(nutSpeci,nutStd,nutNutSideWid_s,nutBearMinD_Damin,nutBearMaxD_Damax,nutBearOutD_dwmu,nutHeight_m) values('" +
                _nut.NutSpeci + "','" + _nut.NutStd + "'," + _nut.NutNutSideWid + "," + _nut.NutBearMinD + "," + _nut.NutBearMaxD + "," + _nut.NutBearOutD + "," +
                _nut.NutHeight + ")";
                int num = dao.Excute(sql);
                if (num > 0)
                {
                    // 插入成功
                    Console.WriteLine("插入" + num + "条数据");
                    MessageBox.Show("插入成功");

                }
                else
                {
                    MessageBox.Show("插入失败，请检查");
                    return;
                }
            }
            
            if (_gasket != null)
            {
                sql = "insert into gasket(gasketstd,gasketinnerD_dhas,gasketoutD_DA,boltheaddowngasketheight_hs1,nutdowngasketheight_hs2) values('" +
                _gasket.Gasketstd + "'," + _gasket.GasketinnerD_dhas + "," + _gasket.GasketoutD_DA + "," + _gasket.Boltheaddowngasketheight_hs1 + "," + _gasket.Nutdowngasketheight_hs2 + ")";

                int num = dao.Excute(sql);
                if (num > 0)
                {
                    // 插入成功
                    Console.WriteLine("插入" + num + "条数据");
                    MessageBox.Show("插入成功");

                }
                else
                {
                    MessageBox.Show("插入失败，请检查");
                    return;
                }
            }
        }

        private void SelfDefLuoshaunlianjieForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“myDataSet.bolt”中。您可以根据需要移动或删除它。
            this.boltTableAdapter.Fill(this.myDataSet.bolt);

        }
    }
}
