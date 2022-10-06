﻿using System;
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
    public partial class BoltChooseForm : Form
    {
        private ValidateDesignForm validateDesignForm;
        private BoltChooseClass boltChooseClass;

        public BoltChooseForm(ValidateDesignForm validateDesignForm)
        {
            this.validateDesignForm = validateDesignForm;
            InitializeComponent();
            Table(1); // 显示基础内容
        }
        public BoltChooseClass GetBoltChooseClass()
        {
            return this.boltChooseClass;
        }

        public void Table(int idx)
        {
            //form2中的datagrid
            dataGridView1.Rows.Clear();
            string sql = "select boltSpeciTable.boltSpeci as speci,boltStdTable.boltStd as std,BoltTable.normalD_d as DN, " +
                "BoltTable.boltLen_ls as ls,BoltTable.polishRodLen_l1 as l1,boreD_dh as dh " +
                "from boltSpeciTable join BoltTable on boltSpeciTable.boltSpeciIndex=BoltTable.boltSpeci " +
                "join boltStdTable on boltStdTable.boltStdIndex=BoltTable.boltStd " +
                "ORDER BY DN asc";
            MessageBox.Show(sql, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string speci, std, DN, ls, l1, dh;
                speci = dr["speci"].ToString();// 把强度等级
                std = dr["std"].ToString();// 
                DN = dr["DN"].ToString();//
                ls = dr["ls"].ToString();// 
                l1 = dr["l1"].ToString();//
                dh = dr["dh"].ToString();//
                string[] strs = { speci, std, DN, ls, l1, dh };
                dataGridView1.Rows.Add(strs);
                //this.strs = strs;
            }
            dr.Close(); // 关闭连接

            //选择螺栓之后要将对应的螺纹也一并赋值
        }

        private void optBtn_Click(object sender, EventArgs e)
        {
            this.boltChooseClass = GetBolt();
            validateDesignForm.updateData();
        }

        BoltChooseClass GetBolt()
        {
            BoltChooseClass boltChooseClass = new BoltChooseClass();

            string sql = "select boltSpeciTable.boltSpeci,boltStdTable.boltStd,BoltTable.* " +
                "from boltSpeciTable join BoltTable on boltSpeciTable.boltSpeciIndex=BoltTable.boltSpeci " +
                "join boltStdTable on boltStdTable.boltStdIndex=BoltTable.boltStd where normalD_d=" + dataGridView1.SelectedCells[2].Value.ToString() +
                " and boltLen_ls="+ dataGridView1.SelectedCells[3].Value.ToString() +
                " and polishRodLen_l1=" + dataGridView1.SelectedCells[4].Value.ToString() +
                " and boreD_dh=" + dataGridView1.SelectedCells[5].Value.ToString() +
                " and boltSpeciTable.boltSpeci='" + dataGridView1.SelectedCells[0].Value.ToString()+ "'" +
                " and boltStdTable.boltStd='" + dataGridView1.SelectedCells[1].Value.ToString()+ "'";
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
            return boltChooseClass;
        }
    }
}