namespace Paint
{
    partial class AuctioneerForm
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
            this.auctionsDatabaseDataSet5 = new Paint.AuctionsDatabaseDataSet5();
            this.objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objectTableAdapter = new Paint.AuctionsDatabaseDataSet5TableAdapters.ObjectTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsDatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.startValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.objectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(509, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(356, 601);
            this.dataGridView1.TabIndex = 0;
            // 
            // auctionsDatabaseDataSet5
            // 
            this.auctionsDatabaseDataSet5.DataSetName = "AuctionsDatabaseDataSet5";
            this.auctionsDatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectBindingSource
            // 
            this.objectBindingSource.DataMember = "Object";
            this.objectBindingSource.DataSource = this.auctionsDatabaseDataSet5;
            // 
            // objectTableAdapter
            // 
            this.objectTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // startValueDataGridViewTextBoxColumn
            // 
            this.startValueDataGridViewTextBoxColumn.DataPropertyName = "StartValue";
            this.startValueDataGridViewTextBoxColumn.HeaderText = "StartValue";
            this.startValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startValueDataGridViewTextBoxColumn.Name = "startValueDataGridViewTextBoxColumn";
            this.startValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // AuctioneerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 625);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AuctioneerForm";
            this.Text = "AuctioneerForm";
            this.Load += new System.EventHandler(this.AuctioneerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionsDatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AuctionsDatabaseDataSet5 auctionsDatabaseDataSet5;
        private System.Windows.Forms.BindingSource objectBindingSource;
        private AuctionsDatabaseDataSet5TableAdapters.ObjectTableAdapter objectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startValueDataGridViewTextBoxColumn;
    }
}