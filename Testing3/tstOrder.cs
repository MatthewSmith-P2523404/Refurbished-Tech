using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    //test class for orders
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        //creating an instance
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        //testing order id
        public void IdOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "abc123";
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        //testing shipping method
        public void shippingOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "same day";
            AnOrder.ShippingMethod = TestData;
            Assert.AreEqual(AnOrder.ShippingMethod, TestData);
        }
        //testing date
        public void dateOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateOrdered = TestData;
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }
        //testing dispatched
        public void DispatchedOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Dispatched = TestData;
            Assert.AreEqual(AnOrder.Dispatched, TestData);
        }
    }
    
}
