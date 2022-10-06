using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public interface IModelEntity
    {
        /// <summary>
        /// 获取该模型的实体对象
        /// </summary>
        /// <returns>可用于在Model.Entities中添加的实体对象</returns>
        Entity GetEntity();
        //Entity GetEntity(double height);
    }
}
