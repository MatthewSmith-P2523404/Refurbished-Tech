using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();

        aStaff = (clsStaff)Session["aStaff"];

        Response.Write("Staff ID: "+ aStaff.StaffID + "; Name: " + aStaff.StaffName + "; Address: " + aStaff.StaffAddress
            + "; Start Date: " + aStaff.StartDate + "; Salary: " + "£" +  aStaff.Salary
            + "; Manager role: " + aStaff.Manager);
    }
}