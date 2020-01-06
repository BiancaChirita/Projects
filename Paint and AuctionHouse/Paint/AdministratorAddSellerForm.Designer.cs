namespace Paint
{
    partial class AdministratorAddSellerForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.auctionsDatabaseDataSet2 = new Paint.AuctionsDatabaseDataSet2();
            this.sellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellerTableAdapter = new Paint.AuctionsDatabaseDataSet2TableAdapters.SellerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdSeller = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstNameSeller = new System.Windows.Forms.TextBox();
            this.txtLastNameSeller = new System.Windows.Forms.TextBox();
            this.txtAddressSeller = new System.Windows.Forms.TextBox();
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.btnClearSeller = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditFirstNameSel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditFirstNameSel = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditLastNameSel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditLastNameSel = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditAddressSel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditAddressSel = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSeller = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeleteSeller = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sellerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(268, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // auctionsDatabaseDataSet2
            // 
            this.auctionsDatabaseDataSet2.DataSetName = "AuctionsDatabaseDataSet2";
            this.auctionsDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellerBindingSource
            // 
            this.sellerBindingSource.DataMember = "Seller";
            this.sellerBindingSource.DataSource = this.auctionsDatabaseDataSet2;
            // 
            // sellerTableAdapter
            // 
            this.sellerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearSeller);
            this.groupBox1.Controls.Add(this.btnAddSeller);
            this.groupBox1.Controls.Add(this.txtAddressSeller);
            this.groupBox1.Controls.Add(this.txtLastNameSeller);
            this.groupBox1.Controls.Add(this.txtFirstNameSeller);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdSeller);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Seller";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // txtIdSeller
            // 
            this.txtIdSeller.Location = new System.Drawing.Point(91, 27);
            this.txtIdSeller.Name = "txtIdSeller";
            this.txtIdSeller.Size = new System.Drawing.Size(140, 22);
            this.txtIdSeller.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // txtFirstNameSeller
            // 
            this.txtFirstNameSeller.Location = new System.Drawing.Point(91, 62);
            this.txtFirstNameSeller.Name = "txtFirstNameSeller";
            this.txtFirstNameSeller.Size = new System.Drawing.Size(140, 22);
            this.txtFirstNameSeller.TabIndex = 6;
            // 
            // txtLastNameSeller
            // 
            this.txtLastNameSeller.Location = new System.Drawing.Point(91, 97);
            this.txtLastNameSeller.Name = "txtLastNameSeller";
            this.txtLastNameSeller.Size = new System.Drawing.Size(140, 22);
            this.txtLastNameSeller.TabIndex = 7;
            // 
            // txtAddressSeller
            // 
            this.txtAddressSeller.Location = new System.Drawing.Point(91, 132);
            this.txtAddressSeller.Name = "txtAddressSeller";
            this.txtAddressSeller.Size = new System.Drawing.Size(140, 22);
            this.txtAddressSeller.TabIndex = 3;
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.Location = new System.Drawing.Point(7, 170);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(75, 23);
            this.btnAddSeller.TabIndex = 8;
            this.btnAddSeller.Text = "Add";
            this.btnAddSeller.UseVisualStyleBackColor = true;
            // 
            // btnClearSeller
            // 
            this.btnClearSeller.Location = new System.Drawing.Point(156, 170);
            this.btnClearSeller.Name = "btnClearSeller";
            this.btnClearSeller.Size = new System.Drawing.Size(75, 23);
            this.btnClearSeller.TabIndex = 9;
            this.btnClearSeller.Text = "Clear";
            this.btnClearSeller.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditFirstNameSel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEditFirstNameSel);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 104);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit First Name";
            // 
            // btnEditFirstNameSel
            // 
            this.btnEditFirstNameSel.Location = new System.Drawing.Point(6, 73);
            this.btnEditFirstNameSel.Name = "btnEditFirstNameSel";
            this.btnEditFirstNameSel.Size = new System.Drawing.Size(75, 23);
            this.btnEditFirstNameSel.TabIndex = 4;
            this.btnEditFirstNameSel.Text = "Ok";
            this.btnEditFirstNameSel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "First Name";
            // 
            // txtEditFirstNameSel
            // 
            this.txtEditFirstNameSel.Location = new System.Drawing.Point(91, 32);
            this.txtEditFirstNameSel.Name = "txtEditFirstNameSel";
            this.txtEditFirstNameSel.Size = new System.Drawing.Size(140, 22);
            this.txtEditFirstNameSel.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditLastNameSel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtEditLastNameSel);
            this.groupBox3.Location = new System.Drawing.Point(12, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 104);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Last Name";
            // 
            // btnEditLastNameSel
            // 
            this.btnEditLastNameSel.Location = new System.Drawing.Point(6, 73);
            this.btnEditLastNameSel.Name = "btnEditLastNameSel";
            this.btnEditLastNameSel.Size = new System.Drawing.Size(75, 23);
            this.btnEditLastNameSel.TabIndex = 4;
            this.btnEditLastNameSel.Text = "Ok";
            this.btnEditLastNameSel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Last Name";
            // 
            // txtEditLastNameSel
            // 
            this.txtEditLastNameSel.Location = new System.Drawing.Point(91, 32);
            this.txtEditLastNameSel.Name = "txtEditLastNameSel";
            this.txtEditLastNameSel.Size = new System.Drawing.Size(140, 22);
            this.txtEditLastNameSel.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEditAddressSel);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtEditAddressSel);
            this.groupBox4.Location = new System.Drawing.Point(699, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 104);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Address";
            // 
            // btnEditAddressSel
            // 
            this.btnEditAddressSel.Location = new System.Drawing.Point(6, 73);
            this.btnEditAddressSel.Name = "btnEditAddressSel";
            this.btnEditAddressSel.Size = new System.Drawing.Size(75, 23);
            this.btnEditAddressSel.TabIndex = 4;
            this.btnEditAddressSel.Text = "Ok";
            this.btnEditAddressSel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Address";
            // 
            // txtEditAddressSel
            // 
            this.txtEditAddressSel.Location = new System.Drawing.Point(91, 32);
            this.txtEditAddressSel.Name = "txtEditAddressSel";
            this.txtEditAddressSel.Size = new System.Drawing.Size(140, 22);
            this.txtEditAddressSel.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteSeller);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtDeleteSeller);
            this.groupBox5.Location = new System.Drawing.Point(699, 135);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 104);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delete Seller";
            // 
            // btnDeleteSeller
            // 
            this.btnDeleteSeller.Location = new System.Drawing.Point(6, 73);
            this.btnDeleteSeller.Name = "btnDeleteSeller";
            this.btnDeleteSeller.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSeller.TabIndex = 4;
            this.btnDeleteSeller.Text = "Delete";
            this.btnDeleteSeller.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Id";
            // 
            // txtDeleteSeller
            // 
            this.txtDeleteSeller.Location = new System.Drawing.Point(91, 32);
            this.txtDeleteSeller.Name = "txtDeleteSeller";
            this.txtDeleteSeller.Size = new System.Drawing.Size(140, 22);
            this.txtDeleteSeller.TabIndex = 2;
            // 
            // AdministratorAddSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 544);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdministratorAddSellerForm";
            this.Text = "AdministratorAddSellerForm";
            this.Load += new System.EventHandler(this.AdministratorAddSellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AuctionsDatabaseDataSet2 auctionsDatabaseDataSet2;
        private System.Windows.Forms.BindingSource sellerBindingSource;
        private AuctionsDatabaseDataSet2TableAdapters.SellerTableAdapter sellerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdSeller;
        private System.Windows.Forms.Button btnClearSeller;
        private System.Windows.Forms.Button btnAddSeller;
        private System.Windows.Forms.TextBox txtAddressSeller;
        private System.Windows.Forms.TextBox txtLastNameSeller;
        private System.Windows.Forms.TextBox txtFirstNameSeller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditFirstNameSel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditFirstNameSel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditLastNameSel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditLastNameSel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEditAddressSel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditAddressSel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDeleteSeller;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeleteSeller;
    }
}