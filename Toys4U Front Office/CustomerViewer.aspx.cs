using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class CustomerViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create an instance of clsCustomer
            clsCustomer AnCustomer = new clsCustomer();
            //get the data from the session object
            AnCustomer = (clsCustomer)Session["AnCustomer"];
            //display the Customer ID for entry
            Response.Write(AnCustomer.CustomerID);
            Response.Write(AnCustomer.EmailAddress);
            Response.Write(AnCustomer.Password);
            Response.Write(AnCustomer.FirstName);
            Response.Write(AnCustomer.LastName);
            Response.Write(AnCustomer.PhoneNumber);
            Response.Write(AnCustomer.PostCode);
            Response.Write(AnCustomer.StreetName);
        }
    }
}