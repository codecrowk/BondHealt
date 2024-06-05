using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using System.Web.Http;


namespace BondHealth.Services.DoctorsRepository.Methods
{
  public class DoctorsCreate: IHttpPost<Doctor>
  {
    private readonly BaseContext _context;
    public DoctorsCreate(BaseContext baseContext){
      _context = baseContext;
    }

    public Doctor Create(Doctor doctor)
    {
      if(string.IsNullOrWhiteSpace(doctor.Email))
      {
        var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
        {
            Content = new StringContent(string.Format("No product with ID = {0}", doctor.Id)),
            ReasonPhrase = "Product ID Not Found"
        };
        throw new HttpResponseException(resp);
      }
        // throw  new HttpResponseException(HttpStatusCode.BadRequest);
        // throw  new  NotImplementedException("This method is not implement");

      _context.Doctors.Add(doctor);
      _context.SaveChanges();
      return  doctor;
    }
  } 
}
