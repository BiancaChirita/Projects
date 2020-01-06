using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Database
{
    class CommandsAuctioneer
    {

        public void InsertAuctioneer(int id, string name, string address, string phone, string email, SqlConnection connection)
        {
            string sql = "INSERT INTO Auctioneer(Id, Name, Address, Phone, Email) VALUES ("
                + id + ", " + name + ", " + address + ", " + phone + "," + email + ")";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void DeleteAuctioneer (int id, SqlConnection connection)
        {
            string sql = "DELETE FROM Auctioneer WHERE Id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdateNameAuctioneer(int id, string name, SqlConnection connection)
        {
            string sql = "UPDATE Auctioneer SET Name = '" + name + "' WHERE id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdateAddressAuctioneer(int id, string address, SqlConnection connection)
        {
            string sql = "UPDATE Auctioneer SET Address ='" + address + "' WHERE id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdatePhoneAuctioneer(int id, string phone, SqlConnection connection)
        {
            string sql = "UPDATE Auctioneer SET Phone ='" + phone + "' WHERE id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

        public void UpdateEmailAuctioneer(int id, string email, SqlConnection connection)
        {
            string sql = "UPDATE Auctioneer SET Email ='" + email + "' WHERE id = " + id;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();

            dataAdapter.InsertCommand = new SqlCommand(sql, connection);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }

    }
}
