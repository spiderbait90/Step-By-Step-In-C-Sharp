using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace GamesStore.Web.Areas.Identity.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("spiderbait90@gmail.com", "SpiderBait");
            var to = new EmailAddress(email, email);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, htmlMessage, htmlMessage);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
