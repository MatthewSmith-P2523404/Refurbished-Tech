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
        [TestMethod]
        public void ListAndCountOK()
        {
            //instance of class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test data
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            clsOrder TestItem = new clsOrder();
            //set properties
            TestItem.OrderId = 1;
            TestItem.ShippingMethod = "sameday";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Dispatched = true;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrders.OrderList = TestList;
            //test if values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //instance of class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item for test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderId = 1;
            TestItem.ShippingMethod = "sameday";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Dispatched = true;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test if values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //instance of class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create item for test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderId = 1;
            TestItem.ShippingMethod = "sameday";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Dispatched = true;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test data
            TestItem.OrderId = 3;
            TestItem.ShippingMethod = "nextday";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestItem.Dispatched = false;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test if values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}

 

