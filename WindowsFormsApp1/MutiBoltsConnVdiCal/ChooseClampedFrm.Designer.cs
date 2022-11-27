namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    partial class ChooseClampedFrm
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
            this.dbo_materialBoltTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet17TableAdapters.dbo_materialBoltTableAdapter();
            this.materialBoltTableAdapter1 = new WindowsFormsApp1.BoltMaterialConnTableAdapters.materialBoltTableAdapter();
            this.materialBoltTableAdapter = new WindowsFormsApp1.BoltConnectionSystemDataSet8TableAdapters.materialBoltTableAdapter();
            this.boltConnectionSystemDataSet8 = new WindowsFormsApp1.BoltConnectionSystemDataSet8();
            this.materialBoltBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltMaterialConn = new WindowsFormsApp1.BoltMaterialConn();
            this.materialBoltBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.optBtn = new System.Windows.Forms.Button();
            this.boltConnectionSystemDataSet17 = new WindowsFormsApp1.BoltConnectionSystemDataSet17();
            this.dbomaterialBoltBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boltConnectionSystemDataSet19 = new WindowsFormsApp1.BoltConnectionSystemDataSet19();
            this.dbomaterialClampedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clampedMaterialNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBoltBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltMaterialConn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBoltBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbomaterialBoltBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbomaterialClampedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbo_materialBoltTableAdapter
            // 
            this.dbo_materialBoltTableAdapter.ClearBeforeFill = true;
            // 
            // materialBoltTableAdapter1
            // 
            this.materialBoltTableAdapter1.ClearBeforeFill = true;
            // 
            // materialBoltTableAdapter
            // 
            this.materialBoltTableAdapter.ClearBeforeFill = true;
            // 
            // boltConnectionSystemDataSet8
            // 
            this.boltConnectionSystemDataSet8.DataSetName = "BoltConnectionSystemDataSet8";
            this.boltConnectionSystemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBoltBindingSource
            // 
            this.materialBoltBindingSource.DataMember = "materialBolt";
            this.materialBoltBindingSource.DataSource = this.boltConnectionSystemDataSet8;
            // 
            // boltMaterialConn
            // 
            this.boltMaterialConn.DataSetName = "BoltMaterialConn";
            this.boltMaterialConn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBoltBindingSource1
            // 
            this.materialBoltBindingSource1.DataMember = "materialBolt";
            this.materialBoltBindingSource1.DataSource = this.boltMaterialConn;
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
            this.optBtn.Click += new System.EventHandler(this.optBtn_Click);
            // 
            // boltConnectionSystemDataSet17
            // 
            this.boltConnectionSystemDataSet17.DataSetName = "BoltConnectionSystemDataSet17";
            this.boltConnectionSystemDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbomaterialBoltBindingSource
            // 
            this.dbomaterialBoltBindingSource.DataMember = "dbo_materialBolt";
            this.dbomaterialBoltBindingSource.DataSource = this.boltConnectionSystemDataSet17;
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
            this.splitContainer1.TabIndex = 3;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clampedMaterialNameDataGridViewTextBoxColumn,
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn,
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn,
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn,
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dbomaterialClampedBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(597, 450);
            this.dataGridView1.TabIndex = 2;
            // 
            // boltConnectionSystemDataSet19
            // 
            this.boltConnectionSystemDataSet19.DataSetName = "BoltConnectionSystemDataSet19";
            this.boltConnectionSystemDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbomaterialClampedBindingSource
            // 
            this.dbomaterialClampedBindingSource.DataMember = "dbo_materialClamped";
            this.dbomaterialClampedBindingSource.DataSource = this.boltConnectionSystemDataSet19;
            // 
            // clampedMaterialNameDataGridViewTextBoxColumn
            // 
            this.clampedMaterialNameDataGridViewTextBoxColumn.DataPropertyName = "ClampedMaterialName";
            this.clampedMaterialNameDataGridViewTextBoxColumn.HeaderText = "材料名";
            this.clampedMaterialNameDataGridViewTextBoxColumn.Name = "clampedMaterialNameDataGridViewTextBoxColumn";
            this.clampedMaterialNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clampedMaterialRatiofBDataGridViewTextBoxColumn
            // 
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn.DataPropertyName = "ClampedMaterialRatio_fB";
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn.HeaderText = "剪切强度比fBs";
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn.Name = "clampedMaterialRatiofBDataGridViewTextBoxColumn";
            this.clampedMaterialRatiofBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clampedMatrialRatiofGDataGridViewTextBoxColumn
            // 
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn.DataPropertyName = "ClampedMatrialRatio_fG";
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn.HeaderText = "极限表面压力系数fG";
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn.Name = "clampedMatrialRatiofGDataGridViewTextBoxColumn";
            this.clampedMatrialRatiofGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clampedMatrialEpyangshiDataGridViewTextBoxColumn
            // 
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn.DataPropertyName = "ClampedMatrialEp_yangshi";
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn.HeaderText = "杨氏模量Ep";
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn.Name = "clampedMatrialEpyangshiDataGridViewTextBoxColumn";
            this.clampedMatrialEpyangshiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clampedMatrialRmminkanglaDataGridViewTextBoxColumn
            // 
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn.DataPropertyName = "ClampedMatrialRmmin_kangla";
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn.HeaderText = "抗拉强度Rmmin";
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn.Name = "clampedMatrialRmminkanglaDataGridViewTextBoxColumn";
            this.clampedMatrialRmminkanglaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ChooseClampedFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ChooseClampedFrm";
            this.Text = "ChooseClampedFrm";
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBoltBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltMaterialConn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBoltBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbomaterialBoltBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltConnectionSystemDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbomaterialClampedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BoltConnectionSystemDataSet17TableAdapters.dbo_materialBoltTableAdapter dbo_materialBoltTableAdapter;
        private BoltMaterialConnTableAdapters.materialBoltTableAdapter materialBoltTableAdapter1;
        private BoltConnectionSystemDataSet8TableAdapters.materialBoltTableAdapter materialBoltTableAdapter;
        private BoltConnectionSystemDataSet8 boltConnectionSystemDataSet8;
        private System.Windows.Forms.BindingSource materialBoltBindingSource;
        private BoltMaterialConn boltMaterialConn;
        private System.Windows.Forms.BindingSource materialBoltBindingSource1;
        private System.Windows.Forms.Button optBtn;
        private BoltConnectionSystemDataSet17 boltConnectionSystemDataSet17;
        private System.Windows.Forms.BindingSource dbomaterialBoltBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMaterialNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMaterialRatiofBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMatrialRatiofGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMatrialEpyangshiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clampedMatrialRmminkanglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dbomaterialClampedBindingSource;
        private BoltConnectionSystemDataSet19 boltConnectionSystemDataSet19;
    }
}