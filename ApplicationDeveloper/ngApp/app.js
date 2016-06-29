
var app =   angular.module('ApplicationDeveloper', ['', 'ngResource', 'ui.bootstrap', 'ngTouch', 'ui.grid' ]);

//This is the controller where I would sort by the fields with the data retrieved via the http (AJAX) call
app.controller('TradeController', ['$scope', '$http', 'uiGridConstants', function ($scope, $http, uiGridConstants) {
    //Here I would create multiple options with the different fields to create specific sorting based on numeric desc/asc or alphabetically
    $scope.options = {
        enableSorting: true,
        columnDefs: [
            {
                field: 'TradeDate',
                sort: {
                    direction: uiGridConstants.DESC,
                    priority: 1
                }
            },
            { field: 'SettleDate' },
            { field: 'Symbol' },
            { field: 'Account' },
            { field: 'Quanity' },
            { field: 'Price' },
            { field: 'Principal' },
            { field: 'Currency' }
        ],
        onRegisterApi: function (tradeApi) {
            $scope.tradeGrid = tradeApi;
        }


    };

    //This is the basic http call that would call the tradeapi controller to receive the data in JSON format
    $http.get('/api/TradeApi.json').success(function (data) {
        $scope.options = data;
    });

}]);

  
