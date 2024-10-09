using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsUser : clsPerson
    {
        public static clsUser CurrentUser;
        enum enMode { UpdateMode = 1, AddNewMode = 2 };
        enMode Mode;
        public string _UserName, _Gendor, _ImagePath, _Password, _Status, _Position;
        public int _Permissions, _CountryID, _DepartmentID, _ID;
        public double _Salary, _Bonus;
        public DateTime _DateOfBirth, _HireDate, _ExitDate;


        public enum enMainMenuPermission
        {
            eAll = -1, pManageUsers = 1, pListEntireTableUsers = 2, pTransactions = 4,
            pLoginRegister = 8, pListClients = 16, pAddNewClient = 32, pDeleteClient = 64,
            pUpdateClients = 128, pFindClient = 256
        };
        struct stLoginRegisterRecord
        {
            string DateTime;
            string UserName;
            string Password;
            int Permissions;

        };
        //static string EncryptText(string Text, short EncryptionKey = 2)
        //{
        //    for (int i = 0; i <= Text.Length; i++)
        //    {
        //        Text[i] = char((int)Text[i] + EncryptionKey);
        //    }
        //    return Text;
        //}
    
        public clsUser(int ID, string UserName, string Password, string FirstName, string LastName,
            string Email, string Phone, string Position, string Gendor, string ImagePath, int DepartmentID, double Salary,
            DateTime HireDate, DateTime ExitDate,
            int Permissions, string Status) : base(FirstName, LastName, Email, Phone)
        {

            _UserName = UserName;
            _Password = Password;
            _Permissions = Permissions;
            // _CountryID = CountryID;
            _DepartmentID = DepartmentID;
            _Salary = Salary;
            //  _Bonus = Bonus;
            //  _DateOfBirth = DateOfBirth;
            _Position = Position;
            _HireDate = HireDate;
            _ExitDate = ExitDate;
            _Gendor = Gendor;
            _ImagePath = ImagePath;
            _Email = Email;
            _Phone = Phone;
            _ID = ID;
            _Status = Status;
            Mode = enMode.UpdateMode;


        }
        public clsUser()
        {
            _UserName = "";
            _Password = "";
            _Permissions = 0;
            //  _CountryID = 0;
            _DepartmentID = 0;
            _Salary = 0;
            //  _Bonus = 0;
            //  _DateOfBirth = DateTime.Now;
            _HireDate = DateTime.Now;
            _ExitDate = DateTime.Now;
            _Gendor = "";
            _ImagePath = "";
            _Email = "";
            _Phone = "";
            _Position = "";
            _ID = 0;
            _Status = "";
            Mode = enMode.AddNewMode;
        }
        public static clsUser Find(string UserName, string Password)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Gendor = "", ImagePath = @"", Status = "", Position = "";
            int Permissions = -1, DepartmentID = 0, ID = 0;
            double Salary = 0;


            DateTime HireDate = DateTime.Now, ExitDate = DateTime.Now;
            if (clsUserData.GetUserInfoByUserNamePassword(ref ID, UserName, Password, ref FirstName, ref LastName
                , ref Email, ref Phone, ref Gendor, ref HireDate, ref ExitDate, ref DepartmentID, ref Position, ref Permissions, ref Salary, ref Status, ref ImagePath))
                return new clsUser(ID, UserName, Password, FirstName, LastName, Email, Phone, Position, Gendor, ImagePath, DepartmentID, Salary, HireDate, ExitDate, Permissions, Status);
            else
                return null;
        }
        public static clsUser Find(int ID)
        {


            string UserName = "", Password = "", FirstName = "", LastName = "", Email = "", Phone = "", Gendor = "", ImagePath = @"", Status = "", Position = "";
            int Permissions = -1, CountryID = 0, DepartmentID = 0;
            double Salary = 0, Bonus = 0;
            DateTime DateOfBirth = DateTime.Now, HireDate = DateTime.Now, ExitDate = DateTime.Now;
            if (clsUserData.GetUserByID(ID, ref UserName, ref Password, ref FirstName, ref LastName
                    , ref Email, ref Phone, ref Gendor, ref HireDate, ref ExitDate, ref DepartmentID, ref Position, ref Permissions, ref Salary, ref Status, ref ImagePath))
                return new clsUser(ID, UserName, Password, FirstName, LastName, Email, Phone, Position, Gendor, ImagePath, DepartmentID, Salary, HireDate, ExitDate, Permissions, Status);
            else
                return null;
        }
        private bool _AddNewUser()
        {
            this._ID = clsUserData.AddNewUser(this._UserName, this._Password, this._FirstName, this._LastName, this._Email, this._Phone, this._Position, this._Gendor,
                                                 this._HireDate, this._ExitDate, this._DepartmentID, this._Permissions, this._Salary, this._Status, this._ImagePath);
            return (this._ID != -1);
        }
        private bool _UpateUser()
        {
            return clsUserData.UpdateUser(this._UserName, this._Password, this._FirstName, this._LastName, this._Email, this._Phone, this._Position
                , this._Gendor, this._HireDate, this._ExitDate, this._DepartmentID, this._Permissions, this._Salary, this._Status, this._ImagePath);
        }
        public static bool DeleteUser(string UserName)
        {
            return clsUserData.DeleteUser(UserName);
        }
        public static bool DeleteUser(int ID)
        {
            return clsUserData.DeleteUser(ID);
        }
        public static DataTable GetTop10HighSalaries()
        {
            return clsUserData.GetTop10HighSalaries();
        }
        public static DataTable GetTopLowestSalaries()
        {
            return clsUserData.GetTopLowestSalaries();
        }
        public static DataTable GetShortDetailedEmployees()
        {
            return clsUserData.GetShortDetailedEmployees();
        }
        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }
        public static DataTable GetActiveEmployees()
        {
            return clsUserData.GetActiveEmployees();
        }
        public static DataTable GetRetiredEmployees()
        {
            return clsUserData.GetRetiredEmployees();
        }
        public static DataTable GetFemalesEmployees()
        {
            return clsUserData.GetFemalesEmployees();
        }
        public static DataTable GetMalesEmployees()
        {
            return clsUserData.GetMalesEmployees();
        }
        public static int GetUsersCount()
        {

            return clsUserData.GetUsersCount();

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enMode.AddNewMode:
                    if (_AddNewUser())
                    {

                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.UpdateMode:

                    return _UpateUser();

            }

            return false;
        }
        public bool CheckAccessPermission(enMainMenuPermission Permission)
        {
            if (this._Permissions == (int)enMainMenuPermission.eAll)
                return true;

            if (((int)Permission & this._Permissions) == (int)Permission)
                return true;
            else
                return false;

        }
        static bool CheckAccessRights(enMainMenuPermission permission, clsUser User)
        {
            if (!User.CheckAccessPermission(permission))
            {
                return false;
            }
            else
                return true;
        }
        public string GetPermissions(clsUser User)
        {
            if (User._Permissions == -1)
                return "Full Access.";
            string sPermissions = "";
            if (CheckAccessRights(enMainMenuPermission.pManageUsers, User))
                sPermissions = "* Manage Users";
            if (CheckAccessRights(enMainMenuPermission.pListEntireTableUsers, User))
                sPermissions += "  * List All Users";
            if (CheckAccessRights(enMainMenuPermission.pTransactions, User))
                sPermissions += "  * Transactions";
            if (CheckAccessRights(enMainMenuPermission.pLoginRegister, User))
                sPermissions += "  * Login Register";
            if (CheckAccessRights(enMainMenuPermission.pListClients, User))
                sPermissions += "  * List Clients";
            if (CheckAccessRights(enMainMenuPermission.pAddNewClient, User))
                sPermissions += "  * Add New Client";
            if (CheckAccessRights(enMainMenuPermission.pDeleteClient, User))
                sPermissions += "  * Delete Client";
            if (CheckAccessRights(enMainMenuPermission.pUpdateClients, User))
                sPermissions += "  * Update Client";
            if (CheckAccessRights(enMainMenuPermission.pFindClient, User))
                sPermissions += "  * Find Client";

            return sPermissions;
        }
        public static DataTable TestGetEmployees()
        {
            return clsUserData.TestGetEmployees();
        }
        public static bool TestUpdateEmployees()
        {
            return clsUserData.TestUpdateEmployeesSalary();
        }
        public static DataTable GetEmployeesBasedPerformanceRatingBasedandDepartment()
        {
            DataTable dt = new DataTable();
            string Department = "";
            int PerformanceRating = 0;
            for (short i = 1; i > 0; i++)
            {
                Department=clsUserData.GetEmployeeDepartment("Employee " + i);
                PerformanceRating = clsUserData.GetEmployeePerformanceRating("Employee " + i);
                if (Department == "" || PerformanceRating == -1)
                    return dt;
                if(Department == "Marketing")
                {
                    if(PerformanceRating>90)
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.15));
                    }
                    else if(PerformanceRating>75||PerformanceRating<90)
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.10));
                    }
                    else
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.05));
                    }
                }
                if(Department == "HR")
                {
                    if (PerformanceRating > 90)
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.10));
                    }
                    else if (PerformanceRating > 75 || PerformanceRating < 90)
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.08));
                    }
                    else
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.04));
                    }
                }
                if(Department == "IT")
                {
                    if (PerformanceRating > 90)
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.08));
                    }
                    else if (PerformanceRating > 75 || PerformanceRating < 90)
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.06));
                    }
                    else
                    {
                        dt.Merge(clsUserData.testUpdateSalary($"Employee {i}", 0.03));
                    }
                }

            }
            return dt;
        }
    }


}
