using Exam.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;



namespace Exam.Controllers
{
    public class SendController : Controller
    {
        public IActionResult AddSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSend(Send data)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(MailboxAddress.Parse(data.From));
                message.To.Add(MailboxAddress.Parse(data.To));
                message.Subject = data.Subject;
                message.Body = new TextPart() { Text = $" hii  " };
                var smtpclient = new SmtpClient();
                smtpclient.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtpclient.Authenticate("jijinjora22@gmail.com", "uxjz skrr jiuz wfgf");
                smtpclient.Send(message);
                smtpclient.Disconnect(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return View();
        }
    }
}
