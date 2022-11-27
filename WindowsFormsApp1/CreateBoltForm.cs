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

            Console.WriteLine(model1.BackColor.R);
            Console.WriteLine(model1.BackColor.G);
            Console.WriteLine(model1.BackColor.B);
            Console.WriteLine(model1.BackColor.A);

            dataGridView1.Columns["ValueField"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns["PropeField"].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;


            //dataGridView1.Rows.Add("d", 29);
            //dataGridView1.Rows.Add("d1", 25.835);
            //dataGridView1.Rows.Add("p", 2);
            //dataGridView1.Rows.Add("l", 80);
            //dataGridView1.Rows.Add("b", 66);
            //dataGridView1.Rows.Add("e", 58);
            //dataGridView1.Rows.Add("s", 46);
            //dataGridView1.Rows.Add("k", 18.7);
            //dataGridView1.Rows.Add("r", 1);

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

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_bolt == null || _boltData == null)
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
            if (_bolt == null)
            {
                throw new Exception("bolt is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                _boltEntity = _bolt.GetEntity();
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
            return _bolt;
        }
        Bolt _bolt;
        Entity _boltEntity;
        BoltClass _boltData;

        public BoltClass getBoltData()
        {
            return _boltData;
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
    }
}
