using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.VDISolution;

namespace WindowsFormsApp1.MutiBoltsConnVdiCal
{
    public partial class DisplayResultFrm : Form
    {
        Solution solution;
        ComputeResult rs;
        public DisplayResultFrm(Solution solution, ComputeResult rs)
        {
            InitializeComponent();
            this.solution = solution;
            this.rs = rs;
            resGrid.SelectedObject = rs;
        }
    }
}
