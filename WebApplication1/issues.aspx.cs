using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace WebApplication1
{
    public partial class issues : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["repo"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            string x=Path.GetFileName(Session["reponame"].ToString());
            
            cmd.CommandText = "select * from dbo.repository where reponame=@rn";
            cmd.Parameters.AddWithValue("rn",x);
            SqlDataReader rdr = cmd.ExecuteReader();

            GridView1.DataSource = rdr;
            GridView1.DataBind();
            if(GridView1.Rows.Count==0)
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No issues for the selected repository');", true);
        }
    }
}