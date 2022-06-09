using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Class1.f1 = this;

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;

            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;

            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;

            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Form2 newForm = new Form2();
            newForm.Show();

            this.Hide();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 nfm = new Form3();
            nfm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 nfm = new Form4();
            nfm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
