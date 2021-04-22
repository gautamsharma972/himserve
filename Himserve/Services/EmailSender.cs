using Himserve.Models;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;

namespace Himserve.Services
{

    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;
         
        public EmailSender(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public void SendMail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);

            SendAsync(emailMessage);
        }

        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(message.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message.Content };

            return emailMessage;
        }

        private async void SendAsync(MimeMessage mailMessage)
        {
            using (SmtpClient smtpClient = new SmtpClient())
            {
                await smtpClient.ConnectAsync(_emailConfig.SmtpServer,
                _emailConfig.Port, true);
                await smtpClient.AuthenticateAsync(_emailConfig.UserName,
                _emailConfig.Password);
                await smtpClient.SendAsync(mailMessage);
                await smtpClient.DisconnectAsync(true);
            }
        }
    }
}
