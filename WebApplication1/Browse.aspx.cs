using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class Browse : System.Web.UI.Page
    {
        //ListItem item;
        string absolutepath = @"G:\GIT\";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");
            if (!IsPostBack)
            {
                ShowDirectoriesIn();
                ShowFilesIn();
            }
        }
         private void ShowDirectoriesIn()
         {
             
             DirectoryInfo di = new DirectoryInfo(absolutepath);
            
             ListBox1.Items.Clear();
             try
             {
                 //DirectoryInfo dirInfo = new DirectoryInfo(dir);
                 foreach (DirectoryInfo dirItem in di.GetDirectories())
                 {
                     ListBox1.Items.Add(dirItem.Name);
                 }
                 ListBox1.SelectedIndex = 0;
             }
             catch (Exception err)
             {
                 // Ignore the error and leave the list box empty.
             }
         } 

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



        }
        private void ShowFilesIn()
        {
            //lblFileInfo.Text = "";
            ListBox2.Items.Clear();
            
            try
            {
                //Label4.Text = Path.Combine(absolutepath, ListBox1.SelectedItem.Text);
                DirectoryInfo dirInfo = new DirectoryInfo(Path.Combine(absolutepath,ListBox1.SelectedItem.Text));
                foreach (FileInfo ﬁleItem in dirInfo.GetFiles())
                {
                    ListBox2.Items.Add(ﬁleItem.Name);

                }
            }
            catch (Exception err)
            {
            //Label4.Text=err.ToString();
                    // Ignore the error and leave the list box empty.
            }
        } 

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBox2.SelectedIndex!=-1)
            {
                Label4.Text=File.GetLastAccessTime(Path.Combine(absolutepath,ListBox1.SelectedItem.Text,ListBox2.SelectedItem.Text)).ToString();
                Label5.Text=File.GetCreationTime(Path.Combine(absolutepath,ListBox1.SelectedItem.Text,ListBox2.SelectedItem.Text)).ToString();;
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            ShowFilesIn();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["reponame"] = Path.Combine("G:/Git/",ListBox1.SelectedItem.Text);
            Response.Redirect("~/Repo_homepage.aspx");
        }
    }
}