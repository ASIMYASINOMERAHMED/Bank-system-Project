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
    public partial class frmProfile : Form
    {
        public frmProfile(clsUser User)
        {
            InitializeComponent();
          //  tbProfileDateOfBirth.Text = User._DateOfBirth.ToString();
            lbPosition.Text = User._Position;
            lbEmail.Text = User._Email;
            lbFirstName.Text = User._FirstName;
            lbLastName.Text = User._LastName;    
            lbPassword.Text = User._Password;
            lbPhone.Text = User._Phone;
            lbSalary.Text = User._Salary.ToString()+"$";
            lbID.Text = User._ID.ToString();
            lbUserName.Text = User._UserName;
            clsUser.CurrentUser = User;
            lblProfilePermissions.Text = User.GetPermissions(User);
            roundPic1.Load(User._ImagePath);

        }
        //static bool CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission permission)
        //{
        //    if (!clsBankBusiness.clsUser.CurrentUser.CheckAccessPermission(permission))
        //    {
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private string GetPermissions(clsBankBusiness.clsUser User)
        //{
        //    if (User._Permissions == -1)
        //        return "Full Access.";
        //    string sPermissions = "";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pManageUsers))
        //        sPermissions = "* Manage Users";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pListEntireTableUsers))
        //        sPermissions += "\n* List All Users";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pTransactions))
        //        sPermissions += "\n* Transactions";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pLoginRegister))
        //        sPermissions += "\n* Login Register";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pListClients))
        //        sPermissions += "\n* List Clients";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pAddNewClient))
        //        sPermissions += "\n* Add New Client";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pDeleteClient))
        //        sPermissions += "\n* Delete Client";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pUpdateClients))
        //        sPermissions += "\n* Update Client";
        //    if (CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pFindClient))
        //        sPermissions += "\n* Find Client";

        //    return sPermissions;
        //}
    }
}
