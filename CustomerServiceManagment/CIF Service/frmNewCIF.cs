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

namespace Bank_System_Project
{
    public partial class frmNewCIF : Form
    {
        public frmNewCIF()
        {
            InitializeComponent();
        

            ctrCIFcs1.DataBack += ctrCIF1_DataBack;
        }
        private void ctrCIF1_DataBack(object sender,string CifID)
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show($"The customer record is created Successfully.The CIF ID generated is : {CifID} ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
