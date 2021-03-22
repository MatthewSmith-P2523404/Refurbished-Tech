using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffName = "Matthew Smith";
            TestItem.StaffAddress = "15 Somewhere Road";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Salary = 15000.50;
            TestItem.Manager = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;

            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.StaffName = "Matthew Smith";
            TestStaff.StaffAddress = "15 Somewhere Road";
            TestStaff.StartDate = DateTime.Now.Date;
            TestStaff.Salary = 15000.50;
            TestStaff.Manager = true;

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();

            clsStaff TestItem = new clsStaff();
            TestItem.StaffName = "Matthew Smith";
            TestItem.StaffAddress = "15 Somewhere Road";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Salary = 15000.50;
            TestItem.Manager = true;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        
    }
}
