<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 413px;
        }
    </style>
</head>
<body style="height: 413px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomersList" runat="server" Height="266px" Width="257px"></asp:ListBox>
            <br />
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <br />
        <asp:Label ID="lblEnterUsername" runat="server" Text="Enter a username"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="margin-left: 11px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click1" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
