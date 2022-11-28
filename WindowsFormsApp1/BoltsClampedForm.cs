using CreateBotSpring;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MutiBoltsConnVdiCal;
using WindowsFormsApp1.VDISolution;

namespace WindowsFormsApp1
{
    public partial class BoltsClampedForm : Form
    {
        public IModelBuildForm ClampedForm { set; get; }
        public IModelBuildForm BoltForm { set; get; }
        public IModelBuildForm NutForm { set; get; }
        public bool IsBuildModel { set; get; }


        public BoltClass boltData;
        public HKFDJClamped clamped;
        public NutClass nut;
        public ClampedMaterial clampedMaterial;
        public JiHeParameters jiHeParameters;
        public GongYiParameters gongYiParameters;
        public ZaiHeParameters zaiHeParameters;
        public string zhazhi;
        public string dynamic_load;

        public BoltsClampedForm()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            model1.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            model1.ToolBar.Visible = false;
            model1.Grid.Visible = false;
            model1.ViewCubeIcon.Visible = false;
            model1.CoordinateSystemIcon.Visible = false;
            model1.Grid.Visible = false;
            IsBuildModel = false;
        }

        public void ResetModel()
        {
            dataGridView1.Rows.Clear();
            model1.Entities.Clear();
            IsBuildModel = false;
        }

        private void BoltsClampedForm_Load(object sender, EventArgs e)
        {
            if (IsBuildModel)
            {
                return;
            }
            IsBuildModel = true;
            var clamped = ClampedForm.GetModel() as HKFDJClamped;
            double num = clamped.num;
            var bolt = BoltForm.GetModel() as Bolt;
            var nut = NutForm.GetModel() as NutClass;
            //boltData = new BoltClass(bolt);
            {
                this.clamped = clamped;
                this.nut = nut;
            }
            dataGridView1.Rows.Add("n", clamped.n, "螺栓个数");
            dataGridView1.Rows.Add("d", boltData.NormalD_d, "螺栓公称");
            dataGridView1.Rows.Add("D", clamped.d, "螺栓孔直径公称");
            dataGridView1.Rows.Add("R", clamped.C, "节圆直径");
            dataGridView1.Rows.Add("Plane", "XY", "固定平面");
            dataGridView1.Rows.Add("Forces", "Vectot(0,0,-Z)", "等效螺栓压力");

            Entity boltEntity = BoltForm.GetModelEntity();
            Entity clampedEntity = ClampedForm.GetModelEntity();
            Entity nutEntity = NutForm.GetModelEntity();


            for (int i = 0; i < num - 1; i++)
            {
                var cloneClamped = clampedEntity.Clone() as Entity;
                cloneClamped.Translate(0, 0, (num - i - 1) * clamped.tf);
                model1.Entities.Add(cloneClamped, Color.Blue);
            }
            boltEntity.Translate(clamped.C / 2, 0, clamped.tf * num +  - (bolt.l));// flange.ddz
            nutEntity.Translate(clamped.C / 2, 0, -nut.NutHeight);// flange.ddz
            double r = 2 * Math.PI / clamped.n;

            for (int i = 0; i < clamped.n; i++)
            {
                var cloneBolt = boltEntity.Clone() as Entity;
                var cloneNut = nutEntity.Clone() as Entity;
                model1.Entities.Add(cloneBolt, Color.Red);
                model1.Entities.Add(cloneNut, Color.Cyan);
                boltEntity.Rotate(r, Vector3D.AxisZ);
                nutEntity.Rotate(r, Vector3D.AxisZ);
            }
            model1.Entities.Add(clampedEntity, Color.Blue);
            model1.ZoomFit();
        }

        private void _okBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult = DialogResult.Cancel;
        }

        private void _importFEMBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void BoltMaterialBtn_Click(object sender, EventArgs e)
        {
            StrengthGradeForm strengthGradeForm = new StrengthGradeForm();
            strengthGradeForm.ShowDialog();
            BoltMaterialClass material = strengthGradeForm.getMaterial();
            if (material == null)
            {
                return;
            }
            boltData.boltMaterial = material;
            updateParamDataGrids();
            strengthGradeForm.Hide();
            BoltMaterialBtn.Enabled = false;
        }

        private void ClampedMaterialBtn_Click(object sender, EventArgs e)
        {
            ClampedChooseFrm form = new ClampedChooseFrm();
            form.ShowDialog();
            ClampedMaterial material = form.getMaterial();
            if (material == null)
            {
                return;
            }
            clampedMaterial = material;
            updateParamDataGrids();
            form.Hide();
            ClampedMaterialBtn.Enabled = false;
        }


        private void JiheBtn_Click(object sender, EventArgs e)
        {
            JiHeParamFrm form = new JiHeParamFrm();
            form.ShowDialog();
            JiHeParameters param = form.GetJiheParams();
            if (param == null)
            {
                return;
            }
            jiHeParameters = param;
            updateParamDataGrids();
            form.Hide();
            JiheBtn.Enabled = false;
        }




        private void updateParamDataGrids()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add("NormalD_d", boltData.NormalD_d, "螺栓公称直径");
            dataGridView2.Rows.Add("ScrewP_P", boltData.ScrewP_P, "螺距");
            dataGridView2.Rows.Add("BoltLen_ls", boltData.BoltLen_ls, "螺杆长度");
            dataGridView2.Rows.Add("BoreD_dh", boltData.BoreD_dh, "镗孔直径");
            dataGridView2.Rows.Add("BoreD_dT", boltData.BoreD_dT, "");
            dataGridView2.Rows.Add("BoltHeadOutD_dw", boltData.BoltHeadOutD_dw, "螺栓头承载面外径");
            dataGridView2.Rows.Add("BoltHeadInnerD_da", boltData.BoltHeadInnerD_da, "螺栓头承载面内径");
            dataGridView2.Rows.Add("ScrewMidD_d2", boltData.ScrewMidD_d2, "螺纹中径");
            dataGridView2.Rows.Add("ScrewMinD_d3", boltData.ScrewMinD_d3, "螺纹小径");
            dataGridView2.Rows.Add("PolishRodLen_l1", boltData.PolishRodLen_l1, "光杆1长度");
            dataGridView2.Rows.Add("PolishRodLen_l2", boltData.PolishRodLen_l2, "光杆2长度");
            dataGridView2.Rows.Add("BoltNutSideWid_s", boltData.BoltNutSideWid_s, "螺母对边宽度");
            dataGridView2.Rows.Add("BoltNutScrewMinD_D1", boltData.BoltNutScrewMinD_D1, "螺母螺纹小径");

            if (boltData.boltMaterial != null)
            {
                dataGridView2.Rows.Add("BoltMaterialLevel", boltData.boltMaterial.BoltMaterialLevel, "强度等级");
                dataGridView2.Rows.Add("BoltMaterialRatio_fB", boltData.boltMaterial.BoltMaterialRatio_fB, "剪切强度系数");
                dataGridView2.Rows.Add("BoltMaterialEs", boltData.boltMaterial.BoltMaterialEs, "杨氏模量");
                dataGridView2.Rows.Add("BoltMaterialRpmin", boltData.boltMaterial.BoltMaterialRpmin, "最小屈服强度");
                dataGridView2.Rows.Add("BoltMaterialRm", boltData.boltMaterial.BoltMaterialRm, "抗拉强度");
            }
            
            if (clampedMaterial != null)
            {
                dataGridView2.Rows.Add("ClampedMaterialName", clampedMaterial.ClampedMaterialName, "连接件材料名");
                dataGridView2.Rows.Add("ClampedMaterialRatio_fB", clampedMaterial.ClampedMaterialRatio_fB, "连接件材料名");
                dataGridView2.Rows.Add("ClampedMaterialRatio_fG", clampedMaterial.ClampedMaterialRatio_fG, "连接件材料名");
                dataGridView2.Rows.Add("ClampedMaterialEp", clampedMaterial.ClampedMaterialEp, "连接件材料名");
                dataGridView2.Rows.Add("ClampedMaterialRmmin", clampedMaterial.ClampedMaterialRmmin, "连接件材料名");
            }
            
            if (jiHeParameters != null)
            {
                dataGridView2.Rows.Add("DA", jiHeParameters.DA, "接合面等效外径");
                dataGridView2.Rows.Add("DA_", jiHeParameters.DA_, "接合面上的面的等效外径");
                dataGridView2.Rows.Add("fz", jiHeParameters.fz, "嵌入深度");
                dataGridView2.Rows.Add("n", jiHeParameters.n, "载荷系数");

                if (jiHeParameters.PianXin != null)
                {
                    dataGridView2.Rows.Add("ssym", jiHeParameters.PianXin.ssym, "从0-0轴至螺栓轴的距离Ssym");
                    dataGridView2.Rows.Add("u", jiHeParameters.PianXin.u, "从0-0轴至开口处的距离u");
                    dataGridView2.Rows.Add("cB", jiHeParameters.PianXin.cB, "受弯体长度cB");
                    dataGridView2.Rows.Add("cT", jiHeParameters.PianXin.cT, "被连接件接合面长度cT");
                    dataGridView2.Rows.Add("b", jiHeParameters.PianXin.b, "受弯体宽度b");
                    dataGridView2.Rows.Add("bT", jiHeParameters.PianXin.bT, "被连接件接合面宽度bT");
                    dataGridView2.Rows.Add("e", jiHeParameters.PianXin.e, "从接合面带有张开风险的边缘至螺栓轴的距离e");
                    dataGridView2.Rows.Add("a", jiHeParameters.PianXin.a, "偏心距a");
                }
            }
            

            if (gongYiParameters != null)
            {
                dataGridView2.Rows.Add("Rz", gongYiParameters.Rz, "平均表面粗糙度");
                dataGridView2.Rows.Add("alphaA", gongYiParameters.alphaA, "拧紧系数");
                dataGridView2.Rows.Add("Ugmin", gongYiParameters.Ugmin, "螺纹接触面最小摩擦系数Ugmin");
                dataGridView2.Rows.Add("UTmin", gongYiParameters.UTmin, "被连接件接合面间最小摩擦系数UTmin");
                dataGridView2.Rows.Add("Ukmin", gongYiParameters.Ukmin, "螺栓头接触面最小摩擦系数Ukmin");

                if (gongYiParameters.jiaoBian != null)
                {
                    dataGridView2.Rows.Add("N", gongYiParameters.jiaoBian.N, "循环周期数");
                }
            }

            if (zaiHeParameters != null)
            {
                dataGridView2.Rows.Add("Fao", zaiHeParameters.Fao, "轴向载荷的上限值");
                dataGridView2.Rows.Add("Fau", zaiHeParameters.Fau, "轴向载荷的下限值");
                dataGridView2.Rows.Add("Mt", zaiHeParameters.Mt, "绕螺栓轴的扭矩");
                dataGridView2.Rows.Add("Fq", zaiHeParameters.Fq, "横向载荷");
                dataGridView2.Rows.Add("qf", zaiHeParameters.qf, "载荷传递通过内部接合面数量");
                dataGridView2.Rows.Add("Mb", zaiHeParameters.Mb, "工作弯矩");
                dataGridView2.Rows.Add("v", zaiHeParameters.v, "拧紧时材料的屈服点利用率");
            }
        }

        private void GongYiBtn_Click(object sender, EventArgs e)
        {
            GongYiParamFrm form = new GongYiParamFrm();
            form.ShowDialog();
            GongYiParameters param = form.GetGongYiParams();
            zhazhi = form.zhazhi;
            if (param == null)
            {
                return;
            }
            gongYiParameters = param;
            updateParamDataGrids();
            form.Hide();
            GongYiBtn.Enabled = false;
        }

        private void ZaiHeBtn_Click(object sender, EventArgs e)
        {
            ZaiHeParamFrm form = new ZaiHeParamFrm();
            form.ShowDialog();
            ZaiHeParameters param = form.GetZaiHeParams();
            dynamic_load = form.dynamic_load;
            if (param == null)
            {
                return;
            }
            zaiHeParameters = param;
            updateParamDataGrids();
            form.Hide();
            ZaiHeBtn.Enabled = false;
        }

        Solution solution;
        ComputeResult rs;
        private void VDICalBtn_Click(object sender, EventArgs e)
        {
            calculate();
            DisplayResultFrm form = new DisplayResultFrm(solution, rs);
            form.Show();
        }

        private void calculate()
        {
            if (rs == null)
            {
                rs = new ComputeResult();
            }

            if (solution == null)
            {
                solution = new Solution();
            }
            // r1
            if (solution.r1 == null)
            {
                solution.r1 = new R1();
            }
            solution.r1.alpha = gongYiParameters.alphaA;
            rs.alphaA = solution.r1.alpha;

            #region R2
            // r2
            if (solution.r2 == null)
            {
                solution.r2 = new R2(boltData);
            }
            solution.r2.w = 1; // 通孔
            solution.r2.D_A = jiHeParameters.DA;
            solution.r2.Lk = clamped.tf * 2;
            solution.r2.hmin = clamped.tf;
            solution.r2.setTanPhi_D();
            solution.r2.setDAGr();
            
            if (jiHeParameters.PianXin == null)
            {
                // 同心
            }
            else
            {
                // 偏心
                solution.r2.s_sym = jiHeParameters.PianXin.ssym;
                solution.r2.u = jiHeParameters.PianXin.u;
                solution.r2.cb = jiHeParameters.PianXin.cB;
                solution.r2.ct = jiHeParameters.PianXin.cT;
                solution.r2.b = jiHeParameters.PianXin.b;
                solution.r2.bt = jiHeParameters.PianXin.bT;
                solution.r2.e = jiHeParameters.PianXin.e;
                solution.r2.a = jiHeParameters.PianXin.a;
                solution.r2.ibt = solution.r2.bt * Math.Pow(solution.r2.ct, 3) / 12;
                if (solution.r2.ct < boltData.BoltHeadOutD_dw)
                {
                    MessageBox.Show("预期输入：cT > dw");
                    return ;
                }
                if (solution.r2.cb < boltData.BoltHeadOutD_dw)
                {
                    MessageBox.Show("预期输入：cb > dw");
                    return ;
                }
                if (solution.r2.bt < boltData.BoltHeadOutD_dw)
                {
                    MessageBox.Show("预期输入：bt > dw");
                    return ;
                }
                if (solution.r2.b < boltData.BoltHeadOutD_dw)
                {
                    MessageBox.Show("预期输入：b > dw");
                    return ;
                }
            }

            if (zaiHeParameters.Fq == 0)
            {
                // 无横向剪力  单螺栓
                solution.r2.setF_kerf(zaiHeParameters.Fao.ToString());
            }
            else
            {
                //有剪力
                if (zaiHeParameters.Mt == 0)
                {
                    // 无扭矩
                    solution.r2.setFkq(zaiHeParameters.Fq.ToString(), zaiHeParameters.qf.ToString(), gongYiParameters.UTmin.ToString());
                }
                else
                {
                    // 有剪力和扭矩
                    solution.r2.setFkq(zaiHeParameters.Fq.ToString(), zaiHeParameters.qf.ToString(), gongYiParameters.UTmin.ToString(),
                        zaiHeParameters.Mt.ToString(), clamped.n.ToString(), ((solution.r2.D_A + boltData.BoltHeadInnerD_da) / 4).ToString(), 1);
                }
            }
            // 内压 
            //空着


            if (jiHeParameters.PianXin == null)
            {
                // 同心不算
            }
            else
            {
                // 防止松开
                if (jiHeParameters.PianXin.a == 0)
                {
                    // 无
                }
                else
                {
                    // 有
                    // 必须设置内压面积AD
                    solution.r2.setFka();
                }
                solution.r2.setF_kerf();
                // check
                if (solution.r2.checkClampedLs(nut.NutHeight))
                {
                    // 满足
                }
                else
                {
                    return ;
                }
            }
            

            rs.Fkerf = solution.r2.f_kerf;

            #endregion

            #region r3
            // r3 
            // R3.1: 计算回弹及系数
            if (solution.r3 == null)
            {
                solution.r3 = new R3(boltData, solution.r2);
            }

            solution.r3.Nn = jiHeParameters.n;
            solution.r3.AN = boltData.NormalD_d * boltData.NormalD_d * Math.PI / 4;
            solution.r3.Ad3 = boltData.ScrewMinD_d3 * boltData.ScrewMinD_d3 * Math.PI / 4;
            solution.r3.setLm();
            solution.r3.setBetaS(boltData.boltMaterial.BoltMaterialEs.ToString());
            solution.r3.setBetaS(boltData.boltMaterial.BoltMaterialEs.ToString());

            solution.r3.setDeltaP(clampedMaterial.ClampedMaterialEp.ToString());

            if (jiHeParameters.PianXin == null)
            {
                // 同心不算
            }
            else
            {
                if (jiHeParameters.PianXin.a != 0)
                {
                    solution.r3.G = boltData.BoltHeadOutD_dw + solution.r2.hmin; // 通孔
                    if (solution.r3.G < solution.r2.ct)
                    {
                        Console.WriteLine("G:" + solution.r3.G);
                        MessageBox.Show("G超过限制尺寸，vdi 不适用于计算此情况R1");
                        return ;
                    }
                    solution.r3.setDeltaP_star(clampedMaterial.ClampedMaterialEp.ToString());

                }
            }
            solution.r3.setMB(clampedMaterial.ClampedMaterialEp.ToString());
            //solution.r3.setI_V_Bers();
            double phi = solution.r3.getPhi();
            rs.deltas = solution.r3.deltaS;
            rs.deltap = solution.r3.deltaP;
            rs.phi = phi;
            #endregion


            #region R4
            if (jiHeParameters.fz == 0)
            {
                solution.r4.ffz = solution.r4.table5(gongYiParameters.Rz, solution.r2.w, zaiHeParameters.Fq);
            }
            else
            {
                solution.r4.ffz = jiHeParameters.fz;
            }
            solution.r4.setFz();
            rs.Fz = solution.r4.FZ;
            #endregion


            #region R5
            if (solution.r5 == null)
            {
                solution.r5 = new R5(solution.r2.f_kerf, solution.r3.phi, solution.r2.Fao, solution.r4.FZ);
            }

            rs.Fmmin = solution.r5.getFmmin();

            #endregion

            #region R6
            if (solution.r6 == null)
            {
                solution.r6 = new R6(solution.r1.alpha, solution.r5.getFmmin());
            }

            rs.Fmmax = solution.r6.getFmmax();

            #endregion

            #region R7
            if (solution.r7 == null)
            {
                solution.r7 = new R7(boltData, solution.r2.UGmin, solution.r2.v);
            }

            double fmzul = solution.r7.getFmzul();
            double f_mtb = solution.r7.getF_mtb();
            rs.Fmzul = fmzul;
            #endregion


            #region R8
            if (solution.r8 == null)
            {
                solution.r8 = new R8(boltData, solution.r7.getFmzul(), solution.r2.Fao, phi, solution.r7.Ugmin);
            }
            rs.Sf = solution.r8.getSf();

            #endregion

            #region R9交变
            if (solution.r9 == null)
            {
                solution.r9 = new R9(boltData, solution.r2.s_sym, solution.r3.phi, solution.r7.getFmzul(), boltData.boltMaterial.BoltMaterialRpmin, solution.r2.Fao, solution.r2.Fau);
            }

            if (dynamic_load == "静态加载")
            {
                MessageBox.Show("静态加载不计算交变");
                rs.Sd = 0;
            }
            else
            {
                if (solution.r2.s_sym == 0)
                {
                    // 同心
                    rs.Sd = solution.r9.getSd(zhazhi);
                }
                else
                {
                    rs.Sd = solution.r9.getSd(zhazhi, solution.r3.phi, solution.r2.Mb, solution.r2.Lk, boltData.boltMaterial.BoltMaterialEs,
                        clampedMaterial.ClampedMaterialEp, (boltData.ScrewMidD_d2 + boltData.ScrewMinD_d3) / 2, solution.r3.I_bers);
                }
            }
            
            #endregion


            #region R10

            if (solution.r10 == null)
            {
                solution.r10 = new R10(boltData, solution.r7.getFmzul(), clampedMaterial.ClampedMaterialRatio_fG * clampedMaterial.ClampedMaterialRmmin, solution.r1.alpha, solution.r4.FZ, solution.r2.Fao);
            }
            // 螺母
            double hs = 0;

            rs.Sp = solution.r10.getSp(hs, nut);
            rs.Sp_load = solution.r10.getSp_load(hs, nut);
            rs.Spn = solution.r10.getSpn(hs, nut);
            rs.Spn_load = solution.r10.getSpn_load(hs, nut);

            #endregion

            #region r11
            if (solution.r11 == null)
            {
                solution.r11 = new R11();
            }
            MessageBox.Show("螺栓螺母使用相同强度等级，不计算啮合长度");
            #endregion

            #region r12
            if (solution.r12 == null)
            {
                solution.r12 = new R12(boltData, solution.r7.getFmzul(), solution.r1.alpha, solution.r3.phi, solution.r2.Fao, solution.r4.FZ);
            }

            if (solution.r2.f_qmax == 0)
            {
                MessageBox.Show("无剪力，无需验证剪切");
                double fkrmin = solution.r12.getFKRmin();
                
            }
            else
            {
                double fkrmin = solution.r12.getFKRmin();
                // ra = (DA + Dhamax) / 2
                double ra = solution.r2.r_a;
                if (ra == 0)
                {
                    ra = (solution.r2.D_A + solution.r2.Dhamax) / 2;
                }
                double sg = solution.r12.getSg(solution.r2.f_qmax, solution.r2.q_f, solution.r2.u_Tmin, solution.r2.M_t, solution.r2.q_m, ra);

                if (sg >= solution.r2.sgsoll)
                {
                    if (solution.r2.dtau != 0)
                    {
                        Console.WriteLine("dtau" + solution.r2.dtau);
                        rs.Sa = solution.r12.getSa(boltData.boltMaterial.BoltMaterialRm, solution.r2.f_qmax, solution.r2.dtau);
                    }
                    else
                    {
                        rs.Sa = solution.r12.getSa(boltData.boltMaterial.BoltMaterialRm, solution.r2.f_qmax);
                    }
                }
                else
                {
                    MessageBox.Show("应满足sg>=SGoll");
                }
                if (rs.Sa >= 1.1)
                {
                    Console.WriteLine("安全");
                }
                else
                {
                    Console.WriteLine("不安全");
                }
            }

            #endregion

            #region r13
            if (solution.r13 == null)
            {
                solution.r13 = new R13(boltData, boltData.BoltHeadInnerD_da, solution.r2.UKmin, solution.r2.UGmin, solution.r7.getFmzul());
            }
            rs.Ma = solution.r13.getMA();

            #endregion
        }
    }
}
