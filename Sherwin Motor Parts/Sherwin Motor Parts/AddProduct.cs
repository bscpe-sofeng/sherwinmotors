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
    public partial class AddProduct : Form
    {
        OleDbDataReader reader = null;
        OleDbConnection con = null;
        OleDbCommand com = null;
        String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
//        OleDbConnection con = new OleDbConnection();
//        OleDbCommand com = new OleDbCommand();

        public AddProduct()
        {
            InitializeComponent();
//            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";
        }        

        private void btnAPclear_Click(object sender, EventArgs e)
        {
            txtProname.Clear();
            txtSupplier.Clear();
            txtPDescription.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtTAmount.Clear();
            txtProname.Focus();
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

        private void btnaddtoinventory_Click(object sender, EventArgs e)
        {
 //           Int32 val1 = Convert.ToInt32(txtQuantity.Text);
 //           Int32 val2 = Convert.ToInt32(txtPrice.Text);
//            Int32 val3 = val1 * val2;
 //           txtTAmount.Text = Convert.ToString(val3);

            if (txtProname.Text == "")
            {
                MessageBox.Show("Please enter the product's name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProname.Focus();
                return;
            }
            if (txtSupplier.Text == "")
            {
                MessageBox.Show("Please enter the supplier's name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSupplier.Focus();
                return;
            }
            if (txtPDescription.Text == "")
            {
                MessageBox.Show("Please enter the product description.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPDescription.Focus();
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter the product quantity.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantity.Focus();
                return;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter the product price.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrice.Focus();
                return;
            }

            con = new OleDbConnection(constr);
            con.Open();
            String sc = "insert into Products(Product_Name,Supplier_Name,Product_Description,Product_Quantity,Price,Total_Amount) values('" + txtProname.Text + "','" + txtSupplier.Text + "','" + txtPDescription.Text + "','" + txtQuantity.Text + "','" + txtPrice.Text + "','"+txtTAmount.Text+"')";
            com = new OleDbCommand(sc, con);
            reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
            while (reader.Read() == true)
            {
                dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
            }
            con.Close();
            
           
//            con.Open();
//            com.Connection = con;
//            com.CommandText = "insert into Products(Product_Name,Supplier_Name,Product_Description,Product_Quantity,Total_Price) values('" + txtProname.Text + "','" + txtSupplier.Text + "','" + txtPDescription.Text + "','" + txtQuantity.Text + "','" + txtTPrice.Text + "')";           
//            com.ExecuteNonQuery();
//            con.Close();
            disp_data();
            MessageBox.Show("Alright", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtProname.Clear();
            txtSupplier.Clear();
            txtPDescription.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtTAmount.Clear();
            txtProname.Focus();
        }

        private void txtPDescription_TextChanged(object sender, EventArgs e)
        {           
        }
        private void txtPDescription_KeyPress(object sender, KeyPressEventArgs e)
        {           
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                txtTAmount.Text = (Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();                      
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                txtTAmount.Text = (Convert.ToDecimal(txtQuantity.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();                   
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddProduct_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {          
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }       

        private void txtTAmount_TextChanged(object sender, EventArgs e)
        {
 //           Int32 val1 = Convert.ToInt32(txtQuantity.Text);
  //          Int32 val2 = Convert.ToInt32(txtPrice.Text);
  //          Int32 val3 = val1 * val2;
  //          txtTAmount.Text = Convert.ToString(val3);
        }

        private void txtTAmount_KeyPress(object sender, KeyPressEventArgs e)
        {           
        }
    }
}
