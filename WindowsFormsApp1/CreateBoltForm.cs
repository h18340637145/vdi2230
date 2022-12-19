using CreateBotSpring;
using devDept.Eyeshot;
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
    public partial class CreateBoltForm : Form, IModelBuildForm
    {
        public CreateBoltForm()
        {
            InitializeComponent();

            model1.Grid.Visible = false;
            model1.ToolBar.Visible = false;
            model1.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            model1.OriginSymbol.Visible = false;
            model1.CoordinateSystemIcon.Visible = false;
            model1.Enabled = false;
            model1.ViewCubeIcon.Visible = false;

            //Console.WriteLine(model1.BackColor.R);
            //Console.WriteLine(model1.BackColor.G);
            //Console.WriteLine(model1.BackColor.B);
            //Console.WriteLine(model1.BackColor.A);

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

            Inner6Data.Rows.Add("NormalD_d", 12);
            Inner6Data.Rows.Add("ScrewP_P", 1.75);
            Inner6Data.Rows.Add("BoltLen_ls", 60);
            Inner6Data.Rows.Add("BoreD_dh", 13.5);
            Inner6Data.Rows.Add("BoreD_dT", 0);
            Inner6Data.Rows.Add("BoltHeadOutD_dw", 16.47);
            Inner6Data.Rows.Add("BoltHeadInnerD_da", 13.7);
            Inner6Data.Rows.Add("ScrewMidD_d2", 10.863);
            Inner6Data.Rows.Add("ScrewMinD_d3", 9.853);
            Inner6Data.Rows.Add("PolishRodLen_l1", 30);
            Inner6Data.Rows.Add("PolishRodLen_l2", 0);
            Inner6Data.Rows.Add("BoltNutSideWid_s", 18);
            Inner6Data.Rows.Add("BoltNutScrewMinD_D1", 10.11);

            falanData.Rows.Add("NormalD_d", 12);
            falanData.Rows.Add("ScrewP_P", 1.75);
            falanData.Rows.Add("BoltLen_ls", 60);
            falanData.Rows.Add("BoreD_dh", 13.5);
            falanData.Rows.Add("BoreD_dT", 0);
            falanData.Rows.Add("BoltHeadOutD_dw", 16.47);
            falanData.Rows.Add("BoltHeadInnerD_da", 13.7);
            falanData.Rows.Add("ScrewMidD_d2", 10.863);
            falanData.Rows.Add("ScrewMinD_d3", 9.853);
            falanData.Rows.Add("PolishRodLen_l1", 30);
            falanData.Rows.Add("PolishRodLen_l2", 0);
            falanData.Rows.Add("BoltNutSideWid_s", 18);
            falanData.Rows.Add("BoltNutScrewMinD_D1", 10.11);

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_bolt == null )
            {
                return;
            }

            _setEveryPropFieldFromDataGridViewData();
            _bolt = new Bolt(_boltData);
            _showFlangeToModel(Color.Red);
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            if (_okBtn.Enabled == false)
            {
                return;
            }
            Hide();
        }

        private void _renderBtn_Click(object sender, EventArgs e)
        {
            _okBtn.Enabled = true;
            //_bolt = new Bolt();
            //_setEveryPropFieldFromDataGridView();
            _boltData = new BoltClass();
            _setEveryPropFieldFromDataGridViewData();
            _bolt = new Bolt(_boltData);
            _showFlangeToModel(Color.Red);
        }

        private void _showFlangeToModel(Color red)
        {
            if (_boltData == null)
            {
                throw new Exception("bolt is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                _boltEntity = _boltData.GetEntity();
                model1.Entities.Add(_boltEntity, red);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void _setEveryPropFieldFromDataGridView()
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

        private void _setEveryPropFieldFromDataGridViewData()
        {
            foreach (var f in _boltData.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["PropeField"] != null && (string)row.Cells["PropeField"].Value == propName)
                    {
                        var obj = row.Cells["ValueField"].Value;
                        f.SetValue(_boltData, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        public Entity GetModelEntity()
        {
            if (_bolt == null)
            {
                return null;
            }


            if (_boltEntity == null)
            {
                return _bolt.GetEntity();
            }

            return _boltEntity;
        }

        public object GetModel()
        {
            return _boltData;
        }
        Bolt _bolt;
        Entity _boltEntity;
        BoltClass _boltData;

        public BoltClass getBoltData()
        {
            return _boltData;
        }

        private void Inner6RenderBtn_Click(object sender, EventArgs e)
        {
            Inner6OkBtn.Enabled = true;
            _boltData = new BoltInner6();
            _setEveryPropFieldFromDataGridViewData();
            _showBoltToModel(Color.Red);
        }

        private void _showBoltToModel(Color red)
        {
            if (_boltData == null)
            {
                throw new Exception("_boltData is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                _boltEntity = _boltData.GetEntity();
                model1.Entities.Add(_boltEntity, red);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void Inner6OkBtn_Click(object sender, EventArgs e)
        {
            if (Inner6OkBtn.Enabled == false)
            {
                return;
            }
            Hide();
        }

        private void falanRenderBtn_Click(object sender, EventArgs e)
        {
            falanOkBtn.Enabled = true;
            _boltData = new BoltFaLan();
            _setEveryPropFieldFromDataGridViewData();
            _showBoltToModel(Color.Red);
        }

        private void falanOkBtn_Click(object sender, EventArgs e)
        {
            if (falanOkBtn.Enabled == false)
            {
                return;
            }
            Hide();
        }
    }

    public interface IModelBuildForm
    {
        // 从该form中获取已经创建好的模型对象
        // 返回类型
        // HKFDJ  Bolt
        object GetModel();

        // 获取实际可被Model.Entities添加的模型对象
        //return 该对象
        Entity GetModelEntity();

        EntityList GetModelEntities();
    }
}
