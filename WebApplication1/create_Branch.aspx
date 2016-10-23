<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create_branch.aspx.cs" Inherits="WebApplication1.WebForm1" %>

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

           <span class="card-title" ><h4 class="center-align"><b style="color:darkblue">Create Branch</b> </h4>
               </span>
            

                  
              <div class="input-field col s6">
           
               
            <asp:TextBox ID="TextBox1" runat="server"  class="form-control " Font-Size="Large"></asp:TextBox>
            </div>
               <div class="input-field col s6 left-align">
           
            </div>
          


                <div class="input-field col s6">
           
               <br />
               </span>
         
                </div>  
         
                </div>
            <br />
              <br /><br />
      
            <div class="card-action">
                
                
                      <p style="position:relative;top:54px">
       <asp:Button ID="Button2" Width="90px" runat="server" Text="Discard"  CssClass="btn btn-danger"  />
                   </p>

                 <p style="position:relative;left:-250px;top:10px"> 
           <asp:Button ID="Button1" Width="90px" runat="server" Text="Save"  CssClass="btn btn-success " OnClick="Button1_Click1"/>
   </p>
                </div>

     
    
         </span>
     
    </div>
          
        
       
    </form>
    


    
    <script type="text/javascript" src="jquery-2.1.1.min.js"></script>
      <script type="text/javascript" src="materialize/js/materialize.min.js"></script>
</body>
</html>
