using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyStore
{
    public partial class frmForgotPassword : Form
    {
        public dbConnection _OpenConnecter = new dbConnection();
        SqlCommand CMD;
        SqlDataReader DTR;
        int Counter, Count;
        private ProductOrder _CurrentOrder;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //check if email was added to a textbox and send appropriate message to let user know text must be added
            if (txtEmailAddress.Text == "")
            {
                txtEmailAddress.Focus();
                MessageBox.Show("Provide your email address.\nThey are required for changing password", "Enter Email Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                try
                {
                    //converts email to text
                    string result = txtEmailAddress.Text;
                    _OpenConnecter.ConnectString();
                    Boolean Condition = _OpenConnecter.OpenConnect();
                    if (Condition == true)
                    {
                        CMD = new SqlCommand("SELECT Security.Username, Security.Password, Security.Quiz, Security.Answer " + "FROM Security INNER JOIN Customer ON Customer.SecurityId = Security.SecurityId where Security.Username='" + txtEmailAddress.Text + "'", dbConnection._CONNECT);
                        DTR = CMD.ExecuteReader();
                        if (DTR.Read() == true)
                        {
                                txtSecQuiz.Text = DTR[3].ToString();
                                this.AcceptButton = btnSubmit;
                                btnSubmit.Enabled = true;
                                txtSecAns.ReadOnly = false;
                                txtSecAns.Focus();
                                txtSecAns.Text = "";                            
                        }
                        else
                        if (DTR.Read() == false)
                        {
                            MessageBox.Show("Email address provided was incorrect.\n\rTry Again", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Counter = Counter + 1;
                            txtEmailAddress.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Numbers Only.Try again.\n\rTry Again", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmailAddress.Text = "";
                    txtEmailAddress.Focus();
                }
            if (Counter == 3)
            {
                MessageBox.Show("Ran out of tries.Window will close for Security reasons", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogIn loginForm = new frmLogIn(_CurrentOrder);
                loginForm.Show();
                this.Close();
            }
        }                       
    }
}