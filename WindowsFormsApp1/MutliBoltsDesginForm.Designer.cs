namespace WindowsFormsApp1
{
    partial class MutliBoltsDesginForm
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
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar1 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Red, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton1, false, 0.1D, true);
            devDept.Eyeshot.DisplayModeSettingsRendered displayModeSettingsRendered1 = new devDept.Eyeshot.DisplayModeSettingsRendered(true, devDept.Eyeshot.edgeColorMethodType.EntityColor, System.Drawing.Color.Black, 1F, 2F, devDept.Eyeshot.silhouettesDrawingType.LastFrame, false, devDept.Graphics.shadowType.Realistic, null, false, true, 0.3F, devDept.Graphics.realisticShadowQualityType.High);
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.Solid, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.DodgerBlue, System.Drawing.Color.WhiteSmoke, 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.3D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 0D), 617.10100716628347D, new devDept.Geometry.Quaternion(0.12940952255126034D, 0.22414386804201339D, 0.4829629131445341D, 0.83651630373780794D), devDept.Graphics.projectionType.Perspective, 50D, 2.0938273509698786D, false, 0.001D);
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
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-50D, -50D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Empty, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.DeepSkyBlue, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(794, 424), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.Legend legend1 = new devDept.Eyeshot.Legend(0D, 100D, "Title", "Subtitle", new System.Drawing.Point(24, 24), new System.Drawing.Size(10, 30), true, false, false, "{0:0.##}", System.Drawing.Color.Transparent, System.Drawing.Color.Black, System.Drawing.Color.Black, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(63)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(191))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(127))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(63))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))}, false, false);
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.simulation1 = new devDept.Eyeshot.Simulation();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flatButton = new System.Windows.Forms.RadioButton();
            this.renderedButton = new System.Windows.Forms.RadioButton();
            this.shadedButton = new System.Windows.Forms.RadioButton();
            this.wireframeButton = new System.Windows.Forms.RadioButton();
            this.hiddenLinesButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.isoViewButton = new System.Windows.Forms.Button();
            this.frontViewButton = new System.Windows.Forms.Button();
            this.sideViewButton = new System.Windows.Forms.Button();
            this.topViewButton = new System.Windows.Forms.Button();
            this.animateCameraCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.parallelButton = new System.Windows.Forms.RadioButton();
            this.showExtentsButton = new System.Windows.Forms.CheckBox();
            this.perspectiveButton = new System.Windows.Forms.RadioButton();
            this.showGridButton = new System.Windows.Forms.CheckBox();
            this.showVerticesButton = new System.Windows.Forms.CheckBox();
            this.showOriginButton = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.selectionComboBox = new System.Windows.Forms.ComboBox();
            this.groupButton = new System.Windows.Forms.Button();
            this.invertSelectionButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dumpButton = new System.Windows.Forms.Button();
            this.pickVertexButton = new System.Windows.Forms.CheckBox();
            this.pickFaceButton = new System.Windows.Forms.CheckBox();
            this.cullingButton = new System.Windows.Forms.CheckBox();
            this.volumeButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.showCurveDirectionButton = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this._moddelingParamResetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._twoStepsOpParamDataGridView = new System.Windows.Forms.DataGridView();
            this.PropeField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._modelingParamOkBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._resetBtn = new System.Windows.Forms.Button();
            this._assemblyBtn = new System.Windows.Forms.Button();
            this.createFlangeBtn = new System.Windows.Forms.Button();
            this.createNutBtn = new System.Windows.Forms.Button();
            this.createBoltBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.femPlotGroupBox = new System.Windows.Forms.GroupBox();
            this._firstBatchRenderBtn = new System.Windows.Forms.Button();
            this.plotTypeComboBox = new System.Windows.Forms.ComboBox();
            this.contourPlotCheckBox = new System.Windows.Forms.CheckBox();
            this.nodalAveragesCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this._stepsForceOpDataGridView = new System.Windows.Forms.DataGridView();
            this.BoltIdField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondBatchField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstBatchField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.femScalingGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.showJointCheckBox = new System.Windows.Forms.CheckBox();
            this.showVertexIndicesCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.showLoadCheckBox = new System.Windows.Forms.CheckBox();
            this.showRestraintsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulation1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._twoStepsOpParamDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.femPlotGroupBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._stepsForceOpDataGridView)).BeginInit();
            this.femScalingGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1372, 671);
            this.splitContainer1.SplitterDistance = 808;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(808, 671);
            this.splitContainer2.SplitterDistance = 456;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(808, 456);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.simulation1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(800, 430);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // simulation1
            // 
            this.simulation1.Cursor = System.Windows.Forms.Cursors.Default;
            this.simulation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simulation1.Location = new System.Drawing.Point(3, 3);
            this.simulation1.MinimumSize = new System.Drawing.Size(8, 8);
            this.simulation1.Name = "simulation1";
            this.simulation1.ProgressBar = progressBar1;
            this.simulation1.Rendered = displayModeSettingsRendered1;
            this.simulation1.Size = new System.Drawing.Size(794, 424);
            this.simulation1.TabIndex = 2;
            coordinateSystemIcon1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewport1.CoordinateSystemIcon = coordinateSystemIcon1;
            legend1.TextFont = null;
            legend1.TitleFont = null;
            viewport1.Legends = new devDept.Eyeshot.Legend[] {
        legend1};
            originSymbol1.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            viewport1.OriginSymbol = originSymbol1;
            viewCubeIcon1.Font = null;
            viewCubeIcon1.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport1.ViewCubeIcon = viewCubeIcon1;
            this.simulation1.Viewports.Add(viewport1);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(800, 430);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 211);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.propertyGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "对象属性";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CommandsForeColor = System.Drawing.SystemColors.ControlText;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(794, 179);
            this.propertyGrid1.TabIndex = 63;
            this.propertyGrid1.ToolbarVisible = false;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(560, 671);
            this.tabControl2.TabIndex = 131;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 645);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "视图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flatButton);
            this.groupBox1.Controls.Add(this.renderedButton);
            this.groupBox1.Controls.Add(this.shadedButton);
            this.groupBox1.Controls.Add(this.wireframeButton);
            this.groupBox1.Controls.Add(this.hiddenLinesButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 52);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "着色模式";
            // 
            // flatButton
            // 
            this.flatButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.flatButton.Location = new System.Drawing.Point(339, 20);
            this.flatButton.Name = "flatButton";
            this.flatButton.Size = new System.Drawing.Size(78, 22);
            this.flatButton.TabIndex = 122;
            this.flatButton.TabStop = true;
            this.flatButton.Text = "平铺";
            this.flatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.flatButton.UseVisualStyleBackColor = true;
            this.flatButton.CheckedChanged += new System.EventHandler(this.flatButton_CheckedChanged);
            // 
            // renderedButton
            // 
            this.renderedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renderedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.renderedButton.Location = new System.Drawing.Point(170, 20);
            this.renderedButton.Name = "renderedButton";
            this.renderedButton.Size = new System.Drawing.Size(78, 22);
            this.renderedButton.TabIndex = 4;
            this.renderedButton.Text = "渲染";
            this.renderedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.renderedButton.UseVisualStyleBackColor = true;
            this.renderedButton.CheckedChanged += new System.EventHandler(this.renderedButton_CheckedChanged);
            // 
            // shadedButton
            // 
            this.shadedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shadedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.shadedButton.Checked = true;
            this.shadedButton.Location = new System.Drawing.Point(88, 20);
            this.shadedButton.Name = "shadedButton";
            this.shadedButton.Size = new System.Drawing.Size(78, 22);
            this.shadedButton.TabIndex = 3;
            this.shadedButton.TabStop = true;
            this.shadedButton.Text = "着色";
            this.shadedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shadedButton.UseVisualStyleBackColor = true;
            this.shadedButton.CheckedChanged += new System.EventHandler(this.shadedButton_CheckedChanged);
            // 
            // wireframeButton
            // 
            this.wireframeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wireframeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.wireframeButton.Location = new System.Drawing.Point(6, 20);
            this.wireframeButton.Name = "wireframeButton";
            this.wireframeButton.Size = new System.Drawing.Size(78, 22);
            this.wireframeButton.TabIndex = 2;
            this.wireframeButton.Text = "框架";
            this.wireframeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wireframeButton.UseVisualStyleBackColor = true;
            this.wireframeButton.CheckedChanged += new System.EventHandler(this.wireframeButton_CheckedChanged);
            // 
            // hiddenLinesButton
            // 
            this.hiddenLinesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hiddenLinesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.hiddenLinesButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hiddenLinesButton.Location = new System.Drawing.Point(252, 20);
            this.hiddenLinesButton.Name = "hiddenLinesButton";
            this.hiddenLinesButton.Size = new System.Drawing.Size(78, 22);
            this.hiddenLinesButton.TabIndex = 81;
            this.hiddenLinesButton.Text = "隐藏线";
            this.hiddenLinesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hiddenLinesButton.UseVisualStyleBackColor = false;
            this.hiddenLinesButton.CheckedChanged += new System.EventHandler(this.hiddenLinesButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.isoViewButton);
            this.groupBox3.Controls.Add(this.frontViewButton);
            this.groupBox3.Controls.Add(this.sideViewButton);
            this.groupBox3.Controls.Add(this.topViewButton);
            this.groupBox3.Controls.Add(this.animateCameraCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(8, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 50);
            this.groupBox3.TabIndex = 125;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "视图";
            // 
            // isoViewButton
            // 
            this.isoViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isoViewButton.Location = new System.Drawing.Point(257, 20);
            this.isoViewButton.Name = "isoViewButton";
            this.isoViewButton.Size = new System.Drawing.Size(78, 22);
            this.isoViewButton.TabIndex = 115;
            this.isoViewButton.Text = "Iso";
            this.isoViewButton.UseVisualStyleBackColor = true;
            this.isoViewButton.Click += new System.EventHandler(this.isoViewButton_Click);
            // 
            // frontViewButton
            // 
            this.frontViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frontViewButton.Location = new System.Drawing.Point(11, 20);
            this.frontViewButton.Name = "frontViewButton";
            this.frontViewButton.Size = new System.Drawing.Size(78, 22);
            this.frontViewButton.TabIndex = 116;
            this.frontViewButton.Text = "正视";
            this.frontViewButton.UseVisualStyleBackColor = true;
            this.frontViewButton.Click += new System.EventHandler(this.frontViewButton_Click);
            // 
            // sideViewButton
            // 
            this.sideViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sideViewButton.Location = new System.Drawing.Point(93, 20);
            this.sideViewButton.Name = "sideViewButton";
            this.sideViewButton.Size = new System.Drawing.Size(78, 22);
            this.sideViewButton.TabIndex = 117;
            this.sideViewButton.Text = "右视";
            this.sideViewButton.UseVisualStyleBackColor = true;
            this.sideViewButton.Click += new System.EventHandler(this.sideViewButton_Click);
            // 
            // topViewButton
            // 
            this.topViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topViewButton.Location = new System.Drawing.Point(175, 20);
            this.topViewButton.Name = "topViewButton";
            this.topViewButton.Size = new System.Drawing.Size(78, 22);
            this.topViewButton.TabIndex = 118;
            this.topViewButton.Text = "俯视";
            this.topViewButton.UseVisualStyleBackColor = true;
            this.topViewButton.Click += new System.EventHandler(this.topViewButton_Click);
            // 
            // animateCameraCheckBox
            // 
            this.animateCameraCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.animateCameraCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.animateCameraCheckBox.Location = new System.Drawing.Point(339, 19);
            this.animateCameraCheckBox.Name = "animateCameraCheckBox";
            this.animateCameraCheckBox.Size = new System.Drawing.Size(78, 22);
            this.animateCameraCheckBox.TabIndex = 119;
            this.animateCameraCheckBox.Text = "Animate";
            this.animateCameraCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.animateCameraCheckBox.UseVisualStyleBackColor = true;
            this.animateCameraCheckBox.CheckedChanged += new System.EventHandler(this.animateCameraCheckBox_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.parallelButton);
            this.groupBox4.Controls.Add(this.showExtentsButton);
            this.groupBox4.Controls.Add(this.perspectiveButton);
            this.groupBox4.Controls.Add(this.showGridButton);
            this.groupBox4.Controls.Add(this.showVerticesButton);
            this.groupBox4.Controls.Add(this.showOriginButton);
            this.groupBox4.Location = new System.Drawing.Point(10, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 79);
            this.groupBox4.TabIndex = 126;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "隐藏/显示";
            // 
            // parallelButton
            // 
            this.parallelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parallelButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.parallelButton.Location = new System.Drawing.Point(9, 51);
            this.parallelButton.Name = "parallelButton";
            this.parallelButton.Size = new System.Drawing.Size(160, 22);
            this.parallelButton.TabIndex = 12;
            this.parallelButton.Text = "正交";
            this.parallelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parallelButton.UseVisualStyleBackColor = true;
            this.parallelButton.CheckedChanged += new System.EventHandler(this.parallelButton_CheckedChanged);
            // 
            // showExtentsButton
            // 
            this.showExtentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showExtentsButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showExtentsButton.Location = new System.Drawing.Point(91, 20);
            this.showExtentsButton.Name = "showExtentsButton";
            this.showExtentsButton.Size = new System.Drawing.Size(78, 22);
            this.showExtentsButton.TabIndex = 28;
            this.showExtentsButton.Text = "拓展";
            this.showExtentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showExtentsButton.UseVisualStyleBackColor = true;
            this.showExtentsButton.CheckedChanged += new System.EventHandler(this.showExtentsButton_CheckedChanged);
            // 
            // perspectiveButton
            // 
            this.perspectiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.perspectiveButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.perspectiveButton.Checked = true;
            this.perspectiveButton.Location = new System.Drawing.Point(174, 52);
            this.perspectiveButton.Name = "perspectiveButton";
            this.perspectiveButton.Size = new System.Drawing.Size(160, 22);
            this.perspectiveButton.TabIndex = 13;
            this.perspectiveButton.TabStop = true;
            this.perspectiveButton.Text = "透视";
            this.perspectiveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.perspectiveButton.UseVisualStyleBackColor = true;
            this.perspectiveButton.CheckedChanged += new System.EventHandler(this.perspectiveButton_CheckedChanged);
            // 
            // showGridButton
            // 
            this.showGridButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showGridButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showGridButton.Checked = true;
            this.showGridButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showGridButton.Location = new System.Drawing.Point(255, 20);
            this.showGridButton.Name = "showGridButton";
            this.showGridButton.Size = new System.Drawing.Size(78, 22);
            this.showGridButton.TabIndex = 79;
            this.showGridButton.Text = "网格";
            this.showGridButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showGridButton.UseVisualStyleBackColor = true;
            this.showGridButton.CheckedChanged += new System.EventHandler(this.showGridButton_CheckedChanged);
            // 
            // showVerticesButton
            // 
            this.showVerticesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showVerticesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showVerticesButton.Location = new System.Drawing.Point(173, 20);
            this.showVerticesButton.Name = "showVerticesButton";
            this.showVerticesButton.Size = new System.Drawing.Size(78, 22);
            this.showVerticesButton.TabIndex = 29;
            this.showVerticesButton.Text = "顶点";
            this.showVerticesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showVerticesButton.UseVisualStyleBackColor = true;
            this.showVerticesButton.CheckedChanged += new System.EventHandler(this.showVerticesButton_CheckedChanged);
            // 
            // showOriginButton
            // 
            this.showOriginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showOriginButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showOriginButton.Checked = true;
            this.showOriginButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOriginButton.Location = new System.Drawing.Point(9, 20);
            this.showOriginButton.Name = "showOriginButton";
            this.showOriginButton.Size = new System.Drawing.Size(78, 22);
            this.showOriginButton.TabIndex = 27;
            this.showOriginButton.Text = "原点";
            this.showOriginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showOriginButton.UseVisualStyleBackColor = true;
            this.showOriginButton.CheckedChanged += new System.EventHandler(this.showOriginButton_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.selectionComboBox);
            this.groupBox5.Controls.Add(this.groupButton);
            this.groupBox5.Controls.Add(this.invertSelectionButton);
            this.groupBox5.Controls.Add(this.clearSelectionButton);
            this.groupBox5.Controls.Add(this.selectButton);
            this.groupBox5.Location = new System.Drawing.Point(10, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(437, 79);
            this.groupBox5.TabIndex = 127;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "拾取";
            // 
            // selectionComboBox
            // 
            this.selectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionComboBox.Items.AddRange(new object[] {
            "By Pick",
            "By Box",
            "By Polygon",
            "By Box Enclosed",
            "By Polygon Enclosed",
            "Visible By Pick",
            "Visible By Box",
            "Visible By Polygon",
            "Visible By Pick Label"});
            this.selectionComboBox.Location = new System.Drawing.Point(6, 24);
            this.selectionComboBox.Name = "selectionComboBox";
            this.selectionComboBox.Size = new System.Drawing.Size(158, 20);
            this.selectionComboBox.TabIndex = 120;
            this.selectionComboBox.SelectedIndexChanged += new System.EventHandler(this.selectionComboBox_SelectedIndexChanged);
            // 
            // groupButton
            // 
            this.groupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupButton.Location = new System.Drawing.Point(6, 51);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(156, 22);
            this.groupButton.TabIndex = 104;
            this.groupButton.Text = "组";
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // invertSelectionButton
            // 
            this.invertSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.invertSelectionButton.Location = new System.Drawing.Point(169, 51);
            this.invertSelectionButton.Name = "invertSelectionButton";
            this.invertSelectionButton.Size = new System.Drawing.Size(160, 22);
            this.invertSelectionButton.TabIndex = 24;
            this.invertSelectionButton.Text = "反选";
            this.invertSelectionButton.UseVisualStyleBackColor = true;
            this.invertSelectionButton.Click += new System.EventHandler(this.invertSelectionButton_Click);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearSelectionButton.Location = new System.Drawing.Point(251, 23);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(78, 22);
            this.clearSelectionButton.TabIndex = 23;
            this.clearSelectionButton.Text = "清除";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.clearSelectionButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.selectButton.Location = new System.Drawing.Point(169, 23);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(78, 22);
            this.selectButton.TabIndex = 121;
            this.selectButton.Text = "选择";
            this.selectButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.CheckedChanged += new System.EventHandler(this.selectCheckBox_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dumpButton);
            this.groupBox6.Controls.Add(this.pickVertexButton);
            this.groupBox6.Controls.Add(this.pickFaceButton);
            this.groupBox6.Controls.Add(this.cullingButton);
            this.groupBox6.Controls.Add(this.volumeButton);
            this.groupBox6.Controls.Add(this.areaButton);
            this.groupBox6.Controls.Add(this.showCurveDirectionButton);
            this.groupBox6.Location = new System.Drawing.Point(10, 166);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(437, 79);
            this.groupBox6.TabIndex = 128;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "几何属性";
            // 
            // dumpButton
            // 
            this.dumpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dumpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dumpButton.Location = new System.Drawing.Point(337, 23);
            this.dumpButton.Name = "dumpButton";
            this.dumpButton.Size = new System.Drawing.Size(78, 22);
            this.dumpButton.TabIndex = 84;
            this.dumpButton.Text = "Dump";
            this.dumpButton.UseVisualStyleBackColor = false;
            this.dumpButton.Click += new System.EventHandler(this.dumpButton_Click);
            // 
            // pickVertexButton
            // 
            this.pickVertexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickVertexButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pickVertexButton.Location = new System.Drawing.Point(7, 23);
            this.pickVertexButton.Name = "pickVertexButton";
            this.pickVertexButton.Size = new System.Drawing.Size(78, 22);
            this.pickVertexButton.TabIndex = 76;
            this.pickVertexButton.Text = "顶点拾取";
            this.pickVertexButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pickVertexButton.UseVisualStyleBackColor = true;
            this.pickVertexButton.Click += new System.EventHandler(this.pickVertexButton_Click);
            // 
            // pickFaceButton
            // 
            this.pickFaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickFaceButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.pickFaceButton.Location = new System.Drawing.Point(89, 23);
            this.pickFaceButton.Name = "pickFaceButton";
            this.pickFaceButton.Size = new System.Drawing.Size(78, 22);
            this.pickFaceButton.TabIndex = 77;
            this.pickFaceButton.Text = "面拾取";
            this.pickFaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pickFaceButton.UseVisualStyleBackColor = true;
            this.pickFaceButton.Click += new System.EventHandler(this.pickFaceButton_Click);
            // 
            // cullingButton
            // 
            this.cullingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cullingButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.cullingButton.Location = new System.Drawing.Point(89, 51);
            this.cullingButton.Name = "cullingButton";
            this.cullingButton.Size = new System.Drawing.Size(78, 22);
            this.cullingButton.TabIndex = 6;
            this.cullingButton.Text = "Culling";
            this.cullingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cullingButton.UseVisualStyleBackColor = true;
            this.cullingButton.CheckedChanged += new System.EventHandler(this.cullingButton_CheckedChanged);
            // 
            // volumeButton
            // 
            this.volumeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeButton.Location = new System.Drawing.Point(253, 23);
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.Size = new System.Drawing.Size(78, 22);
            this.volumeButton.TabIndex = 103;
            this.volumeButton.Text = "体积";
            this.volumeButton.UseVisualStyleBackColor = true;
            this.volumeButton.Click += new System.EventHandler(this.volumeButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.areaButton.Location = new System.Drawing.Point(171, 23);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(78, 22);
            this.areaButton.TabIndex = 102;
            this.areaButton.Text = "面积";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // showCurveDirectionButton
            // 
            this.showCurveDirectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showCurveDirectionButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.showCurveDirectionButton.Location = new System.Drawing.Point(9, 51);
            this.showCurveDirectionButton.Name = "showCurveDirectionButton";
            this.showCurveDirectionButton.Size = new System.Drawing.Size(78, 22);
            this.showCurveDirectionButton.TabIndex = 94;
            this.showCurveDirectionButton.Text = "Show Dir.";
            this.showCurveDirectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showCurveDirectionButton.UseVisualStyleBackColor = true;
            this.showCurveDirectionButton.CheckedChanged += new System.EventHandler(this.showCurveDirectionButton_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 645);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "模型";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.49882F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.50118F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(546, 639);
            this.tableLayoutPanel4.TabIndex = 130;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel5);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 219);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(540, 178);
            this.groupBox8.TabIndex = 130;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "参数";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this._moddelingParamResetBtn, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this._modelingParamOkBtn, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(534, 158);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // _moddelingParamResetBtn
            // 
            this._moddelingParamResetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._moddelingParamResetBtn.Location = new System.Drawing.Point(270, 131);
            this._moddelingParamResetBtn.Name = "_moddelingParamResetBtn";
            this._moddelingParamResetBtn.Size = new System.Drawing.Size(261, 24);
            this._moddelingParamResetBtn.TabIndex = 4;
            this._moddelingParamResetBtn.Text = "整体网格划分及力的分布";
            this._moddelingParamResetBtn.UseVisualStyleBackColor = true;
            this._moddelingParamResetBtn.Click += new System.EventHandler(this._moddelingParamResetBtn_Click);
            // 
            // panel1
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this._twoStepsOpParamDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 122);
            this.panel1.TabIndex = 2;
            // 
            // _twoStepsOpParamDataGridView
            // 
            this._twoStepsOpParamDataGridView.AllowUserToAddRows = false;
            this._twoStepsOpParamDataGridView.AllowUserToDeleteRows = false;
            this._twoStepsOpParamDataGridView.AllowUserToResizeColumns = false;
            this._twoStepsOpParamDataGridView.AllowUserToResizeRows = false;
            this._twoStepsOpParamDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._twoStepsOpParamDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._twoStepsOpParamDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropeField,
            this.ValueField,
            this.DescField});
            this._twoStepsOpParamDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._twoStepsOpParamDataGridView.Location = new System.Drawing.Point(0, 0);
            this._twoStepsOpParamDataGridView.Name = "_twoStepsOpParamDataGridView";
            this._twoStepsOpParamDataGridView.RowTemplate.Height = 23;
            this._twoStepsOpParamDataGridView.Size = new System.Drawing.Size(528, 122);
            this._twoStepsOpParamDataGridView.TabIndex = 0;
            // 
            // PropeField
            // 
            this.PropeField.HeaderText = "属性或尺寸";
            this.PropeField.Name = "PropeField";
            // 
            // ValueField
            // 
            this.ValueField.HeaderText = "值";
            this.ValueField.Name = "ValueField";
            // 
            // DescField
            // 
            this.DescField.HeaderText = "备注";
            this.DescField.Name = "DescField";
            // 
            // _modelingParamOkBtn
            // 
            this._modelingParamOkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._modelingParamOkBtn.Enabled = false;
            this._modelingParamOkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this._modelingParamOkBtn.Location = new System.Drawing.Point(3, 131);
            this._modelingParamOkBtn.Name = "_modelingParamOkBtn";
            this._modelingParamOkBtn.Size = new System.Drawing.Size(261, 24);
            this._modelingParamOkBtn.TabIndex = 3;
            this._modelingParamOkBtn.Text = "连接件划分";
            this._modelingParamOkBtn.UseVisualStyleBackColor = true;
            this._modelingParamOkBtn.Click += new System.EventHandler(this._modelingParamOkBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._resetBtn);
            this.groupBox2.Controls.Add(this._assemblyBtn);
            this.groupBox2.Controls.Add(this.createFlangeBtn);
            this.groupBox2.Controls.Add(this.createNutBtn);
            this.groupBox2.Controls.Add(this.createBoltBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 202);
            this.groupBox2.TabIndex = 129;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模型";
            // 
            // _resetBtn
            // 
            this._resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._resetBtn.Location = new System.Drawing.Point(20, 161);
            this._resetBtn.Name = "_resetBtn";
            this._resetBtn.Size = new System.Drawing.Size(514, 35);
            this._resetBtn.TabIndex = 3;
            this._resetBtn.Text = "重置";
            this._resetBtn.UseVisualStyleBackColor = true;
            this._resetBtn.Click += new System.EventHandler(this._resetBtn_Click);
            // 
            // _assemblyBtn
            // 
            this._assemblyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._assemblyBtn.Location = new System.Drawing.Point(20, 124);
            this._assemblyBtn.Name = "_assemblyBtn";
            this._assemblyBtn.Size = new System.Drawing.Size(514, 35);
            this._assemblyBtn.TabIndex = 2;
            this._assemblyBtn.Text = "装配";
            this._assemblyBtn.UseVisualStyleBackColor = true;
            this._assemblyBtn.Click += new System.EventHandler(this._assemblyBtn_Click);
            // 
            // createFlangeBtn
            // 
            this.createFlangeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createFlangeBtn.Location = new System.Drawing.Point(20, 13);
            this.createFlangeBtn.Name = "createFlangeBtn";
            this.createFlangeBtn.Size = new System.Drawing.Size(514, 35);
            this.createFlangeBtn.TabIndex = 1;
            this.createFlangeBtn.Text = "创建连接件";
            this.createFlangeBtn.UseVisualStyleBackColor = true;
            this.createFlangeBtn.Click += new System.EventHandler(this.createFlangeBtn_Click_1);
            // 
            // createNutBtn
            // 
            this.createNutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createNutBtn.Location = new System.Drawing.Point(20, 86);
            this.createNutBtn.Name = "createNutBtn";
            this.createNutBtn.Size = new System.Drawing.Size(514, 35);
            this.createNutBtn.TabIndex = 0;
            this.createNutBtn.Text = "创建螺母";
            this.createNutBtn.UseVisualStyleBackColor = true;
            this.createNutBtn.Click += new System.EventHandler(this.createNutBtn_Click);
            // 
            // createBoltBtn
            // 
            this.createBoltBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBoltBtn.Location = new System.Drawing.Point(20, 50);
            this.createBoltBtn.Name = "createBoltBtn";
            this.createBoltBtn.Size = new System.Drawing.Size(514, 35);
            this.createBoltBtn.TabIndex = 0;
            this.createBoltBtn.Text = "创建螺栓";
            this.createBoltBtn.UseVisualStyleBackColor = true;
            this.createBoltBtn.Click += new System.EventHandler(this.createBoltBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(552, 645);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "分析";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.femPlotGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.femScalingGroupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 639);
            this.tableLayoutPanel1.TabIndex = 93;
            // 
            // femPlotGroupBox
            // 
            this.femPlotGroupBox.Controls.Add(this._firstBatchRenderBtn);
            this.femPlotGroupBox.Controls.Add(this.plotTypeComboBox);
            this.femPlotGroupBox.Controls.Add(this.contourPlotCheckBox);
            this.femPlotGroupBox.Controls.Add(this.nodalAveragesCheckBox);
            this.femPlotGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.femPlotGroupBox.Location = new System.Drawing.Point(3, 3);
            this.femPlotGroupBox.Name = "femPlotGroupBox";
            this.femPlotGroupBox.Size = new System.Drawing.Size(540, 94);
            this.femPlotGroupBox.TabIndex = 90;
            this.femPlotGroupBox.TabStop = false;
            this.femPlotGroupBox.Text = "有限元绘图形式";
            // 
            // _firstBatchRenderBtn
            // 
            this._firstBatchRenderBtn.Enabled = false;
            this._firstBatchRenderBtn.Location = new System.Drawing.Point(221, 20);
            this._firstBatchRenderBtn.Name = "_firstBatchRenderBtn";
            this._firstBatchRenderBtn.Size = new System.Drawing.Size(229, 28);
            this._firstBatchRenderBtn.TabIndex = 124;
            this._firstBatchRenderBtn.Text = "应力计算";
            this._firstBatchRenderBtn.UseVisualStyleBackColor = true;
            this._firstBatchRenderBtn.Click += new System.EventHandler(this._firstBatchRenderBtn_Click);
            // 
            // plotTypeComboBox
            // 
            this.plotTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plotTypeComboBox.FormattingEnabled = true;
            this.plotTypeComboBox.Items.AddRange(new object[] {
            "Mesh",
            "Displacement X",
            "Displacement Y",
            "Displacement Z",
            "Displacement Magnitude",
            "X Stress",
            "Y Stress",
            "Z Stress",
            "XY Shear",
            "YZ Shear",
            "XZ Shear",
            "Maximum Principal",
            "Intermediate Principal",
            "Minimum Principal",
            "Von Mises",
            "Tresca"});
            this.plotTypeComboBox.Location = new System.Drawing.Point(9, 18);
            this.plotTypeComboBox.Name = "plotTypeComboBox";
            this.plotTypeComboBox.Size = new System.Drawing.Size(170, 20);
            this.plotTypeComboBox.TabIndex = 86;
            this.plotTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.plotTypeComboBox_SelectedIndexChanged);
            // 
            // contourPlotCheckBox
            // 
            this.contourPlotCheckBox.AutoSize = true;
            this.contourPlotCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contourPlotCheckBox.Location = new System.Drawing.Point(9, 44);
            this.contourPlotCheckBox.Name = "contourPlotCheckBox";
            this.contourPlotCheckBox.Size = new System.Drawing.Size(60, 16);
            this.contourPlotCheckBox.TabIndex = 89;
            this.contourPlotCheckBox.Text = "轮廓线";
            this.contourPlotCheckBox.UseVisualStyleBackColor = true;
            this.contourPlotCheckBox.CheckedChanged += new System.EventHandler(this.contourPlotCheckBox_CheckedChanged);
            // 
            // nodalAveragesCheckBox
            // 
            this.nodalAveragesCheckBox.AutoSize = true;
            this.nodalAveragesCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nodalAveragesCheckBox.Location = new System.Drawing.Point(101, 46);
            this.nodalAveragesCheckBox.Name = "nodalAveragesCheckBox";
            this.nodalAveragesCheckBox.Size = new System.Drawing.Size(48, 16);
            this.nodalAveragesCheckBox.TabIndex = 88;
            this.nodalAveragesCheckBox.Text = "平均";
            this.nodalAveragesCheckBox.UseVisualStyleBackColor = true;
            this.nodalAveragesCheckBox.CheckedChanged += new System.EventHandler(this.nodalAveragesCheckBox_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this._stepsForceOpDataGridView);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 276);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(540, 360);
            this.groupBox7.TabIndex = 92;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "数据";
            // 
            // _stepsForceOpDataGridView
            // 
            this._stepsForceOpDataGridView.AllowUserToAddRows = false;
            this._stepsForceOpDataGridView.AllowUserToDeleteRows = false;
            this._stepsForceOpDataGridView.AllowUserToOrderColumns = true;
            this._stepsForceOpDataGridView.AllowUserToResizeColumns = false;
            this._stepsForceOpDataGridView.AllowUserToResizeRows = false;
            this._stepsForceOpDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._stepsForceOpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._stepsForceOpDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BoltIdField,
            this.SecondBatchField,
            this.FirstBatchField});
            this._stepsForceOpDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stepsForceOpDataGridView.Location = new System.Drawing.Point(3, 17);
            this._stepsForceOpDataGridView.Name = "_stepsForceOpDataGridView";
            this._stepsForceOpDataGridView.RowTemplate.Height = 23;
            this._stepsForceOpDataGridView.Size = new System.Drawing.Size(534, 340);
            this._stepsForceOpDataGridView.TabIndex = 0;
            // 
            // BoltIdField
            // 
            this.BoltIdField.HeaderText = "螺栓编号";
            this.BoltIdField.Name = "BoltIdField";
            // 
            // SecondBatchField
            // 
            this.SecondBatchField.HeaderText = "第二批次";
            this.SecondBatchField.Name = "SecondBatchField";
            // 
            // FirstBatchField
            // 
            this.FirstBatchField.HeaderText = "第一批次";
            this.FirstBatchField.Name = "FirstBatchField";
            // 
            // femScalingGroupBox
            // 
            this.femScalingGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.femScalingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.femScalingGroupBox.Location = new System.Drawing.Point(3, 103);
            this.femScalingGroupBox.Name = "femScalingGroupBox";
            this.femScalingGroupBox.Size = new System.Drawing.Size(540, 167);
            this.femScalingGroupBox.TabIndex = 91;
            this.femScalingGroupBox.TabStop = false;
            this.femScalingGroupBox.Text = "有限元控制";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 147);
            this.tableLayoutPanel2.TabIndex = 95;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.showJointCheckBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.showVertexIndicesCheckBox, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(528, 82);
            this.tableLayoutPanel3.TabIndex = 77;
            // 
            // showJointCheckBox
            // 
            this.showJointCheckBox.AutoSize = true;
            this.showJointCheckBox.Checked = true;
            this.showJointCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showJointCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showJointCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showJointCheckBox.Location = new System.Drawing.Point(3, 3);
            this.showJointCheckBox.Name = "showJointCheckBox";
            this.showJointCheckBox.Size = new System.Drawing.Size(258, 76);
            this.showJointCheckBox.TabIndex = 95;
            this.showJointCheckBox.Text = "Show joints";
            this.showJointCheckBox.UseVisualStyleBackColor = true;
            this.showJointCheckBox.CheckedChanged += new System.EventHandler(this.showJointCheckBox_CheckedChanged);
            // 
            // showVertexIndicesCheckBox
            // 
            this.showVertexIndicesCheckBox.AutoSize = true;
            this.showVertexIndicesCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showVertexIndicesCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showVertexIndicesCheckBox.Location = new System.Drawing.Point(267, 3);
            this.showVertexIndicesCheckBox.Name = "showVertexIndicesCheckBox";
            this.showVertexIndicesCheckBox.Size = new System.Drawing.Size(258, 76);
            this.showVertexIndicesCheckBox.TabIndex = 94;
            this.showVertexIndicesCheckBox.Text = "Show vertex indices";
            this.showVertexIndicesCheckBox.UseVisualStyleBackColor = true;
            this.showVertexIndicesCheckBox.CheckedChanged += new System.EventHandler(this.showVertexIndicesCheckBox_CheckedChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.showLoadCheckBox, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.showRestraintsCheckBox, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(528, 53);
            this.tableLayoutPanel6.TabIndex = 78;
            // 
            // showLoadCheckBox
            // 
            this.showLoadCheckBox.AutoSize = true;
            this.showLoadCheckBox.Checked = true;
            this.showLoadCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLoadCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showLoadCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showLoadCheckBox.Location = new System.Drawing.Point(267, 3);
            this.showLoadCheckBox.Name = "showLoadCheckBox";
            this.showLoadCheckBox.Size = new System.Drawing.Size(258, 47);
            this.showLoadCheckBox.TabIndex = 94;
            this.showLoadCheckBox.Text = "Show loads";
            this.showLoadCheckBox.UseVisualStyleBackColor = true;
            this.showLoadCheckBox.CheckedChanged += new System.EventHandler(this.showLoadCheckBox_CheckedChanged);
            // 
            // showRestraintsCheckBox
            // 
            this.showRestraintsCheckBox.AutoSize = true;
            this.showRestraintsCheckBox.Checked = true;
            this.showRestraintsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showRestraintsCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showRestraintsCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showRestraintsCheckBox.Location = new System.Drawing.Point(3, 3);
            this.showRestraintsCheckBox.Name = "showRestraintsCheckBox";
            this.showRestraintsCheckBox.Size = new System.Drawing.Size(258, 47);
            this.showRestraintsCheckBox.TabIndex = 78;
            this.showRestraintsCheckBox.Text = "Show restraints";
            this.showRestraintsCheckBox.UseVisualStyleBackColor = true;
            this.showRestraintsCheckBox.CheckedChanged += new System.EventHandler(this.showRestraintsCheckBox_CheckedChanged);
            // 
            // MutliBoltsDesginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 671);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MutliBoltsDesginForm";
            this.Text = "MutliBoltsDesginForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.simulation1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._twoStepsOpParamDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.femPlotGroupBox.ResumeLayout(false);
            this.femPlotGroupBox.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._stepsForceOpDataGridView)).EndInit();
            this.femScalingGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton flatButton;
        private System.Windows.Forms.RadioButton renderedButton;
        private System.Windows.Forms.RadioButton shadedButton;
        private System.Windows.Forms.RadioButton wireframeButton;
        private System.Windows.Forms.RadioButton hiddenLinesButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button isoViewButton;
        private System.Windows.Forms.Button frontViewButton;
        private System.Windows.Forms.Button sideViewButton;
        private System.Windows.Forms.Button topViewButton;
        private System.Windows.Forms.CheckBox animateCameraCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton parallelButton;
        private System.Windows.Forms.CheckBox showExtentsButton;
        private System.Windows.Forms.RadioButton perspectiveButton;
        private System.Windows.Forms.CheckBox showGridButton;
        private System.Windows.Forms.CheckBox showVerticesButton;
        private System.Windows.Forms.CheckBox showOriginButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox selectionComboBox;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button invertSelectionButton;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.CheckBox selectButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button dumpButton;
        private System.Windows.Forms.CheckBox pickVertexButton;
        private System.Windows.Forms.CheckBox pickFaceButton;
        private System.Windows.Forms.CheckBox cullingButton;
        private System.Windows.Forms.Button volumeButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.CheckBox showCurveDirectionButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _resetBtn;
        private System.Windows.Forms.Button _assemblyBtn;
        private System.Windows.Forms.Button createFlangeBtn;
        private System.Windows.Forms.Button createBoltBtn;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button _moddelingParamResetBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView _twoStepsOpParamDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropeField;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueField;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescField;
        private System.Windows.Forms.Button _modelingParamOkBtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox femPlotGroupBox;
        private System.Windows.Forms.ComboBox plotTypeComboBox;
        private System.Windows.Forms.CheckBox contourPlotCheckBox;
        private System.Windows.Forms.CheckBox nodalAveragesCheckBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView _stepsForceOpDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoltIdField;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondBatchField;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstBatchField;
        private System.Windows.Forms.GroupBox femScalingGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button createNutBtn;
        private System.Windows.Forms.Button _firstBatchRenderBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox showJointCheckBox;
        private System.Windows.Forms.CheckBox showVertexIndicesCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.CheckBox showLoadCheckBox;
        private System.Windows.Forms.CheckBox showRestraintsCheckBox;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private devDept.Eyeshot.Simulation simulation1;
        private System.Windows.Forms.TabPage tabPage6;
    }
}