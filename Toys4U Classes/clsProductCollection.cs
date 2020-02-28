using System.Collections.Generic;

namespace Toys4U_Classes
{
    public class clsProductCollection
    {
        //private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();

        //contructor for the class
        public clsProductCollection()
        {
            //create the items of test data 
            clsProduct TestItem = new clsProduct();
            //set it properties
            TestItem.ProductID = 1;
            TestItem.Name = "Yellow Duck";
            TestItem.Description = "toddler toy";
            TestItem.StockQuantity = 4;
            //add the item to the test list 
            mProductList.Add(TestItem);
            // re intialise the object for some new data 
            TestItem = new clsProduct();
            //set its properties 
            TestItem.ProductID = 2;
            TestItem.Name = "doll";
            TestItem.Description = "baby doll";
            TestItem.StockQuantity = 2;
            //add the item to the test list
            mProductList.Add(TestItem);
        }

        //public property for the product list
        public List<clsProduct> ProductList
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
    }
}