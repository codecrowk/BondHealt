using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;
using Microsoft.EntityFrameworkCore;

namespace BondHealth.Services.PatientsRepository.Methods
{
  public class PatientsUpdate: IHttpPut<Patient>
  {
    private readonly BaseContext _context;
    public PatientsUpdate(BaseContext context){
      _context = context;
    }

    public Patient Update(int id, Patient patient)
    {
      patient.Id = id;
      _context.Entry(patient).State = EntityState.Modified;
      _context.SaveChanges();
      return patient;
    }
  } 
}
