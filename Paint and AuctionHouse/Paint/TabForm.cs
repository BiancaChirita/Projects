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
    public partial class TabForm : Form
    {
        public TabForm()
        {
            InitializeComponent();
            PaintForm paintForm = new PaintForm();
            LogForm logForm = new LogForm();
            paintForm.TopLevel = false;
            paintForm.Visible = true;
            paintForm.FormBorderStyle = FormBorderStyle.None;
            paintForm.Dock = DockStyle.Fill;
            Select.TabPages[0].Controls.Add(paintForm);

            logForm.TopLevel = false;
            logForm.Visible = true;
            logForm.FormBorderStyle = FormBorderStyle.None;
            logForm.Dock = DockStyle.Fill;
            Select.TabPages[1].Controls.Add(logForm);
        }
    }
}
