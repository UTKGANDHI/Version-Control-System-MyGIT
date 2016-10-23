using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class show_merge_req : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses4_mergeDataContext dm = new DataClasses4_mergeDataContext();
            merge_req m = new merge_req();
            GridView1.DataBind();
            if(GridView1.Rows.Count==0)
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('There are no notifications !!');", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             GridViewRow row = GridView1.SelectedRow;
             string branchname = row.Cells[3].Text;
             Session["reponame"]= Path.Combine("G:/GIT/",row.Cells[2].Text);
             Session["notification"] = "yes";
             Response.Redirect("~/Compare.aspx?branchname="+branchname);
    
        }
    }
}