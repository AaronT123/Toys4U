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
    }
}
