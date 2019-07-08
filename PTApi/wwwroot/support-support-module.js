(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["support-support-module"],{

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



/***/ }),

/***/ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.html":
/*!****************************************************************************************!*\
  !*** ./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.html ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <h1 class=\"card-title m-1 pl-2 pull-left mb-2 text-muted text-primary\">\"How to\" guide</h1>\r\n</div>\r\n  <!-- Apex template Knowledge Base starts -->\r\n  <section id=\"kb\">\r\n    <div class=\"row\">\r\n      <div class=\"col-xl-4 col-lg-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n            <i class=\"ft-bell font-large-1 float-left mr-2\"></i>\r\n            <h4 class=\"card-title mb-0\">Getting Started</h4>\r\n            <p class=\"card-text\">Vestibulum consequat odio sit amet eros.</p>\r\n          </div>\r\n          <div class=\"card-content\">\r\n            <div class=\"card-body\">\r\n              <ul class=\"list-group\">\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Activating an Account and Logging in')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Activating an Account and Logging in\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'User Profile')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> User Profile\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Using the Dashboard')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Using the Dashboard\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Subscribing to Email Alerts')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Subscribing to Email Alerts\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Changing a Password')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Changing a Password\r\n                </li>\r\n              </ul>\r\n            </div>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <a class=\"card-link primary\">See all articles (20)</a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-xl-4 col-lg-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n            <i class=\"ft-book font-large-1 float-left mr-2\"></i>\r\n            <h4 class=\"card-title\">User Guides</h4>\r\n            <p class=\"card-text\">Vestibulum consequat odio sit amet eros.</p>\r\n          </div>\r\n          <div class=\"card-content\">\r\n            <div class=\"card-body\">\r\n              <ul class=\"list-group\">\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Files Overview')\">\r\n                  <span class=\"badge bg-warning float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Files Overview\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Search Overview')\">\r\n                  <span class=\"badge bg-warning float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Search Overview\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Using Tasks')\">\r\n                  <span class=\"badge bg-warning float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Using Tasks\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Events')\">\r\n                  <span class=\"badge bg-warning float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Events\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Blogs')\">\r\n                  <span class=\"badge bg-warning float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Blogs\r\n                </li>\r\n              </ul>\r\n            </div>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <a class=\"card-link primary\">See all articles (13)</a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-xl-4 col-lg-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n            <i class=\"ft-file-text text-white font-large-1 float-left mr-2\"></i>\r\n            <h4 class=\"card-title\">Files</h4>\r\n            <p class=\"card-text\">Vestibulum consequat odio sit amet eros.</p>\r\n          </div>\r\n          <div class=\"card-content\">\r\n            <div class=\"card-body\">\r\n              <ul class=\"list-group\">\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Basic Files Module Features')\">\r\n                  <span class=\"badge bg-info float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Basic Files Module Features\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'How to Add a Single File')\">\r\n                  <span class=\"badge bg-info float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> How to Add a Single File\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Drag-and-Drop upload files and folders')\">\r\n                  <span class=\"badge bg-info float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Drag-and-Drop upload files and folders\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Searching Files')\">\r\n                  <span class=\"badge bg-info float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Searching Files\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Digital Rights Management')\">\r\n                  <span class=\"badge bg-info float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Digital Rights Management\r\n                </li>\r\n              </ul>\r\n            </div>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <a class=\"card-link primary\">See all articles (7)</a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"row\">\r\n      <div class=\"col-xl-4 col-lg-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n            <i class=\"ft-user font-large-1 float-left mr-2\"></i>\r\n            <h4 class=\"card-title\">Managing Users</h4>\r\n            <p class=\"card-text\">Vestibulum consequat odio sit amet eros.</p>\r\n          </div>\r\n          <div class=\"card-content\">\r\n            <div class=\"card-body\">\r\n              <ul class=\"list-group\">\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Inviting and Managing Users')\">\r\n                  <span class=\"badge bg-success float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Inviting and Managing Users\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Creating and Managing Groups')\">\r\n                  <span class=\"badge bg-success float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Creating and Managing Groups\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Granting Roles')\">\r\n                  <span class=\"badge bg-success float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Granting Roles\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Quick Guide: Organizing Security Groups')\">\r\n                  <span class=\"badge bg-success float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Quick Guide: Organizing Security Groups\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'What to Do if a User is Unable to Login')\">\r\n                  <span class=\"badge bg-success float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> What to Do if a User is Unable to Login\r\n                </li>\r\n              </ul>\r\n            </div>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <a class=\"card-link primary\">See all articles (11)</a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-xl-4 col-lg-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n            <i class=\"ft-unlock font-large-1 float-left mr-2\"></i>\r\n            <h4 class=\"card-title\">Site Administration</h4>\r\n            <p class=\"card-text\">Vestibulum consequat odio sit amet eros.</p>\r\n          </div>\r\n          <div class=\"card-content\">\r\n            <div class=\"card-body\">\r\n              <ul class=\"list-group\">\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Introduction to the Site Admin Module')\">\r\n                  <span class=\"badge bg-danger float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Introduction to the Site Admin Module\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'How to Create a Virtual Deal Room')\">\r\n                  <span class=\"badge bg-danger float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> How to Create a Virtual Deal Room\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Best Practices for Setting up a New Site')\">\r\n                  <span class=\"badge bg-danger float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Best Practices for Setting up a New Site\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'General Settings')\">\r\n                  <span class=\"badge bg-danger float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> General Settings\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Advanced Settings')\">\r\n                  <span class=\"badge bg-danger float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Advanced Settings\r\n                </li>\r\n              </ul>\r\n            </div>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <a class=\"card-link primary\">See all articles (21)</a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n      <div class=\"col-xl-4 col-lg-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n            <i class=\"ft-airplay font-large-1 float-left mr-2\"></i>\r\n            <h4 class=\"card-title\">System Administration</h4>\r\n            <p class=\"card-text\">Vestibulum consequat odio sit amet eros.</p>\r\n          </div>\r\n          <div class=\"card-content\">\r\n            <div class=\"card-body\">\r\n              <ul class=\"list-group\">\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'System Administration Overview')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> System Administration Overview\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Creating Sites')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Creating Sites\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'User Administration')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> User Administration\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Org Administration')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Org Administration\r\n                </li>\r\n                <li class=\"list-group-item cursor-pointer\" (click)=\"GetDetails(content, 'Site Category System Settings')\">\r\n                  <span class=\"badge bg-primary float-left mr-2\">\r\n                    <i class=\"ft-file-text text-white\"></i>\r\n                  </span> Site Category System Settings\r\n                </li>\r\n              </ul>\r\n            </div>\r\n          </div>\r\n          <div class=\"card-footer\">\r\n            <a class=\"card-link primary\">See all articles (17)</a>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <!-- Apex template Knowledge Base Ends -->\r\n\r\n    <ng-template #content let-c=\"close\" let-d=\"dismiss\">\r\n      <div class=\"modal-header bg-info\">\r\n        <h4 class=\"modal-title white\">{{title}}</h4>\r\n        <button type=\"button\" class=\"close white\" aria-label=\"Close\" (click)=\"d('Cross click')\">\r\n          <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n      </div>\r\n      <div class=\"modal-body\" id=\"kbModal-body\">\r\n        <p class=\"text-bold-500\">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>\r\n        <p>Curabitur et congue orci. Nullam tempor, lectus vitae facilisis consectetur, enim dolor sodales nunc, ut\r\n          venenatis\r\n          ipsum massa non eros. Integer tristique consequat sagittis. Sed vitae sapien lobortis, viverra turpis non,\r\n          hendrerit\r\n          erat. Vivamus luctus, nisl et dignissim pretium, quam risus sollicitudin augue, ut mollis erat neque a lectus.\r\n          Donec\r\n          et ex vitae orci pretium volutpat eget sed est. Nunc ornare mauris nunc, id ullamcorper libero finibus id.\r\n          Fusce\r\n          imperdiet laoreet suscipit. Nunc sagittis arcu non sem euismod auctor. Sed tellus odio, posuere id molestie\r\n          quis,\r\n          egestas sit amet turpis. Duis velit diam, dictum a semper eu, ultricies id neque. Integer nec eros placerat\r\n          lacus\r\n          bibendum viverra in eu urna.</p>\r\n        <p class=\"text-bold-500\">Suspendisse auctor nisl interdum arcu blandit, sed aliquam leo volutpat.</p>\r\n        <p>Donec laoreet in nibh vel maximus. Donec posuere aliquam lacus a congue. Interdum et malesuada fames ac ante\r\n          ipsum\r\n          primis in faucibus. Aenean semper fringilla arcu, non auctor ante. Ut efficitur euismod scelerisque. Cras\r\n          accumsan\r\n          orci rhoncus elementum auctor. Phasellus maximus volutpat nunc ut tincidunt. Lorem ipsum dolor sit amet,\r\n          consectetur\r\n          adipiscing elit. Pellentesque aliquet tincidunt neque, et volutpat est dictum non. Nulla hendrerit leo sit amet\r\n          nisl\r\n          blandit, quis pharetra lacus ultrices. Etiam pretium ipsum eu dui consectetur maximus. Vivamus pretium luctus\r\n          lorem,\r\n          eu viverra velit malesuada at. Nam risus orci, gravida ut convallis et, cursus id velit.</p>\r\n        <p class=\"text-bold-500\"> Phasellus maximus volutpat nunc ut tincidunt.</p>\r\n        <p>Donec laoreet in nibh vel maximus. Donec posuere aliquam lacus a congue. Interdum et malesuada fames ac ante\r\n          ipsum\r\n          primis in faucibus. Aenean semper fringilla arcu, non auctor ante. Ut efficitur euismod scelerisque. Cras\r\n          accumsan\r\n          orci rhoncus elementum auctor. Phasellus maximus volutpat nunc ut tincidunt. Lorem ipsum dolor sit amet,\r\n          consectetur\r\n          adipiscing elit. Pellentesque aliquet tincidunt neque, et volutpat est dictum non. Nulla hendrerit leo sit amet\r\n          nisl\r\n          blandit, quis pharetra lacus ultrices. Etiam pretium ipsum eu dui consectetur maximus. Vivamus pretium luctus\r\n          lorem,\r\n          eu viverra velit malesuada at. Nam risus orci, gravida ut convallis et, cursus id velit.</p>\r\n      </div>\r\n      <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-info btn-raised\" (click)=\"c('Close click')\">Close</button>\r\n      </div>\r\n    </ng-template>\r\n\r\n  </section>\r\n"

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
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");



var SupportHowToDoGuideComponent = /** @class */ (function () {
    function SupportHowToDoGuideComponent(modalService) {
        this.modalService = modalService;
    }
    SupportHowToDoGuideComponent.prototype.GetDetails = function (content, titleText) {
        this.title = titleText;
        this.modalService.open(content, { size: 'lg' }).result.then(function (result) {
        }, function (reason) {
        });
    };
    SupportHowToDoGuideComponent.prototype.ngOnInit = function () {
    };
    SupportHowToDoGuideComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-support-how-to-do-guide',
            template: __webpack_require__(/*! ./support-how-to-do-guide.component.html */ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.html"),
            styles: [__webpack_require__(/*! ./support-how-to-do-guide.component.scss */ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__["NgbModal"]])
    ], SupportHowToDoGuideComponent);
    return SupportHowToDoGuideComponent;
}());



/***/ }),

/***/ "./src/app/support/support-routing.module.ts":
/*!***************************************************!*\
  !*** ./src/app/support/support-routing.module.ts ***!
  \***************************************************/
/*! exports provided: SupportRoutingModule, routedComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SupportRoutingModule", function() { return SupportRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routedComponents", function() { return routedComponents; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _support_how_to_do_guide_support_how_to_do_guide_component__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./support-how-to-do-guide/support-how-to-do-guide.component */ "./src/app/support/support-how-to-do-guide/support-how-to-do-guide.component.ts");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");




var routes = [
    {
        path: '',
        children: [
            {
                path: '',
                component: _support_how_to_do_guide_support_how_to_do_guide_component__WEBPACK_IMPORTED_MODULE_1__["SupportHowToDoGuideComponent"],
                data: {
                    title: '"How to" guide'
                },
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

var routedComponents = [_support_how_to_do_guide_support_how_to_do_guide_component__WEBPACK_IMPORTED_MODULE_1__["SupportHowToDoGuideComponent"]];


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
/* harmony import */ var ng_chartist__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ng-chartist */ "./node_modules/ng-chartist/dist/ng-chartist.js");
/* harmony import */ var ng_chartist__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(ng_chartist__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var app_shared_directives_match_height_directive__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! app/shared/directives/match-height.directive */ "./src/app/shared/directives/match-height.directive.ts");








var SupportModule = /** @class */ (function () {
    function SupportModule() {
    }
    SupportModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [_support_how_to_do_guide_support_how_to_do_guide_component__WEBPACK_IMPORTED_MODULE_3__["SupportHowToDoGuideComponent"]],
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _support_routing_module__WEBPACK_IMPORTED_MODULE_4__["SupportRoutingModule"],
                ng_chartist__WEBPACK_IMPORTED_MODULE_5__["ChartistModule"],
                _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__["NgbModule"],
                app_shared_directives_match_height_directive__WEBPACK_IMPORTED_MODULE_7__["MatchHeightModule"]
            ]
        })
    ], SupportModule);
    return SupportModule;
}());



/***/ })

}]);
//# sourceMappingURL=support-support-module.js.map