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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCorporateBanking_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser._UserName != "Authorize")
            {
                frmMainForm frm = new frmMainForm(clsGlobal.CurrentUser);
                frm.ShowDialog();
            }
            else
            {
                AuthorizeForm frm = new AuthorizeForm();
                frm.ShowDialog();
            }

        }

        private void btnFinancing_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }

        private void btnTreasury_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }

        private void btnInvestment_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }

        private void btnTradeFinance_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }

        private void btnSupportApp_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }

        private void btnOtherApp_Click(object sender, EventArgs e)
        {
            // Not implemented yet
        }
    }
}
