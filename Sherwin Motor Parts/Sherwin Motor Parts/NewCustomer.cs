using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sherwin_Motor_Parts
{
    public partial class NewCustomer : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader rdr = null;

        String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

        public NewCustomer()
        {
            InitializeComponent();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        public void disp_data()
        {
            connection = new OleDbConnection(cs);
            connection.Open();
            String sc = "SELECT * from Customers";
            command = new OleDbCommand(sc, connection);
            rdr = command.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (rdr.Read() == true)
            {
                dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
            }
            connection.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNCfname.Clear();
            txtNClname.Clear();
            txtNCaddress.Clear();
            txtNCcontact.Clear();
            txtNCfname.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNCfname.Text == "")
            {
                MessageBox.Show("Please enter your firstname");
                txtNCfname.Focus();
                return;
            }

            if (txtNClname.Text == "")
            {
                MessageBox.Show("Please enter your lastname");
                txtNClname.Focus();
                return;
            }

            if (txtNCaddress.Text == "")
            {
                MessageBox.Show("Please enter your Address");
                txtNCaddress.Focus();
                return;
            }
            if (txtNCcontact.Text == "")
            {
                MessageBox.Show("Please enter your Contact Number");
                txtNCcontact.Focus();
                return;
            }

            connection = new OleDbConnection(cs);
            connection.Open();
            String sc = "insert into Customers(Firstname,Lastname,Address,ContactNumber) values('" + txtNCfname.Text + "','" + txtNClname.Text + "','" + txtNCaddress.Text + "','" + txtNCcontact.Text + "')";
            command = new OleDbCommand(sc, connection);
            rdr = command.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (rdr.Read() == true)
            {
                dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
            }            
            connection.Close();
            disp_data();
            MessageBox.Show("Customer registration complete");

            txtNCfname.Clear();
            txtNClname.Clear();
            txtNCaddress.Clear();
            txtNCcontact.Clear();
            txtNCfname.Focus();
        }

        private void txtNCname_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }           
        }

        private void txtNClname_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
        }

        private void txtNCcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

             
    }
}
