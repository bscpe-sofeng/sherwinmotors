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
    public partial class NewAccount : Form
    {
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader rdr = null;

        String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

        public NewAccount()
        {
            InitializeComponent();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                MessageBox.Show("Please enter your firstname");
                txtfname.Focus();
                return;
            }

            if (txtlname.Text == "")
            {
                MessageBox.Show("Please enter your lastname");
                txtlname.Focus();
                return;
            }
            if (txtusername.Text == "")
            {
                MessageBox.Show("Please enter your username");
                txtusername.Focus();
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Please enter your password");
                txtpassword.Focus();
                return;
            }
            if (txtretypepassword.Text == "")
            {
                MessageBox.Show("Please re-type your password");
                txtretypepassword.Focus();
                return;
            }
            if (txtretypepassword.Text != txtpassword.Text)
            {
                MessageBox.Show("Your passwords didn't match");
                txtpassword.Clear();
                txtretypepassword.Clear();
                txtpassword.Focus();
                return;
            }
            if (txtcontactno.Text == "")
            {
                MessageBox.Show("Please enter your Contact Number");
                txtcontactno.Focus();
                return;
            }
            connection = new OleDbConnection(cs);

            connection.Open();
            string ct = "select Username from Accounts where Username=@find";
            command = new OleDbCommand(ct);
            command.Connection = connection;
            command.Parameters.Add(new OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "Username"));
            command.Parameters["@find"].Value = txtusername.Text;
            rdr = command.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Text = "";
                txtusername.Focus();

                if ((rdr != null))
                {
                    rdr.Close();
                }
                return;
            }
            connection.Close();

            connection.Open();
            string query = "insert into Accounts(Firstname,Lastname,Username,User_Password,ContactNo) values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + txtcontactno.Text + "')";
            command = new OleDbCommand(query);
            command.Connection = connection;
            command.ExecuteNonQuery();           
            MessageBox.Show("Alright!");
            connection.Close();


//            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
            
//            con.Open();
//            com.Connection = con;
//            com.CommandText = "insert into Accounts(Firstname,Lastname,Username,User_Password,ContactNo) values('" + txtfname.Text + "','" + txtlname.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','"+ txtcontactno.Text +"')";
//            com.ExecuteNonQuery();
//            MessageBox.Show("Successfully Registered");           
//            con.Close();

            txtfname.Clear();
            txtlname.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtretypepassword.Clear();
            txtcontactno.Clear();
            txtfname.Focus();
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {           
        }
        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
        }
        private void txtlname_TextChanged(object sender, EventArgs e)
        {           
        }
        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtretypepassword.Clear();
            txtcontactno.Clear();
            txtfname.Focus();           
        }
        private void txtcontactno_TextChanged(object sender, EventArgs e)
        {            
        }
        private void txtcontactno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCnel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }       
        }
    }

