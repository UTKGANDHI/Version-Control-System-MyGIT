using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace WebApplication1
{
    public partial class CreateRepository : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text=="" && RadioButtonList1.SelectedIndex==-1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter the repository name!!');", true);
            }
            else
            {
                string absolutepath = @"G:\GIT\";
                string combinedpath = Path.Combine(absolutepath, TextBox1.Text);
                if (Directory.Exists(combinedpath))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Directory already exists.');", true);
                }
                else
                {
                    Directory.CreateDirectory(combinedpath);
                    Session["reponame"] = combinedpath;
                    //code for creating a log file for each repository
                    int x = Int32.Parse(Application["count1"].ToString());
                    x++;
                    Application.Lock();
                    Application["count1"] = x;
                    Application.UnLock();
                    Logging.insertlog(combinedpath, x, RadioButtonList1.SelectedItem.Text, Session["login_name"].ToString(),TextBox1.Text,"Create");
                    //Creating the description file
                    create_description();
                    //fetching the email id of the actor
                    string emailid=Email.getEmail(Session["login_name"].ToString());
                    //sending the email
                    Email.SendEmail(emailid,"Repository created","A repository by the name "+TextBox1.Text+" has been created by your registered account");
                    Response.Redirect("Repo_homepage.aspx");
                }

            }
        }
        protected void create_description()
        {
            if (TextBox2.Text != null)
            {
                StreamWriter w;
                w = File.CreateText(Path.Combine(Session["reponame"].ToString(), "Description.txt"));
                w.Write(TextBox2.Text);
                w.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)//discard button pressed
        {
            Response.Redirect("Repository.aspx");
        }
    }
}