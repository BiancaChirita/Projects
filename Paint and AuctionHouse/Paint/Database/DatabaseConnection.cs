using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Database
{
    class DatabaseConnection
    {
        public SqlConnection StartConnection()
        {
            string connectionString;
            SqlConnection connection;
            connectionString = @"Server=DESKTOP-2BMVGDR\SQLEXPRESS;Database=AuctionsDatabase;User Id=sa;Password=123";
            connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void EndConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
