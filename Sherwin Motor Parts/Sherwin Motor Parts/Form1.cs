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
    public partial class Login : Form
    {
        String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
        
        public Login()
        {
            InitializeComponent();            
        }       
                
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "")
            {
                MessageBox.Show("Please enter your username");
                txtuname.Focus();
                return;
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("Please enter your password");
                txtpass.Focus();
                return;
            }            
            OleDbConnection connection = default(OleDbConnection);
            connection = new OleDbConnection(cs);
            OleDbCommand command = default(OleDbCommand);
            command = new OleDbCommand("select Username,User_Password from Accounts where Username = @uname and User_Password = @pass", connection);
            OleDbParameter usernme = new OleDbParameter("@uname", OleDbType.VarChar);
            OleDbParameter passwrd = new OleDbParameter("@pass", OleDbType.VarChar);
            usernme.Value = txtuname.Text;
            passwrd.Value = txtpass.Text;
            command.Parameters.Add(usernme);
            command.Parameters.Add(passwrd);

            command.Connection.Open();
            OleDbDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            if (reader.Read() == true)
              {
                sistema frm = new sistema();
                this.Hide();
                frm.Show();             
            }
            else
            {
                MessageBox.Show("Invalid username and password");
                txtuname.Clear();
                txtpass.Clear();
                txtuname.Focus();
            }
            if (connection.State == ConnectionState.Open) 
            {
                connection.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtuname.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
