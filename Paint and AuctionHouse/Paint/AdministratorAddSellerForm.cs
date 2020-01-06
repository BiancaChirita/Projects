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
    public partial class AdministratorAddSellerForm : Form
    {
        public AdministratorAddSellerForm()
        {
            InitializeComponent();
        }

        private void AdministratorAddSellerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auctionsDatabaseDataSet2.Seller' table. You can move, or remove it, as needed.
            this.sellerTableAdapter.Fill(this.auctionsDatabaseDataSet2.Seller);

        }
    }
}
