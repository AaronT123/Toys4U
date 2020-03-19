using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class OrderViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of the clsOrder class
            clsOrder AnOrder = new clsOrder();
            //get the data from the session object
            AnOrder = (clsOrder)Session["AnOrder"];
            //display the OrderID for this entry
            Response.Write(AnOrder.OrderID);
            Response.Write(AnOrder.OrderDate);
            Response.Write(AnOrder.CustomerID);
        }
    }
}