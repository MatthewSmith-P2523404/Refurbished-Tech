<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID number"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="lblStaffName" runat="server" Text="Name" width="125px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffAddress" runat="server" Text="Address" width="125px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStaffAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStartDate" runat="server" Text="StartDate" width="125px"></asp:Label>
&nbsp;<asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSalary" runat="server" Text="Salary" width="125px"></asp:Label>
&nbsp;<asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkManager" runat="server" Text="Manager" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
