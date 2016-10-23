<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Graph.aspx.cs" Inherits="WebApplication1.Graph" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
    <style>
        body {
            background-image: url("white-color-wallpaper-background.jpg");
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
                    <asp:Button ID="Button2" runat="server" Text="Home" CssClass="w3-right-align" PostBackUrl="~/Repository.aspx"/>
                    <asp:Button ID="Button3" runat="server" Text="Account" PostBackUrl="~/Account.aspx" CssClass="w3-right-align"/>
                </div>
       </div>
      </div>


    <br />
    <br />
</div>
            </div>




        Select Repository:
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;Select Branch:
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp; Select Action:&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>Addition</asp:ListItem>
            <asp:ListItem>Deletion</asp:ListItem>
            <asp:ListItem>Downloads</asp:ListItem>
        </asp:DropDownList>
        <br />
        &nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Draw Graph" />
        <br />
        <br />
        <div style="margin-left: 240px">
            <asp:Chart ID="Chart1" runat="server" BackColor="IndianRed" BackGradientStyle="Center" BackImageTransparentColor="Black" BackSecondaryColor="Yellow" OnLoad="Chart1_Load" BorderlineColor="Black" Height="513px" Width="850px">
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
        <br />
    </form>
</body>
</html>
