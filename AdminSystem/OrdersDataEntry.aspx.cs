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
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        //display the order ID on the page
        Response.Write(AnOrder.OrderId);
        //display the shipping method on the page
        Response.Write(AnOrder.ShippingMethod);
        //display the date of order on the page
        Response.Write(AnOrder.DateOrdered);
        //display dispatched on the page
        Response.Write(AnOrder.Dispatched);
    }

    protected void BtnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order id
        //AnOrder.OrderId = txtOrderId.Text;
        //capture the shipping method
        AnOrder.ShippingMethod = txtShippingMethod.Text;
        //capture the date
        //AnOrder.DateOrdered = txtDateOrdered.Text;
        //store the order in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrder.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtShippingMethod.Text = AnOrder.ShippingMethod;
            txtDateOrdered.Text = AnOrder.DateOrdered.ToString();

        }
    }
}