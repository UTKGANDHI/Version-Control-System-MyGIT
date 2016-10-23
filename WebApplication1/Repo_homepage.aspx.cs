using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Services;
using System.Web.Script.Services;
using Ionic.Zip;

namespace WebApplication1
{
    public partial class Repo_homepage : System.Web.UI.Page
    {
        
        string uploaddirectory;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");

            if (!this.IsPostBack)
            {
               Label1.Text += Path.GetFileName(Session["reponame"].ToString());
            }
            if(Request.QueryString["fork"]!=null)
                if (Int32.Parse(Request.QueryString["fork"].ToString()) == 1)
                    forking();
        }

        
        
        public void forking()
        {
            Response.ContentType = "application/zip";
            Response.AddHeader("content-disposition", "attachment; filename=" + "GIT-copy.zip");
            using (ZipFile zipfile = new ZipFile())
            {
                string[] files = Directory.GetFiles(Session["reponame"].ToString());
                // add all those files to the ProjectX folder in the zip file
                zipfile.AddFiles(files);
                zipfile.Save(Response.OutputStream);

                
            }
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Forking complete.');", true);
            Response.End();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["reponame"] = null;
            Response.Redirect("Repository.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}