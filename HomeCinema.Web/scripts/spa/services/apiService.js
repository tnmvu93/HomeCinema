(function () {
    'use strict';

    var commonCore = angular.module('common.core')

    commonCore.factory('apiService', apiService);

    apiService.$inject = ['$http', '$location', '$rootScope', 'notificationService'];

    function apiService($http, $location, $rootScope, notificationService) {
        var service = {
            get: get,
            post: post
        };

        var apiAddress = 'http://localhost:8000/';

        return service;

        function get(url, config, success, failure) {
            return $http.get(apiAddress + url, config)
                        .then(function (result) {
                            success(result);
                        }, function (error) {
                            if (error.status == '401') {
                                notificationService.displayError('Authentication required.');
                                $rootScope.previousState = $location.path();
                                $location.path('/login');
                            } else if (failure != null) {
                                failure(error);
                            }
                        });
        }

        function post(url, config, success, failure) {
            return $http.post(apiAddress + url, config)
                        .then(function (result) {
                            success(result);
                        }, function (error) {
                            if (error.status == '401') {
                                notificationService.displayError('Authentication required.');
                                $rootScope.previousState = $location.path();
                                $location.path('/login');
                            } else if (failure != null) {
                                failure(error);
                            }
                        });
        }
    }
})();