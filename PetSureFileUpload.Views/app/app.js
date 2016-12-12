var app = angular.module('app', ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
    .when('/upload', {
        controller: 'UploadController',
        templateUrl: 'app/views/upload.html'
    })
    .otherwise({ redirectTo: '/upload' });
}]);

var ngFileSelect = function () {
    return {
        link: function ($scope, el) {
            el.bind("change", function (e) {
                var fileHolder = (e.srcElement || e.target).files[0];
                //$scope.FileUpload = fileHolder;
                $scope.initializeFile(e.target.id, fileHolder);
            });
        }
    };
};

app.directive("ngFileSelect", ngFileSelect);