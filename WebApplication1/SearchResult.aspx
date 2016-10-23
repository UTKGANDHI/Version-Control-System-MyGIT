<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="WebApplication1.SearchResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <style>
     body
      {
    background-image: url("blue.jpg");
    }
     </style><title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />

    <script src="search_part1.js" type="text/javascript"></script>
    <script src="search_part2.js" type="text/javascript"></script>
    <link href="jquery-ui.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
    $(function () {
        $("[id$=txtSearch]").autocomplete({
            source: function (request, response) {
                $.ajax({
                    url: '<%=ResolveUrl("~/SearchResult.aspx/GetCustomers") %>',
                    data: "{ 'prefix': '" + request.term + "'}",
                    dataType: "json",
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    success: function (data) {
                        response($.map(data.d, function (item) {
                            return {
                                label: item.split('-')[0],
                                val: item.split('-')[1]
                            }
                        }))
                    },
                    error: function (response) {
                        alert(response.responseText);
                    },
                    failure: function (response) {
                        alert(response.responseText);
                    }
                });
            },
            select: function (e, i) {
                $("[id$=hfCustomerId]").val(i.item.val);
            },
            minLength: 1
        });
    });  
</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Enter search term:
<asp:TextBox ID="txtSearch" runat="server" />   
<asp:HiddenField ID="hfCustomerId" runat="server" />
<asp:Button ID="Button1" Text="Select Repository" runat="server" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
