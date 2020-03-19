<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductHome.aspx.cs" Inherits="Toys4U_Front_Office.ProductHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 9px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <br />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 509px; top: 159px; position: absolute; height: 129px; width: 137px" />
   
        <br />
        <p>
            <asp:Label ID="LblToys4U" runat="server" Font-Italic="False" Font-Overline="False" Font-Size="XX-Large" style="z-index: 1; left: 113px; top: 36px; position: absolute; height: 53px; width: 174px" Text="Toys4U"></asp:Label>
        </p>
        <asp:ListBox ID="LstToys" runat="server" Height="200px" Width="384px"></asp:ListBox>
        <p>
            <asp:TextBox ID="TxtToys" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnApply" runat="server" Height="53px" OnClick="BtnApply_Click" Text="Apply" Width="130px" BackColor="#0066FF" ForeColor="#CCCCCC" />
        </p>
        <p>
            <asp:Button ID="BtnDisplayAll" runat="server" Height="57px" Text="Display All" Width="133px" BackColor="#0066FF" ForeColor="#CCCCCC" />
        </p>
        <asp:Button ID="BtnAdd" runat="server" Text="Add" OnClick="BtnAdd_Click2" BackColor="#3366FF" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" BackColor="#0066FF" />
        <asp:Button ID="BtnDelete" runat="server" OnClick="BtnDelete_Click" Text="Delete" BackColor="#0066FF" />
    </form>
</body>
</html>
