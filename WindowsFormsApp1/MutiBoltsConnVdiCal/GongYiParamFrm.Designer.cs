namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    partial class GongYiParamFrm
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
            this.N = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ifN = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 522;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(522, 450);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ifN);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.N);
            this.groupBox2.Size = new System.Drawing.Size(274, 450);
            this.groupBox2.Controls.SetChildIndex(this.N, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.okBtn, 0);
            this.groupBox2.Controls.SetChildIndex(this.cancelBtn, 0);
            this.groupBox2.Controls.SetChildIndex(this.pianxinBtn, 0);
            this.groupBox2.Controls.SetChildIndex(this.zhazhiBtn, 0);
            this.groupBox2.Controls.SetChildIndex(this.ifN, 0);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Size = new System.Drawing.Size(268, 41);
            // 
            // okBtn
            // 
            this.okBtn.Size = new System.Drawing.Size(268, 41);
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(145, 165);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(100, 21);
            this.N.TabIndex = 2;
            this.N.TextChanged += new System.EventHandler(this.N_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "循环周期数：";
            // 
            // ifN
            // 
            this.ifN.AutoSize = true;
            this.ifN.Location = new System.Drawing.Point(64, 149);
            this.ifN.Name = "ifN";
            this.ifN.Size = new System.Drawing.Size(156, 16);
            this.ifN.TabIndex = 4;
            this.ifN.Text = "疲劳强度范围内交变应力";
            this.ifN.UseVisualStyleBackColor = true;
            this.ifN.CheckedChanged += new System.EventHandler(this.ifN_CheckedChanged);
            // 
            // GongYiParamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "GongYiParamFrm";
            this.Text = "GongYiParamFrm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ifN;
    }
}