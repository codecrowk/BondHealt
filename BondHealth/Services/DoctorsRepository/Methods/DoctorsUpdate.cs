using BondHealth.Data;
using BondHealth.Models;
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
      doctor.Id = id;
      _context.Entry(doctor).State = EntityState.Modified;
      _context.SaveChanges();
      return doctor;
    }
  } 
}
