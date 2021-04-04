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
        [TestMethod]
        //testing the find method
        public void FindMethodOK()
        {
            //create an instance of the class
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderLine.Find(OrderId);
            //test to see if result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void OrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderLine.Find(OrderId);
            //check the order id
            if (AnOrderLine.OrderId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ProductIdFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderLine.Find(OrderId);
            //check the product id
            if (AnOrderLine.ProductId != "abc123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void PriceFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderLine.Find(OrderId);
            //check the price
            if (AnOrderLine.Price != 15.05)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void QuantityFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderLine.Find(OrderId);
            //check the quantity
            if (AnOrderLine.Quantity != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void AvailableFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrderLine.Find(OrderId);
            //check available
            if (AnOrderLine.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
       
    }
}
