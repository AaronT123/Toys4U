<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeliveryDelete.aspx.cs" Inherits="Toys4U_Front_Office.DeliveryDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblVerify" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Are you sure you want to delete this Delivery?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 12px; top: 45px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 68px; top: 45px; position: absolute" Text="No" />
        <asp:Label ID="lblDeliveryID" runat="server" style="z-index: 1; left: 238px; top: 49px; position: absolute" Text="Blank"></asp:Label>
    </form>
</body>
</html>
