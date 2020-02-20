<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Toys4U_Front_Office.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 17px; top: 227px; position: absolute; height: 16px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 179px; top: 347px; position: absolute" Text="Delete" />
        <p>
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 20px; top: 295px; position: absolute; height: 26px" Text="Apply" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 99px; top: 347px; position: absolute; height: 26px" Text="Edit" />
            <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 101px; top: 294px; position: absolute" Text="Display All" />
            <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 175px; width: 429px"></asp:ListBox>
        </p>
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 16px; top: 346px; position: absolute; height: 26px; right: 992px" Text="Add" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 20px; top: 194px; position: absolute; width: 138px" Text="Enter a staff"></asp:Label>
      
    </form>
</body>
</html>
