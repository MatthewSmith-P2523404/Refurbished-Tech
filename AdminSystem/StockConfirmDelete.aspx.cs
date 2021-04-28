using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 productId;
    protected void Page_Load(object sender, EventArgs e)
    {
        productId = Convert.ToInt32(Session["productId"]); // get pk from session storage
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // instantiate collection class
        clsStockCollection StockCollection = new clsStockCollection();
        // find record to delete
        StockCollection.ThisItem.Find(productId);
        // delete record
        StockCollection.Delete();
        // redirect to main page
        Response.Redirect("StockList.aspx");
    }



    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}