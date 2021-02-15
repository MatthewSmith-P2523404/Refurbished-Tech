using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AnItem = new clsStock();

        AnItem = (clsStock)Session["AnItem"];

        Response.Write(AnItem.productID);
        Response.Write(AnItem.productName);
        Response.Write(AnItem.productPrice);
        Response.Write(AnItem.modelNo);
        Response.Write(AnItem.releaseDate);
        Response.Write(AnItem.netWeight);
        Response.Write(AnItem.grossWeight);
        Response.Write(AnItem.visible);

    }
}