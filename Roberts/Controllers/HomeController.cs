using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Roberts.Models;

namespace Roberts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var message = new MimeMessage();
            //message.From.Add(new MailboxAddress("Test Project", "dksalazars@gmail.com"));
            //message.To.Add(new MailboxAddress("Gary", "dksalzar@gmail.com"));
            //message.Subject = "ASP.NET Test";
            //message.Body = new TextPart("plain")
            //{
            //    Text = "Hello World mail"
            //};
            //using (var client = new SmtpClient())
            //{
            //    client.Connect("smtp.gmail.com", 587, false);
            //    client.Authenticate("dksalazars@gmail.com", "amazingmerino42");
            //    client.Send(message);
            //    client.Disconnect(true);
            //}

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
