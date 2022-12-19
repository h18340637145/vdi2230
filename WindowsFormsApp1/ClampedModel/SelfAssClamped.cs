using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsFormsApp1.ClampedModel
{
    public class SelfAssClamped : ClampedHeight
    {
        public N4FaLanClamped falan { get; set; }
        public FeilunClamped feilun { get; set; }

        public override Entity GetEntity()
        {
            return GetSolid();
        }
        private Solid GetSolid()
        {
            N4FaLanClamped symFaln = new N4FaLanClamped(falan);
            FeilunClamped symFeilun = new FeilunClamped(feilun);
            Solid falanSolid = (Solid)falan.GetEntity();
            falanSolid.Translate(0, 0, feilun.tf * 2-1);
            Solid feilunSolid = (Solid)feilun.GetEntity();
            feilunSolid.Translate(0, 0, feilun.tf);

            Solid symFeilunSolid = (Solid)symFeilun.GetEntity();
            symFeilunSolid.Translate(0, 0, 0);

            Solid symFalanSolid = (Solid)symFaln.GetEntity();
            symFalanSolid.Rotate(Math.PI, new devDept.Geometry.Vector3D(0, 1, 0));
            symFalanSolid.Translate(0, 0, 1);

            Solid temp = Solid.CreateCylinder(1, feilun.tf * 2 + falan.tf*2, 100);
            temp.Translate(falan.A / 2-1, 1, -falan.tf);
            //List<Solid> solidList = new List<Solid>()
            //{
            //    symFalanSolid,
            //    symFeilunSolid,
            //    feilunSolid,
            //    falanSolid,
            //     temp,
            //};
            var res = Solid.Union(temp,  falanSolid);
            if (res == null || res.Length != 1)
            {
                throw new Exception($"实体合并结果异常, 合并结果={res.Length}");
            }

            res = Solid.Union(res[0], feilunSolid);
            if (res == null || res.Length != 1)
            {
                throw new Exception($"实体合并结果异常, 合并结果={res.Length}");
            }
            //MessageBox.Show(res.Length + "");

            //double feilunHeight = feilun.tf;
            //Solid n4Solid = falan.GetFlange();
            //n4Solid.Translate(0, 0, feilunHeight * 2);
            //Solid feilunSolid = feilun.GetFeilun();
            //feilunSolid.Translate(0, 0, feilunHeight);

            //FeilunClamped feilunSym = new FeilunClamped(feilun);
            //Solid feilunSymSolid = feilunSym.GetFeilun();

            //Solid temp = Solid.CreateCylinder(1, feilun.GetHeight() * 2 + falan.tf, 100);
            //temp.Translate(falan.Ag / 2, feilun.d / 2 + 1, 0);

            //Solid symFalan = falan.GetSymFalan();
            ////symFalan.Translate(0, 0, 0);  
            //List<Solid> list = new List<Solid>
            //{
            //    temp,
            //    symFalan,
            //    feilunSymSolid,
            //    feilunSolid,
            //    n4Solid,
            //};
            //var res = Solid.Union(list);
            //if (res == null || res.Length != 1)
            //{
            //    throw new Exception($"实体合并结果异常, 合并结果={res.Length}");
            //}
            //MessageBox.Show(res.Length + "");
            //Entity s = new Entity()
            return res[0];
        }

        public override double GetHeight()
        {
            throw new NotImplementedException();
        }

        public override EntityList GetEntitilist()
        {
            EntityList entities = new EntityList();
            double feilunHeight = feilun.tf;
            Solid falanSolid = falan.GetFlange();
            falanSolid.Translate(0, 0, feilunHeight * 2);

            Solid feilunSolid = feilun.GetFeilun();
            feilunSolid.Translate(0, 0, feilunHeight);

            Solid feilunSymSolid = feilun.GetFeilun();

            Solid falanSymSolid = falan.GetFlange();
            falanSymSolid.Rotate(Math.PI, new devDept.Geometry.Vector3D(0, 1, 0));

            entities.Add(falanSolid);
            entities.Add(feilunSolid);
            entities.Add(feilunSymSolid);
            entities.Add(falanSymSolid);
            return entities;
        }
    }
}
