using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Graphics;
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
    public partial class CreateNutForm : Form, IModelBuildForm
    {
        public CreateNutForm()
        {
            InitializeComponent();
            dataGridView1.Columns["ValueField"].ReadOnly = true;
            model3.Grid.Visible = false;
            model3.ToolBar.Visible = false;
            model3.OriginSymbol.Visible = false;
            model3.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            model3.Enabled = false;
            model3.ViewCubeIcon.Visible = false;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            _okBtn.Enabled = false;

            dataGridView1.Rows.Add("NutNutSideWid", "18", "mm螺母对边宽度");
            dataGridView1.Rows.Add("NutBearMinD", "12", "mm最小内径");
            dataGridView1.Rows.Add("NutBearMaxD", "16.6", "mm最大内径");
            dataGridView1.Rows.Add("NutBearOutD", "16.6", "mm外径");
            dataGridView1.Rows.Add("NutHeight", "10.8", "mm高度");
        }

        private void _renderBtn_Click(object sender, EventArgs e)
        {
            _okBtn.Enabled = true;
            _nut = new NutClass();
            _setEveryPropFieldsFromDataGridView();
            _showNutToModel(Color.Blue);
        }

        private void _showNutToModel(Color blue)
        {
            if (_nut == null)
            {
                throw new Exception("nut is null");
            }

            model3.Entities.Clear();
            model3.Enabled = true;
            try
            {
                _nutEntity = _nut.GetEntity();
                model3.Entities.Add(_nutEntity, blue);
                model3.ZoomFit();
                model3.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误，请仔细检查");
            }
        }

        private void _setEveryPropFieldsFromDataGridView()
        {
            foreach (var f in _nut.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["PropeField"] != null && (string)row.Cells["PropeField"].Value == propName)
                    {
                        var obj = row.Cells["ValueField"].Value;
                        f.SetValue(_nut, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            if (_nut == null)
            {
                _okBtn.Enabled = false;
                return;
            }
            Hide();
        }

        public object GetModel()
        {
            return _nut;
        }

        public Entity GetModelEntity()
        {
            if (_nut == null)
            {
                return null;
            }

            if (_nutEntity == null)
            {
                return _nutEntity = _nut.GetEntity();
            }

            return _nutEntity;
        }

        private NutClass _nut;
        private Entity _nutEntity;

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_nut == null)
            {
                return;
            }

            _setEveryPropFieldsFromDataGridView();
            _showNutToModel(Color.Cyan);
        }

        public EntityList GetModelEntities()
        {
            throw new NotImplementedException();
        }
    }
}
