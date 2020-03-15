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
        //variable to store the primary key with page level scope
        Int32 DeliveryID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {

            //get the number of the delivery to be processed
            DeliveryID = Convert.ToInt32(Session["DeliveryID"]);

            if (IsPostBack == false)
            {
                //populate the list of Deliveries
                DisplayDelivery();
                //if this is not a new record
                if (DeliveryID != -1)
                {
                    //display the current data for the record
                    DisplayDelivery();
                }
            }
        }

        void DisplayDelivery()
        {
            clsDeliveryCollection MyDeliveries = new clsDeliveryCollection();
            //find the record to update
            MyDeliveries.ThisDelivery.Find(DeliveryID);
            //display the data for this record
            txtOrderID.Text = Convert.ToString(MyDeliveries.ThisDelivery.OrderID);
            txtHouseNo.Text = MyDeliveries.ThisDelivery.HouseNo;
            txtStreet.Text = MyDeliveries.ThisDelivery.Street;
            txtTown.Text = MyDeliveries.ThisDelivery.Town;
            txtCity.Text = MyDeliveries.ThisDelivery.City;
            txtPostcode.Text = MyDeliveries.ThisDelivery.Postcode;
            txtDateAdded.Text = Convert.ToString(MyDeliveries.ThisDelivery.DateAdded);
            txtDateEstimated.Text = Convert.ToString(MyDeliveries.ThisDelivery.DateEstimated);
        }

        //function for addding new records
        void Add()
        {
            //create an instance of a clsDeliveryCollection
            clsDeliveryCollection MyDeliveries = new clsDeliveryCollection();
            //validate the data on the web form
            String Error = MyDeliveries.ThisDelivery.Valid(txtOrderID.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtCity.Text, txtPostcode.Text, txtDateAdded.Text, txtDateEstimated.Text);
            if (Error == "")
            {
                //get the data entered by the user
                MyDeliveries.ThisDelivery.OrderID = Convert.ToInt32(txtOrderID.Text);
                MyDeliveries.ThisDelivery.HouseNo = txtHouseNo.Text;
                MyDeliveries.ThisDelivery.Street = txtStreet.Text;
                MyDeliveries.ThisDelivery.Town = txtTown.Text;
                MyDeliveries.ThisDelivery.City = txtCity.Text;
                MyDeliveries.ThisDelivery.Postcode = txtPostcode.Text;
                MyDeliveries.ThisDelivery.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                MyDeliveries.ThisDelivery.DateEstimated = Convert.ToDateTime(txtDateEstimated.Text);
                //add the record
                MyDeliveries.Add();
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            /*
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
            */

            if (DeliveryID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                //Update();
            }
            //redirect to the viewer page
            Response.Redirect("DeliveryList.aspx");
        }
    }
}