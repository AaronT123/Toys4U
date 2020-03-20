using System;
using System.Collections.Generic;

namespace Toys4U_Classes
{
    public class clsDeliveryCollection
    {
        //private data member for the list
        List<clsDelivery> mDeliveryList = new List<clsDelivery>();
        //private data member thisDelivery
        clsDelivery mThisDelivery = new clsDelivery();
        //constructor for the class
        public clsDeliveryCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        //public property for the delivery list
        public List<clsDelivery> DeliveryList
        {
            get
            {
                //return the private data
                return mDeliveryList;
            }
            set
            {
                //set the private data
                mDeliveryList = value;
            }

        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mDeliveryList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisDelivery
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@OrderID", mThisDelivery.OrderID);
            DB.AddParameter("@HouseNo", mThisDelivery.HouseNo);
            DB.AddParameter("@Street", mThisDelivery.Street);
            DB.AddParameter("@Town", mThisDelivery.Town);
            DB.AddParameter("@City", mThisDelivery.City);
            DB.AddParameter("@Postcode", mThisDelivery.Postcode);
            DB.AddParameter("@DateAdded", mThisDelivery.DateAdded);
            DB.AddParameter("@DateEstimated", mThisDelivery.DateEstimated);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblDelivery_Insert");
        }

        public clsDelivery ThisDelivery
        {
            get
            {
                //return the private data
                return mThisDelivery;
            }
            set
            {
                //set the private data
                mThisDelivery = value;
            }
        }

        public void Delete()
        {
            //deletes the reecord pointed to by thisDelivery
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored proceedure
            DB.AddParameter("@DeliveryID", mThisDelivery.DeliveryID);
            //execute the stored proceedure
            DB.Execute("sproc_tblDelivery_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisDelivery
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DeliveryID", mThisDelivery.DeliveryID);
            DB.AddParameter("@OrderID", mThisDelivery.OrderID);
            DB.AddParameter("@HouseNo", mThisDelivery.HouseNo);
            DB.AddParameter("@Street", mThisDelivery.Street);
            DB.AddParameter("@Town", mThisDelivery.Town);
            DB.AddParameter("@City", mThisDelivery.City);
            DB.AddParameter("@Postcode", mThisDelivery.Postcode);
            DB.AddParameter("@DateAdded", mThisDelivery.DateAdded);
            DB.AddParameter("@DateEstimated", mThisDelivery.DateEstimated);
            //execute the stored procedure
            DB.Execute("Sproc_tblDelivery_Update");
        }

        public void ReportByPostcode(string Postcode)
        {
            //filters the records based on a full or partial postcode
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Postcode parameter to the database
            DB.AddParameter("@PostCode", Postcode);
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_FilterByPostcode");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mDeliveryList = new List<clsDelivery>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank delivery
                clsDelivery ADelivery = new clsDelivery();
                //read in the fields from the current record
                ADelivery.DeliveryID = Convert.ToInt32(DB.DataTable.Rows[Index]["DeliveryID"]);
                ADelivery.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                ADelivery.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                ADelivery.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                ADelivery.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                ADelivery.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                ADelivery.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                ADelivery.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ADelivery.DateEstimated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateEstimated"]);
                //add the record to the private data member
                mDeliveryList.Add(ADelivery);
                //point at the next record
                Index++;
            }
        }
    }
}