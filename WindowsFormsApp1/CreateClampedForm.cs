using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using OpenGL.Delegates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ClampedModel;

namespace WindowsFormsApp1
{
    public partial class CreateClampedForm : Form, IModelBuildForm
    {
        public string std_selfDef;
        public CreateClampedForm()
        {
            InitializeComponent();
            dataGridView1.Columns["ValueField"].ReadOnly = false;
            model1.Grid.Visible = false;
            model1.ToolBar.Visible = false;
            model1.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            model1.OriginSymbol.Visible = true;
            model1.Enabled = false;
            model1.ViewCubeIcon.Visible = false;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            _okBtn.Enabled = false;

            dataGridView1.Rows.Add("num", 3, "连接件个数");
            dataGridView1.Rows.Add("d", 12, "mm螺孔直径");
            dataGridView1.Rows.Add("n", 12, "mm螺栓个数");
            dataGridView1.Rows.Add("outer_A", 200, "mm连接件外径");
            dataGridView1.Rows.Add("C", 160, "mm节圆直径");
            dataGridView1.Rows.Add("inner_B", 100, "mm连接件内径");
            dataGridView1.Rows.Add("tf", 15, "mm连接件高度");


            dataGridView2.Columns["falanValue"].ReadOnly = false;

            dataGridView2.Rows.Add("d", 12, "mm螺孔直径");
            dataGridView2.Rows.Add("n", 12, "mm螺栓个数");
            dataGridView2.Rows.Add("A", 200, "mm连接件外径");
            dataGridView2.Rows.Add("C", 160, "mm节圆直径");
            dataGridView2.Rows.Add("B", 100, "mm连接件内径");
            dataGridView2.Rows.Add("Ag", 110, "mm外孔直径");
            dataGridView2.Rows.Add("Bg", 62, "mm内孔直径");
            dataGridView2.Rows.Add("tf", 8,"mm底盘高度");
            dataGridView2.Rows.Add("th", 13, "mm扩展宽度");
            dataGridView2.Rows.Add("tc", 3,"mm上切口宽度");
            dataGridView2.Rows.Add("h", 22, "mm扩展高度");
            dataGridView2.Rows.Add("L", 15, "mm上切口高度");

            dataGridView3.Columns["feilunValue"].ReadOnly = false;
            dataGridView3.Rows.Add("d", 12, "mm螺孔直径");
            dataGridView3.Rows.Add("n", 12, "mm螺栓个数");
            dataGridView3.Rows.Add("outer_A", 220, "mm连接件外径");
            dataGridView3.Rows.Add("C", 160,"mm节圆直径");
            dataGridView3.Rows.Add("inner_B", 1000, "mm连接件内径");
            dataGridView3.Rows.Add("tf", 8,"mm厚度");
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
            std_selfDef = "std";
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
            if (std_selfDef == "std")
            {
                return _flange;
            }
            else
            {
                return selfAssClamped;
            }
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
        N4FaLanClamped n4FaLan;
        Entity n4FaLanEntity;
        private void addN4Btn_Click(object sender, EventArgs e)
        {
            n4FaLan = new N4FaLanClamped();
            _setEveryPropFieldsFromDataGridViewN4Falan();
            _showN4FalanToModel(Color.Blue);
            falanOkBtn.Enabled = true;
        }

        private void _showN4FalanToModel(Color blue)
        {
            if (n4FaLan == null)
            {
                throw new Exception("n4FaLan is null");
            }

            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                n4FaLanEntity = n4FaLan.GetEntity();
                model1.Entities.Add(n4FaLanEntity, blue);
                model1.ZoomFit();
                model1.Invalidate();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误 请仔细检查");
            }
        }

        private void _setEveryPropFieldsFromDataGridViewN4Falan()
        {
            foreach (var f in n4FaLan.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["falanProp"] != null && (string)row.Cells["falanProp"].Value == propName)
                    {
                        var obj = row.Cells["falanValue"].Value;
                        f.SetValue(n4FaLan, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        FeilunClamped feilun;
        Entity feilunEntity;
        private void addFeiLunBtn_Click(object sender, EventArgs e)
        {
            feilun = new FeilunClamped();
            _setEveryPropFieldsFromDataGridViewFeilun();
            _showFeilunToModel(Color.LightCyan);
            feilunOkBtn.Enabled = true;
        }

        private void _setEveryPropFieldsFromDataGridViewFeilun()
        {
            foreach (var f in feilun.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells["feilunProp"] != null && (string)row.Cells["feilunProp"].Value == propName)
                    {
                        var obj = row.Cells["feilunValue"].Value;
                        f.SetValue(feilun, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void _showFeilunToModel(Color lightCyan)
        {
            if (feilun == null)
            {
                throw new Exception("feilun is null");
            }

            model1.Entities.Clear();
            model1.Enabled = true;

            try
            {
                feilunEntity = feilun.GetEntity();
                model1.Entities.Add(feilunEntity, lightCyan);
                model1.ZoomFit();
                model1.Invalidate();

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误 请仔细检查");
            }
        }

        private void splitContainer4_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        //List<Entity> entities = new List<Entity>();
        //List<Solid> selfClampedList = new List<Solid>();

        SelfAssClamped selfAssClamped;
        EntityList entityList;
        private void AssBtn_Click(object sender, EventArgs e)
        {
            if (selfAssClamped == null)
            {
                selfAssClamped = new SelfAssClamped();
            }
            if (n4FaLan != null)
            {
                selfAssClamped.falan = n4FaLan;
            }

            if (feilun != null)
            {
                selfAssClamped.feilun = feilun;
            }

            
            if (n4FaLanEntity != null && feilunEntity != null)
            {
                entityList = selfAssClamped.GetEntitilist();
                model1.Entities.Clear();
                model1.Enabled = true;
                for (int i = 0; i < entityList.Count; i++)
                {
                    model1.Entities.Add(entityList[i], entityList[i].Color);

                }
                model1.ZoomFit();
                model1.Invalidate();
                assOkBtn.Enabled = true;
            }
            else
            {
                return;
            }

            // 实现
        }

        private void falanOkBtn_Click(object sender, EventArgs e)
        {
            if (n4FaLan == null)
            {
                falanOkBtn.Enabled = false;
                return;
            }
            std_selfDef = "selfDef";
            Hide();
        }

        private void feilunOkBtn_Click(object sender, EventArgs e)
        {
            if(feilun == null)
            {
                feilunOkBtn.Enabled = false;
                return;
            }
            std_selfDef = "selfDef";

            Hide();
        }

        private void assOkBtn_Click(object sender, EventArgs e)
        {
            if(n4FaLan == null || feilun == null)
            {
                feilunOkBtn.Enabled = false;
                falanOkBtn.Enabled = false;
                return;
            }
            std_selfDef = "selfDef";

            Hide();
        }

        public EntityList GetModelEntities()
        {
            if (selfAssClamped == null)
            {
                return null;
            }

            if (entityList == null)
            {
                return entityList = selfAssClamped.GetEntitilist();
            }

            return entityList;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                // 标准
                pictureBox1.Image = Image.FromFile("./Resources/pic/连接件.png");
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("./Resources/flange_section.png");
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 0)
            {
                // 标准
                pictureBox1.Image = Image.FromFile("./Resources/flange_section.png");
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
            else
            {
                pictureBox1.Image = Image.FromFile("./Resources/pic/连接件.png");
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            }
        }
    }
}
