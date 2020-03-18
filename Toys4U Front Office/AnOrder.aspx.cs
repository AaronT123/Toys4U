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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsOrder
            //clsOrder AnOrder = new clsOrder();
            //capture the OrderID
            //AnOrder.OrderID = Convert.ToInt32(txtOrderId.Text);
            //AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            //AnOrder.CustomerID = Convert.ToInt32(txtCustomerNo.Text);
            //Store the order in the session object
            //Session["AnOrder"] = AnOrder;
            //add the new record
            Add();
            //redirect to the viewer page
            Response.Redirect("OrderList.aspx");
        }

        void Add()
        {
            //create an instance of the order book
            clsOrderCollection OrderBook = new clsOrderCollection();
            //validate the data on the web form
            String Error = OrderBook.ThisOrder.Valid(txtOrderId.Text, txtOrderDate.Text, txtCustomerNo.Text);
            //if the data is OK then add it to the object
            if(Error == "")
            {
                //get the data entered by the user
                OrderBook.ThisOrder.OrderID = Convert.ToInt32(txtOrderId.Text);
                OrderBook.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
                OrderBook.ThisOrder.CustomerID = Convert.ToInt32(txtCustomerNo.Text);
                //add the record
                OrderBook.Add();
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }
    }
}