using System;

namespace Toys4U_Classes
{
    public class clsCustomer
    {
        //private data memeber for the CustomerID property
        private Int32 mCustomerID;
        ////private data memeber for the EmailAddress property
        //private Int32 mEmailAddress;
        ////private data memeber for the FirstName property
        //private Int32 mFirstName;
        ////private data memeber for the LastName property
        //private Int32 mLastName;
        ////private data memeber for the Password property
        //private Int32 mPassword;
        ////private data memeber for the PhoneNumber property
        //private Int32 mPhoneNUmber;
        ////private data memeber for the PostCode property
        //private Int32 mPostCode;
        ////private data memeber for the StreetName property
        //private Int32 mStreetName;
        ////private data memeber for the HouseNo property
        //private Int32 mHouseNo;

        //public property for the Customer ID
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }


     
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string PostCode { get; set; }
        public string StreetName { get; set; }
        public string HouseNo { get; set; }

        public Boolean Find(int CustomerID)
        {
            //set the private data memebr to the test data value
            mCustomerID = 104;
            //always return true
            return true;
        }

        public string Valid(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            string Error = "";
            return Error;
        }
    }
}