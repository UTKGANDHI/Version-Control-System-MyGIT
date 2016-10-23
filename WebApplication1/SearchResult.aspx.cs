using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace WebApplication1
{
    public partial class SearchResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");

        }

        [WebMethod]
        public static string[] GetCustomers(string prefix)
        {
            List<string> customers = new List<string>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Repo"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select reponame from [Repo_Owner] where reponame like @SearchText + '%'";
                    cmd.Parameters.AddWithValue("@SearchText", prefix);
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            customers.Add( sdr["reponame"].ToString());               
                        }

                    }
                    conn.Close();
                }
            }
            return customers.ToArray();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != null)
            {
                Session["reponame"] = Path.Combine("G:/Git/", txtSearch.Text);
                Response.Redirect("~/Repo_homepage.aspx");
            }
        }
    }
}