using BondHealth.Data;
using BondHealth.Helpers;
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

    // public IEnumerable<Doctor> GetAll()
    // {
    //   DoctorsGet taskUnit = new(_context);
    //   return taskUnit.GetAll();
    // }

    public PageResponse<IEnumerable<Doctor>> GetAll(int pageNumber)
    {
      DoctorsGet taskUnit = new(_context);
      return taskUnit.GetAll(pageNumber);
    }

    // public Doctor GetById(int id)
    // {
    //   DoctorsGet taskUnit = new(_context);
    //   return taskUnit.GetById(id);
    // }

    public Response<Doctor> GetById(int id)
    {
      DoctorsGet taskUnit = new(_context);
      return taskUnit.GetById(id);
    }

    public Doctor Create(Doctor doctor)
    {
      DoctorsCreate taskUnit = new(_context);
      return taskUnit.Create(doctor);
    }

    public Doctor Update(int id, Doctor doctor)
    {
      DoctorsUpdate taskUnit  = new(_context);
      return taskUnit.Update(id, doctor);
    }

    public int Delete(int id)
    {
      DoctorsDelete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
