using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class delete_branch : System.Web.UI.Page
    {
        Boolean allowed = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses2DataContext db = new DataClasses2DataContext();
            var q1 = "";
            try
            {
                q1 = (from x in db.Repo_Owners where x.reponame == Path.GetFileName(Session["reponame"].ToString()) select x.Type).Single();
            }
            catch (Exception err)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please browse another repository !!');", true);
            }
            if (q1.Equals("public"))
            {
                allowed = true;
            }
            else
            {

                //checking for adequate permissions
                DataClasses3DataContext dr = new DataClasses3DataContext();

                var q = (from c in dr.Collaborators where Session["login_name"].ToString() == c.collaborators select c).ToList();
                if (q.Count == 0)
                {
                    //check whether is admin is logged in,if he is the one logged in then he should be allowed
                    try
                    {
                        var temp = (from x in db.Repo_Owners where x.reponame == Path.GetFileName(Session["reponame"].ToString()) select x.owner).Single();
                        if (Session["login_name"].ToString() == temp)//admin logged in
                            allowed = true;
                        else
                        {
                            //other than admin logged in
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Not enough permissions!!');", true);
                            allowed = false;
                        }
                    }
                    catch (Exception error)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Server error,Sorry for the inconvenience');", true);
                    }
                }
                else
                {
                    allowed = true;

                }
            }

            if (allowed == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Not enough permissions !!');", true);
                return;
            }

            ShowDirectoriesIn();
        }
        private void ShowDirectoriesIn()
        {
            DropDownList1.Items.Clear();
           // ListBox1.Items.Add("Master");

            DirectoryInfo di = new DirectoryInfo(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString())));
            if (!di.Exists)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No branch of the selected repository exist!!');", true);
                return;

            }
                
            try
            {
                //DirectoryInfo dirInfo = new DirectoryInfo(dir);
                foreach (DirectoryInfo dirItem in di.GetDirectories())
                {
                    DropDownList1.Items.Add(dirItem.Name);
                }
            }
            catch (Exception err)
            {
                // Ignore the error and leave the list box empty.
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (allowed == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Not enough permissions !!');", true);
                return;
            }

            if(DropDownList1.Items.Count==0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('There are no branches available !!');", true);
            }
            else if (DropDownList1.SelectedIndex == -1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a branch!!');", true);
            }
            else
            {
                String path = Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), DropDownList1.SelectedItem.Text);
                if (Directory.Exists(path))
                {
                    //Delete all files from the Directory
                    foreach (string file in Directory.GetFiles(path))
                    {
                        File.Delete(file);
                    }

                    //Delete a branch
                    Directory.Delete(path);
                    Response.Redirect("~/Code.aspx");
                }
            }
        }
    }
}