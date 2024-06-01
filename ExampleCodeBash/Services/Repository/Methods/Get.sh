cd $rootProjectDir/Services/${globalModelNaming}Repository/Methods

cat > ${globalModelNaming}Get.cs << EOM
namespace "\$project_name".Services."\$repository_name".Methods
{
  public class "\$globalModelNaming"Get: IHttpGet<"\$model_name">
  {
    // BaseContext _context
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$globalModelNaming"Get("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }
        
    public "\$http_getAll_return" GetAll()
    {
      return _"\$db_context_field"."\$globalModelNaming".ToList();
    }

    public "\$http_getById_return" GetById(int id)
    {
      return _"\$db_context_field"."\$globalModelNaming".Find(id);
    }
  } 
}
EOM