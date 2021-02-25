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
    }
}