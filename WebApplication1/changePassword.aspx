<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changePassword.aspx.cs" Inherits="WebApplication1.changePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="materialize.scss" rel="stylesheet" />
    <link href="materialize.min.css" rel="stylesheet" />
    <link href="materialize.css" rel="stylesheet" />
    <link href="bootstrap.css" rel="stylesheet" />
  <style>
     body
      {
    background-image: url("silver.jpg");
    }
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

           <span class="card-title" ><h4 class="center-align"><b style="color:darkblue">Change your password</b> </h4>
               </span>
            

                  
              <div class="input-field col s6">
           <label for="first_name"><a style="font-size:medium">Old password</a></label>
               
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" class="form-control " Font-Size="Large"></asp:TextBox>
            </div>
                <br />
             <br />
               <div class="input-field col s6 left-align">
           <label for="first_name" class="left-align"><a style="font-size:medium"> New password</a></label>
            <asp:TextBox ID="TextBox2"  TextMode="Password" runat="server" class=" form-control" Font-Size="Large"></asp:TextBox>
            </div>
             <br />
             <br />
             <br />



                <div class="input-field col s6">
           <label for="first_name"><a style="font-size:medium"> Confirm password</a></label>
            <asp:TextBox ID="TextBox3" TextMode="Password" runat="server"  Font-Size="Large" class="form-control input-group-lg"></asp:TextBox>
               <br /> 
               </span>
         
                </div>  
         
                </div>
            <br />
                 <br />
            <div class="card-action">
                  <p style="position:relative;left:-250px;top:16px;">
       <asp:Button ID="Button1" Width="90px" runat="server" OnClick="Button1_Click" Text="Save"  CssClass="btn btn-success"/>
                </p>
                      <p style="position:relative;top:-30px">
       <asp:Button ID="Button2" Width="90px" runat="server" Text="Discard" OnClick="Button2_Click" CssClass="btn btn-danger" />
                   </p>
                </div>
    </div>

         
          
    
            </div>
          </div>
        </div>
    
         </span>
     
    </div>
          
        
       
    </form>
    


    
    <script type="text/javascript" src="jquery-2.1.1.min.js"></script>
      <script type="text/javascript" src="materialize/js/materialize.min.js"></script>
</body>
</html>
