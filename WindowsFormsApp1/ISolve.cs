using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 获取计算参数
    /// </summary>
    /// <returns>void</returns>
    public interface IParameter
    {
        void GetCalParameter();
    }

    public interface ISolveBolt : IParameter
    {
        new void GetCalParameter();
        BoltClass Solve();
    }

    public interface ISolveResult : IParameter
    {
        new void GetCalParameter();
        ComputeResult Solve();
    }
}
