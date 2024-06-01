using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

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
      _context.Doctors.Add(doctor);
      _context.SaveChanges();
      return  doctor;
    }
  } 
}
