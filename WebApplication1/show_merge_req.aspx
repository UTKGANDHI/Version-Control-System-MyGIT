<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show_merge_req.aspx.cs" Inherits="WebApplication1.show_merge_req" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
    <style>
     
     </style>
    <link href="gridview.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False" CssClass="mydatagrid" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
            <Columns>
                <asp:CommandField ShowSelectButton="True" SelectText="Resolve" />
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="reponame" HeaderText="reponame" SortExpression="reponame" />
                <asp:BoundField DataField="branchname" HeaderText="branchname" SortExpression="branchname" />
                <asp:BoundField DataField="sender" HeaderText="sender" SortExpression="sender" />
                <asp:BoundField DataField="timestamp" HeaderText="timestamp" SortExpression="timestamp" />
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            </Columns>

<HeaderStyle CssClass="header"></HeaderStyle>

<PagerStyle CssClass="pager"></PagerStyle>

<RowStyle CssClass="rows"></RowStyle>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString1 %>" SelectCommand="SELECT * FROM [merge_req]"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
