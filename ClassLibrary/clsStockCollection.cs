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
            clsDataConnection DB = new clsDataConnection();
            // exec stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            // populate array
            PopulateArray(DB);
        
        }

        public int Add()
        {
            // adds a new record to the database based on ThisStock
            // init db connection
            clsDataConnection DB = new clsDataConnection();
            // set params for stored procedure
            //DB.AddParameter("@productId", mThisItem.productId);
            DB.AddParameter("@productName", mThisItem.productName);
            DB.AddParameter("@productPrice", mThisItem.productPrice);
            DB.AddParameter("@modelNo", mThisItem.modelNo);
            DB.AddParameter("@releaseDate", mThisItem.releaseDate);
            DB.AddParameter("@netWeight", mThisItem.netWeight);
            DB.AddParameter("@grossWeight", mThisItem.grossWeight);
            DB.AddParameter("@visible", mThisItem.visible);
            // execute stored procedure returning pk value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update() // update database record based on primary key
        {
            // connect to db
            clsDataConnection DB = new clsDataConnection();
            // set params for stored procedure
            DB.AddParameter("@productId", mThisItem.productId);
            DB.AddParameter("@productName", mThisItem.productName);
            DB.AddParameter("@productPrice", mThisItem.productPrice);
            DB.AddParameter("@modelNo", mThisItem.modelNo);
            DB.AddParameter("@releaseDate", mThisItem.releaseDate);
            DB.AddParameter("@netWeight", mThisItem.netWeight);
            DB.AddParameter("@grossWeight", mThisItem.grossWeight);
            DB.AddParameter("@visible", mThisItem.visible);
            // execute stored procedure returning pk value
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete() // delete an item based on primary key
        {
            // connect to db
            clsDataConnection DB = new clsDataConnection();
            // set params for stored procedure
            DB.AddParameter("@productId", mThisItem.productId);
            // execute stored proecedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void FilterByMaxPrice(double productPrice)
        {
            // filters records by all equal to or less than specified price
            
            // connect to db
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@productPrice", productPrice);
            // exec stored procedure
            DB.Execute("sproc_tblStock_FilterByMaxPrice");
            // populate array list with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // index and record counter
            Int32 i = 0;
            Int32 RecordCount = DB.Count;
            // clear private array list
            mStockList = new List<clsStock>();
            // while there are new records to process
            while (i < RecordCount)
            {
                // populates array based on data dable in parameter DB
                clsStock AnItem = new clsStock(); //instantiate class
                                                  // retrieve details from current record
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
