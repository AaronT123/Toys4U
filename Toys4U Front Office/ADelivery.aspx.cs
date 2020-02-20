using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class ADelivery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsDelivery
            clsDelivery ADelivery = new clsDelivery();
            //capture the Order ID
            ADelivery.OrderID = Convert.ToInt32(txtOrderID.Text);
            ADelivery.HouseNo = txtHouseNo.Text;
            ADelivery.Street = txtStreet.Text;
            ADelivery.Town = txtTown.Text;
            ADelivery.City = txtCity.Text;
            ADelivery.Postcode = txtPostcode.Text;
            ADelivery.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            ADelivery.DateEstimated = Convert.ToDateTime(txtDateEstimated.Text);
            //store the delivery in the session object
            Session["ADelivery"] = ADelivery;
            //redirect to the viewer page
            Response.Redirect("DeliveryViewer.aspx");
        }
    }
}