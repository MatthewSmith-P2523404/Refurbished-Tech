using System;

namespace ClassLibrary
{
    //order class and properties
    public class clsOrder
    {
        //private data member for the order id property
        private Int32 mOrderId;
        //order id public property
        public Int32 OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
        //private data member for shipping method property
        private string mShippingMethod;
        //shipping method public property
        public string ShippingMethod
        {
            get
            {
                return mShippingMethod;
            }
            set
            {
                mShippingMethod = value;
            }
        }
        //private data member for date property
        private System.DateTime mDateOrdered;
        public System.DateTime DateOrdered
        {
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered=value;
            }
        }
        //private data member for the dispatched property
        private Boolean mDispatched;
        public Boolean Dispatched
        {
            get
            {
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }

        public bool Find(int orderId)
        {
            /* //set the private data members to the test data value
             mOrderId = 1;
             mShippingMethod = "sameday";
             mDateOrdered = Convert.ToDateTime("16/9/2015");
             mDispatched = true;
             //always return true
             return true;
             */
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order ID to search for
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //if one record is found(there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mShippingMethod = Convert.ToString(DB.DataTable.Rows[0]["ShippinfMethod"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOrdered"]);
                mDispatched=Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string shippingMethod, string dateOrdered)
        {
            //var to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the shipping method is blank
            if (shippingMethod.Length == 0)
            {
                Error = Error + "The shipping method may be blank : ";
            }

            if (shippingMethod.Length > 50)
            {
                Error = Error + "The shipping method should be less than 50 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOrdered);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }


            //return any error messages
            return Error;
        }
    }
}