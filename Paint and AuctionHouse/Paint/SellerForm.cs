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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auctionsDatabaseDataSet3.Object' table. You can move, or remove it, as needed.
            this.objectTableAdapter.Fill(this.auctionsDatabaseDataSet3.Object);

        }
    }
}
