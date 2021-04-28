using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        // TEST "clsStock" CLASS

        // Good test data

        string productId = "1";
        string productName = "ASUS Laptop";
        string productPrice = "99.99";
        string modelNo = "PN123456";
        string releaseDate = Convert.ToString(new DateTime(2014, 01, 01));
        string netWeight = "1.05";
        string grossWeight = "1.25";
        string visible = "TRUE";
        

        

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
        public void testProductId()
        {
            clsStock stockTest = new clsStock();
            Int32 testData = 1;
            stockTest.productId = testData;
            Assert.AreEqual(testData, stockTest.productId);
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
            Int32 productId = 1;
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
            Int32 productId = 1;
            // invoke the Find() method
            found = stockTest.Find(productId);
            // check the data
            if (stockTest.productId != 1)
            {
                OK = false;
            }
            // see if result is expected
            Assert.IsTrue(OK);
        }


        // test valid method with correct data
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock stockTest = new clsStock();

            String Error = "";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        /**
        // test product id validity
        [TestMethod]
        public void productIdEmpty()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product ID cannot be empty.");
        }

        [TestMethod]
        public void productIdInvalid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "12345678') DROP TABLE Products; --";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product ID is invalid.");
        }

        [TestMethod]
        public void productIdExtremeMin()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "-999999";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product ID cannot be a negative value.");
        }

        [TestMethod]
        public void productIdMinLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "-1";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product ID cannot be a negative value.");
        }

        [TestMethod]
        public void productIdMinBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "0";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void productIdMinPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "1";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void productIdMaxLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "99999998";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void productIdMaxBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "99999999";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void productIdMaxPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "100000000";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product ID cannot be more than 8 digits long.");
        }


        [TestMethod]
        public void productIdExtremeMax()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "1000000000";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product ID cannot be more than 8 digits long.");
        }


        [TestMethod]
        public void productIdMid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductId = "12345";

            Error = stockTest.Valid(testProductId, productName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }
        */
        // test product name validity
        [TestMethod]
        public void ProductNameEmpty()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductName = "";

            Error = stockTest.Valid(testProductName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product name cannot be empty.");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(testProductName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

           Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(testProductName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(testProductName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product name cannot be greater than 50 characters.");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(testProductName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product name cannot be greater than 50 characters.");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductName = "aaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(testProductName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameInvalid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductName = "iPad') DROP TABLE Products; --";

            Error = stockTest.Valid(testProductName, productPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product name contains illegal characters.");
        }

        // test model number validity
        [TestMethod]
        public void ModelNoEmpty()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testModelNo = "";

            Error = stockTest.Valid(productName, productPrice, testModelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Model number cannot be empty.");
        }

        [TestMethod]
        public void ModelNoMaxLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testModelNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(productName, productPrice, testModelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNoMaxBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testModelNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(productName, productPrice, testModelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelNoMaxPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testModelNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(productName, productPrice, testModelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Model number cannot be greater than 50 characters.");
        }

        [TestMethod]
        public void ModelNoExtremeMax()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testModelNo = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(productName, productPrice, testModelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Model number cannot be greater than 50 characters.");
        }

        [TestMethod]
        public void ModelNoMid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testModelNo = "aaaaaaaaaaaaaaaaaaaa";

            Error = stockTest.Valid(productName, productPrice, testModelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelNoInvalid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testModelNo = "Optiplex') DROP TABLE Products; --";

            Error = stockTest.Valid(productName, productPrice, testModelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Model number contains illegal characters.");
        }


        // test product price validity
        [TestMethod]
        public void ProductPriceExtremeMin()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "-9999999";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Price cannot be zero or negative.");
        }

        [TestMethod]
        public void ProductPriceMinLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "-1";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Price cannot be zero or negative.");
        }

        [TestMethod]
        public void ProductPriceMinBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "0.01";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMinPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "1";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMaxLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "999999";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMaxBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "1000000";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceMaxPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "1000001";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Price is too high.");
        }

        [TestMethod]
        public void ProductPriceMid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "500000";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductPriceExtremeMax()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "1000000000";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Price is too high.");
        }

        [TestMethod]
        public void ProductPriceInvalid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testProductPrice = "onebilliondollars";

            Error = stockTest.Valid(productName, testProductPrice, modelNo,
                releaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Product price is invalid.");
        }

        // test release date validity
        [TestMethod]
        public void ReleaseDateInvalid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testReleaseDate = "thursday";

            Error = stockTest.Valid(productName, productPrice, modelNo,
               testReleaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Release date is invalid.");
        }

        [TestMethod]
        public void ReleaseDateCorrect()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testReleaseDate = Convert.ToString(DateTime.Now.Date);

            Error = stockTest.Valid(productName, productPrice, modelNo,
               testReleaseDate, netWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateEmpty()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testReleaseDate = "";

            Error = stockTest.Valid(productName, productPrice, modelNo,
               testReleaseDate, netWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Release date cannot be empty.");
        }

        // test gross weight validity
        [TestMethod]
        public void GrossWeightExtremeMin()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "-9999999";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            StringAssert.Contains(Error, "Gross weight cannot be negative.");
        }

        [TestMethod]
        public void GrossWeightMinLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "-1";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            StringAssert.Contains(Error, "Gross weight cannot be negative.");
        }

        [TestMethod]
        public void GrossWeightMinBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "0.01";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GrossWeightMinPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "1";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GrossWeightMaxLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "9999";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GrossWeightMaxBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "10000";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GrossWeightMaxPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "10001";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            StringAssert.Contains(Error, "Gross weight cannot be greater than 10,000kg.");
        }

        [TestMethod]
        public void GrossWeightMid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "500";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GrossWeightExtremeMax()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "1000000000";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            StringAssert.Contains(Error, "Gross weight cannot be greater than 10,000kg.");
        }

        [TestMethod]
        public void GrossWeightInvalid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testGrossWeight = "1 kilogram";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, netWeight, testGrossWeight, visible);

            StringAssert.Contains(Error, "Gross weight is invalid.");
        }

        // test gross weight validity
        [TestMethod]
        public void NetWeightExtremeMin()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "-9999999";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, testNetWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Net weight cannot be negative.");
        }

        [TestMethod]
        public void NetWeightMinLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "-1";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                            releaseDate, testNetWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Net weight cannot be negative.");
        }

        [TestMethod]
        public void NetWeightMinBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "0.01";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                 releaseDate, testNetWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NetWeightMinPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "1";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, testNetWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NetWeightMaxLessOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "9999";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, testNetWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NetWeightMaxBoundary()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "10000";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, testNetWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NetWeightMaxPlusOne()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "10001";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, testNetWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Net weight cannot be greater than 10,000kg.");
        }

        [TestMethod]
        public void NetWeightMid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "500";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, testNetWeight, grossWeight, visible);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NetWeightExtremeMax()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "1000000000";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, testNetWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Net weight cannot be greater than 10,000kg.");
        }

        [TestMethod]
        public void NetWeightInvalid()
        {
            clsStock stockTest = new clsStock();

            String Error = "";
            String testNetWeight = "1 kilogram";

            Error = stockTest.Valid(productName, productPrice, modelNo,
                releaseDate, testNetWeight, grossWeight, visible);

            StringAssert.Contains(Error, "Net weight is invalid.");
        }


    }
}
