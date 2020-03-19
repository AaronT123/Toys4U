<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnOrder.aspx.cs" Inherits="Toys4U_Front_Office.AnOrder" %>

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
            &nbsp;</p>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 14px; top: 54px; position: absolute" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 93px; top: 54px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 12px; top: 90px; position: absolute" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 91px; top: 90px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 12px; top: 124px; position: absolute" Text="Customer Number"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 140px; top: 125px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 158px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 203px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 44px; top: 203px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
