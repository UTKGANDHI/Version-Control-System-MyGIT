using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
   
    public partial class Account : System.Web.UI.Page
    {
        DataClasses2DataContext db;
        string absolutepath = @"G:\GIT\";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");
            /*if(!IsPostBack)
            ShowDirectoriesIn();*/
            string v=Request.QueryString["logout"];
            if (v == ("1").ToString())
            {
                Session.Abandon();
                Response.Redirect("index.html");
            }

        }

    }
}