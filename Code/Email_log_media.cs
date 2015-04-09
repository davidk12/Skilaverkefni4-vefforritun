using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Net.Mail;
using System.Diagnostics;

namespace skilaverkefni_4.Code
{
    public class Email_log_media : Log_media
    {
        private string email = ConfigurationManager.AppSettings["Email"];    // Grab the email from the Web.config file.

        public override void log_message(string message)
        {
            try
            {
                using (MailMessage m = new MailMessage())                   
                {
                    m.To.Add(email);                                        

                    m.Subject = "Email Subject Line!";
                    m.Body = message;

                    using (SmtpClient client = new SmtpClient())
                    {
                        client.EnableSsl = true;
                        client.Send(m);
                    }
                }
            }
            catch(SmtpException ex)
            {
                Debug.WriteLine(ex.Message + Environment.NewLine);
            }
        }
    }
}