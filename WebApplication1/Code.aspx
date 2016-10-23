<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Code.aspx.cs" Inherits="WebApplication1.Code" %>

<!DOCTYPE html>
<html>
<title></title>
<meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />

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
         

<body>
    <form runat="server" id="form1">
   <div class="w3-container w3-center w3-animate-opacity " >
<div class="w3-row w3-center">

    <div class="w3-center">
        <div class="w3-card-8 ">
            <header class="w3-container w3-cyan " style="font:italic">
            <h4  > <b>
                <asp:Label ID="Label2" runat="server" Text="MyGit "></asp:Label></b></h4>
            </header>

                <div class="w3-container w3-cyan">
                    <asp:Button ID="Button1" runat="server" Text="Home" CssClass="w3-right-align" PostBackUrl="~/Repository.aspx" />
                    <asp:Button ID="Button2" runat="server" Text="Account" PostBackUrl="~/Account.aspx" CssClass="w3-right-align"/>
                </div>
       </div>
      </div>


    <br />
    <br />

    <div class="w3-third">
        <div class="w3-card-8 ">
            <header class="w3-container w3-blue" style="font:italic">
            <h4  > <b>Create your Branch</b></h4>
            </header>

                <div class="w3-container w3-blue">
                    <p style="color:white"><i>Each time, that you want to commit a bug or a feature, you need to create a branch for it, which will be a copy of your master branch.</i></p>
                       <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="create_branch.aspx">Create Branch</a></button></p>
                </div>
       </div>
      </div>
     <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-red" style="font:italic">
            <h4 ><b>Delete your Branch</b></h4>
            </header>

                <div class="w3-container w3-red">
                    <p style="color:white"><i>If you want no more branches of yours on server, then you can clear it by deleting from here. </i></p>
                            <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="delete_branch.aspx">Delete Branch</a></button></p>
                </div>
       </div>
      </div>
 <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-purple"     style="font:italic">
            <h4  > <b>Manage your Files</b></h4>
            </header>

                <div class="w3-container w3-purple">
                    <p style="color:white"><i>Get your work done easily by uploading to repsoitories, deleting or downloading files from repositories. </i></p>
                           <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="up_del_file.aspx">Manage Files</a></button></p>
                </div>
       </div>
      </div>
 <div class="w3-half">
        <div class="w3-card-8 ">
            <header class="w3-container w3-orange"    style="font:italic">
            <h4  style="color:white"> <b>Manage your Account</b></h4>
            </header>

                <div class="w3-container w3-orange">
                    <p style="color:white"><i>Remove your unwanted repositories from your account. Trasnfer the ownership of your repositories or change account password here.</i></p>
                           <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="Account.aspx">Open Account</a></button></p>
                </div>
       </div>
      </div>

    
    
 <div class="w3-half">
        <div class="w3-card-8">
            <header class="w3-container w3-green"     style="font:italic">
            <h4  > <b>Add collaborators</b></h4>
            </header>

                <div class="w3-container w3-green">
                    <p style="color:white"><i>To work with others in a joint intellectual effort, add collaborators which will have acacess to your repository.  </i></p>
                            <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="Add_collab.aspx">Add</a></button></p>
                </div>
       </div>
      </div>
</div>



</div>

    </form>
</body>
</html>  
