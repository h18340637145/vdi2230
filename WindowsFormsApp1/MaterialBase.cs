using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MaterialBase : Form
    {
        MainWindow form2;
        int idx = 1;//1  表示bolt  2 表示clamp
        string tableName;

        public MaterialBase(MainWindow form2, int idx)
        {
            this.idx = idx;
            this.form2 = form2;
            InitializeComponent();
            if (idx == 1)
            {
                this.tableName = "dbo_materialBolt";
                label2.Hide();
                textBox2.Hide();
                Table(1);
            }
            else
            {
                this.tableName = "dbo_materialClamped";
                Table(2);
            }
        }

        public string getTableName()
        {
            return this.tableName;
        }

        public int getIdx()
        {
            return this.idx;
        }

        // idx == 1 2 分别表示连接件和螺栓的材料
        public void Table(int idx)
        {
            //form2中的datagrid
            dataGridView1.Rows.Clear();
            string sql = "select * from " + this.getTableName();
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                if (idx == 1)
                {
                    string index, level, fB, Es, Rpmin, Rm, alpha;
                    index = dr["BoltMaterialIndex"].ToString();
                    level = dr["BoltMaterialLevel"].ToString();
                    fB = dr["BoltMaterialRatio_fB"].ToString();
                    Es = dr["BoltMatrialEs_yangshi"].ToString();
                    Rpmin = dr["BoltMatrialRpmin_qufu"].ToString();
                    Rm = dr["BoltMaterialRm_kangla"].ToString();
                    alpha = dr["BoltMaterialA_alpha"].ToString();
                    string[] str = { index, level, fB, Es, Rpmin, Rm, alpha };
                    dataGridView1.Rows.Add(str);
                }
                else
                {
                    string index, name, fB, fG, Ep, Rmmin, alpha;
                    index = dr["ClampedMaterialIndex"].ToString();
                    name = dr["ClampedMaterialName"].ToString();
                    fB = dr["ClampedMaterialRatio_fB"].ToString();
                    fG = dr["ClampedMatrialRatio_fG"].ToString();
                    Ep = dr["ClampedMatrialEp_yangshi"].ToString();
                    Rmmin = dr["ClampedMatrialRmmin_kangla"].ToString();
                    alpha = dr["ClampedMatrialA_alpha"].ToString();
                    string[] str = { index, name, fB, fG, Ep, Rmmin, alpha };
                    dataGridView1.Rows.Add(str);
                }
            }
            dr.Close();// 关闭连接
        }
        
        // 重载 
        // 索引查询或者名字模糊查询  param = 1为索引查询  param=2 为名字模糊查询 index_name是参数
        public void Table(int idx, int param, string index_name)
        {
            // form2中的datagrid
            dataGridView1.Rows.Clear();
            string sql = "select * from " + this.getTableName();
            if (idx == 1)// 螺栓 索引 查询
                sql += " where BoltMaterialIndex=" + index_name;
            else
            {
                // 夹紧件查询
                if (param == 1)
                {
                    // 索引查询
                    sql += " where ClampedMaterialIndex='" + index_name + "'";
                }
                else
                {
                    // 名字模糊查询
                    sql += " where ClampedMaterialName like '%" + index_name + "%'";
                }
            }

            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                if (idx == 1)//螺栓 索引 查询
                {
                    string index, level, fB, Es, Rpmin, Rm, alpha;
                    index = dr["BoltMaterialIndex"].ToString();
                    level = dr["BoltMaterialLevel"].ToString();
                    fB = dr["BoltMaterialRatio_fB"].ToString();
                    Es = dr["BoltMatrialEs_yangshi"].ToString();
                    Rpmin = dr["BoltMatrialRpmin_qufu"].ToString();
                    Rm = dr["BoltMaterialRm_kangla"].ToString();
                    alpha = dr["BoltMaterialA_alpha"].ToString();
                    string[] str = { index, level, fB, Es, Rpmin, Rm, alpha };
                    dataGridView1.Rows.Add(str);
                }
                else
                {
                    string index, name, fB, fG, Ep, Rmmin, alpha;
                    index = dr["ClampedMaterialIndex"].ToString();
                    name = dr["ClampedMaterialName"].ToString();
                    fB = dr["ClampedMaterialRatio_fB"].ToString();
                    fG = dr["ClampedMatrialRatio_fG"].ToString();
                    Ep = dr["ClampedMatrialEp_yangshi"].ToString();
                    Rmmin = dr["ClampedMatrialRmmin_kangla"].ToString();
                    alpha = dr["ClampedMatrialA_alpha"].ToString();
                    string[] str = { index, name, fB, fG, Ep, Rmmin, alpha };
                    dataGridView1.Rows.Add(str);
                }
            }
            dr.Close();//关闭连接
        }

        internal void Table()
        {
            throw new NotImplementedException();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
            
            if (dr == DialogResult.OK)
            {
                string id ,sql;
                id = dataGridView1.SelectedCells[0].Value.ToString();
                if (idx == 1)
                {
                    sql = "delete from " + this.tableName + " where BoltMaterialIndex =" +id ;
                }
                else {
                    sql = "delete from " + this.tableName + " where ClampedMaterialIndex ='" + id + "'";
                }
                DaoAccess dao = new DaoAccess();
                dao.Excute(sql);
                Table(this.idx);
            }
        }

        private void addBuuton_Click(object sender, EventArgs e)
        {
            InsertBaseForm f = new InsertBaseForm(this);
            f.ShowDialog();//对话框   关闭之后才可以操作当前界面
        }

        private void MaterialBase_Load(object sender, EventArgs e)
        {

        }

        private void selButton_Click(object sender, EventArgs e)
        {
            if (idx == 1)//螺栓查询  仅索引查询
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //执行bolt的索引搜索
                    Table(idx, 1, textBox1.Text);//textBox1.Text 是索引
                }
            }
            else if (idx == 2)
            {
                //夹紧件包含索引和名字查询
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    //都是空  提示
                    MessageBox.Show("请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(textBox1.Text != "" && textBox2.Text == "")
                {
                    //执行clamped的索引搜索
                    Table(idx, 1, textBox1.Text);//textbox1 是索引查询
                }
                else if(textBox1.Text == "" && textBox2.Text != "")
                {
                    //执行name模糊的索引搜索
                    Table(idx, 2, textBox2.Text);//textbox2 是名字
                }
                else
                {
                    //执行name模糊的索引搜索
                    Table(idx, 2, textBox2.Text);//textbox2 是名字
                }
            }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(),
                dataGridView1.SelectedCells[1].Value.ToString(),
                dataGridView1.SelectedCells[2].Value.ToString(),
                dataGridView1.SelectedCells[3].Value.ToString(),
                dataGridView1.SelectedCells[4].Value.ToString(),
                dataGridView1.SelectedCells[5].Value.ToString(),
                dataGridView1.SelectedCells[6].Value.ToString()
            };
            //MessageBox.Show(str[0] + str[1]);
            InsertBaseForm f = new InsertBaseForm(this, str);
            f.ShowDialog();//对话框   关闭之后才可以操作当前界面
        }
    }
}
