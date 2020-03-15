using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class DeliveryDelete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be delete
        Int32 DeliveryID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be deleted from the session object
            DeliveryID = Convert.ToInt32(Session["DeliveryID"]);
            lblDeliveryID.Text = Convert.ToString(DeliveryID);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteDelivery();
            //redirect back to main page
            Response.Redirect("DeliveryList.aspx");
        }

        void DeleteDelivery()
        {
            //delete selected record
            //create new instance of deliveries
            clsDeliveryCollection Deliveries = new clsDeliveryCollection();
            //find the record to delete
            Deliveries.ThisDelivery.Find(DeliveryID);
            //delete the record
            Deliveries.Delete();
        }
    }
}