<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblQuestion" runat="server" Text="Are you sre you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" Text="Yes" Width="39px" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" Text="No" Width="41px" OnClick="btnNo_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
