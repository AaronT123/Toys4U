using System.Collections.Generic;

namespace Toys4U_Classes
{
    public class clsCustomerCollection
    {
        //public List<clsCustomer> CustomerList { get; set; }
        //public int Count { get; set; }
        public clsCustomer ThisCustomer { get; set; }
            
        //private data member for this list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
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
            //create the items of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properites
            TestItem.CustomerID = 1;
            TestItem.EmailAddress = "Abdisuldan@gmail.com";
            TestItem.Password = "Password";
            TestItem.FirstName = "Abdi";
            TestItem.LastName = "Suldan";
            TestItem.PhoneNumber = "0116 123 1234";
            TestItem.PostCode = "LE2 3FE";
            TestItem.StreetName = "Happy Lane";
            //add the item to the test 
            mCustomerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 2;
            TestItem.EmailAddress = "HelloKitty@gmail.com";
            TestItem.Password = "Sonic_23";
            TestItem.FirstName = "Wayne";
            TestItem.LastName = "Rooney";
            TestItem.PhoneNumber = "0116 245 8932";
            TestItem.PostCode = "LE6 J67";
            TestItem.StreetName = "Old Trafford";
            //add the item to the test list
            mCustomerList.Add(TestItem);

        }
        
    }
}