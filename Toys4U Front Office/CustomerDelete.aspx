<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDelete.aspx.cs" Inherits="Toys4U_Front_Office.CustomerDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="background-color:burlywood">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 542px; top: 157px; position: absolute" Text="Are you sure want to delete this Customer?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 593px; top: 207px; position: absolute" Text="Yes" OnClick="btnYes_Click1" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White"/>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 718px; top: 205px; position: absolute" Text="No" OnClick="btnNo_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White"/>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 877px; top: 82px; position: absolute; height: 110px; width: 118px" />
   
        </p>
        <asp:Label ID="lblDeleteCustomer" runat="server" style="z-index: 1; left: 565px; top: 48px; position: absolute" Text="Delete Customer" Font-Size="XX-Large" BorderStyle="Double"></asp:Label>
    </form>
</body>
</html>
