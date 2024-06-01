using BondHealth.Models;
using BondHealth.Services.DoctorsRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/doctors")]
  [ApiController]
  public class DoctorsCreateController: ControllerBase
  {
    private readonly IDoctorsRepository _doctorsRepository;
    public DoctorsCreateController(IDoctorsRepository doctorsRepository)
    {
      _doctorsRepository = doctorsRepository;
    }

    [HttpPost]
    public Doctor Create([FromBody] Doctor doctor)
    {
      return _doctorsRepository.Create(doctor);
    }
  }
}
