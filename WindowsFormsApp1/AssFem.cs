using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateBotSpring;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using WindowsFormsApp1.ClampedModel;

namespace WindowsFormsApp1
{
    public class AssFem : AssBase, IModelFemMesh
    {
        public FemMesh GetFemMesh()
        {
            List<Solid> list = new List<Solid>();
            var clampedList = clamped.GetEntitys();
            for (int i = clampedList.Count - 1; i >= 0; i--)
            {
                clampedList[i].Translate(0, 0, bolt.BoltLen_ls - clamped.tf * clampedList.Count);
                list.Add((Solid)clampedList[i]);
            }
            // 螺栓螺母组
            var boltSolid = bolt.GetEntity() as Solid;
            var nutSolid = nut.GetEntity() as Solid;
            nutSolid.Translate(0, 0, bolt.BoltLen_ls - clamped.tf * clampedList.Count - nut.NutHeight);
            var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];

            double angle = Math.PI * 2 / clamped.n;
            double angletemp = angle;
            for (int i = 0; i < clamped.n; i++)
            {
                // 螺栓
                var temp = boltconns.Clone() as Solid;
                temp.Translate(clamped.C / 2 * Math.Cos(angle), clamped.C / 2 * Math.Sin(angle), 0);  // +1是让union整合成一个实体，有空隙无法整合

                double kd = 3;
                var box = Solid.CreateBox(kd, kd, 0.1);
                box.Translate(clamped.C / 2 * Math.Cos(angle) - kd / 2, clamped.C / 2 * Math.Sin(angle) - kd / 2, bolt.BoltLen_ls + bolt.BoltNutSideWid_s * 1.155 / 2);
                _boundingBoxOfBoltHole.Add(new Tuple<Point3D, Point3D>(box.BoxMin, box.BoxMax));
                var arr = Solid.Difference(temp, box);
                angle += angletemp;
                list.Add(arr[0]);
            }

            var solid = Solid.Union(list);
            MessageBox.Show(solid.Length + "实体个数");
            var mesh = solid[0].ConvertToMesh();
            assFemMesh = mesh.ConvertToFemMesh(devDept.Graphics.Material.StainlessSteel, false);
            return assFemMesh;
        }

        private List<Tuple<Point3D, Point3D>> _boundingBoxOfBoltHole = new List<Tuple<Point3D, Point3D>>();

        public void SetForceFor(int index, double fz, double fx = 0, double fy = 0)
        {
            if (assFemMesh == null)
            {
                GetFemMesh();
            }
            var box = _boundingBoxOfBoltHole[index];
            assFemMesh.SetForce(box.Item1, box.Item2, .1, new Vector3D(fx, fy, -fz));
        }
        public AssFem()
        {
        }

        public void SetBoltAndClampedMesh(FemMesh bolt, FemMesh clamped, int n, double r)
        {
            var fm = clamped;
            var boltfm = bolt;
            double angle = Math.PI * 2 / n;
            for (int i = 0; i < n; i++)
            {
                var tempFem = boltfm.Clone() as FemMesh;
                tempFem.Translate(r, 0, 0);
                fm.MergeWith(tempFem, true);
                fm.Rotate(angle, Vector3D.AxisZ);
            }
            assFemMesh = fm;
        }

        public Entity GetEntity()
        {
            return GetAssEntity();
        }

        private Entity GetAssEntity() { return null; }

        //public EntityList GetEntitys()
        //{
        //    assEntities.Clear();
        //    if (clamped != null)
        //    {
        //        var clampedList = clamped.GetEntitys();
        //        for (int i = clampedList.Count - 1; i >= 0; i--)
        //        {
        //            clampedList[i].Translate(0, 0, bolt.BoltLen_ls - clamped.tf * clampedList.Count);
        //            assEntities.Add(clampedList[i]);
        //        }
        //        // 螺栓螺母组
        //        var boltSolid = bolt.GetEntity() as Solid;
        //        var nutSolid = nut.GetEntity() as Solid;
        //        nutSolid.Translate(0, 0, bolt.BoltLen_ls - clamped.tf * clampedList.Count - nut.NutHeight);
        //        var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];

        //        double angle = Math.PI * 2 / clamped.n;
        //        double angletemp = angle;
        //        for (int i = 0; i < clamped.n; i++)
        //        {
        //            // 螺栓
        //            var temp = boltconns.Clone() as Solid;
        //            temp.Translate(clamped.C / 2 * Math.Cos(angle), clamped.C / 2 * Math.Sin(angle), 0);
        //            angle += angletemp;
        //            assEntities.Add(temp);
        //        }
        //    }
        //    else
        //    {
        //        double feilunHeight = selfClamped.feilun.tf;
        //        double falanHeight = selfClamped.falan.tf;

        //        var clampedList = selfClamped.GetEntitilist();
        //        for (int i = clampedList.Count - 1; i >= 0; i--)
        //        {
        //            clampedList[i].Translate(0, 0, bolt.BoltLen_ls - feilunHeight * 2 - falanHeight) ;
        //            assEntities.Add(clampedList[i]);
        //        }
        //        // 螺栓螺母组
        //        var boltSolid = bolt.GetEntity() as Solid;
        //        var nutSolid = nut.GetEntity() as Solid;
        //        nutSolid.Translate(0, 0, bolt.BoltLen_ls - feilunHeight * 2 - falanHeight* 2 - nut.NutHeight);
        //        var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];

        //        double angle = Math.PI * 2 / selfClamped.falan.n;
        //        double angletemp = angle;
        //        for (int i = 0; i < selfClamped.falan.n; i++)
        //        {
        //            // 螺栓
        //            var temp = boltconns.Clone() as Solid;
        //            temp.Translate(selfClamped.falan.C / 2 * Math.Cos(angle), selfClamped.falan.C / 2 * Math.Sin(angle), 0);
        //            angle += angletemp;
        //            assEntities.Add(temp);
        //        }
        //    }
            
        //    return assEntities;
        //}

        public override EntityList GetEntitilist()
        {
            if (assEntities == null)
            {
                assEntities = new EntityList();
            }
            if (clamped != null)
            {
                var clampedList = clamped.GetEntitilist();
                for (int i = clampedList.Count - 1; i >= 0; i--)
                {
                    clampedList[i].Translate(0, 0, bolt.BoltLen_ls - clamped.tf * clampedList.Count);
                    assEntities.Add(clampedList[i], Color.Blue);
                }
                // 螺栓螺母组
                var boltSolid = bolt.GetEntity() as Solid;
                var nutSolid = nut.GetEntity() as Solid;
                nutSolid.Translate(0, 0, bolt.BoltLen_ls - clamped.tf * clampedList.Count - nut.NutHeight);
                var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];

                double angle = Math.PI * 2 / clamped.n;
                double angletemp = angle;
                for (int i = 0; i < clamped.n; i++)
                {
                    // 螺栓
                    var temp = boltconns.Clone() as Solid;
                    temp.Translate(clamped.C / 2 * Math.Cos(angle), clamped.C / 2 * Math.Sin(angle), 0);
                    angle += angletemp;
                    assEntities.Add(temp, Color.Red);
                }
            }
            else
            {
                double feilunHeight = selfClamped.feilun.tf;
                double falanHeight = selfClamped.falan.tf;

                var clampedList = selfClamped.GetEntitilist();
                for (int i = clampedList.Count - 1; i >= 0; i--)
                {
                    clampedList[i].Translate(0, 0, bolt.BoltLen_ls - feilunHeight * 2 - falanHeight-1);
                    assEntities.Add(clampedList[i]);
                }
                // 螺栓螺母组
                var boltSolid = bolt.GetEntity() as Solid;
                var nutSolid = nut.GetEntity() as Solid;
                nutSolid.Translate(0, 0, bolt.BoltLen_ls - feilunHeight * 2 - falanHeight * 2 - nut.NutHeight);
                var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];

                double angle = Math.PI * 2 / selfClamped.falan.n;
                double angletemp = angle;
                for (int i = 0; i < selfClamped.falan.n; i++)
                {
                    // 螺栓
                    var temp = boltconns.Clone() as Solid;
                    temp.Translate(selfClamped.falan.C / 2 * Math.Cos(angle), selfClamped.falan.C / 2 * Math.Sin(angle), 0);
                    angle += angletemp;
                    assEntities.Add(temp, Color.Red);
                }
            }
            return assEntities;

        }

        public EntityList assEntities ;
        private FemMesh assFemMesh;
        private Entity assEntity;

        public BoltClass bolt { get; set; }
        public HKFDJClamped clamped { get; set; }
        public NutClass nut { get; set; }
        public SelfAssClamped selfClamped { get;  set; }
    }
}
