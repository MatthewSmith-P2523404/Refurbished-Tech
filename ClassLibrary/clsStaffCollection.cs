using System;
using System.Collections.Generic;

namespace ClassLibrary
    
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

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
        public clsStaff ThisStaff { get; set; }

        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();

                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffStartDate"]);
                AStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["StaffSalary"]);
                AStaff.Manager = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffManager"]);

                mStaffList.Add(AStaff);

                Index++;
            }
        }
    }
}