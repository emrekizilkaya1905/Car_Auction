using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.MailHelper
{
	public class MailService : IMailService
	{
		public void SendEmail(string subject, string body, string email)
		{
			try
			{
				var emailToSend = new MimeMessage();
				emailToSend.From.Add(MailboxAddress.Parse("CarAuction@gmail.com"));
				emailToSend.To.Add(MailboxAddress.Parse(email));
				emailToSend.Subject = subject;
				emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

				//Send email
				using var emailCLient = new SmtpClient();
				emailCLient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
				emailCLient.Authenticate("kizilkayaemre88@gmail.com", "ndwuxzxvipsppocs");
				emailCLient.Send(emailToSend);
				emailCLient.Disconnect(true);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
	}
}
