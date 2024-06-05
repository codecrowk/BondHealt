using BondHealth.Services.SpecialtiesRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/specialties")]
  [ApiController]
  public class SpecialtiesDeleteController: ControllerBase
  {
    private readonly ISpecialtiesRepository _specialtiesRepository;
    public SpecialtiesDeleteController(ISpecialtiesRepository specialtiesRepository)
    {
      _specialtiesRepository = specialtiesRepository;
    }

    [HttpDelete("{Id}")]
    public int Delete(int Id)
    {
      return _specialtiesRepository.Delete(Id);
    }
  }
}
