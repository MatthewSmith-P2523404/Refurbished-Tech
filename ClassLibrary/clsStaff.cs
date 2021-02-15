using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffID;
        private String mStaffName;
        private String mStaffAddress;
        private DateTime mStartDate;
        private Double mSalary;
        private Boolean mManager;


        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }
        }
        public string StaffAddress
        {
            get
            {
                return mStaffAddress;
            }
            set
            {
                mStaffAddress = value;
            }
        }
        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
            }
        }
        public double Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }
        public bool Manager
        {
            get
            {
                return mManager;
            }
            set
            {
                mManager = value;
            }
        }

        public bool Find(int staffID)
        {
            mStaffID = 21;
            mStaffName = "Matthew Smith";
            mStaffAddress = "A road";
            mStartDate = Convert.ToDateTime("07/03/2020");
            mSalary = 1400.50;
            mManager = true;
            return true;
        }
    }
}