using System.Collections.Generic;
using System.Net.Mail;

namespace TrackerLibrary
{
	public static class EmailLogic
	{
		public static void SendEmail(string toAddress, string subject, string body)
		{
			SendEmail(new List<string> { toAddress }, new List<string>(), subject, body);
		}

		public static void SendEmail(List<string> toAddresses, List<string> bccAddresses, string subject, string body)
		{
			MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("senderEmail"), GlobalConfig.AppKeyLookup("senderDisplayName"));

			MailMessage mail = new MailMessage();
			foreach (var toAddress in toAddresses)
			{
				mail.To.Add(toAddress); 
			}
			foreach (var bccAddress in bccAddresses)
			{
				mail.To.Add(bccAddress);
			}
			mail.From = fromMailAddress;
			mail.Subject = subject;
			mail.Body = body;
			mail.IsBodyHtml = true;

			SmtpClient client = new SmtpClient();

			client.Send(mail);
		}
	}
}
