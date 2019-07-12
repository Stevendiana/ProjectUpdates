(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["resources-resources-module"],{

/***/ "./src/app/resources/resource/delete-resource.component.html":
/*!*******************************************************************!*\
  !*** ./src/app/resources/resource/delete-resource.component.html ***!
  \*******************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/resources/resource/delete-resource.component.ts":
/*!*****************************************************************!*\
  !*** ./src/app/resources/resource/delete-resource.component.ts ***!
  \*****************************************************************/
/*! exports provided: DeleteResourceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DeleteResourceComponent", function() { return DeleteResourceComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var DeleteResourceComponent = /** @class */ (function () {
    function DeleteResourceComponent() {
    }
    DeleteResourceComponent.prototype.ngOnInit = function () {
    };
    DeleteResourceComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-delete-resource',
            template: __webpack_require__(/*! ./delete-resource.component.html */ "./src/app/resources/resource/delete-resource.component.html"),
            styles: [__webpack_require__(/*! ./new-resource.component.scss */ "./src/app/resources/resource/new-resource.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], DeleteResourceComponent);
    return DeleteResourceComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/edit-resource.component.html":
/*!*****************************************************************!*\
  !*** ./src/app/resources/resource/edit-resource.component.html ***!
  \*****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ""

/***/ }),

/***/ "./src/app/resources/resource/edit-resource.component.ts":
/*!***************************************************************!*\
  !*** ./src/app/resources/resource/edit-resource.component.ts ***!
  \***************************************************************/
/*! exports provided: EditResourceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EditResourceComponent", function() { return EditResourceComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var EditResourceComponent = /** @class */ (function () {
    function EditResourceComponent() {
    }
    EditResourceComponent.prototype.ngOnInit = function () {
    };
    EditResourceComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-edit-resource',
            template: __webpack_require__(/*! ./edit-resource.component.html */ "./src/app/resources/resource/edit-resource.component.html"),
            styles: [__webpack_require__(/*! ./new-resource.component.scss */ "./src/app/resources/resource/new-resource.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], EditResourceComponent);
    return EditResourceComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/new-resource.component.html":
/*!****************************************************************!*\
  !*** ./src/app/resources/resource/new-resource.component.html ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<!-- The Modal -->\r\n\r\n<div class=\"container\">\r\n  <div class=\"modal-header\">\r\n    <h4 class=\"modal-title\">Edit {{name}} Resource</h4>\r\n    <button type=\"button\" class=\"close\" aria-label=\"Close\" (click)=\"activeModal.dismiss('Cross click')\">\r\n      <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n  </div>\r\n  <div class=\"modal-body\">\r\n    <!-- <section> -->\r\n      <div class=\"row text-left\">\r\n              <div class=\"col-md-12\">\r\n                <div class=\"card\">\r\n                  <div class=\"card-header pb-2\">\r\n                    <h4 class=\"card-title\" id=\"horz-layout-colored-controls\">User Profile</h4>\r\n                    <p class=\"mb-0\">This is 2-columns horizontal form with labels on left and form controls on right in one line.\r\n                      Add <code>.form-horizontal</code> class to the form tag to have horizontal form styling. User can also\r\n                      change the border color and background color of the form control. Add <code>border-*</code> class to change\r\n                      border color and <code>bg-*</code> class to change background color of the form control.</p>\r\n                  </div>\r\n                  <div class=\"card-content\">\r\n                    <div class=\"px-3\">\r\n                      <form class=\"form form-horizontal\">\r\n                        <div class=\"form-body\">\r\n                          <h4 class=\"form-section\"><i class=\"ft-info\"></i> About User</h4>\r\n                          <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                              <div class=\"form-group row\">\r\n                                <label class=\"col-md-3 label-control\" for=\"userinput1\">First Name: </label>\r\n                                <div class=\"col-md-9\">\r\n                                  <input type=\"text\" id=\"userinput1\" class=\"form-control border-primary\" name=\"firstname\">\r\n                                </div>\r\n                              </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                              <div class=\"form-group row\">\r\n                                <label class=\"col-md-3 label-control\" for=\"userinput2\">Last Name: </label>\r\n                                <div class=\"col-md-9\">\r\n                                  <input type=\"text\" id=\"userinput2\" class=\"form-control border-primary\" name=\"lastname\">\r\n                                </div>\r\n                              </div>\r\n                            </div>\r\n                          </div>\r\n                          <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                              <div class=\"form-group row\">\r\n                                <label class=\"col-md-3 label-control\" for=\"userinput3\">Username: </label>\r\n                                <div class=\"col-md-9\">\r\n                                  <input type=\"text\" id=\"userinput3\" class=\"form-control border-primary\" name=\"username\">\r\n                                </div>\r\n                              </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                              <div class=\"form-group row\">\r\n                                <label class=\"col-md-3 label-control\" for=\"userinput4\">Nick Name: </label>\r\n                                <div class=\"col-md-9\">\r\n                                  <input type=\"text\" id=\"userinput4\" class=\"form-control border-primary\" name=\"nickname\">\r\n                                </div>\r\n                              </div>\r\n                            </div>\r\n                          </div>\r\n\r\n                          <h4 class=\"form-section\"><i class=\"ft-mail\"></i> Contact Info & Bio</h4>\r\n\r\n                          <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                              <div class=\"form-group row\">\r\n                                <label class=\"col-md-3 label-control\" for=\"userinput5\">Email: </label>\r\n                                <div class=\"col-md-9\">\r\n                                  <input class=\"form-control border-primary\" type=\"email\" id=\"userinput5\">\r\n                                </div>\r\n                              </div>\r\n\r\n                              <div class=\"form-group row\">\r\n                                <label class=\"col-md-3 label-control\" for=\"userinput6\">Website: </label>\r\n                                <div class=\"col-md-9\">\r\n                                  <input class=\"form-control border-primary\" type=\"url\" id=\"userinput6\">\r\n                                </div>\r\n                              </div>\r\n\r\n                              <div class=\"form-group row\">\r\n                                <label class=\"col-md-3 label-control\">Contact Number: </label>\r\n                                <div class=\"col-md-9\">\r\n                                  <input class=\"form-control border-primary\" type=\"number\" id=\"userinput7\">\r\n                                </div>\r\n                              </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                              <div class=\"form-group row\">\r\n                                <label class=\"col-md-3 label-control\" for=\"userinput8\">Bio: </label>\r\n                                <div class=\"col-md-9\">\r\n                                  <textarea id=\"userinput8\" rows=\"6\" class=\"form-control col-md-9 border-primary\" name=\"bio\"></textarea>\r\n                                </div>\r\n                              </div>\r\n                            </div>\r\n                          </div>\r\n                        </div>\r\n\r\n                        <div class=\"form-actions right\">\r\n                          <button type=\"button\" class=\"btn btn-raised btn-warning mr-1\">\r\n                            <i class=\"ft-x\"></i> Cancel\r\n                          </button>\r\n                          <button type=\"button\" class=\"btn btn-raised btn-primary\">\r\n                            <i class=\"fa fa-check-square-o\"></i> Save\r\n                          </button>\r\n                        </div>\r\n                      </form>\r\n\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n      <!-- </section> -->\r\n  </div>\r\n  <div class=\"modal-footer\">\r\n    <button type=\"button\" class=\"btn btn-secondary btn-raised\" (click)=\"activeModal.close('Close click')\">Close</button>\r\n  </div>\r\n  </div>\r\n\r\n"

/***/ }),

/***/ "./src/app/resources/resource/new-resource.component.scss":
/*!****************************************************************!*\
  !*** ./src/app/resources/resource/new-resource.component.scss ***!
  \****************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9uZXctcmVzb3VyY2UuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/resources/resource/new-resource.component.ts":
/*!**************************************************************!*\
  !*** ./src/app/resources/resource/new-resource.component.ts ***!
  \**************************************************************/
/*! exports provided: NewResourceComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NewResourceComponent", function() { return NewResourceComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");



var NewResourceComponent = /** @class */ (function () {
    function NewResourceComponent(activeModal) {
        this.activeModal = activeModal;
    }
    NewResourceComponent.prototype.ngOnInit = function () {
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Input"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], NewResourceComponent.prototype, "name", void 0);
    NewResourceComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-new-resource',
            template: __webpack_require__(/*! ./new-resource.component.html */ "./src/app/resources/resource/new-resource.component.html"),
            styles: [__webpack_require__(/*! ./new-resource.component.scss */ "./src/app/resources/resource/new-resource.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__["NgbActiveModal"]])
    ], NewResourceComponent);
    return NewResourceComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/resource-absences-table/resource-absences-table.component.html":
/*!***************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-absences-table/resource-absences-table.component.html ***!
  \***************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-absences-table works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resource/resource-absences-table/resource-absences-table.component.scss":
/*!***************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-absences-table/resource-absences-table.component.scss ***!
  \***************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9yZXNvdXJjZS1hYnNlbmNlcy10YWJsZS9yZXNvdXJjZS1hYnNlbmNlcy10YWJsZS5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/resources/resource/resource-absences-table/resource-absences-table.component.ts":
/*!*************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-absences-table/resource-absences-table.component.ts ***!
  \*************************************************************************************************/
/*! exports provided: ResourceAbsencesTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceAbsencesTableComponent", function() { return ResourceAbsencesTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceAbsencesTableComponent = /** @class */ (function () {
    function ResourceAbsencesTableComponent() {
    }
    ResourceAbsencesTableComponent.prototype.ngOnInit = function () {
    };
    ResourceAbsencesTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-absences-table',
            template: __webpack_require__(/*! ./resource-absences-table.component.html */ "./src/app/resources/resource/resource-absences-table/resource-absences-table.component.html"),
            styles: [__webpack_require__(/*! ./resource-absences-table.component.scss */ "./src/app/resources/resource/resource-absences-table/resource-absences-table.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceAbsencesTableComponent);
    return ResourceAbsencesTableComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/resource-absences/resource-absences.component.html":
/*!***************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-absences/resource-absences.component.html ***!
  \***************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-absences works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resource/resource-absences/resource-absences.component.scss":
/*!***************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-absences/resource-absences.component.scss ***!
  \***************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9yZXNvdXJjZS1hYnNlbmNlcy9yZXNvdXJjZS1hYnNlbmNlcy5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/resources/resource/resource-absences/resource-absences.component.ts":
/*!*************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-absences/resource-absences.component.ts ***!
  \*************************************************************************************/
/*! exports provided: ResourceAbsencesComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceAbsencesComponent", function() { return ResourceAbsencesComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceAbsencesComponent = /** @class */ (function () {
    function ResourceAbsencesComponent() {
    }
    ResourceAbsencesComponent.prototype.ngOnInit = function () {
    };
    ResourceAbsencesComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-absences',
            template: __webpack_require__(/*! ./resource-absences.component.html */ "./src/app/resources/resource/resource-absences/resource-absences.component.html"),
            styles: [__webpack_require__(/*! ./resource-absences.component.scss */ "./src/app/resources/resource/resource-absences/resource-absences.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceAbsencesComponent);
    return ResourceAbsencesComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/resource-availability-table/resource-availability-table.component.html":
/*!***********************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-availability-table/resource-availability-table.component.html ***!
  \***********************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-availability-table works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resource/resource-availability-table/resource-availability-table.component.scss":
/*!***********************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-availability-table/resource-availability-table.component.scss ***!
  \***********************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9yZXNvdXJjZS1hdmFpbGFiaWxpdHktdGFibGUvcmVzb3VyY2UtYXZhaWxhYmlsaXR5LXRhYmxlLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/resources/resource/resource-availability-table/resource-availability-table.component.ts":
/*!*********************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-availability-table/resource-availability-table.component.ts ***!
  \*********************************************************************************************************/
/*! exports provided: ResourceAvailabilityTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceAvailabilityTableComponent", function() { return ResourceAvailabilityTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceAvailabilityTableComponent = /** @class */ (function () {
    function ResourceAvailabilityTableComponent() {
    }
    ResourceAvailabilityTableComponent.prototype.ngOnInit = function () {
    };
    ResourceAvailabilityTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-availability-table',
            template: __webpack_require__(/*! ./resource-availability-table.component.html */ "./src/app/resources/resource/resource-availability-table/resource-availability-table.component.html"),
            styles: [__webpack_require__(/*! ./resource-availability-table.component.scss */ "./src/app/resources/resource/resource-availability-table/resource-availability-table.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceAvailabilityTableComponent);
    return ResourceAvailabilityTableComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/resource-availability/resource-availability.component.html":
/*!***********************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-availability/resource-availability.component.html ***!
  \***********************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-availability works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resource/resource-availability/resource-availability.component.scss":
/*!***********************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-availability/resource-availability.component.scss ***!
  \***********************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9yZXNvdXJjZS1hdmFpbGFiaWxpdHkvcmVzb3VyY2UtYXZhaWxhYmlsaXR5LmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/resources/resource/resource-availability/resource-availability.component.ts":
/*!*********************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-availability/resource-availability.component.ts ***!
  \*********************************************************************************************/
/*! exports provided: ResourceAvailabilityComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceAvailabilityComponent", function() { return ResourceAvailabilityComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceAvailabilityComponent = /** @class */ (function () {
    function ResourceAvailabilityComponent() {
    }
    ResourceAvailabilityComponent.prototype.ngOnInit = function () {
    };
    ResourceAvailabilityComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-availability',
            template: __webpack_require__(/*! ./resource-availability.component.html */ "./src/app/resources/resource/resource-availability/resource-availability.component.html"),
            styles: [__webpack_require__(/*! ./resource-availability.component.scss */ "./src/app/resources/resource/resource-availability/resource-availability.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceAvailabilityComponent);
    return ResourceAvailabilityComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/resource-demand/resource-demand.component.html":
/*!***********************************************************************************!*\
  !*** ./src/app/resources/resource/resource-demand/resource-demand.component.html ***!
  \***********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-demand works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resource/resource-demand/resource-demand.component.scss":
/*!***********************************************************************************!*\
  !*** ./src/app/resources/resource/resource-demand/resource-demand.component.scss ***!
  \***********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9yZXNvdXJjZS1kZW1hbmQvcmVzb3VyY2UtZGVtYW5kLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/resources/resource/resource-demand/resource-demand.component.ts":
/*!*********************************************************************************!*\
  !*** ./src/app/resources/resource/resource-demand/resource-demand.component.ts ***!
  \*********************************************************************************/
/*! exports provided: ResourceDemandComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceDemandComponent", function() { return ResourceDemandComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceDemandComponent = /** @class */ (function () {
    function ResourceDemandComponent() {
    }
    ResourceDemandComponent.prototype.ngOnInit = function () {
    };
    ResourceDemandComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-demand',
            template: __webpack_require__(/*! ./resource-demand.component.html */ "./src/app/resources/resource/resource-demand/resource-demand.component.html"),
            styles: [__webpack_require__(/*! ./resource-demand.component.scss */ "./src/app/resources/resource/resource-demand/resource-demand.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceDemandComponent);
    return ResourceDemandComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.html":
/*!*********************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.html ***!
  \*********************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-utilization-table works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.scss":
/*!*********************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.scss ***!
  \*********************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9yZXNvdXJjZS11dGlsaXphdGlvbi10YWJsZS9yZXNvdXJjZS11dGlsaXphdGlvbi10YWJsZS5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.ts":
/*!*******************************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.ts ***!
  \*******************************************************************************************************/
/*! exports provided: ResourceUtilizationTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceUtilizationTableComponent", function() { return ResourceUtilizationTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceUtilizationTableComponent = /** @class */ (function () {
    function ResourceUtilizationTableComponent() {
    }
    ResourceUtilizationTableComponent.prototype.ngOnInit = function () {
    };
    ResourceUtilizationTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-utilization-table',
            template: __webpack_require__(/*! ./resource-utilization-table.component.html */ "./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.html"),
            styles: [__webpack_require__(/*! ./resource-utilization-table.component.scss */ "./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceUtilizationTableComponent);
    return ResourceUtilizationTableComponent;
}());



/***/ }),

/***/ "./src/app/resources/resource/resource-utilization/resource-utilization.component.html":
/*!*********************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-utilization/resource-utilization.component.html ***!
  \*********************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resource-utilization works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resource/resource-utilization/resource-utilization.component.scss":
/*!*********************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-utilization/resource-utilization.component.scss ***!
  \*********************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZS9yZXNvdXJjZS11dGlsaXphdGlvbi9yZXNvdXJjZS11dGlsaXphdGlvbi5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/resources/resource/resource-utilization/resource-utilization.component.ts":
/*!*******************************************************************************************!*\
  !*** ./src/app/resources/resource/resource-utilization/resource-utilization.component.ts ***!
  \*******************************************************************************************/
/*! exports provided: ResourceUtilizationComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceUtilizationComponent", function() { return ResourceUtilizationComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourceUtilizationComponent = /** @class */ (function () {
    function ResourceUtilizationComponent() {
    }
    ResourceUtilizationComponent.prototype.ngOnInit = function () {
    };
    ResourceUtilizationComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resource-utilization',
            template: __webpack_require__(/*! ./resource-utilization.component.html */ "./src/app/resources/resource/resource-utilization/resource-utilization.component.html"),
            styles: [__webpack_require__(/*! ./resource-utilization.component.scss */ "./src/app/resources/resource/resource-utilization/resource-utilization.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourceUtilizationComponent);
    return ResourceUtilizationComponent;
}());



/***/ }),

/***/ "./src/app/resources/resources-absences-table/resources-absences-table.component.html":
/*!********************************************************************************************!*\
  !*** ./src/app/resources/resources-absences-table/resources-absences-table.component.html ***!
  \********************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<p>\r\n  resources-absences-table works!\r\n</p>\r\n"

/***/ }),

/***/ "./src/app/resources/resources-absences-table/resources-absences-table.component.scss":
/*!********************************************************************************************!*\
  !*** ./src/app/resources/resources-absences-table/resources-absences-table.component.scss ***!
  \********************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZXMtYWJzZW5jZXMtdGFibGUvcmVzb3VyY2VzLWFic2VuY2VzLXRhYmxlLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/resources/resources-absences-table/resources-absences-table.component.ts":
/*!******************************************************************************************!*\
  !*** ./src/app/resources/resources-absences-table/resources-absences-table.component.ts ***!
  \******************************************************************************************/
/*! exports provided: ResourcesAbsencesTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesAbsencesTableComponent", function() { return ResourcesAbsencesTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");


var ResourcesAbsencesTableComponent = /** @class */ (function () {
    function ResourcesAbsencesTableComponent() {
    }
    ResourcesAbsencesTableComponent.prototype.ngOnInit = function () {
    };
    ResourcesAbsencesTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources-absences-table',
            template: __webpack_require__(/*! ./resources-absences-table.component.html */ "./src/app/resources/resources-absences-table/resources-absences-table.component.html"),
            styles: [__webpack_require__(/*! ./resources-absences-table.component.scss */ "./src/app/resources/resources-absences-table/resources-absences-table.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [])
    ], ResourcesAbsencesTableComponent);
    return ResourcesAbsencesTableComponent;
}());



/***/ }),

/***/ "./src/app/resources/resources-availability-table/resources-availability-table.component.html":
/*!****************************************************************************************************!*\
  !*** ./src/app/resources/resources-availability-table/resources-availability-table.component.html ***!
  \****************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<table  #exampleTableTools class=\"table table-hover table-responsive-md text-center dataTable \" datatable [dtOptions]=\"dtOptions\"\r\n              [dtTrigger]=\"dtTrigger\" id=\"exampleTableTools\">\r\n                <thead>\r\n                  <tr>\r\n                    <th>#</th>\r\n                    <th></th>\r\n                    <th>First Name</th>\r\n                    <th>Last Name</th>\r\n                    <th>Gender</th>\r\n                    <th>Email</th>\r\n                    <th>Actions</th>\r\n                  </tr>\r\n                </thead>\r\n                <tbody>\r\n                  <tr>\r\n                    <td>1</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item1\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item1\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>John</td>\r\n                    <td>Carter</td>\r\n                    <td>Male</td>\r\n                    <td>johncarter@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                  <tr>\r\n                    <td>2</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item2\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item2\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>Peter</td>\r\n                    <td>Parker</td>\r\n                    <td>Male</td>\r\n                    <td>peterparker@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                  <tr>\r\n                    <td>3</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item3\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item3\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>John</td>\r\n                    <td>Rambo</td>\r\n                    <td>Male</td>\r\n                    <td>johnrambo@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                </tbody>\r\n              </table>\r\n"

/***/ }),

/***/ "./src/app/resources/resources-availability-table/resources-availability-table.component.scss":
/*!****************************************************************************************************!*\
  !*** ./src/app/resources/resources-availability-table/resources-availability-table.component.scss ***!
  \****************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZXMtYXZhaWxhYmlsaXR5LXRhYmxlL3Jlc291cmNlcy1hdmFpbGFiaWxpdHktdGFibGUuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/resources/resources-availability-table/resources-availability-table.component.ts":
/*!**************************************************************************************************!*\
  !*** ./src/app/resources/resources-availability-table/resources-availability-table.component.ts ***!
  \**************************************************************************************************/
/*! exports provided: ResourcesAvailabilityTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesAvailabilityTableComponent", function() { return ResourcesAvailabilityTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");



var ResourcesAvailabilityTableComponent = /** @class */ (function () {
    function ResourcesAvailabilityTableComponent() {
        this.dtOptions = {};
        // dtOptions: DataTables.Settings = {};
        this.dtTrigger = new rxjs__WEBPACK_IMPORTED_MODULE_2__["Subject"]();
    }
    // constructor() { }
    ResourcesAvailabilityTableComponent.prototype.ngOnInit = function () {
        this.dtOptions = {
            pagingType: 'full_numbers',
            pageLength: 100,
            processing: true,
            'paging': true,
            'ordering': true,
            'info': true,
            'columnDefs': [{
                    'targets': [3],
                    'visible': true,
                    'searchable': true
                },
                {
                    'targets': [4],
                    'visible': true
                }
                // ,{ 'bSortable': true, 'bSort': false, 'aTargets': [ '_all' ] }
            ],
            // responsive: true,
            searching: true,
            select: true,
            order: [0, 'desc'],
            dom: "<\n             <\"row\"\n               <\"col-lg-3 col-md-12\"l>\n               <\"col-lg-6 col-md-12 button-wrapper btn-sm danger\"B>\n               <\"col-lg-3 col-md-12\"f>><hr>\n             <\"row\" <\"col\"t>>\n             <\"row\"\n               <\"col\"i>\n               <\"col btn-sm\"p>>\n             >",
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print',
                {
                    text: 'GroupBy',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
            ],
            'bLengthChange': true,
            'Filter': true,
            'Info': true,
            fixedHeader: {
                header: true,
                bottom: true,
                // footer: false,
                zTop: 1000
                // headerOffset: 400
            },
        };
        this.example = $(this.table.nativeElement);
        this.example.DataTable(this.dtOptions);
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('exampleTableTools'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], ResourcesAvailabilityTableComponent.prototype, "table", void 0);
    ResourcesAvailabilityTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources-availability-table',
            template: __webpack_require__(/*! ./resources-availability-table.component.html */ "./src/app/resources/resources-availability-table/resources-availability-table.component.html"),
            styles: [__webpack_require__(/*! ./resources-availability-table.component.scss */ "./src/app/resources/resources-availability-table/resources-availability-table.component.scss")]
        })
    ], ResourcesAvailabilityTableComponent);
    return ResourcesAvailabilityTableComponent;
}());



/***/ }),

/***/ "./src/app/resources/resources-availability/resources-availability.component.html":
/*!****************************************************************************************!*\
  !*** ./src/app/resources/resources-availability/resources-availability.component.html ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <h1 class=\"card-title m-1 pl-2 pull-left text-muted text-primary\">Resource Availability</h1>\r\n</div>\r\n<!-- Minimal statistics with bg color section start -->\r\n<section id=\"minimal-statistics-bg\">\r\n  <div class=\"row text-left\" matchHeight=\"card\">\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-primary\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-pencil white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>278</h3>\r\n                <span>New Posts</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-danger\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-speech white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>156</h3>\r\n                <span>New Comments</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-success\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-graph white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>64.89 %</h3>\r\n                <span>Bounce Rate</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-warning\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-pointer white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>423</h3>\r\n                <span>Total Visits</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</section>\r\n<!-- Minimal statistics with bg color section end -->\r\n\r\n<section id=\"extended\">\r\n    <div class=\"row text-left\">\r\n      <div class=\"col-sm-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n              <h2 class=\"card-title text-capitalize text-monospace\">Yearly Availability</h2>\r\n          </div>\r\n          <div class=\"card-content p-2 m-2\">\r\n            <div class=\"card-body\">\r\n                <div classs =\"m-2 p-2\">\r\n                    <div classs =\"row\">\r\n                        <div class=\"col-12\">\r\n                            <ngb-tabset  type=\"pills\">\r\n                                <hr>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year1}} </b><span class=\"text-danger\">- Current year</span></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year2}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year3}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year4}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                    <ng-template ngbTabTitle><b>{{year5}}</b></ng-template>\r\n                                    <ng-template ngbTabContent>\r\n                                      <hr>\r\n                                      <app-resources-availability-table></app-resources-availability-table>\r\n                                    </ng-template>\r\n                                  </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year6}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year7}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year8}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year9}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year10}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-availability-table></app-resources-availability-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                            </ngb-tabset>\r\n                        </div>\r\n                    </div>\r\n                    </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </section>\r\n\r\n\r\n"

/***/ }),

/***/ "./src/app/resources/resources-availability/resources-availability.component.scss":
/*!****************************************************************************************!*\
  !*** ./src/app/resources/resources-availability/resources-availability.component.scss ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ":host /deep/ .ct-grid {\n  stroke-dasharray: 0px;\n  stroke: rgba(0, 0, 0, 0.1); }\n\n:host /deep/ .ct-label {\n  font-size: 0.9rem; }\n\n:host /deep/ .lineArea .ct-series-a .ct-area {\n  fill-opacity: 0.7;\n  fill: url(\"/dashboard/dashboard1#gradient1\") !important; }\n\n:host /deep/ .lineArea .ct-series-b .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient\") !important;\n  fill-opacity: 0.9; }\n\n:host /deep/ .lineArea .ct-line {\n  stroke-width: 0px; }\n\n:host /deep/ .lineArea .ct-point {\n  stroke-width: 0px; }\n\n:host /deep/ .Stackbarchart .ct-series-a .ct-bar {\n  stroke: url(\"/dashboard/dashboard1#linear\") !important; }\n\n:host /deep/ .Stackbarchart .ct-series-b .ct-bar {\n  stroke: #e9e9e9; }\n\n:host /deep/ .lineArea2 .ct-series-a .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient2\") !important; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient3\") !important; }\n\n:host /deep/ .lineArea2 .ct-point-circle {\n  stroke-width: 2px;\n  fill: white; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-point-circle {\n  stroke: #843cf7; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-line {\n  stroke: #A675F4; }\n\n:host /deep/ .lineArea2 .ct-series-a .ct-point-circle {\n  stroke: #31afb2; }\n\n:host /deep/ .lineArea2 .ct-line {\n  fill: none;\n  stroke-width: 2px; }\n\n:host /deep/ .lineChart .ct-point-circle {\n  stroke-width: 2px;\n  fill: white; }\n\n:host /deep/ .lineChart .ct-series-a .ct-point-circle {\n  stroke: white; }\n\n:host /deep/ .lineChart .ct-line {\n  fill: none;\n  stroke: white;\n  stroke-width: 1px; }\n\n:host /deep/ .lineChart .ct-label {\n  color: #FFF; }\n\n:host /deep/ .lineChartShadow {\n  -webkit-filter: drop-shadow(0px 25px 8px rgba(0, 0, 0, 0.3));\n  filter: drop-shadow(0px 25px 8px rgba(0, 0, 0, 0.3));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n:host /deep/ .donut .ct-done .ct-slice-donut {\n  stroke: #0CC27E;\n  stroke-width: 24px !important; }\n\n:host /deep/ .donut .ct-progress .ct-slice-donut {\n  stroke: #FFC107;\n  stroke-width: 16px !important; }\n\n:host /deep/ .donut .ct-outstanding .ct-slice-donut {\n  stroke: #7E57C2;\n  stroke-width: 8px !important; }\n\n:host /deep/ .donut .ct-started .ct-slice-donut {\n  stroke: #2196F3;\n  stroke-width: 32px !important; }\n\n:host /deep/ .donut .ct-label {\n  text-anchor: middle;\n  alignment-baseline: middle;\n  font-size: 20px;\n  fill: #868e96; }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+1) {\n  stroke: url(\"/dashboard/dashboard1#gradient7\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+2) {\n  stroke: url(\"/dashboard/dashboard1#gradient5\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+3) {\n  stroke: url(\"/dashboard/dashboard1#gradient6\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+4) {\n  stroke: url(\"/dashboard/dashboard1#gradient4\"); }\n\n:host /deep/ .BarChartShadow {\n  -webkit-filter: drop-shadow(0px 20px 8px rgba(0, 0, 0, 0.3));\n  filter: drop-shadow(0px 20px 8px rgba(0, 0, 0, 0.3));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n:host /deep/ .WidgetlineChart .ct-point {\n  stroke-width: 0px; }\n\n:host /deep/ .WidgetlineChart .ct-line {\n  stroke: #fff; }\n\n:host /deep/ .WidgetlineChart .ct-grid {\n  stroke-dasharray: 0px;\n  stroke: rgba(255, 255, 255, 0.2); }\n\n:host /deep/ .WidgetlineChartshadow {\n  -webkit-filter: drop-shadow(0px 15px 5px rgba(0, 0, 0, 0.8));\n  filter: drop-shadow(0px 15px 5px rgba(0, 0, 0, 0.8));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n.noshow {\n  display: none; }\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcmVzb3VyY2VzL3Jlc291cmNlcy1hdmFpbGFiaWxpdHkvQzpcXFVzZXJzXFxOZGlhbmFuaWVcXEdpdFxcUHJvamVjdFVwZGF0ZXNcXFBUQW5ndWxhclxccHJvamVjdHVwZGF0ZXNmcm9udGVuZC9zcmNcXGFwcFxccmVzb3VyY2VzXFxyZXNvdXJjZXMtYXZhaWxhYmlsaXR5XFxyZXNvdXJjZXMtYXZhaWxhYmlsaXR5LmNvbXBvbmVudC5zY3NzIiwic3JjL2FwcC9yZXNvdXJjZXMvcmVzb3VyY2VzLWF2YWlsYWJpbGl0eS9yZXNvdXJjZXMtYXZhaWxhYmlsaXR5LmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUVBO0VBQ0kscUJBQXFCO0VBQ3JCLDBCQUEwQixFQUFBOztBQUc5QjtFQUNJLGlCQUFpQixFQUFBOztBQUtyQjtFQUNJLGlCQUFpQjtFQUNqQix1REFBNEQsRUFBQTs7QUFHaEU7RUFDSSxzREFBNEQ7RUFDNUQsaUJBQWlCLEVBQUE7O0FBRXJCO0VBQ0ksaUJBQWlCLEVBQUE7O0FBRXJCO0VBQ0ksaUJBQWlCLEVBQUE7O0FBT3JCO0VBR1ksc0RBQTRELEVBQUE7O0FBSHhFO0VBUVksZUFBZSxFQUFBOztBQVMzQjtFQUNJLHVEQUE2RCxFQUFBOztBQUdqRTtFQUNJLHVEQUE2RCxFQUFBOztBQUdqRTtFQUNJLGlCQUFpQjtFQUNqQixXQUFXLEVBQUE7O0FBR2Y7RUFDSSxlQUFlLEVBQUE7O0FBR25CO0VBQ0ksZUFBZSxFQUFBOztBQUduQjtFQUNJLGVBQWUsRUFBQTs7QUFHbkI7RUFDSSxVQUFVO0VBQ1YsaUJBQWlCLEVBQUE7O0FBT3JCO0VBQ0ksaUJBQWlCO0VBQ2pCLFdBQVcsRUFBQTs7QUFHZjtFQUNJLGFBQWEsRUFBQTs7QUFHakI7RUFDSSxVQUFVO0VBQ1YsYUFBYTtFQUNiLGlCQUFpQixFQUFBOztBQUdyQjtFQUNJLFdBQVcsRUFBQTs7QUFHZjtFQUNJLDREQUEyRDtFQUNuRCxvREFBbUQ7RUFBRTtnRkNwQ2UsRURxQ0M7O0FBTS9FO0VBQ0UsZUFBZTtFQUNmLDZCQUE2QixFQUFBOztBQUUvQjtFQUNFLGVBQWU7RUFDZiw2QkFBNkIsRUFBQTs7QUFFL0I7RUFDRSxlQUFlO0VBQ2YsNEJBQTRCLEVBQUE7O0FBRzlCO0VBQ0UsZUFBZTtFQUNmLDZCQUE2QixFQUFBOztBQUcvQjtFQUNFLG1CQUFtQjtFQUNuQiwwQkFBMEI7RUFDMUIsZUFBZTtFQUNmLGFBQWEsRUFBQTs7QUFPZjtFQUNFLDhDQUFvRCxFQUFBOztBQUV0RDtFQUNFLDhDQUFvRCxFQUFBOztBQUV0RDtFQUNFLDhDQUFvRCxFQUFBOztBQUV0RDtFQUNFLDhDQUFvRCxFQUFBOztBQUd0RDtFQUNFLDREQUEyRDtFQUNuRCxvREFBbUQ7RUFBRTtnRkMvQ2UsRURnREM7O0FBT2pGO0VBQ0ksaUJBQWlCLEVBQUE7O0FBRXJCO0VBQ0ksWUFBWSxFQUFBOztBQUloQjtFQUNJLHFCQUFxQjtFQUNwQixnQ0FBZ0MsRUFBQTs7QUFHckM7RUFDSSw0REFBMkQ7RUFDbkQsb0RBQW1EO0VBQUU7Z0ZDdERlLEVEdURDOztBQUtqRjtFQUNFLGFBQWEsRUFBQSIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZXMtYXZhaWxhYmlsaXR5L3Jlc291cmNlcy1hdmFpbGFiaWxpdHkuY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyJAaW1wb3J0IFwiLi4vLi4vLi4vYXNzZXRzL3Nhc3Mvc2Nzcy9ncmFkaWVudC12YXJpYWJsZXNcIjtcclxuXHJcbjpob3N0IC9kZWVwLyAuY3QtZ3JpZHtcclxuICAgIHN0cm9rZS1kYXNoYXJyYXk6IDBweDtcclxuICAgIHN0cm9rZTogcmdiYSgwLCAwLCAwLCAwLjEpO1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmN0LWxhYmVse1xyXG4gICAgZm9udC1zaXplOiAwLjlyZW07XHJcbn1cclxuXHJcbi8vIExpbmUgd2l0aCBBcmVhIENoYXJ0IENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LXNlcmllcy1hIC5jdC1hcmVhIHtcclxuICAgIGZpbGwtb3BhY2l0eTogMC43O1xyXG4gICAgZmlsbDp1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQxKSAhaW1wb3J0YW50O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1zZXJpZXMtYiAuY3QtYXJlYSB7XHJcbiAgICBmaWxsOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQpICFpbXBvcnRhbnQ7XHJcbiAgICBmaWxsLW9wYWNpdHk6IDAuOTtcclxufVxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1saW5le1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAwcHg7XHJcbn1cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3QtcG9pbnQge1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAwcHg7XHJcbn1cclxuXHJcbi8vIExpbmUgd2l0aCBBcmVhIENoYXJ0IDEgQ1NTIEVuZHNcclxuXHJcbi8vIFN0YWNrIEJhciBDaGFydCBDU1MgU3RhcnRzXHJcblxyXG46aG9zdCAvZGVlcC8gLlN0YWNrYmFyY2hhcnR7XHJcbiAgICAuY3Qtc2VyaWVzLWEge1xyXG4gICAgICAgIC5jdC1iYXJ7XHJcbiAgICAgICAgICAgIHN0cm9rZTogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2xpbmVhcikgIWltcG9ydGFudFxyXG4gICAgICAgIH1cclxuICAgIH1cclxuICAgIC5jdC1zZXJpZXMtYiB7XHJcbiAgICAgICAgLmN0LWJhcntcclxuICAgICAgICAgICAgc3Ryb2tlOiAjZTllOWU5O1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG5cclxuLy8gU3RhY2sgQmFyIENoYXJ0IENTUyBFbmRzXHJcblxyXG4vLyBMaW5lIHdpdGggQXJlYSBDaGFydCAyIENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYSAuY3QtYXJlYSB7XHJcbiAgICBmaWxsOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQyKSAhaW1wb3J0YW50O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LWFyZWEge1xyXG4gICAgZmlsbDogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2dyYWRpZW50MykgIWltcG9ydGFudDtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXBvaW50LWNpcmNsZSB7XHJcbiAgICBzdHJva2Utd2lkdGg6IDJweDtcclxuICAgIGZpbGw6IHdoaXRlO1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LXBvaW50LWNpcmNsZXtcclxuICAgIHN0cm9rZTogIzg0M2NmNztcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1iIC5jdC1saW5le1xyXG4gICAgc3Ryb2tlOiAjQTY3NUY0O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWEgLmN0LXBvaW50LWNpcmNsZSB7XHJcbiAgICBzdHJva2U6ICMzMWFmYjI7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1saW5lIHtcclxuICAgIGZpbGw6IG5vbmU7XHJcbiAgICBzdHJva2Utd2lkdGg6IDJweDtcclxufVxyXG5cclxuLy8gTGluZSB3aXRoIEFyZWEgQ2hhcnQgMiBDU1MgRW5kc1xyXG5cclxuLy8gTGluZSBDaGFydCBDU1MgU3RhcnRzXHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3QtcG9pbnQtY2lyY2xlIHtcclxuICAgIHN0cm9rZS13aWR0aDogMnB4O1xyXG4gICAgZmlsbDogd2hpdGU7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtcG9pbnQtY2lyY2xlIHtcclxuICAgIHN0cm9rZTogd2hpdGU7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1saW5lIHtcclxuICAgIGZpbGw6IG5vbmU7XHJcbiAgICBzdHJva2U6IHdoaXRlO1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAxcHg7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1sYWJlbCB7XHJcbiAgICBjb2xvcjogI0ZGRjtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnRTaGFkb3cge1xyXG4gICAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMjVweCA4cHggcmdiYSgwLDAsMCwwLjMpICk7XHJcbiAgICAgICAgICAgIGZpbHRlcjogZHJvcC1zaGFkb3coIDBweCAyNXB4IDhweCByZ2JhKDAsMCwwLDAuMykgKTsgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqL1xyXG59XHJcblxyXG4vLyBMaW5lIENoYXJ0ICBDU1MgRW5kc1xyXG5cclxuICAvLyBEb251dCBDaGFydCAgQ1NTIEVuZHNcclxuICA6aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1kb25lIC5jdC1zbGljZS1kb251dCB7XHJcbiAgICBzdHJva2U6ICMwQ0MyN0U7XHJcbiAgICBzdHJva2Utd2lkdGg6IDI0cHggIWltcG9ydGFudDtcclxuICB9XHJcbiAgOmhvc3QgL2RlZXAvIC5kb251dCAuY3QtcHJvZ3Jlc3MgLmN0LXNsaWNlLWRvbnV0IHtcclxuICAgIHN0cm9rZTogI0ZGQzEwNztcclxuICAgIHN0cm9rZS13aWR0aDogMTZweCAhaW1wb3J0YW50O1xyXG4gIH1cclxuICA6aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1vdXRzdGFuZGluZyAuY3Qtc2xpY2UtZG9udXQge1xyXG4gICAgc3Ryb2tlOiAjN0U1N0MyO1xyXG4gICAgc3Ryb2tlLXdpZHRoOiA4cHggIWltcG9ydGFudDtcclxuICB9XHJcblxyXG4gIDpob3N0IC9kZWVwLyAuZG9udXQgLmN0LXN0YXJ0ZWQgLmN0LXNsaWNlLWRvbnV0IHtcclxuICAgIHN0cm9rZTogIzIxOTZGMztcclxuICAgIHN0cm9rZS13aWR0aDogMzJweCAhaW1wb3J0YW50O1xyXG4gIH1cclxuXHJcbiAgOmhvc3QgL2RlZXAvIC5kb251dCAuY3QtbGFiZWwge1xyXG4gICAgdGV4dC1hbmNob3I6IG1pZGRsZTtcclxuICAgIGFsaWdubWVudC1iYXNlbGluZTogbWlkZGxlO1xyXG4gICAgZm9udC1zaXplOiAyMHB4O1xyXG4gICAgZmlsbDogIzg2OGU5NjtcclxuICB9XHJcblxyXG4gIC8vIERvbnV0IENoYXJ0ICBDU1MgRW5kc1xyXG5cclxuICAvLyBCYXIgQ2hhcnQgQ1NTIFN0YXJ0c1xyXG5cclxuICA6aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzEpIHtcclxuICAgIHN0cm9rZTogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2dyYWRpZW50Nyk7XHJcbiAgfVxyXG4gIDpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rMikge1xyXG4gICAgc3Ryb2tlOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQ1KTtcclxuICB9XHJcbiAgOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0biszKSB7XHJcbiAgICBzdHJva2U6IHVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudDYpO1xyXG4gIH1cclxuICA6aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzQpIHtcclxuICAgIHN0cm9rZTogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2dyYWRpZW50NCk7XHJcbiAgfVxyXG5cclxuICA6aG9zdCAvZGVlcC8gLkJhckNoYXJ0U2hhZG93IHtcclxuICAgIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdyggMHB4IDIwcHggOHB4IHJnYmEoMCwwLDAsMC4zKSApO1xyXG4gICAgICAgICAgICBmaWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMjBweCA4cHggcmdiYSgwLDAsMCwwLjMpICk7IC8qIFNhbWUgc3ludGF4IGFzIGJveC1zaGFkb3csIGV4Y2VwdFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgZm9yIHRoZSBzcHJlYWQgcHJvcGVydHkgKi9cclxufVxyXG5cclxuLy8gQmFyIENoYXJ0IENTUyBFbmRzXHJcblxyXG4vLyBXaWRnZXQgbGluZSBDaGFydCBDU1MgU3RhcnRzXHJcblxyXG46aG9zdCAvZGVlcC8gLldpZGdldGxpbmVDaGFydCAuY3QtcG9pbnQge1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAwcHg7XHJcbn1cclxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnQgLmN0LWxpbmV7XHJcbiAgICBzdHJva2U6ICNmZmY7XHJcbn1cclxuXHJcblxyXG46aG9zdCAvZGVlcC8gLldpZGdldGxpbmVDaGFydCAuY3QtZ3JpZCB7XHJcbiAgICBzdHJva2UtZGFzaGFycmF5OiAwcHg7XHJcbiAgICAgc3Ryb2tlOiByZ2JhKDI1NSwgMjU1LCAyNTUsIDAuMik7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0c2hhZG93IHtcclxuICAgIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdyggMHB4IDE1cHggNXB4IHJnYmEoMCwwLDAsMC44KSApO1xyXG4gICAgICAgICAgICBmaWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMTVweCA1cHggcmdiYSgwLDAsMCwwLjgpICk7IC8qIFNhbWUgc3ludGF4IGFzIGJveC1zaGFkb3csIGV4Y2VwdFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgZm9yIHRoZSBzcHJlYWQgcHJvcGVydHkgKi9cclxufVxyXG5cclxuLy8gV2lkZ2V0IGxpbmUgQ2hhcnQgQ1NTIEVuZHNcclxuXHJcbi5ub3Nob3cge1xyXG4gIGRpc3BsYXk6IG5vbmU7XHJcbn1cclxuIiwiOmhvc3QgL2RlZXAvIC5jdC1ncmlkIHtcbiAgc3Ryb2tlLWRhc2hhcnJheTogMHB4O1xuICBzdHJva2U6IHJnYmEoMCwgMCwgMCwgMC4xKTsgfVxuXG46aG9zdCAvZGVlcC8gLmN0LWxhYmVsIHtcbiAgZm9udC1zaXplOiAwLjlyZW07IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3Qtc2VyaWVzLWEgLmN0LWFyZWEge1xuICBmaWxsLW9wYWNpdHk6IDAuNztcbiAgZmlsbDogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50MVwiKSAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LXNlcmllcy1iIC5jdC1hcmVhIHtcbiAgZmlsbDogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50XCIpICFpbXBvcnRhbnQ7XG4gIGZpbGwtb3BhY2l0eTogMC45OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LWxpbmUge1xuICBzdHJva2Utd2lkdGg6IDBweDsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1wb2ludCB7XG4gIHN0cm9rZS13aWR0aDogMHB4OyB9XG5cbjpob3N0IC9kZWVwLyAuU3RhY2tiYXJjaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhciB7XG4gIHN0cm9rZTogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2xpbmVhclwiKSAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAuU3RhY2tiYXJjaGFydCAuY3Qtc2VyaWVzLWIgLmN0LWJhciB7XG4gIHN0cm9rZTogI2U5ZTllOTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWEgLmN0LWFyZWEge1xuICBmaWxsOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQyXCIpICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1iIC5jdC1hcmVhIHtcbiAgZmlsbDogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50M1wiKSAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1wb2ludC1jaXJjbGUge1xuICBzdHJva2Utd2lkdGg6IDJweDtcbiAgZmlsbDogd2hpdGU7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1iIC5jdC1wb2ludC1jaXJjbGUge1xuICBzdHJva2U6ICM4NDNjZjc7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1iIC5jdC1saW5lIHtcbiAgc3Ryb2tlOiAjQTY3NUY0OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYSAuY3QtcG9pbnQtY2lyY2xlIHtcbiAgc3Ryb2tlOiAjMzFhZmIyOyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1saW5lIHtcbiAgZmlsbDogbm9uZTtcbiAgc3Ryb2tlLXdpZHRoOiAycHg7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LXBvaW50LWNpcmNsZSB7XG4gIHN0cm9rZS13aWR0aDogMnB4O1xuICBmaWxsOiB3aGl0ZTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LXBvaW50LWNpcmNsZSB7XG4gIHN0cm9rZTogd2hpdGU7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LWxpbmUge1xuICBmaWxsOiBub25lO1xuICBzdHJva2U6IHdoaXRlO1xuICBzdHJva2Utd2lkdGg6IDFweDsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3QtbGFiZWwge1xuICBjb2xvcjogI0ZGRjsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydFNoYWRvdyB7XG4gIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMjVweCA4cHggcmdiYSgwLCAwLCAwLCAwLjMpKTtcbiAgZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMjVweCA4cHggcmdiYSgwLCAwLCAwLCAwLjMpKTtcbiAgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqLyB9XG5cbjpob3N0IC9kZWVwLyAuZG9udXQgLmN0LWRvbmUgLmN0LXNsaWNlLWRvbnV0IHtcbiAgc3Ryb2tlOiAjMENDMjdFO1xuICBzdHJva2Utd2lkdGg6IDI0cHggIWltcG9ydGFudDsgfVxuXG46aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1wcm9ncmVzcyAuY3Qtc2xpY2UtZG9udXQge1xuICBzdHJva2U6ICNGRkMxMDc7XG4gIHN0cm9rZS13aWR0aDogMTZweCAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAuZG9udXQgLmN0LW91dHN0YW5kaW5nIC5jdC1zbGljZS1kb251dCB7XG4gIHN0cm9rZTogIzdFNTdDMjtcbiAgc3Ryb2tlLXdpZHRoOiA4cHggIWltcG9ydGFudDsgfVxuXG46aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1zdGFydGVkIC5jdC1zbGljZS1kb251dCB7XG4gIHN0cm9rZTogIzIxOTZGMztcbiAgc3Ryb2tlLXdpZHRoOiAzMnB4ICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5kb251dCAuY3QtbGFiZWwge1xuICB0ZXh0LWFuY2hvcjogbWlkZGxlO1xuICBhbGlnbm1lbnQtYmFzZWxpbmU6IG1pZGRsZTtcbiAgZm9udC1zaXplOiAyMHB4O1xuICBmaWxsOiAjODY4ZTk2OyB9XG5cbjpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rMSkge1xuICBzdHJva2U6IHVybChcIi9kYXNoYm9hcmQvZGFzaGJvYXJkMSNncmFkaWVudDdcIik7IH1cblxuOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0bisyKSB7XG4gIHN0cm9rZTogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50NVwiKTsgfVxuXG46aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzMpIHtcbiAgc3Ryb2tlOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQ2XCIpOyB9XG5cbjpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rNCkge1xuICBzdHJva2U6IHVybChcIi9kYXNoYm9hcmQvZGFzaGJvYXJkMSNncmFkaWVudDRcIik7IH1cblxuOmhvc3QgL2RlZXAvIC5CYXJDaGFydFNoYWRvdyB7XG4gIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMjBweCA4cHggcmdiYSgwLCAwLCAwLCAwLjMpKTtcbiAgZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMjBweCA4cHggcmdiYSgwLCAwLCAwLCAwLjMpKTtcbiAgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqLyB9XG5cbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1wb2ludCB7XG4gIHN0cm9rZS13aWR0aDogMHB4OyB9XG5cbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1saW5lIHtcbiAgc3Ryb2tlOiAjZmZmOyB9XG5cbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1ncmlkIHtcbiAgc3Ryb2tlLWRhc2hhcnJheTogMHB4O1xuICBzdHJva2U6IHJnYmEoMjU1LCAyNTUsIDI1NSwgMC4yKTsgfVxuXG46aG9zdCAvZGVlcC8gLldpZGdldGxpbmVDaGFydHNoYWRvdyB7XG4gIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMTVweCA1cHggcmdiYSgwLCAwLCAwLCAwLjgpKTtcbiAgZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMTVweCA1cHggcmdiYSgwLCAwLCAwLCAwLjgpKTtcbiAgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqLyB9XG5cbi5ub3Nob3cge1xuICBkaXNwbGF5OiBub25lOyB9XG4iXX0= */"

/***/ }),

/***/ "./src/app/resources/resources-availability/resources-availability.component.ts":
/*!**************************************************************************************!*\
  !*** ./src/app/resources/resources-availability/resources-availability.component.ts ***!
  \**************************************************************************************/
/*! exports provided: ResourcesAvailabilityComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesAvailabilityComponent", function() { return ResourcesAvailabilityComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! chartist */ "./node_modules/chartist/dist/chartist.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(chartist__WEBPACK_IMPORTED_MODULE_2__);



var data = __webpack_require__(/*! ../../shared/data/chartist.json */ "./src/app/shared/data/chartist.json");
var ResourcesAvailabilityComponent = /** @class */ (function () {
    function ResourcesAvailabilityComponent() {
        this.previous = false;
        this.current = false;
        this.future = false;
        // constructor() { }
        // Line chart configuration Starts
        this.WidgetlineChart = {
            type: 'Line', data: data['WidgetlineChart2'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart1 = {
            type: 'Line', data: data['WidgetlineChart3'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true,
                chartPadding: { top: 0, right: 0, bottom: 10, left: 0 }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart2 = {
            type: 'Line', data: data['WidgetlineChart'],
            options: {
                axisX: {
                    showGrid: true,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 40,
                    showLabel: false,
                    offset: 0,
                },
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_2__["Interpolation"].cardinal({
                    tension: 0
                }),
                fullWidth: true
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient1',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart1 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 0,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9c9';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart2 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 90,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9e7';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart3 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 270,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue964';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Line area chart configuration Starts
        this.lineAreaChart = {
            type: 'Line',
            data: data['lineArea3'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(38, 198, 218, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                }
            },
        };
        // Line area chart configuration Ends
        // Line chart configuration Starts
        this.lineChart2 = {
            type: 'Line', data: data['line2'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.lineChart1 = {
            type: 'Line', data: data['line1'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line area chart configuration Starts
        this.lineArea = {
            type: 'Line',
            data: data['lineAreaDashboard'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(146, 254, 157, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient1',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line area chart configuration Ends
        // Stacked Bar chart configuration Starts
        this.Stackbarchart = {
            type: 'Bar',
            data: data['Stackbarchart'],
            options: {
                stackBars: true,
                fullWidth: true,
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                chartPadding: 30
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'linear',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
                draw: function (data) {
                    if (data.type === 'bar') {
                        data.element.attr({
                            style: 'stroke-width: 5px',
                            x1: data.x1 + 0.001
                        });
                    }
                    else if (data.type === 'label') {
                        data.element.attr({
                            y: 270
                        });
                    }
                }
            },
        };
        // Stacked Bar chart configuration Ends
        // Line area chart 2 configuration Starts
        this.lineArea2 = {
            type: 'Line',
            data: data['lineArea2'],
            options: {
                showArea: true,
                fullWidth: true,
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_2__["Interpolation"].none(),
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                }
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient2',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient3',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0.3,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line area chart 2 configuration Ends
        // Line chart configuration Starts
        this.lineChart = {
            type: 'Line', data: data['LineDashboard'],
            options: {
                axisX: {
                    showGrid: false
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    low: 0,
                    high: 100,
                    offset: 0,
                },
                fullWidth: true,
                offset: 0,
            },
            events: {
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart = {
            type: 'Pie',
            data: data['donutDashboard'],
            options: {
                donut: true,
                startAngle: 0,
                labelInterpolationFnc: function (value) {
                    var total = data['donutDashboard'].series.reduce(function (prev, series) {
                        return prev + series.value;
                    }, 0);
                    return total + '%';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: data.element.root().height() / 2
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        //  Bar chart configuration Starts
        this.BarChart = {
            type: 'Bar', data: data['DashboardBar'], options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                low: 0,
                high: 60,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px)', {
                        seriesBarDistance: 5,
                        axisX: {
                            labelInterpolationFnc: function (value) {
                                return value[0];
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient4',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(238, 9, 121,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 106, 0, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient5',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 75, 145,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(120, 204, 55, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient6',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient7',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(155, 60, 183,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 57, 111, 1)'
                    });
                },
                draw: function (data) {
                    var barHorizontalCenter, barVerticalCenter, label, value;
                    if (data.type === 'bar') {
                        data.element.attr({
                            y1: 195,
                            x1: data.x1 + 0.001
                        });
                    }
                }
            },
        };
    }
    // Bar chart configuration Ends
    ResourcesAvailabilityComponent.prototype.ngOnInit = function () {
        this.currentyear = 2005;
        this.year1 = this.currentyear;
        this.year2 = this.currentyear + 1;
        this.year3 = this.currentyear + 2;
        this.year4 = this.currentyear + 3;
        this.year5 = this.currentyear + 4;
        this.year6 = this.currentyear + 5;
        this.year7 = this.currentyear + 6;
        this.year8 = this.currentyear + 7;
        this.year9 = this.currentyear + 8;
        this.year10 = this.currentyear + 9;
    };
    ResourcesAvailabilityComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources-availability',
            template: __webpack_require__(/*! ./resources-availability.component.html */ "./src/app/resources/resources-availability/resources-availability.component.html"),
            styles: [__webpack_require__(/*! ./resources-availability.component.scss */ "./src/app/resources/resources-availability/resources-availability.component.scss")]
        })
    ], ResourcesAvailabilityComponent);
    return ResourcesAvailabilityComponent;
}());



/***/ }),

/***/ "./src/app/resources/resources-dashboard/resources-dashboard.component.html":
/*!**********************************************************************************!*\
  !*** ./src/app/resources/resources-dashboard/resources-dashboard.component.html ***!
  \**********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <h1 class=\"card-title m-1 pl-2 pull-left text-muted text-primary\">Resource Pool</h1>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-xl-3 col-lg-6 col-md-6 col-12\">\r\n      <div class=\"card bg-primary\">\r\n        <div class=\"card-content\">\r\n          <div class=\"card-body pt-2 pb-0\">\r\n            <div class=\"media\">\r\n              <div class=\"media-body white text-left\">\r\n                <h3 class=\"font-large-1 mb-0\">{{resourceCount}}</h3>\r\n                <span>Total Resources</span>\r\n              </div>\r\n              <div class=\"media-right white text-right\">\r\n                <i class=\"icon-bulb font-large-1\"></i>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <div id=\"Widget-line-chart\" class=\"height-75 WidgetlineChart WidgetlineChartShadow mb-3\">\r\n            <x-chartist class=\"\" [data]=\"WidgetlineChart.data\" [type]=\"WidgetlineChart.type\" [options]=\"WidgetlineChart.options\"\r\n              [responsiveOptions]=\"WidgetlineChart.responsiveOptions\" [events]=\"WidgetlineChart.events\">\r\n            </x-chartist>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-md-6 col-12\">\r\n      <div class=\"card bg-warning\">\r\n        <div class=\"card-content\">\r\n          <div class=\"card-body pt-2 pb-0\">\r\n            <div class=\"media\">\r\n              <div class=\"media-body white text-left\">\r\n                <h3 class=\"font-large-1 mb-0\">$2156</h3>\r\n                <span>Total Tax</span>\r\n              </div>\r\n              <div class=\"media-right white text-right\">\r\n                <i class=\"icon-pie-chart font-large-1\"></i>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <div id=\"Widget-line-chart2\" class=\"height-75 WidgetlineChart WidgetlineChartShadow mb-3\">\r\n            <x-chartist class=\"\" [data]=\"WidgetlineChart.data\" [type]=\"WidgetlineChart.type\" [options]=\"WidgetlineChart.options\"\r\n              [responsiveOptions]=\"WidgetlineChart.responsiveOptions\" [events]=\"WidgetlineChart.events\">\r\n            </x-chartist>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n    <div class=\"col-xl-3 col-lg-6 col-md-6 col-12\">\r\n      <div class=\"card bg-success\">\r\n        <div class=\"card-content\">\r\n          <div class=\"card-body pt-2 pb-0\">\r\n            <div class=\"media\">\r\n              <div class=\"media-body white text-left\">\r\n                <h3 class=\"font-large-1 mb-0\">$45,668</h3>\r\n                <span>Total Sales</span>\r\n              </div>\r\n              <div class=\"media-right white text-right\">\r\n                <i class=\"icon-graph font-large-1\"></i>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <div id=\"Widget-line-chart2\" class=\"height-75 WidgetlineChart WidgetlineChartShadow mb-3\">\r\n            <x-chartist class=\"\" [data]=\"WidgetlineChart.data\" [type]=\"WidgetlineChart.type\" [options]=\"WidgetlineChart.options\"\r\n              [responsiveOptions]=\"WidgetlineChart.responsiveOptions\" [events]=\"WidgetlineChart.events\">\r\n            </x-chartist>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-md-6 col-12\">\r\n      <div class=\"card bg-danger\">\r\n        <div class=\"card-content\">\r\n          <div class=\"card-body pt-2 pb-0\">\r\n            <div class=\"media\">\r\n              <div class=\"media-body white text-left\">\r\n                <h3 class=\"font-large-1 mb-0\">$32,454</h3>\r\n                <span>Total Earning</span>\r\n              </div>\r\n              <div class=\"media-right white text-right\">\r\n                <i class=\"icon-wallet font-large-1\"></i>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <div id=\"Widget-line-chart2\" class=\"height-75 WidgetlineChart WidgetlineChartShadow mb-3\">\r\n            <x-chartist class=\"\" [data]=\"WidgetlineChart.data\" [type]=\"WidgetlineChart.type\" [options]=\"WidgetlineChart.options\"\r\n              [responsiveOptions]=\"WidgetlineChart.responsiveOptions\" [events]=\"WidgetlineChart.events\">\r\n            </x-chartist>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n<div class=\"row\" matchHeight =\"card\">\r\n    <div class=\"col-xl-8 col-lg-12 col-12\">\r\n      <div class=\"card\">\r\n        <div class=\"card-header\">\r\n          <h4 class=\"card-title mb-0\">Visit & Sales Statistics</h4>\r\n        </div>\r\n        <div class=\"card-content\">\r\n          <div class=\"card-body\">\r\n            <div class=\"chart-info mb-2\">\r\n              <span class=\"text-uppercase mr-3\"><i class=\"fa fa-circle primary font-small-2 mr-1\"></i> Sales</span>\r\n              <span class=\"text-uppercase\"><i class=\"fa fa-circle deep-purple font-small-2 mr-1\"></i> Visits</span>\r\n            </div>\r\n            <div id=\"line-area2\" class=\"height-400 lineArea2\">\r\n              <x-chartist class=\"\" [data]=\"lineArea2.data\" [type]=\"lineArea2.type\" [options]=\"lineArea2.options\"\r\n               [responsiveOptions]=\"lineArea2.responsiveOptions\" [events]=\"lineArea2.events\">\r\n\r\n              </x-chartist>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-4 col-lg-12 col-12\">\r\n      <div class=\"card gradient-blackberry\">\r\n        <div class=\"card-content\">\r\n          <div class=\"card-body\">\r\n            <h4 class=\"card-title white\">Statistics</h4>\r\n            <div class=\"p-2 text-center\">\r\n              <a class=\"white font-medium-1\">Month</a>\r\n              <a class=\"btn btn-raised btn-round bg-white mx-3 px-3\">Week</a>\r\n              <a class=\"white font-medium-1\">Day</a>\r\n            </div>\r\n            <div class=\"my-3 text-center white\">\r\n              <a class=\"font-large-2 d-block mb-1\">$ 78.89 <span class=\"ft-arrow-up font-large-2\"></span></a>\r\n              <span class=\"font-medium-1\">Week2   +15.44</span>\r\n            </div>\r\n          </div>\r\n          <div id=\"lineChart\" class=\"height-250 lineChart lineChartShadow\">\r\n            <x-chartist class=\"\" [data]=\"lineChart.data\" [type]=\"lineChart.type\" [options]=\"lineChart.options\"\r\n             [responsiveOptions]=\"lineChart.responsiveOptions\" [events]=\"lineChart.events\">\r\n            </x-chartist>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>"

/***/ }),

/***/ "./src/app/resources/resources-dashboard/resources-dashboard.component.scss":
/*!**********************************************************************************!*\
  !*** ./src/app/resources/resources-dashboard/resources-dashboard.component.scss ***!
  \**********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZXMtZGFzaGJvYXJkL3Jlc291cmNlcy1kYXNoYm9hcmQuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/resources/resources-dashboard/resources-dashboard.component.ts":
/*!********************************************************************************!*\
  !*** ./src/app/resources/resources-dashboard/resources-dashboard.component.ts ***!
  \********************************************************************************/
/*! exports provided: ResourcesDashboardComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesDashboardComponent", function() { return ResourcesDashboardComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! chartist */ "./node_modules/chartist/dist/chartist.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(chartist__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var angular_datatables__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! angular-datatables */ "./node_modules/angular-datatables/index.js");
/* harmony import */ var _resources_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../resources.service */ "./src/app/resources/resources.service.ts");
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var _resource_new_resource_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../resource/new-resource.component */ "./src/app/resources/resource/new-resource.component.ts");








var data = __webpack_require__(/*! ../../shared/data/chartist.json */ "./src/app/shared/data/chartist.json");
var ResourcesDashboardComponent = /** @class */ (function () {
    // Bar chart configuration Ends
    function ResourcesDashboardComponent(resourcesService, modalService) {
        this.resourcesService = resourcesService;
        this.modalService = modalService;
        this.resources$ = [];
        this.dtOptions = {};
        this.dtTrigger = new rxjs__WEBPACK_IMPORTED_MODULE_3__["Subject"]();
        // Line chart configuration Starts
        this.WidgetlineChart = {
            type: 'Line', data: data['WidgetlineChart2'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart1 = {
            type: 'Line', data: data['WidgetlineChart3'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true,
                chartPadding: { top: 0, right: 0, bottom: 10, left: 0 }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart2 = {
            type: 'Line', data: data['WidgetlineChart'],
            options: {
                axisX: {
                    showGrid: true,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 40,
                    showLabel: false,
                    offset: 0,
                },
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_2__["Interpolation"].cardinal({
                    tension: 0
                }),
                fullWidth: true
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient1',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart1 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 0,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9c9';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart2 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 90,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9e7';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart3 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 270,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue964';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Line area chart configuration Starts
        this.lineAreaChart = {
            type: 'Line',
            data: data['lineArea3'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(38, 198, 218, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                }
            },
        };
        // Line area chart configuration Ends
        // Line chart configuration Starts
        this.lineChart2 = {
            type: 'Line', data: data['line2'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.lineChart1 = {
            type: 'Line', data: data['line1'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line area chart configuration Starts
        this.lineArea = {
            type: 'Line',
            data: data['lineAreaDashboard'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(146, 254, 157, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient1',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line area chart configuration Ends
        // Stacked Bar chart configuration Starts
        this.Stackbarchart = {
            type: 'Bar',
            data: data['Stackbarchart'],
            options: {
                stackBars: true,
                fullWidth: true,
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                chartPadding: 30
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'linear',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
                draw: function (data) {
                    if (data.type === 'bar') {
                        data.element.attr({
                            style: 'stroke-width: 5px',
                            x1: data.x1 + 0.001
                        });
                    }
                    else if (data.type === 'label') {
                        data.element.attr({
                            y: 270
                        });
                    }
                }
            },
        };
        // Stacked Bar chart configuration Ends
        // Line area chart 2 configuration Starts
        this.lineArea2 = {
            type: 'Line',
            data: data['lineArea2'],
            options: {
                showArea: true,
                fullWidth: true,
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_2__["Interpolation"].none(),
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                }
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient2',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient3',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0.3,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line area chart 2 configuration Ends
        // Line chart configuration Starts
        this.lineChart = {
            type: 'Line', data: data['LineDashboard'],
            options: {
                axisX: {
                    showGrid: false
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    low: 0,
                    high: 100,
                    offset: 0,
                },
                fullWidth: true,
                offset: 0,
            },
            events: {
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart = {
            type: 'Pie',
            data: data['donutDashboard'],
            options: {
                donut: true,
                startAngle: 0,
                labelInterpolationFnc: function (value) {
                    var total = data['donutDashboard'].series.reduce(function (prev, series) {
                        return prev + series.value;
                    }, 0);
                    return total + '%';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: data.element.root().height() / 2
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        //  Bar chart configuration Starts
        this.BarChart = {
            type: 'Bar', data: data['DashboardBar'], options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                low: 0,
                high: 60,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px)', {
                        seriesBarDistance: 5,
                        axisX: {
                            labelInterpolationFnc: function (value) {
                                return value[0];
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient4',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(238, 9, 121,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 106, 0, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient5',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 75, 145,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(120, 204, 55, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient6',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient7',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(155, 60, 183,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 57, 111, 1)'
                    });
                },
                draw: function (data) {
                    var barHorizontalCenter, barVerticalCenter, label, value;
                    if (data.type === 'bar') {
                        data.element.attr({
                            y1: 195,
                            x1: data.x1 + 0.001
                        });
                    }
                }
            },
        };
    }
    ResourcesDashboardComponent.prototype.ngOnInit = function () {
        this.dtOptions = {
            pagingType: 'full_numbers',
            pageLength: 100,
            processing: true,
            // data: this.resources$,
            // 'bDestroy': true,
            'paging': true,
            'ordering': true,
            'info': true,
            'columnDefs': [{
                    'targets': [3],
                    'visible': true,
                    'searchable': true
                },
                {
                    'targets': [4],
                    'visible': true
                }
                // ,{ 'bSortable': true, 'bSort': false, 'aTargets': [ '_all' ] }
            ],
            // responsive: true,
            searching: true,
            select: true,
            order: [0, 'desc'],
            dom: "<\n             <\"row\"\n               <\"col-lg-3 col-md-12\"l>\n               <\"col-lg-6 col-md-12 button-wrapper btn-sm danger\"B>\n               <\"col-lg-3 col-md-12\"f>><hr>\n             <\"row\" <\"col\"t>>\n             <\"row\"\n               <\"col\"i>\n               <\"col btn-sm\"p>>\n             >",
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print',
                {
                    text: 'GroupBy',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
            ],
            'bLengthChange': true,
            'Filter': true,
            // retrieve: true,
            language: {
                search: '_INPUT_',
                searchPlaceholder: 'Search records',
            },
            'Info': true,
        };
        this.resourcesService.getResourcesAndRates();
        this.getResources();
        this.rerender();
        this.example = $(this.table.nativeElement);
        this.example.DataTable(this.dtOptions);
        setTimeout(function () {
        }, 250);
    };
    ResourcesDashboardComponent.prototype.getResources = function () {
        var _this = this;
        this.resourcesService.resourcesandrates.subscribe(function (resources) {
            setTimeout(function () {
                _this.resources$ = resources;
                // this.dtTrigger.next();
                console.log(_this.resources$);
                _this.resourceCount = formatNumber(_this.resources$.length);
            }, 250);
        });
    };
    // tslint:disable-next-line:use-life-cycle-interface
    ResourcesDashboardComponent.prototype.ngOnDestroy = function () {
        this.dtTrigger.unsubscribe();
    };
    // tslint:disable-next-line:use-life-cycle-interface
    ResourcesDashboardComponent.prototype.ngAfterViewInit = function () { this.dtTrigger.next(); };
    ResourcesDashboardComponent.prototype.rerender = function () {
        var _this = this;
        this.example.dtInstance.then(function (dtInstance) {
            // Destroy the table first
            dtInstance.destroy();
            // Call the dtTrigger to rerender again
            _this.dtTrigger.next();
        });
    };
    ResourcesDashboardComponent.prototype.openContent = function () {
        var modalRef = this.modalService.open(_resource_new_resource_component__WEBPACK_IMPORTED_MODULE_7__["NewResourceComponent"], { size: 'lg', windowClass: 'modal-xl' });
        modalRef.componentInstance.name = 'World';
    };
    // Open default modal
    ResourcesDashboardComponent.prototype.open = function (content) {
        var _this = this;
        this.modalService.open(content).result.then(function (result) {
            _this.closeResult = "Closed with: " + result;
        }, function (reason) {
            _this.closeResult = "Dismissed " + _this.getDismissReason(reason);
        });
    };
    // This function is used in open
    ResourcesDashboardComponent.prototype.getDismissReason = function (reason) {
        if (reason === _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__["ModalDismissReasons"].ESC) {
            return 'by pressing ESC';
        }
        else if (reason === _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__["ModalDismissReasons"].BACKDROP_CLICK) {
            return 'by clicking on a backdrop';
        }
        else {
            return "with: " + reason;
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])(angular_datatables__WEBPACK_IMPORTED_MODULE_4__["DataTableDirective"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", angular_datatables__WEBPACK_IMPORTED_MODULE_4__["DataTableDirective"])
    ], ResourcesDashboardComponent.prototype, "dtElement", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('exampleTableTools'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], ResourcesDashboardComponent.prototype, "table", void 0);
    ResourcesDashboardComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources-dashboard',
            template: __webpack_require__(/*! ./resources-dashboard.component.html */ "./src/app/resources/resources-dashboard/resources-dashboard.component.html"),
            styles: [__webpack_require__(/*! ./resources-dashboard.component.scss */ "./src/app/resources/resources-dashboard/resources-dashboard.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_resources_service__WEBPACK_IMPORTED_MODULE_5__["ResourceService"], _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_6__["NgbModal"]])
    ], ResourcesDashboardComponent);
    return ResourcesDashboardComponent;
}());

function formatNumber(num) {
    return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,');
}


/***/ }),

/***/ "./src/app/resources/resources-demand-table/resources-demand-table.component.html":
/*!****************************************************************************************!*\
  !*** ./src/app/resources/resources-demand-table/resources-demand-table.component.html ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<table  #exampleTableTools class=\"table table-hover table-responsive-md text-center dataTable \" datatable [dtOptions]=\"dtOptions\"\r\n              [dtTrigger]=\"dtTrigger\" id=\"exampleTableTools\">\r\n                <thead>\r\n                  <tr>\r\n                    <th>#</th>\r\n                    <th></th>\r\n                    <th>First Name</th>\r\n                    <th>Last Name</th>\r\n                    <th>Gender</th>\r\n                    <th>Email</th>\r\n                    <th>Actions</th>\r\n                  </tr>\r\n                </thead>\r\n                <tbody>\r\n                  <tr>\r\n                    <td>1</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item1\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item1\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>John</td>\r\n                    <td>Carter</td>\r\n                    <td>Male</td>\r\n                    <td>johncarter@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                  <tr>\r\n                    <td>2</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item2\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item2\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>Peter</td>\r\n                    <td>Parker</td>\r\n                    <td>Male</td>\r\n                    <td>peterparker@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                  <tr>\r\n                    <td>3</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item3\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item3\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>John</td>\r\n                    <td>Rambo</td>\r\n                    <td>Male</td>\r\n                    <td>johnrambo@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                </tbody>\r\n              </table>\r\n"

/***/ }),

/***/ "./src/app/resources/resources-demand-table/resources-demand-table.component.scss":
/*!****************************************************************************************!*\
  !*** ./src/app/resources/resources-demand-table/resources-demand-table.component.scss ***!
  \****************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZXMtZGVtYW5kLXRhYmxlL3Jlc291cmNlcy1kZW1hbmQtdGFibGUuY29tcG9uZW50LnNjc3MifQ== */"

/***/ }),

/***/ "./src/app/resources/resources-demand-table/resources-demand-table.component.ts":
/*!**************************************************************************************!*\
  !*** ./src/app/resources/resources-demand-table/resources-demand-table.component.ts ***!
  \**************************************************************************************/
/*! exports provided: ResourcesDemandTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesDemandTableComponent", function() { return ResourcesDemandTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");



var ResourcesDemandTableComponent = /** @class */ (function () {
    function ResourcesDemandTableComponent() {
        this.dtOptions = {};
        // dtOptions: DataTables.Settings = {};
        this.dtTrigger = new rxjs__WEBPACK_IMPORTED_MODULE_2__["Subject"]();
    }
    // constructor() { }
    ResourcesDemandTableComponent.prototype.ngOnInit = function () {
        this.dtOptions = {
            pagingType: 'full_numbers',
            pageLength: 100,
            processing: true,
            'paging': true,
            'ordering': true,
            'info': true,
            'columnDefs': [{
                    'targets': [3],
                    'visible': true,
                    'searchable': true
                },
                {
                    'targets': [4],
                    'visible': true
                }
                // ,{ 'bSortable': true, 'bSort': false, 'aTargets': [ '_all' ] }
            ],
            // responsive: true,
            searching: true,
            select: true,
            order: [0, 'desc'],
            dom: "<\n             <\"row\"\n               <\"col-lg-3 col-md-12\"l>\n               <\"col-lg-6 col-md-12 button-wrapper btn-sm danger\"B>\n               <\"col-lg-3 col-md-12\"f>><hr>\n             <\"row\" <\"col\"t>>\n             <\"row\"\n               <\"col\"i>\n               <\"col btn-sm\"p>>\n             >",
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print',
                {
                    text: 'GroupBy',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
            ],
            'bLengthChange': true,
            'Filter': true,
            'Info': true,
            fixedHeader: {
                header: true,
                bottom: true,
                // footer: false,
                zTop: 1000
                // headerOffset: 400
            },
        };
        this.example = $(this.table.nativeElement);
        this.example.DataTable(this.dtOptions);
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('exampleTableTools'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], ResourcesDemandTableComponent.prototype, "table", void 0);
    ResourcesDemandTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources-demand-table',
            template: __webpack_require__(/*! ./resources-demand-table.component.html */ "./src/app/resources/resources-demand-table/resources-demand-table.component.html"),
            styles: [__webpack_require__(/*! ./resources-demand-table.component.scss */ "./src/app/resources/resources-demand-table/resources-demand-table.component.scss")]
        })
    ], ResourcesDemandTableComponent);
    return ResourcesDemandTableComponent;
}());



/***/ }),

/***/ "./src/app/resources/resources-demand/resources-demand.component.html":
/*!****************************************************************************!*\
  !*** ./src/app/resources/resources-demand/resources-demand.component.html ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <h1 class=\"card-title m-1 pl-2 pull-left text-muted text-primary\">Resource Demand</h1>\r\n</div>\r\n<!-- Minimal statistics with bg color section start -->\r\n<section id=\"minimal-statistics-bg\">\r\n  <div class=\"row text-left\" matchHeight=\"card\">\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-primary\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-pencil white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>278</h3>\r\n                <span>New Posts</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-danger\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-speech white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>156</h3>\r\n                <span>New Comments</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-success\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-graph white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>64.89 %</h3>\r\n                <span>Bounce Rate</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-warning\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-pointer white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>423</h3>\r\n                <span>Total Visits</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</section>\r\n<!-- Minimal statistics with bg color section end -->\r\n\r\n<section id=\"extended\">\r\n    <div class=\"row text-left\">\r\n      <div class=\"col-sm-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n              <h2 class=\"card-title text-capitalize text-monospace\">Yearly Demand</h2>\r\n          </div>\r\n          <div class=\"card-content p-2 m-2\">\r\n            <div class=\"card-body\">\r\n                <div classs =\"m-2 p-2\">\r\n                    <div classs =\"row\">\r\n                        <div class=\"col-12\">\r\n                            <ngb-tabset  type=\"pills\">\r\n                                <hr>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year1}} </b><span class=\"text-danger\">- Current year</span></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                      <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year2}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year3}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year4}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                    <ng-template ngbTabTitle><b>{{year5}}</b></ng-template>\r\n                                    <ng-template ngbTabContent>\r\n                                      <hr>\r\n                                      <app-resources-demand-table></app-resources-demand-table>\r\n                                    </ng-template>\r\n                                  </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year6}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year7}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year8}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year9}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year10}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-demand-table></app-resources-demand-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                            </ngb-tabset>\r\n                        </div>\r\n                    </div>\r\n                    </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </section>\r\n\r\n\r\n"

/***/ }),

/***/ "./src/app/resources/resources-demand/resources-demand.component.scss":
/*!****************************************************************************!*\
  !*** ./src/app/resources/resources-demand/resources-demand.component.scss ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ":host /deep/ .ct-grid {\n  stroke-dasharray: 0px;\n  stroke: rgba(0, 0, 0, 0.1); }\n\n:host /deep/ .ct-label {\n  font-size: 0.9rem; }\n\n:host /deep/ .lineArea .ct-series-a .ct-area {\n  fill-opacity: 0.7;\n  fill: url(\"/dashboard/dashboard1#gradient1\") !important; }\n\n:host /deep/ .lineArea .ct-series-b .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient\") !important;\n  fill-opacity: 0.9; }\n\n:host /deep/ .lineArea .ct-line {\n  stroke-width: 0px; }\n\n:host /deep/ .lineArea .ct-point {\n  stroke-width: 0px; }\n\n:host /deep/ .Stackbarchart .ct-series-a .ct-bar {\n  stroke: url(\"/dashboard/dashboard1#linear\") !important; }\n\n:host /deep/ .Stackbarchart .ct-series-b .ct-bar {\n  stroke: #e9e9e9; }\n\n:host /deep/ .lineArea2 .ct-series-a .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient2\") !important; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient3\") !important; }\n\n:host /deep/ .lineArea2 .ct-point-circle {\n  stroke-width: 2px;\n  fill: white; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-point-circle {\n  stroke: #843cf7; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-line {\n  stroke: #A675F4; }\n\n:host /deep/ .lineArea2 .ct-series-a .ct-point-circle {\n  stroke: #31afb2; }\n\n:host /deep/ .lineArea2 .ct-line {\n  fill: none;\n  stroke-width: 2px; }\n\n:host /deep/ .lineChart .ct-point-circle {\n  stroke-width: 2px;\n  fill: white; }\n\n:host /deep/ .lineChart .ct-series-a .ct-point-circle {\n  stroke: white; }\n\n:host /deep/ .lineChart .ct-line {\n  fill: none;\n  stroke: white;\n  stroke-width: 1px; }\n\n:host /deep/ .lineChart .ct-label {\n  color: #FFF; }\n\n:host /deep/ .lineChartShadow {\n  -webkit-filter: drop-shadow(0px 25px 8px rgba(0, 0, 0, 0.3));\n  filter: drop-shadow(0px 25px 8px rgba(0, 0, 0, 0.3));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n:host /deep/ .donut .ct-done .ct-slice-donut {\n  stroke: #0CC27E;\n  stroke-width: 24px !important; }\n\n:host /deep/ .donut .ct-progress .ct-slice-donut {\n  stroke: #FFC107;\n  stroke-width: 16px !important; }\n\n:host /deep/ .donut .ct-outstanding .ct-slice-donut {\n  stroke: #7E57C2;\n  stroke-width: 8px !important; }\n\n:host /deep/ .donut .ct-started .ct-slice-donut {\n  stroke: #2196F3;\n  stroke-width: 32px !important; }\n\n:host /deep/ .donut .ct-label {\n  text-anchor: middle;\n  alignment-baseline: middle;\n  font-size: 20px;\n  fill: #868e96; }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+1) {\n  stroke: url(\"/dashboard/dashboard1#gradient7\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+2) {\n  stroke: url(\"/dashboard/dashboard1#gradient5\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+3) {\n  stroke: url(\"/dashboard/dashboard1#gradient6\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+4) {\n  stroke: url(\"/dashboard/dashboard1#gradient4\"); }\n\n:host /deep/ .BarChartShadow {\n  -webkit-filter: drop-shadow(0px 20px 8px rgba(0, 0, 0, 0.3));\n  filter: drop-shadow(0px 20px 8px rgba(0, 0, 0, 0.3));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n:host /deep/ .WidgetlineChart .ct-point {\n  stroke-width: 0px; }\n\n:host /deep/ .WidgetlineChart .ct-line {\n  stroke: #fff; }\n\n:host /deep/ .WidgetlineChart .ct-grid {\n  stroke-dasharray: 0px;\n  stroke: rgba(255, 255, 255, 0.2); }\n\n:host /deep/ .WidgetlineChartshadow {\n  -webkit-filter: drop-shadow(0px 15px 5px rgba(0, 0, 0, 0.8));\n  filter: drop-shadow(0px 15px 5px rgba(0, 0, 0, 0.8));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n.noshow {\n  display: none; }\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcmVzb3VyY2VzL3Jlc291cmNlcy1kZW1hbmQvQzpcXFVzZXJzXFxOZGlhbmFuaWVcXEdpdFxcUHJvamVjdFVwZGF0ZXNcXFBUQW5ndWxhclxccHJvamVjdHVwZGF0ZXNmcm9udGVuZC9zcmNcXGFwcFxccmVzb3VyY2VzXFxyZXNvdXJjZXMtZGVtYW5kXFxyZXNvdXJjZXMtZGVtYW5kLmNvbXBvbmVudC5zY3NzIiwic3JjL2FwcC9yZXNvdXJjZXMvcmVzb3VyY2VzLWRlbWFuZC9yZXNvdXJjZXMtZGVtYW5kLmNvbXBvbmVudC5zY3NzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiJBQUVBO0VBQ0kscUJBQXFCO0VBQ3JCLDBCQUEwQixFQUFBOztBQUc5QjtFQUNJLGlCQUFpQixFQUFBOztBQUtyQjtFQUNJLGlCQUFpQjtFQUNqQix1REFBNEQsRUFBQTs7QUFHaEU7RUFDSSxzREFBNEQ7RUFDNUQsaUJBQWlCLEVBQUE7O0FBRXJCO0VBQ0ksaUJBQWlCLEVBQUE7O0FBRXJCO0VBQ0ksaUJBQWlCLEVBQUE7O0FBT3JCO0VBR1ksc0RBQTRELEVBQUE7O0FBSHhFO0VBUVksZUFBZSxFQUFBOztBQVMzQjtFQUNJLHVEQUE2RCxFQUFBOztBQUdqRTtFQUNJLHVEQUE2RCxFQUFBOztBQUdqRTtFQUNJLGlCQUFpQjtFQUNqQixXQUFXLEVBQUE7O0FBR2Y7RUFDSSxlQUFlLEVBQUE7O0FBR25CO0VBQ0ksZUFBZSxFQUFBOztBQUduQjtFQUNJLGVBQWUsRUFBQTs7QUFHbkI7RUFDSSxVQUFVO0VBQ1YsaUJBQWlCLEVBQUE7O0FBT3JCO0VBQ0ksaUJBQWlCO0VBQ2pCLFdBQVcsRUFBQTs7QUFHZjtFQUNJLGFBQWEsRUFBQTs7QUFHakI7RUFDSSxVQUFVO0VBQ1YsYUFBYTtFQUNiLGlCQUFpQixFQUFBOztBQUdyQjtFQUNJLFdBQVcsRUFBQTs7QUFHZjtFQUNJLDREQUEyRDtFQUNuRCxvREFBbUQ7RUFBRTtnRkNwQ2UsRURxQ0M7O0FBTS9FO0VBQ0UsZUFBZTtFQUNmLDZCQUE2QixFQUFBOztBQUUvQjtFQUNFLGVBQWU7RUFDZiw2QkFBNkIsRUFBQTs7QUFFL0I7RUFDRSxlQUFlO0VBQ2YsNEJBQTRCLEVBQUE7O0FBRzlCO0VBQ0UsZUFBZTtFQUNmLDZCQUE2QixFQUFBOztBQUcvQjtFQUNFLG1CQUFtQjtFQUNuQiwwQkFBMEI7RUFDMUIsZUFBZTtFQUNmLGFBQWEsRUFBQTs7QUFPZjtFQUNFLDhDQUFvRCxFQUFBOztBQUV0RDtFQUNFLDhDQUFvRCxFQUFBOztBQUV0RDtFQUNFLDhDQUFvRCxFQUFBOztBQUV0RDtFQUNFLDhDQUFvRCxFQUFBOztBQUd0RDtFQUNFLDREQUEyRDtFQUNuRCxvREFBbUQ7RUFBRTtnRkMvQ2UsRURnREM7O0FBT2pGO0VBQ0ksaUJBQWlCLEVBQUE7O0FBRXJCO0VBQ0ksWUFBWSxFQUFBOztBQUloQjtFQUNJLHFCQUFxQjtFQUNwQixnQ0FBZ0MsRUFBQTs7QUFHckM7RUFDSSw0REFBMkQ7RUFDbkQsb0RBQW1EO0VBQUU7Z0ZDdERlLEVEdURDOztBQUtqRjtFQUNFLGFBQWEsRUFBQSIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZXMtZGVtYW5kL3Jlc291cmNlcy1kZW1hbmQuY29tcG9uZW50LnNjc3MiLCJzb3VyY2VzQ29udGVudCI6WyJAaW1wb3J0IFwiLi4vLi4vLi4vYXNzZXRzL3Nhc3Mvc2Nzcy9ncmFkaWVudC12YXJpYWJsZXNcIjtcclxuXHJcbjpob3N0IC9kZWVwLyAuY3QtZ3JpZHtcclxuICAgIHN0cm9rZS1kYXNoYXJyYXk6IDBweDtcclxuICAgIHN0cm9rZTogcmdiYSgwLCAwLCAwLCAwLjEpO1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmN0LWxhYmVse1xyXG4gICAgZm9udC1zaXplOiAwLjlyZW07XHJcbn1cclxuXHJcbi8vIExpbmUgd2l0aCBBcmVhIENoYXJ0IENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LXNlcmllcy1hIC5jdC1hcmVhIHtcclxuICAgIGZpbGwtb3BhY2l0eTogMC43O1xyXG4gICAgZmlsbDp1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQxKSAhaW1wb3J0YW50O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1zZXJpZXMtYiAuY3QtYXJlYSB7XHJcbiAgICBmaWxsOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQpICFpbXBvcnRhbnQ7XHJcbiAgICBmaWxsLW9wYWNpdHk6IDAuOTtcclxufVxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1saW5le1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAwcHg7XHJcbn1cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3QtcG9pbnQge1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAwcHg7XHJcbn1cclxuXHJcbi8vIExpbmUgd2l0aCBBcmVhIENoYXJ0IDEgQ1NTIEVuZHNcclxuXHJcbi8vIFN0YWNrIEJhciBDaGFydCBDU1MgU3RhcnRzXHJcblxyXG46aG9zdCAvZGVlcC8gLlN0YWNrYmFyY2hhcnR7XHJcbiAgICAuY3Qtc2VyaWVzLWEge1xyXG4gICAgICAgIC5jdC1iYXJ7XHJcbiAgICAgICAgICAgIHN0cm9rZTogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2xpbmVhcikgIWltcG9ydGFudFxyXG4gICAgICAgIH1cclxuICAgIH1cclxuICAgIC5jdC1zZXJpZXMtYiB7XHJcbiAgICAgICAgLmN0LWJhcntcclxuICAgICAgICAgICAgc3Ryb2tlOiAjZTllOWU5O1xyXG4gICAgICAgIH1cclxuICAgIH1cclxufVxyXG5cclxuLy8gU3RhY2sgQmFyIENoYXJ0IENTUyBFbmRzXHJcblxyXG4vLyBMaW5lIHdpdGggQXJlYSBDaGFydCAyIENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYSAuY3QtYXJlYSB7XHJcbiAgICBmaWxsOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQyKSAhaW1wb3J0YW50O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LWFyZWEge1xyXG4gICAgZmlsbDogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2dyYWRpZW50MykgIWltcG9ydGFudDtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXBvaW50LWNpcmNsZSB7XHJcbiAgICBzdHJva2Utd2lkdGg6IDJweDtcclxuICAgIGZpbGw6IHdoaXRlO1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LXBvaW50LWNpcmNsZXtcclxuICAgIHN0cm9rZTogIzg0M2NmNztcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1iIC5jdC1saW5le1xyXG4gICAgc3Ryb2tlOiAjQTY3NUY0O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWEgLmN0LXBvaW50LWNpcmNsZSB7XHJcbiAgICBzdHJva2U6ICMzMWFmYjI7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1saW5lIHtcclxuICAgIGZpbGw6IG5vbmU7XHJcbiAgICBzdHJva2Utd2lkdGg6IDJweDtcclxufVxyXG5cclxuLy8gTGluZSB3aXRoIEFyZWEgQ2hhcnQgMiBDU1MgRW5kc1xyXG5cclxuLy8gTGluZSBDaGFydCBDU1MgU3RhcnRzXHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3QtcG9pbnQtY2lyY2xlIHtcclxuICAgIHN0cm9rZS13aWR0aDogMnB4O1xyXG4gICAgZmlsbDogd2hpdGU7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtcG9pbnQtY2lyY2xlIHtcclxuICAgIHN0cm9rZTogd2hpdGU7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1saW5lIHtcclxuICAgIGZpbGw6IG5vbmU7XHJcbiAgICBzdHJva2U6IHdoaXRlO1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAxcHg7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1sYWJlbCB7XHJcbiAgICBjb2xvcjogI0ZGRjtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnRTaGFkb3cge1xyXG4gICAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMjVweCA4cHggcmdiYSgwLDAsMCwwLjMpICk7XHJcbiAgICAgICAgICAgIGZpbHRlcjogZHJvcC1zaGFkb3coIDBweCAyNXB4IDhweCByZ2JhKDAsMCwwLDAuMykgKTsgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqL1xyXG59XHJcblxyXG4vLyBMaW5lIENoYXJ0ICBDU1MgRW5kc1xyXG5cclxuICAvLyBEb251dCBDaGFydCAgQ1NTIEVuZHNcclxuICA6aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1kb25lIC5jdC1zbGljZS1kb251dCB7XHJcbiAgICBzdHJva2U6ICMwQ0MyN0U7XHJcbiAgICBzdHJva2Utd2lkdGg6IDI0cHggIWltcG9ydGFudDtcclxuICB9XHJcbiAgOmhvc3QgL2RlZXAvIC5kb251dCAuY3QtcHJvZ3Jlc3MgLmN0LXNsaWNlLWRvbnV0IHtcclxuICAgIHN0cm9rZTogI0ZGQzEwNztcclxuICAgIHN0cm9rZS13aWR0aDogMTZweCAhaW1wb3J0YW50O1xyXG4gIH1cclxuICA6aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1vdXRzdGFuZGluZyAuY3Qtc2xpY2UtZG9udXQge1xyXG4gICAgc3Ryb2tlOiAjN0U1N0MyO1xyXG4gICAgc3Ryb2tlLXdpZHRoOiA4cHggIWltcG9ydGFudDtcclxuICB9XHJcblxyXG4gIDpob3N0IC9kZWVwLyAuZG9udXQgLmN0LXN0YXJ0ZWQgLmN0LXNsaWNlLWRvbnV0IHtcclxuICAgIHN0cm9rZTogIzIxOTZGMztcclxuICAgIHN0cm9rZS13aWR0aDogMzJweCAhaW1wb3J0YW50O1xyXG4gIH1cclxuXHJcbiAgOmhvc3QgL2RlZXAvIC5kb251dCAuY3QtbGFiZWwge1xyXG4gICAgdGV4dC1hbmNob3I6IG1pZGRsZTtcclxuICAgIGFsaWdubWVudC1iYXNlbGluZTogbWlkZGxlO1xyXG4gICAgZm9udC1zaXplOiAyMHB4O1xyXG4gICAgZmlsbDogIzg2OGU5NjtcclxuICB9XHJcblxyXG4gIC8vIERvbnV0IENoYXJ0ICBDU1MgRW5kc1xyXG5cclxuICAvLyBCYXIgQ2hhcnQgQ1NTIFN0YXJ0c1xyXG5cclxuICA6aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzEpIHtcclxuICAgIHN0cm9rZTogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2dyYWRpZW50Nyk7XHJcbiAgfVxyXG4gIDpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rMikge1xyXG4gICAgc3Ryb2tlOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQ1KTtcclxuICB9XHJcbiAgOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0biszKSB7XHJcbiAgICBzdHJva2U6IHVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudDYpO1xyXG4gIH1cclxuICA6aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzQpIHtcclxuICAgIHN0cm9rZTogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2dyYWRpZW50NCk7XHJcbiAgfVxyXG5cclxuICA6aG9zdCAvZGVlcC8gLkJhckNoYXJ0U2hhZG93IHtcclxuICAgIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdyggMHB4IDIwcHggOHB4IHJnYmEoMCwwLDAsMC4zKSApO1xyXG4gICAgICAgICAgICBmaWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMjBweCA4cHggcmdiYSgwLDAsMCwwLjMpICk7IC8qIFNhbWUgc3ludGF4IGFzIGJveC1zaGFkb3csIGV4Y2VwdFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgZm9yIHRoZSBzcHJlYWQgcHJvcGVydHkgKi9cclxufVxyXG5cclxuLy8gQmFyIENoYXJ0IENTUyBFbmRzXHJcblxyXG4vLyBXaWRnZXQgbGluZSBDaGFydCBDU1MgU3RhcnRzXHJcblxyXG46aG9zdCAvZGVlcC8gLldpZGdldGxpbmVDaGFydCAuY3QtcG9pbnQge1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAwcHg7XHJcbn1cclxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnQgLmN0LWxpbmV7XHJcbiAgICBzdHJva2U6ICNmZmY7XHJcbn1cclxuXHJcblxyXG46aG9zdCAvZGVlcC8gLldpZGdldGxpbmVDaGFydCAuY3QtZ3JpZCB7XHJcbiAgICBzdHJva2UtZGFzaGFycmF5OiAwcHg7XHJcbiAgICAgc3Ryb2tlOiByZ2JhKDI1NSwgMjU1LCAyNTUsIDAuMik7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0c2hhZG93IHtcclxuICAgIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdyggMHB4IDE1cHggNXB4IHJnYmEoMCwwLDAsMC44KSApO1xyXG4gICAgICAgICAgICBmaWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMTVweCA1cHggcmdiYSgwLDAsMCwwLjgpICk7IC8qIFNhbWUgc3ludGF4IGFzIGJveC1zaGFkb3csIGV4Y2VwdFxyXG4gICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgZm9yIHRoZSBzcHJlYWQgcHJvcGVydHkgKi9cclxufVxyXG5cclxuLy8gV2lkZ2V0IGxpbmUgQ2hhcnQgQ1NTIEVuZHNcclxuXHJcbi5ub3Nob3cge1xyXG4gIGRpc3BsYXk6IG5vbmU7XHJcbn1cclxuIiwiOmhvc3QgL2RlZXAvIC5jdC1ncmlkIHtcbiAgc3Ryb2tlLWRhc2hhcnJheTogMHB4O1xuICBzdHJva2U6IHJnYmEoMCwgMCwgMCwgMC4xKTsgfVxuXG46aG9zdCAvZGVlcC8gLmN0LWxhYmVsIHtcbiAgZm9udC1zaXplOiAwLjlyZW07IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3Qtc2VyaWVzLWEgLmN0LWFyZWEge1xuICBmaWxsLW9wYWNpdHk6IDAuNztcbiAgZmlsbDogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50MVwiKSAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LXNlcmllcy1iIC5jdC1hcmVhIHtcbiAgZmlsbDogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50XCIpICFpbXBvcnRhbnQ7XG4gIGZpbGwtb3BhY2l0eTogMC45OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LWxpbmUge1xuICBzdHJva2Utd2lkdGg6IDBweDsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1wb2ludCB7XG4gIHN0cm9rZS13aWR0aDogMHB4OyB9XG5cbjpob3N0IC9kZWVwLyAuU3RhY2tiYXJjaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhciB7XG4gIHN0cm9rZTogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2xpbmVhclwiKSAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAuU3RhY2tiYXJjaGFydCAuY3Qtc2VyaWVzLWIgLmN0LWJhciB7XG4gIHN0cm9rZTogI2U5ZTllOTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWEgLmN0LWFyZWEge1xuICBmaWxsOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQyXCIpICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1iIC5jdC1hcmVhIHtcbiAgZmlsbDogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50M1wiKSAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1wb2ludC1jaXJjbGUge1xuICBzdHJva2Utd2lkdGg6IDJweDtcbiAgZmlsbDogd2hpdGU7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1iIC5jdC1wb2ludC1jaXJjbGUge1xuICBzdHJva2U6ICM4NDNjZjc7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1iIC5jdC1saW5lIHtcbiAgc3Ryb2tlOiAjQTY3NUY0OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYSAuY3QtcG9pbnQtY2lyY2xlIHtcbiAgc3Ryb2tlOiAjMzFhZmIyOyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1saW5lIHtcbiAgZmlsbDogbm9uZTtcbiAgc3Ryb2tlLXdpZHRoOiAycHg7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LXBvaW50LWNpcmNsZSB7XG4gIHN0cm9rZS13aWR0aDogMnB4O1xuICBmaWxsOiB3aGl0ZTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LXBvaW50LWNpcmNsZSB7XG4gIHN0cm9rZTogd2hpdGU7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LWxpbmUge1xuICBmaWxsOiBub25lO1xuICBzdHJva2U6IHdoaXRlO1xuICBzdHJva2Utd2lkdGg6IDFweDsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3QtbGFiZWwge1xuICBjb2xvcjogI0ZGRjsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydFNoYWRvdyB7XG4gIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMjVweCA4cHggcmdiYSgwLCAwLCAwLCAwLjMpKTtcbiAgZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMjVweCA4cHggcmdiYSgwLCAwLCAwLCAwLjMpKTtcbiAgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqLyB9XG5cbjpob3N0IC9kZWVwLyAuZG9udXQgLmN0LWRvbmUgLmN0LXNsaWNlLWRvbnV0IHtcbiAgc3Ryb2tlOiAjMENDMjdFO1xuICBzdHJva2Utd2lkdGg6IDI0cHggIWltcG9ydGFudDsgfVxuXG46aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1wcm9ncmVzcyAuY3Qtc2xpY2UtZG9udXQge1xuICBzdHJva2U6ICNGRkMxMDc7XG4gIHN0cm9rZS13aWR0aDogMTZweCAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAuZG9udXQgLmN0LW91dHN0YW5kaW5nIC5jdC1zbGljZS1kb251dCB7XG4gIHN0cm9rZTogIzdFNTdDMjtcbiAgc3Ryb2tlLXdpZHRoOiA4cHggIWltcG9ydGFudDsgfVxuXG46aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1zdGFydGVkIC5jdC1zbGljZS1kb251dCB7XG4gIHN0cm9rZTogIzIxOTZGMztcbiAgc3Ryb2tlLXdpZHRoOiAzMnB4ICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5kb251dCAuY3QtbGFiZWwge1xuICB0ZXh0LWFuY2hvcjogbWlkZGxlO1xuICBhbGlnbm1lbnQtYmFzZWxpbmU6IG1pZGRsZTtcbiAgZm9udC1zaXplOiAyMHB4O1xuICBmaWxsOiAjODY4ZTk2OyB9XG5cbjpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rMSkge1xuICBzdHJva2U6IHVybChcIi9kYXNoYm9hcmQvZGFzaGJvYXJkMSNncmFkaWVudDdcIik7IH1cblxuOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0bisyKSB7XG4gIHN0cm9rZTogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50NVwiKTsgfVxuXG46aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzMpIHtcbiAgc3Ryb2tlOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQ2XCIpOyB9XG5cbjpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rNCkge1xuICBzdHJva2U6IHVybChcIi9kYXNoYm9hcmQvZGFzaGJvYXJkMSNncmFkaWVudDRcIik7IH1cblxuOmhvc3QgL2RlZXAvIC5CYXJDaGFydFNoYWRvdyB7XG4gIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMjBweCA4cHggcmdiYSgwLCAwLCAwLCAwLjMpKTtcbiAgZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMjBweCA4cHggcmdiYSgwLCAwLCAwLCAwLjMpKTtcbiAgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqLyB9XG5cbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1wb2ludCB7XG4gIHN0cm9rZS13aWR0aDogMHB4OyB9XG5cbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1saW5lIHtcbiAgc3Ryb2tlOiAjZmZmOyB9XG5cbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1ncmlkIHtcbiAgc3Ryb2tlLWRhc2hhcnJheTogMHB4O1xuICBzdHJva2U6IHJnYmEoMjU1LCAyNTUsIDI1NSwgMC4yKTsgfVxuXG46aG9zdCAvZGVlcC8gLldpZGdldGxpbmVDaGFydHNoYWRvdyB7XG4gIC13ZWJraXQtZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMTVweCA1cHggcmdiYSgwLCAwLCAwLCAwLjgpKTtcbiAgZmlsdGVyOiBkcm9wLXNoYWRvdygwcHggMTVweCA1cHggcmdiYSgwLCAwLCAwLCAwLjgpKTtcbiAgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqLyB9XG5cbi5ub3Nob3cge1xuICBkaXNwbGF5OiBub25lOyB9XG4iXX0= */"

/***/ }),

/***/ "./src/app/resources/resources-demand/resources-demand.component.ts":
/*!**************************************************************************!*\
  !*** ./src/app/resources/resources-demand/resources-demand.component.ts ***!
  \**************************************************************************/
/*! exports provided: ResourcesDemandComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesDemandComponent", function() { return ResourcesDemandComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! chartist */ "./node_modules/chartist/dist/chartist.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(chartist__WEBPACK_IMPORTED_MODULE_2__);



var data = __webpack_require__(/*! ../../shared/data/chartist.json */ "./src/app/shared/data/chartist.json");
var ResourcesDemandComponent = /** @class */ (function () {
    function ResourcesDemandComponent() {
        this.previous = false;
        this.current = false;
        this.future = false;
        // constructor() { }
        // Line chart configuration Starts
        this.WidgetlineChart = {
            type: 'Line', data: data['WidgetlineChart2'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart1 = {
            type: 'Line', data: data['WidgetlineChart3'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true,
                chartPadding: { top: 0, right: 0, bottom: 10, left: 0 }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart2 = {
            type: 'Line', data: data['WidgetlineChart'],
            options: {
                axisX: {
                    showGrid: true,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 40,
                    showLabel: false,
                    offset: 0,
                },
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_2__["Interpolation"].cardinal({
                    tension: 0
                }),
                fullWidth: true
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient1',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart1 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 0,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9c9';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart2 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 90,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9e7';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart3 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 270,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue964';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Line area chart configuration Starts
        this.lineAreaChart = {
            type: 'Line',
            data: data['lineArea3'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(38, 198, 218, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                }
            },
        };
        // Line area chart configuration Ends
        // Line chart configuration Starts
        this.lineChart2 = {
            type: 'Line', data: data['line2'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.lineChart1 = {
            type: 'Line', data: data['line1'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line area chart configuration Starts
        this.lineArea = {
            type: 'Line',
            data: data['lineAreaDashboard'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(146, 254, 157, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient1',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line area chart configuration Ends
        // Stacked Bar chart configuration Starts
        this.Stackbarchart = {
            type: 'Bar',
            data: data['Stackbarchart'],
            options: {
                stackBars: true,
                fullWidth: true,
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                chartPadding: 30
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'linear',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
                draw: function (data) {
                    if (data.type === 'bar') {
                        data.element.attr({
                            style: 'stroke-width: 5px',
                            x1: data.x1 + 0.001
                        });
                    }
                    else if (data.type === 'label') {
                        data.element.attr({
                            y: 270
                        });
                    }
                }
            },
        };
        // Stacked Bar chart configuration Ends
        // Line area chart 2 configuration Starts
        this.lineArea2 = {
            type: 'Line',
            data: data['lineArea2'],
            options: {
                showArea: true,
                fullWidth: true,
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_2__["Interpolation"].none(),
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                }
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient2',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient3',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0.3,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line area chart 2 configuration Ends
        // Line chart configuration Starts
        this.lineChart = {
            type: 'Line', data: data['LineDashboard'],
            options: {
                axisX: {
                    showGrid: false
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    low: 0,
                    high: 100,
                    offset: 0,
                },
                fullWidth: true,
                offset: 0,
            },
            events: {
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart = {
            type: 'Pie',
            data: data['donutDashboard'],
            options: {
                donut: true,
                startAngle: 0,
                labelInterpolationFnc: function (value) {
                    var total = data['donutDashboard'].series.reduce(function (prev, series) {
                        return prev + series.value;
                    }, 0);
                    return total + '%';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: data.element.root().height() / 2
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        //  Bar chart configuration Starts
        this.BarChart = {
            type: 'Bar', data: data['DashboardBar'], options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                low: 0,
                high: 60,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px)', {
                        seriesBarDistance: 5,
                        axisX: {
                            labelInterpolationFnc: function (value) {
                                return value[0];
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient4',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(238, 9, 121,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 106, 0, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient5',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 75, 145,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(120, 204, 55, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient6',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient7',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(155, 60, 183,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 57, 111, 1)'
                    });
                },
                draw: function (data) {
                    var barHorizontalCenter, barVerticalCenter, label, value;
                    if (data.type === 'bar') {
                        data.element.attr({
                            y1: 195,
                            x1: data.x1 + 0.001
                        });
                    }
                }
            },
        };
    }
    // Bar chart configuration Ends
    ResourcesDemandComponent.prototype.ngOnInit = function () {
        this.currentyear = 2005;
        this.year1 = this.currentyear;
        this.year2 = this.currentyear + 1;
        this.year3 = this.currentyear + 2;
        this.year4 = this.currentyear + 3;
        this.year5 = this.currentyear + 4;
        this.year6 = this.currentyear + 5;
        this.year7 = this.currentyear + 6;
        this.year8 = this.currentyear + 7;
        this.year9 = this.currentyear + 8;
        this.year10 = this.currentyear + 9;
    };
    ResourcesDemandComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources-demand',
            template: __webpack_require__(/*! ./resources-demand.component.html */ "./src/app/resources/resources-demand/resources-demand.component.html"),
            styles: [__webpack_require__(/*! ./resources-demand.component.scss */ "./src/app/resources/resources-demand/resources-demand.component.scss")]
        })
    ], ResourcesDemandComponent);
    return ResourcesDemandComponent;
}());



/***/ }),

/***/ "./src/app/resources/resources-routing.module.ts":
/*!*******************************************************!*\
  !*** ./src/app/resources/resources-routing.module.ts ***!
  \*******************************************************/
/*! exports provided: ResourcesRoutingModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesRoutingModule", function() { return ResourcesRoutingModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _resources_resources_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./resources/resources.component */ "./src/app/resources/resources/resources.component.ts");
/* harmony import */ var _resources_availability_resources_availability_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./resources-availability/resources-availability.component */ "./src/app/resources/resources-availability/resources-availability.component.ts");
/* harmony import */ var _resources_utilization_resources_utilization_component__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./resources-utilization/resources-utilization.component */ "./src/app/resources/resources-utilization/resources-utilization.component.ts");
/* harmony import */ var _resources_demand_resources_demand_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./resources-demand/resources-demand.component */ "./src/app/resources/resources-demand/resources-demand.component.ts");
/* harmony import */ var _resources_dashboard_resources_dashboard_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./resources-dashboard/resources-dashboard.component */ "./src/app/resources/resources-dashboard/resources-dashboard.component.ts");








var routes = [
    {
        path: '',
        children: [
            {
                path: 'dashbaord',
                component: _resources_dashboard_resources_dashboard_component__WEBPACK_IMPORTED_MODULE_7__["ResourcesDashboardComponent"],
                data: {
                    title: 'Dashboard'
                }
            },
            {
                path: 'resources',
                component: _resources_resources_component__WEBPACK_IMPORTED_MODULE_3__["ResourcesComponent"],
                data: {
                    title: 'Resource Pool'
                }
            },
            {
                path: 'demand',
                component: _resources_demand_resources_demand_component__WEBPACK_IMPORTED_MODULE_6__["ResourcesDemandComponent"],
                data: {
                    title: 'Demand'
                }
            },
            {
                path: 'availability',
                component: _resources_availability_resources_availability_component__WEBPACK_IMPORTED_MODULE_4__["ResourcesAvailabilityComponent"],
                data: {
                    title: 'Availability'
                }
            },
            {
                path: 'utilization',
                component: _resources_utilization_resources_utilization_component__WEBPACK_IMPORTED_MODULE_5__["ResourcesUtilizationComponent"],
                data: {
                    title: 'Utilization'
                }
            },
        ]
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

// export const routedComponents = [ResourcesComponent];


/***/ }),

/***/ "./src/app/resources/resources-utilization-table/resources-utilization-table.component.html":
/*!**************************************************************************************************!*\
  !*** ./src/app/resources/resources-utilization-table/resources-utilization-table.component.html ***!
  \**************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<table  #exampleTableTools class=\"table table-hover table-responsive-md text-center dataTable \" datatable [dtOptions]=\"dtOptions\"\r\n              [dtTrigger]=\"dtTrigger\" id=\"exampleTableTools\">\r\n                <thead>\r\n                  <tr>\r\n                    <th>#</th>\r\n                    <th></th>\r\n                    <th>First Name</th>\r\n                    <th>Last Name</th>\r\n                    <th>Gender</th>\r\n                    <th>Email</th>\r\n                    <th>Actions</th>\r\n                  </tr>\r\n                </thead>\r\n                <tbody>\r\n                  <tr>\r\n                    <td>1</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item1\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item1\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>John</td>\r\n                    <td>Carter</td>\r\n                    <td>Male</td>\r\n                    <td>johncarter@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                  <tr>\r\n                    <td>2</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item2\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item2\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>Peter</td>\r\n                    <td>Parker</td>\r\n                    <td>Male</td>\r\n                    <td>peterparker@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                  <tr>\r\n                    <td>3</td>\r\n                    <td>\r\n                      <div class=\"custom-control custom-checkbox m-0\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\" id=\"item3\">\r\n                        <label class=\"custom-control-label col-form-label\" for=\"item3\"></label>\r\n                      </div>\r\n                    </td>\r\n                    <td>John</td>\r\n                    <td>Rambo</td>\r\n                    <td>Male</td>\r\n                    <td>johnrambo@mail.com</td>\r\n                    <td>\r\n                      <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                      <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                        <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                      </a>\r\n                    </td>\r\n                  </tr>\r\n                </tbody>\r\n              </table>\r\n"

/***/ }),

/***/ "./src/app/resources/resources-utilization-table/resources-utilization-table.component.scss":
/*!**************************************************************************************************!*\
  !*** ./src/app/resources/resources-utilization-table/resources-utilization-table.component.scss ***!
  \**************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Jlc291cmNlcy9yZXNvdXJjZXMtdXRpbGl6YXRpb24tdGFibGUvcmVzb3VyY2VzLXV0aWxpemF0aW9uLXRhYmxlLmNvbXBvbmVudC5zY3NzIn0= */"

/***/ }),

/***/ "./src/app/resources/resources-utilization-table/resources-utilization-table.component.ts":
/*!************************************************************************************************!*\
  !*** ./src/app/resources/resources-utilization-table/resources-utilization-table.component.ts ***!
  \************************************************************************************************/
/*! exports provided: ResourcesUtilizationTableComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesUtilizationTableComponent", function() { return ResourcesUtilizationTableComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");



var ResourcesUtilizationTableComponent = /** @class */ (function () {
    function ResourcesUtilizationTableComponent() {
        this.dtOptions = {};
        // dtOptions: DataTables.Settings = {};
        this.dtTrigger = new rxjs__WEBPACK_IMPORTED_MODULE_2__["Subject"]();
    }
    // constructor() { }
    ResourcesUtilizationTableComponent.prototype.ngOnInit = function () {
        this.dtOptions = {
            pagingType: 'full_numbers',
            pageLength: 100,
            processing: true,
            'paging': true,
            'ordering': true,
            'info': true,
            'columnDefs': [{
                    'targets': [3],
                    'visible': true,
                    'searchable': true
                },
                {
                    'targets': [4],
                    'visible': true
                }
                // ,{ 'bSortable': true, 'bSort': false, 'aTargets': [ '_all' ] }
            ],
            // responsive: true,
            searching: true,
            select: true,
            order: [0, 'desc'],
            dom: "<\n             <\"row\"\n               <\"col-lg-3 col-md-12\"l>\n               <\"col-lg-6 col-md-12 button-wrapper btn-sm danger\"B>\n               <\"col-lg-3 col-md-12\"f>><hr>\n             <\"row\" <\"col\"t>>\n             <\"row\"\n               <\"col\"i>\n               <\"col btn-sm\"p>>\n             >",
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print',
                {
                    text: 'GroupBy',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
            ],
            'bLengthChange': true,
            'Filter': true,
            'Info': true,
            fixedHeader: {
                header: true,
                bottom: true,
                // footer: false,
                zTop: 1000
                // headerOffset: 400
            },
        };
        this.example = $(this.table.nativeElement);
        this.example.DataTable(this.dtOptions);
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('exampleTableTools'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Object)
    ], ResourcesUtilizationTableComponent.prototype, "table", void 0);
    ResourcesUtilizationTableComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources-utilization-table',
            template: __webpack_require__(/*! ./resources-utilization-table.component.html */ "./src/app/resources/resources-utilization-table/resources-utilization-table.component.html"),
            styles: [__webpack_require__(/*! ./resources-utilization-table.component.scss */ "./src/app/resources/resources-utilization-table/resources-utilization-table.component.scss")]
        })
    ], ResourcesUtilizationTableComponent);
    return ResourcesUtilizationTableComponent;
}());



/***/ }),

/***/ "./src/app/resources/resources-utilization/resources-utilization.component.html":
/*!**************************************************************************************!*\
  !*** ./src/app/resources/resources-utilization/resources-utilization.component.html ***!
  \**************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <h1 class=\"card-title m-1 pl-2 pull-left text-muted text-primary\">Resource Utilization</h1>\r\n</div>\r\n\r\n<section id=\"minimal-statistics-bg\">\r\n  <div class=\"row text-left\" matchHeight=\"card\">\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-warning\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-body white text-left\">\r\n                <h3>278</h3>\r\n                <span>New Projects</span>\r\n              </div>\r\n              <div class=\"media-right align-self-center\">\r\n                <i class=\"icon-rocket white font-large-2 float-right\"></i>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-success\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-body white text-left\">\r\n                <h3>156</h3>\r\n                <span>New Clients</span>\r\n              </div>\r\n              <div class=\"media-right align-self-center\">\r\n                <i class=\"icon-user white font-large-2 float-right\"></i>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-danger\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-body white text-left\">\r\n                <h3>64.89 %</h3>\r\n                <span>Conversion Rate</span>\r\n              </div>\r\n              <div class=\"media-right align-self-center\">\r\n                <i class=\"icon-pie-chart white font-large-2 float-right\"></i>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-primary\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-body white text-left\">\r\n                <h3>423</h3>\r\n                <span>Support Tickets</span>\r\n              </div>\r\n              <div class=\"media-right align-self-center\">\r\n                <i class=\"icon-support white font-large-2 float-right\"></i>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</section>\r\n<section id=\"extended\">\r\n    <div class=\"row text-left\">\r\n      <div class=\"col-sm-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n              <h2 class=\"card-title text-capitalize text-monospace\">Yearly Utilization</h2>\r\n          </div>\r\n          <div class=\"card-content p-2 m-2\">\r\n            <div class=\"card-body\">\r\n                <div classs =\"m-2 p-2\">\r\n                    <div classs =\"row\">\r\n                        <div class=\"col-12\">\r\n                            <ngb-tabset  type=\"pills\">\r\n                                <hr>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year1}} </b><span class=\"text-danger\">- Current year</span></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                      <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year2}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year3}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year4}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                    <ng-template ngbTabTitle><b>{{year5}}</b></ng-template>\r\n                                    <ng-template ngbTabContent>\r\n                                      <hr>\r\n                                      <app-resources-utilization-table></app-resources-utilization-table>\r\n                                    </ng-template>\r\n                                  </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year6}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year7}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year8}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year9}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                                <ngb-tab>\r\n                                  <ng-template ngbTabTitle><b>{{year10}}</b></ng-template>\r\n                                  <ng-template ngbTabContent>\r\n                                    <hr>\r\n                                    <app-resources-utilization-table></app-resources-utilization-table>\r\n                                  </ng-template>\r\n                                </ngb-tab>\r\n                            </ngb-tabset>\r\n                        </div>\r\n                    </div>\r\n                    </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </section>\r\n"

/***/ }),

/***/ "./src/app/resources/resources-utilization/resources-utilization.component.scss":
/*!**************************************************************************************!*\
  !*** ./src/app/resources/resources-utilization/resources-utilization.component.scss ***!
  \**************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ":host /deep/ .ct-grid {\n  stroke-dasharray: 0px;\n  stroke: rgba(0, 0, 0, 0.1); }\n\n:host /deep/ .ct-label {\n  font-size: 0.9rem; }\n\n:host /deep/ .lineArea .ct-series-a .ct-area {\n  fill-opacity: 0.7;\n  fill: url(\"/dashboard/dashboard1#gradient1\") !important; }\n\n:host /deep/ .lineArea .ct-series-b .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient\") !important;\n  fill-opacity: 0.9; }\n\n:host /deep/ .lineArea .ct-line {\n  stroke-width: 0px; }\n\n:host /deep/ .lineArea .ct-point {\n  stroke-width: 0px; }\n\n:host /deep/ .Stackbarchart .ct-series-a .ct-bar {\n  stroke: url(\"/dashboard/dashboard1#linear\") !important; }\n\n:host /deep/ .Stackbarchart .ct-series-b .ct-bar {\n  stroke: #e9e9e9; }\n\n:host /deep/ .lineArea2 .ct-series-a .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient2\") !important; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient3\") !important; }\n\n:host /deep/ .lineArea2 .ct-point-circle {\n  stroke-width: 2px;\n  fill: white; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-point-circle {\n  stroke: #843cf7; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-line {\n  stroke: #A675F4; }\n\n:host /deep/ .lineArea2 .ct-series-a .ct-point-circle {\n  stroke: #31afb2; }\n\n:host /deep/ .lineArea2 .ct-line {\n  fill: none;\n  stroke-width: 2px; }\n\n:host /deep/ .lineChart .ct-point-circle {\n  stroke-width: 2px;\n  fill: white; }\n\n:host /deep/ .lineChart .ct-series-a .ct-point-circle {\n  stroke: white; }\n\n:host /deep/ .lineChart .ct-line {\n  fill: none;\n  stroke: white;\n  stroke-width: 1px; }\n\n:host /deep/ .lineChart .ct-label {\n  color: #FFF; }\n\n:host /deep/ .lineChartShadow {\n  -webkit-filter: drop-shadow(0px 25px 8px rgba(0, 0, 0, 0.3));\n  filter: drop-shadow(0px 25px 8px rgba(0, 0, 0, 0.3));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n:host /deep/ .donut .ct-done .ct-slice-donut {\n  stroke: #0CC27E;\n  stroke-width: 24px !important; }\n\n:host /deep/ .donut .ct-progress .ct-slice-donut {\n  stroke: #FFC107;\n  stroke-width: 16px !important; }\n\n:host /deep/ .donut .ct-outstanding .ct-slice-donut {\n  stroke: #7E57C2;\n  stroke-width: 8px !important; }\n\n:host /deep/ .donut .ct-started .ct-slice-donut {\n  stroke: #2196F3;\n  stroke-width: 32px !important; }\n\n:host /deep/ .donut .ct-label {\n  text-anchor: middle;\n  alignment-baseline: middle;\n  font-size: 20px;\n  fill: #868e96; }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+1) {\n  stroke: url(\"/dashboard/dashboard1#gradient7\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+2) {\n  stroke: url(\"/dashboard/dashboard1#gradient5\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+3) {\n  stroke: url(\"/dashboard/dashboard1#gradient6\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+4) {\n  stroke: url(\"/dashboard/dashboard1#gradient4\"); }\n\n:host /deep/ .BarChartShadow {\n  -webkit-filter: drop-shadow(0px 20px 8px rgba(0, 0, 0, 0.3));\n  filter: drop-shadow(0px 20px 8px rgba(0, 0, 0, 0.3));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n:host /deep/ .WidgetlineChart .ct-point {\n  stroke-width: 0px; }\n\n:host /deep/ .WidgetlineChart .ct-line {\n  stroke: #fff; }\n\n:host /deep/ .WidgetlineChart .ct-grid {\n  stroke-dasharray: 0px;\n  stroke: rgba(255, 255, 255, 0.2); }\n\n:host /deep/ .WidgetlineChartshadow {\n  -webkit-filter: drop-shadow(0px 15px 5px rgba(0, 0, 0, 0.8));\n  filter: drop-shadow(0px 15px 5px rgba(0, 0, 0, 0.8));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n.noshow {\n  display: none; }\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcmVzb3VyY2VzL3Jlc291cmNlcy11dGlsaXphdGlvbi9DOlxcVXNlcnNcXE5kaWFuYW5pZVxcR2l0XFxQcm9qZWN0VXBkYXRlc1xcUFRBbmd1bGFyXFxwcm9qZWN0dXBkYXRlc2Zyb250ZW5kL3NyY1xcYXBwXFxyZXNvdXJjZXNcXHJlc291cmNlcy11dGlsaXphdGlvblxccmVzb3VyY2VzLXV0aWxpemF0aW9uLmNvbXBvbmVudC5zY3NzIiwic3JjL2FwcC9yZXNvdXJjZXMvcmVzb3VyY2VzLXV0aWxpemF0aW9uL3Jlc291cmNlcy11dGlsaXphdGlvbi5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFFQTtFQUNJLHFCQUFxQjtFQUNyQiwwQkFBMEIsRUFBQTs7QUFHOUI7RUFDSSxpQkFBaUIsRUFBQTs7QUFLckI7RUFDSSxpQkFBaUI7RUFDakIsdURBQTRELEVBQUE7O0FBR2hFO0VBQ0ksc0RBQTREO0VBQzVELGlCQUFpQixFQUFBOztBQUVyQjtFQUNJLGlCQUFpQixFQUFBOztBQUVyQjtFQUNJLGlCQUFpQixFQUFBOztBQU9yQjtFQUdZLHNEQUE0RCxFQUFBOztBQUh4RTtFQVFZLGVBQWUsRUFBQTs7QUFTM0I7RUFDSSx1REFBNkQsRUFBQTs7QUFHakU7RUFDSSx1REFBNkQsRUFBQTs7QUFHakU7RUFDSSxpQkFBaUI7RUFDakIsV0FBVyxFQUFBOztBQUdmO0VBQ0ksZUFBZSxFQUFBOztBQUduQjtFQUNJLGVBQWUsRUFBQTs7QUFHbkI7RUFDSSxlQUFlLEVBQUE7O0FBR25CO0VBQ0ksVUFBVTtFQUNWLGlCQUFpQixFQUFBOztBQU9yQjtFQUNJLGlCQUFpQjtFQUNqQixXQUFXLEVBQUE7O0FBR2Y7RUFDSSxhQUFhLEVBQUE7O0FBR2pCO0VBQ0ksVUFBVTtFQUNWLGFBQWE7RUFDYixpQkFBaUIsRUFBQTs7QUFHckI7RUFDSSxXQUFXLEVBQUE7O0FBR2Y7RUFDSSw0REFBMkQ7RUFDbkQsb0RBQW1EO0VBQUU7Z0ZDcENlLEVEcUNDOztBQU0vRTtFQUNFLGVBQWU7RUFDZiw2QkFBNkIsRUFBQTs7QUFFL0I7RUFDRSxlQUFlO0VBQ2YsNkJBQTZCLEVBQUE7O0FBRS9CO0VBQ0UsZUFBZTtFQUNmLDRCQUE0QixFQUFBOztBQUc5QjtFQUNFLGVBQWU7RUFDZiw2QkFBNkIsRUFBQTs7QUFHL0I7RUFDRSxtQkFBbUI7RUFDbkIsMEJBQTBCO0VBQzFCLGVBQWU7RUFDZixhQUFhLEVBQUE7O0FBT2Y7RUFDRSw4Q0FBb0QsRUFBQTs7QUFFdEQ7RUFDRSw4Q0FBb0QsRUFBQTs7QUFFdEQ7RUFDRSw4Q0FBb0QsRUFBQTs7QUFFdEQ7RUFDRSw4Q0FBb0QsRUFBQTs7QUFHdEQ7RUFDRSw0REFBMkQ7RUFDbkQsb0RBQW1EO0VBQUU7Z0ZDL0NlLEVEZ0RDOztBQU9qRjtFQUNJLGlCQUFpQixFQUFBOztBQUVyQjtFQUNJLFlBQVksRUFBQTs7QUFJaEI7RUFDSSxxQkFBcUI7RUFDcEIsZ0NBQWdDLEVBQUE7O0FBR3JDO0VBQ0ksNERBQTJEO0VBQ25ELG9EQUFtRDtFQUFFO2dGQ3REZSxFRHVEQzs7QUFLakY7RUFDRSxhQUFhLEVBQUEiLCJmaWxlIjoic3JjL2FwcC9yZXNvdXJjZXMvcmVzb3VyY2VzLXV0aWxpemF0aW9uL3Jlc291cmNlcy11dGlsaXphdGlvbi5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIkBpbXBvcnQgXCIuLi8uLi8uLi9hc3NldHMvc2Fzcy9zY3NzL2dyYWRpZW50LXZhcmlhYmxlc1wiO1xyXG5cclxuOmhvc3QgL2RlZXAvIC5jdC1ncmlke1xyXG4gICAgc3Ryb2tlLWRhc2hhcnJheTogMHB4O1xyXG4gICAgc3Ryb2tlOiByZ2JhKDAsIDAsIDAsIDAuMSk7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAuY3QtbGFiZWx7XHJcbiAgICBmb250LXNpemU6IDAuOXJlbTtcclxufVxyXG5cclxuLy8gTGluZSB3aXRoIEFyZWEgQ2hhcnQgQ1NTIFN0YXJ0c1xyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3Qtc2VyaWVzLWEgLmN0LWFyZWEge1xyXG4gICAgZmlsbC1vcGFjaXR5OiAwLjc7XHJcbiAgICBmaWxsOnVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudDEpICFpbXBvcnRhbnQ7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LXNlcmllcy1iIC5jdC1hcmVhIHtcclxuICAgIGZpbGw6IHVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudCkgIWltcG9ydGFudDtcclxuICAgIGZpbGwtb3BhY2l0eTogMC45O1xyXG59XHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LWxpbmV7XHJcbiAgICBzdHJva2Utd2lkdGg6IDBweDtcclxufVxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1wb2ludCB7XHJcbiAgICBzdHJva2Utd2lkdGg6IDBweDtcclxufVxyXG5cclxuLy8gTGluZSB3aXRoIEFyZWEgQ2hhcnQgMSBDU1MgRW5kc1xyXG5cclxuLy8gU3RhY2sgQmFyIENoYXJ0IENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAuU3RhY2tiYXJjaGFydHtcclxuICAgIC5jdC1zZXJpZXMtYSB7XHJcbiAgICAgICAgLmN0LWJhcntcclxuICAgICAgICAgICAgc3Ryb2tlOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjbGluZWFyKSAhaW1wb3J0YW50XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG4gICAgLmN0LXNlcmllcy1iIHtcclxuICAgICAgICAuY3QtYmFye1xyXG4gICAgICAgICAgICBzdHJva2U6ICNlOWU5ZTk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcblxyXG4vLyBTdGFjayBCYXIgQ2hhcnQgQ1NTIEVuZHNcclxuXHJcbi8vIExpbmUgd2l0aCBBcmVhIENoYXJ0IDIgQ1NTIFN0YXJ0c1xyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1hIC5jdC1hcmVhIHtcclxuICAgIGZpbGw6IHVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudDIpICFpbXBvcnRhbnQ7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYiAuY3QtYXJlYSB7XHJcbiAgICBmaWxsOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQzKSAhaW1wb3J0YW50O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3QtcG9pbnQtY2lyY2xlIHtcclxuICAgIHN0cm9rZS13aWR0aDogMnB4O1xyXG4gICAgZmlsbDogd2hpdGU7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYiAuY3QtcG9pbnQtY2lyY2xle1xyXG4gICAgc3Ryb2tlOiAjODQzY2Y3O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LWxpbmV7XHJcbiAgICBzdHJva2U6ICNBNjc1RjQ7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYSAuY3QtcG9pbnQtY2lyY2xlIHtcclxuICAgIHN0cm9rZTogIzMxYWZiMjtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LWxpbmUge1xyXG4gICAgZmlsbDogbm9uZTtcclxuICAgIHN0cm9rZS13aWR0aDogMnB4O1xyXG59XHJcblxyXG4vLyBMaW5lIHdpdGggQXJlYSBDaGFydCAyIENTUyBFbmRzXHJcblxyXG4vLyBMaW5lIENoYXJ0IENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1wb2ludC1jaXJjbGUge1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAycHg7XHJcbiAgICBmaWxsOiB3aGl0ZTtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1wb2ludC1jaXJjbGUge1xyXG4gICAgc3Ryb2tlOiB3aGl0ZTtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LWxpbmUge1xyXG4gICAgZmlsbDogbm9uZTtcclxuICAgIHN0cm9rZTogd2hpdGU7XHJcbiAgICBzdHJva2Utd2lkdGg6IDFweDtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LWxhYmVsIHtcclxuICAgIGNvbG9yOiAjRkZGO1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydFNoYWRvdyB7XHJcbiAgICAtd2Via2l0LWZpbHRlcjogZHJvcC1zaGFkb3coIDBweCAyNXB4IDhweCByZ2JhKDAsMCwwLDAuMykgKTtcclxuICAgICAgICAgICAgZmlsdGVyOiBkcm9wLXNoYWRvdyggMHB4IDI1cHggOHB4IHJnYmEoMCwwLDAsMC4zKSApOyAvKiBTYW1lIHN5bnRheCBhcyBib3gtc2hhZG93LCBleGNlcHRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZvciB0aGUgc3ByZWFkIHByb3BlcnR5ICovXHJcbn1cclxuXHJcbi8vIExpbmUgQ2hhcnQgIENTUyBFbmRzXHJcblxyXG4gIC8vIERvbnV0IENoYXJ0ICBDU1MgRW5kc1xyXG4gIDpob3N0IC9kZWVwLyAuZG9udXQgLmN0LWRvbmUgLmN0LXNsaWNlLWRvbnV0IHtcclxuICAgIHN0cm9rZTogIzBDQzI3RTtcclxuICAgIHN0cm9rZS13aWR0aDogMjRweCAhaW1wb3J0YW50O1xyXG4gIH1cclxuICA6aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1wcm9ncmVzcyAuY3Qtc2xpY2UtZG9udXQge1xyXG4gICAgc3Ryb2tlOiAjRkZDMTA3O1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAxNnB4ICFpbXBvcnRhbnQ7XHJcbiAgfVxyXG4gIDpob3N0IC9kZWVwLyAuZG9udXQgLmN0LW91dHN0YW5kaW5nIC5jdC1zbGljZS1kb251dCB7XHJcbiAgICBzdHJva2U6ICM3RTU3QzI7XHJcbiAgICBzdHJva2Utd2lkdGg6IDhweCAhaW1wb3J0YW50O1xyXG4gIH1cclxuXHJcbiAgOmhvc3QgL2RlZXAvIC5kb251dCAuY3Qtc3RhcnRlZCAuY3Qtc2xpY2UtZG9udXQge1xyXG4gICAgc3Ryb2tlOiAjMjE5NkYzO1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAzMnB4ICFpbXBvcnRhbnQ7XHJcbiAgfVxyXG5cclxuICA6aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1sYWJlbCB7XHJcbiAgICB0ZXh0LWFuY2hvcjogbWlkZGxlO1xyXG4gICAgYWxpZ25tZW50LWJhc2VsaW5lOiBtaWRkbGU7XHJcbiAgICBmb250LXNpemU6IDIwcHg7XHJcbiAgICBmaWxsOiAjODY4ZTk2O1xyXG4gIH1cclxuXHJcbiAgLy8gRG9udXQgQ2hhcnQgIENTUyBFbmRzXHJcblxyXG4gIC8vIEJhciBDaGFydCBDU1MgU3RhcnRzXHJcblxyXG4gIDpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rMSkge1xyXG4gICAgc3Ryb2tlOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQ3KTtcclxuICB9XHJcbiAgOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0bisyKSB7XHJcbiAgICBzdHJva2U6IHVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudDUpO1xyXG4gIH1cclxuICA6aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzMpIHtcclxuICAgIHN0cm9rZTogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2dyYWRpZW50Nik7XHJcbiAgfVxyXG4gIDpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rNCkge1xyXG4gICAgc3Ryb2tlOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQ0KTtcclxuICB9XHJcblxyXG4gIDpob3N0IC9kZWVwLyAuQmFyQ2hhcnRTaGFkb3cge1xyXG4gICAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMjBweCA4cHggcmdiYSgwLDAsMCwwLjMpICk7XHJcbiAgICAgICAgICAgIGZpbHRlcjogZHJvcC1zaGFkb3coIDBweCAyMHB4IDhweCByZ2JhKDAsMCwwLDAuMykgKTsgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqL1xyXG59XHJcblxyXG4vLyBCYXIgQ2hhcnQgQ1NTIEVuZHNcclxuXHJcbi8vIFdpZGdldCBsaW5lIENoYXJ0IENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1wb2ludCB7XHJcbiAgICBzdHJva2Utd2lkdGg6IDBweDtcclxufVxyXG46aG9zdCAvZGVlcC8gLldpZGdldGxpbmVDaGFydCAuY3QtbGluZXtcclxuICAgIHN0cm9rZTogI2ZmZjtcclxufVxyXG5cclxuXHJcbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1ncmlkIHtcclxuICAgIHN0cm9rZS1kYXNoYXJyYXk6IDBweDtcclxuICAgICBzdHJva2U6IHJnYmEoMjU1LCAyNTUsIDI1NSwgMC4yKTtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnRzaGFkb3cge1xyXG4gICAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMTVweCA1cHggcmdiYSgwLDAsMCwwLjgpICk7XHJcbiAgICAgICAgICAgIGZpbHRlcjogZHJvcC1zaGFkb3coIDBweCAxNXB4IDVweCByZ2JhKDAsMCwwLDAuOCkgKTsgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqL1xyXG59XHJcblxyXG4vLyBXaWRnZXQgbGluZSBDaGFydCBDU1MgRW5kc1xyXG5cclxuLm5vc2hvdyB7XHJcbiAgZGlzcGxheTogbm9uZTtcclxufVxyXG4iLCI6aG9zdCAvZGVlcC8gLmN0LWdyaWQge1xuICBzdHJva2UtZGFzaGFycmF5OiAwcHg7XG4gIHN0cm9rZTogcmdiYSgwLCAwLCAwLCAwLjEpOyB9XG5cbjpob3N0IC9kZWVwLyAuY3QtbGFiZWwge1xuICBmb250LXNpemU6IDAuOXJlbTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1zZXJpZXMtYSAuY3QtYXJlYSB7XG4gIGZpbGwtb3BhY2l0eTogMC43O1xuICBmaWxsOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQxXCIpICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3Qtc2VyaWVzLWIgLmN0LWFyZWEge1xuICBmaWxsOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnRcIikgIWltcG9ydGFudDtcbiAgZmlsbC1vcGFjaXR5OiAwLjk7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3QtbGluZSB7XG4gIHN0cm9rZS13aWR0aDogMHB4OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LXBvaW50IHtcbiAgc3Ryb2tlLXdpZHRoOiAwcHg7IH1cblxuOmhvc3QgL2RlZXAvIC5TdGFja2JhcmNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyIHtcbiAgc3Ryb2tlOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjbGluZWFyXCIpICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5TdGFja2JhcmNoYXJ0IC5jdC1zZXJpZXMtYiAuY3QtYmFyIHtcbiAgc3Ryb2tlOiAjZTllOWU5OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYSAuY3QtYXJlYSB7XG4gIGZpbGw6IHVybChcIi9kYXNoYm9hcmQvZGFzaGJvYXJkMSNncmFkaWVudDJcIikgIWltcG9ydGFudDsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LWFyZWEge1xuICBmaWxsOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQzXCIpICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXBvaW50LWNpcmNsZSB7XG4gIHN0cm9rZS13aWR0aDogMnB4O1xuICBmaWxsOiB3aGl0ZTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LXBvaW50LWNpcmNsZSB7XG4gIHN0cm9rZTogIzg0M2NmNzsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LWxpbmUge1xuICBzdHJva2U6ICNBNjc1RjQ7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1hIC5jdC1wb2ludC1jaXJjbGUge1xuICBzdHJva2U6ICMzMWFmYjI7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LWxpbmUge1xuICBmaWxsOiBub25lO1xuICBzdHJva2Utd2lkdGg6IDJweDsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3QtcG9pbnQtY2lyY2xlIHtcbiAgc3Ryb2tlLXdpZHRoOiAycHg7XG4gIGZpbGw6IHdoaXRlOyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtcG9pbnQtY2lyY2xlIHtcbiAgc3Ryb2tlOiB3aGl0ZTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3QtbGluZSB7XG4gIGZpbGw6IG5vbmU7XG4gIHN0cm9rZTogd2hpdGU7XG4gIHN0cm9rZS13aWR0aDogMXB4OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1sYWJlbCB7XG4gIGNvbG9yOiAjRkZGOyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0U2hhZG93IHtcbiAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KDBweCAyNXB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMykpO1xuICBmaWx0ZXI6IGRyb3Atc2hhZG93KDBweCAyNXB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMykpO1xuICAvKiBTYW1lIHN5bnRheCBhcyBib3gtc2hhZG93LCBleGNlcHRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZvciB0aGUgc3ByZWFkIHByb3BlcnR5ICovIH1cblxuOmhvc3QgL2RlZXAvIC5kb251dCAuY3QtZG9uZSAuY3Qtc2xpY2UtZG9udXQge1xuICBzdHJva2U6ICMwQ0MyN0U7XG4gIHN0cm9rZS13aWR0aDogMjRweCAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAuZG9udXQgLmN0LXByb2dyZXNzIC5jdC1zbGljZS1kb251dCB7XG4gIHN0cm9rZTogI0ZGQzEwNztcbiAgc3Ryb2tlLXdpZHRoOiAxNnB4ICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5kb251dCAuY3Qtb3V0c3RhbmRpbmcgLmN0LXNsaWNlLWRvbnV0IHtcbiAgc3Ryb2tlOiAjN0U1N0MyO1xuICBzdHJva2Utd2lkdGg6IDhweCAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAuZG9udXQgLmN0LXN0YXJ0ZWQgLmN0LXNsaWNlLWRvbnV0IHtcbiAgc3Ryb2tlOiAjMjE5NkYzO1xuICBzdHJva2Utd2lkdGg6IDMycHggIWltcG9ydGFudDsgfVxuXG46aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1sYWJlbCB7XG4gIHRleHQtYW5jaG9yOiBtaWRkbGU7XG4gIGFsaWdubWVudC1iYXNlbGluZTogbWlkZGxlO1xuICBmb250LXNpemU6IDIwcHg7XG4gIGZpbGw6ICM4NjhlOTY7IH1cblxuOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0bisxKSB7XG4gIHN0cm9rZTogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50N1wiKTsgfVxuXG46aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzIpIHtcbiAgc3Ryb2tlOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQ1XCIpOyB9XG5cbjpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rMykge1xuICBzdHJva2U6IHVybChcIi9kYXNoYm9hcmQvZGFzaGJvYXJkMSNncmFkaWVudDZcIik7IH1cblxuOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0bis0KSB7XG4gIHN0cm9rZTogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50NFwiKTsgfVxuXG46aG9zdCAvZGVlcC8gLkJhckNoYXJ0U2hhZG93IHtcbiAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KDBweCAyMHB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMykpO1xuICBmaWx0ZXI6IGRyb3Atc2hhZG93KDBweCAyMHB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMykpO1xuICAvKiBTYW1lIHN5bnRheCBhcyBib3gtc2hhZG93LCBleGNlcHRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZvciB0aGUgc3ByZWFkIHByb3BlcnR5ICovIH1cblxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnQgLmN0LXBvaW50IHtcbiAgc3Ryb2tlLXdpZHRoOiAwcHg7IH1cblxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnQgLmN0LWxpbmUge1xuICBzdHJva2U6ICNmZmY7IH1cblxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnQgLmN0LWdyaWQge1xuICBzdHJva2UtZGFzaGFycmF5OiAwcHg7XG4gIHN0cm9rZTogcmdiYSgyNTUsIDI1NSwgMjU1LCAwLjIpOyB9XG5cbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0c2hhZG93IHtcbiAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KDBweCAxNXB4IDVweCByZ2JhKDAsIDAsIDAsIDAuOCkpO1xuICBmaWx0ZXI6IGRyb3Atc2hhZG93KDBweCAxNXB4IDVweCByZ2JhKDAsIDAsIDAsIDAuOCkpO1xuICAvKiBTYW1lIHN5bnRheCBhcyBib3gtc2hhZG93LCBleGNlcHRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZvciB0aGUgc3ByZWFkIHByb3BlcnR5ICovIH1cblxuLm5vc2hvdyB7XG4gIGRpc3BsYXk6IG5vbmU7IH1cbiJdfQ== */"

/***/ }),

/***/ "./src/app/resources/resources-utilization/resources-utilization.component.ts":
/*!************************************************************************************!*\
  !*** ./src/app/resources/resources-utilization/resources-utilization.component.ts ***!
  \************************************************************************************/
/*! exports provided: ResourcesUtilizationComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourcesUtilizationComponent", function() { return ResourcesUtilizationComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! chartist */ "./node_modules/chartist/dist/chartist.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(chartist__WEBPACK_IMPORTED_MODULE_2__);



var data = __webpack_require__(/*! ../../shared/data/chartist.json */ "./src/app/shared/data/chartist.json");
var ResourcesUtilizationComponent = /** @class */ (function () {
    function ResourcesUtilizationComponent() {
        this.previous = false;
        this.current = false;
        this.future = false;
        // constructor() { }
        // Line chart configuration Starts
        this.WidgetlineChart = {
            type: 'Line', data: data['WidgetlineChart2'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart1 = {
            type: 'Line', data: data['WidgetlineChart3'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true,
                chartPadding: { top: 0, right: 0, bottom: 10, left: 0 }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart2 = {
            type: 'Line', data: data['WidgetlineChart'],
            options: {
                axisX: {
                    showGrid: true,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 40,
                    showLabel: false,
                    offset: 0,
                },
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_2__["Interpolation"].cardinal({
                    tension: 0
                }),
                fullWidth: true
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient1',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart1 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 0,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9c9';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart2 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 90,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9e7';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart3 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 270,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue964';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Line area chart configuration Starts
        this.lineAreaChart = {
            type: 'Line',
            data: data['lineArea3'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(38, 198, 218, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                }
            },
        };
        // Line area chart configuration Ends
        // Line chart configuration Starts
        this.lineChart2 = {
            type: 'Line', data: data['line2'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.lineChart1 = {
            type: 'Line', data: data['line1'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line area chart configuration Starts
        this.lineArea = {
            type: 'Line',
            data: data['lineAreaDashboard'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(146, 254, 157, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient1',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line area chart configuration Ends
        // Stacked Bar chart configuration Starts
        this.Stackbarchart = {
            type: 'Bar',
            data: data['Stackbarchart'],
            options: {
                stackBars: true,
                fullWidth: true,
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                chartPadding: 30
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'linear',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
                draw: function (data) {
                    if (data.type === 'bar') {
                        data.element.attr({
                            style: 'stroke-width: 5px',
                            x1: data.x1 + 0.001
                        });
                    }
                    else if (data.type === 'label') {
                        data.element.attr({
                            y: 270
                        });
                    }
                }
            },
        };
        // Stacked Bar chart configuration Ends
        // Line area chart 2 configuration Starts
        this.lineArea2 = {
            type: 'Line',
            data: data['lineArea2'],
            options: {
                showArea: true,
                fullWidth: true,
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_2__["Interpolation"].none(),
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                }
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient2',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient3',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0.3,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line area chart 2 configuration Ends
        // Line chart configuration Starts
        this.lineChart = {
            type: 'Line', data: data['LineDashboard'],
            options: {
                axisX: {
                    showGrid: false
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    low: 0,
                    high: 100,
                    offset: 0,
                },
                fullWidth: true,
                offset: 0,
            },
            events: {
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_2__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart = {
            type: 'Pie',
            data: data['donutDashboard'],
            options: {
                donut: true,
                startAngle: 0,
                labelInterpolationFnc: function (value) {
                    var total = data['donutDashboard'].series.reduce(function (prev, series) {
                        return prev + series.value;
                    }, 0);
                    return total + '%';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: data.element.root().height() / 2
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        //  Bar chart configuration Starts
        this.BarChart = {
            type: 'Bar', data: data['DashboardBar'], options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                low: 0,
                high: 60,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px)', {
                        seriesBarDistance: 5,
                        axisX: {
                            labelInterpolationFnc: function (value) {
                                return value[0];
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient4',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(238, 9, 121,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 106, 0, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient5',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 75, 145,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(120, 204, 55, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient6',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient7',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(155, 60, 183,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 57, 111, 1)'
                    });
                },
                draw: function (data) {
                    var barHorizontalCenter, barVerticalCenter, label, value;
                    if (data.type === 'bar') {
                        data.element.attr({
                            y1: 195,
                            x1: data.x1 + 0.001
                        });
                    }
                }
            },
        };
    }
    // Bar chart configuration Ends
    ResourcesUtilizationComponent.prototype.ngOnInit = function () {
        this.currentyear = 2005;
        this.year1 = this.currentyear;
        this.year2 = this.currentyear + 1;
        this.year3 = this.currentyear + 2;
        this.year4 = this.currentyear + 3;
        this.year5 = this.currentyear + 4;
        this.year6 = this.currentyear + 5;
        this.year7 = this.currentyear + 6;
        this.year8 = this.currentyear + 7;
        this.year9 = this.currentyear + 8;
        this.year10 = this.currentyear + 9;
    };
    ResourcesUtilizationComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-resources-utilization',
            template: __webpack_require__(/*! ./resources-utilization.component.html */ "./src/app/resources/resources-utilization/resources-utilization.component.html"),
            styles: [__webpack_require__(/*! ./resources-utilization.component.scss */ "./src/app/resources/resources-utilization/resources-utilization.component.scss")]
        })
    ], ResourcesUtilizationComponent);
    return ResourcesUtilizationComponent;
}());



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
/* harmony import */ var app_shared_shared_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! app/shared/shared.module */ "./src/app/shared/shared.module.ts");
/* harmony import */ var ng_chartist__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ng-chartist */ "./node_modules/ng-chartist/dist/ng-chartist.js");
/* harmony import */ var ng_chartist__WEBPACK_IMPORTED_MODULE_6___default = /*#__PURE__*/__webpack_require__.n(ng_chartist__WEBPACK_IMPORTED_MODULE_6__);
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var app_shared_directives_match_height_directive__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! app/shared/directives/match-height.directive */ "./src/app/shared/directives/match-height.directive.ts");
/* harmony import */ var _resources_availability_resources_availability_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./resources-availability/resources-availability.component */ "./src/app/resources/resources-availability/resources-availability.component.ts");
/* harmony import */ var _resources_utilization_resources_utilization_component__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./resources-utilization/resources-utilization.component */ "./src/app/resources/resources-utilization/resources-utilization.component.ts");
/* harmony import */ var _resources_demand_resources_demand_component__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./resources-demand/resources-demand.component */ "./src/app/resources/resources-demand/resources-demand.component.ts");
/* harmony import */ var _resources_availability_table_resources_availability_table_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./resources-availability-table/resources-availability-table.component */ "./src/app/resources/resources-availability-table/resources-availability-table.component.ts");
/* harmony import */ var _resources_demand_table_resources_demand_table_component__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! ./resources-demand-table/resources-demand-table.component */ "./src/app/resources/resources-demand-table/resources-demand-table.component.ts");
/* harmony import */ var _resources_utilization_table_resources_utilization_table_component__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! ./resources-utilization-table/resources-utilization-table.component */ "./src/app/resources/resources-utilization-table/resources-utilization-table.component.ts");
/* harmony import */ var _resources_absences_table_resources_absences_table_component__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! ./resources-absences-table/resources-absences-table.component */ "./src/app/resources/resources-absences-table/resources-absences-table.component.ts");
/* harmony import */ var _resource_resource_absences_table_resource_absences_table_component__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! ./resource/resource-absences-table/resource-absences-table.component */ "./src/app/resources/resource/resource-absences-table/resource-absences-table.component.ts");
/* harmony import */ var _resource_resource_absences_resource_absences_component__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! ./resource/resource-absences/resource-absences.component */ "./src/app/resources/resource/resource-absences/resource-absences.component.ts");
/* harmony import */ var _resource_resource_demand_resource_demand_component__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! ./resource/resource-demand/resource-demand.component */ "./src/app/resources/resource/resource-demand/resource-demand.component.ts");
/* harmony import */ var _resource_resource_availability_table_resource_availability_table_component__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! ./resource/resource-availability-table/resource-availability-table.component */ "./src/app/resources/resource/resource-availability-table/resource-availability-table.component.ts");
/* harmony import */ var _resource_resource_availability_resource_availability_component__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./resource/resource-availability/resource-availability.component */ "./src/app/resources/resource/resource-availability/resource-availability.component.ts");
/* harmony import */ var _resource_resource_utilization_resource_utilization_component__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! ./resource/resource-utilization/resource-utilization.component */ "./src/app/resources/resource/resource-utilization/resource-utilization.component.ts");
/* harmony import */ var _resource_resource_utilization_table_resource_utilization_table_component__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! ./resource/resource-utilization-table/resource-utilization-table.component */ "./src/app/resources/resource/resource-utilization-table/resource-utilization-table.component.ts");
/* harmony import */ var _resources_service__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! ./resources.service */ "./src/app/resources/resources.service.ts");
/* harmony import */ var _resource_new_resource_component__WEBPACK_IMPORTED_MODULE_24__ = __webpack_require__(/*! ./resource/new-resource.component */ "./src/app/resources/resource/new-resource.component.ts");
/* harmony import */ var _resource_edit_resource_component__WEBPACK_IMPORTED_MODULE_25__ = __webpack_require__(/*! ./resource/edit-resource.component */ "./src/app/resources/resource/edit-resource.component.ts");
/* harmony import */ var _resource_delete_resource_component__WEBPACK_IMPORTED_MODULE_26__ = __webpack_require__(/*! ./resource/delete-resource.component */ "./src/app/resources/resource/delete-resource.component.ts");
/* harmony import */ var _resources_dashboard_resources_dashboard_component__WEBPACK_IMPORTED_MODULE_27__ = __webpack_require__(/*! ./resources-dashboard/resources-dashboard.component */ "./src/app/resources/resources-dashboard/resources-dashboard.component.ts");




























var ResourcesModule = /** @class */ (function () {
    function ResourcesModule() {
    }
    ResourcesModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            declarations: [_resources_resources_component__WEBPACK_IMPORTED_MODULE_3__["ResourcesComponent"],
                _resources_availability_resources_availability_component__WEBPACK_IMPORTED_MODULE_9__["ResourcesAvailabilityComponent"], _resources_utilization_resources_utilization_component__WEBPACK_IMPORTED_MODULE_10__["ResourcesUtilizationComponent"], _resources_demand_resources_demand_component__WEBPACK_IMPORTED_MODULE_11__["ResourcesDemandComponent"],
                _resources_availability_table_resources_availability_table_component__WEBPACK_IMPORTED_MODULE_12__["ResourcesAvailabilityTableComponent"], _resources_demand_table_resources_demand_table_component__WEBPACK_IMPORTED_MODULE_13__["ResourcesDemandTableComponent"], _resources_utilization_table_resources_utilization_table_component__WEBPACK_IMPORTED_MODULE_14__["ResourcesUtilizationTableComponent"],
                _resources_absences_table_resources_absences_table_component__WEBPACK_IMPORTED_MODULE_15__["ResourcesAbsencesTableComponent"], _resource_resource_absences_table_resource_absences_table_component__WEBPACK_IMPORTED_MODULE_16__["ResourceAbsencesTableComponent"], _resource_resource_absences_resource_absences_component__WEBPACK_IMPORTED_MODULE_17__["ResourceAbsencesComponent"], _resource_resource_demand_resource_demand_component__WEBPACK_IMPORTED_MODULE_18__["ResourceDemandComponent"],
                _resource_resource_availability_table_resource_availability_table_component__WEBPACK_IMPORTED_MODULE_19__["ResourceAvailabilityTableComponent"], _resource_resource_availability_resource_availability_component__WEBPACK_IMPORTED_MODULE_20__["ResourceAvailabilityComponent"], _resource_resource_utilization_resource_utilization_component__WEBPACK_IMPORTED_MODULE_21__["ResourceUtilizationComponent"], _resource_resource_utilization_table_resource_utilization_table_component__WEBPACK_IMPORTED_MODULE_22__["ResourceUtilizationTableComponent"],
                _resource_new_resource_component__WEBPACK_IMPORTED_MODULE_24__["NewResourceComponent"], _resource_edit_resource_component__WEBPACK_IMPORTED_MODULE_25__["EditResourceComponent"], _resource_delete_resource_component__WEBPACK_IMPORTED_MODULE_26__["DeleteResourceComponent"], _resources_dashboard_resources_dashboard_component__WEBPACK_IMPORTED_MODULE_27__["ResourcesDashboardComponent"]],
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                _resources_routing_module__WEBPACK_IMPORTED_MODULE_4__["ResourcesRoutingModule"],
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"],
                app_shared_shared_module__WEBPACK_IMPORTED_MODULE_5__["SharedModule"],
                ng_chartist__WEBPACK_IMPORTED_MODULE_6__["ChartistModule"],
                _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_7__["NgbModule"],
                app_shared_directives_match_height_directive__WEBPACK_IMPORTED_MODULE_8__["MatchHeightModule"]
            ],
            entryComponents: [_resource_new_resource_component__WEBPACK_IMPORTED_MODULE_24__["NewResourceComponent"], _resource_edit_resource_component__WEBPACK_IMPORTED_MODULE_25__["EditResourceComponent"]],
            providers: [_resources_service__WEBPACK_IMPORTED_MODULE_23__["ResourceService"]]
        })
    ], ResourcesModule);
    return ResourcesModule;
}());



/***/ }),

/***/ "./src/app/resources/resources.service.ts":
/*!************************************************!*\
  !*** ./src/app/resources/resources.service.ts ***!
  \************************************************/
/*! exports provided: ResourceService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ResourceService", function() { return ResourceService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");
/* harmony import */ var app_shared_auth_auth_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! app/shared/auth/auth.service */ "./src/app/shared/auth/auth.service.ts");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm5/operators/index.js");








var ResourceService = /** @class */ (function () {
    function ResourceService(http, auth) {
        this.http = http;
        this.auth = auth;
        this.baseUrl = 'http://localhost:53956/api';
        this.resourceStore = { resources: [] };
        this._resources = new rxjs__WEBPACK_IMPORTED_MODULE_2__["BehaviorSubject"]([]);
        this.resourceListStore = { resourcesandrates: [] };
        this._resourcesandrates = new rxjs__WEBPACK_IMPORTED_MODULE_2__["BehaviorSubject"]([]);
    }
    Object.defineProperty(ResourceService.prototype, "resources", {
        get: function () {
            return this._resources.asObservable();
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(ResourceService.prototype, "resourcesandrates", {
        get: function () {
            return this._resourcesandrates.asObservable();
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(ResourceService.prototype, "resourcesData", {
        get: function () { return this.resourceStore.resources; },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(ResourceService.prototype, "returnedresources", {
        get: function () {
            return this.resourceStore.resources;
        },
        enumerable: true,
        configurable: true
    });
    ResourceService.prototype.error = function (error) {
        return error;
    };
    ResourceService.prototype.resourceById = function (id) {
        return this.resourceStore.resources.find(function (x) { return x.resourceId === id; });
    };
    ResourceService.prototype.resourceandrateById = function (id) {
        return this.resourceListStore.resourcesandrates.find(function (x) { return x.resourceId === id; });
    };
    ResourceService.prototype.getResources = function () {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
            var companyId;
            var _this = this;
            return tslib__WEBPACK_IMPORTED_MODULE_0__["__generator"](this, function (_a) {
                companyId = this.auth.companyId;
                this.http.get(this.baseUrl + '/resources/' + companyId, this.auth.tokenHeader.body).subscribe(function (response) {
                    _this.resourceStore.resources = response.json();
                    _this._resources.next(Object.assign({}, _this.resourceStore).resources);
                }, function (error) {
                    console.log('Failed to fetch resources');
                });
                return [2 /*return*/];
            });
        });
    };
    ResourceService.prototype.getResourcepool = function () {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
            var companyId, options;
            var _this = this;
            return tslib__WEBPACK_IMPORTED_MODULE_0__["__generator"](this, function (_a) {
                companyId = this.auth.companyId;
                options = new _angular_http__WEBPACK_IMPORTED_MODULE_3__["RequestOptions"]();
                options.headers = new _angular_http__WEBPACK_IMPORTED_MODULE_3__["Headers"]();
                options.headers.append('Authorization', 'Bearer ' + localStorage.getItem(this.auth.TOKEN_KEY));
                options.headers.append('Content-Type', 'application/json; charset=utf-8');
                options.headers.append('responseType', 'ResponseContentType.Blob');
                this.http.get(this.baseUrl + '/resources/' + companyId, options).subscribe(function (response) {
                    _this.resourceStore.resources = response.json();
                    _this._resources.next(Object.assign({}, _this.resourceStore).resources);
                }, function (error) {
                    console.log('Failed to fetch resources');
                });
                return [2 /*return*/];
            });
        });
    };
    ResourceService.prototype.downloadFile = function () {
        var options = new _angular_http__WEBPACK_IMPORTED_MODULE_3__["RequestOptions"]({ responseType: _angular_http__WEBPACK_IMPORTED_MODULE_3__["ResponseContentType"].Blob });
        return this.http.get(this.baseUrl + '/uploadactuals/export', options).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["map"])(function (res) { return res.blob(); }));
        // .catch(this.handleError);
    };
    ResourceService.prototype.createImageFromBlob = function (image) {
        var _this = this;
        var reader = new FileReader();
        reader.addEventListener('load', function () {
            _this.imageToShow = reader.result;
        }, false);
        if (image) {
            reader.readAsDataURL(image);
        }
    };
    ResourceService.prototype.getResourcesAndRates = function () {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
            var headers, companyId;
            var _this = this;
            return tslib__WEBPACK_IMPORTED_MODULE_0__["__generator"](this, function (_a) {
                headers = new _angular_http__WEBPACK_IMPORTED_MODULE_3__["Headers"]();
                headers.append('Authorization', 'Bearer ' + localStorage.getItem(this.auth.TOKEN_KEY));
                headers.append('Content-Type', 'application/json');
                companyId = this.auth.companyId;
                console.log(this.auth.tokenHeader);
                console.log(companyId);
                this.http.get(this.baseUrl + '/resources/' + companyId, this.auth.tokenHeader).subscribe(function (response) {
                    console.log(response);
                    _this.resourceListStore.resourcesandrates = response.json();
                    _this._resourcesandrates.next(Object.assign({}, _this.resourceListStore).resourcesandrates);
                }, function (error) {
                    console.log('Failed to fetch resources');
                });
                return [2 /*return*/];
            });
        });
    };
    ResourceService.prototype.postResource = function (resource) {
        var _this = this;
        // tslint:disable-next-line:max-line-length
        return this.http.post(this.baseUrl + '/resources', resource, this.auth.tokenHeader).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["map"])(function (res) {
            res.json(),
                _this.resourceStore.resources.push(res.json());
            _this._resources.next(Object.assign({}, _this.resourceStore).resources);
            console.log(resource),
                console.log(res.json());
        }));
    };
    ResourceService.prototype.getResource = function (id) {
        // tslint:disable-next-line:prefer-const
        var companyId = this.auth.companyId;
        if (id === '') {
            return Object(rxjs__WEBPACK_IMPORTED_MODULE_2__["of"])(this.initializeBusiness());
        }
        return this.http.get(this.baseUrl + '/resources' + '/' + companyId + '/' + id, this.auth.tokenHeader).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["map"])(function (res) { return res.json(); }));
    };
    ResourceService.prototype.saveResource = function (ResourceData) {
        console.log(ResourceData);
        // tslint:disable-next-line:max-line-length
        return this.http.post(this.baseUrl + '/resources/resource', ResourceData, this.auth.tokenHeaderWithType).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["map"])(function (res) { return res.json(); }));
    };
    // saveResource(ResourceData) {
    //   console.log(ResourceData);
    // // tslint:disable-next-line:max-line-length
    // return this.http.post(this.baseUrl + '/resources/resource',  ResourceData, this.auth.tokenHeader).map(res => res.json());
    // }
    ResourceService.prototype.deleteItem = function (id) {
        var _this = this;
        var companyId = this.auth.companyId;
        return this.http.delete(this.baseUrl + '/resources' + '/' + companyId + '/' + id, this.auth.tokenHeader).toPromise()
            .then(function () {
            _this.getResources(),
                _this._resources.next(_this.resourceStore.resources),
                console.log(id);
        }, function (error) { return console.log('Failed to fetch resources'); });
        // .do(data => console.log('deleteProduct: ' + JSON.stringify(data))).catch(this.handleError);
    };
    ResourceService.prototype.GetGiveAccess = function () {
        return this.http.get(this.baseUrl + '/dropdown/giveaccess', this.auth.tokenHeader).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["map"])(function (res) { return res.json(); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError));
    };
    ResourceService.prototype.GetEmployeeTypes = function () {
        return this.http.get(this.baseUrl + '/dropdown/employeeTypes', this.auth.tokenHeader).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["map"])(function (res) { return res.json(); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError));
    };
    ResourceService.prototype.GetResourceTypes = function () {
        return this.http.get(this.baseUrl + '/dropdown/resourcetypes', this.auth.tokenHeader).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["map"])(function (res) { return res.json(); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_5__["catchError"])(this.handleError));
    };
    ResourceService.prototype.handleError = function (error) {
        return Object(rxjs__WEBPACK_IMPORTED_MODULE_2__["throwError"])('Something went wrong!');
    };
    ResourceService.prototype.initializeBusiness = function () {
        // Return an initialized object
        return {
            resourceId: '',
            resourceNumber: '',
            resourceEmailAddress: '',
            employeeRef: '',
            resourceStartDate: '',
            resourceEndDate: '',
            platformId: '',
            agency: '',
            vendor: '',
            locationName: '',
            location: '',
            billable: false,
            isDisabled: false,
            employeeJobTitle: '',
            resourceRateCardId: '',
            companyRateCard: '',
            contractedHours: 0,
            resourceContractEffortInPercentage: 100,
            resourceType: '',
            employeeType: '',
            appUserRole: '',
            company: '',
            resourceManagerId: '',
            identityId: '',
            identity: '',
            firstName: '',
            lastName: '',
            employeeGradeBand: '',
            managerName: '',
            resourceRate: '',
            displayName: '',
            addedBy: '',
            companyId: this.auth.companyId,
        };
    };
    ResourceService.prototype.onSelect = function (event) {
        console.log(event);
    };
    ResourceService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_http__WEBPACK_IMPORTED_MODULE_3__["Http"],
            app_shared_auth_auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"]])
    ], ResourceService);
    return ResourceService;
}());



/***/ }),

/***/ "./src/app/resources/resources/resources.component.html":
/*!**************************************************************!*\
  !*** ./src/app/resources/resources/resources.component.html ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"row\">\r\n    <h1 class=\"card-title m-1 pl-2 pull-left text-muted text-primary\">Resource Demand</h1>\r\n</div>\r\n<!-- Minimal statistics with bg color section start -->\r\n<section id=\"minimal-statistics-bg\">\r\n  <div class=\"row text-left\" matchHeight=\"card\">\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-primary\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-pencil white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>278</h3>\r\n                <span>New Posts</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-danger\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-speech white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>156</h3>\r\n                <span>New Comments</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-success\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-graph white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>64.89 %</h3>\r\n                <span>Bounce Rate</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n    <div class=\"col-xl-3 col-lg-6 col-12\">\r\n      <div class=\"card bg-warning\">\r\n        <div class=\"card-content\">\r\n          <div class=\"px-3 py-3\">\r\n            <div class=\"media\">\r\n              <div class=\"media-left align-self-center\">\r\n                <i class=\"icon-pointer white font-large-2 float-left\"></i>\r\n              </div>\r\n              <div class=\"media-body white text-right\">\r\n                <h3>423</h3>\r\n                <span>Total Visits</span>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</section>\r\n<!-- Minimal statistics with bg color section end -->\r\n\r\n<section id=\"extended\">\r\n    <div class=\"row text-left\">\r\n      <div class=\"col-sm-12\">\r\n        <div class=\"card\">\r\n          <div class=\"card-header\">\r\n              <h2 class=\"card-title text-capitalize text-monospace\">Resource Pool</h2>\r\n          </div>\r\n          <div class=\"card-content p-2 m-2\">\r\n            <div class=\"card-body\">\r\n              <div class=\"row\">\r\n                  <input type=\"text\" [(ngModel)]=\"search\" (ngModelChange)=\"filter($event)\" class=\"form-control round\" placeholder=\"search this page\">\r\n              </div>\r\n                <div classs =\"m-2 p-2\">\r\n                    <div classs =\"row\">\r\n                        <div class=\"col-12\">\r\n                            <table [mfData]=\"resources$ | async\" #mf=\"mfDataTable\" [mfRowsOnPage]=\"5\" class=\"table table-hover table-responsive-md text-center dataTable \">\r\n                  <thead>\r\n                    <tr>\r\n                        <th style=\"width: 20%\">\r\n                            <mfDefaultSorter by=\"displayName\">Name</mfDefaultSorter>\r\n                        </th>\r\n                        <th style=\"width: 50%\">\r\n                            <mfDefaultSorter by=\"firstName\">Email</mfDefaultSorter>\r\n                        </th>\r\n                        <th style=\"width: 10%\">\r\n                            <mfDefaultSorter by=\"firstName\">Age</mfDefaultSorter>\r\n                        </th>\r\n                        <th style=\"width: 20%\">\r\n                            <mfDefaultSorter by=\"firstName\">City</mfDefaultSorter>\r\n                        </th>\r\n                      <th>Name</th>\r\n                      <th>First Name</th>\r\n                      <th>Actions</th>\r\n                    </tr>\r\n                  </thead>\r\n                  <tbody>\r\n                    <tr *ngFor=\"let res of mf.data\">\r\n                      <td>\r\n                          <!-- <img class=\"media-object round-media\" src=\"{{res.imageUrl}}\" alt=\"Generic placeholder image\"\r\n                            style=\"height: 75px;\" /> -->\r\n                            <span  class=\"avatar avatar-md mr-2 ml-0\">\r\n                              <span *ngIf=\"!res.imageUrl\" style=\"height: 50px;\" class=\"media-object rounded-circle roundprofile + ' ' + bg-info \">\r\n                              <p class=\"d-flex innerTEXT\">{{ res.firstName | fl }}</p></span>\r\n                              <img *ngIf=\"res.imageUrl\" style=\"height: 50px;\" class=\"media-object rounded-circle\" [src]=\"res.imageUrl\" alt=\"Generic placeholder image\">\r\n                              {{res.displayName}}\r\n                            </span>\r\n                        </td>\r\n                        <td>{{res.firstName}}</td>\r\n                      <!-- <td>\r\n                        <div class=\"custom-control custom-checkbox m-0\">\r\n                          <input type=\"checkbox\" class=\"custom-control-input\" id=\"item1\">\r\n                          <label class=\"custom-control-label col-form-label\" for=\"item1\"></label>\r\n                        </div>\r\n                      </td> -->\r\n                      <td>{{res.firstName}}</td>\r\n                      <td>{{res.firstName}}</td>\r\n                      <td>{{res.firstName}}</td>\r\n                      <td>{{res.firstName}}</td>\r\n                      <td>\r\n                        <a class=\"info p-0\" data-original-title=\"\" title=\"\">\r\n                          <i class=\"ft-user font-medium-3 mr-2\"></i>\r\n                        </a>\r\n                        <a class=\"success p-0\" data-original-title=\"\" title=\"\">\r\n                          <i class=\"ft-edit-2 font-medium-3 mr-2\"></i>\r\n                        </a>\r\n                        <a class=\"danger p-0\" data-original-title=\"\" title=\"\">\r\n                          <i class=\"ft-x font-medium-3 mr-2\"></i>\r\n                        </a>\r\n                      </td>\r\n                    </tr>\r\n                  </tbody>\r\n                  <tfoot>\r\n                      <tr>\r\n                          <td colspan=\"4\">\r\n                              <mfBootstrapPaginator [rowsOnPageSet]=\"[5,10,25]\"></mfBootstrapPaginator>\r\n                          </td>\r\n                      </tr>\r\n                      </tfoot>\r\n                </table>\r\n                        </div>\r\n                    </div>\r\n                    </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </section>\r\n\r\n\r\n"

/***/ }),

/***/ "./src/app/resources/resources/resources.component.scss":
/*!**************************************************************!*\
  !*** ./src/app/resources/resources/resources.component.scss ***!
  \**************************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = ":host /deep/ .ct-grid {\n  stroke-dasharray: 0px;\n  stroke: rgba(0, 0, 0, 0.1); }\n\n:host /deep/ .ct-label {\n  font-size: 0.9rem; }\n\n:host /deep/ .lineArea .ct-series-a .ct-area {\n  fill-opacity: 0.7;\n  fill: url(\"/dashboard/dashboard1#gradient1\") !important; }\n\n:host /deep/ .lineArea .ct-series-b .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient\") !important;\n  fill-opacity: 0.9; }\n\n:host /deep/ .lineArea .ct-line {\n  stroke-width: 0px; }\n\n:host /deep/ .lineArea .ct-point {\n  stroke-width: 0px; }\n\n:host /deep/ .Stackbarchart .ct-series-a .ct-bar {\n  stroke: url(\"/dashboard/dashboard1#linear\") !important; }\n\n:host /deep/ .Stackbarchart .ct-series-b .ct-bar {\n  stroke: #e9e9e9; }\n\n:host /deep/ .lineArea2 .ct-series-a .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient2\") !important; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-area {\n  fill: url(\"/dashboard/dashboard1#gradient3\") !important; }\n\n:host /deep/ .lineArea2 .ct-point-circle {\n  stroke-width: 2px;\n  fill: white; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-point-circle {\n  stroke: #843cf7; }\n\n:host /deep/ .lineArea2 .ct-series-b .ct-line {\n  stroke: #A675F4; }\n\n:host /deep/ .lineArea2 .ct-series-a .ct-point-circle {\n  stroke: #31afb2; }\n\n:host /deep/ .lineArea2 .ct-line {\n  fill: none;\n  stroke-width: 2px; }\n\n:host /deep/ .lineChart .ct-point-circle {\n  stroke-width: 2px;\n  fill: white; }\n\n:host /deep/ .lineChart .ct-series-a .ct-point-circle {\n  stroke: white; }\n\n:host /deep/ .lineChart .ct-line {\n  fill: none;\n  stroke: white;\n  stroke-width: 1px; }\n\n:host /deep/ .lineChart .ct-label {\n  color: #FFF; }\n\n:host /deep/ .lineChartShadow {\n  -webkit-filter: drop-shadow(0px 25px 8px rgba(0, 0, 0, 0.3));\n  filter: drop-shadow(0px 25px 8px rgba(0, 0, 0, 0.3));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n:host /deep/ .donut .ct-done .ct-slice-donut {\n  stroke: #0CC27E;\n  stroke-width: 24px !important; }\n\n:host /deep/ .donut .ct-progress .ct-slice-donut {\n  stroke: #FFC107;\n  stroke-width: 16px !important; }\n\n:host /deep/ .donut .ct-outstanding .ct-slice-donut {\n  stroke: #7E57C2;\n  stroke-width: 8px !important; }\n\n:host /deep/ .donut .ct-started .ct-slice-donut {\n  stroke: #2196F3;\n  stroke-width: 32px !important; }\n\n:host /deep/ .donut .ct-label {\n  text-anchor: middle;\n  alignment-baseline: middle;\n  font-size: 20px;\n  fill: #868e96; }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+1) {\n  stroke: url(\"/dashboard/dashboard1#gradient7\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+2) {\n  stroke: url(\"/dashboard/dashboard1#gradient5\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+3) {\n  stroke: url(\"/dashboard/dashboard1#gradient6\"); }\n\n:host /deep/ .BarChart .ct-series-a .ct-bar:nth-of-type(4n+4) {\n  stroke: url(\"/dashboard/dashboard1#gradient4\"); }\n\n:host /deep/ .BarChartShadow {\n  -webkit-filter: drop-shadow(0px 20px 8px rgba(0, 0, 0, 0.3));\n  filter: drop-shadow(0px 20px 8px rgba(0, 0, 0, 0.3));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n:host /deep/ .WidgetlineChart .ct-point {\n  stroke-width: 0px; }\n\n:host /deep/ .WidgetlineChart .ct-line {\n  stroke: #fff; }\n\n:host /deep/ .WidgetlineChart .ct-grid {\n  stroke-dasharray: 0px;\n  stroke: rgba(255, 255, 255, 0.2); }\n\n:host /deep/ .WidgetlineChartshadow {\n  -webkit-filter: drop-shadow(0px 15px 5px rgba(0, 0, 0, 0.8));\n  filter: drop-shadow(0px 15px 5px rgba(0, 0, 0, 0.8));\n  /* Same syntax as box-shadow, except\r\n                                                       for the spread property */ }\n\n.noshow {\n  display: none; }\n\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvcmVzb3VyY2VzL3Jlc291cmNlcy9DOlxcVXNlcnNcXE5kaWFuYW5pZVxcR2l0XFxQcm9qZWN0VXBkYXRlc1xcUFRBbmd1bGFyXFxwcm9qZWN0dXBkYXRlc2Zyb250ZW5kL3NyY1xcYXBwXFxyZXNvdXJjZXNcXHJlc291cmNlc1xccmVzb3VyY2VzLmNvbXBvbmVudC5zY3NzIiwic3JjL2FwcC9yZXNvdXJjZXMvcmVzb3VyY2VzL3Jlc291cmNlcy5jb21wb25lbnQuc2NzcyJdLCJuYW1lcyI6W10sIm1hcHBpbmdzIjoiQUFFQTtFQUNJLHFCQUFxQjtFQUNyQiwwQkFBMEIsRUFBQTs7QUFHOUI7RUFDSSxpQkFBaUIsRUFBQTs7QUFLckI7RUFDSSxpQkFBaUI7RUFDakIsdURBQTRELEVBQUE7O0FBR2hFO0VBQ0ksc0RBQTREO0VBQzVELGlCQUFpQixFQUFBOztBQUVyQjtFQUNJLGlCQUFpQixFQUFBOztBQUVyQjtFQUNJLGlCQUFpQixFQUFBOztBQU9yQjtFQUdZLHNEQUE0RCxFQUFBOztBQUh4RTtFQVFZLGVBQWUsRUFBQTs7QUFTM0I7RUFDSSx1REFBNkQsRUFBQTs7QUFHakU7RUFDSSx1REFBNkQsRUFBQTs7QUFHakU7RUFDSSxpQkFBaUI7RUFDakIsV0FBVyxFQUFBOztBQUdmO0VBQ0ksZUFBZSxFQUFBOztBQUduQjtFQUNJLGVBQWUsRUFBQTs7QUFHbkI7RUFDSSxlQUFlLEVBQUE7O0FBR25CO0VBQ0ksVUFBVTtFQUNWLGlCQUFpQixFQUFBOztBQU9yQjtFQUNJLGlCQUFpQjtFQUNqQixXQUFXLEVBQUE7O0FBR2Y7RUFDSSxhQUFhLEVBQUE7O0FBR2pCO0VBQ0ksVUFBVTtFQUNWLGFBQWE7RUFDYixpQkFBaUIsRUFBQTs7QUFHckI7RUFDSSxXQUFXLEVBQUE7O0FBR2Y7RUFDSSw0REFBMkQ7RUFDbkQsb0RBQW1EO0VBQUU7Z0ZDcENlLEVEcUNDOztBQU0vRTtFQUNFLGVBQWU7RUFDZiw2QkFBNkIsRUFBQTs7QUFFL0I7RUFDRSxlQUFlO0VBQ2YsNkJBQTZCLEVBQUE7O0FBRS9CO0VBQ0UsZUFBZTtFQUNmLDRCQUE0QixFQUFBOztBQUc5QjtFQUNFLGVBQWU7RUFDZiw2QkFBNkIsRUFBQTs7QUFHL0I7RUFDRSxtQkFBbUI7RUFDbkIsMEJBQTBCO0VBQzFCLGVBQWU7RUFDZixhQUFhLEVBQUE7O0FBT2Y7RUFDRSw4Q0FBb0QsRUFBQTs7QUFFdEQ7RUFDRSw4Q0FBb0QsRUFBQTs7QUFFdEQ7RUFDRSw4Q0FBb0QsRUFBQTs7QUFFdEQ7RUFDRSw4Q0FBb0QsRUFBQTs7QUFHdEQ7RUFDRSw0REFBMkQ7RUFDbkQsb0RBQW1EO0VBQUU7Z0ZDL0NlLEVEZ0RDOztBQU9qRjtFQUNJLGlCQUFpQixFQUFBOztBQUVyQjtFQUNJLFlBQVksRUFBQTs7QUFJaEI7RUFDSSxxQkFBcUI7RUFDcEIsZ0NBQWdDLEVBQUE7O0FBR3JDO0VBQ0ksNERBQTJEO0VBQ25ELG9EQUFtRDtFQUFFO2dGQ3REZSxFRHVEQzs7QUFLakY7RUFDRSxhQUFhLEVBQUEiLCJmaWxlIjoic3JjL2FwcC9yZXNvdXJjZXMvcmVzb3VyY2VzL3Jlc291cmNlcy5jb21wb25lbnQuc2NzcyIsInNvdXJjZXNDb250ZW50IjpbIkBpbXBvcnQgXCIuLi8uLi8uLi9hc3NldHMvc2Fzcy9zY3NzL2dyYWRpZW50LXZhcmlhYmxlc1wiO1xyXG5cclxuOmhvc3QgL2RlZXAvIC5jdC1ncmlke1xyXG4gICAgc3Ryb2tlLWRhc2hhcnJheTogMHB4O1xyXG4gICAgc3Ryb2tlOiByZ2JhKDAsIDAsIDAsIDAuMSk7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAuY3QtbGFiZWx7XHJcbiAgICBmb250LXNpemU6IDAuOXJlbTtcclxufVxyXG5cclxuLy8gTGluZSB3aXRoIEFyZWEgQ2hhcnQgQ1NTIFN0YXJ0c1xyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3Qtc2VyaWVzLWEgLmN0LWFyZWEge1xyXG4gICAgZmlsbC1vcGFjaXR5OiAwLjc7XHJcbiAgICBmaWxsOnVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudDEpICFpbXBvcnRhbnQ7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LXNlcmllcy1iIC5jdC1hcmVhIHtcclxuICAgIGZpbGw6IHVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudCkgIWltcG9ydGFudDtcclxuICAgIGZpbGwtb3BhY2l0eTogMC45O1xyXG59XHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LWxpbmV7XHJcbiAgICBzdHJva2Utd2lkdGg6IDBweDtcclxufVxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1wb2ludCB7XHJcbiAgICBzdHJva2Utd2lkdGg6IDBweDtcclxufVxyXG5cclxuLy8gTGluZSB3aXRoIEFyZWEgQ2hhcnQgMSBDU1MgRW5kc1xyXG5cclxuLy8gU3RhY2sgQmFyIENoYXJ0IENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAuU3RhY2tiYXJjaGFydHtcclxuICAgIC5jdC1zZXJpZXMtYSB7XHJcbiAgICAgICAgLmN0LWJhcntcclxuICAgICAgICAgICAgc3Ryb2tlOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjbGluZWFyKSAhaW1wb3J0YW50XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG4gICAgLmN0LXNlcmllcy1iIHtcclxuICAgICAgICAuY3QtYmFye1xyXG4gICAgICAgICAgICBzdHJva2U6ICNlOWU5ZTk7XHJcbiAgICAgICAgfVxyXG4gICAgfVxyXG59XHJcblxyXG4vLyBTdGFjayBCYXIgQ2hhcnQgQ1NTIEVuZHNcclxuXHJcbi8vIExpbmUgd2l0aCBBcmVhIENoYXJ0IDIgQ1NTIFN0YXJ0c1xyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1hIC5jdC1hcmVhIHtcclxuICAgIGZpbGw6IHVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudDIpICFpbXBvcnRhbnQ7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYiAuY3QtYXJlYSB7XHJcbiAgICBmaWxsOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQzKSAhaW1wb3J0YW50O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3QtcG9pbnQtY2lyY2xlIHtcclxuICAgIHN0cm9rZS13aWR0aDogMnB4O1xyXG4gICAgZmlsbDogd2hpdGU7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYiAuY3QtcG9pbnQtY2lyY2xle1xyXG4gICAgc3Ryb2tlOiAjODQzY2Y3O1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LWxpbmV7XHJcbiAgICBzdHJva2U6ICNBNjc1RjQ7XHJcbn1cclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYSAuY3QtcG9pbnQtY2lyY2xlIHtcclxuICAgIHN0cm9rZTogIzMxYWZiMjtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LWxpbmUge1xyXG4gICAgZmlsbDogbm9uZTtcclxuICAgIHN0cm9rZS13aWR0aDogMnB4O1xyXG59XHJcblxyXG4vLyBMaW5lIHdpdGggQXJlYSBDaGFydCAyIENTUyBFbmRzXHJcblxyXG4vLyBMaW5lIENoYXJ0IENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1wb2ludC1jaXJjbGUge1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAycHg7XHJcbiAgICBmaWxsOiB3aGl0ZTtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1wb2ludC1jaXJjbGUge1xyXG4gICAgc3Ryb2tlOiB3aGl0ZTtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LWxpbmUge1xyXG4gICAgZmlsbDogbm9uZTtcclxuICAgIHN0cm9rZTogd2hpdGU7XHJcbiAgICBzdHJva2Utd2lkdGg6IDFweDtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5saW5lQ2hhcnQgLmN0LWxhYmVsIHtcclxuICAgIGNvbG9yOiAjRkZGO1xyXG59XHJcblxyXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydFNoYWRvdyB7XHJcbiAgICAtd2Via2l0LWZpbHRlcjogZHJvcC1zaGFkb3coIDBweCAyNXB4IDhweCByZ2JhKDAsMCwwLDAuMykgKTtcclxuICAgICAgICAgICAgZmlsdGVyOiBkcm9wLXNoYWRvdyggMHB4IDI1cHggOHB4IHJnYmEoMCwwLDAsMC4zKSApOyAvKiBTYW1lIHN5bnRheCBhcyBib3gtc2hhZG93LCBleGNlcHRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZvciB0aGUgc3ByZWFkIHByb3BlcnR5ICovXHJcbn1cclxuXHJcbi8vIExpbmUgQ2hhcnQgIENTUyBFbmRzXHJcblxyXG4gIC8vIERvbnV0IENoYXJ0ICBDU1MgRW5kc1xyXG4gIDpob3N0IC9kZWVwLyAuZG9udXQgLmN0LWRvbmUgLmN0LXNsaWNlLWRvbnV0IHtcclxuICAgIHN0cm9rZTogIzBDQzI3RTtcclxuICAgIHN0cm9rZS13aWR0aDogMjRweCAhaW1wb3J0YW50O1xyXG4gIH1cclxuICA6aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1wcm9ncmVzcyAuY3Qtc2xpY2UtZG9udXQge1xyXG4gICAgc3Ryb2tlOiAjRkZDMTA3O1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAxNnB4ICFpbXBvcnRhbnQ7XHJcbiAgfVxyXG4gIDpob3N0IC9kZWVwLyAuZG9udXQgLmN0LW91dHN0YW5kaW5nIC5jdC1zbGljZS1kb251dCB7XHJcbiAgICBzdHJva2U6ICM3RTU3QzI7XHJcbiAgICBzdHJva2Utd2lkdGg6IDhweCAhaW1wb3J0YW50O1xyXG4gIH1cclxuXHJcbiAgOmhvc3QgL2RlZXAvIC5kb251dCAuY3Qtc3RhcnRlZCAuY3Qtc2xpY2UtZG9udXQge1xyXG4gICAgc3Ryb2tlOiAjMjE5NkYzO1xyXG4gICAgc3Ryb2tlLXdpZHRoOiAzMnB4ICFpbXBvcnRhbnQ7XHJcbiAgfVxyXG5cclxuICA6aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1sYWJlbCB7XHJcbiAgICB0ZXh0LWFuY2hvcjogbWlkZGxlO1xyXG4gICAgYWxpZ25tZW50LWJhc2VsaW5lOiBtaWRkbGU7XHJcbiAgICBmb250LXNpemU6IDIwcHg7XHJcbiAgICBmaWxsOiAjODY4ZTk2O1xyXG4gIH1cclxuXHJcbiAgLy8gRG9udXQgQ2hhcnQgIENTUyBFbmRzXHJcblxyXG4gIC8vIEJhciBDaGFydCBDU1MgU3RhcnRzXHJcblxyXG4gIDpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rMSkge1xyXG4gICAgc3Ryb2tlOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQ3KTtcclxuICB9XHJcbiAgOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0bisyKSB7XHJcbiAgICBzdHJva2U6IHVybCgkZGFzaGJvYXJkMS1ncmFkaWVudC1wYXRoICsgICNncmFkaWVudDUpO1xyXG4gIH1cclxuICA6aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzMpIHtcclxuICAgIHN0cm9rZTogdXJsKCRkYXNoYm9hcmQxLWdyYWRpZW50LXBhdGggKyAgI2dyYWRpZW50Nik7XHJcbiAgfVxyXG4gIDpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rNCkge1xyXG4gICAgc3Ryb2tlOiB1cmwoJGRhc2hib2FyZDEtZ3JhZGllbnQtcGF0aCArICAjZ3JhZGllbnQ0KTtcclxuICB9XHJcblxyXG4gIDpob3N0IC9kZWVwLyAuQmFyQ2hhcnRTaGFkb3cge1xyXG4gICAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMjBweCA4cHggcmdiYSgwLDAsMCwwLjMpICk7XHJcbiAgICAgICAgICAgIGZpbHRlcjogZHJvcC1zaGFkb3coIDBweCAyMHB4IDhweCByZ2JhKDAsMCwwLDAuMykgKTsgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqL1xyXG59XHJcblxyXG4vLyBCYXIgQ2hhcnQgQ1NTIEVuZHNcclxuXHJcbi8vIFdpZGdldCBsaW5lIENoYXJ0IENTUyBTdGFydHNcclxuXHJcbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1wb2ludCB7XHJcbiAgICBzdHJva2Utd2lkdGg6IDBweDtcclxufVxyXG46aG9zdCAvZGVlcC8gLldpZGdldGxpbmVDaGFydCAuY3QtbGluZXtcclxuICAgIHN0cm9rZTogI2ZmZjtcclxufVxyXG5cclxuXHJcbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0IC5jdC1ncmlkIHtcclxuICAgIHN0cm9rZS1kYXNoYXJyYXk6IDBweDtcclxuICAgICBzdHJva2U6IHJnYmEoMjU1LCAyNTUsIDI1NSwgMC4yKTtcclxufVxyXG5cclxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnRzaGFkb3cge1xyXG4gICAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KCAwcHggMTVweCA1cHggcmdiYSgwLDAsMCwwLjgpICk7XHJcbiAgICAgICAgICAgIGZpbHRlcjogZHJvcC1zaGFkb3coIDBweCAxNXB4IDVweCByZ2JhKDAsMCwwLDAuOCkgKTsgLyogU2FtZSBzeW50YXggYXMgYm94LXNoYWRvdywgZXhjZXB0XHJcbiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICBmb3IgdGhlIHNwcmVhZCBwcm9wZXJ0eSAqL1xyXG59XHJcblxyXG4vLyBXaWRnZXQgbGluZSBDaGFydCBDU1MgRW5kc1xyXG5cclxuLm5vc2hvdyB7XHJcbiAgZGlzcGxheTogbm9uZTtcclxufVxyXG4iLCI6aG9zdCAvZGVlcC8gLmN0LWdyaWQge1xuICBzdHJva2UtZGFzaGFycmF5OiAwcHg7XG4gIHN0cm9rZTogcmdiYSgwLCAwLCAwLCAwLjEpOyB9XG5cbjpob3N0IC9kZWVwLyAuY3QtbGFiZWwge1xuICBmb250LXNpemU6IDAuOXJlbTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhIC5jdC1zZXJpZXMtYSAuY3QtYXJlYSB7XG4gIGZpbGwtb3BhY2l0eTogMC43O1xuICBmaWxsOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQxXCIpICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3Qtc2VyaWVzLWIgLmN0LWFyZWEge1xuICBmaWxsOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnRcIikgIWltcG9ydGFudDtcbiAgZmlsbC1vcGFjaXR5OiAwLjk7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYSAuY3QtbGluZSB7XG4gIHN0cm9rZS13aWR0aDogMHB4OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEgLmN0LXBvaW50IHtcbiAgc3Ryb2tlLXdpZHRoOiAwcHg7IH1cblxuOmhvc3QgL2RlZXAvIC5TdGFja2JhcmNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyIHtcbiAgc3Ryb2tlOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjbGluZWFyXCIpICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5TdGFja2JhcmNoYXJ0IC5jdC1zZXJpZXMtYiAuY3QtYmFyIHtcbiAgc3Ryb2tlOiAjZTllOWU5OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUFyZWEyIC5jdC1zZXJpZXMtYSAuY3QtYXJlYSB7XG4gIGZpbGw6IHVybChcIi9kYXNoYm9hcmQvZGFzaGJvYXJkMSNncmFkaWVudDJcIikgIWltcG9ydGFudDsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LWFyZWEge1xuICBmaWxsOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQzXCIpICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXBvaW50LWNpcmNsZSB7XG4gIHN0cm9rZS13aWR0aDogMnB4O1xuICBmaWxsOiB3aGl0ZTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LXBvaW50LWNpcmNsZSB7XG4gIHN0cm9rZTogIzg0M2NmNzsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVBcmVhMiAuY3Qtc2VyaWVzLWIgLmN0LWxpbmUge1xuICBzdHJva2U6ICNBNjc1RjQ7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LXNlcmllcy1hIC5jdC1wb2ludC1jaXJjbGUge1xuICBzdHJva2U6ICMzMWFmYjI7IH1cblxuOmhvc3QgL2RlZXAvIC5saW5lQXJlYTIgLmN0LWxpbmUge1xuICBmaWxsOiBub25lO1xuICBzdHJva2Utd2lkdGg6IDJweDsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3QtcG9pbnQtY2lyY2xlIHtcbiAgc3Ryb2tlLXdpZHRoOiAycHg7XG4gIGZpbGw6IHdoaXRlOyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtcG9pbnQtY2lyY2xlIHtcbiAgc3Ryb2tlOiB3aGl0ZTsgfVxuXG46aG9zdCAvZGVlcC8gLmxpbmVDaGFydCAuY3QtbGluZSB7XG4gIGZpbGw6IG5vbmU7XG4gIHN0cm9rZTogd2hpdGU7XG4gIHN0cm9rZS13aWR0aDogMXB4OyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0IC5jdC1sYWJlbCB7XG4gIGNvbG9yOiAjRkZGOyB9XG5cbjpob3N0IC9kZWVwLyAubGluZUNoYXJ0U2hhZG93IHtcbiAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KDBweCAyNXB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMykpO1xuICBmaWx0ZXI6IGRyb3Atc2hhZG93KDBweCAyNXB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMykpO1xuICAvKiBTYW1lIHN5bnRheCBhcyBib3gtc2hhZG93LCBleGNlcHRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZvciB0aGUgc3ByZWFkIHByb3BlcnR5ICovIH1cblxuOmhvc3QgL2RlZXAvIC5kb251dCAuY3QtZG9uZSAuY3Qtc2xpY2UtZG9udXQge1xuICBzdHJva2U6ICMwQ0MyN0U7XG4gIHN0cm9rZS13aWR0aDogMjRweCAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAuZG9udXQgLmN0LXByb2dyZXNzIC5jdC1zbGljZS1kb251dCB7XG4gIHN0cm9rZTogI0ZGQzEwNztcbiAgc3Ryb2tlLXdpZHRoOiAxNnB4ICFpbXBvcnRhbnQ7IH1cblxuOmhvc3QgL2RlZXAvIC5kb251dCAuY3Qtb3V0c3RhbmRpbmcgLmN0LXNsaWNlLWRvbnV0IHtcbiAgc3Ryb2tlOiAjN0U1N0MyO1xuICBzdHJva2Utd2lkdGg6IDhweCAhaW1wb3J0YW50OyB9XG5cbjpob3N0IC9kZWVwLyAuZG9udXQgLmN0LXN0YXJ0ZWQgLmN0LXNsaWNlLWRvbnV0IHtcbiAgc3Ryb2tlOiAjMjE5NkYzO1xuICBzdHJva2Utd2lkdGg6IDMycHggIWltcG9ydGFudDsgfVxuXG46aG9zdCAvZGVlcC8gLmRvbnV0IC5jdC1sYWJlbCB7XG4gIHRleHQtYW5jaG9yOiBtaWRkbGU7XG4gIGFsaWdubWVudC1iYXNlbGluZTogbWlkZGxlO1xuICBmb250LXNpemU6IDIwcHg7XG4gIGZpbGw6ICM4NjhlOTY7IH1cblxuOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0bisxKSB7XG4gIHN0cm9rZTogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50N1wiKTsgfVxuXG46aG9zdCAvZGVlcC8gLkJhckNoYXJ0IC5jdC1zZXJpZXMtYSAuY3QtYmFyOm50aC1vZi10eXBlKDRuKzIpIHtcbiAgc3Ryb2tlOiB1cmwoXCIvZGFzaGJvYXJkL2Rhc2hib2FyZDEjZ3JhZGllbnQ1XCIpOyB9XG5cbjpob3N0IC9kZWVwLyAuQmFyQ2hhcnQgLmN0LXNlcmllcy1hIC5jdC1iYXI6bnRoLW9mLXR5cGUoNG4rMykge1xuICBzdHJva2U6IHVybChcIi9kYXNoYm9hcmQvZGFzaGJvYXJkMSNncmFkaWVudDZcIik7IH1cblxuOmhvc3QgL2RlZXAvIC5CYXJDaGFydCAuY3Qtc2VyaWVzLWEgLmN0LWJhcjpudGgtb2YtdHlwZSg0bis0KSB7XG4gIHN0cm9rZTogdXJsKFwiL2Rhc2hib2FyZC9kYXNoYm9hcmQxI2dyYWRpZW50NFwiKTsgfVxuXG46aG9zdCAvZGVlcC8gLkJhckNoYXJ0U2hhZG93IHtcbiAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KDBweCAyMHB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMykpO1xuICBmaWx0ZXI6IGRyb3Atc2hhZG93KDBweCAyMHB4IDhweCByZ2JhKDAsIDAsIDAsIDAuMykpO1xuICAvKiBTYW1lIHN5bnRheCBhcyBib3gtc2hhZG93LCBleGNlcHRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZvciB0aGUgc3ByZWFkIHByb3BlcnR5ICovIH1cblxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnQgLmN0LXBvaW50IHtcbiAgc3Ryb2tlLXdpZHRoOiAwcHg7IH1cblxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnQgLmN0LWxpbmUge1xuICBzdHJva2U6ICNmZmY7IH1cblxuOmhvc3QgL2RlZXAvIC5XaWRnZXRsaW5lQ2hhcnQgLmN0LWdyaWQge1xuICBzdHJva2UtZGFzaGFycmF5OiAwcHg7XG4gIHN0cm9rZTogcmdiYSgyNTUsIDI1NSwgMjU1LCAwLjIpOyB9XG5cbjpob3N0IC9kZWVwLyAuV2lkZ2V0bGluZUNoYXJ0c2hhZG93IHtcbiAgLXdlYmtpdC1maWx0ZXI6IGRyb3Atc2hhZG93KDBweCAxNXB4IDVweCByZ2JhKDAsIDAsIDAsIDAuOCkpO1xuICBmaWx0ZXI6IGRyb3Atc2hhZG93KDBweCAxNXB4IDVweCByZ2JhKDAsIDAsIDAsIDAuOCkpO1xuICAvKiBTYW1lIHN5bnRheCBhcyBib3gtc2hhZG93LCBleGNlcHRcclxuICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIGZvciB0aGUgc3ByZWFkIHByb3BlcnR5ICovIH1cblxuLm5vc2hvdyB7XG4gIGRpc3BsYXk6IG5vbmU7IH1cbiJdfQ== */"

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
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! chartist */ "./node_modules/chartist/dist/chartist.js");
/* harmony import */ var chartist__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(chartist__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _resources_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../resources.service */ "./src/app/resources/resources.service.ts");
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var _resource_new_resource_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../resource/new-resource.component */ "./src/app/resources/resource/new-resource.component.ts");
/* harmony import */ var angular_datatables__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! angular-datatables */ "./node_modules/angular-datatables/index.js");








var data = __webpack_require__(/*! ../../shared/data/chartist.json */ "./src/app/shared/data/chartist.json");
var ResourcesComponent = /** @class */ (function () {
    // Bar chart configuration Ends
    function ResourcesComponent(resourcesService, modalService) {
        this.resourcesService = resourcesService;
        this.modalService = modalService;
        this.resources$ = new rxjs__WEBPACK_IMPORTED_MODULE_1__["Subject"]();
        this.resources = [];
        this.dtOptions = {};
        this.dtTrigger = new rxjs__WEBPACK_IMPORTED_MODULE_1__["Subject"]();
        // Line chart configuration Starts
        this.WidgetlineChart = {
            type: 'Line', data: data['WidgetlineChart2'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart1 = {
            type: 'Line', data: data['WidgetlineChart3'],
            options: {
                axisX: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 50,
                    showLabel: false,
                    offset: 0,
                },
                fullWidth: true,
                chartPadding: { top: 0, right: 0, bottom: 10, left: 0 }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.WidgetlineChart2 = {
            type: 'Line', data: data['WidgetlineChart'],
            options: {
                axisX: {
                    showGrid: true,
                    showLabel: false,
                    offset: 0,
                },
                axisY: {
                    showGrid: false,
                    low: 40,
                    showLabel: false,
                    offset: 0,
                },
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_3__["Interpolation"].cardinal({
                    tension: 0
                }),
                fullWidth: true
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'widgradient1',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart1 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 0,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9c9';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart2 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 90,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue9e7';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart3 = {
            type: 'Pie',
            data: data['DashboardDonut'],
            options: {
                donut: true,
                donutWidth: 3,
                startAngle: 270,
                chartPadding: 25,
                labelInterpolationFnc: function (value) {
                    return '\ue964';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: (data.element.root().height() + (data.element.height() / 4)) / 2,
                                class: 'ct-label',
                                'font-family': 'feather'
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        // Line area chart configuration Starts
        this.lineAreaChart = {
            type: 'Line',
            data: data['lineArea3'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(38, 198, 218, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_3__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                }
            },
        };
        // Line area chart configuration Ends
        // Line chart configuration Starts
        this.lineChart2 = {
            type: 'Line', data: data['line2'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                draw: function (data) {
                    var circleRadius = 6;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_3__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line chart configuration Starts
        this.lineChart1 = {
            type: 'Line', data: data['line1'],
            options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                fullWidth: true
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Line area chart configuration Starts
        this.lineArea = {
            type: 'Line',
            data: data['lineAreaDashboard'],
            options: {
                low: 0,
                showArea: true,
                fullWidth: true,
                onlyInteger: true,
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                },
                axisX: {
                    showGrid: false
                }
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(146, 254, 157, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient1',
                        x1: 0,
                        y1: 1,
                        x2: 1,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                },
            },
        };
        // Line area chart configuration Ends
        // Stacked Bar chart configuration Starts
        this.Stackbarchart = {
            type: 'Bar',
            data: data['Stackbarchart'],
            options: {
                stackBars: true,
                fullWidth: true,
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                chartPadding: 30
            },
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'linear',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 201, 255,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(17,228,183, 1)'
                    });
                },
                draw: function (data) {
                    if (data.type === 'bar') {
                        data.element.attr({
                            style: 'stroke-width: 5px',
                            x1: data.x1 + 0.001
                        });
                    }
                    else if (data.type === 'label') {
                        data.element.attr({
                            y: 270
                        });
                    }
                }
            },
        };
        // Stacked Bar chart configuration Ends
        // Line area chart 2 configuration Starts
        this.lineArea2 = {
            type: 'Line',
            data: data['lineArea2'],
            options: {
                showArea: true,
                fullWidth: true,
                lineSmooth: chartist__WEBPACK_IMPORTED_MODULE_3__["Interpolation"].none(),
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    low: 0,
                    scaleMinSpace: 50,
                }
            },
            responsiveOptions: [
                ['screen and (max-width: 640px) and (min-width: 381px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 2 === 0 ? value : null;
                            }
                        }
                    }],
                ['screen and (max-width: 380px)', {
                        axisX: {
                            labelInterpolationFnc: function (value, index) {
                                return index % 3 === 0 ? value : null;
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient2',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(0, 201, 255, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient3',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0.3,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(255, 255, 255, 1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-opacity': '0.2',
                        'stop-color': 'rgba(132, 60, 247, 1)'
                    });
                },
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_3__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line area chart 2 configuration Ends
        // Line chart configuration Starts
        this.lineChart = {
            type: 'Line', data: data['LineDashboard'],
            options: {
                axisX: {
                    showGrid: false
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    low: 0,
                    high: 100,
                    offset: 0,
                },
                fullWidth: true,
                offset: 0,
            },
            events: {
                draw: function (data) {
                    var circleRadius = 4;
                    if (data.type === 'point') {
                        var circle = new chartist__WEBPACK_IMPORTED_MODULE_3__["Svg"]('circle', {
                            cx: data.x,
                            cy: data.y,
                            r: circleRadius,
                            class: 'ct-point-circle'
                        });
                        data.element.replace(circle);
                    }
                    else if (data.type === 'label') {
                        // adjust label position for rotation
                        var dX = data.width / 2 + (30 - data.width);
                        data.element.attr({ x: data.element.attr('x') - dX });
                    }
                }
            },
        };
        // Line chart configuration Ends
        // Donut chart configuration Starts
        this.DonutChart = {
            type: 'Pie',
            data: data['donutDashboard'],
            options: {
                donut: true,
                startAngle: 0,
                labelInterpolationFnc: function (value) {
                    var total = data['donutDashboard'].series.reduce(function (prev, series) {
                        return prev + series.value;
                    }, 0);
                    return total + '%';
                }
            },
            events: {
                draw: function (data) {
                    if (data.type === 'label') {
                        if (data.index === 0) {
                            data.element.attr({
                                dx: data.element.root().width() / 2,
                                dy: data.element.root().height() / 2
                            });
                        }
                        else {
                            data.element.remove();
                        }
                    }
                }
            }
        };
        // Donut chart configuration Ends
        //  Bar chart configuration Starts
        this.BarChart = {
            type: 'Bar', data: data['DashboardBar'], options: {
                axisX: {
                    showGrid: false,
                },
                axisY: {
                    showGrid: false,
                    showLabel: false,
                    offset: 0
                },
                low: 0,
                high: 60,
            },
            responsiveOptions: [
                ['screen and (max-width: 640px)', {
                        seriesBarDistance: 5,
                        axisX: {
                            labelInterpolationFnc: function (value) {
                                return value[0];
                            }
                        }
                    }]
            ],
            events: {
                created: function (data) {
                    var defs = data.svg.elem('defs');
                    defs.elem('linearGradient', {
                        id: 'gradient4',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(238, 9, 121,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 106, 0, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient5',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(0, 75, 145,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(120, 204, 55, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient6',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(132, 60, 247,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(56, 184, 242, 1)'
                    });
                    defs.elem('linearGradient', {
                        id: 'gradient7',
                        x1: 0,
                        y1: 1,
                        x2: 0,
                        y2: 0
                    }).elem('stop', {
                        offset: 0,
                        'stop-color': 'rgba(155, 60, 183,1)'
                    }).parent().elem('stop', {
                        offset: 1,
                        'stop-color': 'rgba(255, 57, 111, 1)'
                    });
                },
                draw: function (data) {
                    var barHorizontalCenter, barVerticalCenter, label, value;
                    if (data.type === 'bar') {
                        data.element.attr({
                            y1: 195,
                            x1: data.x1 + 0.001
                        });
                    }
                }
            },
        };
    }
    ResourcesComponent.prototype.ngOnInit = function () {
        this.dtOptions = {
            pagingType: 'full_numbers',
            pageLength: 100,
            processing: true,
            // data: this.resources$,
            // 'bDestroy': true,
            'paging': true,
            'ordering': true,
            'info': true,
            'columnDefs': [{
                    'targets': [3],
                    'visible': true,
                    'searchable': true
                },
                {
                    'targets': [4],
                    'visible': true
                }
                // ,{ 'bSortable': true, 'bSort': false, 'aTargets': [ '_all' ] }
            ],
            // responsive: true,
            searching: true,
            select: true,
            order: [0, 'desc'],
            dom: "<\n             <\"row\"\n               <\"col-lg-3 col-md-12\"l>\n               <\"col-lg-6 col-md-12 button-wrapper btn-sm danger\"B>\n               <\"col-lg-3 col-md-12\"f>><hr>\n             <\"row\" <\"col\"t>>\n             <\"row\"\n               <\"col\"i>\n               <\"col btn-sm\"p>>\n             >",
            buttons: [
                'copy', 'csv', 'excel', 'pdf', 'print',
                {
                    text: 'GroupBy',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
                {
                    text: 'Some button',
                    key: '1',
                    action: function (e, dt, node, config) {
                        alert('Button activated');
                    }
                },
            ],
            'bLengthChange': true,
            'Filter': true,
            // retrieve: true,
            language: {
                search: '_INPUT_',
                searchPlaceholder: 'Search records',
            },
            'Info': true,
        };
        // this.dtTrigger.unsubscribe();
        this.resourcesService.getResourcesAndRates();
        this.getResources();
        // this.rerender();
        setTimeout(function () {
        }, 200);
    };
    ResourcesComponent.prototype.getResources = function () {
        var _this = this;
        this.resourcesService.resourcesandrates.subscribe(function (resources) {
            _this.resources = resources;
            _this.resources$.next(resources);
            // this.dtTrigger.next();
            console.log(_this.resources$);
            _this.resourceCount = formatNumber(_this.resources.length);
            setTimeout(function () {
            }, 250);
        });
    };
    ResourcesComponent.prototype.filter = function (search) {
        this.resources$.next(this.resources.filter(function (_) { return _.displayName.toLowerCase().includes(search.toLowerCase()); }));
    };
    ResourcesComponent.prototype.openContent = function () {
        var modalRef = this.modalService.open(_resource_new_resource_component__WEBPACK_IMPORTED_MODULE_6__["NewResourceComponent"], { size: 'lg', windowClass: 'modal-xl' });
        modalRef.componentInstance.name = 'World';
    };
    // Open default modal
    ResourcesComponent.prototype.open = function (content) {
        var _this = this;
        this.modalService.open(content).result.then(function (result) {
            _this.closeResult = "Closed with: " + result;
        }, function (reason) {
            _this.closeResult = "Dismissed " + _this.getDismissReason(reason);
        });
    };
    // This function is used in open
    ResourcesComponent.prototype.getDismissReason = function (reason) {
        if (reason === _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_5__["ModalDismissReasons"].ESC) {
            return 'by pressing ESC';
        }
        else if (reason === _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_5__["ModalDismissReasons"].BACKDROP_CLICK) {
            return 'by clicking on a backdrop';
        }
        else {
            return "with: " + reason;
        }
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["ViewChild"])(angular_datatables__WEBPACK_IMPORTED_MODULE_7__["DataTableDirective"]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", angular_datatables__WEBPACK_IMPORTED_MODULE_7__["DataTableDirective"])
    ], ResourcesComponent.prototype, "dtElement", void 0);
    ResourcesComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["Component"])({
            selector: 'app-resources',
            template: __webpack_require__(/*! ./resources.component.html */ "./src/app/resources/resources/resources.component.html"),
            styles: [__webpack_require__(/*! ./resources.component.scss */ "./src/app/resources/resources/resources.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_resources_service__WEBPACK_IMPORTED_MODULE_4__["ResourceService"], _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_5__["NgbModal"]])
    ], ResourcesComponent);
    return ResourcesComponent;
}());

function formatNumber(num) {
    return num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,');
}


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
//# sourceMappingURL=resources-resources-module.js.map