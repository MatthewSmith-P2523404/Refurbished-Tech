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
        public Double Salary
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

        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");

            //if a record is found
            if (DB.Count == 1)
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffStartDate"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["StaffSalary"]);
                mManager = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffManager"]);
                return true;
            }
            //if no record is found
            else
            {
                return false;
            }
        }

        public string Valid(string staffName, string staffAddress, string startDate, string salary)
        {
            String error = "";      //variable for the error
            DateTime TempDate;      //variable for the temporary date
            Double TempSalary;       //variable for the temporary salary

            if(staffName.Length == 0)
            {
                error = error + "The Staff name may be blank : "; 
            }

            if(staffName.Length > 50)
            {
                error = error + "The Staff name should be less than 50 characters : ";
            }

            try
            {
                TempDate = Convert.ToDateTime(startDate);
                if (TempDate < DateTime.Now.Date)
                {
                    error = error + "The date cannot be in the past : ";
                }

                if (TempDate > DateTime.Now.Date)
                {
                    error = error + "The data cannot be in the future : ";
                }
            }
            catch
            {
                error = error + "The date was not a valid date : ";
            }
            
            if (staffAddress.Length == 0)
            {
                error = error + "The address may be blank : ";
            }

            if (staffAddress.Length > 50)
            {
                error = error + "The address should not be over 50 characters : ";
            }

            try
            {
                TempSalary = Double.Parse(salary);
                if (TempSalary <= 0)
                {
                    error = error + "The salary should not be 0 or less : ";
                }

                if (TempSalary >= 1000000)
                {
                    error = error + "The salary is too high : ";
                }
            }
            catch
            {
                error = error + "The salary should be a number : ";
            }

            return error;
        }
    }
}