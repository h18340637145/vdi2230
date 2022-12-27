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
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("username", "other");
            dataGridView1.Rows.Add("password", "other");
            dataGridView1.Rows.Add("flag", "0");
        }

        User user;
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new User();
            }
            _setEveryPropFieldsFromDataGridView();
            InsertToDb();
        }

        private void InsertToDb()
        {
            DaoAccess daoAccess = new DaoAccess();
            string sql = "insert into admin values('" + user.username + "','" + user.password + "','" + user.flag + "')";
            int i = daoAccess.Excute(sql);
        }

        private void _setEveryPropFieldsFromDataGridView()
        {
            foreach (var f in user.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["prop"] != null && (string)row.Cells["prop"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value.ToString();
                        f.SetValue(user, obj);
                        break;
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
