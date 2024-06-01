using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.DoctorsRepository.Methods;

namespace BondHealth.Services.DoctorsRepository
{
  public class DoctorsRepository: IDoctorsRepository
  {
    private readonly BaseContext _context;

    public DoctorsRepository(BaseContext context)
    {
      _context = context;
    }

    public IEnumerable<Doctor> GetAll()
    {
      DoctorsGet taskUnit = new DoctorsGet(_context);
      return taskUnit.GetAll();
    }

    public Doctor GetById(int id)
    {
      DoctorsGet taskUnit = new DoctorsGet(_context);
      return taskUnit.GetById(id);
    }

    public Doctor Create(Doctor doctor)
    {
      DoctorsCreate taskUnit = new DoctorsCreate(_context);
      return taskUnit.Create(doctor);
    }

    public Doctor Update(Doctor doctor)
    {
      DoctorsUpdate taskUnit  = new(_context);
      return taskUnit.Update(doctor);
    }

    public int Delete(int id)
    {
      DoctorsDelete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
