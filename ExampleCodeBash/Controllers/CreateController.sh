cd "$rootProjectDir/Controllers/${globalModelNaming}"

cat > ${globalModelNaming}CreateController.cs << EOM
using BondHealth.Models;
using BondHealth.Services.DoctorsRepository;
using Microsoft.AspNetCore.Mvc;

namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  public class "\$globalModelNaming"CreateController: ControllerBase
  {
    private readonly "\$repository_interface_name" _"\$repository_filed";
    public "\$globalModelNaming"CreateController("\$repository_interface_name" "\$repository_filed")
    {
      _"\$repository_filed" = "\$repository_filed";
    }

    [HttpPost]
    public "\$http_post_return" Create([FromBody] "\$globalModelNaming" "\$globalModelNaming_argument")
    {
      return _"\$repository_filed".Create("\$globalModelNaming_argument");
    }
  }
}
EOM