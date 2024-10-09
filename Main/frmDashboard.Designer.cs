namespace Bank_System_Project
{
    partial class frmDashboard
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
            this.lbUsersCount = new System.Windows.Forms.Label();
            this.lbClientsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dashboardpanel = new System.Windows.Forms.Panel();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dashboardpanel.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUsersCount
            // 
            this.lbUsersCount.AutoSize = true;
            this.lbUsersCount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbUsersCount.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsersCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUsersCount.Location = new System.Drawing.Point(185, 327);
            this.lbUsersCount.Name = "lbUsersCount";
            this.lbUsersCount.Size = new System.Drawing.Size(34, 39);
            this.lbUsersCount.TabIndex = 69;
            this.lbUsersCount.Text = "0";
            // 
            // lbClientsCount
            // 
            this.lbClientsCount.AutoSize = true;
            this.lbClientsCount.BackColor = System.Drawing.Color.SteelBlue;
            this.lbClientsCount.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientsCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lbClientsCount.Location = new System.Drawing.Point(660, 327);
            this.lbClientsCount.Name = "lbClientsCount";
            this.lbClientsCount.Size = new System.Drawing.Size(34, 39);
            this.lbClientsCount.TabIndex = 71;
            this.lbClientsCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(269, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 39);
            this.label2.TabIndex = 73;
            this.label2.Text = "Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(752, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 74;
            this.label1.Text = "Clients";
            // 
            // Dashboardpanel
            // 
            this.Dashboardpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboardpanel.Controls.Add(this.panelDisplay);
            this.Dashboardpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dashboardpanel.Location = new System.Drawing.Point(0, 0);
            this.Dashboardpanel.Name = "Dashboardpanel";
            this.Dashboardpanel.Size = new System.Drawing.Size(1297, 846);
            this.Dashboardpanel.TabIndex = 77;
            // 
            // panelDisplay
            // 
            this.panelDisplay.AutoScroll = true;
            this.panelDisplay.BackColor = System.Drawing.Color.Transparent;
            this.panelDisplay.Controls.Add(this.lbUsersCount);
            this.panelDisplay.Controls.Add(this.label2);
            this.panelDisplay.Controls.Add(this.lbClientsCount);
            this.panelDisplay.Controls.Add(this.label1);
            this.panelDisplay.Controls.Add(this.pictureBox2);
            this.panelDisplay.Controls.Add(this.pictureBox1);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(1297, 846);
            this.panelDisplay.TabIndex = 82;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Bank_System_Project.Properties.Resources.Clients2_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(656, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 319);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bank_System_Project.Properties.Resources.Employees;
            this.pictureBox1.Location = new System.Drawing.Point(183, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1297, 846);
            this.Controls.Add(this.Dashboardpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Dashboardpanel.ResumeLayout(false);
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUsersCount;
        private System.Windows.Forms.Label lbClientsCount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Dashboardpanel;
        private System.Windows.Forms.Panel panelDisplay;
    }
}