(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["support-support-module"],{

/***/ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.html":
/*!****************************************************************************************!*\
  !*** ./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.html ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  support-how-to-do-guide works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.scss":
/*!****************************************************************************************!*\
  !*** ./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.scss ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3N1cHBvcnQvc3VwcG9ydC1ob3ctdG8tZG8tZ3VpZGUvc3VwcG9ydC1ob3ctdG8tZG8tZ3VpZGUuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.ts":
/*!**************************************************************************************!*\
  !*** ./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.ts ***!
  \**************************************************************************************/
/*! exports provided: SupportHowToDoGuideComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SupportHowToDoGuideComponent", function() { return SupportHowToDoGuideComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var SupportHowToDoGuideComponent = /** @class */ (function () {
    function SupportHowToDoGuideComponent() {
    }
    SupportHowToDoGuideComponent.prototype.ngOnInit = function () {
    };
    SupportHowToDoGuideComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-support-how-to-do-guide',
            template: __webpack_require__(/*! ./support-how-to-do-guide.component.html */ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.html"),
            styles: [__webpack_require__(/*! ./support-how-to-do-guide.component.scss */ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], SupportHowToDoGuideComponent);
    return SupportHowToDoGuideComponent;
}());



/***/ }),

/***/ "./src/app/support/support-routing.module.ts":
/*!***************************************************!*\
  !*** ./src/app/support/support-routing.module.ts ***!
  \***************************************************/
/*! exports provided: SupportRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SupportRoutingModule", function() { return SupportRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _support_how_to_do_guide_support_how_to_do_guide_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./support-how-to-do-guide/support-how-to-do-guide.component */ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.ts");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");




var routes = [
    {
        path: '',
        children: [
            {
                path: 'howtoguide',
                component: _support_how_to_do_guide_support_how_to_do_guide_component__WEBPACK_IMPORTED_MODULE_1__["SupportHowToDoGuideComponent"],
                data: {
                    title: 'Projects'
                }
            },
        ]
        // path: '',
        //  component: MyprojectsComponent,
        // data: {
        //   title: 'Projects'
        // },
    }
];
var SupportRoutingModule = /** @class */ (function () {
    function SupportRoutingModule() {
    }
    SupportRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"]]
        })
    ], SupportRoutingModule);
    return SupportRoutingModule;
}());

// export const routedComponents = [MyprojectsComponent];


/***/ }),

/***/ "./src/app/support/support.module.ts":
/*!*******************************************!*\
  !*** ./src/app/support/support.module.ts ***!
  \*******************************************/
/*! exports provided: SupportModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SupportModule", function() { return SupportModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _support_how_to_do_guide_support_how_to_do_guide_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./support-how-to-do-guide/support-how-to-do-guide.component */ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.ts");
/* harmony import */ var _support_routing_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./support-routing.module */ "./src/app/support/support-routing.module.ts");





var SupportModule = /** @class */ (function () {
    function SupportModule() {
    }
    SupportModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [_support_how_to_do_guide_support_how_to_do_guide_component__WEBPACK_IMPORTED_MODULE_3__["SupportHowToDoGuideComponent"], _support_routing_module__WEBPACK_IMPORTED_MODULE_4__["SupportRoutingModule"]],
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"]
            ]
        })
    ], SupportModule);
    return SupportModule;
}());



/***/ })

}]);
//# sourceMappingURL=support-support-module.js.map