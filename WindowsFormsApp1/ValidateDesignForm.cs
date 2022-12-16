using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

using devDept.Eyeshot;
using devDept.Geometry;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Labels;
using System.Text;
using devDept.Graphics;
using devDept.Eyeshot.Fem;
using devDept.Eyeshot.Triangulation;
using System.Collections.Generic;
using devDept.Eyeshot.Translators;

using System.Threading.Tasks;
using WindowsApplication1;
using CreateBotSpring;
using WindowsFormsApp1.VDISolution;
using WindowsFormsApp1.StepCalForm;
using WindowsFormsApp1.report;
using System.Linq;
using Aspose.Html.Toolkit.Markdown.Syntax;
using Aspose.Html;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    // 无法显示垫片数据模型
    public partial class ValidateDesignForm : Form, ISolveResult
    {
        const double pi = 3.1415926;

        // 序列化工具
        private JavaScriptSerializer serializer = new JavaScriptSerializer();

        // 螺栓建模
        Bolt _bolt;
        // 螺栓数据
        public BoltClass bolt = new BoltClass();
        // 螺母数据
        public NutClass nut;
        // 垫片数据
        public GasketClass gasket;
        public GasketClass gasket2;
        public ComputeResult rs = new ComputeResult();
        public Solution solution;
        List<GasketClass> gasketList = new List<GasketClass>();


        //public MaterialChooseClass material; // matrial Bolt
        public BoltChooseClass boltChooseClass;

        BoltChooseForm boltChooseForm;
        StrengthGradeForm strengthGradeForm;
        //ComputeResult rs;

        //ClampedClass _clamped;
        private Entity _boltEntity;
        //private List<Entity> _nutEntity;
        //private List<Entity> _gasketEntity;
        //private List<Entity> _clampedEntity;

        //private Entity _clampedEntity;


        public double getBoltHeight()
        {
            gasketChooseBtn.Checked = false;
            dataClampedChoosed.Rows.Clear();
            return boltChooseClass.BoltLen_ls;
        }

        public ValidateDesignForm()
        {
            InitializeComponent();
            // event handlers
            simulation1.SelectionChanged += new Model.SelectionChangedEventHandler(simulation1_SelectionChanged);
            simulation1.Viewports[0].LabelSelectionChanged += new Model.SelectionChangedEventHandler(viewportZero_LabelSelectionChanged);
            simulation1.WorkCompleted += new devDept.Eyeshot.Model.WorkCompletedEventHandler(simulation1_WorkCompleted);
            simulation1.WorkCancelled += new devDept.Eyeshot.Model.WorkCancelledEventHandler(simulation1_WorkCancelled);
            simulation1.WorkFailed += new devDept.Eyeshot.Model.WorkFailedEventHandler(simulation1_WorkFailed);
            simulation1.OriginSymbol.Visible = false;
            simulation1.ToolBar.Visible = false;
            simulation1.Grid.AutoSize = true;
            simulation1.Grid.AutoStep = true;
            simulation1.Grid.FillColor = Color.FromArgb(150, 123, 123, 123);
            simulation1.ViewCubeIcon.Visible = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            simulation1.MagnifyingGlass.Factor = 3;
            simulation1.MagnifyingGlass.Size = new Size(200, 200);

            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e)
        {
            simulation1.Focus();
            base.OnShown(e);
        }

        // 选择螺栓--实例化螺栓模型实体 ——bolt，如果选择通孔，也会实例化nut数据模型
        public void updateData()
        {
            boltChooseClass = boltChooseForm.GetBoltChooseClass();
            boltStd.Text = boltChooseClass.std;
            boringDh.Text = boltChooseClass.NormalD_d.ToString();
            ScrewLengthls.Text = boltChooseClass.BoltLen_ls.ToString();
            _bolt = new Bolt(boltChooseClass);

            if (BoltType.Text == "内六角螺栓")
            {

            }
            else if (BoltType.Text == "外六角螺栓")
            {
                dt.Text = boltChooseForm.GetBoltChooseClass().NormalD_d.ToString();
            }

            if (BoltType == null)
            {

            }
            else
            {
                showBoltModel(Color.Red);
            }
            if (BoltConnectType.Text == "盲孔螺栓连接")
            {

            }
            else if (BoltConnectType.Text == "通孔螺栓连接")
            {
                nut = NutData(boltChooseClass);
                showNutModel(Color.Red);
            }

            if (gasketChooseBtn.Checked == true)
            {
                this.gasket = GasketData();
                showGasketModel(gasket, Color.Cyan);
            }
            else
            {

            }
        }

        public void updateDataMaterial(BoltMaterialClass material)
        {
            boltChooseClass.boltMaterial = material;
            Es_yangshi.Text = material.BoltMaterialEs.ToString();
            Rpmin_qufu.Text = material.BoltMaterialRpmin.ToString();
            Rm_kangla.Text = material.BoltMaterialRm.ToString();
            fBS.Text = material.BoltMaterialRatio_fB.ToString();
        }

        private void ValidateDesignForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet19.dbo_materialClamped”中。您可以根据需要移动或删除它。
            //this.dbo_materialClampedTableAdapter1.Fill(this.boltConnectionSystemDataSet19.dbo_materialClamped);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet18.dbo_materialClamped”中。您可以根据需要移动或删除它。
            this.dbo_materialClampedTableAdapter.Fill(this.boltConnectionSystemDataSet18.dbo_materialClamped);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet9.materialClamped”中。您可以根据需要移动或删除它。
            //this.materialClampedTableAdapter.Fill(this.boltConnectionSystemDataSet9.materialClamped);

        }


        #region mode

        #region DisplayMode
        private void UpdateDisplayModeButtons()
        {
            // syncs the shading buttons with the current display mode.
            switch (simulation1.DisplayMode)
            {
                case displayType.Wireframe:
                    wireframeButton.Checked = true;
                    break;
                case displayType.Shaded:
                    shadedButton.Checked = true;
                    break;
                case displayType.Rendered:
                    renderedButton.Checked = true;
                    break;
                case displayType.Flat:
                    flatButton.Checked = true;
                    break;
                case displayType.HiddenLines:
                    hiddenLinesButton.Checked = true;
                    break;
            }
        }

        private void wireframeButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.Wireframe);
            SetDisplayMode(simulation1, displayType.Wireframe);
        }

        private void shadedButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.Shaded);
        }

        private void renderedButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.Rendered);
        }

        private void hiddenLinesButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.HiddenLines);
        }

        private void flatButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.Flat);
        }

        public static void SetDisplayMode(Model simulation, displayType displayType)
        {
            simulation.DisplayMode = displayType;
            SetBackgroundStyleAndColor(simulation);
            simulation.Entities.UpdateBoundingBox(); // Updates simplified representation (when available)
            simulation.Invalidate();
        }

        public static void SetBackgroundStyleAndColor(Model simulation)
        {
            simulation.CoordinateSystemIcon.Lighting = false;
            simulation.ViewCubeIcon.Lighting = false;

            switch (simulation.DisplayMode)
            {

                case displayType.HiddenLines:
                    simulation.Background.TopColor = Color.FromArgb(0xD2, 0xD0, 0xB9);

                    simulation.CoordinateSystemIcon.Lighting = true;
                    simulation.ViewCubeIcon.Lighting = true;

                    break;

                default:
                    simulation.Background.TopColor = Color.Snow;
                    break;
            }

            simulation.CompileUserInterfaceElements();
        }

        #endregion

        #region View

        private void isoViewButton_Click(object sender, EventArgs e)
        {
            simulation1.SetView(viewType.Isometric, true, simulation1.AnimateCamera);
            simulation1.Invalidate();
        }

        private void frontViewButton_Click(object sender, EventArgs e)
        {
            simulation1.SetView(viewType.Front, true, simulation1.AnimateCamera);
            simulation1.Invalidate();
        }

        private void sideViewButton_Click(object sender, EventArgs e)
        {
            simulation1.SetView(viewType.Right, true, simulation1.AnimateCamera);
            simulation1.Invalidate();
        }

        private void topViewButton_Click(object sender, EventArgs e)
        {
            simulation1.SetView(viewType.Top, true, simulation1.AnimateCamera);
            simulation1.Invalidate();
        }

        private void prevViewButton_Click(object sender, EventArgs e)
        {
            simulation1.PreviousView();
            simulation1.Invalidate();
        }

        private void nextViewButton_Click(object sender, EventArgs e)
        {
            simulation1.NextView();
            simulation1.Invalidate();
        }

        private void animateCameraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.AnimateCamera = animateCameraCheckBox.Checked;
        }

        #endregion

        #region Hide/Show

        private void showOriginButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.OriginSymbol.Visible = showOriginButton.Checked;
            simulation1.Invalidate();
        }

        private void showExtentsButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.BoundingBox.Visible = showExtentsButton.Checked;
            simulation1.Invalidate();
        }

        private void showVerticesButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.ShowVertices = showVerticesButton.Checked;
            simulation1.Invalidate();
        }

        private void showGridButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.Grid.Visible = showGridButton.Checked;
            simulation1.Invalidate();
        }

        #endregion

        #region Event handlers

        private void simulation1_SelectionChanged(object sender, devDept.Eyeshot.Environment.SelectionChangedEventArgs e)
        {
            int count = 0;
            // counts selected entities
            foreach (Entity ent in simulation1.Entities)
                if (ent.Selected)
                    count++;
            object[] selected = new object[count];
            count = 0;

            // fills selected array
            foreach (Entity ent in simulation1.Entities)
                if (ent.Selected)
                    selected[count++] = ent;

        }

        private void viewportZero_LabelSelectionChanged(object sender, devDept.Eyeshot.Environment.SelectionChangedEventArgs e)
        {
            int count = 0;

            // counts selected entities
            foreach (devDept.Eyeshot.Labels.Label lbl in simulation1.Viewports[0].Labels)

                if (lbl.Selected)

                    count++;

            object[] selected = new object[count];

            count = 0;

            // fills selected array
            foreach (devDept.Eyeshot.Labels.Label lbl in simulation1.Viewports[0].Labels)

                if (lbl.Selected)

                    selected[count++] = lbl;
        }

        private void simulation1_WorkCompleted(object sender, WorkCompletedEventArgs e)
        {
            if (e.WorkUnit is ReadFileAsync)
            {
                ReadFileAsync rfa = (ReadFileAsync)e.WorkUnit;

                rfa.AddToScene(simulation1);
                simulation1.ZoomFit();
            }
            else if (e.WorkUnit is SolverBase)
            {

                SolverBase solver = (SolverBase)e.WorkUnit;

                FemMesh fm = solver.Mesh;

                // computes the selected plot
                fm.PlotMode = FemMesh.plotType.Tresca;

                fm.NodalAverages = true;

                fm.ComputePlot(simulation1, simulation1.Legends[0]);

                simulation1.ZoomFit();
            }
            UpdateDisplayModeButtons();
        }

        private void simulation1_WorkFailed(object sender, WorkFailedEventArgs e)
        {
            EnableControls();
        }

        private void EnableControls()
        {
            //tabControl1.Enabled = true;
        }

        private void simulation1_WorkCancelled(object sender, EventArgs e)
        {

            EnableControls();
        }

        #endregion

        #endregion

        #region DB_OPT

        public string[] Table(int index)
        {
            string sql = "select introGroup,introLabel from dbo_IntroDetailTable where introindex=" + index;
            string introGroupDetail = "", introLabelDetail = "";
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            if (dr.Read())
            {
                introGroupDetail = dr["introGroup"].ToString();
                introLabelDetail = dr["introLabel"].ToString();
            }
            dr.Close();//关闭连接
            string[] res = { introGroupDetail, introLabelDetail };
            return res;
        }

        #endregion

        #region data_event

        #region bolt_clamped_createModel

        // 螺栓模型 换螺栓
        private void showBoltModel(Color color)
        {
            // 第一次调用是在update  选择螺栓数据中new的Bolt(boltChooseClass)
            if (boltChooseClass == null)
            {
                throw new Exception("bolt is null");
            }
            simulation1.Entities.Clear();
            simulation1.Enabled = true;
            try
            {
                _boltEntity = _bolt.GetEntity();
                simulation1.Entities.Add(_boltEntity, color);
                simulation1.ZoomFit();
                simulation1.Invalidate();

                // 清空连接件
                dataClampedChoosed.Rows.Clear();
                clampedList.Clear();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }

        // 不换螺栓的时候调用
        private void showBoltModelNotClear(Color color)
        {
            if (boltChooseClass == null)
            {
                throw new Exception("bolt is null");
            }
            try
            {
                _boltEntity = _bolt.GetEntity();
                simulation1.Entities.Add(_boltEntity, color);
                simulation1.ZoomFit();
                simulation1.Invalidate();

                //// 清空连接件
                //dataClampedChoosed.Rows.Clear();
                //clampedList.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }

        // 连接件
        List<ClampedClass> clampedList = new List<ClampedClass>();

        // 添加连接件
        private void addButton_Click(object sender, EventArgs e)
        {
            if (boltChooseClass == null)
            {
                MessageBox.Show("请先选择螺栓！");
                return;
            }
            else
            {
                string[] str = {
                    dataClamped.SelectedCells[0].Value.ToString(),
                    dataClamped.SelectedCells[1].Value.ToString(),
                    dataClamped.SelectedCells[2].Value.ToString(),
                    dataClamped.SelectedCells[3].Value.ToString(),
                    dataClamped.SelectedCells[4].Value.ToString(),
                };
                dataClampedChoosed.Rows.Add(str);
                if (boltChooseClass == null)
                {
                    return;
                }
                ClampedClass clamped = new ClampedClass(0, boltChooseClass.NormalD_d * 5);
                clamped.clampedMaterial.ClampedMaterialName = dataClamped.SelectedCells[0].Value.ToString();
                clamped.clampedMaterial.ClampedMaterialEp = double.Parse(dataClamped.SelectedCells[1].Value.ToString());
                clamped.clampedMaterial.ClampedMaterialRmmin = double.Parse(dataClamped.SelectedCells[2].Value.ToString());
                clamped.clampedMaterial.ClampedMaterialRatio_fG = double.Parse(dataClamped.SelectedCells[3].Value.ToString());
                clamped.clampedMaterial.ClampedMaterialRatio_fB = double.Parse(dataClamped.SelectedCells[4].Value.ToString());

                clampedList.Add(clamped);
            }
        }

        // 添加连接件之后要编辑连接件高度，最后会触发渲染，当前选定单元格的模式停止时触发
        private void dataClampedChoosed_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //只要改了一个高度，就将列表中所有连接件offset更新
            // 同时更新nut gasket的offsetz
            // 显示的时候，清除螺栓，重新绘制

            // 第一次add上填写没问题
            double total = boltChooseClass.BoltLen_ls;

            if (dataClampedChoosed.CurrentRow.Cells[5].Value == null)
            {
                return;
            }
            // 这一行的连接件的高度设置----放在上面
            clampedList[dataClampedChoosed.CurrentRow.Index].Height = double.Parse(dataClampedChoosed.CurrentRow.Cells[5].Value.ToString()); // 必须是同一行
            CalClampedOffsetz();

            if (gasketChooseBtn.Checked == true)
            {
                CalGasketOffsetz(); // 第二个垫片要看好
            }

            if (BoltConnectType.Text == "通孔螺栓连接")
            {
                CalDownNutOffsetZ(); // 关键在螺母上 下面那个
            }

            FlushModel();

        }

        private void FlushModel()
        {
            simulation1.Entities.Clear();
            showBoltModelNotClear(Color.Red);
            if (this.nut != null && BoltConnectType.Text == "通孔螺栓连接")
            {
                showNutModel(Color.Red);
            }

            // 绘制偏移后的模型
            for (int i = 0; i < clampedList.Count; i++)
            {
                if (clampedList[i].Height == 0)
                {
                    continue;
                }
                showClampedModel(clampedList[i], Color.Blue);
            }
            if (this.gasket != null)
            {
                showGasketModel(this.gasket, Color.Cyan);
                if (this.gasket2 != null)
                {
                    showGasketModel(this.gasket2, Color.Cyan);
                }
            }
        }

        private void showClampedModel(ClampedClass clamped, Color color)
        {
            if (clamped == null || clampedList.Count == 0)
            {
                MessageBox.Show("请先选择螺栓！");
                throw new Exception("clamped is null");
            }

            try
            {
                Entity clampedEntity = clamped.GetEntity();
                simulation1.Entities.Add(clampedEntity, color);
                simulation1.ZoomFit();
                simulation1.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }

        // 通孔螺栓连接才能调用  计算下面那个螺母的偏移
        private void CalDownNutOffsetZ()
        {
            double height = 0;
            // 有螺母 有垫片 垫片绝对是两个 下面螺母的偏移要注意
            if (gasketChooseBtn.Checked == true)
            {
                height += (this.gasket.Boltheaddowngasketheight_hs1);
                height += (this.gasket.Boltheaddowngasketheight_hs1);
            }

            if (clampedList.Count != 0)
            {
                height += CalClampedHeightAll();
            }
            this.nut.Offsetz = this.boltChooseClass.BoltLen_ls - height - this.nut.NutHeight;
        }

        private void CalClampedOffsetz()
        {
            // 计算所有连接件的偏移 从list中算
            if (clampedList.Count != 0)
            {
                // 有连接件
                double height = 0;
                if (gasketChooseBtn.Checked == true)
                {
                    // 有垫片 算最上面那个就行
                    height += gasket.Boltheaddowngasketheight_hs1;
                }
                for (int i = 0; i < clampedList.Count; i++)
                {
                    double sub = 0;
                    for (int j = 0; j <= i; j++)
                    {
                        sub += clampedList[j].Height;
                    }
                    clampedList[i].Offsetz = boltChooseClass.BoltLen_ls - sub - height;
                }
            }
        }

        // 计算连接件的总厚度
        private double CalClampedHeightAll()
        {
            double height = 0;
            if (clampedList.Count != 0)
            {
                for (int i = 0; i < clampedList.Count; i++)
                {
                    height += clampedList[i].Height;
                }
            }
            return height;
        }

        // 计算垫片的偏移
        private void CalGasketOffsetz()
        {
            this.gasket.offsetz = boltChooseClass.BoltLen_ls - gasket.Boltheaddowngasketheight_hs1;

            if (BoltConnectType.Text == "通孔螺栓连接")
            {
                if (this.gasket2 == null)
                {
                    this.gasket2 = new GasketClass(this.gasket);
                }
                this.gasket2.offsetz = boltChooseClass.BoltLen_ls - CalClampedHeightAll() - 2 * this.gasket.Boltheaddowngasketheight_hs1;
            }
        }

        // 删除连接件
        private void delButton_Click(object sender, EventArgs e)
        {
            if (boltChooseClass == null)
            {
                MessageBox.Show("请先选择螺栓！");
                return;
            }
            else if (clampedList.Count == 0)
            {
                MessageBox.Show("没有可删除的连接件！");
                return;
            }
            else
            {
                // 删除选定行
                int idx = dataClampedChoosed.SelectedCells[0].RowIndex;
                clampedList.RemoveAt(idx);
                dataClampedChoosed.Rows.RemoveAt(idx);

                CalOffsetZ();
                FlushModel();
            }
        }

        #endregion

        #region nut_model
        private void displayNutText(NutClass nut)
        {
            Daz.Text = nut.NutBearMinD.ToString();
            Dw.Text = nut.NutBearOutD.ToString();
            m.Text = nut.NutHeight.ToString();
        }

        private NutClass NutData(BoltChooseClass boltChooseClass)
        {
            NutClass nut = new NutClass();
            string sql = "select isnut, nutindex from dbo_BoltTable " +
                    "where normalD_d=" + boltChooseClass.NormalD_d
                    + " and screwP_P=" + boltChooseClass.ScrewP_P
                    + " and boreD_dh=" + boltChooseClass.BoreD_dh
                    + " and boltHeadOutD_dw=" + boltChooseClass.BoltHeadOutD_dw
                    + " and screwMidD_d2=" + boltChooseClass.ScrewMidD_d2
                    + " and screwMinD_d3=" + boltChooseClass.ScrewMinD_d3
                    + " and polishRodLen_l1=" + boltChooseClass.PolishRodLen_l1
                    + " and boltNutScrewMinD_D1=" + boltChooseClass.BoltNutScrewMinD_D1
                    + " and boltHeadInnerD_da=" + boltChooseClass.BoltHeadInnerD_da;
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            if (dr.Read())
            {
                string isnut, nutIndex;
                isnut = dr["isnut"].ToString();
                if (isnut.Equals("1"))
                {
                    //有螺母的
                    nutIndex = dr["nutIndex"].ToString();
                    string sql2 = "select * from dbo_nutTable where nutIndex=" + nutIndex;
                    IDataReader dr2 = dao.read(sql2);

                    if (dr2.Read())
                    {
                        string nutSpeci, nutStd, nutNutSideWid, nutBearMinD, nutBearMaxD, nutBearOutD, nutHeight;

                        nutStd = dr2["nutStd"].ToString();
                        nutSpeci = dr2["nutSpeci"].ToString();
                        nutNutSideWid = dr2["nutNutSideWid_s"].ToString();
                        nutBearMinD = dr2["nutBearMinD_Damin"].ToString();
                        nutBearMaxD = dr2["nutBearMaxD_Damax"].ToString();
                        nutBearOutD = dr2["nutBearOutD_dwmu"].ToString();
                        nutHeight = dr2["nutHeight_m"].ToString();

                        nut.NutSpeci = nutSpeci;
                        nut.NutStd = nutStd;
                        nut.NutNutSideWid = double.Parse(nutNutSideWid);
                        nut.NutBearMinD = double.Parse(nutBearMinD);
                        nut.NutBearMaxD = double.Parse(nutBearMaxD);
                        nut.NutBearOutD = double.Parse(nutBearOutD);
                        nut.NutHeight = double.Parse(nutHeight);
                    }
                    dr2.Close();
                }
            }
            dr.Close();
            return nut;
        }

        private void showNutModel(Color color)
        {
            if (nut == null && BoltType.Text == "盲孔螺栓连接")
            {
                throw new Exception("bolt is null");
            }
            //model1.Entities.Clear();
            //model1.Enabled = true;
            try
            {
                Entity nutEntity = nut.GetEntity();
                simulation1.Entities.Add(nutEntity, color);
                simulation1.ZoomFit();
                simulation1.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }

        #endregion

        #region gasketModel
        private GasketClass GasketData()
        {
            GasketClass gasketTemp = new GasketClass();
            string sql = "select isgasket, gasketindex from dbo_BoltTable " +
                    "where normalD_d=" + boltChooseClass.NormalD_d
                    + " and screwP_P=" + boltChooseClass.ScrewP_P
                    + " and boreD_dh=" + boltChooseClass.BoreD_dh
                    + " and boltHeadOutD_dw=" + boltChooseClass.BoltHeadOutD_dw
                    + " and screwMidD_d2=" + boltChooseClass.ScrewMidD_d2
                    + " and screwMinD_d3=" + boltChooseClass.ScrewMinD_d3
                    + " and polishRodLen_l1=" + boltChooseClass.PolishRodLen_l1
                    + " and boltNutScrewMinD_D1=" + boltChooseClass.BoltNutScrewMinD_D1
                    + " and boltHeadInnerD_da=" + boltChooseClass.BoltHeadInnerD_da;
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            if (dr.Read())
            {
                string isgasket, gasketIndex;
                isgasket = dr["isgasket"].ToString();
                if (isgasket.Equals("1"))
                {
                    //有垫片的
                    gasketIndex = dr["gasketIndex"].ToString();
                    string sql2 = "select * from dbo_gaskettable where gasketIndex=" + gasketIndex;
                    IDataReader dr2 = dao.read(sql2);

                    if (dr2.Read())
                    {
                        string gasketstd, gasketinnerD_dhas, gasketoutD_DA, boltheaddowngasketheight_hs1, nutdowngasketheight_hs2;

                        gasketstd = dr2["gasketstd"].ToString();
                        gasketinnerD_dhas = dr2["gasketinnerD_dhas"].ToString();
                        gasketoutD_DA = dr2["gasketoutD_DA"].ToString();
                        boltheaddowngasketheight_hs1 = dr2["boltheaddowngasketheight_hs1"].ToString();
                        nutdowngasketheight_hs2 = dr2["nutdowngasketheight_hs2"].ToString();

                        gasketTemp.Gasketstd = gasketstd;
                        gasketTemp.GasketinnerD_dhas = double.Parse(gasketinnerD_dhas);
                        gasketTemp.GasketoutD_DA = double.Parse(gasketoutD_DA);
                        gasketTemp.Boltheaddowngasketheight_hs1 = double.Parse(boltheaddowngasketheight_hs1);
                        gasketTemp.Nutdowngasketheight_hs2 = double.Parse(nutdowngasketheight_hs2);
                    }
                    dr2.Close();
                }
            }
            dr.Close();
            return gasketTemp;
        }

        private void gasketChooseBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (gasketChooseBtn.Checked == true)
            {
                if (boltChooseClass == null)
                {
                    MessageBox.Show("notbolt");
                    gasketChooseBtn.Checked = false;
                    return;
                }
                else
                {
                    if (clampedList.Count == 0)
                    {
                        MessageBox.Show("not clamped");
                        gasketChooseBtn.Checked = false;
                        return;
                    }
                    else
                    {
                        // 有螺栓，有连接件， 选择了垫片
                        this.gasket = GasketData();
                        if (BoltConnectType.Text == "通孔螺栓连接")
                        {
                            // 有nut
                            this.gasket2 = new GasketClass(this.gasket);
                        }
                    }
                }
                dhas.Text = gasket.GasketinnerD_dhas.ToString();
                dau.Text = gasket.GasketoutD_DA.ToString();
                hs2.Text = gasket.Nutdowngasketheight_hs2.ToString();
            }
            else
            {
                // 关闭垫片的时候
                this.gasket = null;
                this.gasket2 = null;
                dhas.Text = "";
                dau.Text = "";
                hs2.Text = "";
            }
            CalOffsetZ();
            FlushModel();
        }

        private void CalOffsetZ()
        {
            if (this.gasket != null)
            {
                CalGasketOffsetz();
            }
            if (clampedList.Count != 0)
            {
                CalClampedOffsetz();
            }
            if (nut != null)
            {
                CalDownNutOffsetZ();
            }
        }

        private void BoltConnectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoltConnectType.Text == "通孔螺栓连接")
            {
                if (boltChooseClass != null)
                {
                    this.nut = NutData(boltChooseClass);
                }
            }
            else
            {
                this.nut = null;
                this.gasket2 = null;
            }
            if (boltChooseClass != null)
            {
                CalOffsetZ();
                FlushModel();
            }
        }

        private void showGasketModel(GasketClass myGasket, Color color)
        {
            // 只有螺栓头，一个垫片
            if (myGasket == null)
            {
                throw new Exception("_gasket is null");
            }
            try
            {
                Entity entity = myGasket.GetEntity();
                simulation1.Entities.Add(entity, color);
                simulation1.ZoomFit();
                simulation1.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }

        #endregion


        #region clickBtn
        private void boltConnect_Click(object sender, EventArgs e)
        {
            introGroup.Visible = true;
            string[] intro = Table(1);
            introGroup.Text = intro[0];
            introLabel.Text = intro[1];
        }

        private void DA_Click(object sender, EventArgs e)
        {
            introGroup.Visible = true;
            string[] intro = Table(2);
            introGroup.Text = intro[0];
            introLabel.Text = intro[1];
        }

        private void DA2_Click(object sender, EventArgs e)
        {
            introGroup.Visible = true;
            string[] intro = Table(3);
            introGroup.Text = intro[0];
            introLabel.Text = intro[1];
        }

        private void strengthGradeChooseBtn_Click(object sender, EventArgs e)
        {
            if (boltChooseClass == null)
            {
                MessageBox.Show("请先选择螺栓");
                return;
            }
            strengthGradeForm = new StrengthGradeForm(this);
            strengthGradeForm.ShowDialog();
        }
        #endregion

        #region selected_changed

        private void BoltType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoltType.Text == "内六角螺栓")
            {
                dtLabel.Visible = false;
                dtUnit.Visible = false;
                dt.Visible = false;
            }
            else if (BoltType.Text == "外六角螺栓")
            {
                dtLabel.Visible = true;
                dtUnit.Visible = true;
                dt.Visible = true;
            }
        }

        private void isAngle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isAngle.Text == "考虑")
            {
                dha.ReadOnly = false;
            }
            else if (isAngle.Text == "不考虑")
            {
                dha.Clear();
                dha.ReadOnly = true;
            }
        }

        private void isCounterBore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isCounterBore.Text == "考虑")
            {
                CounterBoreDepth.ReadOnly = false;
            }
            else if (isCounterBore.Text == "不考虑")
            {
                CounterBoreDepth.Clear();
                CounterBoreDepth.ReadOnly = true;
            }
        }

        //private void pEmbeddedValue_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (pEmbeddedValue.Text == "考虑")
        //    {
        //        EmbeddedValue.ReadOnly = false;
        //    }
        //    else if (pEmbeddedValue.Text == "不考虑")
        //    {
        //        EmbeddedValue.Clear();
        //        EmbeddedValue.ReadOnly = true;
        //    }
        //}

        private void boltChooseBtn_Click_1(object sender, EventArgs e)
        {
            boltChooseForm = new BoltChooseForm(this);
            boltChooseForm.ShowDialog();
        }

        private void isFkerf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFkerf.Text == "选择")
            {
                Fkerf.ReadOnly = false;
            }
            else if (isFkerf.Text == "不选择")
            {
                Fkerf.Clear();
                Fkerf.ReadOnly = true;
            }
        }

        private void tighten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tighten.Text == "自定义输入")
            {
                // 开启
                tightenCoef.ReadOnly = false;
            }
            else if (tighten.Text == "屈服控制拧紧")
            {
                // Fkerf.Clear();
                tightenCoef.ReadOnly = true;
            }
        }

        private void isN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isN.Text == "自定义")
            {
                n.ReadOnly = false;  // 自由输入
                sv.Enabled = false;  // 禁止编辑sv
                lA.ReadOnly = true;
                ak.ReadOnly = true;
            }
            else if (isN.Text == "默认")
            {
                n.Clear();
                n.ReadOnly = true;
                sv.Enabled = true;
                lA.ReadOnly = false;
                ak.ReadOnly = false;
            }
        }

        private void isFORM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFORM.Text == "不")
            {
                Fmzul.Clear();
                v.ReadOnly = false;
                Fmzul.ReadOnly = true;
            }
            else if (isFORM.Text == "预定FMzul")
            {
                v.Clear();
                v.ReadOnly = true;
                Fmzul.ReadOnly = false;
            }
        }

        private void workingLoads_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workingLoads.Text == "静态")
            {
                // fao false
                // fau true
                FAO.Clear();
                fau.Clear();
                FAO.ReadOnly = false;
                fau.ReadOnly = true;
                zhazhi.Enabled = false;
                ifZhouqiN.Enabled = false;
                zhouqiN.Enabled = false;
            }
            else if (workingLoads.Text == "动态")
            {
                FAO.Clear();
                fau.Clear();
                FAO.ReadOnly = false;
                fau.ReadOnly = false;
                zhazhi.Enabled = true;
                ifZhouqiN.Enabled = true;
                // zhouqiN的打开受if控制
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFz.Text == "是")
            {
                fz.ReadOnly = false;
            }
            else
            {
                fz.ReadOnly = true;
                fz.Text = "";
            }
        }

        private void saveTempData_Click(object sender, EventArgs er)
        {
            // strFileName 是文件的路径+文件名
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JSON文件(*.json)|*.json";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //设置默认的文件名
            sfd.FileName = "YourFileName";
            string localFilePath = "";
            string fileNameExt = "";
            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径
            }

            SaveData s = new SaveData();
            s.clampingWay = clampingWay.Text;
            s.BoltConnectType = BoltConnectType.Text;
            s.boltConnect = boltConnectLoad.Text;
            s.DA = DA.Text;
            s.DA2 = DA2.Text;
            s.dataSource = dataSource.Text;
            s.screwType = screwType.Text;
            s.BoltType = BoltType.Text;
            //s.boltStd = boltStd.Text;
            //s.boringDh = boringDh.Text;
            //s.ScrewLengthls = ScrewLengthls.Text;
            //s.beta = beta.Text;
            //s.dt = dt.Text;
            //s.Es_yangshi = Es_yangshi.Text;
            //s.Rpmin_qufu = Rpmin_qufu.Text;
            //s.Rm_kangla = Rm_kangla.Text;
            //s.gasketChoose = gasketChoose.Text;
            s.dhas = dhas.Text;
            s.dau = dau.Text;
            s.hs2 = hs2.Text;
            s.isAngle = isAngle.Text;
            s.dha = dha.Text;
            s.isCounterBore = isCounterBore.Text;
            s.CounterBoreDepth = CounterBoreDepth.Text;
            //s.pEmbeddedValue = pEmbeddedValue.Text;
            s.surfaceRoughness = Rz.Text;
            //s.EmbeddedValue = EmbeddedValue.Text;
            s.Es_gasket = Es_gasket.Text;
            s.RmminS = RmminS.Text;
            s.Daz = Daz.Text;
            s.Dw = Dw.Text;
            s.m = m.Text;
            s.workingLoads = workingLoads.Text;
            s.FAO = FAO.Text;
            s.fau = fau.Text;
            s.a = a.Text;
            s.isFkerf = isFkerf.Text;
            s.Fkerf = Fkerf.Text;
            s.MB = MB.Text;
            s.tighten = tighten.Text;
            s.tightenCoef = tightenCoef.Text;
            s.UGmin = UGmin.Text;
            s.UKmin = UKmin.Text;
            s.Ts = Ts.Text;
            s.Tp = Tp.Text;
            s.isN = isN.Text;
            s.n = n.Text;
            s.sv = sv.Text;
            s.lA = lA.Text;
            s.ak = ak.Text;
            s.isFORM = isFORM.Text;
            s.v = v.Text;
            s.Fmzul = Fmzul.Text;
            s.isFz = isFz.Text;
            s.fz = fz.Text;
            // 剪切
            s.ifDt = ifDt.Text;
            s.dtau = dtau.Text;
            s.isMt = isMt.Text;
            s.Mt = Mt.Text;
            s.ifRa = ifRa.Text;
            s.ra = ra.Text;
            s.Dhamax = Dhamax.Text;
            s.FQ = FQ.Text;
            s.UTmin = UTmin.Text;
            s.isSGsoll = isSGsoll.Text;
            s.SGsoll = SGsoll.Text;

            // 偏心
            s.Ssym = Ssym.Text;
            s.u = u.Text;
            s.cB = cB.Text;
            s.cT = cT.Text;
            s.b = b.Text;
            s.bT = bT.Text;
            s.isIbt = isIbt.Text;
            s.Ibt = Ibt.Text;
            s.e = e.Text;
            s.jiaZaiQingKuang = jiaZaiQingKuang.Text;
            s.qM = qM.Text;
            s.ifa = ifa.Text;

            s.zhazhi = zhazhi.Text;
            s.ifZhouqiN = ifZhouqiN.Text;
            s.zhouqiN = zhouqiN.Text;
            s.AD = AD.Text;

            try
            {
                string out1 = serializer.Serialize(s);
                File.WriteAllText(localFilePath, out1);
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败，请检查！");
                return;
            }
        }

        private void readTempData_Click(object sender, EventArgs er)
        {
            // strFileName 是文件的路径+文件名
            string strFileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON文件(*.json)|*.json";
            ofd.ValidateNames = true; // 验证用户输入是否是一个有效的Windows文件名
            ofd.CheckFileExists = true; //验证路径的有效性
            ofd.CheckPathExists = true;//验证路径的有效性
            if (ofd.ShowDialog() == DialogResult.OK) //用户点击确认按钮，发送确认消息
            {
                strFileName = ofd.FileName;//获取在文件对话框中选定的路径或者字符串
            }
            try
            {
                string JSONstring = File.ReadAllText(strFileName);
                SaveData s = serializer.Deserialize<SaveData>(JSONstring);
                clampingWay.Text = s.clampingWay;
                BoltConnectType.Text = s.BoltConnectType;
                Console.WriteLine(s.BoltConnectType);
                boltConnectLoad.Text = s.boltConnect;
                DA.Text = s.DA;
                DA2.Text = s.DA2;
                dataSource.Text = s.dataSource;
                screwType.Text = s.screwType;
                BoltType.Text = s.BoltType;
                //boltStd.Text = s.boltStd;
                //boringDh.Text = s.boringDh;
                //ScrewLengthls.Text = s.ScrewLengthls;
                //beta.Text = s.beta;
                //dt.Text = s.dt;
                //Es_yangshi.Text = s.Es_yangshi;
                //Rpmin_qufu.Text = s.Rpmin_qufu;
                //Rm_kangla.Text = s.Rm_kangla;
                //gasketChoose.Text = s.gasketChoose;
                dhas.Text = s.dhas;
                dau.Text = s.dau;
                hs2.Text = s.hs2;
                isAngle.Text = s.isAngle;
                dha.Text = s.dha;
                isCounterBore.Text = s.isCounterBore;
                CounterBoreDepth.Text = s.CounterBoreDepth;
                //pEmbeddedValue.Text = s.pEmbeddedValue;
                Rz.Text = s.surfaceRoughness;
                //EmbeddedValue.Text = s.EmbeddedValue;
                Es_gasket.Text = s.Es_gasket;
                RmminS.Text = s.RmminS;
                Daz.Text = s.Daz;
                Dw.Text = s.Dw;
                m.Text = s.m;
                workingLoads.Text = s.workingLoads;
                FAO.Text = s.FAO;
                fau.Text = s.fau;
                a.Text = s.a;
                isFkerf.Text = s.isFkerf;
                Fkerf.Text = s.Fkerf;
                MB.Text = s.MB;
                tighten.Text = s.tighten;
                tightenCoef.Text = s.tightenCoef;
                UGmin.Text = s.UGmin;
                UKmin.Text = s.UKmin;
                Ts.Text = s.Ts;
                Tp.Text = s.Tp;
                isN.Text = s.isN;
                n.Text = s.n;
                sv.Text = s.sv;
                lA.Text = s.lA;
                ak.Text = s.ak;
                isFORM.Text = s.isFORM;
                v.Text = s.v;
                Fmzul.Text = s.Fmzul;
                isFz.Text = s.isFz;
                fz.Text = s.fz;
                // 剪切
                ifDt.Text = s.ifDt;
                dtau.Text = s.dtau;
                isMt.Text = s.isMt;
                Mt.Text = s.Mt;
                ifRa.Text = s.ifRa;
                ra.Text = s.ra;
                Dhamax.Text = s.Dhamax;
                FQ.Text = s.FQ;
                UTmin.Text = s.UTmin;
                isSGsoll.Text = s.isSGsoll;
                SGsoll.Text = s.SGsoll;

                // 偏心
                Ssym.Text = s.Ssym;
                u.Text =s.u;
                cB.Text = s.cB;
                cT.Text = s.cT;
                b.Text = s.b;
                bT.Text = s.bT;
                isIbt.Text =s.isIbt;
                Ibt.Text = s.Ibt;
                e.Text = s.e;
                jiaZaiQingKuang.Text = s.jiaZaiQingKuang;
                qM.Text = s.qM;
                ifa.Text = s.ifa;
                //MessageBox.Show("读取完成！");
                zhazhi.Text = s.zhazhi;
                ifZhouqiN.Text = s.ifZhouqiN;
                zhouqiN.Text = s.zhouqiN;
                AD.Text = s.AD;
            }
            catch (Exception)
            {
                MessageBox.Show("未读取数据,请重新输入");
                return;
            }
        }

        private void clearBtn_Click(object sender, EventArgs er)
        {
            clampingWay.Text = "";
            BoltConnectType.Text = "";
            boltConnectLoad.Text = "";
            DA.Text = "";
            DA2.Text = "";
            dataSource.Text = "";
            screwType.Text = "";
            BoltType.Text = "";
            boltStd.Text = "";
            boringDh.Text = "";
            ScrewLengthls.Text = "";
            beta.Text = "";
            dt.Text = "";
            Es_yangshi.Text = "";
            Rpmin_qufu.Text = "";
            Rm_kangla.Text = "";
            //gasketChoose.Text = "";
            dhas.Text = "";
            dau.Text = "";
            hs2.Text = "";
            isAngle.Text = "";
            dha.Text = "";
            isCounterBore.Text = "";
            CounterBoreDepth.Text = "";
            //pEmbeddedValue.Text = "";
            Rz.Text = "";
            //EmbeddedValue.Text = "";
            Es_gasket.Text = "";
            RmminS.Text = "";
            Daz.Text = "";
            Dw.Text = "";
            m.Text = "";
            workingLoads.Text = "";
            FAO.Text = "";
            fau.Text = "";
            a.Text = "";
            isFkerf.Text = "";
            Fkerf.Text = "";
            MB.Text = "";
            tighten.Text = "";
            tightenCoef.Text = "";
            UGmin.Text = "";
            UKmin.Text = "";
            Ts.Text = "";
            Tp.Text = "";
            isN.Text = "";
            n.Text = "";
            sv.Text = "";
            lA.Text = "";
            ak.Text = "";
            isFORM.Text = "";
            v.Text = "";
            Fmzul.Text = "";
            isFz.Text = "";
            fz.Text = "";

            ifDt.Text = "";
            dtau.Text = "";
            isMt.Text = "";
            Mt.Text = "";
            ifRa.Text = "";
            ra.Text = "";
            Dhamax.Text = "";
            FQ.Text = "";
            UTmin.Text = "";
            isSGsoll.Text = "";
            SGsoll.Text = "";

            Ssym.Text = "";
            u.Text = "";
            cB.Text = "";
            cT.Text = "";
            b.Text = "";
            bT.Text = "";
            isIbt.Text = "";
            Ibt.Text = "";
            e.Text = "";
            jiaZaiQingKuang.Text = "";
            ifa.Text = "";

            qM.Text = "";
            zhazhi.Text = "";
            ifZhouqiN.Text = "";
            zhouqiN.Text = ""; 
            AD.Text = ""; 
        }

        private void boltConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boltConnectLoad.Text == "单螺栓连接")
            {
                ifDt.Enabled = false;
                isMt.Enabled = false;
                FtauGroup.Visible = false;
                ifRa.Enabled = false;
                ifDt.SelectedIndex = 1; // 否
                ifPimax.Enabled = false;
            }
            else if (boltConnectLoad.Text == "受横向载荷的单螺栓连接")
            {
                ifDt.Enabled = true;
                isMt.Enabled = true;
                FtauGroup.Visible = true;
                ifRa.Enabled = true;
                ifDt.SelectedIndex = 0;
                ifPimax.Enabled = true;
            }
        }

        private void ifDt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ifDt.Text == "是")
            {
                dtau.ReadOnly = false;
            }
            else if (ifDt.Text == "否")
            {
                dtau.Clear();
                dtau.ReadOnly = true;
            }
        }

        private void ifRa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ifRa.Text == "是")
            {
                ra.ReadOnly = false;
                ra.Clear();
                Dhamax.ReadOnly = true;
            }
            else if (ifRa.Text == "否")
            {
                ra.ReadOnly = true;
                Dhamax.Clear();
                Dhamax.ReadOnly = false;

            }
        }

        private void isMt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMt.Text == "是")
            {
                Mt.ReadOnly = false;
                qM.Enabled = true;
                Dhamax.ReadOnly = false;
            }
            else if (isMt.Text == "否")
            {
                Mt.ReadOnly = true;
                Dhamax.ReadOnly = true;
                qM.Enabled = false;

            }
        }

        private void isSGsoll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSGsoll.Text == "是")
            {
                SGsoll.ReadOnly = false;
            }
            else if (isSGsoll.Text == "否")
            {
                SGsoll.ReadOnly = true;
            }
        }

        private void isFz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFz.Text == "是")
            {
                fz.ReadOnly = false;
            }
            else if (isFz.Text == "否")
            {
                fz.ReadOnly = true;
            }
        }

        private void clampingWay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clampingWay.Text == "同心")
            {
                pianxinGroup.Visible = false;
            }
            else if (clampingWay.Text == "偏心")
            {
                pianxinGroup.Visible = true;
            }
        }

        private void isIbt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isIbt.Text == "是")
            {
                Ibt.Enabled = true;
            }
            else if (isIbt.Text == "否")
            {
                Ibt.Enabled = false;
            }
        }
        #endregion

        #endregion

        #region calculation

        private void loadData()
        {
            string sql = "select * from ((((((dbo_BoltTable inner join dbo_boltSpeciTable on dbo_boltSpeciTable.boltSpeciIndex=dbo_BoltTable.boltSpeci) " +
                    "inner join dbo_boltStdTable on dbo_boltStdTable.boltStdIndex=dbo_BoltTable.boltStd) " +
                    "inner join dbo_boltTypeTable on dbo_boltTypeTable.boltTypeIndex=dbo_BoltTable.boltType) " +
                    "inner join dbo_screwTypeTable on dbo_screwTypeTable.screwTypeIndex=dbo_BoltTable.screwType) " +
                    "inner join dbo_nutTable on dbo_nutTable.nutIndex=dbo_BoltTable.nutIndex) " +
                    "inner join dbo_gasketTable on dbo_gasketTable.gasketIndex=dbo_BoltTable.gasketIndex) " +
                    "where dbo_screwTypeTable.screwType='" + screwType.Text + "' and dbo_boltTypeTable.boltType='" + BoltType.Text + "' and dbo_boltSpeciTable.boltSpeci='"
                    + boltChooseForm.GetBoltChooseClass().speci + "' and dbo_boltStdTable.boltStd='" + boltStd.Text + "'";
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            if (dr.Read())
            {
                string normalD_d, screwP_P, boltLen_ls, boreD_dh, BoreD_dT, boltHeadOutD_dw, boltHeadInnerD_da,
                    screwMidD_d2, screwMinD_d3, polishRodLen_l1, polishRodLen_l2, boltNutSideWid_s, boltNutScrewMinD_D1;
                string isnut, isgasket, nutIndex, gasketIndex;
                normalD_d = dr["normalD_d"].ToString();
                screwP_P = dr["screwP_P"].ToString();
                boltLen_ls = dr["boltLen_ls"].ToString();
                boreD_dh = dr["boreD_dh"].ToString();
                BoreD_dT = dr["dT"].ToString();
                boltHeadOutD_dw = dr["boltHeadOutD_dw"].ToString();
                boltHeadInnerD_da = dr["boltHeadInnerD_da"].ToString();
                screwMidD_d2 = dr["screwMidD_d2"].ToString();
                screwMinD_d3 = dr["screwMinD_d3"].ToString();
                polishRodLen_l1 = dr["polishRodLen_l1"].ToString();
                polishRodLen_l2 = dr["polishRodLen_l2"].ToString();
                boltNutSideWid_s = dr["boltNutSideWid_s"].ToString();
                boltNutScrewMinD_D1 = dr["boltNutScrewMinD_D1"].ToString();
                nutIndex = dr["dbo_bolttable.nutIndex"].ToString();
                gasketIndex = dr["dbo_bolttable.gasketIndex"].ToString();

                isnut = dr["isnut"].ToString();
                isgasket = dr["isgasket"].ToString();
                string[] str = { normalD_d, screwP_P, boltLen_ls, boreD_dh, BoreD_dT, boltHeadOutD_dw, boltHeadInnerD_da,
                        screwMidD_d2, screwMinD_d3, polishRodLen_l1, boltNutSideWid_s, boltNutScrewMinD_D1 };

                bolt.BoltLen_ls = double.Parse(boltLen_ls);
                bolt.NormalD_d = double.Parse(normalD_d);
                bolt.ScrewP_P = double.Parse(screwP_P);
                bolt.BoreD_dh = double.Parse(boreD_dh);
                bolt.BoreD_dT = double.Parse(BoreD_dT);
                bolt.BoltHeadOutD_dw = double.Parse(boltHeadOutD_dw);
                bolt.BoltHeadInnerD_da = double.Parse(boltHeadInnerD_da);
                bolt.ScrewMidD_d2 = double.Parse(screwMidD_d2);
                bolt.ScrewMinD_d3 = double.Parse(screwMinD_d3);
                bolt.PolishRodLen_l1 = double.Parse(polishRodLen_l1);
                bolt.BoltNutSideWid_s = double.Parse(boltNutSideWid_s);
                bolt.BoltNutScrewMinD_D1 = double.Parse(boltNutScrewMinD_D1);
                
                if (isnut.Equals("1") && BoltConnectType.Text == "通孔螺栓连接")
                {
                    //有螺母的
                    string sql2 = "select * from dbo_nutTable where nutIndex=" + nutIndex;
                    IDataReader dr2 = dao.read(sql2);
                    if (dr2.Read())
                    {
                        string nutSpeci, nutStd, nutNutSideWid, nutBearMinD, nutBearMaxD, nutBearOutD, nutHeight;
                        nutSpeci = dr2["nutSpeci"].ToString();
                        nutStd = dr2["nutStd"].ToString();
                        nutNutSideWid = dr2["nutNutSideWid_s"].ToString();
                        nutBearMinD = dr2["nutBearMinD_Damin"].ToString();
                        nutBearMaxD = dr2["nutBearMaxD_Damax"].ToString();
                        nutBearOutD = dr2["nutBearOutD_dwmu"].ToString();
                        nutHeight = dr2["nutHeight_m"].ToString();
                        this.nut.NutSpeci = nutSpeci;
                        this.nut.NutStd = nutStd;
                        this.nut.NutNutSideWid = double.Parse(nutNutSideWid);
                        this.nut.NutBearMinD = double.Parse(nutBearMinD);
                        this.nut.NutBearMaxD = double.Parse(nutBearMaxD);
                        this.nut.NutBearOutD = double.Parse(nutBearOutD);
                        this.nut.NutHeight = double.Parse(nutHeight);
                    }
                    dr2.Close();
                }
                else
                {
                    nut = new NutClass();
                    string sql2 = "select * from dbo_nutTable where nutIndex=" + nutIndex;
                    IDataReader dr2 = dao.read(sql2);
                    if (dr2.Read())
                    {
                        string nutSpeci, nutStd, nutNutSideWid, nutBearMinD, nutBearMaxD, nutBearOutD, nutHeight;
                        nutSpeci = dr2["nutSpeci"].ToString();
                        nutStd = dr2["nutStd"].ToString();
                        nutNutSideWid = dr2["nutNutSideWid_s"].ToString();
                        nutBearMinD = dr2["nutBearMinD_Damin"].ToString();
                        nutBearMaxD = dr2["nutBearMaxD_Damax"].ToString();
                        nutBearOutD = dr2["nutBearOutD_dwmu"].ToString();
                        nutHeight = dr2["nutHeight_m"].ToString();
                        this.nut.NutSpeci = nutSpeci;
                        this.nut.NutStd = nutStd;
                        this.nut.NutNutSideWid = double.Parse(nutNutSideWid);
                        this.nut.NutBearMinD = double.Parse(nutBearMinD);
                        this.nut.NutBearMaxD = double.Parse(nutBearMaxD);
                        this.nut.NutBearOutD = double.Parse(nutBearOutD);
                        this.nut.NutHeight = double.Parse(nutHeight);
                    }
                    dr2.Close();
                }

                if (isgasket.Equals("1") && gasketChooseBtn.Checked == true)
                {
                    //有垫片的
                    string sql3 = "select * from dbo_gasketTable where gasketindex=" + gasketIndex;
                    IDataReader dr3 = dao.read(sql3);
                    if (dr3.Read())
                    {
                        string gasketstd, gasketinnerD_dhas, gasketoutD_DA, boltheaddowngasketheight_hs1, nutdowngasketheight_hs2;
                        gasketstd = dr3["gasketstd"].ToString();
                        gasketinnerD_dhas = dr3["gasketinnerD_dhas"].ToString();
                        gasketoutD_DA = dr3["gasketoutD_DA"].ToString();
                        boltheaddowngasketheight_hs1 = dr3["boltheaddowngasketheight_hs1"].ToString();
                        nutdowngasketheight_hs2 = dr3["nutdowngasketheight_hs2"].ToString();
                        this.gasket.Gasketstd = gasketstd;
                        this.gasket.GasketinnerD_dhas = double.Parse(gasketinnerD_dhas);
                        this.gasket.GasketoutD_DA = double.Parse(gasketoutD_DA);
                        this.gasket.Boltheaddowngasketheight_hs1 = double.Parse(boltheaddowngasketheight_hs1);
                        this.gasket.Nutdowngasketheight_hs2 = double.Parse(nutdowngasketheight_hs2);
                    }
                    dr3.Close();
                }
            }

            dr.Close();//关闭连接
        }

        private double computePhi_D(int w,double H)
        {
            double Da = double.Parse(DA.Text);
            double Lk = H;
            if (w == 2)
            {
                Lk = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[5].Value);
            }
            // 计算DAGr
            double Ddwm = bolt.BoltHeadOutD_dw;
            double BL = Lk / Ddwm;
            double y = Da / Ddwm;
            double TanPhi = 0;
            if (w == 1)
            {
                TanPhi = 0.362 + 0.032 * Math.Log(BL / 2) + 0.153 * Math.Log(y);
            }
            else if (w == 2)
            {
                TanPhi = 0.348 + 0.013 * Math.Log(BL) + 0.193 * Math.Log(y);
            }
            return TanPhi;
        }
        private double computeDAGr(int w, double H)
        {
            double Lk = H;
            if (w == 2)
            {
                Lk = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[5].Value);
            }
            double Ddwm = bolt.BoltHeadOutD_dw;
            double BL = Lk / Ddwm;
            double TanPhi = computePhi_D(w, H);

            // 计算DAGr
            
            double DAGr = Ddwm + w * Lk * TanPhi;
            Console.WriteLine("lk:" + Lk);
            Console.WriteLine("TanPhi:" + TanPhi);
            Console.WriteLine("DAGr:" + DAGr);

            return DAGr;
        }
        private double computeBetaS(int w, double lk, double betaGM, double In)
        {

            double I3 = Math.PI * Math.Pow((bolt.ScrewMinD_d3), 4) / 64;
            double lGew = lk - bolt.PolishRodLen_l1 - bolt.PolishRodLen_l2;
            double betaGEW = lGew / Convert.ToDouble(Es_yangshi.Text) / I3;
            if (lGew <= 0)
            {
                betaGEW = 0;
            }
            double beta1 = bolt.PolishRodLen_l1 / Convert.ToDouble(Es_yangshi.Text) / In;
            double beta2 = bolt.PolishRodLen_l2 / Convert.ToDouble(Es_yangshi.Text) / In;
            double lsk = 0.5 * bolt.NormalD_d;
            if (BoltType.Text == "内六角螺栓")
            {
                lsk = 0.4 * bolt.NormalD_d;
            }
            double betaSK = lsk / Convert.ToDouble(Es_yangshi.Text) / In;

            double betaS = betaGM + beta1 + beta2 + betaSK + betaGEW;
            return betaS;
        }
        private double ComputeDeltaS(int w, double lk, double deltaGM, double AN)
        {
            double Ad3 = (bolt.ScrewMinD_d3) * (bolt.ScrewMinD_d3) * pi / 4;
            // δGew  夹紧件长度 - 光杆长度l1  - 磨光面长度
            double lGew = lk - bolt.PolishRodLen_l1 - bolt.PolishRodLen_l2;
            double deltaGew = lGew / double.Parse(Es_yangshi.Text) / Ad3;
            if (lGew <= 0)
            {
                deltaGew = 0;
            }

            // δi
            double deltaS1 = bolt.PolishRodLen_l1 / double.Parse(Es_yangshi.Text) / AN;
            double deltaS2 = bolt.PolishRodLen_l2 / double.Parse(Es_yangshi.Text) / AN;
            // sk
            double lsk = 0.5 * bolt.NormalD_d;
            if (BoltType.Text == "内六角螺栓")
            {
                lsk = 0.4 * bolt.NormalD_d;
            }
            double deltaSK = lsk / double.Parse(Es_yangshi.Text) / AN;
            double deltaS = deltaSK + deltaS1 + deltaS2 + deltaGew + deltaGM;

            Console.WriteLine("bolt.PolishRodLen_l1:" + bolt.PolishRodLen_l1.ToString());
            Console.WriteLine("AN:" + AN.ToString());
            Console.WriteLine("deltaS1:" + deltaS1.ToString());
            Console.WriteLine("deltaS2:" + deltaS2.ToString());
            Console.WriteLine("deltaSk:" + deltaSK.ToString());
            Console.WriteLine("deltaGew:" + deltaGew.ToString());
            Console.WriteLine("deltaGM:" + deltaGM.ToString());

            return deltaS;
        }

        private double computeDeltaP(int w, double H, double Ep, double DAGr, int idx)
        {
            // R3.3: compute deltaP

            double deltaP = 0;
            double dw = (bolt.BoltHeadOutD_dw);
            double dh = bolt.BoreD_dh;
            double Lk = H;
            if (w == 2)
            {
                Lk = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[5].Value);
            }
            double BL = Lk / dw;
            double y = double.Parse(DA.Text) / dw;
            double TanPhi = 0;
            if (w == 1)
            {
                TanPhi = 0.362 + 0.032 * Math.Log(BL / 2) + 0.153 * Math.Log(y);
                if (idx == 1)
                {
                    TanPhi = 0.357 + 0.05 * Math.Log(BL / 2) + 0.121 * Math.Log(y);
                }
            }
            else if (w == 2)
            {
                TanPhi = 0.348 + 0.013 * Math.Log(BL) + 0.193 * Math.Log(y);
            }
            Console.WriteLine("phi:" + Math.Atan(TanPhi));
            Console.WriteLine("DAGr:" + DAGr.ToString()); // x
            Console.WriteLine("TanPhi:" + TanPhi.ToString());

            if (double.Parse(DA.Text) >= DAGr)
            {
                deltaP = 2 * Math.Log(((dw + dh) * (dw + w * Lk * TanPhi - dh)) / ((dw - dh) * (dw + w * Lk * TanPhi + dh))) / (w * Ep * pi * dh * TanPhi);
            }
            else
            {
                double da = double.Parse(DA.Text);
                double log = Math.Log(((dw + dh) * (da - dh)) / ((dw - dh) * (da + dh)));
                double left = 2 * log / (w * dh * TanPhi);
                double right = 4 * (Lk - (da - dw) / w / TanPhi) / (da * da - dh * dh);
                deltaP = (left + right) / Ep / pi;
            }
            //Console.WriteLine("deltaP:" + deltaP.ToString());

            return deltaP;
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            // 防呆
            #region fangdai
            // 防呆检测
            // 基础
            if (clampingWay.Text == "")
            {
                MessageBox.Show("请选择夹紧方式！");
                return;
            }
            if (BoltConnectType.Text == "")
            {
                MessageBox.Show("请选择螺栓连接类型！");
                return;
            }
            if (boltConnectLoad.Text == "")
            {
                MessageBox.Show("请选择螺栓类型！");
                return;
            }

            // 几何尺寸
            if (DA.Text == "")
            {
                MessageBox.Show("请填写接合面等效外径！");
                return;
            }
            if (DA2.Text == "")
            {
                MessageBox.Show("请填写接合面上面的等效外径！");
                return;
            }

            // 螺栓
            if (dataSource.Text == "")
            {
                MessageBox.Show("请选择数据源！");
                return;
            }
            if (screwType.Text == "")
            {
                MessageBox.Show("请选择螺纹类型！");
                return;
            }
            if (boltStd.Text == "" || boringDh.Text == "" || ScrewLengthls.Text == "")
            {
                MessageBox.Show("请指定螺栓！");
                return;
            }
            if (Es_yangshi.Text == "" || Rpmin_qufu.Text == "" || Rm_kangla.Text == "")
            {
                MessageBox.Show("请确定强度等级！");
                return;
            }

            // 防呆-夹紧件
            if (dataClampedChoosed.RowCount == 0)
            {
                MessageBox.Show("请添加夹紧件！");
                return;
            }

            // 防呆-加载数据
            if (workingLoads.Text == "")
            {
                MessageBox.Show("选择载荷类型！");
                return;
            }
            if (FAO.Text == "")
            {
                MessageBox.Show("请填写轴向载荷上限值！");
                return;
            }
            if (isFkerf.Text == "")
            {
                MessageBox.Show("请确认是否有最小夹紧力！");
                return;
            }
            if (tighten.Text == "")
            {
                MessageBox.Show("请选择拧紧工艺！");
                return;
            }
            if (UGmin.Text == "")
            {
                MessageBox.Show("请填写摩擦系数UGmin！");
                return;
            }

            if (UKmin.Text == "")
            {
                MessageBox.Show("请填写摩擦系数Ukmin！");
                return;
            }
            if (Ts.Text == "")
            {
                MessageBox.Show("请填写螺栓的工作温度Ts！");
                return;
            }
            if (Tp.Text == "")
            {
                MessageBox.Show("请填写被连接件的工作温度Tp！");
                return;
            }
            if (isN.Text == "")
            {
                MessageBox.Show("请选择载荷系数计算方式！");
                return;
            }
            if (isFORM.Text == "")
            {
                MessageBox.Show("请选择预定在室温下允许的装配预紧力 / 必要的拧紧力矩！");
                return;
            }
            if (isFz.Text == "")
            {
                MessageBox.Show("请确定未拧紧至屈服点下的最小有效啮合长度！");
                return;
            }

            #endregion
            genWordBtn.Visible = true;
            // 防呆组合问题
            ComputeResult rs = new ComputeResult();
            // 获取参数
            this.GetCalParameter();

            // 计算结果
            rs = this.Solve();
            if (rs == null)
            {
                MessageBox.Show("重新输入参数");
                return;
            }
            // 显示结果
            resGrid.SelectedObject = rs;
            if (rs.Sd >= 1 && rs.Sp >= 1 && rs.Sp_load >= 1)
            {
                MessageBox.Show("安全");
            }
            else
            {
                MessageBox.Show("不安全,请修改参数，重新设计螺栓连接结构");
            }
            ShowDataChartForOpResult();
        }


        private void ShowDataChartForOpResult()
        {
            lineChart.Series.Clear();
            Series blackLine = new Series("Screw characteristic");
            Series redLine = new Series("characteristic strutted part(Fmzul)");
            blackLine.ChartType = SeriesChartType.Line;
            redLine.ChartType = SeriesChartType.Line;
            blackLine.IsValueShownAsLabel = true;
            redLine.IsValueShownAsLabel = true;

            lineChart.ChartAreas[0].AxisX.Title = "load F, kN";
            lineChart.ChartAreas[0].AxisY.Title = "Displacement f, mm";
            lineChart.ChartAreas[0].AxisY.MajorGrid.Interval = 1;//ChartAreas[0]想要获取或设置的元素从0开始的索引
            lineChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightBlue;
            lineChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightBlue;
            lineChart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;//虚线
            lineChart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            //lineChart.ChartAreas[0].AxisX.MajorGrid.Interval = 400;
            //lineChart.ChartAreas[0].AxisY.MajorGrid.Interval = 50;
            lineChart.ChartAreas[0].AxisX.Interval = 0.025;
            lineChart.ChartAreas[0].AxisY.Interval = 5; //设置Y轴的刻度间距
            //Y轴范围0-Fmzul  X轴范围0~deltaS + deltaP
            lineChart.ChartAreas[0].AxisX.Minimum = 0;
            lineChart.ChartAreas[0].AxisX.Maximum = (rs.Fmzul * rs.deltas + rs.Fmzul * rs.deltap) * 1.2;
            lineChart.ChartAreas[0].AxisY.Minimum = 0;
            lineChart.ChartAreas[0].AxisY.Maximum = rs.Fmzul * 1.25 / 1000;
            lineChart.ChartAreas[0].Area3DStyle.Enable3D = false;//启用3D显示
            //设置空数据时显示坐标轴
            lineChart.ChartAreas[0].AxisX.Enabled = AxisEnabled.True;
            lineChart.ChartAreas[0].AxisY.Enabled = AxisEnabled.True;
            blackLine.Points.AddXY(0, 0);
            blackLine.Points.AddXY(rs.Fmzul * rs.deltas, rs.Fmzul / 1000);
            redLine.Points.AddXY(rs.Fmzul * rs.deltas, rs.Fmzul / 1000);
            redLine.Points.AddXY(rs.Fmzul * rs.deltas + rs.Fmzul * rs.deltap, 0);

            // Fmin line
            Series FminLine = new Series("characteristic strutted part(FMmin)");
            FminLine.ChartType = SeriesChartType.Line;
            FminLine.IsVisibleInLegend = false;
            double x1 = addLineFuncGetX(rs.Fmmin / 1000);
            double y1 = rs.Fmmin / 1000;
            double x2 = subLineFuncGetX(x1, y1, 0);
            double y2 = 0;
            FminLine.Points.AddXY(x1, y1);
            FminLine.Points.AddXY(x2, y2);
            Series FminDottedLine = new Series();
            FminDottedLine.ChartType = SeriesChartType.StepLine;
            FminDottedLine.BorderDashStyle = ChartDashStyle.Dash;
            FminDottedLine.IsValueShownAsLabel = true;
            FminDottedLine.Points.AddXY(0, y1);
            FminDottedLine.Points.AddXY(rs.Fmzul * rs.deltas + rs.Fmzul * rs.deltap, rs.Fmmin / 1000);

            // Fmax line
            Series FmaxLine = new Series("characteristic strutted part(FMmax)");
            FmaxLine.ChartType = SeriesChartType.Line;
            //FmaxLine.IsValueShownAsLabel = true;
            x1 = addLineFuncGetX(rs.Fmmax / 1000);
            y1 = rs.Fmmax / 1000;
            x2 = subLineFuncGetX(x1, y1, 0);
            y2 = 0;
            FmaxLine.Points.AddXY(x1, y1);
            FmaxLine.Points.AddXY(x2, y2);
            Series FmaxDottedLine = new Series();
            FmaxDottedLine.ChartType = SeriesChartType.Line;
            FmaxDottedLine.BorderDashStyle = ChartDashStyle.Dash;
            FmaxDottedLine.IsVisibleInLegend = false;
            //FmaxDottedLine.IsValueShownAsLabel = true;
            FmaxDottedLine.Points.AddXY(0, y1);
            FmaxDottedLine.Points.AddXY(rs.Fmzul * rs.deltas + rs.Fmzul * rs.deltap, rs.Fmmax / 1000);

            // fmzul
            Series FmzulLine = new Series();
            FmzulLine.ChartType = SeriesChartType.FastLine;
            FmzulLine.BorderDashStyle = ChartDashStyle.Dash;

            FmzulLine.IsVisibleInLegend = false;
            FmzulLine.Points.AddXY(0, rs.Fmzul / 1000);
            FmzulLine.Points.AddXY(rs.Fmzul * rs.deltas + rs.Fmzul * rs.deltap, rs.Fmzul / 1000);


            //把series添加到chart上
            lineChart.Series.Add(blackLine);
            lineChart.Series.Add(redLine);
            lineChart.Series.Add(FminLine);
            lineChart.Series.Add(FmaxLine);
            lineChart.Series.Add(FminDottedLine);
            lineChart.Series.Add(FmaxDottedLine);
            lineChart.Series.Add(FmzulLine);

        }
        double addLineFuncGetX(double y)
        {
            //y = kx + b;  k = y0 / x0  过0,0,   y = kx  x = y / k;
            double k = (rs.Fmzul / 1000) / (rs.Fmzul * rs.deltas);
            return y / k;
        }
        double subLineFuncGetX(double x0, double y0, double y)
        {
            // y - y0 = k (x - x0);
            //k = (y1 - y2) / (x1 - x2);
            // 斜率+一个点
            double k = (rs.Fmzul / 1000 - 0) / (rs.Fmzul * rs.deltas - (rs.Fmzul * rs.deltas + rs.Fmzul * rs.deltap));
            // 
            return (y - y0) / k + x0;
        }
        // 计算N
        private double computeN(double H)
        {
            double Nn = 0;
            double LA = 0;
            double Ak = 0;
            string SV = "";
            // compute n
            if (isN.Text == "自定义" && n.Enabled == true)
            {
                // n直接输入的情况
                if (n.Text == "")
                {
                    MessageBox.Show("请输入n值");
                    return 0;
                }
                Nn = double.Parse(n.Text);
            }
            else
            {
                // 通过sv计算n的情况
                // 通过查表 la ak h sv 四个参数共同计算
                LA = double.Parse(lA.Text);
                Ak = double.Parse(ak.Text);
                SV = sv.Text;

                #region 计算n表格
                // Nn表格
                if (LA / H >= 0 && LA / H < 0.1)
                {
                    if (Ak / H >= 0 && Ak / H < 0.1)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.7f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.57f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.44f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.42f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.30f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.15f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.1 && Ak / H < 0.3)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.55f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.46f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.37f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.34f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.25f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.14f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.3 && Ak / H < 0.5)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.3f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.3f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.26f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.25f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.22f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.14f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.5)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.13f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.13f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.12f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.12f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.1f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.07f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                }
                else if (LA / H >= 0.1 && LA / H < 0.2)
                {
                    if (Ak / H >= 0 && Ak / H < 0.1)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.52f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.44f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.35f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.33f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.24f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.13f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.1 && Ak / H < 0.3)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.41f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.36f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.30f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.27f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.21f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.12f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.3 && Ak / H < 0.5)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.22f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.21f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.20f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.15f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.1f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.5)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.1f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.1f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.09f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.08f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.07f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.06f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                }
                else if (LA / H >= 0.2 && LA / H < 0.3)
                {
                    if (Ak / H >= 0 && Ak / H < 0.1)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.34f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.3f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.26f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.23f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.19f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.11f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.1 && Ak / H < 0.3)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.28f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.25f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.23f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.19f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.17f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.11f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.3 && Ak / H < 0.5)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.15f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.12f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.12f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.09f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.5)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.14f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.14f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.10f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                }
                else if (LA / H >= 0.3)
                {
                    if (Ak / H >= 0 && Ak / H < 0.1)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.16f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.14f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.14f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.1f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.1 && Ak / H < 0.3)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.14f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.14f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.14f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.13f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.13f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.1f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.3 && Ak / H < 0.5)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.12f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.12f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.12f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.1f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.1f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.08f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                    if (Ak / H >= 0.5)
                    {
                        if (SV == "sv1")
                        {
                            Nn = 0.04f;
                        }
                        else if (SV == "sv2")
                        {
                            Nn = 0.04f;
                        }
                        else if (SV == "sv3")
                        {
                            Nn = 0.04f;
                        }
                        else if (SV == "sv4")
                        {
                            Nn = 0.03f;
                        }
                        else if (SV == "sv5")
                        {
                            Nn = 0.03f;
                        }
                        else if (SV == "sv6")
                        {
                            Nn = 0.03f;
                        }
                        else
                        {
                            Nn = 0;
                        }
                    }

                }
                else
                {
                    Nn = 0;
                }
                #endregion

            }
            return Nn;
        }
        
        #endregion

        private void BoltType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // 内六角螺栓和外六角螺栓不同
            // 建模也不同
            if (BoltType.Text == "外六角螺栓")
            {

            }
            else if (BoltType.Text == "内六角螺栓")
            {

            }
        }

        // 接口实现 获取界面参数值
        public void GetCalParameter()
        {
            // 加载螺栓，螺母，垫片数据
            loadData();
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    

        public ComputeResult Solve()
        {
            //ComputeResult rs = new ComputeResult();


            solution = new Solution();
            #region R1_alpha_A
            if (tighten.Text == null || tighten.Text == "")
            {
                MessageBox.Show("请选择拧紧工艺");
                return null;
            }
            R1 r1 = new R1();
            r1.getAlpha(tighten.Text, tightenCoef.Text);
            double a_lpha_A = r1.alpha;
            rs.alphaA = a_lpha_A;
            solution.r1 = r1;
            #endregion

            #region R2_Fkerf_DAGr

            Console.WriteLine("R2:");
            R2 r2 = new R2(bolt);
            if (BoltConnectType.Text == null || BoltConnectType.Text == "")
            {
                MessageBox.Show("请选择螺栓连接类型");
                return null;
            }
            if (DA.Text == "")
            {
                MessageBox.Show("请输入DA");
                return null;
            }
            else
            {
                r2.setDA(DA.Text);
            }

            #region zaihe
            if (FAO.Text == "")
            {
                MessageBox.Show("轴向载荷");
                return null;
            }
            r2.setFao(FAO.Text);
            if (fau.ReadOnly == true)
            {

            }
            else if (fau.ReadOnly == false && fau.Text == "")
            {
                MessageBox.Show("轴向载荷");
                return null;
            }
            else
            {
                r2.setFau(fau.Text);
            }


            if (clampingWay.Text == "同心")
            {
                r2.setA("0");
            }
            else
            {
                if (a.ReadOnly == true)
                {

                }
                else if (a.ReadOnly == false && a.Text == "")
                {
                    MessageBox.Show("a");
                    return null;
                }
                else
                {
                    r2.setA(a.Text);
                }
            }
           

            if (Fkerf.ReadOnly == true)
            {

            }
            else if (Fkerf.ReadOnly == false && Fkerf.Text == "")
            {
                MessageBox.Show("Fkerf");
                return null;
            }
            else
            {
                r2.setFkerf(Fkerf.Text);
            }

            if (MB.Text == "")
            {
                r2.setMB("0");
            }
            else
            {
                r2.setMB(MB.Text);
            }

            if (UGmin.Text == "")
            {
                MessageBox.Show("UGmin");
                return null;
            }
            else
            {
                r2.setUTmin(UGmin.Text);
            }

            if (UKmin.Text == "")
            {
                MessageBox.Show("UKmin");
                return null;
            }
            else
            {
                r2.setUKmin(UKmin.Text);
            }
            if (Ts.Text == "")
            {
                MessageBox.Show("Ts");
                return null;
            }
            else
            {
                r2.setTs(Ts.Text);
            }
            if (Tp.Text == "")
            {
                MessageBox.Show("Tp");
                return null;
            }
            else
            {
                r2.setTp(Tp.Text);
            }

            
            if (v.ReadOnly == true)
            {

            }
            else if (v.ReadOnly == false && v.Text == "")
            {
                MessageBox.Show("v");
                return null;
            }
            else
            {
                r2.setV(v.Text);
            }

            if (Fmzul.ReadOnly == true)
            {

            }
            else if (Fmzul.ReadOnly == false && Fmzul.Text == "")
            {
                MessageBox.Show("Fmzul");
                return null;
            }
            else
            {
                r2.setFmzul(Fmzul.Text);
            }
            #endregion

            #region jihe
            if (DA.Text == "")
            {
                MessageBox.Show("请输入DA");
                return null;
            }
            else
            {
                r2.setDA(DA.Text);
            }

            if (AD.Text == "")
            {
                MessageBox.Show("请输入AD");
                return null;
            }
            r2.AD = Convert.ToDouble(AD.Text);
            if (pimax.ReadOnly == true)
            {

            }
            else if (pimax.ReadOnly == false && pimax.Text == "")
            {
                r2.setP_imax("0");
            }
            else
            {
                r2.setP_imax(pimax.Text);
            }


            #endregion

            #region jianli
            

            if (boltConnectLoad.Text== "受横向载荷的单螺栓连接")
            {
                if (FQ.Text == "")
                {
                    r2.f_qmax = 0;
                }
                r2.f_qmax = Convert.ToDouble(FQ.Text);

                if (UTmin.Text == "")
                {
                    MessageBox.Show("utmin");
                    return null;
                }
                else
                {
                    r2.u_Tmin = Convert.ToDouble(UTmin.Text);
                }

                if (SGsoll.ReadOnly == true)
                {
                    r2.sgsoll = 1;
                }
                else if (SGsoll.ReadOnly == false && SGsoll.Text == "")
                {
                    r2.sgsoll = 1;
                }
                else
                {
                    r2.sgsoll = Convert.ToDouble(SGsoll.Text);
                }

                if (qF.Text == "")
                {
                    r2.q_f = 1;
                }
                else
                {
                    r2.q_f = Convert.ToDouble(qF.Text);
                }

                if (dtau.ReadOnly == true)
                {
                    r2.dtau = 0;
                }
                else if (dtau.ReadOnly == false && dtau.Text == "")
                {
                    MessageBox.Show("dtau");
                    return null;
                }
                else
                {
                    r2.dtau = Convert.ToDouble(dtau.Text);
                }

                if (Mt.ReadOnly == true)
                {
                    r2.M_t = 0;
                }
                else if (Mt.ReadOnly == false && Mt.Text == "")
                {
                    MessageBox.Show("Mt");
                    return null;
                }
                else
                {
                    r2.M_t = Convert.ToDouble(Mt.Text);
                }

                if (ra.ReadOnly == true)
                {

                }
                else if (ra.ReadOnly == false && ra.Text == "")
                {
                    MessageBox.Show("ra");
                    return null;
                }
                else
                {
                    r2.r_a = Convert.ToDouble(ra.Text);
                }

                if (Dhamax.ReadOnly == true)
                {

                }
                else if (Dhamax.ReadOnly == false && Dhamax.Text == "")
                {
                    MessageBox.Show("Dhamax");
                    return null;
                }
                else
                {
                    r2.Dhamax = Convert.ToDouble(Dhamax.Text);
                }

                if (qM.Text == "")
                {
                    r2.q_m = 1;
                }
                else
                {
                    r2.q_m = Convert.ToDouble(qM.Text);
                }
            }


            #endregion

            #region pianxin
            if (clampingWay.Text == "偏心")
            {
                if (Ssym.Text == "" || cB.Text == "" || cT.Text == "" || b.Text == "" || bT.Text == "" || e.Text == "")
                {
                    MessageBox.Show("受弯体几何尺寸不能为空");
                    return null;
                }
                r2.setSsym(Ssym.Text);
                r2.setU(u.Text);
                r2.setCb(cB.Text);
                r2.setCt(cT.Text);
                r2.setB(b.Text);
                r2.setBt(bT.Text);
                r2.setE(e.Text);

                if (ifa.Text == "" || ifa.Text == "否")
                {
                    r2.setA("0");
                }
                else
                {
                    r2.setA(a.Text);
                }

                if (isIbt.Text == "否" || isIbt.Text == "")
                {
                    r2.ibt = r2.bt * Math.Pow(r2.ct, 3) / 12;
                }
                else
                {
                    r2.setIbt(Ibt.Text);
                }
            }
            #endregion
            double D_A = r2.D_A;
            r2.setW(BoltConnectType.Text);
            int w = r2.w;
            double H = 0;
            double hmin = int.MaxValue;
            if (dataClampedChoosed.RowCount < 1)
            {
                MessageBox.Show("请输入连接件");
                return null;
            }
            if (BoltConnectType.Text == "通孔螺栓连接")
            {
                int rows = dataClampedChoosed.RowCount - 1;
                for (int i = 0; i < rows; i++)
                {
                    hmin = Math.Min(hmin, Convert.ToSingle(dataClampedChoosed.Rows[i].Cells[5].Value));
                    H += Convert.ToSingle(dataClampedChoosed.Rows[i].Cells[5].Value);
                }
            }
            else if (BoltConnectType.Text == "盲孔螺栓连接")
            {
                if (dataClampedChoosed.Rows[0].Cells[5].Value == null)
                {
                    MessageBox.Show("请输入连接件");
                    return null;
                }
                H = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[5].Value);
                hmin = Math.Min(hmin, Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[5].Value));
            }
            r2.hmin = hmin;
            r2.setLk(H, dataClampedChoosed.Rows[1].Cells[5].Value.ToString());
            double L_k = r2.Lk;
            double dw = bolt.BoltHeadOutD_dw;
            r2.setTanPhi_D();
            double tanPhi_D = r2.tanPhi_D;
            r2.setDAGr();
            double DAGr = r2.DAGr;
            double f_kerf = 0;
            
            if (clampingWay.Text == "偏心")
            {
                if (r2.ct < dw)
                {
                    MessageBox.Show("预期输入：cT > dw");
                    return null;
                }
                if (r2.cb < dw)
                {
                    MessageBox.Show("预期输入：cb > dw");
                    return null;
                }
                if (r2.bt < dw)
                {
                    MessageBox.Show("预期输入：bt > dw");
                    return null;
                }
                if (r2.b < dw)
                {
                    MessageBox.Show("预期输入：b > dw");
                    return null;
                }
            }
            if (isFkerf.Enabled == true && isFkerf.Text == "选择")
            {
                r2.setF_kerf(Fkerf.Text);
            }
            else
            {
                double f_kq = 0;
                if (boltConnectLoad.Text == "单螺栓连接")
                {
                    r2.setF_kerf(FAO.Text);
                    f_kerf = r2.f_kerf;
                }
                else
                {
                    if (isMt.Text == "" || isMt.Text == "否")
                    {
                        // 受横向剪力  不加扭矩
                        r2.setFkq(FQ.Text, qF.Text, UTmin.Text);
                        f_kq = r2.f_kerf;
                        if (f_kq == -1)
                        {
                            MessageBox.Show("剪力系数存在错误，请修改");
                            return null;
                        }
                    }
                    else
                    {
                        // 有扭矩 
                        // 不加摩擦半径（与承载相反）
                        if ((ifRa.Text == "" || ifRa.Text == "否") )
                        {
                            // 0 使用d  1使用ra
                            if (FQ.Text == "" || qF.Text == "" || UTmin.Text == "" || Mt.Text == "" || qM.Text == "" || Dhamax.Text == "" )
                            {
                                MessageBox.Show("剪力系数存在错误，请修改");
                                return null;
                            }
                            r2.setFkq(FQ.Text, qF.Text, UTmin.Text, Mt.Text, qM.Text, Dhamax.Text, 0);
                        }
                        else
                        {
                            // 加摩擦半径
                            if (FQ.Text == "" || qF.Text == "" || UTmin.Text == "" || Mt.Text == "" || qM.Text == "" || ra.Text == "")
                            {
                                MessageBox.Show("剪力系数存在错误，请修改");
                                return null;
                            }
                            r2.setFkq(FQ.Text, qF.Text, UTmin.Text, Mt.Text, qM.Text, ra.Text, 1);
                        }
                        f_kq = r2.f_kq;
                    }
                }
                r2.setF_kp(pimax.Text);
                double f_kp = r2.f_kp;
                // 防止松开
                double f_ka = 0;
                if (ifa.Text == "是")
                {
                    r2.setFka();
                    f_ka = r2.f_ka;
                }
                else
                {
                    f_ka = 0;
                }
                r2.setF_kerf();
            }

            bool checkFlag = r2.checkClampedLs(nut.NutHeight);
            if (checkFlag == true)
            {
                // 满足
            }
            else
            {
                return null;
            }

            f_kerf = r2.f_kerf;
            Console.WriteLine("DA:" + D_A);
            Console.WriteLine("w:" + w);
            Console.WriteLine("hmin:" + hmin);
            Console.WriteLine("L_k:" + L_k);
            Console.WriteLine("tanPhi_D:" + tanPhi_D);
            Console.WriteLine("DAGr:" + DAGr);
            Console.WriteLine("f_kerf:" + f_kerf);

            rs.Fkerf = f_kerf;
            solution.r2 = r2;

            #endregion

            #region R3_delta_phi
            // R3: 计算回弹及系数
            // R3.1: 计算回弹及系数
            Console.WriteLine("R3:");

            R3 r3 = new R3(bolt, r2);
            if (isN.Text == "")
            {
                MessageBox.Show("请输入系数");
                return null;
            }
            double Nn = 0;
            if (isN.Text == "自定义" || isN.Text == "")
            {
                if (n.Text == "")
                {
                    MessageBox.Show("请输入系数");
                    return null;
                }
                r3.setN(n.Text);
            }
            else if (isN.Text == "默认")
            {
                if (sv.Text == null || sv.Text == "")
                {
                    MessageBox.Show("选择连接类型");
                    return null;
                }
                if (lA.Text == null || lA.Text == "")
                {
                    MessageBox.Show("lA");
                    return null;
                }
                if (ak.Text == null || ak.Text == "")
                {
                    MessageBox.Show("ak");
                    return null;
                }
                double n = r3.getN(sv.Text, lA.Text, ak.Text, H);
                r3.setN(n.ToString());
            }
            Nn = r3.Nn;
            Console.WriteLine("Nn:" + Nn);

            r3.AN = bolt.NormalD_d * bolt.NormalD_d * pi / 4;
            r3.Ad3 = bolt.ScrewMinD_d3 * bolt.ScrewMinD_d3 * pi / 4;
            r3.setLm();
            // R3.2: compute deltaS
            if (Es_yangshi.Text == "")
            {
                MessageBox.Show("请选择材料");
                return null;
            }

            r3.setDeltaS(Es_yangshi.Text);
            double deltaS = r3.deltaS;

            r3.setBetaS(Es_yangshi.Text);
            double betaS = r3.betaS;

            // deltap
            string ep = dataClampedChoosed.Rows[0].Cells[1].Value.ToString();
            if (ep == null || ep == "")
            {
                MessageBox.Show("请输入连接件");
                return null;
            }
            double deltaP = 0;
            r3.setDeltaP(ep);
            deltaP = r3.deltaP;

            if (clampingWay.Text == "同心")
            {
            }
            else
            {
                if (BoltConnectType.Text == "通孔螺栓连接")
                {
                    r3.G = bolt.BoltHeadOutD_dw + r2.hmin; // 通孔
                }
                else if (BoltConnectType.Text == "盲孔螺栓连接")
                {
                    r3.G = 1.5 * bolt.BoltHeadOutD_dw; // 盲孔估计值
                }
                if (r3.G < r2.ct)
                {
                    Console.WriteLine("G:" + r3.G);
                    MessageBox.Show("G超过限制尺寸，vdi 不适用于计算此情况R1");
                    return null;
                }
                // 计算deltap*
                r3.setDeltaP_star(ep);
            }
            double deltaP_star = r3.deltaP_star;
            double deltaP_star_star = r3.deltaP_star_star;

            Console.WriteLine("an:" + r3.AN);
            Console.WriteLine("deltaS1:" + r3.deltaS1);
            Console.WriteLine("deltaS2:" + r3.deltaS2);
            Console.WriteLine("deltaSk:" + r3.deltaSK);
            Console.WriteLine("deltaGEW:" + r3.deltaGew);
            Console.WriteLine("deltaGM:" + r3.deltaGM);
            Console.WriteLine("deltaS:" + r3.deltaS);
            Console.WriteLine("betas:" + r3.betaS);
            Console.WriteLine("deltaP:" + deltaP);
            Console.WriteLine("deltaP_star:" + deltaP_star);
            Console.WriteLine("deltaP_star_star:" + deltaP_star_star);
            r3.setMB(ep);
            double phi_m_star = r3.phi_m_star;
            double phi = r3.getPhi();

            Console.WriteLine("phi:" + phi);

            double f_sa_max = Convert.ToDouble(FAO.Text) * phi;
            double f_sa_min = Convert.ToDouble(fau.Text) * phi;

            rs.deltas = deltaS;
            rs.deltap = deltaP;
            rs.phi = phi;
            solution.r3 = r3;

            #endregion

            #region R4_fz
            // R4:
            Console.WriteLine("R4:");
            double ffz = 0;
            R4 r4 = new R4(r3);
            if (isFz.Text == "是")
            {
                if (fz.Text == "")
                {
                    MessageBox.Show("fz");
                    return null;
                }
                ffz = double.Parse(fz.Text);
            }
            else
            {
                // 根据p73表格5求fz
                ffz = table5();
                double rz = 0;
                if (Rz.Text == "")
                {
                    MessageBox.Show("请输入Rz");
                    return null;
                }
                else
                {
                     rz = Convert.ToDouble(Rz.Text);
                }
                double fq = 0;
                if (FQ.Text == "")
                {
                    fq = 0;
                }
                else
                {
                    fq = Convert.ToDouble(FQ.Text);
                }
                ffz = r4.table5(rz, r2.w, fq);
            }
            r4.ffz = ffz;
            r4.setFz();
            double Fz = r4.FZ;
            rs.Fz = Fz;
            Console.WriteLine("ffz:" + ffz.ToString());
            Console.WriteLine("Fz:" + Fz);
            solution.r4 = r4;

            #endregion

            #region R5_fmmin
            // R5:
            Console.WriteLine("R5:");
            R5 r5 = new R5(r2.f_kerf, r3.phi, r2.Fao, r4.FZ);
            double Fmmin = r5.getFmmin();
            //double Famax = r2.Fao;
            //double Famin = r2.Fau;
            
            //double Fmmin = f_kerf + (1 - r3.phi) * Famax + Fz;
            rs.Fmmin = Fmmin;
            Console.WriteLine("Fmmin:" + rs.Fmmin.ToString());
            solution.r5 = r5;

            #endregion

            #region R6_fmmax
            // R6:
            Console.WriteLine("R6:");
            R6 r6 = new R6(r1.alpha, r5.getFmmin());
            rs.Fmmax = r6.getFmmax();
            //rs.Fmmax = Fmmax;
            Console.WriteLine("Fmmax:" + rs.Fmmax.ToString());
            solution.r6 = r6;

            #endregion

            #region R7_fmzul
            // R7:
            Console.WriteLine("R7:");
            double V = r2.v;

            R7 r7 = new R7(bolt, r2.UGmin, V);
            double fmzul = r7.getFmzul();
            double f_mtb = r7.getF_mtb();
            rs.Fmzul = fmzul;
            Console.WriteLine("fmzul:" + fmzul);
            solution.r7 = r7;

            #endregion

            #region R8_fsmax
            // R8: 工作应力
            // 温度影响
            Console.WriteLine("R8:");
            R8 r8 = new R8(bolt, r7.getFmzul(), r2.Fao, phi, r7.Ugmin);
            double sf = r8.getSf();
            Console.WriteLine("sf:" + sf);
            solution.r8 = r8;
            rs.Sf = sf;
            #endregion

            #region R9_jiaobian
            Console.WriteLine("r2.Fao:" + r2.Fao);
            Console.WriteLine("r2.Fau:" + r2.Fau);

            R9 r9 = new R9(bolt, r2.a, r2.s_sym, phi, r7.getFmzul(), Convert.ToDouble(Rpmin_qufu.Text), r2.Fao, r2.Fau);

            if (ifZhouqiN.Checked == true)
            {
                // azsv   有点问题
                if (zhouqiN.Text == "")
                {
                    MessageBox.Show("请输入N");
                    r9.zhouqiN = 0;
                    return null;
                }
                else
                {
                    r9.zhouqiN = Convert.ToDouble(zhouqiN.Text);
                }
            }
            else
            {
                r9.zhouqiN = 0;
            }

            if (clampingWay.Text == "同心")
            {
                rs.Sd = r9.getSd(zhazhi.Text);
            }
            else
            {
                double es = Convert.ToDouble(Es_yangshi.Text);
                rs.Sd = r9.getSd(zhazhi.Text,r3.phi, r2.Mb, r2.Lk, 
                    es, Convert.ToDouble(ep), (bolt.ScrewMidD_d2 + bolt.ScrewMinD_d3) / 2, r3.I_bers);
            }
            solution.r9 = r9;

            Console.WriteLine("sd:" + rs.Sd);
            #endregion

            #region R_10_sp
            // R10
            Console.WriteLine("R10:");
            // pG = fG*Rm  行数有问题，待定
            double Rm = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[2].Value);
            double fg = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[3].Value);
            double pG = fg * Rm; // 连接件pg
            // f_sa_max = Convert.ToDouble(FAO.Text) * phi;
            R10 r10 = new R10(bolt, r7.getFmzul(), pG, r1.alpha, r4.FZ, r2.Fao * phi);
            if (r2.w == 1)
            {
                // 螺母
                double hs = 0;
                if (gasketChooseBtn.Checked == true)
                {
                    hs = Convert.ToDouble(hs2.Text);
                }

                rs.Sp = r10.getSp(hs, nut);
                rs.Sp_load = r10.getSp_load(hs, nut);
                rs.Spn = r10.getSpn(hs, nut);
                rs.Spn_load = r10.getSpn_load(hs, nut);
                Console.WriteLine("fao:"+ r10.f_sa_max);
                Console.WriteLine("Sp:"+ rs.Sp);
                Console.WriteLine("Sp_load:"+ rs.Sp_load);
                Console.WriteLine("Spn:"+ rs.Spn);
                Console.WriteLine("Spn_load:"+ rs.Spn_load);
            }
            else
            {
                rs.Sp = r10.getSp_nonut();
                rs.Sp_load = r10.getSp_load_nonut();
                Console.WriteLine("Sp:"+ rs.Sp);
                Console.WriteLine("Sp_load:"+ rs.Sp_load);
            }
            solution.r10 = r10;

            #endregion

            #region R_11_meff
            // R11 最小旋合长度  涉及螺母材料的剪切强度，未考虑螺母材料
            // mdesign做法是：螺母螺栓同样强度等级的标准螺母
            Console.WriteLine("R11");
            double rm = Convert.ToDouble(dataClampedChoosed.Rows[0].Cells[2].Value);
            double fbm = Convert.ToDouble(dataClampedChoosed.Rows[0].Cells[4].Value);
            R11 r11;
            if (BoltConnectType.Text == "通孔螺栓连接")
            {
                // 不用计算
                MessageBox.Show("螺栓螺母使用相同强度等级，不计算啮合长度");
            }
            else
            {
                double s = bolt.BoltNutSideWid_s;
                r11 = new R11(bolt, r2.Lk, fbm, rm);
                double meff = r11.getMeff();
                Console.WriteLine("meff:"+ meff);
                solution.r11 = r11;
            }
            #endregion

            #region R_12_sg

            R12 r12 = new R12(bolt, r7.getFmzul(), r1.alpha, r3.phi, r2.Fao, r4.FZ);
            if (boltConnectLoad.Text == "单螺栓连接")
            {
                MessageBox.Show("无需验证剪切");
                double fkrmin = r12.getFKRmin();
                if (fkrmin > 0)
                {
                    Console.WriteLine("R12: 安全");
                }
            }
            else
            {
                double fkrmin = r12.getFKRmin();
                // ra = (DA + Dhamax) / 2
                double ra = r2.r_a;
                if (ra == 0)
                {
                    ra = (r2.D_A + r2.Dhamax) / 2;
                }
                double sg = r12.getSg(r2.f_qmax, r2.q_f, r2.u_Tmin, r2.M_t, r2.q_m, ra);

                if (sg >= r2.sgsoll)
                {
                    if (r2.dtau != 0)
                    {
                        Console.WriteLine("dtau" + r2.dtau);
                        rs.Sa = r12.getSa(double.Parse(Rm_kangla.Text), r2.f_qmax, r2.dtau);
                    }
                    else
                    {
                        rs.Sa = r12.getSa(double.Parse(Rm_kangla.Text), r2.f_qmax);
                    }
                }
                else
                {
                    MessageBox.Show("应满足sg>=SGoll");
                }
                if (rs.Sa >= 1.1)
                {
                    Console.WriteLine("安全");
                }
                else
                {
                    Console.WriteLine("不安全");
                }
            }
            Console.WriteLine("sg" + rs.sgoll);
            Console.WriteLine("sa" + rs.Sa);

            solution.r12 = r12;

            #endregion

            #region R_13_M
            // R13 拧紧力矩
            double da = Math.Max(0, nut.NutBearMaxD);
            R13 r13 = new R13(bolt, da, r2.UKmin, r2.UGmin, r7.getFmzul());
            double MA  = r13.getMA();
            
            rs.Ma = MA;
            Console.WriteLine("R13:");
            Console.WriteLine("MA:" + rs.Ma.ToString());
            solution.r13 = r13;

            #endregion
            return rs;
        }

        private double f88(double rs_)
        {
            return 6.22 * Math.Exp(-0.01166 * rs_) + 0.8552 * Math.Exp(-0.0007668 * rs_);
        }

        private double f109(double rs_)
        {
            return 7.425 * Math.Exp(-0.01147 * rs_) + 1.273 * Math.Exp(-0.001167 * rs_);
        }

        private double f129(double rs_)
        {
            return 8.478 * Math.Exp(-0.01111*rs_) + 1.375 * Math.Exp(-0.0009947 * rs_);
        }


        private double table1()
        {
            int d = Convert.ToInt32(bolt.NormalD_d);
            string level = bolt.boltMaterial.BoltMaterialLevel;
            double u_G = Convert.ToDouble(UGmin.Text);

            int level_index = 0;
            int ug_index = 0;
            if (u_G == 0.08)
            {
                ug_index = 0;
            }
            else if (u_G == 0.1)
            {
                ug_index = 1;
            }
            else if(u_G == 0.12)
            {
                ug_index = 2;
            }
            else if (u_G == 0.14)
            {
                ug_index = 3;
            }
            else if (u_G == 0.16)
            {
                ug_index = 4;
            }
            else if (u_G == 0.2)
            {
                ug_index = 5;
            } 
            else if (u_G == 0.24)
            {
                ug_index = 6;
            }

            if (level == "8.8")
            {
                level_index = 0;
            }
            else if (level == "10.9")
            {
                level_index = 1;
            }
            else if (level == "12.9")
            {
                level_index = 2;
            }

            double Ftb = 0;
            switch (d)
            {
                case 4:
                    double[,] arr4 = new double[3, 7] {
                        { 4.6, 4.5, 4.4, 4.3, 4.2, 3.9, 3.7 },
                        { 6.8, 6.7, 6.5, 6.3, 6.1, 5.7, 5.4 },
                        { 8,   7.8, 7.6, 7.4, 7.1, 6.7, 6.3}
                    };
                    Ftb = arr4[level_index,ug_index];
                    break;
                case 5:
                    double[,] arr5 = new double[3, 7] {
                        { 7.6, 7.4, 7.2, 7.0, 6.8, 6.4, 6 },
                        { 11.1,10.8,10.6,10.3,10.0,9.4, 8.8 },
                        { 13,  12.7,12.4,12.0,11.7,11.0,10.3}
                    };
                    Ftb = arr5[level_index, ug_index];
                    break;
                case 6:
                    double[,] arr6 = new double[3, 7] {
                        { 10.7, 10.4, 10.2, 9.9, 9.6, 9.0, 8.4 },
                        { 15.7, 15.3, 14.9, 14.5,14.1,13.2,12.4 },
                        { 18.4, 17.9, 17.5, 17.0,16.5, 15.5, 14.5}
                    };
                    Ftb = arr6[level_index, ug_index];
                    break;
                case 7:
                    double[,] arr7 = new double[3, 7] {
                        { 15.5, 15.1, 14.8, 14.4, 14.0, 13.1, 12.3 },
                        { 22.7, 22.5, 21.7, 21.1, 20.5, 19.3, 18.1 },
                        { 26.6, 26.0, 25.4, 24.7, 24.0, 22.6, 21.2}
                    };
                    Ftb = arr7[level_index, ug_index];
                    break;
                case 8:
                    double[,] arr8 = new double[3, 7] {
                        { 19.5, 19.1, 18.6, 18.1, 17.6, 16.5, 15.5 },
                        { 28.7, 28.0, 27.3, 26.6, 25.8, 24.3, 22.7 },
                        { 33.6, 32.8, 32.0, 31.1, 30.2, 28.4, 26.6}
                    };
                    Ftb = arr8[level_index, ug_index];
                    break;
                case 10:
                    double[,] arr10 = new double[3, 7] {
                        { 31.0, 30.3, 29.6, 28.8, 27.9, 26.3, 24.7 },
                        { 45.6, 44.5, 43.4, 42.2, 41.0, 38.6, 36.2 },
                        { 53.3, 52.1, 50.8, 49.4, 48.0, 45.2, 42.4}
                    };
                    Ftb = arr10[level_index, ug_index];
                    break;
                case 12:
                    double[,] arr12 = new double[3, 7] {
                        { 45.2, 44.1, 43.0, 41.9, 40.7, 38.3, 35.9 },
                        { 66.3, 64.8, 63.2, 61.5, 59.8, 56.3, 52.8 },
                        { 77.6, 75.9, 74.0, 72.0, 70.0, 65.8, 61.8}
                    };
                    Ftb = arr12[level_index, ug_index];
                    break;
                case 14:
                    double[,] arr14 = new double[3, 7] {
                        { 62.0, 60.6, 59.1, 57.5, 55.9, 52.6, 49.3 },
                        { 91.0, 88.9 ,86.7, 84.4, 82.1, 77.2, 72.5 },
                        { 106.5,104.1,101.5,98.8, 96.0, 90.4, 84.8}
                    };
                    Ftb = arr14[level_index, ug_index];
                    break;
                case 16:
                    double[,] arr16 = new double[3, 7] {
                        { 62.0, 60.6, 59.1, 57.5, 55.9, 52.6, 49.3 },
                        { 91.0, 88.9 ,86.7, 84.4, 82.1, 77.2, 72.5 },
                        { 106.5,104.1,101.5,98.8, 96.0, 90.4, 84.8}
                    };
                    Ftb = arr16[level_index, ug_index];
                    break;
                case 18:
                    double[,] arr18 = new double[3, 7] {
                        { 107, 104, 102, 99, 96, 91, 85 },
                        { 152, 149, 145, 141, 137, 129, 121},
                        { 178, 174, 170, 165, 160, 151 , 142}
                    };
                    Ftb = arr18[level_index, ug_index];
                    break;
                case 20:
                    double[,] arr20 = new double[3, 7] {
                        { 136, 134, 130, 127, 123, 116, 109 },
                        { 194, 190, 186, 181, 176, 166, 156},
                        { 227, 223, 217, 212, 206, 194, 182}
                    };
                    Ftb = arr20[level_index, ug_index];
                    break;
                case 22:
                    double[,] arr22 = new double[3, 7] {
                        { 170, 166, 162, 158, 154, 145, 137 },
                        { 242, 237, 231, 225, 219, 207, 194},
                        { 283, 277, 271, 264, 257, 242, 228}
                    };
                    Ftb = arr22[level_index, ug_index];
                    break;
                case 24:
                    double[,] arr24 = new double[3, 7] {
                        { 196, 192, 188, 183, 178 ,168, 157},
                        { 280, 274, 267, 260, 253, 239, 224},
                        { 327, 320 , 313 ,305, 296 ,279, 262}
                    };
                    Ftb = arr24[level_index, ug_index];
                    break;
                case 27:
                    double[,] arr27 = new double[3, 7] {
                        { 257, 252, 246, 240 ,234, 220, 207},
                        { 367, 359, 351, 342, 333 ,314, 295},
                        { 429, 420 ,410 ,400 ,389 ,367, 345}
                    };
                    Ftb = arr27[level_index, ug_index];
                    break;
                case 30:
                    double[,] arr30 = new double[3, 7] {
                        { 313, 307, 300, 292, 284 ,268,252},
                        { 446, 437, 427, 416, 405, 382 ,359},
                        { 522, 511 ,499, 487 ,474 ,447 ,420}
                    };
                    Ftb = arr30[level_index, ug_index];
                    break;
                case 33:
                    double[,] arr33 = new double[3, 7] {
                        { 389, 381, 373 ,363 ,354 ,334 ,314},
                        { 554 ,543 ,531 ,517 ,504 ,475 ,447},
                        { 649 ,635 ,621 ,605 ,589 ,556 ,523}
                    };
                    Ftb = arr33[level_index, ug_index];
                    break;
                case 36:
                    double[,] arr36 = new double[3, 7] {
                        { 458, 448 ,438 ,427 ,415 ,392 ,368},
                        { 652 ,638, 623 ,608 ,591 ,558 ,524},
                        { 763 ,747 ,729 ,711 ,692 ,653, 614}
                    };
                    Ftb = arr36[level_index, ug_index];
                    break;
                case 39:
                    double[,] arr39 = new double[3, 7] {
                        { 548, 537, 525 ,512 ,498 ,470 ,443},
                        { 781 ,765 ,748 ,729 ,710 ,670 ,630},
                        { 914 ,895 ,875 ,853 ,831 ,784 ,738}
                    };
                    Ftb = arr39[level_index, ug_index];
                    break;
            }
            return Ftb;
        }

        private double table5()
        {
            double ffz = 0;
            double R_z = Convert.ToDouble(Rz.Text);
            if (R_z < 10)
            {
                if (boltConnectLoad.Text == "单螺栓连接")
                {
                    ffz = 7;
                    if (BoltConnectType.Text == "通孔螺栓连接")
                    {
                        ffz = ffz + 2.5;
                    }
                }
                else if (boltConnectLoad.Text == "受横向载荷的单螺栓连接")
                {
                    ffz = 8;
                    if (BoltConnectType.Text == "通孔螺栓连接")
                    {
                        ffz = ffz + 3;
                    }
                }
            }
            else if (R_z >= 10 && R_z < 40)
            {
                if (boltConnectLoad.Text == "单螺栓连接")
                {
                    ffz = 8;
                    if (BoltConnectType.Text == "通孔螺栓连接")
                    {
                        ffz = ffz + 3;
                    }
                }
                else if (boltConnectLoad.Text == "受横向载荷的单螺栓连接")
                {
                    ffz = 10;
                    if (BoltConnectType.Text == "通孔螺栓连接")
                    {
                        ffz = ffz + 4.5;
                    }
                }
            }
            else if (R_z >= 40 && R_z < 160)
            {
                if (boltConnectLoad.Text == "单螺栓连接")
                {
                    ffz = 10;
                    if (BoltConnectType.Text == "通孔螺栓连接")
                    {
                        ffz = ffz + 4;
                    }
                }
                else if (boltConnectLoad.Text == "受横向载荷的单螺栓连接")
                {
                    ffz = 13;
                    if (BoltConnectType.Text == "通孔螺栓连接")
                    {
                        ffz = ffz + 6.5;
                    }
                }
            }
            else
            {
                MessageBox.Show("Rz输入错误，请检查");
                throw new Exception();
            }
            return ffz / 1000;
        }

        private void gasketMaterialChooseBtn_Click(object sender, EventArgs e)
        {

        }

        private void ifPimax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ifPimax.Text == "是")
            {
                pimax.ReadOnly = false;
            }
            else
            {
                pimax.ReadOnly = true;
            }
        }

        private void splitBasic_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void FQ_TextChanged(object sender, EventArgs e)
        {
            if (FQ.Text == "0")
            {
                qF.Enabled = false;
            }
            else
            {
                qF.Enabled = true;
            }
        }

        private void ifa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ifa.Text == "是")
            {
                a.ReadOnly = false;
            }
            else
            {
                a.ReadOnly = true;
            }
        }

        private void ifZhouqiN_CheckedChanged(object sender, EventArgs e)
        {
            if (ifZhouqiN.Checked == true)
            {
                zhouqiN.Enabled = true;
            }
            else
            {
                zhouqiN.Enabled = false;
            }
        }

        private void simulation1_Click(object sender, EventArgs e)
        {

        }

        private void CalFMmin_Click(object sender, EventArgs e)
        {
            R5FMminForm form = new R5FMminForm();
            form.Show();
        }

        private void CalFMmax_Click(object sender, EventArgs e)
        {
            R6FMmaxForm form = new R6FMmaxForm();
            form.Show();
        }

        private void CalFMzul_Click(object sender, EventArgs e)
        {
            R7FMzulForm form = new R7FMzulForm();
            form.Show();
        }

        private void CalFSmax_Click(object sender, EventArgs e)
        {
            R8FSmaxForm form = new R8FSmaxForm();
            form.Show();
        }

        private void CalSp_Click(object sender, EventArgs e)
        {
            R10SpForm form = new R10SpForm();
            form.Show();
        }

        private void CalMeff_Click(object sender, EventArgs e)
        {
            R11MeffForm form = new R11MeffForm();
            form.Show();
        }

        private void CalSg_Click(object sender, EventArgs e)
        {
            R12SgForm form = new R12SgForm();
            form.Show();
        }

        private void CalMa_Click(object sender, EventArgs e)
        {
            R13MAForm form = new R13MAForm();
            form.Show();
        }

        private void genWordBtn_Click(object sender, EventArgs e)
        {
            exportReport();
        }

        public SaveFileDialog saveFileDialog;
        private void exportReport()
        {
            var md = new MarkdownSyntaxTree(new Configuration());

            // Use the SyntaxFactory property to get the factory for creating the Markdown syntax tree
            var mdf = md.SyntaxFactory;

            #region 标题
            // 添加文档内容
            // 标题
            var title = mdf.Paragraph();
            title.AppendChild(mdf.Text("<h1 align=\"center\"> VDI2230单螺栓连接结构设计文档 </h1>"));
            md.AppendChild(title);
            var newLineTrivia = mdf.NewLineTrivia();
            title.GetTrailingTrivia().Add(newLineTrivia);
            #endregion

            #region 几何尺寸
            // 
            var jihechcunTitle = mdf.AtxHeading("几何尺寸", 2);
            md.AppendChild(jihechcunTitle);
            jihechcunTitle.GetTrailingTrivia().Add(newLineTrivia);
            var boltIntro = mdf.Paragraph();
            boltIntro.AppendChild(mdf.Text("圆柱螺栓 M" + bolt.NormalD_d + "X" + bolt.BoltLen_ls + "-" + bolt.boltMaterial.BoltMaterialLevel));
            md.AppendChild(boltIntro);
            jihechcunTitle.GetTrailingTrivia().Add(newLineTrivia);

            #endregion

            #region 通用计算值
            var tong_yong_ji_suan_zhiTitle = mdf.AtxHeading("通用计算值", 2);
            md.AppendChild(tong_yong_ji_suan_zhiTitle);
            tong_yong_ji_suan_zhiTitle.GetTrailingTrivia().Add(newLineTrivia);

            var table = mdf.Paragraph();
            string text = "<table>";
            // 螺栓属性
            string d = "<tr><td>公称直径</td><td>d</td><td>=</td><td>" + bolt.NormalD_d + "mm</td></tr>";
            string p = "<tr><td>螺距</td><td>P</p><td>=</td><td>" + bolt.ScrewP_P + "mm</td></tr>";
            string dh = "<tr><td>镗孔直径</td><td>dh</td><td>=</td><td>" + bolt.BoreD_dh + "mm</td></tr>";
            string dw = "<tr><td>螺栓头承载面外径</td><td>dw</td><td>=</td><td>" + bolt.BoltHeadOutD_dw + "mm</td></tr>";
            string da = "<tr><td>螺栓头承载面内径</td><td>da</td><td>=</td><td>" + bolt.BoltHeadInnerD_da + "mm</td></tr>";
            string d2 = "<tr><td>螺纹中径</td><td>d2</td><td>=</td><td>" + bolt.ScrewMidD_d2 + "mm</td></tr>";
            string d3 = "<tr><td>螺纹小径</td><td>d3</td><td>=</td><td>" + bolt.ScrewMinD_d3 + "mm</td></tr>";
            string l1 = "<tr><td>光杆长度</td><td>l1</td><td>=</td><td>" + bolt.PolishRodLen_l1 + "mm</td></tr>";
            string ls = "<tr><td>螺栓长度</td><td>ls</td><td>=</td><td>" + bolt.BoltLen_ls + "mm</td></tr>";
            string D1 = "<tr><td>螺母螺纹小径</td><td>D1</td><td>=</td><td>" + bolt.BoltNutScrewMinD_D1 + "mm</td></tr>" + "</br>";
            string lk = "<tr><td>夹持长度</td><td>lk</td><td>=</td><td>" + solution.r2.Lk + "mm</td></tr>" + "</br>";
            string phi = "<tr><td>变形锥角</td><td> phi_D </td><td>=</td><td>" + Math.Atan(solution.r2.tanPhi_D) + "°</td></tr>";
            string DAGr = "<tr><td>变形锥极限外径</td><td>DAGr </td><td>=</td><td>" + solution.r2.DAGr + "mm</td></tr>";
            string lH = "<tr><td>变形套筒总高度</td><td> l_H </td><td>=</td><td>" + solution.r3.l_H + "mm</td></tr>";
            string lV = "<tr><td>变形锥总高度</td><td> l_V </td><td>=</td><td>" + solution.r3.l_v + "mm</td></tr>" + "</br>";
            text = text + d + p + dh + dw + da + d2 + d3 + l1 + ls + D1 + lk + phi + DAGr + lH + lV + "</table>";
            table.AppendChild(mdf.Text(text));
            md.AppendChild(table);


            #endregion

            #region 加载数据
            var jia_zai_shu_juTitle = mdf.AtxHeading("加载数据", 2);
            md.AppendChild(jia_zai_shu_juTitle);
            jia_zai_shu_juTitle.GetTrailingTrivia().Add(newLineTrivia);

            var jiazaiTable = mdf.Paragraph();

            text = "<table>";
            string deltaS = "<tr><td>螺栓的弹性柔度(在室温下)</td><td>deltaS</td><td>=</td><td>" + solution.r3.deltaS + "mm</td></tr>";
            string deltaP = "<tr><td>连接件的弹性柔度(在室温下)</td><td>deltaP</td><td>=</td><td>" + solution.r3.deltaP + "mm</td></tr>";
            string alphaA = "<tr><td>拧紧系数</td><td>alpha_A</td><td>=</td><td>" + rs.alphaA + "</td></tr>";
            string n = "<tr><td>载荷导入系数</td><td>n</td><td>=</td><td>" + solution.r3.Nn + "</td></tr>";
            string phi_N = "<tr><td>载荷系数</td><td>phi_N</td><td>=</td><td>" + solution.r3.phi + "</td></tr>";
            string ffz = "<tr><td>嵌入值</td><td>ffz</td><td>=</td><td>" + solution.r4.ffz + "N</td></tr>" + "</br>";

            string Fkp = "<tr><td>密封所需的最小夹紧力</td><td>Fkp</td><td>=</td><td>" + solution.r2.f_kp + "N</td></tr>";
            string Fkerf = "<tr><td>所需的最小夹紧力</td><td>Fkerf</td><td>=</td><td>" + solution.r2.f_kerf + "N</td></tr>";
            string Fz = "<tr><td>因嵌入导致的预紧力损失</td><td>Fz</td><td>=</td><td>" + solution.r4.FZ + "N</td></tr>";
            string Fv = "<tr><td>因工作温度导致的预紧力改变</td><td>△Fv</td><td>=</td><td>" + 0 + "N</td></tr>" + "</br>";

            string FSAmax = "<tr><td>最大附加螺栓载荷</td><td>FSAmax</td><td>=</td><td>" + solution.r2.Fao * solution.r3.phi + "N</td></tr>";
            string FPAmax = "<tr><td>最大附加被连接件载荷</td><td>FPAmax</td><td>=</td><td>" + solution.r2.Fao * (1 - solution.r3.phi) + "N</td></tr>";
            string Fmzul = "<tr><td>室温下的许用装配预紧力</td><td>FMzul</td><td>=</td><td>" + solution.r7.getFmzul() + "N</td></tr>";
            string FMmin = "<tr><td>最小必须装配预紧力</td><td>FMmin</td><td>=</td><td>" + solution.r5.getFmmin() + "N</td></tr>";
            string FMmax = "<tr><td>最大耐受装配预紧力</td><td>FMmax</td><td>=</td><td>" + solution.r6.getFmmax() + "N</td></tr>";

            text = text + deltaS + deltaP + alphaA + phi_N + ffz + Fkp + Fkerf + Fz + Fv + FSAmax + FPAmax + Fmzul + FMmin + FMmax + "</table>";
            jiazaiTable.AppendChild(mdf.Text(text));
            md.AppendChild(jiazaiTable);

            #endregion

            #region 工作应力
            var gong_zuo_ying_liTitle = mdf.AtxHeading("安全校核", 2);
            md.AppendChild(gong_zuo_ying_liTitle);
            gong_zuo_ying_liTitle.GetTrailingTrivia().Add(newLineTrivia);

            var gongzuo_yingliTable = mdf.Paragraph();

            text = "<table>";
            string FSmax = "<tr><td>服役最大螺栓力</td><td>FSmax</td><td>=</td><td>" + solution.r8.getFSmax() + "N</td></tr>";
            string SF = "<tr><td>抗屈服安全系数</td><td>SF</td><td>=</td><td>" + solution.r8.getSf() + "</td></tr>";

            if (rs.Sd == 0)
            {
                // 静态加载 跳过
                text = text + FSmax + SF;
            }
            else
            {
                string Fsm = "<tr><td>平均螺栓力</td><td>Fsm</td><td>=</td><td>" + solution.r9.fsm + "N</td></tr>";
                string deltaa = "<tr><td>作用在螺栓上的连续交替应力</td><td>deltaa</td><td>=</td><td>" + solution.r9.delta + "mm</td></tr>";
                string SD = "<tr><td>疲劳安全系数</td><td>SD</td><td>=</td><td>" + solution.r9.sd + "</td></tr>";
                text = text + FSmax + SF + Fsm + deltaa + SD;
            }

            if (solution.r2.w == 2)
            {
                // 盲孔
                // 表面压应力--- 装配状态
                string zhuangpei_pG = "<tr><td>连接件表面压力</td><td>pG</td><td>=</td><td>" + solution.r10.pG + "N/mm2</td></tr>";
                string sp_bolt = "<tr><td>螺栓头承载面抗压安全系数</td><td>Spmk</td><td>=</td><td>" + rs.Sp + "</td></tr>";
                // 表面压应力--- 工作状态
                string gongzuo_pG = "<tr><td>连接件表面压力</td><td>pG</td><td>=</td><td>" + solution.r10.pG + "N/mm2</td></tr>";
                string sp_bolt_load = "<tr><td>螺栓头承载面抗压安全系数</td><td>SpBk</td><td>=</td><td>" + rs.Sp_load + "</td></tr>";
                text += (zhuangpei_pG + sp_bolt + gongzuo_pG + sp_bolt_load);
            }
            else
            {
                // 表面压应力--- 装配状态
                string zhuangpei_pG = "<tr><td>连接件表面压力</td><td>pG</td><td>=</td><td>" + solution.r10.pG + "N/mm2</td></tr>";
                string sp_bolt = "<tr><td>螺栓头承载面抗压安全系数</td><td>Spmk</td><td>=</td><td>" + rs.Sp + "</td></tr>";
                string sp_nut = "<tr><td>螺母承载面抗压安全系数</td><td>Spmmu</td><td>=</td><td>" + rs.Spn + "</td></tr>";
                // 表面压应力--- 工作状态
                string gongzuo_pG = "<tr><td>连接件表面压力</td><td>pG</td><td>=</td><td>" + solution.r10.pG + "N/mm2</td></tr>";
                string sp_bolt_load = "<tr><td>螺栓头承载面抗压安全系数</td><td>SpBk</td><td>=</td><td>" + rs.Sp_load + "</td></tr>";
                string sp_nut_load = "<tr><td>螺母承载面抗压安全系数</td><td>SpBmu</td><td>=</td><td>" + rs.Spn_load + "</td></tr>";
                text += (zhuangpei_pG + sp_bolt + sp_nut + gongzuo_pG + sp_bolt_load + sp_nut_load);
            }
            

            // 抗滑移安全系数
            if (rs.sgoll == 0)
            {
                // 没有剪力？
            }
            else
            {
                string SG = "<tr><td>抗滑移安全系数</td><td>SG</td><td>=</td><td>" + rs.sgoll + "</td></tr>";
                string SA = "<tr><td>抗剪切安全系数</td><td>SA</td><td>=</td><td>" + rs.Sa + "</td></tr>";
                text += (SG + SA);
            }
            // 弯矩
            string MA = "<tr><td>室温下必要的拧紧扭矩</td><td>MA</td><td>=</td><td>" + (rs.Ma / 1000) + "N·m</td></tr>";
            text += MA;

            gongzuo_yingliTable.AppendChild(mdf.Text(text));
            md.AppendChild(gongzuo_yingliTable);

            #endregion

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Filter = "单个文件(*.md)|所有文件(*)";
            saveFileDialog.FileName = "报告.md";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string mhtPath = saveFileDialog.FileName;
                try
                {
                    string fileName = mhtPath.Split('\\').Last();

                    string directoryPath = mhtPath.Replace(fileName, "");
                    string dir = directoryPath.Replace("\\", "/");

                    // Prepare a path for MD file saving 
                    string savePath = Path.Combine(dir, fileName);

                    // Save MD file
                    md.Save(savePath);
                }
                catch (Exception)
                {
                    MessageBox.Show("生成报告出错");
                }
            }
        }
    }
}
