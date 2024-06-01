cd "$rootProjectDir/Controllers/${globalModelNaming}"

cat > ${globalModelNaming}UpdateController.cs << EOM
using BondHealth.Models;
using BondHealth.Services.DoctorsRepository;
using Microsoft.AspNetCore.Mvc;

namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  public class "\$globalModelNaming"UpdateController: ControllerBase
  {
    private readonly "\$repository_interface_name" _"\$repository_filed";
    public "\$globalModelNaming"UpdateController("\$repository_interface_name" "\$repository_filed")
    {
      _"\$repository_filed" = "\$repository_filed";
    }

    [HttpPut]
    public "\$http_put_return" Update("\$model_name" "\$model_name_argument")
    {
      return _"\$repository_filed".Update("\$model_name_argument");
    }
  }
}
EOM