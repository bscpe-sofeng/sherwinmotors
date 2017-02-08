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
    public partial class VCRecords : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader reader = null;

        String cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

        public VCRecords()
        {
            InitializeComponent();
        }

        private void VCRecords_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(cs);
            con.Open();
            String sql = "SELECT * from Customers";
            com = new OleDbCommand(sql, con);
            reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (reader.Read() == true)
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
            }
            con.Close(); 
        }

        private void btnVCRclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
