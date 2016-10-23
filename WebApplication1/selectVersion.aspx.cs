using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class selectVersion : System.Web.UI.Page
    {
        string branchname, notification;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");
            notification=Request.QueryString["From"];

            if(!IsPostBack)
            {
                branchname = Request.QueryString["branchname"];
                Button2.Text = branchname;
                string[] getmyarray = (string[])Session["files"];
                foreach (string file in getmyarray)
                {
                    if (file == null)
                        break;
                    ListBox1.Items.Add(file);
                }
            
            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)//if master button pressed then no need of doing anything,we will just refresh the
                                                                //listbox by removing the selected file
        {//error handling required
            ListBox1.Items.Remove(ListBox1.SelectedItem);
            refresh();
            //Page_Load(sender,e);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex == -1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a file !!');", true);
            }
            else
            {
                //error handling required

                //retrieving repository name
                string reponame = Path.GetFileName(Session["reponame"].ToString());
                string sourcefile = Path.Combine("G:/Git Branch/", reponame, Button2.Text, ListBox1.SelectedItem.Text);
                string destinationfile = Path.Combine("G:/Git/", Path.GetFileName(reponame), ListBox1.SelectedItem.Text);
                try
                {
                    File.Copy(sourcefile, destinationfile, true);
                    //File.Delete(sourcefile);
                    //File.Delete();
                }
                catch (Exception err)
                {
                    //error copying file
                }
                ListBox1.Items.Remove(ListBox1.SelectedItem);
                refresh();
                //Page_Load(sender, e);
            }
        }
        protected void refresh()
        {
            if (ListBox1.Items.Count == 0)//testing purpose
            {

                if (Session["notification"]!=null)
                {
                    DataClasses4_mergeDataContext dm = new DataClasses4_mergeDataContext();

                    var q = (from c in dm.merge_reqs where c.reponame == (Session["reponame"].ToString()) && c.branchname == Button2.Text select c).Single();
                    dm.merge_reqs.DeleteOnSubmit(q);
                    dm.SubmitChanges();

                }
                Response.Redirect("Repository.aspx");
            }
        }
    }
}