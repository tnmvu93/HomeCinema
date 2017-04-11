(function () {
    'use strict';

    var commonUI = angular.module('common.ui');

    commonUI.directive('componentRating', componentRating);

    function componentRating() {
        return {
            restrict: 'A',
            link: function ($scope, $element, $attrs) {
                $element.raty({
                    score: $attrs.componentRating,
                    halfShow: false,
                    readOnly: $scope.isReadOnly,
                    noRateMsg: "Not rated yet!",
                    starHalf: "../content/images/raty/star-half.png",
                    starOff: "../content/images/raty/star-off.png",
                    starOn: "../content/images/raty/star-on.png",
                    hints: ["Poor", "Average", "Good", "Very Good", "Exellent"],
                    click: function (score, event) {
                        $scope.movie.Rating = score;
                        $scope.$apply();
                    }
                });
            }
        }
    }
})();