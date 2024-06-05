using BondHealth.Models.MailerSend;

namespace BondHealth.Helpers.Interfaces
{
  public interface IMailClient
  {
    Task<string> SendEmail (Email data);
  }
}