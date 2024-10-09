namespace Bank_System_Project
{
    partial class AuthorizeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVTransactions = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customButtonColumn1 = new Bank_System_Project.CustomDataGridView.CustomButtonColumn();
            this.lbNoTransactions = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTransactions
            // 
            this.DGVTransactions.AllowUserToAddRows = false;
            this.DGVTransactions.AllowUserToDeleteRows = false;
            this.DGVTransactions.AllowUserToOrderColumns = true;
            this.DGVTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVTransactions.ColumnHeadersHeight = 50;
            this.DGVTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTransactions.EnableHeadersVisualStyles = false;
            this.DGVTransactions.GridColor = System.Drawing.Color.SteelBlue;
            this.DGVTransactions.Location = new System.Drawing.Point(0, 0);
            this.DGVTransactions.Name = "DGVTransactions";
            this.DGVTransactions.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVTransactions.RowHeadersVisible = false;
            this.DGVTransactions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DGVTransactions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVTransactions.RowTemplate.Height = 35;
            this.DGVTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTransactions.Size = new System.Drawing.Size(1297, 846);
            this.DGVTransactions.TabIndex = 0;
            this.DGVTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTransactions_CellClick);
            this.DGVTransactions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVTransactions_CellFormatting);
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dataGridViewButtonColumn1.HeaderText = "Authorization";
            this.dataGridViewButtonColumn1.MinimumWidth = 10;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.Text = "Authorize";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            this.dataGridViewButtonColumn1.Width = 167;
            // 
            // customButtonColumn1
            // 
            this.customButtonColumn1.MinimumWidth = 10;
            this.customButtonColumn1.Name = "customButtonColumn1";
            this.customButtonColumn1.Width = 200;
            // 
            // lbNoTransactions
            // 
            this.lbNoTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNoTransactions.AutoSize = true;
            this.lbNoTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbNoTransactions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoTransactions.Location = new System.Drawing.Point(445, 367);
            this.lbNoTransactions.Name = "lbNoTransactions";
            this.lbNoTransactions.Size = new System.Drawing.Size(442, 39);
            this.lbNoTransactions.TabIndex = 1;
            this.lbNoTransactions.Text = "No Transactions Available.";
            this.lbNoTransactions.Visible = false;
            // 
            // Check
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Check.DefaultCellStyle = dataGridViewCellStyle2;
            this.Check.HeaderText = "Authorization";
            this.Check.MinimumWidth = 10;
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Check.Text = "Authorize";
            this.Check.UseColumnTextForButtonValue = true;
            this.Check.Visible = false;
            this.Check.Width = 167;
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 846);
            this.Controls.Add(this.lbNoTransactions);
            this.Controls.Add(this.DGVTransactions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizeForm";
            this.Text = "AuthorizeForm";
            this.Load += new System.EventHandler(this.AuthorizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVTransactions;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private CustomDataGridView.CustomButtonColumn customButtonColumn1;
        private System.Windows.Forms.Label lbNoTransactions;
        private System.Windows.Forms.DataGridViewButtonColumn Check;
    }
}