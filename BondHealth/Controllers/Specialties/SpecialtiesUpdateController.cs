using BondHealth.Models;
using BondHealth.Services.SpecialtiesRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/specialties")]
  [ApiController]
  public class SpecialtiesUpdateController: ControllerBase
  {
    private readonly ISpecialtiesRepository _specialtiesRepository;
    public SpecialtiesUpdateController(ISpecialtiesRepository specialtiesRepository)
    {
      _specialtiesRepository = specialtiesRepository;
    }

    [HttpPut("{Id}")]
    public Specialty Update(int Id, Specialty specialty)
    {
      return _specialtiesRepository.Update(Id, specialty);
    }
  }
}
