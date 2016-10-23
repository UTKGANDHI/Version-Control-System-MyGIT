using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebApplication1
{
    public static class Logging
    {
        public static void insertlog(string combinedpath,int x,string type,string username,string reponame,string action)//logging when a new repository is created
        {
            

            SqlConnection myconn = new SqlConnection();
            myconn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Gagan Maheshwari\Desktop\WebApplication1\WebApplication1\App_Data\Database1.mdf;Integrated Security=True";
            myconn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = myconn;
            string t; // type of repo
            if (type.Equals("Public"))
            {
                t = "public";
            }
            else
            {
                t = "private";
            }
            string d = DateTime.Now.ToString().Substring(0, 10);

            cmd.CommandText = "insert into dbo.Repo_Owner (owner,reponame,timestamp,action,Id,Type) Values (@owner,@reponame,@time,@action,@id,@Type)";
            cmd.Parameters.AddWithValue("@owner", username);
            cmd.Parameters.AddWithValue("@reponame", reponame);// instead of combined path i have used textbx3
            cmd.Parameters.AddWithValue("@time", d);
            cmd.Parameters.AddWithValue("@action", action);
            cmd.Parameters.AddWithValue("@id", x);
            cmd.Parameters.AddWithValue("@Type", t);
            cmd.ExecuteNonQuery();
            myconn.Close();
        }
        public static void operationLog(int x,string reponame,string filename,string username,string action,string branchname)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["repo"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string insertsql;

            insertsql = "Insert into dbo.repository(Id,time,username,reponame,description,filename,Branchname)VALUES(@id,@ts,@us,@re,@ds,@fn,@bn)";
            con.Open();
            cmd.Parameters.AddWithValue("@id", x);
            cmd.Parameters.AddWithValue("@ts", DateTime.Now);
            cmd.Parameters.AddWithValue("@us", username);
            cmd.Parameters.AddWithValue("@re", reponame);
            cmd.Parameters.AddWithValue("@ds", action);
            cmd.Parameters.AddWithValue("@fn", filename);
            cmd.Parameters.AddWithValue("@bn", branchname);
            cmd.CommandText = insertsql;
            int n = 0;
            try
            {
                n = cmd.ExecuteNonQuery();
            }
            catch (Exception es)
            {
            }
            con.Close();
            
        }
    }
}