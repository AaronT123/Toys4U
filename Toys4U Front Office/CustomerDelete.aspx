<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDelete.aspx.cs" Inherits="Toys4U_Front_Office.CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 67px; top: 79px; position: absolute" Text="Are you sure want to delete this Customer?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 76px; top: 137px; position: absolute" Text="Yes" OnClick="btnYes_Click1" />
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 139px; top: 137px; position: absolute" Text="No" />
    </form>
</body>
</html>
