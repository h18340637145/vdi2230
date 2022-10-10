﻿using System;
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

        List<GasketClass> gasketList = new List<GasketClass>();


        //public MaterialChooseClass material; // matrial Bolt
        public BoltChooseClass boltChooseClass;

        BoltChooseForm boltChooseForm;
        StrengthGradeForm strengthGradeForm;
        ComputeResult rs;

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
                dt.Text = boltChooseForm.GetBoltChooseClass().BoltLen_ls.ToString();
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

        private void strengthGradeChooseBtn_Click(object sender, EventArgs e)
        {
            strengthGradeForm = new StrengthGradeForm(this);
            strengthGradeForm.ShowDialog();
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

        private void pEmbeddedValue_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (pEmbeddedValue.Text == "考虑")
            {
                EmbeddedValue.ReadOnly = false;
            }
            else if (pEmbeddedValue.Text == "不考虑")
            {
                EmbeddedValue.Clear();
                EmbeddedValue.ReadOnly = true;
            }
        }

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
                //Fkerf.Clear();
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
            }
            else if (workingLoads.Text == "动态")
            {
                FAO.Clear();
                fau.Clear();
                FAO.ReadOnly = false;
                fau.ReadOnly = false;
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

        private void saveTempData_Click(object sender, EventArgs e)
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
            s.pEmbeddedValue = pEmbeddedValue.Text;
            s.surfaceRoughness = surfaceRoughness.Text;
            s.EmbeddedValue = EmbeddedValue.Text;
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

        private void readTempData_Click(object sender, EventArgs e)
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
                pEmbeddedValue.Text = s.pEmbeddedValue;
                surfaceRoughness.Text = s.surfaceRoughness;
                EmbeddedValue.Text = s.EmbeddedValue;
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

                //MessageBox.Show("读取完成！");
            }
            catch (Exception)
            {
                MessageBox.Show("未读取数据,请重新输入");
                return;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
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
            pEmbeddedValue.Text = "";
            surfaceRoughness.Text = "";
            EmbeddedValue.Text = "";
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

        }

        private void boltConnect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boltConnectLoad.Text == "单螺栓连接")
            {
                ifDt.Enabled = false;
                isMt.Enabled = false;
                FtauGroup.Visible = false;
            }
            else if (boltConnectLoad.Text == "受横向载荷的单螺栓连接")
            {
                ifDt.Enabled = true;
                isMt.Enabled = true;
                FtauGroup.Visible = true;
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
                dtau.ReadOnly = true;
            }
        }

        private void ifRa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ifRa.Text == "是")
            {
                ra.ReadOnly = false;
                Dhamax.ReadOnly = true;
            }
            else if (ifRa.Text == "否")
            {
                ra.ReadOnly = true;
                Dhamax.ReadOnly = false;

            }
        }

        private void isMt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMt.Text == "是")
            {
                Mt.ReadOnly = false;
                ifRa.Enabled = true;
                Dhamax.ReadOnly = false;
            }
            else if (isMt.Text == "否")
            {
                Mt.ReadOnly = true;
                ifRa.Enabled = false;
                Dhamax.ReadOnly = true;

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
                string normalD_d, screwP_P, boltLen_ls, boreD_dh, boltHeadOutD_dw, boltHeadInnerD_da,
                    screwMidD_d2, screwMinD_d3, polishRodLen_l1, boltNutSideWid_s, boltNutScrewMinD_D1;
                string isnut, isgasket, nutIndex, gasketIndex;
                normalD_d = dr["normalD_d"].ToString();
                screwP_P = dr["screwP_P"].ToString();
                boltLen_ls = dr["boltLen_ls"].ToString();
                boreD_dh = dr["boreD_dh"].ToString();
                boltHeadOutD_dw = dr["boltHeadOutD_dw"].ToString();
                boltHeadInnerD_da = dr["boltHeadInnerD_da"].ToString();
                screwMidD_d2 = dr["screwMidD_d2"].ToString();
                screwMinD_d3 = dr["screwMinD_d3"].ToString();
                polishRodLen_l1 = dr["polishRodLen_l1"].ToString();
                boltNutSideWid_s = dr["boltNutSideWid_s"].ToString();
                boltNutScrewMinD_D1 = dr["boltNutScrewMinD_D1"].ToString();
                nutIndex = dr["dbo_bolttable.nutIndex"].ToString();
                gasketIndex = dr["dbo_bolttable.gasketIndex"].ToString();

                isnut = dr["isnut"].ToString();
                isgasket = dr["isgasket"].ToString();
                string[] str = { normalD_d, screwP_P, boltLen_ls, boreD_dh, boltHeadOutD_dw, boltHeadInnerD_da,
                        screwMidD_d2, screwMinD_d3, polishRodLen_l1, boltNutSideWid_s, boltNutScrewMinD_D1 };

                bolt.BoltLen_ls = double.Parse(boltLen_ls);
                bolt.NormalD_d = double.Parse(normalD_d);
                bolt.ScrewP_P = double.Parse(screwP_P);
                bolt.BoreD_dh = double.Parse(boreD_dh);
                bolt.BoltHeadOutD_dw = double.Parse(boltHeadOutD_dw);
                bolt.BoltHeadInnerD_da = double.Parse(boltHeadInnerD_da);
                bolt.ScrewMidD_d2 = double.Parse(screwMidD_d2);
                bolt.ScrewMinD_d3 = double.Parse(screwMinD_d3);
                bolt.PolishRodLen_l1 = double.Parse(polishRodLen_l1);
                bolt.BoltNutSideWid_s = double.Parse(boltNutSideWid_s);
                bolt.BoltNutScrewMinD_D1 = double.Parse(boltNutScrewMinD_D1);
                
                if (isnut.Equals("1"))
                {
                    //有螺母的
                    string sql2 = "select * from dbo_nutTable where nutIndex=" + nutIndex;
                    IDataReader dr2 = dao.read(sql2);
                    if (dr2.Read())
                    {
                        string nutSpeci, nutStd, nutNutSideWid, nutBearMinD, nutBearMaxD, nutBearOutD, nutHeight;
                        nutSpeci = dr["nutSpeci"].ToString();
                        nutStd = dr["nutStd"].ToString();
                        nutNutSideWid = dr["nutNutSideWid_s"].ToString();
                        nutBearMinD = dr["nutBearMinD_Damin"].ToString();
                        nutBearMaxD = dr["nutBearMaxD_Damax"].ToString();
                        nutBearOutD = dr["nutBearOutD_dwmu"].ToString();
                        nutHeight = dr["nutHeight_m"].ToString();
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
                if (isgasket.Equals("1") && gasketChooseBtn.Checked == true)
                {
                    //有垫片的
                    string sql3 = "select * from dbo_gasketTable where gasketindex=" + gasketIndex;
                    IDataReader dr3 = dao.read(sql3);
                    if (dr3.Read())
                    {
                        string gasketstd, gasketinnerD_dhas, gasketoutD_DA, boltheaddowngasketheight_hs1, nutdowngasketheight_hs2;
                        gasketstd = dr["gasketstd"].ToString();
                        gasketinnerD_dhas = dr["gasketinnerD_dhas"].ToString();
                        gasketoutD_DA = dr["gasketoutD_DA"].ToString();
                        boltheaddowngasketheight_hs1 = dr["boltheaddowngasketheight_hs1"].ToString();
                        nutdowngasketheight_hs2 = dr["nutdowngasketheight_hs2"].ToString();
                        gasket.Gasketstd = gasketstd;
                        gasket.GasketinnerD_dhas = double.Parse(gasketinnerD_dhas);
                        gasket.GasketoutD_DA = double.Parse(gasketoutD_DA);
                        gasket.Boltheaddowngasketheight_hs1 = double.Parse(boltheaddowngasketheight_hs1);
                        gasket.Nutdowngasketheight_hs2 = double.Parse(nutdowngasketheight_hs2);
                    }
                    dr3.Close();
                }
            }

            dr.Close();//关闭连接
        }

        private double computeDAGr(int w, double H)
        {
            double Da = double.Parse(DA.Text);
            double Lk = H;
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
            double DAGr = Ddwm + w * Lk * TanPhi;
            return DAGr;
        }

        private double ComputeDeltaS(int w, double H, double deltaM, double AN)
        {
            double Ad3 = (bolt.ScrewMinD_d3) * (bolt.ScrewMinD_d3) * pi / 4;
            double deltaG = 0.5 * (bolt.NormalD_d) / double.Parse(Es_yangshi.Text) / Ad3;

            double lGew = H - bolt.PolishRodLen_l1;
            double deltaGew = lGew / double.Parse(Es_yangshi.Text) / Ad3;
            double deltaS1 = bolt.PolishRodLen_l1 / double.Parse(Es_yangshi.Text) / AN;
            double deltaS = deltaS1 + deltaGew + deltaG + deltaM;
            Console.WriteLine("bolt.PolishRodLen_l1:" + bolt.PolishRodLen_l1.ToString());
            Console.WriteLine("AN:" + AN.ToString());
            Console.WriteLine("deltaS1:" + deltaS1.ToString());
            Console.WriteLine("deltaGew:" + deltaGew.ToString());
            Console.WriteLine("deltaG:" + deltaG.ToString());
            Console.WriteLine("deltaM:" + deltaM.ToString());

            return deltaS;
        }

        private double computeDeltaP(int w, double H, double Ep, double DAGr)
        {
            // R3.3: compute deltaP
            Console.WriteLine("w:" + w.ToString());
            Console.WriteLine("h:" + H.ToString());
            Console.WriteLine("Ep:" + Ep.ToString());

            double deltaP = 0;
            double dw = (bolt.BoltHeadOutD_dw);
            double dh = bolt.BoreD_dh;
            double Lk = H;
            double BL = Lk / dw;
            double y = double.Parse(DA.Text) / dw;
            double TanPhi = 0;
            if (w == 1)
            {
                TanPhi = 0.362 + 0.032 * Math.Log(BL / 2) + 0.153 * Math.Log(y);
            }
            else if (w == 2)
            {
                TanPhi = 0.348 + 0.013 * Math.Log(BL) + 0.193 * Math.Log(y);
            }
            Console.WriteLine("dw:" + dw.ToString()); // x
            Console.WriteLine("dh:" + dh.ToString());
            Console.WriteLine("DAGr:" + DAGr.ToString()); // x
            Console.WriteLine("y:" + y.ToString());
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
            Console.WriteLine("deltaP:" + deltaP.ToString());

            return deltaP;
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
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

            // 防呆组合问题

            //ComputeResult rs = new ComputeResult();
            this.GetCalParameter();
            rs = this.Solve();
            // 显示结果
            resGrid.SelectedObject = rs;
            if (rs.Sf >= 1 && rs.Sg >= 1 && rs.Sp >= 1 && rs.Sd >= 1)
            {
                MessageBox.Show("安全");
            }
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
                Nn = double.Parse(n.Text);
            }
            else
            {
                // 通过sv计算n的情况
                // 通过查表 la ak h sv 四个参数共同计算
                LA = double.Parse(lA.Text);
                Ak = double.Parse(ak.Text);
                SV = sv.Text;

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
            ComputeResult rs = new ComputeResult();

            // R2：计算DA DAGr = dw + w lk TanPhi
            Console.WriteLine("R2:");
            // 计算w
            int w = 0;
            // 计算夹紧长度H = lk  贯穿的螺栓是求和
            // 螺纹是求第一个夹紧件高度
            double H = 0;
            if (BoltConnectType.Text == "通孔螺栓连接")
            {
                w = 1; // DSV
                int rows = dataClampedChoosed.RowCount - 1;
                for (int i = 0; i < rows; i++)
                {
                    H += Convert.ToSingle(dataClampedChoosed.Rows[i].Cells[5].Value);
                }
            }
            else if (BoltConnectType.Text == "盲孔螺栓连接")
            {
                w = 2; // ESV
                H = Convert.ToSingle(dataClampedChoosed.Rows[1].Cells[5].Value);
                Console.WriteLine("H=" + H.ToString());
            }

            double DAGr = computeDAGr(w, H);

            // R3: 计算回弹及系数
            // R3.1: 计算回弹及系数
            Console.WriteLine("R3:");
            double Nn = computeN(H);
            // R3.2: compute deltaS
            double d = bolt.NormalD_d;
            double AN = d * d * pi / 4;
            double lM = 0;
            if (w == 1)
            {  
                // s
                lM = 0.4 * d;
            }
            else
            {
                // w
                lM = 0.33 * d;
            }
            //Console.WriteLine("Es_yangshi:" + double.Parse(Es_yangshi.Text));
            double deltaM = lM / double.Parse(Es_yangshi.Text) / AN;
            double deltaS = ComputeDeltaS(w, H, deltaM, AN);
            Console.WriteLine("deltaM:" + deltaM.ToString());
            Console.WriteLine("deltaS:" + deltaS.ToString());

            // R3.3: compute deltaP
            double deltaP = computeDeltaP(w, H, double.Parse(Es_yangshi.Text), DAGr);
            //MessageBox.Show("deltaP:" + deltaP.ToString());

            double deltaPzu = (w - 1) * deltaM;
            double PhiK = (deltaP + deltaPzu) / (deltaP + deltaS);
            double PhiN = Nn * PhiK;
            Console.WriteLine("deltaS:" + deltaS.ToString());
            Console.WriteLine("PhiK:" + PhiK.ToString());
            Console.WriteLine("PhiN:" + PhiN.ToString());

            // R4:
            Console.WriteLine("R4:");
            double ffz = double.Parse(fz.Text);
            double Fz = ffz / (deltaS + deltaP);
            rs.Fz = Fz;
            Console.WriteLine("Fz:" + rs.Fz.ToString());


            // R5:
            Console.WriteLine("R5:");
            double fkerf = 0;
            if (isFkerf.Enabled == true && isFkerf.Text == "选择")
            {
                fkerf = double.Parse(Fkerf.Text);
            }
            fkerf = Math.Max(fkerf, 0);
            double Famax = double.Parse(FAO.Text);
            double Famin = 0;
            if (fau.Text == "" || fau.Text == null)
            {
                Famin = 0;
            }
            else
            {
                Famin = double.Parse(fau.Text);
            }
            double Fmmin = fkerf + (1 - PhiN) * Famax + Fz;
            rs.Fmmin = Fmmin;
            Console.WriteLine("Fmmin:" + rs.Fmmin.ToString());

            // R6:
            Console.WriteLine("R6:");
            double alpha = 0;
            if (tighten.Text == "自定义输入")
            {
                alpha = double.Parse(tightenCoef.Text);
            }
            else if (tighten.Text == "屈服拧紧")
            {
                alpha = 1;
            }
            double Fmmax = alpha * Fmmin;
            rs.Fmmax = Fmmax;
            Console.WriteLine("Fmmax:" + rs.Fmmax.ToString());


            // R7:
            Console.WriteLine("R7:");
            double V = double.Parse(v.Text);
            double d0 = (bolt.ScrewMidD_d2 + bolt.ScrewMinD_d3) / 2;
            double A0 = pi * d0 * d0 / 4;
            double Rp = double.Parse(Rpmin_qufu.Text);
            double Pp = (bolt.ScrewP_P);
            double d2 = (bolt.ScrewMidD_d2);
            double Ugmin = double.Parse(UGmin.Text);
            double d2_3_2d0 = 3 * d2 / (2 * d0);
            double p_pid_2 = Pp / pi / d2;
            double square = (d2_3_2d0 * (p_pid_2 + 1.155 * Ugmin)) * (d2_3_2d0 * (p_pid_2 + 1.155 * Ugmin));
            double Fmzul = A0 * V * Rp / Math.Sqrt(1 + 3 * square);
            if (Fmzul > Fmmax)
            {
                // 合理
                Console.WriteLine("合理");
            }
            else
            {
                // 不合理
                Console.WriteLine("不合理");
            }
            rs.Fmzul = Fmzul;
            Console.WriteLine("A0:" + A0.ToString());
            Console.WriteLine("square:" + square.ToString());
            Console.WriteLine("Fmzul:" + rs.Fmzul.ToString());


            // R8: 工作应力
            // 温度影响
            Console.WriteLine("R8:");
            double deltaFv = 0;
            double FSmax = Fmzul + PhiN * Fmmax + deltaFv;
            double deltamax = FSmax / A0;
            double kt = 0.5;
            double temp = Fmzul * d2 * ((Pp / pi / d2) + 1.155 * Ugmin) / 2;
            double tmax = temp / ((pi * d0 * d0 * d0) / 16);
            double deltaRedB = Math.Sqrt(tmax * tmax + 3 * (kt * tmax) * (kt * tmax));
            double sf = double.Parse(Rpmin_qufu.Text) / deltaRedB;
            if (sf >= 1)
            {
                // 安全
                Console.WriteLine("安全");
            }
            else
            {
                // 不安全
                Console.WriteLine("不安全");
            }
            rs.Sf = sf;
            Console.WriteLine("Fmzul:" + Fmzul.ToString());
            Console.WriteLine("temp:" + temp.ToString());
            Console.WriteLine("FSmax:" + FSmax.ToString());
            Console.WriteLine("tmax:" + tmax.ToString());
            Console.WriteLine("deltaRedB:" + deltaRedB.ToString());
            Console.WriteLine("sf:" + rs.Sf.ToString());


            // R9;交变应力
            // 非偏心
            Console.WriteLine("R9:");
            double delta = 0;
            double d3 = bolt.ScrewMinD_d3;
            double As = pi * d0 * d0 / 4;
            double deltaASV = 0;
            double sd = 0;

            delta = PhiN * (Famax - Famin) / 2 / As;
            deltaASV = 0.85 * (150 / d + 45);
            sd = deltaASV / delta;
            if (sd > 1)
            {
                // 安全
                Console.WriteLine("安全");
            }
            else
            {
                // 不安全
                Console.WriteLine("不安全");
            }
            rs.Sd = sd;
            Console.WriteLine("Famax:" + Famax.ToString());
            Console.WriteLine("Famin:" + Famin.ToString());
            Console.WriteLine("As:" + As.ToString());
            Console.WriteLine("delta:" + delta.ToString());
            Console.WriteLine("deltaASV:" + deltaASV.ToString());
            Console.WriteLine("sd:" + rs.Sd.ToString());



            // R10
            Console.WriteLine("R10:");
            double dh = bolt.BoreD_dh;
            double dw = bolt.BoltHeadOutD_dw;
            double Apmin = pi * (dw * dw - dh * dh) / 4;
            double pMmax = Fmzul / Apmin;
            // pG = fG*Rm  行数有问题，待定
            double Rm = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[2].Value);
            double fg = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[3].Value);
            double pG = fg * Rm;
            double sp = pG / pMmax;
            if (sp > 1)
            {
                // 安全
                Console.WriteLine("安全");
            }
            else
            {
                Console.WriteLine("不安全");
                // 不安全
            }
            double Fv = Fmzul - Fz;
            double pBmax = (Fv + FSmax - deltaFv) / Apmin;
            if (pBmax <= pG)
            {
                // 正常
            }

            if (Fz > PhiN * Famax)
            {
                // 忽略表面压力计算
            }
            rs.Sp = sp;
            Console.WriteLine("Apmin:" + Apmin.ToString());
            Console.WriteLine("pMmax:" + pMmax.ToString());
            Console.WriteLine("pG:" + pG.ToString());
            Console.WriteLine("sp:" + sp.ToString());
            Console.WriteLine("Fv:" + Fv.ToString());
            Console.WriteLine("pBmax:" + pBmax.ToString());

            // R11 最小旋合长度  涉及螺母材料的剪切强度，未考虑螺母材料
            // mdesign做法是：螺母螺栓同样强度等级的标准螺母
            double meff = 0;
            double mges = 0;
            if (BoltConnectType.SelectedText == "通孔螺栓连接")
            {
                // 不用计算
            }
            else
            {
                // 计算啮合长度meff
                // 螺栓的剪切应力
                double t_bolt = boltChooseClass.boltMaterial.BoltMaterialRatio_fB * double.Parse(Rm_kangla.Text);
                // tb == t_clamped
                double t_clamped = Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[4].Value) * Convert.ToSingle(dataClampedChoosed.Rows[0].Cells[2].Value);
                double up = bolt.NormalD_d * (bolt.ScrewP_P / 2 + (bolt.NormalD_d - bolt.ScrewMidD_d2) * Math.Tan(30 * Math.PI / 180));
                double down = bolt.BoltNutScrewMinD_D1 * ((bolt.ScrewP_P / 2) + (bolt.ScrewMidD_d2 - bolt.BoltNutScrewMinD_D1) * Math.Tan(30 * Math.PI / 180));
                double Rs = up / down * t_clamped / t_bolt;
                Console.WriteLine("t_bolt:" + t_bolt.ToString());
                Console.WriteLine("tb:" + t_clamped.ToString());
                Console.WriteLine("Rs:" + Rs.ToString());
                double C1 = 0;
                double C2 = 0;
                double C3 = 0;

                if (w == 2)
                {
                    // ESV 
                    C1 = 1;
                    if (Rs > 0.4 && Rs < 1)
                    {
                        C3 = 0.728 + 1.769 * Rs - 2.896 * Rs * Rs + 1.296 * Rs * Rs * Rs;
                    }
                    else if (Rs <= 0.4)
                    {
                        // 公式存在疑问
                        C3 = 0.728 + 1.769 * Rs - 2.896 * Rs * Rs + 1.296 * Rs * Rs * Rs;
                    }
                    else
                    {
                        C3 = 0.897;
                    }
                    Console.WriteLine("C1:" + C1.ToString());
                    Console.WriteLine("C3:" + C3.ToString());
                    double meff_up = double.Parse(Rm_kangla.Text) * As * bolt.ScrewP_P;
                    Console.WriteLine("Rm:" + Rm_kangla.Text);
                    Console.WriteLine("As:" + As.ToString());
                    Console.WriteLine("meff_up:" + meff_up.ToString());

                    double temp_meff = bolt.ScrewP_P / 2 + (d - d2) * (Math.Tan(30 * pi / 180));
                    Console.WriteLine("bolt.ScrewP_P / 2:" + (bolt.ScrewP_P / 2).ToString());
                    Console.WriteLine("(d - d2):" + (d - d2).ToString());
                    Console.WriteLine("(Math.Tan(30 * pi / 180):" + (Math.Tan(30 * pi / 180).ToString()));
                    Console.WriteLine("temp_meff:" + temp_meff.ToString());
                    double meff_down = C1 * C3 * t_clamped * temp_meff * pi * d;

                    meff = meff_up / meff_down;
                    mges = meff + 2 * bolt.ScrewP_P;
                    Console.WriteLine("meff_up:" + meff_up.ToString());
                    Console.WriteLine("meff_down:" + meff_down.ToString());

                }
                else if (w != 2 && Rs < 1)
                {
                    double s = bolt.BoltNutSideWid_s;
                    if (s / d >= 1.4 && s / d <= 1.9)
                    {
                        C1 = 3.9 * s / d - (s / d) * (s / d) - 2.61;
                    }
                    else
                    {
                        C1 = 1;
                        if (Rs > 0.4 && Rs < 1)
                        {
                            C3 = 0.728 + 1.769 * Rs - 2.896 * Rs * Rs + 1.296 * Rs * Rs * Rs;
                        }
                        else if (Rs <= 0.4)
                        {
                            // 公式存在疑问
                            C3 = 0.728 + 1.769 * Rs - 2.896 * Rs * Rs + 1.296 * Rs * Rs * Rs;
                        }
                        else
                        {
                            C3 = 0.897;
                        }
                    }

                    Console.WriteLine("C1:" + C1.ToString());
                    Console.WriteLine("C2:" + C2.ToString());
                    Console.WriteLine("C3:" + C3.ToString());
                    double meff_up = double.Parse(Rm_kangla.Text) * As * bolt.ScrewP_P;
                    Console.WriteLine("Rm:" + Rm_kangla.Text);
                    Console.WriteLine("As:" + As.ToString());
                    Console.WriteLine("meff_up:" + meff_up.ToString());

                    double meff_down = C1 * C3 * t_clamped * (bolt.ScrewP_P / 2 + (d - d2) * Math.Tan(30 * Math.PI / 180) * Math.PI * d);

                    meff = meff_up / meff_down;
                    mges = meff + 2 * bolt.ScrewP_P;
                    Console.WriteLine("meff_up:" + meff_up.ToString());
                    Console.WriteLine("meff_down:" + meff_down.ToString());

                }
                else if (w != 2 && Rs >= 1)
                {
                    double s = bolt.BoltNutSideWid_s;
                    if (s / d >= 1.4 && s / d <= 1.9)
                    {
                        C1 = 3.9 * s / d - (s / d) * (s / d) - 2.61;
                    }
                    else
                    {
                        C1 = 1;
                    }

                    if (Rs < 2.2 && Rs > 1)
                    {
                        C2 = 5.594 - 13.682 * Rs + 14.107 * Rs * Rs
                            - 6.057 * Rs * Rs * Rs + 0.9353 * Rs * Rs * Rs * Rs;
                    }
                    else if (Rs >= 2.2)
                    {
                        C2 = 1.187;
                    }

                    Console.WriteLine("C1:" + C1.ToString());
                    Console.WriteLine("C2:" + C2.ToString());
                    double meff_up = double.Parse(Rm_kangla.Text) * As * bolt.ScrewP_P;
                    Console.WriteLine("Rm:" + Rm_kangla.Text);
                    Console.WriteLine("As:" + As.ToString());
                    Console.WriteLine("meff_up:" + meff_up.ToString());

                    double meff_down = C1 * C2 * t_clamped * (bolt.ScrewP_P / 2 + (-d + d2) * Math.Tan(30 * Math.PI / 180) * Math.PI * d);

                    meff = meff_up / meff_down;
                    mges = meff + 2 * bolt.ScrewP_P;
                    Console.WriteLine("meff_up:" + meff_up.ToString());
                    Console.WriteLine("meff_down:" + meff_down.ToString());

                }

                // 连接件的剪切应力
            }
            Console.WriteLine("mges:" + mges.ToString());


            // R12 滑动安全余量和剪切应力     无剪力跳过
            double FKRmin = Fmzul / alpha - (1 - PhiN) * Famax - Fz - deltaFv;
            double sg = FKRmin / fkerf;
            rs.Sg = sg;
            Console.WriteLine("R12:");
            Console.WriteLine("FKRmin:" + FKRmin.ToString());
            Console.WriteLine("sg:" + rs.Sg.ToString());
            if (boltConnectLoad.Text == "单螺栓连接")
            {
                if (sg > 1)
                {
                    // 安全
                    Console.WriteLine("安全");
                }
                else
                {
                    Console.WriteLine("不安全");
                    // 不安全
                }
            }
            else if (boltConnectLoad.Text == "受横向载荷的单螺栓连接")
            {
                double Fq = double.Parse(FQ.Text);
                double Utmin = double.Parse(UTmin.Text);
                double sgsoll = 0;
                if (isSGsoll.Text == "是")
                {
                    sgsoll = double.Parse(SGsoll.Text);
                }
                else
                {
                    sgsoll = 1;
                }
                Console.WriteLine("Fq:" + Fq.ToString());
                Console.WriteLine("Utmin:" + Utmin.ToString());
                Console.WriteLine("sgsoll:" + sgsoll.ToString());

                if (sg >= sgsoll)
                {
                    // 计算剪力
                    double dt = 0;
                    if (dtau.ReadOnly == true)
                    {
                        dt = bolt.NormalD_d;
                    }
                    else
                    {
                        if (dtau.Text == null || dtau.Text == "")
                        {
                            MessageBox.Show("剪切横截面直接dt！");
                            return null;
                        }
                        else
                        {
                            dt = double.Parse(dtau.Text);
                        }
                    }
                    double At = pi * dt * dt / 4;
                    double T_bs = boltChooseClass.boltMaterial.BoltMaterialRatio_fB * double.Parse(Rm_kangla.Text);
                    double FQmax = Fq;
                    rs.Sa = At * T_bs / FQmax;
                    if (rs.Sa >= 1.1)
                    {
                        Console.WriteLine("安全");
                    }
                    else
                    {
                        Console.WriteLine("不安全");
                    }
                    Console.WriteLine("At:" + At.ToString());
                    Console.WriteLine("T_bs:" + T_bs.ToString());
                    Console.WriteLine("FQmax:" + FQmax.ToString());
                    Console.WriteLine("rs.Sa:" + rs.Sa.ToString());
                }
                else
                {
                    Console.WriteLine("不安全");
                    // 不安全
                }
            }

            // R13 拧紧力矩
            double da = nut.NutBearMaxD;
            double dkm = (Math.Max(dh, da) + dw) / 2;
            double Ukmin = double.Parse(UKmin.Text);
            double MA = Fmzul * (0.16 * Pp + 0.58 * d2 * Ugmin + dkm / 2 * Ukmin);
            rs.Ma = MA;
            Console.WriteLine("R13:");
            Console.WriteLine("Ukmin:" + Ukmin.ToString());
            Console.WriteLine("MA:" + rs.Ma.ToString());
            return rs;
        }

        private void gasketMaterialChooseBtn_Click(object sender, EventArgs e)
        {

        }


    }
}
