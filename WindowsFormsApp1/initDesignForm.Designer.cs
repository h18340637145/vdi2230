namespace WindowsFormsApp1
{
    partial class InitDesignForm
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
            this.strengthGradeAndDNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet7 = new WindowsFormsApp1.BoltConnectionSystemDataSet7();
            this.strengthGradeAndDNTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet7TableAdapters.strengthGradeAndDNTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.optBtn = new System.Windows.Forms.Button();
            this.computeBtn = new System.Windows.Forms.Button();
            this.tightenTheProcess = new System.Windows.Forms.ComboBox();
            this.TightenTheProcessLabel = new System.Windows.Forms.Label();
            this.isEccentricLabel = new System.Windows.Forms.Label();
            this.isEccentric = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpperLimitAxialLoadDisplay = new System.Windows.Forms.Label();
            this.UTmin = new System.Windows.Forms.TextBox();
            this.FQ = new System.Windows.Forms.TextBox();
            this.upperLimitAxialLoad = new System.Windows.Forms.TextBox();
            this.uTminLabel = new System.Windows.Forms.Label();
            this.FQLabel = new System.Windows.Forms.Label();
            this.UpperLimitAxialLoadLabel = new System.Windows.Forms.Label();
            this.workingLoads = new System.Windows.Forms.ComboBox();
            this.workingLoadsLabel = new System.Windows.Forms.Label();
            this.boltType = new System.Windows.Forms.ComboBox();
            this.boltTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet1 = new WindowsFormsApp1.BoltConnectionSystemDataSet1();
            this.dboboltTypeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet15 = new WindowsFormsApp1.BoltConnectionSystemDataSet15();
            this.boltTypeLabel = new System.Windows.Forms.Label();
            this.screwType = new System.Windows.Forms.ComboBox();
            this.boltConType = new System.Windows.Forms.ComboBox();
            this.screwTypeLabel = new System.Windows.Forms.Label();
            this.BoltConTypeLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boltTypeTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet1TableAdapters.boltTypeTableTableAdapter();
            this.boltConnectionSystemDataSet14 = new WindowsFormsApp1.BoltConnectionSystemDataSet14();
            this.dboboltTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_boltTypeTableTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet14TableAdapters.dbo_boltTypeTableTableAdapter();
            this.dbo_boltTypeTableTableAdapter1 = new WindowsFormsApp1.BoltConnectionSystemDataSet15TableAdapters.dbo_boltTypeTableTableAdapter();
            this.strengthGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.strengthGradeAndDNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet7)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boltTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltTypeTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltTypeTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // strengthGradeAndDNBindingSource
            // 
            this.strengthGradeAndDNBindingSource.DataMember = "strengthGradeAndDN";
            this.strengthGradeAndDNBindingSource.DataSource = this.boltConnectionSystemDataSet7;
            // 
            // boltConnectionSystemDataSet7
            // 
            this.boltConnectionSystemDataSet7.DataSetName = "BoltConnectionSystemDataSet7";
            this.boltConnectionSystemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // strengthGradeAndDNTableAdapter
            // 
            this.strengthGradeAndDNTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(71, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 398);
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
            this.splitContainer1.Panel1.Controls.Add(this.optBtn);
            this.splitContainer1.Panel1.Controls.Add(this.computeBtn);
            this.splitContainer1.Panel1.Controls.Add(this.tightenTheProcess);
            this.splitContainer1.Panel1.Controls.Add(this.TightenTheProcessLabel);
            this.splitContainer1.Panel1.Controls.Add(this.isEccentricLabel);
            this.splitContainer1.Panel1.Controls.Add(this.isEccentric);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.UpperLimitAxialLoadDisplay);
            this.splitContainer1.Panel1.Controls.Add(this.UTmin);
            this.splitContainer1.Panel1.Controls.Add(this.FQ);
            this.splitContainer1.Panel1.Controls.Add(this.upperLimitAxialLoad);
            this.splitContainer1.Panel1.Controls.Add(this.uTminLabel);
            this.splitContainer1.Panel1.Controls.Add(this.FQLabel);
            this.splitContainer1.Panel1.Controls.Add(this.UpperLimitAxialLoadLabel);
            this.splitContainer1.Panel1.Controls.Add(this.workingLoads);
            this.splitContainer1.Panel1.Controls.Add(this.workingLoadsLabel);
            this.splitContainer1.Panel1.Controls.Add(this.boltType);
            this.splitContainer1.Panel1.Controls.Add(this.boltTypeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.screwType);
            this.splitContainer1.Panel1.Controls.Add(this.boltConType);
            this.splitContainer1.Panel1.Controls.Add(this.screwTypeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.BoltConTypeLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 398);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // optBtn
            // 
            this.optBtn.Location = new System.Drawing.Point(146, 359);
            this.optBtn.Margin = new System.Windows.Forms.Padding(2);
            this.optBtn.Name = "optBtn";
            this.optBtn.Size = new System.Drawing.Size(71, 30);
            this.optBtn.TabIndex = 50;
            this.optBtn.Text = "选择";
            this.optBtn.UseVisualStyleBackColor = true;
            this.optBtn.Click += new System.EventHandler(this.optBtn_Click);
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(21, 359);
            this.computeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(71, 30);
            this.computeBtn.TabIndex = 49;
            this.computeBtn.Text = "计算";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click_1);
            // 
            // tightenTheProcess
            // 
            this.tightenTheProcess.FormattingEnabled = true;
            this.tightenTheProcess.Items.AddRange(new object[] {
            "屈服控制拧紧",
            "转角控制拧紧",
            "实验室测定必须拧紧力矩的扭矩扳手",
            "B级预估摩擦系数的扭矩扳手",
            "A级预估摩擦系数的扭矩扳手",
            "冲击扳手或扭矩控制的冲击扳手拧紧"});
            this.tightenTheProcess.Location = new System.Drawing.Point(130, 275);
            this.tightenTheProcess.Margin = new System.Windows.Forms.Padding(2);
            this.tightenTheProcess.Name = "tightenTheProcess";
            this.tightenTheProcess.Size = new System.Drawing.Size(92, 20);
            this.tightenTheProcess.TabIndex = 48;
            // 
            // TightenTheProcessLabel
            // 
            this.TightenTheProcessLabel.AutoSize = true;
            this.TightenTheProcessLabel.Location = new System.Drawing.Point(25, 279);
            this.TightenTheProcessLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TightenTheProcessLabel.Name = "TightenTheProcessLabel";
            this.TightenTheProcessLabel.Size = new System.Drawing.Size(65, 12);
            this.TightenTheProcessLabel.TabIndex = 47;
            this.TightenTheProcessLabel.Text = "拧紧工艺：";
            // 
            // isEccentricLabel
            // 
            this.isEccentricLabel.AutoSize = true;
            this.isEccentricLabel.Location = new System.Drawing.Point(22, 245);
            this.isEccentricLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isEccentricLabel.Name = "isEccentricLabel";
            this.isEccentricLabel.Size = new System.Drawing.Size(65, 12);
            this.isEccentricLabel.TabIndex = 46;
            this.isEccentricLabel.Text = "是否偏心：";
            // 
            // isEccentric
            // 
            this.isEccentric.FormattingEnabled = true;
            this.isEccentric.Items.AddRange(new object[] {
            "是",
            "否"});
            this.isEccentric.Location = new System.Drawing.Point(130, 240);
            this.isEccentric.Margin = new System.Windows.Forms.Padding(2);
            this.isEccentric.Name = "isEccentric";
            this.isEccentric.Size = new System.Drawing.Size(92, 20);
            this.isEccentric.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 310);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "N";
            // 
            // UpperLimitAxialLoadDisplay
            // 
            this.UpperLimitAxialLoadDisplay.AutoSize = true;
            this.UpperLimitAxialLoadDisplay.Location = new System.Drawing.Point(235, 205);
            this.UpperLimitAxialLoadDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpperLimitAxialLoadDisplay.Name = "UpperLimitAxialLoadDisplay";
            this.UpperLimitAxialLoadDisplay.Size = new System.Drawing.Size(11, 12);
            this.UpperLimitAxialLoadDisplay.TabIndex = 44;
            this.UpperLimitAxialLoadDisplay.Text = "N";
            // 
            // UTmin
            // 
            this.UTmin.Location = new System.Drawing.Point(132, 332);
            this.UTmin.Margin = new System.Windows.Forms.Padding(2);
            this.UTmin.Name = "UTmin";
            this.UTmin.Size = new System.Drawing.Size(92, 21);
            this.UTmin.TabIndex = 43;
            this.UTmin.Visible = false;
            // 
            // FQ
            // 
            this.FQ.Location = new System.Drawing.Point(132, 307);
            this.FQ.Margin = new System.Windows.Forms.Padding(2);
            this.FQ.Name = "FQ";
            this.FQ.Size = new System.Drawing.Size(92, 21);
            this.FQ.TabIndex = 43;
            this.FQ.Visible = false;
            // 
            // upperLimitAxialLoad
            // 
            this.upperLimitAxialLoad.Location = new System.Drawing.Point(130, 202);
            this.upperLimitAxialLoad.Margin = new System.Windows.Forms.Padding(2);
            this.upperLimitAxialLoad.Name = "upperLimitAxialLoad";
            this.upperLimitAxialLoad.Size = new System.Drawing.Size(92, 21);
            this.upperLimitAxialLoad.TabIndex = 43;
            // 
            // uTminLabel
            // 
            this.uTminLabel.AutoSize = true;
            this.uTminLabel.Location = new System.Drawing.Point(18, 335);
            this.uTminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uTminLabel.Name = "uTminLabel";
            this.uTminLabel.Size = new System.Drawing.Size(95, 12);
            this.uTminLabel.TabIndex = 42;
            this.uTminLabel.Text = "摩擦系数UTmin：";
            this.uTminLabel.Visible = false;
            // 
            // FQLabel
            // 
            this.FQLabel.AutoSize = true;
            this.FQLabel.Location = new System.Drawing.Point(18, 310);
            this.FQLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FQLabel.Name = "FQLabel";
            this.FQLabel.Size = new System.Drawing.Size(77, 12);
            this.FQLabel.TabIndex = 42;
            this.FQLabel.Text = "轴向载荷FQ：";
            this.FQLabel.Visible = false;
            // 
            // UpperLimitAxialLoadLabel
            // 
            this.UpperLimitAxialLoadLabel.AutoSize = true;
            this.UpperLimitAxialLoadLabel.Location = new System.Drawing.Point(20, 205);
            this.UpperLimitAxialLoadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpperLimitAxialLoadLabel.Name = "UpperLimitAxialLoadLabel";
            this.UpperLimitAxialLoadLabel.Size = new System.Drawing.Size(113, 12);
            this.UpperLimitAxialLoadLabel.TabIndex = 42;
            this.UpperLimitAxialLoadLabel.Text = "轴向载荷的上限值：";
            // 
            // workingLoads
            // 
            this.workingLoads.FormattingEnabled = true;
            this.workingLoads.Items.AddRange(new object[] {
            "动态",
            "静态"});
            this.workingLoads.Location = new System.Drawing.Point(130, 159);
            this.workingLoads.Margin = new System.Windows.Forms.Padding(2);
            this.workingLoads.Name = "workingLoads";
            this.workingLoads.Size = new System.Drawing.Size(92, 20);
            this.workingLoads.TabIndex = 41;
            // 
            // workingLoadsLabel
            // 
            this.workingLoadsLabel.AutoSize = true;
            this.workingLoadsLabel.Location = new System.Drawing.Point(20, 162);
            this.workingLoadsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workingLoadsLabel.Name = "workingLoadsLabel";
            this.workingLoadsLabel.Size = new System.Drawing.Size(65, 12);
            this.workingLoadsLabel.TabIndex = 40;
            this.workingLoadsLabel.Text = "工作载荷：";
            // 
            // boltType
            // 
            this.boltType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.boltTypeTableBindingSource, "boltType", true));
            this.boltType.DataSource = this.dboboltTypeTableBindingSource1;
            this.boltType.DisplayMember = "boltType";
            this.boltType.FormattingEnabled = true;
            this.boltType.Location = new System.Drawing.Point(130, 116);
            this.boltType.Margin = new System.Windows.Forms.Padding(2);
            this.boltType.Name = "boltType";
            this.boltType.Size = new System.Drawing.Size(92, 20);
            this.boltType.TabIndex = 39;
            this.boltType.ValueMember = "boltType";
            // 
            // boltTypeTableBindingSource
            // 
            this.boltTypeTableBindingSource.DataMember = "boltTypeTable";
            this.boltTypeTableBindingSource.DataSource = this.boltConnectionSystemDataSet1;
            // 
            // boltConnectionSystemDataSet1
            // 
            this.boltConnectionSystemDataSet1.DataSetName = "BoltConnectionSystemDataSet1";
            this.boltConnectionSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dboboltTypeTableBindingSource1
            // 
            this.dboboltTypeTableBindingSource1.DataMember = "dbo_boltTypeTable";
            this.dboboltTypeTableBindingSource1.DataSource = this.boltConnectionSystemDataSet15;
            // 
            // boltConnectionSystemDataSet15
            // 
            this.boltConnectionSystemDataSet15.DataSetName = "BoltConnectionSystemDataSet15";
            this.boltConnectionSystemDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boltTypeLabel
            // 
            this.boltTypeLabel.AutoSize = true;
            this.boltTypeLabel.Location = new System.Drawing.Point(20, 118);
            this.boltTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.boltTypeLabel.Name = "boltTypeLabel";
            this.boltTypeLabel.Size = new System.Drawing.Size(65, 12);
            this.boltTypeLabel.TabIndex = 38;
            this.boltTypeLabel.Text = "螺栓类型：";
            // 
            // screwType
            // 
            this.screwType.FormattingEnabled = true;
            this.screwType.Items.AddRange(new object[] {
            "标准螺纹",
            "细牙螺纹"});
            this.screwType.Location = new System.Drawing.Point(130, 72);
            this.screwType.Margin = new System.Windows.Forms.Padding(2);
            this.screwType.Name = "screwType";
            this.screwType.Size = new System.Drawing.Size(92, 20);
            this.screwType.TabIndex = 37;
            // 
            // boltConType
            // 
            this.boltConType.FormattingEnabled = true;
            this.boltConType.Items.AddRange(new object[] {
            "单螺栓连接",
            "受横向载荷的螺栓连接"});
            this.boltConType.Location = new System.Drawing.Point(130, 31);
            this.boltConType.Margin = new System.Windows.Forms.Padding(2);
            this.boltConType.Name = "boltConType";
            this.boltConType.Size = new System.Drawing.Size(92, 20);
            this.boltConType.TabIndex = 36;
            this.boltConType.SelectedIndexChanged += new System.EventHandler(this.boltConType_SelectedIndexChanged);
            // 
            // screwTypeLabel
            // 
            this.screwTypeLabel.AutoSize = true;
            this.screwTypeLabel.Location = new System.Drawing.Point(20, 76);
            this.screwTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.screwTypeLabel.Name = "screwTypeLabel";
            this.screwTypeLabel.Size = new System.Drawing.Size(65, 12);
            this.screwTypeLabel.TabIndex = 35;
            this.screwTypeLabel.Text = "螺纹类型：";
            // 
            // BoltConTypeLabel
            // 
            this.BoltConTypeLabel.AutoSize = true;
            this.BoltConTypeLabel.Location = new System.Drawing.Point(20, 33);
            this.BoltConTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoltConTypeLabel.Name = "BoltConTypeLabel";
            this.BoltConTypeLabel.Size = new System.Drawing.Size(89, 12);
            this.BoltConTypeLabel.TabIndex = 34;
            this.BoltConTypeLabel.Text = "螺栓连接类型：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.strengthGrade,
            this.DN});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(325, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // boltTypeTableTableAdapter
            // 
            this.boltTypeTableTableAdapter.ClearBeforeFill = true;
            // 
            // boltConnectionSystemDataSet14
            // 
            this.boltConnectionSystemDataSet14.DataSetName = "BoltConnectionSystemDataSet14";
            this.boltConnectionSystemDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dboboltTypeTableBindingSource
            // 
            this.dboboltTypeTableBindingSource.DataMember = "dbo_boltTypeTable";
            this.dboboltTypeTableBindingSource.DataSource = this.boltConnectionSystemDataSet14;
            // 
            // dbo_boltTypeTableTableAdapter
            // 
            this.dbo_boltTypeTableTableAdapter.ClearBeforeFill = true;
            // 
            // dbo_boltTypeTableTableAdapter1
            // 
            this.dbo_boltTypeTableTableAdapter1.ClearBeforeFill = true;
            // 
            // strengthGrade
            // 
            this.strengthGrade.HeaderText = "强度等级";
            this.strengthGrade.Name = "strengthGrade";
            // 
            // DN
            // 
            this.DN.HeaderText = "公称直径(mm)";
            this.DN.Name = "DN";
            // 
            // InitDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(742, 452);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InitDesignForm";
            this.Text = "initDesignForm";
            this.Load += new System.EventHandler(this.InitDesignForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strengthGradeAndDNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boltTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltTypeTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dboboltTypeTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BoltConnectionSystemDataSet7 boltConnectionSystemDataSet7;
        private System.Windows.Forms.BindingSource strengthGradeAndDNBindingSource;
        private BoltConnectionSystemDataSet7TableAdapters.strengthGradeAndDNTableAdapter strengthGradeAndDNTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button optBtn;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.ComboBox tightenTheProcess;
        private System.Windows.Forms.Label TightenTheProcessLabel;
        private System.Windows.Forms.Label isEccentricLabel;
        private System.Windows.Forms.ComboBox isEccentric;
        private System.Windows.Forms.Label UpperLimitAxialLoadDisplay;
        private System.Windows.Forms.TextBox upperLimitAxialLoad;
        private System.Windows.Forms.Label UpperLimitAxialLoadLabel;
        private System.Windows.Forms.ComboBox workingLoads;
        private System.Windows.Forms.Label workingLoadsLabel;
        private System.Windows.Forms.ComboBox boltType;
        private System.Windows.Forms.Label boltTypeLabel;
        private System.Windows.Forms.ComboBox screwType;
        private System.Windows.Forms.ComboBox boltConType;
        private System.Windows.Forms.Label screwTypeLabel;
        private System.Windows.Forms.Label BoltConTypeLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BoltConnectionSystemDataSet1 boltConnectionSystemDataSet1;
        private System.Windows.Forms.BindingSource boltTypeTableBindingSource;
        private BoltConnectionSystemDataSet1TableAdapters.boltTypeTableTableAdapter boltTypeTableTableAdapter;
        private BoltConnectionSystemDataSet14 boltConnectionSystemDataSet14;
        private System.Windows.Forms.BindingSource dboboltTypeTableBindingSource;
        private BoltConnectionSystemDataSet14TableAdapters.dbo_boltTypeTableTableAdapter dbo_boltTypeTableTableAdapter;
        private BoltConnectionSystemDataSet15 boltConnectionSystemDataSet15;
        private System.Windows.Forms.BindingSource dboboltTypeTableBindingSource1;
        private BoltConnectionSystemDataSet15TableAdapters.dbo_boltTypeTableTableAdapter dbo_boltTypeTableTableAdapter1;
        private System.Windows.Forms.TextBox UTmin;
        private System.Windows.Forms.TextBox FQ;
        private System.Windows.Forms.Label uTminLabel;
        private System.Windows.Forms.Label FQLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn strengthGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DN;
    }
}