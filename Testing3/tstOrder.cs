using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    //test class for orders
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method
        string ShippingMethod = "sameday";
        string DateOrdered = DateTime.Now.Date.ToString();
        [TestMethod]
        //creating an instance
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        //testing order id
        [TestMethod]
        public void IdOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 123;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        //testing shipping method
        [TestMethod]
        public void shippingOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "same day";
            AnOrder.ShippingMethod = TestData;
            Assert.AreEqual(AnOrder.ShippingMethod, TestData);
        }
        //testing date
        [TestMethod]
        public void dateOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateOrdered = TestData;
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }
        //testing dispatched
        [TestMethod]
        public void DispatchedOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Dispatched = TestData;
            Assert.AreEqual(AnOrder.Dispatched, TestData);
        }
        [TestMethod]
        //testing the find method
        public void FindMethodOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void OrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ShippingMethodFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the shipping method
            if (AnOrder.ShippingMethod != "sameday")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DateOrderedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.DateOrdered != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void DispatchedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 21;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.Dispatched!=true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //validation testing
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsOrder AnOrder= new clsOrder();
            //string var to store error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test result
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingMethodMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShippingMethod = "";
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingMethodMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingMethod = "a";
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingMethodMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingMethod = "aa";
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingMethodMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingMethod = "";
            ShippingMethod = ShippingMethod.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingMethodMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingMethod = "";
            ShippingMethod = ShippingMethod.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingMethodMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShippingMethod = "";
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingMethodMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingMethod = "";
            ShippingMethod = ShippingMethod.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the date to a non date value
            string DateOrdered = "this is not a date";
            //invoke the method
            Error = AnOrder.Valid(ShippingMethod, DateOrdered);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }

}
