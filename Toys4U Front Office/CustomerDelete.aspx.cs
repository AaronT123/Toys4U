using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class CustomerDelete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer to be deleted from the session object
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
        }

        protected void btnYes_Click1(object sender, EventArgs e)
        {
            //delete the record 
            DeleteCustomer();
            //redirect back to the main page
            Response.Redirect("CustomerList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
           
            
                Response.Redirect("CustomerList.aspx");
            
        }

        void DeleteCustomer()
        {
            //function a new instance of the selected record
            //create a new instance of the Customer book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //find the record to delete
            CustomerBook.ThisCustomer.Find(CustomerID);
            //delete the record
            CustomerBook.Delete();
        }
    }
}