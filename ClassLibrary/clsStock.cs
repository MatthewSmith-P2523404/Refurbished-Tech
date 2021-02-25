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
        private Int32 mProductId;
        private string mProductName;
        private double mProductPrice;
        private string mModelNo;
        private DateTime mReleaseDate;
        private double mNetWeight;
        private double mGrossWeight;
        private bool mVisible;

        public Int32 productId
        {
            get
            {
                return mProductId; // return the property
            }
            set
            {
                mProductId = value; // set the property
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
        // for productId
        public bool Find(int productId)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@productId", productId);

            DB.Execute("sproc_tblStock_FilterByProductId");

            if (DB.Count == 1)
            {
                // copy from the database to private properties
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["productId"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["productName"]);
                mProductPrice = Convert.ToDouble(DB.DataTable.Rows[0]["productPrice"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["releaseDate"]);
                mModelNo = Convert.ToString(DB.DataTable.Rows[0]["modelNo"]);
                mNetWeight = Convert.ToDouble(DB.DataTable.Rows[0]["netWeight"]);
                mGrossWeight = Convert.ToDouble(DB.DataTable.Rows[0]["grossWeight"]);
                mVisible = Convert.ToBoolean(DB.DataTable.Rows[0]["visible"]);

                // return true if everything worked OK
                return true;
            }

            else
            {
                // return false if the item wasn't found
                return false;
            }
        }
    }
}
