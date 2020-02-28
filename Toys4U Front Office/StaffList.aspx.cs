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
        Int32 StaffNo;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be processed

            StaffNo = Convert.ToInt32(Session["StaffNo"]);
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
            Session["StaffNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnStaff.aspx");
        }

        //event handler for the delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 StaffNo;
            //if a record has been selected from the list 
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key of thge record to delete
                StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffNo"] = StaffNo;
                //redirect to the delete page
                Response.Redirect("StaffDeletePage.aspx");

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
            Int32 StaffNo;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex !=-1)
            {
                //get the primary key value of the record to edit
                StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffNo"] = StaffNo;
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