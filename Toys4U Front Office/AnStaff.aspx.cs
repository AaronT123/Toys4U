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
        //var to store the staff id with page level scope
        Int32 StaffId;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            ////create a new instance of the clsStaff
            //clsStaff AnStaff = new clsStaff();
            ////capture the data
            //AnStaff.Admin = CheckBoxAdmin.Checked;
            //AnStaff.DateOfBirth = Convert.ToDateTime(TextBoxDateOfBirth.Text);
            //AnStaff.DateJoined = Convert.ToDateTime(TextBoxDateJoined.Text);
            //AnStaff.Email = TextBoxEmail.Text;
            //AnStaff.HourlyPay = Convert.ToDecimal(TextBoxHourlyPay.Text);
            //AnStaff.LastName = TextBoxLastName.Text;
            //AnStaff.Password = TextBoxPassword.Text;
            //AnStaff.PhoneNumber = TextBoxPhoneNumber.Text;
            //AnStaff.FirstName = TextBoxFirstName.Text;
            //AnStaff.JobTitle = TextBoxJobTitle.Text;



            ////store the first name in the session object
            //Session["AnStaff"] = AnStaff;
            ////redurect to the viewer page
            //Response.Redirect("StaffViewer.aspx");

            //add the new recprd
            Add();
            //all done so redirect back to the main page
            Response.Redirect("StaffList.aspx");

        }


        //function for adding new records
        void Add()
        {
            //create an instance of the staff collection
            clsStaffCollection SomeStaff = new clsStaffCollection();
            //validate the data on the web form
            String Error = SomeStaff.ThisStaff.Valid(TextBoxStaffID.Text, TextBoxFirstName.Text, TextBoxLastName.Text);
            //if the data is ok then add it to the object
            if (Error =="")
            {
                //get the data entered by the user 
                SomeStaff.ThisStaff.Admin = CheckBoxAdmin.Checked;
                SomeStaff.ThisStaff.DateOfBirth = Convert.ToDateTime(TextBoxDateOfBirth.Text);
                SomeStaff.ThisStaff.DateJoined = Convert.ToDateTime(TextBoxDateJoined.Text);
                SomeStaff.ThisStaff.Email =TextBoxEmail .Text;
                SomeStaff.ThisStaff.HourlyPay = Convert.ToDecimal(TextBoxHourlyPay.Text);
                SomeStaff.ThisStaff.LastName = TextBoxLastName.Text;
                SomeStaff.ThisStaff.Password = TextBoxPassword.Text;
                SomeStaff.ThisStaff.PhoneNumber = TextBoxPhoneNumber.Text;
                SomeStaff.ThisStaff.FirstName = TextBoxFirstName.Text;
                SomeStaff.ThisStaff.JobTitle = TextBoxJobTitle.Text;

                //ADD THIS RECORD
                SomeStaff.Add();


            }
            else
            {
                //report an error 
                lblError.Text = "There were problems with the data entered " + Error;

            }


        }
    }
}