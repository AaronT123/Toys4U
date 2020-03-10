using System.Collections.Generic;
using System;
namespace Toys4U_Classes
{
    public class clsProductCollection
    {
        //private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();

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
            //get the count of records
            RecordCount = DB.Count;
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












        public clsProduct ThisProduct { get; set; }

        public int Add()
        {
            throw new NotImplementedException();
        }
    }
}