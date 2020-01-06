namespace Paint
{
    partial class SellerForm
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auctionsDatabaseDataSet3 = new Paint.AuctionsDatabaseDataSet3();
            this.objectTableAdapter = new Paint.AuctionsDatabaseDataSet3TableAdapters.ObjectTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdObject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameObject = new System.Windows.Forms.TextBox();
            this.txtPriceObject = new System.Windows.Forms.TextBox();
            this.txtStartValObject = new System.Windows.Forms.TextBox();
            this.btnAddObject = new System.Windows.Forms.Button();
            this.btnClearObject = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEditNameObj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditNameObj = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEditPriceObj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditPriceObj = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditStartValObj = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditStartValObj = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDeleteObject = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeleteObject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsDatabaseDataSet3)).BeginInit();
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
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.startValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.objectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(579, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 601);
            this.dataGridView1.TabIndex = 0;
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
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // startValueDataGridViewTextBoxColumn
            // 
            this.startValueDataGridViewTextBoxColumn.DataPropertyName = "StartValue";
            this.startValueDataGridViewTextBoxColumn.HeaderText = "StartValue";
            this.startValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startValueDataGridViewTextBoxColumn.Name = "startValueDataGridViewTextBoxColumn";
            this.startValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // objectBindingSource
            // 
            this.objectBindingSource.DataMember = "Object";
            this.objectBindingSource.DataSource = this.auctionsDatabaseDataSet3;
            // 
            // auctionsDatabaseDataSet3
            // 
            this.auctionsDatabaseDataSet3.DataSetName = "AuctionsDatabaseDataSet3";
            this.auctionsDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectTableAdapter
            // 
            this.objectTableAdapter.ClearBeforeFill = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearObject);
            this.groupBox1.Controls.Add(this.btnAddObject);
            this.groupBox1.Controls.Add(this.txtStartValObject);
            this.groupBox1.Controls.Add(this.txtPriceObject);
            this.groupBox1.Controls.Add(this.txtNameObject);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdObject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Object";
            // 
            // txtIdObject
            // 
            this.txtIdObject.Location = new System.Drawing.Point(81, 27);
            this.txtIdObject.Name = "txtIdObject";
            this.txtIdObject.Size = new System.Drawing.Size(157, 22);
            this.txtIdObject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Value";
            // 
            // txtNameObject
            // 
            this.txtNameObject.Location = new System.Drawing.Point(81, 62);
            this.txtNameObject.Name = "txtNameObject";
            this.txtNameObject.Size = new System.Drawing.Size(157, 22);
            this.txtNameObject.TabIndex = 7;
            // 
            // txtPriceObject
            // 
            this.txtPriceObject.Location = new System.Drawing.Point(81, 97);
            this.txtPriceObject.Name = "txtPriceObject";
            this.txtPriceObject.Size = new System.Drawing.Size(157, 22);
            this.txtPriceObject.TabIndex = 8;
            // 
            // txtStartValObject
            // 
            this.txtStartValObject.Location = new System.Drawing.Point(81, 132);
            this.txtStartValObject.Name = "txtStartValObject";
            this.txtStartValObject.Size = new System.Drawing.Size(157, 22);
            this.txtStartValObject.TabIndex = 9;
            // 
            // btnAddObject
            // 
            this.btnAddObject.Location = new System.Drawing.Point(6, 168);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(75, 23);
            this.btnAddObject.TabIndex = 10;
            this.btnAddObject.Text = "Add";
            this.btnAddObject.UseVisualStyleBackColor = true;
            // 
            // btnClearObject
            // 
            this.btnClearObject.Location = new System.Drawing.Point(163, 168);
            this.btnClearObject.Name = "btnClearObject";
            this.btnClearObject.Size = new System.Drawing.Size(75, 23);
            this.btnClearObject.TabIndex = 11;
            this.btnClearObject.Text = "Clear";
            this.btnClearObject.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEditNameObj);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEditNameObj);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Name";
            // 
            // txtEditNameObj
            // 
            this.txtEditNameObj.Location = new System.Drawing.Point(81, 34);
            this.txtEditNameObj.Name = "txtEditNameObj";
            this.txtEditNameObj.Size = new System.Drawing.Size(157, 22);
            this.txtEditNameObj.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // btnEditNameObj
            // 
            this.btnEditNameObj.Location = new System.Drawing.Point(6, 76);
            this.btnEditNameObj.Name = "btnEditNameObj";
            this.btnEditNameObj.Size = new System.Drawing.Size(75, 23);
            this.btnEditNameObj.TabIndex = 11;
            this.btnEditNameObj.Text = "Ok";
            this.btnEditNameObj.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditPriceObj);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtEditPriceObj);
            this.groupBox3.Location = new System.Drawing.Point(12, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 105);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edit Price";
            // 
            // btnEditPriceObj
            // 
            this.btnEditPriceObj.Location = new System.Drawing.Point(6, 76);
            this.btnEditPriceObj.Name = "btnEditPriceObj";
            this.btnEditPriceObj.Size = new System.Drawing.Size(75, 23);
            this.btnEditPriceObj.TabIndex = 11;
            this.btnEditPriceObj.Text = "Ok";
            this.btnEditPriceObj.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // txtEditPriceObj
            // 
            this.txtEditPriceObj.Location = new System.Drawing.Point(81, 34);
            this.txtEditPriceObj.Name = "txtEditPriceObj";
            this.txtEditPriceObj.Size = new System.Drawing.Size(157, 22);
            this.txtEditPriceObj.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEditStartValObj);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtEditStartValObj);
            this.groupBox4.Location = new System.Drawing.Point(12, 477);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 105);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Start Value";
            // 
            // btnEditStartValObj
            // 
            this.btnEditStartValObj.Location = new System.Drawing.Point(6, 76);
            this.btnEditStartValObj.Name = "btnEditStartValObj";
            this.btnEditStartValObj.Size = new System.Drawing.Size(75, 23);
            this.btnEditStartValObj.TabIndex = 11;
            this.btnEditStartValObj.Text = "Ok";
            this.btnEditStartValObj.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Start Value";
            // 
            // txtEditStartValObj
            // 
            this.txtEditStartValObj.Location = new System.Drawing.Point(81, 34);
            this.txtEditStartValObj.Name = "txtEditStartValObj";
            this.txtEditStartValObj.Size = new System.Drawing.Size(157, 22);
            this.txtEditStartValObj.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDeleteObject);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtDeleteObject);
            this.groupBox5.Location = new System.Drawing.Point(295, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 105);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Delete Object";
            // 
            // btnDeleteObject
            // 
            this.btnDeleteObject.Location = new System.Drawing.Point(6, 76);
            this.btnDeleteObject.Name = "btnDeleteObject";
            this.btnDeleteObject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteObject.TabIndex = 11;
            this.btnDeleteObject.Text = "Delete";
            this.btnDeleteObject.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Id";
            // 
            // txtDeleteObject
            // 
            this.txtDeleteObject.Location = new System.Drawing.Point(81, 34);
            this.txtDeleteObject.Name = "txtDeleteObject";
            this.txtDeleteObject.Size = new System.Drawing.Size(157, 22);
            this.txtDeleteObject.TabIndex = 4;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 625);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsDatabaseDataSet3)).EndInit();
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
        private AuctionsDatabaseDataSet3 auctionsDatabaseDataSet3;
        private System.Windows.Forms.BindingSource objectBindingSource;
        private AuctionsDatabaseDataSet3TableAdapters.ObjectTableAdapter objectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClearObject;
        private System.Windows.Forms.Button btnAddObject;
        private System.Windows.Forms.TextBox txtStartValObject;
        private System.Windows.Forms.TextBox txtPriceObject;
        private System.Windows.Forms.TextBox txtNameObject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdObject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEditNameObj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEditNameObj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEditPriceObj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditPriceObj;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEditStartValObj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditStartValObj;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDeleteObject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeleteObject;
    }
}