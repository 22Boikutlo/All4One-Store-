using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStore
{
    public partial class frmMeat : Form
    {
        public frmMeat()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPork_Click(object sender, EventArgs e)
        {
            frmPork PorkDetails = new frmPork();
            PorkDetails.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBeef_Click(object sender, EventArgs e)
        {
            frmBeef BeefDetails = new frmBeef();
            BeefDetails.Show();
        }
    }
}
