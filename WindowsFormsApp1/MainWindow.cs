using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Login;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        private User user;

        public MainWindow()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            //Table();
        }

        //private bool flag { get; set; }
        //public MainWindow(bool flag)
        //{
        //    this.flag = flag;
        //    InitializeComponent();
        //    toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        //    timer1.Start();
        //    //Table();
        //}

        public MainWindow(User user)
        {
            this.user = user;
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            if (user.flag.Equals("1"))
            {
                // 所有权限
                
            }
            else
            {
                // 部分权限
                selfManagmentBtn.Visible = false;
                otherManagmentBtn.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//强行结束整个程序
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            splitLogin.SplitterDistance = 1;
            //splitContainer1.SplitterDistance = 625;
            load_datagrid();
            //infoManagementGrp.Visible = false;
        }

        private void load_datagrid()
        {
            DaoAccess daoAccess = new DaoAccess();
            string sql = "select username,password from admin";
            IDataReader dr = daoAccess.read(sql);
            while (dr.Read())
            {
                //dataGridView1.Rows.Add(dr["username"].ToString(), dr["password"].ToString(), dr["flag"]);
            }
            dr.Close();//关闭连接
        }

        /*
         * @function    让表显示数据
         * @author      hhw
         * @file        form2.cs
         * @date        2021-9-19
         */


        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void 螺栓材料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialBase f = new MaterialBase(this , 1, user);
            f.ShowDialog();//对话框   关闭之后才可以操作当前界面
        }

        private void 连接件材料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialBase f = new MaterialBase(this, 2, user);
            f.ShowDialog();//对话框   关闭之后才可以操作当前界面
        }

        private void VDI2230BoltConGeo_Click(object sender, EventArgs e)
        {
            VDI2230BoltConGeoForm f = new VDI2230BoltConGeoForm();
            f.ShowDialog();
        }
        // 选中节点后进行触发
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (tvMenu.SelectedNode.Level == 2)
            //{
                
            //}
        }

        private void initDesign_Click(object sender, EventArgs e)
        {
            InitDesignForm initDesignForm = new InitDesignForm();
            initDesignForm.ShowDialog();
        }

        private void validateCompute_Click(object sender, EventArgs e)
        {
            ValidateDesignForm validateDesignForm = new ValidateDesignForm();
            validateDesignForm.ShowDialog();
        }

        private void multiBoltsDesign_Click(object sender, EventArgs e)
        {
            MutliBoltsDesginForm mutliBoltsDesginForm = new MutliBoltsDesginForm();
            mutliBoltsDesginForm.ShowDialog();
        }

        private void multiDesignBtn_Click(object sender, EventArgs e)
        {
            MutliBoltsDesginForm mutliBoltsDesginForm = new MutliBoltsDesginForm();
            mutliBoltsDesginForm.ShowDialog();
        }

        private void selfDefLuoshaunlianjiebtn_Click(object sender, EventArgs e)
        {
            SelfDefLuoshaunlianjieForm form = new SelfDefLuoshaunlianjieForm();
            form.ShowDialog();
        }

        private void selfManagmentBtn_Click(object sender, EventArgs e)
        {
            splitLogin.SplitterDistance = 200;
            username.Text = user.username;
            password.Text = user.password;
            flag.Text = user.flag.Equals("1") ? "管理员" : "设计人员";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (password.Text == null || password.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }
           
            string sql = "update admin set password='" + password.Text + "' where username='" + user.username + "'";
            DaoAccess dao = new DaoAccess();
            int i = dao.Excute(sql);
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            splitLogin.SplitterDistance = 1;
        }

        private void otherManagmentBtn_Click(object sender, EventArgs e)
        {
            //infoManagementGrp.Visible = true;
            //splitContainer1.SplitterDistance = 1;

        }

        private void cancelInfoBtn_Click(object sender, EventArgs e)
        {
            //infoManagementGrp.Visible = false;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
