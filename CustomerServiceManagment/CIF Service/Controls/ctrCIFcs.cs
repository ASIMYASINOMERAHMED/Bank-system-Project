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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using BankBusinessLayer;

namespace Bank_System_Project
{

    public partial class ctrCIFcs : UserControl
    {
        public delegate void DataBackEventHandler(object sender, string CifID);
        public event DataBackEventHandler DataBack;
        public ctrCIFcs()
        {
            InitializeComponent();
            _FillCountriesInComboBox();
        }

       
            clsBankClient _client;
            public void SetClientInfo(ref clsBankClient client)
            {
                if (client != null)
                {
                    // _client = clsBankBusiness.clsBankClient.Find(CifNumber);
                    _client = client;
                    // SetClientInfo(ref client);
                    btnEdit.Visible = true;
                    btnNext.Visible = false;

                }
                CTBFirstName.Texts = client._FirstName;
                CTBLastName.Texts = client._LastName;
                CTBEmail.Texts = client._Email;
                maskedTBPhone.Text = client._Phone;
                DtpDateOfBirth.Value = client._DateOfBirth;
                CTBAddress.Texts = client._Address;
                CTBIncome.Texts = client._Income.ToString();
                if (client._Gender == "M")
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                if (client._IdentityType == "Passport")
                    rbPassport.Checked = true;
                else if (client._IdentityType == "Social Security number")
                    rbSocialSecuritynumber.Checked = true;
                else
                    rbDrivingLicence.Checked = true;
                CTBNationality.Texts = client._IdentityNumber;
                cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(client._CountryID).CountryName);
                cbIncomeType.SelectedIndex = cbIncomeType.FindString(client._IncomeType);
                cbOccupationType.SelectedIndex = cbOccupationType.FindString(client._OccupationType);
                roundPic2.Load(client._ImagePath);

                EnableDisableFeilds(false);
            }
            private void EnableDisableFeilds(bool Enable)
            {
                CTBFirstName.Enabled = Enable;
                CTBFirstName.Enabled = Enable;
                CTBLastName.Enabled = Enable;
                CTBEmail.Enabled = Enable;
                maskedTBPhone.Enabled = Enable;
                CTBAddress.Enabled = Enable;
                CTBNationality.Enabled = Enable;
                DtpDateOfBirth.Enabled = Enable;
                cbOccupationType.Enabled = Enable;
                cbCountry.Enabled = Enable;
                CTBIncome.Enabled = Enable;
                cbIncomeType.Enabled = Enable;
                llSetImage.Visible = Enable;
                groupBox3.Enabled = Enable;
                groupBox1.Enabled = Enable;
               // btnNext.Visible = Enable;
                btnCancel.Visible = Enable;
                btnSave.Visible = Enable;
            }
            private void _FillCountriesInComboBox()
            {
                DataTable dtCountries = clsBankClient.GetCountries();
                foreach (DataRow row in dtCountries.Rows)
                {
                    cbCountry.Items.Add(row["CountryName"]);
                }
            }
         
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            EnableDisableFeilds(true);
            btnNext.Visible = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Cursor = Cursors.WaitCursor;
                WaitForm waitForm = new WaitForm();
                waitForm.StartPosition = FormStartPosition.CenterScreen;
                waitForm.Show();
                await Task.Delay(2000);
                _client._FirstName = CTBFirstName.Texts;
                _client._LastName = CTBLastName.Texts;
                _client._Email = CTBEmail.Texts;
                _client._Phone = maskedTBPhone.Text;
                _client._Address = CTBAddress.Texts;
                _client._IdentityNumber = CTBNationality.Texts;
                _client._DateOfBirth = DtpDateOfBirth.Value;
                if (rbMale.Checked)
                    _client._Gender = "M";
                else if (rbFemale.Checked)
                    _client._Gender = "F";
                _client._OccupationType = cbOccupationType.GetItemText(cbOccupationType.SelectedItem);
                _client._CountryID = cbCountry.SelectedIndex + 1;
                _client._Income = Convert.ToDecimal(CTBIncome.Texts);
                _client._IncomeType = cbIncomeType.GetItemText(cbIncomeType.SelectedItem);
                if (rbSocialSecuritynumber.Checked)
                    _client._IdentityType = "Social Security Number";
                else if (rbPassport.Checked)
                    _client._IdentityType = "Passport";
                else if (rbDrivingLicence.Checked)
                    _client._IdentityType = "Driving License";

                if (roundPic2.ImageLocation != null)
                {
                    _client._ImagePath = roundPic2.ImageLocation;
                }
                else
                    _client._ImagePath = @"C:\Resources\PersonEmptyPhoto.jfif";
                waitForm.Close();
                if (_client.Save())
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
                EnableDisableFeilds(false);
            }
        }

        private async void btnNext_Click_1(object sender, EventArgs e)
        {
            _client = new clsBankClient();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Cursor = Cursors.WaitCursor;
                WaitForm waitForm = new WaitForm();
                waitForm.StartPosition = FormStartPosition.CenterScreen;
                waitForm.Show();
                await Task.Delay(2000);
                _client._FirstName = CTBFirstName.Texts;
                _client._LastName = CTBLastName.Texts;
                _client._Email = CTBEmail.Texts;
                _client._Phone = maskedTBPhone.Text;
                _client._Address = CTBAddress.Texts;
                _client._IdentityNumber = CTBNationality.Texts;
                _client._DateOfBirth = DtpDateOfBirth.Value;
                if (rbMale.Checked)
                    _client._Gender = "M";
                else if (rbFemale.Checked)
                    _client._Gender = "F";
                _client._OccupationType = cbOccupationType.GetItemText(cbOccupationType.SelectedItem);
                _client._CountryID = cbCountry.SelectedIndex + 1;
                _client._Income = Convert.ToDecimal(CTBIncome.Texts);
                _client._IncomeType = cbIncomeType.GetItemText(cbIncomeType.SelectedItem);
                if (rbSocialSecuritynumber.Checked)
                    _client._IdentityType = "Social Security Number";
                else if (rbPassport.Checked)
                    _client._IdentityType = "Passport";
                else if (rbDrivingLicence.Checked)
                    _client._IdentityType = "Driving License";

                if (roundPic2.ImageLocation != null)
                {
                    _client._ImagePath = roundPic2.ImageLocation;
                }
                else
                    _client._ImagePath = @"C:\Resources\PersonEmptyPhoto.jfif";
                await Task.Delay(2000);
                waitForm.Close();
                string CifNumber = _client._AddNewClient();
                if (CifNumber != "")
                {
                    //   SystemSounds.Exclamation.Play();
                    //   MessageBox.Show($"The customer record is created Successfully.The CIF ID generated is : {CifNumber} ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        string senderEmail = "as1549yasas@gmail.com";
                        string recipientEmail = _client._Email;
                        string subject = "CIF Opening Confirmation";
                        string body = $"Dear {_client.FullName()}:\n Thank you for opening CIF with us.\nYour CIF Number is {CifNumber}";

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
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Error, Failed To Open Account.");
                }
                Cursor = Cursors.Default;
                DataBack?.Invoke(this, CifNumber);
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Make Sure All Fields Not Empty and Correct!");
            }


        }

        private void llSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.jfif;*.png;*.gif;*.bmp";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Process the selected file
                    string selectedFilePath = openFileDialog1.FileName;
                    //MessageBox.Show("Selected Image is:" + selectedFilePath);

                    roundPic2.Load(selectedFilePath);
                    llRemove.Visible = true;
                    // ...
                }
        }

        private void llRemove_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            roundPic2.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
            llRemove.Visible = false;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            SetClientInfo(ref _client);
        }

        private void CTBFirstName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBFirstName.Texts))
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(CTBFirstName, "Please enter Client's FirstName!");

            }
            else
            {
                //e.Cancel = true;
                //errorProvider.SetError(CTBFirstName, null);
                errorProvider.Clear();
                return;
            }
        }

        private void CTBLastName_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBLastName.Texts))
            {
                e.Cancel = true;
                CTBLastName.Focus();
                errorProvider.SetError(CTBLastName, "Please enter Client's LastName!");
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

        private void maskedTBPhone_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTBPhone.Text) || maskedTBPhone.Text == "+000 00-000-0000")
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(maskedTBPhone, "Phone Number required!");
                return;
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void CTBIncome_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBIncome.Texts))
            {
                e.Cancel = true;
                CTBIncome.Focus();
                errorProvider.SetError(CTBIncome, "This feild is required!");
                return;
            }
            else if (int.TryParse(CTBIncome.Texts, out int result) == false)
            {
                e.Cancel = true;
                CTBIncome.Focus();
                errorProvider.SetError(CTBIncome, "Only Numbers allowed!");
                return;
            }
            else if (Convert.ToDouble(CTBIncome.Texts) < 1000)
            {
                e.Cancel = true;
                CTBIncome.Focus();
                errorProvider.SetError(CTBIncome, "Income Must be not less than 1000!");
                //e.Cancel = true;
                //errorProvider.SetError(CTBFirstName, null);

            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void cbOccupationType_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbOccupationType.Text) || cbOccupationType.Text == "--SELECT--")
            {
                e.Cancel = true;
                cbOccupationType.Focus();
                errorProvider.SetError(cbOccupationType, "Select Occupation Type!");
                return;
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void cbCountry_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbCountry.Text) || cbCountry.Text == "--SELECT--")
            {
                e.Cancel = true;
                cbCountry.Focus();
                errorProvider.SetError(cbCountry, "Select Country!");
                return;
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void groupBox3_Validating_1(object sender, CancelEventArgs e)
        {
            if (rbFemale.Checked == false && rbMale.Checked == false)
            {
                e.Cancel = true;
                groupBox3.Focus();
                errorProvider.SetError(groupBox3, "Select Gender!");
                return;
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void DtpDateOfBirth_Validating_1(object sender, CancelEventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;

            // Reject dates in the future
            if (dateTimePicker.Value > DateTime.Now)
            {
                e.Cancel = true;
                dateTimePicker.Value = DateTime.Now; // Reset to current date
                MessageBox.Show("Future dates are not allowed.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(DtpDateOfBirth, "Future Date Not Accepted!");
                return;
            }

            // Reject ages less than 18 years
            DateTime today = DateTime.Today;
            int age = today.Year - dateTimePicker.Value.Year;
            if (dateTimePicker.Value > today.AddYears(-age))
                age--;

            if (age < 18)
            {
                e.Cancel = true;
                MessageBox.Show("Age must be 18 years or older.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(DtpDateOfBirth, "Age Must be 18 or older!");
                return;
            }
        }

        private void CTBEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBEmail.Texts))
            {
                e.Cancel = true;
                CTBEmail.Focus();
                errorProvider.SetError(CTBEmail, "Please enter Client's Email!");
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

        private void CTBAddress_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBAddress.Texts))
            {
                e.Cancel = true;
                CTBAddress.Focus();
                errorProvider.SetError(CTBAddress, "Please enter Client's Full Address!");
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

        private void cbIncomeType_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbIncomeType.Text) || cbIncomeType.Text == "--SELECT--")
            {
                e.Cancel = true;
                cbIncomeType.Focus();
                errorProvider.SetError(cbIncomeType, "Select Income type!");
                return;
            }
            else
            {
                errorProvider.Clear();
                return;
            }
        }

        private void groupBox1_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(CTBNationality.Texts)||CTBNationality.Texts== "Social Security Number" || CTBNationality.Texts== "Passport" || CTBNationality.Texts== "Driving License")
            {
                e.Cancel = true;
                CTBFirstName.Focus();
                errorProvider.SetError(groupBox1, "Please enter Client's ID Number!");
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

        private void CTBNationality_Enter_1(object sender, EventArgs e)
        {
            if (CTBNationality.Texts == "Passport Number" || CTBNationality.Texts == "Licence Number" || CTBNationality.Texts == "Social Security Number")
            {
                CTBNationality.Texts = "";
                CTBNationality.ForeColor = Color.Black;
            }
        }

        private void CTBNationality_Leave_1(object sender, EventArgs e)
        {
            if (CTBNationality.Texts == "" && rbPassport.Checked)
            {
                CTBNationality.Texts = "Passport Number";
                CTBNationality.ForeColor = Color.DarkGray;
            }
            else if (CTBNationality.Texts == "" && rbDrivingLicence.Checked)
            {
                CTBNationality.Texts = "Licence Number";
                CTBNationality.ForeColor = Color.DarkGray;
            }
            else if (CTBNationality.Texts == "" && rbSocialSecuritynumber.Checked)
            {
                CTBNationality.Texts = "Social Security Number";
                CTBNationality.ForeColor = Color.DarkGray;
            }
        }

        private void rbPassport_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbPassport.Checked)
            {
                CTBNationality.Texts = "Passport Number";
                CTBNationality.Enabled = true;
            }
        }

        private void rbSocialSecuritynumber_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbSocialSecuritynumber.Checked)
            {
                CTBNationality.Texts = "Social Security Number";
                CTBNationality.Enabled = true;
            }
        }

        private void rbDrivingLicence_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbDrivingLicence.Checked)
            {
                CTBNationality.Texts = "Licence Number";
                CTBNationality.Enabled = true;

            }
        }
    }
}



