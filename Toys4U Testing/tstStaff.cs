using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstStaff
    {
        //test method to check if instance can be created
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);

        }
        //test methods for propertys
        [TestMethod]
        public void AdminPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Admin = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.Admin, TestData);



        }


        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateJoined = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.DateJoined, TestData);



        }


        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            DateTime TestData = new DateTime(2000, 12, 12);
            //assign the data to the property
            AnStaff.DateOfBirth = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.DateOfBirth, TestData);



        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            string TestData = "callumjohnsimpson@hotmail.com";
            //assign the data to the property
            AnStaff.Email = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.Email, TestData);



        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            string TestData = "callum";
            //assign the data to the property
            AnStaff.FirstName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.FirstName, TestData);



        }

        [TestMethod]
        public void HourlyPayPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            string TestData = "7.78";
            //assign the data to the property
            //enters as a string but later converted to decimal using validaiton. 
            AnStaff.HourlyPay = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.HourlyPay, TestData);



        }

        [TestMethod]
        public void JobTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            string TestData = "Web Developer";
            //assign the data to the property
            AnStaff.JobTitle = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.JobTitle, TestData);



        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            string TestData = "callum";
            //assign the data to the property
            AnStaff.LastName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.LastName, TestData);



        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            string TestData = "PaSswORD123";
            //assign the data to the property
            AnStaff.Password = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.Password, TestData);



        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            string TestData = "07654 675354";
            //assign the data to the property
            AnStaff.PhoneNumber = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.PhoneNumber, TestData);



        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            int TestData = 12345;
            //assign the data to the property
            AnStaff.StaffID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.StaffID, TestData);



        }


    }
}
