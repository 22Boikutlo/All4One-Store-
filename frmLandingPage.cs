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
    public partial class frmLandingPage : Form
    {
        public frmLandingPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCategories CategoriesForm = new frmCategories();
            CategoriesForm.Show();
            

            this.Hide();
        }

        private void lblLebenkele_Click(object sender, EventArgs e)
        {

        }
    }
}
