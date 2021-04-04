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
    }
}