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
        public IModelBuildForm ClampedForm { set; get; }
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
            var clamped = ClampedForm.GetModel() as HKFDJClamped;
            double num = clamped.num;
            var bolt = BoltForm.GetModel() as Bolt;
            var nut = NutForm.GetModel() as NutClass;

            dataGridView1.Rows.Add("n", clamped.n, "螺栓个数");
            dataGridView1.Rows.Add("d", bolt.d, "螺栓公称");
            dataGridView1.Rows.Add("D", clamped.d, "螺栓孔直径公称");
            dataGridView1.Rows.Add("R", clamped.C, "螺栓定位圆直径");
            dataGridView1.Rows.Add("Plane", "XY", "固定平面");
            dataGridView1.Rows.Add("Forces", "Vectot(0,0,-Z)", "等效螺栓压力");

            Entity boltEntity = BoltForm.GetModelEntity();
            Entity clampedEntity = ClampedForm.GetModelEntity();
            Entity nutEntity = NutForm.GetModelEntity();


            for (int i = 0; i < num - 1; i++)
            {
                var cloneClamped = clampedEntity.Clone() as Entity;
                cloneClamped.Translate(0, 0, (num - i - 1) * clamped.tf);
                model1.Entities.Add(cloneClamped, Color.Blue);
            }
            boltEntity.Translate(clamped.C / 2, 0, clamped.tf * num +  - (bolt.l));// flange.ddz
            nutEntity.Translate(clamped.C / 2, 0, -nut.NutHeight);// flange.ddz
            double r = 2 * Math.PI / clamped.n;

            for (int i = 0; i < clamped.n; i++)
            {
                var cloneBolt = boltEntity.Clone() as Entity;
                var cloneNut = nutEntity.Clone() as Entity;
                model1.Entities.Add(cloneBolt, Color.Red);
                model1.Entities.Add(cloneNut, Color.Cyan);
                boltEntity.Rotate(r, Vector3D.AxisZ);
                nutEntity.Rotate(r, Vector3D.AxisZ);
            }
            model1.Entities.Add(clampedEntity, Color.Blue);
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
