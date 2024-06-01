##----- Global variables -----##
# This varible is going to be use to name all files 
declare modelName="Patient"
declare projectName="BondHealth"

cd ../${projectName}

###---------- MAKE SERVICES ----------###
mkdir Services/${modelName}Repository
cd Services/${modelName}Repository


##----- REPOSITORY ----##
cat > ${modelName}Repository.cs << EOM
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
      BooksGet "\$model_name"sGet = new BooksGet(_context);
      return "\$model_name"sGet.GetAll();
    }

    public "\$http_getById_return" GetById(int id)
    {
      BooksGet "\$model_name"sGet = new BooksGet(_context);
      return "\$model_name"Get.GetById(id);
    }

    public "\$http_post_return" Create("\$model_name" "\$model_name_argument")
    {
      BooksCreate "\$model_name"sCreate = new BooksCreate(_context);
      return "\$model_name"Create.Create("\$model_name_argument");
    }

    public "\$http_put_return" Update("\$model_name" "\$model_name_argument")
    {
      BooksUpdate "\$model_name"sUpdate  = new(_context);
      return "\$model_name"Update.Update("\$model_name_argument");
    }

    public "\$http_delete_return" Delete(int id)
    {
      BooksDelete "\$model_name"sDelete = new(_context);
      return "\$model_name"Delete.Delete(id);
    } 
  }
}
EOM

##----- IREPOSITORY ----##
cat > "I${modelName}Repository.cs" << EOM
namespace "\$project_name".Services."\$repository_name"
{
  // We have to create the following methods
  public interface "\$repository_interface_name": IHttpGet<"\$model_name">, 
    IHttpPost<"\$model_name">, 
    IHttpPut<"\$model_name">, 
    IHttpDelete<"\$model_name">
  { }
}
EOM


###---------- MAKE METHOD SERVICES ----------###
cd Methods

##----- GET ----##

cat > ${modelName}Get.cs << EOM
namespace "\$project_name".Services."\$repository_name".Methods
{
  public class "\$model_name"sGet: IHttpGet<"\$model_name">
  {
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$model_name"sGet("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }
        
    public "\$http_getAll_return" GetAll()
    {
      return _"\$db_context_field"."\$model_name"s.ToList();
    }

    public "\$http_getById_return" GetById(int id)
    {
      return _"\$db_context_field"."\$model_name"s.Find(id);
    }
  } 
}
EOM

##----- CREATE ----##
cat > ${modelName}Create.cs << EOM
namespace "\$project_name".Services."\$repository_name".Methods
{
  public class "\$model_name"sCreate: IHttpPost<"\$model_name">
  {
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$model_name"sCreate("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }

    public "\$http_post_return" Create("\$model_name" "\$model_name_argument")
    {
      _context.Books.Add( "\$model_name_argument");
      _context.SaveChanges();
      return  "\$model_name_argument";
    }
  } 
}
EOM

##----- UPDATE ----##
cat > ${modelName}Update.cs << EOM
namespace "\$project_name".Services."\$repository_name".Methods
{
  public class "\$model_name"sUpdate: IHttpPut<"\$model_name">
  {
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$model_name"sUpdate("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }

    public "\$http_put_return" Update("\$model_name" "\$model_name_argument")
    {
      _context.Entry("\$model_name_argument").State = EntityState.Modified;
      _context.SaveChanges();
      return "\$model_name_argument";
    }
  } 
}
EOM

##----- DELETE ----##
cat > ${modelName}Delete.cs << EOM
namespace "\$project_name".Services."\$repository_name".Methods
{
  public class "\$model_name"sDelete: IHttpDelete<"\$model_name">
  {
    private readonly "\$db_context_name" _"\$db_context_field";
    public "\$model_name"sDelete("\$db_context_name" "\$db_context_field"){
      _"\$db_context_field" = "\$db_context_field";
    }

    public "\$http_delete_return" Delete(int id)
    {
      var dataEntry = _context."\$model_name"s.Find(id);
      _context."\$model_name"s.Remove(dataEntry);
      _context.SaveChanges();
      return dataEntry.Id;
    }
  } 
}
EOM