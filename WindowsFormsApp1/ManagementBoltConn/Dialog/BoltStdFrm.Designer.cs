﻿namespace WindowsFormsApp1.ManagementBoltConn.Dialog
{
    partial class BoltStdFrm
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(427, 234);
            this.splitContainer1.SplitterDistance = 252;
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(252, 234);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(171, 234);
            // 
            // delBtn
            // 
            this.delBtn.Size = new System.Drawing.Size(165, 41);
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Size = new System.Drawing.Size(165, 41);
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // BoltStdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 234);
            this.Name = "BoltStdFrm";
            this.Text = "BoltStdFrm";
            this.Load += new System.EventHandler(this.BoltStdFrm_Load_1);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}