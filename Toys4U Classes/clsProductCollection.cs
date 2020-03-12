using System.Collections.Generic;
using System;
namespace Toys4U_Classes
{
    public class clsProductCollection
    {
        //private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();
        //private data member thisproduct
        clsProduct mThisProduct = new clsProduct();


        //contructor for the class
        public clsProductCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank product detail
                clsProduct AnProduct = new clsProduct();
                //read in the fields from the current record and collect its data
                AnProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnProduct.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnProduct.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                //add the record to the private member
                mProductList.Add(AnProduct);
                //point at the next record
                Index++;
            }

  
        }

        //public property for the product list
        public List<clsProduct> ProductHome
        {
            get
            {
                //return the private data
                return mProductList;
            }
            set
            {
                //set the private data
                mProductList = value;
            }
        }

        //public property thisProduct
        public clsProduct ThisProduct
        {
            get
            {
                //return the private data
                return mThisProduct;
            }
            set
            {
                //set the private data
                mThisProduct = value;
            }
        }

        //public propert for count
        public int Count
        {
            get
            {
                //return the count list
                return mProductList.Count;
            }
            set
            {
                //worry about this later
            }
        }












        //public clsProduct ThisProduct { get; set; }

        public int Add()
        {
            //add a new record to the database based on tne values mThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure 
            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@StockQuantity", mThisProduct.StockQuantity);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by his This Product
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            //execute the stored procedure 
            DB.Execute("sproc_tblProduct_Delete");
        }

        //for updating records
        public void Update()
        {
            
        }

        public void ReportByName(string Name)
        {
            //filterrs the records based on a full or partial name
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@Name", Name);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //POPULATE THE ARRAY LIST BASED ON THE DATA TABLE IN THE PARAMETER DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mProductList = new List<clsProduct>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blacnk product
                clsProduct AnProduct = new clsProduct();
                //read in the fields from the current record
                AnProduct.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnProduct.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AnProduct.StockQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["StockQuantity"]);
                //add the record to the private data member
                mProductList.Add(AnProduct);
                //point at the next record
                Index++;
            }
        }
    }
}