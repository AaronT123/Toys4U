<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnStaffManagemenT.aspx.cs" Inherits="Toys4U_Front_Office.AnStaffManagemenT" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <form id="form2" runat="server">

            <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 278px; top: 87px; position: absolute; height: 23px; width: 94px" Text="Date Of Birth:" Font-Bold="True" Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="TextBoxDateOfBirth" runat="server" style="z-index: 1; position: absolute; top: 85px; left: 374px; width: 140px;"></asp:TextBox>
            <asp:Label ID="lblDateJoined" runat="server" style="z-index: 1; position: absolute; top: 130px; left: 290px;" Text="Date Joined" Font-Bold="True" Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="TextBoxDateJoined" runat="server" style="z-index: 1; position: absolute; top: 126px; left: 374px; width: 141px;"></asp:TextBox>
   
     
       
      
       
 
            

       
      
      
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 279px; top: 36px; position: absolute; width: 230px; height: 45px" Text="Staff Details"></asp:Label>

        

  
            <asp:Label ID="lblEmail" runat="server" style="z-index: 1; position: absolute; top: 163px; left: 329px;" Text="Email" Font-Bold="True" Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="TextBoxEmail" runat="server" style="z-index: 1; position: absolute; top: 159px; left: 374px; width: 142px;"></asp:TextBox>
            
  
            <asp:Label ID="lblHourlyPay" runat="server" style="z-index: 1; position: absolute; top: 202px; left: 565px; margin-top: 0px;" Text="Hourly Pay" Font-Bold="True" Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="TextBoxHourlyPay" runat="server" style="z-index: 1; position: absolute; top: 202px; left: 649px;"></asp:TextBox>
        
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo.jpg" style="z-index: 1; left: 602px; top: 34px; position: absolute; height: 94px; width: 94px" />
   
   
             <asp:Label ID="lblLastName" runat="server" style="z-index: 1; position: absolute; top: 242px; left: 294px;" Text="Last Name" Font-Bold="True" Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="TextBoxLastName" runat="server" style="z-index: 1; position: absolute; top: 242px; left: 374px; margin-top: 0px; width: 143px;"></asp:TextBox>
           
   
            <asp:Label ID="Label8" runat="server" style="z-index: 1; position: absolute; top: 278px; left: 301px;" Text="Password" Font-Bold="True" Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" style="z-index: 1; position: absolute; top: 279px; left: 373px; width: 140px; right: 869px;"></asp:TextBox>
                    
   
              <asp:Label ID="Label9" runat="server" style="z-index: 1; position: absolute; top: 157px; left: 612px; width: 27px;" Text="Tel" Font-Bold="True" Font-Names="Calibri"></asp:Label>
            <asp:TextBox ID="TextBoxPhoneNumber" runat="server" style="z-index: 1; position: absolute; top: 159px; left: 648px;"></asp:TextBox>
 
     
                  <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 202px; left: 295px;" Text="First Name" Font-Bold="True" Font-Names="Calibri"></asp:Label>
                  <asp:TextBox ID="TextBoxFirstName" runat="server" style="z-index: 1; position: absolute; top: 203px; left: 374px; width: 139px;"></asp:TextBox>
        

      
                    <asp:Label ID="Label6" runat="server" style="z-index: 1; position: absolute; top: 238px; left: 580px; height: 19px;" Text="Job Title" Font-Bold="True" Font-Names="Calibri"></asp:Label>
                   <asp:TextBox ID="TextBoxJobTitle" runat="server" style="z-index: 1; position: absolute; top: 237px; left: 649px;"></asp:TextBox>
           
     
            <asp:Button ID="ButtonCancel" runat="server" style="z-index: 1; position: absolute; top: 352px; left: 652px; width: 123px;" Text="Cancel" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White" OnClick="ButtonCancel_Click" />
     
            <asp:Button ID="ButtonOK" runat="server" style="z-index: 1; position: absolute; top: 319px; left: 650px; width: 127px;" Text="OK" OnClick="ButtonOK_Click" BackColor="#3366CC" Font-Bold="True" Font-Names="Calibri" ForeColor="White"  />
      
            <asp:CheckBox ID="CheckBoxAdmin" runat="server" style="z-index: 1; position: absolute; top: 272px; left: 700px;" Text="Admin?" Font-Bold="True" Font-Names="Calibri" />
       
            <asp:Label ID="lblError" runat="server" style="z-index: 1; position: absolute; top: 317px; left: 373px; width: 204px; height: 20px;" Font-Bold="True" Font-Names="Calibri" ForeColor="#CC3300"></asp:Label>
      
            
 
     

    
   
    </form>
    </form>
</body>
</html>
