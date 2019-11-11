/* Copyright (©) 2019 PETTO SYSTEM
/************************************************************************
/* File Name    : EmailSender.cs
/* Function     : Email sender
/* Create       : LinhTran 2019/11/11
/************************************************************************/
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

namespace Pet_Management.Services
{
    /// <summary>
    /// Send mail
    /// See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
    /// Ref: https://docs.microsoft.com/en-us/azure/sendgrid-dotnet-how-to-send-email
    /// </summary>
    public class EmailSender
    {
        public EmailSender(IOptions<AuthMessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public void SendEmail(string email, string subject, string message)
        {
            Execute(Options.SendGridKey, subject, message, email).Wait();
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return ExecuteAsync(Options.SendGridKey, subject, message, email);
        }

        public Task ExecuteAsync(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("petto.management@gmail.com", "PETTO"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg);
        }

        public async Task Execute(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("petto.management@gmail.com", "PETTO"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);

            await client.SendEmailAsync(msg);
        }
    }
}
