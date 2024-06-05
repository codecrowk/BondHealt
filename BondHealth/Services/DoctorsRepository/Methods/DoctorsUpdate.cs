using BondHealth.Data;
using BondHealth.Helpers;
using BondHealth.Models;
using BondHealth.Models.MailerSend;
using BondHealth.Services.HttpMethods;
using Microsoft.EntityFrameworkCore;

namespace BondHealth.Services.DoctorsRepository.Methods
{
  public class DoctorsUpdate: IHttpPut<Doctor>
  {
    private readonly BaseContext _context;
    public DoctorsUpdate(BaseContext baseContext){
      _context = baseContext;
    }

    public Doctor Update(int id, Doctor doctor)
    {
      // var options = new MailerSendClientOptions
      // {
      //   ApiToken = "mlsn.ea53d2d62c5b62333be9a2106064e6922bf3658c9769db63f9d48b5d94afe71b",
      //   ApiUrl = "https://api.mailersend.com/v1/email"
      // };

      // Email newEmail = new Email
      // {
      //   From = new Recipent{Email = "trial-pq3enl60en8l2vwr.mlsender.net"},
      //   To = 
      //   [
      //     new Recipent{Email = "jabele2887@crodity.com"}
      //   ],
      //   Subject = "Email from backend",
      //   Text = "This is an email generate from backend"
      // };

      // MailerSendClient mailerSendClient = new MailerSendClient(options);
      // string emailInfo = await mailerSendClient.SendEmail(newEmail);

      doctor.Id = id;
      _context.Entry(doctor).State = EntityState.Modified;
      _context.SaveChanges();
      return doctor;
    }
  } 
}
