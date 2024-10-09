using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsTransactionData
    {
        public static bool FindTransactionByID(int ID, ref string UserName, ref string AccountNumber, ref string UTI, ref string TransactionType, ref string Status, ref decimal Amount)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select TransactionID,UserName,UTI,AccountNumber,TransactionType,Amount,TransactionDate,Transactions.Status from Transactions inner join Employees on Transactions.EmployeeID = Employees.EmployeeID inner join Accounts on Transactions.AccountID=Accounts.AccountID where TransactionID= @TransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    AccountNumber = (string)reader["AccountNumber"];
                    UserName = (string)reader["UserName"];
                    UTI = (string)reader["UTI"];
                    TransactionType = (string)reader["TransactionType"];
                    Status = (string)reader["Status"];
                    Amount = (decimal)reader["Amount"];

                    //if (reader["ImagePath"] == DBNull.Value)
                    //{
                    //    ImagePath = "";

                    //}
                    //else
                    //    ImagePath = (string)reader["ImagePath"];

                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static int RegisterTransactionInDB(int ID, string UTI, int ClientID, decimal Amount, string TransactionType)
        {
            int TransactionID = -1;

            DateTime TransactionDate = DateTime.Now;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into Transactions (EmployeeID,UTI,AccountID,TransactionType,Amount,TransactionDate,Status) 
                             values(@ID,@UTI,(select Clients.AccountID from CLients inner join Accounts on Clients.AccountID = Accounts.AccountID
                             where Clients.ClientID = @ClientID),@TransactionType,@Amount,@TransactionDate,'Pending');
                             Select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@TransactionType", TransactionType);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@UTI", UTI);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    TransactionID = InsertedID;
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
            return TransactionID;
        }
        public static bool UpdateTransactionStatus(int transactionId, string newStatus)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = "UPDATE Transactions SET Status = @Status WHERE TransactionID = @TransactionId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionId", transactionId);
            command.Parameters.AddWithValue("@Status", newStatus);

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
        public static DataTable GetTransactionList()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from TransactionList;";

            SqlCommand command = new SqlCommand(query, connection);
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
        public static DataTable GetAllTransactions()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select TransactionID,UserName,UTI,AccountNumber,TransactionType,Amount,TransactionDate,Transactions.Status from Transactions inner join Employees on Transactions.EmployeeID = Employees.EmployeeID \r\ninner join Accounts on Transactions.AccountID=Accounts.AccountID where Transactions.Status ='Accept' or Transactions.Status = 'Reject' or  Transactions.Status = 'Pending';";

            SqlCommand command = new SqlCommand(query, connection);

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
        public static bool DeleteTransaction(int TransactionID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "delete from Transactions where TransactionID = @TransactionID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);

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
