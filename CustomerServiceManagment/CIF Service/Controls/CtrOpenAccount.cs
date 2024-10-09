using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;

namespace Bank_System_Project
{
    public partial class CtrOpenAccount : UserControl
    {
        public CtrOpenAccount()
        {
            InitializeComponent();
        }
        private clsBankClient client = new clsBankClient();
        private clsBankClient.enMode _Mode;
        private int CifID = 0;
        private string ClientEmail = "";
        public delegate void DataBackEventHandler(object sender, string AccountNumber);
        public event DataBackEventHandler DataBack;
        public void SetClient(ref clsBankClient client) 
        {
            CifID = client._CifID;
            ClientEmail = client._Email;
            CTBFirstName.Texts = client._FirstName;
            CTBLastName.Texts = client._LastName;
            CTBEmail.Texts = client._Email;
            CTBAddress.Texts = client._Address;
            CTBNationality.Texts = client._IdentityNumber;
            DtpDateOfBirth.Value = client._DateOfBirth;
            maskedTBPhone.Text = client._Phone;
            if (client._IdentityType == "Social Security Number")
                rbSocialSecuritynumber.Checked = true;
            else if (client._IdentityType == "Passport")
                rbPassport.Checked = true;
            else 
                rbDrivingLicence.Checked = true;
            roundPic2.Load(client._ImagePath);

            maskedTBPhone.Enabled = false;
            CTBFirstName.Enabled = false;
            CTBLastName.Enabled = false;
            CTBEmail.Enabled = false;   
            CTBNationality.Enabled = false;
            CTBAddress.Enabled = false;
            DtpDateOfBirth.Enabled = false;
            rbPassport.Enabled = false;
            rbSocialSecuritynumber.Enabled = false;
            rbDrivingLicence.Enabled = false;
        }
        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string AccountNumber = GenarateAccountNumber();
                Cursor = Cursors.WaitCursor;
                WaitForm waitForm = new WaitForm();
                waitForm.StartPosition = FormStartPosition.CenterScreen;
                waitForm.Show();

                await Task.Delay(4000);
                _Mode =  clsBankClient.enMode.AddNewMode;
                //client._FirstName = CTBFirstName.Texts;
                //client._LastName = CTBLastName.Texts;
                client._AccountBalance = Convert.ToDecimal(CTBBalance.Texts);
                client._AccountNumber = AccountNumber;
                //client._Email = CTBEmail.Texts;
                //client._Phone = maskedTBPhone.Text;
                //client._Address = CTBAddress.Texts;
                client._PinCode = CTBPassword.Texts;
                //client._IdentityNumber = CTBNationality.Texts;
                //client._DateOfBirth = DtpDateOfBirth.Value;
                //if (rbSocialSecuritynumber.Checked)
                //    client._IdentityType = "Social Security Number";
                //else if (rbPassport.Checked)
                //    client._IdentityType = "Passport";
                //else if (rbDrivingLicence.Checked)
                //    client._IdentityType = "Driving License";
                if (rbCheckingAccount.Checked)
                    client._AccountType = "Checking Account";
                else if (rbSavingAccount.Checked)
                    client._AccountType = "Saving Account";


                //if (roundPic2.ImageLocation != null)
                //{
                //    client._ImagePath = roundPic2.ImageLocation;
                //}
                //else
                //    client._ImagePath = @"C:\Resources\PersonEmptyPhoto.jfif";

                waitForm.Close();
                if (client._OpenNewAccount(CifID,client._AccountNumber,client._PinCode,client._AccountBalance,client._AccountType))
                {
                    //SystemSounds.Exclamation.Play();
                    //MessageBox.Show($"Account Opened Succssfully.\n With AccountNumber {AccountNumber} ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        string senderEmail = "as1549yasas@gmail.com";
                        string recipientEmail = client._Email;
                        string subject = "Account Opening Confirmation";
                        string body = $"Dear {client.FullName()}:\n Thank you for opening an account with us. Your account is now active.\nYour Account Number is {client._AccountNumber}";

                        MailMessage mail = new MailMessage(senderEmail, recipientEmail, subject, body);
                        // mail.CC.Add("cc@example.com");
                        // mail.Bcc.Add("bcc@example.com");
                        // mail.Attachments.Add(new Attachment("path_to_attachment_file"));
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential(senderEmail, "utlg gqnb geox ftrw");
                        smtpClient.EnableSsl = true; // Enable SSL if required by your SMTP server

                        smtpClient.Send(mail);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error sending email: " + ex.Message);
                    }
                    DataBack?.Invoke(this, AccountNumber);
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Error, Failed To Open Account.");
                }
                Cursor = Cursors.Default;
                _Mode = clsBankClient.enMode.UpdateMode;
         
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Make Sure All Fields Not Empty and Correct!");
            }


        }
        private string GenarateAccountNumber()
        {
            Random rnd = new Random();
            string AccountNumber = "";
            for (short i = 0; i <= 12; i++)
            {
                AccountNumber += Convert.ToString(rnd.Next(1, 9));
            }
            return AccountNumber;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CTBBalance.Texts = "";
            CTBPassword.Texts = "";
            CTBConfirmPassword.Texts = "";
            rbCheckingAccount.Checked = false;
            rbSavingAccount.Checked = false;
        }

        private void CTBBalance_Validating(object sender, CancelEventArgs e)
        {
             if (int.TryParse(CTBBalance.Texts, out int result)==false)
             {
                e.Cancel = true;
                CTBBalance.Focus();
                errorProvider.SetError(CTBBalance, "Only Numbers allowed!");
                return;
             }
            else if (string.IsNullOrEmpty(CTBBalance.Texts))
            {
                e.Cancel = true;
                CTBBalance.Focus();
                errorProvider.SetError(CTBBalance, "Initial Deposit is required!");
                return;
            }
            else if (Convert.ToDecimal(CTBBalance.Texts) < 1000)
            {
                e.Cancel = true;
                CTBBalance.Focus();
                errorProvider.SetError(CTBBalance, "Initial Deposit Must be not less than 1000!");
                //e.Cancel = true;
                //errorProvider.SetError(CTBFirstName, null);
                return;
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void CTBPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBPassword.Texts))
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(CTBPassword, "Please enter Password!");
                return;
            }
            else if (CTBPassword.Texts.Length < 5)
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(CTBPassword, "Password Should be at least 5 Characters!");
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void CTBConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBConfirmPassword.Texts))
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(CTBConfirmPassword, "Please Confirm Password!");
                return;
            }
            else if (CTBConfirmPassword.Texts != CTBPassword.Texts)
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(CTBConfirmPassword, "Password Doesn't Match!");
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void CTBNationality_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBNationality.Texts))
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(CTBNationality, "Please enter Client's ID Number!");
                return;
            }
            else
            {
                //e.Cancel = true;
                //errorProvider.SetError(CTBFirstName, null);
                errorProvider.Clear();
                return;
            }
        }

        private void gbAccountTypes_Validating(object sender, CancelEventArgs e)
        {
            if (rbCheckingAccount.Checked == false && rbSavingAccount.Checked == false)
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(gbAccountTypes, "Please select Account Type!");
                return;
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void groupBox1_Validating(object sender, CancelEventArgs e)
        {
            if (rbPassport.Checked == false && rbSocialSecuritynumber.Checked == false && rbDrivingLicence.Checked == false)
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(groupBox1, "Please select Identity Type!");
                return;
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }
    }
}
