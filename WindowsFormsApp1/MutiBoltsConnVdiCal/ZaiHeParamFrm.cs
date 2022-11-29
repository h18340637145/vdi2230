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
    public partial class ZaiHeParamFrm : ParamBaseFrm
    {
        ZaiHeParameters zaiHeParameters;
        public static string dynamic_load;

        public ZaiHeParamFrm()
        {
            InitializeComponent();

            pianxinBtn.Visible = false;
            zhazhiBtn.Visible = false;

            dataGridView1.Rows.Add("Fao", 24900, "N轴向载荷的上限值");
            dataGridView1.Rows.Add("Fau", 0, "N轴向载荷的下限值");
            dataGridView1.Rows.Add("Mt", 0, "N/mm2绕螺栓轴的扭矩");
            dataGridView1.Rows.Add("Fq", 0, "N横向载荷");
            dataGridView1.Rows.Add("qf", 1, "载荷传递通过内部接合面数量");
            dataGridView1.Rows.Add("Mb", 0, "N/mm2工作弯矩");
            dataGridView1.Rows.Add("v", 0.9, "拧紧时材料的屈服点利用率");
            dataGridView1.Rows.Add("Dhamx", 20, "mm承载面最大内径");
            dataGridView1.Rows.Add("ra", 20, "mm摩擦半径");
        }

        internal ZaiHeParameters GetZaiHeParams()
        {
            return zaiHeParameters;
        }

        private void _setEveryPropFieldFromDataGridViewZaiHe()
        {
            if (zaiHeParameters == null)
            {
                zaiHeParameters = new ZaiHeParameters();
            }
            foreach (var f in zaiHeParameters.GetType().GetProperties())
            {
                var propName = f.Name;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["param"] != null && (string)row.Cells["param"].Value == propName)
                    {
                        var obj = row.Cells["value"].Value;
                        f.SetValue(zaiHeParameters, obj is string ? Convert.ToDouble(obj) : obj);
                        break;
                    }
                }
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            _setEveryPropFieldFromDataGridViewZaiHe();
            Hide();
        }


        private void dynamic_loadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (dynamic_loadBtn.Checked == true)
            {
                dynamic_load = "动态加载";
            }
            else
            {
                dynamic_load = "静态加载";
            }
        }
    }

    public class ZaiHeParameters
    {
        public double Fao { get; set; }
        public double Mt { get; set; }
        public double Fq { get; set; }
        public double qf { get; set; }
        public double Mb { get; set; }
        public double Fau { get; set; }
        public double v { get; set; }
        public double Dhamx { get; set; }
        public double ra { get; set; }
    }
}
