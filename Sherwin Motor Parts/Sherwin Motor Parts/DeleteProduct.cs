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
    public partial class DeleteProduct : Form
    {
//        OleDbConnection con = new OleDbConnection();
//        OleDbCommand com = new OleDbCommand();
        OleDbDataReader reader = null;
        OleDbConnection con = null;
        OleDbCommand com = null;
        String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

        public DeleteProduct()
        {
            InitializeComponent();
//            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        private void disp_data()
        {
            dataGridView1.AllowUserToAddRows = false;
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

        private void btnDPcancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtDProductID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDProductID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtDProductID.Clear();
            }
        }

        private void btnDPdelete_Click(object sender, EventArgs e)
        {
            if (txtDProductID.Text == "")
            {
                MessageBox.Show("Please enter the Product's ID number you want to delete.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDProductID.Focus();
                return;
            }
            
            con = new OleDbConnection(constr);

            con.Open();
            string ct = "select ProductID from Products where ProductID=@pid";
            com = new OleDbCommand(ct);
            com.Connection = con;
            com.Parameters.Add(new OleDbParameter("@pid", System.Data.OleDb.OleDbType.VarChar, 30, "ProductID"));
            com.Parameters["@pid"].Value = txtDProductID.Text;
            reader = com.ExecuteReader();

            if (reader.Read() == false)
            {
                MessageBox.Show("Product ID number does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDProductID.Text = "";
                txtDProductID.Focus();

                if ((reader != null))
                {
                    reader.Close();
                }
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this product?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                con = new OleDbConnection(constr);
                con.Open();
                String sql = "delete from Products where ProductId =" + txtDProductID.Text + "";
                com = new OleDbCommand(sql, con);
                reader = com.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (reader.Read() == true)
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                }
                con.Close();
                disp_data();
                //                con.Open();
                //                com.Connection = con;
                //                string query = "delete from Products where ProductID =" + txtDProductID.Text + "";
                //                com.CommandText = query;
                //                com.ExecuteNonQuery();
                //                con.Close();
                //                disp_data();
                MessageBox.Show("Product was successfully deteled!");
            }
            else
            {
                txtDProductID.Clear();
            }
        }

        private void txtDSearch_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection(constr);
            con.Open();
            String cs = "select * from Products where Product_Name like '" + txtDSearch.Text + "%' order by ProductID";
            com = new OleDbCommand(cs, con);
            reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (reader.Read() == true)
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            con.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow drow = dataGridView1.SelectedRows[0];

            txtDProductID.Text = drow.Cells[0].Value.ToString();
//            txtEProductN.Text = drow.Cells[1].Value.ToString();
 //           txtESupplierN.Text = drow.Cells[2].Value.ToString();
  //          txtEPDescription.Text = drow.Cells[3].Value.ToString();
   //         txtEQuantity.Text = drow.Cells[4].Value.ToString();
    //        txtEPrice.Text = drow.Cells[5].Value.ToString();
        }
    }
}
