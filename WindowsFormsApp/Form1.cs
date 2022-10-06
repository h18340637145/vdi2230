using CreateBotSpring;
using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplication1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // 全局模型
        Bolt _bolt;
        ClampedClass _clamped;
        NutClass _nut;
        private Entity _boltEntity;
        private Entity _clampedEntity;
        private Entity _nutEntity;

        private void button3_Click(object sender, EventArgs e)
        {
            // new bolt
            BoltChooseClass boltChooseClass = new BoltChooseClass();

            // bolt data
            string sql = "select boltSpeciTable.boltSpeci,boltStdTable.boltStd,BoltTable.* " +
                "from boltSpeciTable join BoltTable on boltSpeciTable.boltSpeciIndex=BoltTable.boltSpeci " +
                "join boltStdTable on boltStdTable.boltStdIndex=BoltTable.boltStd where normalD_d=" + 12 +
                " and boltLen_ls=" + 60 +
                " and polishRodLen_l1=" + 24 +
                " and boreD_dh=" + 13.5 +
                " and boltSpeciTable.boltSpeci='M12×60'" +
                " and boltStdTable.boltStd='DIN EN ISO 4762'";
            MessageBox.Show(sql, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Console.WriteLine(sql);
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                //string speci, std, DN, ls, l1, dh;
                boltChooseClass.speci = dr["boltSpeci"].ToString();// 把强度等级
                boltChooseClass.std = dr["boltStd"].ToString();// 
                boltChooseClass.NormalD_d = double.Parse(dr["normalD_d"].ToString());//
                boltChooseClass.BoltLen_ls = double.Parse(dr["boltLen_ls"].ToString());// 
                boltChooseClass.PolishRodLen_l1 = double.Parse(dr["polishRodLen_l1"].ToString());//
                boltChooseClass.BoreD_dh = double.Parse(dr["boreD_dh"].ToString());//
                boltChooseClass.ScrewP_P = double.Parse(dr["screwP_P"].ToString());
                boltChooseClass.BoltHeadOutD_dw = double.Parse(dr["boltHeadOutD_dw"].ToString());
                boltChooseClass.BoltHeadInnerD_da = double.Parse(dr["boltHeadInnerD_da"].ToString());
                boltChooseClass.ScrewMidD_d2 = double.Parse(dr["screwMidD_d2"].ToString());
                boltChooseClass.ScrewMinD_d3 = double.Parse(dr["screwMinD_d3"].ToString());
                boltChooseClass.BoltNutSideWid_s = double.Parse(dr["boltNutSideWid_s"].ToString());
                boltChooseClass.BoltNutScrewMinD_D1 = double.Parse(dr["boltNutScrewMinD_D1"].ToString());
            }
            dr.Close(); // 关闭连接

            _bolt = new Bolt(boltChooseClass);
            // show model
            showBoltModel(Color.Red);

            _clamped = new ClampedClass(boltChooseClass.BoltLen_ls, boltChooseClass.NormalD_d * 5);

            showClampedModel(Color.Blue);

        }

        private void showClampedModel(Color color)
        {
            if (_clamped == null)
            {
                throw new Exception("clamped is null");
            }
            //model1.Entities.Clear();
            //model1.Enabled = true;
            try
            {
                _clampedEntity = _clamped.GetEntity();
                model1.Entities.Add(_clampedEntity, color);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }

        private void showBoltModel(Color color)
        {
            if (_bolt == null)
            {
                throw new Exception("bolt is null");
            }
            model1.Entities.Clear();
            model1.Enabled = true;
            try
            {
                _boltEntity = _bolt.GetEntity();
                model1.Entities.Add(_boltEntity, color);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }
        GasketClass _gasket;
        Entity entity;
        private void button4_Click(object sender, EventArgs e)
        {
            //List<Bolt> list = new List<Bolt>();
            //MessageBox.Show(list.Count.ToString());
            //_nut = new NutClass();
            // nut data
            GasketClass gasket = new GasketClass();
            string sql = "select * from gaskettable where gasketIndex='1'";

            Dao dao = new Dao();
            IDataReader dr2 = dao.read(sql);
            while (dr2.Read())
            {
                string gasketstd, gasketinnerD_dhas, gasketoutD_DA, boltheaddowngasketheight_hs1, nutdowngasketheight_hs2;

                gasketstd = dr2["gasketstd"].ToString();
                gasketinnerD_dhas = dr2["gasketinnerD_dhas"].ToString();
                gasketoutD_DA = dr2["gasketoutD_DA"].ToString();
                boltheaddowngasketheight_hs1 = dr2["boltheaddowngasketheight_hs1"].ToString();
                nutdowngasketheight_hs2 = dr2["nutdowngasketheight_hs2"].ToString();

                gasket.Gasketstd = gasketstd;
                gasket.GasketinnerD_dhas = double.Parse(gasketinnerD_dhas);
                gasket.GasketoutD_DA = double.Parse(gasketoutD_DA);
                gasket.Boltheaddowngasketheight_hs1 = double.Parse(boltheaddowngasketheight_hs1);
                gasket.Nutdowngasketheight_hs2 = double.Parse(nutdowngasketheight_hs2);
            }
            dr2.Close(); // 关闭连接
            _gasket = gasket;
            showGasketModel(Color.Cyan);
        }

        private void showGasketModel(Color color)
        {
            if (_gasket == null)
            {
                throw new Exception("_gasket is null");
            }
            //model1.Entities.Clear();
            //model1.Enabled = true;
            try
            {
                entity = _gasket.GetEntity();
                model1.Entities.Add(entity, color);
                model1.ZoomFit();
                model1.Invalidate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }


        //    private void timer1_Tick(object sender, EventArgs e)
        //    {
        //        if (pictureBox1.Location.X < 150)
        //        {
        //            //每10ms会执行一次计时器事件
        //            pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);//给这个图附一个位置 是原来的+1
        //        }
        //        else
        //        {
        //            timer1.Stop();

        //            if (comboBox1.Text == "学生")
        //            {
        //                //四步读数据法
        //                string sql = "select * from student where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
        //                Dao dao = new Dao();
        //                IDataReader dr = dao.read(sql);//返回结果集到idata中
        //                dr.Read();//必须读一下

        //                string sid = dr["id"].ToString();
        //                Form3 form3 = new Form3(sid);//当前登录学生的id  传送到选课的界面中，最后用于  sid 和 cid组合选课表
        //                form3.Show();
        //                this.Hide();
        //                //this.Close();
        //            }
        //            else if (comboBox1.Text == "老师")
        //            {
        //                Form2 form2 = new Form2();
        //                form2.Show();
        //                this.Hide();
        //            }
        //            else if (comboBox1.Text == "管理员")
        //            {
        //                Form4 form4 = new Form4();
        //                form4.Show();
        //                this.Hide();
        //            }
        //        }
        //    //}
        //    /*
        //     * 登录事件
        //     */
        //    private void button1_Click(object sender, EventArgs e)
        //    {
        //        if (login())
        //        {
        //            timer1.Start();//启动计时器   10ms移动一次  图片开始移动
        //            textBox1.Visible = false;
        //            textBox2.Visible = false;
        //            comboBox1.Visible = false;
        //            button1.Visible = false;
        //            button2.Visible = false;
        //            label1.Visible = false;
        //            label2.Visible = false;
        //            label3.Visible = false;
        //        }
        //    }

        //    /*
        //     * @function    用于检查账号密码匹配，只要三种角色有一个匹配，即可进入，不同的界面
        //     * @author      hhw
        //     * @date        2021-9-19
        //     * @file        Form1.cs
        //     */
        //    private bool login()
        //    {
        //        if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
        //        {
        //            MessageBox.Show("输入不完整，请检查","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        //            return false;
        //        }
        //        if (comboBox1.Text == "学生")
        //        {
        //            string sql = "select * from student where name='"+textBox1.Text+"' and password='"+textBox2.Text+"'";
        //            Dao dao = new Dao();
        //            IDataReader dr = dao.read(sql);//返回结果集到idata中
        //            if (dr.Read())//类似于游标
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        if (comboBox1.Text == "老师")
        //        {
        //            string sql = "select * from teacher where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
        //            Dao dao = new Dao();
        //            IDataReader dr = dao.read(sql);//返回结果集到idata中
        //            if (dr.Read())//类似于游标,读到，想到于匹配到了
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        if (comboBox1.Text == "管理员")
        //        {
        //            if(textBox1.Text == "admin" && textBox2.Text == "admin")
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        return false ;
        //    }

    }
}
