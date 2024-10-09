namespace Bank_System_Project
{
    partial class frmClientCIF
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientCIF));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lbNoAccounts = new System.Windows.Forms.Label();
            this.DGVAccounts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.depositAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withDrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withDrawAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxAccounts = new System.Windows.Forms.ToolStripComboBox();
            this.transferToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxToCIF = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripcbDestenationAccounts = new System.Windows.Forms.ToolStripComboBox();
            this.amountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTBAmount = new System.Windows.Forms.ToolStripTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.preformTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrCIFcs1 = new Bank_System_Project.ctrCIFcs();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1419, 1041);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrCIFcs1);
            this.tabPage1.Location = new System.Drawing.Point(8, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1403, 988);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddAccount);
            this.tabPage2.Controls.Add(this.lbNoAccounts);
            this.tabPage2.Controls.Add(this.DGVAccounts);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(8, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1403, 988);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client\'s Accounts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(32, 55);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(191, 55);
            this.btnAddAccount.TabIndex = 2;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // lbNoAccounts
            // 
            this.lbNoAccounts.AutoSize = true;
            this.lbNoAccounts.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoAccounts.Location = new System.Drawing.Point(530, 417);
            this.lbNoAccounts.Name = "lbNoAccounts";
            this.lbNoAccounts.Size = new System.Drawing.Size(356, 42);
            this.lbNoAccounts.TabIndex = 1;
            this.lbNoAccounts.Text = "No Accounts Available.";
            this.lbNoAccounts.Visible = false;
            // 
            // DGVAccounts
            // 
            this.DGVAccounts.AllowUserToAddRows = false;
            this.DGVAccounts.AllowUserToDeleteRows = false;
            this.DGVAccounts.AllowUserToOrderColumns = true;
            this.DGVAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVAccounts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVAccounts.ColumnHeadersHeight = 50;
            this.DGVAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVAccounts.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVAccounts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVAccounts.Location = new System.Drawing.Point(3, 152);
            this.DGVAccounts.Name = "DGVAccounts";
            this.DGVAccounts.ReadOnly = true;
            this.DGVAccounts.RowHeadersVisible = false;
            this.DGVAccounts.RowHeadersWidth = 82;
            this.DGVAccounts.RowTemplate.Height = 35;
            this.DGVAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAccounts.Size = new System.Drawing.Size(1397, 833);
            this.DGVAccounts.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 42);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 27);
            this.label2.TabIndex = 139;
            this.label2.Text = "Customer Information File";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(161)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1383, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 138;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withDrawToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 118);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositAmountToolStripMenuItem,
            this.toolStripTextBox1});
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(192, 38);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 39);
            // 
            // depositAmountToolStripMenuItem
            // 
            this.depositAmountToolStripMenuItem.Name = "depositAmountToolStripMenuItem";
            this.depositAmountToolStripMenuItem.Size = new System.Drawing.Size(322, 44);
            this.depositAmountToolStripMenuItem.Text = "Deposit Amount";
            // 
            // withDrawToolStripMenuItem
            // 
            this.withDrawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withDrawAmountToolStripMenuItem,
            this.toolStripTextBox2});
            this.withDrawToolStripMenuItem.Name = "withDrawToolStripMenuItem";
            this.withDrawToolStripMenuItem.Size = new System.Drawing.Size(192, 38);
            this.withDrawToolStripMenuItem.Text = "WithDraw";
            // 
            // withDrawAmountToolStripMenuItem
            // 
            this.withDrawAmountToolStripMenuItem.Name = "withDrawAmountToolStripMenuItem";
            this.withDrawAmountToolStripMenuItem.Size = new System.Drawing.Size(344, 44);
            this.withDrawAmountToolStripMenuItem.Text = "WithDraw Amount";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 39);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferFromToolStripMenuItem,
            this.toolStripComboBoxAccounts});
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(192, 38);
            this.transferToolStripMenuItem.Text = "Transfer";
            // 
            // transferFromToolStripMenuItem
            // 
            this.transferFromToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToToolStripMenuItem,
            this.toolStripTextBoxToCIF,
            this.toolStripSeparator1,
            this.toolStripcbDestenationAccounts});
            this.transferFromToolStripMenuItem.Name = "transferFromToolStripMenuItem";
            this.transferFromToolStripMenuItem.Size = new System.Drawing.Size(419, 44);
            this.transferFromToolStripMenuItem.Text = "Transfer From";
            // 
            // toolStripComboBoxAccounts
            // 
            this.toolStripComboBoxAccounts.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxAccounts.Name = "toolStripComboBoxAccounts";
            this.toolStripComboBoxAccounts.Size = new System.Drawing.Size(300, 41);
            this.toolStripComboBoxAccounts.Text = "A.cc Source";
            // 
            // transferToToolStripMenuItem
            // 
            this.transferToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amountToolStripMenuItem,
            this.toolStripTBAmount});
            this.transferToToolStripMenuItem.Name = "transferToToolStripMenuItem";
            this.transferToToolStripMenuItem.Size = new System.Drawing.Size(419, 44);
            this.transferToToolStripMenuItem.Text = "Transfer To";
            // 
            // toolStripTextBoxToCIF
            // 
            this.toolStripTextBoxToCIF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStripTextBoxToCIF.AutoSize = false;
            this.toolStripTextBoxToCIF.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBoxToCIF.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripTextBoxToCIF.Name = "toolStripTextBoxToCIF";
            this.toolStripTextBoxToCIF.Size = new System.Drawing.Size(300, 40);
            this.toolStripTextBoxToCIF.Text = "CIF Number";
            this.toolStripTextBoxToCIF.Enter += new System.EventHandler(this.toolStripTextBox3_Enter);
            this.toolStripTextBoxToCIF.Leave += new System.EventHandler(this.toolStripTextBoxToCIF_Leave);
            this.toolStripTextBoxToCIF.Validating += new System.ComponentModel.CancelEventHandler(this.toolStripTextBoxToCIF_Validating);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(416, 6);
            // 
            // toolStripcbDestenationAccounts
            // 
            this.toolStripcbDestenationAccounts.Enabled = false;
            this.toolStripcbDestenationAccounts.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripcbDestenationAccounts.Name = "toolStripcbDestenationAccounts";
            this.toolStripcbDestenationAccounts.Size = new System.Drawing.Size(300, 41);
            // 
            // amountToolStripMenuItem
            // 
            this.amountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preformTransferToolStripMenuItem});
            this.amountToolStripMenuItem.Name = "amountToolStripMenuItem";
            this.amountToolStripMenuItem.Size = new System.Drawing.Size(419, 44);
            this.amountToolStripMenuItem.Text = "Amount";
            // 
            // toolStripTBAmount
            // 
            this.toolStripTBAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTBAmount.Name = "toolStripTBAmount";
            this.toolStripTBAmount.Size = new System.Drawing.Size(300, 39);
            this.toolStripTBAmount.Validating += new System.ComponentModel.CancelEventHandler(this.toolStripTBAmount_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // preformTransferToolStripMenuItem
            // 
            this.preformTransferToolStripMenuItem.Name = "preformTransferToolStripMenuItem";
            this.preformTransferToolStripMenuItem.Size = new System.Drawing.Size(323, 44);
            this.preformTransferToolStripMenuItem.Text = "Preform Transfer";
            this.preformTransferToolStripMenuItem.Click += new System.EventHandler(this.preformTransferToolStripMenuItem_Click);
            // 
            // ctrCIFcs1
            // 
            this.ctrCIFcs1.BackColor = System.Drawing.Color.White;
            this.ctrCIFcs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrCIFcs1.Location = new System.Drawing.Point(3, 3);
            this.ctrCIFcs1.Name = "ctrCIFcs1";
            this.ctrCIFcs1.Size = new System.Drawing.Size(1397, 982);
            this.ctrCIFcs1.TabIndex = 0;
            // 
            // frmClientCIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 1083);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientCIF";
            this.Text = "frmClientCIF";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label lbNoAccounts;
        private System.Windows.Forms.DataGridView DGVAccounts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private ctrCIFcs ctrCIFcs1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem depositAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withDrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withDrawAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxToCIF;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxAccounts;
        private System.Windows.Forms.ToolStripMenuItem amountToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTBAmount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox toolStripcbDestenationAccounts;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripMenuItem preformTransferToolStripMenuItem;
    }
}