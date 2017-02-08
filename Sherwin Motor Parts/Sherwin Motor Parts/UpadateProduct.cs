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
    public partial class UpadateProduct : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader reader = null;
        DataGridViewRow drow = null;
        
        String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

        public UpadateProduct()
        {
            InitializeComponent(); 
        }

        private void UpadateProduct_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()    
        {
            dataGridView1.AllowUserToAddRows = false;
            con = new OleDbConnection(constr);
            con.Open();
            String sc = "SELECT * from Products";
            com = new OleDbCommand(sc, con);
            reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (reader.Read() == true)
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            con.Close();
        }
       
        private void btnEClear_Click(object sender, EventArgs e)
        {           
            txtEProductID.Clear();
            txtEProductN.Clear();
            txtESupplierN.Clear();
            txtEPDescription.Clear();
            txtEQuantity.Clear();
            txtEPrice.Clear();
            txtESearch.Clear();
            txtToAmount.Clear();
            txtEProductID.Focus();
        }

        private void btnESave_Click(object sender, EventArgs e)
        {
            if (txtEProductID.Text == "")
            {
                MessageBox.Show("Please select a row from the table");
                txtEProductID.Focus();
                return;
            }
            if (txtEProductN.Text == "")
            {
                MessageBox.Show("Please enter the product name ");
                txtEProductN.Focus();
                return;
            }
            if (txtESupplierN.Text == "")
            {
                MessageBox.Show("Please enter the supplier's name");
                txtESupplierN.Focus();
                return;
            }
            if (txtEPDescription.Text == "")
            {
                MessageBox.Show("Please enter the product description");
                txtEPDescription.Focus();
                return;
            }
            if (txtEQuantity.Text == "")
            {
                MessageBox.Show("Please enter the product quantity");
                txtEQuantity.Focus();
                return;
            }
            if (txtEPrice.Text == "")
            {
                MessageBox.Show("Please enter the product price");
                txtEPrice.Focus();
                return;
            }
            con = new OleDbConnection(constr);

            con.Open();
            string ct = "select ProductID from Products where ProductID=@pid";
            com = new OleDbCommand(ct);
            com.Connection = con;
            com.Parameters.Add(new OleDbParameter("@pid", System.Data.OleDb.OleDbType.VarChar, 30, "ProductID"));
            com.Parameters["@pid"].Value = txtEProductID.Text;
            reader = com.ExecuteReader();

            if (reader.Read() == false)
            {
                MessageBox.Show("Product ID number does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEProductID.Text = "";
                txtEProductID.Focus();

                if ((reader != null))
                {
                    reader.Close();
                }
                return;
            }

            if (MessageBox.Show("Are you sure you want to save the changes you've made?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Product editting/updating successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 

            con = new OleDbConnection(constr);
            con.Open();
            String sql = "update Products set Product_Name = '" + txtEProductN.Text + "',Supplier_Name = '" + txtESupplierN.Text + "',Product_Description = '" + txtEPDescription.Text + "',Product_Quantity ='" + txtEQuantity.Text + "',Price = '" + txtEPrice.Text + "',Total_Amount ='" + txtToAmount.Text + "' where ProductID =" + txtEProductID.Text + "";
            com = new OleDbCommand(sql, con);
            reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (reader.Read() == true)
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            con.Close();
            disp_data();

            txtEProductID.Clear();
            txtEProductN.Clear();
            txtESupplierN.Clear();
            txtEPDescription.Clear();
            txtEQuantity.Clear();
            txtEPrice.Clear();
            txtESearch.Clear();
            txtToAmount.Clear();
            txtEProductN.Focus();
        }

        private void txtEProductID_TextChanged(object sender, EventArgs e)
        {           
        }
        private void txtEProductID_KeyPress(object sender, KeyPressEventArgs e)
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
       
        private void txtEQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEQuantity.Text) && !string.IsNullOrEmpty(txtEPrice.Text))
                txtToAmount.Text = (Convert.ToDecimal(txtEQuantity.Text) * Convert.ToDecimal(txtEPrice.Text)).ToString();
        }

        private void txtEQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtEPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEQuantity.Text) && !string.IsNullOrEmpty(txtEPrice.Text))
                txtToAmount.Text = (Convert.ToDecimal(txtEQuantity.Text) * Convert.ToDecimal(txtEPrice.Text)).ToString();
        }

        private void txtEPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
                      
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }      

        private void btnECancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {           
            
            DataGridViewRow drow = dataGridView1.SelectedRows[0];

            txtEProductID.Text = drow.Cells[0].Value.ToString();
            txtEProductN.Text = drow.Cells[1].Value.ToString();
            txtESupplierN.Text = drow.Cells[2].Value.ToString();
            txtEPDescription.Text = drow.Cells[3].Value.ToString();
            txtEQuantity.Text = drow.Cells[4].Value.ToString();
            txtEPrice.Text = drow.Cells[5].Value.ToString();
        }

        private void txtESearch_TextChanged(object sender, EventArgs e)
        {
            con = new OleDbConnection(constr);
            con.Open();
            String cs = "select * from Products where Product_Name like '"+txtESearch.Text+"%' order by ProductID"; 
            com = new OleDbCommand(cs, con);
//            OleDbDataAdapter da = new OleDbDataAdapter(com);
//            DataSet ds = new DataSet();
//            da.Fill(ds, "Products");
//            dataGridView1.DataSource = ds.Tables["Products"].DefaultView;
            reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (reader.Read() == true)
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            con.Close();
        }                         
        }
    }

