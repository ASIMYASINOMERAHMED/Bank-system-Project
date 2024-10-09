using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Project
{
    public class clsTransactionReport
    {
        public string BalanceText { get; set; }
        public DateTime Time { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal balance { get; set; }
        public string Operation { get; set; }


        public clsTransactionReport(clsBankClient client,string Operation)
        {
            this.Time = DateTime.Now;
            this.FullName = client.FullName();
            this.Address = client._Address;
            this.Phone = client._Phone;
            this.Email = client._Email;
            this.balance = client._AccountBalance;
            this.BalanceText = clsBankClient.NumberToText(Convert.ToInt32(client._AccountBalance));
            this.Operation = Operation;
        }
        public static List<clsTransactionReport> GetTransactionInfo(clsBankClient Client,string Operation)
        {
            List<clsTransactionReport> list = new List<clsTransactionReport>();
            
              list.Add(new clsTransactionReport(Client,Operation));
              return list;
        }

    }
               
            

} 

    

