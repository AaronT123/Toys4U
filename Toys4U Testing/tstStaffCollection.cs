using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;
using System.Collections.Generic;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {

            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exisists
            Assert.IsNotNull(AllStaff);

        }

        [TestMethod]
        public void StaffListOK()
        {

            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            //TestItem.DateOfBirth = 01/'01/2000;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Email = "callumjohnsimpson@hotmail.com";
            TestItem.HourlyPay = 7.77m;
            TestItem.LastName = "Simpson";
            TestItem.Password = "Something!";
            TestItem.PhoneNumber = "07465 659874";
            TestItem.FirstName = "Callum";
            TestItem.JobTitle = "Manager";
            //add the item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);


        }
        //commented out as old test that now fails
        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    //create an instance of the class we want to create 
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //create some test data to assign to the property 
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllStaff.Count = SomeCount;
        //    //test to see that the two vlauyes are the same 
        //    Assert.AreEqual(AllStaff.Count, SomeCount);
        //}


        [TestMethod]
        public void ThisStaffPropertyOK()
        {

            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object 
            //TestStaff.DateOfBirth = 01/'01/2000;
            TestStaff.DateJoined = DateTime.Now.Date;
            TestStaff.Email = "callumjohnsimpson@hotmail.com";
            TestStaff.HourlyPay = 7.77m;
            TestStaff.LastName = "Simpson";
            TestStaff.Password = "Something!";
            TestStaff.PhoneNumber = "07465 659874";
            TestStaff.FirstName = "Callum";
            TestStaff.JobTitle = "Manager";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        //test if records can be added to the lists
        //and the Count property correctly reports how many items are in the list.
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to asign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties
            //TestItem.DateOfBirth = 01/'01/2000;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Email = "callumjohnsimpson@hotmail.com";
            TestItem.HourlyPay = 7.77m;
            TestItem.LastName = "Simpson";
            TestItem.Password = "Something!";
            TestItem.PhoneNumber = "07465 659874";
            TestItem.FirstName = "Callum";
            TestItem.JobTitle = "Manager";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are tghe same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        //old redundant test, hence commented out 
        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //test to see that the two values ar ethe sama , aka there is two records present
        //    Assert.AreEqual(AllStaff.Count, 2);

        //}


        [TestMethod]
        public void AddMethodOK()
        {
            //create a instance of the classd we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it primary key
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Email = "callumjohnsimpson@hotmail.com";
            TestItem.HourlyPay = 7.77m;
            TestItem.LastName = "Simpson";
            TestItem.Password = "Something!";
            TestItem.PhoneNumber = "07465 659874";
            TestItem.FirstName = "Callum";
            TestItem.JobTitle = "Manager";
            //Set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record 
            PrimaryKey = AllStaff.Add();
            //set the primaru key of the test data
            TestItem.StaffID = PrimaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //testy to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }



        [TestMethod]
        public void DeleteMethodOK()
        {

            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Email = "callumjohnsimpson@hotmail.com";
            TestItem.HourlyPay = 7.77m;
            TestItem.LastName = "Simpson";
            TestItem.Password = "Something!";
            TestItem.PhoneNumber = "07465 659874";
            TestItem.FirstName = "Callum";

            TestItem.JobTitle = "Manager";
            //set this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //ADD THE RECORD
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the rtecord
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see that the record was not found 
            Assert.IsFalse(Found);


        }



        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we waznt to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Email = "callumjohnsimpson@hotmail.com";
            TestItem.HourlyPay = 7.77m;
            TestItem.LastName = "Simpson";
            TestItem.Password = "Something!";
            TestItem.PhoneNumber = "07465 659874";
            TestItem.FirstName = "Callum";

            TestItem.JobTitle = "Manager";
            //set this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //ADD THE RECORD
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;

            //modify the test data
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.Email = "grimreaper@hotmail.com";
            TestItem.HourlyPay = 8.88m;
            TestItem.LastName = "Slater";
            TestItem.Password = "pass";
            TestItem.PhoneNumber = "07465 889124";
            TestItem.FirstName = "John";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test DATA
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }



        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create aN instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaff.ReportByJobTitle("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);


        }


        [TestMethod]
        public void ReportByJobTitleTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //this is where youre at , page 38. 
        }
      

    }
}
