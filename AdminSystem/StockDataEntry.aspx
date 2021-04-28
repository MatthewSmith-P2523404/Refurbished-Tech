<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 329px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Add or Edit Inventory</strong></div>
        <asp:Label ID="lblProductId" runat="server" Text="Product ID" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Search Product ID" />
        <br />
        <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductPrice" runat="server" Text="Product Price" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblModelNumber" runat="server" Text="Model No." width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtModelNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblReleaseDate" runat="server" Text="Release Date" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNetWeight" runat="server" Text="Net Weight" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtNetWeight" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblGrossWeight" runat="server" Text="Gross Weight" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtGrossWeight" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblHiddenItem" runat="server" Text="Visible On Store?"></asp:Label>
        <asp:CheckBox ID="chkVisibility" runat="server" Checked="True" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <asp:Button ID="btnCancel" runat="server" Text="Back" OnClick="btnCancel_Click" />
        <br />
    </form>
</body>
</html>
