using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class ShowConflictingFiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");


            string[] getmyarray = (string[])Session["files"];
            foreach(string file in getmyarray)
            {
                if (file == null)
                    break;
                ListBox1.Items.Add(file);
            }
            
        }
    }
}