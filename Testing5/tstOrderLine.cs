using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{   //test class for order lines
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }
        //testing order ID
        [TestMethod]
        public void IdOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 123;
            AnOrderLine.OrderId = TestData;
            Assert.AreEqual(AnOrderLine.OrderId, TestData);
        }
        //testing product ID
        [TestMethod]
        public void ProductIdOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            string TestData = "abc123";
            AnOrderLine.ProductId = TestData;
            Assert.AreEqual(AnOrderLine.ProductId, TestData);
        }
        //testing price
        [TestMethod]
        public void PriceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            double TestData = 25.00;
            AnOrderLine.Price = TestData;
            Assert.AreEqual(AnOrderLine.Price, TestData);
        }
        //testing quantity
        [TestMethod]
        public void QuantityOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 3;
            AnOrderLine.Quantity = TestData;
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }
        //testing availability
        [TestMethod]
        public void AvailableOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean TestData = true;
            AnOrderLine.Available = TestData;
            Assert.AreEqual(AnOrderLine.Available, TestData);
        }
    }
}
