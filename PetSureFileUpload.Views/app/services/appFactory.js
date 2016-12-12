app.factory('appFactory', ['$http', '$q', function ($http, $q) {
    var factory = {};
    var api = "http://localhost:51729/api/";

    factory.getPetNames = function () {
        var q = $q.defer();
        $http.get(api + 'Pet/GetAll')
        .success(function (data) {
            q.resolve(data);
        }).error(function (e) {
            q.reject(e);
        });

        return q.promise;
    },

    factory.getPetNameById = function (id) {
        var q = $q.defer();
        $http.get(api + 'Pet/GetNameById?id=' + id)
        .success(function (data) {
            q.resolve(data);
        }).error(function (e) {
            q.reject(e);
        });

        return q.promise;
    }

    factory.uploadFileToUrl = function (file) {
        var fd = new FormData();
        fd.append('file', file);

        $https.post(fd, {
            transformRequest: angular.identity,
            headers: { 'Content-Type': undefined }
        })

        .success(function () {
        })

        .error(function () {
        });
    }

    return factory;
}]);