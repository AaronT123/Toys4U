<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnProduct.aspx.cs" Inherits="Toys4U_Front_Office.AnProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductID" runat="server" Text="ProductID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 632px; top: 65px; position: absolute; height: 94px; width: 94px" />
   
        <p>
            <asp:Label ID="lblStockQuantity" runat="server" Text="StockQuantity"></asp:Label>
            <asp:TextBox ID="txtStockquantity" runat="server"></asp:TextBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 271px; top: 214px; position: absolute; height: 18px; width: 211px"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
