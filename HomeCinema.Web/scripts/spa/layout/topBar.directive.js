﻿'use strict';

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