<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="217px" Width="255px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="46px" Text="Add" Width="66px" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Height="46px" style="margin-right: 3px" Text="Edit" Width="63px" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Height="46px" Text="Delete" Width="72px" OnClick="btnDelete_Click" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
