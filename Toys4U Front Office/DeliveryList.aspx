<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeliveryList.aspx.cs" Inherits="Toys4U_Front_Office.DeliveryList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 419px">
    <form id="form1" runat="server">
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 25px; top: 525px; position: absolute" Text="Add" BackColor="#3366CC" Font-Names="Calibri" ForeColor="White" Width="125px" Font-Bold="True" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 175px; top: 525px; position: absolute" Text="Edit" OnClick="btnEdit_Click" BackColor="#3366CC" Font-Names="Calibri" ForeColor="White" Width="125px" Font-Bold="True" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 325px; top: 525px; position: absolute" Text="Delete" OnClick="btnDelete_Click" BackColor="#3366CC" Font-Names="Calibri" ForeColor="White" Width="125px" Font-Bold="True" />
        <asp:ListBox ID="lstDelivery" runat="server" style="z-index: 1; left: 25px; top: 225px; position: absolute; height: 273px; width: 425px" Font-Names="Calibri"></asp:ListBox>
        <div>
        </div>
        <asp:Label ID="lblEnterPostcode" runat="server" style="z-index: 1; left: 25px; top: 100px; position: absolute" Text="Enter A Postcode:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 25px; top: 175px; position: absolute; width: 125px" Text="Apply" OnClick="btnApply_Click" BackColor="#3366CC" Font-Names="Calibri" ForeColor="White" Font-Bold="True" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 175px; top: 175px; position: absolute; width: 125px" Text="Display All" OnClick="btnDisplayAll_Click" BackColor="#3366CC" Font-Names="Calibri" ForeColor="White" Font-Bold="True" />
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 25px; top: 125px; position: absolute; width: 125px;"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 25px; top: 575px; position: absolute" Font-Names="Calibri" ForeColor="Red"></asp:Label>
        <asp:Label ID="lblManageDelivery" runat="server" style="z-index: 1; left: 25px; top: 50px; position: absolute" Text="Manage Deliveries" Font-Bold="True" Font-Names="Calibri" Font-Size="XX-Large" Font-Underline="True"></asp:Label>
        <asp:Image ID="imgBear" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 375px; top: 50px; position: absolute; height: 100px; width: 100px" />
    </form>
</body>
</html>
