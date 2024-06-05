using BondHealth.Data;
using BondHealth.Helpers;
using BondHealth.Models;
using BondHealth.Services.HttpMethods;
using Microsoft.EntityFrameworkCore;

namespace BondHealth.Services.DoctorsRepository.Methods
{
  public class DoctorsGet //: IHttpGet<Doctor>
  {
    private readonly BaseContext _context;
    public DoctorsGet(BaseContext baseContext){
      _context = baseContext;
    }
        
    // public IEnumerable<Doctor> GetAll()
    // {
    //   return _context.Doctors.Include(d => d.Specialty).ToList();
    // }

    public PageResponse<IEnumerable<Doctor>> GetAll(int pageNumber)
    {
      int pageSize = 2;
      var data = _context.Doctors.Include(d => d.Specialty)
        .Skip((pageNumber -1) * pageSize)
        .Take(pageSize)
        .ToList();
      return new PageResponse<IEnumerable<Doctor>>(data, pageNumber, pageNumber +1, pageSize, "");
    }

    // public Doctor GetById(int id)
    // {
    //   return _context.Doctors.Find(id);
    // }

    public Response<Doctor> GetById(int id)
    {
      var data = _context.Doctors.Find(id);
      return new Response<Doctor>(data, "Doctor found!");
    }
  } 
}
