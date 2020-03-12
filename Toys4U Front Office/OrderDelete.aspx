<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDelete.aspx.cs" Inherits="Toys4U_Front_Office.OrderDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOK" runat="server" style="z-index: 1; left: 39px; top: 42px; position: absolute" Text="Are you sure you want to delete this order?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 31px; top: 78px; position: absolute; width: 50px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 127px; top: 79px; position: absolute; width: 52px" Text="No" />
    </form>
</body>
</html>
