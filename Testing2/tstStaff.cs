using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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
    }
}
