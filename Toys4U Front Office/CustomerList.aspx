<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Toys4U_Front_Office.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomer" runat="server" style="z-index: 1; left: 117px; top: 78px; position: absolute; height: 146px; width: 173px; bottom: 438px"></asp:ListBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 113px; top: 304px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 194px; top: 383px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 106px; top: 447px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 269px; top: 449px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 116px; top: 273px; position: absolute" Text="Please Enter a Post Code"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 185px; top: 518px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 177px; top: 448px; position: absolute" Text="Edit" />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 108px; top: 383px; position: absolute" Text="Apply" />
    </form>
</body>
</html>
