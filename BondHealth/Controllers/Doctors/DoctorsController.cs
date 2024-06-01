using BondHealth.Models;
using BondHealth.Services.DoctorsRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/doctors")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class DoctorsController: ControllerBase
  {
    private readonly IDoctorsRepository _doctorsRepository;
    public DoctorsController(IDoctorsRepository doctorsRepository)
    {
      _doctorsRepository = doctorsRepository;
    }

    [HttpGet]
    public IEnumerable<Doctor> GetAll()
    {
      return _doctorsRepository.GetAll();
    }

    [HttpGet("{Id}")]
    public Doctor GetById(int Id)
    {
      return _doctorsRepository.GetById(Id);
    }
  }
}
