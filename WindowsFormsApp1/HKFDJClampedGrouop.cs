using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devDept.Eyeshot.Entities;

namespace WindowsFormsApp1
{
    class HKFDJClampedGrouop : IModelEntity, IModelFemMesh
    {
        private List<Tuple<HKFDJClamped, int>> clampedGroup = new List<Tuple<HKFDJClamped, int>>(); // 连接件列表
        private FemMesh _flangeFMCache; // 有限元连接件


        public Entity GetEntity()
        {
            return GetClamped();
        }

        private Solid GetClamped()
        {
            Solid res;
            for (int i = 0; i < clampedGroup.Count; i++)
            {
                var clone = clampedGroup[i].Item1 as HKFDJClamped;
                int height = clampedGroup[i].Item2;
                clone.tf = height;
                var entity = clone.GetEntity() as Entity;
                
            }
        }

        public FemMesh GetFemMesh()
        {
            throw new NotImplementedException();
        }
    }
}
