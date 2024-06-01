using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.DoctorsRepository.Methods
{
  public class DoctorsDelete: IHttpDelete<Doctor>
  {
    private readonly BaseContext _context;
    public DoctorsDelete(BaseContext baseContext){
      _context = baseContext;
    }

    public int Delete(int id)
    {
      var dataEntry = _context.Doctors.Find(id);
      _context.Doctors.Remove(dataEntry);
      _context.SaveChanges();
      return dataEntry.Id;
    }
  } 
}
