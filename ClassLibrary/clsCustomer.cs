using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mCustomerId;
        private String mUsername;
        private String mPassword;
        private String mEmail;
        private DateTime mDateCreated;
        private Boolean mActive;

        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        public string Username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }


        public DateTime DateCreated
        {
            get
            {
                return mDateCreated;
            }
            set
            {
                mDateCreated = value;
            }
        }
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public bool Find(int CustomerId)
        {
            // create instance to the database
            clsDataConnection DB = new clsDataConnection();
            // add parameter primary key to be searched for
            DB.AddParameter("@CustomerID", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            // if the record is found
            if (DB.Count == 1)
            {
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["ActiveAccount"]);
                return true;
            }
            // no record was found
            else
            {
                return false;
            }
        }

        public string Valid(string username,
                            string password,
                            string email,
                            string dateCreated)
        {
            String Error = "";
            DateTime DateTemp;

            if (username.Length == 0)
            {
                Error = Error + "The username may not be blank: ";
            }
            if (username.Length > 20)
            {
                Error = Error + "The username must be less than 20 characters: ";
            }
            
            if (password.Length == 0)
            {
                Error = Error + "The password may not be blank: ";
            }
            if (password.Length > 50)
            {
                Error = Error + "The password must be less than 50 characters: ";
            }

            if (email.Length == 0)
            {
                Error = Error + "The email may not be blank: ";
            }
            if (email.Length > 50)
            {
                Error = Error + "The email must be less than 50 character: ";
            }
            if (!email.Contains("@"))
            {
                Error = Error + "The email must contain the symbol @ for it to be a vaild email address: ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateCreated);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "The date was not valid date: ";
            }
            

            return Error;
        }

    }
}