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
    public partial class InitDesignForm : Form
    {
        public InitDesignForm()
        {
            InitializeComponent();
        }
        string[] type = new string[4];
        int getForce(double upperLimitAxialLoadString)
        {
            int num = Convert.ToInt32(upperLimitAxialLoadString);
            if (num < 1000)
            {
                num = 1000;
            }
            else if (num < 1600 && num >= 1000)
            {
                num = 1600;
            }
            else if (num < 2500 && num >= 1600)
            {
                num = 2500;
            }
            else if (num < 4000 && num >= 2500)
            {
                num = 4000;
            }
            else if (num < 6300 && num >= 4000)
            {
                num = 6300;
            }
            else if (num < 10000 && num >= 6300)
            {
                num = 10000;
            }
            else if (num < 16000 && num >= 10000)
            {
                num = 16000;
            }
            else if (num < 25000 && num >= 16000)
            {
                num = 25000;
            }
            else if (num < 40000 && num >= 25000)
            {
                num = 40000;
            }
            else if (num < 63000 && num >= 40000)
            {
                num = 63000;
            }
            else if (num < 100000 && num >= 63000)
            {
                num = 100000;
            }
            else if (num < 160000 && num >= 100000)
            {
                num = 160000;
            }
            else if (num < 250000 && num >= 160000)
            {
                num = 250000;
            }
            else if (num < 400000 && num >= 250000)
            {
                num = 400000;
            }
            else if (num < 630000 && num > 400000)
            {
                num = 630000;
            }
            return num;
        }

        public void Table(string boltConTypeString, string workingLoads, string upperLimitAxialLoadString, string isEccentricString, string tightenTheProcessString)
        {
            //form2中的datagrid
            dataGridView1.Rows.Clear();
            string sql = "";
            double fa = double.Parse(upperLimitAxialLoadString);
            double fqmax = double.Parse(upperLimitAxialLoadString);
            double fres = 0;

            double fmmin = fa;
            double fmmax = fa;
            double[] zaiheN = { 250,400,630,1000,1600,2500,4000,6300,10000,16000,25000,40000,63000,100000,160000,250000,400000,630000 };
            int idx = 0;
            for (int i = 0; i < zaiheN.Length - 1; i++)
            {
                if (fa > zaiheN[i] && fa <= zaiheN[i + 1] )
                {
                    fa = zaiheN[i + 1];
                    idx = i + 1;
                    break;
                }
            }

            // B
            if (boltConTypeString == "单螺栓连接")
            {
                // fa
                // 动态偏心
                if (workingLoads == "动态" && isEccentricString == "是")
                {
                    fmmin = zaiheN[idx + 2];
                    idx = idx + 2;
                }
                // 静态偏心  || 动态同心
                else if ((workingLoads == "静态" && isEccentricString == "是")
                        ||(workingLoads == "动态" && isEccentricString == "否"))
                {
                    fmmin = zaiheN[idx + 1];
                    idx = idx + 1;
                }
                // 静态同心 不变
                else
                {
                    fmmin = fmmin;
                }

                // 使用  动态
                if (tightenTheProcessString == "复紧扭矩")
                {
                    fmmax = zaiheN[idx + 2];
                    idx = idx + 2;
                }
                else if (tightenTheProcessString == "冲击扳手或扭矩控制的冲击扳手拧紧" || tightenTheProcessString == "实验室测定必须拧紧力矩的扭矩扳手" 
                    ||  tightenTheProcessString == "A级预估摩擦系数的扭矩扳手" || tightenTheProcessString == "B级预估摩擦系数的扭矩扳手")
                {
                    fmmax = zaiheN[idx + 1];
                    idx = idx + 1;
                }
                // 角度控制 或者屈服控制不增加
                else if (tightenTheProcessString == "屈服控制拧紧" || tightenTheProcessString == "转角控制拧紧")
                {
                    fmmax = fmmin;
                }
                fres = fmmax;
            }
            else
            {
                // FQmax加四级  idx + 4
                fqmax = zaiheN[idx + 4];
                fres = fqmax;
            }

            int force = getForce(fres);

            MessageBox.Show(force.ToString());
            sql = "select * from dbo_strengthGradeAndDN where force=" + force;
            DaoAccess dao = new DaoAccess();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string strengthGrade, DN;
                strengthGrade = dr["strengthGrade"].ToString();
                DN = dr["DN"].ToString();
                string[] str = { strengthGrade, DN };
                dataGridView1.Rows.Add(str);
            }
            dr.Close(); // 关闭连接
        }

        private void computeBtn_Click_1(object sender, EventArgs e)
        {
            if (boltConType.Text == "" || screwType.Text == "" || boltType.Text == ""
                || workingLoads.Text == "" || upperLimitAxialLoad.Text == "" 
                || isEccentric.Text == "" || tightenTheProcess.Text == "")
            {
                MessageBox.Show("请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // 根据静态或者动态条件获取力的大小，根据规范规则，找出力的值，到数据库中进行检索
                string boltConTypeString = boltConType.Text;
                string screwTypeString = screwType.Text;
                string boltTypeString = boltType.Text;
                string workingLoadsString = workingLoads.Text;
                string upperLimitAxialLoadString = upperLimitAxialLoad.Text;
                string isEccentricString = isEccentric.Text;
                string tightenTheProcessString = tightenTheProcess.Text;

                type[0] = boltConTypeString;
                type[1] = screwTypeString;
                type[2] = boltTypeString;
                type[3] = tightenTheProcessString;

                Table(boltConTypeString, workingLoadsString, upperLimitAxialLoadString, isEccentricString, tightenTheProcessString);
                
                //Table(idx, 1, textBox1.Text);//textBox1.Text 是索引
            }
        }

        private void optBtn_Click(object sender, EventArgs e)
        {
            string[] str = { dataGridView1.SelectedCells[0].Value.ToString(),
                dataGridView1.SelectedCells[1].Value.ToString(),
            };
            //MessageBox.Show(str[0] + str[1]);
            InitDesignChooseForm initDesignChooseForm = new InitDesignChooseForm(str, type);
            initDesignChooseForm.ShowDialog(); // 传入数据，强度等级和直径
        }

        private void InitDesignForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet15.dbo_boltTypeTable”中。您可以根据需要移动或删除它。
            this.dbo_boltTypeTableTableAdapter1.Fill(this.boltConnectionSystemDataSet15.dbo_boltTypeTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet14.dbo_boltTypeTable”中。您可以根据需要移动或删除它。
            this.dbo_boltTypeTableTableAdapter.Fill(this.boltConnectionSystemDataSet14.dbo_boltTypeTable);
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet1.boltTypeTable”中。您可以根据需要移动或删除它。
            //this.boltTypeTableTableAdapter.Fill(this.boltConnectionSystemDataSet1.boltTypeTable);
        }
    }
}
