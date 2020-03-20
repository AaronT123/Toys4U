<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffManagemenTDeletePage.aspx.cs" Inherits="Toys4U_Front_Office.StaffManagemenTDeletePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 602px; top: 34px; position: absolute; height: 94px; width: 94px" />
   
     
       
      
       
 
            

       
      
      
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 279px; top: 36px; position: absolute; width: 230px; height: 45px" Text="Delete Staff"></asp:Label>

        
        <asp:Label ID="LoadLabel" runat="server" style="z-index: 1; left: 281px; top: 98px; position: absolute; width: 165px" Text="Are you sure you want to delete the selected staff?" Font-Bold="True" Font-Names="Calibri"></asp:Label>
     
       
      
       
 
            

       
      
      

            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 339px; top: 170px; position: absolute; width: 53px" Text="No" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" OnClick="btnNo_Click1" />


            <p>


            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 281px; top: 170px; position: absolute; width: 51px; " Text="Yes" OnClick="btnYes_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" />
            </p>
    </form>
</body>
</html>
