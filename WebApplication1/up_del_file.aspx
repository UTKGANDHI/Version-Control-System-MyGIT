<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="up_del_file.aspx.cs" Inherits="WebApplication1.up_del_file" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" />
            <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />

    <style>
     body
      {
    background-image: url("white-color-wallpaper-background.jpg");
    }
        .auto-style1 {
            width: 38%;
            margin-top: 0px;
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
                <asp:Label ID="Label2" runat="server" Text="MyGit "></asp:Label></b></h4>
            </header>

                <div class="w3-container w3-cyan">
                    <asp:Button ID="Button6" runat="server" Text="Home" CssClass="w3-right-align" PostBackUrl="~/Repository.aspx"/>
                    <asp:Button ID="Button7" runat="server" Text="Account" PostBackUrl="~/Account.aspx" CssClass="w3-right-align"/>
                </div>
       </div>
      </div>


    <br />
    <br />
</div>
            </div>
    <div>
    
        BRANCH NAME:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 Repository&#39;s content:<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="ListBox2" runat="server" Height="154px" Width="121px"></asp:ListBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:ListBox ID="ListBox1" runat="server" Height="151px" Width="141px"></asp:ListBox>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <br />
        <br />
        <div style="margin-left: 560px" >
            <asp:Button ID="Button3" runat="server" Text="Delete file" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Download file" OnClick="Button4_Click" />
            <table class="auto-style1">
            <tr>
                <td>
            <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Upload" Height="26px" Width="75px" />
                </td>
            </tr>
        </table>
        
            </div>
        <br />

        <br />

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Files In Selected Branch above" class="btn btn-default" Width="350px"/>

        <br />
        <br />
        <br />
    
    </div>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Commit Selected Branch" Width="250px" CssClass="btn btn-default" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
