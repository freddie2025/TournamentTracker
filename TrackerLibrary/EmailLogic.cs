using System.Collections.Generic;
using System.Net.Mail;

namespace TrackerLibrary
{
	public static class EmailLogic
	{
		public static void SendEmail(string toAddress, string subject, string body)
		{
			MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderDisplayName"));

			MailMessage mail = new MailMessage();
			mail.To.Add(toAddress);
			mail.From = fromMailAddress;
			mail.Subject = subject;
			mail.Body = body;
			mail.IsBodyHtml = true;

			SmtpClient client = new SmtpClient();

			client.Send(mail);
		}
	}
}
