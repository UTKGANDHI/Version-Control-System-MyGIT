<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signp.aspx.cs" Inherits="WebApplication1.Signp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
    body  {
    background-image: url("white-color-wallpaper-background.jpg ");
    }
        </style>
    <link href="bootstrap.css" rel="stylesheet" />
    <link href="bootstrap.min.css" rel="stylesheet" />
</head>
<body>
   <h3><font color="blue" class="col-lg-offset-5"><b>Sign Up herere</b></font></h3><br />
    <div class="container">
    <div class="row">
        <form role="form" runat="server">
            <div class="col-lg-6">
              
                <div class="form-group">
                    <label for="InputName">Enter Name</label>
                    <div class="input-group">
                       <asp:TextBox ID="UserName" runat="server" class="form-control input-group-lg"></asp:TextBox>
                         <asp:CustomValidator ID="CustomValidator1" runat="server" OnServerValidate="validateUserName" ErrorMessage="Already exists"></asp:CustomValidator>  
                    &nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="form-group">
                    <label for="InputEmail">Enter Email</label>
                    <asp:TextBox ID="Email" runat="server" class="form-control input-group-lg"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Please enter valid Email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="Email" ></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="Email" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                </div>
             
                  <div class="form-group">
                    <label for="InputName">Enter First Name</label>
                    <div class="input-group">
                       <asp:TextBox ID="TextBox1" runat="server" class="form-control input-group-lg"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <br />
                        
                    </div>

                       <div class="form-group">
                    <label for="InputName">Enter Last Name</label>
                    <div class="input-group">
                       <asp:TextBox ID="TextBox2" runat="server" class="form-control input-group-lg"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TextBox2" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <br />
                        
                    </div>
                            <div class="form-group">
                    <label for="InputName">Enter Phone Number</label>
                    <div class="input-group">
                       <asp:TextBox ID="TextBox3" runat="server" class="form-control input-group-lg"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox3" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <br />
                        
                    </div>  
                </div>
                             <div class="form-group">
                    <label for="InputName">Enter Country</label>
                    <div class="input-group">
                       <asp:TextBox ID="TextBox4" runat="server" class="form-control input-group-lg"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="TextBox4" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <br />
                        
                    </div>  
                            <div class="form-group">
                    <label for="InputName">Enter Password</label>
                    <div class="input-group">
                       <asp:TextBox ID="TextBox5" runat="server" type="password" class="form-control input-group-lg"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="TextBox5" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <br />
                        
                    </div>  
                </div>
                          <div class="form-group">
                    <label for="InputName">Confirm Password</label>
                    <div class="input-group">
                       <asp:TextBox ID="TextBox6" runat="server" type="password" class="form-control input-group-lg"></asp:TextBox>
                          <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox6" ErrorMessage="Password didn't match"></asp:CompareValidator>
                    <br />
                        
                    </div>  
                </div>
                </div>
                <asp:Button ID="Button1" runat="server" Text="Sign Up" class="btn btn-info pull-right" CausesValidation="true"  OnClick="Button1_Click"/>
            </div>
        </form>
       
    </div>
</div>
   
</body>
</html>
