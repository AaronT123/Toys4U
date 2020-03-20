using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string EmailAddress = "Abdisuldan@gmail.com";
        string Password = "Abdis45";
        string FirstName = "Abdi";
        string LastName = "Suldan";
        string PhoneNumber = "01161231234";
        string PostCode = "LE23GB";
        string StreetName = "HaveStreet";
        string HouseNo = "57A";

        [TestMethod]
        public void InstanceOK()
        {
            //create a instanc of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exist
            Assert.IsNotNull(AnCustomer);

        }
        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1234;
            //assign the data to the property
            AnCustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void EmailAddressOK()
        {
            //create an instance of the class we want to create.
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Abdisuldan@gmail.com";
            //assign the data to the property/
            AnCustomer.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Abdi";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);

        }

        [TestMethod]
        public void LastNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Suldan";
            //assign the data to the property
            AnCustomer.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }
        [TestMethod]
        public void PasswordOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Abdis45";
            //assign the data to the property
            AnCustomer.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Password, TestData);
        }
        [TestMethod]
        public void PhoneNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "0116 123 1234";
            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }
        [TestMethod]
        public void PostCodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property//
            string TestData = "LE2 3GB";
            //assign the data to the property
            AnCustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.PostCode, TestData);
        }
        [TestMethod]
        public void StreetNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Have Street";
            //assign the data to the property
            AnCustomer.StreetName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.StreetName, TestData);
        }
        [TestMethod]
        public void HouseNoOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "57A";
            //assign the data to the property
            AnCustomer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.HouseNo, TestData);
        }
       [TestMethod]
       public void FindMethodOK()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 21;
            //invoke the methods
            Found = AnCustomer.Find(CustomerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.CustomerID != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailAddressFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.EmailAddress != "Elitone@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPasswordFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.Password != "Elite_12")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.FirstName != "Elite")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.LastName != "One")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.PhoneNumber != "1161238967")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.PostCode != "LE29HE")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStreetNameFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.StreetName != "Shop Closed Lane")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an insatnce of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerID = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the CustomerID
            if (AnCustomer.HouseNo != "5")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodsOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "A@Mail.com"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "AS@Mail.com"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "AbdiKsuldan2050@Mail.com"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "Abdikarimsuldan3@Mail.com"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "Abdikarimsuldan36@Mail.com"; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "AKS@Mail.com"; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(50, 'a');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "D"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "De"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "Dee"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "VANMIDDLESWORT"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "VANMIDDLESWORTH"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "VANMIDDLESWORTHS"; //this should Fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "VANMIDD"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'c');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "O"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "HO"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "Jon"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "MAGSHAMHRADHÁI"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "MAGSHAMHRADHÁIN"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "MAGSHAMHRADHÁINS"; //this should not pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "MAGSHAM"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "";
            LastName = LastName.PadRight(50, 'd');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = ""; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "01165987463"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "011659874638"; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0116598746"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "01165987468"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "011659874687"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "0116598"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(20, '4');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE1"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE63"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE651A"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE651AE"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE651AER"; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "LE64YG"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "";
            PostCode = PostCode.PadRight(20, '4');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StreetNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StreetName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StreetNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StreetName = "HatterLane"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StreetNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StreetName = "HatternLane"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StreetNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StreetName = "DeMontFortUniversit"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StreetNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StreetName = "DeMontFortUniversity"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StreetNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StreetName = "DeMontFortUniversitys"; //this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StreetNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StreetName = "DeMontFort"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StreetNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StreetName = "";
            StreetName = StreetName.PadRight(50, 'r');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string HouseNo = "";
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void HouseNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "1"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "12"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "123AB"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "123ABC"; // this should be ok
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "1234ABC"; //this should fail
            //invoke the method 
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "123"; //this should pass
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(50, '1');//this should fail
            //invoke the method
            Error = AnCustomer.Valid(EmailAddress, Password, FirstName, LastName, PhoneNumber, PostCode, StreetName, HouseNo);
            //test to see that the test is coorect
            Assert.AreNotEqual(Error, "");
        }

    }
}
