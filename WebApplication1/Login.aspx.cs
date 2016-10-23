using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class lgn : System.Web.UI.Page
    {
        DataClasses1DataContext db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
            if (Session["login_name"] != null)
                Response.Redirect("Repository.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String pass =TextBox1.Text;
            //MovieDb db = new MovieDb();
            var x = (from c in db.GetTable<User>()
                     where c.Username == UserName.Text && c.Password == pass
                     select c).ToList<User>();
            if (x.Count == 1)//Successful retrieve
            {
                //Maintaining the session code
                Session["login_name"] = UserName.Text;
                Response.Redirect("Repository.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Invalid credentials !!');", true);
                UserName.Text = "";
                TextBox1.Text = "";
            }

 
        }
    }
}