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

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // instantiate stock item
        clsStock AnItem = new clsStock();

        // fetch data from forms for each field

        string productId = txtProductId.Text;
        string productName = txtProductName.Text;
        string productPrice = txtProductPrice.Text;
        string modelNo = txtModelNo.Text;
        string releaseDate = txtReleaseDate.Text;
        string netWeight = txtNetWeight.Text;
        string grossWeight = txtGrossWeight.Text;
        string Error = "";

        Error = AnItem.Valid(productId, productName, productPrice, modelNo, releaseDate, netWeight, grossWeight, "true");

        if (Error == "")
        {
            AnItem.productId = Convert.ToInt32(txtProductId.Text);
            AnItem.productName = txtProductName.Text;
            AnItem.productPrice = Convert.ToDouble(txtProductPrice.Text);
            AnItem.modelNo = txtModelNo.Text;
            AnItem.releaseDate = Convert.ToDateTime(txtReleaseDate.Text);
            AnItem.netWeight = Convert.ToDouble(txtNetWeight.Text);
            AnItem.grossWeight = Convert.ToDouble(txtGrossWeight.Text);
            AnItem.visible = chkVisibility.Checked;

            // create a session for the instantiated class
            Session["AnItem"] = AnItem;

            // navigate to the stock viewer page
            Response.Redirect("StockViewer.aspx");

            
        } else
        {
            lblError.Text = Error;
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
}