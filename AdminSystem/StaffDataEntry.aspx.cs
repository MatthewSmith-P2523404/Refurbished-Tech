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
        /* clsStaff aStaff = new clsStaff();
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
         }*/

        clsStaff AStaff = new clsStaff();
        string StaffID = txtStaffID.Text;
        string StaffName = txtStaffName.Text;
        string StaffAddress = txtStaffAddress.Text;
        string StartDate = txtStartDate.Text;
        string Salary = txtSalary.Text;


        string Error = "";
        Error = AStaff.Valid(StaffName, StaffAddress, StartDate, Salary);

        if (Error == "")
        {
            AStaff.StaffName = StaffName;
            AStaff.StaffAddress = StaffAddress;
            AStaff.StartDate = Convert.ToDateTime(StartDate);
            AStaff.Salary = Convert.ToDouble(Salary);
            if (chkManager.Checked)
            {
                AStaff.Manager = true;
            }
            else
            {
                AStaff.Manager = false;
            }

            Session["AStaff"] = AStaff;
            Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffID;
        Boolean found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);

        found = AStaff.Find(StaffID);
        if (found == true)
        {
            txtStaffName.Text = AStaff.StaffName;
            txtStaffAddress.Text = AStaff.StaffAddress;
            txtStartDate.Text = AStaff.StartDate.ToString();
            txtSalary.Text = AStaff.Salary.ToString();
        }
        
        
    }
}