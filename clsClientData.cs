using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsClientData
    {
        public static bool GetClientInfoByCifNumber(ref int ID, ref int CifID, string CifNumber, ref string FirstName,
        ref string LastName, ref string Email, ref string Phone, ref decimal Income, ref string IncomeType, ref string OccupationType, ref string Gender, ref int CountryID, ref string Address, ref DateTime DateOfBirth, ref string IdentityNumber, ref string IdentityType, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Clients inner join CIF on Clients.CifID=CIF.CifID where CifNumber = @CifNumber;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CifNumber", CifNumber);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["ClientID"];
                    CifID = (int)reader["CifID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    if (reader["IncomeType"] == DBNull.Value)
                        IncomeType = "";
                    else
                        IncomeType = (string)reader["IncomeType"];
                    if (reader["OccupationType"] == DBNull.Value)
                        OccupationType = "";
                    else
                        OccupationType = (string)reader["OccupationType"];
                    if (reader["Gender"] == DBNull.Value)
                        Gender = "";
                    else
                        Gender = (string)reader["Gender"];
                    if (reader["CountryID"] == DBNull.Value)
                        CountryID = 0;
                    else
                        CountryID = (int)reader["CountryID"];
                    if (reader["Income"] == DBNull.Value)
                        Income = 0;
                    else
                        Income = (decimal)reader["Income"];
                    ImagePath = (string)reader["ImagePath"];

                    if (reader["IdentityNumber"] == DBNull.Value)
                        IdentityNumber = "";
                    else
                        IdentityNumber = (string)reader["IdentityNumber"];
                    if (reader["IdentityType"] == DBNull.Value)
                        IdentityType = "";
                    else
                        IdentityType = (string)reader["IdentityType"];
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
        public static bool GetClientInfoByID(int ID, ref int CifID, ref string CifNumber, ref string FirstName,
               ref string LastName, ref string Email, ref string Phone, ref decimal Income, ref string IncomeType, ref string OccupationType, ref int CountryID, ref string Gender, ref string Address, ref DateTime DateOfBirth, ref string IdentityNumber, ref string IdentityType, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select ClientID,CifNumber,FirstName,LastName,Email,Phone,IdentityNumber,IdentityType,Address,DateOfBirth,Gender,Income,IncomeType,OccupationType,CountryID from Clients inner join CIF on Clients.CifID=CIF.CifID where ClientID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    CifNumber = (string)reader["CifNumber"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    IncomeType = (string)reader["IncomeType"];
                    Address = (string)reader["Address"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    // ImagePath = (string)reader["ImagePath"];
                    Income = (decimal)reader["Income"];
                    CountryID = (int)reader["CountryID"];
                    Gender = (string)reader["Gender"];
                    OccupationType = (string)reader["OccupationType"];
                    if (reader["IdentityNumber"] == DBNull.Value)
                        IdentityNumber = "";
                    else
                        IdentityNumber = (string)reader["IdentityNumber"];
                    if (reader["IdentityType"] == DBNull.Value)
                        IdentityType = "";
                    else
                        IdentityType = (string)reader["IdentityType"];
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
        public static int AddNewClient(int CifID, string FirstName, string LastName, string Email, string Phone, string Address, DateTime DateOfBirth, string IdentityNumber, string IdentityType, string Gender, decimal Income, string IncomeType, string OccupationType, int CountryID, string ImagePath)
        {
            int ClientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"insert into Clients (CifID,FirstName,LastName,Email,Phone,IdentityNumber,IdentityType,Address,DateOfBirth,Gender,Income,IncomeType,OccupationType,CountryID,ImagePath)
                            values(@CifID,@FirstName,@LastName,@Email,@Phone,@IdentityNumber,@IdentityType,@Address,@DateOfBirth,@Gender,@Income,@IncomeType,@OccupationType,@CountryID,@ImagePath);
                             Select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@IdentityNumber", IdentityNumber);
            command.Parameters.AddWithValue("@IdentityType", IdentityType);
            command.Parameters.AddWithValue("@CifID", CifID);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Income", Income);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@IncomeType", IncomeType);
            command.Parameters.AddWithValue("@OccupationType", OccupationType);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
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
            return ClientID;
        }


        public static bool UpdateClient(int CifID, string FirstName, string LastName, string Email
        , string Phone, string Gender, decimal Income, string IncomeType, string OccupationType, int CountryID, string Address, DateTime DateOfBirth, string IdentityNumber, string IdentityType, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Clients
                             SET 
                                ,FirstName = @FirstName
                                ,LastName = @LastName
                                ,Email = @Email
                                ,Phone = @Phone
                                ,IdentityNumber = @IdentityNumber
                                ,IdentityType = @IdentityType
                                ,Gender = @Gender
                                ,Income = @Income
                                ,IncomeType = @IncomeType
                                ,OccupationType = @OccupationType
                                ,CountryID = @CountryID
                                ,Address = @Address
                                ,DateOfBirth = @DateOfBirth
                                ,ImagePath = @ImagePath
                                 where CifID = @CifID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Income", Income);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@IncomeType", IncomeType);
            command.Parameters.AddWithValue("@CifID", CifID);
            command.Parameters.AddWithValue("@IdentityNumber", IdentityNumber);
            command.Parameters.AddWithValue("@IdentityType", IdentityType);
            command.Parameters.AddWithValue("@OccupationType", OccupationType);
            command.Parameters.AddWithValue("@CountryID", CountryID);

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
        public static DataTable GetClientByID(int ID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients where ClientID = @ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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
        public static DataTable GetAllClients()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT ClientID,AccountNumber,FirstName, LastName,Email, Phone,IdentityNumber,IdentityType, Address,AccountBalance FROM Clients";

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

        public static int GetClientsCount()
        {
            int ClientsCounts = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT COUNT(*) FROM Clients;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                ClientsCounts = (int)command.ExecuteScalar();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return ClientsCounts;
        }
        public static bool DeleteClientInfo(int CifID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Clients 
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
        public static bool DeleteClientByAccountNumber(string AccountNumber)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Clients 
                                where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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
