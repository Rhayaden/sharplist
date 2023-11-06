using System.Net;
using System.Net.Mail;

namespace Sharplist
{
    public class EmailNotifier : INotifier
    {
        public void Send(string email, string subject, string body)
        {
            string mail = "gmail_address";
            string pw = "gmail_address_password";

            MailAddress to = new MailAddress(email);
            MailAddress from = new MailAddress(mail);

            MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            message.Body = body;

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new NetworkCredential(mail, pw);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Send(message);
        }
    }
}
