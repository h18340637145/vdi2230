using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Login
{
    public partial class InfoManagement : Form
    {
        public InfoManagement()
        {
            InitializeComponent();
        }

        private void InfoManagement_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet21.admin”中。您可以根据需要移动或删除它。
            //this.adminTableAdapter.Fill(this.boltConnectionSystemDataSet21.admin);
            Table();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                string username, sql;
                username = dataGridView1.SelectedCells[0].Value.ToString();
                sql = "delete from admin where username='" + username + "'";
                
                DaoAccess dao = new DaoAccess();
                dao.Excute(sql);
                Table();
            }
        }

        private void Table()
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from admin";
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string username, password, flag;
                username = dr["username"].ToString();
                password = dr["password"].ToString();
                flag = dr["flag"].ToString();
                string[] str = { username, password, flag };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();// 关闭连接
        }


        
        private void addBtn_Click(object sender, EventArgs e)
        {
            AddInfo addInfo = new AddInfo();
            addInfo.Show();
        }

        private void selBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            string sql = "select * from admin where username='" + textBox1.Text + "'";
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string username, password, flag;
                username = dr["username"].ToString();
                password = dr["password"].ToString();
                flag = dr["flag"].ToString();
                string[] str = { username, password, flag };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();// 关闭连接
        }
    }
}
