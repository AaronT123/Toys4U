using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Toys4U_Front_Office
{
    public partial class CustomerDeletePage : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer to be deleted from the session object
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {

        }
    }
}