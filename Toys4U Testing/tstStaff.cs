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
            Decimal TestData = 7.78m;
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
        public void StaffNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //creaate some test data to assign to the property
            int TestData = 12345;
            //assign the data to the property
            AnStaff.StaffNo = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStaff.StaffNo, TestData);



        }

        [TestMethod]
        public void FindMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //test to see that the result is corect
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestStaffNoFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.StaffNo !=58)
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAdminFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.Admin != true)
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.DateJoined != Convert.ToDateTime("12/12/2012"))
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.DateOfBirth != Convert.ToDateTime("12/12/2012"))
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.Email != "test@hotmail.com")
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.FirstName != Test)
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHourlyPayFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.HourlyPay != 999m)
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestJobTitleFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.JobTitle != "Test")
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.LastName != "Test")
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.Password != Test)
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffNo = 58;
            Found = AnStaff.Find(StaffNo);
            //check the staff no
            if (AnStaff.PhoneNumber != "99999 999999")
            {
                OK = false;
            }
            //test to see tat the result is corect 
            Assert.IsTrue(OK);
        }

    }
}
