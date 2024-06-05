using BondHealth.Models;
using BondHealth.Services.SpecialtiesRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/specialties")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class SpecialtiesController: ControllerBase
  {
    private readonly ISpecialtiesRepository _specialtiesRepository;
    public SpecialtiesController(ISpecialtiesRepository specialtiesRepository)
    {
      _specialtiesRepository = specialtiesRepository;
    }

    [HttpGet]
    public IEnumerable<Specialty> GetAll()
    {
      return _specialtiesRepository.GetAll();
    }

    [HttpGet("{Id}")]
    public Specialty GetById(int Id)
    {
      return _specialtiesRepository.GetById(Id);
    }
  }
}
