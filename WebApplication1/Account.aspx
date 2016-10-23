<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="WebApplication1.Account" %>



<!DOCTYPE html>
<html>
<title></title>
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
   </style>
         <form id="form1" runat="server">
&nbsp;<body><div class="w3-container w3-center w3-animate-opacity " >
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
            <h4  > <b>Delete Your Repository</b></h4>
            </header>

                <div class="w3-container w3-blue">
                    <p style="color:white"><i>Delete the unwanted stale repositories under your control from here. </i></p>
                       <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="DeleteRepo.aspx">Delete</a></button></p>
                </div>
       </div>
      </div>
     <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-red" style="font:italic">
            <h4 ><b>Change Ownership</b></h4>
            </header>

                <div class="w3-container w3-red">
                    <p style="color:white"><i>Transfer the ownership of the repository to other available users. </i></p>
                            <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="changeOwnership.aspx">Change it</a></button></p>
                </div>
       </div>
      </div>
 <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-purple"     style="font:italic">
            <h4  > <b>Change your password</b></h4>
            </header>

                <div class="w3-container w3-purple">
                    <p style="color:white"><i>Feeling your password is compromised or weak enough,change it from here </i></p>
                           <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="changePassword.aspx">Change Password</a></button></p>
                </div>
       </div>
      </div>

    
    
    <br />
    <br />
    <br />

    
    
</div>



</div>
                 <div style="margin-left: 600px">
                     <br />
                     <br />
                     <br />
                     <br />
                     <asp:HyperLink ID="HyperLink1"  runat="server"><h5 style="color:black"><a href="?logout=1" style="color:red"><u><b>-Logout from here-</b></u></a></h5></asp:HyperLink>
                 </div>
             </form>

    
</body>
</html>  
