cd $rootProjectDir/Services/${globalModelNaming}Repository/Methods

cat > ${globalModelNaming}Delete.cs << EOM
namespace "\$project_name".Services."\$repository_name".Methods
{
  public class "\$globalModelNaming"Delete: IHttpDelete<"\$model_name">
  {
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$globalModelNaming"Delete("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }

    public "\$http_delete_return" Delete(int id)
    {
      var dataEntry = _context."\$globalModelNaming".Find(id);
      _context."\$globalModelNaming".Remove(dataEntry);
      _context.SaveChanges();
      return dataEntry.Id;
    }
  } 
}
EOM