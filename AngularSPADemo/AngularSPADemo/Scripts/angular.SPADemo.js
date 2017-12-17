var SPA = angular.module("SPA", ["ngRoute"]);

//SPA路由設定，可在此往下新增路由
SPA.config(['$routeProvider', "$locationProvider",
    function ($routeProvider, $locationProvider) {
        $routeProvider
        .when("/", {
            templateUrl: '/Home/SPApage1',
            controller: 'Main'
        })
    }])