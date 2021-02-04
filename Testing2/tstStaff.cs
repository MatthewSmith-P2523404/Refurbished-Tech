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
            double TestSalary = 1000.50;
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
    }
}
