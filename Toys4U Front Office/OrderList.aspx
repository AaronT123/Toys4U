<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="Toys4U_Front_Office.OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 289px; top: 144px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 289px; top: 117px; position: absolute" Text="Filter by Order ID:" Font-Bold="True" ForeColor="#3366CC"></asp:Label>
        </div>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 288px; top: 174px; position: absolute; width: 120px" Text="Apply Filter" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
        <asp:Button ID="btnDisplay" runat="server" style="z-index: 1; left: 458px; top: 174px; position: absolute; width: 120px" Text="Display All" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 289px; top: 362px; position: absolute; width: 125px" Text="Add new order" OnClick="btnAdd_Click" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 426px; top: 362px; position: absolute; width: 125px" Text="Edit" OnClick="btnEdit_Click" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 563px; top: 362px; position: absolute; width: 125px" Text="Delete" OnClick="btnDelete_Click" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 289px; top: 334px; position: absolute; height: 19px;" Font-Bold="True" ForeColor="Red"></asp:Label>
            <asp:ListBox ID="lstOrders" runat="server" style="z-index: 1; left: 288px; top: 205px; position: absolute; height: 122px; width: 401px" OnSelectedIndexChanged="lstOrders_SelectedIndexChanged"></asp:ListBox>
            <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 600px; top: 10px; position: absolute; height: 94px; width: 94px" />
   
            </p>
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="30pt" Font-Underline="True" ForeColor="#3366CC" style="z-index: 1; left: 284px; top: 13px; position: absolute" Text="Toys 4U"></asp:Label>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20pt" ForeColor="#3366CC" style="z-index: 1; left: 287px; top: 74px; position: absolute" Text="Order Page"></asp:Label>
    </form>
</body>
</html>
