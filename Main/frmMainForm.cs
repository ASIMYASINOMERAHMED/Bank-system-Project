using Bank_System_Project.Properties;
using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bank_System_Project
{
    public partial class frmMainForm : Form
    {
       
        public frmMainForm(clsUser User)
        {
            InitializeComponent();
            timerTime.Start();
            roundPicPerson.Load(User._ImagePath);
            lbName.Text = User.FullName()+ " (" + User._Position + ")";
         
           
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginScreenBar loginScreenBar = new LoginScreenBar();
            loginScreenBar.Visible = true;
        }

        private void Dashboard_Load(object Form)
        {
            if(this.mainPanel.Controls.Count > 0) 
                this.mainPanel.Controls.RemoveAt(0);
            Form frm = Form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frm);
            frm.Show();
        }
        static bool CheckAccessRights(clsUser.enMainMenuPermission permission)
        {
            if(!clsUser.CurrentUser.CheckAccessPermission(permission))
            {
                System.Media.SystemSounds.Exclamation.Play();
                MessageBox.Show("Access Denied! Contact Your Admin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return false;
            }
            else
                return true;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard_Load(new frmDashboard());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRights(clsUser.enMainMenuPermission.pManageUsers))
            {
                return;
            }
            Cursor = Cursors.AppStarting;
            Dashboard_Load(new Users());
            Cursor = Cursors.Default;
        }

        private void btnClients_Click(object sender, EventArgs e)
        { 
            Cursor = Cursors.AppStarting;
            Dashboard_Load(new Clients());
            Cursor = Cursors.Default;
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
           
            if (!CheckAccessRights(clsUser.enMainMenuPermission.pTransactions))
            {
                return;
            }
            if (clsUser.CurrentUser._UserName == "Authorize")
            {
                Dashboard_Load(new AuthorizeForm());
            }
            else
                Dashboard_Load(new Transactions());
        }

        private void btnLoginLog_Click(object sender, EventArgs e)
        {
            if (!CheckAccessRights(clsUser.enMainMenuPermission.pLoginRegister))
            {
                return;
            }
            Dashboard_Load(new frmLoginLog());
        }

      
        private void btnProfile_Click(object sender, EventArgs e)
        {
            Dashboard_Load(new frmProfile(clsUser.CurrentUser));
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Dashboard_Load(new frmDashboard());

        
        }

        bool SideBarExpand = false;
        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if(SideBarExpand)
            {
               
                SideBar.Width -= 10;
                if (SideBar.Width==SideBar.MinimumSize.Width)
                {
                    labelMenu.Visible = false;
                
                    SideBarExpand = false;
                    SideBarTimer.Stop();
                }
              
            }
            else
            {
            
                SideBar.Width += 10;
           
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    labelMenu.Visible = true;
         
                    SideBarExpand = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

            //if (SideBar.Size == SideBar.MaximumSize)
            //{
            //    labelMenu.Visible = false;
            //    label2.Visible = false;
            //    pictureBox3.Visible = false;
            //    panel11.Size = panel11.MinimumSize;
            //    SideBar.Size = SideBar.MinimumSize;
            //}
            //else
            //{
            //    labelMenu.Visible = true;
            //    label2.Visible = true;
            //    pictureBox3.Visible = true;
            //    panel11.Size = panel11.MaximumSize;
            //    SideBar.Size = SideBar.MaximumSize;
            //}
            SideBarTimer.Start();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.LightSkyBlue;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = panel2.BackColor;
        }

        private void btnUsers_MouseEnter(object sender, EventArgs e)
        {
            btnUsers.BackColor = Color.LightSkyBlue;
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnUsers.BackColor = panel2.BackColor;
        }

        private void btnClients_MouseEnter(object sender, EventArgs e)
        {
            btnClients.BackColor = Color.LightSkyBlue;
        }

        private void btnClients_MouseLeave(object sender, EventArgs e)
        {
            btnClients.BackColor = panel2.BackColor;
        }

        private void btnTransactions_MouseEnter(object sender, EventArgs e)
        {
            btnTransactions.BackColor = Color.LightSkyBlue;
        }

        private void btnTransactions_MouseLeave(object sender, EventArgs e)
        {
            btnTransactions.BackColor= panel2.BackColor;
        }

        private void btnLoginLog_MouseEnter(object sender, EventArgs e)
        {
            btnLoginLog.BackColor = Color.LightSkyBlue;
        }

        private void btnLoginLog_MouseLeave(object sender, EventArgs e)
        {
            btnLoginLog.BackColor = panel2.BackColor;
        }

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile.BackColor = Color.LightSkyBlue;
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.BackColor= panel2.BackColor;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.LightSkyBlue;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = panel2.BackColor;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseEnter_1(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave_1(object sender, EventArgs e)
        {
            btnClose.BackColor = SystemColors.Highlight;
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  
            _start_point = new Point(e.X, e.Y);
        }

        private void panel10_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Minimized)
            //{
            //   waitForm.WindowState = FormWindowState.Minimized;
        
            //}
            //else if (WindowState == FormWindowState.Normal)
            //{
            //    GlobalWaitForm.waitForm.WindowState = FormWindowState.Normal;
 
            //}
        }

      
    }
}
