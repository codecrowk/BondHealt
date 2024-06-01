using BondHealth.Models;
using BondHealth.Services.PatientsRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/patients")]
  [ApiController]
  public class PatientsCreateController: ControllerBase
  {
    private readonly IPatientsRepository _patientsRepository;
    public PatientsCreateController(IPatientsRepository patientsRepository)
    {
      _patientsRepository = patientsRepository;
    }

    [HttpPost]
    public Patient Create([FromBody] Patient patient)
    {
      return _patientsRepository.Create(patient);
    }
  }
}
