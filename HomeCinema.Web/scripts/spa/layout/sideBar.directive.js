(function () {
    'use strict';

    var commonUI = angular.module('common.ui')

    commonUI.directive('sideBar', sideBar);

    function sideBar() {
        return {
            restrict: 'E',
            replace: true,
            templateUrl: '/scripts/spa/layout/sideBar.html'
        };
    }

})();