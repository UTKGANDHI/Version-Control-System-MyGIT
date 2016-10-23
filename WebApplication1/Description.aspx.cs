using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Description : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");

            string line;
            StreamReader r;
            Label1.Text = Path.GetFileName(Session["reponame"].ToString());
            if(!IsPostBack)
            {
                if(File.Exists(Path.Combine("G:/Git/", Path.GetFileName(Session["reponame"].ToString()))))
                {
                r = File.OpenText(Path.Combine("G:/Git/", Path.GetFileName(Session["reponame"].ToString()),"Description.txt"));
                do
                {
                    line = r.ReadLine();
                    if (line != null)
                    {
                        TextBox1.Text = TextBox1.Text + line;
                    }
                }while (line != null);
                r.Close();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Sorry no description exists for selected repository!!');", true);
                    return;
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine("G:/Git/", Path.GetFileName(Session["reponame"].ToString()), "Description.txt"), TextBox1.Text);
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Your changes are saved!!');", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Repo_homepage.aspx");
        }
    }
}