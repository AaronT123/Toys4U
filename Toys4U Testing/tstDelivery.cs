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
    }
}
