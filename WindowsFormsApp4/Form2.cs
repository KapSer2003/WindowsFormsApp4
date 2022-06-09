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

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        int s = 20;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W)
            {
                player.Location = new Point(player.Location.X, player.Location.Y - 10);
                if (player.Top <= 0)
                {
                    player.Location = new Point(player.Location.X, player.Location.Y + 10);
                }
            }
            if (e.KeyData == Keys.S)
            {
                player.Location = new Point(player.Location.X, player.Location.Y + 10);
                if (player.Bottom >= ClientRectangle.Height)
                {
                    player.Location = new Point(player.Location.X, player.Location.Y - 10);
                }

            }
            if (e.KeyCode == Keys.A)
            {
                player.Location = new Point(player.Location.X - 10, player.Location.Y);
                if (player.Left <= 0)
                {
                    player.Location = new Point(player.Location.X + 10, player.Location.Y);
                }
            }
            if (e.KeyCode == Keys.D)
            {
                player.Location = new Point(player.Location.X + 10, player.Location.Y);
                if (player.Right >= ClientRectangle.Width)
                {
                    player.Location = new Point(player.Location.X - 10, player.Location.Y);
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                player.Location = new Point(player.Location.X - 10, player.Location.Y);
                if (player.Left <= 0)
                {
                    player.Location = new Point(player.Location.X + 10, player.Location.Y);
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                player.Location = new Point(player.Location.X + 10, player.Location.Y);
                if (player.Right >= ClientRectangle.Width)
                {
                    player.Location = new Point(player.Location.X - 10, player.Location.Y);
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                player.Location = new Point(player.Location.X, player.Location.Y - 10);
                if (player.Top <= 0)
                {
                    player.Location = new Point(player.Location.X, player.Location.Y + 10);
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                player.Location = new Point(player.Location.X, player.Location.Y + 10);
                if (player.Bottom >= ClientRectangle.Height)
                {
                    player.Location = new Point(player.Location.X, player.Location.Y - 10);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            schet();
            if (Class1.LeftMove == true)
            {
                player2.Left += 10;
            }
            if (Class1.LeftMove == false)
            {
                player2.Left -= 10;
            }
            if (Class1.UpMove == true)
            {
                player2.Top += 10;
            }
            if (Class1.UpMove == false)
            {
                player2.Top -= 10;
            }

            if (player2.Left <= ClientRectangle.Left)
            {
                Class1.LeftMove = true;
            }
            if (player2.Right >= ClientRectangle.Right)
            {
                Class1.LeftMove = false;
            }
            if (player2.Top <= ClientRectangle.Top)
            {
                Class1.UpMove = true;
            }
            if (player2.Bottom >= ClientRectangle.Bottom)
            {
                Class1.UpMove = false;
            }
        }
        private void schet()
        {
            if (player.Bounds.IntersectsWith(player2.Bounds))
            {
                Class1.a++;
                label1.Text = "Счет:" + Convert.ToString(Class1.a);
                Thread.Sleep(1000);
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = "Время:" + s--;
            if (s == 0)
            {
                timer1.Stop();
                timer2.Stop();
                this.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form res = new Form5();
            res.Show();
        }
    }
}
    

