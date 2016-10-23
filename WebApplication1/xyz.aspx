<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xyz.aspx.cs" Inherits="WebApplication1.xyz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" />
    <style>    
     .dis
    {
        background-color:#ddd;
    }
        </style>
    <style>
        body {
            background-image: url("white-color-wallpaper-background.jpg");
        }
        .auto-style1 {
            width: 37%;
        }
        .auto-style2 {
            width: 91px;
            margin-left: 40px;
        }
        .auto-style3 {
            width: 478px;
        }
     </style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br /> 
        <div>
        <asp:Label ID="Label1" runat="server" BorderStyle="None" Text="Select the branch:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" BorderStyle="None" Text="Current Collaborators"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" BorderStyle="None" Text="Available Users:"></asp:Label>

            <br />
            <br />

            </div>

         <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="140px" Width="100px" CssClass="col-lg-offset-0"></asp:ListBox>
            <asp:ListBox ID="ListBox2" runat="server" Height="140px" Width="100px"></asp:ListBox>
            <asp:ListBox ID="ListBox3" runat="server" Height="140px" Width="100px"></asp:ListBox>
        <br />
        <br />
    
    </div>
        

            <asp:Button ID="Button1" runat="server" Text="Add Colloborator" Width="165px" class="btn btn-default"/>
                    
            <asp:Button ID="Button2" runat="server" Text="Delete Colloborator" class="btn btn-default"/>
                    <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
            </table>
        
    </form>
</body>
</html>
