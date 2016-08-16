/// <reference path="../models/room.ts" />
var app;
(function (app) {
    var services;
    (function (services) {
        var RoomService = (function () {
            function RoomService($http) {
                this.$http = $http;
            }
            RoomService.prototype.getRooms = function () {
                var respPromise = this.$http.get('/Chat.FE.Web/api/Rooms');
                respPromise.then(function (result) {
                    this.roomServiceCallback(result);
                });
            };
            RoomService.$inject = ['$http'];
            return RoomService;
        }());
        services.RoomService = RoomService;
        angular.module('app').service('roomsService', RoomService);
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=RoomsService.js.map