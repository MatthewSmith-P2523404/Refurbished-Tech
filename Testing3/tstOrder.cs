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
        [TestMethod]
        public void IdOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 123;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        //testing shipping method
        [TestMethod]
        public void shippingOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "same day";
            AnOrder.ShippingMethod = TestData;
            Assert.AreEqual(AnOrder.ShippingMethod, TestData);
        }
        //testing date
        [TestMethod]
        public void dateOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateOrdered = TestData;
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }
        //testing dispatched
        [TestMethod]
        public void DispatchedOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Dispatched = TestData;
            Assert.AreEqual(AnOrder.Dispatched, TestData);
        }
        [TestMethod]
        //testing the find method
        public void FindMethodOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void OrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ShippingMethodFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the shipping method
            if (AnOrder.ShippingMethod != "sameday")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateOrderedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.DateOrdered != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DispatchedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.Dispatched!=true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }

}
