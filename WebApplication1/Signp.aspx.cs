using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Signp : System.Web.UI.Page
    {
        DataClasses1DataContext db;
        Boolean allowed = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataClasses1DataContext();
        }
        protected void validateUserName(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
            var x = (from c in db.GetTable<User>()
                     where c.Username == UserName.Text
                     select c).ToList();
            if (x.Count != 0)
            {
                Label1.Text="username already exists,please select another username";
                allowed = false;
            }
            
        }
        public static string Encrypt(string plainText)
        {
            return plainText;
            /*
            if (plainText == null) throw new ArgumentNullException("plainText");
            
            //encrypt data
            var data = Encoding.Unicode.GetBytes(plainText);
            byte[] encrypted = ProtectedData.Protect(data, null, null);

            //return as base64 string
            return Convert.ToBase64String(encrypted);
            */
        }
        public static string Decrypt(string cipher)
        {
            return cipher;
            /*
            if (cipher == null) throw new ArgumentNullException("cipher");

            //parse base64 string
            byte[] data = Convert.FromBase64String(cipher);
            
            //decrypt data
            byte[] decrypted = ProtectedData.Unprotect(data, null, null);
            return Encoding.Unicode.GetString(decrypted);
                                       */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (allowed == false)
                return;
            User u = new User();
            u.Username = UserName.Text;
            u.FirstName = TextBox1.Text;
            u.LastName = TextBox2.Text;

            u.Email = Email.Text;
            u.PhoneNo = TextBox3.Text;
            u.Country = TextBox4.Text;
            u.Password = Encrypt(TextBox5.Text);
            u.u_id = db.Users.Count() + 1;
            db.GetTable<User>().InsertOnSubmit(u);


            db.SubmitChanges();
            Response.Redirect("Login.aspx");
        
        }


        
    }
}