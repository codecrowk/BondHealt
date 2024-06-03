using BondHealth.Models;
using BondHealth.Services.DoctorsRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/doctors")]
  [ApiController]
  public class DoctorsUpdateController: ControllerBase
  {
    private readonly IDoctorsRepository _doctorsRepository;
    public DoctorsUpdateController(IDoctorsRepository doctorsRepository)
    {
      _doctorsRepository = doctorsRepository;
    }

    [HttpPut("{Id}")]
    public Doctor Update(int Id, Doctor doctor)
    {
      return _doctorsRepository.Update(Id, doctor);
    }
  }
}
