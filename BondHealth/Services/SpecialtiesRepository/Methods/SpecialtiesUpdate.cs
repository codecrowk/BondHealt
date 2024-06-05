using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;
using Microsoft.EntityFrameworkCore;

namespace BondHealth.Services.SpecialtiesRepository.Methods
{
  public class SpecialtiesUpdate: IHttpPut<Specialty>
  {
    private readonly BaseContext _context;
    public SpecialtiesUpdate(BaseContext context){
      _context = context;
    }

    public Specialty Update(int id, Specialty specialty)
    {
      specialty.Id = id;
      _context.Entry(specialty).State = EntityState.Modified;
      _context.SaveChanges();
      return specialty;
    }
  } 
}
