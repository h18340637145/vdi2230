namespace WindowsFormsApp1.StepCalForm
{
    partial class R10SpForm
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
            this.ifNut = new System.Windows.Forms.CheckBox();
            this.ifGasket = new System.Windows.Forms.CheckBox();
            this.HS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer2
            // 
            this.splitContainer2.SplitterDistance = 201;
            // 
            // resGrid
            // 
            this.resGrid.Size = new System.Drawing.Size(468, 245);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HS);
            this.groupBox1.Controls.Add(this.ifGasket);
            this.groupBox1.Controls.Add(this.ifNut);
            this.groupBox1.Size = new System.Drawing.Size(468, 201);
            this.groupBox1.Controls.SetChildIndex(this.CalBtn, 0);
            this.groupBox1.Controls.SetChildIndex(this.cancelBtn, 0);
            this.groupBox1.Controls.SetChildIndex(this.chooseBoltBtn, 0);
            this.groupBox1.Controls.SetChildIndex(this.chooseMaterialBtn, 0);
            this.groupBox1.Controls.SetChildIndex(this.ifNut, 0);
            this.groupBox1.Controls.SetChildIndex(this.ifGasket, 0);
            this.groupBox1.Controls.SetChildIndex(this.HS, 0);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            // 
            // ifNut
            // 
            this.ifNut.AutoSize = true;
            this.ifNut.Location = new System.Drawing.Point(16, 163);
            this.ifNut.Name = "ifNut";
            this.ifNut.Size = new System.Drawing.Size(96, 16);
            this.ifNut.TabIndex = 5;
            this.ifNut.Text = "通孔螺栓连接";
            this.ifNut.UseVisualStyleBackColor = true;
            // 
            // ifGasket
            // 
            this.ifGasket.AutoSize = true;
            this.ifGasket.Location = new System.Drawing.Point(140, 163);
            this.ifGasket.Name = "ifGasket";
            this.ifGasket.Size = new System.Drawing.Size(72, 16);
            this.ifGasket.TabIndex = 5;
            this.ifGasket.Text = "选择垫圈";
            this.ifGasket.UseVisualStyleBackColor = true;
            this.ifGasket.CheckedChanged += new System.EventHandler(this.ifGasket_CheckedChanged);
            // 
            // HS
            // 
            this.HS.Location = new System.Drawing.Point(323, 158);
            this.HS.Name = "HS";
            this.HS.Size = new System.Drawing.Size(100, 21);
            this.HS.TabIndex = 6;
            this.HS.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "垫圈厚度";
            this.label1.Visible = false;
            // 
            // R10SpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "R10SpForm";
            this.Text = "R10SpForm";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ifNut;
        private System.Windows.Forms.CheckBox ifGasket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HS;
    }
}