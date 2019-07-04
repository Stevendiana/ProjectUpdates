(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["resources-resources-module"],{

/***/ "./src/app/resources/resources-routing.module.ts":
/*!*******************************************************!*\
  !*** ./src/app/resources/resources-routing.module.ts ***!
  \*******************************************************/
/*! exports provided: ResourcesRoutingModule, routedComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesRoutingModule", function() { return ResourcesRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routedComponents", function() { return routedComponents; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _resources_resources_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./resources/resources.component */ "./src/app/resources/resources/resources.component.ts");




var routes = [
    {
        path: '',
        component: _resources_resources_component__WEBPACK_IMPORTED_MODULE_3__["ResourcesComponent"],
        data: {
            title: 'Resource pool'
        },
    }
];
var ResourcesRoutingModule = /** @class */ (function () {
    function ResourcesRoutingModule() {
    }
    ResourcesRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]]
        })
    ], ResourcesRoutingModule);
    return ResourcesRoutingModule;
}());

var routedComponents = [_resources_resources_component__WEBPACK_IMPORTED_MODULE_3__["ResourcesComponent"]];


/***/ }),

/***/ "./src/app/resources/resources.module.ts":
/*!***********************************************!*\
  !*** ./src/app/resources/resources.module.ts ***!
  \***********************************************/
/*! exports provided: ResourcesModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesModule", function() { return ResourcesModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _resources_resources_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./resources/resources.component */ "./src/app/resources/resources/resources.component.ts");
/* harmony import */ var _resources_routing_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./resources-routing.module */ "./src/app/resources/resources-routing.module.ts");





var ResourcesModule = /** @class */ (function () {
    function ResourcesModule() {
    }
    ResourcesModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [_resources_resources_component__WEBPACK_IMPORTED_MODULE_3__["ResourcesComponent"]],
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _resources_routing_module__WEBPACK_IMPORTED_MODULE_4__["ResourcesRoutingModule"]
            ]
        })
    ], ResourcesModule);
    return ResourcesModule;
}());



/***/ }),

/***/ "./src/app/resources/resources/resources.component.html":
/*!**************************************************************!*\
  !*** ./src/app/resources/resources/resources.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resources works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resources/resources.component.scss":
/*!**************************************************************!*\
  !*** ./src/app/resources/resources/resources.component.scss ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZXMvcmVzb3VyY2VzLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/resources/resources/resources.component.ts":
/*!************************************************************!*\
  !*** ./src/app/resources/resources/resources.component.ts ***!
  \************************************************************/
/*! exports provided: ResourcesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesComponent", function() { return ResourcesComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourcesComponent = /** @class */ (function () {
    function ResourcesComponent() {
    }
    ResourcesComponent.prototype.ngOnInit = function () {
    };
    ResourcesComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources',
            template: __webpack_require__(/*! ./resources.component.html */ "./src/app/resources/resources/resources.component.html"),
            styles: [__webpack_require__(/*! ./resources.component.scss */ "./src/app/resources/resources/resources.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourcesComponent);
    return ResourcesComponent;
}());



/***/ })

}]);
//# sourceMappingURL=resources-resources-module.js.map