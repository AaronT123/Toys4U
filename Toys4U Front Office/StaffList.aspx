<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="Toys4U_Front_Office.StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 529px">
 <form id="form1" runat="server">
      
        <asp:TextBox ID="txtJobTitle" runat="server" style="z-index: 1; left: 15px; top: 219px; position: absolute; height: 16px; width: 94px;"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 179px; top: 347px; position: absolute; height: 26px;" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 50px; top: 293px; position: absolute; height: 26px" Text="Apply" OnClick="btnApply_Click" />
        </p>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 122px; top: 347px; position: absolute; height: 26px" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 101px; top: 294px; position: absolute" Text="Display All" OnClick="btnDisplayAll_Click" />
            <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 15px; top: 16px; position: absolute; height: 145px; width: 408px">
                <asp:ListItem Value="24">TestItem</asp:ListItem>
            </asp:ListBox>
        </p>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 58px; top: 348px; position: absolute; height: 26px; right: 551px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 16px; top: 180px; position: absolute; width: 138px" Text="Enter a JobTitle"></asp:Label>
      
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
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
      
    </form>
</body>
</html>
