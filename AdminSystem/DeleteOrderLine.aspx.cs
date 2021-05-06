using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteOrderLine : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        OrderLines.ThisOrderLine.Find(OrderId);
        OrderLines.Delete();
        Response.Redirect("OrderLineList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLineList.aspx");
    }
}