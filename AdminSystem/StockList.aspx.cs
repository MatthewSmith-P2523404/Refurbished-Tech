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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into session object to indicate it's a new record
        Session["productId"] = -1;
        // redirect to entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // var to store PK value of record to be edited
        Int32 productId;
        // if record selected
        if (lstStockList.SelectedIndex != -1)
        {
            // get PK value of record to edit
            productId = Convert.ToInt32(lstStockList.SelectedValue);
            // store data in session object
            Session["productId"] = productId;
            // redirect to edit page
            Response.Redirect("StockDataEntry.aspx");
        } else // display an error if user tries to delete nothing
        {
            lblError.Text = "No item selected.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store PK value of record to be edited
        Int32 productId;
        // if record selected
        if (lstStockList.SelectedIndex != -1)
        {
            // get PK value of record to delete
            productId = Convert.ToInt32(lstStockList.SelectedValue);
            // store data in session object
            Session["productId"] = productId;
            // redirect to edit page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else // display an error if user tries to delete nothing
        {
            lblError.Text = "No item selected.";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        Double tmp; // workaround for tryparse validation
        bool valid = Double.TryParse(txtMaxPriceFilter.Text, out tmp); //check value is valid
        // instantiate class
        clsStockCollection Stock = new clsStockCollection();
        if (valid == false)
        {
            lblError.Text = "Invalid filter entered."; // error message
        }
        else if (tmp > 10000 || tmp < 0)
        {
            lblError.Text = "Invalid filter. Must be between 0 and 10000."; // another error
        }
        else
        {
            // Writing comments for the exact same code over and over is raising my blood pressure
            // so I'm not going to anymore
            // you know the drill by now
            Stock.FilterByMaxPrice(Convert.ToDouble(txtMaxPriceFilter.Text));

            lstStockList.DataSource = Stock.StockList;

            lstStockList.DataValueField = "productId";

            lstStockList.DataTextField = "productName";

            lstStockList.DataBind();
        }
        
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // instantiate class
        clsStockCollection Stock = new clsStockCollection();
        Stock.FilterByMaxPrice(10000);

        txtMaxPriceFilter.Text = "";

        lstStockList.DataSource = Stock.StockList;

        lstStockList.DataValueField = "productId";

        lstStockList.DataTextField = "productName";

        lstStockList.DataBind();
    }

}
