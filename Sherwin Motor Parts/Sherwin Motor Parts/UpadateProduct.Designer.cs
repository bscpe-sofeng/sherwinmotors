namespace Sherwin_Motor_Parts
{
    partial class UpadateProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEProductID = new System.Windows.Forms.TextBox();
            this.txtEProductN = new System.Windows.Forms.TextBox();
            this.txtESupplierN = new System.Windows.Forms.TextBox();
            this.txtEPDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEQuantity = new System.Windows.Forms.TextBox();
            this.btnESave = new System.Windows.Forms.Button();
            this.btnEClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnECancel = new System.Windows.Forms.Button();
            this.txtESearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToAmount = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(3, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Product Number:";
            // 
            // txtEProductID
            // 
            this.txtEProductID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEProductID.Location = new System.Drawing.Point(150, 13);
            this.txtEProductID.Name = "txtEProductID";
            this.txtEProductID.Size = new System.Drawing.Size(97, 22);
            this.txtEProductID.TabIndex = 1;
            this.txtEProductID.TextChanged += new System.EventHandler(this.txtEProductID_TextChanged);
            this.txtEProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEProductID_KeyPress);
            // 
            // txtEProductN
            // 
            this.txtEProductN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEProductN.Location = new System.Drawing.Point(150, 43);
            this.txtEProductN.Name = "txtEProductN";
            this.txtEProductN.Size = new System.Drawing.Size(501, 22);
            this.txtEProductN.TabIndex = 2;
            // 
            // txtESupplierN
            // 
            this.txtESupplierN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtESupplierN.Location = new System.Drawing.Point(150, 75);
            this.txtESupplierN.Name = "txtESupplierN";
            this.txtESupplierN.Size = new System.Drawing.Size(501, 22);
            this.txtESupplierN.TabIndex = 3;
            // 
            // txtEPDescription
            // 
            this.txtEPDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEPDescription.Location = new System.Drawing.Point(150, 106);
            this.txtEPDescription.Name = "txtEPDescription";
            this.txtEPDescription.Size = new System.Drawing.Size(501, 22);
            this.txtEPDescription.TabIndex = 4;
            this.txtEPDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtESupplierCon_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Supplier Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtToAmount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEQuantity);
            this.groupBox1.Controls.Add(this.txtEPDescription);
            this.groupBox1.Controls.Add(this.txtESupplierN);
            this.groupBox1.Controls.Add(this.txtEProductN);
            this.groupBox1.Controls.Add(this.txtEProductID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtEPrice
            // 
            this.txtEPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEPrice.Location = new System.Drawing.Point(332, 136);
            this.txtEPrice.Name = "txtEPrice";
            this.txtEPrice.Size = new System.Drawing.Size(97, 22);
            this.txtEPrice.TabIndex = 6;
            this.txtEPrice.TextChanged += new System.EventHandler(this.txtETPrice_TextChanged);
            this.txtEPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtETPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantity:";
            // 
            // txtEQuantity
            // 
            this.txtEQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEQuantity.Location = new System.Drawing.Point(150, 136);
            this.txtEQuantity.Name = "txtEQuantity";
            this.txtEQuantity.Size = new System.Drawing.Size(97, 22);
            this.txtEQuantity.TabIndex = 5;
            this.txtEQuantity.TextChanged += new System.EventHandler(this.txtEQuantity_TextChanged);
            this.txtEQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEQuantity_KeyPress);
            // 
            // btnESave
            // 
            this.btnESave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESave.Location = new System.Drawing.Point(207, 14);
            this.btnESave.Name = "btnESave";
            this.btnESave.Size = new System.Drawing.Size(115, 26);
            this.btnESave.TabIndex = 0;
            this.btnESave.Text = "Save Changes";
            this.btnESave.UseVisualStyleBackColor = true;
            this.btnESave.Click += new System.EventHandler(this.btnESave_Click);
            // 
            // btnEClear
            // 
            this.btnEClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEClear.Location = new System.Drawing.Point(338, 14);
            this.btnEClear.Name = "btnEClear";
            this.btnEClear.Size = new System.Drawing.Size(97, 26);
            this.btnEClear.TabIndex = 1;
            this.btnEClear.Text = "Clear";
            this.btnEClear.UseVisualStyleBackColor = true;
            this.btnEClear.Click += new System.EventHandler(this.btnEClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnECancel);
            this.groupBox2.Controls.Add(this.btnEClear);
            this.groupBox2.Controls.Add(this.btnESave);
            this.groupBox2.Location = new System.Drawing.Point(5, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 49);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnECancel
            // 
            this.btnECancel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnECancel.Location = new System.Drawing.Point(450, 14);
            this.btnECancel.Name = "btnECancel";
            this.btnECancel.Size = new System.Drawing.Size(97, 26);
            this.btnECancel.TabIndex = 2;
            this.btnECancel.Text = "Cancel";
            this.btnECancel.UseVisualStyleBackColor = true;
            this.btnECancel.Click += new System.EventHandler(this.btnECancel_Click_1);
            // 
            // txtESearch
            // 
            this.txtESearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtESearch.Location = new System.Drawing.Point(108, 14);
            this.txtESearch.Name = "txtESearch";
            this.txtESearch.Size = new System.Drawing.Size(545, 22);
            this.txtESearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Product:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtESearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(3, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 43);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(467, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Amount:";
            // 
            // txtToAmount
            // 
            this.txtToAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToAmount.Location = new System.Drawing.Point(555, 136);
            this.txtToAmount.Name = "txtToAmount";
            this.txtToAmount.ReadOnly = true;
            this.txtToAmount.Size = new System.Drawing.Size(97, 22);
            this.txtToAmount.TabIndex = 8;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Supplier";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Amount";
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // UpadateProduct
            // 
            this.AcceptButton = this.btnESave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 502);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UpadateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upadate/Edit Product";
            this.Load += new System.EventHandler(this.UpadateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEProductID;
        private System.Windows.Forms.TextBox txtEProductN;
        private System.Windows.Forms.TextBox txtESupplierN;
        private System.Windows.Forms.TextBox txtEPDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnESave;
        private System.Windows.Forms.Button btnEClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnECancel;
        private System.Windows.Forms.TextBox txtESearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}