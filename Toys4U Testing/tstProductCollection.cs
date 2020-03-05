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
            TestItem.Name = "Hot Wheels";
            TestItem.Description = "Fast and furious season";
            TestItem.StockQuantity = 23;
            //add items to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProduct.ProductHome = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllProduct.ProductHome, TestList);

        }
        //commented out as its oldd
        //[TestMethod]
        //public void CountPropertyOK()
        //{
            //create an instance of the class we want to create           
            //clsProductCollection AllProduct = new clsProductCollection();
            //create some test data
            //Int32 SomeCount = 2;
            //assign data to property
            //AllProduct.Count = SomeCount;
            //test to see that the two value are the same
            //Assert.AreEqual(AllProduct.Count, SomeCount);            
        //}

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            //create an instance of the class we want to create 
            clsProductCollection AllProduct = new clsProductCollection();
            //create some test data to assign to the property 
            clsProduct TestProduct = new clsProduct();
            //set the properties of the test object
            TestProduct.ProductID = 2;
            TestProduct.Name = "Car Toy";
            TestProduct.Description = "New car toy";
            TestProduct.StockQuantity = 3;
            //assign the data to the property 
            AllProduct.ThisProduct = TestProduct;
            //test to see that the two value are the same
            Assert.AreEqual(AllProduct.ThisProduct, TestProduct);
        }

        //test if records can be added to the lists
        //and the Count property correctly reports how many items are in the list.

        //commented out as its old
        //[TestMethod]
        //public void ListAndCountOK()
        //{
            //CREATE an instance of the class we want to create 
            //clsProductCollection AllProduct = new clsProductCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects 
            //List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list 
            //create some test data of the item
            //clsProduct TestItem = new clsProduct();
            //set its properties 
            //TestItem.ProductID = 4;
            //TestItem.Name = "Hot Wheels";
            //TestItem.Description = "Fast and Furious season";
            //TestItem.StockQuantity = 20;
            //add the test item to the list 
            //TestList.Add(TestItem);
            //assign the data to the property
            //AllProduct.ProductList = TestList;
            //test to see that the two values are the same
            //Assert.AreEqual(AllProduct.Count, TestList.Count);
        //}

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
            //create an instance of the class we want to create 
            //clsProductCollection AllProduct = new clsProductCollection();
            //test to see that two values are the same 
            //Assert.AreEqual(AllProduct.Count, 2);
        //}
    }
}
