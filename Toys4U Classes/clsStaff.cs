using System;

namespace Toys4U_Classes
{
    public class clsStaff
    {
        //PRIVATE DATA MEMEBER FOR THE PROPERTY
        private Int32 mStaffNo;
        private bool mAdmin;


        private DateTime mDateJoined;
        private DateTime mDateOfBirth;
        private string mEmail;
        private string mFirstName;
        private decimal mHourlyPay;
        private string mJobTitle;
        private string mLastName;
        private string mPassword;
        private string mPhoneNumber;
        public int StaffNo
        {
            get
            {
                //return the private data
                return mStaffNo;
            }
            set
            {
                //set the value of the provate data ember
                mStaffNo = value;
            }
        }

        public bool Admin
        {
            get
            {
                //return the private data
                return mAdmin;
            }
            set
            {
                //set the value of the provate data ember
                mAdmin = value;
            }
        }

        public DateTime DateJoined
        {
            get
            {
                //return the private data
                return mDateJoined;
            }
            set
            {
                //set the value of the provate data ember
                mDateJoined = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the value of the provate data ember
                mDateOfBirth = value;
            }
        }

        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the value of the provate data ember
                mEmail = value;
            }
        }

        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the provate data ember
                mFirstName = value;
            }
        }

        public decimal HourlyPay
        {
            get
            {
                //return the private data
                return mHourlyPay;
            }
            set
            {
                //set the value of the provate data ember
                mHourlyPay = value;
            }
        }

        public string JobTitle
        {
            get
            {
                //return the private data
                return mJobTitle;
            }
            set
            {
                //set the value of the provate data ember
                mJobTitle = value;
            }
        }

        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the value of the provate data ember
                mLastName = value;
            }
        }
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the value of the provate data ember
                mPassword = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the value of the provate data ember
                mPhoneNumber = value;
            }
        }

        public Boolean Find(int PrimaryKey)
        {//set the private data member to the test data value
            //mStaffNo = 58;
            //mAdmin = true;
            //mDateJoined = Convert.ToDateTime("12 / 12 / 2012");
            //mDateOfBirth = Convert.ToDateTime("12 / 12 / 2012");
            //mEmail = "test@hotmail.com";
            //mFirstName = "Test";
            //mHourlyPay = 999m;
            //mJobTitle = "Test";
            //mLastName = "Test";
            //mPassword = "Test";
            //mPhoneNumber = "99999 999999";
            //return true;


            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("StaffNo", StaffNo);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByJobTitle");
            //if one record is found (there should be either one or zero!)
            if (DB.Count ==1)
            {
                //copy the data from the database to the private data members
                mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                mAdmin = Convert.ToBoolean(DB.DataTable.Rows[0]["Admin"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mHourlyPay = Convert.ToDecimal(DB.DataTable.Rows[0]["HourlyPay"]); ;
                mJobTitle = Convert.ToString(DB.DataTable.Rows[0]["JobTitle"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string text1, string text2, string text3)
        {
            string Error = "";
            return Error;
        }


        
        
    }

  
}