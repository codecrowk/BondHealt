using BondHealth.Services.DoctorsRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/doctors")]
  [ApiController]
  public class DoctorsDeleteController: ControllerBase
  {
    private readonly IDoctorsRepository _doctorsRepository;
    public DoctorsDeleteController(IDoctorsRepository doctorsRepository)
    {
      _doctorsRepository = doctorsRepository;
    }

    [HttpDelete("{Id}")]
    public int Delete(int Id)
    {
      return _doctorsRepository.Delete(Id);
    }
  }
}
