using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.SpecialtiesRepository.Methods
{
  public class SpecialtiesDelete: IHttpDelete<Specialty>
  {
    private readonly BaseContext _context;
    public SpecialtiesDelete(BaseContext context){
      _context = context;
    }

    public int Delete(int id)
    {
      var dataEntry = _context.Specialties.Find(id);
      _context.Specialties.Remove(dataEntry);
      _context.SaveChanges();
      return dataEntry.Id;
    }
  } 
}
