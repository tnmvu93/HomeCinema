(function (app) {
    'use strict';

    app.factory('apiService', apiService);

    apiService.$inject = ['$http', '$location', '$rootScope', 'notificationService'];

    function apiService($http, $location, $rootScope, notificationService) {
        var service = {
            get: get,
            post: post
        };

        return service;

        function get(url, config, success, failure) {
            return $http.get(url, config)
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
            return $http.post(url, config)
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
})(angular.module('common.core'));
(function (app) {
    'use strict';

    app.factory('notificationService', notificationService);

    function notificationService() {

        toastr.options = {
            "debug": false,
            "positionClass": "toast-top-right",
            "onclick": null,
            "fadeIn": 300,
            "fadeOut": 1000,
            "timeOut": 3000,
            "extendedTimeOut": 1000
        };

        var service = {
            displaySuccess: displaySuccess,
            displayError: displayError,
            displayWarning: displayWarning,
            displayInfo: displayInfo
        };

        return service;

        function displaySuccess(message) {
            toastr.success(message);
        }

        function displayError(message) {
            if (Array.isArray(error)) {
                error.forEach(function (err) {
                    toastr.error(err);
                })
            } else {
                toastr.error(message);
            }
        }

        function displayWarning(message) {
            toastr.warning(message);
        }

        function displayInfo(message) {
            toastr.info(message);
        }
    }
})(angular.module('common.core'));