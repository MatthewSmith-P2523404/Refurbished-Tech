using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // checks if this is the first time the page is loaded
        if (IsPostBack == false)
        {
            DisplayStock(); // call method to populate list with stock
        }
        
    }
    void DisplayStock()
    {
        clsStockCollection Inventory = new clsStockCollection(); // instantiate class
        // set data source to list of products
        lstStockList.DataSource = Inventory.StockList;
        //set name of PK
        lstStockList.DataValueField = "productId";
        //set data field to display
        lstStockList.DataTextField = "productName";
        // bind data to list
        lstStockList.DataBind();
        }
}