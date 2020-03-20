using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class DeliveryList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this function handles the load event for the page
            if (IsPostBack == false)
            {
                //update the listbox
                DisplayDelivery();
            }
        }

        void DisplayDelivery()
        {
            //create an instance of the delivery collection
            clsDeliveryCollection Deliveries = new clsDeliveryCollection();
            //set the data source to the list of Deliveries in the collection
            lstDelivery.DataSource = Deliveries.DeliveryList;
            //set the name of the primary key
            lstDelivery.DataValueField = "DeliveryID";
            //set the data field to display
            lstDelivery.DataTextField = "PostCode";

            //bing the data to the list
            lstDelivery.DataBind();
        }

        //event handler for the add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["DeliveryID"] = -1;
            //redirect to the data entry page
            Response.Redirect("ADelivery.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 DeliveryID;
            //if a record has been selected from the list
            if (lstDelivery.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                DeliveryID = Convert.ToInt32(lstDelivery.SelectedValue);
                //store the data in the session object
                Session["DeliveryID"] = DeliveryID;
                //redirect to the delete page
                Response.Redirect("DeliveryDelete.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 DeliveryID;
            //if a record has been selected from the list
            if (lstDelivery.SelectedIndex != -1)
            {
                //get the priamry key value of the record to edit
                DeliveryID = Convert.ToInt32(lstDelivery.SelectedValue);
                //store the data in the session object
                Session["DeliveryID"] = DeliveryID;
                //redirect to the edit page
                Response.Redirect("ADelivery.aspx");
            }
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        //filter the listbox by the user entered postcode
        protected void btnApply_Click(object sender, EventArgs e)
        {
            FilterDelivery(txtPostcode.Text);
        }

        //reset the listbox to display all postcodes
        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            FilterDelivery("");
        }

        //Filter the delivery tables by the user entered postcode
        Int32 FilterDelivery(string PostcodeFilter)
        {
            //declare the variables for the listbox
            Int32 DeliveryID;
            string Postcode;
            //create an instance of the delivery collection
            clsDeliveryCollection ListOfDeliveries = new clsDeliveryCollection();
            //Apply the postcode filter to the list
            ListOfDeliveries.ReportByPostcode(PostcodeFilter);
            //declare the variables so we can loop through the results
            Int32 RecordCount;
            Int32 Index = 0;
            //Assign the record count to the amount of filtered postcodes
            RecordCount = ListOfDeliveries.Count;
            //clear the listbox
            lstDelivery.Items.Clear();
            //while the current record is lower than the total records
            while(Index<RecordCount)
            {
                //Assign the delivery ID to the indexed delivery ID
                DeliveryID = ListOfDeliveries.DeliveryList[Index].DeliveryID;
                //Assign the postcode to the indexed postcode
                Postcode = ListOfDeliveries.DeliveryList[Index].Postcode;
                //create a new list item formed of the postcode and its delivery ID
                ListItem NewDelivery = new ListItem(Postcode + "", DeliveryID.ToString());
                //add the list item to the new delivery list
                lstDelivery.Items.Add(NewDelivery);
                //increase the index
                Index++;
            }
            //return the record count
            return RecordCount;
        }
    }
}