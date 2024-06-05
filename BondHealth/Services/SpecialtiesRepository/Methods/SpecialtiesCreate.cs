using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.SpecialtiesRepository.Methods
{
  public class SpecialtiesCreate: IHttpPost<Specialty>
  {
    // BaseContext _context
    private readonly BaseContext _context;
    public SpecialtiesCreate(BaseContext context){
      _context = context;
    }

    public Specialty Create(Specialty specialty)
    {
      _context.Specialties.Add(specialty);
      _context.SaveChanges();
      return  specialty;
    }
  } 
}
