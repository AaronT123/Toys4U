using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class AnOrder : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 OrderID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the order to be processed
            OrderID = Convert.ToInt32(Session["OrderID"]);
            if(IsPostBack == false)
            {
                //populate the list of orders
                DisplayOrders();
                //if this is not a new record
                if (OrderID != -1)
                {
                    //display the current data for the record
                    DisplayOrders();
                }

            }
        }

        void DisplayOrders()
        {
            //create an instance of the addres book
            clsOrderCollection OrderBook = new clsOrderCollection();
            //find the record to update
            OrderBook.ThisOrder.Find(OrderID);
            //display the data for this record
            txtOrderDate.Text = OrderBook.ThisOrder.OrderDate.ToString();
            txtCustomerID.Text = OrderBook.ThisOrder.CustomerID.ToString();

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (OrderID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }

        void Add()
        {
            //create an instance of the order book
            clsOrderCollection OrderBook = new clsOrderCollection();
            //validate the data on the web form
            String Error = OrderBook.ThisOrder.Valid(txtOrderId.Text, txtOrderDate.Text, txtCustomerID.Text);
            //if the data is OK then add it to the object
            if(Error == "")
            {
                //get the data entered by the user
                OrderBook.ThisOrder.OrderID = Convert.ToInt32(txtOrderId.Text);
                OrderBook.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                OrderBook.ThisOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                //add the record
                OrderBook.Add();
                Response.Redirect("OrderList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void Update()
        {
            //create an intance of the orderBook
            clsOrderCollection OrderBook = new clsOrderCollection();
            //validate the data on the web form
            String Error = OrderBook.ThisOrder.Valid(txtOrderId.Text, txtOrderDate.Text, txtCustomerID.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                OrderBook.ThisOrder.Find(OrderID);
                //get the data entered by the user
                OrderBook.ThisOrder.OrderID = Convert.ToInt32(txtOrderId.Text);
                OrderBook.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                OrderBook.ThisOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                //update the record
                OrderBook.Update();
                //all done so redirect back to the main page
                Response.Redirect("OrderList.aspx");
            }
            else
            {
                //Report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }
        }
    }
}