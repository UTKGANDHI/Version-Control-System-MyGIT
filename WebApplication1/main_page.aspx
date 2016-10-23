<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main_page.aspx.cs" Inherits="trial.main_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
    
    <style type="text/css">
        body{
            background-image:url('s2.jpg');
            background-repeat: no-repeat;
            background-size:cover;
            background-attachment: fixed;
            width: 763px;
        }
       .dropdown-content{
           display:none;
           position:absolute;
           right:0;
           background-color:#f9f9f9;
           box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
           margin-top:1px;
       }

       .dropdown-content a{
           color:black;
           padding:15px 16px;
           text-decoration:none;
           display:block;
       }
       
       .dropdown-content a:hover{
           background-color:#f1f1f1
       }

       .dropdown:hover .dropdown-content{
           display:block;
       }
          
       .dropdown:hover .dropbtn{
           
       }
       
        .homebtn{
           margin-left:90px;
           
       }
         .homediv{
             width:20%;
         }
         
         .search{
          
          margin-top:13px;
       }   
         
         .dropdown{
           margin-left:10px;

       }    

          .dropbtn{
           margin-top:13px;
       }

            .title{
    position:fixed;
    text-align:center;
    background-color:rgba(6,50,60,0.85);
    height:50px;
    width:74%;
    margin-left:-10px;
    margin-top:0px;
    color:white;
    font-family:'Freehand591 BT';
    font-size:40px;
    
}
         .button{
             position:fixed;
           width:27%;
           background-color:rgba(6,50,60,0.85);
           height:50px;
           margin-left:988px;
          
       }
        
       .gridplay{
           margin-left:520px;
       }

   .player{
       margin-left:350px;
   }
        
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
       <br/>
         <div class="title">
             &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
           MyGit
        </div>

        <div class="button">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            
             <asp:ImageButton ID="ImageButton4" CssClass="homebtn" runat="server"  Height="35px" Width="30px" ImageUrl="~/homeicon.png" OnClick="ImageButton4_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="24px" ImageUrl="~/search.png" Width="25px" CssClass="search" OnClick="ImageButton1_Click1" />
            &nbsp;&nbsp;&nbsp;&nbsp;  
       </div>

<br/><br/><br/><br/><br/>          
        
    </form>
</body>
</html>
