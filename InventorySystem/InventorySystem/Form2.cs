using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter your Last Name!");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please enter your First Name!");
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Please enter your Middle Name!");
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please enter your User Name!");
            }
            if (textBox7.Text == "")
            {
                MessageBox.Show("Please enter your Password!");
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("Please Re-type your Password!");
            }
            if ((textBox7.Text == textBox8.Text))
            {
                MessageBox.Show("Password Confirm!");
            }
            if ((textBox7.Text != textBox8.Text))
            {
                MessageBox.Show("Password did not match!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
