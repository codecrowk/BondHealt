## Get to root dir
declare rootBashDir=`pwd`

cd ../
declare rootDir=`pwd`

## Go back to root dir
cd $rootBashDir

##----- GLOBAL VARIBLES -----##
declare projectName="BondHealth"
declare modelName="Especialidad"
declare globalModelNaming=${modelName}es

declare rootProjectDir="${rootDir}/${projectName}"

##----- HELPER FUNCTIONS -----##
# goToProjectDir()
# {
#   ## Equal to: BondHealt(root dir)/BondHeath(main dir)
#   cd ${rootProjectDir}/${projectName}
#   cd ./$1
# }

export rootProjectDir
export globalModelNaming
export modelName
##----- Testing
# cd $projectName/Data
# echo $rootProjectDir
# pwd


##----- START -----##
##---- Project Skeleton
./projectSkeleton.sh

##--- BaseContext
./Data/BaseContext.sh


##--- Controllers
./Controllers/GetController.sh
./Controllers/CreateController.sh
./Controllers/UpdateController.sh
./Controllers/DeleteController.sh

##--- Model
./Models/Model.sh

##--- Http methods
./Services/HttpMethods/IHttpGet.sh
./Services/HttpMethods/IHttpPost.sh
./Services/HttpMethods/IHttpPut.sh
./Services/HttpMethods/IHttpDelete.sh

##--- REPOSITORY ---##
#-- Methods
./Services/Repository/Methods/Get.sh
./Services/Repository/Methods/Create.sh
./Services/Repository/Methods/Update.sh
./Services/Repository/Methods/Delete.sh

#-- Repository
./Services/Repository/Repository.sh
./Services/Repository/IRepository.sh