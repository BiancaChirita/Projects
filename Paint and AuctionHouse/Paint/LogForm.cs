using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void rdBtnAdministrator_Click(object sender, EventArgs e)
        {
            rdBtnSeller.Checked = false;
            rdBtnAuctioneer.Checked = false;
        }

        private void rdBtnSeller_Click(object sender, EventArgs e)
        {
            rdBtnAdministrator.Checked = false;
            rdBtnAuctioneer.Checked = false;
        }

        private void rdBtnAuctioneer_Click(object sender, EventArgs e)
        {
            rdBtnSeller.Checked = false;
            rdBtnAdministrator.Checked = false;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if(rdBtnAdministrator.Checked == true)
            {
                AdministratorTabForm administratorTabForm = new AdministratorTabForm();

                administratorTabForm.Show();
            }
            if(rdBtnSeller.Checked == true)
            {
                SellerForm sellerForm = new SellerForm();

                sellerForm.Show();
            }
            if(rdBtnAuctioneer.Checked == true)
            {
                AuctioneerForm auctioneerForm = new AuctioneerForm();

                auctioneerForm.Show();
            }
        }


    }
}
