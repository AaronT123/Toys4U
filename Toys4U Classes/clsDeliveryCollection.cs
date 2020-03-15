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
            /*
            //create the items of test data
            clsDelivery TestItem = new clsDelivery();
            //set its properties
            TestItem.DeliveryID = 1;
            TestItem.OrderID = 1;
            TestItem.HouseNo = "32B";
            TestItem.Street = "London Road";
            TestItem.Town = "Oadby";
            TestItem.City = "Leicester";
            TestItem.Postcode = "LE2 5DH";
            TestItem.DateAdded = Convert.ToDateTime("20/12/2020");
            TestItem.DateEstimated = Convert.ToDateTime("25/12/2020");
            //add the item to the test list
            mDeliveryList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsDelivery();
            //set its properties
            TestItem.DeliveryID = 2;
            TestItem.OrderID = 2;
            TestItem.HouseNo = "8";
            TestItem.Street = "Colby Drive";
            TestItem.Town = "Thurmaston";
            TestItem.City = "Leicester";
            TestItem.Postcode = "LE4 8LA";
            TestItem.DateAdded = Convert.ToDateTime("21/12/2020");
            TestItem.DateEstimated = Convert.ToDateTime("26/12/2020");
            //add the item to the test list
            mDeliveryList.Add(TestItem);
            */

            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDelivery_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank delivery
                clsDelivery ADelivery = new clsDelivery();
                //read in the fileds from the current record
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
    }
}