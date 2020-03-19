<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnOrderLine.aspx.cs" Inherits="Toys4U_Front_Office.AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 16px; top: 41px; position: absolute; height: 19px; width: 68px" Text="Product ID"></asp:Label>
        </div>
        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 100px; top: 39px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 99px; top: 73px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 17px; top: 74px; position: absolute" Text="Quantity"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 110px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 140px; position: absolute; width: 58px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 73px; top: 140px; position: absolute; width: 58px" Text="Cancel" />
    </form>
</body>
</html>
