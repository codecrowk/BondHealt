using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.PatientsRepository.Methods
{
  public class PatientsGet: IHttpGet<Patient>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public PatientsGet(BaseContext context){
      _context = context;
    }
        
    public IEnumerable<Patient> GetAll()
    {
      return _context.Patients.ToList();
    }

    public Patient GetById(int id)
    {
      return _context.Patients.Find(id);
    }
  } 
}
