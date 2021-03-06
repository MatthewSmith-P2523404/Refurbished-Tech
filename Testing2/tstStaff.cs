using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        String StaffName = "Matthew Smith";
        String StaffAddress = "15 Somewhere Road";
        String StartDate = DateTime.Now.Date.ToString();
        String Salary = Convert.ToString(1500);

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Int32 TestID = 1;
            AStaff.StaffID = TestID;
            Assert.AreEqual(AStaff.StaffID, TestID);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            String TestString = "testing";
            AStaff.StaffName = TestString;
            Assert.AreEqual(AStaff.StaffName, TestString);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            String TestString = "test road";
            AStaff.StaffAddress = TestString;
            Assert.AreEqual(AStaff.StaffAddress, TestString);
        }

        [TestMethod]
        public void StartDatePropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestDate = DateTime.Now.Date;
            AStaff.StartDate = TestDate;
            Assert.AreEqual(AStaff.StartDate, TestDate);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Double TestSalary = 1000.50;
            AStaff.Salary = TestSalary;
            Assert.AreEqual(AStaff.Salary, TestSalary);
        }

        [TestMethod]
        public void ManagerPropertyOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Testbool = true;
            AStaff.Manager = Testbool;
            Assert.AreEqual(AStaff.Manager, Testbool);
        }

        //TESTING FIND METHOD

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffName != "Matthew Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffAddress != "15 Somewhere Road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.StartDate != Convert.ToDateTime("29/01/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.Salary != 13000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManagerFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.Manager != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        } 
        //TESTING VALIDATION

        [TestMethod]
        public void ValidMethodOK()
        {
        clsStaff AStaff = new clsStaff();
        String error = "";
        error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
        Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "a";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "ab";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcv";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvb";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbn";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "qwertyuiopasdfghjklzxcvbn";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StartDateExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StartDate = TestDate.ToString();
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StartDateMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string StartDate = TestDate.ToString();
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StartDate = TestDate.ToString();
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StartDateMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string StartDate = TestDate.ToString();
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StartDateExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StartDate = TestDate.ToString();
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StartDateNotValid()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffName = "Matthew Smith";
            string StaffAddress = "15 somewhere road";
            string salary = Convert.ToString(1500);
            string StartDate = "Not a date";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffAddress = "";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }
        
        [TestMethod]
        public void StaffAddressMin()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffAddress = "1";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffAddress = "15";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffAddress = "qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcv";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMax()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffAddress = "qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvb";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffAddress = "qwertyuiopasdfghjklzxcvbnmqwertyuiopasdfghjklzxcvbn";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffAddress = "";
            StaffAddress.PadRight(500, 'a');
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void StaffAddressMid()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string StaffAddress = "qwertyuiopasdfghjklzxcvbn";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(0);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SalaryMin()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(1);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(2);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(999999.98);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryMax()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(999999.99);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        public void SalaryMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(1000000.00);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SalaryMid()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(500000);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void SalaryExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(10000000000);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SalaryExtremeMin()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = Convert.ToString(-10000000);
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void SalaryInvalid()
        {
            clsStaff AStaff = new clsStaff();
            String error = "";
            string Salary = "Not a number";
            error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);
            Assert.AreNotEqual(error, "");
        }
    }

   
}
