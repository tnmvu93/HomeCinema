﻿
(function () {
    'use strict';

    var commonUI = angular.module('common.ui');

    commonUI.directive('availableMovie', availableMovie);

    function availableMovie() {
        return {
            restrict: 'E',
            templateUrl: '/scripts/spa/directives/availableMovie.html',
            link: function ($scope, $element, $attrs) {
                $scope.getAvailableClass = function () {
                    if ($attrs.isAvailable === 'true') {
                        return 'label label-success';
                    } else {
                        return 'label label-danger';
                    }
                }

                $scope.getAvailability = function () {
                    if ($attrs.isAvailable === 'true') {
                        return 'Available!';
                    } else {
                        return 'Not Available';
                    }
                }
            }
        };
    }
})();