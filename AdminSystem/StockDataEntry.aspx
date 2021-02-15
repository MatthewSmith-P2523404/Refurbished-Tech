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
        </div>
        <asp:Label ID="lblProductId" runat="server" Text="Product ID" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductName" runat="server" Text="Product Name" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblProductPrice" runat="server" Text="Product Price" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtProductPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Model Number" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtModelNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Release Date" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtReleaseDate" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Net Weight" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtNetWeight" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Gross Weight" width="94px"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtGrossWeight" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Hidden Item"></asp:Label>
        <asp:CheckBox ID="chkVisibility" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
    </form>
</body>
</html>
