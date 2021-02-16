using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);

        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void usernameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "bobs_username";
            ACustomer.Username = TestData;
            Assert.AreEqual(ACustomer.Username, TestData);
        }

        [TestMethod]
        public void passwordOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "bobs_pass";
            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void emailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "bob@email.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void dateCreatedOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateCreated = TestData;
            Assert.AreEqual(ACustomer.DateCreated, TestData);
        }

        [TestMethod]
        public void activeAccountOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }

    }
}
