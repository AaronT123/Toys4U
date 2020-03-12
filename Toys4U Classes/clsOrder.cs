using System;

namespace Toys4U_Classes
{
    public class clsOrder
    { 

        //private data memeber for the OrderID property
        private Int32 mOrderID;
        //private data memeber for the CustomerID property
        private Int32 mCustomerID;
        //private data memeber for the OrderDate property
        private DateTime mOrderDate;

        //public property for the Order ID
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member
                mOrderID = value;
            }
        }
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
        //public property for the OrderDate
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }
        }

        public string Valid(string text1, string text2, string text3)
        {
            throw new NotImplementedException();
        }

        public Boolean Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                //return everything that worked ok
                return true;
            }
            else
            {
                //if no record was found
                return false;
            }
        }
    }
}