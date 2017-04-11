(function () {
    'use strict';

    var commonUI = angular.module('common.ui')

    commonUI.directive('topBar', topBar);

    function topBar() {
        return {
            restrict: 'E',
            replace: true,
            templateUrl: '/scripts/spa/layout/topBar.html'
        };
    }
})();