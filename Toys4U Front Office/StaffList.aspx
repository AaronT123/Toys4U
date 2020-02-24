<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="Toys4U_Front_Office.StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
 <form id="form1" runat="server">
      
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 51px; top: 227px; position: absolute; height: 16px; width: 94px;"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 179px; top: 347px; position: absolute; height: 26px;" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 20px; top: 295px; position: absolute; height: 26px" Text="Apply" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 122px; top: 347px; position: absolute; height: 26px" Text="Edit" />
            <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 101px; top: 294px; position: absolute" Text="Display All" />
            <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 15px; top: 15px; position: absolute; height: 145px; width: 408px"></asp:ListBox>
        </p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 58px; top: 348px; position: absolute; height: 26px; right: 551px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 20px; top: 194px; position: absolute; width: 138px" Text="Enter a staff"></asp:Label>
      
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </p>
      
    </form>
</body>
</html>
