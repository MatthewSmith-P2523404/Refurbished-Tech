<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    This is the order entry page
        <div>
            <asp:Label ID="OrderId" runat="server" height="22px" Text="Order ID" width="135px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" style="margin-left: 15px"></asp:TextBox>
            <br />
            <asp:Label ID="ShippingMethod" runat="server" Text="Shipping Method"></asp:Label>
            <asp:TextBox ID="txtShippingMethod" runat="server" style="margin-left: 42px"></asp:TextBox>
            <br />
            <asp:Label ID="DateOrdered" runat="server" height="22px" Text="Date of Order" width="135px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDateOrdered" runat="server" style="margin-left: 37px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkDispatched" runat="server" Text="Dispatched" Visible="False" />
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="White" Text="lblerror"></asp:Label>
            <br />
            <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click1" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
