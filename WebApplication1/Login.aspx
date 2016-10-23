<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.lgn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="materialize/css/materialize.css" rel="stylesheet"/>
    <link href="materialize/css/materialize.min.css" rel="stylesheet" />
      <style>
    body  {
    background-image: url("silver.jpg");
   </style> 
</head>
<body>
    <form id="form1" runat="server">
    
        <div class="row">
     <div class="col s5 offset-s4"><span class="flow-text">


            
         <div class="row">
         <div class="col s12 m10">
         <div class="card white">
         <div class="card-content">            

           <span class="card-title" ><h4 class="center-align"><b style="color:darkblue"> Login</b> </h4>
               </span>
                  
              <div class="input-field col s6">
           <label for="first_name">Username</label>
            <asp:TextBox ID="UserName" runat="server" class="form-control input-group-lg"></asp:TextBox>
            </div>
                <br />
                <br />


                <div class="input-field col s6">
           <label for="first_name">Password</label>
            <asp:TextBox ID="TextBox1" TextMode="Password" runat="server"  class="form-control input-group-lg"></asp:TextBox>
               <br /> 
               </span>
         
                </div>  
         
                </div>
            <br />
                 <br />
            <div class="card-action">
          <asp:Button ID="Button1" runat="server"  Text="login" CausesValidation="true" CssClass="btn btn-success" OnClick="Button1_Click" />
            </div>
          </div>
        </div>
    
         </span>
     
    </div>
          
        
        <div class="row">
     <div class="col s5 offset-s3"><span class="flow-text">
         <b>  <a href="Signp.aspx" class="red-text" style="font-size:medium " >Create new account</a></b>
         </span>
    </form>
    <script type="text/javascript" src="https://code.jquery.com/jquery-2.1.1.min.js"></script>
      <script type="text/javascript" src="materialize/js/materialize.min.js"></script>
</body>
</html>



            