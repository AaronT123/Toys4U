<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderList.aspx.cs" Inherits="Toys4U_Front_Office.OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrders" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 215px; width: 242px"></asp:ListBox>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 19px; top: 260px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 22px; top: 236px; position: absolute" Text="Please Enter Order ID"></asp:Label>
        </div>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 19px; top: 301px; position: absolute; width: 112px" Text="Apply" />
        <asp:Button ID="btnDisplay" runat="server" style="z-index: 1; left: 135px; top: 301px; position: absolute; width: 120px" Text="Display All" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 19px; top: 335px; position: absolute; width: 67px" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 91px; top: 335px; position: absolute; width: 77px" Text="Edit" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 173px; top: 335px; position: absolute; width: 81px" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 362px; position: absolute"></asp:Label>
    </form>
</body>
</html>
