using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class AnStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            //create a new instance of the clsStaff
            clsStaff AnStaff = new clsStaff();
            //capture the data
            AnStaff.Email = TextBoxEmail.Text;
            AnStaff.FirstName = TextBoxFirstName.Text;
            AnStaff.HourlyPay = TextBoxHourlyPay.Text;
            AnStaff.JobTitle = TextBoxJobTitle.Text;
            AnStaff.LastName = TextBoxLastName.Text;
            AnStaff.Password = TextBoxPassword.Text;
            AnStaff.PhoneNumber = TextBoxPhoneNumber.Text;
           
            //store the first name in the session object
            Session["AnStaff"] = AnStaff;
            //redurect to the viewer page
            Response.Redirect("StaffViewer.aspx");

        }
    }
}