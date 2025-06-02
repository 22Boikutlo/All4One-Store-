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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnMeat_Click(object sender, EventArgs e)
        {

            frmMeat meatForm = new frmMeat();
            meatForm.Show();
            this.Hide();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {

        }
    }
}
