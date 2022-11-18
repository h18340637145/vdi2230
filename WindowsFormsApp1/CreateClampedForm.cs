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
    public partial class CreateClampedForm : Form, IModelBuildForm
    {
        public CreateClampedForm()
        {
            InitializeComponent();
            dataGridView1.Columns["ValueField"].ReadOnly = false;
            model1.Grid.Visible = false;
            model1.ToolBar.Visible = false;
            model1.OriginSymbol.Visible = false;
            model1.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            model1.Enabled = false;
            model1.ViewCubeIcon.Visible = false;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            _okBtn.Enabled = false;

            //dataGridView1.Rows.Add("d", 29);
            //dataGridView1.Rows.Add("n", 8);
            //dataGridView1.Rows.Add("A", 290);
            //dataGridView1.Rows.Add("C", 235);
            //dataGridView1.Rows.Add("B", 102);
            //dataGridView1.Rows.Add("Ag", 149);
            //dataGridView1.Rows.Add("Bg", 124);
            //dataGridView1.Rows.Add("tf", 44.5);
            //dataGridView1.Rows.Add("th", 25.4);
            //dataGridView1.Rows.Add("tc", 6);
            //dataGridView1.Rows.Add("h", 44.5);
            //dataGridView1.Rows.Add("L", 30);

            dataGridView1.Rows.Add("d", 29);
            dataGridView1.Rows.Add("n", 8);
            dataGridView1.Rows.Add("outer_A", 290);
            dataGridView1.Rows.Add("C", 235);
            dataGridView1.Rows.Add("inner_B", 102);
            dataGridView1.Rows.Add("tf", 44.5);
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_flange == null)
            {
                return;
            }
            _setEveryPropFieldsFromDataGridView();
            _showFlangeToModel(Color.Blue);
        }

        private void _showFlangeToModel(Color color)
        {
            if (_flange == null)
            {
                throw new Exception("Flange is null");
            }

            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                _flangeEntity = _flange.GetEntity();
                model1.Entities.Add(_flangeEntity, color);
                model1.ZoomFit();
                model1.Invalidate();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误 请仔细检查");
            }
        }

        private void _setEveryPropFieldsFromDataGridView()
        {
            foreach (var f in _flange.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["PropeField"] != null && (string)row.Cells["PropeField"].Value == propName)
                    {
                        var obj = row.Cells["ValueField"].Value;
                        f.SetValue(_flange, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        // 渲染
        private void _rednerBtn_Click(object sender, EventArgs e)
        {
            _okBtn.Enabled = true;
            _flange = new HKFDJClamped();
            _setEveryPropFieldsFromDataGridView();
            _showFlangeToModel(Color.Blue);
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            if (_flange == null)
            {
                _okBtn.Enabled = false;
                return;
            }
            Hide();
        }

        private void _openObjBtn_Click(object sender, EventArgs e)
        {

        }

        private void _saveObjBtn_Click(object sender, EventArgs e)
        {

        }

        public object GetModel()
        {
            return _flange;
        }

        private HKFDJClamped _flange;
        private Entity _flangeEntity;

        public Entity GetModelEntity()
        {
            if (_flange == null)
            {
                return null;
            }

            if (_flangeEntity == null)
            {
                return _flangeEntity = _flange.GetEntity();
            }

            return _flangeEntity;
        }
    }
}
