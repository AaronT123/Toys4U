using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
    public partial class AnStaffManagement : System.Web.UI.Page
    {
        //var to store the staff No with page level scope
        Int32 StaffNo;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be processed 
            StaffNo = Convert.ToInt32(Session["StaffNo"]);
            if (IsPostBack == false)
            {
              
                //if this is not a new record
                if (StaffNo != -1)
                {
                    //display the current data for the record
                    DisplayData();
                }

            }
        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            if (StaffNo == -1)
            {

                //add the new recprd
                Add();
            }
            else
            {
                //update a record with the details given
                Update();
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            //go back to the StaffManage list page
            Response.Redirect("StaffManagementList.aspx");
        }


        void DisplayData()
        {
            //create an instance of the somestaff 
            clsStaffManagementCollection SomeStaff = new clsStaffManagementCollection();
            //find the record to update
            SomeStaff.ThisStaff.Find(StaffNo);
            //display the data for this record
            CheckBoxAdmin.Checked = SomeStaff.ThisStaff.Admin;
            TextBoxDateOfBirth.Text = SomeStaff.ThisStaff.DateOfBirth.ToString();
            TextBoxDateJoined.Text = SomeStaff.ThisStaff.DateJoined.ToString();
            TextBoxEmail.Text = SomeStaff.ThisStaff.Email;
            TextBoxHourlyPay.Text = SomeStaff.ThisStaff.HourlyPay.ToString();
            TextBoxLastName.Text = SomeStaff.ThisStaff.LastName;
            TextBoxPassword.Text = SomeStaff.ThisStaff.Password;
            TextBoxPhoneNumber.Text = SomeStaff.ThisStaff.PhoneNumber;
            TextBoxFirstName.Text = SomeStaff.ThisStaff.FirstName;
            TextBoxJobTitle.Text = SomeStaff.ThisStaff.JobTitle;

        }

        //function for adding new records
        void Add()
        {
            //create an instance of the staff collection
            clsStaffManagementCollection SomeStaff = new clsStaffManagementCollection();
            //validate the data on the web form
            String Error = "";
            Error = SomeStaff.ThisStaff.Valid(TextBoxDateJoined.Text, TextBoxDateOfBirth.Text, TextBoxEmail.Text, TextBoxFirstName.Text, TextBoxHourlyPay.Text, TextBoxJobTitle.Text, TextBoxLastName.Text, TextBoxPassword.Text, TextBoxPhoneNumber.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user 
                SomeStaff.ThisStaff.Admin = CheckBoxAdmin.Checked;
                SomeStaff.ThisStaff.DateOfBirth = Convert.ToDateTime(TextBoxDateOfBirth.Text);
                SomeStaff.ThisStaff.DateJoined = Convert.ToDateTime(TextBoxDateJoined.Text);
                SomeStaff.ThisStaff.Email = TextBoxEmail.Text;
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
                lblError.Text += "There were problems with the data entered " + Error;

            }


        }

        public void Update()
        {
            //create an instance of the staff collection
            clsStaffManagementCollection SomeStaff = new clsStaffManagementCollection();
            //validate the data on the web form
            string Error = "";
            Error = SomeStaff.ThisStaff.Valid(TextBoxDateJoined.Text, TextBoxDateOfBirth.Text, TextBoxEmail.Text, TextBoxFirstName.Text, TextBoxHourlyPay.Text, TextBoxJobTitle.Text, TextBoxLastName.Text, TextBoxPassword.Text, TextBoxPhoneNumber.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //get the data entered by the user 
                SomeStaff.ThisStaff.StaffNo = StaffNo;
                SomeStaff.ThisStaff.Admin = CheckBoxAdmin.Checked;
                SomeStaff.ThisStaff.DateOfBirth = Convert.ToDateTime(TextBoxDateOfBirth.Text);
                SomeStaff.ThisStaff.DateJoined = Convert.ToDateTime(TextBoxDateJoined.Text);
                SomeStaff.ThisStaff.Email = TextBoxEmail.Text;
                SomeStaff.ThisStaff.HourlyPay = Convert.ToDecimal(TextBoxHourlyPay.Text);
                SomeStaff.ThisStaff.LastName = TextBoxLastName.Text;
                SomeStaff.ThisStaff.Password = TextBoxPassword.Text;
                SomeStaff.ThisStaff.PhoneNumber = TextBoxPhoneNumber.Text;
                SomeStaff.ThisStaff.FirstName = TextBoxFirstName.Text;
                SomeStaff.ThisStaff.JobTitle = TextBoxJobTitle.Text;

                //ADD THIS RECORD
                SomeStaff.Update();
                Response.Redirect("StaffManagementList.aspx");

            }
            else
            {
                //report an error 
                lblError.Text += "There were problems with the data entered " + Error;

            }

        }
    }
}