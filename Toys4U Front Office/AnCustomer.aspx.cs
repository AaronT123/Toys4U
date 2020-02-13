using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
	public partial class AnCustomer : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create and new instance of clsCustomer
            clsCustomer AnCustomer = new clsCustomer();
            //capture the Customer ID
            AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            AnCustomer.EmailAddress = txtEmailAddress.Text;
            AnCustomer.Password = txtPassword.Text;
            AnCustomer.FirstName = txtFirstName.Text;
            AnCustomer.LastName = txtLastName.Text;
            AnCustomer.PhoneNumber = txtPhoneNumber.Text;
            AnCustomer.PostCode = txtPostCode.Text;
            AnCustomer.StreetName = txtStreetName.Text;


            //store teh address in the session object
            Session["AnCustomer"] = AnCustomer;
            //redirect to the viewer page
            Response.Redirect("CustomerViewer.aspx");
 
        }
        
    }
}