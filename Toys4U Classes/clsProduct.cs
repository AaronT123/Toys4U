using System;

namespace Toys4U_Classes
{
    public class clsProduct
    {
        //Private data member for the Product ID property
        private Int32 mProductID;
        //Private data member for product name
        private string mName;
        //Private data member for description
        private string mDescription;
        //Private data member for stock quantity
        private Int32 mStockQuantity;


        //public property for the product id
        public int ProductID
        {
            get
            {
                //return the private data
                return mProductID;
            }
            set
            {
                //set the value of the private data member
                mProductID = value;
            }
        }

        //public property for product name
        public string Name
        {
            get
            {
                //return the private data 
                return mName;
            }
            set
            {
                //set the value of the private data member
                mName = value;
            }
        }

        //public property for product description
        public string Description
        {
            get
            {
                //return the private data
                return mDescription;
            }
            set
            {
                //set the value for the private data member
                mDescription = value;
            }
        }

        //public property for product stock quantity
        public int StockQuantity
        {
            get
            {
                //return the private data 
                return mStockQuantity;
            }
            set
            {
                //set the value for the private data member 
                mStockQuantity = value;
            }
        }


        public Boolean Find(int ProductID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the product id to search for
            DB.AddParameter("@ProductID", ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string text1, string text2, string text3)
        {
            return "";
        }
    }
}