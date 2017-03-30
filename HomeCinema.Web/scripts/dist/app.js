'use strict';

(function () {
    angular.module('homeCinema', ['common.core', 'common.ui'])
        .config(config);

    config.$inject = ['$routeProvider'];
    function config($routeProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "scripts/spa/home/index.html",
                controller: "indexCtrl"
            })
            .when("/login", {
                templateUrl: "scripts/spa/account/login.html",
                controller: "loginCtrl"
            })
            .when("/register", {
                templateUrl: "scripts/spa/account/register.html",
                controller: "registerCtrl"
            })
            .when("/customers", {
                templateUrl: "scripts/spa/customers/customers.html",
                controller: "customersCtrl"
            })
            .when("/customers/register", {
                templateUrl: "scripts/spa/customers/register.html",
                controller: "customersRegCtrl"
            })
            .when("/movies", {
                templateUrl: "scripts/spa/movies/movies.html",
                controller: "moviesCtrl"
            })
            .when("/movies/add", {
                templateUrl: "scripts/spa/movies/add.html",
                controller: "movieAddCtrl"
            })
            .when("/movies/:id", {
                templateUrl: "scripts/spa/movies/details.html",
                controller: "movieDetailsCtrl"
            })
            .when("/movies/edit/:id", {
                templateUrl: "scripts/spa/movies/edit.html",
                controller: "movieEditCtrl"
            })
            .when("/rental", {
                templateUrl: "scripts/spa/rental/rental.html",
                controller: "rentStatsCtrl"
            })
            .otherwise({ redirectTo: "/" });




    }

})();
(function (app) {
    'use strict';

    app.controller('rootCtrl', rootCtrl);

    function rootCtrl($scope) {
        $scope.userdata = {};

        $scope.userdata.displayUserInfo = displayUserInfo;
        $scope.logout = logout;

        function displayUserInfo() {

        }

        function logout() {

        }
    }
})(angular.module('homeCinema'));
'use strict';

(function (app) {
    app.directive('sideBar', sideBar);

    function sideBar() {
        return {
            restrict: 'E',
            replace: true,
            templateUrl: '/scripts/spa/layout/sideBar.html'
        };
    }

})(angular.module('common.ui'));
'use strict';

(function (app) {
    app.directive('topBar', topBar);

    function topBar() {
        return {
            restrict: 'E',
            replace: true,
            templateUrl: '/scripts/spa/layout/topBar.html'
        };
    }
})(angular.module('common.ui'));
/// <reference path="common.core.js" />
'use strict';

(function () {
    angular.module('common.core', ['ngRoute', 'ngCookies', 'base64', 'angularFileUpload', 'angularValidator', 'angucomplete-alt']);
})();
'use strict';

(function () {
    angular.module('common.ui', ['ui.bootstrap', 'chieffancypants.loadingBar']);

})();
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