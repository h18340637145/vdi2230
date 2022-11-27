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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();
            //Table();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//强行结束整个程序
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /*
         * @function    让表显示数据
         * @author      hhw
         * @file        form2.cs
         * @date        2021-9-19
         */
        

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void 螺栓材料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialBase f = new MaterialBase(this , 1);
            f.ShowDialog();//对话框   关闭之后才可以操作当前界面
        }

        private void 连接件材料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaterialBase f = new MaterialBase(this, 2);
            f.ShowDialog();//对话框   关闭之后才可以操作当前界面
        }

        private void VDI2230BoltConGeo_Click(object sender, EventArgs e)
        {
            VDI2230BoltConGeoForm f = new VDI2230BoltConGeoForm();
            f.ShowDialog();
        }
        // 选中节点后进行触发
        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (tvMenu.SelectedNode.Level == 2)
            //{
                
            //}
        }

        private void initDesign_Click(object sender, EventArgs e)
        {
            InitDesignForm initDesignForm = new InitDesignForm();
            initDesignForm.ShowDialog();
        }

        private void validateCompute_Click(object sender, EventArgs e)
        {
            ValidateDesignForm validateDesignForm = new ValidateDesignForm();
            validateDesignForm.ShowDialog();
        }

        private void multiBoltsDesign_Click(object sender, EventArgs e)
        {
            MutliBoltsDesginForm mutliBoltsDesginForm = new MutliBoltsDesginForm();
            mutliBoltsDesginForm.ShowDialog();
        }

        private void multiDesignBtn_Click(object sender, EventArgs e)
        {
            MutliBoltsDesginForm mutliBoltsDesginForm = new MutliBoltsDesginForm();
            mutliBoltsDesginForm.ShowDialog();
        }
    }
}
