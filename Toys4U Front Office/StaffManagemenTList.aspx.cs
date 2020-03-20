using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;


namespace Toys4U_Front_Office
{
	public partial class StaffManagemenTList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (IsPostBack == false)
            {
                //UPDATE THE LIST BOX
                DisplayStaff();
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            FilterStaff(txtJobTitle.Text);
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            FilterStaff("");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            //store -1 into the session object to indicate this is a new record
            Session["StaffNo"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnStaffManagemenT.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 StaffNo;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                StaffNo = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffNo"] = StaffNo;
                //redirect to the edit page
                Response.Redirect("AnStaffManagemenT.aspx");

            }
            else//if no record has been selected
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

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
                Response.Redirect("StaffManagemenTDeletePage.aspx");

            }
            else //if no record has been selected
            {
                //display an error 
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        void DisplayStaff()
        {
            //create an instance of the staff collection
            clsStaffManagemenTCollection Staffs = new clsStaffManagemenTCollection();
            //set the data source to the list of staff in the collection
            lstStaff.DataSource = Staffs.StaffList;
            //set the name of the primary key
            lstStaff.DataValueField = "StaffNo";
            //bind the data to the list
            lstStaff.DataTextField = "JobTitle";
            //bind the data to the list 
            lstStaff.DataBind();
        }
        Int32 FilterStaff(string JobTitleFilter)
        {
            Int32 StaffNo;
            string JobTitle;
            clsStaffManagemenTCollection ListOfStaff = new clsStaffManagemenTCollection();
            ListOfStaff.ReportByJobTitle(JobTitleFilter);
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = ListOfStaff.Count;
            lstStaff.Items.Clear();
            while (Index < RecordCount)
            {
                StaffNo = ListOfStaff.StaffList[Index].StaffNo;
                JobTitle = ListOfStaff.StaffList[Index].JobTitle;
                ListItem NewStaff = new ListItem(JobTitle + "", StaffNo.ToString());
                lstStaff.Items.Add(NewStaff);
                Index++;
            }
            return RecordCount;

        }
    }
}