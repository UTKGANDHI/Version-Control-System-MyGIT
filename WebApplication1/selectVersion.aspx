<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="selectVersion.aspx.cs" Inherits="WebApplication1.selectVersion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" />
    <style>
        body {
            background-image: url("white-color-wallpaper-background.jpg");
        }
     </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server" Height="314px" Width="259px"></asp:ListBox>
        <br />
&nbsp;Select the version of the file to be kept in the repository:
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Master" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
