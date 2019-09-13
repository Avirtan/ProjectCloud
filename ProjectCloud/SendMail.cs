using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace ProjectCloud
{
    class SendMail
    {
        static public void Send(string ToAdress,string text,string subject)
        {
            SmtpClient smtp = new SmtpClient("smtp.mail.ru",587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("cloudproject1488@mail.ru","project228");
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("cloudproject1488@mail.ru");
            msg.To.Add(new MailAddress(ToAdress));
            msg.Subject = subject;
            msg.Body = text;
            smtp.Send(msg);
        }
    }
}
