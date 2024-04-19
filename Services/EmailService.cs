using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BalloonCity_Backend.Services
{
    public class EmailService
    {

        public static void SendEmail(string body){
            var mail = new MailMessage()
            {
                From = new MailAddress("ballooncityform@gmail.com"),
                Subject = "New Message From Website",
                Body=body
            };

            mail.To.Add("gentleeagle8787@gmail.com");

            var smtpServer = new SmtpClient("smtp.gmail.com"){
                Port=587,
                Credentials = new NetworkCredential("ballooncityform@gmail.com","Mbappe87!!"),
                EnableSsl = true
            };

            smtpServer.Send(mail);

        }
    }
}