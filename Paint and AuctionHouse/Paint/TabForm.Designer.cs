namespace Paint
{
    partial class TabForm
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
            this.PaintPage = new System.Windows.Forms.TabPage();
            this.AuctionsPage = new System.Windows.Forms.TabPage();
            this.Select.SuspendLayout();
            this.SuspendLayout();
            // 
            // Select
            // 
            this.Select.Controls.Add(this.PaintPage);
            this.Select.Controls.Add(this.AuctionsPage);
            this.Select.Location = new System.Drawing.Point(0, 4);
            this.Select.Margin = new System.Windows.Forms.Padding(4);
            this.Select.Name = "Select";
            this.Select.SelectedIndex = 0;
            this.Select.Size = new System.Drawing.Size(1064, 650);
            this.Select.TabIndex = 0;
            // 
            // PaintPage
            // 
            this.PaintPage.AutoScroll = true;
            this.PaintPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPage.Location = new System.Drawing.Point(4, 25);
            this.PaintPage.Margin = new System.Windows.Forms.Padding(4);
            this.PaintPage.Name = "PaintPage";
            this.PaintPage.Padding = new System.Windows.Forms.Padding(4);
            this.PaintPage.Size = new System.Drawing.Size(1056, 621);
            this.PaintPage.TabIndex = 0;
            this.PaintPage.Text = "Paint";
            this.PaintPage.UseVisualStyleBackColor = true;
            // 
            // AuctionsPage
            // 
            this.AuctionsPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuctionsPage.Location = new System.Drawing.Point(4, 25);
            this.AuctionsPage.Margin = new System.Windows.Forms.Padding(4);
            this.AuctionsPage.Name = "AuctionsPage";
            this.AuctionsPage.Padding = new System.Windows.Forms.Padding(4);
            this.AuctionsPage.Size = new System.Drawing.Size(1056, 621);
            this.AuctionsPage.TabIndex = 1;
            this.AuctionsPage.Text = "Auctions";
            this.AuctionsPage.UseVisualStyleBackColor = true;
            // 
            // TabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 655);
            this.Controls.Add(this.Select);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabForm";
            this.Text = "TabForm";
            this.Select.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Select;
        private System.Windows.Forms.TabPage AuctionsPage;
        private System.Windows.Forms.TabPage PaintPage;
    }
}