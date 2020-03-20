<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeliveryDelete.aspx.cs" Inherits="Toys4U_Front_Office.DeliveryDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblVerify" runat="server" style="z-index: 1; left: 15px; top: 65px; position: absolute" Text="Are you sure you want to delete this Delivery?" Font-Names="Calibri"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 15px; top: 100px; position: absolute; width: 50px;" Text="Yes" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 100px; top: 100px; position: absolute; width: 50px;" Text="No" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
        <asp:Label ID="lblDeleteDelivery" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 15px; top: 15px; position: absolute" Text="Delete Delivery"></asp:Label>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 350px; top: 15px; position: absolute; height: 100px; width: 100px" />
    </form>
</body>
</html>
