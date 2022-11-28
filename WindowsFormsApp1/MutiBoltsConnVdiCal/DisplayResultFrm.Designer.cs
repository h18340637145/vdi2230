namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    partial class DisplayResultFrm
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
            this.resultPage = new System.Windows.Forms.TabControl();
            this.resGrid = new System.Windows.Forms.PropertyGrid();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.resultPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultPage
            // 
            this.resultPage.Controls.Add(this.tabPage1);
            this.resultPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPage.Location = new System.Drawing.Point(0, 0);
            this.resultPage.Name = "resultPage";
            this.resultPage.SelectedIndex = 0;
            this.resultPage.Size = new System.Drawing.Size(800, 450);
            this.resultPage.TabIndex = 0;
            // 
            // resGrid
            // 
            this.resGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resGrid.Location = new System.Drawing.Point(3, 3);
            this.resGrid.Name = "resGrid";
            this.resGrid.Size = new System.Drawing.Size(786, 418);
            this.resGrid.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.resGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DisplayResultFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultPage);
            this.Name = "DisplayResultFrm";
            this.Text = "DisplayResultFrm";
            this.resultPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl resultPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PropertyGrid resGrid;
    }
}