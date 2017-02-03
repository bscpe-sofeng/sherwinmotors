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
//        OleDbConnection con = new OleDbConnection();
 //       OleDbCommand com = new OleDbCommand();
        OleDbDataReader reader = null;
        OleDbConnection con = null;
        OleDbCommand com = null;
        String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

        public UpadateProduct()
        {
            InitializeComponent();
 //           con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
        }

        private void UpadateProduct_Load(object sender, EventArgs e)
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
                MessageBox.Show("Please enter the Product ID Number");
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
            String sql = "update Products set Product_Name = '" + txtEProductN.Text + "',Supplier_Name = '" + txtESupplierN.Text + "',Product_Description = '" + txtEPDescription.Text + "',Product_Quantity ='" + txtEQuantity.Text + "',Price = '" + txtEPrice.Text + "',Total_Amount ='" + txtToAmount.Text + "' where ProductID =" + txtEProductID.Text + "";
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
//            string query = "update Products set Product_Name = '" + txtEProductN.Text + "',Supplier_Name = '" + txtESupplierN.Text + "',Product_Description = '" + txtEPDescription.Text + "',Product_Quantity ='" + txtEQuantity.Text + "',Price = '" + txtEPrice.Text + "',Total_Amount ='"+txtToAmount.Text+"' where ProductID =" + txtEProductID.Text + "";
//            com.CommandText = query;
//            com.ExecuteNonQuery();
//            con.Close();
            disp_data();
            MessageBox.Show("Product edit successful");
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

        private void txtESupplierCon_KeyPress(object sender, KeyPressEventArgs e)
        {           
        }
        private void txtEQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEQuantity.Text) && !string.IsNullOrEmpty(txtEPrice.Text))
                txtToAmount.Text = (Convert.ToInt32(txtEQuantity.Text) * Convert.ToInt32(txtEPrice.Text)).ToString();
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
        private void txtETPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEQuantity.Text) && !string.IsNullOrEmpty(txtEPrice.Text))
                txtToAmount.Text = (Convert.ToInt32(txtEQuantity.Text) * Convert.ToInt32(txtEPrice.Text)).ToString();
        }

        private void txtETPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnECancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }       
        }
    }

