using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //get public property for the address list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return private data
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                // to be continued...
            }
        }
            
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DateCreated", mThisCustomer.DateCreated);
            DB.AddParameter("@ActiveAccount", mThisCustomer.Active);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DateCreated", mThisCustomer.DateCreated);
            DB.AddParameter("@ActiveAccount", mThisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByUsername(string Username)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", Username);
            DB.Execute("sproc_tblCustomer_FilterByUsername");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.DateCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateCreated"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["ActiveAccount"]);

                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
    }
}