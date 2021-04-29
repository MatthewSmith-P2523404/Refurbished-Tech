using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        lstCustomersList.DataSource = Customers.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "Username";
        lstCustomersList.DataBind();
    }

    protected void btnApply_Click1(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByUsername(txtFilter.Text);
        lstCustomersList.DataSource = Customers.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "Username";
        lstCustomersList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByUsername("");
        txtFilter.Text = "";
        lstCustomersList.DataSource = Customers.CustomerList;
        lstCustomersList.DataValueField = "CustomerId";
        lstCustomersList.DataTextField = "Username";
        lstCustomersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 to indicate this is async new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;

        if (lstCustomersList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomersList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if (lstCustomersList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomersList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to be edited from the list";
        }
    }
}