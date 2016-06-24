using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public static class FinalDB
    {
        public static MySqlConnection GetConnection()
        {
            ///server=178.62.247.167;user id=bryggeri;password=bryggeri2015;persistsecurityinfo=True;database=inventory;Convert Zero Datetime=True;Allow Zero Datetime=True;
            string connStr = @"server=178.62.247.167;Database=inventory;user id=bryggeri;password=bryggeri2015;";
            MySqlConnection mcon = new MySqlConnection(connStr);
            return mcon;
        }
        public static int insertToDB(int id, string SerialNumber, int amount)
        {
            int return_code = 0;
            string transactionDate = DateTime.Now.ToShortDateString() + ' ' + DateTime.Now.ToShortTimeString();
            string insertStatement = "UPDATE inv_products " +
                "SET amount = amount + @amount " +
                "WHERE id = @id;";
            MySqlConnection connection = FinalDB.GetConnection();
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
