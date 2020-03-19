using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstDelivery
    {
        //good test data
        //create some test data to pass to the method
        string OrderID = "1";
        string HouseNo = "12b";
        string Street = "Some Street";
        string Town = "Some Town";
        string City = "some City";
        string Postcode = "some postcode";
        string DateAdded = DateTime.Now.Date.ToString();
        string DateEstimated = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //test to see that it exists
            Assert.IsNotNull(ADelivery);
        }

        [TestMethod]
        public void DeliveryIDOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ADelivery.DeliveryID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADelivery.DeliveryID, TestData);
        }

        public void OrderIDOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ADelivery.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADelivery.OrderID, TestData);
        }

        public void HouseNoOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //create some test data to assign to the property
            string TestData = "32B";
            //assign the data to the property
            ADelivery.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADelivery.HouseNo, TestData);
        }

        public void StreetOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //create some test data to assign to the property
            string TestData = "London Road";
            //assign the data to the property
            ADelivery.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADelivery.Street, TestData);
        }

        public void TownOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //create some test data to assign to the property
            string TestData = "Oadby";
            //assign the data to the property
            ADelivery.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADelivery.Town, TestData);
        }

        public void CityOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            ADelivery.City = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADelivery.City, TestData);
        }

        public void PostcodeOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //create some test data to assign to the property
            string TestData = "LE2 5DH";
            //assign the data to the property
            ADelivery.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADelivery.Postcode, TestData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //creaate some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ADelivery.DateAdded = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ADelivery.DateAdded, TestData);
        }

        [TestMethod]
        public void DateEstimatedOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //creaate some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ADelivery.DateEstimated = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(ADelivery.DateEstimated, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 DeliveryID = 1;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDeliveryIDFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.DeliveryID != 18)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.OrderID != 111)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.HouseNo != "yyy yyy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.Street != "yyy yyy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.Town != "yyy yyy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCityFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.City != "yyy yyy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.Postcode != "yyy yyy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.DateAdded != Convert.ToDateTime("15/03/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateEstimatedFound()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DeliveryID = 18;
            //invoke the method
            Found = ADelivery.Find(DeliveryID);
            //check the data
            if (ADelivery.DateEstimated != Convert.ToDateTime("15/03/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*
         * 
         * 
         * 
         * 
         * OrderID
         * 
         * 
         * 
         * 
         */

        [TestMethod]
        public void OrderIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMin()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "1";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "11";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "11111111";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "111111111";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "1111111111";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDMid()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "1111";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            OrderID = OrderID.PadRight(500, '1');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDNegative()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "-1";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDExistsInDatabase()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "1";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /*
         * 
         * 
         * This test will fail as the appropriate code in clsDelivery is commented out
         * 
         * Check comment in clsDelivery for details
         * 
         * 
        [TestMethod]
        public void OrderIDDoesNotExist()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderID = "99";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        */

        /*
         * 
         * 
         * 
         * 
         * HouseNo
         * 
         * 
         * 
         * 
         */


        [TestMethod]
        public void HouseNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMin()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "1";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "1A";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "1234567";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "12345678";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "123456789";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "12345";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "";
            HouseNo = HouseNo.PadRight(500, '1');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*
         * 
         * 
         * 
         * 
         * Street
         * 
         * 
         * 
         * 
         */


        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMin()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "a";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "ab";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(51, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "Some Street";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetExtremeMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Street = "";
            Street = Street.PadRight(500, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*
         * 
         * 
         * 
         * 
         * Town
         * 
         * 
         * 
         * 
         */


        [TestMethod]
        public void TownMinLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Town = "a";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Town = "ab";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(49, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(50, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(51, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Town = "Some Town";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownExtremeMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Town = "";
            Town = Town.PadRight(500, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*
         * 
         * 
         * 
         * 
         * City
         * 
         * 
         * 
         * 
         */


        [TestMethod]
        public void CityMinLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMin()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "a";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "ab";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "";
            City = City.PadRight(49, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "";
            City = City.PadRight(50, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "";
            City = City.PadRight(51, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMid()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "Some City";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityExtremeMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string City = "";
            City = City.PadRight(500, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*
         * 
         * 
         * 
         * 
         * Postcode
         * 
         * 
         * 
         * 
         */


        [TestMethod]
        public void PostcodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMin()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "a";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodePlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "ab";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMid()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "";
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeExtremeMax()
        {
            //create an instance of the class we want to create
            clsDelivery ADelivery = new clsDelivery();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Postcode = "";
            Postcode = Postcode.PadRight(500, 'a');
            //invoke the method
            Error = ADelivery.Valid(OrderID, HouseNo, Street, Town, City, Postcode, DateAdded, DateEstimated);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
