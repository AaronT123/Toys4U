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
    }
}
