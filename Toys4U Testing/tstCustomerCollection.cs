using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;


namespace Toys4U_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that is exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test to assign to the property
            //in this case the data needs to be a list of the objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set the properties
            TestItem.CustomerID = 1;
            TestItem.EmailAddress = "Abdisuldan@gmail.com";
            TestItem.Password = "Password";
            TestItem.FirstName = "Abdi";
            TestItem.LastName = "Suldan";
            TestItem.PhoneNumber = "0116 123 1234";
            TestItem.PostCode = "LE2 3FE";
            TestItem.StreetName = "Happy Lane";
            TestItem.HouseNo = "58";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.EmailAddress = "Abdisuldan@gmail.com";
            TestCustomer.Password = "Password";
            TestCustomer.FirstName = "Abdi";
            TestCustomer.LastName = "Suldan";
            TestCustomer.PhoneNumber = "0116 123 1234";
            TestCustomer.PostCode = "LE2 3FE";
            TestCustomer.StreetName = "Happy Lane";
            TestCustomer.HouseNo = "78";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it properites
            TestItem.EmailAddress = "Elitone@gmail.com";
            TestItem.Password = "Matt_12";
            TestItem.FirstName = "Elite";
            TestItem.LastName = "One";
            TestItem.PhoneNumber = "01161238967";
            TestItem.PostCode = "LE29HE";
            TestItem.StreetName = "Shop Closed Lane";
            TestItem.HouseNo = "5";
            //set ThisCustomer to the test data"
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.EmailAddress = "hello@gmail.com";
            TestItem.Password = "makda";
            TestItem.FirstName = "kepa";
            TestItem.LastName = "anil";
            TestItem.PhoneNumber = "1166957845";
            TestItem.PostCode = "PE15DJ";
            TestItem.StreetName = "Shearrdroad";
            TestItem.HouseNo = "21";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 2;
            TestItem.EmailAddress = "Mata@hotmail.com";
            TestItem.Password = "Mata_6";
            TestItem.FirstName = "Juan";
            TestItem.LastName = "Mata";
            TestItem.PhoneNumber = "1163692587";
            TestItem.PostCode = "LE28UJ";
            TestItem.StreetName = "Old Trafford";
            TestItem.HouseNo = "8";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.EmailAddress = "AttackOnTitans";
            TestItem.Password = "Arron_34";
            TestItem.FirstName = "Mikasa";
            TestItem.LastName = "Ewrin";
            TestItem.PhoneNumber = "01166874253";
            TestItem.PostCode = "LE25TD";
            TestItem.StreetName = "Titan";
            TestItem.HouseNo = "78";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class containing unfiltered resuls
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByPostCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByPostCodeNonFound()
        {
            //create an instance of filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a post code that doesn't exist
            FilteredCustomers.ReportByPostCode("XXX XXX");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an instance of filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredCustomers.ReportByPostCode("yyyyyy");
            //check that the correct number of records 
            if (FilteredCustomers.Count == 2)
            {
                //check that the correct number of records are found
                if (FilteredCustomers.CustomerList[0].CustomerID != 55)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredCustomers.CustomerList[1].CustomerID != 57)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    

    }
}
