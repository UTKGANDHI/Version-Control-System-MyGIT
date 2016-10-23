using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["repo"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string query = "Select count(*) as c from dbo.repository";
            string query1 = "Select count(*) as c from dbo.Repo_Owner";
            
            cmd.CommandText = query;
            con.Open();
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            Application["count"] = (int)rdr["c"];

            //dusre table ke liye!!
            cmd.CommandText = query1;
            rdr.Close();
            rdr=cmd.ExecuteReader();
            rdr.Read();
            Application["count1"] = (int)rdr["c"];
            con.Close();
            
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
            {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}