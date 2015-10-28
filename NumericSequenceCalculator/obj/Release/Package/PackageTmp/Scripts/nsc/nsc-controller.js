angular.module('NscApp', ['ngAnimate', 'ui.bootstrap'])
    .controller('NscCtrl', function ($scope, $http, $location) {
        $scope.number = 0;
        $scope.error = false;
        $scope.pathLoc = window.location.pathname;
        console.log("pathname : " + window.location.pathname);
        console.log("before : "+$scope.pathLoc);
        if ($scope.pathLoc.length === 0) {
            console.log("in");
            $scope.pathLoc = "/";
        }
        console.log("after : " + $scope.pathLoc);
        $scope.types = {
            "normal": "All numbers up to and including the number entered",
            "fibonacci": "All fibonacci number up to and including the number entered",
            "odd": "All odd numbers up to and including the number entered",
            "even": "All even numbers up to and including the number entered",
            "special": "All numbers up to and including the number entered, except when; A number is a "+
                "multiple of 3 output C, and when; A number is a multiple of 5 output E, and when; A " +
                "number is a multiple of both 3 and 5 output Z."
        };
        $scope.sequences = {};
        $scope.getSequences = function () {
            if ($scope.number !== null && $scope.number >= 0) {
                for (var type in $scope.types) {
                    $scope.getSequence(type, $scope.number);
                }
            }
        };
        $scope.getSequence = function ($type, $number) {
            $http.get($scope.pathLoc + "api/nsc/" + $type + "/" + $number).success(function (data, status, headers, config) {
                $scope.sequences[$type] = data;
                $scope.error = false;
            }).error(function (data, status, headers, config) {
                $scope.error = true;
            });
        };
    }).directive('numericOnly', function () {
        return {
            require: 'ngModel',
            link: function (scope, element, attrs, modelCtrl) {

                modelCtrl.$parsers.push(function (inputValue) {
                    var transformedInput = inputValue ? inputValue.replace(/[^\d.-]/g, '') : null;

                    if (transformedInput != inputValue) {
                        modelCtrl.$setViewValue(transformedInput);
                        modelCtrl.$render();
                    }

                    return transformedInput;
                });
            }
        };
    });