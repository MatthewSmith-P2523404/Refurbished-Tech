using System;
using System.Collections.Generic;
using System.Globalization;
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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        string id = txtStaffID.Text;
        aStaff.StaffID = Int32.Parse(id);
        aStaff.StaffName = txtStaffName.Text;
        aStaff.StaffAddress = txtStaffAddress.Text;
      
        //so the string can be converted the dateTime type
        string date = txtStartDate.Text;
        //changes how the date will be formatted
        var dateForm = new CultureInfo("de-DE");
        aStaff.StartDate = DateTime.Parse(date);

        string amount = txtSalary.Text;
        aStaff.Salary = Int32.Parse(amount);

        if (chkManager.Checked)
        {
            aStaff.Manager = true;
        } else
        {
            aStaff.Manager = false;
        }

        Session["aStaff"] = aStaff;

        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }
}