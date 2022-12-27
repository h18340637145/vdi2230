

using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace WindowsFormsApp1.ManagementBoltConn.Dialog
{
    public partial class BoltTypeFrm : BaseParamFrm
    {
        public BoltTypeFrm()
        {
            InitializeComponent();
        }

        private void BoltTypeFrm_Load(object sender, System.EventArgs e)
        {
            Table();
        }

        public void Table()
        {
            //form2中的datagrid
            dataGridView1.Rows.Clear();
            string sql = "select * from dbo_boltTypeTable";
            DaoAccess dao = new DaoAccess();
            System.Data.IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string index, boltType;
                index = dr["boltTypeIndex"].ToString();
                boltType = dr["boltType"].ToString();
                string[] str = { index, boltType };
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
                sql = "delete from dbo_boltTypeTable where boltTypeIndex=" + idx;

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
            sql = "insert into dbo_boltTypeTable values(" + idx + ",'" + val.Text + "')";
            DaoAccess dao = new DaoAccess();
            int i = dao.Excute(sql);
            if (i != 0)
            {
                MessageBox.Show("插入成功");
            }
            Table();
        }

        private void BoltTypeFrm_Load_1(object sender, System.EventArgs e)
        {
            Table();

        }
    }
}
