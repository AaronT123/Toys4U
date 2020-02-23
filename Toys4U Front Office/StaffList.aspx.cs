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
           ////create an instance of the staff collection
            //Toys4U_Classes.clsStaffCollection Staffs = new Toys4U_Classes.clsStaffCollection();
            ////set the data source to the list of staff in the collection
            //lstStaff.DataSource = Staffs.StaffList;
            ////set the name of the primary key
            //lstStaff.DataValueField = "StaffNo";
            ////bind the data to the list
            //lstStaff.DataTextField = "FirstName";
            ////bind the data to the list 
            //lstStaff.DataBind();
        }

        //event handler for the add button
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["StaffID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnStaff.aspx");
        }
    }
}