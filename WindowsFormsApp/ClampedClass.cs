using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devDept.Eyeshot.Entities;

namespace WindowsFormsApp1
{
    public class ClampedMaterial
    {
        public string ClampedMaterialName { get; set; }
        public double ClampedMaterialRatio_fB { get; set; }
        public double ClampedMaterialRatio_fG { get; set; }
        public double ClampedMaterialEp { get; set; }
        public double ClampedMaterialRmmin { get; set; }
        public double ClampedMaterialA_alpha { get; set; }
        public double ClampedMaterialTmax { get; set; }
    }

    public class ClampedClass : IModelEntity
    {
        private const int _slice = 100;
        private const double _tol = .1;

        public double Height { get; set; }
        public double D { get; set; }
        public double Offsetz { get; set; }
        public ClampedMaterial clampedMaterial { get; set; }

        public ClampedClass()
        {
            clampedMaterial = new ClampedMaterial();
        }
        public ClampedClass(double height, double d)
        {
            this.Height = height;
            this.D = d;
            clampedMaterial = new ClampedMaterial();
        }
        private Entity GetClamped(int type)
        {
            //Solid clamped;
            var clampedModel = Solid.CreateBox(D, D / 2 ,Height);
            clampedModel.Translate(-D / 2, 0, this.Offsetz);
            return clampedModel;
            throw new NotImplementedException();
        }

        public Entity GetEntity()
        {
            return GetClamped(1);
        }

        //public Entity GetEntity(double height)
        //{
        //    return GetClamped(height);
        //}
    }
}
