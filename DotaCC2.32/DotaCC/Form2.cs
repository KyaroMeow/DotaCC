using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotaCC
{
    public partial class Timing : Form
    {
        public Timing()
        {
            InitializeComponent();
        }

        
        Point lastpoint;
        private void panel1MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }


        private void panel1MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Visible = false;
            timer1.Enabled = false;
        }
    }
}
