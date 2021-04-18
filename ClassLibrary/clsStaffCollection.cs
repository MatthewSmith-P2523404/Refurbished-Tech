using System;
using System.Collections.Generic;

namespace ClassLibrary
    
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;

            RecordCount = DB.Count;

            mStaffList = new List<clsStaff>();

            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();

                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffStartDate"]);
                AStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["StaffSalary"]);
                AStaff.Manager = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffManager"]);

                mStaffList.Add(AStaff);

                Index++;
            }
        }

        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffStartDate", mThisStaff.StartDate);
            DB.AddParameter("@StaffSalary", mThisStaff.Salary);
            DB.AddParameter("@StaffManager", mThisStaff.Manager);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("StaffID", mThisStaff.StaffID);
            DB.AddParameter("StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffStartDate", mThisStaff.StartDate);
            DB.AddParameter("@StaffSalary", mThisStaff.Salary);
            DB.AddParameter("@StaffManager", mThisStaff.Manager);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StaffID", mThisStaff.StaffID);

            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByName(String Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", Name);

            DB.Execute("sproc_tblStaff_FilterByName");

            PopulateArray(DB);
        }
    }
}