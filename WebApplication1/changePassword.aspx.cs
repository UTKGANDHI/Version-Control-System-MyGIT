using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class changePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login_name"] == null)
                Response.Redirect("~/index.html");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please enter proper details !!');", true);
            }
            else
            {

              //  lblMessage.Text = "Processing";
                if (!(TextBox1.Text.Equals(TextBox2.Text, StringComparison.CurrentCultureIgnoreCase)) && (TextBox2.Text == TextBox3.Text))
                {
                    int rowsAffected = 0;
                    string query = "UPDATE [User] SET [Password] = @NewPassword WHERE [Username] = @Username AND [Password] = @CurrentPassword";
                    //string constr = ConfigurationManager.ConnectionStrings["Repo"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\SDP\WebApplication1\WebApplication1\App_Data\Database1.mdf;Integrated Security=True;MultipleActiveResultSets=True;"))
                    {
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            using (SqlDataAdapter sda = new SqlDataAdapter())
                            {
                                cmd.Parameters.AddWithValue("@Username", Session["login_name"].ToString());
                                cmd.Parameters.AddWithValue("@CurrentPassword", TextBox1.Text);
                                cmd.Parameters.AddWithValue("@NewPassword", TextBox2.Text);
                                cmd.Connection = con;
                                con.Open();
                                rowsAffected = cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        if (rowsAffected > 0)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Password changed succesfully!');", true);
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error changing the password!!');", true);
                        }
                    }
                }
                else
                {
                  //  lblMessage.ForeColor = Color.Red;
                  //  lblMessage.Text = "Old Password and New Password must not be equal.";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Repository.aspx");
        }
    }  
}