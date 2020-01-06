namespace Paint
{
    partial class LogForm
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
            this.rdBtnAdministrator = new System.Windows.Forms.RadioButton();
            this.rdBtnSeller = new System.Windows.Forms.RadioButton();
            this.UserGroup = new System.Windows.Forms.GroupBox();
            this.txtAuctioneer = new System.Windows.Forms.TextBox();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.rdBtnAuctioneer = new System.Windows.Forms.RadioButton();
            this.btnLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdBtnAdministrator
            // 
            this.rdBtnAdministrator.AutoSize = true;
            this.rdBtnAdministrator.Location = new System.Drawing.Point(6, 46);
            this.rdBtnAdministrator.Name = "rdBtnAdministrator";
            this.rdBtnAdministrator.Size = new System.Drawing.Size(112, 21);
            this.rdBtnAdministrator.TabIndex = 0;
            this.rdBtnAdministrator.TabStop = true;
            this.rdBtnAdministrator.Text = "Administrator";
            this.rdBtnAdministrator.UseVisualStyleBackColor = true;
            this.rdBtnAdministrator.Click += new System.EventHandler(this.rdBtnAdministrator_Click);
            // 
            // rdBtnSeller
            // 
            this.rdBtnSeller.AutoSize = true;
            this.rdBtnSeller.Location = new System.Drawing.Point(6, 46);
            this.rdBtnSeller.Name = "rdBtnSeller";
            this.rdBtnSeller.Size = new System.Drawing.Size(65, 21);
            this.rdBtnSeller.TabIndex = 1;
            this.rdBtnSeller.TabStop = true;
            this.rdBtnSeller.Text = "Seller";
            this.rdBtnSeller.UseVisualStyleBackColor = true;
            this.rdBtnSeller.Click += new System.EventHandler(this.rdBtnSeller_Click);
            // 
            // UserGroup
            // 
            this.UserGroup.Controls.Add(this.txtAuctioneer);
            this.UserGroup.Controls.Add(this.txtSeller);
            this.UserGroup.Controls.Add(this.rdBtnAuctioneer);
            this.UserGroup.Controls.Add(this.rdBtnSeller);
            this.UserGroup.Location = new System.Drawing.Point(568, 90);
            this.UserGroup.Name = "UserGroup";
            this.UserGroup.Size = new System.Drawing.Size(200, 194);
            this.UserGroup.TabIndex = 2;
            this.UserGroup.TabStop = false;
            this.UserGroup.Text = "User";
            // 
            // txtAuctioneer
            // 
            this.txtAuctioneer.Location = new System.Drawing.Point(6, 146);
            this.txtAuctioneer.Name = "txtAuctioneer";
            this.txtAuctioneer.Size = new System.Drawing.Size(100, 22);
            this.txtAuctioneer.TabIndex = 4;
            // 
            // txtSeller
            // 
            this.txtSeller.Location = new System.Drawing.Point(7, 74);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(100, 22);
            this.txtSeller.TabIndex = 3;
            // 
            // rdBtnAuctioneer
            // 
            this.rdBtnAuctioneer.AutoSize = true;
            this.rdBtnAuctioneer.Location = new System.Drawing.Point(6, 119);
            this.rdBtnAuctioneer.Name = "rdBtnAuctioneer";
            this.rdBtnAuctioneer.Size = new System.Drawing.Size(97, 21);
            this.rdBtnAuctioneer.TabIndex = 2;
            this.rdBtnAuctioneer.TabStop = true;
            this.rdBtnAuctioneer.Text = "Auctioneer";
            this.rdBtnAuctioneer.UseVisualStyleBackColor = true;
            this.rdBtnAuctioneer.Click += new System.EventHandler(this.rdBtnAuctioneer_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(495, 358);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "OK";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnAdministrator);
            this.groupBox1.Location = new System.Drawing.Point(297, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrator";
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.UserGroup);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.UserGroup.ResumeLayout(false);
            this.UserGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnAdministrator;
        private System.Windows.Forms.RadioButton rdBtnSeller;
        private System.Windows.Forms.GroupBox UserGroup;
        private System.Windows.Forms.TextBox txtAuctioneer;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.RadioButton rdBtnAuctioneer;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}