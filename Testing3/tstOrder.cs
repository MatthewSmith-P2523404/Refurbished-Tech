using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        public void IdOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "abc123";
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        public void shippingOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "same day";
            AnOrder.ShippingMethod = TestData;
            Assert.AreEqual(AnOrder.ShippingMethod, TestData);
        }

        public void dateOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateOrdered = TestData;
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }
    }
    
}
