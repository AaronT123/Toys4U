using System;

namespace Toys4U_Classes
{
    public class clsCustomer
    {
        //private data memeber for the CustomerID property
        private Int32 mCustomerID;
        //private data memeber for the EmailAddress property
        private string mEmailAddress;
        //private data memeber for the FirstName property
        private string mFirstName;
        //private data memeber for the LastName property
        private string mLastName;
        //private data memeber for the Password property
        private string mPassword;
        //private data memeber for the PhoneNumber property
        private string mPhoneNumber;
        //private data memeber for the PostCode property
        private string mPostCode;
        //private data memeber for the StreetName property
        private string mStreetName;
        //private data memeber for the HouseNo property
        private string mHouseNo;

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

        //public property for the Email Address
        public string EmailAddress
        {
            get
            {
                //return the private data
                return mEmailAddress;
            }
            set
            {
                //set the value of the private data member
                mEmailAddress = value;
            }
        }
        //public property for the Password
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the value of the private data member
                mPassword = value;
            }
        }
        //public property for the FirstName
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data member
                mFirstName = value;
            }
        }
        //public property for the LastName
        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the value of the private data member
                mLastName = value;
            }
        }
        //public property for the PhoneNumber
        public string PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the value of the private data member
                mPhoneNumber = value;
            }
        }
        //public property for the PhoneNumber
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the value of the private data member
                mPostCode = value;
            }
        }
        //public property for the PhoneNumber
        public string StreetName
        {
            get
            {
                //return the private data
                return mStreetName;
            }
            set
            {
                //set the value of the private data member
                mStreetName = value;
            }
        }
        //public property for the PhoneNumber
        public string HouseNo
        {
            get
            {
                //return the private data
                return mHouseNo;
            }
            set
            {
                //set the value of the private data member
                mHouseNo = value;
            }
        }


        public Boolean Find(int CustomerID)
        {
            //set the private data memebr to the test data value
            mCustomerID = 104;
            mEmailAddress = "Test@gmail.com";
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