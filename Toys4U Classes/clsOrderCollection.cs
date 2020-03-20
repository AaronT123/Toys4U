using System;
using System.Collections.Generic;

namespace Toys4U_Classes
{
    public class clsOrderCollection
    {
        //public List<clsCustomer> CustomerList { get; set; }
        //public int Count { get; set; }


        //private data member thisCustomer
        clsOrder mThisOrder = new clsOrder();


        //public property for thisCustomer
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }

            set
            {
                //set the private data
                mThisOrder = value;
            }
        }

        List<clsOrder> mOrderList = new List<clsOrder>();
        //public property for the customer list
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data 
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }

        }

        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                //add the record to the private data mamber
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
           // DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            //update an existing redcord based on the values of this Order
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("OrderID", mThisOrder.OrderID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }
    }
}