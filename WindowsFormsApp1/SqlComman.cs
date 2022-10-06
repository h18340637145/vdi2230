using System;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    internal class SqlComman
    {
        private string sql;
        private SqlConnection sqlConnection;

        public SqlComman(string sql, SqlConnection sqlConnection)
        {
            this.sql = sql;
            this.sqlConnection = sqlConnection;
        }

        public static implicit operator SqlCommand(SqlComman v)
        {
            throw new NotImplementedException();
        }
    }
}