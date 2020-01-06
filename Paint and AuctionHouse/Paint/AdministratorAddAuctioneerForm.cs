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
    public partial class AdministratorAddAuctioneerForm : Form
    {
        public AdministratorAddAuctioneerForm()
        {
            InitializeComponent();
        }

        private void AdministratorAddAuctioneerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auctionsDatabaseDataSet1.Auctioneer' table. You can move, or remove it, as needed.
            this.auctioneerTableAdapter.Fill(this.auctionsDatabaseDataSet1.Auctioneer);

        }
    }
}
