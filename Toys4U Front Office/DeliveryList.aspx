<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeliveryList.aspx.cs" Inherits="Toys4U_Front_Office.DeliveryList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 419px">
    <form id="form1" runat="server">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 20px; top: 339px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 78px; top: 339px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 143px; top: 339px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <asp:ListBox ID="lstDelivery" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 176px; width: 309px"></asp:ListBox>
        <div>
        </div>
        <asp:Label ID="lblEnterID" runat="server" style="z-index: 1; left: 15px; top: 227px; position: absolute" Text="Enter A Postcode:"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 17px; top: 288px; position: absolute; width: 100px" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 128px; top: 289px; position: absolute; width: 100px" Text="Display All" OnClick="btnDisplayAll_Click" />
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 14px; top: 254px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 197px; position: absolute"></asp:Label>
    </form>
</body>
</html>
