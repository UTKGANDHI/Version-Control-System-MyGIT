using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Add_collab : System.Web.UI.Page
    {
        string s,branch,u_name,p_name;
        protected void Page_Load(object sender, EventArgs e)
        {

            DataClasses2DataContext db = new DataClasses2DataContext();

            var q1=(from x in db.Repo_Owners where x.reponame == Path.GetFileName(Session["reponame"].ToString())select x.Type).Single();
            if(q1.Equals("public"))//if public repository then adding the colloborator feature ain't available
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Public repository don't have this feature');", true);
                return;
            }


            var q = (from c in db.Repo_Owners where c.reponame ==Path.GetFileName(Session["reponame"].ToString()) select c.owner).Single();

            
             if(!q.Equals(Session["login_name"].ToString()))//Only owner should be allowed to add colloborators
             {
                 ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Sorry you dont have the administrator right!!');", true);
                 return;
                 //Response.Redirect("~/Repo_homepage.aspx");
             }
            if(!IsPostBack)
            {
                Label1.Text += Path.GetFileName(Session["reponame"].ToString());
            }
            u_name = null;
            if (ListBox1.SelectedIndex != -1)
                u_name = ListBox1.SelectedItem.Text;
            p_name = null;
            if (ListBox2.SelectedIndex != -1)
                p_name = ListBox2.SelectedItem.Text;
            
            showowners();
            showcollab();
        }

        protected void showcollab()
        {
            ListBox2.Items.Clear();
            DataClasses3DataContext db = new DataClasses3DataContext();
            var q = from x in db.Collaborators where x.reponame == Path.GetFileName(Session["reponame"].ToString()) select x.collaborators;
                foreach (var m in q)
                {
                    ListBox2.Items.Add(m.ToString());
                }
         
        }
        protected void showowners()
        {
            ListBox1.Items.Clear();
            DataClasses1DataContext db = new DataClasses1DataContext();
            var q = (from c in db.Users where Session["login_name"].ToString() != c.Username select c.Username);
            foreach(var m in q)
            {
                  ListBox1.Items.Add(m.ToString());
            }
        }
        protected void Button2_Click(object sender, EventArgs e)   //delete
        {
          //s = ListBox1.SelectedItem.Text;
            DataClasses3DataContext db = new DataClasses3DataContext();
            Boolean flag=false;
            if (p_name == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a colloborator to be deleted !!');", true);
                return;
            }

     
            var k = from x in db.Collaborators select x.collaborators;
            foreach(var m in k)
            {
                if(m.ToString()==p_name)
                {
                    flag=true;
                }

            }
            if(flag==true)
            {
                var q = (from c in db.Collaborators where c.collaborators == p_name select c).Single();
                db.Collaborators.DeleteOnSubmit(q);
                db.SubmitChanges();
            }
            else
            {
                //Label1.Text = "error";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('This collaborator isn't added yet !!');", true);

            }
            showcollab();
        }

        protected void Button1_Click(object sender, EventArgs e)          //add
        {
            if (u_name == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a name from the list !!');", true);
                return;
            }
            Boolean flag=true;
            DataClasses3DataContext db = new DataClasses3DataContext();
            var q = from x in db.Collaborators where x.reponame ==  Path.GetFileName(Session["reponame"].ToString()) select x.collaborators;
            foreach(var m in q)
            {
                if (u_name != null)
                {
                    if (m.ToString() == u_name)
                    {
                        flag = false;
                    }
                }
            }
            if(flag==false)             //if already collab
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Collaborator already ADDED !!');", true);
            }
            else
            {
               int x = Int32.Parse(Application["count"].ToString());
                x++;
                Application.Lock();
                Application["count"] = x;
                Application.UnLock();

              

              Collaborator c = new Collaborator();
              c.collaborators = u_name;
              c.reponame =Path.GetFileName(Session["reponame"].ToString());
              c.branch = "not available";
              c.Id=x;
              db.Collaborators.InsertOnSubmit(c);
              db.SubmitChanges();
           }
            showcollab();
        }
        
    }
}