using System;
using System.Collections.Generic;

namespace Toys4U_Classes
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        
        //constructor for the class
        public clsStaffCollection()
        {
            //create the items of test data
            clsStaff TestItem = new clsStaff();
            //set its propertiesdd
            //TestItem.DateOfBirth = 01/'01/2000;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Email = "callumjohnsimpson@hotmail.com";
            TestItem.HourlyPay = 7.77m;
            TestItem.LastName = "Simpson";
            TestItem.Password = "Something!";
            TestItem.PhoneNumber = "07465 659874";
            TestItem.FirstName = "Callum";
            TestItem.JobTitle = "Manager";
            //add the item to the list 
            mStaffList.Add(TestItem);
            //re initialise the object for some new data 
            TestItem = new clsStaff();
            //set its properties
            //TestItem.DateOfBirth = 01/'01/2000;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Email = "random@hotmail.com";
            TestItem.HourlyPay = 6.77m;
            TestItem.LastName = "";
            TestItem.Password = "Something!";
            TestItem.PhoneNumber = "02345 675243";
            TestItem.FirstName = "John";
            TestItem.JobTitle = "Clerk";
            //add the item to the list
            mStaffList.Add(TestItem);

        }

        //public List<clsStaff> StaffList { get; set; }
        //expose the private data via the public property
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;

            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        //return the value of the Count property of the list as the value of our own 
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

       
        public clsStaff ThisStaff { get; set; }
    }
}