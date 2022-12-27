

using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WindowsFormsApp1.ManagementBoltConn.Dialog
{
    public partial class ScrewTypeFrm : BaseParamFrm
    {
        public ScrewTypeFrm()
        {
            InitializeComponent();
        }

        private void ScrewTypeFrm_Load(object sender, System.EventArgs e)
        {
            Table();
        }

        public void Table()
        {
            //form2中的datagrid
            dataGridView1.Rows.Clear();
            string sql = "select * from dbo_screwTypeTable";
            DaoAccess dao = new DaoAccess();
            System.Data.IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string index, screwType;
                index = dr["screwTypeIndex"].ToString();
                screwType = dr["screwType"].ToString();
                string[] str = { index, screwType };
                dataGridView1.Rows.Add(str);
            }
            dr.Close();// 关闭连接
        }

        private void delBtn_Click(object sender, System.EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.OK)
            {
                string idx, sql;
                idx = dataGridView1.SelectedCells[0].Value.ToString();
                sql = "delete from dbo_screwTypeTable where screwTypeIndex=" + idx;
                
                DaoAccess dao = new DaoAccess();
                dao.Excute(sql);
                Table();
            }
        }

        private void addBtn_Click(object sender, System.EventArgs e)
        {
            if (index.Text == "" || val.Text == "")
            {
                MessageBox.Show("请输入编号和值");
                return;
            }
           
            string sql;
            int idx = int.Parse(index.Text);
            sql = "insert into dbo_screwTypeTable values(" + idx + ",'" + val.Text + "')";
            DaoAccess dao = new DaoAccess();
            dao.Excute(sql);
            Table();
        }
    }
}
