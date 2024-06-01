using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.PatientsRepository.Methods
{
  public class PatientsDelete: IHttpDelete<Patient>
  {
    private readonly BaseContext _context;
    public PatientsDelete(BaseContext context){
      _context = context;
    }

    public int Delete(int id)
    {
      var dataEntry = _context.Patients.Find(id);
      _context.Patients.Remove(dataEntry);
      _context.SaveChanges();
      return dataEntry.Id;
    }
  } 
}
