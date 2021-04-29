<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" width="165px"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find Customer" />
        <p>
            <asp:Label ID="lblUsername" runat="server" Text="Username" width="165px"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPassword" runat="server" Text="Password" width="165px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email" width="165px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDateCreated" runat="server" Text="Date Account was Created"></asp:Label>
        <asp:TextBox ID="txtDateCreated" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkActiveAccount" runat="server" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </p>
    </form>
</body>
</html>
