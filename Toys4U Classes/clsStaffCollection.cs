using System;
using System.Collections.Generic;

namespace Toys4U_Classes
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>()

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the recrod count 
            Int32 RecordCount = 0;
            //object for data conneciton
            clsDataConnection DB = new clsDataConnection();
            //execute the stored proceduire
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            //while there are recrods to procesds
            while (Index < RecordCount)
            {
                //create a blank staff
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                //TestStaff.DateOfBirth = 01/'01/2000; AnStaff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.HourlyPay = Convert.ToDecimal(DB.DataTable.Rows[Index]["HourlyPay"]);
                AnStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnStaff.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnStaff.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnStaff.JobTitle = Convert.ToString(DB.DataTable.Rows[Index]["JobTitle"]);
               
                //add the record to the private data member
                mStaffList.Add(AnStaff);
                //point at the next record
                Index++;
            }

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