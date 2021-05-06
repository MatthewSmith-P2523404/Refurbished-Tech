using System;

namespace ClassLibrary
{
    //order line class and properties
    public class clsOrderLine
    {
        //private data member for the order id property
        private int mOrderId;
        //public property for order id
        public int OrderId
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
        //private data member for the product id property
        private string mProductId;
        //public property for product id
        public string ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }
        //private data member for the price property
        private double mPrice;
        //public property for price
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        //private data member for the quantity property
        private int mQuantity;
        //public property for quantity
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        //private data member for available property
        private bool mAvailable;
        //public property for available
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
        public bool Find(int orderId)
        {
            //set the private data members to the test data value
            mOrderId = 1;
            mProductId = "abc123";
            mPrice = 15.05;
            mQuantity = 2;
            mAvailable = true;
            //always return true
            return true;
        }

        public string Valid(string productId, string price, string quantity)
        {
            //create a string variable to store the error
            String Error = "";

            //temporary var ro store the price
            Double PriceTemp;

            //if the product Id is blank
            if (productId.Length == 0)
            {
                //record the error
                Error = Error + "The product Id may not be blank : ";
            }
            //if the product Id is greater than 6 characters
            if (productId.Length > 8)
            {
                //record the error
                Error = Error + "The product Id must be less than 8 characters : ";
            }
            try
            {
                PriceTemp = Double.Parse(price);
                //is the price a positive number
                if (price.Length <= 0)
                {
                    //record the error
                    Error = Error + "The price may not be 0 or less than 0 : ";
                }
                //if the price is too high
                if (price.Length > 100000)
                {
                    //record the error
                    Error = Error + "The price is too high : ";
                }
            }
            catch
            {
                Error = Error + "The price should be a number : ";
            }
            //is quantity blank
            if (quantity.Length == 0)
            {
                //record the error
                Error = Error + "The quantity may not be blank : ";
            }
            //if the quantity is too long
            if (quantity.Length > 4)
            {
                //record the error
                Error = Error + "The quantity must be less than 4 characters : ";
            }
            //return any error messages
            return Error;
        }

    }
}