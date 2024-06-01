using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.PatientsRepository.Methods
{
  public class PatientsCreate: IHttpPost<Patient>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public PatientsCreate(BaseContext context){
      _context = context;
    }

    public Patient Create(Patient patient)
    {
      _context.Patients.Add(patient);
      _context.SaveChanges();
      return  patient;
    }
  } 
}
