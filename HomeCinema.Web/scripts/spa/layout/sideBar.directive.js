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