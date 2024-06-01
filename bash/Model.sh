##----- Global variables -----##
# This varible is going to be use to name all files 
declare modelName="Patient"
declare projectName="BondHealth"

cd ../${projectName}
###---------- MAKE MODEL ----------###
mkdir Models
cd Models

##----- GET ----##

cat > ${modelName}.cs << EOM
namespace "\$project_name".Models
{
  public class "\$model_name"
  {
    // A good part of models have ID
    public int Id {get; set;}
    public "\$data_type" "\$field_name" {get; set;}
  }
}
EOM