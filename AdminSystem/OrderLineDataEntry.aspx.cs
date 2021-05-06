using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display current data for the record
                DisplayOrderLine();
            }
        }
    }
    void DisplayOrderLine()
    {
        //create an instance of the order
        clsOrderLineCollection OrderLine = new clsOrderLineCollection();
        //find the record to update
        OrderLine.ThisOrderLine.Find(OrderID);
        //display the data for this record
        txtOrderId.Text = OrderLine.ThisOrderLine.OrderId.ToString();
        txtProductId.Text = OrderLine.ThisOrderLine.ProductId;
        txtPrice.Text = OrderLine.ThisOrderLine.Price.ToString();
        txtQuantity.Text = OrderLine.ThisOrderLine.Quantity.ToString();
        chkAvailable.Checked = OrderLine.ThisOrderLine.Available;
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create new instance of the class
        clsOrderLine AnOrderLine = new clsOrderLine();
        string OrderId = txtOrderId.Text;
        string ProductId = txtProductId.Text;
        string Price = txtPrice.Text;
        string Quantity = txtQuantity.Text;
        //var for error messages
        string Error = "";
        //validate the data
        Error = AnOrderLine.Valid(ProductId, Price, Quantity);
        if (Error == "")
        {
            //capture the order id
            AnOrderLine.OrderId = this.OrderID;
            //capture the product id
            AnOrderLine.ProductId = ProductId;
            //capture the price
            AnOrderLine.Price = Convert.ToDouble(Price);
            //capture the quantity
            AnOrderLine.Quantity = Convert.ToInt32(Quantity);
            //capture available
            AnOrderLine.Available = chkAvailable.Checked;
            //store the order in the session object
            Session["AnOrder"] = AnOrderLine;
            //navigate to the viewer page
            Response.Write("OrderLineViewer.aspx");

            //create new instance of the order collection
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            if (this.OrderID == -1)
            {
                //set the ThisOrder property
                OrderLineList.ThisOrderLine = AnOrderLine;
                //add the new record
                OrderLineList.Add();
            }//otherwise it must be an update
            else
            {
                //find the record to update
                OrderLineList.ThisOrderLine.Find(OrderID);
                //set the ThisOrder property
                OrderLineList.ThisOrderLine = AnOrderLine;
                //update the record
                OrderLineList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrderLine
        clsOrderLine AnOrderLine = new clsOrderLine();
        //variable to store the primary key
        Int32 OrderId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //find the record
        Found = AnOrderLine.Find(OrderId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProductId.Text = AnOrderLine.ProductId;
            txtPrice.Text = AnOrderLine.Price.ToString();
            txtQuantity.Text = AnOrderLine.Quantity.ToString();
        }
    }
}