using System;
using System.IO;
using System.Net;
using System.Net.Mail;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace WebApplication1
{
    public static class Email
    {
        public static void SendEmail(string owner, string subject, string body)
        {
            using (MailMessage mm = new MailMessage("mysdpproject@gmail.com", owner))
            {
                mm.Subject = subject;
                mm.Body = body;
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("mysdpproject@gmail.com", "mysdpproject2016");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                try
                {
                    smtp.Send(mm);//exception handling because without internet connection trying to send an email will generate error
                }
                catch(Exception e)
                {
                }
                
            }
        }
        public static string getEmail(string uname)
        {
            string emailid="";
            DataClasses1DataContext dc;

            dc = new DataClasses1DataContext();

            var q = (from c in dc.Users where c.Username == uname select c.Email).Single();

            emailid = q;


            return emailid;
        }
    }
}
