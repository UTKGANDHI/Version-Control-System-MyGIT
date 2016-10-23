<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="issues.aspx.cs" Inherits="WebApplication1.issues" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
    <link href="gridview.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
 #grid-view-container
 {
  height:auto;
  overflow:scroll;
  max-height:450px;
 }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="grid-view-container">
    
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
            <Columns>
                <asp:BoundField DataField="Id" ReadOnly="True" HeaderText="Id" />
                <asp:BoundField DataField="username" HeaderText="user"/>
                <asp:BoundField DataField="description" HeaderText="description" />
                <asp:BoundField DataField="time"  HeaderText="timestamp"/>
                <asp:BoundField DataField="filename" HeaderText="File Name" />
                <asp:BoundField DataField="Branchname" HeaderText="Branch Name" />
                </Columns>
        </asp:GridView>
     </div>    
    </form>
</body>
</html>
