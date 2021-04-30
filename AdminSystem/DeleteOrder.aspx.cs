using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of orders to be deleted from the session object
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of order
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to delete
        Order.ThisOrder.Find(OrderId);
        //delete the record
        Order.Delete();
        //redirect to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}