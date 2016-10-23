e<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repo_homepage.aspx.cs" Inherits="WebApplication1.Repo_homepage" %>

<html>
<head>
    <link href="//maxcdn.bootstrapcdn.com/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400;300' rel='stylesheet' type='text/css'>
    <link href='style.css' rel='stylesheet'>


 
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
         &nbsp;</head><body><form id="form1" runat="server">

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

        
    <div class="w3-center">
        <div class="w3-card-8 ">
            <header class="w3-container w3-black" style="font:italic">
            <h4  > <b>
                <asp:Label ID="Label1" runat="server" Text="Current Repository: "></asp:Label></b></h4>
            </header>

                <div class="w3-container w3-black">                       
                </div>
       </div>
      </div>


    <br />
    <br />

    <div class="w3-third">
        <div class="w3-card-8 ">
            <header class="w3-container w3-blue" style="font:italic">
            <h4  > <b>Put your views</b></h4>
            </header>

                <div class="w3-container w3-blue">
                    <p style="color:white"><i>Get general information pertaining to the project i.e. Its scope, aim, guidelines goal over here.</i><br /></p>
                       <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="Description.aspx">Put your Description</a></button></p>
                </div>
       </div>
      </div>

     <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-red" style="font:italic">
            <h4 ><b>Code</b></h4>
            </header>

                <div class="w3-container w3-red">
                    <p style="color:white"><i>Perform operations on the repositories like uploading, deletion, downloading of a file over here. </i></p>
                            <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="Code.aspx">Code it</a></button></p>
                </div>
       </div>
      </div>

 <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-purple"     style="font:italic">
            <h4  > <b>Graph</b></h4>
            </header>

                <div class="w3-container w3-purple">
                    <p style="color:white"><i>Get the graphical representation of operations for the selected repository and branch over here.</i></p>
                           <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="Graph.aspx">View History</a></button></p>
                </div>
       </div>
      </div>

 <div class="w3-third">
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

    
    
 <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-green"     style="font:italic">
            <h4  > <b>Delete your Repository</b></h4>
            </header>

                <div class="w3-container w3-green">
                    <p style="color:white"><i>If you want no more repository of yours on server, then you can clear it by deleting from here.   </i></p>
                            <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="DeleteRepo.aspx">Delete</a></button></p>
                </div>
       </div>
      </div>


             <div class="w3-third">
        <div class="w3-card-8">
            <header class="w3-container w3-blue"     style="font:italic">
            <h4  > <b>Issues</b></h4>
            </header>

                <div class="w3-container w3-blue">
                    <p style="color:white"><i>Get the summary of the actions performed(Upload/ Download/ Delete) by different users in chronological order over here.  </i></p>
                            <p class="w3-left-align"><button class="w3-btn-block w3-white w3-hover-white"  ><a href="issues.aspx">View actions performed</a></button></p>
                </div>
       </div>
      </div>
</div>

        
        
        <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
        <script src="app.js"></script>
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server"><h4><a style="color:red" href="?fork=1"><b>Get your Local copy here !!</b></a></h4></asp:HyperLink>
        
    </form>
</body>
</html>