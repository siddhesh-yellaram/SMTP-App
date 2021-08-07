
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SMTPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("devildante830@gmail.com");
                mail.To.Add("devildante830@gmail.com");
                mail.Subject = "This is god......";
                mail.Body = "Hello Devil....";
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("devildante830@gmail.com","devil@1999");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                Console.WriteLine("Mail Sent");
            }
        }
    }
}
