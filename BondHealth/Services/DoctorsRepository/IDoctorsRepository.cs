using BondHealth.Models;
using BondHealth.Services.HttpMethods;

namespace BondHealth.Services.DoctorsRepository
{
  // We have to create the following methods
  public interface IDoctorsRepository: IHttpGet<Doctor>, 
    IHttpPost<Doctor>, 
    IHttpPut<Doctor>, 
    IHttpDelete<Doctor>
  { }
}
