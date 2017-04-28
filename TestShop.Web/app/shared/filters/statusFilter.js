(function (app) {
    app.filter('statusFilter', function () {
        return function (input) {
            if (input == true)
                return 'Yes';
            else
                return 'No';
        }
    });
})(angular.module('testshop.common'));