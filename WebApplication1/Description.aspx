<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Description.aspx.cs" Inherits="WebApplication1.Description" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    
    <style>
     body
      {
    background-image: url("white-color-wallpaper-background.jpg");
    }
     </style><title></title>
    <link href="bootstrap.css" rel="stylesheet" />
    <link href="w3.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="w3-center">
    
        <br />
        <br />
        <b>Repository Name:</b><asp:Label ID="Label1" runat="server" Text="Label" class="w3-hover-text-blue"></asp:Label>
        <br />
        <br />
        <div class="container w3-center">
        <b>Description:</b><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <div class="row">
      <asp:TextBox ID="TextBox1" runat="server" Height="149px" OnTextChanged="TextBox1_TextChanged"  class="form-control input-group-lg col-lg-offset-4" Width="442px"></asp:TextBox>
        <br /></div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" CssClass="btn btn-success" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Discard" CssClass="btn btn-danger" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
&nbsp;</div>
        </div>
    </form>
     
</body>
</html>
