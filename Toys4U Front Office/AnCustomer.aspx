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
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 75px; top: 60px; position: absolute" Text="Email Address:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 74px; top: 91px; position: absolute; bottom: 751px; margin-top: 1px" Text="Password:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 70px; position: absolute; top: 130px" Text="First Name:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 74px; top: 167px; position: absolute" Text="Last Name:"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 58px; top: 215px; position: absolute; height: 22px;" Text="Phone Number:"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 73px; top: 251px; position: absolute; height: 19px; width: 68px;" Text="Post Code:"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 70px; top: 290px; position: absolute" Text="Street Name:"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 180px; top: 61px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 174px; top: 96px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 170px; top: 135px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 170px; top: 172px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 168px; top: 212px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 169px; top: 250px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStreetName" runat="server" style="z-index: 1; left: 167px; top: 292px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 186px; top: 25px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label" runat="server" style="z-index: 1; left: 90px; top: 23px; position: absolute" Text="Customer ID:"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 136px; top: 443px; position: absolute" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 95px; top: 442px; position: absolute" Text="OK" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 84px; top: 330px; position: absolute; right: 1360px; height: 16px" Text="House No:"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 161px; top: 333px; position: absolute"></asp:TextBox>
        <p>
        <asp:Label ID="lblError0" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
        <p>
        <asp:Label ID="lblError1" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblError2" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblError3" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblError4" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblError5" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblError6" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblError7" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Label ID="lblError8" runat="server" style="z-index: 1; left: 85px; top: 399px; position: absolute" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
