using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisItem = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                // return the private data
                return mStockList;
            }
            set
            {
                // set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                // return the private data
                return mStockList.Count;
            }
            set
            {
                //
            }
        }
        public clsStock ThisItem
        {
            get
            {
                // return the private data
                return mThisItem;
            }
            set
            {
                mThisItem = value;
            }
        }

        // constructor
        public clsStockCollection()
        {
            // index for iterating over stock items
            Int32 i = 0;
            // var to store count of records in DB
            Int32 RecordCount = 0;
            // init database connection
            clsDataConnection DB = new clsDataConnection();
            // exec stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            // get record count
            RecordCount = DB.Count;
            // while loop to iterate over database records
            while (i < RecordCount)
            {
                clsStock AnItem = new clsStock();

                AnItem.productId = Convert.ToInt32(DB.DataTable.Rows[i]["productId"]);
                AnItem.productName = Convert.ToString(DB.DataTable.Rows[i]["productName"]);
                AnItem.productPrice = Convert.ToDouble(DB.DataTable.Rows[i]["productPrice"]);
                AnItem.releaseDate = Convert.ToDateTime(DB.DataTable.Rows[i]["releaseDate"]);
                AnItem.modelNo = Convert.ToString(DB.DataTable.Rows[i]["modelNo"]);
                AnItem.netWeight = Convert.ToDouble(DB.DataTable.Rows[i]["netWeight"]);
                AnItem.grossWeight = Convert.ToDouble(DB.DataTable.Rows[i]["grossWeight"]);
                AnItem.visible = Convert.ToBoolean(DB.DataTable.Rows[i]["visible"]);

                mStockList.Add(AnItem);

                i++;
            }
        }

    }
}
