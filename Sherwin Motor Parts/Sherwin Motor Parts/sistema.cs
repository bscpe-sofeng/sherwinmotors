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
    public partial class sistema : Form
    {
        OleDbDataReader reader = null;
        OleDbConnection con = null;
        OleDbCommand com = null;
        String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
//        private OleDbConnection con = new OleDbConnection();
        
        public sistema()
        {
            InitializeComponent();
//            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
        }

        private void sistema_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            con = new OleDbConnection(constr);
            con.Open();
            String sql = "SELECT * from Products";
            com = new OleDbCommand(sql, con);
            reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (reader.Read() == true)
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            con.Close();
//            con.Open();
//            OleDbCommand com = new OleDbCommand();
//            com.Connection = con;
//            com.CommandType = CommandType.Text;
//            com.CommandText = "select * from Products";
//            com.ExecuteNonQuery();
//            DataTable dt = new DataTable();
//            OleDbDataAdapter da = new OleDbDataAdapter(com);
//            da.Fill(dt);
//            dataGridView1.DataSource = dt;
//            con.Close();
        }
      
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Hide();
                Login frm = new Login();
                frm.Show();              
            }
        }
        
        private void createNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccount uafrm = new NewAccount();
            uafrm.Show();
            uafrm.BringToFront();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {          
        }
        
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct Apfrm = new AddProduct();
            Apfrm.Show();
            Apfrm.BringToFront();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            disp_data();
        }
       
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AllUser AllUfrm = new AllUser();
            AllUfrm.Show();
            AllUfrm.BringToFront();
        }
        
        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpadateProduct UPfrm = new UpadateProduct();
            UPfrm.Show();
            UPfrm.BringToFront();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {            
        }        
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UAccount UAfrm = new UAccount();
            UAfrm.Show();
            UAfrm.BringToFront();
        }

        private void sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();          
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAccount DAfrm = new DeleteAccount();
            DAfrm.Show();
            DAfrm.BringToFront();
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct DPfrm = new DeleteProduct();
            DPfrm.Show();
            DPfrm.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = System.DateTime.Now.ToString();
        }

        private void viewCustomerRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VCRecords VCRfrm = new VCRecords();
            VCRfrm.Show();
            VCRfrm.BringToFront();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer NCfrm = new NewCustomer();
            NCfrm.Show();
            NCfrm.BringToFront();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewTransaction NTfrm = new NewTransaction();
            NTfrm.Show();
            NTfrm.BringToFront();
        }                
      }
    }

