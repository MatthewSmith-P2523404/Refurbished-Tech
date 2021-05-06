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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the listbox
            DisplayOrderLines();
        }
    }
    void DisplayOrderLines()
    {
        //instance of Collection
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        //set data source to the list in the collection
        lstOrderList.DataSource = OrderLines.OrderLineList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the data field to display
        lstOrderList.DataTextField = "ProductId";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderId"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderLineDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the edit page
            Response.Redirect("OrderLineDataEntry.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderId;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderId"] = OrderId;
            //redirect to the delete page
            Response.Redirect("DeleteOrderLine.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        OrderLines.ReportByProductId(txtFilter.Text);
        lstOrderList.DataSource = OrderLines.OrderLineList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        //set the name of the field to display
        lstOrderList.DataTextField = "ProductId";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        OrderLines.ReportByProductId("");
        txtFilter.Text = "";
        lstOrderList.DataSource = OrderLines.OrderLineList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "ProductId";
        lstOrderList.DataBind();
    }
}