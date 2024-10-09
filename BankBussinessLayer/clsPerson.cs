using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsPerson
    {
        public string _FirstName { set; get; }
        public string _LastName { set; get; }
        public string _Phone { set; get; }
        public string _Email { set; get; }
        public clsPerson(string FirstName, string LastName,string Phone,string Email)
        {
            this._FirstName = FirstName;
            this._LastName = LastName;
            this._Phone = Phone;
            this._Email = Email;
        }
        public clsPerson()
        {
            this._FirstName = "";
            this._LastName = "";
            this._Phone = "";
            this._Email = "";
        }
        public string FullName()
        {
            return _FirstName+" "+_LastName;
        }
        //void send Email()
        //void send SMS()
    }
}
