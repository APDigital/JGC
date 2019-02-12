using System;
using System.Net.Mail;
namespace Jgamerclub.Models
{
    public class EmailBuilder
    {
        public string UsersName { get; set; }
        public string UsersEmail { get; set; }
        public string Subject { get; set; }
        public string MessageBody { get; set; }
        public EmailBuilder()
        {

        }
        public void SendEmail()
        {


            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                MailMessage mail = new MailMessage();
                mail.To.Add("YOUR EMAIL HERE");
                mail.From = new MailAddress("JGC.ContactForm@gmail.com");
                mail.Subject = Subject;
                mail.Body = GetMessageBody();
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("YOUR EMAIL HERE", "YOUR EMAIL PASSWORD HERE");

                smtpClient.Send(mail);
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public string GetMessageBody()
        {
            string body = string.Format("{0} {1}{1}From {2} {1}{3}", MessageBody, Environment.NewLine, UsersName, UsersEmail);
            return body;

        }
    }
}