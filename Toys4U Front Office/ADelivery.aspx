<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADelivery.aspx.cs" Inherits="Toys4U_Front_Office.ADelivery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 616px">
    <form id="form1" runat="server">

        <!-- Order No -->
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 0px; top: 75px; position: absolute; bottom: 663px; width: 110px; text-align: right;" Text="Order ID:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 115px; top: 75px; position: absolute"></asp:TextBox>
        <!-- House No -->
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 0px; top: 110px; position: absolute; width: 110px; text-align: right;" Text="House No:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 115px; top: 110px; position: absolute"></asp:TextBox>
        <!-- Street -->
        <asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 0px; top: 145px; position: absolute; bottom: 588px; width: 110px; text-align: right;" Text="Street:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 115px; top: 145px; position: absolute"></asp:TextBox>
        <!-- Town -->
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 0px; top: 180px; position: absolute; width: 110px; text-align: right;" Text="Town:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 115px; top: 180px; position: absolute"></asp:TextBox>
        <!-- City -->
        <asp:Label ID="lblCity" runat="server" style="z-index: 1; left: 300px; top: 75px; position: absolute; height: 24px; width: 110px; text-align: right;" Text="City:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server" style="z-index: 1; left: 415px; top: 75px; position: absolute"></asp:TextBox>
        <!-- Postcode -->
        <asp:Label ID="lblPostcode" runat="server" style="z-index: 1; left: 300px; top: 110px; position: absolute; width: 110px; text-align: right;" Text="Postcode:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:TextBox ID="txtPostcode" runat="server" style="z-index: 1; left: 415px; top: 110px; position: absolute"></asp:TextBox>
        <!-- Date Added -->
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 300px; top: 145px; position: absolute; width: 110px; text-align: right;" Text="Date Added:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 415px; top: 145px; position: absolute; width: 160px" TextMode="Date"></asp:TextBox>
        <!-- Date Estimated -->
        <asp:Label ID="lblDateEstimated" runat="server" style="z-index: 1; left: 300px; top: 180px; position: absolute; width: 110px; text-align: right;" Text="Date Estimated:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
        <asp:TextBox ID="txtDateEstimated"  runat="server" style="z-index: 1; left: 415px; top: 180px; position: absolute; width: 160px" TextMode="Date"></asp:TextBox>
        <!-- Other Controls -->
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 115px; top: 215px; position: absolute; width:100px;" Text="OK" OnClick="btnOK_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 250px; top: 215px; position: absolute; width:100px;" Text="Cancel" OnClick="btnCancel_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White"/>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 115px; top: 250px; position: absolute; height: 20px;" Font-Bold="True" Font-Names="Calibri" ForeColor="Red"></asp:Label>
        <asp:Label ID="lblDeliveryDetails" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 25px; top: 25px; position: absolute" Text="Delivery Details"></asp:Label>
        <asp:Image ID="imgBear" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 600px; top: 75px; position: absolute; height: 125px; width: 125px" />
    </form>
</body>
</html>
