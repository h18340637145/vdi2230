using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    public partial class ClampedChooseFrm : Form
    {
        public ClampedChooseFrm()
        {
            InitializeComponent();
        }
        ClampedMaterial material;
        private void ClampedChooseFrm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“boltConnectionSystemDataSet20.dbo_materialClamped”中。您可以根据需要移动或删除它。
            this.dbo_materialClampedTableAdapter.Fill(this.boltConnectionSystemDataSet20.dbo_materialClamped);

        }

        internal ClampedMaterial getMaterial()
        {
            return material;
        }

        private void optBtn_Click(object sender, EventArgs e)
        {
            material = new ClampedMaterial();
            material.ClampedMaterialName = dataGridView1.SelectedCells[0].Value.ToString();
            material.ClampedMaterialRatio_fB = double.Parse(dataGridView1.SelectedCells[1].Value.ToString());
            material.ClampedMaterialRatio_fG = double.Parse(dataGridView1.SelectedCells[2].Value.ToString());
            material.ClampedMaterialEp = double.Parse(dataGridView1.SelectedCells[3].Value.ToString());
            material.ClampedMaterialRmmin = double.Parse(dataGridView1.SelectedCells[4].Value.ToString());
        }
    }
}
