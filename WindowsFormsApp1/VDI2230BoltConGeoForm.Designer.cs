namespace WindowsFormsApp1
{
    partial class VDI2230BoltConGeoForm
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
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton2 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar2 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton2, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings2 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera2 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 3.4199999264855729D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton2 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton2 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton2 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton2 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton2 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton2 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton2 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar2 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton2)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton2))});
            devDept.Eyeshot.Grid grid2 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings2 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings2 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings2 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings2 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager2 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport2 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(997, 342), backgroundSettings2, camera2, new devDept.Eyeshot.ToolBar[] {
            toolBar2}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid2}, false, rotateSettings2, zoomSettings2, panSettings2, navigationSettings2, savedViewsManager2, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon2 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol2 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon2 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.boltSpeciTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet2 = new WindowsFormsApp1.BoltConnectionSystemDataSet2();
            this.boltStdTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet6 = new WindowsFormsApp1.BoltConnectionSystemDataSet6();
            this.screwTypeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet5 = new WindowsFormsApp1.BoltConnectionSystemDataSet5();
            this.boltTypeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet4 = new WindowsFormsApp1.BoltConnectionSystemDataSet4();
            this.boltConnectionSystemDataSet = new WindowsFormsApp1.BoltConnectionSystemDataSet();
            this.screwTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.screwTypeTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSetTableAdapters.screwTypeTableTableAdapter();
            this.boltConnectionSystemDataSet1 = new WindowsFormsApp1.BoltConnectionSystemDataSet1();
            this.boltTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltTypeTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet1TableAdapters.boltTypeTableTableAdapter();
            this.boltSpeciTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet2TableAdapters.boltSpeciTableTableAdapter();
            this.boltConnectionSystemDataSet3 = new WindowsFormsApp1.BoltConnectionSystemDataSet3();
            this.boltTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet3TableAdapters.BoltTableTableAdapter();
            this.boltTypeTableTableAdapter1 = new WindowsFormsApp1.BoltConnectionSystemDataSet4TableAdapters.boltTypeTableTableAdapter();
            this.screwTypeTableTableAdapter1 = new WindowsFormsApp1.BoltConnectionSystemDataSet5TableAdapters.screwTypeTableTableAdapter();
            this.boltStdTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet6TableAdapters.boltStdTableTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.boltGroup = new System.Windows.Forms.GroupBox();
            this.boltStdBtn = new System.Windows.Forms.Button();
            this.boltSpeciBtn = new System.Windows.Forms.Button();
            this.boltTypeBtn = new System.Windows.Forms.Button();
            this.screwTypeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gasketGroup = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.nutdowngasketheight_hs2 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.boltheaddowngasketheight_hs1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.gasketoutD_DA = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.gasketinnerD_dhas = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.gasketstd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nutGroup = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nutStd = new System.Windows.Forms.TextBox();
            this.nutNutSideWid = new System.Windows.Forms.TextBox();
            this.nutBearMinD = new System.Windows.Forms.TextBox();
            this.nutBearMaxD = new System.Windows.Forms.TextBox();
            this.nutBearOutD = new System.Windows.Forms.TextBox();
            this.nutHeight = new System.Windows.Forms.TextBox();
            this.nutSpeci = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.seeButton = new System.Windows.Forms.Button();
            this.boltType = new System.Windows.Forms.ComboBox();
            this.dboboltTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet11 = new WindowsFormsApp1.BoltConnectionSystemDataSet11();
            this.label5 = new System.Windows.Forms.Label();
            this.screwType = new System.Windows.Forms.ComboBox();
            this.dboscrewTypeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet22 = new WindowsFormsApp1.BoltConnectionSystemDataSet22();
            this.label6 = new System.Windows.Forms.Label();
            this.boltLen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boltl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boltNutScrewMinD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boltNutSideWid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.polishRodLen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.screwMinD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.screwMidD = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.boltHeadInnerD = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.boltHeadOutD = new System.Windows.Forms.TextBox();
            this.boltSpeci = new System.Windows.Forms.ComboBox();
            this.dboboltSpeciTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet12 = new WindowsFormsApp1.BoltConnectionSystemDataSet12();
            this.boreD = new System.Windows.Forms.TextBox();
            this.boltStd = new System.Windows.Forms.ComboBox();
            this.dboboltStdTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet13 = new WindowsFormsApp1.BoltConnectionSystemDataSet13();
            this.screwP = new System.Windows.Forms.TextBox();
            this.normalD = new System.Windows.Forms.TextBox();
            this.model1 = new devDept.Eyeshot.Model();
            this.dboscrewTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet10 = new WindowsFormsApp1.BoltConnectionSystemDataSet10();
            this.dbo_screwTypeTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet10TableAdapters.dbo_screwTypeTableTableAdapter();
            this.dbo_boltTypeTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet11TableAdapters.dbo_boltTypeTableTableAdapter();
            this.dbo_boltSpeciTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet12TableAdapters.dbo_boltSpeciTableTableAdapter();
            this.dbo_boltStdTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet13TableAdapters.dbo_boltStdTableTableAdapter();
            this.dbo_screwTypeTableTableAdapter1 = new WindowsFormsApp1.BoltConnectionSystemDataSet22TableAdapters.dbo_screwTypeTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.boltSpeciTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltStdTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screwTypeTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltTypeTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screwTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.boltGroup.SuspendLayout();
            this.gasketGroup.SuspendLayout();
            this.nutGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboscrewTypeTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltSpeciTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltStdTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboscrewTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // boltSpeciTableBindingSource
            // 
            this.boltSpeciTableBindingSource.DataMember = "boltSpeciTable";
            this.boltSpeciTableBindingSource.DataSource = this.boltConnectionSystemDataSet2;
            // 
            // boltConnectionSystemDataSet2
            // 
            this.boltConnectionSystemDataSet2.DataSetName = "BoltConnectionSystemDataSet2";
            this.boltConnectionSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boltStdTableBindingSource
            // 
            this.boltStdTableBindingSource.DataMember = "boltStdTable";
            this.boltStdTableBindingSource.DataSource = this.boltConnectionSystemDataSet6;
            // 
            // boltConnectionSystemDataSet6
            // 
            this.boltConnectionSystemDataSet6.DataSetName = "BoltConnectionSystemDataSet6";
            this.boltConnectionSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // screwTypeTableBindingSource1
            // 
            this.screwTypeTableBindingSource1.DataMember = "screwTypeTable";
            this.screwTypeTableBindingSource1.DataSource = this.boltConnectionSystemDataSet5;
            // 
            // boltConnectionSystemDataSet5
            // 
            this.boltConnectionSystemDataSet5.DataSetName = "BoltConnectionSystemDataSet5";
            this.boltConnectionSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boltTypeTableBindingSource1
            // 
            this.boltTypeTableBindingSource1.DataMember = "boltTypeTable";
            this.boltTypeTableBindingSource1.DataSource = this.boltConnectionSystemDataSet4;
            // 
            // boltConnectionSystemDataSet4
            // 
            this.boltConnectionSystemDataSet4.DataSetName = "BoltConnectionSystemDataSet4";
            this.boltConnectionSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boltConnectionSystemDataSet
            // 
            this.boltConnectionSystemDataSet.DataSetName = "BoltConnectionSystemDataSet";
            this.boltConnectionSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // screwTypeTableBindingSource
            // 
            this.screwTypeTableBindingSource.DataMember = "screwTypeTable";
            this.screwTypeTableBindingSource.DataSource = this.boltConnectionSystemDataSet;
            // 
            // screwTypeTableTableAdapter
            // 
            this.screwTypeTableTableAdapter.ClearBeforeFill = true;
            // 
            // boltConnectionSystemDataSet1
            // 
            this.boltConnectionSystemDataSet1.DataSetName = "BoltConnectionSystemDataSet1";
            this.boltConnectionSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boltTypeTableBindingSource
            // 
            this.boltTypeTableBindingSource.DataMember = "boltTypeTable";
            this.boltTypeTableBindingSource.DataSource = this.boltConnectionSystemDataSet1;
            // 
            // boltTypeTableTableAdapter
            // 
            this.boltTypeTableTableAdapter.ClearBeforeFill = true;
            // 
            // boltSpeciTableTableAdapter
            // 
            this.boltSpeciTableTableAdapter.ClearBeforeFill = true;
            // 
            // boltConnectionSystemDataSet3
            // 
            this.boltConnectionSystemDataSet3.DataSetName = "BoltConnectionSystemDataSet3";
            this.boltConnectionSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boltTableBindingSource
            // 
            this.boltTableBindingSource.DataMember = "BoltTable";
            this.boltTableBindingSource.DataSource = this.boltConnectionSystemDataSet3;
            // 
            // boltTableTableAdapter
            // 
            this.boltTableTableAdapter.ClearBeforeFill = true;
            // 
            // boltTypeTableTableAdapter1
            // 
            this.boltTypeTableTableAdapter1.ClearBeforeFill = true;
            // 
            // screwTypeTableTableAdapter1
            // 
            this.screwTypeTableTableAdapter1.ClearBeforeFill = true;
            // 
            // boltStdTableTableAdapter
            // 
            this.boltStdTableTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.boltGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.model1);
            this.splitContainer1.Size = new System.Drawing.Size(997, 707);
            this.splitContainer1.SplitterDistance = 361;
            this.splitContainer1.TabIndex = 0;
            // 
            // boltGroup
            // 
            this.boltGroup.AutoSize = true;
            this.boltGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boltGroup.Controls.Add(this.boltStdBtn);
            this.boltGroup.Controls.Add(this.boltSpeciBtn);
            this.boltGroup.Controls.Add(this.boltTypeBtn);
            this.boltGroup.Controls.Add(this.screwTypeBtn);
            this.boltGroup.Controls.Add(this.label2);
            this.boltGroup.Controls.Add(this.gasketGroup);
            this.boltGroup.Controls.Add(this.label3);
            this.boltGroup.Controls.Add(this.nutGroup);
            this.boltGroup.Controls.Add(this.label4);
            this.boltGroup.Controls.Add(this.addBtn);
            this.boltGroup.Controls.Add(this.seeButton);
            this.boltGroup.Controls.Add(this.boltType);
            this.boltGroup.Controls.Add(this.label5);
            this.boltGroup.Controls.Add(this.screwType);
            this.boltGroup.Controls.Add(this.label6);
            this.boltGroup.Controls.Add(this.boltLen);
            this.boltGroup.Controls.Add(this.label7);
            this.boltGroup.Controls.Add(this.boltl);
            this.boltGroup.Controls.Add(this.label8);
            this.boltGroup.Controls.Add(this.label9);
            this.boltGroup.Controls.Add(this.boltNutScrewMinD);
            this.boltGroup.Controls.Add(this.label10);
            this.boltGroup.Controls.Add(this.boltNutSideWid);
            this.boltGroup.Controls.Add(this.label11);
            this.boltGroup.Controls.Add(this.polishRodLen);
            this.boltGroup.Controls.Add(this.label12);
            this.boltGroup.Controls.Add(this.screwMinD);
            this.boltGroup.Controls.Add(this.label13);
            this.boltGroup.Controls.Add(this.screwMidD);
            this.boltGroup.Controls.Add(this.label14);
            this.boltGroup.Controls.Add(this.boltHeadInnerD);
            this.boltGroup.Controls.Add(this.label15);
            this.boltGroup.Controls.Add(this.boltHeadOutD);
            this.boltGroup.Controls.Add(this.boltSpeci);
            this.boltGroup.Controls.Add(this.boreD);
            this.boltGroup.Controls.Add(this.boltStd);
            this.boltGroup.Controls.Add(this.screwP);
            this.boltGroup.Controls.Add(this.normalD);
            this.boltGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.boltGroup.Location = new System.Drawing.Point(0, 0);
            this.boltGroup.Name = "boltGroup";
            this.boltGroup.Size = new System.Drawing.Size(980, 413);
            this.boltGroup.TabIndex = 175;
            this.boltGroup.TabStop = false;
            this.boltGroup.Text = "螺栓";
            // 
            // boltStdBtn
            // 
            this.boltStdBtn.Location = new System.Drawing.Point(261, 105);
            this.boltStdBtn.Name = "boltStdBtn";
            this.boltStdBtn.Size = new System.Drawing.Size(19, 16);
            this.boltStdBtn.TabIndex = 174;
            this.boltStdBtn.Text = "...";
            this.boltStdBtn.UseVisualStyleBackColor = true;
            this.boltStdBtn.Visible = false;
            this.boltStdBtn.Click += new System.EventHandler(this.boltStdBtn_Click);
            // 
            // boltSpeciBtn
            // 
            this.boltSpeciBtn.Location = new System.Drawing.Point(261, 80);
            this.boltSpeciBtn.Name = "boltSpeciBtn";
            this.boltSpeciBtn.Size = new System.Drawing.Size(19, 16);
            this.boltSpeciBtn.TabIndex = 174;
            this.boltSpeciBtn.Text = "...";
            this.boltSpeciBtn.UseVisualStyleBackColor = true;
            this.boltSpeciBtn.Visible = false;
            this.boltSpeciBtn.Click += new System.EventHandler(this.boltSpeciBtn_Click);
            // 
            // boltTypeBtn
            // 
            this.boltTypeBtn.Location = new System.Drawing.Point(261, 54);
            this.boltTypeBtn.Name = "boltTypeBtn";
            this.boltTypeBtn.Size = new System.Drawing.Size(19, 16);
            this.boltTypeBtn.TabIndex = 174;
            this.boltTypeBtn.Text = "...";
            this.boltTypeBtn.UseVisualStyleBackColor = true;
            this.boltTypeBtn.Visible = false;
            this.boltTypeBtn.Click += new System.EventHandler(this.boltTypeBtn_Click);
            // 
            // screwTypeBtn
            // 
            this.screwTypeBtn.Location = new System.Drawing.Point(261, 31);
            this.screwTypeBtn.Name = "screwTypeBtn";
            this.screwTypeBtn.Size = new System.Drawing.Size(19, 16);
            this.screwTypeBtn.TabIndex = 174;
            this.screwTypeBtn.Text = "...";
            this.screwTypeBtn.UseVisualStyleBackColor = true;
            this.screwTypeBtn.Visible = false;
            this.screwTypeBtn.Click += new System.EventHandler(this.screwTypeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 115;
            this.label2.Text = "螺纹类型";
            // 
            // gasketGroup
            // 
            this.gasketGroup.AutoSize = true;
            this.gasketGroup.Controls.Add(this.label25);
            this.gasketGroup.Controls.Add(this.nutdowngasketheight_hs2);
            this.gasketGroup.Controls.Add(this.label28);
            this.gasketGroup.Controls.Add(this.boltheaddowngasketheight_hs1);
            this.gasketGroup.Controls.Add(this.label26);
            this.gasketGroup.Controls.Add(this.gasketoutD_DA);
            this.gasketGroup.Controls.Add(this.label29);
            this.gasketGroup.Controls.Add(this.gasketinnerD_dhas);
            this.gasketGroup.Controls.Add(this.label27);
            this.gasketGroup.Controls.Add(this.gasketstd);
            this.gasketGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.gasketGroup.Location = new System.Drawing.Point(467, 17);
            this.gasketGroup.Name = "gasketGroup";
            this.gasketGroup.Size = new System.Drawing.Size(257, 393);
            this.gasketGroup.TabIndex = 173;
            this.gasketGroup.TabStop = false;
            this.gasketGroup.Text = "垫片";
            this.gasketGroup.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 28);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 162;
            this.label25.Text = "标准";
            // 
            // nutdowngasketheight_hs2
            // 
            this.nutdowngasketheight_hs2.Location = new System.Drawing.Point(141, 128);
            this.nutdowngasketheight_hs2.Margin = new System.Windows.Forms.Padding(2);
            this.nutdowngasketheight_hs2.Name = "nutdowngasketheight_hs2";
            this.nutdowngasketheight_hs2.ReadOnly = true;
            this.nutdowngasketheight_hs2.Size = new System.Drawing.Size(111, 21);
            this.nutdowngasketheight_hs2.TabIndex = 171;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 110);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(113, 12);
            this.label28.TabIndex = 163;
            this.label28.Text = "螺栓头下的垫圈厚度";
            // 
            // boltheaddowngasketheight_hs1
            // 
            this.boltheaddowngasketheight_hs1.Location = new System.Drawing.Point(141, 102);
            this.boltheaddowngasketheight_hs1.Margin = new System.Windows.Forms.Padding(2);
            this.boltheaddowngasketheight_hs1.Name = "boltheaddowngasketheight_hs1";
            this.boltheaddowngasketheight_hs1.ReadOnly = true;
            this.boltheaddowngasketheight_hs1.Size = new System.Drawing.Size(111, 21);
            this.boltheaddowngasketheight_hs1.TabIndex = 170;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 55);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 164;
            this.label26.Text = "内径";
            // 
            // gasketoutD_DA
            // 
            this.gasketoutD_DA.Location = new System.Drawing.Point(141, 77);
            this.gasketoutD_DA.Margin = new System.Windows.Forms.Padding(2);
            this.gasketoutD_DA.Name = "gasketoutD_DA";
            this.gasketoutD_DA.ReadOnly = true;
            this.gasketoutD_DA.Size = new System.Drawing.Size(111, 21);
            this.gasketoutD_DA.TabIndex = 169;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(5, 137);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 12);
            this.label29.TabIndex = 165;
            this.label29.Text = "螺母下的垫圈厚度";
            // 
            // gasketinnerD_dhas
            // 
            this.gasketinnerD_dhas.Location = new System.Drawing.Point(141, 51);
            this.gasketinnerD_dhas.Margin = new System.Windows.Forms.Padding(2);
            this.gasketinnerD_dhas.Name = "gasketinnerD_dhas";
            this.gasketinnerD_dhas.ReadOnly = true;
            this.gasketinnerD_dhas.Size = new System.Drawing.Size(111, 21);
            this.gasketinnerD_dhas.TabIndex = 168;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(5, 82);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 166;
            this.label27.Text = "外径";
            // 
            // gasketstd
            // 
            this.gasketstd.Location = new System.Drawing.Point(141, 25);
            this.gasketstd.Margin = new System.Windows.Forms.Padding(2);
            this.gasketstd.Name = "gasketstd";
            this.gasketstd.ReadOnly = true;
            this.gasketstd.Size = new System.Drawing.Size(111, 21);
            this.gasketstd.TabIndex = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 116;
            this.label3.Text = "螺栓类型";
            // 
            // nutGroup
            // 
            this.nutGroup.AutoSize = true;
            this.nutGroup.Controls.Add(this.label23);
            this.nutGroup.Controls.Add(this.label17);
            this.nutGroup.Controls.Add(this.label18);
            this.nutGroup.Controls.Add(this.label19);
            this.nutGroup.Controls.Add(this.label20);
            this.nutGroup.Controls.Add(this.label21);
            this.nutGroup.Controls.Add(this.label22);
            this.nutGroup.Controls.Add(this.nutStd);
            this.nutGroup.Controls.Add(this.nutNutSideWid);
            this.nutGroup.Controls.Add(this.nutBearMinD);
            this.nutGroup.Controls.Add(this.nutBearMaxD);
            this.nutGroup.Controls.Add(this.nutBearOutD);
            this.nutGroup.Controls.Add(this.nutHeight);
            this.nutGroup.Controls.Add(this.nutSpeci);
            this.nutGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.nutGroup.Location = new System.Drawing.Point(724, 17);
            this.nutGroup.Name = "nutGroup";
            this.nutGroup.Size = new System.Drawing.Size(253, 393);
            this.nutGroup.TabIndex = 172;
            this.nutGroup.TabStop = false;
            this.nutGroup.Text = "螺母";
            this.nutGroup.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 17);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 154;
            this.label23.Text = "螺母规格";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 44);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 142;
            this.label17.Text = "标准";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 71);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 143;
            this.label18.Text = "螺母对边宽度";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 98);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 12);
            this.label19.TabIndex = 144;
            this.label19.Text = "螺母承载面最小内径";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 126);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(113, 12);
            this.label20.TabIndex = 145;
            this.label20.Text = "螺母承载面最大内径";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 153);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 12);
            this.label21.TabIndex = 146;
            this.label21.Text = "螺母承载面外径";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 182);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 147;
            this.label22.Text = "螺母高度";
            // 
            // nutStd
            // 
            this.nutStd.Location = new System.Drawing.Point(137, 39);
            this.nutStd.Margin = new System.Windows.Forms.Padding(2);
            this.nutStd.Name = "nutStd";
            this.nutStd.ReadOnly = true;
            this.nutStd.Size = new System.Drawing.Size(111, 21);
            this.nutStd.TabIndex = 148;
            // 
            // nutNutSideWid
            // 
            this.nutNutSideWid.Location = new System.Drawing.Point(137, 67);
            this.nutNutSideWid.Margin = new System.Windows.Forms.Padding(2);
            this.nutNutSideWid.Name = "nutNutSideWid";
            this.nutNutSideWid.ReadOnly = true;
            this.nutNutSideWid.Size = new System.Drawing.Size(111, 21);
            this.nutNutSideWid.TabIndex = 149;
            // 
            // nutBearMinD
            // 
            this.nutBearMinD.Location = new System.Drawing.Point(137, 95);
            this.nutBearMinD.Margin = new System.Windows.Forms.Padding(2);
            this.nutBearMinD.Name = "nutBearMinD";
            this.nutBearMinD.ReadOnly = true;
            this.nutBearMinD.Size = new System.Drawing.Size(111, 21);
            this.nutBearMinD.TabIndex = 150;
            // 
            // nutBearMaxD
            // 
            this.nutBearMaxD.Location = new System.Drawing.Point(137, 123);
            this.nutBearMaxD.Margin = new System.Windows.Forms.Padding(2);
            this.nutBearMaxD.Name = "nutBearMaxD";
            this.nutBearMaxD.ReadOnly = true;
            this.nutBearMaxD.Size = new System.Drawing.Size(111, 21);
            this.nutBearMaxD.TabIndex = 151;
            // 
            // nutBearOutD
            // 
            this.nutBearOutD.Location = new System.Drawing.Point(137, 151);
            this.nutBearOutD.Margin = new System.Windows.Forms.Padding(2);
            this.nutBearOutD.Name = "nutBearOutD";
            this.nutBearOutD.ReadOnly = true;
            this.nutBearOutD.Size = new System.Drawing.Size(111, 21);
            this.nutBearOutD.TabIndex = 152;
            // 
            // nutHeight
            // 
            this.nutHeight.Location = new System.Drawing.Point(137, 179);
            this.nutHeight.Margin = new System.Windows.Forms.Padding(2);
            this.nutHeight.Name = "nutHeight";
            this.nutHeight.ReadOnly = true;
            this.nutHeight.Size = new System.Drawing.Size(111, 21);
            this.nutHeight.TabIndex = 153;
            // 
            // nutSpeci
            // 
            this.nutSpeci.Location = new System.Drawing.Point(137, 11);
            this.nutSpeci.Margin = new System.Windows.Forms.Padding(2);
            this.nutSpeci.Name = "nutSpeci";
            this.nutSpeci.ReadOnly = true;
            this.nutSpeci.Size = new System.Drawing.Size(111, 21);
            this.nutSpeci.TabIndex = 155;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 117;
            this.label4.Text = "螺栓规格";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(298, 67);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(78, 32);
            this.addBtn.TabIndex = 160;
            this.addBtn.Text = "插入";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Visible = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // seeButton
            // 
            this.seeButton.Location = new System.Drawing.Point(298, 25);
            this.seeButton.Margin = new System.Windows.Forms.Padding(2);
            this.seeButton.Name = "seeButton";
            this.seeButton.Size = new System.Drawing.Size(78, 32);
            this.seeButton.TabIndex = 160;
            this.seeButton.Text = "查看";
            this.seeButton.UseVisualStyleBackColor = true;
            this.seeButton.Click += new System.EventHandler(this.seeButton_Click);
            // 
            // boltType
            // 
            this.boltType.DataSource = this.dboboltTypeTableBindingSource;
            this.boltType.DisplayMember = "boltType";
            this.boltType.FormattingEnabled = true;
            this.boltType.Location = new System.Drawing.Point(141, 51);
            this.boltType.Margin = new System.Windows.Forms.Padding(2);
            this.boltType.Name = "boltType";
            this.boltType.Size = new System.Drawing.Size(115, 20);
            this.boltType.TabIndex = 159;
            // 
            // dboboltTypeTableBindingSource
            // 
            this.dboboltTypeTableBindingSource.DataMember = "dbo_boltTypeTable";
            this.dboboltTypeTableBindingSource.DataSource = this.boltConnectionSystemDataSet11;
            // 
            // boltConnectionSystemDataSet11
            // 
            this.boltConnectionSystemDataSet11.DataSetName = "BoltConnectionSystemDataSet11";
            this.boltConnectionSystemDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 118;
            this.label5.Text = "标准";
            // 
            // screwType
            // 
            this.screwType.DataSource = this.dboscrewTypeTableBindingSource1;
            this.screwType.DisplayMember = "screwType";
            this.screwType.FormattingEnabled = true;
            this.screwType.Location = new System.Drawing.Point(141, 27);
            this.screwType.Margin = new System.Windows.Forms.Padding(2);
            this.screwType.Name = "screwType";
            this.screwType.Size = new System.Drawing.Size(115, 20);
            this.screwType.TabIndex = 158;
            // 
            // dboscrewTypeTableBindingSource1
            // 
            this.dboscrewTypeTableBindingSource1.DataMember = "dbo_screwTypeTable";
            this.dboscrewTypeTableBindingSource1.DataSource = this.boltConnectionSystemDataSet22;
            // 
            // boltConnectionSystemDataSet22
            // 
            this.boltConnectionSystemDataSet22.DataSetName = "BoltConnectionSystemDataSet22";
            this.boltConnectionSystemDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 119;
            this.label6.Text = "螺纹公称直径";
            // 
            // boltLen
            // 
            this.boltLen.Location = new System.Drawing.Point(141, 125);
            this.boltLen.Margin = new System.Windows.Forms.Padding(2);
            this.boltLen.Name = "boltLen";
            this.boltLen.ReadOnly = true;
            this.boltLen.Size = new System.Drawing.Size(115, 21);
            this.boltLen.TabIndex = 157;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 120;
            this.label7.Text = "螺距";
            // 
            // boltl
            // 
            this.boltl.AutoSize = true;
            this.boltl.Location = new System.Drawing.Point(20, 132);
            this.boltl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boltl.Name = "boltl";
            this.boltl.Size = new System.Drawing.Size(53, 12);
            this.boltl.TabIndex = 156;
            this.boltl.Text = "螺栓长度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 121;
            this.label8.Text = "镗孔直径";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 122;
            this.label9.Text = "螺栓头承载面外径";
            // 
            // boltNutScrewMinD
            // 
            this.boltNutScrewMinD.Location = new System.Drawing.Point(141, 373);
            this.boltNutScrewMinD.Margin = new System.Windows.Forms.Padding(2);
            this.boltNutScrewMinD.Name = "boltNutScrewMinD";
            this.boltNutScrewMinD.ReadOnly = true;
            this.boltNutScrewMinD.Size = new System.Drawing.Size(115, 21);
            this.boltNutScrewMinD.TabIndex = 140;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 256);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 123;
            this.label10.Text = "螺栓头承载面内径";
            // 
            // boltNutSideWid
            // 
            this.boltNutSideWid.Location = new System.Drawing.Point(141, 348);
            this.boltNutSideWid.Margin = new System.Windows.Forms.Padding(2);
            this.boltNutSideWid.Name = "boltNutSideWid";
            this.boltNutSideWid.ReadOnly = true;
            this.boltNutSideWid.Size = new System.Drawing.Size(115, 21);
            this.boltNutSideWid.TabIndex = 139;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 124;
            this.label11.Text = "螺纹中径";
            // 
            // polishRodLen
            // 
            this.polishRodLen.Location = new System.Drawing.Point(141, 324);
            this.polishRodLen.Margin = new System.Windows.Forms.Padding(2);
            this.polishRodLen.Name = "polishRodLen";
            this.polishRodLen.ReadOnly = true;
            this.polishRodLen.Size = new System.Drawing.Size(115, 21);
            this.polishRodLen.TabIndex = 138;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 305);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 125;
            this.label12.Text = "螺纹小径";
            // 
            // screwMinD
            // 
            this.screwMinD.Location = new System.Drawing.Point(141, 299);
            this.screwMinD.Margin = new System.Windows.Forms.Padding(2);
            this.screwMinD.Name = "screwMinD";
            this.screwMinD.ReadOnly = true;
            this.screwMinD.Size = new System.Drawing.Size(115, 21);
            this.screwMinD.TabIndex = 137;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 330);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 126;
            this.label13.Text = "光杆长度";
            // 
            // screwMidD
            // 
            this.screwMidD.Location = new System.Drawing.Point(141, 274);
            this.screwMidD.Margin = new System.Windows.Forms.Padding(2);
            this.screwMidD.Name = "screwMidD";
            this.screwMidD.ReadOnly = true;
            this.screwMidD.Size = new System.Drawing.Size(115, 21);
            this.screwMidD.TabIndex = 136;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 355);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 127;
            this.label14.Text = "螺母对边宽度";
            // 
            // boltHeadInnerD
            // 
            this.boltHeadInnerD.Location = new System.Drawing.Point(141, 249);
            this.boltHeadInnerD.Margin = new System.Windows.Forms.Padding(2);
            this.boltHeadInnerD.Name = "boltHeadInnerD";
            this.boltHeadInnerD.ReadOnly = true;
            this.boltHeadInnerD.Size = new System.Drawing.Size(115, 21);
            this.boltHeadInnerD.TabIndex = 135;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 380);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 128;
            this.label15.Text = "螺母螺纹小径";
            // 
            // boltHeadOutD
            // 
            this.boltHeadOutD.Location = new System.Drawing.Point(141, 224);
            this.boltHeadOutD.Margin = new System.Windows.Forms.Padding(2);
            this.boltHeadOutD.Name = "boltHeadOutD";
            this.boltHeadOutD.ReadOnly = true;
            this.boltHeadOutD.Size = new System.Drawing.Size(115, 21);
            this.boltHeadOutD.TabIndex = 134;
            // 
            // boltSpeci
            // 
            this.boltSpeci.DataSource = this.dboboltSpeciTableBindingSource;
            this.boltSpeci.DisplayMember = "boltSpeci";
            this.boltSpeci.FormattingEnabled = true;
            this.boltSpeci.Location = new System.Drawing.Point(141, 79);
            this.boltSpeci.Margin = new System.Windows.Forms.Padding(2);
            this.boltSpeci.Name = "boltSpeci";
            this.boltSpeci.Size = new System.Drawing.Size(115, 20);
            this.boltSpeci.TabIndex = 129;
            // 
            // dboboltSpeciTableBindingSource
            // 
            this.dboboltSpeciTableBindingSource.DataMember = "dbo_boltSpeciTable";
            this.dboboltSpeciTableBindingSource.DataSource = this.boltConnectionSystemDataSet12;
            // 
            // boltConnectionSystemDataSet12
            // 
            this.boltConnectionSystemDataSet12.DataSetName = "BoltConnectionSystemDataSet12";
            this.boltConnectionSystemDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boreD
            // 
            this.boreD.Location = new System.Drawing.Point(141, 200);
            this.boreD.Margin = new System.Windows.Forms.Padding(2);
            this.boreD.Name = "boreD";
            this.boreD.ReadOnly = true;
            this.boreD.Size = new System.Drawing.Size(115, 21);
            this.boreD.TabIndex = 133;
            // 
            // boltStd
            // 
            this.boltStd.DataSource = this.dboboltStdTableBindingSource;
            this.boltStd.DisplayMember = "boltStd";
            this.boltStd.FormattingEnabled = true;
            this.boltStd.Location = new System.Drawing.Point(141, 102);
            this.boltStd.Margin = new System.Windows.Forms.Padding(2);
            this.boltStd.Name = "boltStd";
            this.boltStd.Size = new System.Drawing.Size(115, 20);
            this.boltStd.TabIndex = 130;
            // 
            // dboboltStdTableBindingSource
            // 
            this.dboboltStdTableBindingSource.DataMember = "dbo_boltStdTable";
            this.dboboltStdTableBindingSource.DataSource = this.boltConnectionSystemDataSet13;
            // 
            // boltConnectionSystemDataSet13
            // 
            this.boltConnectionSystemDataSet13.DataSetName = "BoltConnectionSystemDataSet13";
            this.boltConnectionSystemDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // screwP
            // 
            this.screwP.Location = new System.Drawing.Point(141, 175);
            this.screwP.Margin = new System.Windows.Forms.Padding(2);
            this.screwP.Name = "screwP";
            this.screwP.ReadOnly = true;
            this.screwP.Size = new System.Drawing.Size(115, 21);
            this.screwP.TabIndex = 132;
            // 
            // normalD
            // 
            this.normalD.Location = new System.Drawing.Point(141, 150);
            this.normalD.Margin = new System.Windows.Forms.Padding(2);
            this.normalD.Name = "normalD";
            this.normalD.ReadOnly = true;
            this.normalD.Size = new System.Drawing.Size(115, 21);
            this.normalD.TabIndex = 131;
            // 
            // model1
            // 
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model1.Location = new System.Drawing.Point(0, 0);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar2;
            this.model1.Size = new System.Drawing.Size(997, 342);
            this.model1.TabIndex = 0;
            this.model1.Text = "model1";
            coordinateSystemIcon2.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport2.CoordinateSystemIcon = coordinateSystemIcon2;
            viewport2.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol2.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport2.OriginSymbol = originSymbol2;
            viewCubeIcon2.Font = null;
            viewCubeIcon2.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport2.ViewCubeIcon = viewCubeIcon2;
            this.model1.Viewports.Add(viewport2);
            // 
            // dboscrewTypeTableBindingSource
            // 
            this.dboscrewTypeTableBindingSource.DataMember = "dbo_screwTypeTable";
            this.dboscrewTypeTableBindingSource.DataSource = this.boltConnectionSystemDataSet10;
            // 
            // boltConnectionSystemDataSet10
            // 
            this.boltConnectionSystemDataSet10.DataSetName = "BoltConnectionSystemDataSet10";
            this.boltConnectionSystemDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbo_screwTypeTableTableAdapter
            // 
            this.dbo_screwTypeTableTableAdapter.ClearBeforeFill = true;
            // 
            // dbo_boltTypeTableTableAdapter
            // 
            this.dbo_boltTypeTableTableAdapter.ClearBeforeFill = true;
            // 
            // dbo_boltSpeciTableTableAdapter
            // 
            this.dbo_boltSpeciTableTableAdapter.ClearBeforeFill = true;
            // 
            // dbo_boltStdTableTableAdapter
            // 
            this.dbo_boltStdTableTableAdapter.ClearBeforeFill = true;
            // 
            // dbo_screwTypeTableTableAdapter1
            // 
            this.dbo_screwTypeTableTableAdapter1.ClearBeforeFill = true;
            // 
            // VDI2230BoltConGeoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(997, 707);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VDI2230BoltConGeoForm";
            this.Text = "VDI2230BoltConGeoForm";
            this.Load += new System.EventHandler(this.VDI2230BoltConGeoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boltSpeciTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltStdTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screwTypeTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltTypeTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screwTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltTableBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.boltGroup.ResumeLayout(false);
            this.boltGroup.PerformLayout();
            this.gasketGroup.ResumeLayout(false);
            this.gasketGroup.PerformLayout();
            this.nutGroup.ResumeLayout(false);
            this.nutGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboscrewTypeTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltSpeciTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltStdTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboscrewTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BoltConnectionSystemDataSet boltConnectionSystemDataSet;
        private System.Windows.Forms.BindingSource screwTypeTableBindingSource;
        private BoltConnectionSystemDataSetTableAdapters.screwTypeTableTableAdapter screwTypeTableTableAdapter;
        private BoltConnectionSystemDataSet1 boltConnectionSystemDataSet1;
        private System.Windows.Forms.BindingSource boltTypeTableBindingSource;
        private BoltConnectionSystemDataSet1TableAdapters.boltTypeTableTableAdapter boltTypeTableTableAdapter;
        private BoltConnectionSystemDataSet2 boltConnectionSystemDataSet2;
        private System.Windows.Forms.BindingSource boltSpeciTableBindingSource;
        private BoltConnectionSystemDataSet2TableAdapters.boltSpeciTableTableAdapter boltSpeciTableTableAdapter;
        private BoltConnectionSystemDataSet3 boltConnectionSystemDataSet3;
        private System.Windows.Forms.BindingSource boltTableBindingSource;
        private BoltConnectionSystemDataSet3TableAdapters.BoltTableTableAdapter boltTableTableAdapter;
        private BoltConnectionSystemDataSet4 boltConnectionSystemDataSet4;
        private System.Windows.Forms.BindingSource boltTypeTableBindingSource1;
        private BoltConnectionSystemDataSet4TableAdapters.boltTypeTableTableAdapter boltTypeTableTableAdapter1;
        private BoltConnectionSystemDataSet5 boltConnectionSystemDataSet5;
        private System.Windows.Forms.BindingSource screwTypeTableBindingSource1;
        private BoltConnectionSystemDataSet5TableAdapters.screwTypeTableTableAdapter screwTypeTableTableAdapter1;
        private BoltConnectionSystemDataSet6 boltConnectionSystemDataSet6;
        private System.Windows.Forms.BindingSource boltStdTableBindingSource;
        private BoltConnectionSystemDataSet6TableAdapters.boltStdTableTableAdapter boltStdTableTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox boltGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gasketGroup;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox nutdowngasketheight_hs2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox boltheaddowngasketheight_hs1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox gasketoutD_DA;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox gasketinnerD_dhas;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox gasketstd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox nutGroup;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox nutStd;
        private System.Windows.Forms.TextBox nutNutSideWid;
        private System.Windows.Forms.TextBox nutBearMinD;
        private System.Windows.Forms.TextBox nutBearMaxD;
        private System.Windows.Forms.TextBox nutBearOutD;
        private System.Windows.Forms.TextBox nutHeight;
        private System.Windows.Forms.TextBox nutSpeci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button seeButton;
        private System.Windows.Forms.ComboBox boltType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox screwType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boltLen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label boltl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boltNutScrewMinD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boltNutSideWid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox polishRodLen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox screwMinD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox screwMidD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox boltHeadInnerD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox boltHeadOutD;
        private System.Windows.Forms.ComboBox boltSpeci;
        private System.Windows.Forms.TextBox boreD;
        private System.Windows.Forms.ComboBox boltStd;
        private System.Windows.Forms.TextBox screwP;
        private System.Windows.Forms.TextBox normalD;
        private devDept.Eyeshot.Model model1;
        private BoltConnectionSystemDataSet10 boltConnectionSystemDataSet10;
        private System.Windows.Forms.BindingSource dboscrewTypeTableBindingSource;
        private BoltConnectionSystemDataSet10TableAdapters.dbo_screwTypeTableTableAdapter dbo_screwTypeTableTableAdapter;
        private BoltConnectionSystemDataSet11 boltConnectionSystemDataSet11;
        private System.Windows.Forms.BindingSource dboboltTypeTableBindingSource;
        private BoltConnectionSystemDataSet11TableAdapters.dbo_boltTypeTableTableAdapter dbo_boltTypeTableTableAdapter;
        private BoltConnectionSystemDataSet12 boltConnectionSystemDataSet12;
        private System.Windows.Forms.BindingSource dboboltSpeciTableBindingSource;
        private BoltConnectionSystemDataSet12TableAdapters.dbo_boltSpeciTableTableAdapter dbo_boltSpeciTableTableAdapter;
        private BoltConnectionSystemDataSet13 boltConnectionSystemDataSet13;
        private System.Windows.Forms.BindingSource dboboltStdTableBindingSource;
        private BoltConnectionSystemDataSet13TableAdapters.dbo_boltStdTableTableAdapter dbo_boltStdTableTableAdapter;
        private System.Windows.Forms.Button boltStdBtn;
        private System.Windows.Forms.Button boltSpeciBtn;
        private System.Windows.Forms.Button boltTypeBtn;
        private System.Windows.Forms.Button screwTypeBtn;
        private BoltConnectionSystemDataSet22 boltConnectionSystemDataSet22;
        private System.Windows.Forms.BindingSource dboscrewTypeTableBindingSource1;
        private BoltConnectionSystemDataSet22TableAdapters.dbo_screwTypeTableTableAdapter dbo_screwTypeTableTableAdapter1;
        private System.Windows.Forms.Button addBtn;
    }
}