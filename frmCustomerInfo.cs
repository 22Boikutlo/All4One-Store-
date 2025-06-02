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
    public partial class frmCustomerInfo : Form
    {
        SqlCommand _CMD;
        SqlDataReader _DTR;
        dbConnection _ConnectOpener = new dbConnection();
        string _strGender = "";
        string _strUserName = "";
        Boolean _boolCondition;
        public static string _strCustomerName { get; set; }
        private ProductOrder _currentOrder;

        public frmCustomerInfo()
        {
            InitializeComponent();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFName.Text) && string.IsNullOrWhiteSpace(txtLName.Text) && string.IsNullOrWhiteSpace(txtAddress.Text) && string.IsNullOrWhiteSpace(txtEmail.Text) && string.IsNullOrWhiteSpace(txtPhone.Text) && (radMale.Checked == false | radFemale.Checked == false | radOther.Checked == false))
            {
                MessageBox.Show("Provide All Fields.\nThey are required for Adding a new customer", "Field required check report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
            }
            else
            {
                if (radMale.Checked == true)
                {
                    //_strGender = "Male";
                    _strGender = "M";
                }
                else
                    if (radFemale.Checked == true)
                {
                    //_strGender = "Female";
                    _strGender = "F";
                }
                else
                        if (radOther.Checked == true)
                {
                    //_strGender = "Other";
                    _strGender = "O";
                }
            }

            Boolean _boolCharCheck = _ConnectOpener.charCheck(txtFName.Text);
            _boolCharCheck = _ConnectOpener.charCheck(txtLName.Text);
            _boolCharCheck = _ConnectOpener.charCheck(txtAddress.Text);
            _boolCharCheck = _ConnectOpener.charCheck(txtPhone.Text);
            _boolCharCheck = _ConnectOpener.charCheck(txtQuiz.Text);
            _boolCharCheck = _ConnectOpener.charCheck(txtAns.Text);

            if (_boolCharCheck == true)
            {
                MessageBox.Show("Special characters are not allowed as part of input", "Special characters not allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _ConnectOpener.ConnectString();
                _boolCondition = _ConnectOpener.OpenConnect();
                if (_boolCondition == true)
                {
                    //this checks if a username exists. if it does not exist. They take the customer Email to be the new username
                    _CMD = new SqlCommand("SELECT Username FROM Security WHERE Username = @username", dbConnection._CONNECT);
                    _CMD.Parameters.AddWithValue("@username", txtEmail.Text);
                    
                        _DTR = _CMD.ExecuteReader();
                        if (_DTR.Read() == true)
                        {
                            MessageBox.Show("User exists");
                        }                    
                }
                else
                {
                    MessageBox.Show("Database connection failed.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _ConnectOpener.ConnectString();
                    _boolCondition = _ConnectOpener.OpenConnect();
                    if (_boolCondition == true)
                    {
                        //add user info into the security table 
                        _CMD = new SqlCommand(" INSERT INTO Security( UserName,Password,Quiz,Answer)  VALUES(@username,@password,@quiz,@answer)", dbConnection._CONNECT);
                        try
                        {
                            _CMD.Parameters.AddWithValue("@username", txtEmail.Text);
                            string _strEncryptedPassword = _ConnectOpener.makeMd5(txtPassword.Text);
                            _CMD.Parameters.AddWithValue("@password", _strEncryptedPassword);
                            _CMD.Parameters.AddWithValue("@quiz", txtQuiz.Text);
                            _CMD.Parameters.AddWithValue("@answer", txtAns.Text);
                            _CMD.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Could not add update security table");
                        }
                        // dbConnection._CONNECT.Close();
                    }


                    if (_boolCondition == true)
                    {
                        //select added user to create tjh
                        _CMD = new SqlCommand(" INSERT INTO Customer( CustomerFirstName,CustomerLastName,CustomerGender,CustomerAddress,CustomerEmailAddress,CustomerPhoneNumber) " +
                            "                   VALUES(@name,@surname,@gender,@address,@email,@phone)", dbConnection._CONNECT);
                        _CMD.Parameters.AddWithValue("@name", txtFName.Text);
                        _CMD.Parameters.AddWithValue("@surname", txtLName.Text);
                        _CMD.Parameters.AddWithValue("@gender", _strGender);
                        _CMD.Parameters.AddWithValue("@address", txtAddress.Text);
                        _CMD.Parameters.AddWithValue("@email", txtEmail.Text);
                        _CMD.Parameters.AddWithValue("@phone", txtPhone.Text);
                        _CMD.ExecuteNonQuery();
                        // dbConnection._CONNECT.Close();
                        MessageBox.Show("Customer was added Successfully");
                        frmLogIn _logIn = new frmLogIn(_currentOrder);
                        _logIn.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Database Timeout");
                    }
                
            }

            if (txtPassword.Text != txtConfirmedPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please check and try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmedPassword.Clear();
                txtConfirmedPassword.Focus();
                return;
            }
        }        

            private void btnBack_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void lblSpecialCharacter(object sender, EventArgs e)
            {
                Boolean _boolCharChecker = _ConnectOpener.charCheck(txtPassword.Text);
                if (_boolCharChecker == false)
                {
                    MessageBox.Show("The password should atleast have 1 special character.", "Characters Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblSpecialChar.ForeColor = Color.Green;
                }
            }

            private void lblLowCase(object sender, EventArgs e)
            {
                Boolean _boolLowerCase = checkUpper(txtPassword.Text);
                if (_boolLowerCase == false)
                {
                    MessageBox.Show("Your password should consist of lowercase", "Lowercase Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblLowcase.ForeColor = Color.Green;
                }
            }


            private void lblUpperCase(object sender, EventArgs e)
            {
                Boolean _boolUpperCase = checkUpper(txtPassword.Text);
                if (_boolUpperCase == true)
                {
                    lblUpCase.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Your password should consist of uppercase", "Uppercase Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void txtPassword_TextChanged(object sender, EventArgs e)
            {
                //first determines length
                int _intLength = txtPassword.Text.Length;
                Boolean _boolUpperCase = checkUpper(txtPassword.Text);
                Boolean _boolLowerCase = checkLower(txtPassword.Text);
                Boolean _boolCharChecker = _ConnectOpener.charCheck(txtPassword.Text);
                Boolean _boolInputPassword = ContainsNums(txtPassword.Text);
                lblNumOfCharacters.ForeColor = (_intLength >= 8 && _intLength <= 16) ? Color.Green : Color.Black;
                lblUpCase.ForeColor = (_boolUpperCase == true) ? Color.Green : Color.Black;
                lblLowcase.ForeColor = (_boolLowerCase == true) ? Color.Green : Color.Black;
                lblSpecialChar.ForeColor = (_boolCharChecker == true) ? Color.Green : Color.Black;
                lblNums.ForeColor = (_boolInputPassword == true) ? Color.Green : Color.Black;

                if (_intLength >= 9 && _intLength <= 16 && _boolUpperCase && _boolLowerCase && _boolCharChecker && _boolInputPassword)
                {
                    MessageBox.Show("The password length should be atleast 8 and less than 16 characters." +
                        "\nYour password should consist of an uppercase and a lowercase." +
                        " \nThe password should atleast have 1 special character and atleast 1 numeric.", "Invalid password synthax.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        
                }


            }   ///SPECIAL METHODS FOR PASSWORD CONSTRAINTS
            public Boolean ContainsNums(string _strInput)
            {
                return _strInput.Any(char.IsDigit);
            }

            public Boolean checkUpper(string _strInput)
            {
                foreach (char c in _strInput)
                {
                    if (char.IsUpper(c))
                    {
                        return true;
                    }
                }
                return false;
            }

            public Boolean checkLower(string _strInput)
            {
                foreach (char c in _strInput)
                {
                    if (char.IsLower(c))
                    {
                        return true;
                    }
                }
                return false;
            }

        private void frmCustomerInfo_Load(object sender, EventArgs e)
        {

        }
    }
} 
