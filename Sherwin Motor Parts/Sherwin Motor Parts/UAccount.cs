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
    public partial class UAccount : Form
    {
     
        OleDbConnection connection = new OleDbConnection();
        OleDbCommand command = null;
        OleDbDataReader rdr = null;
        
        String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

        public UAccount()
        {
            InitializeComponent();
       
        }       

        private void UAccount_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void disp_data()
        {
            dataGridView1.AllowUserToAddRows = false;
            connection = new OleDbConnection(cs);
            connection.Open();
            String sql = "SELECT User_ID,Firstname,Lastname,Username,User_Password,ContactNo from Accounts";
            command = new OleDbCommand(sql, connection);
            rdr = command.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (rdr.Read() == true)
            {
                dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
            }
            connection.Close();
//            connection = new OleDbConnection(cs);
//            connection.Open();
//            command.Connection = connection;
//            command.CommandType = CommandType.Text;
//            command.CommandText = "select User_ID,Firstname,Lastname,Username,ContactNo from Accounts";
//            command.ExecuteNonQuery();
//            DataTable dt = new DataTable();
//            OleDbDataAdapter da = new OleDbDataAdapter(command);
//            da.Fill(dt);
//            dataGridView1.DataSource = dt;
//            connection.Close();
      
        }


        private void UAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnUAccountSave_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Please select a row from the table");
                txtUserID.Focus();
                return;
            }
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
            string cts = "select User_ID from Accounts where User_ID=@uid";
            command = new OleDbCommand(cts);
            command.Connection = connection;
            command.Parameters.Add(new OleDbParameter("@uid", System.Data.OleDb.OleDbType.VarChar, 30, "User_ID"));
            command.Parameters["@uid"].Value = txtUserID.Text;
            rdr = command.ExecuteReader();

            if (rdr.Read() == false)
            {
                MessageBox.Show("User ID number does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserID.Text = "";
                txtUserID.Focus();

                if ((rdr != null))
                {
                    rdr.Close();
                }
                return;
            }
            
//            connection = new OleDbConnection(cs);
           
//                connection.Open();
//                string ct = "select Username from Accounts where Username=@find";
//                command = new OleDbCommand(ct);
//                command.Connection = connection;
//                command.Parameters.Add(new OleDbParameter("@find", System.Data.OleDb.OleDbType.VarChar, 30, "Username"));
//                command.Parameters["@find"].Value = txtusername.Text;
//                rdr = command.ExecuteReader();                

//                if (rdr.Read())
//                {
//                    MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    txtusername.Text = "";
//                    txtusername.Focus();

//                    if ((rdr != null))
//                    {
//                        rdr.Close();
//                    }
//                    return;
//                }
                connection.Close();

                if (MessageBox.Show("Are you sure you want to save the changes you've made?", "Update/Edit User Account Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Account editting/updating successful", "Update/Edit User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 

                connection.Open();
                string query = "update Accounts set Firstname = '" + txtfname.Text + "',Lastname = '" + txtlname.Text + "',Username = '" + txtusername.Text + "',User_Password ='" + txtpassword.Text + "',ContactNo = '" + txtcontactno.Text + "' where User_ID =" + txtUserID.Text + "";
                command = new OleDbCommand(query);
                command.Connection = connection;
                command.ExecuteNonQuery();
                disp_data();               
                connection.Close();

                txtUserID.Clear();
                txtfname.Clear();
                txtlname.Clear();
                txtusername.Clear();
                txtpassword.Clear();
                txtretypepassword.Clear();
                txtcontactno.Clear();
                txtUserID.Focus();     
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnUAccountCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
        }

        private void txtcontactno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtcontactno.Text, "[^0-9]"))
            {
                MessageBox.Show("Only numbers are allowed in this box.");
                txtcontactno.Clear();
            }
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

        private void btnEClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtretypepassword.Clear();
            txtcontactno.Clear();
            txtUserID.Focus();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow drow = dataGridView1.SelectedRows[0];

            txtUserID.Text = drow.Cells[0].Value.ToString();
            txtfname.Text = drow.Cells[1].Value.ToString();
            txtlname.Text = drow.Cells[2].Value.ToString();
            txtusername.Text = drow.Cells[3].Value.ToString(); 
            txtpassword.Text = drow.Cells[4].Value.ToString();       
            txtcontactno.Text = drow.Cells[5].Value.ToString();
        }       
    }
}
