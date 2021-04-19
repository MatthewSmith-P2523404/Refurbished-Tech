using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //var to store the primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the num of orders to pe processed
        OrderID = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display current data for the record
                DisplayOrder();
            }
        }
        /*/create anew instance of the class
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
        */
    }
    void DisplayOrder()
    {
        //create an instance of the order
        clsOrderCollection Order = new clsOrderCollection();
        //find the record to update
        Order.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderId.Text = Order.ThisOrder.OrderId.ToString();
        txtShippingMethod.Text = Order.ThisOrder.ShippingMethod;
        txtDateOrdered.Text = Order.ThisOrder.DateOrdered.ToString();
        chkDispatched.Checked = Order.ThisOrder.Dispatched;
    }

    protected void BtnOK_Click1(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order id
        string OrderID = txtOrderId.Text;
        //capture the shipping method
        string ShippingMethod = txtShippingMethod.Text;
        //capture the date
        string DateOrdered = txtDateOrdered.Text;
        //var for error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(ShippingMethod, DateOrdered);
        if (Error == "")
        {
            //capture the order id
            AnOrder.OrderId = this.OrderID;
            //capture the shipping method
            AnOrder.ShippingMethod = ShippingMethod;
            //capture the date
            AnOrder.DateOrdered = Convert.ToDateTime(DateOrdered);
            //capture dispatched
            AnOrder.Dispatched = chkDispatched.Checked;
            //store the order in the session object
            //Session["AnOrder"] = AnOrder;
            //navigate to the viewer page
            //Response.Write("OrdersViewer.aspx");

            //create new instance of the order collection
            clsOrderCollection OrderList = new clsOrderCollection();
            if (this.OrderID == -1)
            {
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }//otherwise it must be an update
            else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderID);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display error message
            Label1.Text = Error;
        }
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
