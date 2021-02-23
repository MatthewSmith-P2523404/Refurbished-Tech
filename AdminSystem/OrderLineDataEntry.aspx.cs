using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create anew instance of the class
        clsOrderLine AnOrderLine = new clsOrderLine();
        //get the data from the session object
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        //display the product ID on the page
        Response.Write(AnOrderLine.ProductId);
        //display the order ID on the page
        Response.Write(AnOrderLine.OrderId);
        //display the price on the page
        Response.Write(AnOrderLine.Price);
        //display the quantity the page
        Response.Write(AnOrderLine.Quantity);
        //display the availability on the page
        Response.Write(AnOrderLine.Available);

    }
}