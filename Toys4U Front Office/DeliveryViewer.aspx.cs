using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class DeliveryViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of clsDelivery
            clsDelivery ADelivery = new clsDelivery();
            //get the data from the session object
            ADelivery = (clsDelivery)Session["ADelivery"];
            //display the Order ID for this entry
            Response.Write("Order ID: " + ADelivery.OrderID + "<br />");
            Response.Write("House No: " + ADelivery.HouseNo + "<br />");
            Response.Write("Street: " + ADelivery.Street + "<br />");
            Response.Write("Town: " + ADelivery.Town + "<br />");
            Response.Write("City: " + ADelivery.City + "<br />");
            Response.Write("Postcode: " + ADelivery.Postcode + "<br />");
            Response.Write("DateAdded: " + ADelivery.DateAdded.ToString("dd/MM/yyyy") + "<br />");
            Response.Write("DateEstimated: " + ADelivery.DateEstimated.ToString("dd/MM/yyyy") + "<br />");
        }
    }
}