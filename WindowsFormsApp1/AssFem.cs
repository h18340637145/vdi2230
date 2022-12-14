using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateBotSpring;
using devDept.Eyeshot.Entities;
using devDept.Geometry;

namespace WindowsFormsApp1
{
    public class AssFem : IModelFemMesh, IModelEntityClampeds
    {
        public FemMesh GetFemMesh()
        {
            List<Solid> list = new List<Solid>();
            var clampedList = clamped.GetEntitys();
            for (int i = clampedList.Count - 1; i >= 0; i--)
            {
                clampedList[i].Translate(0, 0, bolt.l - clamped.tf * clampedList.Count);
                list.Add((Solid)clampedList[i]);
            }
            // 螺栓螺母组
            var boltSolid = bolt.GetEntity() as Solid;
            var nutSolid = nut.GetEntity() as Solid;
            nutSolid.Translate(0, 0, bolt.l - clamped.tf * clampedList.Count - nut.NutHeight);
            var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];

            double angle = Math.PI * 2 / clamped.n;
            double angletemp = angle;
            for (int i = 0; i < clamped.n; i++)
            {
                // 螺栓
                var temp = boltconns.Clone() as Solid;
                temp.Translate(clamped.C / 2 * Math.Cos(angle+1), clamped.C / 2 * Math.Sin(angle+1), 0);  // +1是让union整合成一个实体，有空隙无法整合

                double kd = 3;
                var box = Solid.CreateBox(kd, kd, 0.1);
                box.Translate(clamped.C / 2 * Math.Cos(angle + 1) - kd / 2, clamped.C / 2 * Math.Sin(angle + 1) - kd / 2, bolt.l + bolt.k);
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
        //private Entity GetAssEntity()
        //{
        //    //// 连接件
        //    //var clampedSolid = clamped.GetEntity() as Solid;
        //    //clampedSolid.Translate(0, 0, bolt.l - clamped.tf);
        //    //var clampedSolid2 = clampedSolid.Clone() as Solid;
        //    //clampedSolid2.Translate(0, 0, bolt.l - clamped.tf * 2);
        //    //var res = Solid.Union(new List<Solid> { clampedSolid, clampedSolid2 })[0];
        //    //res.Translate(0, 0, -bolt.k);


        //    //// 螺栓螺母组
        //    var boltSolid = bolt.GetEntity() as Solid;
        //    var nutSolid = nut.GetEntity() as Solid;
        //    nutSolid.Translate(0, 0, bolt.l - clamped.tf * 2 - nut.NutHeight);
        //    var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];


        //    // 连接件个数
        //    // 连接件厚度
        //    var clampedSolid = clamped.GetEntity() as Solid;
        //    for (int i = 1; i < num; i++)
        //    {
        //        var temp = clampedSolid.Clone() as Solid;
        //        temp.Translate(0, 0, clamped.tf * i);
        //        clampedSolid = Solid.Union(new List<Solid> { clampedSolid, temp })[0];
        //    }
        //    clampedSolid.Translate(0, 0, bolt.l - clamped.tf * num);

        //    //// 根据孔个数建模螺栓组装配
        //    //Circle boltCircle = new Circle(new Point3D(d / 2, 0, 0), 0.1);
        //    double angle = Math.PI * 2 / clamped.n;
        //    for (int i = 0; i < clamped.n; i++)
        //    {
        //        // 螺栓
        //        var temp = boltconns.Clone() as Solid;
        //        temp.Translate(clamped.C / 2, 0, 0);
        //        clampedSolid = Solid.Union(new List<Solid> { clampedSolid, temp })[0];
        //        clampedSolid.Rotate(angle, Vector3D.AxisZ);
        //    }
        //    assEntity = clampedSolid;
        //    //if (solids == null || solids.Length != 1)
        //    //{
        //    //    throw new Exception($"实体合并结果异常, 合并结果={solids.Length}");
        //    //}
        //    //assEntity = res;
        //    return assEntity;
        //}

        public List<Entity> GetEntitys()
        {
            assEntities.Clear();
            var clampedList = clamped.GetEntitys();
            for (int i = clampedList.Count - 1; i >= 0; i--)
            {
                clampedList[i].Translate(0, 0, bolt.l - clamped.tf * clampedList.Count);
                assEntities.Add(clampedList[i]);
            }
            // 螺栓螺母组
            var boltSolid = bolt.GetEntity() as Solid;
            var nutSolid = nut.GetEntity() as Solid;
            nutSolid.Translate(0, 0, bolt.l - clamped.tf * clampedList.Count - nut.NutHeight);
            var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];

            double angle = Math.PI * 2 / clamped.n;
            double angletemp = angle;
            for (int i = 0; i < clamped.n; i++)
            {
                // 螺栓
                var temp = boltconns.Clone() as Solid;
                temp.Translate(clamped.C / 2 * Math.Cos(angle), clamped.C / 2 * Math.Sin(angle), 0);
                angle += angletemp;
                assEntities.Add(temp);
            }
            return assEntities;
        }

        public List<Entity> assEntities = new List<Entity>();
        private FemMesh assFemMesh;
        private Entity assEntity;

        public Bolt bolt { get; set; }
        public HKFDJClamped clamped { get; set; }
        public NutClass nut { get; set; }
    }
}
