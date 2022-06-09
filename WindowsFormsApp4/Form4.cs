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
    public partial class Form4 : Form
    {
        SqlConnection sqlConnection;
        public Form4()
        {
            InitializeComponent();

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Result] ORDER BY Score DESC", sqlConnection);
            try
            {
                sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    if(listBox1.Items.Count<10)
                        listBox1.Items.Add(Convert.ToString(sqlReader["Nic"]) + "     " + Convert.ToString(sqlReader["Score"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
            Class1.f1.Show();
            //Application.Exit();
        }
    }
}
