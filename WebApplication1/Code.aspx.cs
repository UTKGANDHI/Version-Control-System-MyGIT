using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication1
{
    public partial class Code : System.Web.UI.Page
    {
        string uploaddirectory,lbox,com;//class variable

        /*protected void Button2_click(object sender, EventArgs e)
        {
            if (DropDownList1.Items.Count == 0)
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
        }*/
      /*  private void ShowDirectoriesIn()
        {
            DropDownList1.Items.Clear();
            // ListBox1.Items.Add("Master");

            DirectoryInfo di = new DirectoryInfo(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString())));
            if (!di.Exists)
                return;
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
        }*/

      /*  protected void Button1_click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter a valid name !!');", true);
            }
            else
            {
                Branch.DirectoryCopy(Session["reponame"].ToString(), TextBox1.Text);
                string emailid = Email.getEmail(Session["login_name"].ToString());
                Email.SendEmail(emailid, "Branch Created", "A branch has been created in the repository: " + Session["reponame"].ToString() + " by the name " + TextBox1.Text + " ");
                // ShowDirectoriesIn();
                Response.Redirect("~/Code.aspx");
            }
        }*/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");

       //     ShowDirectoriesIn();

            /*if (!IsPostBack)
            {
                ListBox2.Items.Add("Master");
            
                ListBox2.SelectedIndex = 0;
                if (Directory.Exists(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()))))

                    ShowDirectoriesIn();
            
            }
            else
            {
                if (ListBox2.SelectedIndex == -1)
                    com = "Master";
                else
                {
                    com = ListBox2.SelectedItem.Text;
                }
                
            }*/
            
        }
        
        /*private void ShowDirectoriesIn()
        {
            ListBox2.Items.Clear();
            ListBox2.Items.Add("Master");
            
            DirectoryInfo di = new DirectoryInfo(Path.Combine("G:/Git Branch/",Path.GetFileName(Session["reponame"].ToString())));
            if (!di.Exists)
                return;
            try
            {
                //DirectoryInfo dirInfo = new DirectoryInfo(dir);
                foreach (DirectoryInfo dirItem in di.GetDirectories())
                {
                    ListBox2.Items.Add(dirItem.Name);
                }
            }
            catch (Exception err)
            {
                // Ignore the error and leave the list box empty.
            }
        }

        protected void Refreshlist(string path)
        {
            ListBox1.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            foreach (FileInfo ﬁleItem in dirInfo.GetFiles())
            {
                ListBox1.Items.Add(ﬁleItem.Name);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)//upload
        {
            string branchname;
            try
            {
                lbox = com;
                string serverFileName = Path.GetFileName(FileUpload1.FileName);  
                uploaddirectory = Session["reponame"].ToString();
                if (String.Equals(lbox,"Master"))
                {
                    string final = Path.Combine(uploaddirectory, serverFileName);
                    FileUpload1.PostedFile.SaveAs(final);
                }
                else
                {
                    branchname = com;
                    string upath = Path.Combine("G:/Git Branch/",Path.GetFileName(uploaddirectory),branchname,serverFileName);
                    FileUpload1.PostedFile.SaveAs(upath);
                }
            }
            catch (Exception f)
            {
                Label1.Text = f.ToString();
            }
            //com = ListBox2.SelectedItem.Text;
            if (string.Equals(com, "Master"))
                Refreshlist(Session["reponame"].ToString());
            else
                Refreshlist(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), com));
            //logging code
            
            int x = Int32.Parse(Application["count"].ToString());
            x++;
            Application.Lock();
            Application["count"] = x;
            Application.UnLock();
            Logging.operationLog(x, Path.GetFileName(Session["reponame"].ToString()), FileUpload1.FileName, Session["login_name"].ToString(), "Upload", com);
            graphlogging.insertlog(Path.GetFileName(Session["reponame"].ToString()), com, "Addition", x);
            
        }

        protected void Button2_Click(object sender, EventArgs e)//Delete
        {
            
            int a = 0;
            if (ListBox1.Items.Count.Equals(a))
            {
            
                Label2.Text = "There are no such file in the repository ! ";
            }
            else
            {
                string temp;
                uploaddirectory = Session["reponame"].ToString();


               if (string.Equals(com, "Master"))
                    temp = Path.Combine(Session["reponame"].ToString(), ListBox1.SelectedItem.Text);

                else
                    temp = Path.Combine("G:/Git Branch/", Path.GetFileName(uploaddirectory),com,ListBox1.SelectedItem.Text);      
           
                Label2.Text = temp;
                FileInfo fi = new FileInfo(temp);
                fi.Delete();
                //Refreshlist();
                if (string.Equals(com, "Master"))
                    Refreshlist(Session["reponame"].ToString());
                else
                    Refreshlist(Path.Combine("G:/Git Branch/", Path.GetFileName(uploaddirectory), com));
            
                int x = Int32.Parse(Application["count"].ToString());
                x++;
                Application.Lock();
                Application["count"] = x;
                Application.UnLock();
                Logging.operationLog(x, Path.GetFileName(Session["reponame"].ToString()), Path.GetFileName(temp), Session["login_name"].ToString(), "Delete", com);
                graphlogging.insertlog(Path.GetFileName(Session["reponame"].ToString()), com, "Deletion", x);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)//Download
        {
            string directory;
            if (ListBox2.SelectedItem.Text == "Master")
                directory = Path.Combine("G:/Git/", Session["reponame"].ToString());
            else
                directory = Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()),ListBox2.SelectedItem.Text);

            string path = Path.Combine(directory,ListBox1.SelectedItem.Text); //get physical file path from server
            string name = Path.GetFileName(path); //get file name
            string ext = Path.GetExtension(path); //get file extension
            string type = "";

            // set known types based on file extension
            if (ext != null)
            {
                switch (ext.ToLower())
                {
                    case ".htm":
                    case ".html":
                        type = "text/HTML";
                        break;
                    case ".jpg":
                        type = "image/jpeg";
                        break;

                    case ".txt":
                        type = "text/plain";
                        break;

                    case ".GIF":
                        type = "image/GIF";
                        break;

                    case ".pdf":
                        type = "Application/pdf";
                        break;

                    case ".doc":
                    case ".rtf":
                        type = "Application/msword";
                        break;
                }
            }

            Response.AppendHeader("content-disposition", "attachment; filename=" + name);

            if (type != "")
                Response.ContentType = type;
            Response.WriteFile(path);

            int x = Int32.Parse(Application["count"].ToString());
            x++;
            Application.Lock();
            Application["count"] = x;
            Application.UnLock();

            Logging.operationLog(x, Path.GetFileName(Session["reponame"].ToString()), Path.GetFileName(ListBox1.SelectedItem.Text), Session["login_name"].ToString(), "Download", com);
            
            Response.End(); 

            //logging operation
            
        }

        protected void Button4_Click(object sender, EventArgs e)    //create branch
        {
            Branch.DirectoryCopy(Session["reponame"].ToString(),TextBox1.Text);
            string emailid=Email.getEmail(Session["login_name"].ToString());
            Email.SendEmail(emailid,"Branch Created","A branch has been created in the repository: "+Session["reponame"].ToString()+" by the name "+TextBox1.Text+" ");
            ShowDirectoriesIn();
            //Label2.Text = "done";
           
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }

        protected void Button5_Click(object sender, EventArgs e) // show files
        {

            if (string.Equals(com, "Master"))
                Refreshlist(Session["reponame"].ToString());
            else
                Refreshlist(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), com));
         
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Compare.aspx?branchname="+com);
        }
        */
        /*protected void Button7_Click(object sender, EventArgs e)
        {
           if (ListBox2.SelectedIndex == -1)
                return;
            if ((com=="Master"))
                Refreshlist(Session["reponame"].ToString());
            else
                Refreshlist(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), com));
         
        }*/
        }
    }
