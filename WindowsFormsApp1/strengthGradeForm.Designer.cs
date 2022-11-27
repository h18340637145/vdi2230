namespace WindowsFormsApp1
{
    partial class StrengthGradeForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbomaterialBoltBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet17 = new WindowsFormsApp1.BoltConnectionSystemDataSet17();
            this.panel2 = new System.Windows.Forms.Panel();
            this.optBtn = new System.Windows.Forms.Button();
            this.materialBoltBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boltMaterialConn = new WindowsFormsApp1.BoltMaterialConn();
            this.materialBoltBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltConnectionSystemDataSet8 = new WindowsFormsApp1.BoltConnectionSystemDataSet8();
            this.materialBoltTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet8TableAdapters.materialBoltTableAdapter();
            this.materialBoltTableAdapter1 = new WindowsFormsApp1.BoltMaterialConnTableAdapters.materialBoltTableAdapter();
            this.dbo_materialBoltTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet17TableAdapters.dbo_materialBoltTableAdapter();
            this.boltMaterialLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltMatrialEsyangshiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltMatrialRpminqufuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltMaterialRmkanglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltMaterialRatiofBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltMaterialTmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoltMaterialA_alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbomaterialBoltBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet17)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBoltBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltMaterialConn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBoltBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet8)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 597;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boltMaterialLevelDataGridViewTextBoxColumn,
            this.boltMatrialEsyangshiDataGridViewTextBoxColumn,
            this.boltMatrialRpminqufuDataGridViewTextBoxColumn,
            this.boltMaterialRmkanglaDataGridViewTextBoxColumn,
            this.boltMaterialRatiofBDataGridViewTextBoxColumn,
            this.boltMaterialTmaxDataGridViewTextBoxColumn,
            this.BoltMaterialA_alpha});
            this.dataGridView1.DataSource = this.dbomaterialBoltBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(597, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dbomaterialBoltBindingSource
            // 
            this.dbomaterialBoltBindingSource.DataMember = "dbo_materialBolt";
            this.dbomaterialBoltBindingSource.DataSource = this.boltConnectionSystemDataSet17;
            this.dbomaterialBoltBindingSource.CurrentChanged += new System.EventHandler(this.dbomaterialBoltBindingSource_CurrentChanged);
            // 
            // boltConnectionSystemDataSet17
            // 
            this.boltConnectionSystemDataSet17.DataSetName = "BoltConnectionSystemDataSet17";
            this.boltConnectionSystemDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.optBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 450);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // optBtn
            // 
            this.optBtn.Location = new System.Drawing.Point(43, 47);
            this.optBtn.Margin = new System.Windows.Forms.Padding(2);
            this.optBtn.Name = "optBtn";
            this.optBtn.Size = new System.Drawing.Size(77, 34);
            this.optBtn.TabIndex = 47;
            this.optBtn.Text = "选择";
            this.optBtn.UseVisualStyleBackColor = true;
            this.optBtn.Click += new System.EventHandler(this.optBtn_Clickx);
            // 
            // materialBoltBindingSource1
            // 
            this.materialBoltBindingSource1.DataMember = "materialBolt";
            this.materialBoltBindingSource1.DataSource = this.boltMaterialConn;
            this.materialBoltBindingSource1.CurrentChanged += new System.EventHandler(this.materialBoltBindingSource1_CurrentChanged);
            // 
            // boltMaterialConn
            // 
            this.boltMaterialConn.DataSetName = "BoltMaterialConn";
            this.boltMaterialConn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBoltBindingSource
            // 
            this.materialBoltBindingSource.DataMember = "materialBolt";
            this.materialBoltBindingSource.DataSource = this.boltConnectionSystemDataSet8;
            this.materialBoltBindingSource.CurrentChanged += new System.EventHandler(this.materialBoltBindingSource_CurrentChanged);
            // 
            // boltConnectionSystemDataSet8
            // 
            this.boltConnectionSystemDataSet8.DataSetName = "BoltConnectionSystemDataSet8";
            this.boltConnectionSystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBoltTableAdapter
            // 
            this.materialBoltTableAdapter.ClearBeforeFill = true;
            // 
            // materialBoltTableAdapter1
            // 
            this.materialBoltTableAdapter1.ClearBeforeFill = true;
            // 
            // dbo_materialBoltTableAdapter
            // 
            this.dbo_materialBoltTableAdapter.ClearBeforeFill = true;
            // 
            // boltMaterialLevelDataGridViewTextBoxColumn
            // 
            this.boltMaterialLevelDataGridViewTextBoxColumn.DataPropertyName = "BoltMaterialLevel";
            this.boltMaterialLevelDataGridViewTextBoxColumn.HeaderText = "强度等级";
            this.boltMaterialLevelDataGridViewTextBoxColumn.Name = "boltMaterialLevelDataGridViewTextBoxColumn";
            // 
            // boltMatrialEsyangshiDataGridViewTextBoxColumn
            // 
            this.boltMatrialEsyangshiDataGridViewTextBoxColumn.DataPropertyName = "BoltMatrialEs_yangshi";
            this.boltMatrialEsyangshiDataGridViewTextBoxColumn.HeaderText = "Es";
            this.boltMatrialEsyangshiDataGridViewTextBoxColumn.Name = "boltMatrialEsyangshiDataGridViewTextBoxColumn";
            // 
            // boltMatrialRpminqufuDataGridViewTextBoxColumn
            // 
            this.boltMatrialRpminqufuDataGridViewTextBoxColumn.DataPropertyName = "BoltMatrialRpmin_qufu";
            this.boltMatrialRpminqufuDataGridViewTextBoxColumn.HeaderText = "Rpmin";
            this.boltMatrialRpminqufuDataGridViewTextBoxColumn.Name = "boltMatrialRpminqufuDataGridViewTextBoxColumn";
            // 
            // boltMaterialRmkanglaDataGridViewTextBoxColumn
            // 
            this.boltMaterialRmkanglaDataGridViewTextBoxColumn.DataPropertyName = "BoltMaterialRm_kangla";
            this.boltMaterialRmkanglaDataGridViewTextBoxColumn.HeaderText = "Rm";
            this.boltMaterialRmkanglaDataGridViewTextBoxColumn.Name = "boltMaterialRmkanglaDataGridViewTextBoxColumn";
            // 
            // boltMaterialRatiofBDataGridViewTextBoxColumn
            // 
            this.boltMaterialRatiofBDataGridViewTextBoxColumn.DataPropertyName = "BoltMaterialRatio_fB";
            this.boltMaterialRatiofBDataGridViewTextBoxColumn.HeaderText = "fBS";
            this.boltMaterialRatiofBDataGridViewTextBoxColumn.Name = "boltMaterialRatiofBDataGridViewTextBoxColumn";
            // 
            // boltMaterialTmaxDataGridViewTextBoxColumn
            // 
            this.boltMaterialTmaxDataGridViewTextBoxColumn.DataPropertyName = "BoltMaterialTmax";
            this.boltMaterialTmaxDataGridViewTextBoxColumn.HeaderText = "Tmax";
            this.boltMaterialTmaxDataGridViewTextBoxColumn.Name = "boltMaterialTmaxDataGridViewTextBoxColumn";
            // 
            // BoltMaterialA_alpha
            // 
            this.BoltMaterialA_alpha.DataPropertyName = "alpha";
            this.BoltMaterialA_alpha.HeaderText = "alpha";
            this.BoltMaterialA_alpha.Name = "BoltMaterialA_alpha";
            // 
            // StrengthGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StrengthGradeForm";
            this.Text = "strengthGradeForm";
            this.Load += new System.EventHandler(this.StrengthGradeForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbomaterialBoltBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet17)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialBoltBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltMaterialConn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBoltBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button optBtn;
        private BoltConnectionSystemDataSet8 boltConnectionSystemDataSet8;
        private System.Windows.Forms.BindingSource materialBoltBindingSource;
        private BoltConnectionSystemDataSet8TableAdapters.materialBoltTableAdapter materialBoltTableAdapter;
        private BoltMaterialConn boltMaterialConn;
        private System.Windows.Forms.BindingSource materialBoltBindingSource1;
        private BoltMaterialConnTableAdapters.materialBoltTableAdapter materialBoltTableAdapter1;
        private BoltConnectionSystemDataSet17 boltConnectionSystemDataSet17;
        private System.Windows.Forms.BindingSource dbomaterialBoltBindingSource;
        private BoltConnectionSystemDataSet17TableAdapters.dbo_materialBoltTableAdapter dbo_materialBoltTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltMaterialLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltMatrialEsyangshiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltMatrialRpminqufuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltMaterialRmkanglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltMaterialRatiofBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltMaterialTmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoltMaterialA_alpha;
    }
}