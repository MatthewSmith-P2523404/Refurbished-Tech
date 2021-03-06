﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 productId;
    protected void Page_Load(object sender, EventArgs e)
    {
        // get product id to be processed
        productId = Convert.ToInt32(Session["productId"]);
        if (IsPostBack == false)
        {
            // if not a new record
            if (productId != -1)
            {
                //display data for record
                DisplayAddress();
            }
        }
    }

    private void DisplayAddress()
    {
        clsStockCollection Inventory = new clsStockCollection(); // instantiate class
        // find record to update
        Inventory.ThisItem.Find(productId);
        // display data for record
        txtProductId.Text = Inventory.ThisItem.productId.ToString();
        txtProductName.Text = Inventory.ThisItem.productName.ToString();
        txtProductPrice.Text = Inventory.ThisItem.productPrice.ToString();
        txtModelNo.Text = Inventory.ThisItem.modelNo.ToString();
        txtReleaseDate.Text = Inventory.ThisItem.releaseDate.ToString();
        txtGrossWeight.Text = Inventory.ThisItem.grossWeight.ToString();
        txtNetWeight.Text = Inventory.ThisItem.netWeight.ToString();
        chkVisibility.Checked = Inventory.ThisItem.visible;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // instantiate stock item
        clsStock AnItem = new clsStock();

        // fetch data from forms for each field

        string productName = txtProductName.Text;
        string productPrice = txtProductPrice.Text;
        string modelNo = txtModelNo.Text;
        string releaseDate = txtReleaseDate.Text;
        string netWeight = txtNetWeight.Text;
        string grossWeight = txtGrossWeight.Text;
        bool visible = chkVisibility.Checked;
        string Error = "";

        Error = AnItem.Valid(productName, productPrice, modelNo, releaseDate, netWeight, grossWeight, "true");

        if (Error == "") // if error string is blank we know the data validated correctly
        {
            // grab data 
            
            AnItem.productName = productName;
            AnItem.productPrice = Convert.ToDouble(productPrice);
            AnItem.modelNo = modelNo;
            AnItem.releaseDate = Convert.ToDateTime(releaseDate);
            AnItem.netWeight = Convert.ToDouble(netWeight);
            AnItem.grossWeight = Convert.ToDouble(grossWeight);
            AnItem.visible = visible;

            // instantiate stock collection
            clsStockCollection StockList = new clsStockCollection();

            // if a new record then add the data 
            if (Convert.ToInt32(productId) == -1)
            {
                // set thisstock property
                StockList.ThisItem = AnItem;
                // add record
                StockList.Add();
            } else // it must be an update 
            {
                // find record to update
                StockList.ThisItem.Find(Convert.ToInt32(productId));
                // set thisitem property
                StockList.ThisItem = AnItem;
                // update record
                StockList.Update();
            }

            // navigate to the stock viewer page
            Response.Redirect("StockList.aspx");        
        } else
        {
            lblError.Text = Error; // show any errors if present
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // instantiate stock class
        clsStock item = new clsStock();

        // primary key
        Int32 productId;

        // bool to store found status
        Boolean found = false;

        // temporary solution to not crash the program if non-integer productId is given
        Int32.TryParse(txtProductId.Text, out productId);

        // try find the item
        found = item.Find(productId);

        // if item found, insert item details into textboxes, else throw an error
        if (found == true)
        {
            txtProductName.Text = item.productName;
            txtModelNo.Text = item.modelNo;
            txtGrossWeight.Text = item.grossWeight.ToString();
            txtNetWeight.Text = item.netWeight.ToString();
            txtProductName.Text = item.productName;
            txtProductPrice.Text = item.productPrice.ToString();
            txtReleaseDate.Text = item.releaseDate.ToString();

            chkVisibility.Checked = item.visible;

            // clear any existing error messages
            lblError.Text = "";
        }
        else
        {
            // throw error message
            lblError.Text = "ERROR: Product ID \"" + productId + "\" not found.";

            // reset forms if searched item does not exist
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtModelNo.Text = "";
            txtGrossWeight.Text = "";
            txtNetWeight.Text = "";
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtReleaseDate.Text = "";
            chkVisibility.Checked = false;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // navigate to stock list page
        Response.Redirect("StockList.aspx");
    }
}