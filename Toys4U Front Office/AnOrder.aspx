<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnOrder.aspx.cs" Inherits="Toys4U_Front_Office.AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 600px; top: 10px; position: absolute; height: 94px; width: 94px" />
   
            <asp:Label ID="lblTitle" runat="server" Font-Bold="True" Font-Size="30pt" Font-Underline="True" ForeColor="#3366CC" style="z-index: 1; left: 284px; top: 13px; position: absolute; bottom: 606px" Text="Toys 4U"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 289px; top: 156px; position: absolute; right: 453px;" Text="Order ID" Font-Bold="True" ForeColor="#3366CC"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 420px; top: 154px; position: absolute" Font-Bold="False"></asp:TextBox>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 289px; top: 184px; position: absolute" Text="Order Date" Font-Bold="True" ForeColor="#3366CC"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 420px; top: 182px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 289px; top: 212px; position: absolute" Text="Customer Number" Font-Bold="True" ForeColor="#3366CC"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 420px; top: 211px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 288px; top: 238px; position: absolute" Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 288px; top: 269px; position: absolute; width: 128px; right: 1114px;" Text="OK" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 556px; top: 270px; position: absolute; width: 128px;" Text="Cancel" BackColor="#3366CC" Font-Bold="True" ForeColor="White" />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20pt" ForeColor="#3366CC" style="z-index: 1; left: 285px; top: 81px; position: absolute" Text="Order Information"></asp:Label>
    </form>
</body>
</html>
