using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;

namespace trial
{
    public partial class main_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /*Random rand = new Random();
                int toSkip = rand.Next(1, context.Playlists.Count());

                var query1 = (from c in context.Playlists
                              select new { Playlist_Name = c.Playlistname, Img_Id = c.Username });
                var rows = query1.OrderBy(c => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();
                var list = new List<object> { rows };
                GridView1.DataSource = list;
                GridView1.DataBind();

                toSkip = rand.Next(1, context.Playlists.Count());
                var query2 = (from c in context.Playlists
                              select new { Playlist_Name = c.Playlistname, Img_Id = c.Username });
                var rows2 = query2.OrderBy(c => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();
                var list2 = new List<object> { rows2 };
                GridView2.DataSource = list2;
                GridView2.DataBind();

                toSkip = rand.Next(1, context.Playlists.Count());
                var query3 = (from c in context.Playlists
                              select new { Playlist_Name = c.Playlistname, Img_Id = c.Username });
                var rows3 = query3.OrderBy(c => Guid.NewGuid()).Skip(toSkip).Take(1).FirstOrDefault();
                var list3 = new List<object> { rows3 };
                GridView3.DataSource = list3;
                GridView3.DataBind();*/
            }
        }
        //MusicdbDataContext context = new MusicdbDataContext();
        //User u = new User();

        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {
           // Response.Redirect("Profile.aspx");
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
           // Response.Redirect("Search.aspx");

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("main_page.aspx");
        }
        /*string url;
        protected void GridViewdisplaysong1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string name = GridView1.SelectedRow.Cells[1].Text.ToString();

                         var query1 = from c in context.Playlists
                         where c.Playlistname == name
                         select c.Playlist_Id;
                         int id = query1.First();

                         int playlistid = query1.First();
            var query2 = from c in context.Song_to_Playlists
                                     join b in context.Songs
                                     on c.Song_Id equals b.Song_Id
                                     where c.Playlist_Id == id
                                     select new { song = b.File.ToArray(), songname = b.Songname };
            try
            {
                var ifnull = query2.First();
                if (ifnull != null)
                {
                    GridView4.DataSource = query2;
                    GridView4.DataBind();
                }
            }
            catch (Exception ex)
            { Label5.Text = "No results"; }

            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView3.DataSource = null;
            GridView3.DataBind();
            GridView2.DataSource = null;
            GridView2.DataBind();
         
        }

        protected void GridViewdisplaysong2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string name=GridView2.SelectedRow.Cells[1].Text.ToString();


            var query1 = from c in context.Playlists
                         where c.Playlistname.Equals(name)
                         select c.Playlist_Id;

            int playlistid = query1.First();
            var query2 = from c in context.Song_to_Playlists
                         join b in context.Songs
                         on c.Song_Id equals b.Song_Id
                         where c.Playlist_Id == query1.First()
                         select new { song = b.File.ToArray(), songname = b.Songname };
            try
            {
                var ifnull = query2.First();
                if (ifnull != null)
                {
                    GridView4.DataSource = query2;
                    GridView4.DataBind();
                }
            }
            catch (Exception ex)
            { Label5.Text = "No results"; }
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView3.DataSource = null;
            GridView3.DataBind();
            GridView2.DataSource = null;
            GridView2.DataBind();

        }

        protected void GridViewdisplaysong3_SelectedIndexChanged(object sender, EventArgs e)
        {                                  
            var query1 = from c in context.Playlists
                         where c.Playlistname.Equals(GridView3.SelectedRow.Cells[1].Text.ToString())
                         select c.Playlist_Id;
            int playlistid =query1.First() ;

            var query2 = from c in context.Song_to_Playlists
                         join b in context.Songs
                         on c.Song_Id equals b.Song_Id
                         where c.Playlist_Id == query1.First()
                         select new { song = b.File.ToArray(), songname = b.Songname };
             try{
                    var ifnull = query2.First();
                    if (ifnull != null)
                    {
                        GridView4.DataSource = query2;
                        GridView4.DataBind();
                    }
                }
                catch (Exception ex)
                { Label5.Text = "No results"; }
            
            GridView1.DataSource = null;
            GridView1.DataBind();
            GridView3.DataSource = null;
            GridView3.DataBind();
            GridView2.DataSource = null;
            GridView2.DataBind();

        }

        protected void GridView_playsong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = GridView4.SelectedRow.Cells[1].Text.ToString();
            url = @"C:\Users\Admin\Documents\Visual Studio 2013\Projects\Online_Music_System\new\" + name;
            Media_Player_Control1.MovieURL = url;
         
        }

       

        //Display Playlist onclick display songs and then play song 
        */

    }
}