using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollections
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create on instance of the class to be created
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create a instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data to assign to the customer
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add item to the list
            clsCustomer TestItem = new clsCustomer();
            //set the items properties
            TestItem.CustomerId = 1;
            TestItem.Username = "user";
            TestItem.Password = "UserPassword";
            TestItem.Email = "user@email.co.uk";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Active = true;
            //add item to the list
            AllCustomers.CustomerList = TestList;
            //test that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data to assign to the customer
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerId = 1;
            TestCustomer.Username = "user";
            TestCustomer.Password = "UserPassword";
            TestCustomer.Email = "user@email.co.uk";
            TestCustomer.DateCreated = DateTime.Now.Date;
            TestCustomer.Active = true;
            //assign the data to the customer
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create test data to assign to the customer
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            clsCustomer TestItem = new clsCustomer();
            //set the items properties
            TestItem.CustomerId = 1;
            TestItem.Username = "user";
            TestItem.Password = "UserPassword";
            TestItem.Email = "user@email.co.uk";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Active = true;
            //add item to list
            TestList.Add(TestItem);
            //assign data to the customer
            AllCustomers.CustomerList = TestList;
            //test to check the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            int PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerId = 23;
            TestItem.Username = "BobbyS";
            TestItem.Password = "b0bby";
            TestItem.Email = "bobbyS@email.co.uk";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Active = true;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.CustomerId = 1;
            TestItem.Username = "userTwo";
            TestItem.Password = "passwordTwo";
            TestItem.Email = "userTwo@email.com";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Active = true;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.Username = "JonaM";
            TestItem.Password = "J_M";
            TestItem.Email = "j0na_m@email.co.uk";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Active = true;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerId = PrimaryKey;

            TestItem.Username = "JonaMoor";
            TestItem.Password = "J_Moor";
            TestItem.Email = "j0na_moor2@email.co.uk";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.Active = false;

            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByUsername("");
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportByUsername("xxxxxxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByUsernameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            Boolean OK = true;
            FilteredCustomers.ReportByUsername("user");
            if (FilteredCustomers.Count == 2)
            {
                if (FilteredCustomers.CustomerList[0].CustomerId != 1)
                {
                    OK = false;
                }
                if (FilteredCustomers.CustomerList[1].CustomerId != 42)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
