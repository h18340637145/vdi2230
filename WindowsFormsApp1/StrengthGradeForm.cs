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
    public partial class StrengthGradeForm : Form
    {
        private ValidateDesignForm validateDesignForm;
        public StrengthGradeForm(ValidateDesignForm validateDesignForm)
        {
            this.validateDesignForm = validateDesignForm;
            InitializeComponent();
        }

        private void StrengthGradeForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet17.dbo_materialBolt”中。您可以根据需要移动或删除它。
            this.dbo_materialBoltTableAdapter.Fill(this.boltConnectionSystemDataSet17.dbo_materialBolt);
            //// TODO: 这行代码将数据加载到表“boltMaterialConn.materialBolt”中。您可以根据需要移动或删除它。
            //this.materialBoltTableAdapter1.Fill(this.boltMaterialConn.materialBolt);
            //// TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet8.materialBolt”中。您可以根据需要移动或删除它。
            //this.materialBoltTableAdapter.Fill(this.boltConnectionSystemDataSet8.materialBolt);
        }

        private void optBtn_Click(object sender, EventArgs e)
        {
            this.validateDesignForm.bolt.boltMaterial.BoltMaterialLevel = dataGridView1.SelectedCells[0].Value.ToString();
            this.validateDesignForm.bolt.boltMaterial.BoltMaterialEs = double.Parse(dataGridView1.SelectedCells[1].Value.ToString());
            this.validateDesignForm.bolt.boltMaterial.BoltMaterialRpmin = double.Parse(dataGridView1.SelectedCells[2].Value.ToString());
            this.validateDesignForm.bolt.boltMaterial.BoltMaterialRm = double.Parse(dataGridView1.SelectedCells[3].Value.ToString());
            this.validateDesignForm.bolt.boltMaterial.BoltMaterialRatio_fB = double.Parse(dataGridView1.SelectedCells[4].Value.ToString());
            this.validateDesignForm.bolt.boltMaterial.BoltMaterialTmax = double.Parse(dataGridView1.SelectedCells[5].Value.ToString());
            this.validateDesignForm.bolt.boltMaterial.BoltMaterialA = double.Parse(dataGridView1.SelectedCells[6].Value.ToString());
            validateDesignForm.updateDataMaterial(this.validateDesignForm.bolt.boltMaterial);
        }

        public void updateBoltMaterial(BoltClass bolt)
        {
            bolt.boltMaterial = this.validateDesignForm.bolt.boltMaterial;
        }

        public void Table(int idx)
        {
            dataGridView1.Rows.Clear();
            string sql = "select * from dbo_materialBolt";
            MessageBox.Show(sql, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string level, fB, Es, Rpmin, Rm, Alpha, Tmax;
                level = dr["BoltMaterialLevel"].ToString();
                fB = dr["BoltMaterialRatio_fB"].ToString();
                Es = dr["BoltMatrialEs_yangshi"].ToString();
                Rpmin = dr["BoltMatrialRpmin_qufu"].ToString();
                Rm = dr["BoltMaterialRm_kangla"].ToString();
                Alpha = dr["BoltMaterialA_alpha"].ToString();
                Tmax = dr["BoltMaterialTmax"].ToString();
                string[] str = { level, Es, Rpmin, Rm, fB, Tmax, Alpha};
                dataGridView1.Rows.Add(str);
            }
            dr.Close(); // 关闭连接
        }
    }
}
