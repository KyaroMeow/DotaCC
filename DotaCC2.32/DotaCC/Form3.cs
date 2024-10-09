using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotaCC
{
    public partial class Form3 : Form
    {
        public Form3()
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
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile("X.png");
        }
        private void iftouchedclose(object sender, EventArgs e)
        {
            System.Media.SoundPlayer plays = new System.Media.SoundPlayer(@"resx\\sounds\\Ui_menu_close.wav");
            plays.Play();
            pictureBox5.Image = Image.FromFile("Red_X.png");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            timer1.Enabled = false;
        }
    }
}
