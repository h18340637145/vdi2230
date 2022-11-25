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

    partial class Draw
    {
        public static FemMesh fm;
        public static Color Color = Color.Black;


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

    }
}