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
    public partial class frmLoginLog : Form
    {
        public frmLoginLog()
        {
            InitializeComponent();
            DGVLoginLog.DataSource = _FillDataGridViewFromFile();
  
        }
        private string _File = @"F:\LoginRegister.txt";
        private DataTable _FillDataGridViewFromFile()
        {
            string[] rows = System.IO.File.ReadAllLines(_File);
            string[] separator = new string[] { "#//#" };
            DataTable dt = new DataTable(_File);
            if (rows.Length != 0)
            {
                foreach (string headerCol in rows[0].Split(separator,StringSplitOptions.None))
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
     
    }

  

}
