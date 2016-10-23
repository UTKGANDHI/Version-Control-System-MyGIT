using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Services;
using System.Configuration;

namespace WebApplication1
{
    public partial class Repository : System.Web.UI.Page
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
                            customers.Add(sdr["reponame"].ToString());
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
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["Repo"].ConnectionString;
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "select reponame from [Repo_Owner] where reponame like @SearchText ";
                        cmd.Parameters.AddWithValue("@SearchText", txtSearch.Text);
                        cmd.Connection = conn;
                        conn.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                          if(!sdr.HasRows)
                          {
                              ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No such repository exist !!');", true); return;
                          }

                        }
                        conn.Close();
                    }
                }
                Session["reponame"] = Path.Combine("G:/Git/", txtSearch.Text);
                Response.Redirect("~/Repo_homepage.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter the name !!');", true);
            }
            
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {

        }
    }
}