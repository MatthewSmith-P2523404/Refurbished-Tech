using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStock
    {
        // private member variables for class properties
        private Int32 mProductID;
        private string mProductName;
        private double mProductPrice;
        private string mModelNo;
        private DateTime mReleaseDate;
        private double mNetWeight;
        private double mGrossWeight;
        private bool mVisible;

        public Int32 productID
        {
            get
            {
                return mProductID; // return the property
            }
            set
            {
                mProductID = value; // set the property
            }
        }

        public string productName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }

        public double productPrice
        {
            get
            {
                return mProductPrice;
            }
            set
            {
                mProductPrice = value;
            }
        }

        public string modelNo
        {
            get
            {
                return mModelNo;
            }
            set
            {
                mModelNo = value;
            }
        }

        public DateTime releaseDate
        {
            get
            {
                return mReleaseDate;
            }
            set
            {
                mReleaseDate = value;
            }
        }

        public double netWeight
        {
            get
            {
                return mNetWeight;
            }
            set
            {
                mNetWeight = value;
            }
        }

        public double grossWeight
        {
            get
            {
                return mGrossWeight;
            }
            set
            {
                mGrossWeight = value;
            }
        }
        public bool visible
        {
            get
            {
                return mVisible;
            }
            set
            {
                mVisible = value;
            }
        }

        // Find methods

        public bool Find(int productId)
        {
            // temporary data
            mProductID = 000001;
            mProductName = "Lenovo Thinkpad";
            mProductPrice = 129.99;
            mModelNo = "T440P";
            mReleaseDate = Convert.ToDateTime("01/01/2014");
            mNetWeight = 1.50;
            mGrossWeight = 2.00;
            mVisible = true;

            // always return true
            return true;
        }
    }
}
