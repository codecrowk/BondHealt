cd "$rootProjectDir/Controllers/${globalModelNaming}"

cat > ${globalModelNaming}Controller.cs << EOM
using BondHealth.Models;
using BondHealth.Services.DoctorsRepository;
using Microsoft.AspNetCore.Mvc;

namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class "globalModelNaming"Controller: ControllerBase
  {
    private readonly "\$repository_interface_name" _"\$repository_filed";
    public "\$globalModelNaming"Controller("\$repository_interface_name" "\$repository_filed")
    {
      _"\$repository_filed" = "\$repository_filed";
    }

    [HttpGet]
    public "\$http_getAll_return" GetAll()
    {
      return _"\$repository_filed".GetAll();
    }

    [HttpGet("{Id}")]
    public "\$http_getById_return" GetById(int Id)
    {
      return _"\$repository_filed".GetById(Id);
    }
  }
}
EOM