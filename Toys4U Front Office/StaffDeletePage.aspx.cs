using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class StaffDeletePage : System.Web.UI.Page
    {

        //var to store the primary key of the record to be deleted
        Int32 StaffNo;
        //event handler for the load event 
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the address to be deleted from the session object
            StaffNo = Convert.ToInt32(Session["StaffNo"]);
            LoadLabel.Text = "Are you sure you want to delete the selected staff with ID:" + StaffNo;
        }


        void DeleteStaff()
        {
            //fuction to delete the seceted record

            //create a new instance of the SomeStaff
            clsStaffCollection SomeStaff = new clsStaffCollection();
            //find the record to delete
            SomeStaff.ThisStaff.Find(StaffNo);
            //DELETE THE RECORD
            SomeStaff.Delete();

        }
        //event handler for yes button
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record.
            DeleteStaff();
            //redirect back to the main page
            Response.Redirect("StaffList.aspx");

        }

        

        protected void btnNo_Click1(object sender, EventArgs e)
        {
            Response.Redirect("StaffList.aspx");
        }
    }
}