using BondHealth.Data;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.DoctorsRepository.Methods
{
  public class DoctorsGet: IHttpGet<Doctor>
  {
    private readonly BaseContext _context;
    public DoctorsGet(BaseContext baseContext){
      _context = baseContext;
    }
        
    public IEnumerable<Doctor> GetAll()
    {
      return _context.Doctors.ToList();
    }

    public Doctor GetById(int id)
    {
      return _context.Doctors.Find(id);
    }
  } 
}
