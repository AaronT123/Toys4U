using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstProduct
    {
        //good test data 
        //create some test data to pass to the method 
        string Name = "Rocking Horse";
        string Description = "Ages 1 - 3.";
        string StockQuantity = "6";



        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //test to see that it exists
            Assert.IsNotNull(AnProduct);
            
        }

        [TestMethod]
        public void ProductIDOk()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //asign the data to the property
            AnProduct.ProductID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnProduct.ProductID, TestData);

        }

        [TestMethod]
        public void NameOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "HotWheels";
            //asign the data to the property
            AnProduct.Name = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnProduct.Name, TestData);
        }

        [TestMethod]
        public void DescriptionOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            string TestData = "This is a new series of HotWheels, the season is about space";
            //asign the data to the property
            AnProduct.Description = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnProduct.Description, TestData);
        }

        [TestMethod]
        public void StockQuantityOK()
        {
            //create an instance of the class we want to create
            clsProduct AnProduct = new clsProduct();
            //create some test data to assign to the property
            int TestData = 21;
            //asign the data to the property
            AnProduct.StockQuantity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnProduct.StockQuantity, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want t create 
            clsProduct AnProduct = new clsProduct();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnProduct.Find(ProductID);
            //teset to see that the result is correct
            Assert.IsTrue(Found);
        }

        //[TestMethod]
        //public void TestProductIDFound()
        //{
        //    //create an instance of the class we want to create
        //    clsProduct AnProduct = new clsProduct();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK 
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 ProductID = 5;
        //    //invok the method 
        //    Found = AnProduct.Find(ProductID);
        //    //check the product id
        //    if (AnProduct.ProductID != 5)
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

        //[TestMethod]
        //public void TestNameFound()
        //{
        //    //create an instance of the class we want to create
        //    clsProduct AnProduct = new clsProduct();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK 
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 ProductID = 5;
        //    //invok the method 
        //    Found = AnProduct.Find(ProductID);
        //    //check the product id
        //    if (AnProduct.Name != "test name")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

        //[TestMethod]
        //public void TestDescriptionFound()
        //{
        //    //create an instance of the class we want to create
        //    clsProduct AnProduct = new clsProduct();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK 
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 ProductID = 5;
        //    //invok the method 
        //    Found = AnProduct.Find(ProductID);
        //    //check the product id
        //    if (AnProduct.Description != "test description")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

        //[TestMethod]
        //public void TestStockQuantityFound()
        //{
        //    //create an instance of the class we want to create
        //    clsProduct AnProduct = new clsProduct();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK 
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 ProductID = 5;
        //    //invok the method 
        //    Found = AnProduct.Find(ProductID);
        //    //check the product id
        //    if (AnProduct.StockQuantity==0)
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}

        [TestMethod]
        public void ValidMethodOK()
        {
            //CREATE AN INSTANCE OF THE CLASS WE WANT TO CREATE
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = ""; //this should trigger an error
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "aaaa"; //this should be ok 
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "aaaaa"; //this should be ok 
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "aaa"; //this should be ok 
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = "aaaaaaa"; //this should be ok 
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //create some test data to pass to the method 
            string Name = ""; //this should fail
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Name = ""; 
            Name = Name.PadRight(100, 'a'); //this should fail
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMin()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string StockQuantity = "1"; //this should pass
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string StockQuantity = ""; //this should trigger an error
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string StockQuantity = "2"; //this should pass
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockQuantityMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AnProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string StockQuantity = "999"; //this should pass
            //invoke the method 
            Error = AnProduct.Valid(Name, Description, StockQuantity);
            //teset to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

    }
}
