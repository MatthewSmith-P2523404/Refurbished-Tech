using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if (CustomerId != -1)
            {
                DisplayCustomers();
            }
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerId);
        txtCustomerId.Text = Customers.ThisCustomer.CustomerId.ToString();
        txtUsername.Text = Customers.ThisCustomer.Username;
        txtPassword.Text = Customers.ThisCustomer.Password;
        txtEmail.Text = Customers.ThisCustomer.Email;
        txtDateCreated.Text = Customers.ThisCustomer.DateCreated.ToString();
        chkActiveAccount.Checked = Customers.ThisCustomer.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the data
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        string Email = txtEmail.Text;
        string DateCreated = txtDateCreated.Text;
        string Error = "";
        // validate the data
        Error = ACustomer.Valid(Username, Password, Email, DateCreated);
        if (Error == "")
        {
            //capture the data
            ACustomer.CustomerId = CustomerId;
            ACustomer.Username = Username;
            ACustomer.Password = Password;
            ACustomer.Email = Email;
            ACustomer.DateCreated = Convert.ToDateTime(DateCreated);
            ACustomer.Active = chkActiveAccount.Checked;

            clsCustomerCollection Customers = new clsCustomerCollection();

            if (CustomerId == -1)
            {
                Customers.ThisCustomer = ACustomer;
                Customers.Add();
            }
            else
            {
                Customers.ThisCustomer.Find(CustomerId);
                Customers.ThisCustomer = ACustomer;
                Customers.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerId;
        Boolean Found = false;
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Found = ACustomer.Find(CustomerId);
        if (Found == true)
        {
            txtUsername.Text = ACustomer.Username;
            txtPassword.Text = ACustomer.Password;
            txtEmail.Text = ACustomer.Email;
            txtDateCreated.Text = ACustomer.DateCreated.ToString();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        txtCustomerId.Text = "";
        txtUsername.Text = "";
        txtPassword.Text = "";
        txtEmail.Text = "";
        txtDateCreated.Text = "";
    }
}