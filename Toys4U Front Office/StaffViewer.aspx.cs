using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;
namespace Toys4U_Front_Office
{
    public partial class StaffViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of clsStaff
            clsStaff AnStaff = new clsStaff();
            //get the data from the session object
            AnStaff = (clsStaff)Session["AnStaff"];
            //display the first name for this entry
            Response.Write(AnStaff.Email);
            Response.Write(AnStaff.FirstName);
            Response.Write(AnStaff.HourlyPay);
            Response.Write(AnStaff.JobTitle);
            Response.Write(AnStaff.LastName);
            Response.Write(AnStaff.Password);
            Response.Write(AnStaff.PhoneNumber);
         
        }
    }
}