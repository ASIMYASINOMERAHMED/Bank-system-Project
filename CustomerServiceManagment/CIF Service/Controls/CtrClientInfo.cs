using Bank_System_Project.Properties;
using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_Project
{
    public partial class CtrClientInfo : UserControl
    {
        public CtrClientInfo(int ClientID)
        {
            InitializeComponent();
            clsBankClient client = clsBankClient.Find(ClientID);
            if(client != null ) 
            {
                lbFirstName.Text = client._FirstName; 
                lbLastName.Text = client._LastName;
                lbEmail.Text = client._Email;
                lbPhone.Text = client._Phone;
                lbAddress.Text = client._Address;
                lbDateOfBirth.Text = client._DateOfBirth.ToString();
                lbIdentityNumber.Text = client._IdentityNumber;
                lbBalance.Text = client._AccountBalance.ToString();
                lbAccontType.Text = client._AccountType;
                lbOpeningDate.Text = "";
                if (client._IdentityType == "Passport")
                    lableIdentityNumber.Text = "Passport Number:";
                else if (client._IdentityType == "Driving License")
                    lableIdentityNumber.Text = "Driving License No:";
                else if (client._IdentityType == "Social Security Number")
                    lableIdentityNumber.Text = "Social Security No:";
                lbAccountNumber.Text = client._AccountNumber;
                if (client._ImagePath != "")
                    roundPic2.Load(client._ImagePath);
                else
                    roundPic2.Load(Resources.PersonEmptyPhoto.ToString());
                
            }
        }

    
    }
}
