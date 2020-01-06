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
    public partial class AdministratorTabForm : Form
    {
        public AdministratorTabForm()
        {
            InitializeComponent();

            AdministratorAddSellerForm sellerForm = new AdministratorAddSellerForm();
            sellerForm.TopLevel = false;
            sellerForm.Visible = true;
            sellerForm.FormBorderStyle = FormBorderStyle.None;
            sellerForm.Dock = DockStyle.Fill;
            Select.TabPages[0].Controls.Add(sellerForm);

            AdministratorAddAuctioneerForm auctioneerForm = new AdministratorAddAuctioneerForm();
            auctioneerForm.TopLevel = false;
            auctioneerForm.Visible = true;
            auctioneerForm.FormBorderStyle = FormBorderStyle.None;
            auctioneerForm.Dock = DockStyle.Fill;
            Select.TabPages[1].Controls.Add(auctioneerForm);


        }
    }
}
