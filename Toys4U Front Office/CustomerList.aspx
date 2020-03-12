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
        <asp:ListBox ID="lstCustomer" runat="server" style="z-index: 1; left: 110px; top: 61px; position: absolute; height: 180px; width: 181px; bottom: 615px"></asp:ListBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 113px; top: 304px; position: absolute; width: 154px;"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 194px; top: 383px; position: absolute" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 102px; top: 448px; position: absolute; width: 57px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 253px; top: 447px; position: absolute; width: 61px;" Text="Delete" OnClick="btnDelete_Click" />
        <p>
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 112px; top: 273px; position: absolute" Text="Please Enter a Post Code"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 185px; top: 518px; position: absolute" Text="[lblError]"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 100px; top: 383px; position: absolute; width: 90px; right: 1320px;" Text="Apply" OnClick="btnApply_Click" />
        <p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 176px; top: 448px; position: absolute; width: 62px;" Text="Edit" />
        </p>
    </form>
</body>
</html>
