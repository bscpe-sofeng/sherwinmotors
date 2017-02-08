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
    public partial class NewTransaction : Form
    {
        OleDbDataReader reader = null;
        OleDbConnection con = null;
        OleDbCommand com = null;
        String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Smp.accdb;";

        public NewTransaction()
        {
            InitializeComponent();
        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchCstmr_Click(object sender, EventArgs e)
        {
            this.Hide();
            VCRecords1 VCR1frm = new VCRecords1();
            VCR1frm.Show();
            VCR1frm.BringToFront();
        }

        private void btnAddCstmr_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCustomer NCfrm = new NewCustomer();
            NCfrm.Show();
            NCfrm.BringToFront();
        }

        private void btnNTClear_Click(object sender, EventArgs e)
        {
            txtCID.Clear();
            txtCfname.Clear();
            txtClname.Clear();
            txtCfname.Focus();
        }

      
    }
}