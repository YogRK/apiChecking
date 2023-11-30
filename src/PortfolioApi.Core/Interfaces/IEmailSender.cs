using System.Threading.Tasks;

namespace PortfolioApi.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
