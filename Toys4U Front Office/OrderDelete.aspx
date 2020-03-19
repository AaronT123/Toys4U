<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDelete.aspx.cs" Inherits="Toys4U_Front_Office.OrderDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 600px; top: 10px; position: absolute; height: 94px; width: 94px" />
   
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="30pt" Font-Underline="True" ForeColor="#3366CC" style="z-index: 1; left: 284px; top: 13px; position: absolute" Text="Toys 4U"></asp:Label>
            <asp:Label ID="lblOK" runat="server" style="z-index: 1; left: 286px; top: 69px; position: absolute; width: 270px;" Text="Are you sure you want to delete this order?" Font-Bold="True" Font-Size="Larger" ForeColor="#3366CC"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 280px; top: 145px; position: absolute; width: 110px; right: 1140px;" Text="Yes" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 433px; top: 145px; position: absolute; width: 110px" Text="No" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
    </form>
</body>
</html>
