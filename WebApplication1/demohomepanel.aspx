<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demohomepanel.aspx.cs" Inherits="WebApplication1.demohomepanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
</head>
<body>
      <div class="title">
             &nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
           The Music Chamber
        </div>

        <div class="button">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            
             <asp:ImageButton ID="ImageButton4"  runat="server"  Height="35px" Width="30px" ImageUrl="~/homeicon.png" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="24px" ImageUrl="~/search.png" Width="25px" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/profile.png" Height="25px" Width="30px" />
            
            &nbsp;<div class="dropdown"  style="float: right; width: 53px;">
                <asp:ImageButton ID="ImageButton3" runat="server" Height="25px" Width="30px" CssClass="dropbtn" ImageUrl="~/set.png" />
              <div class="dropdown-content">
                  <a href="Change_Password.aspx">Edit Profile &nbsp;&nbsp;&nbsp;&nbsp;</a>
                 <a href="Logout.aspx">Logout&nbsp;&nbsp;&nbsp;&nbsp;</a>
                </div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>

       </div>

        <div>

</body>
</html>
