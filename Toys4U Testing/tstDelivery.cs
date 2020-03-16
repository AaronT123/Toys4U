using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstDelivery
    {
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
    }
}
