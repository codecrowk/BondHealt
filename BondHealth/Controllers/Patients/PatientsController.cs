using BondHealth.Models;
using BondHealth.Services.PatientsRepository;
using Microsoft.AspNetCore.Mvc;

namespace BondHealth.Controllers
{
  [Route("api/patients")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class PatientsController: ControllerBase
  {
    private readonly IPatientsRepository _patientsRepository;
    public PatientsController(IPatientsRepository patientsRepository)
    {
      _patientsRepository = patientsRepository;
    }

    [HttpGet]
    public IEnumerable<Patient> GetAll()
    {
      return _patientsRepository.GetAll();
    }

    [HttpGet("{Id}")]
    public Patient GetById(int Id)
    {
      return _patientsRepository.GetById(Id);
    }
  }
}
