using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DataAccess
{
    public class DataAccess : IDisposable
    {
        protected SqlConnection connection;
        protected SqlCommand command;
        public DataAccess()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hexa"].ConnectionString);
            connection.Open();
        }
        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteReader();
            

        }

        public int ExecuteQuery(string sql)
        {
            command = new SqlCommand(sql, connection);
            return command.ExecuteNonQuery();

        }

        public void Dispose()
        {
            connection.Close();
        }
    }

}

