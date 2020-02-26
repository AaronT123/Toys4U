using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;
using System.Collections.Generic;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //test to see that it exisists
            Assert.IsNotNull(AllProduct);
        }

        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data 
            clsProduct TestItem = new clsProduct();
            //set its properties
            TestItem.ProductID = 1;
            TestItem.Name = "HotWheels";
            TestItem.Description = "Fast and furious season";
            TestItem.StockQuantity = 23;
            //add items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProduct.ProductList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllProduct.ProductList, TestList);

        }
    }
}
