using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.PatientsRepository
{
  // We have to create the following methods
  public interface IPatientsRepository: IHttpGet<Patient>, 
    IHttpPost<Patient>, 
    IHttpPut<Patient>, 
    IHttpDelete<Patient>
  { }
}
