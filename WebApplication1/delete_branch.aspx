<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete_branch.aspx.cs" Inherits="WebApplication1.delete_branch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" />
    <style>
     body
      {
    background-image: url("silver.jpg");
    }
     </style>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Select a branch to delete:</h3><br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="35px" Width="311px" >
        </asp:DropDownList>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Branch" class="btn btn-default"/>
    </form>
</body>
</html>
