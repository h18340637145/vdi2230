namespace WindowsFormsApp1
{
    partial class InitDesignChooseForm
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
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton2 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar2 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton2, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings2 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera2 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 3.3400000156767078D, false, 0.001D);
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
            devDept.Eyeshot.Viewport viewport2 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(404, 334), backgroundSettings2, camera2, new devDept.Eyeshot.ToolBar[] {
            toolBar2}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid2}, false, rotateSettings2, zoomSettings2, panSettings2, navigationSettings2, savedViewsManager2, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon2 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol2 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon2 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.std = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model1 = new devDept.Eyeshot.Model();
            this.panel2 = new System.Windows.Forms.Panel();
            this.D1res = new System.Windows.Forms.TextBox();
            this.lsres = new System.Windows.Forms.TextBox();
            this.d3res = new System.Windows.Forms.TextBox();
            this.d2res = new System.Windows.Forms.TextBox();
            this.dares = new System.Windows.Forms.TextBox();
            this.Rpminres = new System.Windows.Forms.TextBox();
            this.dwres = new System.Windows.Forms.TextBox();
            this.Rmres = new System.Windows.Forms.TextBox();
            this.dhres = new System.Windows.Forms.TextBox();
            this.ESRTres = new System.Windows.Forms.TextBox();
            this.dres = new System.Windows.Forms.TextBox();
            this.Pres = new System.Windows.Forms.TextBox();
            this.D1Label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lsLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.d3Label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.d2Label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.daLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dwLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RmLabel = new System.Windows.Forms.Label();
            this.dhLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.ESRTLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.PLabel = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hexagonHeadedBoltLabel = new System.Windows.Forms.Label();
            this.strengthGradeLabel = new System.Windows.Forms.Label();
            this.boltStdDimStrengthValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boltStdDimStrengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.physicalDimensionLabel = new System.Windows.Forms.Label();
            this.optBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 514);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1072, 514);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.SplitterWidth = 3;
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
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.model1);
            this.splitContainer2.Size = new System.Drawing.Size(404, 514);
            this.splitContainer2.SplitterDistance = 176;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.std,
            this.DN,
            this.ls,
            this.l1,
            this.dh});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(404, 176);
            this.dataGridView1.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // std
            // 
            this.std.HeaderText = "标准";
            this.std.Name = "std";
            this.std.ReadOnly = true;
            // 
            // DN
            // 
            this.DN.HeaderText = "公称直径";
            this.DN.Name = "DN";
            this.DN.ReadOnly = true;
            // 
            // ls
            // 
            this.ls.HeaderText = "ls";
            this.ls.Name = "ls";
            this.ls.ReadOnly = true;
            // 
            // l1
            // 
            this.l1.HeaderText = "l1";
            this.l1.Name = "l1";
            this.l1.ReadOnly = true;
            // 
            // dh
            // 
            this.dh.HeaderText = "dh";
            this.dh.Name = "dh";
            this.dh.ReadOnly = true;
            // 
            // model1
            // 
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model1.Location = new System.Drawing.Point(0, 0);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar2;
            this.model1.Size = new System.Drawing.Size(404, 334);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.D1res);
            this.panel2.Controls.Add(this.lsres);
            this.panel2.Controls.Add(this.d3res);
            this.panel2.Controls.Add(this.d2res);
            this.panel2.Controls.Add(this.dares);
            this.panel2.Controls.Add(this.Rpminres);
            this.panel2.Controls.Add(this.dwres);
            this.panel2.Controls.Add(this.Rmres);
            this.panel2.Controls.Add(this.dhres);
            this.panel2.Controls.Add(this.ESRTres);
            this.panel2.Controls.Add(this.dres);
            this.panel2.Controls.Add(this.Pres);
            this.panel2.Controls.Add(this.D1Label);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lsLabel);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.d3Label);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.d2Label);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.daLabel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.dwLabel);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.RmLabel);
            this.panel2.Controls.Add(this.dhLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.ESRTLabel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dLabel);
            this.panel2.Controls.Add(this.PLabel);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.hexagonHeadedBoltLabel);
            this.panel2.Controls.Add(this.strengthGradeLabel);
            this.panel2.Controls.Add(this.boltStdDimStrengthValue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.boltStdDimStrengthLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.physicalDimensionLabel);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.optBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 514);
            this.panel2.TabIndex = 0;
            // 
            // D1res
            // 
            this.D1res.Location = new System.Drawing.Point(175, 428);
            this.D1res.Margin = new System.Windows.Forms.Padding(2);
            this.D1res.Name = "D1res";
            this.D1res.ReadOnly = true;
            this.D1res.Size = new System.Drawing.Size(60, 21);
            this.D1res.TabIndex = 102;
            // 
            // lsres
            // 
            this.lsres.Location = new System.Drawing.Point(175, 402);
            this.lsres.Margin = new System.Windows.Forms.Padding(2);
            this.lsres.Name = "lsres";
            this.lsres.ReadOnly = true;
            this.lsres.Size = new System.Drawing.Size(60, 21);
            this.lsres.TabIndex = 101;
            // 
            // d3res
            // 
            this.d3res.Location = new System.Drawing.Point(175, 378);
            this.d3res.Margin = new System.Windows.Forms.Padding(2);
            this.d3res.Name = "d3res";
            this.d3res.ReadOnly = true;
            this.d3res.Size = new System.Drawing.Size(60, 21);
            this.d3res.TabIndex = 100;
            // 
            // d2res
            // 
            this.d2res.Location = new System.Drawing.Point(175, 353);
            this.d2res.Margin = new System.Windows.Forms.Padding(2);
            this.d2res.Name = "d2res";
            this.d2res.ReadOnly = true;
            this.d2res.Size = new System.Drawing.Size(60, 21);
            this.d2res.TabIndex = 99;
            // 
            // dares
            // 
            this.dares.Location = new System.Drawing.Point(175, 328);
            this.dares.Margin = new System.Windows.Forms.Padding(2);
            this.dares.Name = "dares";
            this.dares.ReadOnly = true;
            this.dares.Size = new System.Drawing.Size(60, 21);
            this.dares.TabIndex = 98;
            // 
            // Rpminres
            // 
            this.Rpminres.Location = new System.Drawing.Point(489, 241);
            this.Rpminres.Margin = new System.Windows.Forms.Padding(2);
            this.Rpminres.Name = "Rpminres";
            this.Rpminres.ReadOnly = true;
            this.Rpminres.Size = new System.Drawing.Size(60, 21);
            this.Rpminres.TabIndex = 97;
            // 
            // dwres
            // 
            this.dwres.Location = new System.Drawing.Point(175, 303);
            this.dwres.Margin = new System.Windows.Forms.Padding(2);
            this.dwres.Name = "dwres";
            this.dwres.ReadOnly = true;
            this.dwres.Size = new System.Drawing.Size(60, 21);
            this.dwres.TabIndex = 96;
            // 
            // Rmres
            // 
            this.Rmres.Location = new System.Drawing.Point(489, 216);
            this.Rmres.Margin = new System.Windows.Forms.Padding(2);
            this.Rmres.Name = "Rmres";
            this.Rmres.ReadOnly = true;
            this.Rmres.Size = new System.Drawing.Size(60, 21);
            this.Rmres.TabIndex = 95;
            // 
            // dhres
            // 
            this.dhres.Location = new System.Drawing.Point(175, 278);
            this.dhres.Margin = new System.Windows.Forms.Padding(2);
            this.dhres.Name = "dhres";
            this.dhres.ReadOnly = true;
            this.dhres.Size = new System.Drawing.Size(60, 21);
            this.dhres.TabIndex = 94;
            // 
            // ESRTres
            // 
            this.ESRTres.Location = new System.Drawing.Point(489, 191);
            this.ESRTres.Margin = new System.Windows.Forms.Padding(2);
            this.ESRTres.Name = "ESRTres";
            this.ESRTres.ReadOnly = true;
            this.ESRTres.Size = new System.Drawing.Size(60, 21);
            this.ESRTres.TabIndex = 93;
            // 
            // dres
            // 
            this.dres.Location = new System.Drawing.Point(175, 230);
            this.dres.Margin = new System.Windows.Forms.Padding(2);
            this.dres.Name = "dres";
            this.dres.ReadOnly = true;
            this.dres.Size = new System.Drawing.Size(60, 21);
            this.dres.TabIndex = 92;
            // 
            // Pres
            // 
            this.Pres.Location = new System.Drawing.Point(175, 254);
            this.Pres.Margin = new System.Windows.Forms.Padding(2);
            this.Pres.Name = "Pres";
            this.Pres.ReadOnly = true;
            this.Pres.Size = new System.Drawing.Size(60, 21);
            this.Pres.TabIndex = 91;
            // 
            // D1Label
            // 
            this.D1Label.AutoSize = true;
            this.D1Label.Location = new System.Drawing.Point(136, 430);
            this.D1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.D1Label.Name = "D1Label";
            this.D1Label.Size = new System.Drawing.Size(35, 12);
            this.D1Label.TabIndex = 89;
            this.D1Label.Text = "D1 = ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 430);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 90;
            this.label15.Text = "螺母螺纹小径";
            // 
            // lsLabel
            // 
            this.lsLabel.AutoSize = true;
            this.lsLabel.Location = new System.Drawing.Point(136, 405);
            this.lsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lsLabel.Name = "lsLabel";
            this.lsLabel.Size = new System.Drawing.Size(35, 12);
            this.lsLabel.TabIndex = 88;
            this.lsLabel.Text = "ls = ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 405);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 87;
            this.label13.Text = "螺栓长度";
            // 
            // d3Label
            // 
            this.d3Label.AutoSize = true;
            this.d3Label.Location = new System.Drawing.Point(136, 380);
            this.d3Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.d3Label.Name = "d3Label";
            this.d3Label.Size = new System.Drawing.Size(35, 12);
            this.d3Label.TabIndex = 86;
            this.d3Label.Text = "d3 = ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 380);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 85;
            this.label12.Text = "螺纹小径";
            // 
            // d2Label
            // 
            this.d2Label.AutoSize = true;
            this.d2Label.Location = new System.Drawing.Point(136, 355);
            this.d2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.d2Label.Name = "d2Label";
            this.d2Label.Size = new System.Drawing.Size(35, 12);
            this.d2Label.TabIndex = 84;
            this.d2Label.Text = "d2 = ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 355);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 83;
            this.label11.Text = "螺纹中径";
            // 
            // daLabel
            // 
            this.daLabel.AutoSize = true;
            this.daLabel.Location = new System.Drawing.Point(136, 330);
            this.daLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.daLabel.Name = "daLabel";
            this.daLabel.Size = new System.Drawing.Size(35, 12);
            this.daLabel.TabIndex = 82;
            this.daLabel.Text = "da = ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 330);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 81;
            this.label10.Text = "螺栓头承载面内径";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(434, 243);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 80;
            this.label16.Text = "Rpmin = ";
            // 
            // dwLabel
            // 
            this.dwLabel.AutoSize = true;
            this.dwLabel.Location = new System.Drawing.Point(136, 306);
            this.dwLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dwLabel.Name = "dwLabel";
            this.dwLabel.Size = new System.Drawing.Size(35, 12);
            this.dwLabel.TabIndex = 79;
            this.dwLabel.Text = "dw = ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 243);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 12);
            this.label14.TabIndex = 78;
            this.label14.Text = "室温下螺栓的最小屈服强度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 306);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 77;
            this.label9.Text = "螺栓头承载面外径";
            // 
            // RmLabel
            // 
            this.RmLabel.AutoSize = true;
            this.RmLabel.Location = new System.Drawing.Point(451, 218);
            this.RmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RmLabel.Name = "RmLabel";
            this.RmLabel.Size = new System.Drawing.Size(35, 12);
            this.RmLabel.TabIndex = 76;
            this.RmLabel.Text = "Rm = ";
            // 
            // dhLabel
            // 
            this.dhLabel.AutoSize = true;
            this.dhLabel.Location = new System.Drawing.Point(136, 281);
            this.dhLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dhLabel.Name = "dhLabel";
            this.dhLabel.Size = new System.Drawing.Size(35, 12);
            this.dhLabel.TabIndex = 75;
            this.dhLabel.Text = "dh = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 73;
            this.label5.Text = "室温下螺栓的抗拉强度";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(553, 246);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 12);
            this.label25.TabIndex = 55;
            this.label25.Text = "N/mm2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(553, 222);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 56;
            this.label24.Text = "N/mm2";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(553, 198);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 12);
            this.label23.TabIndex = 57;
            this.label23.Text = "N/mm2";
            // 
            // ESRTLabel
            // 
            this.ESRTLabel.AutoSize = true;
            this.ESRTLabel.Location = new System.Drawing.Point(439, 194);
            this.ESRTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ESRTLabel.Name = "ESRTLabel";
            this.ESRTLabel.Size = new System.Drawing.Size(47, 12);
            this.ESRTLabel.TabIndex = 58;
            this.ESRTLabel.Text = "ESRT = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 281);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 74;
            this.label8.Text = "镗孔直径\"中\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 59;
            this.label3.Text = "室温下螺栓材料的杨氏模量";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(238, 434);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 60;
            this.label22.Text = "mm";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(238, 409);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 12);
            this.label21.TabIndex = 61;
            this.label21.Text = "mm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(238, 384);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 12);
            this.label20.TabIndex = 62;
            this.label20.Text = "mm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(238, 359);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 71;
            this.label19.Text = "mm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(238, 334);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 64;
            this.label18.Text = "mm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(238, 309);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 63;
            this.label17.Text = "mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 284);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 72;
            this.label6.Text = "mm";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(238, 237);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 12);
            this.label28.TabIndex = 65;
            this.label28.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 66;
            this.label4.Text = "mm";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(142, 233);
            this.dLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(29, 12);
            this.dLabel.TabIndex = 67;
            this.dLabel.Text = "d = ";
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(142, 256);
            this.PLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(29, 12);
            this.PLabel.TabIndex = 68;
            this.PLabel.Text = "P = ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(39, 233);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 12);
            this.label26.TabIndex = 69;
            this.label26.Text = "公称直径";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 70;
            this.label7.Text = "螺距";
            // 
            // hexagonHeadedBoltLabel
            // 
            this.hexagonHeadedBoltLabel.AutoSize = true;
            this.hexagonHeadedBoltLabel.Location = new System.Drawing.Point(39, 200);
            this.hexagonHeadedBoltLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hexagonHeadedBoltLabel.Name = "hexagonHeadedBoltLabel";
            this.hexagonHeadedBoltLabel.Size = new System.Drawing.Size(65, 12);
            this.hexagonHeadedBoltLabel.TabIndex = 54;
            this.hexagonHeadedBoltLabel.Text = "六角头螺栓";
            // 
            // strengthGradeLabel
            // 
            this.strengthGradeLabel.AutoSize = true;
            this.strengthGradeLabel.Location = new System.Drawing.Point(358, 167);
            this.strengthGradeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strengthGradeLabel.Name = "strengthGradeLabel";
            this.strengthGradeLabel.Size = new System.Drawing.Size(11, 12);
            this.strengthGradeLabel.TabIndex = 53;
            this.strengthGradeLabel.Text = " ";
            // 
            // boltStdDimStrengthValue
            // 
            this.boltStdDimStrengthValue.AutoSize = true;
            this.boltStdDimStrengthValue.Location = new System.Drawing.Point(105, 167);
            this.boltStdDimStrengthValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boltStdDimStrengthValue.Name = "boltStdDimStrengthValue";
            this.boltStdDimStrengthValue.Size = new System.Drawing.Size(11, 12);
            this.boltStdDimStrengthValue.TabIndex = 52;
            this.boltStdDimStrengthValue.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 51;
            this.label2.Text = "强度等级";
            // 
            // boltStdDimStrengthLabel
            // 
            this.boltStdDimStrengthLabel.AutoSize = true;
            this.boltStdDimStrengthLabel.Location = new System.Drawing.Point(37, 167);
            this.boltStdDimStrengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boltStdDimStrengthLabel.Name = "boltStdDimStrengthLabel";
            this.boltStdDimStrengthLabel.Size = new System.Drawing.Size(53, 12);
            this.boltStdDimStrengthLabel.TabIndex = 50;
            this.boltStdDimStrengthLabel.Text = "圆柱螺栓";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(284, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 49;
            this.label1.Text = "材料数据：";
            // 
            // physicalDimensionLabel
            // 
            this.physicalDimensionLabel.AutoSize = true;
            this.physicalDimensionLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.physicalDimensionLabel.Location = new System.Drawing.Point(39, 131);
            this.physicalDimensionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.physicalDimensionLabel.Name = "physicalDimensionLabel";
            this.physicalDimensionLabel.Size = new System.Drawing.Size(70, 12);
            this.physicalDimensionLabel.TabIndex = 48;
            this.physicalDimensionLabel.Text = "几何尺寸：";
            // 
            // optBtn
            // 
            this.optBtn.Location = new System.Drawing.Point(39, 66);
            this.optBtn.Margin = new System.Windows.Forms.Padding(2);
            this.optBtn.Name = "optBtn";
            this.optBtn.Size = new System.Drawing.Size(77, 34);
            this.optBtn.TabIndex = 47;
            this.optBtn.Text = "选择";
            this.optBtn.UseVisualStyleBackColor = true;
            this.optBtn.Click += new System.EventHandler(this.optBtn_Click_1);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(158, 66);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 34);
            this.cancelBtn.TabIndex = 47;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // InitDesignChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 514);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InitDesignChooseForm";
            this.Text = "InitDesignChooseForm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox D1res;
        private System.Windows.Forms.TextBox lsres;
        private System.Windows.Forms.TextBox d3res;
        private System.Windows.Forms.TextBox d2res;
        private System.Windows.Forms.TextBox dares;
        private System.Windows.Forms.TextBox Rpminres;
        private System.Windows.Forms.TextBox dwres;
        private System.Windows.Forms.TextBox Rmres;
        private System.Windows.Forms.TextBox dhres;
        private System.Windows.Forms.TextBox ESRTres;
        private System.Windows.Forms.TextBox dres;
        private System.Windows.Forms.TextBox Pres;
        private System.Windows.Forms.Label D1Label;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lsLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label d3Label;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label d2Label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label daLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label dwLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label RmLabel;
        private System.Windows.Forms.Label dhLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label ESRTLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label hexagonHeadedBoltLabel;
        private System.Windows.Forms.Label strengthGradeLabel;
        private System.Windows.Forms.Label boltStdDimStrengthValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label boltStdDimStrengthLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label physicalDimensionLabel;
        private System.Windows.Forms.Button optBtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private devDept.Eyeshot.Model model1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn std;
        private System.Windows.Forms.DataGridViewTextBoxColumn DN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ls;
        private System.Windows.Forms.DataGridViewTextBoxColumn l1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dh;
        private System.Windows.Forms.Button cancelBtn;
    }
}