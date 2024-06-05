using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.SpecialtiesRepository.Methods
{
  public class SpecialtiesGet: IHttpGet<Specialty>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public SpecialtiesGet(BaseContext context){
      _context = context;
    }
        
    public IEnumerable<Specialty> GetAll()
    {
      return _context.Specialties.ToList();
    }

    public Specialty GetById(int id)
    {
      return _context.Specialties.Find(id);
    }
  } 
}
