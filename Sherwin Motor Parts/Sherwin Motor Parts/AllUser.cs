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
    public partial class AllUser : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        public AllUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AllUser_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;

            string query = "select Firstname,Lastname,Username,ContactNo from Accounts";
            com.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AllUser_FormClosing(object sender, FormClosingEventArgs e)
        {            
        }
    }
}
