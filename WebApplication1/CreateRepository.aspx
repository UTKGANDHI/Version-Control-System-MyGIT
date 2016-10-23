<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateRepository.aspx.cs" Inherits="WebApplication1.CreateRepository" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" />
    <link href="w3.css" rel="stylesheet" />
    <style>
     body
      {
    background-image: url("white-color-wallpaper-background.jpg");
    }
     </style>
    
    <link href='style.css' rel="stylesheet" />
           
    
</head>
<body>
    <form id="form1" runat="server" ><div class="col s3 offset-s3"><span class="flow-text">
        <div class="container center-block">
        <div class="html" >
    
        <br />
        <br />
        <br />
&nbsp;<asp:Label runat="server" ID="label1" Font-size="Large" color="" Font-Bold="False" CssClass="f" ForeColor="Black"><b style="color:black">Enter name of repository:</b></asp:Label>&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" class="form-control input-group-lg"></asp:TextBox>
        <br />
        <br />
        &nbsp;
        <asp:Label runat="server" ID="label2" Font-size="Large" color="#00FFFF" Font-Bold="False" CssClass="f" ForeColor="Black"><b>Select type of repository:</b></asp:Label>
        <br />
        <br />
            <div class="w3-radio">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="f" ForeColor="Black">

            <asp:ListItem Text="Private" ></asp:ListItem>
            <asp:ListItem Text="Public"></asp:ListItem>
        </asp:RadioButtonList></div>
        <br />
       
        <asp:Label runat="server" ID="label3" Font-size="Large" color="#00FFFF" Font-Bold="False" CssClass="f" ForeColor="Black"><b>Enter Description:</b></asp:Label><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="144px" Width="340px" class="form-control input-group-lg"></asp:TextBox>
        <br />
        <br /></div>
            &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" class="btn btn-success glyphicon-align-left" Width="89px"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Discard" OnClick="Button2_Click" class="btn btn-danger"/>
        <br />
    
    </div>
           </span></div>
    </form>
</body>
</html>
