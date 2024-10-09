namespace Bank_System_Project
{
    partial class CtrOpenAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CTBConfirmPassword = new Bank_System_Project.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CTBPassword = new Bank_System_Project.CustomTextBox();
            this.CTBBalance = new Bank_System_Project.CustomTextBox();
            this.gbAccountTypes = new System.Windows.Forms.GroupBox();
            this.rbCheckingAccount = new System.Windows.Forms.RadioButton();
            this.rbSavingAccount = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.rbDrivingLicence = new System.Windows.Forms.RadioButton();
            this.CTBNationality = new Bank_System_Project.CustomTextBox();
            this.rbSocialSecuritynumber = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.roundPic2 = new Bank_System_Project.RoundPic();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.CTBLastName = new Bank_System_Project.CustomTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CTBEmail = new Bank_System_Project.CustomTextBox();
            this.CTBFirstName = new Bank_System_Project.CustomTextBox();
            this.CTBAddress = new Bank_System_Project.CustomTextBox();
            this.maskedTBPhone = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.gbAccountTypes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPic2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.CTBConfirmPassword);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.CTBPassword);
            this.groupBox3.Controls.Add(this.CTBBalance);
            this.groupBox3.Location = new System.Drawing.Point(545, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(866, 408);
            this.groupBox3.TabIndex = 137;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(62, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 31);
            this.label13.TabIndex = 21;
            this.label13.Text = " Initial Deposit:";
            // 
            // CTBConfirmPassword
            // 
            this.CTBConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CTBConfirmPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBConfirmPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBConfirmPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBConfirmPassword.BorderSize = 2;
            this.CTBConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.CTBConfirmPassword.Location = new System.Drawing.Point(291, 233);
            this.CTBConfirmPassword.Multiline = false;
            this.CTBConfirmPassword.Name = "CTBConfirmPassword";
            this.CTBConfirmPassword.Padding = new System.Windows.Forms.Padding(7);
            this.CTBConfirmPassword.PasswordChar = false;
            this.CTBConfirmPassword.Size = new System.Drawing.Size(518, 42);
            this.CTBConfirmPassword.TabIndex = 131;
            this.CTBConfirmPassword.Texts = "";
            this.CTBConfirmPassword.UnderlineStyle1 = false;
            this.CTBConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.CTBConfirmPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 31);
            this.label3.TabIndex = 130;
            this.label3.Text = "Confirm Password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(69, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 31);
            this.label15.TabIndex = 19;
            this.label15.Text = "Password:";
            // 
            // CTBPassword
            // 
            this.CTBPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CTBPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBPassword.BorderSize = 2;
            this.CTBPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBPassword.ForeColor = System.Drawing.Color.Black;
            this.CTBPassword.Location = new System.Drawing.Point(291, 166);
            this.CTBPassword.Multiline = false;
            this.CTBPassword.Name = "CTBPassword";
            this.CTBPassword.Padding = new System.Windows.Forms.Padding(7);
            this.CTBPassword.PasswordChar = false;
            this.CTBPassword.Size = new System.Drawing.Size(518, 42);
            this.CTBPassword.TabIndex = 118;
            this.CTBPassword.Texts = "";
            this.CTBPassword.UnderlineStyle1 = false;
            this.CTBPassword.Validating += new System.ComponentModel.CancelEventHandler(this.CTBPassword_Validating);
            // 
            // CTBBalance
            // 
            this.CTBBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CTBBalance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBBalance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBBalance.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBBalance.BorderSize = 2;
            this.CTBBalance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBBalance.ForeColor = System.Drawing.Color.Black;
            this.CTBBalance.Location = new System.Drawing.Point(291, 98);
            this.CTBBalance.Multiline = false;
            this.CTBBalance.Name = "CTBBalance";
            this.CTBBalance.Padding = new System.Windows.Forms.Padding(7);
            this.CTBBalance.PasswordChar = false;
            this.CTBBalance.Size = new System.Drawing.Size(518, 42);
            this.CTBBalance.TabIndex = 121;
            this.CTBBalance.Texts = "";
            this.CTBBalance.UnderlineStyle1 = false;
            this.CTBBalance.Validating += new System.ComponentModel.CancelEventHandler(this.CTBBalance_Validating);
            // 
            // gbAccountTypes
            // 
            this.gbAccountTypes.Controls.Add(this.rbCheckingAccount);
            this.gbAccountTypes.Controls.Add(this.rbSavingAccount);
            this.gbAccountTypes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccountTypes.Location = new System.Drawing.Point(49, 657);
            this.gbAccountTypes.Name = "gbAccountTypes";
            this.gbAccountTypes.Size = new System.Drawing.Size(474, 108);
            this.gbAccountTypes.TabIndex = 136;
            this.gbAccountTypes.TabStop = false;
            this.gbAccountTypes.Text = "Account Type";
            this.gbAccountTypes.Validating += new System.ComponentModel.CancelEventHandler(this.gbAccountTypes_Validating);
            // 
            // rbCheckingAccount
            // 
            this.rbCheckingAccount.AutoSize = true;
            this.rbCheckingAccount.Location = new System.Drawing.Point(247, 46);
            this.rbCheckingAccount.Name = "rbCheckingAccount";
            this.rbCheckingAccount.Size = new System.Drawing.Size(221, 31);
            this.rbCheckingAccount.TabIndex = 128;
            this.rbCheckingAccount.TabStop = true;
            this.rbCheckingAccount.Text = "Checking Account";
            this.rbCheckingAccount.UseVisualStyleBackColor = true;
            // 
            // rbSavingAccount
            // 
            this.rbSavingAccount.AutoSize = true;
            this.rbSavingAccount.Location = new System.Drawing.Point(35, 46);
            this.rbSavingAccount.Name = "rbSavingAccount";
            this.rbSavingAccount.Size = new System.Drawing.Size(203, 31);
            this.rbSavingAccount.TabIndex = 127;
            this.rbSavingAccount.TabStop = true;
            this.rbSavingAccount.Text = "Savings Account";
            this.rbSavingAccount.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(364, 784);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(201, 94);
            this.btnCancel.TabIndex = 134;
            this.btnCancel.Text = "&Clear";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(770, 784);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(201, 94);
            this.btnNext.TabIndex = 133;
            this.btnNext.Text = "&Submit";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Location = new System.Drawing.Point(35, 50);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(137, 35);
            this.rbPassport.TabIndex = 0;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Passport";
            this.rbPassport.UseVisualStyleBackColor = true;
            // 
            // rbDrivingLicence
            // 
            this.rbDrivingLicence.AutoSize = true;
            this.rbDrivingLicence.Location = new System.Drawing.Point(35, 176);
            this.rbDrivingLicence.Name = "rbDrivingLicence";
            this.rbDrivingLicence.Size = new System.Drawing.Size(215, 35);
            this.rbDrivingLicence.TabIndex = 1;
            this.rbDrivingLicence.TabStop = true;
            this.rbDrivingLicence.Text = "Driving License";
            this.rbDrivingLicence.UseVisualStyleBackColor = true;
            // 
            // CTBNationality
            // 
            this.CTBNationality.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBNationality.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBNationality.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBNationality.BorderSize = 2;
            this.CTBNationality.Enabled = false;
            this.CTBNationality.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBNationality.ForeColor = System.Drawing.Color.DarkGray;
            this.CTBNationality.Location = new System.Drawing.Point(35, 235);
            this.CTBNationality.Multiline = false;
            this.CTBNationality.Name = "CTBNationality";
            this.CTBNationality.Padding = new System.Windows.Forms.Padding(7);
            this.CTBNationality.PasswordChar = false;
            this.CTBNationality.Size = new System.Drawing.Size(415, 42);
            this.CTBNationality.TabIndex = 126;
            this.CTBNationality.Texts = "";
            this.CTBNationality.UnderlineStyle1 = false;
            this.CTBNationality.Validating += new System.ComponentModel.CancelEventHandler(this.CTBNationality_Validating);
            // 
            // rbSocialSecuritynumber
            // 
            this.rbSocialSecuritynumber.AutoSize = true;
            this.rbSocialSecuritynumber.Location = new System.Drawing.Point(35, 112);
            this.rbSocialSecuritynumber.Name = "rbSocialSecuritynumber";
            this.rbSocialSecuritynumber.Size = new System.Drawing.Size(307, 35);
            this.rbSocialSecuritynumber.TabIndex = 127;
            this.rbSocialSecuritynumber.TabStop = true;
            this.rbSocialSecuritynumber.Text = " Social Security number";
            this.rbSocialSecuritynumber.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSocialSecuritynumber);
            this.groupBox1.Controls.Add(this.CTBNationality);
            this.groupBox1.Controls.Add(this.rbDrivingLicence);
            this.groupBox1.Controls.Add(this.rbPassport);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 294);
            this.groupBox1.TabIndex = 135;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identity ID";
            this.groupBox1.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1_Validating);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(515, 70);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 31);
            this.label22.TabIndex = 35;
            this.label22.Text = "DateOfBirth:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(515, 219);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 31);
            this.label21.TabIndex = 33;
            this.label21.Text = "Address:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(517, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 31);
            this.label14.TabIndex = 20;
            this.label14.Text = "Email:";
            // 
            // roundPic2
            // 
            this.roundPic2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roundPic2.Image = global::Bank_System_Project.Properties.Resources.PersonEmptyPhoto;
            this.roundPic2.Location = new System.Drawing.Point(1105, 32);
            this.roundPic2.Name = "roundPic2";
            this.roundPic2.Size = new System.Drawing.Size(200, 197);
            this.roundPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPic2.TabIndex = 43;
            this.roundPic2.TabStop = false;
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpDateOfBirth.Location = new System.Drawing.Point(687, 65);
            this.DtpDateOfBirth.MaxDate = new System.DateTime(2023, 9, 25, 0, 0, 0, 0);
            this.DtpDateOfBirth.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(379, 33);
            this.DtpDateOfBirth.TabIndex = 36;
            this.DtpDateOfBirth.Value = new System.DateTime(2023, 9, 25, 0, 0, 0, 0);
            // 
            // llSetImage
            // 
            this.llSetImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.Location = new System.Drawing.Point(1091, 268);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(93, 18);
            this.llSetImage.TabIndex = 41;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(14, 219);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 31);
            this.label18.TabIndex = 29;
            this.label18.Text = "Phone:";
            // 
            // llRemove
            // 
            this.llRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.llRemove.AutoSize = true;
            this.llRemove.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemove.Location = new System.Drawing.Point(1232, 268);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(73, 18);
            this.llRemove.TabIndex = 42;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            this.llRemove.Visible = false;
            // 
            // CTBLastName
            // 
            this.CTBLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CTBLastName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBLastName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBLastName.BorderSize = 2;
            this.CTBLastName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBLastName.ForeColor = System.Drawing.Color.Black;
            this.CTBLastName.Location = new System.Drawing.Point(201, 142);
            this.CTBLastName.Multiline = false;
            this.CTBLastName.Name = "CTBLastName";
            this.CTBLastName.Padding = new System.Windows.Forms.Padding(7);
            this.CTBLastName.PasswordChar = false;
            this.CTBLastName.Size = new System.Drawing.Size(267, 42);
            this.CTBLastName.TabIndex = 120;
            this.CTBLastName.Texts = "";
            this.CTBLastName.UnderlineStyle1 = false;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 31);
            this.label19.TabIndex = 28;
            this.label19.Text = "LastName:";
            // 
            // CTBEmail
            // 
            this.CTBEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CTBEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBEmail.BorderSize = 2;
            this.CTBEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBEmail.ForeColor = System.Drawing.Color.Black;
            this.CTBEmail.Location = new System.Drawing.Point(684, 142);
            this.CTBEmail.Multiline = false;
            this.CTBEmail.Name = "CTBEmail";
            this.CTBEmail.Padding = new System.Windows.Forms.Padding(7);
            this.CTBEmail.PasswordChar = false;
            this.CTBEmail.Size = new System.Drawing.Size(382, 42);
            this.CTBEmail.TabIndex = 123;
            this.CTBEmail.Texts = "";
            this.CTBEmail.UnderlineStyle1 = false;
            // 
            // CTBFirstName
            // 
            this.CTBFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CTBFirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBFirstName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBFirstName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBFirstName.BorderSize = 2;
            this.CTBFirstName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBFirstName.ForeColor = System.Drawing.Color.Black;
            this.CTBFirstName.Location = new System.Drawing.Point(201, 65);
            this.CTBFirstName.Multiline = false;
            this.CTBFirstName.Name = "CTBFirstName";
            this.CTBFirstName.Padding = new System.Windows.Forms.Padding(7);
            this.CTBFirstName.PasswordChar = false;
            this.CTBFirstName.Size = new System.Drawing.Size(267, 42);
            this.CTBFirstName.TabIndex = 119;
            this.CTBFirstName.Texts = "";
            this.CTBFirstName.UnderlineStyle1 = false;
            // 
            // CTBAddress
            // 
            this.CTBAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CTBAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBAddress.BorderSize = 2;
            this.CTBAddress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBAddress.ForeColor = System.Drawing.Color.Black;
            this.CTBAddress.Location = new System.Drawing.Point(684, 213);
            this.CTBAddress.Multiline = true;
            this.CTBAddress.Name = "CTBAddress";
            this.CTBAddress.Padding = new System.Windows.Forms.Padding(7);
            this.CTBAddress.PasswordChar = false;
            this.CTBAddress.Size = new System.Drawing.Size(382, 83);
            this.CTBAddress.TabIndex = 124;
            this.CTBAddress.Texts = "";
            this.CTBAddress.UnderlineStyle1 = false;
            // 
            // maskedTBPhone
            // 
            this.maskedTBPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTBPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maskedTBPhone.BeepOnError = true;
            this.maskedTBPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTBPhone.Location = new System.Drawing.Point(201, 220);
            this.maskedTBPhone.Mask = "+000 00-000-0000";
            this.maskedTBPhone.Name = "maskedTBPhone";
            this.maskedTBPhone.PromptChar = '0';
            this.maskedTBPhone.Size = new System.Drawing.Size(267, 35);
            this.maskedTBPhone.TabIndex = 126;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 31);
            this.label20.TabIndex = 27;
            this.label20.Text = "FirstName:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.maskedTBPhone);
            this.groupBox2.Controls.Add(this.CTBAddress);
            this.groupBox2.Controls.Add(this.CTBFirstName);
            this.groupBox2.Controls.Add(this.CTBEmail);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.CTBLastName);
            this.groupBox2.Controls.Add(this.llRemove);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.llSetImage);
            this.groupBox2.Controls.Add(this.DtpDateOfBirth);
            this.groupBox2.Controls.Add(this.roundPic2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(49, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1362, 318);
            this.groupBox2.TabIndex = 130;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Information";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CtrOpenAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbAccountTypes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox2);
            this.Name = "CtrOpenAccount";
            this.Size = new System.Drawing.Size(1463, 895);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbAccountTypes.ResumeLayout(false);
            this.gbAccountTypes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPic2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private CustomTextBox CTBConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private CustomTextBox CTBPassword;
        private CustomTextBox CTBBalance;
        private System.Windows.Forms.GroupBox gbAccountTypes;
        private System.Windows.Forms.RadioButton rbCheckingAccount;
        private System.Windows.Forms.RadioButton rbSavingAccount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rbPassport;
        private System.Windows.Forms.RadioButton rbDrivingLicence;
        private CustomTextBox CTBNationality;
        private System.Windows.Forms.RadioButton rbSocialSecuritynumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private RoundPic roundPic2;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel llRemove;
        private CustomTextBox CTBLastName;
        private System.Windows.Forms.Label label19;
        private CustomTextBox CTBEmail;
        private CustomTextBox CTBFirstName;
        private CustomTextBox CTBAddress;
        private System.Windows.Forms.MaskedTextBox maskedTBPhone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
