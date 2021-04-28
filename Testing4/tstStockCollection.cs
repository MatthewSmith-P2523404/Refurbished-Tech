using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection(); //instantiate class

            Assert.IsNotNull(AllStock); // test it exists
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection(); //instantiate class

            List<clsStock> TestList = new List<clsStock>(); // create empty list

            clsStock AnItem = new clsStock();

            AnItem.productId = 1;
            AnItem.productName = "ASUS Laptop";
            AnItem.productPrice = 199.99;
            AnItem.modelNo = "x200";
            AnItem.netWeight = 1.50;
            AnItem.grossWeight = 1.80;
            AnItem.releaseDate = DateTime.Now.Date;
            AnItem.visible = true;

            TestList.Add(AnItem);

            AllStock.StockList = TestList;
            
            Assert.AreEqual(AllStock.StockList, TestList);
        }
       
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection(); //instantiate class

            clsStock AnItem = new clsStock();

            AnItem.productId = 1;
            AnItem.productName = "ASUS Laptop";
            AnItem.productPrice = 199.99;
            AnItem.modelNo = "x200";
            AnItem.netWeight = 1.50;
            AnItem.grossWeight = 1.80;
            AnItem.releaseDate = DateTime.Now.Date;
            AnItem.visible = true;

            AllStock.ThisItem = AnItem;

            Assert.AreEqual(AllStock.ThisItem, AnItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection(); //instantiate class

            List<clsStock> TestList = new List<clsStock>(); // create empty list

            clsStock AnItem = new clsStock();

            AnItem.productName = "ASUS Laptop";
            AnItem.productPrice = 199.99;
            AnItem.modelNo = "x200";
            AnItem.netWeight = 1.50;
            AnItem.grossWeight = 1.80;
            AnItem.releaseDate = DateTime.Now.Date;
            AnItem.visible = true;

            TestList.Add(AnItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // instantiate collection class
            clsStockCollection AllStock = new clsStockCollection(); //instantiate class
            // instantiate stock item
            clsStock AnItem = new clsStock();
            // int for primary key
            Int32 PrimaryKey = 0;
            // test data
            AnItem.productId = 1;
            AnItem.productName = "ASUS Netbook";
            AnItem.productPrice = 49.99;
            AnItem.modelNo = "EEE PC 1015BX";
            AnItem.netWeight = 1.50;
            AnItem.grossWeight = 1.80;
            AnItem.releaseDate = DateTime.Now.Date;
            AnItem.visible = true;
            // set collection ThisItem to test data
            AllStock.ThisItem = AnItem;
            // add record
            PrimaryKey = AllStock.Add();
            // set primary key of test data
            AnItem.productId = PrimaryKey;
            // find record
            AllStock.ThisItem.Find(PrimaryKey);
            // test to see ThisItem matches test data
            Assert.AreEqual(AllStock.ThisItem, AnItem);
        }
        
        // test update/edit method
        [TestMethod]
        public void UpdateMethodOK()
        {
            // instantiate collection class
            clsStockCollection AllStock = new clsStockCollection(); //instantiate class
            // instantiate stock item
            clsStock AnItem = new clsStock();
            // int for primary key
            Int32 pk = 0;
            // test data
            AnItem.productName = "ASUS Netbook";
            AnItem.productPrice = 49.99;
            AnItem.modelNo = "EEE PC 1015BX";
            AnItem.netWeight = 1.50;
            AnItem.grossWeight = 1.80;
            AnItem.releaseDate = DateTime.Now.Date;
            AnItem.visible = true;
            // set collection ThisItem to test data
            AllStock.ThisItem = AnItem;
            // add record
            pk = AllStock.Add();
            // set primary key of test data
            AnItem.productId = pk;
            // modify test data
            AnItem.productName = "ASUS Desktop PC";
            AnItem.productPrice = 159.99;
            AnItem.modelNo = "x350";
            AnItem.netWeight = 2.50;
            AnItem.grossWeight = 2.80;
            AnItem.releaseDate = DateTime.Now.Date;
            AnItem.visible = false;
            // set record based on new test data
            AllStock.ThisItem = AnItem;
            // update record
            AllStock.Update();
            // find record
            AllStock.ThisItem.Find(pk);
            // test to see ThisItem matches test data
            Assert.AreEqual(AllStock.ThisItem, AnItem);
        }

        [TestMethod] 
        public void FilterByMaxPriceOK()
        {
            clsStockCollection AllStock = new clsStockCollection(); //instantiate class
            clsStockCollection FilteredStock = new clsStockCollection(); //instantiate class again

            // invoke method
            FilteredStock.FilterByMaxPrice(10000);

            // should be equal
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void FilterByMaxPriceNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection(); //instantiate class
            // price cannot be free so none should be found
            FilteredStock.FilterByMaxPrice(-1);
            // should be no records
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void FilterByMaxPriceDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection(); //instantiate class
            // outcome bool
            Boolean OK = true;

            // should not normally be possible for an item to be free
            // but a test record should be created with a price of 0.00 to test this method
            FilteredStock.FilterByMaxPrice(0.00); 

            // should be exactly 1 result
            if (FilteredStock.Count == 1)
            {
                // if doesn't match the specific name, change bool to false
                if (FilteredStock.StockList[0].productName != "TESTITEM-IGNORE")
                {
                    OK = false;
                }
            } else
            {
                OK = false; // if count 0 also make it false
            }
            Assert.IsTrue(OK);
        }

    }
}
