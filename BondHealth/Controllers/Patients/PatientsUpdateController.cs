using BondHealth.Models;
using BondHealth.Services.PatientsRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/patients")]
  [ApiController]
  public class PatientsUpdateController: ControllerBase
  {
    private readonly IPatientsRepository _patientsRepository;
    public PatientsUpdateController(IPatientsRepository patientsRepository)
    {
      _patientsRepository = patientsRepository;
    }

    [HttpPut("{Id}")]
    public Patient Update(int Id, Patient patient)
    {
      return _patientsRepository.Update(Id, patient);
    }
  }
}
