using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Toys4U_Front_Office
{
    public partial class StaffList : System.Web.UI.Page
    {
        //this function handles the load event for the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the firct time the page is displayed
            if (IsPostBack == false)
            {
                //UPDATE THE LIST BOX
                DisplayStaff();
            }

        }

        void DisplayStaff()
        {
            //create an instance of the staff collection
            Toys4U_Classes.clsStaffCollection Staffs = new Toys4U_Classes.clsStaffCollection();
            //set the data source to the list of staff in the collection
            lstStaff.DataSource = Staffs.StaffList;
            //set the name of the primary key
            lstStaff.DataValueField = "StaffNo";
            //bind the data to the list
            lstStaff.DataTextField = "FirstName";
            //bind the data to the list 
            lstStaff.DataBind();
        }

        //event handler for the add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["StaffId"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnStaff.aspx");
        }

        //event handler for the delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 StaffId;
            //if a record has been selected from the list 
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key of thge record to delete
                StaffId = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffId"] = StaffId;
                //redirect to the delete page
                Response.Redirect("StaffDelete.aspx");

            }
            else //if no record has been selected
            {
                //display an error 
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        //event handler for the edit button
        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 StaffId;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex !=-1)
            {
                //get the primary key value of the record to edit
                StaffId = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffId"] = StaffId;
                //redirect to the edit page
                Response.Redirect("AnStaff.aspx");

            }
            else//if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {

        }
    }
}