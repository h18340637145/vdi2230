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
    public partial class ChooseClampedFrm : Form
    {
        public ChooseClampedFrm()
        {
            InitializeComponent();
        }

        public ClampedMaterial material { get; set; }

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
