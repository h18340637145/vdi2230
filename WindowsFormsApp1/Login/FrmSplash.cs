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

namespace WindowsFormsApp1.Login
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();

            //Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            //DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
            //string displayableVersion = $"{version} ({buildDate})";

            //lblVersion.Text = Properties.Settings.Default.Version;
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
            string displayableVersion = $"{version} ({buildDate})";

            //lblVersion.Text = displayableVersion;
            //if (System.IO.File.Exists(Application.StartupPath + @"\\splash.cfg"))
            //{
            //    //picLogo.Load(Application.StartupPath + @"\\splash.jpg",);
            //    picLogo.Image = Image.FromFile(Application.StartupPath + @"\\splash.cfg");

            //    picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            //}
        }

        private User user;
        private void loginBtn_Click(object sender, EventArgs e)
        {
            // 防呆设计
            if (username.Text == null || username.Text == "")
            {
                MessageBox.Show("请输入用户名");
                return;
            }

            if (passwd.Text == null || passwd.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }

            string uid = username.Text;
            string password = passwd.Text;
            string tableName = "admin";
            string flag;
            if (adminBtn.Checked == true)
            {
                // 管理员登录，拥有所有权限
                flag = "1";
            }
            else if (otherBtn.Checked == true)
            {
                // 设计人员登录，仅拥有查询权限，但是也拥有自定义数据库的管理权限
                flag = "0";
            }
            else
            {
                MessageBox.Show("请选择权限");
                return;
            }
            if (user == null)
            {
                user = new User();
            }
            user.username = uid;
            user.password = password;
            user.flag = flag;

            string sql = "select * from " + tableName + " where username='" + uid + "' and password='" + password + "' and flag='" + flag + "'";
            // 执行查找
            DaoAccess daoAccess = new DaoAccess();
            IDataReader dr = daoAccess.read(sql);
            try
            {
                //如果存在用户名和密码正确数据执行进入系统操作
                if (dr.Read())
                {
                    MessageBox.Show("登录成功");
                    MainWindow mainWindow = new MainWindow(user);
                    Thread.Sleep(2000);
                    mainWindow.Show();
                    Hide();
                   
                }
                else
                {
                    MessageBox.Show("请输入正确的用户名和密码");
                }
            }
            catch (Exception msg)
            {
                throw new Exception(msg.ToString());  //处理异常信息
            }
            finally
            {
                dr.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
