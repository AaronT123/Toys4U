
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnCustomer.aspx.cs" Inherits="Toys4U_Front_Office.AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 70px; top: 47px; position: absolute" Text="Email Address:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 84px; top: 78px; position: absolute; bottom: 568px; margin-top: 1px" Text="Password:"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 75px; position: absolute; top: 112px" Text="First Name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 75px; top: 149px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 39px; top: 185px; position: absolute; height: 22px; width: 115px; right: 1192px;" Text="Phone Number:"></asp:Label>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 62px; top: 228px; position: absolute; height: 19px; width: 79px; right: 1205px;" Text="Post Code:"></asp:Label>
        <asp:Label ID="lblStreetName" runat="server" style="z-index: 1; left: 67px; top: 269px; position: absolute" Text="Street Name:"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 172px; top: 46px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 172px; top: 55px; position: absolute; margin-top: 23px;"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 170px; top: 114px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 171px; top: 150px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 170px; top: 191px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 168px; top: 226px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 168px; top: 268px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 221px; top: 431px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 135px; top: 431px; position: absolute; width: 59px; right: 1152px;" Text="OK" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 69px; top: 307px; position: absolute; right: 1187px; height: 35px" Text="House No:"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 166px; top: 304px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 84px; top: 369px; position: absolute; height: 19px;"></asp:Label>
    </form>
</body>
</html>
