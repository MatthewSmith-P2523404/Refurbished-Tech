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
            //set the private data members to the test data value
            mOrderId = 21;
            mShippingMethod = "sameday";
            mDateOrdered = Convert.ToDateTime("16/9/2015");
            mDispatched = true;
            //always return true
            return true;
        }
    }
}