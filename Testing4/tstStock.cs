﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        // TEST "clsStock" CLASS

        // instantiate class and check if not null
        public void testInstantiation()
        {
            clsStock stockTest = new clsStock();
            Assert.IsNotNull(stockTest);
        }

        // TEST PROPERTIES

        // 1: instantiate class 
        // 2: create test data
        // 3: set test data to property 
        // 4: check test data & property are equal

        // test the "Product ID" property
        [TestMethod]
        public void testProductID()
        {
            clsStock stockTest = new clsStock();
            Int32 testData = 1;
            stockTest.productID = testData;
            Assert.AreEqual(testData, stockTest.productID);
        }

        // test the "Product Name" property
        [TestMethod]
        public void testProductName()
        {
            clsStock stockTest = new clsStock();
            string testData = "Dell Optiplex GX200";
            stockTest.productName = testData;
            Assert.AreEqual(testData, stockTest.productName);
        }

        // test the "Product Price" property
        [TestMethod]
        public void testProductPrice()
        {
            clsStock stockTest = new clsStock();
            double testData = 39.99;
            stockTest.productPrice = testData;
            Assert.AreEqual(testData, stockTest.productPrice);
        }

        // test the "Model Number" property
        [TestMethod]
        public void testModelNo()
        {
            clsStock stockTest = new clsStock();
            string testData = "GX200";
            stockTest.modelNo = testData;
            Assert.AreEqual(testData, stockTest.modelNo);
        }

        // test the "Release Date" property
        [TestMethod]
        public void testReleaseDate()
        {
            clsStock stockTest = new clsStock();
            DateTime testData = new DateTime(2005, 1, 1);
            stockTest.releaseDate = testData;
            Assert.AreEqual(testData, stockTest.releaseDate);
        }

        // test the "Net Weight" property
        [TestMethod]
        public void testNetWeight()
        {
            clsStock stockTest = new clsStock();
            double testData = 5.00;
            stockTest.netWeight = testData;
            Assert.AreEqual(testData, stockTest.netWeight);
        }

        // test the "Gross Weight" property
        [TestMethod]
        public void testGrossWeight()
        {
            clsStock stockTest = new clsStock();
            double testData = 5.00;
            stockTest.grossWeight = testData;
            Assert.AreEqual(testData, stockTest.grossWeight);
        }

        // test the "Visible" property
        [TestMethod]
        public void testVisible()
        {
            clsStock stockTest = new clsStock();
            bool testData = false;
            stockTest.visible = testData;
            Assert.AreEqual(testData, stockTest.visible);
        }

        // TEST FIND METHOD

        [TestMethod]
        public void testFind()
        {
            // instantiate stock class
            clsStock stockTest = new clsStock();
            // prepare boolean for validating find method
            Boolean found = false;
            // product ID to search for
            Int32 productId = 000001;
            // test the Find() method
            found = stockTest.Find(productId);
            // should be found i.e. true
            Assert.IsTrue(found);
        }

        // TEST FIND METHOD WITH HARDCODED DATA

        [TestMethod]
        public void testProductNoFound()
        {
            // instantiate stock class
            clsStock stockTest = new clsStock();
            // prepare boolean for validating find method
            Boolean found = false;
            // prepare boolean for validating if data is OK
            Boolean OK = true;
            // product ID to search for
            Int32 productID = 000001;
            // invoke the Find() method
            found = stockTest.Find(productID);
            // check the data
            if (stockTest.productID != 000001)
            {
                OK = false;
            }
            // see if result is expected
            Assert.IsTrue(OK);
        }

        // Insert other tests here tomorrow probably
    }
}
