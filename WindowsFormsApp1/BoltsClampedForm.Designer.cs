namespace WindowsFormsApp1
{
    partial class BoltsClampedForm
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
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 4.45999899081269D, false, 0.001D);
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
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(867, 446), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.model1 = new devDept.Eyeshot.Model();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PropeField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._importFEMBtn = new System.Windows.Forms.Button();
            this._okBtn = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.VdiMultiDesign = new System.Windows.Forms.GroupBox();
            this.pianxin = new System.Windows.Forms.TextBox();
            this.PianXinLabel = new System.Windows.Forms.Label();
            this.FQPianxinBtn = new System.Windows.Forms.CheckBox();
            this.VDICalBtn = new System.Windows.Forms.Button();
            this.ZaiHeBtn = new System.Windows.Forms.Button();
            this.GongYiBtn = new System.Windows.Forms.Button();
            this.JiheBtn = new System.Windows.Forms.Button();
            this.ClampedMaterialBtn = new System.Windows.Forms.Button();
            this.BoltMaterialBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.docBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.VdiMultiDesign.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1207, 746);
            this.splitContainer1.SplitterDistance = 867;
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
            this.splitContainer2.Panel1.Controls.Add(this.model1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(867, 746);
            this.splitContainer2.SplitterDistance = 446;
            this.splitContainer2.TabIndex = 2;
            // 
            // model1
            // 
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model1.Location = new System.Drawing.Point(0, 0);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar1;
            this.model1.Size = new System.Drawing.Size(867, 446);
            this.model1.TabIndex = 1;
            this.model1.Text = "model1";
            coordinateSystemIcon1.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport1.CoordinateSystemIcon = coordinateSystemIcon1;
            viewport1.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol1.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport1.OriginSymbol = originSymbol1;
            viewCubeIcon1.Font = null;
            viewCubeIcon1.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport1.ViewCubeIcon = viewCubeIcon1;
            this.model1.Viewports.Add(viewport1);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(867, 296);
            this.splitContainer3.SplitterDistance = 600;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropeField,
            this.ValueField,
            this.DescField});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(600, 296);
            this.dataGridView1.TabIndex = 1;
            // 
            // PropeField
            // 
            this.PropeField.HeaderText = "属性";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._importFEMBtn);
            this.groupBox1.Controls.Add(this._okBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "有限元计算";
            // 
            // _importFEMBtn
            // 
            this._importFEMBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._importFEMBtn.Location = new System.Drawing.Point(3, 40);
            this._importFEMBtn.Name = "_importFEMBtn";
            this._importFEMBtn.Size = new System.Drawing.Size(257, 23);
            this._importFEMBtn.TabIndex = 3;
            this._importFEMBtn.Text = "导入有限元";
            this._importFEMBtn.UseVisualStyleBackColor = true;
            this._importFEMBtn.Click += new System.EventHandler(this._importFEMBtn_Click_1);
            // 
            // _okBtn
            // 
            this._okBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._okBtn.Location = new System.Drawing.Point(3, 17);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(257, 23);
            this._okBtn.TabIndex = 2;
            this._okBtn.Text = "完成";
            this._okBtn.UseVisualStyleBackColor = true;
            this._okBtn.Click += new System.EventHandler(this._okBtn_Click_1);
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
            this.splitContainer4.Panel1.AutoScroll = true;
            this.splitContainer4.Panel1.Controls.Add(this.VdiMultiDesign);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer4.Size = new System.Drawing.Size(336, 746);
            this.splitContainer4.SplitterDistance = 291;
            this.splitContainer4.TabIndex = 0;
            // 
            // VdiMultiDesign
            // 
            this.VdiMultiDesign.Controls.Add(this.docBtn);
            this.VdiMultiDesign.Controls.Add(this.pianxin);
            this.VdiMultiDesign.Controls.Add(this.PianXinLabel);
            this.VdiMultiDesign.Controls.Add(this.FQPianxinBtn);
            this.VdiMultiDesign.Controls.Add(this.VDICalBtn);
            this.VdiMultiDesign.Controls.Add(this.ZaiHeBtn);
            this.VdiMultiDesign.Controls.Add(this.GongYiBtn);
            this.VdiMultiDesign.Controls.Add(this.JiheBtn);
            this.VdiMultiDesign.Controls.Add(this.ClampedMaterialBtn);
            this.VdiMultiDesign.Controls.Add(this.BoltMaterialBtn);
            this.VdiMultiDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VdiMultiDesign.Location = new System.Drawing.Point(0, 0);
            this.VdiMultiDesign.Name = "VdiMultiDesign";
            this.VdiMultiDesign.Size = new System.Drawing.Size(336, 291);
            this.VdiMultiDesign.TabIndex = 0;
            this.VdiMultiDesign.TabStop = false;
            this.VdiMultiDesign.Text = "VDI多螺栓刚体力学设计";
            // 
            // pianxin
            // 
            this.pianxin.Location = new System.Drawing.Point(246, 251);
            this.pianxin.Name = "pianxin";
            this.pianxin.Size = new System.Drawing.Size(84, 21);
            this.pianxin.TabIndex = 4;
            this.pianxin.Visible = false;
            // 
            // PianXinLabel
            // 
            this.PianXinLabel.AutoSize = true;
            this.PianXinLabel.Location = new System.Drawing.Point(171, 257);
            this.PianXinLabel.Name = "PianXinLabel";
            this.PianXinLabel.Size = new System.Drawing.Size(53, 12);
            this.PianXinLabel.TabIndex = 3;
            this.PianXinLabel.Text = "偏心距：";
            this.PianXinLabel.Visible = false;
            // 
            // FQPianxinBtn
            // 
            this.FQPianxinBtn.AutoSize = true;
            this.FQPianxinBtn.Location = new System.Drawing.Point(16, 257);
            this.FQPianxinBtn.Name = "FQPianxinBtn";
            this.FQPianxinBtn.Size = new System.Drawing.Size(120, 16);
            this.FQPianxinBtn.TabIndex = 2;
            this.FQPianxinBtn.Text = "横向载荷不过形心";
            this.FQPianxinBtn.UseVisualStyleBackColor = true;
            this.FQPianxinBtn.CheckedChanged += new System.EventHandler(this.FQPianxinBtn_CheckedChanged);
            // 
            // VDICalBtn
            // 
            this.VDICalBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.VDICalBtn.Location = new System.Drawing.Point(3, 176);
            this.VDICalBtn.Name = "VDICalBtn";
            this.VDICalBtn.Size = new System.Drawing.Size(330, 31);
            this.VDICalBtn.TabIndex = 1;
            this.VDICalBtn.Text = "VDI多螺栓验证设计";
            this.VDICalBtn.UseVisualStyleBackColor = true;
            this.VDICalBtn.Click += new System.EventHandler(this.VDICalBtn_Click);
            // 
            // ZaiHeBtn
            // 
            this.ZaiHeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZaiHeBtn.Location = new System.Drawing.Point(3, 145);
            this.ZaiHeBtn.Name = "ZaiHeBtn";
            this.ZaiHeBtn.Size = new System.Drawing.Size(330, 31);
            this.ZaiHeBtn.TabIndex = 0;
            this.ZaiHeBtn.Text = "载荷参数";
            this.ZaiHeBtn.UseVisualStyleBackColor = true;
            this.ZaiHeBtn.Click += new System.EventHandler(this.ZaiHeBtn_Click);
            // 
            // GongYiBtn
            // 
            this.GongYiBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GongYiBtn.Location = new System.Drawing.Point(3, 113);
            this.GongYiBtn.Name = "GongYiBtn";
            this.GongYiBtn.Size = new System.Drawing.Size(330, 32);
            this.GongYiBtn.TabIndex = 0;
            this.GongYiBtn.Text = "工艺参数";
            this.GongYiBtn.UseVisualStyleBackColor = true;
            this.GongYiBtn.Click += new System.EventHandler(this.GongYiBtn_Click);
            // 
            // JiheBtn
            // 
            this.JiheBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.JiheBtn.Location = new System.Drawing.Point(3, 81);
            this.JiheBtn.Name = "JiheBtn";
            this.JiheBtn.Size = new System.Drawing.Size(330, 32);
            this.JiheBtn.TabIndex = 0;
            this.JiheBtn.Text = "几何参数";
            this.JiheBtn.UseVisualStyleBackColor = true;
            this.JiheBtn.Click += new System.EventHandler(this.JiheBtn_Click);
            // 
            // ClampedMaterialBtn
            // 
            this.ClampedMaterialBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClampedMaterialBtn.Location = new System.Drawing.Point(3, 49);
            this.ClampedMaterialBtn.Name = "ClampedMaterialBtn";
            this.ClampedMaterialBtn.Size = new System.Drawing.Size(330, 32);
            this.ClampedMaterialBtn.TabIndex = 0;
            this.ClampedMaterialBtn.Text = "连接件材料选择";
            this.ClampedMaterialBtn.UseVisualStyleBackColor = true;
            this.ClampedMaterialBtn.Click += new System.EventHandler(this.ClampedMaterialBtn_Click);
            // 
            // BoltMaterialBtn
            // 
            this.BoltMaterialBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BoltMaterialBtn.Location = new System.Drawing.Point(3, 17);
            this.BoltMaterialBtn.Name = "BoltMaterialBtn";
            this.BoltMaterialBtn.Size = new System.Drawing.Size(330, 32);
            this.BoltMaterialBtn.TabIndex = 0;
            this.BoltMaterialBtn.Text = "螺栓材料选择";
            this.BoltMaterialBtn.UseVisualStyleBackColor = true;
            this.BoltMaterialBtn.Click += new System.EventHandler(this.BoltMaterialBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 451);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数列表";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.param,
            this.value});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(330, 431);
            this.dataGridView2.TabIndex = 3;
            // 
            // param
            // 
            this.param.HeaderText = "属性";
            this.param.Name = "param";
            this.param.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "值";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // docBtn
            // 
            this.docBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.docBtn.Location = new System.Drawing.Point(3, 207);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(330, 31);
            this.docBtn.TabIndex = 5;
            this.docBtn.Text = "输出多螺栓计算文档";
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // BoltsClampedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 746);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BoltsClampedForm";
            this.Text = "BoltsClampedForm";
            this.Load += new System.EventHandler(this.BoltsClampedForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.VdiMultiDesign.ResumeLayout(false);
            this.VdiMultiDesign.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private devDept.Eyeshot.Model model1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropeField;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueField;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescField;
        private System.Windows.Forms.GroupBox VdiMultiDesign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _importFEMBtn;
        private System.Windows.Forms.Button _okBtn;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button GongYiBtn;
        private System.Windows.Forms.Button JiheBtn;
        private System.Windows.Forms.Button ClampedMaterialBtn;
        private System.Windows.Forms.Button BoltMaterialBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn param;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button VDICalBtn;
        private System.Windows.Forms.Button ZaiHeBtn;
        private System.Windows.Forms.TextBox pianxin;
        private System.Windows.Forms.Label PianXinLabel;
        private System.Windows.Forms.CheckBox FQPianxinBtn;
        private System.Windows.Forms.Button docBtn;
    }
}