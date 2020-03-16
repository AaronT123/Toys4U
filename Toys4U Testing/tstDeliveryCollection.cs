using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;
using System.Collections.Generic;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstDeliveryCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            //test to see that it exists
            Assert.IsNotNull(AllDeliveries);
        }

        [TestMethod]
        public void DeliveryListOK()
        {
            //create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsDelivery> TestList = new List<clsDelivery>();
            //add an item to the list
            //create the item of test data
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
            TestList.Add(TestItem);
            //assign the data to the property
            AllDeliveries.DeliveryList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.DeliveryList, TestList);
        }

        [TestMethod]
        public void ThisDeliveryOK()
        {
            //create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            //create some test data to assign to the property
            clsDelivery TestDelivery = new clsDelivery();
            //set the properties of the test object
            TestDelivery.DeliveryID = 1;
            TestDelivery.OrderID = 1;
            TestDelivery.HouseNo = "32B";
            TestDelivery.Street = "London Road";
            TestDelivery.Town = "Oadby";
            TestDelivery.City = "Leicester";
            TestDelivery.Postcode = "LE2 5DH";
            TestDelivery.DateAdded = Convert.ToDateTime("20/12/2020");
            TestDelivery.DateEstimated = Convert.ToDateTime("25/12/2020");
            //assign the data to the property
            AllDeliveries.ThisDelivery = TestDelivery;
            //test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.ThisDelivery, TestDelivery);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            //create some test data to assign to the property
            //in thise case the data needs to be a list of objects
            List<clsDelivery> TestList = new List<clsDelivery>();
            //add an item to the list
            //create the item of test data
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
            TestList.Add(TestItem);
            //assign the data to the property
            AllDeliveries.DeliveryList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            //create the item of test data
            clsDelivery TestItem = new clsDelivery();
            //var to store the primary key
            Int32 PrimaryKey = 0;
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
            //set ThisDelivery to the test data
            AllDeliveries.ThisDelivery = TestItem;
            //add the record
            PrimaryKey = AllDeliveries.Add();
            //set the primary key of the test data
            TestItem.DeliveryID = PrimaryKey;
            //find the record
            AllDeliveries.ThisDelivery.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.ThisDelivery, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            //create the item of test data
            clsDelivery TestItem = new clsDelivery();
            //var to store the primary key
            Int32 PrimaryKey = 0;
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
            //set ThisDelivery to the test data
            AllDeliveries.ThisDelivery = TestItem;
            //add the record
            PrimaryKey = AllDeliveries.Add();
            //set the primary key of the test data
            TestItem.DeliveryID = PrimaryKey;
            //find the record
            AllDeliveries.ThisDelivery.Find(PrimaryKey);
            //delete the record
            AllDeliveries.Delete();
            //now find the record
            Boolean Found = AllDeliveries.ThisDelivery.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            //create the item of test data
            clsDelivery TestItem = new clsDelivery();
            //var to store the primary key
            Int32 PrimaryKey = 0;
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
            //set ThisDelivery to the test data
            AllDeliveries.ThisDelivery = TestItem;
            //add the record
            PrimaryKey = AllDeliveries.Add();
            //set the primary key of the test data
            TestItem.DeliveryID = PrimaryKey;
            //modify the test data
            TestItem.DeliveryID = 1;
            TestItem.OrderID = 1;
            TestItem.HouseNo = "32C";
            TestItem.Street = "London Street";
            TestItem.Town = "Oadbyyyy";
            TestItem.City = "Leicestershire";
            TestItem.Postcode = "LE3 6CF";
            TestItem.DateAdded = Convert.ToDateTime("22/12/2020");
            TestItem.DateEstimated = Convert.ToDateTime("28/12/2020");
            //set the record based on the new test data
            AllDeliveries.ThisDelivery = TestItem;
            //update the record
            AllDeliveries.Update();
            //find the record
            AllDeliveries.ThisDelivery.Find(PrimaryKey);
            //test to see ThisDelivery matches the test data
            Assert.AreEqual(AllDeliveries.ThisDelivery, TestItem);
        }

        
        [TestMethod]
        public void ReportByPostcodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsDeliveryCollection AllDeliveries = new clsDeliveryCollection();
            //create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            //apply a blank string (should return all records)
            FilteredDeliveries.ReportByPostcode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllDeliveries.Count, FilteredDeliveries.Count);
        }

        [TestMethod]
        public void ReportByPostcodeNoneFound()
        {
            //create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            //apply a postcode that doesn't exist
            FilteredDeliveries.ReportByPostcode("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredDeliveries.Count);
        }

        [TestMethod]
        public void ReportByPostcodeTestDataFound()
        {
            //create an instance of the filtered data
            clsDeliveryCollection FilteredDeliveries = new clsDeliveryCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a postcode that doesn't exist
            FilteredDeliveries.ReportByPostcode("yyy yyy");
            //check that the correct number of records are found
            if (FilteredDeliveries.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredDeliveries.DeliveryList[0].DeliveryID != 18)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredDeliveries.DeliveryList[1].DeliveryID != 19)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no new records
            Assert.IsTrue(OK);
        }
        
    }
}
