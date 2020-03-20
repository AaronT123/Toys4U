
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnCustomer.aspx.cs" Inherits="Toys4U_Front_Office.AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="background-color:burlywood">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 580px; top: 130px; position: absolute" Text="Email Address:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 607px; top: 169px; position: absolute; bottom: 476px; margin-top: 1px" Text="Password:"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 600px; position: absolute; top: 207px" Text="First Name:"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 602px; top: 246px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 573px; top: 283px; position: absolute; height: 22px; width: 115px; right: 818px;" Text="Phone Number:"></asp:Label>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 591px; top: 322px; position: absolute; height: 19px; width: 79px; right: 836px;" Text="Post Code:"></asp:Label>
        <asp:Label ID="lblStreetName" runat="server" style="z-index: 1; left: 587px; top: 359px; position: absolute" Text="Street Name:"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 716px; top: 127px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 714px; top: 144px; position: absolute; margin-top: 23px;"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 713px; top: 205px; position: absolute; margin-top: 1px;"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 712px; top: 244px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 710px; top: 281px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 709px; top: 320px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 707px; top: 357px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 730px; top: 443px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
        <asp:Label ID="Label1" runat="server" BorderStyle="Double" Font-Size="XX-Large" style="z-index: 1; left: 622px; top: 44px; position: absolute" Text="Customer Details"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 635px; top: 444px; position: absolute; width: 59px; right: 812px;" Text="OK" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 591px; top: 394px; position: absolute; right: 815px; height: 35px" Text="House No:"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 708px; top: 392px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 613px; top: 505px; position: absolute; height: 19px;"></asp:Label>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 970px; top: 53px; position: absolute; height: 110px; width: 118px" />
   
        </p>
    </form>
</body>
</html>
