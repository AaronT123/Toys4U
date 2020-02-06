using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toys4U_Classes;

namespace Toys4U_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a instanc of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exist
            Assert.IsNotNull(AnCustomer);
        }
    }
}
