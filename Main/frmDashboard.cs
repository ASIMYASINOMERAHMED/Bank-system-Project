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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
          
            InitializeComponent();
            lbUsersCount.Text = GetUsersCount().ToString();
            lbClientsCount.Text = GetClientsCount().ToString();
        }
        private int GetUsersCount()
        {

            return clsUser.GetUsersCount();
         
        }
        private int GetClientsCount()
        {

            return clsBankClient.GetClientsCount();
         
        }


     
    }
}
