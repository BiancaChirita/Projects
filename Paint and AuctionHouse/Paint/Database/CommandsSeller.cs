using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Database
{
    class CommandsSeller
    {

        public void InsertSeller (int id, string firstName, string lastName, string address, SqlConnection connection)
        {
            string sql = "INSERT INTO Seller(Id, FirstName, LastName, Address) VALUES ("
                + id + ", '" + firstName + "', '" + lastName + "', '" + address + "')";

            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void DeleteSeller(int id, SqlConnection connection)
        {
            string sql = "DELETE FROM Seller WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdateFirstNameSeller(int id, string firstName, SqlConnection connection)
        {
            string sql = "UPDATE Seller SET FirstName = '" + firstName + "' WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdateLastNameSeller(int id, string lastName, SqlConnection connection)
        {
            string sql = "UPDATE Seller SET LastName = '" + lastName + "' WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdateAddressSeller(int id, string address, SqlConnection connection)
        {
            string sql = "UPDATE Seller SET Address = '" + address + "' WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

    }
}
