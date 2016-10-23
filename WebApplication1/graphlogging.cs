using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebApplication1
{
    public static class graphlogging
    {
        public static void insertlog(string reponame,string branchname,string action,int count)
        {
            SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["repo"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string insertsql;
            string temp = DateTime.Now.ToString();
            temp=temp.Substring(0,10);
            insertsql = "Insert into dbo.FileAct(Id,timestamp,reponame,branchname,action)VALUES(@id,@ts,@rn,@bn,@action)";
            con.Open();
            cmd.Parameters.AddWithValue("@id", count);
            cmd.Parameters.AddWithValue("@ts", temp);
            cmd.Parameters.AddWithValue("@rn", reponame);
            cmd.Parameters.AddWithValue("@action", action);
            cmd.Parameters.AddWithValue("@bn", branchname);
            cmd.CommandText = insertsql;
            int n = 0;
            try
            {
                n = cmd.ExecuteNonQuery();
                //Label2.Text = n.ToString();
            }
            catch (Exception es)
            {
                
            }
            con.Close();
        }
    }
}