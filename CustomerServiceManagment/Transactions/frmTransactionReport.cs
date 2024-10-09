using BankBusinessLayer;
using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_Project
{
    public partial class frmTransactionReport : Form
    {
        clsBankClient client;
        private string _Operation = "";
        public frmTransactionReport(clsBankClient Client, string Operation)
        {

            InitializeComponent();
            client = Client;
            _Operation = Operation;
        }

        private void frmTransactionReport_Load(object sender, EventArgs e)
        {

            List<clsTransactionReport> list = clsTransactionReport.GetTransactionInfo(client, _Operation);  //get list of students
            reportViewer1.LocalReport.ReportPath = @"C:\Users\lap2p\source\repos\Bank System Project\Bank System Project\TransactionReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear(); //clear report
            reportViewer1.LocalReport.ReportEmbeddedResource = "TransactionReport.rdlc"; // bind reportviewer with .rdlc

            Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("TransactionDS", list); // set the datasource
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = list;
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport(); // refresh report


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);



        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }

}
