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
    public partial class frmDelivery : Form
    {
        dbConnection _ConnectOpener = new dbConnection();
        SqlCommand _CMD;
        SqlDataReader _DTR;
        public ProductOrder _CurrentOrder;
        public frmDelivery(ProductOrder _order)
        {
            InitializeComponent();
            _CurrentOrder = _order;
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            _ConnectOpener.ConnectString();
            Boolean _boolCondition = _ConnectOpener.OpenConnect();
            if (_boolCondition == true)
            {
                string _strCustAddress = "";
                try
                {
                    int _intCustomerId = 0;
                    _CMD = new SqlCommand("SELECT CustomerId, CustomerAddress FROM Customer WHERE CustomerEmailAddress = @email", dbConnection._CONNECT);
                    _CMD.Parameters.AddWithValue("@email", frmLogIn._LoggedInEmail);
                    _DTR = _CMD.ExecuteReader();
                    if (_DTR.Read() == true)
                    {
                        _intCustomerId = Convert.ToInt32(_DTR["CustomerId"]);
                        txtDeliveryAddress.Text = _DTR["CustomerAddress"].ToString();
                        _strCustAddress = txtDeliveryAddress.Text;                       
                    }
                }
                catch
                {
                    MessageBox.Show("Customer not found");
                }

                txtUserName.Text = frmLogIn._LoggedInEmail;
                txtDeliveryProdName.Text = _CurrentOrder._ProdName;
                txtOrderOwner.Text = _CurrentOrder._UserName;
                txtDeliveryDate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
                txtDeliveryAddress.Text = _strCustAddress;
                txtOrderOwner.Text = frmLogIn._LoggedInEmail;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            _ConnectOpener.ConnectString();
            Boolean _boolCondition = _ConnectOpener.OpenConnect();

            if (_boolCondition == true)
            {
                try
                {
                    int _intCustomerId = 0;
                    int _intOrderId = 0;
                    _CurrentOrder._OrderId = _intOrderId;
                    _CMD = new SqlCommand("SELECT Customer.CustomerID, Customer.CustomerAddress,Orders.OrderId FROM Customer INNER JOIN Orders ON Customer.CustomerID = Orders.CustomerID WHERE CustomerEmailAddress = @email", dbConnection._CONNECT);
                    _CMD.Parameters.AddWithValue("@email", frmLogIn._LoggedInEmail);
                    _DTR = _CMD.ExecuteReader();
                    if (_DTR.Read() == true)
                    {
                        _intCustomerId = Convert.ToInt32(_DTR["CustomerId"]);
                        txtDeliveryAddress.Text = _DTR["CustomerAddress"].ToString();
                        _intOrderId = Convert.ToInt32(_DTR["OrderId"]);
                        txtOrderOwner.Text = frmLogIn._LoggedInEmail;
                    }
                    else
                    {
                        MessageBox.Show("Customer not found");
                        _DTR.Close();
                    }
                    _DTR.Close();


                    _CMD = new SqlCommand("INSERT INTO Delivery (DeliveryDate,DeliveryAddress,OrderId,CustomerID)" +
                    " VALUES(@date,@address,@orderid,@customerId)", dbConnection._CONNECT);
                    _CMD.Parameters.AddWithValue("@date", System.DateTime.Now);
                    _CMD.Parameters.AddWithValue("@address", txtDeliveryAddress.Text);
                    _CMD.Parameters.AddWithValue("@orderid", _intOrderId);
                    _CMD.Parameters.AddWithValue("@customerId", _intCustomerId);
                    _CMD.ExecuteNonQuery();
                    MessageBox.Show("delivery table updated successfully.");
                    MessageBox.Show("Order has been placed and delivery details have been confirmed.");
                    this.Close();
                    
                }
                catch
                {
                    MessageBox.Show("Unable to update delivery.", "Failed to update delivery");
                }
            }
            else
            {
                MessageBox.Show("Connection could not be established.");
            }
        }
    }
}
