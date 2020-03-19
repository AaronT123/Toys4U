using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class OrderLineViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of the clsOrder class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //get the data from the session object
            AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
            //display the OrderID for this entry
            Response.Write(AnOrderLine.OrderID);
            Response.Write(AnOrderLine.ProductID);
            Response.Write(AnOrderLine.Quantity);
        }
    }
}