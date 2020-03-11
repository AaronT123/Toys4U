<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDelete.aspx.cs" Inherits="Toys4U_Front_Office.ProductDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 15px; top: 79px; position: absolute; width: 314px" Text="Are you sure you want to delete this product?"></asp:Label>
        <asp:Button ID="BtnYes" runat="server" OnClick="BtnYes_Click" style="z-index: 1; left: 59px; top: 133px; position: absolute; right: 488px" Text="Yes" />
        <asp:Button ID="BtnNo" runat="server" style="z-index: 1; top: 133px; position: absolute; left: 165px; height: 25px; width: 41px" Text="No" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 262px; top: 217px; position: absolute; height: 32px; width: 101px"></asp:Label>
    </form>
</body>
</html>
