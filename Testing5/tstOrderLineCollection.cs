using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstOrderLineCollection

    {
        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of a class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //test if it exists
            Assert.IsNotNull(AllOrderLines);
            //create a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an intem into the list
            //create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.OrderId = 1;
            TestItem.ProductId = "123abc";
            TestItem.Price = 24.99;
            TestItem.Quantity = 3;
            TestItem.Available = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrderLines.OrderLineList = TestList;
            //test if values are the same
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            //instance of class
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //test data
            Int32 SomeCount = 0;
            //assign data to property
            AllOrderLines.Count = SomeCount;
            //test if values are the same
            Assert.AreEqual(AllOrderLines.Count, SomeCount);
        }
        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            //instance of class
            clsOrderLineCollection AllOrders = new clsOrderLineCollection();
            //test data
            clsOrderLine TestOrderLine = new clsOrderLine();
            //set properties of the test object
            TestOrderLine.OrderId = 1;
            TestOrderLine.ProductId = "123abc";
            TestOrderLine.Price = 24.99;
            TestOrderLine.Quantity = 3;
            TestOrderLine.Available = true;
            //assign data to property
            AllOrders.ThisOrderLine = TestOrderLine;
            //test if values are the same
            Assert.AreEqual(AllOrders.ThisOrderLine, TestOrderLine);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //instance of class
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //test data
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //add an item to the list
            clsOrderLine TestItem = new clsOrderLine();
            //set properties
            TestItem.OrderId = 1;
            TestItem.ProductId = "123abc";
            TestItem.Price = 24.99;
            TestItem.Quantity = 3;
            TestItem.Available = true;
            //add item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllOrderLines.OrderLineList = TestList;
            //test if values are the same
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //instance of class
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create item for test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderId = 1;
            TestItem.ProductId = "123abc";
            TestItem.Price = 24.99;
            TestItem.Quantity = 3;
            TestItem.Available = true;
            //set ThisOrder to the test data
            AllOrderLines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLines.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //test if values are the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //instance of class
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create item for test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderId = 1;
            TestItem.ProductId = "123abc";
            TestItem.Price = 24.99;
            TestItem.Quantity = 3;
            TestItem.Available = true;
            //set ThisOrder to the test data
            AllOrderLines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLines.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify the test data
            TestItem.OrderId = 2;
            TestItem.ProductId = "124vbc";
            TestItem.Price = 36;
            TestItem.Quantity = 1;
            TestItem.Available = false;
            //set the record based on the new test data
            AllOrderLines.ThisOrderLine = TestItem;
            //update the record
            AllOrderLines.Update();
            //find the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //test if values are the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //instance of class
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //create item for test data
            clsOrderLine TestItem = new clsOrderLine();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.OrderId = 1;
            TestItem.ProductId = "123abc";
            TestItem.Price = 24.99;
            TestItem.Quantity = 3;
            TestItem.Available = true;
            //set ThisOrder to the test data
            AllOrderLines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderLines.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //delete the record
            //AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByProductIdOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLineCollection FilterOrderLines = new clsOrderLineCollection();

            FilterOrderLines.ReportByProductId("");
            Assert.AreEqual(AllOrderLines.Count, FilterOrderLines.Count);
        }
        [TestMethod]
        public void ReportByProductIdFound()
        {
            //create an instance of the filtered data
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            //apply a shipping method that doesnt exist
            FilteredOrderLines.ReportByProductId("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrderLines.Count);
        }
        [TestMethod]
        public void ReportByProductIdTestDataFound()
        {
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a shipping method that doesn't exist
            FilteredOrderLines.ReportByProductId("yyy yyy");
            //check that the correct number of records are found
            if (FilteredOrderLines.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredOrderLines.OrderLineList[0].OrderId != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 2
                if (FilteredOrderLines.OrderLineList[1].OrderId != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
