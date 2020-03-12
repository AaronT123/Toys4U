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

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //create some test data
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 6;
            TestItem.Name = "Rocking Horse";
            TestItem.Description = "Ages 1 - 3.";
            TestItem.StockQuantity = 6;
            //set this product to the test data
            AllProduct.ThisProduct = TestItem;
            //add the record 
            PrimaryKey = AllProduct.Add();
            //set the primary key of this test data
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProduct.ThisProduct.Find(PrimaryKey);
            //test to see if the two values are the same
            Assert.AreEqual(AllProduct.ThisProduct, TestItem);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsProductCollection AllProduct = new clsProductCollection();
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductID = 6;
            TestItem.Name = "Rocking Horse";
            TestItem.Description = "Ages 1 - 3.";
            TestItem.StockQuantity = 6;
            //set this product to test the data
            AllProduct.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProduct.Add();
            //find the record
            AllProduct.ThisProduct.Find(PrimaryKey);
            //delete the record
            AllProduct.Delete();
            //now find the record 
            Boolean Found = AllProduct.ThisProduct.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
           
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsProductCollection AllProduct = new clsProductCollection();
            //create the item of test data 
            clsProduct TestItem = new clsProduct();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Name = "Rocking Horse";
            TestItem.Description = "Ages 1 - 3";
            TestItem.StockQuantity = 6;
            //set this prodcut to test data
            AllProduct.ThisProduct = TestItem;
            //add the record 
            PrimaryKey = AllProduct.Add();
            //modify the test data 
            TestItem.Name = "Rocking Horse 1";
            TestItem.Description = "Ages 2 - 3.";
            TestItem.StockQuantity = 35;
            //set the record based on the new test data
            AllProduct.ThisProduct = TestItem;
            //update the record
            AllProduct.Update();
            //find the record
            AllProduct.ThisProduct.Find(PrimaryKey);
            //test to see this product matches the teset data
            Assert.AreEqual(AllProduct.ThisProduct, TestItem);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class containing unfiltered results 
            clsProductCollection AllProduct = new clsProductCollection();
            //create an instance of the filtered data
            clsProductCollection FilteredProduct = new clsProductCollection();
            //apply a blank string (should return all records);
            FilteredProduct.ReportByName("");
            //test to see that the two values are the same 
            Assert.AreEqual(AllProduct.Count, FilteredProduct.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsProductCollection FilteredProduct = new clsProductCollection();
            //apply a name that doesnt exist
            FilteredProduct.ReportByName("xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredProduct.Count);
        }
           
    }
}
