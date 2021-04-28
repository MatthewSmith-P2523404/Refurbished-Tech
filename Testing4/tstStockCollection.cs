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

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }


    }
}
