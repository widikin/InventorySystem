using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public static class RemoveAmount
    {
        public static MySqlConnection GetConnection()
        {
            string connStr = @"server=178.62.247.167;Database=inventory;user id=bryggeri;password=bryggeri2015;";
            MySqlConnection mcon = new MySqlConnection(connStr);
            return mcon;
        }
        public static int insertToDB(int id, string SerialNumber, int amount)
        {
            int return_code = 0;
            string transactionDate = DateTime.Now.ToShortDateString() + ' ' + DateTime.Now.ToShortTimeString();
            string insertStatement = "UPDATE inv_products " +
                "SET amount = amount - @amount, last_added = now() " +
                "WHERE id = @id;";
            MySqlConnection connection = AddAmount.GetConnection();
            MySqlCommand insertCommand = new MySqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@id", id);
            insertCommand.Parameters.AddWithValue("@serial", SerialNumber);
            insertCommand.Parameters.AddWithValue("@lastAdded", transactionDate);
            insertCommand.Parameters.AddWithValue("@amount", amount);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return_code = 1;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return return_code;
        }
    }
}
