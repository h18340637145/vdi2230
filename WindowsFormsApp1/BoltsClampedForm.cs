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
using WindowsFormsApp1.MutiBoltsConnVdiCal;

namespace WindowsFormsApp1
{
    public partial class BoltsClampedForm : Form
    {
        public IModelBuildForm ClampedForm { set; get; }
        public IModelBuildForm BoltForm { set; get; }
        public IModelBuildForm NutForm { set; get; }
        public bool IsBuildModel { set; get; }


        public BoltClass boltNormal;
        public ClampedMaterial clampedMaterial;

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
            boltNormal = new BoltClass(bolt);

            dataGridView1.Rows.Add("n", clamped.n, "螺栓个数");
            dataGridView1.Rows.Add("d", bolt.d, "螺栓公称");
            dataGridView1.Rows.Add("D", clamped.d, "螺栓孔直径公称");
            dataGridView1.Rows.Add("R", clamped.C, "节圆直径");
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

        private void BoltMaterialBtn_Click(object sender, EventArgs e)
        {
            StrengthGradeForm strengthGradeForm = new StrengthGradeForm();
            strengthGradeForm.ShowDialog();
            BoltMaterialClass material = strengthGradeForm.getMaterial();
            if (material == null)
            {
                return;
            }
            boltNormal.boltMaterial = material;
            updateParamDataGrids();
            strengthGradeForm.Hide();
            BoltMaterialBtn.Enabled = false;
        }

        private void ClampedMaterialBtn_Click(object sender, EventArgs e)
        {
            ChooseClampedFrm form = new ChooseClampedFrm();
            form.ShowDialog();
            ClampedMaterial material = form.material;
            if (material == null)
            {
                return;
            }
            clampedMaterial = material;
            updateParamDataGrids();
            form.Hide();
            ClampedMaterialBtn.Enabled = false;
        }

        private void updateParamDataGrids()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("NormalD_d", boltNormal.NormalD_d, "螺栓公称直径");
            dataGridView1.Rows.Add("ScrewP_P", boltNormal.ScrewP_P, "螺距");
            dataGridView1.Rows.Add("BoltLen_ls", boltNormal.BoltLen_ls, "螺杆长度");
            dataGridView1.Rows.Add("BoreD_dh", boltNormal.BoreD_dh, "镗孔直径");
            dataGridView1.Rows.Add("BoreD_dT", boltNormal.BoreD_dT, "");
            dataGridView1.Rows.Add("BoltHeadOutD_dw", boltNormal.BoltHeadOutD_dw, "螺栓头承载面外径");
            dataGridView1.Rows.Add("BoltHeadInnerD_da", boltNormal.BoltHeadInnerD_da, "螺栓头承载面内径");
            dataGridView1.Rows.Add("ScrewMidD_d2", boltNormal.ScrewMidD_d2, "螺纹中径");
            dataGridView1.Rows.Add("ScrewMinD_d3", boltNormal.ScrewMinD_d3, "螺纹小径");
            dataGridView1.Rows.Add("PolishRodLen_l1", boltNormal.PolishRodLen_l1, "光杆1长度");
            dataGridView1.Rows.Add("PolishRodLen_l2", boltNormal.PolishRodLen_l2, "光杆2长度");
            dataGridView1.Rows.Add("BoltNutSideWid_s", boltNormal.BoltNutSideWid_s, "螺母对边宽度");
            dataGridView1.Rows.Add("BoltNutScrewMinD_D1", boltNormal.BoltNutScrewMinD_D1, "螺母螺纹小径");

            dataGridView1.Rows.Add("BoltMaterialLevel", boltNormal.boltMaterial.BoltMaterialLevel, "强度等级");
            dataGridView1.Rows.Add("BoltMaterialRatio_fB", boltNormal.boltMaterial.BoltMaterialRatio_fB, "剪切强度系数");
            dataGridView1.Rows.Add("BoltMaterialEs", boltNormal.boltMaterial.BoltMaterialEs, "杨氏模量");
            dataGridView1.Rows.Add("BoltMaterialRpmin", boltNormal.boltMaterial.BoltMaterialRpmin, "最小屈服强度");
            dataGridView1.Rows.Add("BoltMaterialRm", boltNormal.boltMaterial.BoltMaterialRm, "抗拉强度");

            dataGridView1.Rows.Add("ClampedMaterialName", clampedMaterial.ClampedMaterialName, "连接件材料名");
            dataGridView1.Rows.Add("ClampedMaterialRatio_fB", clampedMaterial.ClampedMaterialRatio_fB, "连接件材料名");
            dataGridView1.Rows.Add("ClampedMaterialRatio_fG", clampedMaterial.ClampedMaterialRatio_fG, "连接件材料名");
            dataGridView1.Rows.Add("ClampedMaterialEp", clampedMaterial.ClampedMaterialEp, "连接件材料名");
            dataGridView1.Rows.Add("ClampedMaterialRmmin", clampedMaterial.ClampedMaterialRmmin, "连接件材料名");



        }

    }
}
