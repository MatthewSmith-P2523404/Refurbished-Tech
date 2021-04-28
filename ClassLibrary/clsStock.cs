using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public string Valid(string productId, string productName, string productPrice, string modelNo, string releaseDate, string netWeight, string grossWeight, string visible)
        {
            string Error = ""; // String to contain error messages
            Regex validChars = new Regex("^[a-zA-Z0-9-_ ]*$"); // regex to validate strings as alphanumeric

            // Product ID validation
            if (productId == "")
            {
                Error += "Product ID cannot be empty.\n";
            }
            else if (!Int32.TryParse(productId, out int a))
            {
                Error += "Product ID is invalid.\n";
            }
            else if (productId.Length > 8)
            {
                Error += "Product ID cannot be more than 8 digits long.\n";
            }
            else if (Convert.ToInt32(productId) < 0)
            {
                Error += "Product ID cannot be a negative value.\n";
            }

            // Product name validation
            if (productName == "")
            {
                Error += "Product name cannot be empty.\n";
            }
            else if (!validChars.IsMatch(productName))
            {
                Error += "Product name contains illegal characters.\n";
            }
            else if (productName.Length > 50)
            {
                Error += "Product name cannot be greater than 50 characters.\n";
            }

            // Product price validation
            if (productPrice == "")
            {
                Error += "Product price cannot be empty.\n";
            }
            else if (!double.TryParse(productPrice, out double b))
            {
                Error += "Product price is invalid.\n";
            }
            else if (Convert.ToDouble(productPrice) > 1000000) // max price: 1 million
            {
                Error += "Price is too high.\n";
            }
            else if (Convert.ToDouble(productPrice) <= 0) //price cannot be negative 
            {
                Error += "Price cannot be zero or negative.\n";
            }

            // Model number validation
            if (modelNo == "")
            {
                Error += "Model number cannot be empty.\n";
            }
            else if (!validChars.IsMatch(modelNo))
            {
                Error += "Model number contains illegal characters.\n";
            }
            else if (modelNo.Length > 50)
            {
                Error += "Model number cannot be greater than 50 characters.\n";
            }

            // Release date validation
            if (releaseDate == "")
            {
                Error += "Release date cannot be empty.\n";
            }
            else if (!DateTime.TryParse(releaseDate, out DateTime c)) // checks if date is valid
            {
                Error += "Release date is invalid.\n";
            }


            // Net weight validation
            if (netWeight == "")
            {
                // empty weight is fine
            }
            else if (!double.TryParse(netWeight, out double d))
            {
                Error += "Net weight is invalid.\n";
            }
            else if (Convert.ToDouble(netWeight) > 10000) // max weight: 10000 (kg)
            {
                Error += "Net weight cannot be greater than 10,000kg.\n";
            }
            else if (Convert.ToDouble(netWeight) < 0) // cannot be negative 
            {
                Error += "Net weight cannot be negative.\n";
            }

            // Gross weight validation
            if (grossWeight == "")
            {
                // empty weight is fine
            }
            else if (!double.TryParse(grossWeight, out double e))
            {
                Error += "Gross weight is invalid.\n";
            }
            else if (Convert.ToDouble(grossWeight) > 10000) // max weight: 10000 (kg)
            {
                Error += "Gross weight cannot be greater than 10,000kg.\n";
            }
            else if (Convert.ToDouble(grossWeight) < 0) // cannot be negative 
            {
                Error += "Gross weight cannot be negative.\n";
            }

            // return error report
            return Error;
        }
    }
}
