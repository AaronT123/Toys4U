<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADelivery.aspx.cs" Inherits="Toys4U_Front_Office.ADelivery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 372px">
    <form id="form1" runat="server">
        <!-- Order No -->
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 50px; top: 15px; position: absolute" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 125px; top: 15px; position: absolute"></asp:TextBox>
        <!-- House No -->
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 48px; top: 45px; position: absolute" Text="House No"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 125px; top: 45px; position: absolute"></asp:TextBox>
        <!-- Street -->
        <asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 73px; top: 75px; position: absolute" Text="Street"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 125px; top: 75px; position: absolute"></asp:TextBox>
        <!-- Town -->
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 73px; top: 105px; position: absolute" Text="Town"></asp:Label>
        <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 125px; top: 105px; position: absolute"></asp:TextBox>
        <!-- City -->
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 83px; top: 135px; position: absolute" Text="City"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 125px; top: 135px; position: absolute"></asp:TextBox>
        <!-- Postcode -->
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 52px; top: 165px; position: absolute" Text="Postcode"></asp:Label>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 125px; top: 165px; position: absolute"></asp:TextBox>
        <!-- Date Added -->
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 34px; top: 195px; position: absolute" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 125px; top: 195px; position: absolute"></asp:TextBox>
        <!-- Date Estimated -->
        <asp:Label ID="lblDateEstimated" runat="server" style="z-index: 1; left: 15px; top: 225px; position: absolute" Text="Date Estimated"></asp:Label>
        <asp:TextBox ID="txtDateEstimated" runat="server" style="z-index: 1; left: 125px; top: 225px; position: absolute"></asp:TextBox>
        <!-- Other Controls -->
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 125px; top: 255px; position: absolute" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 192px; top: 255px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 297px; position: absolute"></asp:Label>
    </form>
</body>
</html>
