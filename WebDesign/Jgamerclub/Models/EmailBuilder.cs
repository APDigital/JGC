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
            MailMessage mail = new MailMessage("aoifejo.pearson@googlemail.com", UsersEmail);
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 25;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Host = "smtp.gmail.com";
            mail.Subject = Subject;
            mail.Body = GetMessageBody();
            smtpClient.Send(mail);
        }
        public string GetMessageBody()
        {
            string body = string.Format("{0} {1} From {2}", MessageBody, Environment.NewLine, UsersName);
            return body;

        }
    }
}