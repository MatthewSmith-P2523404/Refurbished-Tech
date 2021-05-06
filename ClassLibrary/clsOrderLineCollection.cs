using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderLineCollection
    {
        //private data members for the list
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        //private data member thisOrder
        clsOrderLine mThisOrderLine = new clsOrderLine();
        //public properties
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                return mOrderLineList;
            }
            set
            {
                mOrderLineList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderLineList.Count;
            }
            set
            {
                //
            }
        }
        public clsOrderLine ThisOrderLine
        {
            get
            {
                return mThisOrderLine;
            }
            set
            {
                mThisOrderLine = value;
            }
        }
        //constructor for the class
        public clsOrderLineCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_SelectAll");
            //populate the array with the data table
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            Int32 Index = 0;
            Int32 RecordCount;
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderLineList = new List<clsOrderLine>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsOrderLine AnOrderLine = new clsOrderLine();
                //read in the fields from the current record
                AnOrderLine.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrderLine.ProductId = Convert.ToString(DB.DataTable.Rows[Index]["ProductId"]);
                AnOrderLine.Price= Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AnOrderLine.Quantity= Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrderLine.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                //add the record to the private data member
                mOrderLineList.Add(AnOrderLine);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the db based on the values of mThisOrder
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductId", mThisOrderLine.ProductId);
            DB.AddParameter("@Price", mThisOrderLine.Price);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            DB.AddParameter("@Available", mThisOrderLine.Available);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblOrderLine_Insert");
        }

        public void Update()
        {
            //update an existing record to the db based on the values of thisOrder
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrderLine.OrderId);
            DB.AddParameter("@ProductId", mThisOrderLine.ProductId);
            DB.AddParameter("@Price", mThisOrderLine.Price);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            DB.AddParameter("@Available", mThisOrderLine.Available);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrderLine_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductId", mThisOrderLine.ProductId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_Delete");
        }

        public void ReportByProductId(string ProductId)
        {
            //filters the records based on a full or partial post code
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            DB.Execute("sproc_tblOrder_FilterByProductId");
            PopulateArray(DB);
        }
    }
}