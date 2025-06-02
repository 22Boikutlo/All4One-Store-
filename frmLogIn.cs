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
    public partial class frmLogIn : Form
    {
        public dbConnection _ConnectOpener = new dbConnection();
        SqlCommand _CMD;
        SqlDataReader _DTR;
        string _strSecurityId = null;
        string _strUserPassword = null, _strUsername = null;
        public static string _LoggedInEmail { get; private set; }
        public ProductOrder _order;

        public frmLogIn(ProductOrder order)
        {
            InitializeComponent();
            _order = order;
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
        private void lnkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCustomerInfo _customerInfo = new frmCustomerInfo();
            _customerInfo.ShowDialog();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            _ConnectOpener.ConnectString();
            Boolean condition = _ConnectOpener.OpenConnect();
            if (condition == true)
            {
                _strUsername = txtUsername.Text;
                _strUserPassword = txtPassword.Text;
                //check if the username and password are provided
                if (string.IsNullOrWhiteSpace(_strUsername) && string.IsNullOrWhiteSpace(_strUserPassword))
                {
                    MessageBox.Show("Provide your Username and Password", "LogIn details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                //check if the username is provided
                else
                    if (string.IsNullOrWhiteSpace(_strUsername))
                    {
                    MessageBox.Show("Provide your username", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();

                    }
                //check if the password is provided
                else
                    if (string.IsNullOrWhiteSpace(_strUserPassword))
                    {
                        MessageBox.Show("Provide your password", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Focus();
                    }

                else
                {
                    string _strEncryptedPassword = _ConnectOpener.makeMd5(txtPassword.Text);
                    _CMD = new SqlCommand("SELECT Security.UserName,Security.Password,Security.SecurityId FROM SECURITY INNER JOIN Customer ON Security.UserName = Customer.CustomerEmailAddress WHERE Security.Username = @username AND Security.Password = @password ", dbConnection._CONNECT);
                    _CMD.Parameters.AddWithValue("@username", txtUsername.Text);
                    _CMD.Parameters.AddWithValue("@password", _strEncryptedPassword);
                    _DTR = _CMD.ExecuteReader();
                    if (_DTR.Read() == true)
                    {
                        _strSecurityId = _DTR[2].ToString();                    
                        _LoggedInEmail = _strUsername;
                        frmOrder newOrder = new frmOrder(_order);
                        newOrder.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password didn't match.\n\rTry Again");
                        txtUsername.Clear();
                        txtUsername.Focus();
                    }
                    _DTR.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection could not be established","No Connection to database");
            }
        }
    }
}