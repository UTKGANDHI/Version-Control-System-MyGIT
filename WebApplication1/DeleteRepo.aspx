<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteRepo.aspx.cs" Inherits="WebApplication1.DeleteRepo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
     body
      {
    background-image: url("silver.jpg");
    }
     </style>
    <title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" >
    <div style="margin-left: 240px" >
        
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
            <asp:Label ID="Label1" runat="server" Text="Your repositories:" Font-Italic="true" Font-Size="Large" Font-Bold="true"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
        
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
            <asp:Button ID="Button2" runat="server" BackColor="#FF3300" ForeColor="Black" Height="36px" OnClick="Button2_Click" Text="DELETE REPOSITORY" Width="160px" />
    </div>
    </form>
</body>
</html>
