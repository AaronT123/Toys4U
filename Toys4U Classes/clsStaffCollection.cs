using System.Collections.Generic;

namespace Toys4U_Classes
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        public clsStaffCollection()
        {
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