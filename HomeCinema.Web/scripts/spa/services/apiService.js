﻿(function (app) {
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