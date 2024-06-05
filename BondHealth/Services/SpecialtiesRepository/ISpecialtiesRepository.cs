using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.SpecialtiesRepository
{
  // We have to create the following methods
  public interface ISpecialtiesRepository: IHttpGet<Specialty>, 
    IHttpPost<Specialty>, 
    IHttpPut<Specialty>, 
    IHttpDelete<Specialty>
  { }
}
