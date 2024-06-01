## These config is permanet, dont over write!!!


##----- Global variables -----##
# This varible is going to be use to name all files 
declare modelName="Doctors"
declare projectName="BondHealth"

cd ../${projectName}

###---------- MAKE BASE CONTEXT ----------###
cat > Data/BaseContext.cs << EOM
namespace BondHealth.Data
{
  public class "\$db_context_name": DbContext
  {
    public "\$db_context_name"(DbContextOptions<"\$db_context_name"> options): base(options)
    { }

    // Remember that model is singular, and table is plural
    // DbSet<Model> SqlTable
    public DbSet<"\$model_name"> "\$model_name"s {get; set;}
  }
}
EOM

###---------- MAKE HTTP METHODS ----------###
##----- GET ----##
declare httpDir="Services/HttpMethods"

cat > ${httpDir}/IHttpGet.cs << EOM
namespace "\$project_name".Services.HttpMethods
{
  public interface IHttpGet<T>
  {
    // IEnumerable<T>
    "\$http_getAll_return" GetAll();

    // T
    "\$http_getById_return" GetById(int id); 
  }
}
EOM

##----- POST ----##
declare httpDir="Services/HttpMethods"
cat > ${httpDir}/IHttpPost.cs << EOM
namespace "\$project_name".Services.HttpMethods
{
  public interface IHttpPost<T>
  {
    // T
    "\$http_post_return" Create(); 
  }
}
EOM

##----- UPDATE ----##
declare httpDir="Services/HttpMethods"
cat > ${httpDir}/IHttpPut.cs << EOM
namespace "\$project_name".Services.HttpMethods
{
  public interface IHttpPut<T>
  {
    // T
    "\$http_put_return" Update();
  }
}
EOM

##----- DELETE ----##
declare httpDir="Services/HttpMethods"
cat > ${httpDir}/IHttpDelete.cs << EOM
namespace "\$project_name".Services.HttpMethods
{
  public interface IHttpDelete<T>
  {
    // int
    "\$http_delete_return" Delete(); 
  }
}
EOM