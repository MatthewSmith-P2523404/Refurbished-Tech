<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirmDeleteItem" runat="server" Text="Are you sure you want to delete this item?"></asp:Label>
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
