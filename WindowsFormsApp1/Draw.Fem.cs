using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Eyeshot.Triangulation;
using devDept.Geometry;
using devDept.Graphics;
using devDept.Eyeshot.Fem;
using devDept.Eyeshot.Translators;
using Region = devDept.Eyeshot.Entities.Region;
using CreateBotSpring;
using WindowsFormsApp1;

namespace WindowsApplication1
{

    /// <summary>
    /// 多步骤绘图参数
    /// </summary>
    public class MulForcesStepsDrawParam
    {
        /// <summary>
        /// 力
        /// </summary>
        public double[,] Forces { set; get; }

        /// <summary>
        /// 要绘制的拧紧批次
        /// </summary>
        public int Batch { set; get; }

        /// <summary>
        /// 要绘制的螺栓索引
        /// </summary>
        public int BoltIndex { set; get; }

        /// <summary>
        /// 本次绘制时是否覆盖前一次绘制结果，如果为真，则仅绘制本次结果，否则保留前一次绘制结果
        /// </summary>
        public bool IsOverlay { set; get; }
    }

    public class BoltDram
    {
        public double Forces { set; get; }
    }

    partial class Draw
    {
        public static FemMesh fm;
        public static FemMesh boltfm;
        public static AssFem assfm;
        public static Color Color = Color.Black;
        public static HKFDJClamped Clamped { set; get; }
        public static Bolt bolt { set; get; }

        public static void DrawBolt(Model model, BoltChooseClass dataBolt)
        {
            Bolt bolt = new Bolt(dataBolt);
            
            if (bolt == null)
            {
                throw new Exception("bolt is null");
            }
            model.Entities.Clear();
            model.Enabled = true;
            try
            {
                Entity boltEntity = bolt.GetEntity();
                model.Entities.Add(boltEntity, Color.Red);
                model.ZoomFit();
                model.Invalidate();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw new Exception("输入参数错误！请仔细检查");
            }
        }


        // 绘制单螺栓连接的方形
        public static void Flange(Model model, BoltChooseClass bolt, ClampedClass clamped)
        {
            int baseRadius = (int)bolt.NormalD_d * 4;
            int height = (int)bolt.BoltLen_ls;
            int slice = 100;
            Mesh mesh = Mesh.CreateCone(baseRadius, baseRadius, height, slice);
            model.Entities.Add(mesh, "Default", Color.GreenYellow);

        }

        public static void arc(Model model, BoltChooseClass bolt, ClampedClass clamped)
        {
            int d = (int)(bolt.NormalD_d * 5);
            //double z = 30;
            //double radius = 15;

            Line l1 = new Line(d/2, 0, 0, -d/2, 0, 0);
            Arc a1 = new Arc(new Point3D(0, 0, 0), new Point3D(-d/2, 0, 1), new Point3D(d/2, 0, 1));
            //Line l2 = new Line(radius, 0, z + radius, 30, 0, z + radius);

            // 合成面
            CompositeCurve composite = new CompositeCurve(l1, a1);
            LinearPath lpOuter = new LinearPath(10, 16);
            LinearPath lpInner = new LinearPath(5, 11);
            lpInner.Translate(2.5, 2.5, 0);
            lpInner.Reverse();
            //devDept.Eyeshot.Entities.Region.CreatePolygon(new Point3D(0, 0, 0)).ExtrudeAsSolid;
            //Solid
            Region reg = new Region(lpOuter, lpInner);

            Mesh mesh = reg.SweepAsMesh(composite, 0.25);
            //mesh.Translate(offsetX - 10, offsetY - 8, 0);
            model.Entities.Add(mesh, "Default", Color.Brown);
        }

        internal static void InitFlangeFem(Simulation simulation1)
        {
            fm = Clamped.GetFemMesh();
            //boltfm = bolt.GetFemMesh();
            //double angle = Math.PI * 2 / Clamped.n;
            //for (int i = 0; i < Clamped.n; i++)
            //{
            //    var tempFem = boltfm.Clone() as FemMesh;
            //    tempFem.Translate((Clamped.inner_B + Clamped.outer_A) / 4, 0, 0);
            //    fm.MergeWith(tempFem, true);
            //    fm.Rotate(angle, Vector3D.AxisZ);
            //}
            //double r = (Clamped.inner_B + Clamped.outer_A) / 4;
            //if (assfm==null)
            //{
            //    assfm = new AssFem();
            //}
            //assfm.SetBoltAndClampedMesh(boltfm, fm, (int)Clamped.n, r);
            fm = Clamped.GetFemMesh();
            fm.SymbolSize = 0.3;
            fm.AmplificationFactor = 0;
            simulation1.Entities.Add(fm);
        }

        internal static void InitBoltFem(Simulation simulation2)
        {
            boltfm = bolt.GetFemMesh();
            boltfm.SymbolSize = 0.3;
            boltfm.AmplificationFactor = 0;
            simulation2.Entities.Add(boltfm);
        }

        public static void DrawFlangeFemFrame(Simulation simulation, MulForcesStepsDrawParam param)
        {
            simulation.Entities.Clear();
            InitFlangeFem(simulation);
            for (int i = 0; i < Clamped.n; i++)
            {
                Clamped.SetForceFor(i, param.Forces[param.Batch, i]);
            }
            simulation.Entities.Add(fm);
            Solver solver = new Solver(fm);
            simulation.StartWork(solver);

            fm.AmplificationFactor = fm.OptimalAmplificationFactor * .1;

            simulation.Entities.UpdateBoundingBox();
            fm.Compile(new CompileParams(simulation)
            {
                Legend = simulation.Legends[0]
            });

            simulation.Invalidate();
        }

        public static void DrawBoltFemFrame(Simulation simulation, BoltDram param)
        {
            simulation.Entities.Clear();
            InitBoltFem(simulation);
            //for (int i = 0; i < 36; i++)
            //{
            //    //Clamped.SetForceFor(i, param.Forces);
            //    bolt.SetForceFor(i, param.Forces);
            //}
            var temp = Plane.XY;
            temp.Translate(0, 0, bolt.k + bolt.l);
            boltfm.SetPressure(temp, 1, new Vector3D(0, 0, -1000));
            //double p = bolt.p;
            //double b = bolt.b;
            //for (int i = 0; i < b / p ; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        bolt.SetForceForLuoWen(i, j, param.Forces / (i + 2));
            //    }
            //    ////boltfm.SetForce(Plane.XY, 0, new Vector3D(0, 0 ,-100000));
            //    //Plane plane = Plane.XY;
            //    //plane.Translate(0, 0, p * i);
            //    ////plane.Rotate(Math.PI / 2 / 3 / 5, new Vector3D(0, 0, 1));
            //    //boltfm.SetPressure(plane, 1, new Vector3D(0, 0, param.Forces / (i + 2)));
            //}



            simulation.Entities.Add(boltfm);
            Solver solver = new Solver(boltfm);
            simulation.StartWork(solver);

            boltfm.AmplificationFactor = boltfm.OptimalAmplificationFactor * .1;

            simulation.Entities.UpdateBoundingBox();
            boltfm.Compile(new CompileParams(simulation)
            {
                Legend = simulation.Legends[0]
            });

            simulation.Invalidate();
        }
    }
}