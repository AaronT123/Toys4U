using System.Collections.Generic;
using System;


namespace Toys4U_Classes
{
    public class clsCustomerCollection
    {
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for thisCustomer
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }

            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
           

            get
            {
               // return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }

        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
          
        }
        //constructor for the class
        public clsCustomerCollection()
        {
            //object for the class
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procdure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate that array list
            PopulateArray(DB);
        
        }
        public int Add()
        {
            //mThisCustomer.CustomerID = 123;
            //return mThisCustomer.CustomerID;
            //adds a new record to the database based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@StreetName", mThisCustomer.StreetName);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            //exectute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }
        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
        public void Update()
        {
            //update an exisiting record based on the values of thiscustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@StreetName", mThisCustomer.StreetName);
            DB.AddParameter("@HouseNo", mThisCustomer.HouseNo);
            //exectute the query returning the primary key value
            DB.Execute("sproc_tblCustomer_Update");
        }
        public void ReportByPostCode(string PostCode)
        {
            //create an instance of the filtered data
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByPostCode");
            //populate the array list with data table
            PopulateArray(DB);
        }
        void PopulateArray (clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count record
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AnCustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                AnCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnCustomer.StreetName = Convert.ToString(DB.DataTable.Rows[Index]["StreetName"]);
                AnCustomer.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }

    }
}