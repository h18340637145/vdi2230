using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DaoAccess
    {
        public OleDbConnection connection()
        {
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./database/BoltConnectionSystem.mdb";//连接字符串
            OleDbConnection sc = new OleDbConnection(str);
            sc.Open();//打开 数据 库 连接
            return sc;
        }

        public OleDbCommand command(string sql)
        {
            //可对于数据进行操作的对象
            OleDbCommand sc = new OleDbCommand(sql, connection());//调用上面connection函数  要用到自己写的
            return sc;
        }

        public int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();//调用上面自己写的函数command
        }

        public OleDbDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }

    class SelfDao : DaoAccess
    {
        public OleDbConnection connection(string dbname)
        {
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./database/my.mdb";//连接字符串
            OleDbConnection sc = new OleDbConnection(str);
            sc.Open();//打开 数据 库 连接
            return sc;
        }
        public new OleDbCommand command(string sql)
        {
            //可对于数据进行操作的对象
            OleDbCommand sc = new OleDbCommand(sql, connection("my.mdb"));//调用上面connection函数  要用到自己写的
            return sc;
        }
        public new int Excute(string sql)
        {
            return command(sql).ExecuteNonQuery();//调用上面自己写的函数command
        }
    }
}
