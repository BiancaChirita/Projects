using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Database
{
    class CommandsObject
    {

        public void InsertObject(int id, string name, int price, int startValue, SqlConnection connection)
        {
            string sql = "INSERT INTO Object(Id, Name, Price, StartValue) VALUES (" + id + ", '" + name + "', " + price + ", " + startValue + ")";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void DeleteObject(int id, SqlConnection connection)
        {
            string sql = "DELETE FROM Object WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdateNameObject(int id, string name, SqlConnection connection)
        {
            string sql = "UPDATE Object SET Name = '" + name + "' WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdatePriceObject(int id, int price, SqlConnection connection)
        {
            string sql = "UPDATE Object SET Price = " + price + " WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdateStartValueObject(int id, int startValue, SqlConnection connection)
        {
            string sql = "UPDATE Object SET StartValue = " + startValue + " WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

    }
}
