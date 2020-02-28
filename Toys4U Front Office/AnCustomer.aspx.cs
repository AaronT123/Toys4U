using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Toys4U_Classes;

namespace Toys4U_Front_Office
{
	public partial class AnCustomer : System.Web.UI.Page
	{
        //variable to store the primary key with page level scope
        Int32 CustomerID;

        // event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
		{
            //get the number of the Customer to be processed
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
            if (IsPostBack == false)
            {
                //populate the list of customers
                DisplayCustomer();
                //if this is not a new record
                if (CustomerID != -1)
                {
                    //display the current data for the record 
                    DisplayCustomer();

                }
            }
        }
        void DisplayCustomer()
        {
            //create an instance of the addres book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerID);
            //display the data for this record
            txtEmailAddress.Text = CustomerBook.ThisCustomer.EmailAddress;
            txtPassword.Text = CustomerBook.ThisCustomer.Password;
            txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
            txtLastName.Text = CustomerBook.ThisCustomer.LastName;
            txtPhoneNumber.Text = CustomerBook.ThisCustomer.PhoneNumber;
            txtPostCode.Text = CustomerBook.ThisCustomer.PostCode;
            txtStreetName.Text = CustomerBook.ThisCustomer.StreetName;
            txtHouseNo.Text = CustomerBook.ThisCustomer.HouseNo;


        }
        //event handler for the ok button
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (CustomerID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }

            //All done so redirect back to the main page
            Response.Redirect("CustomerList.aspx");

            ////create and new instance of clsCustomer
            //clsCustomer AnCustomer = new clsCustomer();
            ////capture the Customer ID
            //AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            //AnCustomer.EmailAddress = txtEmailAddress.Text;
            //AnCustomer.Password = txtPassword.Text;
            //AnCustomer.FirstName = txtFirstName.Text;
            //AnCustomer.LastName = txtLastName.Text;
            //AnCustomer.PhoneNumber = txtPhoneNumber.Text;
            //AnCustomer.PostCode = txtPostCode.Text;
            //AnCustomer.StreetName = txtStreetName.Text;


            ////store teh address in the session object
            //Session["AnCustomer"] = AnCustomer;
            ////redirect to the viewer page
            //Response.Redirect("CustomerViewer.aspx");

        }
        //function for adding new record
        void Add()
        {
            //create an instance of the Customer Book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //Validate the data on the web form
            string Error = CustomerBook.ThisCustomer.Valid(txtEmailAddress.Text, txtPassword.Text, txtFirstName.Text,
                txtLastName.Text, txtPhoneNumber.Text, txtPostCode.Text, txtStreetName.Text, txtHouseNo.Text);
            // if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the user
                CustomerBook.ThisCustomer.EmailAddress = txtEmailAddress.Text;
                CustomerBook.ThisCustomer.Password = txtPassword.Text;
                CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerBook.ThisCustomer.LastName = txtLastName.Text;
                CustomerBook.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
                CustomerBook.ThisCustomer.PostCode = txtPostCode.Text;
                CustomerBook.ThisCustomer.StreetName = txtStreetName.Text;
                CustomerBook.ThisCustomer.HouseNo = txtHouseNo.Text;
                //add the record
                CustomerBook.Add();
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered" + Error;
            }

        }
        void Update()
        {
            //create an insatcne of the Customer book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            String Error = CustomerBook.ThisCustomer.Valid(txtEmailAddress.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text,
                txtPhoneNumber.Text, txtPostCode.Text, txtStreetName.Text, txtHouseNo.Text);
            //if the data is OK thne add it to the object
            if (Error == "")
            {
                //find the record to update
                CustomerBook.ThisCustomer.Find(CustomerID);
                //get the data entered by the user
                CustomerBook.ThisCustomer.EmailAddress = txtEmailAddress.Text;
                CustomerBook.ThisCustomer.Password = txtPassword.Text;
                CustomerBook.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerBook.ThisCustomer.LastName = txtLastName.Text;
                CustomerBook.ThisCustomer.PhoneNumber = txtPhoneNumber.Text;
                CustomerBook.ThisCustomer.PostCode = txtPostCode.Text;
                CustomerBook.ThisCustomer.StreetName = txtStreetName.Text;
                CustomerBook.ThisCustomer.HouseNo = txtHouseNo.Text;
                //update the record
                CustomerBook.Update();
                //All done so redirect back to the main page
                Response.Redirect("CustomerList.aspx");

            }
            else
            {
                //report an error
                lblError.Text = "There were problem with the data entered" + Error;
            }
        }

    }
}