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
    public partial class frmPork : Form
    {
        dbConnection _ConnectOpener = new dbConnection();
        SqlCommand _CMD;
        SqlDataReader _DTR;
        public ProductOrder CurrentOrder { get; private set; } = new ProductOrder();

        public frmPork()
        {
            InitializeComponent();
        }       
             
        private void btnBuy_Click(object sender, EventArgs e)
        {
            frmLogIn logInForm = new frmLogIn(CurrentOrder);
            logInForm.Show();
            //frmOrder newOrder = new frmOrder(CurrentOrder);
            //newOrder.Show();

            _ConnectOpener.ConnectString();
            Boolean _boolCondition = _ConnectOpener.OpenConnect();
            if(_boolCondition == true)
            {
                _CMD = new SqlCommand("SELECT Weight, Quantity FROM Products WHERE ProductId=3", dbConnection._CONNECT);
               _DTR = _CMD.ExecuteReader();
                decimal _decOriginalWeight =0;
                decimal _decOriginalQuantity=0;
                if (_DTR.Read() == true)
                {
                    _decOriginalWeight = Convert.ToDecimal(_DTR[0]);
                    _decOriginalQuantity = Convert.ToDecimal(_DTR[1]);
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
                decimal _decSize = 0; ;
               // decimal _decReducingPower = 0;      
                    if (rad5.Checked)
                    {
                        _decSize = 5;
                        //_decReducingPower =  0.5m;
                    }
                    else if (rad10.Checked)
                    {
                         _decSize = 10;
                       // _decReducingPower =  1m;
                    }
                    else if (rad15.Checked)
                    {
                         _decSize = 15;
                       // _decReducingPower =  1.5m;
                    }
                decimal _decNewWeight = _decOriginalWeight - _decSize;
                //_FinalPrice = _decOriginalQuantity - _decReducingPower;

                CurrentOrder._ProdName = txtProductName.Text;
                CurrentOrder._ProductDescription = txtDescription.Text;
                CurrentOrder._Quantity = _decSize;
                CurrentOrder._ProductId = 0;
                _DTR.Close();

                _CMD = new SqlCommand("UPDATE Products SET Weight = @weight, Quantity = @quantity WHERE ProductId = 3", dbConnection._CONNECT);
                try
                {                    
                    _CMD.Parameters.AddWithValue("@weight", _decNewWeight);
                    _CMD.Parameters.AddWithValue("@quantity", _decOriginalQuantity);
                    _CMD.ExecuteNonQuery();                    
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error updating table ", "Products not updated");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
              
        private void RadButton_CheckedChanged(object sender, EventArgs e)
        {
            int _intBasePrice = 50;
            int _intFinalPrice = _intBasePrice;

            if (rad5.Checked)
            {
                _intFinalPrice = _intBasePrice;
            }
            else if (rad10.Checked)
            {
                _intFinalPrice = _intBasePrice * 2;
            }
            else if (rad15.Checked)
            {
                _intFinalPrice = _intBasePrice * 3;
            }

            txtPrice.Text = _intFinalPrice.ToString();
            CurrentOrder._FinalPrice = _intFinalPrice;
        }
        private void frmPork_Load(object sender, EventArgs e)
        {
            _ConnectOpener.ConnectString();
            rad5.Checked = true;
            Boolean _boolCondition = _ConnectOpener.OpenConnect();

            if (_boolCondition == true)
            {
                _CMD = new SqlCommand("SELECT ProductName,ProductDescription,Weight,Price,Quantity FROM Products WHERE ProductId=3 ", dbConnection._CONNECT);
                _DTR = _CMD.ExecuteReader();
                if (_DTR.Read() == true)
                {
                    CurrentOrder._ProdName = _DTR[0].ToString();
                    txtDescription.Text = _DTR[1].ToString();
                    txtProductName.Text = CurrentOrder._ProdName;
                }
                else
                {
                    MessageBox.Show("No product data found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _DTR.Close();
            }
            else
            {
                MessageBox.Show("Failed to open database connection.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grpSize_Enter(object sender, EventArgs e)
        {

        }
    }
}