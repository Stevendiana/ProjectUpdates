(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["default~admin-admin-module~resources-resources-module"],{

/***/ "./src/app/resources/resource/resource.component.html":
/*!************************************************************!*\
  !*** ./src/app/resources/resource/resource.component.html ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <h1 class=\"card-title m-1 pl-2 pull-left mb-2 text-muted text-primary\">{{resourceId}}</h1>\r\n</div>\r\n<section>\r\n  <div class=\"email-application\">\r\n      <div #contentOverlay class=\"content-overlay\" (click)=\"onContentOverlay()\"></div>\r\n      <div #emailSidebar class=\"email-app-sidebar float-left d-none d-xl-block\">\r\n        <div [perfectScrollbar] class=\"email-app-sidebar-content\">\r\n          <div class=\"email-app-menu\">\r\n            <div class=\"list-group list-group-messages\">\r\n              <a class=\"list-group-item active no-border text-left\" (click)=\"GetElement($event,'Dashboard')\">\r\n                <i class=\"ft-inbox mr-1 pr-1 float-left\"></i> Dashboard\r\n              </a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Forecast')\">\r\n                <i class=\"fa fa-bar-chart mr-1 pr-1 float-left\"></i> Forecast</a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Budget')\">\r\n                <i class=\"ft-target mr-1 pr-1 float-left\"></i> Budget\r\n              </a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Actual')\">\r\n                <i class=\"fa fa-dollar mr-1 pr-1 float-left\"></i> Actual\r\n              </a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Milestones')\">\r\n                <i class=\"ft-trash-2 mr-1 pr-1 float-left\"></i> Milestones</a>\r\n            </div>\r\n            <h6 class=\"text-muted text-primary text-bold-500 mt-1 mb-1 text-left\">Reporting Logs</h6>\r\n            <div class=\"list-group list-group-messages\">\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Actions')\">\r\n                  <i class=\"fa fa-paper-plane-o mr-1 pr-1 float-left\"></i> RAG Status</a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Rags')\">\r\n                  <i class=\"fa fa-paper-plane-o mr-1 pr-1 float-left\"></i> Action log</a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Risks')\">\r\n                <i class=\"ft-circle mr-1 pr-1 float-left warning\"></i> Risks\r\n                <span class=\"badge badge-warning badge-pill float-right\">5</span>\r\n              </a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Assumptions')\">\r\n                <i class=\"ft-circle mr-1 pr-1 float-left danger\"></i> Assumptions</a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Issues')\">\r\n                <i class=\"ft-circle mr-1 pr-1 float-left primary\"></i> Issue</a>\r\n              <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetElement($event,'Dependencies')\">\r\n                <i class=\"ft-circle mr-1 pr-1 float-left success\"></i> Dependency\r\n                <span class=\"badge badge-success badge-pill float-right\">3</span>\r\n              </a>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"email-app-content row\">\r\n        <div class=\"email-search-box w-100 bg-white p-2\">\r\n          <div class=\"media\">\r\n            <span class=\"email-app-sidebar-toggle ft-align-justify font-large-1 mr-2 d-xl-none\" (click)=\"onSidebarToggle()\"></span>\r\n            <div class=\"media-body\">\r\n              <input *ngIf=\"!displayDashboard\" type=\"text\" class=\"form-control round\" placeholder=\"search this page\">\r\n              <div class=\"container-fluid m-2\">\r\n                <app-resource-absences *ngIf=\"displayForecast\"></app-resource-absences>\r\n                <app-resource-availability *ngIf=\"displayActionlog\"></app-resource-availability>\r\n                <app-resource-demand *ngIf=\"displayAssumption\"></app-resource-demand>\r\n                <app-resource-utilization *ngIf=\"displayMilestone\"></app-resource-utilization>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n"

/***/ }),

/***/ "./src/app/resources/resource/resource.component.scss":
/*!************************************************************!*\
  !*** ./src/app/resources/resource/resource.component.scss ***!
  \************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9yZXNvdXJjZS5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/resources/resource/resource.component.ts":
/*!**********************************************************!*\
  !*** ./src/app/resources/resource/resource.component.ts ***!
  \**********************************************************/
/*! exports provided: ResourceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceComponent", function() { return ResourceComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");



var ResourceComponent = /** @class */ (function () {
    function ResourceComponent(elRef, route) {
        this.elRef = elRef;
        this.displayDashboard = true;
        this.displayForecast = false;
        this.displayActual = false;
        this.displayBudget = false;
        this.displayMilestone = false;
        this.displayActionlog = false;
        this.displayRisk = false;
        this.displayAssumption = false;
        this.displayIssue = false;
        this.displayDependency = false;
        this.displayRag = false;
        this.resourceId = route.snapshot.params['id'];
    }
    ResourceComponent.prototype.ngOnInit = function () {
    };
    // inbox type click event function
    ResourceComponent.prototype.GetElement = function (event, type) {
        if (type === 'Dashboard') {
            this.displayDashboard = true;
            this.displayForecast = false;
            this.displayActual = false;
            this.displayBudget = false;
            this.displayMilestone = false;
            this.displayActionlog = false;
            this.displayRisk = false;
            this.displayAssumption = false;
            this.displayIssue = false;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Forecast') {
            this.displayDashboard = false;
            this.displayForecast = true;
            this.displayActual = false;
            this.displayBudget = false;
            this.displayMilestone = false;
            this.displayActionlog = false;
            this.displayRisk = false;
            this.displayAssumption = false;
            this.displayIssue = false;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Actual') {
            this.displayDashboard = false;
            this.displayForecast = false;
            this.displayActual = true;
            this.displayBudget = false;
            this.displayMilestone = false;
            this.displayActionlog = false;
            this.displayRisk = false;
            this.displayAssumption = false;
            this.displayIssue = false;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Budget') {
            this.displayDashboard = false;
            this.displayForecast = false;
            this.displayActual = false;
            this.displayBudget = true;
            this.displayMilestone = false;
            this.displayActionlog = false;
            this.displayRisk = false;
            this.displayAssumption = false;
            this.displayIssue = false;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Milestones') {
            this.displayDashboard = false;
            this.displayForecast = false;
            this.displayActual = false;
            this.displayBudget = false;
            this.displayMilestone = true;
            this.displayActionlog = false;
            this.displayRisk = false;
            this.displayAssumption = false;
            this.displayIssue = false;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Actions') {
            this.displayDashboard = false;
            this.displayForecast = false;
            this.displayActual = false;
            this.displayBudget = false;
            this.displayMilestone = false;
            this.displayActionlog = true;
            this.displayRisk = false;
            this.displayAssumption = false;
            this.displayIssue = false;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Risks') {
            this.displayDashboard = false;
            this.displayForecast = false;
            this.displayActual = false;
            this.displayBudget = false;
            this.displayMilestone = false;
            this.displayActionlog = false;
            this.displayRisk = true;
            this.displayAssumption = false;
            this.displayIssue = false;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Assumptions') {
            this.displayDashboard = false;
            this.displayForecast = false;
            this.displayActual = false;
            this.displayBudget = false;
            this.displayMilestone = false;
            this.displayActionlog = false;
            this.displayRisk = false;
            this.displayAssumption = true;
            this.displayIssue = false;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Issues') {
            this.displayDashboard = false;
            this.displayForecast = false;
            this.displayActual = false;
            this.displayBudget = false;
            this.displayMilestone = false;
            this.displayActionlog = false;
            this.displayRisk = false;
            this.displayAssumption = false;
            this.displayIssue = true;
            this.displayDependency = false;
            this.displayRag = false;
        }
        if (type === 'Dependencies') {
            this.displayDashboard = false;
            this.displayForecast = false;
            this.displayActual = false;
            this.displayBudget = false;
            this.displayMilestone = false;
            this.displayActionlog = false;
            this.displayRisk = false;
            this.displayAssumption = false;
            this.displayIssue = false;
            this.displayDependency = true;
            this.displayRag = false;
        }
        this.SetItemActive(event);
    };
    ResourceComponent.prototype.SetItemActive = function (event) {
        var hElement = this.elRef.nativeElement;
        // now you can simply get your elements with their class name
        var allAnchors = hElement.querySelectorAll('.list-group-messages > a.list-group-item');
        // do something with selected elements
        [].forEach.call(allAnchors, function (item) {
            item.setAttribute('class', 'list-group-item list-group-item-action no-border');
        });
        // set active class for selected item
        event.currentTarget.setAttribute('class', 'list-group-item active no-border');
    };
    ResourceComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource',
            template: __webpack_require__(/*! ./resource.component.html */ "./src/app/resources/resource/resource.component.html"),
            styles: [__webpack_require__(/*! ./resource.component.scss */ "./src/app/resources/resource/resource.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"], _angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"]])
    ], ResourceComponent);
    return ResourceComponent;
}());



/***/ }),

/***/ "./src/app/shared/directives/match-height.directive.ts":
/*!*************************************************************!*\
  !*** ./src/app/shared/directives/match-height.directive.ts ***!
  \*************************************************************/
/*! exports provided: MatchHeightDirective, MatchHeightModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MatchHeightDirective", function() { return MatchHeightDirective; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MatchHeightModule", function() { return MatchHeightModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var MatchHeightDirective = /** @class */ (function () {
    function MatchHeightDirective(el) {
        this.el = el;
    }
    MatchHeightDirective.prototype.ngAfterViewInit = function () {
        var _this = this;
        // call our matchHeight function here
        setTimeout(function () { _this.matchHeights(_this.el.nativeElement, _this.matchHeight); }, 300);
    };
    MatchHeightDirective.prototype.matchHeights = function (parent, className) {
        // match height logic here
        if (!parent)
            return;
        // step 1: find all the child elements with the selected class name
        var children = parent.getElementsByClassName(className);
        if (!children)
            return;
        //Pixinvent - Match hight - fix --- comment below code
        Array.from(children).forEach(function (x) {
            x.style.height = 'initial';
        });
        // step 2a: get all the child elements heights
        var itemHeights = Array.from(children)
            .map(function (x) { return x.getBoundingClientRect().height; });
        // step 2b: find out the tallest
        var maxHeight = itemHeights.reduce(function (prev, curr) {
            return curr > prev ? curr : prev;
        }, 0);
        // step 3: update all the child elements to the tallest height
        Array.from(children)
            .forEach(function (x) { return x.style.height = maxHeight + "px"; });
    };
    MatchHeightDirective.prototype.onResize = function () {
        // call our matchHeight function here
        this.matchHeights(this.el.nativeElement, this.matchHeight);
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], MatchHeightDirective.prototype, "matchHeight", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])('window:resize'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", []),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], MatchHeightDirective.prototype, "onResize", null);
    MatchHeightDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: '[matchHeight]'
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"]])
    ], MatchHeightDirective);
    return MatchHeightDirective;
}());

var MatchHeightModule = /** @class */ (function () {
    function MatchHeightModule() {
    }
    MatchHeightModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [MatchHeightDirective],
            exports: [MatchHeightDirective]
        })
    ], MatchHeightModule);
    return MatchHeightModule;
}());



/***/ })

}]);
//# sourceMappingURL=default~admin-admin-module~resources-resources-module.js.map