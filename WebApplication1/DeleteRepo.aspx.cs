using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace WebApplication1
{
    public partial class DeleteRepo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");
            if (!IsPostBack)
                refreshlist();
        }

        protected void refreshlist()
        {
            DropDownList1.Items.Clear();
            DataClasses2DataContext db;
            db = new DataClasses2DataContext();
            //DropDownList1.Items.Add("Select");
            var q = from c in db.GetTable<Repo_Owner>() where c.owner == Session["login_name"].ToString() & c.action=="Create" select c.reponame;
            foreach (var m in q)
            {
                DropDownList1.Items.Add(m.ToString());
            }
            if(DropDownList1.Items.Count==0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You don't own a single repository as an administrator !!');", true);
                return;
            }
            

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            //role management code is remaining
            DataClasses2DataContext db = new DataClasses2DataContext();
            try
            {              
                    //Deleting the main Repository
                    if(Directory.Exists((Path.Combine("G:/Git/",DropDownList1.SelectedItem.Text))))
                        Directory.Delete(Path.Combine("G:/Git/",DropDownList1.SelectedItem.Text), true);
                    //Deleting the branches
                    String temp = Path.Combine("G:/Git Branch/", Path.GetFileName(DropDownList1.SelectedItem.Text));
                    if(Directory.Exists(temp))
                        Directory.Delete(temp, true);
                    //deleting the entry in the repo owner table of the corresponding repository so that it's not shown again
                    var entry = (from c in db.Repo_Owners where c.reponame == DropDownList1.SelectedItem.Text & c.owner == Session["login_name"].ToString() & c.action == "Create" select c).Single();
                    db.Repo_Owners.DeleteOnSubmit(entry);
                    db.SubmitChanges();


                    string emailid = Email.getEmail(Session["login_name"].ToString());
                    //logging the activity
                    int x = Int32.Parse(Application["count1"].ToString());
                    x++;
                    Application.Lock();
                    Application["count1"] = x;
                    Application.UnLock();

                    Logging.insertlog("Testing", x, "Public", Session["login_name"].ToString(), DropDownList1.SelectedItem.Text, "Delete");
                    Email.SendEmail(emailid, "Repository deleted", "The repository by the name " + Path.GetFileName(DropDownList1.SelectedItem.Text) + " has been deleted");
                    Session["reponame"] = null;
                    Response.Redirect("~/Repository.aspx");
              
            }catch(Exception error)
            {
                //Response.Redirect("~/Repository.aspx");
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error deleting repository,Please try again later!!');", true);
            }
        }
    }
}