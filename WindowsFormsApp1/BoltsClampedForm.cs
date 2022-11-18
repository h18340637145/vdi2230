using CreateBotSpring;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
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
    public partial class BoltsClampedForm : Form
    {
        public IModelBuildForm FlangeForm { set; get; }
        public IModelBuildForm BoltForm { set; get; }
        public IModelBuildForm NutForm { set; get; }
        public bool IsBuildModel { set; get; }

        public BoltsClampedForm()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            model1.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            model1.ToolBar.Visible = false;
            model1.Grid.Visible = false;
            model1.ViewCubeIcon.Visible = false;
            model1.CoordinateSystemIcon.Visible = false;
            model1.Grid.Visible = false;
            IsBuildModel = false;
        }

        public void ResetModel()
        {
            dataGridView1.Rows.Clear();
            model1.Entities.Clear();
            IsBuildModel = false;
        }

        private void BoltsClampedForm_Load(object sender, EventArgs e)
        {
            if (IsBuildModel)
            {
                return;
            }
            IsBuildModel = true;
            var flange = FlangeForm.GetModel() as HKFDJClamped;
            var bolt = BoltForm.GetModel() as Bolt;
            var nut = NutForm.GetModel() as NutClass;

            dataGridView1.Rows.Add("n", flange.n, "螺栓个数");
            dataGridView1.Rows.Add("d", bolt.d, "螺栓公称");
            dataGridView1.Rows.Add("D", flange.d, "螺栓孔直径公称");
            dataGridView1.Rows.Add("R", flange.C, "螺栓定位圆直径");
            dataGridView1.Rows.Add("Plane", "XY", "固定平面");
            dataGridView1.Rows.Add("Forces", "Vectot(0,0,-Z)", "等效螺栓压力");

            Entity boltEntity = BoltForm.GetModelEntity();
            Entity flangeEntity = FlangeForm.GetModelEntity();
            Entity nutEntity = NutForm.GetModelEntity();

            boltEntity.Translate(flange.C / 2, 0, flange.tf +  - (bolt.l));// flange.ddz
            nutEntity.Translate(flange.C / 2, 0, -nut.NutHeight);// flange.ddz
            double r = 2 * Math.PI / flange.n;

            for (int i = 0; i < flange.n; i++)
            {
                var cloneBolt = boltEntity.Clone() as Entity;
                var cloneNut = nutEntity.Clone() as Entity;
                model1.Entities.Add(cloneBolt, Color.Red);
                model1.Entities.Add(cloneNut, Color.Cyan);
                boltEntity.Rotate(r, Vector3D.AxisZ);
                nutEntity.Rotate(r, Vector3D.AxisZ);
            }
            model1.Entities.Add(flangeEntity, Color.Blue);
            model1.ZoomFit();
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult = DialogResult.Cancel;
        }

        private void _importFEMBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
