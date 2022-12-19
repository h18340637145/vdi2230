namespace WindowsFormsApp1
{
    partial class ValidateDesignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar1 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton1, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 3.8800002446097692D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar1 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton1))});
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(459, 388), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValidateDesignForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveTempData = new System.Windows.Forms.ToolStripMenuItem();
            this.readTempData = new System.Windows.Forms.ToolStripMenuItem();
            this.computeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.stepCalBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CalFMmin = new System.Windows.Forms.ToolStripMenuItem();
            this.CalFMmax = new System.Windows.Forms.ToolStripMenuItem();
            this.CalFMzul = new System.Windows.Forms.ToolStripMenuItem();
            this.CalFSmax = new System.Windows.Forms.ToolStripMenuItem();
            this.CalSp = new System.Windows.Forms.ToolStripMenuItem();
            this.CalMeff = new System.Windows.Forms.ToolStripMenuItem();
            this.CalSg = new System.Windows.Forms.ToolStripMenuItem();
            this.CalMa = new System.Windows.Forms.ToolStripMenuItem();
            this.genWordBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DataInputTable = new System.Windows.Forms.TabControl();
            this.basicData = new System.Windows.Forms.TabPage();
            this.splitUpDown = new System.Windows.Forms.SplitContainer();
            this.splitData = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.pianxinGroup = new System.Windows.Forms.GroupBox();
            this.isIbtLabel = new System.Windows.Forms.Label();
            this.ifaLabel = new System.Windows.Forms.Label();
            this.jiaZaiQingKuangLabel = new System.Windows.Forms.Label();
            this.SsymLabel = new System.Windows.Forms.Label();
            this.cB = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.e = new System.Windows.Forms.TextBox();
            this.Ibt = new System.Windows.Forms.TextBox();
            this.bT = new System.Windows.Forms.TextBox();
            this.cT = new System.Windows.Forms.TextBox();
            this.u = new System.Windows.Forms.TextBox();
            this.cBUnit = new System.Windows.Forms.Label();
            this.bUnit = new System.Windows.Forms.Label();
            this.eUnit = new System.Windows.Forms.Label();
            this.IbtUnit = new System.Windows.Forms.Label();
            this.bTUnit = new System.Windows.Forms.Label();
            this.cTUnit = new System.Windows.Forms.Label();
            this.ifa = new System.Windows.Forms.ComboBox();
            this.isIbt = new System.Windows.Forms.ComboBox();
            this.jiaZaiQingKuang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IbtLabel = new System.Windows.Forms.Label();
            this.bTLabel = new System.Windows.Forms.Label();
            this.cTLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SsymUnit = new System.Windows.Forms.Label();
            this.Ssym = new System.Windows.Forms.TextBox();
            this.splitBasic = new System.Windows.Forms.SplitContainer();
            this.FtauGroup = new System.Windows.Forms.GroupBox();
            this.qF = new System.Windows.Forms.ComboBox();
            this.isSGsoll = new System.Windows.Forms.ComboBox();
            this.isSGsollLabel = new System.Windows.Forms.Label();
            this.UTmin = new System.Windows.Forms.TextBox();
            this.SGsoll = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qFLabel = new System.Windows.Forms.Label();
            this.UTminLabel = new System.Windows.Forms.Label();
            this.FQ = new System.Windows.Forms.TextBox();
            this.FQLabel = new System.Windows.Forms.Label();
            this.FQUnit = new System.Windows.Forms.Label();
            this.basicGroup = new System.Windows.Forms.GroupBox();
            this.ClampingWayLabel = new System.Windows.Forms.Label();
            this.BoltConnectTypeLabel = new System.Windows.Forms.Label();
            this.clampingWay = new System.Windows.Forms.ComboBox();
            this.BoltConnectType = new System.Windows.Forms.ComboBox();
            this.boltConnectLoad = new System.Windows.Forms.ComboBox();
            this.boltConnectLoadLabel = new System.Windows.Forms.Label();
            this.phiDimGroup = new System.Windows.Forms.GroupBox();
            this.qM = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Mt = new System.Windows.Forms.TextBox();
            this.MtLabel = new System.Windows.Forms.Label();
            this.MtUnit = new System.Windows.Forms.Label();
            this.JointFaceEquOutDiameterLabel = new System.Windows.Forms.Label();
            this.Dhamax = new System.Windows.Forms.TextBox();
            this.ra = new System.Windows.Forms.TextBox();
            this.pimax = new System.Windows.Forms.TextBox();
            this.dtau = new System.Windows.Forms.TextBox();
            this.DA2 = new System.Windows.Forms.TextBox();
            this.ifRaLabel = new System.Windows.Forms.Label();
            this.DhamaxUnit = new System.Windows.Forms.Label();
            this.raUnit = new System.Windows.Forms.Label();
            this.ifMtLabel = new System.Windows.Forms.Label();
            this.ADLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ifPreDtLabel = new System.Windows.Forms.Label();
            this.pimaxUnit = new System.Windows.Forms.Label();
            this.dtauUnit = new System.Windows.Forms.Label();
            this.ifRa = new System.Windows.Forms.ComboBox();
            this.ADUnit = new System.Windows.Forms.Label();
            this.DA2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.isMt = new System.Windows.Forms.ComboBox();
            this.raLabel = new System.Windows.Forms.Label();
            this.ifPimax = new System.Windows.Forms.ComboBox();
            this.ifDt = new System.Windows.Forms.ComboBox();
            this.pimaxLabel = new System.Windows.Forms.Label();
            this.dtauLabel = new System.Windows.Forms.Label();
            this.JointFaceUpEquOutDiameterLabel = new System.Windows.Forms.Label();
            this.UpperLimitAxialLoadDisplay = new System.Windows.Forms.Label();
            this.DA = new System.Windows.Forms.TextBox();
            this.AD = new System.Windows.Forms.TextBox();
            this.BoltGroup = new System.Windows.Forms.GroupBox();
            this.fBS = new System.Windows.Forms.TextBox();
            this.Rm_kangla = new System.Windows.Forms.TextBox();
            this.Rpmin_qufu = new System.Windows.Forms.TextBox();
            this.beta = new System.Windows.Forms.TextBox();
            this.Es_yangshi = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.TextBox();
            this.ScrewLengthls = new System.Windows.Forms.TextBox();
            this.boringDh = new System.Windows.Forms.TextBox();
            this.boltStd = new System.Windows.Forms.TextBox();
            this.strengthGradeChooseBtn = new System.Windows.Forms.Button();
            this.boltChooseBtn = new System.Windows.Forms.Button();
            this.screwTypeLabel = new System.Windows.Forms.Label();
            this.fBSLabel = new System.Windows.Forms.Label();
            this.Rm_kanglaLabel = new System.Windows.Forms.Label();
            this.BoltType = new System.Windows.Forms.ComboBox();
            this.betaLabel = new System.Windows.Forms.Label();
            this.Rpmin_qufuLabel = new System.Windows.Forms.Label();
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.Es_yangshiLabel = new System.Windows.Forms.Label();
            this.dtLabel = new System.Windows.Forms.Label();
            this.ScrewLengthLabel = new System.Windows.Forms.Label();
            this.Rm_kanglaUnit = new System.Windows.Forms.Label();
            this.Rpmin_qufuUnit = new System.Windows.Forms.Label();
            this.EsUnit = new System.Windows.Forms.Label();
            this.dtUnit = new System.Windows.Forms.Label();
            this.betaUnit = new System.Windows.Forms.Label();
            this.ScrewLengthUnit = new System.Windows.Forms.Label();
            this.boringDhUnit = new System.Windows.Forms.Label();
            this.boringDhLabel = new System.Windows.Forms.Label();
            this.strengthGradeLabel = new System.Windows.Forms.Label();
            this.boltStdLabel = new System.Windows.Forms.Label();
            this.chooseBoltLabel = new System.Windows.Forms.Label();
            this.BoltTypeLabel = new System.Windows.Forms.Label();
            this.screwType = new System.Windows.Forms.ComboBox();
            this.dataSource = new System.Windows.Forms.ComboBox();
            this.modeAndOpt = new System.Windows.Forms.SplitContainer();
            this.modelControlBox = new System.Windows.Forms.GroupBox();
            this.shadedButton = new System.Windows.Forms.RadioButton();
            this.animateCameraCheckBox = new System.Windows.Forms.CheckBox();
            this.shadingLabel = new System.Windows.Forms.Label();
            this.topViewButton = new System.Windows.Forms.Button();
            this.wireframeButton = new System.Windows.Forms.RadioButton();
            this.sideViewButton = new System.Windows.Forms.Button();
            this.renderedButton = new System.Windows.Forms.RadioButton();
            this.frontViewButton = new System.Windows.Forms.Button();
            this.hiddenLinesButton = new System.Windows.Forms.RadioButton();
            this.isoViewButton = new System.Windows.Forms.Button();
            this.flatButton = new System.Windows.Forms.RadioButton();
            this.viewLabel = new System.Windows.Forms.Label();
            this.showOriginButton = new System.Windows.Forms.CheckBox();
            this.showGridButton = new System.Windows.Forms.CheckBox();
            this.showExtentsButton = new System.Windows.Forms.CheckBox();
            this.hideShowLabel = new System.Windows.Forms.Label();
            this.showVerticesButton = new System.Windows.Forms.CheckBox();
            this.simulation1 = new devDept.Eyeshot.Model();
            this.Mode3D = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.introGroup = new System.Windows.Forms.GroupBox();
            this.introLabel = new System.Windows.Forms.Label();
            this.tableTab = new System.Windows.Forms.TabControl();
            this.getNTable = new System.Windows.Forms.TabPage();
            this.svTable = new System.Windows.Forms.TabPage();
            this.meffd = new System.Windows.Forms.TabPage();
            this.connAndLoadData = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitConn = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataClampedChoosed = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rmmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatioFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fBRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataClamped = new System.Windows.Forms.DataGridView();
            this.clampedMaterialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbomaterialClampedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet18 = new WindowsFormsApp1.BoltConnectionSystemDataSet18();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.splitGasketNut = new System.Windows.Forms.SplitContainer();
            this.gasketGroup = new System.Windows.Forms.GroupBox();
            this.gasketChooseBtn = new System.Windows.Forms.CheckBox();
            this.gasketMaterialGroup = new System.Windows.Forms.GroupBox();
            this.fGUnit = new System.Windows.Forms.Label();
            this.RmminSUnit = new System.Windows.Forms.Label();
            this.EPSUnit = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.RmminS = new System.Windows.Forms.TextBox();
            this.Es_gasket = new System.Windows.Forms.TextBox();
            this.gasketMaterialChooseBtn = new System.Windows.Forms.Button();
            this.fGLabel = new System.Windows.Forms.Label();
            this.RmminSLabel = new System.Windows.Forms.Label();
            this.EPSLabel = new System.Windows.Forms.Label();
            this.surfaceRoughnessUnit = new System.Windows.Forms.Label();
            this.CounterBoreDepthUnit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hs2Unit = new System.Windows.Forms.Label();
            this.DAUUnit = new System.Windows.Forms.Label();
            this.dhasUnitLabel = new System.Windows.Forms.Label();
            this.Rz = new System.Windows.Forms.TextBox();
            this.CounterBoreDepth = new System.Windows.Forms.TextBox();
            this.dha = new System.Windows.Forms.TextBox();
            this.hs2 = new System.Windows.Forms.TextBox();
            this.surfaceRoughnessLabel = new System.Windows.Forms.Label();
            this.CounterBoreDepthLabel = new System.Windows.Forms.Label();
            this.dhaLabel = new System.Windows.Forms.Label();
            this.dau = new System.Windows.Forms.TextBox();
            this.hs2Label = new System.Windows.Forms.Label();
            this.dhas = new System.Windows.Forms.TextBox();
            this.DAULabel = new System.Windows.Forms.Label();
            this.isCounterBore = new System.Windows.Forms.ComboBox();
            this.isAngle = new System.Windows.Forms.ComboBox();
            this.isCounterBoreLabel = new System.Windows.Forms.Label();
            this.isAngleLabel = new System.Windows.Forms.Label();
            this.dhasLabel = new System.Windows.Forms.Label();
            this.nutGroup = new System.Windows.Forms.GroupBox();
            this.mUnit = new System.Windows.Forms.Label();
            this.DwUnit = new System.Windows.Forms.Label();
            this.DazUnit = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.TextBox();
            this.Dw = new System.Windows.Forms.TextBox();
            this.mLabel = new System.Windows.Forms.Label();
            this.Daz = new System.Windows.Forms.TextBox();
            this.DwLabel = new System.Windows.Forms.Label();
            this.DaLabel = new System.Windows.Forms.Label();
            this.splitLoadData = new System.Windows.Forms.SplitContainer();
            this.loadDataGroup = new System.Windows.Forms.GroupBox();
            this.ifZhouqiN = new System.Windows.Forms.CheckBox();
            this.fz = new System.Windows.Forms.TextBox();
            this.fzlabel = new System.Windows.Forms.Label();
            this.fzUnit = new System.Windows.Forms.Label();
            this.akUnit = new System.Windows.Forms.Label();
            this.lAUnit = new System.Windows.Forms.Label();
            this.TpUnit = new System.Windows.Forms.Label();
            this.TsUnit = new System.Windows.Forms.Label();
            this.MBUnit = new System.Windows.Forms.Label();
            this.aUnit = new System.Windows.Forms.Label();
            this.FkerfUnit = new System.Windows.Forms.Label();
            this.fauUnit = new System.Windows.Forms.Label();
            this.FAOUnit = new System.Windows.Forms.Label();
            this.zhouqiN = new System.Windows.Forms.TextBox();
            this.Fmzul = new System.Windows.Forms.TextBox();
            this.v = new System.Windows.Forms.TextBox();
            this.Tp = new System.Windows.Forms.TextBox();
            this.Ts = new System.Windows.Forms.TextBox();
            this.UKmin = new System.Windows.Forms.TextBox();
            this.UGmin = new System.Windows.Forms.TextBox();
            this.ak = new System.Windows.Forms.TextBox();
            this.lA = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.tightenCoef = new System.Windows.Forms.TextBox();
            this.MB = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.Fkerf = new System.Windows.Forms.TextBox();
            this.fau = new System.Windows.Forms.TextBox();
            this.FAO = new System.Windows.Forms.TextBox();
            this.tighten = new System.Windows.Forms.ComboBox();
            this.isFkerf = new System.Windows.Forms.ComboBox();
            this.zhazhi = new System.Windows.Forms.ComboBox();
            this.isFz = new System.Windows.Forms.ComboBox();
            this.isFORM = new System.Windows.Forms.ComboBox();
            this.zhazhiLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sv = new System.Windows.Forms.ComboBox();
            this.isN = new System.Windows.Forms.ComboBox();
            this.workingLoads = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zhouqiNLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vLabel = new System.Windows.Forms.Label();
            this.TpLabel = new System.Windows.Forms.Label();
            this.TsLabel = new System.Windows.Forms.Label();
            this.UKminLabel = new System.Windows.Forms.Label();
            this.UGminLabel = new System.Windows.Forms.Label();
            this.akLabel = new System.Windows.Forms.Label();
            this.lALabel = new System.Windows.Forms.Label();
            this.svlabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.tightenCoefLabel = new System.Windows.Forms.Label();
            this.tightenLabel = new System.Windows.Forms.Label();
            this.MBLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.FkerfLabel = new System.Windows.Forms.Label();
            this.isFkerfLabel = new System.Windows.Forms.Label();
            this.faulabel = new System.Windows.Forms.Label();
            this.isNLabel = new System.Windows.Forms.Label();
            this.FAOLabel = new System.Windows.Forms.Label();
            this.workingLoadsLabel = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.introGroup2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.introTable2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resultData = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.resGrid = new System.Windows.Forms.PropertyGrid();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.report = new System.Windows.Forms.TabPage();
            this.materialClampedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet9 = new WindowsFormsApp1.BoltConnectionSystemDataSet9();
            this.materialClampedTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet9TableAdapters.materialClampedTableAdapter();
            this.dbo_materialClampedTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet18TableAdapters.dbo_materialClampedTableAdapter();
            this.materialClampedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_materialClampedTableAdapter1 = new WindowsFormsApp1.BoltConnectionSystemDataSet19TableAdapters.dbo_materialClampedTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.DataInputTable.SuspendLayout();
            this.basicData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitUpDown)).BeginInit();
            this.splitUpDown.Panel1.SuspendLayout();
            this.splitUpDown.Panel2.SuspendLayout();
            this.splitUpDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitData)).BeginInit();
            this.splitData.Panel1.SuspendLayout();
            this.splitData.Panel2.SuspendLayout();
            this.splitData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            this.pianxinGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBasic)).BeginInit();
            this.splitBasic.Panel1.SuspendLayout();
            this.splitBasic.Panel2.SuspendLayout();
            this.splitBasic.SuspendLayout();
            this.FtauGroup.SuspendLayout();
            this.basicGroup.SuspendLayout();
            this.phiDimGroup.SuspendLayout();
            this.BoltGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeAndOpt)).BeginInit();
            this.modeAndOpt.Panel1.SuspendLayout();
            this.modeAndOpt.Panel2.SuspendLayout();
            this.modeAndOpt.SuspendLayout();
            this.modelControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.introGroup.SuspendLayout();
            this.tableTab.SuspendLayout();
            this.connAndLoadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitConn)).BeginInit();
            this.splitConn.Panel1.SuspendLayout();
            this.splitConn.Panel2.SuspendLayout();
            this.splitConn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClampedChoosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClamped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbomaterialClampedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitGasketNut)).BeginInit();
            this.splitGasketNut.Panel1.SuspendLayout();
            this.splitGasketNut.Panel2.SuspendLayout();
            this.splitGasketNut.SuspendLayout();
            this.gasketGroup.SuspendLayout();
            this.gasketMaterialGroup.SuspendLayout();
            this.nutGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLoadData)).BeginInit();
            this.splitLoadData.Panel1.SuspendLayout();
            this.splitLoadData.SuspendLayout();
            this.loadDataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.introGroup2.SuspendLayout();
            this.introTable2.SuspendLayout();
            this.resultData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialClampedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialClampedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTempData,
            this.readTempData,
            this.computeBtn,
            this.clearBtn,
            this.stepCalBtn,
            this.genWordBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveTempData
            // 
            this.saveTempData.Name = "saveTempData";
            this.saveTempData.Size = new System.Drawing.Size(44, 21);
            this.saveTempData.Text = "保存";
            this.saveTempData.Click += new System.EventHandler(this.saveTempData_Click);
            // 
            // readTempData
            // 
            this.readTempData.Name = "readTempData";
            this.readTempData.Size = new System.Drawing.Size(44, 21);
            this.readTempData.Text = "读取";
            this.readTempData.Click += new System.EventHandler(this.readTempData_Click);
            // 
            // computeBtn
            // 
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(44, 21);
            this.computeBtn.Text = "计算";
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(44, 21);
            this.clearBtn.Text = "清除";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // stepCalBtn
            // 
            this.stepCalBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalFMmin,
            this.CalFMmax,
            this.CalFMzul,
            this.CalFSmax,
            this.CalSp,
            this.CalMeff,
            this.CalSg,
            this.CalMa});
            this.stepCalBtn.Name = "stepCalBtn";
            this.stepCalBtn.Size = new System.Drawing.Size(68, 21);
            this.stepCalBtn.Text = "单步计算";
            // 
            // CalFMmin
            // 
            this.CalFMmin.Name = "CalFMmin";
            this.CalFMmin.Size = new System.Drawing.Size(266, 22);
            this.CalFMmin.Text = "计算最小装配预加载荷FMmin";
            this.CalFMmin.Click += new System.EventHandler(this.CalFMmin_Click);
            // 
            // CalFMmax
            // 
            this.CalFMmax.Name = "CalFMmax";
            this.CalFMmax.Size = new System.Drawing.Size(266, 22);
            this.CalFMmax.Text = "计算最大装配预加载荷FMmax";
            this.CalFMmax.Click += new System.EventHandler(this.CalFMmax_Click);
            // 
            // CalFMzul
            // 
            this.CalFMzul.Name = "CalFMzul";
            this.CalFMzul.Size = new System.Drawing.Size(266, 22);
            this.CalFMzul.Text = "计算装配应力FMzul及校核螺栓尺寸";
            this.CalFMzul.Click += new System.EventHandler(this.CalFMzul_Click);
            // 
            // CalFSmax
            // 
            this.CalFSmax.Name = "CalFSmax";
            this.CalFSmax.Size = new System.Drawing.Size(266, 22);
            this.CalFSmax.Text = "计算工作应力FSmax及校核";
            this.CalFSmax.Click += new System.EventHandler(this.CalFSmax_Click);
            // 
            // CalSp
            // 
            this.CalSp.Name = "CalSp";
            this.CalSp.Size = new System.Drawing.Size(266, 22);
            this.CalSp.Text = "校核表面压力Sp";
            this.CalSp.Click += new System.EventHandler(this.CalSp_Click);
            // 
            // CalMeff
            // 
            this.CalMeff.Name = "CalMeff";
            this.CalMeff.Size = new System.Drawing.Size(266, 22);
            this.CalMeff.Text = "确定最小旋合长度meff";
            this.CalMeff.Click += new System.EventHandler(this.CalMeff_Click);
            // 
            // CalSg
            // 
            this.CalSg.Name = "CalSg";
            this.CalSg.Size = new System.Drawing.Size(266, 22);
            this.CalSg.Text = "校核剪切应力Sg";
            this.CalSg.Click += new System.EventHandler(this.CalSg_Click);
            // 
            // CalMa
            // 
            this.CalMa.Name = "CalMa";
            this.CalMa.Size = new System.Drawing.Size(266, 22);
            this.CalMa.Text = "计算拧紧扭矩MA";
            this.CalMa.Click += new System.EventHandler(this.CalMa_Click);
            // 
            // genWordBtn
            // 
            this.genWordBtn.Name = "genWordBtn";
            this.genWordBtn.Size = new System.Drawing.Size(68, 21);
            this.genWordBtn.Text = "生成报告";
            this.genWordBtn.Visible = false;
            this.genWordBtn.Click += new System.EventHandler(this.genWordBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1160, 710);
            this.webBrowser1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // DataInputTable
            // 
            this.DataInputTable.AllowDrop = true;
            this.DataInputTable.Controls.Add(this.basicData);
            this.DataInputTable.Controls.Add(this.connAndLoadData);
            this.DataInputTable.Controls.Add(this.resultData);
            this.DataInputTable.Controls.Add(this.report);
            this.DataInputTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataInputTable.Location = new System.Drawing.Point(0, 25);
            this.DataInputTable.Name = "DataInputTable";
            this.DataInputTable.SelectedIndex = 0;
            this.DataInputTable.Size = new System.Drawing.Size(1174, 742);
            this.DataInputTable.TabIndex = 5;
            // 
            // basicData
            // 
            this.basicData.Controls.Add(this.splitUpDown);
            this.basicData.Location = new System.Drawing.Point(4, 22);
            this.basicData.Name = "basicData";
            this.basicData.Padding = new System.Windows.Forms.Padding(3);
            this.basicData.Size = new System.Drawing.Size(1166, 716);
            this.basicData.TabIndex = 0;
            this.basicData.Text = "基本数据";
            this.basicData.UseVisualStyleBackColor = true;
            // 
            // splitUpDown
            // 
            this.splitUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitUpDown.Location = new System.Drawing.Point(3, 3);
            this.splitUpDown.Name = "splitUpDown";
            this.splitUpDown.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitUpDown.Panel1
            // 
            this.splitUpDown.Panel1.AllowDrop = true;
            this.splitUpDown.Panel1.AutoScroll = true;
            this.splitUpDown.Panel1.Controls.Add(this.splitData);
            // 
            // splitUpDown.Panel2
            // 
            this.splitUpDown.Panel2.AutoScroll = true;
            this.splitUpDown.Panel2.Controls.Add(this.splitContainer1);
            this.splitUpDown.Size = new System.Drawing.Size(1160, 710);
            this.splitUpDown.SplitterDistance = 556;
            this.splitUpDown.SplitterWidth = 6;
            this.splitUpDown.TabIndex = 4;
            // 
            // splitData
            // 
            this.splitData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitData.Location = new System.Drawing.Point(0, 0);
            this.splitData.Margin = new System.Windows.Forms.Padding(2);
            this.splitData.Name = "splitData";
            // 
            // splitData.Panel1
            // 
            this.splitData.Panel1.Controls.Add(this.splitLeft);
            // 
            // splitData.Panel2
            // 
            this.splitData.Panel2.AllowDrop = true;
            this.splitData.Panel2.Controls.Add(this.modeAndOpt);
            this.splitData.Panel2.Controls.Add(this.Mode3D);
            this.splitData.Size = new System.Drawing.Size(1160, 556);
            this.splitData.SplitterDistance = 696;
            this.splitData.SplitterWidth = 3;
            this.splitData.TabIndex = 7;
            // 
            // splitLeft
            // 
            this.splitLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.AutoScroll = true;
            this.splitLeft.Panel1.Controls.Add(this.pianxinGroup);
            this.splitLeft.Panel1.Controls.Add(this.splitBasic);
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.AutoScroll = true;
            this.splitLeft.Panel2.Controls.Add(this.BoltGroup);
            this.splitLeft.Size = new System.Drawing.Size(696, 556);
            this.splitLeft.SplitterDistance = 382;
            this.splitLeft.TabIndex = 0;
            // 
            // pianxinGroup
            // 
            this.pianxinGroup.AutoSize = true;
            this.pianxinGroup.Controls.Add(this.isIbtLabel);
            this.pianxinGroup.Controls.Add(this.ifaLabel);
            this.pianxinGroup.Controls.Add(this.jiaZaiQingKuangLabel);
            this.pianxinGroup.Controls.Add(this.SsymLabel);
            this.pianxinGroup.Controls.Add(this.cB);
            this.pianxinGroup.Controls.Add(this.b);
            this.pianxinGroup.Controls.Add(this.e);
            this.pianxinGroup.Controls.Add(this.Ibt);
            this.pianxinGroup.Controls.Add(this.bT);
            this.pianxinGroup.Controls.Add(this.cT);
            this.pianxinGroup.Controls.Add(this.u);
            this.pianxinGroup.Controls.Add(this.cBUnit);
            this.pianxinGroup.Controls.Add(this.bUnit);
            this.pianxinGroup.Controls.Add(this.eUnit);
            this.pianxinGroup.Controls.Add(this.IbtUnit);
            this.pianxinGroup.Controls.Add(this.bTUnit);
            this.pianxinGroup.Controls.Add(this.cTUnit);
            this.pianxinGroup.Controls.Add(this.ifa);
            this.pianxinGroup.Controls.Add(this.isIbt);
            this.pianxinGroup.Controls.Add(this.jiaZaiQingKuang);
            this.pianxinGroup.Controls.Add(this.label11);
            this.pianxinGroup.Controls.Add(this.label8);
            this.pianxinGroup.Controls.Add(this.bLabel);
            this.pianxinGroup.Controls.Add(this.label9);
            this.pianxinGroup.Controls.Add(this.IbtLabel);
            this.pianxinGroup.Controls.Add(this.bTLabel);
            this.pianxinGroup.Controls.Add(this.cTLabel);
            this.pianxinGroup.Controls.Add(this.label10);
            this.pianxinGroup.Controls.Add(this.SsymUnit);
            this.pianxinGroup.Controls.Add(this.Ssym);
            this.pianxinGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pianxinGroup.Location = new System.Drawing.Point(0, 526);
            this.pianxinGroup.Name = "pianxinGroup";
            this.pianxinGroup.Size = new System.Drawing.Size(363, 396);
            this.pianxinGroup.TabIndex = 71;
            this.pianxinGroup.TabStop = false;
            this.pianxinGroup.Text = "偏心参数";
            this.pianxinGroup.Visible = false;
            // 
            // isIbtLabel
            // 
            this.isIbtLabel.AutoSize = true;
            this.isIbtLabel.Location = new System.Drawing.Point(14, 245);
            this.isIbtLabel.Name = "isIbtLabel";
            this.isIbtLabel.Size = new System.Drawing.Size(173, 12);
            this.isIbtLabel.TabIndex = 64;
            this.isIbtLabel.Text = "被连接件接合面转动惯量输入：";
            // 
            // ifaLabel
            // 
            this.ifaLabel.AutoSize = true;
            this.ifaLabel.Location = new System.Drawing.Point(14, 335);
            this.ifaLabel.Name = "ifaLabel";
            this.ifaLabel.Size = new System.Drawing.Size(101, 12);
            this.ifaLabel.TabIndex = 64;
            this.ifaLabel.Text = "采用偏心轴向载荷";
            // 
            // jiaZaiQingKuangLabel
            // 
            this.jiaZaiQingKuangLabel.AutoSize = true;
            this.jiaZaiQingKuangLabel.Location = new System.Drawing.Point(14, 361);
            this.jiaZaiQingKuangLabel.Name = "jiaZaiQingKuangLabel";
            this.jiaZaiQingKuangLabel.Size = new System.Drawing.Size(65, 12);
            this.jiaZaiQingKuangLabel.TabIndex = 64;
            this.jiaZaiQingKuangLabel.Text = "加载情况：";
            // 
            // SsymLabel
            // 
            this.SsymLabel.AutoSize = true;
            this.SsymLabel.Location = new System.Drawing.Point(11, 36);
            this.SsymLabel.Name = "SsymLabel";
            this.SsymLabel.Size = new System.Drawing.Size(167, 12);
            this.SsymLabel.TabIndex = 64;
            this.SsymLabel.Text = "从0-0轴至螺栓轴的距离Ssym：";
            // 
            // cB
            // 
            this.cB.Location = new System.Drawing.Point(178, 96);
            this.cB.Name = "cB";
            this.cB.Size = new System.Drawing.Size(110, 21);
            this.cB.TabIndex = 65;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(178, 167);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(110, 21);
            this.b.TabIndex = 65;
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(178, 303);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(110, 21);
            this.e.TabIndex = 65;
            // 
            // Ibt
            // 
            this.Ibt.Location = new System.Drawing.Point(178, 269);
            this.Ibt.Name = "Ibt";
            this.Ibt.Size = new System.Drawing.Size(110, 21);
            this.Ibt.TabIndex = 65;
            // 
            // bT
            // 
            this.bT.Location = new System.Drawing.Point(178, 204);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(110, 21);
            this.bT.TabIndex = 65;
            // 
            // cT
            // 
            this.cT.Location = new System.Drawing.Point(178, 133);
            this.cT.Name = "cT";
            this.cT.Size = new System.Drawing.Size(110, 21);
            this.cT.TabIndex = 65;
            // 
            // u
            // 
            this.u.Location = new System.Drawing.Point(178, 63);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(110, 21);
            this.u.TabIndex = 65;
            // 
            // cBUnit
            // 
            this.cBUnit.AutoSize = true;
            this.cBUnit.Location = new System.Drawing.Point(293, 99);
            this.cBUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cBUnit.Name = "cBUnit";
            this.cBUnit.Size = new System.Drawing.Size(17, 12);
            this.cBUnit.TabIndex = 60;
            this.cBUnit.Text = "mm";
            // 
            // bUnit
            // 
            this.bUnit.AutoSize = true;
            this.bUnit.Location = new System.Drawing.Point(293, 174);
            this.bUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bUnit.Name = "bUnit";
            this.bUnit.Size = new System.Drawing.Size(17, 12);
            this.bUnit.TabIndex = 60;
            this.bUnit.Text = "mm";
            // 
            // eUnit
            // 
            this.eUnit.AutoSize = true;
            this.eUnit.Location = new System.Drawing.Point(293, 310);
            this.eUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eUnit.Name = "eUnit";
            this.eUnit.Size = new System.Drawing.Size(17, 12);
            this.eUnit.TabIndex = 60;
            this.eUnit.Text = "mm";
            // 
            // IbtUnit
            // 
            this.IbtUnit.AutoSize = true;
            this.IbtUnit.Location = new System.Drawing.Point(293, 276);
            this.IbtUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IbtUnit.Name = "IbtUnit";
            this.IbtUnit.Size = new System.Drawing.Size(23, 12);
            this.IbtUnit.TabIndex = 60;
            this.IbtUnit.Text = "mm4";
            // 
            // bTUnit
            // 
            this.bTUnit.AutoSize = true;
            this.bTUnit.Location = new System.Drawing.Point(293, 211);
            this.bTUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bTUnit.Name = "bTUnit";
            this.bTUnit.Size = new System.Drawing.Size(17, 12);
            this.bTUnit.TabIndex = 60;
            this.bTUnit.Text = "mm";
            // 
            // cTUnit
            // 
            this.cTUnit.AutoSize = true;
            this.cTUnit.Location = new System.Drawing.Point(293, 140);
            this.cTUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cTUnit.Name = "cTUnit";
            this.cTUnit.Size = new System.Drawing.Size(17, 12);
            this.cTUnit.TabIndex = 60;
            this.cTUnit.Text = "mm";
            // 
            // ifa
            // 
            this.ifa.DisplayMember = "boltType";
            this.ifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ifa.FormattingEnabled = true;
            this.ifa.Items.AddRange(new object[] {
            "是",
            "否"});
            this.ifa.Location = new System.Drawing.Point(178, 331);
            this.ifa.Margin = new System.Windows.Forms.Padding(2);
            this.ifa.Name = "ifa";
            this.ifa.Size = new System.Drawing.Size(110, 20);
            this.ifa.TabIndex = 59;
            this.ifa.ValueMember = "boltType";
            this.ifa.SelectedIndexChanged += new System.EventHandler(this.ifa_SelectedIndexChanged);
            // 
            // isIbt
            // 
            this.isIbt.DisplayMember = "boltType";
            this.isIbt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isIbt.FormattingEnabled = true;
            this.isIbt.Items.AddRange(new object[] {
            "是",
            "否"});
            this.isIbt.Location = new System.Drawing.Point(189, 241);
            this.isIbt.Margin = new System.Windows.Forms.Padding(2);
            this.isIbt.Name = "isIbt";
            this.isIbt.Size = new System.Drawing.Size(97, 20);
            this.isIbt.TabIndex = 59;
            this.isIbt.ValueMember = "boltType";
            this.isIbt.SelectedIndexChanged += new System.EventHandler(this.isIbt_SelectedIndexChanged);
            // 
            // jiaZaiQingKuang
            // 
            this.jiaZaiQingKuang.DisplayMember = "boltType";
            this.jiaZaiQingKuang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jiaZaiQingKuang.FormattingEnabled = true;
            this.jiaZaiQingKuang.Items.AddRange(new object[] {
            "加载类型一",
            "加载类型二",
            "加载类型三"});
            this.jiaZaiQingKuang.Location = new System.Drawing.Point(178, 357);
            this.jiaZaiQingKuang.Margin = new System.Windows.Forms.Padding(2);
            this.jiaZaiQingKuang.Name = "jiaZaiQingKuang";
            this.jiaZaiQingKuang.Size = new System.Drawing.Size(110, 20);
            this.jiaZaiQingKuang.TabIndex = 59;
            this.jiaZaiQingKuang.ValueMember = "boltType";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(293, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 60;
            this.label11.Text = "mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 63;
            this.label8.Text = "受弯体长度cB：";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(14, 170);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(83, 12);
            this.bLabel.TabIndex = 63;
            this.bLabel.Text = "受弯体宽度b：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "从接合面带有张开风险的\r\n边缘至螺栓轴的距离e：";
            // 
            // IbtLabel
            // 
            this.IbtLabel.AutoSize = true;
            this.IbtLabel.Location = new System.Drawing.Point(14, 273);
            this.IbtLabel.Name = "IbtLabel";
            this.IbtLabel.Size = new System.Drawing.Size(83, 12);
            this.IbtLabel.TabIndex = 63;
            this.IbtLabel.Text = "转动惯量Ibt：";
            // 
            // bTLabel
            // 
            this.bTLabel.AutoSize = true;
            this.bTLabel.Location = new System.Drawing.Point(14, 206);
            this.bTLabel.Name = "bTLabel";
            this.bTLabel.Size = new System.Drawing.Size(137, 12);
            this.bTLabel.TabIndex = 63;
            this.bTLabel.Text = "被连接件接合面宽度bT：";
            // 
            // cTLabel
            // 
            this.cTLabel.AutoSize = true;
            this.cTLabel.Location = new System.Drawing.Point(14, 135);
            this.cTLabel.Name = "cTLabel";
            this.cTLabel.Size = new System.Drawing.Size(137, 12);
            this.cTLabel.TabIndex = 63;
            this.cTLabel.Text = "被连接件接合面长度cT：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 12);
            this.label10.TabIndex = 63;
            this.label10.Text = "从0-0轴至开口处的距离u：";
            // 
            // SsymUnit
            // 
            this.SsymUnit.AutoSize = true;
            this.SsymUnit.Location = new System.Drawing.Point(293, 34);
            this.SsymUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SsymUnit.Name = "SsymUnit";
            this.SsymUnit.Size = new System.Drawing.Size(17, 12);
            this.SsymUnit.TabIndex = 61;
            this.SsymUnit.Text = "mm";
            // 
            // Ssym
            // 
            this.Ssym.Location = new System.Drawing.Point(178, 30);
            this.Ssym.Name = "Ssym";
            this.Ssym.Size = new System.Drawing.Size(110, 21);
            this.Ssym.TabIndex = 66;
            // 
            // splitBasic
            // 
            this.splitBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitBasic.Location = new System.Drawing.Point(0, 0);
            this.splitBasic.Name = "splitBasic";
            this.splitBasic.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitBasic.Panel1
            // 
            this.splitBasic.Panel1.AutoScroll = true;
            this.splitBasic.Panel1.Controls.Add(this.FtauGroup);
            this.splitBasic.Panel1.Controls.Add(this.basicGroup);
            // 
            // splitBasic.Panel2
            // 
            this.splitBasic.Panel2.AutoScroll = true;
            this.splitBasic.Panel2.Controls.Add(this.phiDimGroup);
            this.splitBasic.Size = new System.Drawing.Size(363, 526);
            this.splitBasic.SplitterDistance = 236;
            this.splitBasic.TabIndex = 0;
            this.splitBasic.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitBasic_SplitterMoved);
            // 
            // FtauGroup
            // 
            this.FtauGroup.AutoSize = true;
            this.FtauGroup.Controls.Add(this.qF);
            this.FtauGroup.Controls.Add(this.isSGsoll);
            this.FtauGroup.Controls.Add(this.isSGsollLabel);
            this.FtauGroup.Controls.Add(this.UTmin);
            this.FtauGroup.Controls.Add(this.SGsoll);
            this.FtauGroup.Controls.Add(this.label2);
            this.FtauGroup.Controls.Add(this.qFLabel);
            this.FtauGroup.Controls.Add(this.UTminLabel);
            this.FtauGroup.Controls.Add(this.FQ);
            this.FtauGroup.Controls.Add(this.FQLabel);
            this.FtauGroup.Controls.Add(this.FQUnit);
            this.FtauGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.FtauGroup.Location = new System.Drawing.Point(0, 162);
            this.FtauGroup.Name = "FtauGroup";
            this.FtauGroup.Size = new System.Drawing.Size(346, 179);
            this.FtauGroup.TabIndex = 74;
            this.FtauGroup.TabStop = false;
            this.FtauGroup.Text = "附加剪力系数";
            this.FtauGroup.Visible = false;
            // 
            // qF
            // 
            this.qF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qF.FormattingEnabled = true;
            this.qF.Items.AddRange(new object[] {
            "1",
            "2"});
            this.qF.Location = new System.Drawing.Point(189, 140);
            this.qF.Margin = new System.Windows.Forms.Padding(2);
            this.qF.Name = "qF";
            this.qF.Size = new System.Drawing.Size(76, 20);
            this.qF.TabIndex = 70;
            this.qF.SelectedIndexChanged += new System.EventHandler(this.isSGsoll_SelectedIndexChanged);
            // 
            // isSGsoll
            // 
            this.isSGsoll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isSGsoll.FormattingEnabled = true;
            this.isSGsoll.Items.AddRange(new object[] {
            "是",
            "否"});
            this.isSGsoll.Location = new System.Drawing.Point(191, 79);
            this.isSGsoll.Margin = new System.Windows.Forms.Padding(2);
            this.isSGsoll.Name = "isSGsoll";
            this.isSGsoll.Size = new System.Drawing.Size(76, 20);
            this.isSGsoll.TabIndex = 70;
            this.isSGsoll.SelectedIndexChanged += new System.EventHandler(this.isSGsoll_SelectedIndexChanged);
            // 
            // isSGsollLabel
            // 
            this.isSGsollLabel.AutoSize = true;
            this.isSGsollLabel.Location = new System.Drawing.Point(4, 82);
            this.isSGsollLabel.Name = "isSGsollLabel";
            this.isSGsollLabel.Size = new System.Drawing.Size(161, 12);
            this.isSGsollLabel.TabIndex = 69;
            this.isSGsollLabel.Text = "预定所需的抗滑移安全系数：";
            // 
            // UTmin
            // 
            this.UTmin.Location = new System.Drawing.Point(189, 46);
            this.UTmin.Name = "UTmin";
            this.UTmin.Size = new System.Drawing.Size(76, 21);
            this.UTmin.TabIndex = 66;
            // 
            // SGsoll
            // 
            this.SGsoll.Location = new System.Drawing.Point(191, 107);
            this.SGsoll.Name = "SGsoll";
            this.SGsoll.ReadOnly = true;
            this.SGsoll.Size = new System.Drawing.Size(76, 21);
            this.SGsoll.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 64;
            this.label2.Text = "抗滑移安全系数SGsoll：";
            // 
            // qFLabel
            // 
            this.qFLabel.AutoSize = true;
            this.qFLabel.Location = new System.Drawing.Point(5, 143);
            this.qFLabel.Name = "qFLabel";
            this.qFLabel.Size = new System.Drawing.Size(185, 12);
            this.qFLabel.TabIndex = 63;
            this.qFLabel.Text = "载荷传递通过内部接合面数量qF：";
            // 
            // UTminLabel
            // 
            this.UTminLabel.AutoSize = true;
            this.UTminLabel.Location = new System.Drawing.Point(2, 43);
            this.UTminLabel.Name = "UTminLabel";
            this.UTminLabel.Size = new System.Drawing.Size(119, 24);
            this.UTminLabel.TabIndex = 63;
            this.UTminLabel.Text = "被连接件接合面间\r\n最小摩擦系数UTmin：";
            // 
            // FQ
            // 
            this.FQ.Location = new System.Drawing.Point(189, 15);
            this.FQ.Name = "FQ";
            this.FQ.Size = new System.Drawing.Size(76, 21);
            this.FQ.TabIndex = 68;
            this.FQ.Text = "0";
            this.FQ.TextChanged += new System.EventHandler(this.FQ_TextChanged);
            // 
            // FQLabel
            // 
            this.FQLabel.AutoSize = true;
            this.FQLabel.Location = new System.Drawing.Point(2, 19);
            this.FQLabel.Name = "FQLabel";
            this.FQLabel.Size = new System.Drawing.Size(77, 12);
            this.FQLabel.TabIndex = 65;
            this.FQLabel.Text = "横向载荷FQ：";
            // 
            // FQUnit
            // 
            this.FQUnit.AutoSize = true;
            this.FQUnit.Location = new System.Drawing.Point(270, 18);
            this.FQUnit.Name = "FQUnit";
            this.FQUnit.Size = new System.Drawing.Size(11, 12);
            this.FQUnit.TabIndex = 62;
            this.FQUnit.Text = "N";
            // 
            // basicGroup
            // 
            this.basicGroup.AutoSize = true;
            this.basicGroup.Controls.Add(this.ClampingWayLabel);
            this.basicGroup.Controls.Add(this.BoltConnectTypeLabel);
            this.basicGroup.Controls.Add(this.clampingWay);
            this.basicGroup.Controls.Add(this.BoltConnectType);
            this.basicGroup.Controls.Add(this.boltConnectLoad);
            this.basicGroup.Controls.Add(this.boltConnectLoadLabel);
            this.basicGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicGroup.Location = new System.Drawing.Point(0, 0);
            this.basicGroup.Name = "basicGroup";
            this.basicGroup.Size = new System.Drawing.Size(346, 162);
            this.basicGroup.TabIndex = 70;
            this.basicGroup.TabStop = false;
            this.basicGroup.Text = "基础";
            // 
            // ClampingWayLabel
            // 
            this.ClampingWayLabel.AutoSize = true;
            this.ClampingWayLabel.Location = new System.Drawing.Point(14, 40);
            this.ClampingWayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClampingWayLabel.Name = "ClampingWayLabel";
            this.ClampingWayLabel.Size = new System.Drawing.Size(65, 12);
            this.ClampingWayLabel.TabIndex = 54;
            this.ClampingWayLabel.Text = "夹紧方式：";
            // 
            // BoltConnectTypeLabel
            // 
            this.BoltConnectTypeLabel.AutoSize = true;
            this.BoltConnectTypeLabel.Location = new System.Drawing.Point(14, 83);
            this.BoltConnectTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoltConnectTypeLabel.Name = "BoltConnectTypeLabel";
            this.BoltConnectTypeLabel.Size = new System.Drawing.Size(89, 12);
            this.BoltConnectTypeLabel.TabIndex = 55;
            this.BoltConnectTypeLabel.Text = "螺栓连接类型：";
            // 
            // clampingWay
            // 
            this.clampingWay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clampingWay.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.clampingWay.Items.AddRange(new object[] {
            "同心",
            "偏心"});
            this.clampingWay.Location = new System.Drawing.Point(176, 38);
            this.clampingWay.Margin = new System.Windows.Forms.Padding(2);
            this.clampingWay.Name = "clampingWay";
            this.clampingWay.Size = new System.Drawing.Size(110, 20);
            this.clampingWay.TabIndex = 56;
            this.clampingWay.SelectedIndexChanged += new System.EventHandler(this.clampingWay_SelectedIndexChanged);
            // 
            // BoltConnectType
            // 
            this.BoltConnectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoltConnectType.FormattingEnabled = true;
            this.BoltConnectType.Items.AddRange(new object[] {
            "通孔螺栓连接",
            "盲孔螺栓连接"});
            this.BoltConnectType.Location = new System.Drawing.Point(176, 79);
            this.BoltConnectType.Margin = new System.Windows.Forms.Padding(2);
            this.BoltConnectType.Name = "BoltConnectType";
            this.BoltConnectType.Size = new System.Drawing.Size(110, 20);
            this.BoltConnectType.TabIndex = 57;
            this.BoltConnectType.SelectedIndexChanged += new System.EventHandler(this.BoltConnectType_SelectedIndexChanged);
            // 
            // boltConnectLoad
            // 
            this.boltConnectLoad.DisplayMember = "boltType";
            this.boltConnectLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boltConnectLoad.FormattingEnabled = true;
            this.boltConnectLoad.Items.AddRange(new object[] {
            "单螺栓连接",
            "受横向载荷的单螺栓连接",
            "多螺栓连接"});
            this.boltConnectLoad.Location = new System.Drawing.Point(176, 123);
            this.boltConnectLoad.Margin = new System.Windows.Forms.Padding(2);
            this.boltConnectLoad.Name = "boltConnectLoad";
            this.boltConnectLoad.Size = new System.Drawing.Size(110, 20);
            this.boltConnectLoad.TabIndex = 59;
            this.boltConnectLoad.ValueMember = "boltType";
            this.boltConnectLoad.SelectedIndexChanged += new System.EventHandler(this.boltConnect_SelectedIndexChanged);
            this.boltConnectLoad.Click += new System.EventHandler(this.boltConnect_Click);
            // 
            // boltConnectLoadLabel
            // 
            this.boltConnectLoadLabel.AutoSize = true;
            this.boltConnectLoadLabel.Location = new System.Drawing.Point(14, 125);
            this.boltConnectLoadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boltConnectLoadLabel.Name = "boltConnectLoadLabel";
            this.boltConnectLoadLabel.Size = new System.Drawing.Size(113, 12);
            this.boltConnectLoadLabel.TabIndex = 58;
            this.boltConnectLoadLabel.Text = "螺栓连接加载类型：";
            // 
            // phiDimGroup
            // 
            this.phiDimGroup.AutoSize = true;
            this.phiDimGroup.Controls.Add(this.qM);
            this.phiDimGroup.Controls.Add(this.label13);
            this.phiDimGroup.Controls.Add(this.Mt);
            this.phiDimGroup.Controls.Add(this.MtLabel);
            this.phiDimGroup.Controls.Add(this.MtUnit);
            this.phiDimGroup.Controls.Add(this.JointFaceEquOutDiameterLabel);
            this.phiDimGroup.Controls.Add(this.Dhamax);
            this.phiDimGroup.Controls.Add(this.ra);
            this.phiDimGroup.Controls.Add(this.pimax);
            this.phiDimGroup.Controls.Add(this.dtau);
            this.phiDimGroup.Controls.Add(this.DA2);
            this.phiDimGroup.Controls.Add(this.ifRaLabel);
            this.phiDimGroup.Controls.Add(this.DhamaxUnit);
            this.phiDimGroup.Controls.Add(this.raUnit);
            this.phiDimGroup.Controls.Add(this.ifMtLabel);
            this.phiDimGroup.Controls.Add(this.ADLabel);
            this.phiDimGroup.Controls.Add(this.label12);
            this.phiDimGroup.Controls.Add(this.ifPreDtLabel);
            this.phiDimGroup.Controls.Add(this.pimaxUnit);
            this.phiDimGroup.Controls.Add(this.dtauUnit);
            this.phiDimGroup.Controls.Add(this.ifRa);
            this.phiDimGroup.Controls.Add(this.ADUnit);
            this.phiDimGroup.Controls.Add(this.DA2Label);
            this.phiDimGroup.Controls.Add(this.label1);
            this.phiDimGroup.Controls.Add(this.isMt);
            this.phiDimGroup.Controls.Add(this.raLabel);
            this.phiDimGroup.Controls.Add(this.ifPimax);
            this.phiDimGroup.Controls.Add(this.ifDt);
            this.phiDimGroup.Controls.Add(this.pimaxLabel);
            this.phiDimGroup.Controls.Add(this.dtauLabel);
            this.phiDimGroup.Controls.Add(this.JointFaceUpEquOutDiameterLabel);
            this.phiDimGroup.Controls.Add(this.UpperLimitAxialLoadDisplay);
            this.phiDimGroup.Controls.Add(this.DA);
            this.phiDimGroup.Controls.Add(this.AD);
            this.phiDimGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.phiDimGroup.Location = new System.Drawing.Point(0, 0);
            this.phiDimGroup.Name = "phiDimGroup";
            this.phiDimGroup.Size = new System.Drawing.Size(346, 481);
            this.phiDimGroup.TabIndex = 70;
            this.phiDimGroup.TabStop = false;
            this.phiDimGroup.Text = "几何尺寸";
            // 
            // qM
            // 
            this.qM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qM.Enabled = false;
            this.qM.FormattingEnabled = true;
            this.qM.Items.AddRange(new object[] {
            "1",
            "2"});
            this.qM.Location = new System.Drawing.Point(203, 442);
            this.qM.Margin = new System.Windows.Forms.Padding(2);
            this.qM.Name = "qM";
            this.qM.Size = new System.Drawing.Size(76, 20);
            this.qM.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 12);
            this.label13.TabIndex = 71;
            this.label13.Text = "转矩传递通过内部接合面数量qM：";
            // 
            // Mt
            // 
            this.Mt.Location = new System.Drawing.Point(171, 301);
            this.Mt.Name = "Mt";
            this.Mt.ReadOnly = true;
            this.Mt.Size = new System.Drawing.Size(110, 21);
            this.Mt.TabIndex = 70;
            // 
            // MtLabel
            // 
            this.MtLabel.AutoSize = true;
            this.MtLabel.Location = new System.Drawing.Point(11, 306);
            this.MtLabel.Name = "MtLabel";
            this.MtLabel.Size = new System.Drawing.Size(113, 12);
            this.MtLabel.TabIndex = 69;
            this.MtLabel.Text = "绕螺栓轴的扭矩Mt：";
            // 
            // MtUnit
            // 
            this.MtUnit.AutoSize = true;
            this.MtUnit.Location = new System.Drawing.Point(283, 304);
            this.MtUnit.Name = "MtUnit";
            this.MtUnit.Size = new System.Drawing.Size(23, 12);
            this.MtUnit.TabIndex = 68;
            this.MtUnit.Text = "N*m";
            // 
            // JointFaceEquOutDiameterLabel
            // 
            this.JointFaceEquOutDiameterLabel.AutoSize = true;
            this.JointFaceEquOutDiameterLabel.Location = new System.Drawing.Point(11, 42);
            this.JointFaceEquOutDiameterLabel.Name = "JointFaceEquOutDiameterLabel";
            this.JointFaceEquOutDiameterLabel.Size = new System.Drawing.Size(101, 12);
            this.JointFaceEquOutDiameterLabel.TabIndex = 64;
            this.JointFaceEquOutDiameterLabel.Text = "接合面等效外径：";
            // 
            // Dhamax
            // 
            this.Dhamax.Location = new System.Drawing.Point(171, 410);
            this.Dhamax.Name = "Dhamax";
            this.Dhamax.ReadOnly = true;
            this.Dhamax.Size = new System.Drawing.Size(110, 21);
            this.Dhamax.TabIndex = 65;
            // 
            // ra
            // 
            this.ra.Location = new System.Drawing.Point(171, 370);
            this.ra.Name = "ra";
            this.ra.ReadOnly = true;
            this.ra.Size = new System.Drawing.Size(110, 21);
            this.ra.TabIndex = 65;
            // 
            // pimax
            // 
            this.pimax.Location = new System.Drawing.Point(174, 140);
            this.pimax.Name = "pimax";
            this.pimax.ReadOnly = true;
            this.pimax.Size = new System.Drawing.Size(110, 21);
            this.pimax.TabIndex = 65;
            // 
            // dtau
            // 
            this.dtau.Location = new System.Drawing.Point(171, 236);
            this.dtau.Name = "dtau";
            this.dtau.ReadOnly = true;
            this.dtau.Size = new System.Drawing.Size(110, 21);
            this.dtau.TabIndex = 65;
            // 
            // DA2
            // 
            this.DA2.Location = new System.Drawing.Point(171, 80);
            this.DA2.Name = "DA2";
            this.DA2.Size = new System.Drawing.Size(110, 21);
            this.DA2.TabIndex = 65;
            this.DA2.Text = "80";
            this.DA2.Click += new System.EventHandler(this.DA2_Click);
            // 
            // ifRaLabel
            // 
            this.ifRaLabel.AutoSize = true;
            this.ifRaLabel.Location = new System.Drawing.Point(11, 337);
            this.ifRaLabel.Name = "ifRaLabel";
            this.ifRaLabel.Size = new System.Drawing.Size(77, 12);
            this.ifRaLabel.TabIndex = 63;
            this.ifRaLabel.Text = "预定摩擦半径";
            // 
            // DhamaxUnit
            // 
            this.DhamaxUnit.AutoSize = true;
            this.DhamaxUnit.Location = new System.Drawing.Point(286, 417);
            this.DhamaxUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DhamaxUnit.Name = "DhamaxUnit";
            this.DhamaxUnit.Size = new System.Drawing.Size(17, 12);
            this.DhamaxUnit.TabIndex = 60;
            this.DhamaxUnit.Text = "mm";
            // 
            // raUnit
            // 
            this.raUnit.AutoSize = true;
            this.raUnit.Location = new System.Drawing.Point(286, 377);
            this.raUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raUnit.Name = "raUnit";
            this.raUnit.Size = new System.Drawing.Size(17, 12);
            this.raUnit.TabIndex = 60;
            this.raUnit.Text = "mm";
            // 
            // ifMtLabel
            // 
            this.ifMtLabel.AutoSize = true;
            this.ifMtLabel.Location = new System.Drawing.Point(11, 273);
            this.ifMtLabel.Name = "ifMtLabel";
            this.ifMtLabel.Size = new System.Drawing.Size(53, 12);
            this.ifMtLabel.TabIndex = 63;
            this.ifMtLabel.Text = "预定扭矩";
            // 
            // ADLabel
            // 
            this.ADLabel.AutoSize = true;
            this.ADLabel.Location = new System.Drawing.Point(14, 172);
            this.ADLabel.Name = "ADLabel";
            this.ADLabel.Size = new System.Drawing.Size(77, 12);
            this.ADLabel.TabIndex = 63;
            this.ADLabel.Text = "密封面积AD：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 12);
            this.label12.TabIndex = 63;
            this.label12.Text = "考虑密封需要的内压：";
            // 
            // ifPreDtLabel
            // 
            this.ifPreDtLabel.AutoSize = true;
            this.ifPreDtLabel.Location = new System.Drawing.Point(11, 205);
            this.ifPreDtLabel.Name = "ifPreDtLabel";
            this.ifPreDtLabel.Size = new System.Drawing.Size(89, 12);
            this.ifPreDtLabel.TabIndex = 63;
            this.ifPreDtLabel.Text = "预定剪切面直径";
            // 
            // pimaxUnit
            // 
            this.pimaxUnit.AutoSize = true;
            this.pimaxUnit.Location = new System.Drawing.Point(289, 147);
            this.pimaxUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pimaxUnit.Name = "pimaxUnit";
            this.pimaxUnit.Size = new System.Drawing.Size(29, 12);
            this.pimaxUnit.TabIndex = 60;
            this.pimaxUnit.Text = "N/m2";
            // 
            // dtauUnit
            // 
            this.dtauUnit.AutoSize = true;
            this.dtauUnit.Location = new System.Drawing.Point(286, 243);
            this.dtauUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtauUnit.Name = "dtauUnit";
            this.dtauUnit.Size = new System.Drawing.Size(17, 12);
            this.dtauUnit.TabIndex = 60;
            this.dtauUnit.Text = "mm";
            // 
            // ifRa
            // 
            this.ifRa.DisplayMember = "boltType";
            this.ifRa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ifRa.Enabled = false;
            this.ifRa.FormattingEnabled = true;
            this.ifRa.Items.AddRange(new object[] {
            "是",
            "否"});
            this.ifRa.Location = new System.Drawing.Point(171, 334);
            this.ifRa.Margin = new System.Windows.Forms.Padding(2);
            this.ifRa.Name = "ifRa";
            this.ifRa.Size = new System.Drawing.Size(110, 20);
            this.ifRa.TabIndex = 59;
            this.ifRa.ValueMember = "boltType";
            this.ifRa.SelectedIndexChanged += new System.EventHandler(this.ifRa_SelectedIndexChanged);
            // 
            // ADUnit
            // 
            this.ADUnit.AutoSize = true;
            this.ADUnit.Location = new System.Drawing.Point(286, 174);
            this.ADUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ADUnit.Name = "ADUnit";
            this.ADUnit.Size = new System.Drawing.Size(23, 12);
            this.ADUnit.TabIndex = 60;
            this.ADUnit.Text = "mm2";
            // 
            // DA2Label
            // 
            this.DA2Label.AutoSize = true;
            this.DA2Label.Location = new System.Drawing.Point(286, 87);
            this.DA2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DA2Label.Name = "DA2Label";
            this.DA2Label.Size = new System.Drawing.Size(17, 12);
            this.DA2Label.TabIndex = 60;
            this.DA2Label.Text = "mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 63;
            this.label1.Text = "承载面最大内径Dhamx";
            // 
            // isMt
            // 
            this.isMt.DisplayMember = "boltType";
            this.isMt.Enabled = false;
            this.isMt.FormattingEnabled = true;
            this.isMt.Items.AddRange(new object[] {
            "是",
            "否"});
            this.isMt.Location = new System.Drawing.Point(171, 270);
            this.isMt.Margin = new System.Windows.Forms.Padding(2);
            this.isMt.Name = "isMt";
            this.isMt.Size = new System.Drawing.Size(110, 20);
            this.isMt.TabIndex = 59;
            this.isMt.ValueMember = "boltType";
            this.isMt.SelectedIndexChanged += new System.EventHandler(this.isMt_SelectedIndexChanged);
            // 
            // raLabel
            // 
            this.raLabel.AutoSize = true;
            this.raLabel.Location = new System.Drawing.Point(11, 372);
            this.raLabel.Name = "raLabel";
            this.raLabel.Size = new System.Drawing.Size(77, 12);
            this.raLabel.TabIndex = 63;
            this.raLabel.Text = "摩擦半径ra：";
            // 
            // ifPimax
            // 
            this.ifPimax.DisplayMember = "boltType";
            this.ifPimax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ifPimax.Enabled = false;
            this.ifPimax.FormattingEnabled = true;
            this.ifPimax.Items.AddRange(new object[] {
            "是",
            "否"});
            this.ifPimax.Location = new System.Drawing.Point(171, 110);
            this.ifPimax.Margin = new System.Windows.Forms.Padding(2);
            this.ifPimax.Name = "ifPimax";
            this.ifPimax.Size = new System.Drawing.Size(110, 20);
            this.ifPimax.TabIndex = 59;
            this.ifPimax.ValueMember = "boltType";
            this.ifPimax.SelectedIndexChanged += new System.EventHandler(this.ifPimax_SelectedIndexChanged);
            // 
            // ifDt
            // 
            this.ifDt.DisplayMember = "boltType";
            this.ifDt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ifDt.Enabled = false;
            this.ifDt.FormattingEnabled = true;
            this.ifDt.Items.AddRange(new object[] {
            "是",
            "否"});
            this.ifDt.Location = new System.Drawing.Point(171, 203);
            this.ifDt.Margin = new System.Windows.Forms.Padding(2);
            this.ifDt.Name = "ifDt";
            this.ifDt.Size = new System.Drawing.Size(110, 20);
            this.ifDt.TabIndex = 59;
            this.ifDt.ValueMember = "boltType";
            this.ifDt.SelectedIndexChanged += new System.EventHandler(this.ifDt_SelectedIndexChanged);
            // 
            // pimaxLabel
            // 
            this.pimaxLabel.AutoSize = true;
            this.pimaxLabel.Location = new System.Drawing.Point(14, 142);
            this.pimaxLabel.Name = "pimaxLabel";
            this.pimaxLabel.Size = new System.Drawing.Size(47, 12);
            this.pimaxLabel.TabIndex = 63;
            this.pimaxLabel.Text = "pimax：";
            // 
            // dtauLabel
            // 
            this.dtauLabel.AutoSize = true;
            this.dtauLabel.Location = new System.Drawing.Point(11, 238);
            this.dtauLabel.Name = "dtauLabel";
            this.dtauLabel.Size = new System.Drawing.Size(113, 12);
            this.dtauLabel.TabIndex = 63;
            this.dtauLabel.Text = "剪切横截面直径dt：";
            // 
            // JointFaceUpEquOutDiameterLabel
            // 
            this.JointFaceUpEquOutDiameterLabel.AutoSize = true;
            this.JointFaceUpEquOutDiameterLabel.Location = new System.Drawing.Point(11, 82);
            this.JointFaceUpEquOutDiameterLabel.Name = "JointFaceUpEquOutDiameterLabel";
            this.JointFaceUpEquOutDiameterLabel.Size = new System.Drawing.Size(137, 12);
            this.JointFaceUpEquOutDiameterLabel.TabIndex = 63;
            this.JointFaceUpEquOutDiameterLabel.Text = "接合面上面的等效外径：";
            // 
            // UpperLimitAxialLoadDisplay
            // 
            this.UpperLimitAxialLoadDisplay.AutoSize = true;
            this.UpperLimitAxialLoadDisplay.Location = new System.Drawing.Point(286, 47);
            this.UpperLimitAxialLoadDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpperLimitAxialLoadDisplay.Name = "UpperLimitAxialLoadDisplay";
            this.UpperLimitAxialLoadDisplay.Size = new System.Drawing.Size(17, 12);
            this.UpperLimitAxialLoadDisplay.TabIndex = 61;
            this.UpperLimitAxialLoadDisplay.Text = "mm";
            // 
            // DA
            // 
            this.DA.Location = new System.Drawing.Point(171, 40);
            this.DA.Name = "DA";
            this.DA.Size = new System.Drawing.Size(110, 21);
            this.DA.TabIndex = 66;
            this.DA.Text = "80";
            this.DA.Click += new System.EventHandler(this.DA_Click);
            // 
            // AD
            // 
            this.AD.Location = new System.Drawing.Point(171, 171);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(110, 21);
            this.AD.TabIndex = 66;
            // 
            // BoltGroup
            // 
            this.BoltGroup.AutoSize = true;
            this.BoltGroup.Controls.Add(this.fBS);
            this.BoltGroup.Controls.Add(this.Rm_kangla);
            this.BoltGroup.Controls.Add(this.Rpmin_qufu);
            this.BoltGroup.Controls.Add(this.beta);
            this.BoltGroup.Controls.Add(this.Es_yangshi);
            this.BoltGroup.Controls.Add(this.dt);
            this.BoltGroup.Controls.Add(this.ScrewLengthls);
            this.BoltGroup.Controls.Add(this.boringDh);
            this.BoltGroup.Controls.Add(this.boltStd);
            this.BoltGroup.Controls.Add(this.strengthGradeChooseBtn);
            this.BoltGroup.Controls.Add(this.boltChooseBtn);
            this.BoltGroup.Controls.Add(this.screwTypeLabel);
            this.BoltGroup.Controls.Add(this.fBSLabel);
            this.BoltGroup.Controls.Add(this.Rm_kanglaLabel);
            this.BoltGroup.Controls.Add(this.BoltType);
            this.BoltGroup.Controls.Add(this.betaLabel);
            this.BoltGroup.Controls.Add(this.Rpmin_qufuLabel);
            this.BoltGroup.Controls.Add(this.dataSourceLabel);
            this.BoltGroup.Controls.Add(this.Es_yangshiLabel);
            this.BoltGroup.Controls.Add(this.dtLabel);
            this.BoltGroup.Controls.Add(this.ScrewLengthLabel);
            this.BoltGroup.Controls.Add(this.Rm_kanglaUnit);
            this.BoltGroup.Controls.Add(this.Rpmin_qufuUnit);
            this.BoltGroup.Controls.Add(this.EsUnit);
            this.BoltGroup.Controls.Add(this.dtUnit);
            this.BoltGroup.Controls.Add(this.betaUnit);
            this.BoltGroup.Controls.Add(this.ScrewLengthUnit);
            this.BoltGroup.Controls.Add(this.boringDhUnit);
            this.BoltGroup.Controls.Add(this.boringDhLabel);
            this.BoltGroup.Controls.Add(this.strengthGradeLabel);
            this.BoltGroup.Controls.Add(this.boltStdLabel);
            this.BoltGroup.Controls.Add(this.chooseBoltLabel);
            this.BoltGroup.Controls.Add(this.BoltTypeLabel);
            this.BoltGroup.Controls.Add(this.screwType);
            this.BoltGroup.Controls.Add(this.dataSource);
            this.BoltGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoltGroup.Location = new System.Drawing.Point(0, 0);
            this.BoltGroup.Name = "BoltGroup";
            this.BoltGroup.Size = new System.Drawing.Size(308, 521);
            this.BoltGroup.TabIndex = 51;
            this.BoltGroup.TabStop = false;
            this.BoltGroup.Text = "螺栓";
            // 
            // fBS
            // 
            this.fBS.Location = new System.Drawing.Point(146, 480);
            this.fBS.Name = "fBS";
            this.fBS.ReadOnly = true;
            this.fBS.Size = new System.Drawing.Size(92, 21);
            this.fBS.TabIndex = 47;
            // 
            // Rm_kangla
            // 
            this.Rm_kangla.Location = new System.Drawing.Point(146, 452);
            this.Rm_kangla.Name = "Rm_kangla";
            this.Rm_kangla.ReadOnly = true;
            this.Rm_kangla.Size = new System.Drawing.Size(92, 21);
            this.Rm_kangla.TabIndex = 47;
            // 
            // Rpmin_qufu
            // 
            this.Rpmin_qufu.Location = new System.Drawing.Point(146, 419);
            this.Rpmin_qufu.Name = "Rpmin_qufu";
            this.Rpmin_qufu.ReadOnly = true;
            this.Rpmin_qufu.Size = new System.Drawing.Size(92, 21);
            this.Rpmin_qufu.TabIndex = 47;
            // 
            // beta
            // 
            this.beta.Location = new System.Drawing.Point(146, 277);
            this.beta.Name = "beta";
            this.beta.ReadOnly = true;
            this.beta.Size = new System.Drawing.Size(92, 21);
            this.beta.TabIndex = 47;
            this.beta.Text = "60";
            // 
            // Es_yangshi
            // 
            this.Es_yangshi.Location = new System.Drawing.Point(146, 388);
            this.Es_yangshi.Name = "Es_yangshi";
            this.Es_yangshi.ReadOnly = true;
            this.Es_yangshi.Size = new System.Drawing.Size(92, 21);
            this.Es_yangshi.TabIndex = 47;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(146, 313);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.Size = new System.Drawing.Size(92, 21);
            this.dt.TabIndex = 47;
            this.dt.Visible = false;
            // 
            // ScrewLengthls
            // 
            this.ScrewLengthls.Location = new System.Drawing.Point(146, 244);
            this.ScrewLengthls.Name = "ScrewLengthls";
            this.ScrewLengthls.ReadOnly = true;
            this.ScrewLengthls.Size = new System.Drawing.Size(92, 21);
            this.ScrewLengthls.TabIndex = 47;
            // 
            // boringDh
            // 
            this.boringDh.Location = new System.Drawing.Point(146, 213);
            this.boringDh.Name = "boringDh";
            this.boringDh.ReadOnly = true;
            this.boringDh.Size = new System.Drawing.Size(92, 21);
            this.boringDh.TabIndex = 47;
            // 
            // boltStd
            // 
            this.boltStd.Location = new System.Drawing.Point(146, 181);
            this.boltStd.Name = "boltStd";
            this.boltStd.ReadOnly = true;
            this.boltStd.Size = new System.Drawing.Size(92, 21);
            this.boltStd.TabIndex = 47;
            // 
            // strengthGradeChooseBtn
            // 
            this.strengthGradeChooseBtn.Location = new System.Drawing.Point(144, 347);
            this.strengthGradeChooseBtn.Name = "strengthGradeChooseBtn";
            this.strengthGradeChooseBtn.Size = new System.Drawing.Size(75, 23);
            this.strengthGradeChooseBtn.TabIndex = 46;
            this.strengthGradeChooseBtn.Text = "选择";
            this.strengthGradeChooseBtn.UseVisualStyleBackColor = true;
            this.strengthGradeChooseBtn.Click += new System.EventHandler(this.strengthGradeChooseBtn_Click);
            // 
            // boltChooseBtn
            // 
            this.boltChooseBtn.Location = new System.Drawing.Point(144, 145);
            this.boltChooseBtn.Name = "boltChooseBtn";
            this.boltChooseBtn.Size = new System.Drawing.Size(75, 23);
            this.boltChooseBtn.TabIndex = 46;
            this.boltChooseBtn.Text = "选择";
            this.boltChooseBtn.UseVisualStyleBackColor = true;
            this.boltChooseBtn.Click += new System.EventHandler(this.boltChooseBtn_Click_1);
            // 
            // screwTypeLabel
            // 
            this.screwTypeLabel.AutoSize = true;
            this.screwTypeLabel.Location = new System.Drawing.Point(22, 69);
            this.screwTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.screwTypeLabel.Name = "screwTypeLabel";
            this.screwTypeLabel.Size = new System.Drawing.Size(53, 12);
            this.screwTypeLabel.TabIndex = 41;
            this.screwTypeLabel.Text = "螺纹类型";
            // 
            // fBSLabel
            // 
            this.fBSLabel.AutoSize = true;
            this.fBSLabel.Location = new System.Drawing.Point(22, 485);
            this.fBSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fBSLabel.Name = "fBSLabel";
            this.fBSLabel.Size = new System.Drawing.Size(83, 12);
            this.fBSLabel.TabIndex = 44;
            this.fBSLabel.Text = "剪切强度比fBS";
            // 
            // Rm_kanglaLabel
            // 
            this.Rm_kanglaLabel.AutoSize = true;
            this.Rm_kanglaLabel.Location = new System.Drawing.Point(22, 457);
            this.Rm_kanglaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rm_kanglaLabel.Name = "Rm_kanglaLabel";
            this.Rm_kanglaLabel.Size = new System.Drawing.Size(77, 12);
            this.Rm_kanglaLabel.TabIndex = 44;
            this.Rm_kanglaLabel.Text = "抗拉强度Rm：";
            // 
            // BoltType
            // 
            this.BoltType.DisplayMember = "boltType";
            this.BoltType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoltType.FormattingEnabled = true;
            this.BoltType.Items.AddRange(new object[] {
            "内六角螺栓",
            "外六角螺栓",
            "法兰螺栓"});
            this.BoltType.Location = new System.Drawing.Point(146, 108);
            this.BoltType.Margin = new System.Windows.Forms.Padding(2);
            this.BoltType.Name = "BoltType";
            this.BoltType.Size = new System.Drawing.Size(92, 20);
            this.BoltType.TabIndex = 45;
            this.BoltType.ValueMember = "boltType";
            this.BoltType.SelectedIndexChanged += new System.EventHandler(this.BoltType_SelectedIndexChanged_1);
            // 
            // betaLabel
            // 
            this.betaLabel.AutoSize = true;
            this.betaLabel.Location = new System.Drawing.Point(22, 282);
            this.betaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.betaLabel.Name = "betaLabel";
            this.betaLabel.Size = new System.Drawing.Size(65, 12);
            this.betaLabel.TabIndex = 44;
            this.betaLabel.Text = "螺旋角β：";
            // 
            // Rpmin_qufuLabel
            // 
            this.Rpmin_qufuLabel.AutoSize = true;
            this.Rpmin_qufuLabel.Location = new System.Drawing.Point(22, 425);
            this.Rpmin_qufuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rpmin_qufuLabel.Name = "Rpmin_qufuLabel";
            this.Rpmin_qufuLabel.Size = new System.Drawing.Size(119, 12);
            this.Rpmin_qufuLabel.TabIndex = 44;
            this.Rpmin_qufuLabel.Text = "最小屈服强度Rpmin：";
            // 
            // dataSourceLabel
            // 
            this.dataSourceLabel.AutoSize = true;
            this.dataSourceLabel.Location = new System.Drawing.Point(22, 26);
            this.dataSourceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataSourceLabel.Name = "dataSourceLabel";
            this.dataSourceLabel.Size = new System.Drawing.Size(53, 12);
            this.dataSourceLabel.TabIndex = 40;
            this.dataSourceLabel.Text = "数据源：";
            // 
            // Es_yangshiLabel
            // 
            this.Es_yangshiLabel.AutoSize = true;
            this.Es_yangshiLabel.Location = new System.Drawing.Point(22, 393);
            this.Es_yangshiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Es_yangshiLabel.Name = "Es_yangshiLabel";
            this.Es_yangshiLabel.Size = new System.Drawing.Size(77, 12);
            this.Es_yangshiLabel.TabIndex = 44;
            this.Es_yangshiLabel.Text = "杨氏模量Es：";
            // 
            // dtLabel
            // 
            this.dtLabel.AutoSize = true;
            this.dtLabel.Location = new System.Drawing.Point(22, 319);
            this.dtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtLabel.Name = "dtLabel";
            this.dtLabel.Size = new System.Drawing.Size(77, 12);
            this.dtLabel.TabIndex = 44;
            this.dtLabel.Text = "缩杆直径dt：";
            this.dtLabel.Visible = false;
            // 
            // ScrewLengthLabel
            // 
            this.ScrewLengthLabel.AutoSize = true;
            this.ScrewLengthLabel.Location = new System.Drawing.Point(22, 250);
            this.ScrewLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScrewLengthLabel.Name = "ScrewLengthLabel";
            this.ScrewLengthLabel.Size = new System.Drawing.Size(77, 12);
            this.ScrewLengthLabel.TabIndex = 44;
            this.ScrewLengthLabel.Text = "螺杆长度ls：";
            // 
            // Rm_kanglaUnit
            // 
            this.Rm_kanglaUnit.AutoSize = true;
            this.Rm_kanglaUnit.Location = new System.Drawing.Point(243, 455);
            this.Rm_kanglaUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rm_kanglaUnit.Name = "Rm_kanglaUnit";
            this.Rm_kanglaUnit.Size = new System.Drawing.Size(35, 12);
            this.Rm_kanglaUnit.TabIndex = 44;
            this.Rm_kanglaUnit.Text = "N/mm2";
            // 
            // Rpmin_qufuUnit
            // 
            this.Rpmin_qufuUnit.AutoSize = true;
            this.Rpmin_qufuUnit.Location = new System.Drawing.Point(243, 422);
            this.Rpmin_qufuUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Rpmin_qufuUnit.Name = "Rpmin_qufuUnit";
            this.Rpmin_qufuUnit.Size = new System.Drawing.Size(35, 12);
            this.Rpmin_qufuUnit.TabIndex = 44;
            this.Rpmin_qufuUnit.Text = "N/mm2";
            // 
            // EsUnit
            // 
            this.EsUnit.AutoSize = true;
            this.EsUnit.Location = new System.Drawing.Point(243, 393);
            this.EsUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EsUnit.Name = "EsUnit";
            this.EsUnit.Size = new System.Drawing.Size(35, 12);
            this.EsUnit.TabIndex = 44;
            this.EsUnit.Text = "N/mm2";
            // 
            // dtUnit
            // 
            this.dtUnit.AutoSize = true;
            this.dtUnit.Location = new System.Drawing.Point(243, 319);
            this.dtUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dtUnit.Name = "dtUnit";
            this.dtUnit.Size = new System.Drawing.Size(17, 12);
            this.dtUnit.TabIndex = 44;
            this.dtUnit.Text = "mm";
            this.dtUnit.Visible = false;
            // 
            // betaUnit
            // 
            this.betaUnit.AutoSize = true;
            this.betaUnit.Location = new System.Drawing.Point(243, 280);
            this.betaUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.betaUnit.Name = "betaUnit";
            this.betaUnit.Size = new System.Drawing.Size(17, 12);
            this.betaUnit.TabIndex = 44;
            this.betaUnit.Text = "°";
            // 
            // ScrewLengthUnit
            // 
            this.ScrewLengthUnit.AutoSize = true;
            this.ScrewLengthUnit.Location = new System.Drawing.Point(243, 250);
            this.ScrewLengthUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScrewLengthUnit.Name = "ScrewLengthUnit";
            this.ScrewLengthUnit.Size = new System.Drawing.Size(17, 12);
            this.ScrewLengthUnit.TabIndex = 44;
            this.ScrewLengthUnit.Text = "mm";
            // 
            // boringDhUnit
            // 
            this.boringDhUnit.AutoSize = true;
            this.boringDhUnit.Location = new System.Drawing.Point(243, 218);
            this.boringDhUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boringDhUnit.Name = "boringDhUnit";
            this.boringDhUnit.Size = new System.Drawing.Size(17, 12);
            this.boringDhUnit.TabIndex = 44;
            this.boringDhUnit.Text = "mm";
            // 
            // boringDhLabel
            // 
            this.boringDhLabel.AutoSize = true;
            this.boringDhLabel.Location = new System.Drawing.Point(22, 218);
            this.boringDhLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boringDhLabel.Name = "boringDhLabel";
            this.boringDhLabel.Size = new System.Drawing.Size(77, 12);
            this.boringDhLabel.TabIndex = 44;
            this.boringDhLabel.Text = "镗孔直径dh：";
            // 
            // strengthGradeLabel
            // 
            this.strengthGradeLabel.AutoSize = true;
            this.strengthGradeLabel.Location = new System.Drawing.Point(22, 353);
            this.strengthGradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strengthGradeLabel.Name = "strengthGradeLabel";
            this.strengthGradeLabel.Size = new System.Drawing.Size(65, 12);
            this.strengthGradeLabel.TabIndex = 44;
            this.strengthGradeLabel.Text = "强度等级：";
            // 
            // boltStdLabel
            // 
            this.boltStdLabel.AutoSize = true;
            this.boltStdLabel.Location = new System.Drawing.Point(22, 186);
            this.boltStdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boltStdLabel.Name = "boltStdLabel";
            this.boltStdLabel.Size = new System.Drawing.Size(41, 12);
            this.boltStdLabel.TabIndex = 44;
            this.boltStdLabel.Text = "标准：";
            // 
            // chooseBoltLabel
            // 
            this.chooseBoltLabel.AutoSize = true;
            this.chooseBoltLabel.Location = new System.Drawing.Point(22, 151);
            this.chooseBoltLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chooseBoltLabel.Name = "chooseBoltLabel";
            this.chooseBoltLabel.Size = new System.Drawing.Size(65, 12);
            this.chooseBoltLabel.TabIndex = 44;
            this.chooseBoltLabel.Text = "螺栓指定：";
            // 
            // BoltTypeLabel
            // 
            this.BoltTypeLabel.AutoSize = true;
            this.BoltTypeLabel.Location = new System.Drawing.Point(22, 111);
            this.BoltTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoltTypeLabel.Name = "BoltTypeLabel";
            this.BoltTypeLabel.Size = new System.Drawing.Size(65, 12);
            this.BoltTypeLabel.TabIndex = 44;
            this.BoltTypeLabel.Text = "螺栓类型：";
            // 
            // screwType
            // 
            this.screwType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screwType.FormattingEnabled = true;
            this.screwType.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.screwType.Items.AddRange(new object[] {
            "标准螺纹"});
            this.screwType.Location = new System.Drawing.Point(146, 64);
            this.screwType.Margin = new System.Windows.Forms.Padding(2);
            this.screwType.Name = "screwType";
            this.screwType.Size = new System.Drawing.Size(92, 20);
            this.screwType.TabIndex = 43;
            // 
            // dataSource
            // 
            this.dataSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataSource.FormattingEnabled = true;
            this.dataSource.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataSource.Items.AddRange(new object[] {
            "数据库",
            "自定义"});
            this.dataSource.Location = new System.Drawing.Point(146, 23);
            this.dataSource.Margin = new System.Windows.Forms.Padding(2);
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(92, 20);
            this.dataSource.TabIndex = 42;
            // 
            // modeAndOpt
            // 
            this.modeAndOpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeAndOpt.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.modeAndOpt.Location = new System.Drawing.Point(0, 0);
            this.modeAndOpt.Name = "modeAndOpt";
            this.modeAndOpt.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // modeAndOpt.Panel1
            // 
            this.modeAndOpt.Panel1.AutoScroll = true;
            this.modeAndOpt.Panel1.Controls.Add(this.modelControlBox);
            // 
            // modeAndOpt.Panel2
            // 
            this.modeAndOpt.Panel2.Controls.Add(this.simulation1);
            this.modeAndOpt.Size = new System.Drawing.Size(459, 554);
            this.modeAndOpt.SplitterDistance = 162;
            this.modeAndOpt.TabIndex = 4;
            // 
            // modelControlBox
            // 
            this.modelControlBox.Controls.Add(this.shadedButton);
            this.modelControlBox.Controls.Add(this.animateCameraCheckBox);
            this.modelControlBox.Controls.Add(this.shadingLabel);
            this.modelControlBox.Controls.Add(this.topViewButton);
            this.modelControlBox.Controls.Add(this.wireframeButton);
            this.modelControlBox.Controls.Add(this.sideViewButton);
            this.modelControlBox.Controls.Add(this.renderedButton);
            this.modelControlBox.Controls.Add(this.frontViewButton);
            this.modelControlBox.Controls.Add(this.hiddenLinesButton);
            this.modelControlBox.Controls.Add(this.isoViewButton);
            this.modelControlBox.Controls.Add(this.flatButton);
            this.modelControlBox.Controls.Add(this.viewLabel);
            this.modelControlBox.Controls.Add(this.showOriginButton);
            this.modelControlBox.Controls.Add(this.showGridButton);
            this.modelControlBox.Controls.Add(this.showExtentsButton);
            this.modelControlBox.Controls.Add(this.hideShowLabel);
            this.modelControlBox.Controls.Add(this.showVerticesButton);
            this.modelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.modelControlBox.Location = new System.Drawing.Point(0, 0);
            this.modelControlBox.Margin = new System.Windows.Forms.Padding(2);
            this.modelControlBox.Name = "modelControlBox";
            this.modelControlBox.Padding = new System.Windows.Forms.Padding(2);
            this.modelControlBox.Size = new System.Drawing.Size(459, 157);
            this.modelControlBox.TabIndex = 189;
            this.modelControlBox.TabStop = false;
            this.modelControlBox.Text = "控制";
            // 
            // shadedButton
            // 
            this.shadedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.shadedButton.Location = new System.Drawing.Point(113, 40);
            this.shadedButton.Name = "shadedButton";
            this.shadedButton.Size = new System.Drawing.Size(78, 22);
            this.shadedButton.TabIndex = 171;
            this.shadedButton.TabStop = true;
            this.shadedButton.Text = "着色";
            this.shadedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shadedButton.UseVisualStyleBackColor = true;
            this.shadedButton.CheckedChanged += new System.EventHandler(this.shadedButton_CheckedChanged);
            // 
            // animateCameraCheckBox
            // 
            this.animateCameraCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.animateCameraCheckBox.Location = new System.Drawing.Point(367, 125);
            this.animateCameraCheckBox.Name = "animateCameraCheckBox";
            this.animateCameraCheckBox.Size = new System.Drawing.Size(78, 22);
            this.animateCameraCheckBox.TabIndex = 188;
            this.animateCameraCheckBox.Text = "Animate";
            this.animateCameraCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.animateCameraCheckBox.UseVisualStyleBackColor = true;
            this.animateCameraCheckBox.Click += new System.EventHandler(this.animateCameraCheckBox_CheckedChanged);
            // 
            // shadingLabel
            // 
            this.shadingLabel.AutoSize = true;
            this.shadingLabel.Location = new System.Drawing.Point(32, 24);
            this.shadingLabel.Name = "shadingLabel";
            this.shadingLabel.Size = new System.Drawing.Size(53, 12);
            this.shadingLabel.TabIndex = 173;
            this.shadingLabel.Text = "着色模式";
            // 
            // topViewButton
            // 
            this.topViewButton.Location = new System.Drawing.Point(196, 125);
            this.topViewButton.Name = "topViewButton";
            this.topViewButton.Size = new System.Drawing.Size(78, 22);
            this.topViewButton.TabIndex = 187;
            this.topViewButton.Text = "俯视";
            this.topViewButton.UseVisualStyleBackColor = true;
            this.topViewButton.Click += new System.EventHandler(this.topViewButton_Click);
            // 
            // wireframeButton
            // 
            this.wireframeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.wireframeButton.Location = new System.Drawing.Point(32, 40);
            this.wireframeButton.Name = "wireframeButton";
            this.wireframeButton.Size = new System.Drawing.Size(78, 22);
            this.wireframeButton.TabIndex = 170;
            this.wireframeButton.Text = "框架";
            this.wireframeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wireframeButton.UseVisualStyleBackColor = true;
            this.wireframeButton.CheckedChanged += new System.EventHandler(this.wireframeButton_CheckedChanged);
            // 
            // sideViewButton
            // 
            this.sideViewButton.Location = new System.Drawing.Point(113, 125);
            this.sideViewButton.Name = "sideViewButton";
            this.sideViewButton.Size = new System.Drawing.Size(78, 22);
            this.sideViewButton.TabIndex = 186;
            this.sideViewButton.Text = "右视";
            this.sideViewButton.UseVisualStyleBackColor = true;
            this.sideViewButton.Click += new System.EventHandler(this.sideViewButton_Click);
            // 
            // renderedButton
            // 
            this.renderedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.renderedButton.Checked = true;
            this.renderedButton.Location = new System.Drawing.Point(196, 40);
            this.renderedButton.Name = "renderedButton";
            this.renderedButton.Size = new System.Drawing.Size(78, 22);
            this.renderedButton.TabIndex = 172;
            this.renderedButton.TabStop = true;
            this.renderedButton.Text = "渲染";
            this.renderedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.renderedButton.UseVisualStyleBackColor = true;
            this.renderedButton.CheckedChanged += new System.EventHandler(this.renderedButton_CheckedChanged);
            // 
            // frontViewButton
            // 
            this.frontViewButton.Location = new System.Drawing.Point(32, 125);
            this.frontViewButton.Name = "frontViewButton";
            this.frontViewButton.Size = new System.Drawing.Size(78, 22);
            this.frontViewButton.TabIndex = 185;
            this.frontViewButton.Text = "正视";
            this.frontViewButton.UseVisualStyleBackColor = true;
            this.frontViewButton.Click += new System.EventHandler(this.frontViewButton_Click);
            // 
            // hiddenLinesButton
            // 
            this.hiddenLinesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hiddenLinesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hiddenLinesButton.Location = new System.Drawing.Point(277, 40);
            this.hiddenLinesButton.Name = "hiddenLinesButton";
            this.hiddenLinesButton.Size = new System.Drawing.Size(78, 22);
            this.hiddenLinesButton.TabIndex = 174;
            this.hiddenLinesButton.Text = "隐藏线";
            this.hiddenLinesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hiddenLinesButton.UseVisualStyleBackColor = false;
            this.hiddenLinesButton.CheckedChanged += new System.EventHandler(this.hiddenLinesButton_CheckedChanged);
            // 
            // isoViewButton
            // 
            this.isoViewButton.Location = new System.Drawing.Point(277, 125);
            this.isoViewButton.Name = "isoViewButton";
            this.isoViewButton.Size = new System.Drawing.Size(78, 22);
            this.isoViewButton.TabIndex = 184;
            this.isoViewButton.Text = "Iso";
            this.isoViewButton.UseVisualStyleBackColor = true;
            this.isoViewButton.Click += new System.EventHandler(this.isoViewButton_Click);
            // 
            // flatButton
            // 
            this.flatButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.flatButton.Location = new System.Drawing.Point(365, 40);
            this.flatButton.Name = "flatButton";
            this.flatButton.Size = new System.Drawing.Size(78, 22);
            this.flatButton.TabIndex = 175;
            this.flatButton.TabStop = true;
            this.flatButton.Text = "平铺";
            this.flatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.flatButton.UseVisualStyleBackColor = true;
            this.flatButton.CheckedChanged += new System.EventHandler(this.flatButton_CheckedChanged);
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.Location = new System.Drawing.Point(33, 109);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(29, 12);
            this.viewLabel.TabIndex = 183;
            this.viewLabel.Text = "视图";
            // 
            // showOriginButton
            // 
            this.showOriginButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showOriginButton.Checked = true;
            this.showOriginButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOriginButton.Location = new System.Drawing.Point(32, 84);
            this.showOriginButton.Name = "showOriginButton";
            this.showOriginButton.Size = new System.Drawing.Size(78, 22);
            this.showOriginButton.TabIndex = 178;
            this.showOriginButton.Text = "原点";
            this.showOriginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showOriginButton.UseVisualStyleBackColor = true;
            this.showOriginButton.CheckedChanged += new System.EventHandler(this.showOriginButton_CheckedChanged);
            // 
            // showGridButton
            // 
            this.showGridButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showGridButton.Checked = true;
            this.showGridButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGridButton.Location = new System.Drawing.Point(277, 84);
            this.showGridButton.Name = "showGridButton";
            this.showGridButton.Size = new System.Drawing.Size(78, 22);
            this.showGridButton.TabIndex = 182;
            this.showGridButton.Text = "网格";
            this.showGridButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showGridButton.UseVisualStyleBackColor = true;
            this.showGridButton.CheckedChanged += new System.EventHandler(this.showGridButton_CheckedChanged);
            // 
            // showExtentsButton
            // 
            this.showExtentsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showExtentsButton.Location = new System.Drawing.Point(113, 84);
            this.showExtentsButton.Name = "showExtentsButton";
            this.showExtentsButton.Size = new System.Drawing.Size(78, 22);
            this.showExtentsButton.TabIndex = 179;
            this.showExtentsButton.Text = "扩展";
            this.showExtentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showExtentsButton.UseVisualStyleBackColor = true;
            this.showExtentsButton.CheckedChanged += new System.EventHandler(this.showExtentsButton_CheckedChanged);
            // 
            // hideShowLabel
            // 
            this.hideShowLabel.AutoSize = true;
            this.hideShowLabel.Location = new System.Drawing.Point(32, 68);
            this.hideShowLabel.Name = "hideShowLabel";
            this.hideShowLabel.Size = new System.Drawing.Size(59, 12);
            this.hideShowLabel.TabIndex = 181;
            this.hideShowLabel.Text = "显示/隐藏";
            // 
            // showVerticesButton
            // 
            this.showVerticesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showVerticesButton.Location = new System.Drawing.Point(196, 84);
            this.showVerticesButton.Name = "showVerticesButton";
            this.showVerticesButton.Size = new System.Drawing.Size(78, 22);
            this.showVerticesButton.TabIndex = 180;
            this.showVerticesButton.Text = "顶点";
            this.showVerticesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showVerticesButton.UseVisualStyleBackColor = true;
            this.showVerticesButton.CheckedChanged += new System.EventHandler(this.showVerticesButton_CheckedChanged);
            // 
            // simulation1
            // 
            this.simulation1.Cursor = System.Windows.Forms.Cursors.Default;
            this.simulation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulation1.Location = new System.Drawing.Point(0, 0);
            this.simulation1.Name = "simulation1";
            this.simulation1.ProgressBar = progressBar1;
            this.simulation1.Size = new System.Drawing.Size(459, 388);
            this.simulation1.TabIndex = 1;
            this.simulation1.Text = "simulation1";
            coordinateSystemIcon1.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport1.CoordinateSystemIcon = coordinateSystemIcon1;
            viewport1.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol1.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport1.OriginSymbol = originSymbol1;
            viewCubeIcon1.Font = null;
            viewCubeIcon1.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport1.ViewCubeIcon = viewCubeIcon1;
            this.simulation1.Viewports.Add(viewport1);
            this.simulation1.Click += new System.EventHandler(this.simulation1_Click);
            // 
            // Mode3D
            // 
            this.Mode3D.AutoSize = true;
            this.Mode3D.Location = new System.Drawing.Point(298, 258);
            this.Mode3D.Name = "Mode3D";
            this.Mode3D.Size = new System.Drawing.Size(41, 12);
            this.Mode3D.TabIndex = 1;
            this.Mode3D.Text = "3D模型";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.introGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableTab);
            this.splitContainer1.Size = new System.Drawing.Size(1158, 146);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.TabIndex = 0;
            // 
            // introGroup
            // 
            this.introGroup.Controls.Add(this.introLabel);
            this.introGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introGroup.Location = new System.Drawing.Point(0, 0);
            this.introGroup.Name = "introGroup";
            this.introGroup.Size = new System.Drawing.Size(493, 146);
            this.introGroup.TabIndex = 3;
            this.introGroup.TabStop = false;
            this.introGroup.Text = "说明";
            this.introGroup.Visible = false;
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introLabel.Location = new System.Drawing.Point(3, 17);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(17, 12);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "：\r\n";
            // 
            // tableTab
            // 
            this.tableTab.Controls.Add(this.getNTable);
            this.tableTab.Controls.Add(this.svTable);
            this.tableTab.Controls.Add(this.meffd);
            this.tableTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTab.Location = new System.Drawing.Point(0, 0);
            this.tableTab.Name = "tableTab";
            this.tableTab.SelectedIndex = 0;
            this.tableTab.Size = new System.Drawing.Size(661, 146);
            this.tableTab.TabIndex = 3;
            // 
            // getNTable
            // 
            this.getNTable.AutoScroll = true;
            this.getNTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getNTable.BackgroundImage")));
            this.getNTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.getNTable.Location = new System.Drawing.Point(4, 22);
            this.getNTable.Name = "getNTable";
            this.getNTable.Padding = new System.Windows.Forms.Padding(3);
            this.getNTable.Size = new System.Drawing.Size(653, 120);
            this.getNTable.TabIndex = 0;
            this.getNTable.Text = "载荷传导系数";
            this.getNTable.UseVisualStyleBackColor = true;
            // 
            // svTable
            // 
            this.svTable.AutoScroll = true;
            this.svTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("svTable.BackgroundImage")));
            this.svTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.svTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svTable.Location = new System.Drawing.Point(4, 22);
            this.svTable.Name = "svTable";
            this.svTable.Padding = new System.Windows.Forms.Padding(3);
            this.svTable.Size = new System.Drawing.Size(653, 120);
            this.svTable.TabIndex = 1;
            this.svTable.Text = "sv样式";
            this.svTable.UseVisualStyleBackColor = true;
            // 
            // meffd
            // 
            this.meffd.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.meffd;
            this.meffd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.meffd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meffd.Location = new System.Drawing.Point(4, 22);
            this.meffd.Name = "meffd";
            this.meffd.Padding = new System.Windows.Forms.Padding(3);
            this.meffd.Size = new System.Drawing.Size(653, 120);
            this.meffd.TabIndex = 2;
            this.meffd.Text = "相对啮合长度";
            this.meffd.UseVisualStyleBackColor = true;
            // 
            // connAndLoadData
            // 
            this.connAndLoadData.Controls.Add(this.splitContainer2);
            this.connAndLoadData.Location = new System.Drawing.Point(4, 22);
            this.connAndLoadData.Name = "connAndLoadData";
            this.connAndLoadData.Padding = new System.Windows.Forms.Padding(3);
            this.connAndLoadData.Size = new System.Drawing.Size(1166, 716);
            this.connAndLoadData.TabIndex = 1;
            this.connAndLoadData.Text = "连接件及加载数据";
            this.connAndLoadData.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer2.Size = new System.Drawing.Size(1160, 710);
            this.splitContainer2.SplitterDistance = 542;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitConn);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitRight);
            this.splitContainer3.Size = new System.Drawing.Size(1160, 542);
            this.splitContainer3.SplitterDistance = 341;
            this.splitContainer3.TabIndex = 1;
            // 
            // splitConn
            // 
            this.splitConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitConn.Location = new System.Drawing.Point(0, 0);
            this.splitConn.Name = "splitConn";
            this.splitConn.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitConn.Panel1
            // 
            this.splitConn.Panel1.AutoScroll = true;
            this.splitConn.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitConn.Panel2
            // 
            this.splitConn.Panel2.AutoScroll = true;
            this.splitConn.Panel2.Controls.Add(this.splitContainer4);
            this.splitConn.Size = new System.Drawing.Size(341, 542);
            this.splitConn.SplitterDistance = 63;
            this.splitConn.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.delButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(45, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 26);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // delButton
            // 
            this.delButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delButton.Location = new System.Drawing.Point(24, 3);
            this.delButton.Margin = new System.Windows.Forms.Padding(2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(77, 20);
            this.delButton.TabIndex = 0;
            this.delButton.Text = "删除";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addButton.Location = new System.Drawing.Point(149, 3);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 20);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataClampedChoosed);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dataClamped);
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer4.Size = new System.Drawing.Size(341, 475);
            this.splitContainer4.SplitterDistance = 193;
            this.splitContainer4.TabIndex = 0;
            // 
            // dataClampedChoosed
            // 
            this.dataClampedChoosed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClampedChoosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClampedChoosed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.ES,
            this.Rmmin,
            this.RatioFG,
            this.fBRatio,
            this.hi});
            this.dataClampedChoosed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataClampedChoosed.Location = new System.Drawing.Point(0, 0);
            this.dataClampedChoosed.Name = "dataClampedChoosed";
            this.dataClampedChoosed.RowTemplate.Height = 23;
            this.dataClampedChoosed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClampedChoosed.Size = new System.Drawing.Size(341, 193);
            this.dataClampedChoosed.TabIndex = 2;
            this.dataClampedChoosed.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClampedChoosed_CellEndEdit);
            // 
            // name
            // 
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            // 
            // ES
            // 
            this.ES.HeaderText = "杨氏模量";
            this.ES.Name = "ES";
            // 
            // Rmmin
            // 
            this.Rmmin.HeaderText = "Rmmin";
            this.Rmmin.Name = "Rmmin";
            // 
            // RatioFG
            // 
            this.RatioFG.HeaderText = "极限表面压力系数fG";
            this.RatioFG.Name = "RatioFG";
            // 
            // fBRatio
            // 
            this.fBRatio.HeaderText = "剪切强度比fB";
            this.fBRatio.Name = "fBRatio";
            // 
            // hi
            // 
            this.hi.DataPropertyName = "ClampedMaterialName";
            this.hi.HeaderText = "厚度";
            this.hi.Name = "hi";
            // 
            // dataClamped
            // 
            this.dataClamped.AllowDrop = true;
            this.dataClamped.AutoGenerateColumns = false;
            this.dataClamped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClamped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClamped.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clampedMaterialNameDataGridViewTextBoxColumn,
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn,
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn,
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn,
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn});
            this.dataClamped.DataSource = this.dbomaterialClampedBindingSource;
            this.dataClamped.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataClamped.Location = new System.Drawing.Point(0, 0);
            this.dataClamped.Name = "dataClamped";
            this.dataClamped.ReadOnly = true;
            this.dataClamped.RowTemplate.Height = 23;
            this.dataClamped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClamped.Size = new System.Drawing.Size(341, 278);
            this.dataClamped.TabIndex = 1;
            // 
            // clampedMaterialNameDataGridViewTextBoxColumn
            // 
            this.clampedMaterialNameDataGridViewTextBoxColumn.DataPropertyName = "ClampedMaterialName";
            this.clampedMaterialNameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.clampedMaterialNameDataGridViewTextBoxColumn.Name = "clampedMaterialNameDataGridViewTextBoxColumn";
            this.clampedMaterialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clampedMatrialEpyangshiDataGridViewTextBoxColumn
            // 
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn.DataPropertyName = "ClampedMatrialEp_yangshi";
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn.HeaderText = "Ep";
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn.Name = "clampedMatrialEpyangshiDataGridViewTextBoxColumn";
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clampedMatrialRmminkanglaDataGridViewTextBoxColumn
            // 
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn.DataPropertyName = "ClampedMatrialRmmin_kangla";
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn.HeaderText = "Rmmin";
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn.Name = "clampedMatrialRmminkanglaDataGridViewTextBoxColumn";
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clampedMatrialRatiofGDataGridViewTextBoxColumn
            // 
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn.DataPropertyName = "ClampedMatrialRatio_fG";
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn.HeaderText = "fG";
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn.Name = "clampedMatrialRatiofGDataGridViewTextBoxColumn";
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clampedMaterialRatiofBDataGridViewTextBoxColumn
            // 
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn.DataPropertyName = "ClampedMaterialRatio_fB";
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn.HeaderText = "fB";
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn.Name = "clampedMaterialRatiofBDataGridViewTextBoxColumn";
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbomaterialClampedBindingSource
            // 
            this.dbomaterialClampedBindingSource.DataMember = "dbo_materialClamped";
            this.dbomaterialClampedBindingSource.DataSource = this.boltConnectionSystemDataSet18;
            // 
            // boltConnectionSystemDataSet18
            // 
            this.boltConnectionSystemDataSet18.DataSetName = "BoltConnectionSystemDataSet18";
            this.boltConnectionSystemDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(341, 278);
            this.dataGridView2.TabIndex = 0;
            // 
            // splitRight
            // 
            this.splitRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.AutoScroll = true;
            this.splitRight.Panel1.Controls.Add(this.splitGasketNut);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.AutoScroll = true;
            this.splitRight.Panel2.Controls.Add(this.splitLoadData);
            this.splitRight.Size = new System.Drawing.Size(815, 542);
            this.splitRight.SplitterDistance = 395;
            this.splitRight.TabIndex = 2;
            // 
            // splitGasketNut
            // 
            this.splitGasketNut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGasketNut.Location = new System.Drawing.Point(0, 0);
            this.splitGasketNut.Name = "splitGasketNut";
            this.splitGasketNut.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGasketNut.Panel1
            // 
            this.splitGasketNut.Panel1.AutoScroll = true;
            this.splitGasketNut.Panel1.Controls.Add(this.gasketGroup);
            this.splitGasketNut.Panel1MinSize = 20;
            // 
            // splitGasketNut.Panel2
            // 
            this.splitGasketNut.Panel2.AutoScroll = true;
            this.splitGasketNut.Panel2.Controls.Add(this.nutGroup);
            this.splitGasketNut.Panel2MinSize = 20;
            this.splitGasketNut.Size = new System.Drawing.Size(393, 540);
            this.splitGasketNut.SplitterDistance = 364;
            this.splitGasketNut.TabIndex = 1;
            // 
            // gasketGroup
            // 
            this.gasketGroup.Controls.Add(this.gasketChooseBtn);
            this.gasketGroup.Controls.Add(this.gasketMaterialGroup);
            this.gasketGroup.Controls.Add(this.surfaceRoughnessUnit);
            this.gasketGroup.Controls.Add(this.CounterBoreDepthUnit);
            this.gasketGroup.Controls.Add(this.label3);
            this.gasketGroup.Controls.Add(this.hs2Unit);
            this.gasketGroup.Controls.Add(this.DAUUnit);
            this.gasketGroup.Controls.Add(this.dhasUnitLabel);
            this.gasketGroup.Controls.Add(this.Rz);
            this.gasketGroup.Controls.Add(this.CounterBoreDepth);
            this.gasketGroup.Controls.Add(this.dha);
            this.gasketGroup.Controls.Add(this.hs2);
            this.gasketGroup.Controls.Add(this.surfaceRoughnessLabel);
            this.gasketGroup.Controls.Add(this.CounterBoreDepthLabel);
            this.gasketGroup.Controls.Add(this.dhaLabel);
            this.gasketGroup.Controls.Add(this.dau);
            this.gasketGroup.Controls.Add(this.hs2Label);
            this.gasketGroup.Controls.Add(this.dhas);
            this.gasketGroup.Controls.Add(this.DAULabel);
            this.gasketGroup.Controls.Add(this.isCounterBore);
            this.gasketGroup.Controls.Add(this.isAngle);
            this.gasketGroup.Controls.Add(this.isCounterBoreLabel);
            this.gasketGroup.Controls.Add(this.isAngleLabel);
            this.gasketGroup.Controls.Add(this.dhasLabel);
            this.gasketGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.gasketGroup.Location = new System.Drawing.Point(0, 0);
            this.gasketGroup.Name = "gasketGroup";
            this.gasketGroup.Size = new System.Drawing.Size(376, 520);
            this.gasketGroup.TabIndex = 1;
            this.gasketGroup.TabStop = false;
            this.gasketGroup.Text = "垫圈";
            // 
            // gasketChooseBtn
            // 
            this.gasketChooseBtn.AutoSize = true;
            this.gasketChooseBtn.Location = new System.Drawing.Point(8, 22);
            this.gasketChooseBtn.Name = "gasketChooseBtn";
            this.gasketChooseBtn.Size = new System.Drawing.Size(72, 16);
            this.gasketChooseBtn.TabIndex = 47;
            this.gasketChooseBtn.Text = "选择垫圈";
            this.gasketChooseBtn.UseVisualStyleBackColor = true;
            this.gasketChooseBtn.CheckedChanged += new System.EventHandler(this.gasketChooseBtn_CheckedChanged);
            // 
            // gasketMaterialGroup
            // 
            this.gasketMaterialGroup.Controls.Add(this.fGUnit);
            this.gasketMaterialGroup.Controls.Add(this.RmminSUnit);
            this.gasketMaterialGroup.Controls.Add(this.EPSUnit);
            this.gasketMaterialGroup.Controls.Add(this.textBox8);
            this.gasketMaterialGroup.Controls.Add(this.RmminS);
            this.gasketMaterialGroup.Controls.Add(this.Es_gasket);
            this.gasketMaterialGroup.Controls.Add(this.gasketMaterialChooseBtn);
            this.gasketMaterialGroup.Controls.Add(this.fGLabel);
            this.gasketMaterialGroup.Controls.Add(this.RmminSLabel);
            this.gasketMaterialGroup.Controls.Add(this.EPSLabel);
            this.gasketMaterialGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gasketMaterialGroup.Location = new System.Drawing.Point(3, 331);
            this.gasketMaterialGroup.Name = "gasketMaterialGroup";
            this.gasketMaterialGroup.Size = new System.Drawing.Size(370, 186);
            this.gasketMaterialGroup.TabIndex = 46;
            this.gasketMaterialGroup.TabStop = false;
            this.gasketMaterialGroup.Text = "垫圈材料";
            this.gasketMaterialGroup.Visible = false;
            // 
            // fGUnit
            // 
            this.fGUnit.AutoSize = true;
            this.fGUnit.Location = new System.Drawing.Point(243, 107);
            this.fGUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fGUnit.Name = "fGUnit";
            this.fGUnit.Size = new System.Drawing.Size(35, 12);
            this.fGUnit.TabIndex = 65;
            this.fGUnit.Text = "N/mm2";
            // 
            // RmminSUnit
            // 
            this.RmminSUnit.AutoSize = true;
            this.RmminSUnit.Location = new System.Drawing.Point(243, 75);
            this.RmminSUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RmminSUnit.Name = "RmminSUnit";
            this.RmminSUnit.Size = new System.Drawing.Size(35, 12);
            this.RmminSUnit.TabIndex = 66;
            this.RmminSUnit.Text = "N/mm2";
            // 
            // EPSUnit
            // 
            this.EPSUnit.AutoSize = true;
            this.EPSUnit.Location = new System.Drawing.Point(243, 43);
            this.EPSUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EPSUnit.Name = "EPSUnit";
            this.EPSUnit.Size = new System.Drawing.Size(35, 12);
            this.EPSUnit.TabIndex = 67;
            this.EPSUnit.Text = "N/mm2";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(146, 102);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(92, 21);
            this.textBox8.TabIndex = 62;
            // 
            // RmminS
            // 
            this.RmminS.Location = new System.Drawing.Point(146, 69);
            this.RmminS.Name = "RmminS";
            this.RmminS.ReadOnly = true;
            this.RmminS.Size = new System.Drawing.Size(92, 21);
            this.RmminS.TabIndex = 63;
            // 
            // Es_gasket
            // 
            this.Es_gasket.Location = new System.Drawing.Point(146, 38);
            this.Es_gasket.Name = "Es_gasket";
            this.Es_gasket.ReadOnly = true;
            this.Es_gasket.Size = new System.Drawing.Size(92, 21);
            this.Es_gasket.TabIndex = 64;
            // 
            // gasketMaterialChooseBtn
            // 
            this.gasketMaterialChooseBtn.Location = new System.Drawing.Point(146, 9);
            this.gasketMaterialChooseBtn.Name = "gasketMaterialChooseBtn";
            this.gasketMaterialChooseBtn.Size = new System.Drawing.Size(75, 23);
            this.gasketMaterialChooseBtn.TabIndex = 61;
            this.gasketMaterialChooseBtn.Text = "选择";
            this.gasketMaterialChooseBtn.UseVisualStyleBackColor = true;
            // 
            // fGLabel
            // 
            this.fGLabel.AutoSize = true;
            this.fGLabel.Location = new System.Drawing.Point(11, 107);
            this.fGLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fGLabel.Name = "fGLabel";
            this.fGLabel.Size = new System.Drawing.Size(125, 12);
            this.fGLabel.TabIndex = 57;
            this.fGLabel.Text = "极限表面压力系数fG：";
            // 
            // RmminSLabel
            // 
            this.RmminSLabel.AutoSize = true;
            this.RmminSLabel.Location = new System.Drawing.Point(11, 75);
            this.RmminSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RmminSLabel.Name = "RmminSLabel";
            this.RmminSLabel.Size = new System.Drawing.Size(107, 12);
            this.RmminSLabel.TabIndex = 58;
            this.RmminSLabel.Text = "最小抗拉强度Rmmin\r\n";
            // 
            // EPSLabel
            // 
            this.EPSLabel.AutoSize = true;
            this.EPSLabel.Location = new System.Drawing.Point(11, 43);
            this.EPSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EPSLabel.Name = "EPSLabel";
            this.EPSLabel.Size = new System.Drawing.Size(77, 12);
            this.EPSLabel.TabIndex = 59;
            this.EPSLabel.Text = "杨氏模量Es：";
            // 
            // surfaceRoughnessUnit
            // 
            this.surfaceRoughnessUnit.AutoSize = true;
            this.surfaceRoughnessUnit.Location = new System.Drawing.Point(237, 293);
            this.surfaceRoughnessUnit.Name = "surfaceRoughnessUnit";
            this.surfaceRoughnessUnit.Size = new System.Drawing.Size(17, 12);
            this.surfaceRoughnessUnit.TabIndex = 45;
            this.surfaceRoughnessUnit.Text = "um";
            // 
            // CounterBoreDepthUnit
            // 
            this.CounterBoreDepthUnit.AutoSize = true;
            this.CounterBoreDepthUnit.Location = new System.Drawing.Point(237, 257);
            this.CounterBoreDepthUnit.Name = "CounterBoreDepthUnit";
            this.CounterBoreDepthUnit.Size = new System.Drawing.Size(17, 12);
            this.CounterBoreDepthUnit.TabIndex = 45;
            this.CounterBoreDepthUnit.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "mm";
            // 
            // hs2Unit
            // 
            this.hs2Unit.AutoSize = true;
            this.hs2Unit.Location = new System.Drawing.Point(237, 109);
            this.hs2Unit.Name = "hs2Unit";
            this.hs2Unit.Size = new System.Drawing.Size(17, 12);
            this.hs2Unit.TabIndex = 45;
            this.hs2Unit.Text = "mm";
            // 
            // DAUUnit
            // 
            this.DAUUnit.AutoSize = true;
            this.DAUUnit.Location = new System.Drawing.Point(237, 81);
            this.DAUUnit.Name = "DAUUnit";
            this.DAUUnit.Size = new System.Drawing.Size(17, 12);
            this.DAUUnit.TabIndex = 45;
            this.DAUUnit.Text = "mm";
            // 
            // dhasUnitLabel
            // 
            this.dhasUnitLabel.AutoSize = true;
            this.dhasUnitLabel.Location = new System.Drawing.Point(237, 54);
            this.dhasUnitLabel.Name = "dhasUnitLabel";
            this.dhasUnitLabel.Size = new System.Drawing.Size(17, 12);
            this.dhasUnitLabel.TabIndex = 45;
            this.dhasUnitLabel.Text = "mm";
            // 
            // Rz
            // 
            this.Rz.Location = new System.Drawing.Point(154, 287);
            this.Rz.Name = "Rz";
            this.Rz.Size = new System.Drawing.Size(76, 21);
            this.Rz.TabIndex = 44;
            this.Rz.Text = "16";
            // 
            // CounterBoreDepth
            // 
            this.CounterBoreDepth.Location = new System.Drawing.Point(154, 252);
            this.CounterBoreDepth.Name = "CounterBoreDepth";
            this.CounterBoreDepth.ReadOnly = true;
            this.CounterBoreDepth.Size = new System.Drawing.Size(76, 21);
            this.CounterBoreDepth.TabIndex = 44;
            // 
            // dha
            // 
            this.dha.Location = new System.Drawing.Point(154, 177);
            this.dha.Name = "dha";
            this.dha.ReadOnly = true;
            this.dha.Size = new System.Drawing.Size(76, 21);
            this.dha.TabIndex = 44;
            // 
            // hs2
            // 
            this.hs2.Location = new System.Drawing.Point(154, 104);
            this.hs2.Name = "hs2";
            this.hs2.ReadOnly = true;
            this.hs2.Size = new System.Drawing.Size(76, 21);
            this.hs2.TabIndex = 44;
            // 
            // surfaceRoughnessLabel
            // 
            this.surfaceRoughnessLabel.AutoSize = true;
            this.surfaceRoughnessLabel.Location = new System.Drawing.Point(60, 293);
            this.surfaceRoughnessLabel.Name = "surfaceRoughnessLabel";
            this.surfaceRoughnessLabel.Size = new System.Drawing.Size(29, 12);
            this.surfaceRoughnessLabel.TabIndex = 0;
            this.surfaceRoughnessLabel.Text = "Rz：";
            // 
            // CounterBoreDepthLabel
            // 
            this.CounterBoreDepthLabel.AutoSize = true;
            this.CounterBoreDepthLabel.Location = new System.Drawing.Point(60, 258);
            this.CounterBoreDepthLabel.Name = "CounterBoreDepthLabel";
            this.CounterBoreDepthLabel.Size = new System.Drawing.Size(23, 12);
            this.CounterBoreDepthLabel.TabIndex = 0;
            this.CounterBoreDepthLabel.Text = "ts:";
            // 
            // dhaLabel
            // 
            this.dhaLabel.AutoSize = true;
            this.dhaLabel.Location = new System.Drawing.Point(18, 182);
            this.dhaLabel.Name = "dhaLabel";
            this.dhaLabel.Size = new System.Drawing.Size(101, 12);
            this.dhaLabel.TabIndex = 0;
            this.dhaLabel.Text = "镗孔倒角直径dha:";
            // 
            // dau
            // 
            this.dau.Location = new System.Drawing.Point(154, 76);
            this.dau.Name = "dau";
            this.dau.ReadOnly = true;
            this.dau.Size = new System.Drawing.Size(76, 21);
            this.dau.TabIndex = 44;
            // 
            // hs2Label
            // 
            this.hs2Label.AutoSize = true;
            this.hs2Label.Location = new System.Drawing.Point(60, 110);
            this.hs2Label.Name = "hs2Label";
            this.hs2Label.Size = new System.Drawing.Size(59, 12);
            this.hs2Label.TabIndex = 0;
            this.hs2Label.Text = "厚度hs2：";
            // 
            // dhas
            // 
            this.dhas.Location = new System.Drawing.Point(154, 49);
            this.dhas.Name = "dhas";
            this.dhas.ReadOnly = true;
            this.dhas.Size = new System.Drawing.Size(76, 21);
            this.dhas.TabIndex = 44;
            // 
            // DAULabel
            // 
            this.DAULabel.AutoSize = true;
            this.DAULabel.Location = new System.Drawing.Point(60, 82);
            this.DAULabel.Name = "DAULabel";
            this.DAULabel.Size = new System.Drawing.Size(53, 12);
            this.DAULabel.TabIndex = 0;
            this.DAULabel.Text = "外径DAU:";
            // 
            // isCounterBore
            // 
            this.isCounterBore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isCounterBore.FormattingEnabled = true;
            this.isCounterBore.Items.AddRange(new object[] {
            "不考虑",
            "考虑"});
            this.isCounterBore.Location = new System.Drawing.Point(138, 218);
            this.isCounterBore.Margin = new System.Windows.Forms.Padding(2);
            this.isCounterBore.Name = "isCounterBore";
            this.isCounterBore.Size = new System.Drawing.Size(92, 20);
            this.isCounterBore.TabIndex = 43;
            this.isCounterBore.SelectedIndexChanged += new System.EventHandler(this.isCounterBore_SelectedIndexChanged);
            // 
            // isAngle
            // 
            this.isAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isAngle.FormattingEnabled = true;
            this.isAngle.Items.AddRange(new object[] {
            "不考虑",
            "考虑"});
            this.isAngle.Location = new System.Drawing.Point(138, 143);
            this.isAngle.Margin = new System.Windows.Forms.Padding(2);
            this.isAngle.Name = "isAngle";
            this.isAngle.Size = new System.Drawing.Size(92, 20);
            this.isAngle.TabIndex = 43;
            this.isAngle.SelectedIndexChanged += new System.EventHandler(this.isAngle_SelectedIndexChanged);
            // 
            // isCounterBoreLabel
            // 
            this.isCounterBoreLabel.AutoSize = true;
            this.isCounterBoreLabel.Location = new System.Drawing.Point(6, 221);
            this.isCounterBoreLabel.Name = "isCounterBoreLabel";
            this.isCounterBoreLabel.Size = new System.Drawing.Size(113, 12);
            this.isCounterBoreLabel.TabIndex = 0;
            this.isCounterBoreLabel.Text = "考虑螺纹沉孔深度：";
            // 
            // isAngleLabel
            // 
            this.isAngleLabel.AutoSize = true;
            this.isAngleLabel.Location = new System.Drawing.Point(6, 145);
            this.isAngleLabel.Name = "isAngleLabel";
            this.isAngleLabel.Size = new System.Drawing.Size(89, 12);
            this.isAngleLabel.TabIndex = 0;
            this.isAngleLabel.Text = "考虑镗孔倒角：";
            // 
            // dhasLabel
            // 
            this.dhasLabel.AutoSize = true;
            this.dhasLabel.Location = new System.Drawing.Point(60, 55);
            this.dhasLabel.Name = "dhasLabel";
            this.dhasLabel.Size = new System.Drawing.Size(65, 12);
            this.dhasLabel.TabIndex = 0;
            this.dhasLabel.Text = "内径dhas：";
            // 
            // nutGroup
            // 
            this.nutGroup.Controls.Add(this.mUnit);
            this.nutGroup.Controls.Add(this.DwUnit);
            this.nutGroup.Controls.Add(this.DazUnit);
            this.nutGroup.Controls.Add(this.m);
            this.nutGroup.Controls.Add(this.Dw);
            this.nutGroup.Controls.Add(this.mLabel);
            this.nutGroup.Controls.Add(this.Daz);
            this.nutGroup.Controls.Add(this.DwLabel);
            this.nutGroup.Controls.Add(this.DaLabel);
            this.nutGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.nutGroup.Location = new System.Drawing.Point(0, 0);
            this.nutGroup.Name = "nutGroup";
            this.nutGroup.Size = new System.Drawing.Size(393, 146);
            this.nutGroup.TabIndex = 46;
            this.nutGroup.TabStop = false;
            this.nutGroup.Text = "螺母";
            this.nutGroup.Visible = false;
            // 
            // mUnit
            // 
            this.mUnit.AutoSize = true;
            this.mUnit.Location = new System.Drawing.Point(223, 82);
            this.mUnit.Name = "mUnit";
            this.mUnit.Size = new System.Drawing.Size(17, 12);
            this.mUnit.TabIndex = 52;
            this.mUnit.Text = "mm";
            // 
            // DwUnit
            // 
            this.DwUnit.AutoSize = true;
            this.DwUnit.Location = new System.Drawing.Point(223, 54);
            this.DwUnit.Name = "DwUnit";
            this.DwUnit.Size = new System.Drawing.Size(17, 12);
            this.DwUnit.TabIndex = 53;
            this.DwUnit.Text = "mm";
            // 
            // DazUnit
            // 
            this.DazUnit.AutoSize = true;
            this.DazUnit.Location = new System.Drawing.Point(223, 27);
            this.DazUnit.Name = "DazUnit";
            this.DazUnit.Size = new System.Drawing.Size(17, 12);
            this.DazUnit.TabIndex = 54;
            this.DazUnit.Text = "mm";
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(140, 77);
            this.m.Name = "m";
            this.m.ReadOnly = true;
            this.m.Size = new System.Drawing.Size(76, 21);
            this.m.TabIndex = 49;
            // 
            // Dw
            // 
            this.Dw.Location = new System.Drawing.Point(140, 49);
            this.Dw.Name = "Dw";
            this.Dw.ReadOnly = true;
            this.Dw.Size = new System.Drawing.Size(76, 21);
            this.Dw.TabIndex = 50;
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(6, 83);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(71, 12);
            this.mLabel.TabIndex = 46;
            this.mLabel.Text = "螺母厚度m：";
            // 
            // Daz
            // 
            this.Daz.Location = new System.Drawing.Point(140, 22);
            this.Daz.Name = "Daz";
            this.Daz.ReadOnly = true;
            this.Daz.Size = new System.Drawing.Size(76, 21);
            this.Daz.TabIndex = 51;
            // 
            // DwLabel
            // 
            this.DwLabel.AutoSize = true;
            this.DwLabel.Location = new System.Drawing.Point(6, 55);
            this.DwLabel.Name = "DwLabel";
            this.DwLabel.Size = new System.Drawing.Size(113, 12);
            this.DwLabel.TabIndex = 47;
            this.DwLabel.Text = "螺母承载面外径Dw：";
            // 
            // DaLabel
            // 
            this.DaLabel.AutoSize = true;
            this.DaLabel.Location = new System.Drawing.Point(6, 28);
            this.DaLabel.Name = "DaLabel";
            this.DaLabel.Size = new System.Drawing.Size(113, 12);
            this.DaLabel.TabIndex = 48;
            this.DaLabel.Text = "螺母承载面内径Da：";
            // 
            // splitLoadData
            // 
            this.splitLoadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLoadData.Location = new System.Drawing.Point(0, 0);
            this.splitLoadData.Name = "splitLoadData";
            this.splitLoadData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLoadData.Panel1
            // 
            this.splitLoadData.Panel1.AutoScroll = true;
            this.splitLoadData.Panel1.Controls.Add(this.loadDataGroup);
            // 
            // splitLoadData.Panel2
            // 
            this.splitLoadData.Panel2.AutoScroll = true;
            this.splitLoadData.Size = new System.Drawing.Size(414, 540);
            this.splitLoadData.SplitterDistance = 438;
            this.splitLoadData.TabIndex = 0;
            // 
            // loadDataGroup
            // 
            this.loadDataGroup.Controls.Add(this.ifZhouqiN);
            this.loadDataGroup.Controls.Add(this.fz);
            this.loadDataGroup.Controls.Add(this.fzlabel);
            this.loadDataGroup.Controls.Add(this.fzUnit);
            this.loadDataGroup.Controls.Add(this.akUnit);
            this.loadDataGroup.Controls.Add(this.lAUnit);
            this.loadDataGroup.Controls.Add(this.TpUnit);
            this.loadDataGroup.Controls.Add(this.TsUnit);
            this.loadDataGroup.Controls.Add(this.MBUnit);
            this.loadDataGroup.Controls.Add(this.aUnit);
            this.loadDataGroup.Controls.Add(this.FkerfUnit);
            this.loadDataGroup.Controls.Add(this.fauUnit);
            this.loadDataGroup.Controls.Add(this.FAOUnit);
            this.loadDataGroup.Controls.Add(this.zhouqiN);
            this.loadDataGroup.Controls.Add(this.Fmzul);
            this.loadDataGroup.Controls.Add(this.v);
            this.loadDataGroup.Controls.Add(this.Tp);
            this.loadDataGroup.Controls.Add(this.Ts);
            this.loadDataGroup.Controls.Add(this.UKmin);
            this.loadDataGroup.Controls.Add(this.UGmin);
            this.loadDataGroup.Controls.Add(this.ak);
            this.loadDataGroup.Controls.Add(this.lA);
            this.loadDataGroup.Controls.Add(this.n);
            this.loadDataGroup.Controls.Add(this.tightenCoef);
            this.loadDataGroup.Controls.Add(this.MB);
            this.loadDataGroup.Controls.Add(this.a);
            this.loadDataGroup.Controls.Add(this.Fkerf);
            this.loadDataGroup.Controls.Add(this.fau);
            this.loadDataGroup.Controls.Add(this.FAO);
            this.loadDataGroup.Controls.Add(this.tighten);
            this.loadDataGroup.Controls.Add(this.isFkerf);
            this.loadDataGroup.Controls.Add(this.zhazhi);
            this.loadDataGroup.Controls.Add(this.isFz);
            this.loadDataGroup.Controls.Add(this.isFORM);
            this.loadDataGroup.Controls.Add(this.zhazhiLabel);
            this.loadDataGroup.Controls.Add(this.label5);
            this.loadDataGroup.Controls.Add(this.sv);
            this.loadDataGroup.Controls.Add(this.isN);
            this.loadDataGroup.Controls.Add(this.workingLoads);
            this.loadDataGroup.Controls.Add(this.label4);
            this.loadDataGroup.Controls.Add(this.zhouqiNLabel);
            this.loadDataGroup.Controls.Add(this.label6);
            this.loadDataGroup.Controls.Add(this.vLabel);
            this.loadDataGroup.Controls.Add(this.TpLabel);
            this.loadDataGroup.Controls.Add(this.TsLabel);
            this.loadDataGroup.Controls.Add(this.UKminLabel);
            this.loadDataGroup.Controls.Add(this.UGminLabel);
            this.loadDataGroup.Controls.Add(this.akLabel);
            this.loadDataGroup.Controls.Add(this.lALabel);
            this.loadDataGroup.Controls.Add(this.svlabel);
            this.loadDataGroup.Controls.Add(this.nLabel);
            this.loadDataGroup.Controls.Add(this.tightenCoefLabel);
            this.loadDataGroup.Controls.Add(this.tightenLabel);
            this.loadDataGroup.Controls.Add(this.MBLabel);
            this.loadDataGroup.Controls.Add(this.aLabel);
            this.loadDataGroup.Controls.Add(this.FkerfLabel);
            this.loadDataGroup.Controls.Add(this.isFkerfLabel);
            this.loadDataGroup.Controls.Add(this.faulabel);
            this.loadDataGroup.Controls.Add(this.isNLabel);
            this.loadDataGroup.Controls.Add(this.FAOLabel);
            this.loadDataGroup.Controls.Add(this.workingLoadsLabel);
            this.loadDataGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadDataGroup.Location = new System.Drawing.Point(0, 0);
            this.loadDataGroup.Name = "loadDataGroup";
            this.loadDataGroup.Size = new System.Drawing.Size(397, 989);
            this.loadDataGroup.TabIndex = 1;
            this.loadDataGroup.TabStop = false;
            this.loadDataGroup.Text = "加载数据";
            // 
            // ifZhouqiN
            // 
            this.ifZhouqiN.AutoSize = true;
            this.ifZhouqiN.Location = new System.Drawing.Point(11, 856);
            this.ifZhouqiN.Name = "ifZhouqiN";
            this.ifZhouqiN.Size = new System.Drawing.Size(168, 16);
            this.ifZhouqiN.TabIndex = 61;
            this.ifZhouqiN.Text = "疲劳强度范围内交变应力：";
            this.ifZhouqiN.UseVisualStyleBackColor = true;
            this.ifZhouqiN.CheckedChanged += new System.EventHandler(this.ifZhouqiN_CheckedChanged);
            // 
            // fz
            // 
            this.fz.Location = new System.Drawing.Point(193, 792);
            this.fz.Name = "fz";
            this.fz.ReadOnly = true;
            this.fz.Size = new System.Drawing.Size(76, 21);
            this.fz.TabIndex = 60;
            this.fz.Text = "0.008";
            // 
            // fzlabel
            // 
            this.fzlabel.AutoSize = true;
            this.fzlabel.Location = new System.Drawing.Point(6, 796);
            this.fzlabel.Name = "fzlabel";
            this.fzlabel.Size = new System.Drawing.Size(77, 12);
            this.fzlabel.TabIndex = 59;
            this.fzlabel.Text = "啮合长度fz：";
            // 
            // fzUnit
            // 
            this.fzUnit.AutoSize = true;
            this.fzUnit.Location = new System.Drawing.Point(274, 796);
            this.fzUnit.Name = "fzUnit";
            this.fzUnit.Size = new System.Drawing.Size(17, 12);
            this.fzUnit.TabIndex = 58;
            this.fzUnit.Text = "mm";
            // 
            // akUnit
            // 
            this.akUnit.AutoSize = true;
            this.akUnit.Location = new System.Drawing.Point(275, 612);
            this.akUnit.Name = "akUnit";
            this.akUnit.Size = new System.Drawing.Size(17, 12);
            this.akUnit.TabIndex = 58;
            this.akUnit.Text = "mm";
            // 
            // lAUnit
            // 
            this.lAUnit.AutoSize = true;
            this.lAUnit.Location = new System.Drawing.Point(275, 584);
            this.lAUnit.Name = "lAUnit";
            this.lAUnit.Size = new System.Drawing.Size(17, 12);
            this.lAUnit.TabIndex = 58;
            this.lAUnit.Text = "mm";
            // 
            // TpUnit
            // 
            this.TpUnit.AutoSize = true;
            this.TpUnit.Location = new System.Drawing.Point(275, 464);
            this.TpUnit.Name = "TpUnit";
            this.TpUnit.Size = new System.Drawing.Size(23, 12);
            this.TpUnit.TabIndex = 58;
            this.TpUnit.Text = "°C";
            // 
            // TsUnit
            // 
            this.TsUnit.AutoSize = true;
            this.TsUnit.Location = new System.Drawing.Point(275, 430);
            this.TsUnit.Name = "TsUnit";
            this.TsUnit.Size = new System.Drawing.Size(23, 12);
            this.TsUnit.TabIndex = 58;
            this.TsUnit.Text = "°C";
            // 
            // MBUnit
            // 
            this.MBUnit.AutoSize = true;
            this.MBUnit.Location = new System.Drawing.Point(275, 244);
            this.MBUnit.Name = "MBUnit";
            this.MBUnit.Size = new System.Drawing.Size(29, 12);
            this.MBUnit.TabIndex = 58;
            this.MBUnit.Text = "N·M";
            // 
            // aUnit
            // 
            this.aUnit.AutoSize = true;
            this.aUnit.Location = new System.Drawing.Point(275, 130);
            this.aUnit.Name = "aUnit";
            this.aUnit.Size = new System.Drawing.Size(17, 12);
            this.aUnit.TabIndex = 58;
            this.aUnit.Text = "mm";
            // 
            // FkerfUnit
            // 
            this.FkerfUnit.AutoSize = true;
            this.FkerfUnit.Location = new System.Drawing.Point(275, 208);
            this.FkerfUnit.Name = "FkerfUnit";
            this.FkerfUnit.Size = new System.Drawing.Size(11, 12);
            this.FkerfUnit.TabIndex = 58;
            this.FkerfUnit.Text = "N";
            // 
            // fauUnit
            // 
            this.fauUnit.AutoSize = true;
            this.fauUnit.Location = new System.Drawing.Point(275, 90);
            this.fauUnit.Name = "fauUnit";
            this.fauUnit.Size = new System.Drawing.Size(11, 12);
            this.fauUnit.TabIndex = 58;
            this.fauUnit.Text = "N";
            // 
            // FAOUnit
            // 
            this.FAOUnit.AutoSize = true;
            this.FAOUnit.Location = new System.Drawing.Point(275, 58);
            this.FAOUnit.Name = "FAOUnit";
            this.FAOUnit.Size = new System.Drawing.Size(11, 12);
            this.FAOUnit.TabIndex = 58;
            this.FAOUnit.Text = "N";
            // 
            // zhouqiN
            // 
            this.zhouqiN.Enabled = false;
            this.zhouqiN.Location = new System.Drawing.Point(194, 875);
            this.zhouqiN.Name = "zhouqiN";
            this.zhouqiN.Size = new System.Drawing.Size(76, 21);
            this.zhouqiN.TabIndex = 57;
            // 
            // Fmzul
            // 
            this.Fmzul.Location = new System.Drawing.Point(194, 711);
            this.Fmzul.Name = "Fmzul";
            this.Fmzul.ReadOnly = true;
            this.Fmzul.Size = new System.Drawing.Size(76, 21);
            this.Fmzul.TabIndex = 57;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(194, 679);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(76, 21);
            this.v.TabIndex = 57;
            this.v.Text = "0.9";
            // 
            // Tp
            // 
            this.Tp.Location = new System.Drawing.Point(193, 460);
            this.Tp.Name = "Tp";
            this.Tp.Size = new System.Drawing.Size(76, 21);
            this.Tp.TabIndex = 57;
            this.Tp.Text = "20";
            // 
            // Ts
            // 
            this.Ts.Location = new System.Drawing.Point(193, 426);
            this.Ts.Name = "Ts";
            this.Ts.Size = new System.Drawing.Size(76, 21);
            this.Ts.TabIndex = 57;
            this.Ts.Text = "20";
            // 
            // UKmin
            // 
            this.UKmin.Location = new System.Drawing.Point(193, 391);
            this.UKmin.Name = "UKmin";
            this.UKmin.Size = new System.Drawing.Size(76, 21);
            this.UKmin.TabIndex = 57;
            this.UKmin.Text = "0.1";
            // 
            // UGmin
            // 
            this.UGmin.Location = new System.Drawing.Point(193, 354);
            this.UGmin.Name = "UGmin";
            this.UGmin.Size = new System.Drawing.Size(76, 21);
            this.UGmin.TabIndex = 57;
            this.UGmin.Text = "0.1";
            // 
            // ak
            // 
            this.ak.Location = new System.Drawing.Point(193, 607);
            this.ak.Name = "ak";
            this.ak.ReadOnly = true;
            this.ak.Size = new System.Drawing.Size(76, 21);
            this.ak.TabIndex = 57;
            // 
            // lA
            // 
            this.lA.Location = new System.Drawing.Point(193, 579);
            this.lA.Name = "lA";
            this.lA.ReadOnly = true;
            this.lA.Size = new System.Drawing.Size(76, 21);
            this.lA.TabIndex = 57;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(193, 520);
            this.n.Name = "n";
            this.n.ReadOnly = true;
            this.n.Size = new System.Drawing.Size(76, 21);
            this.n.TabIndex = 57;
            // 
            // tightenCoef
            // 
            this.tightenCoef.Location = new System.Drawing.Point(193, 323);
            this.tightenCoef.Name = "tightenCoef";
            this.tightenCoef.ReadOnly = true;
            this.tightenCoef.Size = new System.Drawing.Size(76, 21);
            this.tightenCoef.TabIndex = 57;
            // 
            // MB
            // 
            this.MB.Location = new System.Drawing.Point(193, 241);
            this.MB.Name = "MB";
            this.MB.Size = new System.Drawing.Size(76, 21);
            this.MB.TabIndex = 57;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(193, 128);
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Size = new System.Drawing.Size(76, 21);
            this.a.TabIndex = 57;
            // 
            // Fkerf
            // 
            this.Fkerf.Location = new System.Drawing.Point(193, 203);
            this.Fkerf.Name = "Fkerf";
            this.Fkerf.ReadOnly = true;
            this.Fkerf.Size = new System.Drawing.Size(76, 21);
            this.Fkerf.TabIndex = 57;
            // 
            // fau
            // 
            this.fau.Location = new System.Drawing.Point(193, 87);
            this.fau.Name = "fau";
            this.fau.ReadOnly = true;
            this.fau.Size = new System.Drawing.Size(76, 21);
            this.fau.TabIndex = 57;
            // 
            // FAO
            // 
            this.FAO.Location = new System.Drawing.Point(193, 55);
            this.FAO.Name = "FAO";
            this.FAO.Size = new System.Drawing.Size(76, 21);
            this.FAO.TabIndex = 57;
            this.FAO.Text = "24900";
            // 
            // tighten
            // 
            this.tighten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tighten.FormattingEnabled = true;
            this.tighten.Items.AddRange(new object[] {
            "自定义输入",
            "伸长量控制或超声波监测拧紧",
            "机械伸长量测量或监测拧紧",
            "液压无摩擦和无扭转拧紧",
            "液压脉冲发生器的脉冲驱动器、扭矩和或转角控制",
            "屈服点控制拧紧，电动或手动",
            "转角控制拧紧，电动或手动",
            "使用液压工具扭矩控制拧紧",
            "扭矩扳手、信号扳手或带动态扭矩测量的电动螺母扳手扭矩控制拧紧",
            "扭矩扳手、信号扳手或带动态扭矩测量的电动螺母扳手扭矩控制拧紧B",
            "扭矩扳手、信号扳手或带动态扭矩测量的电动螺母扳手扭矩控制拧紧A",
            "冲击扳手或脉冲扳手拧紧；用手拧紧"});
            this.tighten.Location = new System.Drawing.Point(193, 284);
            this.tighten.Margin = new System.Windows.Forms.Padding(2);
            this.tighten.Name = "tighten";
            this.tighten.Size = new System.Drawing.Size(152, 20);
            this.tighten.TabIndex = 45;
            this.tighten.SelectedIndexChanged += new System.EventHandler(this.tighten_SelectedIndexChanged);
            // 
            // isFkerf
            // 
            this.isFkerf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isFkerf.FormattingEnabled = true;
            this.isFkerf.Items.AddRange(new object[] {
            "选择",
            "不选择"});
            this.isFkerf.Location = new System.Drawing.Point(193, 162);
            this.isFkerf.Margin = new System.Windows.Forms.Padding(2);
            this.isFkerf.Name = "isFkerf";
            this.isFkerf.Size = new System.Drawing.Size(76, 20);
            this.isFkerf.TabIndex = 45;
            this.isFkerf.SelectedIndexChanged += new System.EventHandler(this.isFkerf_SelectedIndexChanged);
            // 
            // zhazhi
            // 
            this.zhazhi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zhazhi.FormattingEnabled = true;
            this.zhazhi.Items.AddRange(new object[] {
            "热处理前轧制",
            "热处理后轧制"});
            this.zhazhi.Location = new System.Drawing.Point(194, 827);
            this.zhazhi.Margin = new System.Windows.Forms.Padding(2);
            this.zhazhi.Name = "zhazhi";
            this.zhazhi.Size = new System.Drawing.Size(76, 20);
            this.zhazhi.TabIndex = 45;
            // 
            // isFz
            // 
            this.isFz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isFz.FormattingEnabled = true;
            this.isFz.Items.AddRange(new object[] {
            "是",
            "否"});
            this.isFz.Location = new System.Drawing.Point(193, 758);
            this.isFz.Margin = new System.Windows.Forms.Padding(2);
            this.isFz.Name = "isFz";
            this.isFz.Size = new System.Drawing.Size(76, 20);
            this.isFz.TabIndex = 45;
            this.isFz.SelectedIndexChanged += new System.EventHandler(this.isFz_SelectedIndexChanged);
            // 
            // isFORM
            // 
            this.isFORM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isFORM.FormattingEnabled = true;
            this.isFORM.Items.AddRange(new object[] {
            "不",
            "预定FMzul"});
            this.isFORM.Location = new System.Drawing.Point(193, 647);
            this.isFORM.Margin = new System.Windows.Forms.Padding(2);
            this.isFORM.Name = "isFORM";
            this.isFORM.Size = new System.Drawing.Size(76, 20);
            this.isFORM.TabIndex = 45;
            this.isFORM.SelectedIndexChanged += new System.EventHandler(this.isFORM_SelectedIndexChanged);
            // 
            // zhazhiLabel
            // 
            this.zhazhiLabel.AutoSize = true;
            this.zhazhiLabel.Location = new System.Drawing.Point(7, 823);
            this.zhazhiLabel.Name = "zhazhiLabel";
            this.zhazhiLabel.Size = new System.Drawing.Size(65, 12);
            this.zhazhiLabel.TabIndex = 44;
            this.zhazhiLabel.Text = "螺纹加工：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 754);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "确定未拧紧至屈服点下的\r\n最小有效啮合长度";
            // 
            // sv
            // 
            this.sv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sv.Enabled = false;
            this.sv.FormattingEnabled = true;
            this.sv.Items.AddRange(new object[] {
            "sv1",
            "sv2",
            "sv3",
            "sv4",
            "sv5",
            "sv6"});
            this.sv.Location = new System.Drawing.Point(193, 553);
            this.sv.Margin = new System.Windows.Forms.Padding(2);
            this.sv.Name = "sv";
            this.sv.Size = new System.Drawing.Size(76, 20);
            this.sv.TabIndex = 45;
            // 
            // isN
            // 
            this.isN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.isN.FormattingEnabled = true;
            this.isN.Items.AddRange(new object[] {
            "自定义",
            "默认"});
            this.isN.Location = new System.Drawing.Point(193, 490);
            this.isN.Margin = new System.Windows.Forms.Padding(2);
            this.isN.Name = "isN";
            this.isN.Size = new System.Drawing.Size(76, 20);
            this.isN.TabIndex = 45;
            this.isN.SelectedIndexChanged += new System.EventHandler(this.isN_SelectedIndexChanged);
            // 
            // workingLoads
            // 
            this.workingLoads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workingLoads.FormattingEnabled = true;
            this.workingLoads.Items.AddRange(new object[] {
            "静态",
            "动态"});
            this.workingLoads.Location = new System.Drawing.Point(76, 23);
            this.workingLoads.Margin = new System.Windows.Forms.Padding(2);
            this.workingLoads.Name = "workingLoads";
            this.workingLoads.Size = new System.Drawing.Size(92, 20);
            this.workingLoads.TabIndex = 45;
            this.workingLoads.SelectedIndexChanged += new System.EventHandler(this.workingLoads_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "预定在室温下允许的\r\n装配预紧力/必要的拧紧力矩：";
            // 
            // zhouqiNLabel
            // 
            this.zhouqiNLabel.AutoSize = true;
            this.zhouqiNLabel.Location = new System.Drawing.Point(12, 879);
            this.zhouqiNLabel.Name = "zhouqiNLabel";
            this.zhouqiNLabel.Size = new System.Drawing.Size(77, 12);
            this.zhouqiNLabel.TabIndex = 44;
            this.zhouqiNLabel.Text = "循环周期数N:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 715);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 12);
            this.label6.TabIndex = 44;
            this.label6.Text = "室温下允许的装配预紧力FMzul：";
            // 
            // vLabel
            // 
            this.vLabel.AutoSize = true;
            this.vLabel.Location = new System.Drawing.Point(7, 683);
            this.vLabel.Name = "vLabel";
            this.vLabel.Size = new System.Drawing.Size(167, 12);
            this.vLabel.TabIndex = 44;
            this.vLabel.Text = "拧紧时材料的屈服点利用率v：";
            // 
            // TpLabel
            // 
            this.TpLabel.AutoSize = true;
            this.TpLabel.Location = new System.Drawing.Point(6, 464);
            this.TpLabel.Name = "TpLabel";
            this.TpLabel.Size = new System.Drawing.Size(137, 12);
            this.TpLabel.TabIndex = 44;
            this.TpLabel.Text = "被连接件的工作温度Tp：";
            // 
            // TsLabel
            // 
            this.TsLabel.AutoSize = true;
            this.TsLabel.Location = new System.Drawing.Point(6, 430);
            this.TsLabel.Name = "TsLabel";
            this.TsLabel.Size = new System.Drawing.Size(113, 12);
            this.TsLabel.TabIndex = 44;
            this.TsLabel.Text = "螺栓的工作温度Ts：";
            // 
            // UKminLabel
            // 
            this.UKminLabel.AutoSize = true;
            this.UKminLabel.Location = new System.Drawing.Point(6, 395);
            this.UKminLabel.Name = "UKminLabel";
            this.UKminLabel.Size = new System.Drawing.Size(185, 12);
            this.UKminLabel.TabIndex = 44;
            this.UKminLabel.Text = "螺栓头接触面最小摩擦系数UKmin:";
            // 
            // UGminLabel
            // 
            this.UGminLabel.AutoSize = true;
            this.UGminLabel.Location = new System.Drawing.Point(6, 358);
            this.UGminLabel.Name = "UGminLabel";
            this.UGminLabel.Size = new System.Drawing.Size(173, 12);
            this.UGminLabel.TabIndex = 44;
            this.UGminLabel.Text = "螺纹接触面最小摩擦系数UGmin:";
            // 
            // akLabel
            // 
            this.akLabel.AutoSize = true;
            this.akLabel.Location = new System.Drawing.Point(6, 611);
            this.akLabel.Name = "akLabel";
            this.akLabel.Size = new System.Drawing.Size(173, 12);
            this.akLabel.TabIndex = 44;
            this.akLabel.Text = "预紧区和导入点之间的距离ak：";
            // 
            // lALabel
            // 
            this.lALabel.AutoSize = true;
            this.lALabel.Location = new System.Drawing.Point(6, 583);
            this.lALabel.Name = "lALabel";
            this.lALabel.Size = new System.Drawing.Size(173, 12);
            this.lALabel.TabIndex = 44;
            this.lALabel.Text = "连接件和导入点之间的长度lA：";
            // 
            // svlabel
            // 
            this.svlabel.AutoSize = true;
            this.svlabel.Location = new System.Drawing.Point(6, 556);
            this.svlabel.Name = "svlabel";
            this.svlabel.Size = new System.Drawing.Size(65, 12);
            this.svlabel.TabIndex = 44;
            this.svlabel.Text = "连接类型：";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(6, 525);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(95, 12);
            this.nLabel.TabIndex = 44;
            this.nLabel.Text = "载荷导入系数n：";
            // 
            // tightenCoefLabel
            // 
            this.tightenCoefLabel.AutoSize = true;
            this.tightenCoefLabel.Location = new System.Drawing.Point(6, 327);
            this.tightenCoefLabel.Name = "tightenCoefLabel";
            this.tightenCoefLabel.Size = new System.Drawing.Size(83, 12);
            this.tightenCoefLabel.TabIndex = 44;
            this.tightenCoefLabel.Text = "拧紧系数αA：";
            // 
            // tightenLabel
            // 
            this.tightenLabel.AutoSize = true;
            this.tightenLabel.Location = new System.Drawing.Point(6, 287);
            this.tightenLabel.Name = "tightenLabel";
            this.tightenLabel.Size = new System.Drawing.Size(65, 12);
            this.tightenLabel.TabIndex = 44;
            this.tightenLabel.Text = "拧紧工艺：";
            // 
            // MBLabel
            // 
            this.MBLabel.AutoSize = true;
            this.MBLabel.Location = new System.Drawing.Point(6, 245);
            this.MBLabel.Name = "MBLabel";
            this.MBLabel.Size = new System.Drawing.Size(77, 12);
            this.MBLabel.TabIndex = 44;
            this.MBLabel.Text = "工作弯矩MB：";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(6, 131);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(59, 12);
            this.aLabel.TabIndex = 44;
            this.aLabel.Text = "偏心距a：";
            // 
            // FkerfLabel
            // 
            this.FkerfLabel.AutoSize = true;
            this.FkerfLabel.Location = new System.Drawing.Point(6, 207);
            this.FkerfLabel.Name = "FkerfLabel";
            this.FkerfLabel.Size = new System.Drawing.Size(107, 12);
            this.FkerfLabel.TabIndex = 44;
            this.FkerfLabel.Text = "最小夹紧力Fkerf：";
            // 
            // isFkerfLabel
            // 
            this.isFkerfLabel.AutoSize = true;
            this.isFkerfLabel.Location = new System.Drawing.Point(6, 166);
            this.isFkerfLabel.Name = "isFkerfLabel";
            this.isFkerfLabel.Size = new System.Drawing.Size(137, 12);
            this.isFkerfLabel.TabIndex = 44;
            this.isFkerfLabel.Text = "预定所需的最小夹紧力：";
            // 
            // faulabel
            // 
            this.faulabel.AutoSize = true;
            this.faulabel.Location = new System.Drawing.Point(6, 90);
            this.faulabel.Name = "faulabel";
            this.faulabel.Size = new System.Drawing.Size(131, 12);
            this.faulabel.TabIndex = 44;
            this.faulabel.Text = "轴向载荷的下限值FAU：";
            // 
            // isNLabel
            // 
            this.isNLabel.AutoSize = true;
            this.isNLabel.Location = new System.Drawing.Point(6, 496);
            this.isNLabel.Name = "isNLabel";
            this.isNLabel.Size = new System.Drawing.Size(113, 12);
            this.isNLabel.TabIndex = 44;
            this.isNLabel.Text = "预定载荷导入系数：";
            // 
            // FAOLabel
            // 
            this.FAOLabel.AutoSize = true;
            this.FAOLabel.Location = new System.Drawing.Point(6, 58);
            this.FAOLabel.Name = "FAOLabel";
            this.FAOLabel.Size = new System.Drawing.Size(131, 12);
            this.FAOLabel.TabIndex = 44;
            this.FAOLabel.Text = "轴向载荷的上限值FAO：";
            // 
            // workingLoadsLabel
            // 
            this.workingLoadsLabel.AutoSize = true;
            this.workingLoadsLabel.Location = new System.Drawing.Point(6, 26);
            this.workingLoadsLabel.Name = "workingLoadsLabel";
            this.workingLoadsLabel.Size = new System.Drawing.Size(65, 12);
            this.workingLoadsLabel.TabIndex = 44;
            this.workingLoadsLabel.Text = "工作载荷：";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.AutoScroll = true;
            this.splitContainer5.Panel1.Controls.Add(this.introGroup2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.introTable2);
            this.splitContainer5.Size = new System.Drawing.Size(1160, 164);
            this.splitContainer5.SplitterDistance = 485;
            this.splitContainer5.TabIndex = 1;
            // 
            // introGroup2
            // 
            this.introGroup2.Controls.Add(this.label7);
            this.introGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introGroup2.Location = new System.Drawing.Point(0, 0);
            this.introGroup2.Name = "introGroup2";
            this.introGroup2.Size = new System.Drawing.Size(485, 164);
            this.introGroup2.TabIndex = 3;
            this.introGroup2.TabStop = false;
            this.introGroup2.Text = "说明";
            this.introGroup2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "：\r\n";
            // 
            // introTable2
            // 
            this.introTable2.Controls.Add(this.tabPage1);
            this.introTable2.Controls.Add(this.tabPage2);
            this.introTable2.Controls.Add(this.tabPage3);
            this.introTable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introTable2.Location = new System.Drawing.Point(0, 0);
            this.introTable2.Name = "introTable2";
            this.introTable2.SelectedIndex = 0;
            this.introTable2.Size = new System.Drawing.Size(671, 164);
            this.introTable2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "载荷传导系数";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(663, 138);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "sv样式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.meffd;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(663, 138);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "相对啮合长度";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resultData
            // 
            this.resultData.Controls.Add(this.splitContainer6);
            this.resultData.Location = new System.Drawing.Point(4, 22);
            this.resultData.Name = "resultData";
            this.resultData.Padding = new System.Windows.Forms.Padding(3);
            this.resultData.Size = new System.Drawing.Size(1166, 716);
            this.resultData.TabIndex = 2;
            this.resultData.Text = "计算结果";
            this.resultData.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.resGrid);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.lineChart);
            this.splitContainer6.Size = new System.Drawing.Size(1160, 710);
            this.splitContainer6.SplitterDistance = 563;
            this.splitContainer6.TabIndex = 0;
            // 
            // resGrid
            // 
            this.resGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resGrid.Location = new System.Drawing.Point(0, 0);
            this.resGrid.Name = "resGrid";
            this.resGrid.Size = new System.Drawing.Size(563, 710);
            this.resGrid.TabIndex = 1;
            // 
            // lineChart
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea1);
            this.lineChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.lineChart.Legends.Add(legend1);
            this.lineChart.Location = new System.Drawing.Point(0, 0);
            this.lineChart.Name = "lineChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.lineChart.Series.Add(series1);
            this.lineChart.Size = new System.Drawing.Size(593, 710);
            this.lineChart.TabIndex = 1;
            this.lineChart.Text = "chart1";
            // 
            // report
            // 
            this.report.Controls.Add(this.webBrowser1);
            this.report.Location = new System.Drawing.Point(4, 22);
            this.report.Name = "report";
            this.report.Padding = new System.Windows.Forms.Padding(3);
            this.report.Size = new System.Drawing.Size(1166, 716);
            this.report.TabIndex = 3;
            this.report.Text = "报告";
            this.report.UseVisualStyleBackColor = true;
            // 
            // materialClampedBindingSource1
            // 
            this.materialClampedBindingSource1.DataMember = "materialClamped";
            this.materialClampedBindingSource1.DataSource = this.boltConnectionSystemDataSet9;
            // 
            // boltConnectionSystemDataSet9
            // 
            this.boltConnectionSystemDataSet9.DataSetName = "BoltConnectionSystemDataSet9";
            this.boltConnectionSystemDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialClampedTableAdapter
            // 
            this.materialClampedTableAdapter.ClearBeforeFill = true;
            // 
            // dbo_materialClampedTableAdapter
            // 
            this.dbo_materialClampedTableAdapter.ClearBeforeFill = true;
            // 
            // materialClampedBindingSource
            // 
            this.materialClampedBindingSource.DataMember = "materialClamped";
            // 
            // dbo_materialClampedTableAdapter1
            // 
            this.dbo_materialClampedTableAdapter1.ClearBeforeFill = true;
            // 
            // ValidateDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 767);
            this.Controls.Add(this.DataInputTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ValidateDesignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValidateDesignForm";
            this.Load += new System.EventHandler(this.ValidateDesignForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.DataInputTable.ResumeLayout(false);
            this.basicData.ResumeLayout(false);
            this.splitUpDown.Panel1.ResumeLayout(false);
            this.splitUpDown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitUpDown)).EndInit();
            this.splitUpDown.ResumeLayout(false);
            this.splitData.Panel1.ResumeLayout(false);
            this.splitData.Panel2.ResumeLayout(false);
            this.splitData.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitData)).EndInit();
            this.splitData.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel1.PerformLayout();
            this.splitLeft.Panel2.ResumeLayout(false);
            this.splitLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            this.pianxinGroup.ResumeLayout(false);
            this.pianxinGroup.PerformLayout();
            this.splitBasic.Panel1.ResumeLayout(false);
            this.splitBasic.Panel1.PerformLayout();
            this.splitBasic.Panel2.ResumeLayout(false);
            this.splitBasic.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBasic)).EndInit();
            this.splitBasic.ResumeLayout(false);
            this.FtauGroup.ResumeLayout(false);
            this.FtauGroup.PerformLayout();
            this.basicGroup.ResumeLayout(false);
            this.basicGroup.PerformLayout();
            this.phiDimGroup.ResumeLayout(false);
            this.phiDimGroup.PerformLayout();
            this.BoltGroup.ResumeLayout(false);
            this.BoltGroup.PerformLayout();
            this.modeAndOpt.Panel1.ResumeLayout(false);
            this.modeAndOpt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modeAndOpt)).EndInit();
            this.modeAndOpt.ResumeLayout(false);
            this.modelControlBox.ResumeLayout(false);
            this.modelControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulation1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.introGroup.ResumeLayout(false);
            this.introGroup.PerformLayout();
            this.tableTab.ResumeLayout(false);
            this.connAndLoadData.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitConn.Panel1.ResumeLayout(false);
            this.splitConn.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitConn)).EndInit();
            this.splitConn.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataClampedChoosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClamped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbomaterialClampedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.splitGasketNut.Panel1.ResumeLayout(false);
            this.splitGasketNut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGasketNut)).EndInit();
            this.splitGasketNut.ResumeLayout(false);
            this.gasketGroup.ResumeLayout(false);
            this.gasketGroup.PerformLayout();
            this.gasketMaterialGroup.ResumeLayout(false);
            this.gasketMaterialGroup.PerformLayout();
            this.nutGroup.ResumeLayout(false);
            this.nutGroup.PerformLayout();
            this.splitLoadData.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLoadData)).EndInit();
            this.splitLoadData.ResumeLayout(false);
            this.loadDataGroup.ResumeLayout(false);
            this.loadDataGroup.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.introGroup2.ResumeLayout(false);
            this.introGroup2.PerformLayout();
            this.introTable2.ResumeLayout(false);
            this.resultData.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialClampedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialClampedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem computeBtn;
        private System.Windows.Forms.ToolStripMenuItem clearBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl DataInputTable;
        private System.Windows.Forms.TabPage basicData;
        private System.Windows.Forms.SplitContainer splitUpDown;
        private System.Windows.Forms.SplitContainer splitData;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.SplitContainer splitBasic;
        private System.Windows.Forms.GroupBox basicGroup;
        private System.Windows.Forms.Label ClampingWayLabel;
        private System.Windows.Forms.Label BoltConnectTypeLabel;
        private System.Windows.Forms.ComboBox clampingWay;
        private System.Windows.Forms.ComboBox BoltConnectType;
        private System.Windows.Forms.ComboBox boltConnectLoad;
        private System.Windows.Forms.Label boltConnectLoadLabel;
        private System.Windows.Forms.TabPage connAndLoadData;
        private System.Windows.Forms.Label Mode3D;
        private System.Windows.Forms.BindingSource materialClampedBindingSource;
        private System.Windows.Forms.GroupBox phiDimGroup;
        private System.Windows.Forms.Label JointFaceEquOutDiameterLabel;
        private System.Windows.Forms.TextBox DA2;
        public System.Windows.Forms.WebBrowser webBrowser1;

        private System.Windows.Forms.Label DA2Label;
        private System.Windows.Forms.Label JointFaceUpEquOutDiameterLabel;
        private System.Windows.Forms.Label UpperLimitAxialLoadDisplay;
        private System.Windows.Forms.TextBox DA;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tableTab;
        private System.Windows.Forms.TabPage getNTable;
        private System.Windows.Forms.TabPage svTable;
        private System.Windows.Forms.GroupBox introGroup;
        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.TabPage resultData;
        private BoltConnectionSystemDataSet9 boltConnectionSystemDataSet9;
        private System.Windows.Forms.BindingSource materialClampedBindingSource1;
        private BoltConnectionSystemDataSet9TableAdapters.materialClampedTableAdapter materialClampedTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem saveTempData;
        private System.Windows.Forms.ToolStripMenuItem readTempData;
        private System.Windows.Forms.TabPage meffd;
        private System.Windows.Forms.Label ifPreDtLabel;
        private System.Windows.Forms.ComboBox ifDt;
        private System.Windows.Forms.TextBox dtau;
        private System.Windows.Forms.Label dtauUnit;
        private System.Windows.Forms.Label dtauLabel;
        private System.Windows.Forms.GroupBox BoltGroup;
        private System.Windows.Forms.TextBox fBS;
        private System.Windows.Forms.TextBox Rm_kangla;
        private System.Windows.Forms.TextBox Rpmin_qufu;
        private System.Windows.Forms.TextBox beta;
        private System.Windows.Forms.TextBox Es_yangshi;
        private System.Windows.Forms.TextBox dt;
        private System.Windows.Forms.TextBox ScrewLengthls;
        private System.Windows.Forms.TextBox boringDh;
        private System.Windows.Forms.TextBox boltStd;
        private System.Windows.Forms.Button strengthGradeChooseBtn;
        private System.Windows.Forms.Button boltChooseBtn;
        private System.Windows.Forms.Label screwTypeLabel;
        private System.Windows.Forms.Label fBSLabel;
        private System.Windows.Forms.Label Rm_kanglaLabel;
        private System.Windows.Forms.ComboBox BoltType;
        private System.Windows.Forms.Label betaLabel;
        private System.Windows.Forms.Label Rpmin_qufuLabel;
        private System.Windows.Forms.Label dataSourceLabel;
        private System.Windows.Forms.Label Es_yangshiLabel;
        private System.Windows.Forms.Label dtLabel;
        private System.Windows.Forms.Label ScrewLengthLabel;
        private System.Windows.Forms.Label Rm_kanglaUnit;
        private System.Windows.Forms.Label Rpmin_qufuUnit;
        private System.Windows.Forms.Label EsUnit;
        private System.Windows.Forms.Label dtUnit;
        private System.Windows.Forms.Label betaUnit;
        private System.Windows.Forms.Label ScrewLengthUnit;
        private System.Windows.Forms.Label boringDhUnit;
        private System.Windows.Forms.Label boringDhLabel;
        private System.Windows.Forms.Label strengthGradeLabel;
        private System.Windows.Forms.Label boltStdLabel;
        private System.Windows.Forms.Label chooseBoltLabel;
        private System.Windows.Forms.Label BoltTypeLabel;
        private System.Windows.Forms.ComboBox screwType;
        private System.Windows.Forms.ComboBox dataSource;
        private System.Windows.Forms.TextBox Dhamax;
        private System.Windows.Forms.TextBox ra;
        private System.Windows.Forms.Label ifRaLabel;
        private System.Windows.Forms.Label DhamaxUnit;
        private System.Windows.Forms.Label raUnit;
        private System.Windows.Forms.ComboBox ifRa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label raLabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitConn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataClampedChoosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ES;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rmmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatioFG;
        private System.Windows.Forms.DataGridViewTextBoxColumn fBRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn hi;
        private System.Windows.Forms.DataGridView dataClamped;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMaterialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMatrialEpyangshiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMatrialRmminkanglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMatrialRatiofGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMaterialRatiofBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.SplitContainer splitGasketNut;
        private System.Windows.Forms.GroupBox gasketGroup;
        private System.Windows.Forms.Label surfaceRoughnessUnit;
        private System.Windows.Forms.Label CounterBoreDepthUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label hs2Unit;
        private System.Windows.Forms.Label DAUUnit;
        private System.Windows.Forms.Label dhasUnitLabel;
        private System.Windows.Forms.TextBox Rz;
        private System.Windows.Forms.TextBox CounterBoreDepth;
        private System.Windows.Forms.TextBox dha;
        private System.Windows.Forms.TextBox hs2;
        private System.Windows.Forms.Label surfaceRoughnessLabel;
        private System.Windows.Forms.Label CounterBoreDepthLabel;
        private System.Windows.Forms.Label dhaLabel;
        private System.Windows.Forms.TextBox dau;
        private System.Windows.Forms.Label hs2Label;
        private System.Windows.Forms.TextBox dhas;
        private System.Windows.Forms.Label DAULabel;
        private System.Windows.Forms.ComboBox isCounterBore;
        private System.Windows.Forms.ComboBox isAngle;
        private System.Windows.Forms.Label isCounterBoreLabel;
        private System.Windows.Forms.Label isAngleLabel;
        private System.Windows.Forms.Label dhasLabel;
        private System.Windows.Forms.GroupBox nutGroup;
        private System.Windows.Forms.Label mUnit;
        private System.Windows.Forms.Label DwUnit;
        private System.Windows.Forms.Label DazUnit;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.TextBox Dw;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.TextBox Daz;
        private System.Windows.Forms.Label DwLabel;
        private System.Windows.Forms.Label DaLabel;
        private System.Windows.Forms.SplitContainer splitLoadData;
        private System.Windows.Forms.GroupBox loadDataGroup;
        private System.Windows.Forms.TextBox fz;
        private System.Windows.Forms.Label fzlabel;
        private System.Windows.Forms.Label fzUnit;
        private System.Windows.Forms.Label akUnit;
        private System.Windows.Forms.Label lAUnit;
        private System.Windows.Forms.Label TpUnit;
        private System.Windows.Forms.Label TsUnit;
        private System.Windows.Forms.Label MBUnit;
        private System.Windows.Forms.Label aUnit;
        private System.Windows.Forms.Label FkerfUnit;
        private System.Windows.Forms.Label fauUnit;
        private System.Windows.Forms.Label FAOUnit;
        private System.Windows.Forms.TextBox Fmzul;
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.TextBox Tp;
        private System.Windows.Forms.TextBox Ts;
        private System.Windows.Forms.TextBox UKmin;
        private System.Windows.Forms.TextBox UGmin;
        private System.Windows.Forms.TextBox ak;
        private System.Windows.Forms.TextBox lA;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox tightenCoef;
        private System.Windows.Forms.TextBox MB;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox Fkerf;
        private System.Windows.Forms.TextBox fau;
        private System.Windows.Forms.TextBox FAO;
        private System.Windows.Forms.ComboBox tighten;
        private System.Windows.Forms.ComboBox isFkerf;
        private System.Windows.Forms.ComboBox isFz;
        private System.Windows.Forms.ComboBox isFORM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sv;
        private System.Windows.Forms.ComboBox isN;
        private System.Windows.Forms.ComboBox workingLoads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label vLabel;
        private System.Windows.Forms.Label TpLabel;
        private System.Windows.Forms.Label TsLabel;
        private System.Windows.Forms.Label UKminLabel;
        private System.Windows.Forms.Label UGminLabel;
        private System.Windows.Forms.Label akLabel;
        private System.Windows.Forms.Label lALabel;
        private System.Windows.Forms.Label svlabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.Label tightenCoefLabel;
        private System.Windows.Forms.Label tightenLabel;
        private System.Windows.Forms.Label MBLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label FkerfLabel;
        private System.Windows.Forms.Label isFkerfLabel;
        private System.Windows.Forms.Label faulabel;
        private System.Windows.Forms.Label isNLabel;
        private System.Windows.Forms.Label FAOLabel;
        private System.Windows.Forms.Label workingLoadsLabel;
        private System.Windows.Forms.TextBox Mt;
        private System.Windows.Forms.Label MtLabel;
        private System.Windows.Forms.Label MtUnit;
        private System.Windows.Forms.Label ifMtLabel;
        private System.Windows.Forms.ComboBox isMt;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.GroupBox introGroup2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl introTable2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.SplitContainer modeAndOpt;
        private System.Windows.Forms.GroupBox modelControlBox;
        private System.Windows.Forms.RadioButton shadedButton;
        private System.Windows.Forms.CheckBox animateCameraCheckBox;
        private System.Windows.Forms.Label shadingLabel;
        private System.Windows.Forms.Button topViewButton;
        private System.Windows.Forms.RadioButton wireframeButton;
        private System.Windows.Forms.Button sideViewButton;
        private System.Windows.Forms.RadioButton renderedButton;
        private System.Windows.Forms.Button frontViewButton;
        private System.Windows.Forms.RadioButton hiddenLinesButton;
        private System.Windows.Forms.Button isoViewButton;
        private System.Windows.Forms.RadioButton flatButton;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.CheckBox showOriginButton;
        private System.Windows.Forms.CheckBox showGridButton;
        private System.Windows.Forms.CheckBox showExtentsButton;
        private System.Windows.Forms.Label hideShowLabel;
        private System.Windows.Forms.CheckBox showVerticesButton;
        private devDept.Eyeshot.Model simulation1;
        private System.Windows.Forms.GroupBox gasketMaterialGroup;
        private System.Windows.Forms.Label fGUnit;
        private System.Windows.Forms.Label RmminSUnit;
        private System.Windows.Forms.Label EPSUnit;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox RmminS;
        private System.Windows.Forms.TextBox Es_gasket;
        private System.Windows.Forms.Button gasketMaterialChooseBtn;
        private System.Windows.Forms.Label fGLabel;
        private System.Windows.Forms.Label RmminSLabel;
        private System.Windows.Forms.Label EPSLabel;
        private System.Windows.Forms.CheckBox gasketChooseBtn;
        private BoltConnectionSystemDataSet18 boltConnectionSystemDataSet18;
        private System.Windows.Forms.BindingSource dbomaterialClampedBindingSource;
        private BoltConnectionSystemDataSet18TableAdapters.dbo_materialClampedTableAdapter dbo_materialClampedTableAdapter;
        private System.Windows.Forms.GroupBox pianxinGroup;
        private System.Windows.Forms.Label SsymLabel;
        private System.Windows.Forms.Label SsymUnit;
        private System.Windows.Forms.TextBox Ssym;
        private System.Windows.Forms.TextBox cT;
        private System.Windows.Forms.Label cTUnit;
        private System.Windows.Forms.Label cTLabel;
        private System.Windows.Forms.TextBox cB;
        private System.Windows.Forms.Label cBUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label bUnit;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label isIbtLabel;
        private System.Windows.Forms.TextBox e;
        private System.Windows.Forms.TextBox bT;
        private System.Windows.Forms.Label eUnit;
        private System.Windows.Forms.Label bTUnit;
        private System.Windows.Forms.ComboBox isIbt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bTLabel;
        private System.Windows.Forms.Label jiaZaiQingKuangLabel;
        private System.Windows.Forms.ComboBox jiaZaiQingKuang;
        private System.Windows.Forms.TextBox Ibt;
        private System.Windows.Forms.Label IbtUnit;
        private System.Windows.Forms.Label IbtLabel;
        private System.Windows.Forms.TextBox u;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ADLabel;
        private System.Windows.Forms.Label ADUnit;
        private System.Windows.Forms.TextBox AD;
        private System.Windows.Forms.TextBox pimax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label pimaxUnit;
        private System.Windows.Forms.ComboBox ifPimax;
        private System.Windows.Forms.Label pimaxLabel;
        private System.Windows.Forms.GroupBox FtauGroup;
        private System.Windows.Forms.ComboBox isSGsoll;
        private System.Windows.Forms.Label isSGsollLabel;
        private System.Windows.Forms.TextBox UTmin;
        private System.Windows.Forms.TextBox SGsoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UTminLabel;
        private System.Windows.Forms.TextBox FQ;
        private System.Windows.Forms.Label FQLabel;
        private System.Windows.Forms.Label FQUnit;
        private System.Windows.Forms.Label qFLabel;
        private System.Windows.Forms.ComboBox qF;
        private System.Windows.Forms.ComboBox qM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ifaLabel;
        private System.Windows.Forms.ComboBox ifa;
        private System.Windows.Forms.ComboBox zhazhi;
        private System.Windows.Forms.Label zhazhiLabel;
        private System.Windows.Forms.CheckBox ifZhouqiN;
        private System.Windows.Forms.TextBox zhouqiN;
        private System.Windows.Forms.Label zhouqiNLabel;
        private System.Windows.Forms.ToolStripMenuItem stepCalBtn;
        private System.Windows.Forms.ToolStripMenuItem CalFMmin;
        private System.Windows.Forms.ToolStripMenuItem CalFMmax;
        private System.Windows.Forms.ToolStripMenuItem CalFMzul;
        private System.Windows.Forms.ToolStripMenuItem CalFSmax;
        private System.Windows.Forms.ToolStripMenuItem CalSp;
        private System.Windows.Forms.ToolStripMenuItem CalMeff;
        private System.Windows.Forms.ToolStripMenuItem CalSg;
        private System.Windows.Forms.ToolStripMenuItem CalMa;
        private System.Windows.Forms.ToolStripMenuItem genWordBtn;
        private System.Windows.Forms.TabPage report;
        private BoltConnectionSystemDataSet19TableAdapters.dbo_materialClampedTableAdapter dbo_materialClampedTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.PropertyGrid resGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
    }
}