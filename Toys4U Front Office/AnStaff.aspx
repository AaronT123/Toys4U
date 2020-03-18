<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnStaff.aspx.cs" Inherits="Toys4U_Front_Office.AnStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth:"></asp:Label>
            <asp:TextBox ID="TextBoxDateOfBirth" runat="server"></asp:TextBox>
        </p>

        <p>
            
            <asp:Label ID="lblDateJoined" runat="server" Text="Date Joined"></asp:Label>
            <asp:TextBox ID="TextBoxDateJoined" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            
        </p>
        <p>
            <asp:Label ID="lblHourlyPay" runat="server" Text="Hourly Pay"></asp:Label>
            <asp:TextBox ID="TextBoxHourlyPay" runat="server"></asp:TextBox>
        
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 602px; top: 34px; position: absolute; height: 94px; width: 94px" />
   
        </p>
        <p>
             <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
           
             <asp:Label ID="Label11" runat="server" style="z-index: 1; left: 220px; top: 240px; position: absolute" Text="Re Enter Password"></asp:Label>
           
        </p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                    
            <asp:TextBox ID="TextBoxPassword2" runat="server" style="z-index: 1; left: 351px; top: 238px; position: absolute"></asp:TextBox>
                    
        </p>
        <p>
              <asp:Label ID="Label9" runat="server" Text="Tel"></asp:Label>
            <asp:TextBox ID="TextBoxPhoneNumber" runat="server"></asp:TextBox>
              
        </p>

        <p>
            <asp:Label ID="Label10" runat="server" Text="StaffID"></asp:Label>
              <asp:TextBox ID="TextBoxStaffID" runat="server"></asp:TextBox>
            
                 
        </p>
        <p>
                  <asp:Label ID="Label4" runat="server" Text="First Name"></asp:Label>
                  <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        

      
        </p>
        <p>
                    <asp:Label ID="Label6" runat="server" Text="Job Title"></asp:Label>
                   <asp:TextBox ID="TextBoxJobTitle" runat="server"></asp:TextBox>
           
        </p>
        
        <p>
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />
        </p>
        <p>
            <asp:Button ID="ButtonOK" runat="server" Text="OK" OnClick="ButtonOK_Click" />
        <p>
            <asp:CheckBox ID="CheckBoxAdmin" runat="server" Text="Admin?" />
         </p>
         </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>

 
     

    
   
    </form>
</body>
</html>
