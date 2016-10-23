using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class Compare : System.Web.UI.Page
    {
       
        string branchname;
        DataClasses2DataContext db;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");
            branchname = Request.QueryString["branchname"];

            db = new DataClasses2DataContext();
            //checking for ownership of repository
            var query = from c in db.GetTable<Repo_Owner>()
                        where c.owner.Equals(Session["login_name"].ToString())
                        select c.reponame;
            bool allow = false;
            string temp = Path.GetFileName(Session["reponame"].ToString());
            foreach (var q in query)
            {
                if (temp==(q))
                {
                    allow = true;//if owner then allowed to compare
                    break;
                }
            }
            if (allow == false)
            {
                int x = Int32.Parse(Application["count"].ToString());
                x++;
                Application.Lock();
                Application["count"] = x;
                Application.UnLock();
                
                string sender1 = Session["login_name"].ToString();
                Commit.merge(x, Session["reponame"].ToString(), branchname, sender1, "");
  
                Response.Redirect("Repository.aspx");
            }
            
            if (!IsPostBack)
            {
                Label1.Text=Path.GetFileName(Session["reponame"].ToString());
                Label2.Text = branchname;
                populateListBox(Path.Combine("G:/Git/", Path.GetFileName(Session["reponame"].ToString())), "Master");//populating master branch
                populateListBox(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), branchname), branchname);
            }
        }
        public void populateListBox(string path,string branchname)
        {
            //lblFileInfo.Text = "";
            if (string.Equals(branchname, "Master"))
                ListBox1.Items.Clear();
            else
                ListBox2.Items.Clear();

            try
            {
                
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (string.Equals(branchname, "Master"))
                {
                    foreach (FileInfo ﬁleItem in dirInfo.GetFiles())
                    {
                        ListBox1.Items.Add(ﬁleItem.Name);
                    }
                }
                else
                {
                    foreach (FileInfo ﬁleItem in dirInfo.GetFiles())
                    {
                        ListBox2.Items.Add(ﬁleItem.Name);
                    }
                }
            }
            catch (Exception err)
            {
                //Label4.Text=err.ToString();
                // Ignore the error and leave the list box empty.
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label3.Text = ListBox1.SelectedItem.Text;
            if (!(Path.GetExtension(Path.Combine("G:/Git/", Path.GetFileName(Session["reponame"].ToString()), ListBox1.SelectedItem.Text)) == ".txt"))
                return;
            string line;
            StreamReader r;
            TextBox1.Text = "";
            r = File.OpenText(Path.Combine("G:/Git/",Path.GetFileName(Session["reponame"].ToString()),ListBox1.SelectedItem.Text));
              do
              {
                line = r.ReadLine();  
                 if (line != null)  
                {
                  TextBox1.Text = TextBox1.Text + line;  
                } 
             } while (line != null);
              r.Close();
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label4.Text = ListBox2.SelectedItem.Text;
            if (!((Path.GetExtension(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()),branchname,ListBox2.SelectedItem.Text))) == ".txt"))
                return;
            string line;
            StreamReader r;
            TextBox2.Text = "";
            r = File.OpenText(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()),branchname, ListBox2.SelectedItem.Text));
            do
            {
                line = r.ReadLine();
                if (line != null)
                {
                    TextBox2.Text = TextBox2.Text  + line;
                }
            } while (line != null);
            r.Close();
        }

        
        protected void Button2_Click(object sender, EventArgs e)//save button pressed
        {
            string[] ans = null;
            int c = 0;
            ans = Commit.compare(Session["reponame"].ToString(),Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), branchname));
            foreach(string temp in ans)
            {
                if (temp == null)
                    break;
                c++;
            }
            DirectoryInfo d = new DirectoryInfo(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), branchname));
            if (c == 0)
            {
             //   Label5.Text = "No Conflict!\n";
                Label6.Text += "Save changes or not :";
                

                foreach (FileInfo f in d.GetFiles())
                {
                    f.CopyTo(Path.Combine(Session["reponame"].ToString(), f.Name));
                }

                populateListBox(Path.Combine("G:/Git/", Path.GetFileName(Session["reponame"].ToString())), "Master");
                Label6.Text = "Merged successfully";
            
            }
            else
            {
                Label5.Text = "Conflict exist!";
                //before redirecting to the select version page we will have to copy not conflicting file of branch's to master repository
                //logic for copying not conflicting file is as below....

                foreach (FileInfo f in d.GetFiles())
                {
                    if (!ans.Contains(f.Name))
                    {
                        f.CopyTo(Path.Combine(Session["reponame"].ToString(), f.Name));
                    }
                }
                Session["files"] = ans;
                //now as the conflict exists,we will have to resolve it.Conflict can be resolved by asking the administrator 
                //his choice for each conflicting file,whether he wants to keep the master's version or the selected branch version?

                Response.Redirect("~/selectVersion.aspx?branchname=" + branchname);
            }
        
            
        }

        protected void Button3_Click(object sender, EventArgs e)//discard button pressed
        {
            Response.Redirect("~/Repo_homepage.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)//Show conflicting button pressed
        {
            string[] ans = null;
            ans = Commit.compare(Session["reponame"].ToString(), Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), branchname));
            Session["files"] = ans;
            Response.Redirect("~/ShowConflictingFiles.aspx");
        }

    }
}