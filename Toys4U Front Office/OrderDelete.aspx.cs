using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class OrderDelete : System.Web.UI.Page
    {
        Int32 OrderID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the order to be deleted from the session object
            OrderID = Convert.ToInt32(Session["OrderID"]);
        }

        void DeleteOrder()
        {
            //create a new instance of the order book
            clsOrderCollection OrderBook = new clsOrderCollection();
            //find the record to delete
            OrderBook.ThisOrder.Find(OrderID);
            //delete the record
            OrderBook.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteOrder();
            //redirect back to main page
            Response.Redirect("OrderList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderList.aspx");
        }
    }
}