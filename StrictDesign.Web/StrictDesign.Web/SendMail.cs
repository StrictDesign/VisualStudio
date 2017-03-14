using System.Net.Mail;

namespace StrictDesign.Web
{
    public class SendMail
    {
        public static void MyMailMessage()
        {
            string smtpServerUser = "jimmy@mjallby.net";
            string smtpServerPassword = "sprng08wq!";

            MailMessage message = new MailMessage();
            SmtpClient smtpServer = new SmtpClient();
            smtpServer.Port = 465;
            smtpServer.Host = "send.one.com";
            smtpServer.EnableSsl = true;
            smtpServer.Timeout = 10000;
            smtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpServer.UseDefaultCredentials = false;
            smtpServer.Credentials = new System.Net.NetworkCredential(smtpServerUser, smtpServerPassword);

            message.From = new MailAddress("jimmy@mjallby.net");
            message.To.Add(new MailAddress("jimmy@strictdesign.se"));
            message.Subject = "Test";
            message.Body = "Message Body";
            //message.BodyEncoding = UTF8Encoding.UTF8;
            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            smtpServer.Send(message);
        }
    }
}