using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form5 : Form
    {
        SqlConnection sqlConnection;
        public Form5()
        {
            InitializeComponent();
            label2.Text = "Ваш счёт: " + Class1.a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SqlCommand command1 = new SqlCommand("INSERT INTO [Result] (Nic, Score)VALUES(@Nic, @Score)", sqlConnection);

                command1.Parameters.AddWithValue("Nic", textBox1.Text);
                command1.Parameters.AddWithValue("Score", Class1.a);
                command1.ExecuteNonQuery();
            }

            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
