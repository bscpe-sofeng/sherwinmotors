using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventorySystem
{
    public partial class Form1 : Form
    {
        database admin4 = new database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin4.Connect();
            admin4.admin2 = new MySqlCommand("select * from accounts where User=@User and Password=@Password", admin4.adminn);
            admin4.admin2.Parameters.Add(new MySqlParameter("User", textBox1.Text));
            admin4.admin2.Parameters.Add(new MySqlParameter("Password", textBox2.Text));
            //admin4.admin1 = admin4.admin2.ExecuteReader();
            admin4.admin1 = admin4.admin2.ExecuteReader();
            if (admin4.admin1.Read())
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }

            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
        
        }
    }
}
