/// <reference path="C:\Users\nguyen viet dung\Source\Repos\-testshop\TestShop.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('testshop.post_categories', ['testshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('post_categories', {
            url: "/post_categories",
            parent:'base',
            templateUrl: "/app/components/post_categories/postCategoryListView.html",
            controller: "postCategoryListController"
        });
    }
})();