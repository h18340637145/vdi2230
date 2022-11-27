namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    partial class ParamBaseFrm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.param = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pianxinBtn = new System.Windows.Forms.CheckBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.zhazhiBtn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(748, 366);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.param,
            this.value,
            this.intro});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(483, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // param
            // 
            this.param.HeaderText = "参数";
            this.param.Name = "param";
            this.param.ReadOnly = true;
            this.param.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // value
            // 
            this.value.HeaderText = "值";
            this.value.Name = "value";
            this.value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // intro
            // 
            this.intro.HeaderText = "说明";
            this.intro.Name = "intro";
            this.intro.ReadOnly = true;
            this.intro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zhazhiBtn);
            this.groupBox2.Controls.Add(this.pianxinBtn);
            this.groupBox2.Controls.Add(this.cancelBtn);
            this.groupBox2.Controls.Add(this.okBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 366);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // pianxinBtn
            // 
            this.pianxinBtn.AutoSize = true;
            this.pianxinBtn.Location = new System.Drawing.Point(64, 105);
            this.pianxinBtn.Name = "pianxinBtn";
            this.pianxinBtn.Size = new System.Drawing.Size(120, 16);
            this.pianxinBtn.TabIndex = 1;
            this.pianxinBtn.Text = "使用偏心夹紧加载";
            this.pianxinBtn.UseVisualStyleBackColor = true;
            this.pianxinBtn.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cancelBtn.Location = new System.Drawing.Point(3, 58);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(249, 41);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.okBtn.Location = new System.Drawing.Point(3, 17);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(249, 41);
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "确定";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // zhazhiBtn
            // 
            this.zhazhiBtn.AutoSize = true;
            this.zhazhiBtn.Location = new System.Drawing.Point(64, 127);
            this.zhazhiBtn.Name = "zhazhiBtn";
            this.zhazhiBtn.Size = new System.Drawing.Size(96, 16);
            this.zhazhiBtn.TabIndex = 1;
            this.zhazhiBtn.Text = "热处理前轧制";
            this.zhazhiBtn.UseVisualStyleBackColor = true;
            this.zhazhiBtn.Visible = false;
            // 
            // ParamBaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 366);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ParamBaseFrm";
            this.Text = "ParamBaseFrm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.Button okBtn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridViewTextBoxColumn param;
        public System.Windows.Forms.DataGridViewTextBoxColumn value;
        public System.Windows.Forms.DataGridViewTextBoxColumn intro;
        public System.Windows.Forms.CheckBox pianxinBtn;
        public System.Windows.Forms.CheckBox zhazhiBtn;
    }
}