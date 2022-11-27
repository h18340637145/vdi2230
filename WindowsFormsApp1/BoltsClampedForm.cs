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


        public BoltClass boltData;
        public ClampedMaterial clampedMaterial;
        public JiHeParameters jiHeParameters;
        public GongYiParameters gongYiParameters;

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
            //boltData = new BoltClass(bolt);

            dataGridView1.Rows.Add("n", clamped.n, "螺栓个数");
            dataGridView1.Rows.Add("d", boltData.NormalD_d, "螺栓公称");
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
            boltData.boltMaterial = material;
            updateParamDataGrids();
            strengthGradeForm.Hide();
            BoltMaterialBtn.Enabled = false;
        }

        private void ClampedMaterialBtn_Click(object sender, EventArgs e)
        {
            ClampedChooseFrm form = new ClampedChooseFrm();
            form.ShowDialog();
            ClampedMaterial material = form.getMaterial();
            if (material == null)
            {
                return;
            }
            clampedMaterial = material;
            updateParamDataGrids();
            form.Hide();
            ClampedMaterialBtn.Enabled = false;
        }


        private void JiheBtn_Click(object sender, EventArgs e)
        {
            JiHeParamFrm form = new JiHeParamFrm();
            form.ShowDialog();
            JiHeParameters param = form.GetJiheParams();
            if (param == null)
            {
                return;
            }
            jiHeParameters = param;
            updateParamDataGrids();
            form.Hide();
            JiheBtn.Enabled = false;
        }




        private void updateParamDataGrids()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add("NormalD_d", boltData.NormalD_d, "螺栓公称直径");
            dataGridView2.Rows.Add("ScrewP_P", boltData.ScrewP_P, "螺距");
            dataGridView2.Rows.Add("BoltLen_ls", boltData.BoltLen_ls, "螺杆长度");
            dataGridView2.Rows.Add("BoreD_dh", boltData.BoreD_dh, "镗孔直径");
            dataGridView2.Rows.Add("BoreD_dT", boltData.BoreD_dT, "");
            dataGridView2.Rows.Add("BoltHeadOutD_dw", boltData.BoltHeadOutD_dw, "螺栓头承载面外径");
            dataGridView2.Rows.Add("BoltHeadInnerD_da", boltData.BoltHeadInnerD_da, "螺栓头承载面内径");
            dataGridView2.Rows.Add("ScrewMidD_d2", boltData.ScrewMidD_d2, "螺纹中径");
            dataGridView2.Rows.Add("ScrewMinD_d3", boltData.ScrewMinD_d3, "螺纹小径");
            dataGridView2.Rows.Add("PolishRodLen_l1", boltData.PolishRodLen_l1, "光杆1长度");
            dataGridView2.Rows.Add("PolishRodLen_l2", boltData.PolishRodLen_l2, "光杆2长度");
            dataGridView2.Rows.Add("BoltNutSideWid_s", boltData.BoltNutSideWid_s, "螺母对边宽度");
            dataGridView2.Rows.Add("BoltNutScrewMinD_D1", boltData.BoltNutScrewMinD_D1, "螺母螺纹小径");

            if (boltData.boltMaterial != null)
            {
                dataGridView2.Rows.Add("BoltMaterialLevel", boltData.boltMaterial.BoltMaterialLevel, "强度等级");
                dataGridView2.Rows.Add("BoltMaterialRatio_fB", boltData.boltMaterial.BoltMaterialRatio_fB, "剪切强度系数");
                dataGridView2.Rows.Add("BoltMaterialEs", boltData.boltMaterial.BoltMaterialEs, "杨氏模量");
                dataGridView2.Rows.Add("BoltMaterialRpmin", boltData.boltMaterial.BoltMaterialRpmin, "最小屈服强度");
                dataGridView2.Rows.Add("BoltMaterialRm", boltData.boltMaterial.BoltMaterialRm, "抗拉强度");
            }
            
            if (clampedMaterial != null)
            {
                dataGridView2.Rows.Add("ClampedMaterialName", clampedMaterial.ClampedMaterialName, "连接件材料名");
                dataGridView2.Rows.Add("ClampedMaterialRatio_fB", clampedMaterial.ClampedMaterialRatio_fB, "连接件材料名");
                dataGridView2.Rows.Add("ClampedMaterialRatio_fG", clampedMaterial.ClampedMaterialRatio_fG, "连接件材料名");
                dataGridView2.Rows.Add("ClampedMaterialEp", clampedMaterial.ClampedMaterialEp, "连接件材料名");
                dataGridView2.Rows.Add("ClampedMaterialRmmin", clampedMaterial.ClampedMaterialRmmin, "连接件材料名");
            }
            
            if (jiHeParameters != null)
            {
                dataGridView2.Rows.Add("DA", jiHeParameters.DA, "接合面等效外径");
                dataGridView2.Rows.Add("DA_", jiHeParameters.DA_, "接合面上的面的等效外径");
                dataGridView2.Rows.Add("fz", jiHeParameters.fz, "嵌入深度");
                dataGridView2.Rows.Add("n", jiHeParameters.n, "载荷系数");

                if (jiHeParameters.PianXin != null)
                {
                    dataGridView2.Rows.Add("ssym", jiHeParameters.PianXin.ssym, "从0-0轴至螺栓轴的距离Ssym");
                    dataGridView2.Rows.Add("u", jiHeParameters.PianXin.u, "从0-0轴至开口处的距离u");
                    dataGridView2.Rows.Add("cB", jiHeParameters.PianXin.cB, "受弯体长度cB");
                    dataGridView2.Rows.Add("cT", jiHeParameters.PianXin.cT, "被连接件接合面长度cT");
                    dataGridView2.Rows.Add("b", jiHeParameters.PianXin.b, "受弯体宽度b");
                    dataGridView2.Rows.Add("bT", jiHeParameters.PianXin.bT, "被连接件接合面宽度bT");
                    dataGridView2.Rows.Add("e", jiHeParameters.PianXin.e, "从接合面带有张开风险的边缘至螺栓轴的距离e");
                    dataGridView2.Rows.Add("a", jiHeParameters.PianXin.a, "偏心距a");
                }
            }
            

            if (gongYiParameters != null)
            {
                dataGridView2.Rows.Add("Rz", gongYiParameters.Rz, "平均表面粗糙度");
                dataGridView2.Rows.Add("alphaA", gongYiParameters.alphaA, "拧紧系数");
                dataGridView2.Rows.Add("Ugmin", gongYiParameters.Ugmin, "螺纹接触面最小摩擦系数Ugmin");
                dataGridView2.Rows.Add("UTmin", gongYiParameters.UTmin, "被连接件接合面间最小摩擦系数UTmin");
                dataGridView2.Rows.Add("Ukmin", gongYiParameters.Ukmin, "螺栓头接触面最小摩擦系数Ukmin");

                if (gongYiParameters.jiaoBian != null)
                {
                    dataGridView2.Rows.Add("N", gongYiParameters.jiaoBian.N, "循环周期数");
                }
            }

            
        }

        private void GongYiBtn_Click(object sender, EventArgs e)
        {
            GongYiParamFrm form = new GongYiParamFrm();
            form.ShowDialog();
            GongYiParameters param = form.GetGongYiParams();
            if (param == null)
            {
                return;
            }
            gongYiParameters = param;
            updateParamDataGrids();
            form.Hide();
            GongYiBtn.Enabled = false;
        }
    }
}
