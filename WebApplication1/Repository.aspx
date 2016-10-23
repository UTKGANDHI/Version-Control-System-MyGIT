<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repository.aspx.cs" Inherits="WebApplication1.Repository" %>

<!DOCTYPE html>
<html>
    <head runat="server">
<title></title>
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

<meta name="viewport" content="width=device-width, initial-scale=1">

<link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
<style>
.w3-card-2, .w3-card-4, .w3-card-8 {
  margin: 7px;
}
</style>
     <style>
         body {
             background-image: url("silver.jpg");
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

    <div class="w3-row">
    <div class="w3-third">
        <div class="w3-card-8 ">
            <header class="w3-container w3-yellow" style="font:italic">
            <h4 style="color:white" > <b>Search Repository</b></h4>
            </header>

                <div class="w3-container w3-yellow">
                    <p style="color:white"><i style="color:white">Search public repositories.</i></p>
                <asp:TextBox ID="txtSearch" runat="server" width="200px" class="form-control input-group-lg" ForeColor="DarkBlue"></asp:TextBox><asp:HiddenField ID="HiddenField1" runat="server" />
                    <div style="margin-left: 40px">
                        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" class=" hoverable right" Height="56px" Width="117px" />
                   </div>
                    
                </div>
       </div>
      </div>
   <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-red" style="font:italic">
            <h4 ><b>Create Repository</b></h4>
            </header>

                <div class="w3-container w3-red">
                    <p style="color:white"><i>Start the collaborative work over here by creating a repository of your own and add files, collaborators and much more.</i></p>
                            <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="CreateRepository.aspx">Create</a></button></p>
                </div>
       </div>
      </div>
 <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-purple"     style="font:italic">
            <h4  > <b>Browse a repository</b></h4>
            </header>

                <div class="w3-container w3-purple">
                    <p style="color:white"><i>Search all the publicly available repositories and their corresponding contents after which you can contirbute in them.</i></p>
                           <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="Browse.aspx">Browse Repository</a></button></p>
                </div>
       </div>
      </div>


    </div>


    <div class="w3-row">

 <div class="w3-half">
        <div class="w3-card-8 ">
            <header class="w3-container w3-orange"    style="font:italic">
            <h4  style="color:white"> <b>Manage your Account</b></h4>
            </header>

                <div class="w3-container w3-orange">
                    <p style="color:white"><i>Remove your unwanted repositories from your account. Transfer the ownership of your repositories or change account password here.</i></p>
                           <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="Account.aspx">Open Account</a></button></p>
                </div>
       </div>
      </div>

    
    
 <div class="w3-half">
        <div class="w3-card-8">
            <header class="w3-container w3-green"     style="font:italic">
            <h4  > <b>See your notifications</b></h4>
            </header>

                <div class="w3-container w3-green">
                    <p style="color:white"><i>View all the merge requests sent to you by the collaborators of the repository of which you are the owner. </i></p>
                            <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="show_merge_req.aspx">Notifications</a></button></p>
                </div>
       </div>
      </div>
</div>



</div>
          </div>
    </form> 
</body>
</html>  
