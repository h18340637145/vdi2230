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

            dataGridView1.Rows.Add("num", 3);
            dataGridView1.Rows.Add("d", 12);
            dataGridView1.Rows.Add("n", 12);
            dataGridView1.Rows.Add("outer_A", 200);
            dataGridView1.Rows.Add("C", 160);
            dataGridView1.Rows.Add("inner_B", 100);
            dataGridView1.Rows.Add("tf", 15);


            dataGridView2.Columns["falanValue"].ReadOnly = false;

            dataGridView2.Rows.Add("d", 12);
            dataGridView2.Rows.Add("n", 12);
            dataGridView2.Rows.Add("A", 200);
            dataGridView2.Rows.Add("C", 160);
            dataGridView2.Rows.Add("B", 100);
            dataGridView2.Rows.Add("Ag", 110);
            dataGridView2.Rows.Add("Bg", 62);
            dataGridView2.Rows.Add("tf", 8);
            dataGridView2.Rows.Add("th", 13);
            dataGridView2.Rows.Add("tc", 3);
            dataGridView2.Rows.Add("h", 22);
            dataGridView2.Rows.Add("L", 15);

            dataGridView3.Columns["feilunValue"].ReadOnly = false;
            dataGridView3.Rows.Add("d", 12);
            dataGridView3.Rows.Add("n", 12);
            dataGridView3.Rows.Add("outer_A", 220);
            dataGridView3.Rows.Add("C", 160);
            dataGridView3.Rows.Add("inner_B", 100);
            dataGridView3.Rows.Add("tf", 8);
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
                //entities.Add(n4FaLanEntity);
                //entities.Add(feilunEntity);
                //selfClampedList.Clear();
                var res = selfAssClamped.GetEntity();
                //double feilunHeight = feilun.GetHeight();
                //n4FaLanEntity.Translate(0, 0, 2 * feilunHeight);
                //feilunEntity.Translate(0, 0, feilunHeight);

                //Solid symFeilun = feilun.GetSymFeilun();
                //symFeilun.Translate(0, 0, feilunHeight);

                //Solid symFalan = n4FaLan.GetSymFalan();
                //selfClampedList.Add(symFalan);
                //selfClampedList.Add(symFeilun);
                //selfClampedList.Add((Solid)n4FaLanEntity);
                //selfClampedList.Add((Solid)feilunEntity);
                ////var res = Solid.Union(list);

                model1.Entities.Clear();
                model1.Enabled = true;
                //for (int i = 0; i < selfClampedList.Count; i++)
                //{
                //    model1.Entities.Add(selfClampedList[i], Color.Red);
                //}
                //var res = Solid.Union(selfClampedList);
                model1.Entities.Add(res, Color.LightCyan);

                model1.ZoomFit();
                model1.Invalidate();
                assOkBtn.Enabled = true;
            }
            //else if (n4FaLanEntity != null && feilunEntity == null)
            //{
            //    // 法兰成双
            //    //entities.Add(n4FaLanEntity);
            //    selfClampedList.Clear();
            //    Solid symFalan = n4FaLan.GetSymFalan();
            //    selfClampedList.Add(symFalan);
            //    selfClampedList.Add((Solid)n4FaLanEntity);
            //    model1.Entities.Clear();
            //    model1.Enabled = true;
            //    //for (int i = 0; i < selfClampedList.Count; i++)
            //    //{
            //    //    model1.Entities.Add(selfClampedList[i], Color.Red);
            //    //}
            //    var res = Solid.Union(selfClampedList);
            //    model1.Entities.Add(res[0]);
            //    model1.ZoomFit();
            //    model1.Invalidate();
            //    assOkBtn.Enabled = true;
            //}
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
            Hide();
        }

        private void feilunOkBtn_Click(object sender, EventArgs e)
        {
            if(feilun == null)
            {
                feilunOkBtn.Enabled = false;
                return;
            }
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
            Hide();
        }

        public EntityList GetModelEntities()
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
