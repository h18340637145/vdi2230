using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    /*
     * 用法：
     *  直接将Dao类实例化，调用下列方法即可
     */

    class Dao
    {
        /**
         * @auothor hhw
         * @date    2021-9-19
         * @file    Dao.cs
         * @function    get database connection
         */
        public SqlConnection connection()
        {
            string str = "Data Source=MSI;Initial Catalog=BoltConnectionSystem;Integrated Security=True";//连接字符串
            SqlConnection sc = new SqlConnection(str);
            sc.Open();//打开 数据 库 连接
            return sc;
        }

        /*
         * @fuction get database command
         */
        public SqlCommand command(string sql)
        {//可对于数据进行操作的对象
            SqlCommand sc = new SqlCommand(sql, connection());//调用上面connection函数  要用到自己写的
            return sc;
        }

        /*
         * @function    用于delete update insert 返回
         * @return      用影响的行数
         */
        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();//调用上面自己写的函数command
        }

        /*
         * @function    用于select  获取记录
         * @return      返回查找的数据记录
         */
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }

}
