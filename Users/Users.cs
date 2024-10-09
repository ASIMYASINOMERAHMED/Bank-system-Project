using Bank_System_Project.Properties;
using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankBusinessLayer.clsUser;

namespace Bank_System_Project
{
    public partial class Users : Form
    {
        clsUser _User = new clsUser();
        public Users()
        {
            InitializeComponent();
            _RefreshUserList(false);
       
        }
        static bool CheckAccessRights(clsUser.enMainMenuPermission permission, bool ShowMessage = true)
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
        private void _RefreshUserList(bool ShowMessage = true)
        {

            if (!CheckAccessRights(clsUser.enMainMenuPermission.pListEntireTableUsers, ShowMessage))
            {
                comboBoxFilter.SelectedIndex = 3;
                DGVUsers.DataSource = clsUser.GetShortDetailedEmployees();
                return;
            }
            comboBoxFilter.SelectedIndex = 0;
            DGVUsers.DataSource = clsUser.GetAllUsers();

        }
        int UserID = 0;
        private clsUser User = new clsUser();
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            UserID = Convert.ToInt32(CTBSearchUser.Texts);
            Cursor = Cursors.WaitCursor;
            User = clsUser.Find(UserID);
            if (User != null)
            {
                Cursor = Cursors.Default;

                tbSalary.Text = User._Salary.ToString();
                tbPhone.Text = User._Phone.ToString();
                tbPassword.Text = User._Password.ToString();
                tbFirstName.Text = User._FirstName.ToString();
                tbLastName.Text = User._LastName.ToString();
                tbEmail.Text = User._Email.ToString();
                tbDateOfBirth.Text = User._DateOfBirth.ToString();
                tbUserName.Text = User._UserName.ToString();
                lbPermissions.Text = User.GetPermissions(User);
                roundPic1.Load(User._ImagePath);

            }
            else
            {

                ResetFindUser();
                roundPic1.Image = Resources.PersonEmptyPhoto;
                lbNotFound.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbNotFound.Visible = false;
            }
            Cursor = Cursors.Default;
        }
        private void ResetFindUser()
        {
            tbSalary.Text = "";
            tbPhone.Text = "";
            tbPassword.Text = "";
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbDateOfBirth.Text = "";
            tbUserName.Text = "";
            lbPermissions.Text = "???";
        }
        private void ResetAddUser()
        {
            CTBEmail.Texts = "";
            CTBFirstName.Texts = "";
            CTBLastName.Texts = "";
            CTBPassword.Texts = "";
            CTBPhone.Texts = "";
            CTBSalary.Texts = "";
            CTBUserName.Texts = "";
            DtPTimPiker.Value = DateTime.Now;
            comboBoxCountries.Text = "Select";
            comboBoxDepartments.ForeColor = Color.DarkGray;
            comboBoxCountries.ForeColor = Color.DarkGray;
            roundPic2.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
            comboBoxDepartments.Text = "Select";
            cbAllPermissions.Checked = false;
            cbDeleteClient.Checked = false;
            cbAddClient.Checked = false;
            cbFindClient.Checked = false;
            cbLoginLog.Checked = false;
            cbManageUsers.Checked = false;
            cbShowClientList.Checked = false;
            cbTransactions.Checked = false;
            cbUpdateClient.Checked = false;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            CTBBonusPercentage.Texts = "0";


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetAddUser();
        }
        private clsUser User1 = new clsUser();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            User1._FirstName = CTBFirstName.Texts;
            User1._LastName = CTBLastName.Texts;
            User1._Email = CTBEmail.Texts;
            User1._Phone = CTBPhone.Texts;
            User1._Bonus = Convert.ToDouble(CTBBonusPercentage.Texts);
            User1._UserName = CTBUserName.Texts;
            User1._Password = CTBPassword.Texts;
            if (roundPic2.ImageLocation != null)
                User1._ImagePath = roundPic2.ImageLocation;
            else
                User1._ImagePath = @"C:\Resources\PersonEmptyPhoto.jfif";
            User1._DateOfBirth = DtPTimPiker.Value;
            User1._HireDate = DTPHireDate.Value;

            User1._Salary = Convert.ToDouble(CTBSalary.Texts);
            if (radioButtonMale.Checked)
                User1._Gendor = "M";
            else
                User1._Gendor = "F";
            User1._ExitDate = DateTime.MinValue;
            User1._DepartmentID = comboBoxDepartments.SelectedIndex + 1;
            User1._CountryID = comboBoxCountries.SelectedIndex + 1;
            User1._Permissions = GetPermissions();
            if (User1.Save())
            {
                Cursor = Cursors.Default;
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Saved Succssfully.");
            }
            else
            {
                Cursor = Cursors.Default;
                SystemSounds.Hand.Play();
                MessageBox.Show("Error, User Not Saved");
            }

            ResetAddUser();
            tabControl1.SelectedIndex = 0;

        }

        private void CTBBonusPercentage_Enter(object sender, EventArgs e)
        {
            if (CTBBonusPercentage.Texts == "0")
            {
                CTBBonusPercentage.Texts = "";
            }
            CTBBonusPercentage.ForeColor = Color.Black;
        }

        private void CTBBonusPercentage_Leave(object sender, EventArgs e)
        {
            if (CTBBonusPercentage.Texts == "")
            {
                CTBBonusPercentage.Texts = "0";
            }
            CTBBonusPercentage.ForeColor = Color.DarkGray;
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if (comboBoxDepartments.Text == "Select")
                comboBoxDepartments.Text = "";
        }

        private void comboBoxDepartments_Leave(object sender, EventArgs e)
        {
            if (comboBoxDepartments.Text == "")
            {
                comboBoxDepartments.Text = "Select";
                comboBoxDepartments.ForeColor = Color.DarkGray;
            }
            if (comboBoxDepartments.Text != "Select")
                comboBoxDepartments.ForeColor = Color.Black;
        }

        private void comboBoxCountries_Enter(object sender, EventArgs e)
        {
            if (comboBoxCountries.Text == "Select")
                comboBoxCountries.Text = "";

        }

        private void comboBoxCountries_Leave(object sender, EventArgs e)
        {
            if (comboBoxCountries.Text == "")
            {
                comboBoxCountries.Text = "Select";
                comboBoxCountries.ForeColor = Color.DarkGray;
            }
            if (comboBoxCountries.Text != "Select")
                comboBoxCountries.ForeColor = Color.Black;
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                linkLabelRemove.Visible = true;
                // ...
            }
        }

        private void linkLabelRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            roundPic2.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
            linkLabelRemove.Visible = false;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            UserID = Convert.ToInt32(ctbUserID.Texts);
            Cursor = Cursors.WaitCursor;
            User = clsUser.Find(UserID);
            if (User != null)
            {
                Cursor = Cursors.Default;
                customTextBoxSalary.Texts = User._Salary.ToString();
                customTextBoxPhone.Texts = User._Phone.ToString();
                customTextBoxPassword.Texts = User._Password.ToString();
                customTextBoxFirstName.Texts = User._FirstName.ToString();
                customTextBoxLastName.Texts = User._LastName.ToString();
                customTextBoxEmail.Texts = User._Email.ToString();
                DtphiringDate.Value = User._HireDate;
                dtpretireDate.Value = User._ExitDate;
                DtpBirthDate.Value = User._DateOfBirth;
                customTextBoxUserName.Texts = User._UserName.ToString();
                roundPic3.Load(User._ImagePath);
                if (User._Gendor == "M")
                    radioButtonGuy.Checked = true;
                else
                    radioButtonGirl.Checked = true;
                customTextBoxbonus.Texts = User._Bonus.ToString();
                comboBoxDepartmentt.SelectedIndex = User._DepartmentID - 1;
                comboBoxCountryy.SelectedIndex = User._CountryID - 1;
                GetPermissionsToUpdate(User);

                DtphiringDate.Enabled = true;
                DtpBirthDate.Enabled = true;
                dtpretireDate.Enabled = true;
                customTextBoxUserName.Enabled = true;
                radioButtonGuy.Enabled = true;
                radioButtonGirl.Enabled = true;
                customTextBoxbonus.Enabled = true;
                comboBoxDepartmentt.Enabled = true;
                comboBoxCountryy.Enabled = true;
                customTextBoxSalary.Enabled = true;
                customTextBoxPhone.Enabled = true;
                customTextBoxPassword.Enabled = true;
                customTextBoxFirstName.Enabled = true;
                customTextBoxLastName.Enabled = true;
                customTextBoxEmail.Enabled = true;
                linkLabelSetImageUpdate.Enabled = true;
                btnCancell.Enabled = true;
                btnSaveUpdate.Enabled = true;
                groupBox2.Enabled = true;


            }
            else
            {

                lbNotFoundUpdate.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbNotFoundUpdate.Visible = false;
            }
            Cursor = Cursors.Default;
        }

        private void linkLabelSetImageUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.jfif;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                roundPic3.Load(selectedFilePath);
                linkLabelRemoveUpdate.Visible = true;
                // ...
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            roundPic3.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
            linkLabelRemove.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customTextBoxSalary.Texts = User._Salary.ToString();
            customTextBoxPhone.Texts = User._Phone.ToString();
            customTextBoxPassword.Texts = User._Password.ToString();
            customTextBoxFirstName.Texts = User._FirstName.ToString();
            customTextBoxLastName.Texts = User._LastName.ToString();
            customTextBoxEmail.Texts = User._Email.ToString();
            DtphiringDate.Value = User._HireDate;
            dtpretireDate.Value = User._ExitDate;
            DtpBirthDate.Value = User._DateOfBirth;
            customTextBoxUserName.Texts = User._UserName.ToString();
            roundPic3.Load(User._ImagePath);
            if (User._Gendor == "M")
                radioButtonGuy.Checked = true;
            else
                radioButtonGirl.Checked = true;
            customTextBoxbonus.Texts = User._Bonus.ToString();
            comboBoxDepartmentt.SelectedIndex = User._DepartmentID - 1;
            comboBoxCountryy.SelectedIndex = User._CountryID - 1;
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            User._FirstName = customTextBoxFirstName.Texts;
            User._LastName = customTextBoxLastName.Texts;
            User._Email = customTextBoxEmail.Texts;
            User._Phone = customTextBoxPhone.Texts;
            User._Bonus = Convert.ToDouble(customTextBoxbonus.Texts);
            User._UserName = customTextBoxUserName.Texts;
            User._Password = customTextBoxPassword.Texts;
            if (roundPic3.ImageLocation != null)
                User._ImagePath = roundPic3.ImageLocation;
            else
                User._ImagePath = @"C:\Resources\PersonEmptyPhoto.jfif";
            User._DateOfBirth = DtpBirthDate.Value;
            User._HireDate = DtphiringDate.Value;

            User._Salary = Convert.ToDouble(customTextBoxSalary.Texts);
            if (radioButtonGuy.Checked)
                User._Gendor = "M";
            else
                User._Gendor = "F";
            User._ExitDate = dtpretireDate.Value;
            User._DepartmentID = comboBoxDepartmentt.SelectedIndex + 1;
            User._CountryID = comboBoxCountryy.SelectedIndex + 1;
            User._Permissions = GetUpdatePermissions();
            if (User.Save())
            {
                Cursor = Cursors.Default;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Updated Succssfully.");
            }
            else
            {
                Cursor = Cursors.Default;
                SystemSounds.Hand.Play();
                MessageBox.Show("Error, User Not Updated");
            }

            ResetUpdateUser();
            tabControl1.SelectedIndex = 0;
        }
        private void ResetUpdateUser()
        {
            ctbUserID.Texts = "";
            customTextBoxSalary.Texts = "";
            customTextBoxPhone.Texts = "";
            customTextBoxPassword.Texts = "";
            customTextBoxFirstName.Texts = "";
            customTextBoxLastName.Texts = "";
            customTextBoxEmail.Texts = "";
            DtphiringDate.Value = DateTime.Now;
            dtpretireDate.Value = DateTime.Now;
            DtpBirthDate.Value = DateTime.Now;
            customTextBoxUserName.Texts = "";
            roundPic3.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
            radioButtonGuy.Checked = false;
            radioButtonGirl.Checked = false;
            customTextBoxbonus.Texts = "0";
            comboBoxDepartmentt.Text = "";
            comboBoxCountryy.Text = "";
            checkBoxAll.Checked = false;
            checkBoxShowClientList.Checked = false;
            checkBoxFindClient.Checked = false;
            checkBoxAddClient.Checked = false;
            checkBoxUpdate.Checked = false;
            checkBoxDeleteClient.Checked = false;
            checkBoxManageUsers.Checked = false;
            checkBoxTransactions.Checked = false;
            checkBoxLoginLog.Checked = false;
            checkBoxListAllUsers.Checked = false;
            groupBox2.Enabled = false;

            DtphiringDate.Enabled = false;
            DtpBirthDate.Enabled = false;
            dtpretireDate.Enabled = false;
            customTextBoxUserName.Enabled = false;
            radioButtonGuy.Enabled = false;
            radioButtonGirl.Enabled = false;
            customTextBoxbonus.Enabled = false;
            comboBoxDepartmentt.Enabled = false;
            comboBoxCountryy.Enabled = false;
            customTextBoxSalary.Enabled = false;
            customTextBoxPhone.Enabled = false;
            customTextBoxPassword.Enabled = false;
            customTextBoxFirstName.Enabled = false;
            customTextBoxLastName.Enabled = false;
            customTextBoxEmail.Enabled = false;
            linkLabelSetImageUpdate.Enabled = false;
            btnCancell.Enabled = false;
            btnSaveUpdate.Enabled = false;
        }
        private int GetUpdatePermissions()
        {
            int Permissions = 0;
            if (checkBoxAll.Checked)
                return -1;
            if (checkBoxManageUsers.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pManageUsers;
            if (checkBoxListAllUsers.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pListEntireTableUsers;
            if (checkBoxTransactions.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pTransactions;
            if (checkBoxLoginLog.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pLoginRegister;
            if (checkBoxShowClientList.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pListClients;
            if (checkBoxAddClient.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pAddNewClient;
            if (checkBoxDeleteClient.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pDeleteClient;
            if (checkBoxUpdate.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pUpdateClients;
            if (checkBoxFindClient.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pFindClient;

            return Permissions;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
            {
                _RefreshUserList();
            }
            else if (comboBoxFilter.SelectedIndex == 1)
            {
                DGVUsers.DataSource = GetTop10HighSalaries();
            }
            else if (comboBoxFilter.SelectedIndex == 2)
            {
                DGVUsers.DataSource = GetTopLowestSalaries();
            }
            else if (comboBoxFilter.SelectedIndex == 3)
            {
                DGVUsers.DataSource = GetShortDetailedEmployees();
            }
            else if (comboBoxFilter.SelectedIndex == 4)
            {
                DGVUsers.DataSource = GetActiveEmployees();
                // DGVUsers.Columns[7].DefaultCellStyle.BackColor = Color.Green;
          
            }
            else if (comboBoxFilter.SelectedIndex == 5)
            {
                DGVUsers.DataSource = GetRetiredEmployees();
               // DGVUsers.Columns[7].DefaultCellStyle.BackColor = Color.Orange;
            }
            else if (comboBoxFilter.SelectedIndex == 6)
            {
                DGVUsers.DataSource = GetFemalesEmployees();
            }
            else if (comboBoxFilter.SelectedIndex == 7)
            {
                DGVUsers.DataSource = GetMalesEmployees();
            }
        }

        private async void btnSerchDelete_Click(object sender, EventArgs e)
        {
            if (customTextBoxFind.Texts == "")
                return;
            UserID = Convert.ToInt32(customTextBoxFind.Texts);
            Cursor = Cursors.WaitCursor;
            User = clsUser.Find(UserID);
            if (User != null)
            {
                Cursor = Cursors.Default;
                labelSalary.Text = User._Salary.ToString();
                labelPhone.Text = User._Phone.ToString();
                labelPassword.Text = User._Password.ToString();
                labelFirstName.Text = User._FirstName.ToString();
                labelLastName.Text = User._LastName.ToString();
                labelEmail.Text = User._Email.ToString();
                DTPbornDate.Value = User._DateOfBirth;
                labelUserName.Text = User._UserName.ToString();
                lbPermissionsDelete.Text = User.GetPermissions(User);

                roundPic4.Load(User._ImagePath);
                btnDelete.Enabled = true;
                btnCancelDelete.Enabled = true;

            }
            else
            {
                Cursor = Cursors.Default;
                ResetDeleteScreen();

                labelNotFound.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                labelNotFound.Visible = false;
            }
        }
        private void ResetDeleteScreen()
        {
            labelUserName.Text = "???";
            labelSalary.Text = "???";
            labelEmail.Text = "???";
            labelFirstName.Text = "???";
            labelLastName.Text = "???";
            labelPhone.Text = "???";
            labelPassword.Text = "???";
            lbPermissionsDelete.Text = "???";
            DTPbornDate.Value = DateTime.Now;
            btnDelete.Enabled = false;
            btnCancelDelete.Enabled = false;

            roundPic4.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete it?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (DeleteUser(User._UserName))
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("User Deleted Succssffully.");
                    ResetDeleteScreen();
                    tabControl1.SelectedIndex = 0;
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Unable To Delete User.");
                }
            }
            else
            {
                return;
            }
        }

        private void btnCancelDelete_Click(object sender, EventArgs e)
        {
            ResetDeleteScreen();
        }
        private int GetPermissions()
        {
            int Permissions = 0;
            if (cbAllPermissions.Checked)
                return -1;
            if (cbManageUsers.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pManageUsers;
            if (cbListUsers.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pListEntireTableUsers;
            if (cbTransactions.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pTransactions;
            if (cbLoginLog.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pLoginRegister;
            if (cbShowClientList.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pListClients;
            if (cbAddClient.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pAddNewClient;
            if (cbDeleteClient.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pDeleteClient;
            if (cbUpdateClient.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pUpdateClients;
            if (cbFindClient.Checked)
                Permissions += (int)clsUser.enMainMenuPermission.pFindClient;

            return Permissions;
        }
        static bool CheckAccessRights(enMainMenuPermission permission,clsUser User)
        {
            if (!User.CheckAccessPermission(permission))
            {
                return false;
            }
            else
                return true;
        }
        private void GetPermissionsToUpdate(clsUser User)
        {
            if (User._Permissions == -1)
                checkBoxAll.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pManageUsers, User))
                checkBoxManageUsers.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pListEntireTableUsers, User))
                checkBoxListAllUsers.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pTransactions, User))
                checkBoxTransactions.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pLoginRegister, User))
                checkBoxLoginLog.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pListClients, User))
               checkBoxShowClientList.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pAddNewClient, User))
                checkBoxAddClient.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pDeleteClient, User))
                checkBoxDeleteClient.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pUpdateClients, User))
                checkBoxUpdate.Checked = true;
            if (CheckAccessRights(enMainMenuPermission.pFindClient, User))
                checkBoxFindClient.Checked = true;

        }

        private string _TransferFile = @"F:\TransferRegister.txt";
        private DataTable _FillDGVFromTransferFile()
        {
            string[] rows = System.IO.File.ReadAllLines(_TransferFile);
            string[] separator = new string[] { "#//#" };
            DataTable dt = new DataTable(_TransferFile);
            if (rows.Length != 0)
            {
                foreach (string headerCol in rows[0].Split(separator, StringSplitOptions.None))
                {
                    dt.Columns.Add(new DataColumn(headerCol));
                }
                if (rows.Length > 1)
                {
                    for (int i = 1; i < rows.Length; i++)
                    {
                        var newRow = dt.NewRow();
                        var cols = rows[i].Split(separator, StringSplitOptions.None);
                        for (int j = 0; j < cols.Length; j++)
                        {
                            newRow[j] = cols[j];
                        }
                        dt.Rows.Add(newRow);
                    }
                }

            }
            return dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex ==5 ) 
            {
                DGVTransfers.DataSource = _FillDGVFromTransferFile();
            }
        }

        private void cbAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAllPermissions.Checked == true) 
            {
                cbShowClientList.Checked = true;
                cbFindClient.Checked = true;
                cbAddClient.Checked = true;
                cbDeleteClient.Checked = true;
                cbUpdateClient.Checked = true;
                cbManageUsers.Checked = true;
                cbTransactions.Checked = true;
                cbLoginLog.Checked = true;
                cbListUsers.Checked = true;

            }
            else
            {
                cbShowClientList.Checked = false;
                cbFindClient.Checked = false;
                cbAddClient.Checked = false;
                cbDeleteClient.Checked = false;
                cbUpdateClient.Checked = false;
                cbManageUsers.Checked = false;
                cbTransactions.Checked = false;
                cbLoginLog.Checked = false;
                cbListUsers.Checked = false;
            }
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxAll.Checked == true)
            {
                checkBoxShowClientList.Checked = true;
                checkBoxFindClient.Checked = true;
                checkBoxAddClient.Checked = true;
                checkBoxUpdate.Checked = true;
                checkBoxDeleteClient.Checked = true;
                checkBoxManageUsers.Checked = true;
                checkBoxTransactions.Checked = true;
                checkBoxLoginLog.Checked = true;
                checkBoxListAllUsers.Checked = true;
            }
            else
            {
                checkBoxShowClientList.Checked = false;
                checkBoxFindClient.Checked = false;
                checkBoxAddClient.Checked = false;
                checkBoxUpdate.Checked = false;
                checkBoxDeleteClient.Checked = false;
                checkBoxManageUsers.Checked = false;
                checkBoxTransactions.Checked = false;
                checkBoxLoginLog.Checked = false;
                checkBoxListAllUsers.Checked = false;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)DGVUsers.CurrentRow.Cells[0].Value;
            tabControl1.SelectedIndex = 3;
            ctbUserID.Texts = ID.ToString();
            buttonSerch.PerformClick();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete it?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (DeleteUser((int)DGVUsers.CurrentRow.Cells[0].Value))
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("User Deleted Succssffully.");
                    _RefreshUserList();
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Unable To Delete User.");
                }
            }
            else
            {
                return;
            }
        }
    }


}
