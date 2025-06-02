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
    public partial class frmOrder : Form
    {
        SqlCommand _CMD;
        dbConnection _ConnectOpener = new dbConnection();
        SqlDataReader _DTS;
        string _strEmail = " ";
        decimal _decPrice =0;
        public ProductOrder _order;
        

        public frmOrder(ProductOrder order)
        {
            InitializeComponent();
            _order = order;
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            txtOrderProductName.Text = _order._ProdName;
            txtOrderDescription.Text = _order._ProductDescription;
            txtOrderDate.Text= DateTime.Now.ToString("MM/dd/yyyy");
            txtOrderSize.Text = _order._Quantity.ToString();
            txtOrderPrice.Text = _order._FinalPrice.ToString("C"); 
            txtUserName.Text = frmLogIn._LoggedInEmail;            
        }      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Order_Click(object sender, EventArgs e)
        {
            _ConnectOpener.ConnectString();
            Boolean _boolCondition = _ConnectOpener.OpenConnect();
            if (_boolCondition == true)
            {
                try
                {
                    _CMD = new SqlCommand("INSERT INTO Orders (OrderDate,OrderPrice,OrderSize,ProductId,CustomerID) VALUES(@date,@price,@size,@prodId,@CustId)", dbConnection._CONNECT);
                    _CMD.Parameters.AddWithValue("@date", System.DateTime.Now);
                    _CMD.Parameters.AddWithValue("@price", _order._FinalPrice);
                    _CMD.Parameters.AddWithValue("@size", _order._Quantity);
                    _CMD.Parameters.AddWithValue("@prodId", 3);
                    _CMD.Parameters.AddWithValue("@CustId", 3004);

                    _CMD.ExecuteNonQuery();
                    MessageBox.Show("Order placed successfully.");
                    this.Close();
                    frmDelivery delivery = new frmDelivery(_order);
                    delivery.Show();
                }
                catch
                {
                    MessageBox.Show("Unable to place order.", "Failed to place order");
                }
            }
            else
            {
                MessageBox.Show("Connection could not be established.");
            }
        }
    }
}
