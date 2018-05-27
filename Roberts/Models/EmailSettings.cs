using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Roberts.Services;

namespace Roberts.Models
{
    public class EmailSettings
    {
        public String PrimaryDomain { get; set; }

        public int PrimaryPort { get; set; }

        public String SecondayDomain { get; set; }

        public int SecondaryPort { get; set; }

        public String UsernameEmail { get; set; }

        public String UsernamePassword { get; set; }

        public String FromEmail { get; set; }

        public String ToEmail { get; set; }

        public String CcEmail { get; set; }
    }

    //public class AuthMessageSender : IEmailSender, ISmsSender
    //{
    //    public AuthMessageSender(IOptions<EmailSettings> emailSettings)
    //    {
    //        _emailSettings = emailSettings.Value;
    //    }

    //    public EmailSettings _emailSettings { get; }

    //    public Task SendEmailAsync(string email, string subject, string message)
    //    {

    //        Execute(email, subject, message).Wait();
    //        return Task.FromResult(0);
    //    }

    //    public async Task Execute(string email, string subject, string message)
    //    {
    //        try
    //        {
    //            string toEmail = string.IsNullOrEmpty(email)
    //                ? _emailSettings.ToEmail
    //                : email;
    //            MailMessage mail = new MailMessage()
    //            {
    //                From = new MailAddress(_emailSettings.UsernameEmail, "Muhammad Hassan Tariq")
    //            };
    //            mail.To.Add(new MailAddress(toEmail));
    //            mail.CC.Add(new MailAddress(_emailSettings.CcEmail));

    //            mail.Subject = "Personal Management System - " + subject;
    //            mail.Body = message;
    //            mail.IsBodyHtml = true;
    //            mail.Priority = MailPriority.High;

    //            using (SmtpClient smtp = new SmtpClient(_emailSettings.SecondayDomain, _emailSettings.SecondaryPort))
    //            {
    //                smtp.Credentials = new NetworkCredential(_emailSettings.UsernameEmail, _emailSettings.UsernamePassword);
    //                smtp.EnableSsl = true;
    //                await smtp.SendMailAsync(mail);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            //do something here
    //        }
    //    }
    //}
}
