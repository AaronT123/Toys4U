using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // this function handles the load event for the page
            if (IsPostBack == false)
            {
                //update the list box
                DisplayCustomer();
            }
        }
        void DisplayCustomer()
        {
            //create an instance of the County Collection
            clsCustomerCollection Customer = new clsCustomerCollection();
            //set the data source to the list of countries in the collection
            lstCustomer.DataSource = Customer.CustomerList;
            //set the name of the primary key
            lstCustomer.DataValueField = "CustomerID";
            //set the data field to display
            lstCustomer.DataTextField = "PostCode";
            //bind the data to the list
            lstCustomer.DataBind();
        }
        //event handler for the add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["CustomerID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnCustomer.aspx");
        }
        //event handler for the delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 CustomerID;
            //if the record has been selected from the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session object
                Session["CustomerID"] = CustomerID;
                //redirect to the delete page
                Response.Redirect("CustomerDelete.aspx");
            }
            else //if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 CustomerID;
            //if a record has been selected form the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session object
                Session["CustomerID"] = CustomerID;
                //reidrect to the edit page
                Response.Redirect("AnCustomer.aspx");

            }
            else // if no record has been selected 
            {
                //display an error
                lblError.Text = "Please select a record to Edit from the list";
            }
        }
        protected void btnApply_Click(object sender, EventArgs e)
        {
            //display only Postcode 
            DisplayFilterCustomer(txtPostCode.Text);
        }
        Int32  DisplayFilterCustomer(string PostCodeFilter)
        {
            Int32 CustomerID;
            //string PostCode;
            string PostCode;
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            CustomerBook.ReportByPostCode(PostCodeFilter);
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = CustomerBook.Count;
            lstCustomer.Items.Clear();
            while(Index < RecordCount)
            {
                CustomerID = CustomerBook.CustomerList[Index].CustomerID;
                PostCode = CustomerBook.CustomerList[Index].PostCode;
                ListItem NewEntry = new ListItem(PostCode+ "" , CustomerID.ToString());
                lstCustomer.Items.Add(NewEntry);
                Index++;
            }
            return RecordCount;

        }
        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayFilterCustomer(txtPostCode.Text);
        }
    }
}