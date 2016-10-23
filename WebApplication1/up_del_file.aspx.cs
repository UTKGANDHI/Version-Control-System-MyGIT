using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class up_del_file : System.Web.UI.Page
    {
        string com,uploaddirectory,lbox;
        Boolean allowed;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Determining whether public or private
            DataClasses2DataContext db = new DataClasses2DataContext();
            var q1="";
            try
            {
                 q1 = (from x in db.Repo_Owners where x.reponame == Path.GetFileName(Session["reponame"].ToString()) select x.Type).Single();
            }
            catch(Exception err)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please browse another repository !!');", true);
            }
            if(q1.Equals("public"))
            {
                allowed = true;
            }
            else
            {

            //checking for adequate permissions
            DataClasses3DataContext dr=new DataClasses3DataContext();
            
            var q = (from c in dr.Collaborators where Session["login_name"].ToString()==c.collaborators select c).ToList();
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
                }catch(Exception error)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Server error,Sorry for the inconvenience');", true);
                }
            }
            else
            {
                allowed = true;
                
            }
            }
            if (!IsPostBack)
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

            }
            if(ListBox2.SelectedIndex!=-1)
            Label1.Text =ListBox2.SelectedItem.Text ;
        }
        private void ShowDirectoriesIn()
        {
            ListBox2.Items.Clear();
             ListBox2.Items.Add("Master");
             
            DirectoryInfo di = new DirectoryInfo(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString())));
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


        protected void Button1_Click(object sender, EventArgs e)// show files in
        {
            if (string.Equals(com, "Master"))
                Refreshlist(Session["reponame"].ToString());
            else
                Refreshlist(Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), com));
         
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

        protected void Button2_Click(object sender, EventArgs e)// upload
        {
            if(FileUpload1.FileName=="")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a file!!');", true); return;
            }
            if (allowed == false)
                return;
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
                //Label1.Text = f.ToString();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Sorry, maximum file size is 4MB. Try another file !!');", true); 
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(ListBox1.SelectedIndex==-1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a file !!');", true);
                return;
            }
            if (allowed == false)
                return;
            


            int a = 0;
            if (ListBox1.Items.Count.Equals(a))
            {

                Label1.Text = "There are no such file in the repository ! ";
            }
            else
            {
                string temp;
                uploaddirectory = Session["reponame"].ToString();


                if (string.Equals(com, "Master"))
                    temp = Path.Combine(Session["reponame"].ToString(), ListBox1.SelectedItem.Text);

                else
                    temp = Path.Combine("G:/Git Branch/", Path.GetFileName(uploaddirectory), com, ListBox1.SelectedItem.Text);

                //Label1.Text = temp;
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

        protected void Button4_Click(object sender, EventArgs e)// dwnld
        {
            if(ListBox1.SelectedIndex==-1)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a file !!');", true); return;
            }
            if (allowed == false)
                return;
            


            string directory;
            if (ListBox2.SelectedItem.Text == "Master")
                directory = Path.Combine("G:/Git/", Session["reponame"].ToString());
            else
                directory = Path.Combine("G:/Git Branch/", Path.GetFileName(Session["reponame"].ToString()), ListBox2.SelectedItem.Text);

            string path = Path.Combine(directory, ListBox1.SelectedItem.Text); //get physical file path from server
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
            
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if(com=="Master")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please select a branch other than master !!');", true); return;
            }
            else
            Response.Redirect("~/Compare.aspx?branchname=" + com);
        }
    }
}