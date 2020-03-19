<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="Toys4U_Front_Office.StaffList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 529px">
 <form id="form1" runat="server">
      
        <asp:TextBox ID="txtJobTitle" runat="server" style="z-index: 1; left: 277px; top: 128px; position: absolute; height: 16px; width: 125px;"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 554px; top: 396px; position: absolute; height: 26px; width: 125px;" Text="Delete" OnClick="btnDelete_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
   
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 278px; top: 165px; position: absolute; height: 26px; width: 125px;" Text="Apply Filter" OnClick="btnApply_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
   
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 415px; top: 396px; position: absolute; height: 26px; width: 125px; right: 1036px;" Text="Edit" OnClick="btnEdit_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
            <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 416px; top: 166px; position: absolute; margin-top: 0px; width: 125px;" Text="Display All" OnClick="btnDisplayAll_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
            <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; left: 278px; top: 205px; position: absolute; height: 129px; width: 408px">
                <asp:ListItem Value="24">TestItem</asp:ListItem>
            </asp:ListBox>
        
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 276px; top: 105px; position: absolute; width: 138px" Text="Filter By JobTitle:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
     
       
      
       
 
            

       
      
      
     <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 283px; top: 341px; position: absolute; margin-top: 0px;" Font-Bold="True" Font-Names="Calibri" ForeColor="Red"></asp:Label>

        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 279px; top: 396px; position: absolute; height: 26px; right: 1172px; width: 125px;" Text="Add New Staff" OnClick="btnAdd_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
      
     
       
      
       
 
            

       
      
      
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 279px; top: 36px; position: absolute; width: 230px; height: 45px" Text="Manage Staff"></asp:Label>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 602px; top: 34px; position: absolute; height: 94px; width: 94px" />
   
            </p>
      
     
       
      
       
 
            

       
      
      
    </form>
</body>
</html>
