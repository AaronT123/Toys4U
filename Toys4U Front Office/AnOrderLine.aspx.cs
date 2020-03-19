using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class AnOrderLine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsOrderLine
            clsOrderLine AnOrderLine = new clsOrderLine();
            //capture the ProductID
            AnOrderLine.ProductID = Convert.ToInt32(txtProductID.Text);
            //store the OrderLine in the session object
            Session["AnOrderLine"] = AnOrderLine;
            //redirect to the viewer page
            Response.Redirect("OrderLineViewer.aspx");

        }
    }
}