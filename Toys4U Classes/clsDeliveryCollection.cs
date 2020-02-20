using System;
using System.Collections.Generic;

namespace Toys4U_Classes
{
    public class clsDeliveryCollection
    {
        //private data member for the list
        List<clsDelivery> mDeliveryList = new List<clsDelivery>();

        public clsDeliveryCollection()
        {
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

        public clsDelivery ThisDelivery { get; set; }

    }


}