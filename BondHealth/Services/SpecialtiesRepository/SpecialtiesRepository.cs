using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.SpecialtiesRepository.Methods;

namespace BondHealth.Services.SpecialtiesRepository
{
  public class SpecialtiesRepository: ISpecialtiesRepository
  {
    private readonly BaseContext _context;

    public SpecialtiesRepository(BaseContext context)
    {
      _context = context;
    }

    public IEnumerable<Specialty> GetAll()
    {
      SpecialtiesGet taskUnit = new(_context);
      return taskUnit.GetAll();
    }

    public Specialty GetById(int id)
    {
      SpecialtiesGet taskUnit = new(_context);
      return taskUnit.GetById(id);
    }

    public Specialty Create(Specialty specialty)
    {
      SpecialtiesCreate taskUnit = new(_context);
      return taskUnit.Create(specialty);
    }

    public Specialty Update(int id, Specialty specialty)
    {
      SpecialtiesUpdate taskUnit  = new(_context);
      return taskUnit.Update(id, specialty);
    }

    public int Delete(int id)
    {
      SpecialtiesDelete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
