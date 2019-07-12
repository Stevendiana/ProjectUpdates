(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"],{

/***/ "./src/$$_lazy_route_resource lazy recursive":
/*!**********************************************************!*\
  !*** ./src/$$_lazy_route_resource lazy namespace object ***!
  \**********************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var map = {
	"./admin/admin.module": [
		"./src/app/admin/admin.module.ts",
		"default~admin-admin-module~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-~b413bfe0",
		"admin-admin-module"
	],
	"./chat/chat.module": [
		"./src/app/chat/chat.module.ts",
		"chat-chat-module"
	],
	"./dashboard/dashboard.module": [
		"./src/app/dashboard/dashboard.module.ts",
		"default~admin-admin-module~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-~b413bfe0",
		"default~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-full-pages-module~p~8010b75d",
		"default~dashboard-dashboard-module~project-project-module"
	],
	"./inbox/inbox.module": [
		"./src/app/inbox/inbox.module.ts",
		"default~inbox-inbox-module~project-project-module~timesheets-timesheets-module"
	],
	"./myprojects/myprojects.module": [
		"./src/app/myprojects/myprojects.module.ts",
		"default~admin-admin-module~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-~b413bfe0",
		"default~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-full-pages-module~p~8010b75d",
		"myprojects-myprojects-module"
	],
	"./pages/content-pages/content-pages.module": [
		"./src/app/pages/content-pages/content-pages.module.ts",
		"pages-content-pages-content-pages-module"
	],
	"./pages/full-pages/full-pages.module": [
		"./src/app/pages/full-pages/full-pages.module.ts",
		"default~admin-admin-module~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-~b413bfe0",
		"default~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-full-pages-module~p~8010b75d",
		"pages-full-pages-full-pages-module"
	],
	"./project/project.module": [
		"./src/app/project/project.module.ts",
		"default~admin-admin-module~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-~b413bfe0",
		"default~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-full-pages-module~p~8010b75d",
		"default~inbox-inbox-module~project-project-module~timesheets-timesheets-module",
		"default~dashboard-dashboard-module~project-project-module",
		"project-project-module"
	],
	"./resources/resources.module": [
		"./src/app/resources/resources.module.ts",
		"default~admin-admin-module~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-~b413bfe0",
		"default~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-full-pages-module~p~8010b75d",
		"resources-resources-module"
	],
	"./support/support.module": [
		"./src/app/support/support.module.ts",
		"default~admin-admin-module~dashboard-dashboard-module~myprojects-myprojects-module~pages-full-pages-~b413bfe0",
		"support-support-module"
	],
	"./timesheets/timesheets.module": [
		"./src/app/timesheets/timesheets.module.ts",
		"default~inbox-inbox-module~project-project-module~timesheets-timesheets-module",
		"timesheets-timesheets-module"
	]
};
function webpackAsyncContext(req) {
	var ids = map[req];
	if(!ids) {
		return Promise.resolve().then(function() {
			var e = new Error("Cannot find module '" + req + "'");
			e.code = 'MODULE_NOT_FOUND';
			throw e;
		});
	}
	return Promise.all(ids.slice(1).map(__webpack_require__.e)).then(function() {
		var id = ids[0];
		return __webpack_require__(id);
	});
}
webpackAsyncContext.keys = function webpackAsyncContextKeys() {
	return Object.keys(map);
};
webpackAsyncContext.id = "./src/$$_lazy_route_resource lazy recursive";
module.exports = webpackAsyncContext;

/***/ }),

/***/ "./src/app/app-routing.module.ts":
/*!***************************************!*\
  !*** ./src/app/app-routing.module.ts ***!
  \***************************************/
/*! exports provided: AppRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function() { return AppRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _layouts_full_full_layout_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./layouts/full/full-layout.component */ "./src/app/layouts/full/full-layout.component.ts");
/* harmony import */ var _layouts_content_content_layout_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./layouts/content/content-layout.component */ "./src/app/layouts/content/content-layout.component.ts");
/* harmony import */ var _shared_routes_full_layout_routes__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./shared/routes/full-layout.routes */ "./src/app/shared/routes/full-layout.routes.ts");
/* harmony import */ var _shared_routes_content_layout_routes__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./shared/routes/content-layout.routes */ "./src/app/shared/routes/content-layout.routes.ts");
/* harmony import */ var _shared_auth_auth_guard_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./shared/auth/auth-guard.service */ "./src/app/shared/auth/auth-guard.service.ts");








var appRoutes = [
    {
        path: '',
        redirectTo: '/pages/login',
        pathMatch: 'full',
    },
    // {
    //   path: '',
    //   redirectTo: '/myprojects/myprojects',
    //   pathMatch: 'full',
    // },
    // {
    //   path: '',
    //   redirectTo: 'myprojects',
    //   pathMatch: 'full',
    // },
    // {
    //   path: '',
    //   redirectTo: 'dashboard/dashboard2',
    //   pathMatch: 'full',
    // },
    { path: '', component: _layouts_full_full_layout_component__WEBPACK_IMPORTED_MODULE_3__["FullLayoutComponent"], data: { title: 'full Views' }, children: _shared_routes_full_layout_routes__WEBPACK_IMPORTED_MODULE_5__["Full_ROUTES"], canActivate: [_shared_auth_auth_guard_service__WEBPACK_IMPORTED_MODULE_7__["AuthGuard"]] },
    { path: '', component: _layouts_content_content_layout_component__WEBPACK_IMPORTED_MODULE_4__["ContentLayoutComponent"], data: { title: 'content Views' }, children: _shared_routes_content_layout_routes__WEBPACK_IMPORTED_MODULE_6__["CONTENT_ROUTES"] },
    {
        path: '**',
        redirectTo: 'pages/error'
    }
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(appRoutes, { preloadingStrategy: _angular_router__WEBPACK_IMPORTED_MODULE_2__["PreloadAllModules"] })],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());



/***/ }),

/***/ "./src/app/app.component.html":
/*!************************************!*\
  !*** ./src/app/app.component.html ***!
  \************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n<!-- <div *ngIf=\"!isAuthentic\">\r\n  <app-login-page></app-login-page>\r\n</div>\r\n\r\n<div *ngIf=\"isAuthentic\">\r\n\r\n</div> -->\r\n<router-outlet></router-outlet>\r\n\r\n\r\n"

/***/ }),

/***/ "./src/app/app.component.ts":
/*!**********************************!*\
  !*** ./src/app/app.component.ts ***!
  \**********************************/
/*! exports provided: AppComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function() { return AppComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");
/* harmony import */ var _shared_auth_auth_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./shared/auth/auth.service */ "./src/app/shared/auth/auth.service.ts");





var AppComponent = /** @class */ (function () {
    function AppComponent(router, auth) {
        this.router = router;
        this.auth = auth;
        this.isAuthentic = false;
    }
    AppComponent.prototype.ngOnInit = function () {
        this.subscription = this.router.events
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_3__["filter"])(function (event) { return event instanceof _angular_router__WEBPACK_IMPORTED_MODULE_2__["NavigationEnd"]; }))
            .subscribe(function () { return window.scrollTo(0, 0); });
    };
    AppComponent.prototype.ngOnDestroy = function () {
        if (this.subscription) {
            this.subscription.unsubscribe();
        }
    };
    AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-root',
            template: __webpack_require__(/*! ./app.component.html */ "./src/app/app.component.html")
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"], _shared_auth_auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"]])
    ], AppComponent);
    return AppComponent;
}());



/***/ }),

/***/ "./src/app/app.fl.ts":
/*!***************************!*\
  !*** ./src/app/app.fl.ts ***!
  \***************************/
/*! exports provided: FlPipe */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FlPipe", function() { return FlPipe; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var FlPipe = /** @class */ (function () {
    function FlPipe() {
    }
    FlPipe.prototype.transform = function (val) {
        var res = val.charAt(0);
        return res;
    };
    FlPipe = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Pipe"])({
            name: 'fl'
        })
    ], FlPipe);
    return FlPipe;
}());



/***/ }),

/***/ "./src/app/app.module.ts":
/*!*******************************!*\
  !*** ./src/app/app.module.ts ***!
  \*******************************/
/*! exports provided: createTranslateLoader, AppModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "createTranslateLoader", function() { return createTranslateLoader; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function() { return AppModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm5/animations.js");
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
/* harmony import */ var _shared_shared_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./shared/shared.module */ "./src/app/shared/shared.module.ts");
/* harmony import */ var ngx_toastr__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ngx-toastr */ "./node_modules/ngx-toastr/fesm5/ngx-toastr.js");
/* harmony import */ var _agm_core__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @agm/core */ "./node_modules/@agm/core/index.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm5/ngx-translate-core.js");
/* harmony import */ var _ngx_translate_http_loader__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @ngx-translate/http-loader */ "./node_modules/@ngx-translate/http-loader/esm5/ngx-translate-http-loader.js");
/* harmony import */ var _ngrx_store__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @ngrx/store */ "./node_modules/@ngrx/store/fesm5/store.js");
/* harmony import */ var ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ngx-perfect-scrollbar */ "./node_modules/ngx-perfect-scrollbar/dist/ngx-perfect-scrollbar.es5.js");
/* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
/* harmony import */ var _layouts_content_content_layout_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./layouts/content/content-layout.component */ "./src/app/layouts/content/content-layout.component.ts");
/* harmony import */ var _layouts_full_full_layout_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./layouts/full/full-layout.component */ "./src/app/layouts/full/full-layout.component.ts");
/* harmony import */ var ng2_dragula__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ng2-dragula */ "./node_modules/ng2-dragula/dist/fesm5/ng2-dragula.js");
/* harmony import */ var _shared_auth_auth_service__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./shared/auth/auth.service */ "./src/app/shared/auth/auth.service.ts");
/* harmony import */ var _shared_auth_auth_guard_service__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./shared/auth/auth-guard.service */ "./src/app/shared/auth/auth-guard.service.ts");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");




















var DEFAULT_PERFECT_SCROLLBAR_CONFIG = {
    suppressScrollX: true,
    wheelPropagation: false
};
function createTranslateLoader(http) {
    return new _ngx_translate_http_loader__WEBPACK_IMPORTED_MODULE_10__["TranslateHttpLoader"](http, './assets/i18n/', '.json');
}
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [_app_component__WEBPACK_IMPORTED_MODULE_13__["AppComponent"], _layouts_full_full_layout_component__WEBPACK_IMPORTED_MODULE_15__["FullLayoutComponent"], _layouts_content_content_layout_component__WEBPACK_IMPORTED_MODULE_14__["ContentLayoutComponent"]],
            imports: [
                _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_2__["BrowserAnimationsModule"],
                _ngrx_store__WEBPACK_IMPORTED_MODULE_11__["StoreModule"].forRoot({}),
                _app_routing_module__WEBPACK_IMPORTED_MODULE_4__["AppRoutingModule"],
                _shared_shared_module__WEBPACK_IMPORTED_MODULE_5__["SharedModule"],
                _angular_http__WEBPACK_IMPORTED_MODULE_19__["HttpModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_8__["HttpClientModule"],
                ngx_toastr__WEBPACK_IMPORTED_MODULE_6__["ToastrModule"].forRoot(),
                _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_3__["NgbModule"].forRoot(),
                _ngx_translate_core__WEBPACK_IMPORTED_MODULE_9__["TranslateModule"].forRoot({
                    loader: {
                        provide: _ngx_translate_core__WEBPACK_IMPORTED_MODULE_9__["TranslateLoader"],
                        useFactory: createTranslateLoader,
                        deps: [_angular_common_http__WEBPACK_IMPORTED_MODULE_8__["HttpClient"]]
                    }
                }),
                _agm_core__WEBPACK_IMPORTED_MODULE_7__["AgmCoreModule"].forRoot({
                    apiKey: 'AIzaSyCERobClkCv1U4mDijGm1FShKva_nxsGJY'
                }),
                ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_12__["PerfectScrollbarModule"]
            ],
            providers: [
                _shared_auth_auth_service__WEBPACK_IMPORTED_MODULE_17__["AuthService"],
                _shared_auth_auth_guard_service__WEBPACK_IMPORTED_MODULE_18__["AuthGuard"],
                ng2_dragula__WEBPACK_IMPORTED_MODULE_16__["DragulaService"],
                {
                    provide: ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_12__["PERFECT_SCROLLBAR_CONFIG"],
                    useValue: DEFAULT_PERFECT_SCROLLBAR_CONFIG
                },
                { provide: ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_12__["PERFECT_SCROLLBAR_CONFIG"], useValue: DEFAULT_PERFECT_SCROLLBAR_CONFIG }
            ],
            bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_13__["AppComponent"]]
        })
    ], AppModule);
    return AppModule;
}());



/***/ }),

/***/ "./src/app/layouts/content/content-layout.component.html":
/*!***************************************************************!*\
  !*** ./src/app/layouts/content/content-layout.component.html ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\r\n<router-outlet></router-outlet>\r\n\r\n"

/***/ }),

/***/ "./src/app/layouts/content/content-layout.component.scss":
/*!***************************************************************!*\
  !*** ./src/app/layouts/content/content-layout.component.scss ***!
  \***************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2xheW91dHMvY29udGVudC9jb250ZW50LWxheW91dC5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/layouts/content/content-layout.component.ts":
/*!*************************************************************!*\
  !*** ./src/app/layouts/content/content-layout.component.ts ***!
  \*************************************************************/
/*! exports provided: ContentLayoutComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ContentLayoutComponent", function() { return ContentLayoutComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ContentLayoutComponent = /** @class */ (function () {
    function ContentLayoutComponent() {
    }
    ContentLayoutComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-content-layout',
            template: __webpack_require__(/*! ./content-layout.component.html */ "./src/app/layouts/content/content-layout.component.html"),
            styles: [__webpack_require__(/*! ./content-layout.component.scss */ "./src/app/layouts/content/content-layout.component.scss")]
        })
    ], ContentLayoutComponent);
    return ContentLayoutComponent;
}());



/***/ }),

/***/ "./src/app/layouts/full/full-layout.component.html":
/*!*********************************************************!*\
  !*** ./src/app/layouts/full/full-layout.component.html ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div\r\n  #wrapper\r\n  class=\"wrapper\"\r\n  [ngClass]=\"{\r\n    'nav-collapsed': iscollapsed,\r\n    'menu-collapsed': iscollapsed,\r\n    'sidebar-sm': isSidebar_sm,\r\n    'sidebar-lg': isSidebar_lg\r\n  }\"\r\n  [dir]=\"options.direction\"\r\n>\r\n  <div\r\n    #appSidebar\r\n    appSidebar\r\n    class=\"app-sidebar\"\r\n    (toggleHideSidebar)=\"toggleHideSidebar($event)\"\r\n    [ngClass]=\"{ 'hide-sidebar': hideSidebar }\"\r\n    data-active-color=\"white\"\r\n    [attr.data-background-color]=\"bgColor\"\r\n    [attr.data-image]=\"bgImage\"\r\n  >\r\n    <app-sidebar></app-sidebar>\r\n    <div class=\"sidebar-background\" #sidebarBgImage></div>\r\n  </div>\r\n  <app-navbar (toggleHideSidebar)=\"toggleHideSidebar($event)\"></app-navbar>\r\n  <div class=\"main-panel\">\r\n    <div class=\"main-content\">\r\n      <div class=\"content-wrapper\">\r\n        <div class=\"container-fluid\">\r\n          <router-outlet></router-outlet>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <app-footer></app-footer>\r\n  </div>\r\n  <app-notification-sidebar></app-notification-sidebar>\r\n  <app-customizer (directionEvent)=\"getOptions($event)\"></app-customizer>\r\n</div>\r\n"

/***/ }),

/***/ "./src/app/layouts/full/full-layout.component.scss":
/*!*********************************************************!*\
  !*** ./src/app/layouts/full/full-layout.component.scss ***!
  \*********************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2xheW91dHMvZnVsbC9mdWxsLWxheW91dC5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/layouts/full/full-layout.component.ts":
/*!*******************************************************!*\
  !*** ./src/app/layouts/full/full-layout.component.ts ***!
  \*******************************************************/
/*! exports provided: FullLayoutComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FullLayoutComponent", function() { return FullLayoutComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var app_shared_services_config_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! app/shared/services/config.service */ "./src/app/shared/services/config.service.ts");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var app_shared_services_layout_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! app/shared/services/layout.service */ "./src/app/shared/services/layout.service.ts");





var fireRefreshEventOnWindow = function () {
    var evt = document.createEvent('HTMLEvents');
    evt.initEvent('resize', true, false);
    window.dispatchEvent(evt);
};
var FullLayoutComponent = /** @class */ (function () {
    function FullLayoutComponent(elementRef, layoutService, configService, document, renderer) {
        var _this = this;
        this.elementRef = elementRef;
        this.layoutService = layoutService;
        this.configService = configService;
        this.document = document;
        this.renderer = renderer;
        this.options = {
            direction: 'ltr',
            bgColor: 'black',
            bgImage: 'assets/img/sidebar-bg/01.jpg'
        };
        this.iscollapsed = false;
        this.isSidebar_sm = false;
        this.isSidebar_lg = false;
        this.bgColor = 'black';
        this.bgImage = 'assets/img/sidebar-bg/01.jpg';
        this.config = {};
        // event emitter call from customizer
        this.layoutSub = layoutService.customizerChangeEmitted$.subscribe(function (options) {
            if (options) {
                if (options.bgColor) {
                    _this.bgColor = options.bgColor;
                }
                if (options.bgImage) {
                    _this.bgImage = options.bgImage;
                    _this.renderer.setAttribute(_this.sidebarBgImage.nativeElement, 'style', 'background-image: url("' + _this.bgImage + '")');
                }
                if (options.bgImageDisplay === true) {
                    _this.bgImage = options.bgImage;
                    _this.renderer.setAttribute(_this.sidebarBgImage.nativeElement, 'style', 'display: block; background-image: url("' + _this.bgImage + '")');
                }
                else if (options.bgImageDisplay === false) {
                    _this.bgImage = '';
                    // this.renderer.setAttribute(this.sidebarBgImage.nativeElement, 'style', 'display: none');
                    _this.renderer.setAttribute(_this.sidebarBgImage.nativeElement, 'style', 'background-image: none');
                }
                if (options.compactMenu === true) {
                    _this.renderer.addClass(_this.wrapper.nativeElement, 'nav-collapsed');
                    _this.renderer.addClass(_this.wrapper.nativeElement, 'menu-collapsed');
                }
                else if (options.compactMenu === false) {
                    if (_this.wrapper.nativeElement.classList.contains('nav-collapsed')) {
                        _this.renderer.removeClass(_this.wrapper.nativeElement, 'nav-collapsed');
                        _this.renderer.removeClass(_this.wrapper.nativeElement, 'menu-collapsed');
                    }
                }
                if (options.sidebarSize === 'sidebar-lg') {
                    _this.isSidebar_sm = false;
                    _this.isSidebar_lg = true;
                }
                else if (options.sidebarSize === 'sidebar-sm') {
                    _this.isSidebar_sm = true;
                    _this.isSidebar_lg = false;
                }
                else {
                    _this.isSidebar_sm = false;
                    _this.isSidebar_lg = false;
                }
                if (options.layout === 'Light') {
                    _this.renderer.removeClass(_this.document.body, 'layout-dark');
                    _this.renderer.removeClass(_this.document.body, 'layout-transparent');
                    _this.renderer.removeClass(_this.document.body, 'bg-hibiscus');
                    _this.renderer.removeClass(_this.document.body, 'bg-purple-pizzazz');
                    _this.renderer.removeClass(_this.document.body, 'bg-blue-lagoon');
                    _this.renderer.removeClass(_this.document.body, 'bg-electric-violet');
                    _this.renderer.removeClass(_this.document.body, 'bg-portage');
                    _this.renderer.removeClass(_this.document.body, 'bg-tundora');
                    _this.renderer.removeClass(_this.document.body, 'bg-glass-1');
                    _this.renderer.removeClass(_this.document.body, 'bg-glass-2');
                    _this.renderer.removeClass(_this.document.body, 'bg-glass-3');
                    _this.renderer.removeClass(_this.document.body, 'bg-glass-4');
                }
                else if (options.layout === 'Dark') {
                    if (_this.document.body.classList.contains('layout-transparent')) {
                        _this.renderer.removeClass(_this.document.body, 'layout-transparent');
                        _this.renderer.removeClass(_this.document.body, 'bg-hibiscus');
                        _this.renderer.removeClass(_this.document.body, 'bg-purple-pizzazz');
                        _this.renderer.removeClass(_this.document.body, 'bg-blue-lagoon');
                        _this.renderer.removeClass(_this.document.body, 'bg-electric-violet');
                        _this.renderer.removeClass(_this.document.body, 'bg-portage');
                        _this.renderer.removeClass(_this.document.body, 'bg-tundora');
                        _this.renderer.removeClass(_this.document.body, 'bg-glass-1');
                        _this.renderer.removeClass(_this.document.body, 'bg-glass-2');
                        _this.renderer.removeClass(_this.document.body, 'bg-glass-3');
                        _this.renderer.removeClass(_this.document.body, 'bg-glass-4');
                        _this.renderer.addClass(_this.document.body, 'layout-dark');
                    }
                    else {
                        _this.renderer.addClass(_this.document.body, 'layout-dark');
                    }
                }
                else if (options.layout === 'Transparent') {
                    _this.renderer.addClass(_this.document.body, 'layout-transparent');
                    _this.renderer.addClass(_this.document.body, 'layout-dark');
                    _this.renderer.addClass(_this.document.body, 'bg-glass-1');
                }
                if (options.transparentColor) {
                    _this.renderer.removeClass(_this.document.body, 'bg-hibiscus');
                    _this.renderer.removeClass(_this.document.body, 'bg-purple-pizzazz');
                    _this.renderer.removeClass(_this.document.body, 'bg-blue-lagoon');
                    _this.renderer.removeClass(_this.document.body, 'bg-electric-violet');
                    _this.renderer.removeClass(_this.document.body, 'bg-portage');
                    _this.renderer.removeClass(_this.document.body, 'bg-tundora');
                    _this.renderer.removeClass(_this.document.body, 'bg-glass-1');
                    _this.renderer.removeClass(_this.document.body, 'bg-glass-2');
                    _this.renderer.removeClass(_this.document.body, 'bg-glass-3');
                    _this.renderer.removeClass(_this.document.body, 'bg-glass-4');
                    _this.renderer.addClass(_this.document.body, options.transparentColor);
                }
            }
        });
    }
    FullLayoutComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.config = this.configService.templateConf;
        this.bgColor = this.config.layout.sidebar.backgroundColor;
        if (!this.config.layout.sidebar.backgroundImage) {
            this.bgImage = '';
        }
        else {
            this.bgImage = this.config.layout.sidebar.backgroundImageURL;
        }
        if (this.config.layout.variant === 'Transparent') {
            if (this.config.layout.sidebar.backgroundColor.toString().trim() === '') {
                this.bgColor = 'bg-glass-1';
            }
        }
        else {
            if (this.config.layout.sidebar.backgroundColor.toString().trim() === '') {
                this.bgColor = 'black';
            }
        }
        setTimeout(function () {
            if (_this.config.layout.sidebar.size === 'sidebar-lg') {
                _this.isSidebar_sm = false;
                _this.isSidebar_lg = true;
            }
            else if (_this.config.layout.sidebar.size === 'sidebar-sm') {
                _this.isSidebar_sm = true;
                _this.isSidebar_lg = false;
            }
            else {
                _this.isSidebar_sm = false;
                _this.isSidebar_lg = false;
            }
            _this.iscollapsed = _this.config.layout.sidebar.collapsed;
        }, 0);
        // emit event to customizer
        this.options.bgColor = this.bgColor;
        this.options.bgImage = this.bgImage;
        this.layoutService.emitCustomizerChange(this.options);
        // customizer events
        this.elementRef.nativeElement
            .querySelector('#cz-compact-menu')
            .addEventListener('click', this.onClick.bind(this));
        this.elementRef.nativeElement
            .querySelector('#cz-sidebar-width')
            .addEventListener('click', this.onClick.bind(this));
    };
    FullLayoutComponent.prototype.ngAfterViewInit = function () {
        var _this = this;
        setTimeout(function () {
            if (_this.config.layout.dir) {
                _this.options.direction = _this.config.layout.dir;
            }
            if (_this.config.layout.variant === 'Dark') {
                _this.renderer.addClass(_this.document.body, 'layout-dark');
            }
            else if (_this.config.layout.variant === 'Transparent') {
                _this.renderer.addClass(_this.document.body, 'layout-dark');
                _this.renderer.addClass(_this.document.body, 'layout-transparent');
                if (_this.config.layout.sidebar.backgroundColor) {
                    _this.renderer.addClass(_this.document.body, _this.config.layout.sidebar.backgroundColor);
                }
                else {
                    _this.renderer.addClass(_this.document.body, 'bg-glass-1');
                }
                _this.bgColor = 'black';
                _this.options.bgColor = 'black';
                _this.bgImage = '';
                _this.options.bgImage = '';
                _this.bgImage = '';
                _this.renderer.setAttribute(_this.sidebarBgImage.nativeElement, 'style', 'background-image: none');
            }
        }, 0);
    };
    FullLayoutComponent.prototype.ngOnDestroy = function () {
        if (this.layoutSub) {
            this.layoutSub.unsubscribe();
        }
    };
    FullLayoutComponent.prototype.onClick = function (event) {
        // initialize window resizer event on sidebar toggle click event
        setTimeout(function () {
            fireRefreshEventOnWindow();
        }, 300);
    };
    FullLayoutComponent.prototype.toggleHideSidebar = function ($event) {
        var _this = this;
        setTimeout(function () {
            _this.hideSidebar = $event;
        }, 0);
    };
    FullLayoutComponent.prototype.getOptions = function ($event) {
        this.options = $event;
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('sidebarBgImage'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], FullLayoutComponent.prototype, "sidebarBgImage", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('appSidebar'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], FullLayoutComponent.prototype, "appSidebar", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('wrapper'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], FullLayoutComponent.prototype, "wrapper", void 0);
    FullLayoutComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-full-layout',
            template: __webpack_require__(/*! ./full-layout.component.html */ "./src/app/layouts/full/full-layout.component.html"),
            styles: [__webpack_require__(/*! ./full-layout.component.scss */ "./src/app/layouts/full/full-layout.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](3, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_angular_common__WEBPACK_IMPORTED_MODULE_3__["DOCUMENT"])),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"],
            app_shared_services_layout_service__WEBPACK_IMPORTED_MODULE_4__["LayoutService"],
            app_shared_services_config_service__WEBPACK_IMPORTED_MODULE_2__["ConfigService"],
            Document,
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["Renderer2"]])
    ], FullLayoutComponent);
    return FullLayoutComponent;
}());



/***/ }),

/***/ "./src/app/shared/animations/custom-animations.ts":
/*!********************************************************!*\
  !*** ./src/app/shared/animations/custom-animations.ts ***!
  \********************************************************/
/*! exports provided: customAnimations */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "customAnimations", function() { return customAnimations; });
/* harmony import */ var _angular_animations__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/animations */ "./node_modules/@angular/animations/fesm5/animations.js");

var customAnimations = [
    Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["trigger"])('slideInOut', [
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('1', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ height: '*' })),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["state"])('0', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["style"])({ height: '0px' })),
        Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["transition"])('1 <=> 0', Object(_angular_animations__WEBPACK_IMPORTED_MODULE_0__["animate"])(200))
    ])
];


/***/ }),

/***/ "./src/app/shared/auth/auth-guard.service.ts":
/*!***************************************************!*\
  !*** ./src/app/shared/auth/auth-guard.service.ts ***!
  \***************************************************/
/*! exports provided: AuthGuard */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthGuard", function() { return AuthGuard; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./auth.service */ "./src/app/shared/auth/auth.service.ts");




var AuthGuard = /** @class */ (function () {
    function AuthGuard(auth, router) {
        this.auth = auth;
        this.router = router;
    }
    AuthGuard.prototype.canActivate = function (route, state) {
        if (!this.auth.isAuthenticated) {
            this.router.navigate(['/pages/login']);
        }
        return this.auth.isAuthenticated;
    };
    AuthGuard = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_auth_service__WEBPACK_IMPORTED_MODULE_3__["AuthService"], _angular_router__WEBPACK_IMPORTED_MODULE_1__["Router"]])
    ], AuthGuard);
    return AuthGuard;
}());



/***/ }),

/***/ "./src/app/shared/auth/auth.service.ts":
/*!*********************************************!*\
  !*** ./src/app/shared/auth/auth.service.ts ***!
  \*********************************************/
/*! exports provided: AuthService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthService", function() { return AuthService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! environments/environment */ "./src/environments/environment.ts");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");





var AuthService = /** @class */ (function () {
    function AuthService(http, router) {
        this.http = http;
        this.router = router;
        this.BASE_URL = 'http://localhost:53956/api'; // 61646
        // BASE_URL = 'https://myprojectapplicationbackend.azurewebsites.net/api';
        this.TOKEN_KEY = 'token';
        this.FIRSTNAME_KEY = 'firstname';
        this.AVATAR_KEY = 'avatar';
        this.LASTNAME_KEY = 'lastname';
        this.COM_KEY = 'comp';
        this.COM_NAME = 'companyName';
        this.ROL_KEY = 'role';
        this.EMAIL_KEY = 'email';
        this.ROL_Group = 'roleGroup';
        this.REPORTINGDAY_KEY = 'reportingday';
        this.COMPLOGO_KEY = 'complogo';
        this.RESO_KEY = 'resource';
        this.ALLOWREC_KEY = 'allowRec';
        this.FREPPERIOD_KEY = 'financeRepPeriod';
        this.FREPYEAR_KEY = 'financeRepYear';
        this.CURRENCYLN_KEY = 'currencyLongName';
        this.CURRENCYSM_KEY = 'currencyShortName';
        this.CURRENCYSY_KEY = 'currencySymbol';
        this.FREEZEFORE_KEY = 'freezeForecast';
        this.STANDARDHRS_KEY = 'standardDailyHrs';
        this.WORKWEEKEND_KEY = 'doEmployeesWorkWeekends';
    }
    Object.defineProperty(AuthService.prototype, "firstname", {
        get: function () {
            return localStorage.getItem(this.FIRSTNAME_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "reportingday", {
        get: function () {
            return localStorage.getItem(this.REPORTINGDAY_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "complogo", {
        get: function () {
            return localStorage.getItem(this.COMPLOGO_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "lastname", {
        get: function () {
            return localStorage.getItem(this.LASTNAME_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "name", {
        get: function () {
            return this.firstname + ' ' + this.lastname;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "avatar", {
        get: function () {
            return localStorage.getItem(this.AVATAR_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "role", {
        get: function () {
            return localStorage.getItem(this.ROL_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "email", {
        get: function () {
            return localStorage.getItem(this.EMAIL_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "reportingPeriod", {
        get: function () {
            return localStorage.getItem(this.FREPPERIOD_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "reportingYear", {
        get: function () {
            return localStorage.getItem(this.FREPYEAR_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "resourceId", {
        get: function () {
            return localStorage.getItem(this.RESO_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "reportingCurrencySys", {
        get: function () {
            return localStorage.getItem(this.CURRENCYSY_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "CurrencyShortName", {
        get: function () {
            return localStorage.getItem(this.CURRENCYSM_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "companyId", {
        get: function () {
            return localStorage.getItem(this.COM_KEY);
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "companyName", {
        get: function () {
            return localStorage.getItem(this.COM_NAME);
        },
        enumerable: true,
        configurable: true
    });
    AuthService.prototype.isTokenAvailable = function () {
        return !!localStorage.getItem(this.TOKEN_KEY);
    };
    Object.defineProperty(AuthService.prototype, "isAuthenticated", {
        // getToken() {
        //   return this.token;
        // }
        get: function () {
            if (this.isTokenAvailable()) {
                return true;
            }
            // here you can check if user is authenticated or not through his token
            return false;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "tokenHeader", {
        // get tokenHeader() {
        //   const header = new Headers({'Authorization': 'Bearer ' + localStorage.getItem(this.TOKEN_KEY),
        //   'Content-Type': 'application/json'});
        //   return new RequestOptions({ headers: header});
        // }
        get: function () {
            var header = new _angular_http__WEBPACK_IMPORTED_MODULE_4__["Headers"]({ 'Authorization': 'Bearer ' + localStorage.getItem(this.TOKEN_KEY) });
            return new _angular_http__WEBPACK_IMPORTED_MODULE_4__["RequestOptions"]({ headers: header });
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(AuthService.prototype, "tokenHeaderWithType", {
        get: function () {
            // tslint:disable-next-line:prefer-const
            var options = new _angular_http__WEBPACK_IMPORTED_MODULE_4__["RequestOptions"]();
            options.headers = new _angular_http__WEBPACK_IMPORTED_MODULE_4__["Headers"]();
            options.headers.append('Authorization', 'Bearer ' + localStorage.getItem(this.TOKEN_KEY));
            options.headers.append('Content-Type', 'application/json; charset=utf-8');
            return options;
        },
        enumerable: true,
        configurable: true
    });
    AuthService.prototype.login = function (loginData) {
        var _this = this;
        this.http.post(this.BASE_URL + '/auth/login', loginData).subscribe(function (res) {
            console.log(res.json());
            _this.authenticate(res.json());
            _this.router.navigate(['/myprojects/myprojects']);
            // window.location.reload();
        });
    };
    AuthService.prototype.addResource = function (newresource) {
        delete newresource.confirmPassword;
        this.http.post(this.BASE_URL + '/addresource', newresource).subscribe();
    };
    AuthService.prototype.register = function (user) {
        var _this = this;
        delete user.confirmPassword;
        this.http.post(this.BASE_URL + '/auth/register', user).subscribe(function (res) {
            // tslint:disable-next-line:prefer-const
            var authResponse = res.json();
            // tslint:disable-next-line:curly
            if (!authResponse.token)
                return;
            localStorage.setItem(_this.FIRSTNAME_KEY, authResponse.firstname);
            localStorage.setItem(_this.REPORTINGDAY_KEY, authResponse.reportingday);
            localStorage.setItem(_this.COMPLOGO_KEY, authResponse.complogo);
            localStorage.setItem(_this.AVATAR_KEY, authResponse.avatar);
            localStorage.setItem(_this.LASTNAME_KEY, authResponse.lastname);
            localStorage.setItem(_this.TOKEN_KEY, authResponse.token);
            localStorage.setItem(_this.COM_KEY, authResponse.comp);
            localStorage.setItem(_this.ROL_KEY, authResponse.role);
            localStorage.setItem(_this.EMAIL_KEY, authResponse.email);
            localStorage.setItem(_this.RESO_KEY, authResponse.resource);
            localStorage.setItem(_this.ROL_Group, authResponse.roleGroup);
            localStorage.setItem(_this.ALLOWREC_KEY, authResponse.allowRec);
            localStorage.setItem(_this.FREPPERIOD_KEY, authResponse.financeRepPeriod);
            localStorage.setItem(_this.COM_NAME, authResponse.companyName);
            localStorage.setItem(_this.FREPYEAR_KEY, authResponse.financeRepYear);
            localStorage.setItem(_this.CURRENCYLN_KEY, authResponse.currencyLongName);
            localStorage.setItem(_this.CURRENCYSM_KEY, authResponse.currencyShortName);
            localStorage.setItem(_this.CURRENCYSY_KEY, authResponse.currencySymbol);
            localStorage.setItem(_this.FREEZEFORE_KEY, authResponse.freezeForecast);
            localStorage.setItem(_this.STANDARDHRS_KEY, authResponse.standardDailyHrs);
            localStorage.setItem(_this.WORKWEEKEND_KEY, authResponse.doEmployeesWorkWeekends);
            _this.router.navigate(['/myprojects/myprojects']);
        });
    };
    AuthService.prototype.logout = function () {
        this.clearlocalStorage();
        this.router.navigateByUrl('/pages/login');
    };
    AuthService.prototype.clearlocalStorage = function () {
        localStorage.removeItem(this.FIRSTNAME_KEY);
        localStorage.removeItem(this.REPORTINGDAY_KEY);
        localStorage.removeItem(this.COMPLOGO_KEY);
        localStorage.removeItem(this.AVATAR_KEY);
        localStorage.removeItem(this.LASTNAME_KEY);
        localStorage.removeItem(this.TOKEN_KEY);
        localStorage.removeItem(this.COM_KEY);
        localStorage.removeItem(this.ROL_KEY);
        localStorage.removeItem(this.EMAIL_KEY);
        localStorage.removeItem(this.RESO_KEY);
        localStorage.removeItem(this.ROL_Group);
        localStorage.removeItem(this.ALLOWREC_KEY);
        localStorage.removeItem(this.FREPPERIOD_KEY);
        localStorage.removeItem(this.COM_NAME);
        localStorage.removeItem(this.FREPYEAR_KEY);
        localStorage.removeItem(this.CURRENCYLN_KEY);
        localStorage.removeItem(this.CURRENCYSM_KEY);
        localStorage.removeItem(this.CURRENCYSY_KEY);
        localStorage.removeItem(this.FREEZEFORE_KEY);
        localStorage.removeItem(this.STANDARDHRS_KEY);
        localStorage.removeItem(this.WORKWEEKEND_KEY);
    };
    AuthService.prototype.authenticate = function (res) {
        var authResponseSerialised = res;
        // const authResponseSerialised = res.json().result;
        // tslint:disable-next-line:curly
        if (!authResponseSerialised.token)
            return;
        localStorage.setItem(this.FIRSTNAME_KEY, authResponseSerialised.firstname);
        localStorage.setItem(this.REPORTINGDAY_KEY, authResponseSerialised.reportingday);
        localStorage.setItem(this.COMPLOGO_KEY, authResponseSerialised.complogo);
        localStorage.setItem(this.AVATAR_KEY, authResponseSerialised.avatar);
        localStorage.setItem(this.LASTNAME_KEY, authResponseSerialised.lastname);
        localStorage.setItem(this.TOKEN_KEY, authResponseSerialised.token);
        localStorage.setItem(this.COM_KEY, authResponseSerialised.comp);
        localStorage.setItem(this.ROL_KEY, authResponseSerialised.role);
        localStorage.setItem(this.EMAIL_KEY, authResponseSerialised.email);
        localStorage.setItem(this.RESO_KEY, authResponseSerialised.resource);
        localStorage.setItem(this.ROL_Group, authResponseSerialised.roleGroup);
        localStorage.setItem(this.ALLOWREC_KEY, authResponseSerialised.allowRec);
        localStorage.setItem(this.FREPPERIOD_KEY, authResponseSerialised.financeRepPeriod);
        localStorage.setItem(this.COM_NAME, authResponseSerialised.companyName);
        localStorage.setItem(this.FREPYEAR_KEY, authResponseSerialised.financeRepYear);
        localStorage.setItem(this.CURRENCYLN_KEY, authResponseSerialised.currencyLongName);
        localStorage.setItem(this.CURRENCYSM_KEY, authResponseSerialised.currencyShortName);
        localStorage.setItem(this.CURRENCYSY_KEY, authResponseSerialised.currencySymbol);
        localStorage.setItem(this.FREEZEFORE_KEY, authResponseSerialised.freezeForecast);
        localStorage.setItem(this.STANDARDHRS_KEY, authResponseSerialised.standardDailyHrs);
        localStorage.setItem(this.WORKWEEKEND_KEY, authResponseSerialised.doEmployeesWorkWeekends);
    };
    AuthService.prototype.isAO = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].AccountOwner) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isSA = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].SeniorProjectManager) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isA = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].Admin) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isPM = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].ProjectManager) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isSPM = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].SeniorProjectManager) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isPA = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].PortfolioAdmin) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isFA = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].FinanceAdmin) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isFM = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].FinanceManager) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isRO = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].ReadOnly) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isPort = function () {
        var role = localStorage.getItem(this.ROL_KEY);
        if (role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].ProjectManager ||
            role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].SeniorProjectManager ||
            role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].PortfolioAdmin) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isTSO = function () {
        if (localStorage.getItem(this.ROL_KEY) === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].ReadWriteTimesheetOnly) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isSAdmin = function () {
        var role = localStorage.getItem(this.ROL_KEY);
        if (role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].AccountOwner ||
            role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].SuperAdmin) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isGeneralFinanceAdmin = function () {
        var role = localStorage.getItem(this.ROL_KEY);
        if (role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].AccountOwner ||
            role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].SuperAdmin ||
            role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].FinanceAdmin ||
            role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].FinanceManager) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService.prototype.isFin = function () {
        var role = localStorage.getItem(this.ROL_KEY);
        if (role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].FinanceAdmin ||
            role === environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].FinanceManager) {
            return true;
        }
        else {
            return false;
        }
    };
    AuthService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_http__WEBPACK_IMPORTED_MODULE_4__["Http"], _angular_router__WEBPACK_IMPORTED_MODULE_1__["Router"]])
    ], AuthService);
    return AuthService;
}());



/***/ }),

/***/ "./src/app/shared/customizer/customizer.component.html":
/*!*************************************************************!*\
  !*** ./src/app/shared/customizer/customizer.component.html ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!--Theme customizer Starts-->\r\n<div #customizer class=\"customizer border-left-blue-grey border-left-lighten-4 d-none d-sm-none d-md-block\" [ngClass]=\"{open: isOpen}\">\r\n  <a class=\"customizer-close\" (click)=\"closeCustomizer()\">\r\n    <i class=\"ft-x font-medium-3\"></i>\r\n  </a>\r\n  <a class=\"customizer-toggle bg-danger\" id=\"customizer-toggle-icon\" (click)=\"toggleCustomizer()\">\r\n    <i class=\"ft-settings font-medium-4 fa fa-spin white align-middle\"></i>\r\n  </a>\r\n  <div [perfectScrollbar] class=\"customizer-content p-3 ps-container ps-theme-dark text-left\" data-ps-id=\"df6a5ce4-a175-9172-4402-dabd98fc9c0a\">\r\n    <h4 class=\"text-uppercase mb-0 text-bold-400\">Theme Customizer</h4>\r\n    <p>Customize &amp; Preview in Real Time</p>\r\n    <hr>\r\n\r\n    <!-- Layout Options-->\r\n    <h6 class=\"text-center text-bold-500 mb-3 text-uppercase\">Layout Options</h6>\r\n    <div class=\"layout-switch ml-4\">\r\n      <div class=\"custom-control custom-radio d-inline-block custom-control-inline light-layout\">\r\n        <input class=\"custom-control-input\" id=\"ll-switch\" type=\"radio\" name=\"layout-switch\" [checked]=\"config.layout.variant === 'Light'\"  (click)=\"onLightLayout()\" />\r\n        <label class=\"custom-control-label\" for=\"ll-switch\">Light</label>\r\n      </div>\r\n      <div class=\"custom-control custom-radio d-inline-block custom-control-inline dark-layout\">\r\n        <input class=\"custom-control-input\" id=\"dl-switch\" type=\"radio\" name=\"layout-switch\" [checked]=\"config.layout.variant === 'Dark'\" (click)=\"onDarkLayout()\" />\r\n        <label class=\"custom-control-label\" for=\"dl-switch\">Dark</label>\r\n      </div>\r\n      <div class=\"custom-control custom-radio d-inline-block custom-control-inline transparent-layout\">\r\n        <input class=\"custom-control-input\" id=\"tl-switch\" type=\"radio\" name=\"layout-switch\" [checked]=\"config.layout.variant === 'Transparent'\" (click)=\"onTransparentLayout()\" />\r\n        <label class=\"custom-control-label\" for=\"tl-switch\">Transparent</label>\r\n      </div>\r\n    </div>\r\n    <hr />\r\n\r\n    <!-- Sidebar Options Starts-->\r\n    <h6 class=\"text-center text-bold-500 mb-3 text-uppercase sb-options\">Sidebar Color Options</h6>\r\n    <div class=\"cz-bg-color sb-color-options\">\r\n      <div class=\"row p-1\">\r\n        <div class=\"col\"><span class=\"gradient-pomegranate d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"pomegranate\" [ngClass]=\"{'selected': selectedBgColor === 'pomegranate'}\" (click)=\"changeSidebarBgColor('pomegranate')\"></span></div>\r\n        <div class=\"col\"><span class=\"gradient-king-yna d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"king-yna\" [ngClass]=\"{'selected': selectedBgColor === 'king-yna'}\" (click)=\"changeSidebarBgColor('king-yna')\"></span></div>\r\n        <div class=\"col\"><span class=\"gradient-ibiza-sunset d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"ibiza-sunset\" [ngClass]=\"{'selected': selectedBgColor === 'ibiza-sunset'}\" (click)=\"changeSidebarBgColor('ibiza-sunset')\"></span></div>\r\n        <div class=\"col\"><span class=\"gradient-flickr d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"flickr\" [ngClass]=\"{'selected': selectedBgColor === 'flickr'}\" (click)=\"changeSidebarBgColor('flickr')\"></span></div>\r\n        <div class=\"col\"><span class=\"gradient-purple-bliss d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"purple-bliss\" [ngClass]=\"{'selected': selectedBgColor === 'purple-bliss'}\" (click)=\"changeSidebarBgColor('purple-bliss')\"></span></div>\r\n        <div class=\"col\"><span class=\"gradient-man-of-steel d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"man-of-steel\" [ngClass]=\"{'selected': selectedBgColor === 'man-of-steel'}\" (click)=\"changeSidebarBgColor('man-of-steel')\"></span></div>\r\n        <div class=\"col\"><span class=\"gradient-purple-love d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"purple-love\" [ngClass]=\"{'selected': selectedBgColor === 'purple-love'}\" (click)=\"changeSidebarBgColor('purple-love')\"></span></div>\r\n      </div>\r\n      <div class=\"row p-1\">\r\n        <div class=\"col\"><span class=\"bg-black d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n          data-bg-color=\"black\" [ngClass]=\"{'selected': selectedBgColor === 'black'}\" (click)=\"changeSidebarBgColor('black')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-grey d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n          data-bg-color=\"white\" [ngClass]=\"{'selected': selectedBgColor === 'white'}\" (click)=\"changeSidebarBgColor('white')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-primary d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n          data-bg-color=\"primary\" [ngClass]=\"{'selected': selectedBgColor === 'primary'}\" (click)=\"changeSidebarBgColor('primary')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-success d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n          data-bg-color=\"success\" [ngClass]=\"{'selected': selectedBgColor === 'success'}\" (click)=\"changeSidebarBgColor('success')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-warning d-block rounded-circle\" style=\"width:20px; height:20px;\" data-bg-color=\"warning\" [ngClass]=\"{'selected': selectedBgColor === 'warning'}\" (click)=\"changeSidebarBgColor('warning')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-info d-block rounded-circle\" style=\"width:20px; height:20px;\" data-bg-color=\"info\" [ngClass]=\"{'selected': selectedBgColor === 'info'}\" (click)=\"changeSidebarBgColor('info')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-danger d-block rounded-circle\" style=\"width:20px; height:20px;\" data-bg-color=\"danger\" [ngClass]=\"{'selected': selectedBgColor === 'danger'}\" (click)=\"changeSidebarBgColor('danger')\"></span></div>\r\n      </div>\r\n    </div>\r\n    <!-- Sidebar Options Ends-->\r\n    <!-- Transparent Layout Bg color Options-->\r\n    <h6 class=\"text-center text-bold-500 mb-3 text-uppercase tl-color-options d-none\">Background Colors</h6>\r\n    <div class=\"cz-tl-bg-color d-none\">\r\n      <div class=\"row p-1\">\r\n        <div class=\"col\"><span class=\"bg-hibiscus d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"bg-hibiscus\" [ngClass]=\"{'selected': selectedTLBgColor === 'bg-hibiscus'}\" (click)=\"changeSidebarTLBgColor('bg-hibiscus')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-purple-pizzazz d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"bg-purple-pizzazz\" [ngClass]=\"{'selected': selectedTLBgColor === 'bg-purple-pizzazz'}\" (click)=\"changeSidebarTLBgColor('bg-purple-pizzazz')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-blue-lagoon d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"bg-blue-lagoon\" [ngClass]=\"{'selected': selectedTLBgColor === 'bg-blue-lagoon'}\" (click)=\"changeSidebarTLBgColor('bg-blue-lagoon')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-electric-violet d-block rounded-circle\" style=\"width:20px; height:20px;\"\r\n            data-bg-color=\"bg-electric-violet\" [ngClass]=\"{'selected': selectedTLBgColor === 'bg-electric-violet'}\" (click)=\"changeSidebarTLBgColor('bg-electric-violet')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-portage d-block rounded-circle\" style=\"width:20px; height:20px;\" data-bg-color=\"bg-portage\" [ngClass]=\"{'selected': selectedTLBgColor === 'bg-portage'}\" (click)=\"changeSidebarTLBgColor('bg-portage')\"></span></div>\r\n        <div class=\"col\"><span class=\"bg-tundora d-block rounded-circle\" style=\"width:20px; height:20px;\" data-bg-color=\"bg-tundora\" [ngClass]=\"{'selected': selectedTLBgColor === 'bg-tundora'}\" (click)=\"changeSidebarTLBgColor('bg-tundora')\"></span></div>\r\n      </div>\r\n    </div>\r\n    <!-- Transparent Layout Bg color Ends-->\r\n    <hr />\r\n    <!--Sidebar BG Image Starts-->\r\n    <h6 class=\"text-center text-bold-500 mb-3 text-uppercase sb-bg-img\">Sidebar Bg Image</h6>\r\n    <div class=\"cz-bg-image row sb-bg-img\">\r\n      <div class=\"col-sm-2 mb-3\"><img class=\"rounded\" src=\"assets/img/sidebar-bg/01.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedBgImage === 'assets/img/sidebar-bg/01.jpg'}\" (click)=\"changeSidebarBgImage('assets/img/sidebar-bg/01.jpg')\" /></div>\r\n      <div class=\"col-sm-2 mb-3\"><img class=\"rounded\" src=\"assets/img/sidebar-bg/02.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedBgImage === 'assets/img/sidebar-bg/02.jpg'}\" (click)=\"changeSidebarBgImage('assets/img/sidebar-bg/02.jpg')\" /></div>\r\n      <div class=\"col-sm-2 mb-3\"><img class=\"rounded\" src=\"assets/img/sidebar-bg/03.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedBgImage === 'assets/img/sidebar-bg/03.jpg'}\" (click)=\"changeSidebarBgImage('assets/img/sidebar-bg/03.jpg')\" /></div>\r\n      <div class=\"col-sm-2 mb-3\"><img class=\"rounded\" src=\"assets/img/sidebar-bg/04.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedBgImage === 'assets/img/sidebar-bg/04.jpg'}\" (click)=\"changeSidebarBgImage('assets/img/sidebar-bg/04.jpg')\" /></div>\r\n      <div class=\"col-sm-2 mb-3\"><img class=\"rounded\" src=\"assets/img/sidebar-bg/05.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedBgImage === 'assets/img/sidebar-bg/05.jpg'}\" (click)=\"changeSidebarBgImage('assets/img/sidebar-bg/05.jpg')\" /></div>\r\n      <div class=\"col-sm-2 mb-3\"><img class=\"rounded\" src=\"assets/img/sidebar-bg/06.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedBgImage === 'assets/img/sidebar-bg/06.jpg'}\" (click)=\"changeSidebarBgImage('assets/img/sidebar-bg/06.jpg')\" /></div>\r\n    </div>\r\n    <!-- Transparent BG Image Ends-->\r\n    <div class=\"tl-bg-img d-none\">\r\n      <h6 class=\"text-center text-bold-500 text-uppercase\">Background Images</h6>\r\n      <div class=\"cz-tl-bg-image row\">\r\n        <div class=\"col-sm-3\"><img class=\"rounded bg-glass-1\" src=\"assets/img/gallery/bg-glass-1.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedTLBgImage === 'assets/img/gallery/bg-glass-1.jpg'}\" (click)=\"changeSidebarTLBgImage('assets/img/gallery/bg-glass-1.jpg', 'bg-glass-1')\" /></div>\r\n        <div class=\"col-sm-3\"><img class=\"rounded bg-glass-2\" src=\"assets/img/gallery/bg-glass-2.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedTLBgImage === 'assets/img/gallery/bg-glass-2.jpg'}\" (click)=\"changeSidebarTLBgImage('assets/img/gallery/bg-glass-2.jpg', 'bg-glass-2')\" /></div>\r\n        <div class=\"col-sm-3\"><img class=\"rounded bg-glass-3\" src=\"assets/img/gallery/bg-glass-3.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedTLBgImage === 'assets/img/gallery/bg-glass-3.jpg'}\" (click)=\"changeSidebarTLBgImage('assets/img/gallery/bg-glass-3.jpg', 'bg-glass-3')\" /></div>\r\n        <div class=\"col-sm-3\"><img class=\"rounded bg-glass-4\" src=\"assets/img/gallery/bg-glass-4.jpg\" width=\"90\"  [ngClass]=\"{'selected': selectedTLBgImage === 'assets/img/gallery/bg-glass-4.jpg'}\" (click)=\"changeSidebarTLBgImage('assets/img/gallery/bg-glass-4.jpg', 'bg-glass-4')\" /></div>\r\n      </div>\r\n    </div>\r\n\r\n    <hr />\r\n    <!-- Transparent BG Image Ends-->\r\n    <!--Sidebar BG Image Ends-->\r\n\r\n    <!--Sidebar BG Image Toggle Starts-->\r\n    <div class=\"togglebutton toggle-sb-bg-img\">\r\n      <div class=\"switch switch border-0 d-flex justify-content-between w-100\">\r\n        <span>Sidebar Bg Image</span>\r\n        <div class=\"float-right\">\r\n          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n            <input type=\"checkbox\" class=\"custom-control-input cz-bg-image-display\" checked id=\"sidebar-bg-img\" (change)=\"bgImageDisplay($event)\">\r\n            <label class=\"custom-control-label d-block\" for=\"sidebar-bg-img\"></label>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <hr>\r\n    </div>\r\n    <!--Sidebar BG Image Toggle Ends-->\r\n\r\n    <!--Compact Menu Starts-->\r\n    <div class=\"togglebutton\">\r\n      <div class=\"switch switch border-0 d-flex justify-content-between w-100\">\r\n        <span>Compact Menu</span>\r\n        <div class=\"float-right\">\r\n          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n            <input type=\"checkbox\" [checked]=\"config.layout.sidebar.collapsed\" class=\"custom-control-input cz-compact-menu\" id=\"cz-compact-menu\" (change)=\"toggleCompactMenu($event)\">\r\n            <label class=\"custom-control-label d-block\" for=\"cz-compact-menu\"></label>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <!--Compact Menu Ends-->\r\n    <hr>\r\n\r\n    <!--RTL Starts-->\r\n    <div class=\"togglebutton\">\r\n      <div class=\"switch switch border-0 d-flex justify-content-between w-100\">\r\n        <span>RTL</span>\r\n        <div class=\"float-right\">\r\n          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n            <input type=\"checkbox\" [checked]=\"options.direction == 'rtl' ? 'checked' : false\" class=\"custom-control-input cz-rtl\"\r\n              id=\"cz-rtl\" (change)=\"options.direction = (options.direction == 'rtl' ? 'ltr' : 'rtl'); sendOptions()\">\r\n            <label class=\"custom-control-label d-block\" for=\"cz-rtl\"></label>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <!--RTL Ends-->\r\n    <hr>\r\n\r\n    <!--Sidebar Width Starts-->\r\n    <div>\r\n      <label for=\"cz-sidebar-width\">Sidebar Width</label>\r\n      <select id=\"cz-sidebar-width\" #width class=\"custom-select cz-sidebar-width float-right\" (change)=\"changeSidebarWidth(width.value)\">\r\n        <option value=\"sidebar-sm\" [selected] = \"size === 'sidebar-sm'\">Small</option>\r\n        <option value=\"sidebar-md\" [selected] = \"size === 'sidebar-md'\">Medium</option>\r\n        <option value=\"sidebar-lg\" [selected] = \"size === 'sidebar-lg'\">Large</option>\r\n      </select>\r\n    </div>\r\n    <!--Sidebar Width Ends-->\r\n  </div>\r\n</div>\r\n<!--Theme customizer Ends-->\r\n"

/***/ }),

/***/ "./src/app/shared/customizer/customizer.component.scss":
/*!*************************************************************!*\
  !*** ./src/app/shared/customizer/customizer.component.scss ***!
  \*************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ".customizer {\n  width: 400px;\n  right: -400px;\n  padding: 0;\n  background-color: #FFF;\n  z-index: 1051;\n  position: fixed;\n  top: 0;\n  bottom: 0;\n  height: 100vh;\n  transition: right 0.4s cubic-bezier(0.05, 0.74, 0.2, 0.99);\n  -webkit-backface-visibility: hidden;\n          backface-visibility: hidden;\n  border-left: 1px solid rgba(0, 0, 0, 0.05);\n  box-shadow: 0 0 8px rgba(0, 0, 0, 0.1); }\n  .customizer.open {\n    right: 0; }\n  .customizer .customizer-content {\n    position: relative;\n    height: 100%; }\n  .customizer a.customizer-toggle {\n    background: #FFF;\n    color: theme-color(\"primary\");\n    display: block;\n    box-shadow: -3px 0px 8px rgba(0, 0, 0, 0.1); }\n  .customizer a.customizer-close {\n    color: #000; }\n  .customizer .customizer-close {\n    position: absolute;\n    right: 10px;\n    top: 10px;\n    padding: 7px;\n    width: auto;\n    z-index: 10; }\n  .customizer #rtl-icon {\n    position: absolute;\n    right: -1px;\n    top: 35%;\n    width: 54px;\n    height: 50px;\n    text-align: center;\n    cursor: pointer;\n    line-height: 50px;\n    margin-top: 50px; }\n  .customizer .customizer-toggle {\n    position: absolute;\n    top: 35%;\n    width: 54px;\n    height: 50px;\n    left: -54px;\n    text-align: center;\n    line-height: 50px;\n    cursor: pointer; }\n  .customizer .color-options a {\n    white-space: pre; }\n  .customizer .cz-bg-color {\n    margin: 0 auto; }\n  .customizer .cz-bg-color span:hover {\n      cursor: pointer; }\n  .customizer .cz-bg-color span.white {\n      color: #ddd !important; }\n  .customizer .cz-bg-color .selected,\n  .customizer .cz-tl-bg-color .selected {\n    box-shadow: 0 0 10px 3px #009da0;\n    border: 3px solid #fff; }\n  .customizer .cz-bg-image:hover {\n    cursor: pointer; }\n  .customizer .cz-bg-image img.rounded {\n    border-radius: 1rem !important;\n    border: 2px solid #e6e6e6;\n    height: 100px;\n    width: 50px; }\n  .customizer .cz-bg-image img.rounded.selected {\n      border: 2px solid #FF586B; }\n  .customizer .tl-color-options {\n    display: none; }\n  .customizer .cz-tl-bg-image img.rounded {\n    border-radius: 1rem !important;\n    border: 2px solid #e6e6e6;\n    height: 100px;\n    width: 70px; }\n  .customizer .cz-tl-bg-image img.rounded.selected {\n      border: 2px solid #FF586B; }\n  .customizer .cz-tl-bg-image img.rounded:hover {\n      cursor: pointer; }\n  .customizer .bg-hibiscus {\n    background-image: linear-gradient(to right bottom, #f05f57, #c83d5c, #99245a, #671351, #360940);\n    background-size: cover;\n    background-size: 100% 100%;\n    background-attachment: fixed;\n    background-position: center;\n    background-repeat: no-repeat;\n    transition: background .3s; }\n  .customizer .bg-purple-pizzazz {\n    background-image: linear-gradient(to right bottom, #662d86, #8b2a8a, #ae2389, #cf1d83, #ed1e79);\n    background-size: cover;\n    background-size: 100% 100%;\n    background-attachment: fixed;\n    background-position: center;\n    background-repeat: no-repeat;\n    transition: background .3s; }\n  .customizer .bg-blue-lagoon {\n    background-image: linear-gradient(to right bottom, #144e68, #006d83, #008d92, #00ad91, #57ca85);\n    background-size: cover;\n    background-size: 100% 100%;\n    background-attachment: fixed;\n    background-position: center;\n    background-repeat: no-repeat;\n    transition: background .3s; }\n  .customizer .bg-electric-violet {\n    background-image: linear-gradient(to left top, #4a00e0, #600de0, #7119e1, #8023e1, #8e2de2);\n    background-size: cover;\n    background-size: 100% 100%;\n    background-attachment: fixed;\n    background-position: center;\n    background-repeat: no-repeat;\n    transition: background .3s; }\n  .customizer .bg-portage {\n    background-image: linear-gradient(to left top, #97abff, #798ce5, #5b6ecb, #3b51b1, #123597);\n    background-size: cover;\n    background-size: 100% 100%;\n    background-attachment: fixed;\n    background-position: center;\n    background-repeat: no-repeat;\n    transition: background .3s; }\n  .customizer .bg-tundora {\n    background-image: linear-gradient(to left top, #474747, #4a4a4a, #4c4d4d, #4f5050, #525352);\n    background-size: cover;\n    background-size: 100% 100%;\n    background-attachment: fixed;\n    background-position: center;\n    background-repeat: no-repeat;\n    transition: background .3s; }\n  .customizer .cz-bg-color .col span.rounded-circle:hover,\n  .customizer .cz-tl-bg-color .col span.rounded-circle:hover {\n    cursor: pointer; }\n  [dir=rtl] :host ::ng-deep .customizer {\n  left: -400px;\n  right: auto;\n  border-right: 1px solid rgba(0, 0, 0, 0.05);\n  border-left: 0px; }\n  [dir=rtl] :host ::ng-deep .customizer.open {\n    left: 0;\n    right: auto; }\n  [dir=rtl] :host ::ng-deep .customizer .customizer-close {\n    left: 10px;\n    right: auto; }\n  [dir=rtl] :host ::ng-deep .customizer .customizer-toggle {\n    right: -54px;\n    left: auto; }\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvc2hhcmVkL2N1c3RvbWl6ZXIvQzpcXFVzZXJzXFxOZGlhbmFuaWVcXEdpdFxcUHJvamVjdFVwZGF0ZXNcXFBUQW5ndWxhclxccHJvamVjdHVwZGF0ZXNmcm9udGVuZC9zcmNcXGFwcFxcc2hhcmVkXFxjdXN0b21pemVyXFxjdXN0b21pemVyLmNvbXBvbmVudC5zY3NzIiwic3JjL2FwcC9zaGFyZWQvY3VzdG9taXplci9jdXN0b21pemVyLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQVFBO0VBQ0UsWUFBWTtFQUNaLGFBQWE7RUFDYixVQUFVO0VBQ1Ysc0JBQXNCO0VBQ3RCLGFBQWE7RUFDYixlQUFlO0VBQ2YsTUFBTTtFQUNOLFNBQVM7RUFDVCxhQUFhO0VBQ2IsMERBQTBEO0VBQzFELG1DQUEyQjtVQUEzQiwyQkFBMkI7RUFDM0IsMENBQTBDO0VBQzFDLHNDQUFzQyxFQUFBO0VBYnhDO0lBZ0JJLFFBQVEsRUFBQTtFQWhCWjtJQW9CSSxrQkFBa0I7SUFDbEIsWUFBWSxFQUFBO0VBckJoQjtJQXlCSSxnQkFBZ0I7SUFDaEIsNkJBQTZCO0lBQzdCLGNBQWM7SUFDZCwyQ0FBMkMsRUFBQTtFQTVCL0M7SUFnQ0ksV0FBVyxFQUFBO0VBaENmO0lBb0NJLGtCQUFrQjtJQUNsQixXQUFXO0lBQ1gsU0FBUztJQUNULFlBQVk7SUFDWixXQUFXO0lBQ1gsV0FBVyxFQUFBO0VBekNmO0lBNkNJLGtCQUFrQjtJQUNsQixXQUFXO0lBQ1gsUUFBUTtJQUNSLFdBQVc7SUFDWCxZQUFZO0lBQ1osa0JBQWtCO0lBQ2xCLGVBQWU7SUFDZixpQkFBaUI7SUFDakIsZ0JBQWdCLEVBQUE7RUFyRHBCO0lBeURJLGtCQUFrQjtJQUNsQixRQUFRO0lBQ1IsV0FBVztJQUNYLFlBQVk7SUFDWixXQUFXO0lBQ1gsa0JBQWtCO0lBQ2xCLGlCQUFpQjtJQUNqQixlQUFlLEVBQUE7RUFoRW5CO0lBcUVNLGdCQUFnQixFQUFBO0VBckV0QjtJQTBFSSxjQUFjLEVBQUE7RUExRWxCO01BOEVRLGVBQWUsRUFBQTtFQTlFdkI7TUFrRlEsc0JBQXNCLEVBQUE7RUFsRjlCOztJQTBGTSxnQ0FBZ0M7SUFDaEMsc0JBQXNCLEVBQUE7RUEzRjVCO0lBaUdNLGVBQWUsRUFBQTtFQWpHckI7SUFxR00sOEJBQThCO0lBQzlCLHlCQUF5QjtJQUN6QixhQUFhO0lBQ2IsV0FBVyxFQUFBO0VBeEdqQjtNQTJHUSx5QkFBeUIsRUFBQTtFQTNHakM7SUFpSEksYUFBYSxFQUFBO0VBakhqQjtJQXNITSw4QkFBOEI7SUFDOUIseUJBQXlCO0lBQ3pCLGFBQWE7SUFDYixXQUFXLEVBQUE7RUF6SGpCO01BNEhRLHlCQUF5QixFQUFBO0VBNUhqQztNQWdJUSxlQUFlLEVBQUE7RUFoSXZCO0lBc0lJLCtGQTdJd0Y7SUE4SXhGLHNCQUFzQjtJQUN0QiwwQkFBMEI7SUFDMUIsNEJBQTRCO0lBQzVCLDJCQUEyQjtJQUMzQiw0QkFBNEI7SUFDNUIsMEJBQTBCLEVBQUE7RUE1STlCO0lBZ0pJLCtGQXRKOEY7SUF1SjlGLHNCQUFzQjtJQUN0QiwwQkFBMEI7SUFDMUIsNEJBQTRCO0lBQzVCLDJCQUEyQjtJQUMzQiw0QkFBNEI7SUFDNUIsMEJBQTBCLEVBQUE7RUF0SjlCO0lBMEpJLCtGQS9KMEY7SUFnSzFGLHNCQUFzQjtJQUN0QiwwQkFBMEI7SUFDMUIsNEJBQTRCO0lBQzVCLDJCQUEyQjtJQUMzQiw0QkFBNEI7SUFDNUIsMEJBQTBCLEVBQUE7RUFoSzlCO0lBb0tJLDJGQXhLeUY7SUF5S3pGLHNCQUFzQjtJQUN0QiwwQkFBMEI7SUFDMUIsNEJBQTRCO0lBQzVCLDJCQUEyQjtJQUMzQiw0QkFBNEI7SUFDNUIsMEJBQTBCLEVBQUE7RUExSzlCO0lBOEtJLDJGQWpMaUY7SUFrTGpGLHNCQUFzQjtJQUN0QiwwQkFBMEI7SUFDMUIsNEJBQTRCO0lBQzVCLDJCQUEyQjtJQUMzQiw0QkFBNEI7SUFDNUIsMEJBQTBCLEVBQUE7RUFwTDlCO0lBeUxJLDJGQTNMaUY7SUE0TGpGLHNCQUFzQjtJQUN0QiwwQkFBMEI7SUFDMUIsNEJBQTRCO0lBQzVCLDJCQUEyQjtJQUMzQiw0QkFBNEI7SUFDNUIsMEJBQTBCLEVBQUE7RUEvTDlCOztJQXVNVSxlQUFlLEVBQUE7RUN2RXpCO0VEa0ZJLFlBQVk7RUFDWixXQUFXO0VBQ1gsMkNBQTJDO0VBQzNDLGdCQUFnQixFQUFBO0VDaEZsQjtJRG1GSSxPQUFPO0lBQ1AsV0FBVyxFQUFBO0VDakZmO0lEcUZJLFVBQVU7SUFDVixXQUFXLEVBQUE7RUNuRmY7SUR3RkksWUFBWTtJQUNaLFVBQVUsRUFBQSIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9jdXN0b21pemVyL2N1c3RvbWl6ZXIuY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyIvLyBWYXJpYWJsZXMgRm9yIFRyYW5zcGFyZW50IExheW91dFxyXG4kYmctaGliaXNjdXMgOiBsaW5lYXItZ3JhZGllbnQodG8gcmlnaHQgYm90dG9tLCAjZjA1ZjU3LCAjYzgzZDVjLCAjOTkyNDVhLCAjNjcxMzUxLCAjMzYwOTQwKTtcclxuJGJnLXB1cnBsZS1waXp6YXp6IDogbGluZWFyLWdyYWRpZW50KHRvIHJpZ2h0IGJvdHRvbSwgIzY2MmQ4NiwgIzhiMmE4YSwgI2FlMjM4OSwgI2NmMWQ4MywgI2VkMWU3OSk7XHJcbiRiZy1ibHVlLWxhZ29vbjogbGluZWFyLWdyYWRpZW50KHRvIHJpZ2h0IGJvdHRvbSwgIzE0NGU2OCwgIzAwNmQ4MywgIzAwOGQ5MiwgIzAwYWQ5MSwgIzU3Y2E4NSk7XHJcbiRiZy1lbGVjdHJpYy12aW9sZXQ6bGluZWFyLWdyYWRpZW50KHRvIGxlZnQgdG9wLCAjNGEwMGUwLCAjNjAwZGUwLCAjNzExOWUxLCAjODAyM2UxLCAjOGUyZGUyKTtcclxuJGJnLXBvcnRhZ2U6bGluZWFyLWdyYWRpZW50KHRvIGxlZnQgdG9wLCAjOTdhYmZmLCAjNzk4Y2U1LCAjNWI2ZWNiLCAjM2I1MWIxLCAjMTIzNTk3KTtcclxuJGJnLXR1bmRvcmE6bGluZWFyLWdyYWRpZW50KHRvIGxlZnQgdG9wLCAjNDc0NzQ3LCAjNGE0YTRhLCAjNGM0ZDRkLCAjNGY1MDUwLCAjNTI1MzUyKTtcclxuXHJcbi5jdXN0b21pemVyIHtcclxuICB3aWR0aDogNDAwcHg7XHJcbiAgcmlnaHQ6IC00MDBweDtcclxuICBwYWRkaW5nOiAwO1xyXG4gIGJhY2tncm91bmQtY29sb3I6ICNGRkY7XHJcbiAgei1pbmRleDogMTA1MTtcclxuICBwb3NpdGlvbjogZml4ZWQ7XHJcbiAgdG9wOiAwO1xyXG4gIGJvdHRvbTogMDtcclxuICBoZWlnaHQ6IDEwMHZoO1xyXG4gIHRyYW5zaXRpb246IHJpZ2h0IDAuNHMgY3ViaWMtYmV6aWVyKDAuMDUsIDAuNzQsIDAuMiwgMC45OSk7XHJcbiAgYmFja2ZhY2UtdmlzaWJpbGl0eTogaGlkZGVuO1xyXG4gIGJvcmRlci1sZWZ0OiAxcHggc29saWQgcmdiYSgwLCAwLCAwLCAwLjA1KTtcclxuICBib3gtc2hhZG93OiAwIDAgOHB4IHJnYmEoMCwgMCwgMCwgMC4xKTtcclxuXHJcbiAgJi5vcGVuIHtcclxuICAgIHJpZ2h0OiAwO1xyXG4gIH1cclxuXHJcbiAgLmN1c3RvbWl6ZXItY29udGVudCB7XHJcbiAgICBwb3NpdGlvbjogcmVsYXRpdmU7XHJcbiAgICBoZWlnaHQ6IDEwMCU7XHJcbiAgfVxyXG5cclxuICBhLmN1c3RvbWl6ZXItdG9nZ2xlIHtcclxuICAgIGJhY2tncm91bmQ6ICNGRkY7XHJcbiAgICBjb2xvcjogdGhlbWUtY29sb3IoJ3ByaW1hcnknKTtcclxuICAgIGRpc3BsYXk6IGJsb2NrO1xyXG4gICAgYm94LXNoYWRvdzogLTNweCAwcHggOHB4IHJnYmEoMCwgMCwgMCwgMC4xKTtcclxuICB9XHJcblxyXG4gIGEuY3VzdG9taXplci1jbG9zZSB7XHJcbiAgICBjb2xvcjogIzAwMDtcclxuICB9XHJcblxyXG4gIC5jdXN0b21pemVyLWNsb3NlIHtcclxuICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcclxuICAgIHJpZ2h0OiAxMHB4O1xyXG4gICAgdG9wOiAxMHB4O1xyXG4gICAgcGFkZGluZzogN3B4O1xyXG4gICAgd2lkdGg6IGF1dG87XHJcbiAgICB6LWluZGV4OiAxMDtcclxuICB9XHJcblxyXG4gICNydGwtaWNvbiB7XHJcbiAgICBwb3NpdGlvbjogYWJzb2x1dGU7XHJcbiAgICByaWdodDogLTFweDtcclxuICAgIHRvcDogMzUlO1xyXG4gICAgd2lkdGg6IDU0cHg7XHJcbiAgICBoZWlnaHQ6IDUwcHg7XHJcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XHJcbiAgICBjdXJzb3I6IHBvaW50ZXI7XHJcbiAgICBsaW5lLWhlaWdodDogNTBweDtcclxuICAgIG1hcmdpbi10b3A6IDUwcHg7XHJcbiAgfVxyXG5cclxuICAuY3VzdG9taXplci10b2dnbGUge1xyXG4gICAgcG9zaXRpb246IGFic29sdXRlO1xyXG4gICAgdG9wOiAzNSU7XHJcbiAgICB3aWR0aDogNTRweDtcclxuICAgIGhlaWdodDogNTBweDtcclxuICAgIGxlZnQ6IC01NHB4O1xyXG4gICAgdGV4dC1hbGlnbjogY2VudGVyO1xyXG4gICAgbGluZS1oZWlnaHQ6IDUwcHg7XHJcbiAgICBjdXJzb3I6IHBvaW50ZXI7XHJcbiAgfVxyXG5cclxuICAuY29sb3Itb3B0aW9ucyB7XHJcbiAgICBhIHtcclxuICAgICAgd2hpdGUtc3BhY2U6IHByZTtcclxuICAgIH1cclxuICB9XHJcblxyXG4gIC5jei1iZy1jb2xvciB7XHJcbiAgICBtYXJnaW46IDAgYXV0bztcclxuXHJcbiAgICBzcGFuIHtcclxuICAgICAgJjpob3ZlciB7XHJcbiAgICAgICAgY3Vyc29yOiBwb2ludGVyO1xyXG4gICAgICB9XHJcblxyXG4gICAgICAmLndoaXRlIHtcclxuICAgICAgICBjb2xvcjogI2RkZCAhaW1wb3J0YW50O1xyXG4gICAgICB9XHJcbiAgICB9XHJcbiAgfVxyXG5cclxuICAuY3otYmctY29sb3IsXHJcbiAgLmN6LXRsLWJnLWNvbG9yIHtcclxuICAgIC5zZWxlY3RlZCB7XHJcbiAgICAgIGJveC1zaGFkb3c6IDAgMCAxMHB4IDNweCAjMDA5ZGEwO1xyXG4gICAgICBib3JkZXI6IDNweCBzb2xpZCAjZmZmO1xyXG4gICAgfVxyXG4gIH1cclxuXHJcbiAgLmN6LWJnLWltYWdlIHtcclxuICAgICY6aG92ZXIge1xyXG4gICAgICBjdXJzb3I6IHBvaW50ZXI7XHJcbiAgICB9XHJcblxyXG4gICAgaW1nLnJvdW5kZWQge1xyXG4gICAgICBib3JkZXItcmFkaXVzOiAxcmVtICFpbXBvcnRhbnQ7XHJcbiAgICAgIGJvcmRlcjogMnB4IHNvbGlkICNlNmU2ZTY7XHJcbiAgICAgIGhlaWdodDogMTAwcHg7XHJcbiAgICAgIHdpZHRoOiA1MHB4O1xyXG5cclxuICAgICAgJi5zZWxlY3RlZCB7XHJcbiAgICAgICAgYm9yZGVyOiAycHggc29saWQgI0ZGNTg2QjtcclxuICAgICAgfVxyXG4gICAgfVxyXG4gIH1cclxuXHJcbiAgLnRsLWNvbG9yLW9wdGlvbnMge1xyXG4gICAgZGlzcGxheTogbm9uZTtcclxuICB9XHJcblxyXG4gIC5jei10bC1iZy1pbWFnZSB7XHJcbiAgICBpbWcucm91bmRlZCB7XHJcbiAgICAgIGJvcmRlci1yYWRpdXM6IDFyZW0gIWltcG9ydGFudDtcclxuICAgICAgYm9yZGVyOiAycHggc29saWQgI2U2ZTZlNjtcclxuICAgICAgaGVpZ2h0OiAxMDBweDtcclxuICAgICAgd2lkdGg6IDcwcHg7XHJcblxyXG4gICAgICAmLnNlbGVjdGVkIHtcclxuICAgICAgICBib3JkZXI6IDJweCBzb2xpZCAjRkY1ODZCO1xyXG4gICAgICB9XHJcblxyXG4gICAgICAmOmhvdmVyIHtcclxuICAgICAgICBjdXJzb3I6IHBvaW50ZXI7XHJcbiAgICAgIH1cclxuICAgIH1cclxuICB9XHJcblxyXG4gIC5iZy1oaWJpc2N1cyB7XHJcbiAgICBiYWNrZ3JvdW5kLWltYWdlOiAkYmctaGliaXNjdXM7XHJcbiAgICBiYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xyXG4gICAgYmFja2dyb3VuZC1zaXplOiAxMDAlIDEwMCU7XHJcbiAgICBiYWNrZ3JvdW5kLWF0dGFjaG1lbnQ6IGZpeGVkO1xyXG4gICAgYmFja2dyb3VuZC1wb3NpdGlvbjogY2VudGVyO1xyXG4gICAgYmFja2dyb3VuZC1yZXBlYXQ6IG5vLXJlcGVhdDtcclxuICAgIHRyYW5zaXRpb246IGJhY2tncm91bmQgLjNzO1xyXG4gIH1cclxuXHJcbiAgLmJnLXB1cnBsZS1waXp6YXp6IHtcclxuICAgIGJhY2tncm91bmQtaW1hZ2U6ICRiZy1wdXJwbGUtcGl6emF6ejtcclxuICAgIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XHJcbiAgICBiYWNrZ3JvdW5kLXNpemU6IDEwMCUgMTAwJTtcclxuICAgIGJhY2tncm91bmQtYXR0YWNobWVudDogZml4ZWQ7XHJcbiAgICBiYWNrZ3JvdW5kLXBvc2l0aW9uOiBjZW50ZXI7XHJcbiAgICBiYWNrZ3JvdW5kLXJlcGVhdDogbm8tcmVwZWF0O1xyXG4gICAgdHJhbnNpdGlvbjogYmFja2dyb3VuZCAuM3M7XHJcbiAgfVxyXG5cclxuICAuYmctYmx1ZS1sYWdvb24ge1xyXG4gICAgYmFja2dyb3VuZC1pbWFnZTogJGJnLWJsdWUtbGFnb29uO1xyXG4gICAgYmFja2dyb3VuZC1zaXplOiBjb3ZlcjtcclxuICAgIGJhY2tncm91bmQtc2l6ZTogMTAwJSAxMDAlO1xyXG4gICAgYmFja2dyb3VuZC1hdHRhY2htZW50OiBmaXhlZDtcclxuICAgIGJhY2tncm91bmQtcG9zaXRpb246IGNlbnRlcjtcclxuICAgIGJhY2tncm91bmQtcmVwZWF0OiBuby1yZXBlYXQ7XHJcbiAgICB0cmFuc2l0aW9uOiBiYWNrZ3JvdW5kIC4zcztcclxuICB9XHJcblxyXG4gIC5iZy1lbGVjdHJpYy12aW9sZXQge1xyXG4gICAgYmFja2dyb3VuZC1pbWFnZTogJGJnLWVsZWN0cmljLXZpb2xldDtcclxuICAgIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XHJcbiAgICBiYWNrZ3JvdW5kLXNpemU6IDEwMCUgMTAwJTtcclxuICAgIGJhY2tncm91bmQtYXR0YWNobWVudDogZml4ZWQ7XHJcbiAgICBiYWNrZ3JvdW5kLXBvc2l0aW9uOiBjZW50ZXI7XHJcbiAgICBiYWNrZ3JvdW5kLXJlcGVhdDogbm8tcmVwZWF0O1xyXG4gICAgdHJhbnNpdGlvbjogYmFja2dyb3VuZCAuM3M7XHJcbiAgfVxyXG5cclxuICAuYmctcG9ydGFnZSB7XHJcbiAgICBiYWNrZ3JvdW5kLWltYWdlOiAkYmctcG9ydGFnZTtcclxuICAgIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XHJcbiAgICBiYWNrZ3JvdW5kLXNpemU6IDEwMCUgMTAwJTtcclxuICAgIGJhY2tncm91bmQtYXR0YWNobWVudDogZml4ZWQ7XHJcbiAgICBiYWNrZ3JvdW5kLXBvc2l0aW9uOiBjZW50ZXI7XHJcbiAgICBiYWNrZ3JvdW5kLXJlcGVhdDogbm8tcmVwZWF0O1xyXG4gICAgdHJhbnNpdGlvbjogYmFja2dyb3VuZCAuM3M7XHJcbiAgfVxyXG5cclxuXHJcbiAgLmJnLXR1bmRvcmEge1xyXG4gICAgYmFja2dyb3VuZC1pbWFnZTogJGJnLXR1bmRvcmE7XHJcbiAgICBiYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xyXG4gICAgYmFja2dyb3VuZC1zaXplOiAxMDAlIDEwMCU7XHJcbiAgICBiYWNrZ3JvdW5kLWF0dGFjaG1lbnQ6IGZpeGVkO1xyXG4gICAgYmFja2dyb3VuZC1wb3NpdGlvbjogY2VudGVyO1xyXG4gICAgYmFja2dyb3VuZC1yZXBlYXQ6IG5vLXJlcGVhdDtcclxuICAgIHRyYW5zaXRpb246IGJhY2tncm91bmQgLjNzO1xyXG4gIH1cclxuXHJcbiAgLmN6LWJnLWNvbG9yLFxyXG4gIC5jei10bC1iZy1jb2xvciB7XHJcbiAgICAuY29sIHtcclxuICAgICAgc3Bhbi5yb3VuZGVkLWNpcmNsZSB7XHJcbiAgICAgICAgJjpob3ZlciB7XHJcbiAgICAgICAgICBjdXJzb3I6IHBvaW50ZXI7XHJcbiAgICAgICAgfVxyXG4gICAgICB9XHJcbiAgICB9XHJcbiAgfVxyXG5cclxufVxyXG5cclxuXHJcbltkaXI9cnRsXSA6aG9zdCA6Om5nLWRlZXAge1xyXG4gIC5jdXN0b21pemVyIHtcclxuICAgIGxlZnQ6IC00MDBweDtcclxuICAgIHJpZ2h0OiBhdXRvO1xyXG4gICAgYm9yZGVyLXJpZ2h0OiAxcHggc29saWQgcmdiYSgwLCAwLCAwLCAwLjA1KTtcclxuICAgIGJvcmRlci1sZWZ0OiAwcHg7XHJcblxyXG4gICAgJi5vcGVuIHtcclxuICAgICAgbGVmdDogMDtcclxuICAgICAgcmlnaHQ6IGF1dG87XHJcbiAgICB9XHJcblxyXG4gICAgLmN1c3RvbWl6ZXItY2xvc2Uge1xyXG4gICAgICBsZWZ0OiAxMHB4O1xyXG4gICAgICByaWdodDogYXV0bztcclxuXHJcbiAgICB9XHJcblxyXG4gICAgLmN1c3RvbWl6ZXItdG9nZ2xlIHtcclxuICAgICAgcmlnaHQ6IC01NHB4O1xyXG4gICAgICBsZWZ0OiBhdXRvO1xyXG4gICAgfVxyXG5cclxuICB9XHJcbn1cclxuIiwiLmN1c3RvbWl6ZXIge1xuICB3aWR0aDogNDAwcHg7XG4gIHJpZ2h0OiAtNDAwcHg7XG4gIHBhZGRpbmc6IDA7XG4gIGJhY2tncm91bmQtY29sb3I6ICNGRkY7XG4gIHotaW5kZXg6IDEwNTE7XG4gIHBvc2l0aW9uOiBmaXhlZDtcbiAgdG9wOiAwO1xuICBib3R0b206IDA7XG4gIGhlaWdodDogMTAwdmg7XG4gIHRyYW5zaXRpb246IHJpZ2h0IDAuNHMgY3ViaWMtYmV6aWVyKDAuMDUsIDAuNzQsIDAuMiwgMC45OSk7XG4gIGJhY2tmYWNlLXZpc2liaWxpdHk6IGhpZGRlbjtcbiAgYm9yZGVyLWxlZnQ6IDFweCBzb2xpZCByZ2JhKDAsIDAsIDAsIDAuMDUpO1xuICBib3gtc2hhZG93OiAwIDAgOHB4IHJnYmEoMCwgMCwgMCwgMC4xKTsgfVxuICAuY3VzdG9taXplci5vcGVuIHtcbiAgICByaWdodDogMDsgfVxuICAuY3VzdG9taXplciAuY3VzdG9taXplci1jb250ZW50IHtcbiAgICBwb3NpdGlvbjogcmVsYXRpdmU7XG4gICAgaGVpZ2h0OiAxMDAlOyB9XG4gIC5jdXN0b21pemVyIGEuY3VzdG9taXplci10b2dnbGUge1xuICAgIGJhY2tncm91bmQ6ICNGRkY7XG4gICAgY29sb3I6IHRoZW1lLWNvbG9yKFwicHJpbWFyeVwiKTtcbiAgICBkaXNwbGF5OiBibG9jaztcbiAgICBib3gtc2hhZG93OiAtM3B4IDBweCA4cHggcmdiYSgwLCAwLCAwLCAwLjEpOyB9XG4gIC5jdXN0b21pemVyIGEuY3VzdG9taXplci1jbG9zZSB7XG4gICAgY29sb3I6ICMwMDA7IH1cbiAgLmN1c3RvbWl6ZXIgLmN1c3RvbWl6ZXItY2xvc2Uge1xuICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcbiAgICByaWdodDogMTBweDtcbiAgICB0b3A6IDEwcHg7XG4gICAgcGFkZGluZzogN3B4O1xuICAgIHdpZHRoOiBhdXRvO1xuICAgIHotaW5kZXg6IDEwOyB9XG4gIC5jdXN0b21pemVyICNydGwtaWNvbiB7XG4gICAgcG9zaXRpb246IGFic29sdXRlO1xuICAgIHJpZ2h0OiAtMXB4O1xuICAgIHRvcDogMzUlO1xuICAgIHdpZHRoOiA1NHB4O1xuICAgIGhlaWdodDogNTBweDtcbiAgICB0ZXh0LWFsaWduOiBjZW50ZXI7XG4gICAgY3Vyc29yOiBwb2ludGVyO1xuICAgIGxpbmUtaGVpZ2h0OiA1MHB4O1xuICAgIG1hcmdpbi10b3A6IDUwcHg7IH1cbiAgLmN1c3RvbWl6ZXIgLmN1c3RvbWl6ZXItdG9nZ2xlIHtcbiAgICBwb3NpdGlvbjogYWJzb2x1dGU7XG4gICAgdG9wOiAzNSU7XG4gICAgd2lkdGg6IDU0cHg7XG4gICAgaGVpZ2h0OiA1MHB4O1xuICAgIGxlZnQ6IC01NHB4O1xuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICBsaW5lLWhlaWdodDogNTBweDtcbiAgICBjdXJzb3I6IHBvaW50ZXI7IH1cbiAgLmN1c3RvbWl6ZXIgLmNvbG9yLW9wdGlvbnMgYSB7XG4gICAgd2hpdGUtc3BhY2U6IHByZTsgfVxuICAuY3VzdG9taXplciAuY3otYmctY29sb3Ige1xuICAgIG1hcmdpbjogMCBhdXRvOyB9XG4gICAgLmN1c3RvbWl6ZXIgLmN6LWJnLWNvbG9yIHNwYW46aG92ZXIge1xuICAgICAgY3Vyc29yOiBwb2ludGVyOyB9XG4gICAgLmN1c3RvbWl6ZXIgLmN6LWJnLWNvbG9yIHNwYW4ud2hpdGUge1xuICAgICAgY29sb3I6ICNkZGQgIWltcG9ydGFudDsgfVxuICAuY3VzdG9taXplciAuY3otYmctY29sb3IgLnNlbGVjdGVkLFxuICAuY3VzdG9taXplciAuY3otdGwtYmctY29sb3IgLnNlbGVjdGVkIHtcbiAgICBib3gtc2hhZG93OiAwIDAgMTBweCAzcHggIzAwOWRhMDtcbiAgICBib3JkZXI6IDNweCBzb2xpZCAjZmZmOyB9XG4gIC5jdXN0b21pemVyIC5jei1iZy1pbWFnZTpob3ZlciB7XG4gICAgY3Vyc29yOiBwb2ludGVyOyB9XG4gIC5jdXN0b21pemVyIC5jei1iZy1pbWFnZSBpbWcucm91bmRlZCB7XG4gICAgYm9yZGVyLXJhZGl1czogMXJlbSAhaW1wb3J0YW50O1xuICAgIGJvcmRlcjogMnB4IHNvbGlkICNlNmU2ZTY7XG4gICAgaGVpZ2h0OiAxMDBweDtcbiAgICB3aWR0aDogNTBweDsgfVxuICAgIC5jdXN0b21pemVyIC5jei1iZy1pbWFnZSBpbWcucm91bmRlZC5zZWxlY3RlZCB7XG4gICAgICBib3JkZXI6IDJweCBzb2xpZCAjRkY1ODZCOyB9XG4gIC5jdXN0b21pemVyIC50bC1jb2xvci1vcHRpb25zIHtcbiAgICBkaXNwbGF5OiBub25lOyB9XG4gIC5jdXN0b21pemVyIC5jei10bC1iZy1pbWFnZSBpbWcucm91bmRlZCB7XG4gICAgYm9yZGVyLXJhZGl1czogMXJlbSAhaW1wb3J0YW50O1xuICAgIGJvcmRlcjogMnB4IHNvbGlkICNlNmU2ZTY7XG4gICAgaGVpZ2h0OiAxMDBweDtcbiAgICB3aWR0aDogNzBweDsgfVxuICAgIC5jdXN0b21pemVyIC5jei10bC1iZy1pbWFnZSBpbWcucm91bmRlZC5zZWxlY3RlZCB7XG4gICAgICBib3JkZXI6IDJweCBzb2xpZCAjRkY1ODZCOyB9XG4gICAgLmN1c3RvbWl6ZXIgLmN6LXRsLWJnLWltYWdlIGltZy5yb3VuZGVkOmhvdmVyIHtcbiAgICAgIGN1cnNvcjogcG9pbnRlcjsgfVxuICAuY3VzdG9taXplciAuYmctaGliaXNjdXMge1xuICAgIGJhY2tncm91bmQtaW1hZ2U6IGxpbmVhci1ncmFkaWVudCh0byByaWdodCBib3R0b20sICNmMDVmNTcsICNjODNkNWMsICM5OTI0NWEsICM2NzEzNTEsICMzNjA5NDApO1xuICAgIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XG4gICAgYmFja2dyb3VuZC1zaXplOiAxMDAlIDEwMCU7XG4gICAgYmFja2dyb3VuZC1hdHRhY2htZW50OiBmaXhlZDtcbiAgICBiYWNrZ3JvdW5kLXBvc2l0aW9uOiBjZW50ZXI7XG4gICAgYmFja2dyb3VuZC1yZXBlYXQ6IG5vLXJlcGVhdDtcbiAgICB0cmFuc2l0aW9uOiBiYWNrZ3JvdW5kIC4zczsgfVxuICAuY3VzdG9taXplciAuYmctcHVycGxlLXBpenphenoge1xuICAgIGJhY2tncm91bmQtaW1hZ2U6IGxpbmVhci1ncmFkaWVudCh0byByaWdodCBib3R0b20sICM2NjJkODYsICM4YjJhOGEsICNhZTIzODksICNjZjFkODMsICNlZDFlNzkpO1xuICAgIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XG4gICAgYmFja2dyb3VuZC1zaXplOiAxMDAlIDEwMCU7XG4gICAgYmFja2dyb3VuZC1hdHRhY2htZW50OiBmaXhlZDtcbiAgICBiYWNrZ3JvdW5kLXBvc2l0aW9uOiBjZW50ZXI7XG4gICAgYmFja2dyb3VuZC1yZXBlYXQ6IG5vLXJlcGVhdDtcbiAgICB0cmFuc2l0aW9uOiBiYWNrZ3JvdW5kIC4zczsgfVxuICAuY3VzdG9taXplciAuYmctYmx1ZS1sYWdvb24ge1xuICAgIGJhY2tncm91bmQtaW1hZ2U6IGxpbmVhci1ncmFkaWVudCh0byByaWdodCBib3R0b20sICMxNDRlNjgsICMwMDZkODMsICMwMDhkOTIsICMwMGFkOTEsICM1N2NhODUpO1xuICAgIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XG4gICAgYmFja2dyb3VuZC1zaXplOiAxMDAlIDEwMCU7XG4gICAgYmFja2dyb3VuZC1hdHRhY2htZW50OiBmaXhlZDtcbiAgICBiYWNrZ3JvdW5kLXBvc2l0aW9uOiBjZW50ZXI7XG4gICAgYmFja2dyb3VuZC1yZXBlYXQ6IG5vLXJlcGVhdDtcbiAgICB0cmFuc2l0aW9uOiBiYWNrZ3JvdW5kIC4zczsgfVxuICAuY3VzdG9taXplciAuYmctZWxlY3RyaWMtdmlvbGV0IHtcbiAgICBiYWNrZ3JvdW5kLWltYWdlOiBsaW5lYXItZ3JhZGllbnQodG8gbGVmdCB0b3AsICM0YTAwZTAsICM2MDBkZTAsICM3MTE5ZTEsICM4MDIzZTEsICM4ZTJkZTIpO1xuICAgIGJhY2tncm91bmQtc2l6ZTogY292ZXI7XG4gICAgYmFja2dyb3VuZC1zaXplOiAxMDAlIDEwMCU7XG4gICAgYmFja2dyb3VuZC1hdHRhY2htZW50OiBmaXhlZDtcbiAgICBiYWNrZ3JvdW5kLXBvc2l0aW9uOiBjZW50ZXI7XG4gICAgYmFja2dyb3VuZC1yZXBlYXQ6IG5vLXJlcGVhdDtcbiAgICB0cmFuc2l0aW9uOiBiYWNrZ3JvdW5kIC4zczsgfVxuICAuY3VzdG9taXplciAuYmctcG9ydGFnZSB7XG4gICAgYmFja2dyb3VuZC1pbWFnZTogbGluZWFyLWdyYWRpZW50KHRvIGxlZnQgdG9wLCAjOTdhYmZmLCAjNzk4Y2U1LCAjNWI2ZWNiLCAjM2I1MWIxLCAjMTIzNTk3KTtcbiAgICBiYWNrZ3JvdW5kLXNpemU6IGNvdmVyO1xuICAgIGJhY2tncm91bmQtc2l6ZTogMTAwJSAxMDAlO1xuICAgIGJhY2tncm91bmQtYXR0YWNobWVudDogZml4ZWQ7XG4gICAgYmFja2dyb3VuZC1wb3NpdGlvbjogY2VudGVyO1xuICAgIGJhY2tncm91bmQtcmVwZWF0OiBuby1yZXBlYXQ7XG4gICAgdHJhbnNpdGlvbjogYmFja2dyb3VuZCAuM3M7IH1cbiAgLmN1c3RvbWl6ZXIgLmJnLXR1bmRvcmEge1xuICAgIGJhY2tncm91bmQtaW1hZ2U6IGxpbmVhci1ncmFkaWVudCh0byBsZWZ0IHRvcCwgIzQ3NDc0NywgIzRhNGE0YSwgIzRjNGQ0ZCwgIzRmNTA1MCwgIzUyNTM1Mik7XG4gICAgYmFja2dyb3VuZC1zaXplOiBjb3ZlcjtcbiAgICBiYWNrZ3JvdW5kLXNpemU6IDEwMCUgMTAwJTtcbiAgICBiYWNrZ3JvdW5kLWF0dGFjaG1lbnQ6IGZpeGVkO1xuICAgIGJhY2tncm91bmQtcG9zaXRpb246IGNlbnRlcjtcbiAgICBiYWNrZ3JvdW5kLXJlcGVhdDogbm8tcmVwZWF0O1xuICAgIHRyYW5zaXRpb246IGJhY2tncm91bmQgLjNzOyB9XG4gIC5jdXN0b21pemVyIC5jei1iZy1jb2xvciAuY29sIHNwYW4ucm91bmRlZC1jaXJjbGU6aG92ZXIsXG4gIC5jdXN0b21pemVyIC5jei10bC1iZy1jb2xvciAuY29sIHNwYW4ucm91bmRlZC1jaXJjbGU6aG92ZXIge1xuICAgIGN1cnNvcjogcG9pbnRlcjsgfVxuXG5bZGlyPXJ0bF0gOmhvc3QgOjpuZy1kZWVwIC5jdXN0b21pemVyIHtcbiAgbGVmdDogLTQwMHB4O1xuICByaWdodDogYXV0bztcbiAgYm9yZGVyLXJpZ2h0OiAxcHggc29saWQgcmdiYSgwLCAwLCAwLCAwLjA1KTtcbiAgYm9yZGVyLWxlZnQ6IDBweDsgfVxuICBbZGlyPXJ0bF0gOmhvc3QgOjpuZy1kZWVwIC5jdXN0b21pemVyLm9wZW4ge1xuICAgIGxlZnQ6IDA7XG4gICAgcmlnaHQ6IGF1dG87IH1cbiAgW2Rpcj1ydGxdIDpob3N0IDo6bmctZGVlcCAuY3VzdG9taXplciAuY3VzdG9taXplci1jbG9zZSB7XG4gICAgbGVmdDogMTBweDtcbiAgICByaWdodDogYXV0bzsgfVxuICBbZGlyPXJ0bF0gOmhvc3QgOjpuZy1kZWVwIC5jdXN0b21pemVyIC5jdXN0b21pemVyLXRvZ2dsZSB7XG4gICAgcmlnaHQ6IC01NHB4O1xuICAgIGxlZnQ6IGF1dG87IH1cbiJdfQ== */"

/***/ }),

/***/ "./src/app/shared/customizer/customizer.component.ts":
/*!***********************************************************!*\
  !*** ./src/app/shared/customizer/customizer.component.ts ***!
  \***********************************************************/
/*! exports provided: CustomizerComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CustomizerComponent", function() { return CustomizerComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _services_layout_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../services/layout.service */ "./src/app/shared/services/layout.service.ts");
/* harmony import */ var _services_config_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../services/config.service */ "./src/app/shared/services/config.service.ts");




var CustomizerComponent = /** @class */ (function () {
    function CustomizerComponent(elRef, renderer, layoutService, configService) {
        var _this = this;
        this.elRef = elRef;
        this.renderer = renderer;
        this.layoutService = layoutService;
        this.configService = configService;
        this.options = {
            direction: "ltr",
            bgColor: "black",
            transparentColor: "",
            bgImage: "assets/img/sidebar-bg/01.jpg",
            bgImageDisplay: true,
            compactMenu: false,
            sidebarSize: "sidebar-md",
            layout: "Light"
        };
        this.size = "sidebar-md";
        this.isOpen = true;
        this.config = {};
        this.isBgImageDisplay = true;
        this.selectedBgColor = "black";
        this.selectedBgImage = "assets/img/sidebar-bg/01.jpg";
        this.selectedTLBgColor = "";
        this.selectedTLBgImage = "";
        this.directionEvent = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.layoutSub = layoutService.customizerChangeEmitted$.subscribe(function (options) {
            if (options) {
                if (options.bgColor) {
                    _this.selectedBgColor = options.bgColor;
                    _this.selectedBgImage = options.bgImage;
                }
            }
        });
    }
    CustomizerComponent.prototype.ngOnInit = function () {
        this.config = this.configService.templateConf;
        this.isOpen = !this.config.layout.customizer.hidden;
        if (this.config.layout.sidebar.size) {
            this.options.sidebarSize = this.config.layout.sidebar.size;
            this.size = this.config.layout.sidebar.size;
        }
    };
    CustomizerComponent.prototype.ngAfterViewInit = function () {
        var _this = this;
        setTimeout(function () {
            if (_this.config.layout.dir) {
                _this.options.direction = _this.config.layout.dir;
            }
            if (_this.config.layout.variant) {
                _this.options.layout = _this.config.layout.variant;
            }
            if (_this.config.layout.sidebar.collapsed != undefined) {
                _this.options.compactMenu = _this.config.layout.sidebar.collapsed;
            }
            if (_this.config.layout.sidebar.backgroundColor &&
                _this.config.layout.sidebar.backgroundColor != "") {
                console.log(1);
                _this.options.bgColor = _this.config.layout.sidebar.backgroundColor;
                _this.selectedBgColor = _this.config.layout.sidebar.backgroundColor;
            }
            else {
                console.log(2);
                _this.options.bgColor = "black";
                _this.selectedBgColor = "black";
            }
            if (_this.config.layout.sidebar.backgroundImage != undefined) {
                _this.options.bgImageDisplay = _this.config.layout.sidebar.backgroundImage;
                _this.isBgImageDisplay = _this.config.layout.sidebar.backgroundImage;
            }
            if (_this.config.layout.sidebar.backgroundImageURL) {
                _this.options.bgImage = _this.config.layout.sidebar.backgroundImageURL;
                _this.selectedBgImage = _this.config.layout.sidebar.backgroundImageURL;
            }
            if (_this.options.layout === "Transparent") {
                _this.options.bgColor = "black";
                _this.selectedBgColor = "black";
                _this.options.bgImageDisplay = false;
                _this.selectedTLBgColor = "";
                _this.selectedBgImage = "";
                _this.options.bgImage = "";
                _this.isBgImageDisplay = false;
                if (_this.config.layout.sidebar.backgroundColor) {
                    if (_this.config.layout.sidebar.backgroundColor === "bg-glass-1") {
                        _this.selectedTLBgImage = "assets/img/gallery/bg-glass-1.jpg";
                        _this.options.transparentColor = "bg-glass-1";
                    }
                    else if (_this.config.layout.sidebar.backgroundColor === "bg-glass-2") {
                        _this.selectedTLBgImage = "assets/img/gallery/bg-glass-2.jpg";
                        _this.options.transparentColor = "bg-glass-2";
                    }
                    else if (_this.config.layout.sidebar.backgroundColor === "bg-glass-3") {
                        _this.selectedTLBgImage = "assets/img/gallery/bg-glass-3.jpg";
                        _this.options.transparentColor = "bg-glass-3";
                    }
                    else if (_this.config.layout.sidebar.backgroundColor === "bg-glass-4") {
                        _this.selectedTLBgImage = "assets/img/gallery/bg-glass-4.jpg";
                        _this.options.transparentColor = "bg-glass-4";
                    }
                    else {
                        _this.options.transparentColor = _this.config.layout.sidebar.backgroundColor;
                        _this.selectedTLBgColor = _this.config.layout.sidebar.backgroundColor;
                    }
                }
                else {
                    _this.options.bgColor = "black";
                    _this.selectedBgColor = "black";
                    _this.options.bgImageDisplay = false;
                    _this.selectedBgColor = "";
                    _this.selectedTLBgColor = "";
                    _this.selectedTLBgImage = "assets/img/gallery/bg-glass-1.jpg";
                    _this.options.transparentColor = "bg-glass-1";
                }
            }
        }, 0);
    };
    CustomizerComponent.prototype.ngOnDestroy = function () {
        if (this.layoutSub) {
            this.layoutSub.unsubscribe();
        }
    };
    CustomizerComponent.prototype.sendOptions = function () {
        this.directionEvent.emit(this.options);
        this.layoutService.emitChange(this.options);
    };
    CustomizerComponent.prototype.bgImageDisplay = function (e) {
        if (e.target.checked) {
            this.options.bgImageDisplay = true;
            this.isBgImageDisplay = true;
        }
        else {
            this.options.bgImageDisplay = false;
            this.isBgImageDisplay = false;
        }
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.toggleCompactMenu = function (e) {
        if (e.target.checked) {
            this.options.compactMenu = true;
        }
        else {
            this.options.compactMenu = false;
        }
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.changeSidebarWidth = function (value) {
        this.options.sidebarSize = value;
        this.size = value;
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.onLightLayout = function () {
        this.options.layout = "Light";
        this.options.bgColor = "man-of-steel";
        this.selectedBgColor = "man-of-steel";
        if (this.isBgImageDisplay) {
            this.options.bgImageDisplay = true;
        }
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.onDarkLayout = function () {
        this.options.layout = "Dark";
        this.options.bgColor = "black";
        this.selectedBgColor = "black";
        if (this.isBgImageDisplay) {
            this.options.bgImageDisplay = true;
        }
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.onTransparentLayout = function () {
        this.options.layout = "Transparent";
        this.options.bgColor = "black";
        this.selectedBgColor = "black";
        this.options.bgImageDisplay = false;
        this.selectedBgColor = "";
        this.selectedTLBgColor = "";
        this.selectedTLBgImage = "assets/img/gallery/bg-glass-1.jpg";
        this.options.transparentColor = "bg-glass-1";
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.toggleCustomizer = function () {
        if (this.isOpen) {
            this.renderer.removeClass(this.customizer.nativeElement, "open");
            this.isOpen = false;
        }
        else {
            this.renderer.addClass(this.customizer.nativeElement, "open");
            this.isOpen = true;
        }
    };
    CustomizerComponent.prototype.closeCustomizer = function () {
        this.renderer.removeClass(this.customizer.nativeElement, "open");
        this.isOpen = false;
    };
    CustomizerComponent.prototype.changeSidebarBgColor = function (color) {
        this.selectedBgColor = color;
        this.selectedTLBgColor = "";
        this.options.bgColor = color;
        if (this.isBgImageDisplay) {
            this.options.bgImageDisplay = true;
        }
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.changeSidebarBgImage = function (url) {
        this.selectedBgImage = url;
        this.selectedTLBgImage = "";
        //emit event to FUll Layout
        this.options.bgImage = url;
        if (this.isBgImageDisplay) {
            this.options.bgImageDisplay = true;
        }
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.changeSidebarTLBgColor = function (color) {
        this.selectedBgColor = "";
        this.selectedTLBgColor = color;
        this.selectedTLBgImage = "";
        this.options.transparentColor = color;
        this.options.bgImageDisplay = false;
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    CustomizerComponent.prototype.changeSidebarTLBgImage = function (url, color) {
        this.selectedTLBgColor = "";
        this.selectedTLBgImage = url;
        this.options.transparentColor = color;
        this.options.bgImageDisplay = false;
        //emit event to FUll Layout
        this.layoutService.emitCustomizerChange(this.options);
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])("customizer"),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], CustomizerComponent.prototype, "customizer", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], CustomizerComponent.prototype, "directionEvent", void 0);
    CustomizerComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "app-customizer",
            template: __webpack_require__(/*! ./customizer.component.html */ "./src/app/shared/customizer/customizer.component.html"),
            styles: [__webpack_require__(/*! ./customizer.component.scss */ "./src/app/shared/customizer/customizer.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["Renderer2"],
            _services_layout_service__WEBPACK_IMPORTED_MODULE_2__["LayoutService"],
            _services_config_service__WEBPACK_IMPORTED_MODULE_3__["ConfigService"]])
    ], CustomizerComponent);
    return CustomizerComponent;
}());



/***/ }),

/***/ "./src/app/shared/directives/sidebar.directive.ts":
/*!********************************************************!*\
  !*** ./src/app/shared/directives/sidebar.directive.ts ***!
  \********************************************************/
/*! exports provided: SidebarDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SidebarDirective", function() { return SidebarDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");



var SidebarDirective = /** @class */ (function () {
    function SidebarDirective(el, renderer, router, cd) {
        this.el = el;
        this.renderer = renderer;
        this.router = router;
        this.cd = cd;
        this.navlinks = [];
        this.activeLinks = [];
        this.toggleHideSidebar = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
    }
    SidebarDirective.prototype.ngOnInit = function () {
        this.activeRoute = this.router.url;
        this.innerWidth = window.innerWidth;
    };
    SidebarDirective.prototype.ngAfterViewInit = function () {
        var element = this.el.nativeElement;
        this.$wrapper = this.renderer.parentNode(this.el.nativeElement); // document.getElementsByClassName("wrapper")[0];
        var $sidebar_img_container = this.el.nativeElement.querySelector('.sidebar-background');
        var $sidebar_img = element.getAttribute("data-image");
        if ($sidebar_img_container.length !== 0 && $sidebar_img !== undefined) {
            this.renderer.setAttribute($sidebar_img_container, 'style', 'background-image: url("' + $sidebar_img + '")');
        }
        if (!this.$wrapper.classList.contains("nav-collapsed")) {
            this.expandActive();
        }
        if (this.innerWidth < 992) {
            this.renderer.removeClass(this.$wrapper, 'nav-collapsed');
            this.renderer.removeClass(this.$wrapper, 'menu-collapsed');
            this.toggleHideSidebar.emit(true);
        }
        this.cd.detectChanges();
    };
    SidebarDirective.prototype.onMouseOver = function (e) {
        if (this.$wrapper.classList.contains("nav-collapsed")) {
            this.renderer.removeClass(this.$wrapper, 'menu-collapsed');
            this.navlinks
                .filter(function (_) { return _.navCollapsedOpen === true; })
                .forEach(function (link) {
                link.open = true;
                link.navCollapsedOpen = false;
            });
        }
    };
    SidebarDirective.prototype.onMouseOut = function (e) {
        if (this.$wrapper.classList.contains("nav-collapsed")) {
            this.renderer.addClass(this.$wrapper, 'menu-collapsed');
            this.navlinks
                .filter(function (_) { return _.open === true; })
                .forEach(function (link) {
                link.open = false;
                link.navCollapsedOpen = true;
            });
        }
    };
    SidebarDirective.prototype.onClick = function (e) {
        if (e.target.parentElement.classList.contains("logo-text") ||
            e.target.parentElement.classList.contains("logo-img")) {
            this.activeLinks = [];
            this.activeRoute = this.router.url;
            this.expandActive();
            this.hideSidebar();
        }
        else if (e.target.parentElement.classList.contains("nav-close") ||
            e.target.classList.contains("nav-close")) {
            this.toggleHideSidebar.emit(true);
        }
    };
    SidebarDirective.prototype.onResize = function (event) {
        this.innerWidth = window.innerWidth;
        if (event.target.innerWidth < 992) {
            this.renderer.removeClass(this.$wrapper, 'nav-collapsed');
            this.renderer.removeClass(this.$wrapper, 'menu-collapsed');
            this.toggleHideSidebar.emit(true);
        }
        if (event.target.innerWidth > 992) {
            var toggleStatus = this.el.nativeElement;
            this.el.nativeElement.querySelector('.toggle-icon')
                .getAttribute("data-toggle");
            if (toggleStatus === "collapsed" &&
                this.$wrapper.classList.contains("nav-collapsed") &&
                this.$wrapper.classList.contains("menu-collapsed")) {
                this.$wrapper.classList.add("nav-collapsed");
                this.$wrapper.classList.add("menu-collapsed");
            }
            this.toggleHideSidebar.emit(false);
        }
    };
    // check outside click and close sidebar for smaller screen <992
    SidebarDirective.prototype.onOutsideClick = function (event) {
        if (this.innerWidth < 992) {
            var clickedComponent = event.target;
            var inside = false;
            do {
                if (clickedComponent === this.el.nativeElement) {
                    inside = true;
                }
                clickedComponent = clickedComponent.parentNode;
            } while (clickedComponent);
            if (!this.el.nativeElement.classList.contains("hide-sidebar") &&
                !inside &&
                !event.target.classList.contains("navbar-toggle")) {
                this.toggleHideSidebar.emit(true);
            }
        }
    };
    SidebarDirective.prototype.addLink = function (link) {
        this.navlinks.push(link);
    };
    SidebarDirective.prototype.getLinks = function () {
        return this.navlinks;
    };
    SidebarDirective.prototype.hideSidebar = function () {
        if (this.innerWidth < 992) {
            this.toggleHideSidebar.emit(true);
        }
    };
    SidebarDirective.prototype.expandActive = function () {
        var _this = this;
        this.navlinks
            .filter(function (_) { return _.routePath === _this.activeRoute; })
            .forEach(function (link) {
            link.isShown = true;
            if (link.level.toString().trim() === "3") {
                _this.navlinks
                    .filter(function (_) { return _.level.toString().trim() === "2" && _.title === link.parent; })
                    .forEach(function (parentLink) {
                    parentLink.open = true;
                    _this.activeLinks.push(parentLink.title);
                    _this.navlinks
                        .filter(function (_) {
                        return _.level.toString().trim() === "1" &&
                            _.title === parentLink.parent;
                    })
                        .forEach(function (superParentLink) {
                        superParentLink.open = true;
                        _this.activeLinks.push(superParentLink.title);
                        superParentLink.toggleEmit.emit(_this.activeLinks);
                    });
                });
            }
            else if (link.level.toString().trim() === "2") {
                _this.navlinks
                    .filter(function (_) { return _.level.toString().trim() === "1" && _.title === link.parent; })
                    .forEach(function (parentLink) {
                    parentLink.open = true;
                    _this.activeLinks.push(parentLink.title);
                    parentLink.toggleEmit.emit(_this.activeLinks);
                });
            }
        });
    };
    SidebarDirective.prototype.toggleActiveList = function () {
        var _this = this;
        this.navlinks
            .filter(function (_) {
            return _.level.toString().trim() === "3" && _.routePath !== _this.activeRoute;
        })
            .forEach(function (link) {
            link.active = false;
        });
    };
    SidebarDirective.prototype.setIsShown = function (parentLink) {
        var childLevel = Number(parentLink.level) + 1;
        this.navlinks
            .filter(function (_) {
            return _.level.toString().trim() === childLevel.toString().trim() &&
                _.parent === parentLink.title;
        })
            .forEach(function (link) {
            link.isShown = true;
            link.isHidden = false;
        });
    };
    SidebarDirective.prototype.setIsHidden = function (parentLink) {
        var childLevel = Number(parentLink.level) + 1;
        this.navlinks
            .filter(function (_) {
            return _.level.toString().trim() === childLevel.toString().trim() &&
                _.parent === parentLink.title;
        })
            .forEach(function (link) {
            link.isShown = false;
            link.isHidden = true;
        });
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], SidebarDirective.prototype, "toggleHideSidebar", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("mouseenter", ["$event"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Object]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], SidebarDirective.prototype, "onMouseOver", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("mouseleave", ["$event"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Object]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], SidebarDirective.prototype, "onMouseOut", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("click", ["$event"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Object]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], SidebarDirective.prototype, "onClick", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("window:resize", ["$event"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Object]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], SidebarDirective.prototype, "onResize", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("document:click", ["$event"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Object]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], SidebarDirective.prototype, "onOutsideClick", null);
    SidebarDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({ selector: "[appSidebar]" }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["Renderer2"],
            _angular_router__WEBPACK_IMPORTED_MODULE_2__["Router"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ChangeDetectorRef"]])
    ], SidebarDirective);
    return SidebarDirective;
}());



/***/ }),

/***/ "./src/app/shared/directives/sidebaranchortoggle.directive.ts":
/*!********************************************************************!*\
  !*** ./src/app/shared/directives/sidebaranchortoggle.directive.ts ***!
  \********************************************************************/
/*! exports provided: SidebarAnchorToggleDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SidebarAnchorToggleDirective", function() { return SidebarAnchorToggleDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _sidebarlink_directive__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./sidebarlink.directive */ "./src/app/shared/directives/sidebarlink.directive.ts");



var SidebarAnchorToggleDirective = /** @class */ (function () {
    function SidebarAnchorToggleDirective(navlink) {
        this.navlink = navlink;
    }
    SidebarAnchorToggleDirective.prototype.onClick = function () {
        this.navlink.toggle();
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("click", ["$event"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", []),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], SidebarAnchorToggleDirective.prototype, "onClick", null);
    SidebarAnchorToggleDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: "[appSidebarAnchorToggle]"
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](0, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_sidebarlink_directive__WEBPACK_IMPORTED_MODULE_2__["SidebarLinkDirective"])),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_sidebarlink_directive__WEBPACK_IMPORTED_MODULE_2__["SidebarLinkDirective"]])
    ], SidebarAnchorToggleDirective);
    return SidebarAnchorToggleDirective;
}());



/***/ }),

/***/ "./src/app/shared/directives/sidebarlink.directive.ts":
/*!************************************************************!*\
  !*** ./src/app/shared/directives/sidebarlink.directive.ts ***!
  \************************************************************/
/*! exports provided: SidebarLinkDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SidebarLinkDirective", function() { return SidebarLinkDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _sidebarlist_directive__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./sidebarlist.directive */ "./src/app/shared/directives/sidebarlist.directive.ts");
/* harmony import */ var _sidebar_directive__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./sidebar.directive */ "./src/app/shared/directives/sidebar.directive.ts");




var SidebarLinkDirective = /** @class */ (function () {
    function SidebarLinkDirective(sidebarList, sidebar, el) {
        this.el = el;
        this.toggleEmit = new _angular_core__WEBPACK_IMPORTED_MODULE_1__["EventEmitter"]();
        this.sidebarList = sidebarList;
        this.sidebar = sidebar;
    }
    Object.defineProperty(SidebarLinkDirective.prototype, "open", {
        get: function () {
            return this._open;
        },
        set: function (value) {
            this._open = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(SidebarLinkDirective.prototype, "navCollapsedOpen", {
        get: function () {
            return this._navCollapsedOpen;
        },
        set: function (value) {
            this._navCollapsedOpen = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(SidebarLinkDirective.prototype, "active", {
        get: function () {
            return this._active;
        },
        set: function (value) {
            this._active = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(SidebarLinkDirective.prototype, "isShown", {
        get: function () {
            return this._isShown;
        },
        set: function (value) {
            this._isShown = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(SidebarLinkDirective.prototype, "isHidden", {
        get: function () {
            return this._isHidden;
        },
        set: function (value) {
            this._isHidden = value;
        },
        enumerable: true,
        configurable: true
    });
    SidebarLinkDirective.prototype.ngOnInit = function () {
        this.sidebar.addLink(this);
    };
    SidebarLinkDirective.prototype.toggle = function () {
        this.sidebarList.activeLinks = [];
        this.sidebarList.setList(this.sidebar.getLinks());
        var classList = this.el.nativeElement.classList;
        if (this.level.toString().trim() === "3") {
            this.active = true;
            this.sidebarList.toggleActiveList(this);
            this.sidebar.hideSidebar();
        }
        if (this.level.toString().trim() === "1" && !classList.contains("has-sub")) {
            this.sidebarList.collapseOtherLinks(this);
        }
        if (classList.contains("has-sub") && classList.contains("open")) {
            this.sidebarList.collapse(this);
        }
        else {
            if (classList.contains("has-sub")) {
                this.sidebarList.expand(this);
            }
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Number)
    ], SidebarLinkDirective.prototype, "level", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], SidebarLinkDirective.prototype, "classes", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], SidebarLinkDirective.prototype, "parent", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], SidebarLinkDirective.prototype, "title", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String)
    ], SidebarLinkDirective.prototype, "routePath", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Output"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], SidebarLinkDirective.prototype, "toggleEmit", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class.open"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Boolean])
    ], SidebarLinkDirective.prototype, "open", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class.nav-collapsed-open"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Boolean])
    ], SidebarLinkDirective.prototype, "navCollapsedOpen", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class.active"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Boolean])
    ], SidebarLinkDirective.prototype, "active", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class.is-shown"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Boolean])
    ], SidebarLinkDirective.prototype, "isShown", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class.is-hidden"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Boolean])
    ], SidebarLinkDirective.prototype, "isHidden", null);
    SidebarLinkDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({ selector: "[appSidebarlink]" }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](0, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_sidebarlist_directive__WEBPACK_IMPORTED_MODULE_2__["SidebarListDirective"])),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__param"](1, Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"])(_sidebar_directive__WEBPACK_IMPORTED_MODULE_3__["SidebarDirective"])),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_sidebarlist_directive__WEBPACK_IMPORTED_MODULE_2__["SidebarListDirective"],
            _sidebar_directive__WEBPACK_IMPORTED_MODULE_3__["SidebarDirective"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"]])
    ], SidebarLinkDirective);
    return SidebarLinkDirective;
}());



/***/ }),

/***/ "./src/app/shared/directives/sidebarlist.directive.ts":
/*!************************************************************!*\
  !*** ./src/app/shared/directives/sidebarlist.directive.ts ***!
  \************************************************************/
/*! exports provided: SidebarListDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SidebarListDirective", function() { return SidebarListDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var SidebarListDirective = /** @class */ (function () {
    function SidebarListDirective() {
        this.navlinks = [];
        this.activeLinks = [];
    }
    SidebarListDirective.prototype.setList = function (list) {
        this.navlinks = list;
    };
    SidebarListDirective.prototype.collapse = function (link) {
        link.open = false;
        this.setIsHidden(link);
        if (link.level.toString().trim() === "2") {
            this.activeLinks.push(this.navlinks
                .filter(function (_) { return _.level.toString().trim() === "1" && _.open === true; })[0].title);
        }
        link.toggleEmit.emit(this.activeLinks);
    };
    SidebarListDirective.prototype.expand = function (link) {
        link.open = true;
        this.activeLinks.push(link.title);
        this.collapseOtherLinks(link);
        this.setIsShown(link);
        link.toggleEmit.emit(this.activeLinks);
    };
    SidebarListDirective.prototype.toggleActiveList = function (openLink) {
        this.navlinks
            .filter(function (_) { return _.level.toString().trim() === "3"; })
            .forEach(function (link) {
            if (link !== openLink) {
                link.active = false;
            }
        });
    };
    SidebarListDirective.prototype.collapseOtherLinks = function (openLink) {
        var _this = this;
        if (openLink.level.toString().trim() === "1") {
            this.navlinks
                .filter(function (_) {
                return (_.level.toString().trim() === openLink.level.toString().trim() ||
                    _.level.toString().trim() === "2") &&
                    _.open === true;
            })
                .forEach(function (link) {
                if (link !== openLink) {
                    link.open = false;
                    _this.setIsHidden(link);
                }
            });
        }
        else if (openLink.level.toString().trim() === "2") {
            this.activeLinks.push(this.navlinks
                .filter(function (_) { return _.level.toString().trim() === "1" && _.open === true; })[0].title);
            this.navlinks
                .filter(function (_) {
                return _.level.toString().trim() === openLink.level.toString().trim() &&
                    _.parent === openLink.parent &&
                    _.open === true;
            })
                .forEach(function (link) {
                if (link !== openLink) {
                    link.open = false;
                    _this.setIsHidden(link);
                }
            });
        }
    };
    SidebarListDirective.prototype.setIsShown = function (parentLink) {
        var childLevel = Number(parentLink.level) + 1;
        this.navlinks
            .filter(function (_) {
            return _.level.toString().trim() === childLevel.toString().trim() &&
                _.parent === parentLink.title;
        })
            .forEach(function (link) {
            link.isShown = true;
            link.isHidden = false;
        });
    };
    SidebarListDirective.prototype.setIsHidden = function (parentLink) {
        var childLevel = Number(parentLink.level) + 1;
        this.navlinks
            .filter(function (_) {
            return _.level.toString().trim() === childLevel.toString().trim() &&
                _.parent === parentLink.title;
        })
            .forEach(function (link) {
            link.isShown = false;
            link.isHidden = true;
        });
    };
    SidebarListDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({ selector: "[appSidebarList]" })
    ], SidebarListDirective);
    return SidebarListDirective;
}());



/***/ }),

/***/ "./src/app/shared/directives/sidebartoggle.directive.ts":
/*!**************************************************************!*\
  !*** ./src/app/shared/directives/sidebartoggle.directive.ts ***!
  \**************************************************************/
/*! exports provided: SidebarToggleDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SidebarToggleDirective", function() { return SidebarToggleDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var SidebarToggleDirective = /** @class */ (function () {
    function SidebarToggleDirective(el, renderer) {
        this.el = el;
        this.renderer = renderer;
        this._dataToggle = "expanded";
        this._toggleRight = true;
        this._toggleLeft = false;
        this.fireRefreshEventOnWindow = function () {
            var evt = document.createEvent("HTMLEvents");
            evt.initEvent("resize", true, false);
            window.dispatchEvent(evt);
        };
    }
    Object.defineProperty(SidebarToggleDirective.prototype, "dataToggle", {
        get: function () {
            return this._dataToggle;
        },
        set: function (value) {
            this._dataToggle = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(SidebarToggleDirective.prototype, "toggleRight", {
        get: function () {
            return this._toggleRight;
        },
        set: function (value) {
            this._toggleRight = value;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(SidebarToggleDirective.prototype, "toggleLeft", {
        get: function () {
            return this._toggleLeft;
        },
        set: function (value) {
            this._toggleLeft = value;
        },
        enumerable: true,
        configurable: true
    });
    SidebarToggleDirective.prototype.ngAfterViewInit = function () {
        this.$wrapper = document.getElementsByClassName("wrapper")[0];
        this.compact_menu_checkbox = this.$wrapper.querySelector('.cz-compact-menu');
    };
    SidebarToggleDirective.prototype.onClick = function (e) {
        var _this = this;
        if (this.dataToggle === "expanded") {
            this.dataToggle = "collapsed";
            this.renderer.addClass(this.$wrapper, 'nav-collapsed');
            if (this.compact_menu_checkbox) {
                this.compact_menu_checkbox.checked = true;
            }
        }
        else {
            this.dataToggle = "expanded";
            this.renderer.removeClass(this.$wrapper, 'nav-collapsed');
            this.renderer.removeClass(this.$wrapper, 'menu-collapsed');
            if (this.compact_menu_checkbox) {
                this.compact_menu_checkbox.checked = false;
            }
        }
        this.toggleLeft = !this.toggleLeft;
        this.toggleRight = !this.toggleRight;
        setTimeout(function () {
            _this.fireRefreshEventOnWindow();
        }, 300);
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("attr.data-toggle"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", String),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [String])
    ], SidebarToggleDirective.prototype, "dataToggle", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class.ft-toggle-right"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Boolean])
    ], SidebarToggleDirective.prototype, "toggleRight", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostBinding"])("class.ft-toggle-left"),
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Boolean),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Boolean])
    ], SidebarToggleDirective.prototype, "toggleLeft", null);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])("click", ["$event"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Object]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], SidebarToggleDirective.prototype, "onClick", null);
    SidebarToggleDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({ selector: "[appSidebarToggle]" }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["Renderer2"]])
    ], SidebarToggleDirective);
    return SidebarToggleDirective;
}());



/***/ }),

/***/ "./src/app/shared/directives/toggle-fullscreen.directive.ts":
/*!******************************************************************!*\
  !*** ./src/app/shared/directives/toggle-fullscreen.directive.ts ***!
  \******************************************************************/
/*! exports provided: ToggleFullscreenDirective */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ToggleFullscreenDirective", function() { return ToggleFullscreenDirective; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var screenfull__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! screenfull */ "./node_modules/screenfull/dist/screenfull.js");
/* harmony import */ var screenfull__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(screenfull__WEBPACK_IMPORTED_MODULE_2__);



var ToggleFullscreenDirective = /** @class */ (function () {
    function ToggleFullscreenDirective() {
    }
    ToggleFullscreenDirective.prototype.onClick = function () {
        if (screenfull__WEBPACK_IMPORTED_MODULE_2__["enabled"]) {
            screenfull__WEBPACK_IMPORTED_MODULE_2__["toggle"]();
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])('click'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", []),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], ToggleFullscreenDirective.prototype, "onClick", null);
    ToggleFullscreenDirective = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Directive"])({
            selector: '[appToggleFullscreen]'
        })
    ], ToggleFullscreenDirective);
    return ToggleFullscreenDirective;
}());



/***/ }),

/***/ "./src/app/shared/footer/footer.component.html":
/*!*****************************************************!*\
  !*** ./src/app/shared/footer/footer.component.html ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!--Footer Starts-->\r\n<footer>\r\n    <div class=\"container-fluid\">\r\n        <p class=\"copyright text-center\">\r\n                Copyright  &copy;  {{currentDate | date: 'yyyy'}}\r\n        </p>\r\n\r\n    </div>\r\n</footer>\r\n<!--Footer Ends-->\r\n"

/***/ }),

/***/ "./src/app/shared/footer/footer.component.scss":
/*!*****************************************************!*\
  !*** ./src/app/shared/footer/footer.component.scss ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9mb290ZXIvZm9vdGVyLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/shared/footer/footer.component.ts":
/*!***************************************************!*\
  !*** ./src/app/shared/footer/footer.component.ts ***!
  \***************************************************/
/*! exports provided: FooterComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "FooterComponent", function() { return FooterComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var FooterComponent = /** @class */ (function () {
    function FooterComponent() {
        //Variables
        this.currentDate = new Date();
    }
    FooterComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-footer',
            template: __webpack_require__(/*! ./footer.component.html */ "./src/app/shared/footer/footer.component.html"),
            styles: [__webpack_require__(/*! ./footer.component.scss */ "./src/app/shared/footer/footer.component.scss")]
        })
    ], FooterComponent);
    return FooterComponent;
}());



/***/ }),

/***/ "./src/app/shared/navbar/navbar.component.html":
/*!*****************************************************!*\
  !*** ./src/app/shared/navbar/navbar.component.html ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!-- Navbar (Header) Starts -->\r\n<nav class=\"header-navbar navbar navbar-expand-lg navbar-light bg-faded\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"navbar-header\">\r\n            <button type=\"button\" class=\"navbar-toggle d-lg-none float-left\" data-toggle=\"collapse\" (click)=\"toggleSidebar()\">\r\n                <span class=\"sr-only\">Toggle navigation</span>\r\n                <span class=\"icon-bar\"></span>\r\n                <span class=\"icon-bar\"></span>\r\n                <span class=\"icon-bar\"></span>\r\n            </button>\r\n            <span class=\"d-lg-none navbar-right navbar-collapse-toggle\">\r\n                <a class=\"open-navbar-container\" (click)=\"isCollapsed = !isCollapsed\" [attr.aria-expanded]=\"!isCollapsed\" aria-controls=\"navbarSupportedContent\">\r\n                    <i class=\"ft-more-vertical\"></i>\r\n                </a>\r\n              </span>\r\n        </div>\r\n        <div class=\"navbar-container\">\r\n            <div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\" [ngbCollapse]=\"isCollapsed\">\r\n                <ul class=\"navbar-nav\">\r\n                    <li class=\"nav-item mr-2  d-none d-lg-block\">\r\n                        <a href=\"javascript:;\" class=\"nav-link\" id=\"navbar-fullscreen\" appToggleFullscreen (click)=\"ToggleClass()\">\r\n                            <i class=\"{{toggleClass}} font-medium-3 blue-grey darken-4\"></i>\r\n                            <p class=\"d-none\">fullscreen</p>\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\" ngbDropdown [placement]=\"placement\">\r\n                        <a class=\"nav-link position-relative\" id=\"dropdownLang\" ngbDropdownToggle>\r\n                            <i class=\"ft-flag font-medium-3 blue-grey darken-4\"></i>\r\n                            <p class=\"d-none\">Language</p>\r\n                        </a>\r\n                        <div ngbDropdownMenu aria-labelledby=\"dropdownLang\" class=\"dropdownLang text-left\">\r\n                            <a class=\"dropdown-item py-1 lang\" href=\"javascript:;\" (click)=\"ChangeLanguage('en')\">\r\n                                <img src=\"./assets/img/flags/us.png\" alt=\"English\" class=\"langimg\">\r\n                                <span>English</span>\r\n                            </a>\r\n                            <a class=\"dropdown-item py-1 lang\" href=\"javascript:;\" (click)=\"ChangeLanguage('es')\">\r\n                                <img src=\"./assets/img/flags/es.png\" alt=\"Spanish\" class=\"langimg\">\r\n                                <span>Spanish</span>\r\n                            </a>\r\n                            <a class=\"dropdown-item py-1 lang\" href=\"javascript:;\" (click)=\"ChangeLanguage('pt')\">\r\n                                <img src=\"./assets/img/flags/br.png\" alt=\"Portuguese\" class=\"langimg\">\r\n                                <span>Portuguese</span>\r\n                            </a>\r\n                            <a class=\"dropdown-item py-1 lang\" href=\"javascript:;\" (click)=\"ChangeLanguage('de')\">\r\n                                <img src=\"./assets/img/flags/de.png\" alt=\"German\" class=\"langimg\">\r\n                                <span>German</span>\r\n                            </a>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"nav-item\" ngbDropdown [placement]=\"placement\">\r\n                        <a class=\"nav-link position-relative\" id=\"dropdownBasic2\" ngbDropdownToggle>\r\n                            <i class=\"ft-bell font-medium-3 blue-grey darken-4\"></i>\r\n                            <span class=\"notification badge badge-pill badge-danger\">4</span>\r\n                            <p class=\"d-none\">Notifications</p>\r\n                        </a>\r\n                        <div ngbDropdownMenu aria-labelledby=\"dropdownBasic2\" class=\"notification-dropdown\">\r\n                            <div class=\"noti-list\" [perfectScrollbar]>\r\n                                <a class=\"dropdown-item noti-container py-3 border-bottom border-bottom-blue-grey border-bottom-lighten-4\">\r\n                                    <i class=\"ft-bell info float-left d-block font-large-1 mt-1 mr-2\"></i>\r\n                                    <span class=\"noti-wrapper\">\r\n                                        <span class=\"noti-title line-height-1 d-block text-bold-400 info\">New Order Received</span>\r\n                                        <span class=\"noti-text\">Lorem ipsum dolor sit ametitaque in, et!</span>\r\n                                    </span>\r\n                                </a>\r\n                                <a class=\"dropdown-item noti-container py-3 border-bottom border-bottom-blue-grey border-bottom-lighten-4\">\r\n                                    <i class=\"ft-bell warning float-left d-block font-large-1 mt-1 mr-2\"></i>\r\n                                    <span class=\"noti-wrapper\">\r\n                                        <span class=\"noti-title line-height-1 d-block text-bold-400 warning\">New User Registered</span>\r\n                                        <span class=\"noti-text\">Lorem ipsum dolor sit ametitaque in </span>\r\n                                    </span>\r\n                                </a>\r\n                                <a class=\"dropdown-item noti-container py-3 border-bottom border-bottom-blue-grey border-bottom-lighten-4\">\r\n                                    <i class=\"ft-bell danger float-left d-block font-large-1 mt-1 mr-2\"></i>\r\n                                    <span class=\"noti-wrapper\">\r\n                                        <span class=\"noti-title line-height-1 d-block text-bold-400 danger\">New Order Received</span>\r\n                                        <span class=\"noti-text\">Lorem ipsum dolor sit ametest?</span>\r\n                                    </span>\r\n                                </a>\r\n                                <a class=\"dropdown-item noti-container py-3\">\r\n                                    <i class=\"ft-bell success float-left d-block font-large-1 mt-1 mr-2\"></i>\r\n                                    <span class=\"noti-wrapper\">\r\n                                        <span class=\"noti-title line-height-1 d-block text-bold-400 success\">New User Registered</span>\r\n                                        <span class=\"noti-text\">Lorem ipsum dolor sit ametnatus aut.</span>\r\n                                    </span>\r\n                                </a>\r\n                            </div>\r\n                            <a class=\"noti-footer primary text-center d-block border-top border-top-blue-grey border-top-lighten-4 text-bold-400 py-1\">Read All Notifications</a>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"nav-item\" ngbDropdown [placement]=\"placement\">\r\n                        <a class=\"nav-link position-relative\" id=\"dropdownBasic3\" ngbDropdownToggle>\r\n                            <i class=\"ft-user font-medium-3 blue-grey darken-4\"></i>\r\n                            <p class=\"d-none\">User Settings</p>\r\n                        </a>\r\n                        <div ngbDropdownMenu aria-labelledby=\"dropdownBasic3\" class=\"text-left\">\r\n                            <a class=\"dropdown-item py-1\" routerLink=\"/pages/profile\">\r\n                                <i class=\"ft-edit mr-2\"></i>\r\n                                <span>My Profile</span>\r\n                            </a>\r\n                            <a class=\"dropdown-item py-1\" routerLink=\"/inbox\">\r\n                                <i class=\"ft-mail mr-2\"></i>\r\n                                <span>My Inbox</span>\r\n                            </a>\r\n                            <a class=\"dropdown-item py-1\" href=\"javascript:;\">\r\n                                <i class=\"ft-settings mr-2\"></i>\r\n                                <span>Settings</span>\r\n                            </a>\r\n                            <div class=\"dropdown-divider\"></div>\r\n                            <a class=\"dropdown-item\" href=\"javascript:;\" (click)=\"logout()\">\r\n                                <i class=\"ft-power mr-2\"></i>\r\n                                <span>Logout</span>\r\n                            </a>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"nav-item d-none d-lg-block\">\r\n                        <a class=\"nav-link position-relative notification-sidebar-toggle\" (click)=\"toggleNotificationSidebar();\">\r\n                            <i class=\"ft-align-left font-medium-3 blue-grey darken-4\"></i>\r\n                            <p class=\"d-none\">Notifications Sidebar</p>\r\n                        </a>\r\n                    </li>\r\n\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</nav>\r\n<!-- Navbar (Header) Ends -->\r\n"

/***/ }),

/***/ "./src/app/shared/navbar/navbar.component.scss":
/*!*****************************************************!*\
  !*** ./src/app/shared/navbar/navbar.component.scss ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3NoYXJlZC9uYXZiYXIvbmF2YmFyLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/shared/navbar/navbar.component.ts":
/*!***************************************************!*\
  !*** ./src/app/shared/navbar/navbar.component.ts ***!
  \***************************************************/
/*! exports provided: NavbarComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NavbarComponent", function() { return NavbarComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var app_shared_auth_auth_service__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! app/shared/auth/auth.service */ "./src/app/shared/auth/auth.service.ts");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm5/ngx-translate-core.js");
/* harmony import */ var _services_layout_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../services/layout.service */ "./src/app/shared/services/layout.service.ts");
/* harmony import */ var _services_config_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../services/config.service */ "./src/app/shared/services/config.service.ts");






var NavbarComponent = /** @class */ (function () {
    function NavbarComponent(translate, layoutService, auth, configService) {
        var _this = this;
        this.translate = translate;
        this.layoutService = layoutService;
        this.auth = auth;
        this.configService = configService;
        this.currentLang = 'en';
        this.toggleClass = 'ft-maximize';
        this.placement = 'bottom-right';
        this.isCollapsed = true;
        this.toggleHideSidebar = new _angular_core__WEBPACK_IMPORTED_MODULE_2__["EventEmitter"]();
        this.config = {};
        var browserLang = translate.getBrowserLang();
        translate.use(browserLang.match(/en|es|pt|de/) ? browserLang : 'en');
        this.layoutSub = layoutService.changeEmitted$.subscribe(function (direction) {
            var dir = direction.direction;
            if (dir === 'rtl') {
                _this.placement = 'bottom-left';
            }
            else if (dir === 'ltr') {
                _this.placement = 'bottom-right';
            }
        });
    }
    NavbarComponent.prototype.ngOnInit = function () {
        this.config = this.configService.templateConf;
    };
    NavbarComponent.prototype.ngAfterViewInit = function () {
        var _this = this;
        if (this.config.layout.dir) {
            setTimeout(function () {
                var dir = _this.config.layout.dir;
                if (dir === 'rtl') {
                    _this.placement = 'bottom-left';
                }
                else if (dir === 'ltr') {
                    _this.placement = 'bottom-right';
                }
            }, 0);
        }
    };
    NavbarComponent.prototype.logout = function () {
        this.auth.logout();
    };
    NavbarComponent.prototype.ngOnDestroy = function () {
        if (this.layoutSub) {
            this.layoutSub.unsubscribe();
        }
    };
    NavbarComponent.prototype.ChangeLanguage = function (language) {
        this.translate.use(language);
    };
    NavbarComponent.prototype.ToggleClass = function () {
        if (this.toggleClass === 'ft-maximize') {
            this.toggleClass = 'ft-minimize';
        }
        else {
            this.toggleClass = 'ft-maximize';
        }
    };
    NavbarComponent.prototype.toggleNotificationSidebar = function () {
        this.layoutService.emitNotiSidebarChange(true);
    };
    NavbarComponent.prototype.toggleSidebar = function () {
        var appSidebar = document.getElementsByClassName('app-sidebar')[0];
        if (appSidebar.classList.contains('hide-sidebar')) {
            this.toggleHideSidebar.emit(false);
        }
        else {
            this.toggleHideSidebar.emit(true);
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Output"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], NavbarComponent.prototype, "toggleHideSidebar", void 0);
    NavbarComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Component"])({
            selector: 'app-navbar',
            template: __webpack_require__(/*! ./navbar.component.html */ "./src/app/shared/navbar/navbar.component.html"),
            styles: [__webpack_require__(/*! ./navbar.component.scss */ "./src/app/shared/navbar/navbar.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_ngx_translate_core__WEBPACK_IMPORTED_MODULE_3__["TranslateService"], _services_layout_service__WEBPACK_IMPORTED_MODULE_4__["LayoutService"],
            app_shared_auth_auth_service__WEBPACK_IMPORTED_MODULE_1__["AuthService"], _services_config_service__WEBPACK_IMPORTED_MODULE_5__["ConfigService"]])
    ], NavbarComponent);
    return NavbarComponent;
}());



/***/ }),

/***/ "./src/app/shared/notification-sidebar/notification-sidebar.component.html":
/*!*********************************************************************************!*\
  !*** ./src/app/shared/notification-sidebar/notification-sidebar.component.html ***!
  \*********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!-- //////////////////////////////////////////////////////////////////////////// -->\r\n<!-- START Notification Sidebar -->\r\n<aside #sidebar id=\"notification-sidebar\" class=\"notification-sidebar d-none d-sm-none d-md-block\">\r\n  <a class=\"notification-sidebar-close\" (click)=\"onClose()\">\r\n    <i class=\"ft-x font-medium-3\"></i>\r\n  </a>\r\n  <div class=\"side-nav notification-sidebar-content\" [perfectScrollbar]>\r\n    <div class=\"row\">\r\n      <div class=\"col-12 mt-1\">\r\n        <ngb-tabset>\r\n          <ngb-tab>\r\n            <ng-template ngbTabTitle><b>Activity</b></ng-template>\r\n            <ng-template ngbTabContent>\r\n              <div id=\"activity\" class=\"col-12 timeline-left\">\r\n                <h6 class=\"mt-1 mb-3 text-bold-400 text-left\">RECENT ACTIVITY</h6>\r\n                <div id=\"timeline\" class=\"timeline-left timeline-wrapper\">\r\n                  <ul class=\"timeline\">\r\n                    <li class=\"timeline-line\"></li>\r\n                    <li class=\"timeline-item text-left text-left\">\r\n                      <div class=\"timeline-badge\">\r\n                        <span class=\"bg-purple bg-lighten-1\" data-toggle=\"tooltip\" data-placement=\"right\"\r\n                          title=\"Portfolio project work\"><i class=\"ft-shopping-cart\"></i></span>\r\n                      </div>\r\n                      <div class=\"col s9 recent-activity-list-text\">\r\n                        <a href=\"#\" class=\"deep-purple-text medium-small\">just now</a>\r\n                        <p class=\"mt-0 mb-2 fixed-line-height font-weight-300 medium-small\">Jim Doe Purchased new\r\n                          equipments for zonal office.</p>\r\n                      </div>\r\n                    </li>\r\n                    <li class=\"timeline-item text-left\">\r\n                      <div class=\"timeline-badge\">\r\n                        <span class=\"bg-info bg-lighten-1\" data-toggle=\"tooltip\" data-placement=\"right\"\r\n                          title=\"Portfolio project work\"><i class=\"fa fa-plane\"></i></span>\r\n                      </div>\r\n                      <div class=\"col s9 recent-activity-list-text\">\r\n                        <a href=\"#\" class=\"cyan-text medium-small\">Yesterday</a>\r\n                        <p class=\"mt-0 mb-2 fixed-line-height font-weight-300 medium-small\">Your Next flight for USA\r\n                          will be on 15th August 2015.</p>\r\n                      </div>\r\n                    </li>\r\n                    <li class=\"timeline-item text-left\">\r\n                      <div class=\"timeline-badge\">\r\n                        <span class=\"bg-success bg-lighten-1\" data-toggle=\"tooltip\" data-placement=\"right\"\r\n                          title=\"Portfolio project work\"><i class=\"ft-mic\"></i></span>\r\n                      </div>\r\n                      <div class=\"col s9 recent-activity-list-text\">\r\n                        <a href=\"#\" class=\"green-text medium-small\">5 Days Ago</a>\r\n                        <p class=\"mt-0 mb-2 fixed-line-height font-weight-300 medium-small\">Natalya Parker Send you a\r\n                          voice mail for next conference.</p>\r\n                      </div>\r\n                    </li>\r\n                    <li class=\"timeline-item text-left\">\r\n                      <div class=\"timeline-badge\">\r\n                        <span class=\"bg-warning bg-lighten-1\" data-toggle=\"tooltip\" data-placement=\"right\"\r\n                          title=\"Portfolio project work\"><i class=\"ft-map-pin\"></i></span>\r\n                      </div>\r\n                      <div class=\"col s9 recent-activity-list-text\">\r\n                        <a href=\"#\" class=\"amber-text medium-small\">1 Week Ago</a>\r\n                        <p class=\"mt-0 mb-2 fixed-line-height font-weight-300 medium-small\">Jessy Jay open a new store\r\n                          at S.G Road.</p>\r\n                      </div>\r\n                    </li>\r\n                    <li class=\"timeline-item text-left\">\r\n                      <div class=\"timeline-badge\">\r\n                        <span class=\"bg-red bg-lighten-1\" data-toggle=\"tooltip\" data-placement=\"right\"\r\n                          title=\"Portfolio project work\"><i class=\"ft-inbox\"></i></span>\r\n                      </div>\r\n                      <div class=\"col s9 recent-activity-list-text\">\r\n                        <a href=\"#\" class=\"deep-orange-text medium-small\">2 Week Ago</a>\r\n                        <p class=\"mt-0 mb-2 fixed-line-height font-weight-300 medium-small\">voice mail for conference.\r\n                        </p>\r\n                      </div>\r\n                    </li>\r\n                    <li class=\"timeline-item text-left\">\r\n                      <div class=\"timeline-badge\">\r\n                        <span class=\"bg-cyan bg-lighten-1\" data-toggle=\"tooltip\" data-placement=\"right\"\r\n                          title=\"Portfolio project work\"><i class=\"ft-mic\"></i></span>\r\n                      </div>\r\n                      <div class=\"col s9 recent-activity-list-text\">\r\n                        <a href=\"#\" class=\"brown-text medium-small\">1 Month Ago</a>\r\n                        <p class=\"mt-0 mb-2 fixed-line-height font-weight-300 medium-small\">Natalya Parker Send you a\r\n                          voice mail for next conference.</p>\r\n                      </div>\r\n                    </li>\r\n                    <li class=\"timeline-item text-left\">\r\n                      <div class=\"timeline-badge\">\r\n                        <span class=\"bg-amber bg-lighten-1\" data-toggle=\"tooltip\" data-placement=\"right\"\r\n                          title=\"Portfolio project work\"><i class=\"ft-map-pin\"></i></span>\r\n                      </div>\r\n                      <div class=\"col s9 recent-activity-list-text\">\r\n                        <a href=\"#\" class=\"deep-purple-text medium-small\">3 Month Ago</a>\r\n                        <p class=\"mt-0 mb-2 fixed-line-height font-weight-300 medium-small\">Jessy Jay open a new store\r\n                          at S.G Road.</p>\r\n                      </div>\r\n                    </li>\r\n                    <li class=\"timeline-item text-left\">\r\n                      <div class=\"timeline-badge\">\r\n                        <span class=\"bg-grey bg-lighten-1\" data-toggle=\"tooltip\" data-placement=\"right\"\r\n                          title=\"Portfolio project work\"><i class=\"ft-inbox\"></i></span>\r\n                      </div>\r\n                      <div class=\"col s9 recent-activity-list-text\">\r\n                        <a href=\"#\" class=\"grey-text medium-small\">1 Year Ago</a>\r\n                        <p class=\"mt-0 mb-2 fixed-line-height font-weight-300 medium-small\">voice mail for conference.\r\n                        </p>\r\n                      </div>\r\n                    </li>\r\n                  </ul>\r\n                </div>\r\n              </div>\r\n            </ng-template>\r\n          </ngb-tab>\r\n          <ngb-tab>\r\n            <ng-template ngbTabTitle><b>Chat</b></ng-template>\r\n            <ng-template ngbTabContent>\r\n              <div id=\"chatapp\" class=\"col-12\">\r\n                <h6 class=\"mt-1 mb-3 text-bold-400 text-left\">RECENT CHAT</h6>\r\n                <div class=\"collection border-none\">\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-12.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Elizabeth Elliott </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">5.00 AM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Thank you </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-6.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Mary Adams </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">4.14 AM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Hello Boo </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-11.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Caleb Richards </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">9.00 PM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Keny ! </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-18.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">June Lane </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">4.14 AM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Ohh God </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-1.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Edward Fletcher </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">5.15 PM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Love you </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-2.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Crystal Bates </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">8.00 AM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Can we </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-3.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Nathan Watts </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">9.53 PM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Great! </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-15.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Willard Wood </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">4.20 AM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Do it </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-19.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Ronnie Ellis </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">5.30 PM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Got that </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-14.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Gwendolyn Wood </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">4.34 AM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Like you </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-13.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Daniel Russell </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">12.00 AM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Thank you </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-22.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Sarah Graves </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">11.14 PM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Okay you </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-9.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Andrew Hoffman </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">7.30 PM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Can do </p>\r\n                    </div>\r\n                  </div>\r\n                  <div class=\"media mb-1\">\r\n                    <a>\r\n                      <img alt=\"96x96\" class=\"media-object d-flex mr-3 bg-primary height-50 rounded-circle\"\r\n                        src=\"assets/img/portrait/small/avatar-s-20.png\">\r\n                    </a>\r\n                    <div class=\"media-body text-left\">\r\n                      <div class=\"clearfix\">\r\n                        <h4 class=\"font-medium-1 primary mt-1 mb-0 mr-auto float-left\">Camila Lynch </h4>\r\n                        <span class=\"medium-small float-right blue-grey-text text-lighten-3\">2.00 PM</span>\r\n                      </div>\r\n                      <p class=\"text-muted font-small-3\">Leave it </p>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </ng-template>\r\n          </ngb-tab>\r\n          <ngb-tab>\r\n            <ng-template ngbTabTitle><b>Settings</b></ng-template>\r\n            <ng-template ngbTabContent>\r\n              <div id=\"settings\" class=\"col-12\">\r\n                <h6 class=\"mt-1 mb-3 text-bold-400 text-left\">GENERAL SETTINGS</h6>\r\n                <ul class=\"list-unstyled\">\r\n                  <li class=\"text-left\">\r\n                    <div class=\"togglebutton\">\r\n                      <div class=\"switch d-flex justify-content-between w-100\">\r\n                        <span class=\"text-bold-500\">Notifications</span>\r\n                        <div class=\"notification-cb\">\r\n                          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n                            <input checked=\"checked\" class=\"custom-control-input \" type=\"checkbox\"\r\n                              id=\"notifications1\">\r\n                            <label class=\"custom-control-label d-block\" for=\"notifications1\"></label>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n                    </div>\r\n                    <p>Use checkboxes when looking for yes or no answers.</p>\r\n                  </li>\r\n                  <li class=\"text-left\">\r\n                    <div class=\"togglebutton\">\r\n                      <div class=\"switch d-flex justify-content-between w-100\">\r\n                        <span class=\"text-bold-500\">Show recent activity</span>\r\n                        <div class=\"notification-cb\">\r\n                          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n                            <input checked=\"checked\" class=\"custom-control-input \" type=\"checkbox\"\r\n                              id=\"recent-activity1\">\r\n                            <label class=\"custom-control-label d-block\" for=\"recent-activity1\"></label>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n                    </div>\r\n                    <p>The for attribute is necessary to bind our custom checkbox with the input.</p>\r\n                  </li>\r\n                  <li class=\"text-left\">\r\n                    <div class=\"togglebutton\">\r\n                      <div class=\"switch  d-flex justify-content-between w-100\">\r\n                        <span class=\"text-bold-500\">Notifications</span>\r\n                        <div class=\"notification-cb\">\r\n                          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n                            <input class=\"custom-control-input \" type=\"checkbox\" id=\"notifications2\">\r\n                            <label class=\"custom-control-label d-block\" for=\"notifications2\"></label>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n                    </div>\r\n                    <p>Use checkboxes when looking for yes or no answers.</p>\r\n                  </li>\r\n                  <li class=\"text-left\">\r\n                    <div class=\"togglebutton\">\r\n                      <div class=\"switch d-flex justify-content-between w-100\">\r\n                        <span class=\"text-bold-500\">Show recent activity</span>\r\n                        <div class=\"notification-cb\">\r\n                          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n                            <input class=\"custom-control-input \" type=\"checkbox\"\r\n                              id=\"recent-activity2\">\r\n                            <label class=\"custom-control-label d-block\" for=\"recent-activity2\"></label>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n                    </div>\r\n                    <p>The for attribute is necessary to bind our custom checkbox with the input.</p>\r\n                  </li>\r\n                  <li class=\"text-left\">\r\n                    <div class=\"togglebutton\">\r\n                      <div class=\"switch d-flex justify-content-between w-100\">\r\n                        <span class=\"text-bold-500\">Show your emails</span>\r\n                        <div class=\"notification-cb\">\r\n                          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n                            <input class=\"custom-control-input \" type=\"checkbox\" id=\"show-emails\">\r\n                            <label class=\"custom-control-label d-block\" for=\"show-emails\"></label>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n                    </div>\r\n                    <p>Use checkboxes when looking for yes or no answers.</p>\r\n                  </li>\r\n                  <li class=\"text-left\">\r\n                    <div class=\"togglebutton\">\r\n                      <div class=\"switch d-flex justify-content-between w-100\">\r\n                        <span class=\"text-bold-500\">Show Task statistics</span>\r\n                        <div class=\"notification-cb\">\r\n                          <div class=\"custom-control custom-checkbox mb-2 mr-sm-2 mb-sm-0\">\r\n                            <input class=\"custom-control-input \" type=\"checkbox\" id=\"show-stats\">\r\n                            <label class=\"custom-control-label d-block\" for=\"show-stats\"></label>\r\n                          </div>\r\n                        </div>\r\n                      </div>\r\n                    </div>\r\n                    <p>The for attribute is necessary to bind our custom checkbox with the input.</p>\r\n                  </li>\r\n                </ul>\r\n              </div>\r\n            </ng-template>\r\n          </ngb-tab>\r\n        </ngb-tabset>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</aside>\r\n<!-- END Notification Sidebar -->"

/***/ }),

/***/ "./src/app/shared/notification-sidebar/notification-sidebar.component.scss":
/*!*********************************************************************************!*\
  !*** ./src/app/shared/notification-sidebar/notification-sidebar.component.scss ***!
  \*********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "#notification-sidebar {\n  width: 400px;\n  right: -400px;\n  padding: 0;\n  background-color: #FFF;\n  z-index: 1051;\n  position: fixed;\n  top: 0;\n  bottom: 0;\n  height: 100vh;\n  transition: right 0.4s cubic-bezier(0.05, 0.74, 0.2, 0.99);\n  -webkit-backface-visibility: hidden;\n          backface-visibility: hidden;\n  border-left: 1px solid rgba(0, 0, 0, 0.05);\n  box-shadow: 0 0 8px rgba(0, 0, 0, 0.1); }\n  #notification-sidebar.open {\n    right: 0; }\n  #notification-sidebar .notification-sidebar-content {\n    position: relative;\n    height: 100%;\n    padding: 10px; }\n  #notification-sidebar .notification-sidebar-content #timeline.timeline-left .timeline-item:before {\n      border: none; }\n  #notification-sidebar .notification-sidebar-content #timeline.timeline-left .timeline-item:after {\n      border: none; }\n  #notification-sidebar .notification-sidebar-content #settings .switch {\n      border: none; }\n  #notification-sidebar a.notification-sidebar-toggle {\n    background: #FFF;\n    color: theme-color(\"primary\");\n    display: block;\n    box-shadow: -3px 0px 8px rgba(0, 0, 0, 0.1); }\n  #notification-sidebar a.notification-sidebar-close {\n    color: #000; }\n  #notification-sidebar .notification-sidebar-close {\n    position: absolute;\n    right: 10px;\n    top: 10px;\n    padding: 7px;\n    width: auto;\n    z-index: 10; }\n  #notification-sidebar .notification-sidebar-toggle {\n    position: absolute;\n    top: 35%;\n    width: 54px;\n    height: 50px;\n    left: -54px;\n    text-align: center;\n    line-height: 50px;\n    cursor: pointer; }\n  [dir=\"rtl\"] :host ::ng-deep #notification-sidebar {\n  left: -400px;\n  right: auto; }\n  [dir=\"rtl\"] :host ::ng-deep #notification-sidebar.open {\n    left: 0;\n    right: auto; }\n  [dir=\"rtl\"] :host ::ng-deep #notification-sidebar .notification-sidebar-close {\n    left: 10px;\n    right: auto; }\n  [dir=\"rtl\"] :host ::ng-deep #notification-sidebar .notification-sidebar-toggle {\n    right: -54px;\n    left: auto; }\n\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvc2hhcmVkL25vdGlmaWNhdGlvbi1zaWRlYmFyL0M6XFxVc2Vyc1xcTmRpYW5hbmllXFxHaXRcXFByb2plY3RVcGRhdGVzXFxQVEFuZ3VsYXJcXHByb2plY3R1cGRhdGVzZnJvbnRlbmQvc3JjXFxhcHBcXHNoYXJlZFxcbm90aWZpY2F0aW9uLXNpZGViYXJcXG5vdGlmaWNhdGlvbi1zaWRlYmFyLmNvbXBvbmVudC5zY3NzIiwic3JjL2FwcC9zaGFyZWQvbm90aWZpY2F0aW9uLXNpZGViYXIvbm90aWZpY2F0aW9uLXNpZGViYXIuY29tcG9uZW50LnNjc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7RUFDQyxZQUFZO0VBQ1QsYUFBYTtFQUNoQixVQUFVO0VBQ1Asc0JBQXNCO0VBQ3pCLGFBQWE7RUFDVixlQUFlO0VBQ2YsTUFBTTtFQUNOLFNBQVM7RUFDVCxhQUFhO0VBQ2IsMERBQTBEO0VBQzFELG1DQUEyQjtVQUEzQiwyQkFBMkI7RUFDM0IsMENBQTBDO0VBQzFDLHNDQUFzQyxFQUFBO0VBYjFDO0lBZ0JFLFFBQVEsRUFBQTtFQWhCVjtJQXNCRSxrQkFBa0I7SUFDZixZQUFZO0lBQ1osYUFBYSxFQUFBO0VBeEJsQjtNQThCTSxZQUFXLEVBQUE7RUE5QmpCO01BaUNNLFlBQVcsRUFBQTtFQWpDakI7TUF5Q0ksWUFBWSxFQUFBO0VBekNoQjtJQWdERSxnQkFBZ0I7SUFDaEIsNkJBQTRCO0lBQzVCLGNBQWM7SUFDWCwyQ0FBMkMsRUFBQTtFQW5EaEQ7SUFzREssV0FBVyxFQUFBO0VBdERoQjtJQXlERSxrQkFBa0I7SUFDZixXQUFXO0lBQ1gsU0FBUztJQUNULFlBQVk7SUFDWixXQUFXO0lBQ1gsV0FBVyxFQUFBO0VBOURoQjtJQWlFRSxrQkFBa0I7SUFDZixRQUFRO0lBQ1IsV0FBVztJQUNYLFlBQVk7SUFDWixXQUFXO0lBQ1gsa0JBQWtCO0lBQ2xCLGlCQUFpQjtJQUNqQixlQUFlLEVBQUE7RUN0QnBCO0VEZ0NFLFlBQVk7RUFDWixXQUFXLEVBQUE7RUM5Qlg7SURnQ0MsT0FBTztJQUNQLFdBQVcsRUFBQTtFQzlCWjtJRGlDQyxVQUFVO0lBQ1YsV0FBVyxFQUFBO0VDL0JaO0lEa0NDLFlBQVk7SUFDWixVQUFVLEVBQUEiLCJmaWxlIjoic3JjL2FwcC9zaGFyZWQvbm90aWZpY2F0aW9uLXNpZGViYXIvbm90aWZpY2F0aW9uLXNpZGViYXIuY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyIjbm90aWZpY2F0aW9uLXNpZGViYXJ7XHJcblx0d2lkdGg6IDQwMHB4O1xyXG4gICAgcmlnaHQ6IC00MDBweDtcclxuXHRwYWRkaW5nOiAwO1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogI0ZGRjtcclxuXHR6LWluZGV4OiAxMDUxO1xyXG4gICAgcG9zaXRpb246IGZpeGVkO1xyXG4gICAgdG9wOiAwO1xyXG4gICAgYm90dG9tOiAwO1xyXG4gICAgaGVpZ2h0OiAxMDB2aDtcclxuICAgIHRyYW5zaXRpb246IHJpZ2h0IDAuNHMgY3ViaWMtYmV6aWVyKDAuMDUsIDAuNzQsIDAuMiwgMC45OSk7XHJcbiAgICBiYWNrZmFjZS12aXNpYmlsaXR5OiBoaWRkZW47XHJcbiAgICBib3JkZXItbGVmdDogMXB4IHNvbGlkIHJnYmEoMCwgMCwgMCwgMC4wNSk7XHJcbiAgICBib3gtc2hhZG93OiAwIDAgOHB4IHJnYmEoMCwgMCwgMCwgMC4xKTtcclxuXHJcblx0Ji5vcGVue1xyXG5cdFx0cmlnaHQ6IDA7XHJcblx0fVxyXG5cclxuXHRcclxuXHJcblx0Lm5vdGlmaWNhdGlvbi1zaWRlYmFyLWNvbnRlbnR7XHJcblx0XHRwb3NpdGlvbjogcmVsYXRpdmU7XHJcbiAgICBcdGhlaWdodDogMTAwJTtcclxuICAgIFx0cGFkZGluZzogMTBweDtcclxuXHJcbiAgICBcdCN0aW1lbGluZXtcclxuICAgIFx0XHQmLnRpbWVsaW5lLWxlZnR7XHJcbiAgICBcdFx0XHQudGltZWxpbmUtaXRlbXtcclxuICAgIFx0XHRcdFx0JjpiZWZvcmV7XHJcblx0XHRcdFx0XHRcdGJvcmRlcjpub25lO1xyXG4gICAgXHRcdFx0XHR9XHJcbiAgICBcdFx0XHRcdCY6YWZ0ZXJ7XHJcblx0XHRcdFx0XHRcdGJvcmRlcjpub25lO1xyXG4gICAgXHRcdFx0XHR9XHJcbiAgICBcdFx0XHR9XHJcbiAgICBcdFx0fVxyXG5cdFx0fVxyXG5cdFx0XHJcblx0XHQjc2V0dGluZ3N7XHJcblx0XHRcdC5zd2l0Y2h7XHJcblx0XHRcdFx0Ym9yZGVyOiBub25lO1xyXG5cdFx0XHR9XHJcblx0XHR9XHJcblxyXG5cdH1cclxuXHJcblx0YS5ub3RpZmljYXRpb24tc2lkZWJhci10b2dnbGV7XHJcblx0XHRiYWNrZ3JvdW5kOiAjRkZGO1xyXG5cdFx0Y29sb3I6dGhlbWUtY29sb3IoJ3ByaW1hcnknKTtcclxuXHRcdGRpc3BsYXk6IGJsb2NrO1xyXG4gICAgXHRib3gtc2hhZG93OiAtM3B4IDBweCA4cHggcmdiYSgwLCAwLCAwLCAwLjEpO1xyXG5cdH1cclxuXHRhLm5vdGlmaWNhdGlvbi1zaWRlYmFyLWNsb3NlIHtcclxuICAgIFx0Y29sb3I6ICMwMDA7XHJcblx0fVxyXG5cdC5ub3RpZmljYXRpb24tc2lkZWJhci1jbG9zZXtcclxuXHRcdHBvc2l0aW9uOiBhYnNvbHV0ZTtcclxuXHQgICAgcmlnaHQ6IDEwcHg7XHJcblx0ICAgIHRvcDogMTBweDtcclxuXHQgICAgcGFkZGluZzogN3B4O1xyXG5cdCAgICB3aWR0aDogYXV0bztcclxuXHQgICAgei1pbmRleDogMTA7XHJcblx0fVxyXG5cdC5ub3RpZmljYXRpb24tc2lkZWJhci10b2dnbGV7XHJcblx0XHRwb3NpdGlvbjogYWJzb2x1dGU7XHJcblx0ICAgIHRvcDogMzUlO1xyXG5cdCAgICB3aWR0aDogNTRweDtcclxuXHQgICAgaGVpZ2h0OiA1MHB4O1xyXG5cdCAgICBsZWZ0OiAtNTRweDtcclxuXHQgICAgdGV4dC1hbGlnbjogY2VudGVyO1xyXG5cdCAgICBsaW5lLWhlaWdodDogNTBweDtcclxuXHQgICAgY3Vyc29yOiBwb2ludGVyO1xyXG5cdH1cclxuXHRcclxuXHJcblx0XHJcblxyXG59XHJcblxyXG5bZGlyPVwicnRsXCJdIDpob3N0IDo6bmctZGVlcHtcclxuXHQjbm90aWZpY2F0aW9uLXNpZGViYXJ7XHRcclxuXHRcdGxlZnQ6IC00MDBweDtcdFxyXG5cdFx0cmlnaHQ6IGF1dG87XHQgICBcclxuXHRcdCYub3BlbntcclxuXHRcdFx0bGVmdDogMDtcclxuXHRcdFx0cmlnaHQ6IGF1dG87XHJcblx0XHR9XHJcblx0XHQubm90aWZpY2F0aW9uLXNpZGViYXItY2xvc2V7XHJcblx0XHRcdGxlZnQ6IDEwcHg7XHJcblx0XHRcdHJpZ2h0OiBhdXRvO1xyXG5cdFx0fVxyXG5cdFx0Lm5vdGlmaWNhdGlvbi1zaWRlYmFyLXRvZ2dsZXtcdFxyXG5cdFx0XHRyaWdodDogLTU0cHg7XHJcblx0XHRcdGxlZnQ6IGF1dG87XHJcblx0XHR9XHRcclxuXHR9XHJcbn0iLCIjbm90aWZpY2F0aW9uLXNpZGViYXIge1xuICB3aWR0aDogNDAwcHg7XG4gIHJpZ2h0OiAtNDAwcHg7XG4gIHBhZGRpbmc6IDA7XG4gIGJhY2tncm91bmQtY29sb3I6ICNGRkY7XG4gIHotaW5kZXg6IDEwNTE7XG4gIHBvc2l0aW9uOiBmaXhlZDtcbiAgdG9wOiAwO1xuICBib3R0b206IDA7XG4gIGhlaWdodDogMTAwdmg7XG4gIHRyYW5zaXRpb246IHJpZ2h0IDAuNHMgY3ViaWMtYmV6aWVyKDAuMDUsIDAuNzQsIDAuMiwgMC45OSk7XG4gIGJhY2tmYWNlLXZpc2liaWxpdHk6IGhpZGRlbjtcbiAgYm9yZGVyLWxlZnQ6IDFweCBzb2xpZCByZ2JhKDAsIDAsIDAsIDAuMDUpO1xuICBib3gtc2hhZG93OiAwIDAgOHB4IHJnYmEoMCwgMCwgMCwgMC4xKTsgfVxuICAjbm90aWZpY2F0aW9uLXNpZGViYXIub3BlbiB7XG4gICAgcmlnaHQ6IDA7IH1cbiAgI25vdGlmaWNhdGlvbi1zaWRlYmFyIC5ub3RpZmljYXRpb24tc2lkZWJhci1jb250ZW50IHtcbiAgICBwb3NpdGlvbjogcmVsYXRpdmU7XG4gICAgaGVpZ2h0OiAxMDAlO1xuICAgIHBhZGRpbmc6IDEwcHg7IH1cbiAgICAjbm90aWZpY2F0aW9uLXNpZGViYXIgLm5vdGlmaWNhdGlvbi1zaWRlYmFyLWNvbnRlbnQgI3RpbWVsaW5lLnRpbWVsaW5lLWxlZnQgLnRpbWVsaW5lLWl0ZW06YmVmb3JlIHtcbiAgICAgIGJvcmRlcjogbm9uZTsgfVxuICAgICNub3RpZmljYXRpb24tc2lkZWJhciAubm90aWZpY2F0aW9uLXNpZGViYXItY29udGVudCAjdGltZWxpbmUudGltZWxpbmUtbGVmdCAudGltZWxpbmUtaXRlbTphZnRlciB7XG4gICAgICBib3JkZXI6IG5vbmU7IH1cbiAgICAjbm90aWZpY2F0aW9uLXNpZGViYXIgLm5vdGlmaWNhdGlvbi1zaWRlYmFyLWNvbnRlbnQgI3NldHRpbmdzIC5zd2l0Y2gge1xuICAgICAgYm9yZGVyOiBub25lOyB9XG4gICNub3RpZmljYXRpb24tc2lkZWJhciBhLm5vdGlmaWNhdGlvbi1zaWRlYmFyLXRvZ2dsZSB7XG4gICAgYmFja2dyb3VuZDogI0ZGRjtcbiAgICBjb2xvcjogdGhlbWUtY29sb3IoXCJwcmltYXJ5XCIpO1xuICAgIGRpc3BsYXk6IGJsb2NrO1xuICAgIGJveC1zaGFkb3c6IC0zcHggMHB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMSk7IH1cbiAgI25vdGlmaWNhdGlvbi1zaWRlYmFyIGEubm90aWZpY2F0aW9uLXNpZGViYXItY2xvc2Uge1xuICAgIGNvbG9yOiAjMDAwOyB9XG4gICNub3RpZmljYXRpb24tc2lkZWJhciAubm90aWZpY2F0aW9uLXNpZGViYXItY2xvc2Uge1xuICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcbiAgICByaWdodDogMTBweDtcbiAgICB0b3A6IDEwcHg7XG4gICAgcGFkZGluZzogN3B4O1xuICAgIHdpZHRoOiBhdXRvO1xuICAgIHotaW5kZXg6IDEwOyB9XG4gICNub3RpZmljYXRpb24tc2lkZWJhciAubm90aWZpY2F0aW9uLXNpZGViYXItdG9nZ2xlIHtcbiAgICBwb3NpdGlvbjogYWJzb2x1dGU7XG4gICAgdG9wOiAzNSU7XG4gICAgd2lkdGg6IDU0cHg7XG4gICAgaGVpZ2h0OiA1MHB4O1xuICAgIGxlZnQ6IC01NHB4O1xuICAgIHRleHQtYWxpZ246IGNlbnRlcjtcbiAgICBsaW5lLWhlaWdodDogNTBweDtcbiAgICBjdXJzb3I6IHBvaW50ZXI7IH1cblxuW2Rpcj1cInJ0bFwiXSA6aG9zdCA6Om5nLWRlZXAgI25vdGlmaWNhdGlvbi1zaWRlYmFyIHtcbiAgbGVmdDogLTQwMHB4O1xuICByaWdodDogYXV0bzsgfVxuICBbZGlyPVwicnRsXCJdIDpob3N0IDo6bmctZGVlcCAjbm90aWZpY2F0aW9uLXNpZGViYXIub3BlbiB7XG4gICAgbGVmdDogMDtcbiAgICByaWdodDogYXV0bzsgfVxuICBbZGlyPVwicnRsXCJdIDpob3N0IDo6bmctZGVlcCAjbm90aWZpY2F0aW9uLXNpZGViYXIgLm5vdGlmaWNhdGlvbi1zaWRlYmFyLWNsb3NlIHtcbiAgICBsZWZ0OiAxMHB4O1xuICAgIHJpZ2h0OiBhdXRvOyB9XG4gIFtkaXI9XCJydGxcIl0gOmhvc3QgOjpuZy1kZWVwICNub3RpZmljYXRpb24tc2lkZWJhciAubm90aWZpY2F0aW9uLXNpZGViYXItdG9nZ2xlIHtcbiAgICByaWdodDogLTU0cHg7XG4gICAgbGVmdDogYXV0bzsgfVxuIl19 */"

/***/ }),

/***/ "./src/app/shared/notification-sidebar/notification-sidebar.component.ts":
/*!*******************************************************************************!*\
  !*** ./src/app/shared/notification-sidebar/notification-sidebar.component.ts ***!
  \*******************************************************************************/
/*! exports provided: NotificationSidebarComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NotificationSidebarComponent", function() { return NotificationSidebarComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _services_layout_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../services/layout.service */ "./src/app/shared/services/layout.service.ts");



var NotificationSidebarComponent = /** @class */ (function () {
    function NotificationSidebarComponent(elRef, renderer, layoutService) {
        var _this = this;
        this.elRef = elRef;
        this.renderer = renderer;
        this.layoutService = layoutService;
        this.isOpen = false;
        this.layoutSub = layoutService.notiSidebarChangeEmitted$.subscribe(function (value) {
            if (_this.isOpen) {
                _this.renderer.removeClass(_this.sidebar.nativeElement, 'open');
                _this.isOpen = false;
            }
            else {
                _this.renderer.addClass(_this.sidebar.nativeElement, 'open');
                _this.isOpen = true;
            }
        });
    }
    NotificationSidebarComponent.prototype.ngOnInit = function () {
    };
    NotificationSidebarComponent.prototype.ngOnDestroy = function () {
        if (this.layoutSub) {
            this.layoutSub.unsubscribe();
        }
    };
    NotificationSidebarComponent.prototype.onClose = function () {
        this.renderer.removeClass(this.sidebar.nativeElement, 'open');
        this.isOpen = false;
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('sidebar'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], NotificationSidebarComponent.prototype, "sidebar", void 0);
    NotificationSidebarComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-notification-sidebar',
            template: __webpack_require__(/*! ./notification-sidebar.component.html */ "./src/app/shared/notification-sidebar/notification-sidebar.component.html"),
            styles: [__webpack_require__(/*! ./notification-sidebar.component.scss */ "./src/app/shared/notification-sidebar/notification-sidebar.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["Renderer2"],
            _services_layout_service__WEBPACK_IMPORTED_MODULE_2__["LayoutService"]])
    ], NotificationSidebarComponent);
    return NotificationSidebarComponent;
}());



/***/ }),

/***/ "./src/app/shared/routes/content-layout.routes.ts":
/*!********************************************************!*\
  !*** ./src/app/shared/routes/content-layout.routes.ts ***!
  \********************************************************/
/*! exports provided: CONTENT_ROUTES */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CONTENT_ROUTES", function() { return CONTENT_ROUTES; });
//Route for content layout without sidebar, navbar and footer for pages like Login, Registration etc...
var CONTENT_ROUTES = [
    {
        path: 'pages',
        loadChildren: './pages/content-pages/content-pages.module#ContentPagesModule'
    }
];


/***/ }),

/***/ "./src/app/shared/routes/full-layout.routes.ts":
/*!*****************************************************!*\
  !*** ./src/app/shared/routes/full-layout.routes.ts ***!
  \*****************************************************/
/*! exports provided: Full_ROUTES */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Full_ROUTES", function() { return Full_ROUTES; });
// Route for content layout with sidebar, navbar and footer.
var Full_ROUTES = [
    {
        path: 'dashboard',
        loadChildren: './dashboard/dashboard.module#DashboardModule'
    },
    {
        path: 'pages',
        loadChildren: './pages/full-pages/full-pages.module#FullPagesModule'
    },
    {
        path: 'admin',
        loadChildren: './admin/admin.module#AdminModule'
    },
    {
        path: 'support',
        loadChildren: './support/support.module#SupportModule'
    },
    {
        path: 'project',
        loadChildren: './project/project.module#ProjectModule'
    },
    {
        path: 'resources',
        loadChildren: './resources/resources.module#ResourcesModule'
    },
    {
        path: 'myprojects',
        loadChildren: './myprojects/myprojects.module#MyprojectsModule'
    },
    {
        path: 'chat',
        loadChildren: './chat/chat.module#ChatModule'
    },
    {
        path: 'inbox',
        loadChildren: './inbox/inbox.module#InboxModule'
    },
    {
        path: 'timesheets',
        loadChildren: './timesheets/timesheets.module#TimesheetsModule'
    },
];


/***/ }),

/***/ "./src/app/shared/services/config.service.ts":
/*!***************************************************!*\
  !*** ./src/app/shared/services/config.service.ts ***!
  \***************************************************/
/*! exports provided: ConfigService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ConfigService", function() { return ConfigService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ConfigService = /** @class */ (function () {
    function ConfigService() {
        this.setConfigValue();
    }
    ConfigService.prototype.setConfigValue = function () {
        this.templateConf = {
            layout: {
                variant: 'Light',
                dir: 'ltr',
                customizer: {
                    hidden: true // options: true, false
                },
                sidebar: {
                    collapsed: false,
                    size: 'sidebar-md',
                    backgroundColor: 'white',
                    // 'flickr', 'purple-bliss', 'man-of-steel', 'purple-love'
                    /* If you want transparent layout add any of the following mentioned classes to backgroundColor of sidebar option :
                      bg-glass-1, bg-glass-2, bg-glass-3, bg-glass-4, bg-hibiscus, bg-purple-pizzaz,
                      bg-blue-lagoon, bg-electric-viloet, bg-protage, bg-tundora
                    */
                    backgroundImage: true,
                    backgroundImageURL: 'assets/img/sidebar-bg/04.jpg'
                }
            }
        };
    };
    ConfigService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ConfigService);
    return ConfigService;
}());



/***/ }),

/***/ "./src/app/shared/services/layout.service.ts":
/*!***************************************************!*\
  !*** ./src/app/shared/services/layout.service.ts ***!
  \***************************************************/
/*! exports provided: LayoutService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "LayoutService", function() { return LayoutService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");



var LayoutService = /** @class */ (function () {
    function LayoutService() {
        this.emitChangeSource = new rxjs__WEBPACK_IMPORTED_MODULE_2__["Subject"]();
        this.changeEmitted$ = this.emitChangeSource.asObservable();
        //Customizer
        this.emitCustomizerSource = new rxjs__WEBPACK_IMPORTED_MODULE_2__["Subject"]();
        this.customizerChangeEmitted$ = this.emitCustomizerSource.asObservable();
        //customizer - compact menu
        this.emitCustomizerCMSource = new rxjs__WEBPACK_IMPORTED_MODULE_2__["Subject"]();
        this.customizerCMChangeEmitted$ = this.emitCustomizerCMSource.asObservable();
        //customizer - compact menu
        this.emitNotiSidebarSource = new rxjs__WEBPACK_IMPORTED_MODULE_2__["Subject"]();
        this.notiSidebarChangeEmitted$ = this.emitNotiSidebarSource.asObservable();
    }
    LayoutService.prototype.emitChange = function (change) {
        this.emitChangeSource.next(change);
    };
    LayoutService.prototype.emitCustomizerChange = function (change) {
        this.emitCustomizerSource.next(change);
    };
    LayoutService.prototype.emitCustomizerCMChange = function (change) {
        this.emitCustomizerCMSource.next(change);
    };
    LayoutService.prototype.emitNotiSidebarChange = function (change) {
        this.emitNotiSidebarSource.next(change);
    };
    LayoutService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
            providedIn: 'root'
        })
    ], LayoutService);
    return LayoutService;
}());



/***/ }),

/***/ "./src/app/shared/shared.module.ts":
/*!*****************************************!*\
  !*** ./src/app/shared/shared.module.ts ***!
  \*****************************************/
/*! exports provided: SharedModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SharedModule", function() { return SharedModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var angular_datatables__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! angular-datatables */ "./node_modules/angular-datatables/index.js");
/* harmony import */ var angular_6_datatable__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! angular-6-datatable */ "./node_modules/angular-6-datatable/index.js");
/* harmony import */ var angular_6_datatable__WEBPACK_IMPORTED_MODULE_6___default = /*#__PURE__*/__webpack_require__.n(angular_6_datatable__WEBPACK_IMPORTED_MODULE_6__);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm5/ngx-translate-core.js");
/* harmony import */ var ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ngx-perfect-scrollbar */ "./node_modules/ngx-perfect-scrollbar/dist/ngx-perfect-scrollbar.es5.js");
/* harmony import */ var _footer_footer_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./footer/footer.component */ "./src/app/shared/footer/footer.component.ts");
/* harmony import */ var _navbar_navbar_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./navbar/navbar.component */ "./src/app/shared/navbar/navbar.component.ts");
/* harmony import */ var _sidebar_sidebar_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./sidebar/sidebar.component */ "./src/app/shared/sidebar/sidebar.component.ts");
/* harmony import */ var _customizer_customizer_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./customizer/customizer.component */ "./src/app/shared/customizer/customizer.component.ts");
/* harmony import */ var _notification_sidebar_notification_sidebar_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./notification-sidebar/notification-sidebar.component */ "./src/app/shared/notification-sidebar/notification-sidebar.component.ts");
/* harmony import */ var _directives_toggle_fullscreen_directive__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./directives/toggle-fullscreen.directive */ "./src/app/shared/directives/toggle-fullscreen.directive.ts");
/* harmony import */ var _directives_sidebar_directive__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./directives/sidebar.directive */ "./src/app/shared/directives/sidebar.directive.ts");
/* harmony import */ var _directives_sidebarlink_directive__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./directives/sidebarlink.directive */ "./src/app/shared/directives/sidebarlink.directive.ts");
/* harmony import */ var _directives_sidebarlist_directive__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./directives/sidebarlist.directive */ "./src/app/shared/directives/sidebarlist.directive.ts");
/* harmony import */ var _directives_sidebaranchortoggle_directive__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./directives/sidebaranchortoggle.directive */ "./src/app/shared/directives/sidebaranchortoggle.directive.ts");
/* harmony import */ var _directives_sidebartoggle_directive__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./directives/sidebartoggle.directive */ "./src/app/shared/directives/sidebartoggle.directive.ts");
/* harmony import */ var app_app_fl__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! app/app.fl */ "./src/app/app.fl.ts");










// COMPONENTS





// DIRECTIVES







var SharedModule = /** @class */ (function () {
    function SharedModule() {
    }
    SharedModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            exports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_3__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_1__["FormsModule"],
                _footer_footer_component__WEBPACK_IMPORTED_MODULE_10__["FooterComponent"],
                _navbar_navbar_component__WEBPACK_IMPORTED_MODULE_11__["NavbarComponent"],
                _sidebar_sidebar_component__WEBPACK_IMPORTED_MODULE_12__["SidebarComponent"],
                _customizer_customizer_component__WEBPACK_IMPORTED_MODULE_13__["CustomizerComponent"],
                angular_datatables__WEBPACK_IMPORTED_MODULE_5__["DataTablesModule"],
                angular_6_datatable__WEBPACK_IMPORTED_MODULE_6__["DataTableModule"],
                _notification_sidebar_notification_sidebar_component__WEBPACK_IMPORTED_MODULE_14__["NotificationSidebarComponent"],
                _directives_toggle_fullscreen_directive__WEBPACK_IMPORTED_MODULE_15__["ToggleFullscreenDirective"],
                _directives_sidebar_directive__WEBPACK_IMPORTED_MODULE_16__["SidebarDirective"],
                _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_7__["NgbModule"],
                app_app_fl__WEBPACK_IMPORTED_MODULE_21__["FlPipe"],
                _ngx_translate_core__WEBPACK_IMPORTED_MODULE_8__["TranslateModule"]
            ],
            imports: [
                _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"],
                _angular_common__WEBPACK_IMPORTED_MODULE_3__["CommonModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_1__["FormsModule"],
                _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_7__["NgbModule"],
                angular_datatables__WEBPACK_IMPORTED_MODULE_5__["DataTablesModule"],
                angular_6_datatable__WEBPACK_IMPORTED_MODULE_6__["DataTableModule"],
                _ngx_translate_core__WEBPACK_IMPORTED_MODULE_8__["TranslateModule"],
                ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_9__["PerfectScrollbarModule"]
            ],
            declarations: [
                app_app_fl__WEBPACK_IMPORTED_MODULE_21__["FlPipe"],
                _footer_footer_component__WEBPACK_IMPORTED_MODULE_10__["FooterComponent"],
                _navbar_navbar_component__WEBPACK_IMPORTED_MODULE_11__["NavbarComponent"],
                _sidebar_sidebar_component__WEBPACK_IMPORTED_MODULE_12__["SidebarComponent"],
                _customizer_customizer_component__WEBPACK_IMPORTED_MODULE_13__["CustomizerComponent"],
                _notification_sidebar_notification_sidebar_component__WEBPACK_IMPORTED_MODULE_14__["NotificationSidebarComponent"],
                _directives_toggle_fullscreen_directive__WEBPACK_IMPORTED_MODULE_15__["ToggleFullscreenDirective"],
                _directives_sidebar_directive__WEBPACK_IMPORTED_MODULE_16__["SidebarDirective"],
                _directives_sidebarlink_directive__WEBPACK_IMPORTED_MODULE_17__["SidebarLinkDirective"],
                _directives_sidebarlist_directive__WEBPACK_IMPORTED_MODULE_18__["SidebarListDirective"],
                _directives_sidebaranchortoggle_directive__WEBPACK_IMPORTED_MODULE_19__["SidebarAnchorToggleDirective"],
                _directives_sidebartoggle_directive__WEBPACK_IMPORTED_MODULE_20__["SidebarToggleDirective"]
            ]
        })
    ], SharedModule);
    return SharedModule;
}());



/***/ }),

/***/ "./src/app/shared/sidebar/sidebar-routes.config.ts":
/*!*********************************************************!*\
  !*** ./src/app/shared/sidebar/sidebar-routes.config.ts ***!
  \*********************************************************/
/*! exports provided: ROUTES */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ROUTES", function() { return ROUTES; });
//Sidebar menu Routes and data
var ROUTES = [
    // {
    //     path: '', title: 'Dashboard', icon: 'ft-home', class: 'has-sub', badge: '2', badgeClass: 'badge badge-pill badge-danger float-right mr-1 mt-1', isExternalLink: false, submenu: [
    //         { path: '/dashboard/dashboard1', title: 'Dashboard1', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //         { path: '/dashboard/dashboard2', title: 'Dashboard2', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    //     ]
    // },
    { path: '/myprojects/myprojects', title: 'My projects', icon: 'ft-home', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '', title: 'Resource Pool', icon: 'ft-droplet', class: 'has-sub', badge: '', badgeClass: '', isExternalLink: false,
        submenu: [
            { path: '/resources/dashboard', title: 'Dashboard', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            { path: '/resources/resources', title: 'Resources', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            { path: '/resources/demand', title: 'Demand', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            { path: '/resources/availability', title: 'Availability', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            { path: '/resources/utilization', title: 'Utilization', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
        ] },
    { path: '/timesheets', title: 'My timesheets', icon: 'ft-droplet', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '/project', title: 'Project', icon: 'ft-droplet', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    // { path: '/colorpalettes', title: 'Color Palette', icon: 'ft-droplet', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '/inbox', title: 'Inbox', icon: 'ft-mail', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '/chat', title: 'Chat', icon: 'ft-message-square', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    { path: '/support', title: '"How to" guide', icon: 'ft-message-square', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
    {
        path: '', title: 'Admin', icon: 'ft-copy', class: 'has-sub', badge: '', badgeClass: '', isExternalLink: false,
        submenu: [
            { path: '/admin/hierarchy', title: 'Project Hierarchy', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            { path: '/admin/resource', title: 'Resource Centre', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
            { path: '/admin/uploadcentre', title: 'Upload Centre', icon: '', class: '', badge: '', badgeClass: '', isExternalLink: false, submenu: [] },
        ]
    },
];


/***/ }),

/***/ "./src/app/shared/sidebar/sidebar.component.html":
/*!*******************************************************!*\
  !*** ./src/app/shared/sidebar/sidebar.component.html ***!
  \*******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!-- Sidebar Header starts -->\r\n<div class=\"sidebar-header\">\r\n    <div class=\"logo clearfix\">\r\n        <a [routerLink]=\"['/']\" class=\"logo-text float-left\">\r\n            <div class=\"logo-img\">\r\n                <img [src]=\"logoUrl\" />\r\n            </div>\r\n            <span class=\"text align-middle\">PMO</span>\r\n        </a>\r\n        <a class=\"nav-toggle d-none d-sm-none d-md-none d-lg-block\" id=\"sidebarToggle\" href=\"javascript:;\">\r\n            <i #toggleIcon appSidebarToggle class=\"ft-toggle-right toggle-icon\" data-toggle=\"expanded\"></i>\r\n        </a>\r\n        <a class=\"nav-close d-block d-md-block d-lg-none d-xl-none\" id=\"sidebarClose\" href=\"javascript:;\">\r\n            <i class=\"ft-x\"></i>\r\n        </a>\r\n    </div>\r\n</div>\r\n<!-- Sidebar Header Ends -->\r\n\r\n<!-- Sidebar Content starts -->\r\n<div class=\"sidebar-content\"  [perfectScrollbar]>\r\n    <div class=\"nav-container\">\r\n        <ul class=\"navigation\" appSidebarList>\r\n            <!-- First level menu -->\r\n             <li appSidebarlink level=\"{{depth + 1}}\" (toggleEmit)=\"handleToggle($event)\" (click)=\"toggleSlideInOut()\" [routePath]=\"menuItem.path\" [classes]=\"menuItem.class\" [title]=\"menuItem.title\"  [parent]=\"\" *ngFor=\"let menuItem of menuItems\"   [ngClass]=\"{'has-sub': menuItem.class === 'has-sub' ? true: false, 'open': activeTitles.includes(menuItem.title) && !nav_collapsed_open ? true : false, 'nav-collapsed-open': nav_collapsed_open && activeTitles.includes(menuItem.title)}\" [routerLinkActive]=\"menuItem.submenu.length != 0 ? '' : 'active'\"\r\n                [routerLinkActiveOptions]=\"{exact: true}\">\r\n                <a appSidebarAnchorToggle [routerLink]=\"menuItem.class === '' ? [menuItem.path] : null\" *ngIf=\"!menuItem.isExternalLink; else externalLinkBlock\">\r\n                    <i [ngClass]=\"[menuItem.icon]\"></i>\r\n                    <span class=\"menu-title\">{{menuItem.title | translate }}</span>\r\n                    <span *ngIf=\"menuItem.badge != '' \" [ngClass]=\"[menuItem.badgeClass]\">{{menuItem.badge}}</span>\r\n                </a>\r\n                <ng-template #externalLinkBlock>\r\n                    <a [href]=\"[menuItem.path]\" target=\"_blank\">\r\n                        <i [ngClass]=\"[menuItem.icon]\"></i>\r\n                        <span class=\"menu-title\">{{menuItem.title | translate }}</span>\r\n                        <span *ngIf=\"menuItem.badge != '' \" [ngClass]=\"[menuItem.badgeClass]\">{{menuItem.badge}}</span>\r\n                    </a>\r\n                </ng-template>\r\n                <!-- Second level menu -->\r\n                <ul class=\"menu-content\" *ngIf=\"menuItem.submenu.length > 0\" [@slideInOut]=\"activeTitles.includes(menuItem.title) ? true : false\">\r\n                    <li appSidebarlink level=\"{{depth + 2}}\" (toggleEmit)=\"handleToggle($event)\" [routePath]=\"menuSubItem.path\" [classes]=\"menuSubItem.class\" [title]=\"menuSubItem.title\" [parent]=\"menuItem.title\" *ngFor=\"let menuSubItem of menuItem.submenu\" [routerLinkActive]=\"menuSubItem.submenu.length > 0 ? '' : 'active'\" [ngClass]=\"{'has-sub': menuSubItem.class === 'has-sub' ? true: false, 'open': activeTitles.includes(menuSubItem.title) && !nav_collapsed_open ? true : false, 'nav-collapsed-open': nav_collapsed_open && activeTitles.includes(menuSubItem.title)}\">\r\n                        <a appSidebarAnchorToggle [routerLink]=\"menuSubItem.submenu.length > 0 ? null : [menuSubItem.path]\" *ngIf=\"!menuSubItem.isExternalLink; else externalSubLinkBlock\">\r\n                            <i [ngClass]=\"[menuSubItem.icon]\"></i>\r\n                            <span class=\"menu-title\">{{menuSubItem.title | translate }}</span>\r\n                            <span *ngIf=\"menuSubItem.badge != '' \" [ngClass]=\"[menuSubItem.badgeClass]\">{{menuSubItem.badge}}</span>\r\n                        </a>\r\n                        <ng-template #externalSubLinkBlock>\r\n                            <a [href]=\"[menuSubItem.path]\">\r\n                                <i [ngClass]=\"[menuSubItem.icon]\"></i>\r\n                                <span class=\"menu-title\">{{menuSubItem.title | translate }}</span>\r\n                                <span *ngIf=\"menuSubItem.badge != '' \" [ngClass]=\"[menuSubItem.badgeClass]\">{{menuSubItem.badge}}</span>\r\n                            </a>\r\n                        </ng-template>\r\n                        <!-- Third level menu -->\r\n                        <ul class=\"menu-content\" *ngIf=\"menuSubItem.submenu.length > 0\" [@slideInOut]=\"activeTitles.includes(menuSubItem.title) ? true : false\">\r\n                            <li appSidebarlink level=\"{{depth + 3}}\" [routePath]=\"menuSubsubItem.path\" [classes]=\"menuSubsubItem.class\" [title]=\"menuSubsubItem.title\" [parent]=\"menuSubItem.title\" *ngFor=\"let menuSubsubItem of menuSubItem.submenu\" routerLinkActive=\"active\" [routerLinkActiveOptions]=\"{exact: true}\"\r\n                                [ngClass]=\"[menuSubsubItem.class]\">\r\n                                <a appSidebarAnchorToggle [routerLink]=\"[menuSubsubItem.path]\" *ngIf=\"!menuSubsubItem.isExternalLink; else externalSubSubLinkBlock\">\r\n                                    <i [ngClass]=\"[menuSubsubItem.icon]\"></i>\r\n                                    <span class=\"menu-title\">{{menuSubsubItem.title | translate }}</span>\r\n                                    <span *ngIf=\"menuSubsubItem.badge != '' \" [ngClass]=\"[menuSubsubItem.badgeClass]\">{{menuSubsubItem.badge}}</span>\r\n                                </a>\r\n                                <ng-template #externalSubSubLinkBlock>\r\n                                    <a [href]=\"[menuSubsubItem.path]\">\r\n                                        <i [ngClass]=\"[menuSubsubItem.icon]\"></i>\r\n                                        <span class=\"menu-title\">{{menuSubsubItem.title | translate }}</span>\r\n                                        <span *ngIf=\"menuSubsubItem.badge != '' \" [ngClass]=\"[menuSubsubItem.badgeClass]\">{{menuSubsubItem.badge}}</span>\r\n                                    </a>\r\n                                </ng-template>\r\n                            </li>\r\n                        </ul>\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<!-- Sidebar Content Ends -->\r\n"

/***/ }),

/***/ "./src/app/shared/sidebar/sidebar.component.ts":
/*!*****************************************************!*\
  !*** ./src/app/shared/sidebar/sidebar.component.ts ***!
  \*****************************************************/
/*! exports provided: SidebarComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SidebarComponent", function() { return SidebarComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _sidebar_routes_config__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./sidebar-routes.config */ "./src/app/shared/sidebar/sidebar-routes.config.ts");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _ngx_translate_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ngx-translate/core */ "./node_modules/@ngx-translate/core/fesm5/ngx-translate-core.js");
/* harmony import */ var _animations_custom_animations__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../animations/custom-animations */ "./src/app/shared/animations/custom-animations.ts");
/* harmony import */ var _services_config_service__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../services/config.service */ "./src/app/shared/services/config.service.ts");
/* harmony import */ var _services_layout_service__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../services/layout.service */ "./src/app/shared/services/layout.service.ts");








var SidebarComponent = /** @class */ (function () {
    function SidebarComponent(elementRef, renderer, router, route, translate, configService, layoutService) {
        var _this = this;
        this.elementRef = elementRef;
        this.renderer = renderer;
        this.router = router;
        this.route = route;
        this.translate = translate;
        this.configService = configService;
        this.layoutService = layoutService;
        this.activeTitles = [];
        this.nav_collapsed_open = false;
        this.logoUrl = 'assets/img/logo.png';
        this.config = {};
        if (this.depth === undefined) {
            this.depth = 0;
            this.expanded = true;
        }
        this.layoutSub = layoutService.customizerChangeEmitted$.subscribe(function (options) {
            if (options) {
                if (options.bgColor) {
                    if (options.bgColor === 'white') {
                        _this.logoUrl = 'assets/img/logo-dark.png';
                    }
                    else {
                        _this.logoUrl = 'assets/img/logo.png';
                    }
                }
                if (options.compactMenu === true) {
                    _this.expanded = false;
                    _this.renderer.addClass(_this.toggleIcon.nativeElement, 'ft-toggle-left');
                    _this.renderer.removeClass(_this.toggleIcon.nativeElement, 'ft-toggle-right');
                    _this.nav_collapsed_open = true;
                }
                else if (options.compactMenu === false) {
                    _this.expanded = true;
                    _this.renderer.removeClass(_this.toggleIcon.nativeElement, 'ft-toggle-left');
                    _this.renderer.addClass(_this.toggleIcon.nativeElement, 'ft-toggle-right');
                    _this.nav_collapsed_open = false;
                }
            }
        });
    }
    SidebarComponent.prototype.ngOnInit = function () {
        this.config = this.configService.templateConf;
        this.menuItems = _sidebar_routes_config__WEBPACK_IMPORTED_MODULE_2__["ROUTES"];
        if (this.config.layout.sidebar.backgroundColor === 'white') {
            this.logoUrl = 'assets/img/logo-dark.png';
        }
        else {
            this.logoUrl = 'assets/img/logo.png';
        }
    };
    SidebarComponent.prototype.ngAfterViewInit = function () {
        var _this = this;
        setTimeout(function () {
            if (_this.config.layout.sidebar.collapsed != undefined) {
                if (_this.config.layout.sidebar.collapsed === true) {
                    _this.expanded = false;
                    _this.renderer.addClass(_this.toggleIcon.nativeElement, 'ft-toggle-left');
                    _this.renderer.removeClass(_this.toggleIcon.nativeElement, 'ft-toggle-right');
                    _this.nav_collapsed_open = true;
                }
                else if (_this.config.layout.sidebar.collapsed === false) {
                    _this.expanded = true;
                    _this.renderer.removeClass(_this.toggleIcon.nativeElement, 'ft-toggle-left');
                    _this.renderer.addClass(_this.toggleIcon.nativeElement, 'ft-toggle-right');
                    _this.nav_collapsed_open = false;
                }
            }
        }, 0);
    };
    SidebarComponent.prototype.ngOnDestroy = function () {
        if (this.layoutSub) {
            this.layoutSub.unsubscribe();
        }
    };
    SidebarComponent.prototype.toggleSlideInOut = function () {
        this.expanded = !this.expanded;
    };
    SidebarComponent.prototype.handleToggle = function (titles) {
        this.activeTitles = titles;
    };
    // NGX Wizard - skip url change
    SidebarComponent.prototype.ngxWizardFunction = function (path) {
        if (path.indexOf("forms/ngx") !== -1)
            this.router.navigate(["forms/ngx/wizard"], { skipLocationChange: false });
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('toggleIcon'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], SidebarComponent.prototype, "toggleIcon", void 0);
    SidebarComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: "app-sidebar",
            template: __webpack_require__(/*! ./sidebar.component.html */ "./src/app/shared/sidebar/sidebar.component.html"),
            animations: _animations_custom_animations__WEBPACK_IMPORTED_MODULE_5__["customAnimations"]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"],
            _angular_core__WEBPACK_IMPORTED_MODULE_1__["Renderer2"],
            _angular_router__WEBPACK_IMPORTED_MODULE_3__["Router"],
            _angular_router__WEBPACK_IMPORTED_MODULE_3__["ActivatedRoute"],
            _ngx_translate_core__WEBPACK_IMPORTED_MODULE_4__["TranslateService"],
            _services_config_service__WEBPACK_IMPORTED_MODULE_6__["ConfigService"],
            _services_layout_service__WEBPACK_IMPORTED_MODULE_7__["LayoutService"]])
    ], SidebarComponent);
    return SidebarComponent;
}());



/***/ }),

/***/ "./src/environments/environment.ts":
/*!*****************************************!*\
  !*** ./src/environments/environment.ts ***!
  \*****************************************/
/*! exports provided: environment */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function() { return environment; });
// The file contents for the current environment will overwrite these during build.
// The build system defaults to the dev environment which uses `environment.ts`, but if you do
// `ng build --env=prod` then `environment.prod.ts` will be used instead.
// The list of which env maps to which file can be found in `.angular-cli.json`.
var environment = {
    production: false,
    baseurl: 'http://localhost:53956/api',
    // baseurl: 'https://ptapi20190613040346.azurewebsites.net',
    defaultimageUrl: '/assets/images/users/defaultprofileimage.png',
    AccountOwner: 'AccountOwner',
    ResourceOnly: 'ResourceOnly',
    SuperAdmin: 'SuperAdmin',
    Admin: 'Admin',
    ProjectManager: 'ProjectManager',
    SeniorProjectManager: 'SeniorProjectManager',
    PortfolioAdmin: 'PortfolioAdmin',
    FinanceAdmin: 'FinanceAdmin',
    FinanceManager: 'FinanceManager',
    ReadOnly: 'ReadOnly',
    ReadWriteTimesheetOnly: 'ReadWriteTimesheetOnly',
};


/***/ }),

/***/ "./src/main.ts":
/*!*********************!*\
  !*** ./src/main.ts ***!
  \*********************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm5/platform-browser-dynamic.js");
/* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
/* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");




if (_environments_environment__WEBPACK_IMPORTED_MODULE_3__["environment"].production) {
    Object(_angular_core__WEBPACK_IMPORTED_MODULE_0__["enableProdMode"])();
}
Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_1__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_2__["AppModule"]);


/***/ }),

/***/ 0:
/*!***************************!*\
  !*** multi ./src/main.ts ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! C:\Users\Ndiananie\Git\ProjectUpdates\PTAngular\projectupdatesfrontend\src\main.ts */"./src/main.ts");


/***/ })

},[[0,"runtime","vendor"]]]);
//# sourceMappingURL=main.js.map