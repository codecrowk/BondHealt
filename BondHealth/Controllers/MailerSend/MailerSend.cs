using BondHealth.Data;
using BondHealth.Helpers;
using BondHealth.Models.MailerSend;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/emails")]
  [ApiController]
  public class MailerSend: ControllerBase
  {
      // public DoctorsController()
      // {
      //   // _doctorsRepository = doctorsRepository;
      // }

      [HttpGet]
      public async Task<string> GetAll()
      {
        var options = new MailerSendClientOptions
        {
          ApiToken = "mlsn.ea53d2d62c5b62333be9a2106064e6922bf3658c9769db63f9d48b5d94afe71b",
          ApiUrl = "https://api.mailersend.com/v1/email"
        };

        Email newEmail = new Email
        {
          From = new Recipent{Email = "dannyKentala@trial-pq3enl60en8l2vwr.mlsender.net"},
          To = 
          [
            new Recipent{Email = "jabele2887@crodity.com"}
          ],
          Subject = "Email from backend",
          Text = "This is an email generate from backend, backend i'm loving it"
          // Html = "<b>Hello HTML, son of the futass!!!</b>"
        };

        MailerSendClient mailerSendClient = new MailerSendClient(options);
        string emailInfo = await mailerSendClient.SendEmail(newEmail);
        return emailInfo;
      }
  }
}