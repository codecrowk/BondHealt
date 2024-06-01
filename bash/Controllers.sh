##----- Global variables -----##
# This varible is going to be use to name all files 
declare modelName="Patient"
declare projectName="BondHealth"

cd ../${projectName}
###---------- MAKE CONTROLLERS ----------###
mkdir -p Controllers/${modelName}
cd Controllers/${modelName}

##----- GET ----##

cat > ${modelName}Controller.cs << EOM
namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  // Remember that in works in onion (this is level 1, repository is level 2), so
  // others classes, don't know about this one
  public class "\$get_controller_name": ControllerBase
  {
    private readonly "\$repository_interface_name" _"\$repository_filed";
    public "\$get_controller_name"("\$repository_interface_name" "\$repository_filed")
    {
      _"\$repository_filed" = "\$repository_filed";
    }

    [HttpGet]
    public "\$http_getAll_return" getAll()
    {
      return _"\$repository_filed".getAll();
    }

    [HttpGet("{Id}")]
    public "\$http_getById_return" getById(int Id)
    {
      return _"\$repository_filed".getById(Id);
    }
  }
}
EOM

##----- CREATE ----##
cat > ${modelName}CreateController.cs << EOM
namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  public class "\$create_controller_name": ControllerBase
  {
    private readonly "\$repository_interface_name" _"\$repository_filed";
    public "\$create_controller_name"("\$repository_interface_name" "\$repository_filed")
    {
      _"\$repository_filed" = "\$repository_filed";
    }

    [HttpPost]
    public "\$http_post_return" Create([FromBody] "\$model_name" "\$model_name_argument")
    {
      return _"\$repository_filed".Create("\$model_name_argument");
    }
  }
}
EOM

##----- UPDATE ----##
cat > ${modelName}UpdateController.cs << EOM
namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  public class "\$update_controller_name": ControllerBase
  {
    private readonly "\$repository_interface_name" _"\$repository_filed";
    public "\$update_controller_name"("\$repository_interface_name" "\$repository_filed")
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

##----- DELETE ----##
cat > ${modelName}DeleteController.cs << EOM
namespace "\$project_name".Controllers
{
  [Route("\$api_endpoint_name")]
  [ApiController]
  public class "\$delete_controller_name": ControllerBase
  {
    private readonly "\$repository_interface_name" _"\$repository_filed";
    public "\$delete_controller_name"("\$repository_interface_name" "\$repository_filed")
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