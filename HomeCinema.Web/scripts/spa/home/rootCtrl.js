(function () {
    'use strict';

    var app = angular.module('homeCinema');

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
})();