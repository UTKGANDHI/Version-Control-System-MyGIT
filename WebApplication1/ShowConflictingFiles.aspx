<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowConflictingFiles.aspx.cs" Inherits="WebApplication1.ShowConflictingFiles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
    <style>
     body
      {
    background-image: url("blue.jpg");
    }
     </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Conflicting file names:<br />
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <br />
    
    </div>
    </form>
</body>
</html>
