using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateBotSpring;
using devDept.Eyeshot.Entities;
using devDept.Geometry;

namespace WindowsFormsApp1
{
    public class AssFem : IModelFemMesh,IModelEntity
    {
        public FemMesh GetFemMesh()
        {
            return assFemMesh;
        }


        public AssFem()
        {
            num = 2;
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

        private Entity GetAssEntity()
        {
            //// 连接件
            //var clampedSolid = clamped.GetEntity() as Solid;
            //clampedSolid.Translate(0, 0, bolt.l - clamped.tf);
            //var clampedSolid2 = clampedSolid.Clone() as Solid;
            //clampedSolid2.Translate(0, 0, bolt.l - clamped.tf * 2);
            //var res = Solid.Union(new List<Solid> { clampedSolid, clampedSolid2 })[0];
            //res.Translate(0, 0, -bolt.k);
            
            
            //// 螺栓螺母组
            var boltSolid = bolt.GetEntity() as Solid;
            var nutSolid = nut.GetEntity() as Solid;
            nutSolid.Translate(0, 0, bolt.l - clamped.tf * 2 - nut.NutHeight);
            var boltconns = Solid.Union(new List<Solid> { boltSolid, nutSolid })[0];


            // 连接件个数
            // 连接件厚度
            var clampedSolid = clamped.GetEntity() as Solid;
            for (int i = 1; i < num; i++)
            {
                var temp = clampedSolid.Clone() as Solid;
                temp.Translate(0, 0, clamped.tf * i);
                clampedSolid = Solid.Union(new List<Solid> { clampedSolid, temp })[0];
            }
            clampedSolid.Translate(0, 0, bolt.l - clamped.tf * num);

            //// 根据孔个数建模螺栓组装配
            //Circle boltCircle = new Circle(new Point3D(d / 2, 0, 0), 0.1);
            double angle = Math.PI * 2 / clamped.n;
            for (int i = 0; i < clamped.n; i++)
            {
                // 螺栓
                var temp = boltconns.Clone() as Solid;
                temp.Translate(clamped.C / 2, 0, 0);
                clampedSolid = Solid.Union(new List<Solid> { clampedSolid, temp })[0];
                clampedSolid.Rotate(angle, Vector3D.AxisZ);
            }
            assEntity = clampedSolid;
            //if (solids == null || solids.Length != 1)
            //{
            //    throw new Exception($"实体合并结果异常, 合并结果={solids.Length}");
            //}
            //assEntity = res;
            return assEntity;
        }

        private FemMesh assFemMesh;
        private Entity assEntity;

        public Bolt bolt { get; set; }
        public HKFDJClamped clamped { get; set; }
        public NutClass nut { get; set; }
        public int num { get; set; }
    }
}
