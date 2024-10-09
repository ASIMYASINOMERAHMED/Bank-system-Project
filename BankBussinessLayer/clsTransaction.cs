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
    public class clsTransaction
    {
       
            public int TransactionID { set; get; }
            public string Status { set; get; }
            public string UserName { set; get; }
            public string UTI { set; get; }
            public string AccountNumber { set; get; }
            public string TransactionType { set; get; }
            public decimal Amount { set; get; }

           // public frmTransactionReport Receipt { set; get; }
            public clsTransaction(int TransactionID, string Status, string UserName, string UTI, string AccountNumber, string TransactionType, decimal Amount)
            {
                this.TransactionID = TransactionID;
                this.UTI = UTI;
                this.AccountNumber = AccountNumber;
                this.TransactionType = TransactionType;
                this.Amount = Amount;
                this.TransactionType = TransactionType;
                this.UserName = UserName;
                this.Status = Status;
            }
            public static clsTransaction Find(int TransactionID)
            {
                string UserName = "", AccountNumber = "", Status = "", UTI = "", TransactionType = "";
                int TransactionId = 0;
                decimal Amount = 0;
                if (clsTransactionData.FindTransactionByID(TransactionID, ref UserName, ref AccountNumber, ref UTI, ref TransactionType, ref Status, ref Amount))
                    return new clsTransaction(TransactionID, Status, UserName, UTI, AccountNumber, TransactionType, Amount);
                else
                    return null;


            }
      
        string _PrepareTransactionRecord(string UserName, decimal Amount, string Operation, string Status, string Delim = "#//#")
        {
            string TransactionRecord = "";
            TransactionRecord += UserName + Delim;
            TransactionRecord += this.AccountNumber + Delim;
            TransactionRecord += Amount + Delim;
            TransactionRecord += Operation + Delim;
            TransactionRecord += DateTime.Now + Delim;
            TransactionRecord += Status;
            return TransactionRecord;
        }
        private string _TransactionFile = @"F:\TransactionRegister.txt";
        public void RegisterTransactionInFile(string UserName, decimal Amount, string Operation, string Status)
        {

            string stTransactionDataLine = _PrepareTransactionRecord(UserName, Amount, Operation, Status);
            if (File.Exists(_TransactionFile))
            {
                File.AppendAllText(_TransactionFile, stTransactionDataLine + "\n");
            }

        }
        public static DataTable GetTransactionList()
        {
            return clsTransactionData.GetTransactionList();
        }
        public static bool UpdateBalance(int TransactionID,decimal NewBalance)
        {
            return clsAccountsData.UpdateBalance(TransactionID, NewBalance);
        }
        public static bool UpdateTransactionStatus(int TransactionID,string NewStatus)
        {
            return clsTransactionData.UpdateTransactionStatus(TransactionID, NewStatus);
        }
        public static DataTable GetAllTransactions()
        {
            return clsTransactionData.GetAllTransactions();
        }

        public static bool DeleteTransaction(int TransactionID)
        {
            return clsTransactionData.DeleteTransaction(TransactionID); 
        }
    }
}
