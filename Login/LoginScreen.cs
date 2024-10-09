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
using Bank_System_Project.Properties;
using BankBusinessLayer;

namespace Bank_System_Project
{
    public partial class LoginScreenBar : Form
    {
        
        public LoginScreenBar()
        {
            InitializeComponent();
            btnLogin.Focus();
        }
        string UserName = "",Password = "";
        int FailedLoginCount = 0;

  

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      



    
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red; 
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void customTextBox1_Enter(object sender, EventArgs e)
        {
            if (CTextBoxUserName.Texts == "UserName")
                CTextBoxUserName.Texts = "";
            CTextBoxUserName.ForeColor = Color.Black;
        }

        private void customTextBox1_Leave(object sender, EventArgs e)
        {
            if (CTextBoxUserName.Texts == "")
                CTextBoxUserName.Texts = "UserName";
            CTextBoxUserName.ForeColor = Color.DarkGray;
        }

        private void CTextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (CTextBoxPassword.Texts == "Password")
            {
                CTextBoxPassword.Texts = "";
                CTextBoxPassword.PasswordChar = true;
            }
            CTextBoxPassword.ForeColor = Color.Black;
        }

        private void CTextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (CTextBoxPassword.Texts == "")
            {
                CTextBoxPassword.PasswordChar = false;
                CTextBoxPassword.Texts = "Password";
            }
            CTextBoxPassword.ForeColor = Color.DarkGray;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (CTextBoxUserName.Texts == "UserName" || CTextBoxPassword.Texts == "Password")
            {
                lbError.Text = "Enter UserName And Password!";
                lbError.Visible = true;
                SystemSounds.Hand.Play();
                Cursor = Cursors.Default;
                await Task.Delay(1500);
                lbError.Visible = false;
                return;
            } 

          
            UserName = CTextBoxUserName.Texts;
            Password = CTextBoxPassword.Texts;
            clsUser User =  clsUser.Find(UserName, Password);
            clsUser.CurrentUser = User;
            clsGlobal.CurrentUser = User;
            if (User != null) 
            {
                this.Visible = false;
                clsGlobal.RegisterLogIn();
              

                Form main = new frmMainForm(User);
                main.ShowDialog();
                Cursor = Cursors.Default;
                FailedLoginCount = 0;
                CTextBoxUserName.Texts = "UserName";
                CTextBoxPassword.Texts = "Password";
             


            }
            else
            {
                Cursor = Cursors.Default;
                lbError.Text = "invalid UserName/Password !";
                lbError.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbError.Visible = false;
                FailedLoginCount++;
                
                if(FailedLoginCount == 3) 
                {
                
                    MessageBox.Show("YOU ARE LOCKED AFTER 3 FAILED TRAILS","Warning",MessageBoxButtons.OK,MessageBoxIcon.Question);
              
                    CTextBoxPassword.Enabled = false;
                    CTextBoxUserName.Enabled = false;
                    btnLogin.Enabled = false;
                }
              
            }
          
           
        }

        bool ExpandLoginScreen = false;

        private void ResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Not implemented yet
        }
        public void ChangeSize(int width, int height)
        {
            this.ClientSize = new Size(width, height);
        }

        private void CTextBoxPassword__TextChanged(object sender, EventArgs e)
        {
            if(CTextBoxPassword.Texts !="" && CTextBoxPassword.Texts != "Password")
                button3.Visible = true;
            else
                button3.Visible = false;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            if (button4.Focus())
            {
                if (CTextBoxPassword.PasswordChar == true)
                {

                    button3.BackgroundImage = Resources.eyeClose_removebg_preview;
                    CTextBoxPassword.PasswordChar = false;

                }
                else
                {
                    button3.BackgroundImage = null;
                    button3.BackgroundImage = Resources.eyePassword_removebg_preview;
                    CTextBoxPassword.PasswordChar = true;
                }
            }
           
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            if (button4.Focus())
            {
                if (CTextBoxPassword.PasswordChar == true)
                {

                    button3.BackgroundImage = Resources.eyeClose_removebg_preview;
                    CTextBoxPassword.PasswordChar = false;

                }
                else
                {
                    button3.BackgroundImage = null;
                    button3.BackgroundImage = Resources.eyePassword_removebg_preview;
                    CTextBoxPassword.PasswordChar = true;
                }
            }
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            button3.BackColor = this.BackColor;
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = this.BackColor;
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

        private void LoginScreenExpand_Tick(object sender, EventArgs e)
        {
            int Height, Width;
            if (ExpandLoginScreen)
            {
                Height = 1637;
                Width = 731;
                ChangeSize(Height, Width);
                Width -= 10;
                Height -= 10;
                if (Width == 731&&Height==1173)
                {
                    ExpandLoginScreen = false;
                    LoginScreenTimer.Stop();
                }

            }
            else
            {

                Height = 1173;
                Width = 731;
                ChangeSize(Height, Width);
                Width += 10;
                Height += 10;
                if (Width == 731 && Height == 1637)
                {
                    ExpandLoginScreen = false;
                    LoginScreenTimer.Stop();
                }
            }
        }

       
    }
}
