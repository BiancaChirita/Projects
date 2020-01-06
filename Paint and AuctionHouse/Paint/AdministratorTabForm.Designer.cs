namespace Paint
{
    partial class AdministratorTabForm
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
            this.Select = new System.Windows.Forms.TabControl();
            this.tabSeller = new System.Windows.Forms.TabPage();
            this.tabAuctioneer = new System.Windows.Forms.TabPage();
            this.Select.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.Select.Controls.Add(this.tabSeller);
            this.Select.Controls.Add(this.tabAuctioneer);
            this.Select.Location = new System.Drawing.Point(12, 12);
            this.Select.Name = "tabControl1";
            this.Select.SelectedIndex = 0;
            this.Select.Size = new System.Drawing.Size(974, 620);
            this.Select.TabIndex = 0;
            // 
            // tabSeller
            // 
            this.tabSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabSeller.Location = new System.Drawing.Point(4, 25);
            this.tabSeller.Name = "tabSeller";
            this.tabSeller.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeller.Size = new System.Drawing.Size(966, 591);
            this.tabSeller.TabIndex = 0;
            this.tabSeller.Text = "Seller";
            this.tabSeller.UseVisualStyleBackColor = true;
            // 
            // tabAuctioneer
            // 
            this.tabAuctioneer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAuctioneer.Location = new System.Drawing.Point(4, 25);
            this.tabAuctioneer.Name = "tabAuctioneer";
            this.tabAuctioneer.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuctioneer.Size = new System.Drawing.Size(966, 591);
            this.tabAuctioneer.TabIndex = 1;
            this.tabAuctioneer.Text = "Auctioneer";
            this.tabAuctioneer.UseVisualStyleBackColor = true;
            // 
            // AdministratorTabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 644);
            this.Controls.Add(this.Select);
            this.Name = "AdministratorTabForm";
            this.Text = "AdministratorTabForm";
            this.Select.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Select;
        private System.Windows.Forms.TabPage tabSeller;
        private System.Windows.Forms.TabPage tabAuctioneer;
    }
}