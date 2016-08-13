﻿/// <reference path="../app.ts" />
module app.controllers {
    export interface IMainController {
        
    }

    export class MainController implements IMainController {
        private scope: ng.IScope;

        public static $inject = ["$scope"];
        constructor($scope: ng.IScope) {
            this.scope = $scope;
        }

    }
    angular.module('app').controller('MainController', MainController);
}