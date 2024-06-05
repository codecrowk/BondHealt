using BondHealth.Models;
using BondHealth.Services.SpecialtiesRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/specialties")]
  [ApiController]
  public class SpecialtiesCreateController: ControllerBase
  {
    private readonly ISpecialtiesRepository _specialtiesRepository;
    public SpecialtiesCreateController(ISpecialtiesRepository specialtiesRepository)
    {
      _specialtiesRepository = specialtiesRepository;
    }

    [HttpPost]
    public Specialty Create([FromBody] Specialty specialty)
    {
      return _specialtiesRepository.Create(specialty);
    }
  }
}
