namespace WindowsFormsApp1
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selfManagmentBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.otherManagmentBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MatLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoltMatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClampedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VDI2230BoltConGeo = new System.Windows.Forms.ToolStripMenuItem();
            this.selfDefLuoshaunlianjiebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.vDI2230螺栓连接几何尺寸库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initDesign = new System.Windows.Forms.ToolStripMenuItem();
            this.validateCompute = new System.Windows.Forms.ToolStripMenuItem();
            this.multiDesignBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ilIcon = new System.Windows.Forms.ImageList(this.components);
            this.splitLogin = new System.Windows.Forms.SplitContainer();
            this.selfInfo = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.passwdLabel = new System.Windows.Forms.Label();
            this.unameLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.flagLabel = new System.Windows.Forms.Label();
            this.flag = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLogin)).BeginInit();
            this.splitLogin.Panel1.SuspendLayout();
            this.splitLogin.SuspendLayout();
            this.selfInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.MatLibToolStripMenuItem,
            this.VDI2230BoltConGeo,
            this.设计ToolStripMenuItem,
            this.multiDesignBtn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(908, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selfManagmentBtn,
            this.otherManagmentBtn,
            this.ExitToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.SystemToolStripMenuItem.Text = "系统";
            // 
            // selfManagmentBtn
            // 
            this.selfManagmentBtn.Name = "selfManagmentBtn";
            this.selfManagmentBtn.Size = new System.Drawing.Size(180, 22);
            this.selfManagmentBtn.Text = "个人中心";
            this.selfManagmentBtn.Click += new System.EventHandler(this.selfManagmentBtn_Click);
            // 
            // otherManagmentBtn
            // 
            this.otherManagmentBtn.Name = "otherManagmentBtn";
            this.otherManagmentBtn.Size = new System.Drawing.Size(180, 22);
            this.otherManagmentBtn.Text = "信息管理";
            this.otherManagmentBtn.Click += new System.EventHandler(this.otherManagmentBtn_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MatLibToolStripMenuItem
            // 
            this.MatLibToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoltMatToolStripMenuItem,
            this.ClampedToolStripMenuItem});
            this.MatLibToolStripMenuItem.Name = "MatLibToolStripMenuItem";
            this.MatLibToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.MatLibToolStripMenuItem.Text = "材料库";
            // 
            // BoltMatToolStripMenuItem
            // 
            this.BoltMatToolStripMenuItem.Name = "BoltMatToolStripMenuItem";
            this.BoltMatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BoltMatToolStripMenuItem.Text = "螺栓材料";
            this.BoltMatToolStripMenuItem.Click += new System.EventHandler(this.螺栓材料ToolStripMenuItem_Click);
            // 
            // ClampedToolStripMenuItem
            // 
            this.ClampedToolStripMenuItem.Name = "ClampedToolStripMenuItem";
            this.ClampedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClampedToolStripMenuItem.Text = "连接件材料";
            this.ClampedToolStripMenuItem.Click += new System.EventHandler(this.连接件材料ToolStripMenuItem_Click);
            // 
            // VDI2230BoltConGeo
            // 
            this.VDI2230BoltConGeo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selfDefLuoshaunlianjiebtn,
            this.vDI2230螺栓连接几何尺寸库ToolStripMenuItem});
            this.VDI2230BoltConGeo.Name = "VDI2230BoltConGeo";
            this.VDI2230BoltConGeo.Size = new System.Drawing.Size(177, 21);
            this.VDI2230BoltConGeo.Text = "VDI2230螺栓连接几何尺寸库";
            // 
            // selfDefLuoshaunlianjiebtn
            // 
            this.selfDefLuoshaunlianjiebtn.Name = "selfDefLuoshaunlianjiebtn";
            this.selfDefLuoshaunlianjiebtn.Size = new System.Drawing.Size(221, 22);
            this.selfDefLuoshaunlianjiebtn.Text = "自定义螺栓管理";
            this.selfDefLuoshaunlianjiebtn.Click += new System.EventHandler(this.selfDefLuoshaunlianjiebtn_Click);
            // 
            // vDI2230螺栓连接几何尺寸库ToolStripMenuItem
            // 
            this.vDI2230螺栓连接几何尺寸库ToolStripMenuItem.Name = "vDI2230螺栓连接几何尺寸库ToolStripMenuItem";
            this.vDI2230螺栓连接几何尺寸库ToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.vDI2230螺栓连接几何尺寸库ToolStripMenuItem.Text = "VDI2230螺栓连接几何尺寸";
            this.vDI2230螺栓连接几何尺寸库ToolStripMenuItem.Click += new System.EventHandler(this.VDI2230BoltConGeo_Click);
            // 
            // 设计ToolStripMenuItem
            // 
            this.设计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initDesign,
            this.validateCompute});
            this.设计ToolStripMenuItem.Name = "设计ToolStripMenuItem";
            this.设计ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.设计ToolStripMenuItem.Text = "单螺栓设计";
            // 
            // initDesign
            // 
            this.initDesign.Name = "initDesign";
            this.initDesign.Size = new System.Drawing.Size(160, 22);
            this.initDesign.Text = "单螺栓初始设计";
            this.initDesign.Click += new System.EventHandler(this.initDesign_Click);
            // 
            // validateCompute
            // 
            this.validateCompute.Name = "validateCompute";
            this.validateCompute.Size = new System.Drawing.Size(160, 22);
            this.validateCompute.Text = "单螺栓验证计算";
            this.validateCompute.Click += new System.EventHandler(this.validateCompute_Click);
            // 
            // multiDesignBtn
            // 
            this.multiDesignBtn.Name = "multiDesignBtn";
            this.multiDesignBtn.Size = new System.Drawing.Size(80, 21);
            this.multiDesignBtn.Text = "多螺栓设计";
            this.multiDesignBtn.Click += new System.EventHandler(this.multiDesignBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 541);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(908, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 17);
            this.toolStripStatusLabel1.Text = "欢迎登录此系统";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(680, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.toolStripStatusLabel3.IsLink = true;
            this.toolStripStatusLabel3.LinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel3.Text = "time";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel4.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ilIcon
            // 
            this.ilIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcon.ImageStream")));
            this.ilIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcon.Images.SetKeyName(0, "account.png");
            this.ilIcon.Images.SetKeyName(1, "AnalysisPath.png");
            this.ilIcon.Images.SetKeyName(2, "ApplyLoad.png");
            this.ilIcon.Images.SetKeyName(3, "Bolt.png");
            this.ilIcon.Images.SetKeyName(4, "boundary.png");
            this.ilIcon.Images.SetKeyName(5, "c2.png");
            this.ilIcon.Images.SetKeyName(6, "chuangjianmoxing.png");
            this.ilIcon.Images.SetKeyName(7, "cloud.png");
            this.ilIcon.Images.SetKeyName(8, "cloudPic.png");
            this.ilIcon.Images.SetKeyName(9, "conn.png");
            this.ilIcon.Images.SetKeyName(10, "contact.png");
            this.ilIcon.Images.SetKeyName(11, "create-model.png");
            this.ilIcon.Images.SetKeyName(12, "duliModel.png");
            this.ilIcon.Images.SetKeyName(13, "emp.png");
            this.ilIcon.Images.SetKeyName(14, "f.png");
            this.ilIcon.Images.SetKeyName(15, "favicon.ico");
            this.ilIcon.Images.SetKeyName(16, "guizejianmo.png");
            this.ilIcon.Images.SetKeyName(17, "guizejianmo_1.png");
            this.ilIcon.Images.SetKeyName(18, "jianmo.png");
            this.ilIcon.Images.SetKeyName(19, "jianmo_1.png");
            this.ilIcon.Images.SetKeyName(20, "lock.png");
            this.ilIcon.Images.SetKeyName(21, "lock1.png");
            this.ilIcon.Images.SetKeyName(22, "m1.png");
            this.ilIcon.Images.SetKeyName(23, "m2.png");
            this.ilIcon.Images.SetKeyName(24, "Material.png");
            this.ilIcon.Images.SetKeyName(25, "mesh.png");
            this.ilIcon.Images.SetKeyName(26, "MeshRefinement.png");
            this.ilIcon.Images.SetKeyName(27, "MidModel.png");
            this.ilIcon.Images.SetKeyName(28, "model1.png");
            this.ilIcon.Images.SetKeyName(29, "NonBolt.png");
            this.ilIcon.Images.SetKeyName(30, "outCode.png");
            this.ilIcon.Images.SetKeyName(31, "outDoc.png");
            this.ilIcon.Images.SetKeyName(32, "password.png");
            this.ilIcon.Images.SetKeyName(33, "preload.png");
            this.ilIcon.Images.SetKeyName(34, "ProName.png");
            this.ilIcon.Images.SetKeyName(35, "ResultEvaluate.png");
            this.ilIcon.Images.SetKeyName(36, "resultExtract.png");
            this.ilIcon.Images.SetKeyName(37, "save.png");
            this.ilIcon.Images.SetKeyName(38, "savePic.png");
            this.ilIcon.Images.SetKeyName(39, "shujujianmo.png");
            this.ilIcon.Images.SetKeyName(40, "shujujianmogongcheng.png");
            this.ilIcon.Images.SetKeyName(41, "sol.png");
            this.ilIcon.Images.SetKeyName(42, "tra.png");
            this.ilIcon.Images.SetKeyName(43, "TubeModel.png");
            this.ilIcon.Images.SetKeyName(44, "user.png");
            this.ilIcon.Images.SetKeyName(45, "yewujianmogongcheng.png");
            // 
            // splitLogin
            // 
            this.splitLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLogin.Location = new System.Drawing.Point(0, 25);
            this.splitLogin.Name = "splitLogin";
            // 
            // splitLogin.Panel1
            // 
            this.splitLogin.Panel1.Controls.Add(this.selfInfo);
            this.splitLogin.Panel1MinSize = 1;
            // 
            // splitLogin.Panel2
            // 
            this.splitLogin.Panel2.BackColor = System.Drawing.Color.White;
            this.splitLogin.Panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.微信截图_20221226140254;
            this.splitLogin.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitLogin.Panel2MinSize = 1;
            this.splitLogin.Size = new System.Drawing.Size(908, 516);
            this.splitLogin.SplitterDistance = 217;
            this.splitLogin.TabIndex = 3;
            // 
            // selfInfo
            // 
            this.selfInfo.Controls.Add(this.cancelBtn);
            this.selfInfo.Controls.Add(this.updateBtn);
            this.selfInfo.Controls.Add(this.password);
            this.selfInfo.Controls.Add(this.flag);
            this.selfInfo.Controls.Add(this.flagLabel);
            this.selfInfo.Controls.Add(this.passwdLabel);
            this.selfInfo.Controls.Add(this.username);
            this.selfInfo.Controls.Add(this.unameLabel);
            this.selfInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selfInfo.Location = new System.Drawing.Point(0, 0);
            this.selfInfo.Name = "selfInfo";
            this.selfInfo.Size = new System.Drawing.Size(217, 516);
            this.selfInfo.TabIndex = 5;
            this.selfInfo.TabStop = false;
            this.selfInfo.Text = "个人信息";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(67, 221);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(67, 174);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "修改";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(113, 84);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(64, 21);
            this.password.TabIndex = 9;
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Location = new System.Drawing.Point(54, 87);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(41, 12);
            this.passwdLabel.TabIndex = 7;
            this.passwdLabel.Text = "密码：";
            // 
            // unameLabel
            // 
            this.unameLabel.AutoSize = true;
            this.unameLabel.Location = new System.Drawing.Point(54, 47);
            this.unameLabel.Name = "unameLabel";
            this.unameLabel.Size = new System.Drawing.Size(53, 12);
            this.unameLabel.TabIndex = 8;
            this.unameLabel.Text = "用户名：";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(113, 47);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 12);
            this.username.TabIndex = 8;
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.Location = new System.Drawing.Point(54, 129);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(41, 12);
            this.flagLabel.TabIndex = 7;
            this.flagLabel.Text = "权限：";
            // 
            // flag
            // 
            this.flag.AutoSize = true;
            this.flag.Location = new System.Drawing.Point(113, 129);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(0, 12);
            this.flag.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.微信截图_20221226140254;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(908, 563);
            this.Controls.Add(this.splitLogin);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "VDIBoltStudio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitLogin.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLogin)).EndInit();
            this.splitLogin.ResumeLayout(false);
            this.selfInfo.ResumeLayout(false);
            this.selfInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MatLibToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BoltMatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClampedToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ImageList ilIcon;
        private System.Windows.Forms.ToolStripMenuItem VDI2230BoltConGeo;
        private System.Windows.Forms.ToolStripMenuItem 设计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initDesign;
        private System.Windows.Forms.ToolStripMenuItem validateCompute;
        private System.Windows.Forms.ToolStripMenuItem multiDesignBtn;
        private System.Windows.Forms.ToolStripMenuItem selfDefLuoshaunlianjiebtn;
        private System.Windows.Forms.ToolStripMenuItem vDI2230螺栓连接几何尺寸库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selfManagmentBtn;
        private System.Windows.Forms.ToolStripMenuItem otherManagmentBtn;
        private System.Windows.Forms.SplitContainer splitLogin;
        private System.Windows.Forms.GroupBox selfInfo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.Label unameLabel;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label flagLabel;
        private System.Windows.Forms.Label flag;
    }
}