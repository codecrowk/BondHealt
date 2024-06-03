using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.PatientsRepository.Methods;

namespace BondHealth.Services.PatientsRepository
{
  public class PatientsRepository: IPatientsRepository
  {
    private readonly BaseContext _context;

    public PatientsRepository(BaseContext context)
    {
      _context = context;
    }

    public IEnumerable<Patient> GetAll()
    {
      PatientsGet taskUnit = new(_context);
      return taskUnit.GetAll();
    }

    public Patient GetById(int id)
    {
      PatientsGet taskUnit = new(_context);
      return taskUnit.GetById(id);
    }

    public Patient Create(Patient patient)
    {
      PatientsCreate taskUnit = new(_context);
      return taskUnit.Create(patient);
    }

    public Patient Update(int id, Patient patient)
    {
      PatientsUpdate taskUnit  = new(_context);
      return taskUnit.Update(id, patient);
    }

    public int Delete(int id)
    {
      PatientsDelete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
