using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloudMove()
        {
            foreach (Control c in Controls)
            {
                if (c is PictureBox && c.Tag == "cloud")
                {
                    if (c.Top < -150)
                    {
                        c.Top = 450;
                    }

                    c.Top -= 10;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 50) { player.Left -= 5; }
            if (e.KeyCode == Keys.Right && player.Right < 340) { player.Left += 5; }
        }
        private void batMove()
        {
            Random r = new Random();
            int x, y, z;
            if (bat_1.Top < 20)
            {
                x = r.Next(50, 300);
                bat_1.Location = new Point(x, 650);
            }
            else if (bat_2.Top < 20)
            {
                y = r.Next(50, 300);
                bat_2.Location = new Point(y, 500);
            }
            else if (bat_3.Top < 20)
            {
                z = r.Next(50, 300);
                bat_3.Location = new Point(z, 800);
            }
            else
            {
                bat_1.Top -= 8;
                bat_2.Top -= 8;
                bat_3.Top -= 8;
            }
            if (player.Bounds.IntersectsWith(bat_1.Bounds)) { timer1.Stop(); gameoverlbl.Visible = true; bat_1.Visible = false; bat_2.Visible = false; bat_3.Visible = false; }
            if (player.Bounds.IntersectsWith(bat_2.Bounds)) { timer1.Stop(); gameoverlbl.Visible = true; bat_1.Visible = false; bat_2.Visible = false; bat_3.Visible = false; }
            if (player.Bounds.IntersectsWith(bat_3.Bounds)) { timer1.Stop(); gameoverlbl.Visible = true; bat_1.Visible = false; bat_2.Visible = false; bat_3.Visible = false; }
        }
        int score;

        private void StarMove()
        {
            Random r = new Random();
            int x, y;
            if (star_1.Top < 20)
            {
                x = r.Next(50, 300);
                star_1.Location = new Point(x, 650);
            }
            else if (star_2.Top < 20)
            {
                y = r.Next(50, 300);
                star_2.Location = new Point(y, 500);
            }

            else
            {
                star_1.Top -= 5;
                star_2.Top -= 5;

            }
            if (player.Bounds.IntersectsWith(star_1.Bounds)) { star_1.Top =800; score++; }
            if (player.Bounds.IntersectsWith(star_2.Bounds)) { star_2.Top = 1000; score++; }
            scorelbl.Text = score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CloudMove();
            batMove();
            StarMove();
        }

        private void gameoverlbl_Click(object sender, EventArgs e)
        {
            gameoverlbl.Visible = false;
            bat_1.Top = 800;
            bat_2.Top = 900;
            bat_3.Top = 700;
            star_1.Top = 600;
            star_2.Top = 500;
            bat_1.Visible = true;
            bat_2.Visible = true;
            bat_3.Visible = true;

            score = 0;
            timer1.Start();
        }
    }
}
