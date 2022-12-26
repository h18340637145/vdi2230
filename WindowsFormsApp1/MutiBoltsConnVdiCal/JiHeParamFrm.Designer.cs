namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    partial class JiHeParamFrm
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
            this.neiyaBtn = new System.Windows.Forms.CheckBox();
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
            this.groupBox2.Controls.Add(this.neiyaBtn);
            this.groupBox2.Size = new System.Drawing.Size(274, 450);
            this.groupBox2.Controls.SetChildIndex(this.okBtn, 0);
            this.groupBox2.Controls.SetChildIndex(this.cancelBtn, 0);
            this.groupBox2.Controls.SetChildIndex(this.pianxinBtn, 0);
            this.groupBox2.Controls.SetChildIndex(this.zhazhiBtn, 0);
            this.groupBox2.Controls.SetChildIndex(this.neiyaBtn, 0);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Size = new System.Drawing.Size(268, 41);
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Size = new System.Drawing.Size(268, 41);
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // neiyaBtn
            // 
            this.neiyaBtn.AutoSize = true;
            this.neiyaBtn.Location = new System.Drawing.Point(64, 150);
            this.neiyaBtn.Name = "neiyaBtn";
            this.neiyaBtn.Size = new System.Drawing.Size(72, 16);
            this.neiyaBtn.TabIndex = 2;
            this.neiyaBtn.Text = "考虑内压";
            this.neiyaBtn.UseVisualStyleBackColor = true;
            this.neiyaBtn.CheckedChanged += new System.EventHandler(this.neiyaBtn_CheckedChanged);
            // 
            // JiHeParamFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "JiHeParamFrm";
            this.Text = "JiHeParamFrm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox neiyaBtn;
    }
}