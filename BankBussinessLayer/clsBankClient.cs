using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
        public class clsBankClient : clsPerson
        {
            public enum enMode { UpdateMode = 1, AddNewMode = 2 };
            enMode Mode;
            public int _ID { set; get; }
            public string _AccountNumber { set; get; }
            public string _PinCode { set; get; }
            public decimal _AccountBalance { set; get; }
            public string _Address { set; get; }
            public string _ImagePath { set; get; }
            public DateTime _DateOfBirth { set; get; }
            // public Guid UTI { set; get; }
            public int TransactionID { set; get; }
            public string _IdentityNumber { set; get; }
            public string _IdentityType { set; get; }
            public string _AccountType { set; get; }
            public int _CifID { set; get; }
            public string _Gender { set; get; }
            public decimal _Income { set; get; }
            public string _IncomeType { set; get; }
            public string _OccupationType { set; get; }
            public int _CountryID { set; get; }

            public clsBankClient()
            {
                _Address = "";
                _DateOfBirth = DateTime.Now;
                _ImagePath = "";
                //_AccountNumber = "";
                //_PinCode = "";
                //_AccountBalance = 0;
                _IdentityNumber = "";
                _IdentityType = "";
                _AccountType = "";
                _ID = -1;
                Mode = enMode.AddNewMode;
            }
            private clsBankClient(int ID, int CifID, string FirstName, string LastName, string Email, string Phone, decimal Income, string IncomeType, string OccupationType, int CountryID, string Gender, string Address, DateTime DateOfBirth, string IdentityNumber, string IdentityType, string ImagePath)
                : base(FirstName, LastName, Phone, Email)
            {
                //_Mode = Mode;

                this._DateOfBirth = DateOfBirth;
                this._ImagePath = ImagePath;
                this._Address = Address;
                this._IdentityNumber = IdentityNumber;
                this._IdentityType = IdentityType;
                this._Income = Income;
                this._IncomeType = IncomeType;
                this._OccupationType = OccupationType;
                this._CountryID = CountryID;
                this._Gender = Gender;
                this._ID = ID;
                this._CifID = CifID;
                Mode = enMode.UpdateMode;
            }


            public static clsBankClient Find(string CifNumber)
            {
                string FirstName = "", LastName = "", Phone = "", Email = "", Address = "", IdentityNumber = "", IdentityType = "", IncomeType = "", OccupationType = "", Gender = "", ImagePath = "";
                int CifID = 0;
                int ID = 0;
                int CountryID = 0;
                decimal Income = 0;
                DateTime DateOfBirth = DateTime.Now;
                if (clsClientData.GetClientInfoByCifNumber(ref ID, ref CifID, CifNumber, ref FirstName, ref LastName,
                    ref Email, ref Phone, ref Income, ref IncomeType, ref OccupationType, ref Gender, ref CountryID, ref Address, ref DateOfBirth, ref IdentityNumber, ref IdentityType, ref ImagePath))
                    return new clsBankClient(ID, CifID, FirstName, LastName, Email, Phone, Income, IncomeType, OccupationType, CountryID, Gender, Address, DateOfBirth, IdentityNumber, IdentityType, ImagePath);
                else
                    return null;

            }
        public static clsBankClient FindByAccountNumber(string AccountNumber)
        {
            string FirstName = "", LastName = "", Phone = "", Email = "", Address = "", IdentityNumber = "", IdentityType = "", IncomeType = "", OccupationType = "", Gender = "", ImagePath = "";
            int CifID = 0;
            int ID = 0;
            int CountryID = 0;
            decimal Income = 0;
            DateTime DateOfBirth = DateTime.Now;
            if (clsClientData.GetClientInfoByAccountNumber(ref ID, ref CifID, AccountNumber, ref FirstName, ref LastName,
                ref Email, ref Phone, ref Income, ref IncomeType, ref OccupationType, ref Gender, ref CountryID, ref Address, ref DateOfBirth, ref IdentityNumber, ref IdentityType, ref ImagePath))
                return new clsBankClient(ID, CifID, FirstName, LastName, Email, Phone, Income, IncomeType, OccupationType, CountryID, Gender, Address, DateOfBirth, IdentityNumber, IdentityType, ImagePath);
            else
                return null;

        }
        public static clsBankClient Find(int ID)
            {
                string FirstName = "", LastName = "", CifNumber = "", Phone = "", Email = "", Address = "", IdentityNumber = "", IdentityType = "", IncomeType = "", OccupationType = "", Gender = "", ImagePath = "";
                int CountryID = 0, CifID = 0;
                decimal Income = 0;

                DateTime DateOfBirth = DateTime.Now;
                if (clsClientData.GetClientInfoByID(ID, ref CifID, ref CifNumber, ref FirstName, ref LastName,
                    ref Email, ref Phone, ref Income, ref IncomeType, ref OccupationType, ref CountryID, ref Gender, ref Address, ref DateOfBirth, ref IdentityNumber, ref IdentityType, ref ImagePath))
                    return new clsBankClient(ID, CifID, FirstName, LastName, Email, Phone, Income, IncomeType, OccupationType, CountryID, Gender, Address, DateOfBirth, IdentityNumber, IdentityType, ImagePath);
                else
                    return null;

            }
            public string GenerateCifNumber()
            {
                string prefix = "CIF";
                string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
                string randomPart = GenerateRandomNumber(100000, 999999).ToString();

                string cifId = $"{prefix}-{timestamp}-{randomPart}";
                return cifId;
            }

            private int GenerateRandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            public string _AddNewClient()
            {
                string CifNumber = GenerateCifNumber();
                this._CifID = clsCIFData.AddNewCIF(CifNumber);
                this._ID = clsClientData.AddNewClient(this._CifID, this._FirstName, this._LastName, this._Email, this._Phone, this._Address, this._DateOfBirth, this._IdentityNumber, this._IdentityType, this._Gender, this._Income, this._IncomeType, this._OccupationType, this._CountryID, this._ImagePath);
                if (this._ID != -1)
                {
                    return CifNumber;
                }
                else
                    return "";
            }
            public bool _OpenNewAccount(int CifID, string AccountNumber, string Password, decimal Balance, string AccountType)
            {
                int AccountID = clsAccountsData.AddNewAccount(CifID, AccountNumber, Password, Balance, AccountType);
                return (AccountID != -1);
            }
            private bool _UpdateClient()
            {

                return clsClientData.UpdateClient(this._CifID, this._FirstName, this._LastName, this._Email, this._Phone, this._Gender, this._Income, this._IncomeType, this._OccupationType, this._CountryID,
                                                   this._Address, this._DateOfBirth, this._IdentityNumber, this._IdentityType, this._ImagePath);
            }

            public bool Save()
            {


                switch (Mode)
                {
                    case enMode.AddNewMode:
                        if (_AddNewClient() != "")
                        {

                            Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case enMode.UpdateMode:

                        return _UpdateClient();

                }

                return false;
            }
            public static DataTable GetAllClients()
            {
                return clsClientData.GetAllClients();
            }
            public static DataTable GetClient(int ID)
            {
                return clsClientData.GetClientByID(ID);
            }
            public static double GetAccountBalance(string AccountNumber)
            {
                return clsAccountsData.GetAccountBalance(AccountNumber);
            }
            public static DataTable GetCountries()
            {
                return clsCountryData.GetCountries();
            }
            public static DataTable GetAccounts(int CifID)
            {
                return clsAccountsData.GetAccounts(CifID);
            }
            public static bool DeleteClient(string AccountNumber)
            {
                return clsClientData.DeleteClientByAccountNumber(AccountNumber);
            }
            public static bool DeleteCIF(int CifID)
            {
                bool Results = false;
                if (clsAccountsData.DeleteAccounts(CifID))
                {
                    if (clsClientData.DeleteClientInfo(CifID))
                    {
                        Results = clsCIFData.DeleteCIF(CifID);
                    }
                }
                return Results;

            }
            public static int GetClientsCount()
            {

                return clsClientData.GetClientsCount();

            }
            public void Deposit(decimal Amount)
            {
                _AccountBalance += Amount;
                Save();
            }
            public bool Withdraw(decimal Amount)
            {
                if (Amount > _AccountBalance)
                {
                    return false;
                }
                else
                {
                    _AccountBalance -= Amount;
                    Save();
                    return true;
                }
            }
            string _PrepareTransferRecord(decimal Amount, clsBankClient DestinationClient,
            string UserName, string Delim = "#//#")
            {
                string TransferRecord = "";
                TransferRecord += UserName + Delim;
                TransferRecord += this._AccountNumber + Delim;
                TransferRecord += DestinationClient._AccountNumber + Delim;
                TransferRecord += Amount + Delim;
                TransferRecord += this._AccountBalance + Delim;
                TransferRecord += DestinationClient._AccountBalance + Delim;
                TransferRecord += DateTime.Now;
                return TransferRecord;
            }
            private string _File = @"F:\TransferRegister.txt";
            void _RegisterTransferLog(decimal Amount, clsBankClient DestinationClient, string UserName)
            {

                string stTransferDataLine = _PrepareTransferRecord(Amount, DestinationClient, UserName);
                if (File.Exists(_File))
                {
                    File.AppendAllText(_File, stTransferDataLine + "\n");
                }

            }

        public bool RegisterTransactionInDB(int ID, string UTI, int ClientID, decimal Amount, string TransactionType)
        {
            this.TransactionID = clsTransactionData.RegisterTransactionInDB(ID, UTI, ClientID, Amount, TransactionType);
            return (this.TransactionID != -1);
        }

        public bool Transfer(decimal Amount, ref clsBankClient DestenatinationClient, string UserName)
            {
                if (Amount > _AccountBalance)
                {
                    return false;
                }
                Withdraw(Amount);
                DestenatinationClient.Deposit(Amount);
                _RegisterTransferLog(Amount, DestenatinationClient, UserName);
                return true;
            }
            public static string NumberToText(int Number)
            {
                if (Number == 0)
                {
                    return "";
                }
                if (Number >= 1 && Number <= 19)
                {
                    string[] arr = { "", "One", "Tow", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Towlve", "Threeteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                    return arr[Number] + " ";
                }
                if (Number >= 20 && Number <= 99)
                {
                    string[] arr = { "", "", "Tewnty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
                    return arr[Number / 10] + " " + NumberToText(Number % 10);
                }
                if (Number >= 100 && Number <= 199)
                {
                    return "One Handred " + NumberToText(Number % 100);
                }
                if (Number >= 200 && Number <= 999)
                {
                    return NumberToText(Number / 100) + "Handred " + NumberToText(Number % 100);
                }
                if (Number >= 1000 && Number <= 1999)
                {
                    return "One Thousand " + NumberToText(Number % 1000);
                }
                if (Number >= 2000 && Number <= 999999)
                {
                    return NumberToText(Number / 1000) + "Thousand " + NumberToText(Number % 1000);
                }
                if (Number >= 1000000 && Number <= 1999999)
                {
                    return "One Million " + NumberToText(Number % 1000000);
                }
                if (Number >= 2000000 && Number <= 999999999)
                {
                    return NumberToText(Number / 1000000) + "Million " + NumberToText(Number % 1000000);
                }
                if (Number >= 10000000000 && Number <= 1999999999)
                {
                    return "One Billion " + NumberToText(Number % 1000000000);
                }
                else
                {
                    return NumberToText(Number / 1000000000) + "Billions " + NumberToText(Number % 1000000000);
                }
            }
  
     
        }

}
