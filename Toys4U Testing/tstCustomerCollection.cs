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
            TestItem.LastName = "suldan";
            TestItem.PhoneNumber = "0116 123 1234";
            TestItem.PostCode = "LE2 3FE";
            TestItem.StreetName = "Happy Lane";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);

        }
    }
}
