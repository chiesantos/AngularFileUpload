app.controller('UploadController', ['$scope', '$route', '$filter', 'appFactory', function ($scope, $route, $filter, appFactory) {
    $scope.fileDTO = {};
    
    $scope.initialize = function () {
        $scope.actions.getNames();
    }

    $scope.actions = {
        getNames: function () {
            var promise = appFactory.getPetNames();
            promise.then(function (data) {
                $scope.names = data;
                console.log($scope.names);
            });
        }
    };

    $scope.uploadFile = function () {
        var file = $scope.myFile;

        console.log('file is ');
        console.dir(file);

        fileUpload.uploadFileToUrl(file);
    };

    $scope.$watch('fileDTO.PetID', function (newVal) {
        if(newVal){
            appFactory.getPetNameById(newVal).then(function (data) {
                $scope.blah = data.Name;
            })
        }
    });
}]);