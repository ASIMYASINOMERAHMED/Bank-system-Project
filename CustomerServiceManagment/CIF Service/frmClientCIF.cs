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
using BankBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Media;
using BankBussinessLayer;

namespace Bank_System_Project
{
    public partial class frmClientCIF : Form
    {
        clsBankClient client1;
        public frmClientCIF(clsBankClient client)
        {
            InitializeComponent();
            ctrCIFcs1.SetClientInfo(ref client);
            _RefreshAccountsDGV(ref client);

            //CtrCIF ctrCIF = new CtrCIF(client);
            //ctrCIF.Height = 1003;
            //ctrCIF.Width = 1411;
            // tabPage1.Controls.Add(ctrCIF);
            //ctrCIF.Dock = DockStyle.Fill;
            client1 = client;
  
        }

        private void _FillAccountsInComboBox(ToolStripComboBox comboBox,int CifID)
        {
            DataTable dtAccounts = clsBankClient.GetAccounts(CifID);
            foreach (DataRow row in dtAccounts.Rows)
            {
                comboBox.Items.Add(row["AccountNumber"]);
            }
        }
        private void _RefreshAccountsDGV(ref clsBankClient client)
        {
            DGVAccounts.DataSource = clsAccount.GetAllAccountsRelatedToClient(client._CifID);

            DGVAccounts.ClearSelection();
            if (DGVAccounts.Rows.Count == 0)
            {
                DGVAccounts.Visible = false;
                lbNoAccounts.Visible = true;
            }
            else
            {
                DGVAccounts.ClearSelection();
                DGVAccounts.Visible = true;
                lbNoAccounts.Visible = false;
                DGVAccounts.Rows[0].Selected = false;
            }

            DGVAccounts.ClearSelection();
            _FillAccountsInComboBox(toolStripComboBoxAccounts,client._CifID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            frmAddAccount addAccount = new frmAddAccount(ref client1);
            addAccount.StartPosition = FormStartPosition.CenterScreen;
            addAccount.ShowDialog();
            _RefreshAccountsDGV(ref client1);
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox3_Enter(object sender, EventArgs e)
        {
            if (toolStripTextBoxToCIF.Text == "CIF Number")
            {
                toolStripTextBoxToCIF.Text = "";
            }
            toolStripTextBoxToCIF.ForeColor = Color.Black;
        }

        private void toolStripTextBoxToCIF_Leave(object sender, EventArgs e)
        {
            if (toolStripTextBoxToCIF.Text == "")
            {
                toolStripTextBoxToCIF.Text = "CIF Number";
            }
            toolStripTextBoxToCIF.ForeColor = Color.DarkGray;
        }

        private void toolStripTBAmount_Validating(object sender, CancelEventArgs e)
        {

        }
        clsBankClient DestenationClient = null;
        private void toolStripTextBoxToCIF_Validating(object sender, CancelEventArgs e)
        {
            if(toolStripTextBoxToCIF.Text.Length==25)
            {
               clsBankClient client = clsBankClient.Find(toolStripTextBoxToCIF.Text);
                if (client != null)
                {
                    _FillAccountsInComboBox(toolStripcbDestenationAccounts, client._CifID);
                    toolStripcbDestenationAccounts.Enabled = true;
                    DestenationClient = client;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("CIF Number Not Valid","Validation Erorr",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
            }
         
        }

        private void preformTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal Amount = Convert.ToDecimal(toolStripTBAmount.Text);
            double balance = clsBankClient.GetAccountBalance(toolStripComboBoxAccounts.Text);
     
            if (client1.Transfer(Amount, ref DestenationClient, clsUser.CurrentUser._UserName))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show($"Transfer Done Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show($"Amount Exeeds The Balance\n You Can Transfer Up To {balance}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
