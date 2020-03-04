using System;

namespace Toys4U_Classes
{
    public class clsStaff
    {
        //PRIVATE DATA MEMEBER FOR THE PROPERTY
        private Int32 mStaffNo;
        public bool Admin { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public decimal HourlyPay { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
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

        public Boolean Find(int PrimaryKey)
        {//set the private data member to the test data value
            mStaffNo = 58;
            return true;
        }

        public string Valid(string text1, string text2, string text3)
        {
            string Error = "";
            return Error;
        }


        
        
    }

  
}