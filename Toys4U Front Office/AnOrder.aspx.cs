using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class AnOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsOrder
            clsOrder AnOrder = new clsOrder();
            //capture the OrderID
            AnOrder.OrderId = Convert.ToInt32(txtOrderId.Text);
            AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            AnOrder.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
            //Store the order in the session object
            Session["AnOrder"] = AnOrder;
            //redirect to the viewer page
            Response.Redirect("OrderViewer.aspx");
        }
    }
}