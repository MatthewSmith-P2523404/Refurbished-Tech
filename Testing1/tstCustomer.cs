using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string Username = "BobbyS";
        string Password = "b0bby";
        string Email = "bobbyS@email.co.uk";
        string DateCreated = DateTime.Now.Date.ToString();

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
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void UsernameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "bobs_username";
            ACustomer.Username = TestData;
            Assert.AreEqual(ACustomer.Username, TestData);
        }

        [TestMethod]
        public void PasswordOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "bobs_pass";
            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "bob@email.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void DateCreatedOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateCreated = TestData;
            Assert.AreEqual(ACustomer.DateCreated, TestData);
        }

        [TestMethod]
        public void ActiveAccountOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;

            Found = ACustomer.Find(CustomerId);

            if (ACustomer.CustomerId != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUsernameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;

            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Username != "TessaD")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;

            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Password != "TessTestPass")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;

            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Email != "tessa.D@email.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateCreatedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;

            Found = ACustomer.Find(CustomerId);

            if (ACustomer.DateCreated != Convert.ToDateTime("25/02/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;

            Found = ACustomer.Find(CustomerId);

            if (ACustomer.Active != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "a";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "ab";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "abcdefghijklmnopqrs";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "abcdefghijklmnopqrst";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "abcdefghijklmnopqrstu";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void UsernameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "abcdefghij";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Username = "";
            Username = Username.PadRight(100, 'a');
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "a";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "ab";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(49, 'a');
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(50, 'a');
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(51, 'a');
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(25, 'a');
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(200, 'a');
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "@";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "a@";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(48, 'a');
            Email = Email + "@";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Email = Email + "@";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(50, 'a');
            Email = Email + "@";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(24, 'a');
            Email = Email + "@";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(199, 'a');
            Email = Email + "@";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateCreated = TestDate.ToString();
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateCreated = TestDate.ToString();
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateCreated = TestDate.ToString();
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string DateCreated = TestDate.ToString();
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateCreated = TestDate.ToString();
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateCreatedInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string DateCreated = "this is not a date!";
            Error = ACustomer.Valid(Username, Password, Email, DateCreated);
            Assert.AreNotEqual(Error, "");
        }
    }    
}
