<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="faqs.aspx.cs" Inherits="WebApplication1.faqs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="w3.css" rel="stylesheet" />
<link href="mdb.css" rel="stylesheet" />
<link href="mdb.min.css" rel="stylesheet" />
        <link href="materialize/css/materialize.css" rel="stylesheet"/>
    <link href="materialize/css/materialize.min.css" rel="stylesheet" />
     <style>
         body {
             background-image: url("white-color-wallpaper-background.jpg");
         }
   </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <script type="text/javascript" src="jquery-2.1.1.min.js"></script>
    <script type="text/javascript" src="materialize/js/materialize.min.js"></script>
    <ul class="collapsible popout" data-collapsible="accordion">
        <li>
            <div class="collapsible-header"><i class="material-icons">1.</i>Why use something like Mygithub?</div>
            <div class="collapsible-body"><p>Say you and a coworker are both updating pages on the same website. You make your changes, save them, and upload them back to the website. So far, so good. The problem comes when your coworker is working on the same page as you at the same time. One of you is about to have your work overwritten and erased.A version control application like Git keeps that from happening. You and your coworker can each upload your revisions to the same page, and MyGitHub will save two copies. Later, you can merge your changes together without losing any work along the way. </p></div>
        </li>
        <li>
            <div class="collapsible-header"><i class="material-icons">2.</i>What is a Repository?</div>
            <div class="collapsible-body"><p> A directory or storage space where your projects can live. Sometimes MyGitHub users shorten this to “repo.” It can be local to a folder on your computer, or it can be a storage space on MyGitHub or another online host. You can keep code files, text files, image files, you name it, inside a repository.</p></div>
        </li>
        <li>
            <div class="collapsible-header"><i class="material-icons">3.</i>How to Create a Repository?</div>
            <div class="collapsible-body"><p>You can create a new repository on your personal account or any organization where you have sufficient permissions.</p>
            <p>1. login/ sign up for Github account</p>
            <p>2. Provide a name for your repository.</p>
            <p>3. You can choose to make the repository either public or private. Public repositories are visible to the public, while private repositories are only accessible to you, and people you share them with.</p>
            <p> 4. When you are finished, click on create repository</p>
            </div>
        </li>
        <li>
            <div class="collapsible-header"><i class="material-icons">4.</i>What is a Merge Request?</div>
            <div class="collapsible-body">
                <p>1. Merge request is sent to the admin of the repository and it is used to combine the code from two branches in order to make one.</p>
                <p>2. With myGithub, you create a branch when, for example, you need to implement a new functionality that is going to make major changes and/or greatly affect the project for a long time.</p>
                <p>3. When you are done implementing the functionality, you need to merge it in the main project (master, for example).</p>
                <p>4. The merge then assure that no conflicts exists between the two branches and let you decide what to do if some conflicts exists.</p>
            </div>
        </li>
        <li>
            <div class="collapsible-header"><i class="material-icons">5.</i>How to create a Branch?</div>
            <div class="collapsible-body">
                <p> 1.	Create a repository of your own.</p>
                <p> 2.	Provide a proper name for your branch.</p>
                <p> 3.	When you are finished, click Create Branch.</p>
            </div>
        </li>


    </ul>
    </div>
    </form>
</body>
</html>
