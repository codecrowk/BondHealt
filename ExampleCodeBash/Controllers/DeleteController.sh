cd "$rootProjectDir/Controllers/${globalModelNaming}"

cat > ${globalModelNaming}DeleteController.cs << EOM
using BondHealth.Models;
using BondHealth.Services.DoctorsRepository;
using Microsoft.AspNetCore.Mvc;

namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  public class "\$globalModelNaming"DeleteController: ControllerBase
  {
    private readonly "\$repository_interface_name" _"\$repository_filed";
    public "\$globalModelNaming"DeleteController("\$repository_interface_name" "\$repository_filed")
    {
      _"\$repository_filed" = "\$repository_filed";
    }

    [HttpDelete("{Id}")]
    public "\$http_delete_return" Delete(int Id)
    {
      return _"\$repository_filed".Delete(Id);
    }
  }
}
EOM