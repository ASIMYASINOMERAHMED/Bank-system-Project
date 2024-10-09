namespace Bank_System_Project
{
    partial class ctrCIFcs
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbOccupationType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSocialSecuritynumber = new System.Windows.Forms.RadioButton();
            this.CTBNationality = new Bank_System_Project.CustomTextBox();
            this.rbDrivingLicence = new System.Windows.Forms.RadioButton();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.cbIncomeType = new System.Windows.Forms.ComboBox();
            this.CTBIncome = new Bank_System_Project.CustomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.maskedTBPhone = new System.Windows.Forms.MaskedTextBox();
            this.CTBAddress = new Bank_System_Project.CustomTextBox();
            this.CTBFirstName = new Bank_System_Project.CustomTextBox();
            this.CTBEmail = new Bank_System_Project.CustomTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.CTBLastName = new Bank_System_Project.CustomTextBox();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.label18 = new System.Windows.Forms.Label();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.roundPic2 = new Bank_System_Project.RoundPic();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(336, 917);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 64);
            this.btnSave.TabIndex = 200;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Location = new System.Drawing.Point(334, 917);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(201, 64);
            this.btnNext.TabIndex = 194;
            this.btnNext.Text = "&Submit";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(749, 917);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(201, 64);
            this.btnCancel.TabIndex = 195;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(243, 521);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(267, 33);
            this.cbCountry.TabIndex = 198;
            this.cbCountry.Text = "--SELECT--";
            this.cbCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cbCountry_Validating_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 31);
            this.label4.TabIndex = 197;
            this.label4.Text = "Country:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbFemale);
            this.groupBox3.Controls.Add(this.rbMale);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 613);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 121);
            this.groupBox3.TabIndex = 196;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gender";
            this.groupBox3.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox3_Validating_1);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(218, 46);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(102, 27);
            this.rbFemale.TabIndex = 129;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(50, 46);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(83, 27);
            this.rbMale.TabIndex = 128;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbOccupationType
            // 
            this.cbOccupationType.FormattingEnabled = true;
            this.cbOccupationType.Items.AddRange(new object[] {
            "Salaried",
            "Self Employed",
            "Business",
            "Retired",
            "Student",
            "Others"});
            this.cbOccupationType.Location = new System.Drawing.Point(243, 427);
            this.cbOccupationType.Name = "cbOccupationType";
            this.cbOccupationType.Size = new System.Drawing.Size(267, 33);
            this.cbOccupationType.TabIndex = 193;
            this.cbOccupationType.Text = "--SELECT--";
            this.cbOccupationType.Validating += new System.ComponentModel.CancelEventHandler(this.cbOccupationType_Validating_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSocialSecuritynumber);
            this.groupBox1.Controls.Add(this.CTBNationality);
            this.groupBox1.Controls.Add(this.rbDrivingLicence);
            this.groupBox1.Controls.Add(this.rbPassport);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(620, 523);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 295);
            this.groupBox1.TabIndex = 192;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identity ID";
            this.groupBox1.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox1_Validating_1);
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
            this.rbSocialSecuritynumber.CheckedChanged += new System.EventHandler(this.rbSocialSecuritynumber_CheckedChanged_1);
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
            this.CTBNationality.Enter += new System.EventHandler(this.CTBNationality_Enter_1);
            this.CTBNationality.Leave += new System.EventHandler(this.CTBNationality_Leave_1);
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
            this.rbDrivingLicence.CheckedChanged += new System.EventHandler(this.rbDrivingLicence_CheckedChanged_1);
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
            this.rbPassport.CheckedChanged += new System.EventHandler(this.rbPassport_CheckedChanged_1);
            // 
            // cbIncomeType
            // 
            this.cbIncomeType.FormattingEnabled = true;
            this.cbIncomeType.Items.AddRange(new object[] {
            "Monthly",
            "Annualy"});
            this.cbIncomeType.Location = new System.Drawing.Point(731, 426);
            this.cbIncomeType.Name = "cbIncomeType";
            this.cbIncomeType.Size = new System.Drawing.Size(372, 33);
            this.cbIncomeType.TabIndex = 191;
            this.cbIncomeType.Text = "--SELECT--";
            this.cbIncomeType.Validating += new System.ComponentModel.CancelEventHandler(this.cbIncomeType_Validating_1);
            // 
            // CTBIncome
            // 
            this.CTBIncome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CTBIncome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTBIncome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.CTBIncome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.CTBIncome.BorderSize = 2;
            this.CTBIncome.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTBIncome.ForeColor = System.Drawing.Color.Black;
            this.CTBIncome.Location = new System.Drawing.Point(243, 336);
            this.CTBIncome.Multiline = false;
            this.CTBIncome.Name = "CTBIncome";
            this.CTBIncome.Padding = new System.Windows.Forms.Padding(7);
            this.CTBIncome.PasswordChar = false;
            this.CTBIncome.Size = new System.Drawing.Size(267, 42);
            this.CTBIncome.TabIndex = 190;
            this.CTBIncome.Texts = "";
            this.CTBIncome.UnderlineStyle1 = false;
            this.CTBIncome.Validating += new System.ComponentModel.CancelEventHandler(this.CTBIncome_Validating_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 31);
            this.label3.TabIndex = 189;
            this.label3.Text = "Occupation Type:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 188;
            this.label2.Text = "Income Type:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 187;
            this.label1.Text = "Income:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(21, 125);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 31);
            this.label20.TabIndex = 173;
            this.label20.Text = "FirstName:";
            // 
            // maskedTBPhone
            // 
            this.maskedTBPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTBPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maskedTBPhone.BeepOnError = true;
            this.maskedTBPhone.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTBPhone.HidePromptOnLeave = true;
            this.maskedTBPhone.Location = new System.Drawing.Point(243, 272);
            this.maskedTBPhone.Mask = "+000 00-000-0000";
            this.maskedTBPhone.Name = "maskedTBPhone";
            this.maskedTBPhone.PromptChar = '0';
            this.maskedTBPhone.Size = new System.Drawing.Size(267, 35);
            this.maskedTBPhone.TabIndex = 186;
            this.maskedTBPhone.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTBPhone_Validating_1);
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
            this.CTBAddress.Location = new System.Drawing.Point(676, 265);
            this.CTBAddress.Multiline = true;
            this.CTBAddress.Name = "CTBAddress";
            this.CTBAddress.Padding = new System.Windows.Forms.Padding(7);
            this.CTBAddress.PasswordChar = false;
            this.CTBAddress.Size = new System.Drawing.Size(476, 113);
            this.CTBAddress.TabIndex = 185;
            this.CTBAddress.Texts = "";
            this.CTBAddress.UnderlineStyle1 = false;
            this.CTBAddress.Validating += new System.ComponentModel.CancelEventHandler(this.CTBAddress_Validating_1);
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
            this.CTBFirstName.Location = new System.Drawing.Point(243, 117);
            this.CTBFirstName.Multiline = false;
            this.CTBFirstName.Name = "CTBFirstName";
            this.CTBFirstName.Padding = new System.Windows.Forms.Padding(7);
            this.CTBFirstName.PasswordChar = false;
            this.CTBFirstName.Size = new System.Drawing.Size(267, 42);
            this.CTBFirstName.TabIndex = 182;
            this.CTBFirstName.Texts = "";
            this.CTBFirstName.UnderlineStyle1 = false;
            this.CTBFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.CTBFirstName_Validating_1);
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
            this.CTBEmail.Location = new System.Drawing.Point(676, 194);
            this.CTBEmail.Multiline = false;
            this.CTBEmail.Name = "CTBEmail";
            this.CTBEmail.Padding = new System.Windows.Forms.Padding(7);
            this.CTBEmail.PasswordChar = false;
            this.CTBEmail.Size = new System.Drawing.Size(476, 42);
            this.CTBEmail.TabIndex = 184;
            this.CTBEmail.Texts = "";
            this.CTBEmail.UnderlineStyle1 = false;
            this.CTBEmail.Validating += new System.ComponentModel.CancelEventHandler(this.CTBEmail_Validating_1);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 31);
            this.label19.TabIndex = 174;
            this.label19.Text = "LastName:";
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
            this.CTBLastName.Location = new System.Drawing.Point(243, 194);
            this.CTBLastName.Multiline = false;
            this.CTBLastName.Name = "CTBLastName";
            this.CTBLastName.Padding = new System.Windows.Forms.Padding(7);
            this.CTBLastName.PasswordChar = false;
            this.CTBLastName.Size = new System.Drawing.Size(267, 42);
            this.CTBLastName.TabIndex = 183;
            this.CTBLastName.Texts = "";
            this.CTBLastName.UnderlineStyle1 = false;
            this.CTBLastName.Validating += new System.ComponentModel.CancelEventHandler(this.CTBLastName_Validating_1);
            // 
            // llRemove
            // 
            this.llRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.llRemove.AutoSize = true;
            this.llRemove.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemove.Location = new System.Drawing.Point(1318, 322);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(73, 18);
            this.llRemove.TabIndex = 180;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            this.llRemove.Visible = false;
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemove_LinkClicked_1);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(19, 271);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 31);
            this.label18.TabIndex = 175;
            this.label18.Text = "Phone:";
            // 
            // llSetImage
            // 
            this.llSetImage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.Location = new System.Drawing.Point(1177, 322);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(93, 18);
            this.llSetImage.TabIndex = 179;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked_1);
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpDateOfBirth.Location = new System.Drawing.Point(722, 117);
            this.DtpDateOfBirth.MaxDate = new System.DateTime(2023, 9, 25, 0, 0, 0, 0);
            this.DtpDateOfBirth.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(430, 33);
            this.DtpDateOfBirth.TabIndex = 178;
            this.DtpDateOfBirth.Value = new System.DateTime(2023, 9, 25, 0, 0, 0, 0);
            this.DtpDateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDateOfBirth_Validating_1);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(554, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 31);
            this.label14.TabIndex = 172;
            this.label14.Text = "Email:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(552, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 31);
            this.label21.TabIndex = 176;
            this.label21.Text = "Address:";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(552, 122);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 31);
            this.label22.TabIndex = 177;
            this.label22.Text = "DateOfBirth:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::Bank_System_Project.Properties.Resources.edit__2_1;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(1263, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 43);
            this.btnEdit.TabIndex = 199;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // roundPic2
            // 
            this.roundPic2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.roundPic2.Image = global::Bank_System_Project.Properties.Resources.PersonEmptyPhoto;
            this.roundPic2.Location = new System.Drawing.Point(1191, 102);
            this.roundPic2.Name = "roundPic2";
            this.roundPic2.Size = new System.Drawing.Size(200, 197);
            this.roundPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPic2.TabIndex = 181;
            this.roundPic2.TabStop = false;
            // 
            // ctrCIFcs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbOccupationType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbIncomeType);
            this.Controls.Add(this.CTBIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.maskedTBPhone);
            this.Controls.Add(this.CTBAddress);
            this.Controls.Add(this.CTBFirstName);
            this.Controls.Add(this.CTBEmail);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.CTBLastName);
            this.Controls.Add(this.llRemove);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.DtpDateOfBirth);
            this.Controls.Add(this.roundPic2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Name = "ctrCIFcs";
            this.Size = new System.Drawing.Size(1411, 1003);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundPic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbOccupationType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSocialSecuritynumber;
        private CustomTextBox CTBNationality;
        private System.Windows.Forms.RadioButton rbDrivingLicence;
        private System.Windows.Forms.RadioButton rbPassport;
        private System.Windows.Forms.ComboBox cbIncomeType;
        private CustomTextBox CTBIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox maskedTBPhone;
        private CustomTextBox CTBAddress;
        private CustomTextBox CTBFirstName;
        private CustomTextBox CTBEmail;
        private System.Windows.Forms.Label label19;
        private CustomTextBox CTBLastName;
        private System.Windows.Forms.LinkLabel llRemove;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private RoundPic roundPic2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
