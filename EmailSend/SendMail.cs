using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows;

namespace EmailSend
{
    class SendMail
    {
        public static void Send(string topic,string body,string toadress)
        {
            var fromAddress = new MailAddress($"{MailAdr.Adress}", $"{MailAdr.Name}");
            var toAddress = new MailAddress( $"{toadress}" , null);
            var smtp = new SmtpClient
            {
                Host = "smtp.mail.ru",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("danya.argastsev.02@mail.ru", "123Danil2"),
            };
            using (var message = new MailMessage(Convert.ToString(fromAddress), Convert.ToString
                (toAddress))
            {
                Subject = topic,
                Body = body

            })
            {
                smtp.Send(message);
            }
            MessageBox.Show("Сообщение отправлено");
        }
    }
}
