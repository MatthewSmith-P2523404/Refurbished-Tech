using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of a class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test if it exists
            Assert.IsNotNull(AllOrders);
            //create a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an intem into the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.ShippingMethod = "sameday";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Dispatched = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrders.OrderList = TestList;
            //test if values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //instance of class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test data
            Int32 SomeCount = 0;
            //assign data to property
            AllOrders.Count = SomeCount;
            //test if values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //instance of class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test data
            clsOrder TestOrder = new clsOrder();
            //set properties of the test object
            TestOrder.OrderId = 1;
            TestOrder.ShippingMethod = "sameday";
            TestOrder.DateOrdered = DateTime.Now.Date;
            TestOrder.Dispatched = true;
            //assign data to property
            AllOrders.ThisOrder = TestOrder;
            //test if values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
    }
}
