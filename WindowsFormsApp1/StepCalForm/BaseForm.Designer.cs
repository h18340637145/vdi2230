namespace WindowsFormsApp1.StepCalForm
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chooseMaterialBtn = new System.Windows.Forms.Button();
            this.chooseBoltBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.CalBtn = new System.Windows.Forms.Button();
            this.resGrid = new System.Windows.Forms.PropertyGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.param,
            this.value,
            this.intro});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(328, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // param
            // 
            this.param.HeaderText = "参数";
            this.param.Name = "param";
            this.param.ReadOnly = true;
            // 
            // value
            // 
            this.value.HeaderText = "值";
            this.value.Name = "value";
            // 
            // intro
            // 
            this.intro.HeaderText = "说明";
            this.intro.Name = "intro";
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.resGrid);
            this.splitContainer2.Size = new System.Drawing.Size(468, 450);
            this.splitContainer2.SplitterDistance = 161;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chooseMaterialBtn);
            this.groupBox1.Controls.Add(this.chooseBoltBtn);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.CalBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chooseMaterialBtn
            // 
            this.chooseMaterialBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseMaterialBtn.Location = new System.Drawing.Point(3, 109);
            this.chooseMaterialBtn.Name = "chooseMaterialBtn";
            this.chooseMaterialBtn.Size = new System.Drawing.Size(462, 32);
            this.chooseMaterialBtn.TabIndex = 4;
            this.chooseMaterialBtn.Text = "选择材料";
            this.chooseMaterialBtn.UseVisualStyleBackColor = true;
            this.chooseMaterialBtn.Click += new System.EventHandler(this.chooseMaterialBtn_Click);
            // 
            // chooseBoltBtn
            // 
            this.chooseBoltBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.chooseBoltBtn.Location = new System.Drawing.Point(3, 77);
            this.chooseBoltBtn.Name = "chooseBoltBtn";
            this.chooseBoltBtn.Size = new System.Drawing.Size(462, 32);
            this.chooseBoltBtn.TabIndex = 3;
            this.chooseBoltBtn.Text = "选择螺栓";
            this.chooseBoltBtn.UseVisualStyleBackColor = true;
            this.chooseBoltBtn.Click += new System.EventHandler(this.chooseBoltBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cancelBtn.Location = new System.Drawing.Point(3, 49);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(462, 28);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CalBtn
            // 
            this.CalBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalBtn.Location = new System.Drawing.Point(3, 17);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(462, 32);
            this.CalBtn.TabIndex = 2;
            this.CalBtn.Text = "计算";
            this.CalBtn.UseVisualStyleBackColor = true;
            // 
            // resGrid
            // 
            this.resGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resGrid.Location = new System.Drawing.Point(0, 0);
            this.resGrid.Name = "resGrid";
            this.resGrid.Size = new System.Drawing.Size(468, 285);
            this.resGrid.TabIndex = 1;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn param;
        public System.Windows.Forms.DataGridViewTextBoxColumn value;
        public System.Windows.Forms.DataGridViewTextBoxColumn intro;
        public System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.Button CalBtn;
        public System.Windows.Forms.PropertyGrid resGrid;
        protected System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button chooseBoltBtn;
        public System.Windows.Forms.Button chooseMaterialBtn;
    }
}