<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDeletePage.aspx.cs" Inherits="Toys4U_Front_Office.CustomerDeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 43px; top: 188px; position: absolute" Text="Yes" OnClick="btnYes_Click" />
        </p>
        <p>
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 241px; top: 190px; position: absolute" Text="No" />
        </p>
    </form>
</body>
</html>
