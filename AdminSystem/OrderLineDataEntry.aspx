<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" width="79px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="margin-left: 50px"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductId" runat="server" Text="Product ID" width="95px"></asp:Label>
            <asp:TextBox ID="txtProductId" runat="server" style="margin-left: 34px" Width="160px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="79px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 51px"></asp:TextBox>
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="79px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" style="margin-left: 51px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" width="79px" />
            <br />
        </div>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" Width="36px" />
        <asp:Button ID="btnCancel" runat="server" style="margin-left: 15px" Text="Cancel" />
    </form>
</body>
</html>
