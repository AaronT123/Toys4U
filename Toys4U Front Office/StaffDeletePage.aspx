<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffDeletePage.aspx.cs" Inherits="Toys4U_Front_Office.StaffDeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this staff?"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </p>
    </form>
</body>
</html>
