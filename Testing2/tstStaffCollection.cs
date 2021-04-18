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

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StaffID = 1;
            TestItem.StaffName = "Matthew Smith";
            TestItem.StaffAddress = "15 Somewhere Road";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Salary = 13500;
            TestItem.Manager = true;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();

            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StaffID = 1;
            TestItem.StaffName = "Matthew Smith";
            TestItem.StaffAddress = "15 Somewhere Road";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Salary = 13500;
            TestItem.Manager = true;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;

            TestItem.StaffID = 2;
            TestItem.StaffName = "Caitlin Smith";
            TestItem.StaffAddress = "10 Anywhere else";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Salary = 10000.50;
            TestItem.Manager = false;

            AllStaff.ThisStaff = TestItem;

            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StaffID = 1;
            TestItem.StaffName = "Matthew Smith";
            TestItem.StaffAddress = "15 Somewhere Road";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.Salary = 13500;
            TestItem.Manager = true;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();

            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();

            Boolean found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilterStaff = new clsStaffCollection();

            FilterStaff.ReportByName("");
            Assert.AreEqual(AllStaff.Count, FilterStaff.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReportByName("Johnny");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReporByNameTestDataFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            Boolean OK = true;

            FilteredStaff.ReportByName("Freddy");

            if (FilteredStaff.Count == 2)
            {
                if (FilteredStaff.StaffList[0].StaffID != 34)
                {
                    OK = false;
                }

                if (FilteredStaff.StaffList[1].StaffID != 35)
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
