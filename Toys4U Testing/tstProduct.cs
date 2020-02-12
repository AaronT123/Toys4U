using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstProduct
    {
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
            Int32 TestData = 1234;
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
            Int32 TestData = 21;
            //asign the data to the property
            AnProduct.StockQuantity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnProduct.StockQuantity, TestData);

        }

    }
}
