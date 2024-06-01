using BondHealth.Services.PatientsRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/patients")]
  [ApiController]
  public class PatientsDeleteController: ControllerBase
  {
    private readonly IPatientsRepository _patientsRepository;
    public PatientsDeleteController(IPatientsRepository patientsRepository)
    {
      _patientsRepository = patientsRepository;
    }

    [HttpDelete("{Id}")]
    public int Delete(int Id)
    {
      return _patientsRepository.Delete(Id);
    }
  }
}
