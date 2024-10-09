namespace Bank_System_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCorporateBanking = new System.Windows.Forms.Button();
            this.btnFinancing = new System.Windows.Forms.Button();
            this.btnTreasury = new System.Windows.Forms.Button();
            this.btnInvestment = new System.Windows.Forms.Button();
            this.btnTradeFinance = new System.Windows.Forms.Button();
            this.btnAccounting = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnSupportApp = new System.Windows.Forms.Button();
            this.btnOtherApp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1544, 72);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = global::Bank_System_Project.Properties.Resources.People_641;
            this.usersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(171, 68);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsToolStripMenuItem.Image = global::Bank_System_Project.Properties.Resources.account_settings_64;
            this.accountSettingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(318, 68);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::Bank_System_Project.Properties.Resources.User_32__2;
            this.currentUserInfoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentUserInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(477, 46);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::Bank_System_Project.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(477, 46);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::Bank_System_Project.Properties.Resources.sign_out_32__2;
            this.signOutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(477, 46);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1544, 830);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCorporateBanking
            // 
            this.btnCorporateBanking.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCorporateBanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorporateBanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorporateBanking.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCorporateBanking.Location = new System.Drawing.Point(147, 157);
            this.btnCorporateBanking.Name = "btnCorporateBanking";
            this.btnCorporateBanking.Size = new System.Drawing.Size(385, 120);
            this.btnCorporateBanking.TabIndex = 3;
            this.btnCorporateBanking.Text = "Retail && Corporate Banking";
            this.btnCorporateBanking.UseVisualStyleBackColor = false;
            this.btnCorporateBanking.Click += new System.EventHandler(this.btnCorporateBanking_Click);
            // 
            // btnFinancing
            // 
            this.btnFinancing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFinancing.BackColor = System.Drawing.Color.SkyBlue;
            this.btnFinancing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinancing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancing.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFinancing.Location = new System.Drawing.Point(603, 157);
            this.btnFinancing.Name = "btnFinancing";
            this.btnFinancing.Size = new System.Drawing.Size(385, 120);
            this.btnFinancing.TabIndex = 4;
            this.btnFinancing.Text = "Financing && Collection";
            this.btnFinancing.UseVisualStyleBackColor = false;
            this.btnFinancing.Click += new System.EventHandler(this.btnFinancing_Click);
            // 
            // btnTreasury
            // 
            this.btnTreasury.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTreasury.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTreasury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreasury.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreasury.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTreasury.Location = new System.Drawing.Point(1059, 157);
            this.btnTreasury.Name = "btnTreasury";
            this.btnTreasury.Size = new System.Drawing.Size(385, 120);
            this.btnTreasury.TabIndex = 5;
            this.btnTreasury.Text = "Treasury";
            this.btnTreasury.UseVisualStyleBackColor = false;
            this.btnTreasury.Click += new System.EventHandler(this.btnTreasury_Click);
            // 
            // btnInvestment
            // 
            this.btnInvestment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInvestment.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInvestment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvestment.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnInvestment.Location = new System.Drawing.Point(147, 364);
            this.btnInvestment.Name = "btnInvestment";
            this.btnInvestment.Size = new System.Drawing.Size(385, 120);
            this.btnInvestment.TabIndex = 6;
            this.btnInvestment.Text = "Investment";
            this.btnInvestment.UseVisualStyleBackColor = false;
            this.btnInvestment.Click += new System.EventHandler(this.btnInvestment_Click);
            // 
            // btnTradeFinance
            // 
            this.btnTradeFinance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTradeFinance.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTradeFinance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTradeFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTradeFinance.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnTradeFinance.Location = new System.Drawing.Point(603, 364);
            this.btnTradeFinance.Name = "btnTradeFinance";
            this.btnTradeFinance.Size = new System.Drawing.Size(385, 120);
            this.btnTradeFinance.TabIndex = 7;
            this.btnTradeFinance.Text = "Trade Finance";
            this.btnTradeFinance.UseVisualStyleBackColor = false;
            this.btnTradeFinance.Click += new System.EventHandler(this.btnTradeFinance_Click);
            // 
            // btnAccounting
            // 
            this.btnAccounting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAccounting.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAccounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounting.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAccounting.Location = new System.Drawing.Point(1059, 364);
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Size = new System.Drawing.Size(385, 120);
            this.btnAccounting.TabIndex = 8;
            this.btnAccounting.Text = "Fin. Accounting && Processing";
            this.btnAccounting.UseVisualStyleBackColor = false;
            this.btnAccounting.Click += new System.EventHandler(this.btnAccounting_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReporting.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporting.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnReporting.Location = new System.Drawing.Point(147, 571);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Size = new System.Drawing.Size(385, 120);
            this.btnReporting.TabIndex = 9;
            this.btnReporting.Text = "Corp. && Reg. Reporting";
            this.btnReporting.UseVisualStyleBackColor = false;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // btnSupportApp
            // 
            this.btnSupportApp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSupportApp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSupportApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupportApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupportApp.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSupportApp.Location = new System.Drawing.Point(603, 571);
            this.btnSupportApp.Name = "btnSupportApp";
            this.btnSupportApp.Size = new System.Drawing.Size(385, 120);
            this.btnSupportApp.TabIndex = 10;
            this.btnSupportApp.Text = "Support Applications";
            this.btnSupportApp.UseVisualStyleBackColor = false;
            this.btnSupportApp.Click += new System.EventHandler(this.btnSupportApp_Click);
            // 
            // btnOtherApp
            // 
            this.btnOtherApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOtherApp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOtherApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherApp.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnOtherApp.Location = new System.Drawing.Point(1059, 571);
            this.btnOtherApp.Name = "btnOtherApp";
            this.btnOtherApp.Size = new System.Drawing.Size(385, 120);
            this.btnOtherApp.TabIndex = 11;
            this.btnOtherApp.Text = "Other Applications";
            this.btnOtherApp.UseVisualStyleBackColor = false;
            this.btnOtherApp.Click += new System.EventHandler(this.btnOtherApp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1544, 830);
            this.Controls.Add(this.btnOtherApp);
            this.Controls.Add(this.btnSupportApp);
            this.Controls.Add(this.btnReporting);
            this.Controls.Add(this.btnAccounting);
            this.Controls.Add(this.btnTradeFinance);
            this.Controls.Add(this.btnInvestment);
            this.Controls.Add(this.btnTreasury);
            this.Controls.Add(this.btnFinancing);
            this.Controls.Add(this.btnCorporateBanking);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCorporateBanking;
        private System.Windows.Forms.Button btnFinancing;
        private System.Windows.Forms.Button btnTreasury;
        private System.Windows.Forms.Button btnInvestment;
        private System.Windows.Forms.Button btnTradeFinance;
        private System.Windows.Forms.Button btnAccounting;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Button btnSupportApp;
        private System.Windows.Forms.Button btnOtherApp;
    }
}