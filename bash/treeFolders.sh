## Go to project 
declare projectName="BondHealth"
cd ../$projectName

declare modelName="Doctor"
declare globalVar="${modelName}s"

##----- INIT ----##
###--------- PROJECT SKELETON ---------###
declare controller=$globalVar
declare service=$globalVar

mkdir -p "Controllers/${controller}"
mkdir -p "Services/${service}Repository/Methods"
mkdir -p "Services/HttpMethods"
mkdir Data
mkdir Models

wait $!

###--------- Controllers ---------###

## Folders 
cd "Controllers/${controller}"

## Files
touch "${controller}CreateController.cs"
touch "${controller}UpdateController.cs"
touch "${controller}DeleteController.cs"
touch "${controller}Controller.cs"


###--------- Repository ---------###

# Remember out current position is: Controllers/ModelContoller
cd ../../

##-- Folders
cd "Services/${service}Repository"

##-- Files
## First create main repository class with its interface
touch "${service}Repository.cs"
touch "I${service}Repository.cs"

## Now HTTP methods
# corrent route: Services/ServiceRepository/
cd Methods

touch "${service}Get.cs"
touch "${service}Create.cs"
touch "${service}Update.cs"
touch "${service}Delete.cs"

###--------- Models ---------###
declare model=$modelName

# Remember out current position is: Repository/ModelRepository/Methods
cd ../../../

touch "Models/${model}.cs"

###--------- Http Methods ---------###
touch "Data/BaseContext.cs"

###--------- Http Methods ---------###
cd Services/HttpMethods

touch IHttpGet.cs
touch IHttpPost.cs
touch IHttpPut.cs
touch IHttpDelete.cs