(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["admin-admin-module"],{

/***/ "./src/app/admin/admin-routing.module.ts":
/*!***********************************************!*\
  !*** ./src/app/admin/admin-routing.module.ts ***!
  \***********************************************/
/*! exports provided: AdminRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AdminRoutingModule", function() { return AdminRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _hierarchy_hierarchy_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./hierarchy/hierarchy.component */ "./src/app/admin/hierarchy/hierarchy.component.ts");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _resource_resource_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./resource/resource.component */ "./src/app/admin/resource/resource.component.ts");
/* harmony import */ var _upload_centre_upload_centre_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./upload-centre/upload-centre.component */ "./src/app/admin/upload-centre/upload-centre.component.ts");






var routes = [
    {
        path: '',
        children: [
            {
                path: 'hierarchy',
                component: _hierarchy_hierarchy_component__WEBPACK_IMPORTED_MODULE_1__["HierarchyComponent"],
                data: {
                    title: 'Project Hierarchy'
                }
            },
            {
                path: 'resource',
                component: _resource_resource_component__WEBPACK_IMPORTED_MODULE_4__["ResourceComponent"],
                data: {
                    title: 'Resource'
                }
            },
            {
                path: 'uploadcentre',
                component: _upload_centre_upload_centre_component__WEBPACK_IMPORTED_MODULE_5__["UploadCentreComponent"],
                data: {
                    title: 'Upload Centre'
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
var AdminRoutingModule = /** @class */ (function () {
    function AdminRoutingModule() {
    }
    AdminRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"]]
        })
    ], AdminRoutingModule);
    return AdminRoutingModule;
}());

// export const routedComponents = [MyprojectsComponent];


/***/ }),

/***/ "./src/app/admin/admin.module.ts":
/*!***************************************!*\
  !*** ./src/app/admin/admin.module.ts ***!
  \***************************************/
/*! exports provided: AdminModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AdminModule", function() { return AdminModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _admin_routing_module__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./admin-routing.module */ "./src/app/admin/admin-routing.module.ts");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _hierarchy_hierarchy_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./hierarchy/hierarchy.component */ "./src/app/admin/hierarchy/hierarchy.component.ts");
/* harmony import */ var _domain_domain_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./domain/domain.component */ "./src/app/admin/domain/domain.component.ts");
/* harmony import */ var _businessunit_businessunit_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./businessunit/businessunit.component */ "./src/app/admin/businessunit/businessunit.component.ts");
/* harmony import */ var _portfolio_portfolio_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./portfolio/portfolio.component */ "./src/app/admin/portfolio/portfolio.component.ts");
/* harmony import */ var _programme_programme_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./programme/programme.component */ "./src/app/admin/programme/programme.component.ts");
/* harmony import */ var _project_project_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./project/project.component */ "./src/app/admin/project/project.component.ts");
/* harmony import */ var _resource_resource_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./resource/resource.component */ "./src/app/admin/resource/resource.component.ts");
/* harmony import */ var _resource_resource_resource_resource_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./resource-resource/resource-resource.component */ "./src/app/admin/resource-resource/resource-resource.component.ts");
/* harmony import */ var _resource_platform_resource_platform_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./resource-platform/resource-platform.component */ "./src/app/admin/resource-platform/resource-platform.component.ts");
/* harmony import */ var _resource_user_resource_user_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./resource-user/resource-user.component */ "./src/app/admin/resource-user/resource-user.component.ts");
/* harmony import */ var _upload_centre_upload_centre_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./upload-centre/upload-centre.component */ "./src/app/admin/upload-centre/upload-centre.component.ts");
/* harmony import */ var _upload_centre_actual_upload_centre_actual_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./upload-centre-actual/upload-centre-actual.component */ "./src/app/admin/upload-centre-actual/upload-centre-actual.component.ts");
/* harmony import */ var _compan_settings_compan_settings_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./compan-settings/compan-settings.component */ "./src/app/admin/compan-settings/compan-settings.component.ts");
/* harmony import */ var ng_chartist__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ng-chartist */ "./node_modules/ng-chartist/dist/ng-chartist.js");
/* harmony import */ var ng_chartist__WEBPACK_IMPORTED_MODULE_17___default = /*#__PURE__*/__webpack_require__.n(ng_chartist__WEBPACK_IMPORTED_MODULE_17__);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var app_shared_directives_match_height_directive__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! app/shared/directives/match-height.directive */ "./src/app/shared/directives/match-height.directive.ts");




















var AdminModule = /** @class */ (function () {
    function AdminModule() {
    }
    AdminModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            declarations: [
                _hierarchy_hierarchy_component__WEBPACK_IMPORTED_MODULE_4__["HierarchyComponent"], _domain_domain_component__WEBPACK_IMPORTED_MODULE_5__["DomainComponent"], _businessunit_businessunit_component__WEBPACK_IMPORTED_MODULE_6__["BusinessunitComponent"],
                _portfolio_portfolio_component__WEBPACK_IMPORTED_MODULE_7__["PortfolioComponent"], _programme_programme_component__WEBPACK_IMPORTED_MODULE_8__["ProgrammeComponent"], _project_project_component__WEBPACK_IMPORTED_MODULE_9__["ProjectComponent"], _resource_resource_component__WEBPACK_IMPORTED_MODULE_10__["ResourceComponent"],
                _resource_resource_resource_resource_component__WEBPACK_IMPORTED_MODULE_11__["ResourceResourceComponent"], _resource_platform_resource_platform_component__WEBPACK_IMPORTED_MODULE_12__["ResourcePlatformComponent"], _resource_user_resource_user_component__WEBPACK_IMPORTED_MODULE_13__["ResourceUserComponent"],
                _upload_centre_upload_centre_component__WEBPACK_IMPORTED_MODULE_14__["UploadCentreComponent"], _upload_centre_actual_upload_centre_actual_component__WEBPACK_IMPORTED_MODULE_15__["UploadCentreActualComponent"], _compan_settings_compan_settings_component__WEBPACK_IMPORTED_MODULE_16__["CompanSettingsComponent"]
            ],
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_3__["CommonModule"],
                _admin_routing_module__WEBPACK_IMPORTED_MODULE_1__["AdminRoutingModule"],
                ng_chartist__WEBPACK_IMPORTED_MODULE_17__["ChartistModule"],
                _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_18__["NgbModule"],
                app_shared_directives_match_height_directive__WEBPACK_IMPORTED_MODULE_19__["MatchHeightModule"]
            ]
        })
    ], AdminModule);
    return AdminModule;
}());



/***/ }),

/***/ "./src/app/admin/businessunit/businessunit.component.html":
/*!****************************************************************!*\
  !*** ./src/app/admin/businessunit/businessunit.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  businessunit works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/businessunit/businessunit.component.scss":
/*!****************************************************************!*\
  !*** ./src/app/admin/businessunit/businessunit.component.scss ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL2J1c2luZXNzdW5pdC9idXNpbmVzc3VuaXQuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/admin/businessunit/businessunit.component.ts":
/*!**************************************************************!*\
  !*** ./src/app/admin/businessunit/businessunit.component.ts ***!
  \**************************************************************/
/*! exports provided: BusinessunitComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "BusinessunitComponent", function() { return BusinessunitComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var BusinessunitComponent = /** @class */ (function () {
    function BusinessunitComponent() {
    }
    BusinessunitComponent.prototype.ngOnInit = function () {
    };
    BusinessunitComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-businessunit',
            template: __webpack_require__(/*! ./businessunit.component.html */ "./src/app/admin/businessunit/businessunit.component.html"),
            styles: [__webpack_require__(/*! ./businessunit.component.scss */ "./src/app/admin/businessunit/businessunit.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], BusinessunitComponent);
    return BusinessunitComponent;
}());



/***/ }),

/***/ "./src/app/admin/compan-settings/compan-settings.component.html":
/*!**********************************************************************!*\
  !*** ./src/app/admin/compan-settings/compan-settings.component.html ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  compan-settings works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/compan-settings/compan-settings.component.scss":
/*!**********************************************************************!*\
  !*** ./src/app/admin/compan-settings/compan-settings.component.scss ***!
  \**********************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL2NvbXBhbi1zZXR0aW5ncy9jb21wYW4tc2V0dGluZ3MuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/admin/compan-settings/compan-settings.component.ts":
/*!********************************************************************!*\
  !*** ./src/app/admin/compan-settings/compan-settings.component.ts ***!
  \********************************************************************/
/*! exports provided: CompanSettingsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CompanSettingsComponent", function() { return CompanSettingsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var CompanSettingsComponent = /** @class */ (function () {
    function CompanSettingsComponent() {
    }
    CompanSettingsComponent.prototype.ngOnInit = function () {
    };
    CompanSettingsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-compan-settings',
            template: __webpack_require__(/*! ./compan-settings.component.html */ "./src/app/admin/compan-settings/compan-settings.component.html"),
            styles: [__webpack_require__(/*! ./compan-settings.component.scss */ "./src/app/admin/compan-settings/compan-settings.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], CompanSettingsComponent);
    return CompanSettingsComponent;
}());



/***/ }),

/***/ "./src/app/admin/domain/domain.component.html":
/*!****************************************************!*\
  !*** ./src/app/admin/domain/domain.component.html ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"email-app-content-area w-100\">\r\n    <div class=\"email-app-list-mails p-0\">\r\n      <div  class=\"email-app-list\">\r\n        <div id=\"users-list\">\r\n            <div class=\"action-buttons pull-left mt-2 text-center\">\r\n                <a class=\"btn btn-raised gradient-blackberry py-2 px-4 white mr-2\">Add New</a>\r\n              </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"email-app-mail-content\" #emailContent>\r\n      <div class=\"email-app-mail-content-detail\">\r\n        <div class=\"email-app-options card-body\">\r\n          <div class=\"row d-md-none\">\r\n            <button class=\"btn btn-raised btn-primary ml-2 back-to-inbox\">\r\n              <i class=\"fa fa-angle-left\"></i> Back to inbox</button>\r\n          </div>\r\n        </div>\r\n        <!-- side 3 -->\r\n        <div classs =\"m-2 p-2\">\r\n            <div classs =\"row\">\r\n\r\n\r\n            </div>\r\n          </div>\r\n      </div>\r\n      <div class=\"email-app-mail-content-detail\" *ngIf=\"false\">\r\n        <p class=\"primary text-center\">Select a message to read</p>\r\n      </div>\r\n    </div>\r\n  </div>\r\n"

/***/ }),

/***/ "./src/app/admin/domain/domain.component.scss":
/*!****************************************************!*\
  !*** ./src/app/admin/domain/domain.component.scss ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL2RvbWFpbi9kb21haW4uY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/admin/domain/domain.component.ts":
/*!**************************************************!*\
  !*** ./src/app/admin/domain/domain.component.ts ***!
  \**************************************************/
/*! exports provided: DomainComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DomainComponent", function() { return DomainComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var DomainComponent = /** @class */ (function () {
    function DomainComponent() {
    }
    DomainComponent.prototype.ngOnInit = function () {
    };
    DomainComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-domain',
            template: __webpack_require__(/*! ./domain.component.html */ "./src/app/admin/domain/domain.component.html"),
            styles: [__webpack_require__(/*! ./domain.component.scss */ "./src/app/admin/domain/domain.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], DomainComponent);
    return DomainComponent;
}());



/***/ }),

/***/ "./src/app/admin/hierarchy/hierarchy.component.html":
/*!**********************************************************!*\
  !*** ./src/app/admin/hierarchy/hierarchy.component.html ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <h1 class=\"card-title m-1 pl-2 pull-left mb-2 text-muted text-primary\">Project Hierarchy<span class=\"text-lowercase uk-text-small\">- for reporting</span></h1>\r\n</div>\r\n<div classs =\"m-2 p-2\">\r\n    <div classs =\"row\">\r\n        <div class=\"col-12\">\r\n            <ngb-tabset  type=\"pills\">\r\n                <hr>\r\n                <ngb-tab>\r\n                  <ng-template ngbTabTitle>Domains</ng-template>\r\n                  <ng-template ngbTabContent>\r\n                    <hr>\r\n                    <div class=\"container-fluid m-2\">\r\n                      <app-domain></app-domain>\r\n                    </div>\r\n                  </ng-template>\r\n                </ngb-tab>\r\n                <ngb-tab>\r\n                  <ng-template ngbTabTitle>Business units</ng-template>\r\n                  <ng-template ngbTabContent>\r\n                    <hr>\r\n                    <div class=\"container-fluid m-2\">\r\n                      <app-businessunit></app-businessunit>\r\n                    </div>\r\n                  </ng-template>\r\n                </ngb-tab>\r\n                <ngb-tab>\r\n                  <ng-template ngbTabTitle>Portfolios</ng-template>\r\n                  <ng-template ngbTabContent>\r\n                    <hr>\r\n                    <div class=\"container-fluid m-2\">\r\n                      <app-portfolio></app-portfolio>\r\n                    </div>\r\n                  </ng-template>\r\n                </ngb-tab>\r\n                <ngb-tab>\r\n                  <ng-template ngbTabTitle>Programmes</ng-template>\r\n                  <ng-template ngbTabContent>\r\n                    <hr>\r\n                    <div class=\"container-fluid m-2\">\r\n                      <app-programme></app-programme>\r\n                    </div>\r\n                  </ng-template>\r\n                </ngb-tab>\r\n                <ngb-tab>\r\n                  <ng-template ngbTabTitle>Projects</ng-template>\r\n                  <ng-template ngbTabContent>\r\n                    <hr>\r\n                    <div class=\"container-fluid m-2\">\r\n                      <app-project></app-project>\r\n                    </div>\r\n                  </ng-template>\r\n              </ngb-tab>\r\n          </ngb-tabset>\r\n      </div>\r\n  </div>\r\n</div>\r\n"

/***/ }),

/***/ "./src/app/admin/hierarchy/hierarchy.component.scss":
/*!**********************************************************!*\
  !*** ./src/app/admin/hierarchy/hierarchy.component.scss ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL2hpZXJhcmNoeS9oaWVyYXJjaHkuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/admin/hierarchy/hierarchy.component.ts":
/*!********************************************************!*\
  !*** ./src/app/admin/hierarchy/hierarchy.component.ts ***!
  \********************************************************/
/*! exports provided: HierarchyComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HierarchyComponent", function() { return HierarchyComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var HierarchyComponent = /** @class */ (function () {
    function HierarchyComponent() {
    }
    HierarchyComponent.prototype.ngOnInit = function () {
    };
    HierarchyComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-hierarchy',
            template: __webpack_require__(/*! ./hierarchy.component.html */ "./src/app/admin/hierarchy/hierarchy.component.html"),
            styles: [__webpack_require__(/*! ./hierarchy.component.scss */ "./src/app/admin/hierarchy/hierarchy.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], HierarchyComponent);
    return HierarchyComponent;
}());



/***/ }),

/***/ "./src/app/admin/portfolio/portfolio.component.html":
/*!**********************************************************!*\
  !*** ./src/app/admin/portfolio/portfolio.component.html ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  portfolio works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/portfolio/portfolio.component.scss":
/*!**********************************************************!*\
  !*** ./src/app/admin/portfolio/portfolio.component.scss ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3BvcnRmb2xpby9wb3J0Zm9saW8uY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/admin/portfolio/portfolio.component.ts":
/*!********************************************************!*\
  !*** ./src/app/admin/portfolio/portfolio.component.ts ***!
  \********************************************************/
/*! exports provided: PortfolioComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PortfolioComponent", function() { return PortfolioComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var PortfolioComponent = /** @class */ (function () {
    function PortfolioComponent() {
    }
    PortfolioComponent.prototype.ngOnInit = function () {
    };
    PortfolioComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-portfolio',
            template: __webpack_require__(/*! ./portfolio.component.html */ "./src/app/admin/portfolio/portfolio.component.html"),
            styles: [__webpack_require__(/*! ./portfolio.component.scss */ "./src/app/admin/portfolio/portfolio.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], PortfolioComponent);
    return PortfolioComponent;
}());



/***/ }),

/***/ "./src/app/admin/programme/programme.component.html":
/*!**********************************************************!*\
  !*** ./src/app/admin/programme/programme.component.html ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  programme works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/programme/programme.component.scss":
/*!**********************************************************!*\
  !*** ./src/app/admin/programme/programme.component.scss ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3Byb2dyYW1tZS9wcm9ncmFtbWUuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/admin/programme/programme.component.ts":
/*!********************************************************!*\
  !*** ./src/app/admin/programme/programme.component.ts ***!
  \********************************************************/
/*! exports provided: ProgrammeComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProgrammeComponent", function() { return ProgrammeComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ProgrammeComponent = /** @class */ (function () {
    function ProgrammeComponent() {
    }
    ProgrammeComponent.prototype.ngOnInit = function () {
    };
    ProgrammeComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-programme',
            template: __webpack_require__(/*! ./programme.component.html */ "./src/app/admin/programme/programme.component.html"),
            styles: [__webpack_require__(/*! ./programme.component.scss */ "./src/app/admin/programme/programme.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ProgrammeComponent);
    return ProgrammeComponent;
}());



/***/ }),

/***/ "./src/app/admin/project/project.component.html":
/*!******************************************************!*\
  !*** ./src/app/admin/project/project.component.html ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  project works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/project/project.component.scss":
/*!******************************************************!*\
  !*** ./src/app/admin/project/project.component.scss ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3Byb2plY3QvcHJvamVjdC5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/admin/project/project.component.ts":
/*!****************************************************!*\
  !*** ./src/app/admin/project/project.component.ts ***!
  \****************************************************/
/*! exports provided: ProjectComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProjectComponent", function() { return ProjectComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ProjectComponent = /** @class */ (function () {
    function ProjectComponent() {
    }
    ProjectComponent.prototype.ngOnInit = function () {
    };
    ProjectComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-project',
            template: __webpack_require__(/*! ./project.component.html */ "./src/app/admin/project/project.component.html"),
            styles: [__webpack_require__(/*! ./project.component.scss */ "./src/app/admin/project/project.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ProjectComponent);
    return ProjectComponent;
}());



/***/ }),

/***/ "./src/app/admin/resource-platform/resource-platform.component.html":
/*!**************************************************************************!*\
  !*** ./src/app/admin/resource-platform/resource-platform.component.html ***!
  \**************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-platform works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/resource-platform/resource-platform.component.scss":
/*!**************************************************************************!*\
  !*** ./src/app/admin/resource-platform/resource-platform.component.scss ***!
  \**************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3Jlc291cmNlLXBsYXRmb3JtL3Jlc291cmNlLXBsYXRmb3JtLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/admin/resource-platform/resource-platform.component.ts":
/*!************************************************************************!*\
  !*** ./src/app/admin/resource-platform/resource-platform.component.ts ***!
  \************************************************************************/
/*! exports provided: ResourcePlatformComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcePlatformComponent", function() { return ResourcePlatformComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourcePlatformComponent = /** @class */ (function () {
    function ResourcePlatformComponent() {
    }
    ResourcePlatformComponent.prototype.ngOnInit = function () {
    };
    ResourcePlatformComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-platform',
            template: __webpack_require__(/*! ./resource-platform.component.html */ "./src/app/admin/resource-platform/resource-platform.component.html"),
            styles: [__webpack_require__(/*! ./resource-platform.component.scss */ "./src/app/admin/resource-platform/resource-platform.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourcePlatformComponent);
    return ResourcePlatformComponent;
}());



/***/ }),

/***/ "./src/app/admin/resource-resource/resource-resource.component.html":
/*!**************************************************************************!*\
  !*** ./src/app/admin/resource-resource/resource-resource.component.html ***!
  \**************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-resource works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/resource-resource/resource-resource.component.scss":
/*!**************************************************************************!*\
  !*** ./src/app/admin/resource-resource/resource-resource.component.scss ***!
  \**************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3Jlc291cmNlLXJlc291cmNlL3Jlc291cmNlLXJlc291cmNlLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/admin/resource-resource/resource-resource.component.ts":
/*!************************************************************************!*\
  !*** ./src/app/admin/resource-resource/resource-resource.component.ts ***!
  \************************************************************************/
/*! exports provided: ResourceResourceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceResourceComponent", function() { return ResourceResourceComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceResourceComponent = /** @class */ (function () {
    function ResourceResourceComponent() {
    }
    ResourceResourceComponent.prototype.ngOnInit = function () {
    };
    ResourceResourceComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-resource',
            template: __webpack_require__(/*! ./resource-resource.component.html */ "./src/app/admin/resource-resource/resource-resource.component.html"),
            styles: [__webpack_require__(/*! ./resource-resource.component.scss */ "./src/app/admin/resource-resource/resource-resource.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceResourceComponent);
    return ResourceResourceComponent;
}());



/***/ }),

/***/ "./src/app/admin/resource-user/resource-user.component.html":
/*!******************************************************************!*\
  !*** ./src/app/admin/resource-user/resource-user.component.html ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-user works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/resource-user/resource-user.component.scss":
/*!******************************************************************!*\
  !*** ./src/app/admin/resource-user/resource-user.component.scss ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3Jlc291cmNlLXVzZXIvcmVzb3VyY2UtdXNlci5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/admin/resource-user/resource-user.component.ts":
/*!****************************************************************!*\
  !*** ./src/app/admin/resource-user/resource-user.component.ts ***!
  \****************************************************************/
/*! exports provided: ResourceUserComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceUserComponent", function() { return ResourceUserComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceUserComponent = /** @class */ (function () {
    function ResourceUserComponent() {
    }
    ResourceUserComponent.prototype.ngOnInit = function () {
    };
    ResourceUserComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-user',
            template: __webpack_require__(/*! ./resource-user.component.html */ "./src/app/admin/resource-user/resource-user.component.html"),
            styles: [__webpack_require__(/*! ./resource-user.component.scss */ "./src/app/admin/resource-user/resource-user.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceUserComponent);
    return ResourceUserComponent;
}());



/***/ }),

/***/ "./src/app/admin/resource/resource.component.html":
/*!********************************************************!*\
  !*** ./src/app/admin/resource/resource.component.html ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/resource/resource.component.scss":
/*!********************************************************!*\
  !*** ./src/app/admin/resource/resource.component.scss ***!
  \********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3Jlc291cmNlL3Jlc291cmNlLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/admin/resource/resource.component.ts":
/*!******************************************************!*\
  !*** ./src/app/admin/resource/resource.component.ts ***!
  \******************************************************/
/*! exports provided: ResourceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceComponent", function() { return ResourceComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceComponent = /** @class */ (function () {
    function ResourceComponent() {
    }
    ResourceComponent.prototype.ngOnInit = function () {
    };
    ResourceComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource',
            template: __webpack_require__(/*! ./resource.component.html */ "./src/app/admin/resource/resource.component.html"),
            styles: [__webpack_require__(/*! ./resource.component.scss */ "./src/app/admin/resource/resource.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceComponent);
    return ResourceComponent;
}());



/***/ }),

/***/ "./src/app/admin/upload-centre-actual/upload-centre-actual.component.html":
/*!********************************************************************************!*\
  !*** ./src/app/admin/upload-centre-actual/upload-centre-actual.component.html ***!
  \********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  upload-centre-actual works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/upload-centre-actual/upload-centre-actual.component.scss":
/*!********************************************************************************!*\
  !*** ./src/app/admin/upload-centre-actual/upload-centre-actual.component.scss ***!
  \********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3VwbG9hZC1jZW50cmUtYWN0dWFsL3VwbG9hZC1jZW50cmUtYWN0dWFsLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/admin/upload-centre-actual/upload-centre-actual.component.ts":
/*!******************************************************************************!*\
  !*** ./src/app/admin/upload-centre-actual/upload-centre-actual.component.ts ***!
  \******************************************************************************/
/*! exports provided: UploadCentreActualComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UploadCentreActualComponent", function() { return UploadCentreActualComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var UploadCentreActualComponent = /** @class */ (function () {
    function UploadCentreActualComponent() {
    }
    UploadCentreActualComponent.prototype.ngOnInit = function () {
    };
    UploadCentreActualComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-upload-centre-actual',
            template: __webpack_require__(/*! ./upload-centre-actual.component.html */ "./src/app/admin/upload-centre-actual/upload-centre-actual.component.html"),
            styles: [__webpack_require__(/*! ./upload-centre-actual.component.scss */ "./src/app/admin/upload-centre-actual/upload-centre-actual.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], UploadCentreActualComponent);
    return UploadCentreActualComponent;
}());



/***/ }),

/***/ "./src/app/admin/upload-centre/upload-centre.component.html":
/*!******************************************************************!*\
  !*** ./src/app/admin/upload-centre/upload-centre.component.html ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  upload-centre works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/admin/upload-centre/upload-centre.component.scss":
/*!******************************************************************!*\
  !*** ./src/app/admin/upload-centre/upload-centre.component.scss ***!
  \******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2FkbWluL3VwbG9hZC1jZW50cmUvdXBsb2FkLWNlbnRyZS5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/admin/upload-centre/upload-centre.component.ts":
/*!****************************************************************!*\
  !*** ./src/app/admin/upload-centre/upload-centre.component.ts ***!
  \****************************************************************/
/*! exports provided: UploadCentreComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "UploadCentreComponent", function() { return UploadCentreComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var UploadCentreComponent = /** @class */ (function () {
    function UploadCentreComponent() {
    }
    UploadCentreComponent.prototype.ngOnInit = function () {
    };
    UploadCentreComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-upload-centre',
            template: __webpack_require__(/*! ./upload-centre.component.html */ "./src/app/admin/upload-centre/upload-centre.component.html"),
            styles: [__webpack_require__(/*! ./upload-centre.component.scss */ "./src/app/admin/upload-centre/upload-centre.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], UploadCentreComponent);
    return UploadCentreComponent;
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
//# sourceMappingURL=admin-admin-module.js.map