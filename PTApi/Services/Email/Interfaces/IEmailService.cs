using System.Threading.Tasks;

namespace PTApi.Services
{
	public interface IEmailService
	{
		Task SendEmailAsync(string email, string subject, string message);
		// void Send(EmailMessage emailMessage);
		// List<EmailMessage> ReceiveEmail(int maxCount = 10);
	}
}