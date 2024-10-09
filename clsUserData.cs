using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsUserData
    {
        public static bool GetUserInfoByUserNamePassword(ref int ID, string UserName, string Password, ref string FirstName,
       ref string LastName, ref string Email, ref string Phone, ref string Gendor,
       ref DateTime HireDate, ref DateTime ExitDate,
       ref int DepartmentID, ref string Position, ref int Permission, ref double Salary, ref string Status, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); //ConnectionString2
            string query = "Select * From Employees where UserName = @UserName and Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int)reader["EmployeeID"];      //ID
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Gendor = (string)reader["Gendor"];
                    Salary = (double)reader["Salary"];   //MonthlySalary
                                                         //  Bonus = (double)reader["BonusPerc"];
                    DepartmentID = (int)reader["DepartmentID"];
                    //  CountryID = (int)reader["CountryID"];
                    Permission = (int)reader["Permissions"];
                    // DateOfBirth = (DateTime)reader["DateOfBirth"];
                    HireDate = (DateTime)reader["HireDate"];

                    if (reader["Status"] == DBNull.Value)
                    {
                        Status = "";
                    }
                    else
                        Status = (string)reader["Status"];
                    if (reader["Position"] == DBNull.Value)
                    {
                        Position = "";
                    }
                    else
                        Position = (string)reader["Position"];
                    if (reader["ExitDate"] == DBNull.Value)
                    {
                        ExitDate = DateTime.Now;
                    }
                    else
                        ExitDate = (DateTime)reader["ExitDate"];

                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = "";

                    }
                    else
                        ImagePath = (string)reader["ImagePath"];

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
        public static bool GetUserByID(int ID, ref string UserName, ref string Password, ref string FirstName,
            ref string LastName, ref string Email, ref string Phone, ref string Gendor,
            ref DateTime HireDate, ref DateTime ExitDate,
            ref int DepartmentID, ref string Position, ref int Permission, ref double Salary, ref string Status, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); //ConnectionString2
            string query = "Select * From Employees where EmployeeID = @EmployeeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@EmployeeID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Gendor = (string)reader["Gendor"];
                    Salary = (double)reader["Salary"];   //MonthlySalary
                                                         // Bonus = (double)reader["BonusPerc"];
                    DepartmentID = (int)reader["DepartmentID"];
                    // CountryID = (int)reader["CountryID"];
                    Permission = (int)reader["Permissions"];
                    //  DateOfBirth = (DateTime)reader["DateOfBirth"];
                    HireDate = (DateTime)reader["HireDate"];

                    if (reader["Status"] == DBNull.Value)
                    {
                        Status = "";
                    }
                    else
                        Status = (string)reader["Status"];
                    if (reader["Position"] == DBNull.Value)
                    {
                        Position = "";
                    }
                    else
                        Position = (string)reader["Position"];
                    if (reader["ExitDate"] == DBNull.Value)
                    {
                        ExitDate = DateTime.Now;
                    }
                    else
                        ExitDate = (DateTime)reader["ExitDate"];

                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = "";

                    }
                    else
                        ImagePath = (string)reader["ImagePath"];

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
        public static int AddNewUser(string UserName, string Password, string FirstName,
                string LastName, string Email, string Phone, string Position, string Gendor,
                DateTime HireDate, DateTime ExitDate,
                int DepartmentID, int Permission, double Salary, string Status, string ImagePath)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            //INSERT INTO Employees
            //                         (UserName, Password, FirstName, LastName, Email, Phone, Gendor, DateOfBirth, CountryID, DepartmentID,
            //                          HireDate, ExitDate, MonthlySalary, BonusPerc, Permissions, ImagePath)
            //                         VALUES
            //                         (@UserName, @Password, @FirstName, @LastName, @Email, @Phone, @Gendor, @DateOfBirth, @CountryID, @DepartmentID,
            //                         @HireDate, @ExitDate, @MonthlySalary, @BonusPerc, @Permissions, @ImagePath);
            //Select SCOPE_IDENTITY(); ";

            string query = @"INSERT INTO Employees
                                    (UserName,Password,FirstName,LastName,Email,Phone,Position,Gendor,DepartmentID,                                                       
                                     HireDate,ExitDate,Salary,Permissions,Status,ImagePath)
                                     VALUES
                                     (@UserName,@Password,@FirstName,@LastName,@Email,@Phone,@Position,@Gendor,@DepartmentID,
                                     @HireDate,@ExitDate,@Salary,@Permissions,@Status,@ImagePath);
                                     Select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            if (Phone != "")
                command.Parameters.AddWithValue("@Phone", Phone);
            else
                command.Parameters.AddWithValue("@Phone", DBNull.Value);
            if (Status != "")
                command.Parameters.AddWithValue("@Status", Status);
            else
                command.Parameters.AddWithValue("@Status", DBNull.Value);
            if (Position != "")
                command.Parameters.AddWithValue("@Position", Position);
            else
                command.Parameters.AddWithValue("@Position", DBNull.Value);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@HireDate", HireDate);
            if (ExitDate != DateTime.MinValue)
                command.Parameters.AddWithValue("@ExitDate", ExitDate);
            else
                command.Parameters.AddWithValue("@ExitDate", DBNull.Value);
            command.Parameters.AddWithValue("@Salary", Salary);
            // command.Parameters.AddWithValue("@BonusPerc", Bonus);
            command.Parameters.AddWithValue("@Permissions", Permission);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            // command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            // command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
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
            return UserID;
        }
        public static bool UpdateUser(string UserName, string Password, string FirstName,
       string LastName, string Email, string Phone, string Position, string Gendor,
       DateTime HireDate, DateTime ExitDate,
       int DepartmentID, int Permission, double Salary, string Status, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            // ,DateOfBirth = @DateOfBirth
            //,CountryID = @CountryID
            //    ,BonusPerc = @BonusPerc
            string query = @"UPDATE Employees
                             SET 
                                 FirstName = @FirstName
                                ,LastName = @LastName
                                ,Email = @Email
                                ,Phone = @Phone
                                ,Position = @Position
                                ,Gendor = @Gendor
                               
                                ,DepartmentID = @DepartmentID
                                ,HireDate = @HireDate
                                ,ExitDate = @ExitDate
                                ,Salary = @Salary
                            
                                ,Permissions = @Permissions
                                ,Status = @Status
                                ,ImagePath = @ImagePath
                                 where UserName = @UserName and Password = @Password";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@HireDate", HireDate);
            command.Parameters.AddWithValue("@ExitDate", ExitDate);
            command.Parameters.AddWithValue("@Salary", Salary);
            // command.Parameters.AddWithValue("@BonusPerc", Bonus);
            command.Parameters.AddWithValue("@Permissions", Permission);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            //  command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            // command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            command.Parameters.AddWithValue("@Position", Position);
            command.Parameters.AddWithValue("@Status", Status);
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














        public static bool GetUserInfoByUserNamePassword(string UserName, string Password, ref string FirstName,
        ref string LastName, ref string Email, ref string Phone, ref string Gendor,
        ref DateTime DateOfBirth, ref DateTime HireDate, ref string ExitDate, ref int CountryID,
        ref int DepartmentID, ref int Permission, ref double Salary, ref double Bonus, ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);
            string query = "Select * From Employees where UserName = '@UserName' and Password = '@Password'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Phone = (string)reader["Phone"];
                    Gendor = (string)reader["Gendor"];
                    Salary = (double)reader["MonthlySalary"];
                    Bonus = (double)reader["BonusPerc"];
                    DepartmentID = (int)reader["DepartmentID"];
                    CountryID = (int)reader["CountryID"];
                    Permission = (int)reader["Permissions"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    HireDate = (DateTime)reader["HireDate"];

                    if (reader["ExitDate"] == DBNull.Value)
                    {
                        ExitDate = "";
                    }
                    else
                        ExitDate = (string)reader["ExitDate"];

                    if (reader["ImagePath"] == DBNull.Value)
                    {
                        ImagePath = "";

                    }
                    else
                        ImagePath = (string)reader["ImagePath"];

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
        public static int AddNewUser(string UserName, string Password, string FirstName,
       string LastName, string Email, string Phone, string Gendor,
       DateTime DateOfBirth, DateTime HireDate, string ExitDate, int CountryID,
       int DepartmentID, int Permission, double Salary, double Bonus, string ImagePath)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);
            string query = @"INSERT INTO Employees
                                    (UserName,Password,FirstName,LastName,Email,Phone,Gendor,DateOfBirth,CountryID,DepartmentID,
                                     HireDate,ExitDate,MonthlySalary,BonusPerc,Permissions,ImagePath)
                                     VALUES
                                     (@UserName,@Password,@FirstName,@LastName,@Email,@Phone,@Gendor,@DateOfBirth,@CountryID,@DepartmentID,
                                     @HireDate,@ExitDate,@MonthlySalary,@BonusPerc,@Permissions,@ImagePath);
                                     Select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@HireDate", HireDate);
            command.Parameters.AddWithValue("@ExitDate", ExitDate);
            command.Parameters.AddWithValue("@MonthlySalary", Salary);
            command.Parameters.AddWithValue("@BonusPerc", Bonus);
            command.Parameters.AddWithValue("@Permissions", Permission);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
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
            return UserID;
        }
        public static bool UpdateUser(string UserName, string Password, string FirstName,
            string LastName, string Email, string Phone, string Gendor,
            DateTime DateOfBirth, DateTime HireDate, string ExitDate, int CountryID,
            int DepartmentID, int Permission, double Salary, double Bonus, string ImagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = @"UPDATE Employees
                             SET 
                                 FirstName = @FirstName
                                ,LastName = @LastName
                                ,Email = @Email
                                ,Phone = @Phone
                                ,Gendor = @Gendor
                                ,DateOfBirth = @DateOfBirth
                                ,CountryID = @CountryID
                                ,DepartmentID = @DepartmentID
                                ,HireDate = @HireDate
                                ,ExitDate = @ExitDate
                                ,MonthlySalary = @MonthlySalary
                                ,BonusPerc = @BonusPerc
                                ,Permissions = @Permissions
                                ,ImagePath = @ImagePath
                                 where UserName = @UserName and Password = @Password";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@HireDate", HireDate);
            command.Parameters.AddWithValue("@ExitDate", ExitDate);
            command.Parameters.AddWithValue("@MonthlySalary", Salary);
            command.Parameters.AddWithValue("@BonusPerc", Bonus);
            command.Parameters.AddWithValue("@Permissions", Permission);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@DepartmentID", DepartmentID);

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
        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "SELECT * FROM Employees order by FirstName";

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
        public static bool DeleteUser(string UserName)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Employees 
                                where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

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
        public static int GetUsersCount()
        {
            int UserCounts = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "SELECT COUNT(*) FROM Employees;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                UserCounts = (int)command.ExecuteScalar();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return UserCounts;
        }
        public static bool DeleteUser(int ID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Employees 
                                where EmployeeID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

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



        //fix this...


        public static DataTable GetFemalesEmployees()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "select * from FemalesEmployees;";

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
        public static DataTable GetActiveEmployees()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "select * from ActiveEmployees;";

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
        //public static DataTable GetAllUsers()
        //{

        //    DataTable dt = new DataTable();
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

        //    string query = "select top 200 * from AllEmployees;";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    try
        //    {
        //        connection.Open();

        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.HasRows)

        //        {
        //            dt.Load(reader);
        //        }

        //        reader.Close();


        //    }

        //    catch (Exception ex)
        //    {
        //        // Console.WriteLine("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return dt;

        //}
        public static DataTable GetShortDetailedEmployees()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "select * from ShortDetialedEmployees;";

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

        public static DataTable GetTop10HighSalaries()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "select * from Top10Salaries;";

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
        public static DataTable GetTopLowestSalaries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "select * from Top10LowestSalaries;";

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
        public static DataTable GetRetiredEmployees()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "select * from RetiredEmployees;";

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
        public static DataTable GetMalesEmployees()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString2);

            string query = "select * from MalesEmployees;";

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
    }
}
