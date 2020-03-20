<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="Toys4U_Front_Office.CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style ="background-color:burlywood">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomer" runat="server" style="z-index: 1; left: 429px; top: 216px; position: absolute; height: 113px; width: 382px; bottom: 335px"></asp:ListBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 430px; top: 136px; position: absolute; width: 169px;"></asp:TextBox>
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 558px; top: 169px; position: absolute; width: 89px;" Text="Display All" OnClick="btnDisplayAll_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 425px; top: 386px; position: absolute; width: 70px;" Text="Add" OnClick="btnAdd_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 628px; top: 388px; position: absolute; width: 83px;" Text="Delete" OnClick="btnDelete_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
        <p>
            <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 435px; top: 111px; position: absolute" Text="Please Enter a Post Code:" Font-Bold="True"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 437px; top: 342px; position: absolute" Text="[lblError]" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 427px; top: 171px; position: absolute; width: 90px; right: 989px;" Text="Apply" OnClick="btnApply_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White"/>
        <p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 523px; top: 388px; position: absolute; width: 69px;" Text="Edit" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 744px; top: 40px; position: absolute; height: 110px; width: 118px" />
   
        </p>
        <asp:Label ID="Label1" runat="server" BorderStyle="Double" Font-Bold="True" Font-Underline="True" ForeColor="#003300" style="z-index: 1; left: 443px; top: 37px; position: absolute; height: 36px; width: 154px" Text="Toys4U" Font-Size="XX-Large"></asp:Label>
    </form>
</body>
</html>
