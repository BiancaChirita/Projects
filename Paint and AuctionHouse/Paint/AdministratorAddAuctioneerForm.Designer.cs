namespace Paint
{
    partial class AdministratorAddAuctioneerForm
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
            this.auctionsDatabaseDataSet1 = new Paint.AuctionsDatabaseDataSet1();
            this.auctioneerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctioneerTableAdapter = new Paint.AuctionsDatabaseDataSet1TableAdapters.AuctioneerTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAuctioneer = new System.Windows.Forms.TextBox();
            this.btnAddAuctioneer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameAuctioneer = new System.Windows.Forms.TextBox();
            this.txtPhoneAuctioneer = new System.Windows.Forms.TextBox();
            this.txtAddressAuctioneer = new System.Windows.Forms.TextBox();
            this.txtEmailAuctioneer = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEditNameAuct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditNameAuct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditAddressAuct = new System.Windows.Forms.TextBox();
            this.btnEditAddressAuct = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditPhoneAuct = new System.Windows.Forms.Button();
            this.txtEditPhoneAuct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnEditEmailAuct = new System.Windows.Forms.Button();
            this.txtEditEmailAuct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAuct = new System.Windows.Forms.Button();
            this.txtDeleteAuct = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctioneerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.auctioneerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(269, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 520);
            this.dataGridView1.TabIndex = 0;
            // 
            // auctionsDatabaseDataSet1
            // 
            this.auctionsDatabaseDataSet1.DataSetName = "AuctionsDatabaseDataSet1";
            this.auctionsDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auctioneerBindingSource
            // 
            this.auctioneerBindingSource.DataMember = "Auctioneer";
            this.auctioneerBindingSource.DataSource = this.auctionsDatabaseDataSet1;
            // 
            // auctioneerTableAdapter
            // 
            this.auctioneerTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAddAuctioneer);
            this.groupBox1.Controls.Add(this.txtEmailAuctioneer);
            this.groupBox1.Controls.Add(this.txtAddressAuctioneer);
            this.groupBox1.Controls.Add(this.txtPhoneAuctioneer);
            this.groupBox1.Controls.Add(this.txtNameAuctioneer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdAuctioneer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Auctioneer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txtIdAuctioneer
            // 
            this.txtIdAuctioneer.Location = new System.Drawing.Point(75, 27);
            this.txtIdAuctioneer.Name = "txtIdAuctioneer";
            this.txtIdAuctioneer.Size = new System.Drawing.Size(156, 22);
            this.txtIdAuctioneer.TabIndex = 1;
            // 
            // btnAddAuctioneer
            // 
            this.btnAddAuctioneer.Location = new System.Drawing.Point(6, 205);
            this.btnAddAuctioneer.Name = "btnAddAuctioneer";
            this.btnAddAuctioneer.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuctioneer.TabIndex = 2;
            this.btnAddAuctioneer.Text = "Add";
            this.btnAddAuctioneer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // txtNameAuctioneer
            // 
            this.txtNameAuctioneer.Location = new System.Drawing.Point(75, 62);
            this.txtNameAuctioneer.Name = "txtNameAuctioneer";
            this.txtNameAuctioneer.Size = new System.Drawing.Size(156, 22);
            this.txtNameAuctioneer.TabIndex = 6;
            // 
            // txtPhoneAuctioneer
            // 
            this.txtPhoneAuctioneer.Location = new System.Drawing.Point(75, 132);
            this.txtPhoneAuctioneer.Name = "txtPhoneAuctioneer";
            this.txtPhoneAuctioneer.Size = new System.Drawing.Size(156, 22);
            this.txtPhoneAuctioneer.TabIndex = 7;
            // 
            // txtAddressAuctioneer
            // 
            this.txtAddressAuctioneer.Location = new System.Drawing.Point(76, 97);
            this.txtAddressAuctioneer.Name = "txtAddressAuctioneer";
            this.txtAddressAuctioneer.Size = new System.Drawing.Size(155, 22);
            this.txtAddressAuctioneer.TabIndex = 8;
            // 
            // txtEmailAuctioneer
            // 
            this.txtEmailAuctioneer.Location = new System.Drawing.Point(75, 167);
            this.txtEmailAuctioneer.Name = "txtEmailAuctioneer";
            this.txtEmailAuctioneer.Size = new System.Drawing.Size(156, 22);
            this.txtEmailAuctioneer.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 205);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditNameAuct);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEditNameAuct);
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Name";
            // 
            // txtEditNameAuct
            // 
            this.txtEditNameAuct.Location = new System.Drawing.Point(75, 32);
            this.txtEditNameAuct.Name = "txtEditNameAuct";
            this.txtEditNameAuct.Size = new System.Drawing.Size(156, 22);
            this.txtEditNameAuct.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name";
            // 
            // btnEditNameAuct
            // 
            this.btnEditNameAuct.Location = new System.Drawing.Point(6, 73);
            this.btnEditNameAuct.Name = "btnEditNameAuct";
            this.btnEditNameAuct.Size = new System.Drawing.Size(75, 23);
            this.btnEditNameAuct.TabIndex = 4;
            this.btnEditNameAuct.Text = "Ok";
            this.btnEditNameAuct.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditAddressAuct);
            this.groupBox3.Controls.Add(this.txtEditAddressAuct);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 103);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Address";
            // 
            // txtEditAddressAuct
            // 
            this.txtEditAddressAuct.Location = new System.Drawing.Point(75, 33);
            this.txtEditAddressAuct.Name = "txtEditAddressAuct";
            this.txtEditAddressAuct.Size = new System.Drawing.Size(156, 22);
            this.txtEditAddressAuct.TabIndex = 5;
            // 
            // btnEditAddressAuct
            // 
            this.btnEditAddressAuct.Location = new System.Drawing.Point(6, 71);
            this.btnEditAddressAuct.Name = "btnEditAddressAuct";
            this.btnEditAddressAuct.Size = new System.Drawing.Size(75, 23);
            this.btnEditAddressAuct.TabIndex = 6;
            this.btnEditAddressAuct.Text = "Ok";
            this.btnEditAddressAuct.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEditPhoneAuct);
            this.groupBox4.Controls.Add(this.txtEditPhoneAuct);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(699, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 103);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Phone";
            // 
            // btnEditPhoneAuct
            // 
            this.btnEditPhoneAuct.Location = new System.Drawing.Point(6, 71);
            this.btnEditPhoneAuct.Name = "btnEditPhoneAuct";
            this.btnEditPhoneAuct.Size = new System.Drawing.Size(75, 23);
            this.btnEditPhoneAuct.TabIndex = 6;
            this.btnEditPhoneAuct.Text = "Ok";
            this.btnEditPhoneAuct.UseVisualStyleBackColor = true;
            // 
            // txtEditPhoneAuct
            // 
            this.txtEditPhoneAuct.Location = new System.Drawing.Point(75, 33);
            this.txtEditPhoneAuct.Name = "txtEditPhoneAuct";
            this.txtEditPhoneAuct.Size = new System.Drawing.Size(156, 22);
            this.txtEditPhoneAuct.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phone";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEditEmailAuct);
            this.groupBox5.Controls.Add(this.txtEditEmailAuct);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(699, 137);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 103);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edit Email";
            // 
            // btnEditEmailAuct
            // 
            this.btnEditEmailAuct.Location = new System.Drawing.Point(6, 71);
            this.btnEditEmailAuct.Name = "btnEditEmailAuct";
            this.btnEditEmailAuct.Size = new System.Drawing.Size(75, 23);
            this.btnEditEmailAuct.TabIndex = 6;
            this.btnEditEmailAuct.Text = "Ok";
            this.btnEditEmailAuct.UseVisualStyleBackColor = true;
            // 
            // txtEditEmailAuct
            // 
            this.txtEditEmailAuct.Location = new System.Drawing.Point(75, 33);
            this.txtEditEmailAuct.Name = "txtEditEmailAuct";
            this.txtEditEmailAuct.Size = new System.Drawing.Size(156, 22);
            this.txtEditEmailAuct.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Email";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDeleteAuct);
            this.groupBox6.Controls.Add(this.txtDeleteAuct);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(699, 264);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(237, 103);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Delete Auctioneer";
            // 
            // btnDeleteAuct
            // 
            this.btnDeleteAuct.Location = new System.Drawing.Point(6, 71);
            this.btnDeleteAuct.Name = "btnDeleteAuct";
            this.btnDeleteAuct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAuct.TabIndex = 6;
            this.btnDeleteAuct.Text = "Delete";
            this.btnDeleteAuct.UseVisualStyleBackColor = true;
            // 
            // txtDeleteAuct
            // 
            this.txtDeleteAuct.Location = new System.Drawing.Point(75, 33);
            this.txtDeleteAuct.Name = "txtDeleteAuct";
            this.txtDeleteAuct.Size = new System.Drawing.Size(156, 22);
            this.txtDeleteAuct.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Id";
            // 
            // AdministratorAddAuctioneerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 544);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdministratorAddAuctioneerForm";
            this.Text = "AdministratorAddAuctioneerForm";
            this.Load += new System.EventHandler(this.AdministratorAddAuctioneerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctioneerBindingSource)).EndInit();
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AuctionsDatabaseDataSet1 auctionsDatabaseDataSet1;
        private System.Windows.Forms.BindingSource auctioneerBindingSource;
        private AuctionsDatabaseDataSet1TableAdapters.AuctioneerTableAdapter auctioneerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddAuctioneer;
        private System.Windows.Forms.TextBox txtEmailAuctioneer;
        private System.Windows.Forms.TextBox txtAddressAuctioneer;
        private System.Windows.Forms.TextBox txtPhoneAuctioneer;
        private System.Windows.Forms.TextBox txtNameAuctioneer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAuctioneer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditNameAuct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditNameAuct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditAddressAuct;
        private System.Windows.Forms.TextBox txtEditAddressAuct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEditPhoneAuct;
        private System.Windows.Forms.TextBox txtEditPhoneAuct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnEditEmailAuct;
        private System.Windows.Forms.TextBox txtEditEmailAuct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDeleteAuct;
        private System.Windows.Forms.TextBox txtDeleteAuct;
        private System.Windows.Forms.Label label10;
    }
}