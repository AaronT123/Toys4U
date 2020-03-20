using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Toys4U_Front_Office
{
    public partial class OrderList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if(IsPostBack == false)
            {
                //update the list box
                DisplayOrders();
            }

        }

        void DisplayOrders()
        {
            //create an instance of the Order Collection
            Toys4U_Classes.clsOrderCollection Orders = new Toys4U_Classes.clsOrderCollection();
            //set the data source to the list of Orders in the collection
            lstOrders.DataSource = Orders.OrderList;
            //set the name of the primary key
            lstOrders.DataValueField = "OrderID";
            //set the data field to display
            lstOrders.DataTextField = "OrderID";
            //bind the data to the list
            lstOrders.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["OrderID"] = -1;
            //redirect to data entry page
            Response.Redirect("AnOrder.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 OrderID;
            //if a record has been selected from the list
            if(lstOrders.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                OrderID = Convert.ToInt32(lstOrders.SelectedValue);
                //store the data in the session object
                Session["OrderID"] = OrderID;
                //redirect to delete page
                Response.Redirect("OrderDelete.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be updated
            Int32 OrderID;
            //if a record has been selected from the list
            if (lstOrders.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                OrderID = Convert.ToInt32(lstOrders.SelectedValue);
                //store the data in the session object
                Session["OrderID"] = OrderID;
                //redirect to the edit page
                Response.Redirect("AnOrder.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void lstOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}