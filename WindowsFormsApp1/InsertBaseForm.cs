using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InsertBaseForm : Form
    {
        MaterialBase materialBase;
        string[] initstr = new string[7];
        string flag;
        public InsertBaseForm(MaterialBase materialBase)
        {
            this.materialBase = materialBase;
            this.flag = "新增";
            InitializeComponent();
            updateButton.Hide();
        }

        public InsertBaseForm(MaterialBase materialBase, string[] str)
        {
            this.materialBase = materialBase;
            this.flag = "修改";
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                initstr[i] = str[i];
            }
            textBox1.Text = initstr[0];//填入 
            textBox2.Text = initstr[1];
            textBox3.Text = initstr[2];
            textBox4.Text = initstr[3];
            textBox5.Text = initstr[4];
            textBox6.Text = initstr[5];
            textBox7.Text = initstr[6];
            addButton.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("数据不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "";
                if (materialBase.getIdx() == 1)
                {
                    sql = "insert into " + this.materialBase.getTableName() + " values(" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text
                    + "," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + textBox7.Text + ",20)";
                }
                else
                {
                    sql = "insert into " + this.materialBase.getTableName() + " values('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text
                    + "," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + "," + textBox7.Text + ",20)";
                }
                MessageBox.Show(sql);
                DaoAccess dao = new DaoAccess();
                int i = dao.Excute(sql);
                if (i > 0)
                {
                    MessageBox.Show("插入成功");
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    textBox4.Text = null;
                    textBox5.Text = null;
                    textBox6.Text = null;
                    textBox7.Text = null;
                }
            }
            materialBase.Table(materialBase.getIdx());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("修改后有空项，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "";
                if (textBox1.Text != initstr[0])
                {
                    if(materialBase.getIdx() == 1)
                    {
                        sql = "update " + this.materialBase.getTableName() + " set BoltMaterialIndex=" + textBox1.Text + " where BoltMaterialIndex=" + initstr[0];
                    }else
                    {
                        sql = "update " + this.materialBase.getTableName() + " set ClampedMaterialIndex='" + textBox1.Text + "' where ClampedMaterialIndex='" + initstr[0] + "'";
                    }
                    DaoAccess dao = new DaoAccess();
                    int i = dao.Excute(sql);
                    initstr[0] = textBox1.Text;
                }
                if (textBox2.Text != initstr[1])
                {
                    if (materialBase.getIdx() == 1)
                    {
                        sql = "update " + this.materialBase.getTableName() + " set BoltMaterialLevel=" + textBox2.Text + " where BoltMaterialIndex=" + initstr[0];
                    }
                    else
                    {
                        sql = "update " + this.materialBase.getTableName() + " set ClampedMaterialName='" + textBox2.Text + "' where ClampedMaterialIndex='" + initstr[0] + "'";
                    }
                    DaoAccess dao = new DaoAccess();
                    int i = dao.Excute(sql);
                    initstr[1] = textBox2.Text;
                }
                if (textBox3.Text != initstr[2])
                {
                    if (materialBase.getIdx() == 1)
                    {
                        sql = "update " + this.materialBase.getTableName() + " set BoltMaterialRatio_fB=" + textBox3.Text + " where BoltMaterialIndex=" + initstr[0];
                    }
                    else
                    {
                        sql = "update " + this.materialBase.getTableName() + " set ClampedMaterialRatio_fB='" + textBox3.Text + "' where ClampedMaterialIndex='" + initstr[0] + "'";
                    }

                    DaoAccess dao = new DaoAccess();
                    int i = dao.Excute(sql);
                    initstr[2] = textBox3.Text;
                }
                if (textBox4.Text != initstr[3])
                {

                    if (materialBase.getIdx() == 1)
                    {
                        sql = "update " + this.materialBase.getTableName() + " set BoltMatrialEs_yangshi=" + textBox4.Text + " where BoltMaterialIndex=" + initstr[0];
                    }
                    else
                    {
                        sql = "update " + this.materialBase.getTableName() + " set ClampedMatrialRatio_fG='" + textBox4.Text + "' where ClampedMaterialIndex='" + initstr[0] + "'";
                    }
                    DaoAccess dao = new DaoAccess();
                    int i = dao.Excute(sql);
                    initstr[3] = textBox4.Text;
                }
                if (textBox5.Text != initstr[4])
                {
                    sql = "update student set jg='" + textBox5.Text + "' where id='" + initstr[0] + "' and name='" + initstr[1] + "'";
                    if (materialBase.getIdx() == 1)
                    {
                        sql = "update " + this.materialBase.getTableName() + " set BoltMatrialRpmin_qufu=" + textBox5.Text + " where BoltMaterialIndex=" + initstr[0];
                    }
                    else
                    {
                        sql = "update " + this.materialBase.getTableName() + " set ClampedMatrialEp_yangshi='" + textBox5.Text + "' where ClampedMaterialIndex='" + initstr[0] + "'";
                    }

                    DaoAccess dao = new DaoAccess();
                    int i = dao.Excute(sql);
                    initstr[4] = textBox5.Text;
                }
                if (textBox6.Text != initstr[5])
                {
                    if (materialBase.getIdx() == 1)
                    {
                        sql = "update " + this.materialBase.getTableName() + " set BoltMaterialRm_kangla=" + textBox6.Text + " where BoltMaterialIndex=" + initstr[0];
                    }
                    else
                    {
                        sql = "update " + this.materialBase.getTableName() + " set ClampedMatrialRmmin_kangla='" + textBox6.Text + "' where ClampedMaterialIndex='" + initstr[0] + "'";
                    }

                    DaoAccess dao = new DaoAccess();
                    int i = dao.Excute(sql);
                    initstr[5] = textBox6.Text;
                }
                if (textBox7.Text != initstr[6])
                {
                    if (materialBase.getIdx() == 1)
                    {
                        sql = "update " + this.materialBase.getTableName() + " set BoltMaterialA_alpha=" + textBox7.Text + " where BoltMaterialIndex=" + initstr[0];
                    }
                    else
                    {
                        sql = "update " + this.materialBase.getTableName() + " set ClampedMatrialA_alpha='" + textBox7.Text + "' where ClampedMaterialIndex='" + initstr[0] + "'";
                    }

                    DaoAccess dao = new DaoAccess();
                    int i = dao.Excute(sql);
                    initstr[6] = textBox7.Text;
                }
            }
            materialBase.Table(materialBase.getIdx());
        }

        private void InsertBaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
