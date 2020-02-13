<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnStaff.aspx.cs" Inherits="Toys4U_Front_Office.AnStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBoxDateJoined" runat="server" style="z-index: 1; left: 214px; top: 102px; position: absolute; bottom: 544px;"></asp:TextBox>
        <asp:TextBox ID="TextBoxDateOfBirth" runat="server" style="z-index: 1; left: 214px; top: 138px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="TextBoxEmail" runat="server" style="z-index: 1; left: 214px; top: 184px; position: absolute"></asp:TextBox>
            <asp:CheckBox ID="CheckBoxAdmin" runat="server" style="z-index: 1; left: 214px; top: 64px; position: absolute" Text="Admin?" />
        </p>
        <asp:TextBox ID="TextBoxHourlyPay" runat="server" style="z-index: 1; left: 214px; top: 271px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxLastName" runat="server" style="z-index: 1; left: 214px; top: 352px; position: absolute; bottom: 303px"></asp:TextBox>
        <asp:TextBox ID="TextBoxPassword" runat="server" style="z-index: 1; left: 214px; top: 382px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxPhoneNumber" runat="server" style="z-index: 1; left: 214px; top: 423px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBoxStaffID" runat="server" style="z-index: 1; left: 214px; top: 470px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 136px; top: 102px; position: absolute" Text="Date Joined"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:TextBox ID="TextBoxFirstName" runat="server" style="z-index: 1; left: 214px; top: 232px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBoxJobTitle" runat="server" style="z-index: 1; left: 214px; top: 316px; position: absolute; height: 22px;"></asp:TextBox>
        <p>
            <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; left: 286px; top: 516px; position: absolute" Text="Cancel" />
        </p>
        <p>
            <asp:Button ID="ButtonOK" runat="server" style="z-index: 1; left: 216px; top: 516px; position: absolute" Text="OK" OnClick="ButtonOK_Click" />
        </p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 128px; top: 136px; position: absolute" Text="Date Of Birth"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 165px; top: 186px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 140px; top: 232px; position: absolute; height: 20px" Text="First Name"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 139px; top: 270px; position: absolute" Text="Hourly Pay"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 151px; top: 321px; position: absolute; bottom: 328px" Text="Job Title"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 143px; top: 354px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 144px; top: 382px; position: absolute" Text="Password"></asp:Label>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 171px; top: 423px; position: absolute" Text="Tel"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; left: 162px; top: 472px; position: absolute; height: 19px" Text="StaffID"></asp:Label>
        <asp:Label ID="LabelError" runat="server" style="z-index: 1; left: 174px; top: 567px; position: absolute"></asp:Label>
    </form>
</body>
</html>
