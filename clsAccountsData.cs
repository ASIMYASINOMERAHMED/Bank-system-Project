using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsAccountsData
    {
        public static int AddNewAccount(int CifID, string AccountNumber, string Password, decimal Balance, string AccountType)
        {
            int AccountID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Accounts
           ([CifID],[AccountType] ,[AccountNumber],[Password] ,[Balance],[OpeningDate],[AccountStatus]) VALUES
           (@CifID,@AccountType,@AccountNumber,@Password,@Balance,@OpeningDate,'Active')
            Select SCOPE_IDENTITY();";
            DateTime OpeningDate = DateTime.Now;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@OpeningDate", OpeningDate);
            command.Parameters.AddWithValue("@AccountType", AccountType);
            command.Parameters.AddWithValue("@CifID", CifID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedId))
                {
                    AccountID = InsertedId;
                }




            }
            catch
            {
                //Later On
            }
            finally
            {
                connection.Close();
            }
            return AccountID;
        }





        public static bool UpdateBalance(int transactionId, decimal newBalance)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "UPDATE TransactionList SET Balance = @Balance WHERE TransactionID = @TransactionID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", transactionId);
            command.Parameters.AddWithValue("@Balance", newBalance);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }




        public static DataTable GetAccounts(int CifID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select AccountNumber from Accounts where CifID = @CifID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CifID", CifID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
        public static double GetAccountBalance(string AccountNumber)
        {
            double Balance = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select Balance from Accounts where AccountNumber = @AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                Balance = (double)command.ExecuteScalar();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return Balance;
        }






        public static DataTable GetAllAccountsRelatedToClient(int CifID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select AccountNumber,AccountType,Password,Balance,OpeningDate,AccountStatus from Accounts inner join CIF on CIF.CifID=Accounts.CifID where CIF.CifID = @CifID;";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CifID", CifID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool DeleteAccounts(int CifID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Accounts 
                                where CifID = @CifID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CifID", CifID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);
        }

    }
}
