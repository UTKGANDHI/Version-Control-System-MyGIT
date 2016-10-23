using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Graph : System.Web.UI.Page
    {
        string branchname;
        DataClasses2DataContext db;
        DataClasses3_repositoryDataContext dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");

                if (!IsPostBack)
                {
                    DropDownList1.Items.Clear();
                    db = new DataClasses2DataContext();
                    var q = from c in db.Repo_Owners where c.owner == Session["login_name"].ToString() select c.reponame;
                    foreach (var m in q)
                    {
                        DropDownList1.Items.Add(m.ToString());
                    }

                    DropDownList1.SelectedIndex = 0;
                }
                if (IsPostBack)
                {
                    if(DropDownList2.SelectedIndex!=-1)

                    DropDownList2.Items.Clear();
                    dr = new DataClasses3_repositoryDataContext();
                    var q1 = (from c in dr.repositories where DropDownList1.SelectedItem.Text == c.reponame select c.Branchname).Distinct();

                    foreach (var t in q1)
                    {
                        DropDownList2.Items.Add(t.ToString());
                    }
                }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == -1 || DropDownList2.SelectedIndex == -1 || DropDownList3.SelectedIndex == -1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select all the parameters !!');", true);
            }
            else
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["repo"].ConnectionString);
                SqlCommand s = new SqlCommand("SELECT timestamp,COUNT(action) AS Expr1 FROM FileAct WHERE (reponame = @reponame ) AND (branchname = @branchname) AND (action = @action) GROUP BY timestamp", con);
                s.Parameters.AddWithValue("@reponame", DropDownList1.SelectedItem.Text);
                s.Parameters.AddWithValue("@branchname", DropDownList2.SelectedItem.Text);
                s.Parameters.AddWithValue("@action", DropDownList3.SelectedItem.Text);
                con.Open();
                SqlDataReader rdr = s.ExecuteReader();
                Chart1.DataBindTable(rdr, "timestamp");
                if(!rdr.HasRows)
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('For the activity selected no entries exist !!');", true);
                rdr.Close();
                con.Close();
            }
        }

        protected void Chart1_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}