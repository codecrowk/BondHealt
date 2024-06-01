cd $rootProjectDir/Services/${globalModelNaming}Repository/Methods

cat > ${globalModelNaming}Create.cs << EOM
namespace "\$project_name".Services."\$repository_name".Methods
{
  public class "\$globalModelNaming"Create: IHttpPost<"\$model_name">
  {
    // BaseContext _context
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$globalModelNaming"Create("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }

    public "\$http_post_return" Create("\$model_name" "\$model_name_argument")
    {
      _context."\$globalModelNaming".Add("\$model_name_argument");
      _context.SaveChanges();
      return  "\$model_name_argument";
    }
  } 
}
EOM