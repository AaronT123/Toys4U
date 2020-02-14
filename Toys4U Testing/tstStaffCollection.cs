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

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            Int32 SomeCount = 2;
            //assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see that the two vlauyes are the same 
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }


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
        
        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that the two values ar ethe sama , aka there is two records present
            Assert.AreEqual(AllStaff.Count, 2);

        }
    }

}
