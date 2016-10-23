<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_collab.aspx.cs" Inherits="WebApplication1.Add_collab" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
    <link href="bootstrap.css" rel="stylesheet" />
    <link href="jquery-ui.css" rel="Stylesheet" type="text/css" />  
    <style>    
     .dis
    {
        background-color:#ddd;
    }
        </style>
    <style>
.w3-card-2, .w3-card-4, .w3-card-8 {
  margin: 7px;
}

    <style>
        body {
            background-image: url("silver.jpg");
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
    <div class="w3-container w3-center w3-animate-opacity " >
<div class="w3-row w3-center">

    <div class="w3-center">
        <div class="w3-card-8 ">
            <header class="w3-container w3-cyan " style="font:italic">
            <h4  > <b>
                <asp:Label ID="Label4" runat="server" Text="MyGit "></asp:Label></b></h4>
            </header>

                <div class="w3-container w3-cyan">
                    <asp:Button ID="Button3" runat="server" Text="Home" CssClass="w3-right-align" PostBackUrl="~/Repository.aspx" />
                    <asp:Button ID="Button4" runat="server" Text="Account" PostBackUrl="~/Account.aspx" CssClass="w3-right-align"/>
                </div>
       </div>
      </div>


    <br />
    <br />

   </div>
        </div>

        
        
            
        <div>
        <asp:Label ID="Label1" runat="server" Text="Current Repository:" Font-Size="Medium"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" BorderStyle="None" Text="Current Collaborators" Font-Size="Medium"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" BorderStyle="None" Text="Available Users:" Font-Size="Medium"></asp:Label>

            <br />
            <br />

            </div>

         <br />
            <asp:ListBox ID="ListBox2" runat="server" Height="175px" Width="124px"></asp:ListBox>
            <asp:ListBox ID="ListBox1" runat="server" Height="183px" Width="138px"></asp:ListBox>
        <br />
        <br />
    
    </div>
        

            
                    
            <asp:Button ID="Button2" runat="server" CssClass=" col-md-offset-4  btn-default" OnClick="Button2_Click" Text="Delete Colloborator" class="btn btn-default"/>

        <asp:Button ID="Button1" runat="server" Text="Add Colloborator" CssClass="btn-default" OnClick="Button1_Click" Width="165px" class="btn btn-default"/>
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
