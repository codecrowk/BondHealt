cd $rootProjectDir/Services/${globalModelNaming}Repository

cat > ${globalModelNaming}Repository.cs << EOM
namespace "\$project_name".Services."\$repository_name"
{
  public class "\$repository_name": "\$repository_interface_name"
  {
    private readonly BaseContext _context;

    public "\$repository_name"(BaseContext context)
    {
      _context = context;
    }

    public "\$http_getAll_return" GetAll()
    {
      "\$globalModelNaming"Get taskUnit = new "\$globalModelNaming"Get(_context);
      return taskUnit.GetAll();
    }

    public "\$http_getById_return" GetById(int id)
    {
      "\$globalModelNaming"Get taskUnit = new "\$globalModelNaming"Get(_context);
      return taskUnit.GetById(id);
    }

    public "\$http_post_return" Create("\$model_name" "\$model_name_argument")
    {
      "\$globalModelNaming"Create taskUnit = new "\$globalModelNaming"Create(_context);
      return taskUnit.Create("\$model_name_argument");
    }

    public "\$http_put_return" Update("\$model_name" "\$model_name_argument")
    {
      "\$globalModelNaming"Update taskUnit  = new(_context);
      return taskUnit.Update("\$model_name_argument");
    }

    public "\$http_delete_return" Delete(int id)
    {
      "\$globalModelNaming"Delete taskUnit = new(_context);
      return taskUnit.Delete(id);
    } 
  }
}
EOM