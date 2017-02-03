﻿using System;
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
    public partial class DeleteAccount : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();

        public DeleteAccount()
        {
            InitializeComponent();
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
        }

        private void DeleteAccount_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        private void disp_data()
        {
            con.Open();            
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "select User_ID,Firstname,Lastname,Username,ContactNo from Accounts";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(com);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {            
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUserID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtUserID.Clear();
            }           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("Please enter the User's ID number you want to delete");
                txtUserID.Focus();
                return;
            }
            if (txtUserID.Text == "1")
            {
                MessageBox.Show("This account cannot be deleted.");
                txtUserID.Clear();
                txtUserID.Focus();
                return;
            }
            if (MessageBox.Show("Are you sure you want to delete this account?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    com.Connection = con;                    
                    string query = "delete from Accounts where User_ID ="+ txtUserID.Text + "";
                    com.CommandText = query;
                    com.ExecuteNonQuery();
                    con.Close();
                    disp_data();
                    MessageBox.Show("Account was successfully deteled!");
                }           
        }
    }
}
