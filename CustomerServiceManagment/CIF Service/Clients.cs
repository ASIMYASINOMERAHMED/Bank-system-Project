using Bank_System_Project.Properties;
using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_System_Project
{
    public partial class Clients : Form
    {
       private clsBankClient _Client = new clsBankClient();
        private clsBankClient.enMode _Mode;
        public Clients()
        {
            InitializeComponent();
            _RefreshClients(false);
            
        }
        static bool CheckAccessRights(clsUser.enMainMenuPermission permission,bool ShowMessage =true)
        {
            if (!clsUser.CurrentUser.CheckAccessPermission(permission))
            {
                SystemSounds.Exclamation.Play();
                if (ShowMessage)
                {
                   
                    MessageBox.Show("Access Denied! Contact Your Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                }
                return false;
            }
            else
                return true;
        }

        private void _RefreshClients(bool ShowMessage = true)
        {
            if (!CheckAccessRights(clsUser.enMainMenuPermission.pListClients,ShowMessage))
            {
                btonSearch.Enabled = false;
                CTBSearchClient.Enabled = false;
                labelNotFound.Text = "Access Denied!";
                labelNotFound.Visible = true;
                return;
            }
            DGVClients.DataSource = clsBankClient.GetAllClients();
        }

        private void tpDeleteClient_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pDeleteClient))
            //{
            //    return;
            //}
        }

        private void tpListClients_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!CheckAccessRights(clsBankBusiness.clsUser.enMainMenuPermission.pListClients))
            //{
            //    return;
            //}
        }
        string AccountNumber = "";
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            AccountNumber = CTBAccontNum.Texts;
            Cursor = Cursors.WaitCursor;
            clsBankClient Client = clsBankClient.Find(AccountNumber);
            if(Client != null)
            {
                Cursor = Cursors.Default;
                lbClientID.Text = Client._ID.ToString();
                lbAddress.Text = Client._Address;
                tbDateOfBirth.Text = Client._DateOfBirth.ToString();
                lbEmail.Text = Client._Email;
                lbFirstName.Text = Client._FirstName;
                lbLastName.Text = Client._LastName;
                lbPassword.Text = Client._PinCode;
                lbPhone.Text = Client._Phone;
                lbBalance.Text = Client._AccountBalance.ToString();
                roundPic1.Load(Client._ImagePath);
            }
            else
            {

                ResetFindClient();
                lbNotFound.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbNotFound.Visible = false;
            }
            Cursor = Cursors.Default;
        }
        private void ResetFindClient()
        {
            CTBAccontNum.Texts = "";
            lbClientID.Text = "0";
            lbAddress.Text = "Empty";
             tbDateOfBirth.Text = DateTime.Now.ToString();
            lbEmail.Text = "Empty";
            lbFirstName.Text = "Empty";
            lbLastName.Text = "Empty";
            lbPassword.Text = "Empty";
            lbPhone.Text = "Empty";
            lbBalance.Text = "0";
            roundPic1.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
        }
        clsBankClient client = new clsBankClient();


  

   
        //clsBankBusiness.clsBankClient Client;
        int ID = 0;
        bool IsFound = false;
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            ID =Convert.ToInt32(CTBFindUpdate.Texts);
            Cursor = Cursors.WaitCursor;
            _Client = clsBankClient.Find(ID);
            if (_Client != null)
            {
                Cursor = Cursors.Default;
                IsFound = true;
                CTBID.Texts = _Client._ID.ToString();
                CTBAddressUpdate.Texts = _Client._Address;
                dtpickerDateOfBirth.Value = _Client._DateOfBirth;
                CTBEmailUpdate.Texts = _Client._Email;
                CTBFirstNameUpdate.Texts = _Client._FirstName;
                CTBLastNameUpdate.Texts = _Client._LastName;
                CTBPasswordUpdate.Texts = _Client._PinCode;
                CTBPhoneUpdate.Texts = _Client._Phone;
                CTBBalanceUpdate.Texts = _Client._AccountBalance.ToString();
                CTBAccNumUpdate.Texts = _Client._AccountNumber;
                roundPic3.Load(_Client._ImagePath);

                EnableDisableUpdate(true);
            }
            else
            {
                IsFound = false;
                roundPic3.Image = Resources.PersonEmptyPhoto;
                lbnotExist.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbnotExist.Visible = false;
            }
            Cursor = Cursors.Default;
           
        }
        private void EnableDisableUpdate(bool value)
        {
            CTBID.Enabled = value ;
            CTBAddressUpdate.Enabled = value;
            dtpickerDateOfBirth.Enabled = value;
            CTBEmailUpdate.Enabled = value;
            CTBFirstNameUpdate.Enabled = value;
            CTBLastNameUpdate.Enabled = value;
            CTBPasswordUpdate.Enabled = value;
            CTBPhoneUpdate.Enabled = value;
            CTBBalanceUpdate.Enabled = value;
            CTBAccNumUpdate.Enabled = value;
            linkLabelSetImage.Visible = value;
            buttonCancel.Enabled = value;
            buttonSave.Enabled = value;
        }
        private void ResetUpdateClient()
        {
            CTBFindUpdate.Texts = "";
            CTBID.Texts = "";
            CTBAddressUpdate.Texts = "";
            dtpickerDateOfBirth.Value = DateTime.Now;
            CTBEmailUpdate.Texts = "";
            CTBFirstNameUpdate.Texts = "";
            CTBLastNameUpdate.Texts = "";
            CTBPasswordUpdate.Texts = "";
            CTBPhoneUpdate.Texts = "";
            CTBBalanceUpdate.Texts = "";
            CTBAccNumUpdate.Texts = "";
            roundPic3.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
            EnableDisableUpdate(false);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if(!IsFound)
                return;

            CTBID.Texts = _Client._ID.ToString();
            CTBAccNumUpdate.Texts = _Client._AccountNumber;
            CTBAddressUpdate.Texts = _Client._Address;
            dtpickerDateOfBirth.Value = _Client._DateOfBirth;
            CTBEmailUpdate.Texts = _Client._Email;
            CTBFirstNameUpdate.Texts = _Client._FirstName;
            CTBLastNameUpdate.Texts = _Client._LastName;
            CTBPasswordUpdate.Texts =  _Client._PinCode;
            CTBPhoneUpdate.Texts = _Client._Phone;
            CTBBalanceUpdate.Texts = _Client._AccountBalance.ToString();
            roundPic3.Load(_Client._ImagePath);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            if(!IsFound)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Erorr, Fields Empty");
                return;
            }
             Cursor = Cursors.WaitCursor;
            _Client._FirstName = CTBFirstNameUpdate.Texts;
            _Client._LastName = CTBLastNameUpdate.Texts;
            _Client._AccountBalance = Convert.ToDecimal(CTBBalanceUpdate.Texts);
            _Client._AccountNumber = CTBAccNumUpdate.Texts;
            _Client._Email = CTBEmailUpdate.Texts;
            _Client._Phone = CTBPhoneUpdate.Texts;
            _Client._Address = CTBAddressUpdate.Texts;
            _Client._PinCode = CTBPasswordUpdate.Texts;
            if (roundPic3.ImageLocation != null)
            {
                _Client._ImagePath = roundPic3.ImageLocation;
            }
            else
                _Client._ImagePath = @"C:\Resources\PersonEmptyPhoto.jfif";
            if (_Client.Save())
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Client Updated Succssfully.");
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Failed to Update Client.");
            }
            Cursor = Cursors.Default;
      
            _RefreshClients();
            TabControlClients.SelectedIndex = 0;
            EnableDisableUpdate(false);
            ResetUpdateClient();
        }

        private void linkLabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.jfif;*.png;*.gif;*.bmp";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog2.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                roundPic3.Load(selectedFilePath);
                linkLabelRemove.Visible = true;
                // ...
            }
        }

        private void linkLabelRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            roundPic3.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
            linkLabelRemove.Visible = false;
        }

        private async void bttnSearch_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(textBoxFind.Text);
            Cursor = Cursors.WaitCursor;
            _Client = clsBankClient.Find(ID);
            if (_Client != null)
            {
                Cursor = Cursors.Default;
                IsFound = true;
                textBoxFind.Text = _Client._ID.ToString();
                textBAddress.Text = _Client._Address;
                dateTPDateOfBirth.Text = _Client._DateOfBirth.ToString();
                textBEmail.Text = _Client._Email;
                textBFirstName.Text = _Client._FirstName;
                textBLastName.Text = _Client._LastName;
                textBPassword.Text = _Client._PinCode;
                textBPhone.Text = _Client._Phone;
                textBAccountBalance.Text = _Client._AccountBalance.ToString();
                textBAccountNumber.Text = _Client._AccountNumber;
                roundPic4.Load(_Client._ImagePath);
            }
            else
            {
                IsFound = false;
                roundPic4.Image = Resources.PersonEmptyPhoto;
                lbClientNotFound.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbClientNotFound.Visible = false;
            }
            Cursor = Cursors.Default;


        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            ResetDeleteScreen();
            TabControlClients.SelectedIndex = 0;
        }

        private void ResetDeleteScreen()
        {
            textBoxFind.Text = "";
            textBClientID.Text = "";
            textBAddress.Text = "";
            dateTPDateOfBirth.Value = DateTime.Now;
            textBEmail.Text = "";
            textBFirstName.Text = "";
            textBLastName.Text = "";
            textBPassword.Text = "";
            textBPhone.Text = "";
            textBAccountBalance.Text = "";
            textBAccountNumber.Text = "";
            roundPic4.Image = Resources.PersonEmptyPhoto;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!IsFound) 
            {
                MessageBox.Show("There's No Client To Delete.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are You Sure You Want To Delete It ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsBankClient.DeleteClient(_Client._AccountNumber))
                {
                    ResetDeleteScreen();
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Client Deleted Succssfully.");
                    _RefreshClients();
                    TabControlClients.SelectedIndex = 0;
                    ResetDeleteScreen();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Unable To Delete Client.");
                    ResetDeleteScreen();
                }
            }
            else
            {
                ResetDeleteScreen();
                return;
            }
        }
       
        private void TabControlClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlClients.SelectedIndex == 0)
            {
                _RefreshClients(false);
            }
            if (TabControlClients.SelectedIndex == 1)
            {
                if (!CheckAccessRights(clsUser.enMainMenuPermission.pFindClient))
                {
                    TabControlClients.SelectedIndex = 0;
                    return;
                }
            }
            if (TabControlClients.SelectedIndex == 2)
            {
                if (!CheckAccessRights(clsUser.enMainMenuPermission.pAddNewClient))
                {
                    TabControlClients.SelectedIndex = 0;
                    return;
                }
            }
            if (TabControlClients.SelectedIndex == 3)
            {
                if (!CheckAccessRights(clsUser.enMainMenuPermission.pUpdateClients))
                {
                    TabControlClients.SelectedIndex = 0;
                    return;
                }
            }
            if (TabControlClients.SelectedIndex == 4)
            {
                if (!CheckAccessRights(clsUser.enMainMenuPermission.pDeleteClient))
                {
                    TabControlClients.SelectedIndex = 0;
                    return;
                }
            }
        }

        private async void btonSearch_Click(object sender, EventArgs e)
        {
            if (CTBSearchClient.Texts == "")
                return;
            ID = Convert.ToInt32(CTBSearchClient.Texts);
            _Client=clsBankClient.Find(ID);
            if (_Client != null)
                DGVClients.DataSource = clsBankClient.GetClient(ID);
            else
            {
                labelNotFound.Text = "Client Not Found!";
                labelNotFound.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                labelNotFound.Visible = false;
            }

        }
        private string GenarateAccountNumber()
        {
            Random rnd = new Random();
            string AccountNumber = "";
            for (short i=0;i<=12;i++)
            {
                AccountNumber +=Convert.ToString(rnd.Next(1,9));
            }
            return AccountNumber;
        }



        private void DGVClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow currentRow = DGVClients.CurrentRow;
            string IDValue = currentRow.Cells[0].Value?.ToString();
            CtrClientInfo ctrClient = new CtrClientInfo(Convert.ToInt32(IDValue));
            frmClientInfo frmClientInfo = new frmClientInfo();
            frmClientInfo.Controls.Add(ctrClient);
            frmClientInfo.StartPosition = FormStartPosition.CenterScreen;
            frmClientInfo.ShowDialog();
         
        }

        private void openAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = DGVClients.CurrentRow;
            string IDValue = currentRow.Cells[0].Value?.ToString();
            CtrClientInfo ctrClient = new CtrClientInfo(Convert.ToInt32(IDValue));
            frmClientInfo frmClientInfo = new frmClientInfo();
            frmClientInfo.Controls.Add(ctrClient);
            frmClientInfo.StartPosition = FormStartPosition.CenterScreen;
            frmClientInfo.ShowDialog();
        }



        private void btnGo_Click(object sender, EventArgs e)
        {
            if(cbFunction.SelectedIndex==0)
            {
                Form Cif = new frmNewCIF();
                Cif.StartPosition = FormStartPosition.CenterScreen;
                Cif.ShowDialog();
            }
            if(cbFunction.SelectedIndex==4)
            {
                clsBankClient Client= clsBankClient.Find(CTBCIF.Texts);
               if(clsBankClient.DeleteCIF(Client._CifID))
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show($"CIF with Number {CTBCIF.Texts} deleted Successfully.");
                }
               else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show($"Unable To delete CIF.");
                }
            }
        }

        private void cbFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFunction.SelectedIndex == 0) 
            {
                btnSearchCIF.Visible = false;
            }
            else
                btnSearchCIF.Visible = true;
        }

        private void btnSearchCIF_Click(object sender, EventArgs e)
        {
            string CifNumber = CTBCIF.Texts.Trim();
            clsBankClient client = clsBankClient.Find(CifNumber);
            if (client != null)
            {
                frmClientCIF clientCIF = new frmClientCIF(client);
                clientCIF.StartPosition = FormStartPosition.CenterParent;
                clientCIF.ShowDialog();
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("CIF Number is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CTBCIF.Texts = string.Empty;
        }

        private void bttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

        }

        private void btnTransferTo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelTransfer_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchTransferFrom_Click(object sender, EventArgs e)
        {

        }

        private void CTBTransferTo_Enter(object sender, EventArgs e)
        {

        }

        private void CTBTransferTo_Leave(object sender, EventArgs e)
        {

        }

        private void CTBTransferFrom_Enter(object sender, EventArgs e)
        {

        }

        private void CTBTransferFrom_Leave(object sender, EventArgs e)
        {

        }

        private void DGVTransactionsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVTransactionsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
