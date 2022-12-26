using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.StepCalForm
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        public BoltClass bolt;
        public BoltMaterialClass material;
        BoltChooseForm boltfrm;
        StrengthGradeForm materialFrm;
        private void chooseBoltBtn_Click(object sender, EventArgs e)
        {
            if (boltfrm == null)
            {
                boltfrm = new BoltChooseForm();
            }
           
            boltfrm.ShowDialog();
            bolt = boltfrm.getBolt();
            if (bolt == null)
            {
                return;
            }
            boltfrm.Hide();
            chooseBoltBtn.Enabled = false;
        }

        private void chooseMaterialBtn_Click(object sender, EventArgs e)
        {
            if (bolt == null)
            {
                MessageBox.Show("请先选择螺栓");
                return;
            }
            if (materialFrm == null)
            {
                materialFrm = new StrengthGradeForm();
            }

            materialFrm.ShowDialog();
            material = materialFrm.getMaterial();
            if (material == null)
            {
                return;
            }
            bolt.boltMaterial = material;
            materialFrm.Hide();
            chooseMaterialBtn.Enabled = false;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
