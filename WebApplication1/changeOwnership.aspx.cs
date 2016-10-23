using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class changeOwnership : System.Web.UI.Page
    {

        DataClasses1DataContext dc; DataClasses2DataContext db;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");
            showRepo();
        }

        protected void showRepo()
        {
            DropDownList1.Items.Clear();
            DataClasses2DataContext db;
            db = new DataClasses2DataContext();
            //c.action==create because we want to show the repositories which currently exist not the one which have been deleted!
            var q = from c in db.GetTable<Repo_Owner>() where c.owner == Session["login_name"].ToString() & c.action=="Create" select c.reponame;
            foreach (var m in q)
            {
                DropDownList1.Items.Add(m.ToString());
            } 
            

        }
        [WebMethod]
        public static string[] GetNames(string prefix)
        {
            List<string> customers = new List<string>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Repo"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select Username from [User] where Username like @SearchText + '%'";
                    cmd.Parameters.AddWithValue("@SearchText", prefix);
                    cmd.Connection = conn;
                    conn.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            customers.Add(sdr["Username"].ToString());
                        }

                    }
                    conn.Close();
                }
            }
            return customers.ToArray();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dc = new DataClasses1DataContext();
            db = new DataClasses2DataContext();
            try
            {

                 User u = dc.Users.Single(c => c.Username== TextBox1.Text );
                 string t = u.Username;
                if(DropDownList1.SelectedIndex==-1)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a repository!!');", true);
                }
                if (u.Username == Session["login_name"].ToString())
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You are already the owner!!');", true);
                }
                else
                {
                    Repo_Owner ro = db.Repo_Owners.Single(c => c.reponame == DropDownList1.SelectedItem.Text);

                    ro.owner = t;
                    db.SubmitChanges();
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Ownership transfered!!');", true);
                }
            }
            catch(Exception err)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Enter a valid username!!');", true);
            }
            showRepo();
        }
    }
}