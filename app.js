var insmodule = angular.module('InsModule', []);
insmodule.controller('ClaimController',
    ['$scope', '$http', function ($scope, $http) {

        $http(
            {
                method: 'get',
                datatype: 'jsonp',
                
                headers: {
                    'Content-Type': 'application/json'

                },
                url: 'http://localhost:20791/Policy'

            }).success(function (data) {
                $scope.result = data;
                console.log($scope.result);

            });


}]);