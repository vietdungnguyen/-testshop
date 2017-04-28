(function (app) {
    app.controller('postCategoryListController', postCategoryListController);

    postCategoryListController.$inject = ['$scope', 'apiService'];
    function postCategoryListController($scope, apiService) {
        $scope.postCategories = [];
        $scope.page = 0;
        $scope.pageCount = 0;
        $scope.keyword = '';
        $scope.getPostCategories = getPostCategories;

        $scope.search = search;

        function search() {
            getPostCategories();
        }
        function getPostCategories(page) {
            page = page || 0;
            var config = {
                params: {
                    keyword: $scope.keyword,
                    page: page,
                    pageSize: 2
                }
            }
            apiService.get('api/postcategory/getall', config, function (result) {
                $scope.postCategories = result.data.Items;
                $scope.page = result.data.Page;
                $scope.pagesCount = result.data.TotalPages;
                $scope.totalCount = result.data.TotalCount;
            }, function () {
                console.log('load post category failded')
            });
        }
        $scope.getPostCategories();
    }
})(angular.module('testshop.post_categories'));