using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Repository.aspx");
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter a valid name !!');", true);
            }
            else
            {
                Branch.DirectoryCopy(Session["reponame"].ToString(), TextBox1.Text);
                string emailid = Email.getEmail(Session["login_name"].ToString());
                Email.SendEmail(emailid, "Branch Created", "A branch has been created in the repository: " + Session["reponame"].ToString() + " by the name " + TextBox1.Text + " ");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Branch succesfully created !!');", true);
            }
        
        }
    }
}