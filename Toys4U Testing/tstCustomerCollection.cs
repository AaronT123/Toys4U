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
        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create 
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllCustomers.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, SomeCount);
        //}
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

            TestItem.EmailAddress = "DeGea@gmail.com";
            TestItem.Password = "Degea_1";
            TestItem.FirstName = "David";
            TestItem.LastName = "De Gea";
            TestItem.PhoneNumber = "0116 123 1234";
            TestItem.PostCode = "LE2 3FE";
            TestItem.StreetName = "Shop Closed Lanes";
            TestItem.HouseNo = "1";
            //set ThisCustomer to the test data
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
            TestItem.CustomerID = 1;
            TestItem.EmailAddress = "DeGea@gmail.com";
            TestItem.Password = "Degea_1";
            TestItem.FirstName = "David";
            TestItem.LastName = "De Gea";
            TestItem.PhoneNumber = "0116 123 1234";
            TestItem.PostCode = "LE2 3FE";
            TestItem.StreetName = "Shop Closed Lanes";
            TestItem.HouseNo = "1";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
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
            TestItem.EmailAddress = "Mcfly@gmail.com";
            TestItem.Password = "Mcfly_23";
            TestItem.FirstName = "Mc";
            TestItem.LastName = "Fly";
            TestItem.PhoneNumber = "0116 123 8456";
            TestItem.PostCode = "LE2 8YH";
            TestItem.StreetName = "One Direction";
            TestItem.HouseNo = "14";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //Add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.EmailAddress = "OnePiece";
            TestItem.Password = "Luffy_34";
            TestItem.FirstName = "WhiteBeard";
            TestItem.LastName = "Luffy";
            TestItem.PhoneNumber = "0116 456 7890";
            TestItem.PostCode = "LE2 5TG";
            TestItem.StreetName = "Gear Four";
            TestItem.HouseNo = "56";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        //[TestMethod]
        //public void ListAndCountOK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllStaff = new clsCustomerCollection();
        //    //create some test data to asign to the property
        //    //in this case the data needs to be a list of objects
        //    List<clsCustomer> TestList = new List<clsCustomer>();
        //    //add an item to the list
        //    //create the item of test data 
        //    clsCustomer TestItem = new clsCustomer();
        //    //set its properties
        //    TestItem.CustomerID = 1;
        //    TestItem.EmailAddress = "Abdisuldan@gmail.com";
        //    TestItem.Password = "Password";
        //    TestItem.FirstName = "Abdi";
        //    TestItem.LastName = "Suldan";
        //    TestItem.PhoneNumber = "0116 123 1234";
        //    TestItem.PostCode = "LE2 3FE";
        //    TestItem.StreetName = "Happy Lane";
        //    TestItem.HouseNo = "92";
        //    //add the item to the test list
        //    TestList.Add(TestItem);
        //    //assign the data to the property
        //    AllStaff.CustomerList = TestList;
        //    //test to see that the two values are tghe same
        //    Assert.AreEqual(AllStaff.Count, TestList.Count);
        //}



    }
}
