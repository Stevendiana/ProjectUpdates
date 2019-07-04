(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["timesheets-timesheets-module"],{

/***/ "./src/app/timesheets/timesheets-routing.module.ts":
/*!*********************************************************!*\
  !*** ./src/app/timesheets/timesheets-routing.module.ts ***!
  \*********************************************************/
/*! exports provided: TimesheetsRoutingModule, routedComponents */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TimesheetsRoutingModule", function() { return TimesheetsRoutingModule; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "routedComponents", function() { return routedComponents; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm5/router.js");
/* harmony import */ var _timesheets_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./timesheets.component */ "./src/app/timesheets/timesheets.component.ts");




var routes = [
    {
        path: '',
        component: _timesheets_component__WEBPACK_IMPORTED_MODULE_3__["TimesheetsComponent"],
        data: {
            title: 'Timesheets'
        },
    }
];
var TimesheetsRoutingModule = /** @class */ (function () {
    function TimesheetsRoutingModule() {
    }
    TimesheetsRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forChild(routes)],
            exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
        })
    ], TimesheetsRoutingModule);
    return TimesheetsRoutingModule;
}());

var routedComponents = [_timesheets_component__WEBPACK_IMPORTED_MODULE_3__["TimesheetsComponent"]];


/***/ }),

/***/ "./src/app/timesheets/timesheets.component.html":
/*!******************************************************!*\
  !*** ./src/app/timesheets/timesheets.component.html ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "<div class=\"email-application\">\r\n  <div #contentOverlay class=\"content-overlay\" (click)=\"onContentOverlay()\"></div>\r\n  <div #emailSidebar class=\"email-app-sidebar float-left d-none d-xl-block\">\r\n    <div [perfectScrollbar] class=\"email-app-sidebar-content\">\r\n      <div class=\"email-app-menu\">\r\n        <div class=\"form-group form-group-compose text-center\">\r\n          <!-- <button type=\"button\" class=\"btn btn-raised btn-danger btn-block my-2\" (click)=\"open(content)\">\r\n            <i class=\"ft-mail\"></i> Compose</button> -->\r\n        </div>\r\n        <h6 class=\"text-muted text-bold-500 mb-1 text-left\">My Timesheets</h6>\r\n        <div class=\"list-group list-group-messages\">\r\n          <a class=\"list-group-item active no-border text-left\" (click)=\"GetEmailsByType($event, 'Inbox')\">\r\n            <i class=\"ft-inbox mr-1 pr-1 float-left\"></i> Inbox\r\n            <span class=\"badge badge-dark badge-pill float-right\">8</span>\r\n          </a>\r\n          <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetEmailsByType($event, 'Sent')\">\r\n            <i class=\"fa fa-paper-plane-o mr-1 pr-1 float-left\"></i> Sent</a>\r\n          <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetEmailsByType($event, 'Work')\">\r\n            <i class=\"ft-file mr-1 pr-1 float-left\"></i> Draft</a>\r\n          <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetStarredEmails($event)\">\r\n            <i class=\"ft-star mr-1 pr-1 float-left\"></i> Starred\r\n            <span class=\"badge badge-danger badge-pill float-right\">3</span>\r\n          </a>\r\n          <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetEmailsByType($event, 'Trash')\">\r\n            <i class=\"ft-trash-2 mr-1 pr-1 float-left\"></i> Trash</a>\r\n        </div>\r\n        <h6 class=\"text-muted text-bold-500 mt-1 mb-1 text-left\">Labels</h6>\r\n        <div class=\"list-group list-group-messages\">\r\n          <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetEmailsByLabel($event, 'Work')\">\r\n            <i class=\"ft-circle mr-1 pr-1 float-left warning\"></i> Work\r\n            <span class=\"badge badge-warning badge-pill float-right\">5</span>\r\n          </a>\r\n          <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetEmailsByLabel($event, 'Family')\">\r\n            <i class=\"ft-circle mr-1 pr-1 float-left danger\"></i> Family</a>\r\n          <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetEmailsByLabel($event, 'Friends')\">\r\n            <i class=\"ft-circle mr-1 pr-1 float-left primary\"></i> Friends</a>\r\n          <a class=\"list-group-item list-group-item-action no-border text-left\" (click)=\"GetEmailsByLabel($event, 'Private')\">\r\n            <i class=\"ft-circle mr-1 pr-1 float-left success\"></i> Private\r\n            <span class=\"badge badge-success badge-pill float-right\">3</span>\r\n          </a>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n  <div class=\"email-app-content row\">\r\n    <div class=\"email-search-box w-100 bg-white p-2\">\r\n      <div class=\"media\">\r\n        <span class=\"email-app-sidebar-toggle ft-align-justify font-large-1 mr-2 d-xl-none\" (click)=\"onSidebarToggle()\"></span>\r\n        <div class=\"media-body\">\r\n          <input type=\"text\" class=\"form-control round\" placeholder=\"search for emails\" [(ngModel)]=\"searchQuery\">\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n    <div class=\"email-app-content-area w-100\">\r\n      <div class=\"email-app-list-mails p-0\" (click)=\"onListItemClick()\">\r\n        <div [perfectScrollbar] class=\"email-app-list\">\r\n          <div id=\"users-list\">\r\n            <div *ngIf=\"timesheets\" class=\"list-group\">\r\n              <div class=\"users-list-padding\">\r\n                <a [ngClass]=\"true ? 'list-group-item list-group-item-action no-border' : 'list-group-item list-group-item-action bg-blue-grey bg-lighten-5 border-right-primary border-right-2'\"\r\n                  *ngFor=\"let timesheet of timesheets | search:'timesheet.calendarTime.sundayYear,timesheet.calendarTime.sunday,timesheet.calendarTime.monday':searchQuery\"  (click)=\"DisplayMessage($event, [timesheet.mailId])\">\r\n                  <span class=\"media\">\r\n                    <span class=\"avatar avatar-md mr-2\">\r\n                      <span *ngIf=\"true\" class=\"media-object rounded-circle text-circle d-flex mr-2 ml-0 justify-content-center align-items-center + ' ' + bg-info\">{{\r\n                        timesheet.calendarTime.sundayMonthInWords.substring(0,3) }}</span>\r\n                      <!-- <img *ngIf=\"mail.hasImage\" class=\"media-object rounded-circle\" [src]=\"mail.imagePath\" alt=\"Generic placeholder image\"> -->\r\n                    </span>\r\n                    <div class=\"media-body text-left\">\r\n                      <h6 [ngClass]=\"false === false ? 'list-group-item-heading text-bold-400' : 'list-group-item-heading' \">Week From: {{\r\n                        timesheet.calendarTime.sunday | date}}\r\n                        <span class=\"float-right\">\r\n                          <!-- <i class=\"fa-paperclip fa\" *ngIf=\"true\"></i> -->\r\n                          <span [ngClass]=\"false === false ? 'font-small-2 primary' : 'font-small-2 float-right'\">To: {{\r\n                            timesheet.calendarTime.saturday | date }}</span>\r\n                        </span>\r\n                      </h6>\r\n                      <p [ngClass]=\"true === false ? 'list-group-item-text text-truncate text-bold-500' : 'list-group-item-text text-truncate' \">Billable Hours: {{\r\n                        timesheet.totalBillableHours }}</p>\r\n                      <p class=\"list-group-item-text\">Total Hours: {{ timesheet.totalHours }}\r\n                        <span class=\"float-right primary\" *ngIf=\"true\">\r\n                          <span class=\"badge mr-1 + ' ' + 'badge badge-success mr-1'\">Approved</span>\r\n                          <!-- <span class=\"badge mr-1 + ' ' + {{mail.labelClass}}\">{{\r\n                            timesheet.labelType }}</span> -->\r\n                          <!-- <i *ngIf=\"isEmailImportant\" class=\"float-right font-medium-1 ft-star warning\"></i>\r\n                          <i *ngIf=\"!isEmailImportant\" class=\"float-right font-medium-1 ft-star blue-grey\"></i> -->\r\n                          <!-- <i [ngClass]=\"mail.isImportant === false ? 'font-medium-1 ft-star blue-grey lighten-3' : 'font-medium-1 ft-star warning'\"></i> -->\r\n                        </span>\r\n                        <span class=\"float-right primary\" *ngIf=\"false\">\r\n                          <i class=\"font-medium-1 ft-star blue-grey lighten-3\"></i>\r\n                        </span>\r\n\r\n                      </p>\r\n\r\n\r\n                    </div>\r\n                  </span>\r\n                </a>\r\n                <p class=\"primary text-center\" *ngIf=\"timesheets.length === 0\">There are no messages!</p>\r\n              </div>\r\n            </div>\r\n\r\n          </div>\r\n        </div>\r\n\r\n        <hr>\r\n      </div>\r\n      <div class=\"email-app-mail-content\" #emailContent>\r\n        <div class=\"email-app-mail-content-detail\" *ngIf=\"isMessageSelected\">\r\n          <div class=\"email-app-options card-body\">\r\n            <div class=\"row d-md-none\">\r\n              <button class=\"btn btn-raised btn-primary ml-2 back-to-inbox\" (click)=\"OnBackTotimesheets()\">\r\n                <i class=\"fa fa-angle-left\"></i> Back to inbox</button>\r\n            </div>\r\n            <div class=\"row\">\r\n              <div class=\"col-sm-6 col-12 text-left\">\r\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                  <button type=\"button\" class=\"btn btn-sm btn-outline-secondary\" data-toggle=\"tooltip\" data-placement=\"top\"\r\n                    data-original-title=\"Replay\">\r\n                    <i class=\"fa fa-reply\"></i>\r\n                  </button>\r\n                  <button type=\"button\" class=\"btn btn-sm btn-outline-secondary\" data-toggle=\"tooltip\" data-placement=\"top\"\r\n                    data-original-title=\"Replay All\">\r\n                    <i class=\"fa fa-reply-all\"></i>\r\n                  </button>\r\n                  <button type=\"button\" class=\"btn btn-sm btn-outline-secondary\" data-toggle=\"tooltip\" data-placement=\"top\"\r\n                    data-original-title=\"Report SPAM\">\r\n                    <i class=\"ft-alert-octagon\"></i>\r\n                  </button>\r\n                  <button type=\"button\" class=\"btn btn-sm btn-outline-secondary\" data-toggle=\"tooltip\" data-placement=\"top\"\r\n                    data-original-title=\"Delete\">\r\n                    <i class=\"ft-trash-2\"></i>\r\n                  </button>\r\n                </div>\r\n              </div>\r\n              <div class=\"col-sm-6 col-12 text-right\">\r\n                <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                  <button type=\"button\" class=\"btn btn-sm btn-outline-secondary\" data-toggle=\"tooltip\" data-placement=\"top\"\r\n                    data-original-title=\"Previous\">\r\n                    <i class=\"fa fa-angle-left\"></i>\r\n                  </button>\r\n                  <button type=\"button\" class=\"btn btn-sm btn-outline-secondary\" data-toggle=\"tooltip\" data-placement=\"top\"\r\n                    data-original-title=\"Next\">\r\n                    <i class=\"fa fa-angle-right\"></i>\r\n                  </button>\r\n                </div>\r\n                <div class=\"btn-group ml-1\">\r\n                  <div ngbDropdown [placement]=\"placement\" class=\"d-inline-block\">\r\n                    <button class=\"btn btn-sm btn-outline-secondary\" id=\"dropdownBasic1\" ngbDropdownToggle>More</button>\r\n                    <div ngbDropdownMenu aria-labelledby=\"dropdownBasic1\">\r\n                      <button class=\"dropdown-item\" (click)=\"markAsUnread();\">Mark as unread</button>\r\n                      <button class=\"dropdown-item\" *ngIf=\"!isEmailImportant\" (click)=\"markAsImportant();\">Mark\r\n                        as important</button>\r\n                      <button class=\"dropdown-item\" *ngIf=\"isEmailImportant\" (click)=\"markAsUnimportant();\">Mark\r\n                        as unimportant</button>\r\n                      <button class=\"dropdown-item\">Add star</button>\r\n                      <button class=\"dropdown-item\">Add to task</button>\r\n                      <div class=\"dropdown-divider\"></div>\r\n                      <button class=\"dropdown-item\">Filter mail</button>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n\r\n          <div class=\"email-app-title card-body\">\r\n            <h3 class=\"list-group-item-heading text-left\">{{message.subject}}</h3>\r\n            <div class=\"row\">\r\n              <div class=\"col-sm-6 col-12 text-left\">\r\n                <span class=\"primary\">\r\n                  <span class=\"badge badge-primary \">Previous</span>\r\n                </span>\r\n              </div>\r\n              <div class=\"col-sm-6 col-12 text-right\">\r\n                <!-- <i *ngIf=\"isEmailImportant\" class=\"float-right font-medium-3 ft-star warning\"></i> -->\r\n                <!-- <i *ngIf=\"!isEmailImportant\" class=\"float-right font-medium-3 ft-star\"></i> -->\r\n              </div>\r\n            </div>\r\n          </div>\r\n\r\n          <div *ngFor=\"let messageDetail of message.messages\">\r\n            <div id=\"headingCollapse2\" class=\"card-header p-0\">\r\n              <a (click)=\"messageDetail.collapsed = !messageDetail.collapsed\" [attr.aria-expanded]=\"!messageDetail.collapsed\"\r\n                [attr.aria-controls]=\"messageDetail.messageId\">\r\n                <div class=\"email-app-sender list-group-item list-group-item-action no-border\">\r\n                  <div class=\"media\">\r\n                    <span class=\"avatar avatar-md mr-2\">\r\n                      <span *ngIf=\"!messageDetail.hasAvatar\" class=\"media-object rounded-circle text-circle d-flex mr-2 justify-content-center align-items-center + ' ' + {{messageDetail.avatarClass}}\">{{\r\n                        messageDetail.avatarText }}</span>\r\n                      <img *ngIf=\"messageDetail.hasAvatar\" class=\"media-object rounded-circle\" [src]=\"messageDetail.avatarPath\"\r\n                        alt=\"Generic placeholder image\">\r\n                    </span>\r\n                    <div class=\"media-body text-left\">\r\n                      <h6 class=\"list-group-item-heading\">{{messageDetail.mailFrom}}</h6>\r\n                      <p class=\"list-group-item-text\">to {{messageDetail.mailTo}}\r\n                        <span class=\"primary\">{{messageDetail.time}}</span>\r\n                        <span class=\"float-right\">\r\n                          <i class=\"fa fa-reply mr-1\"></i>\r\n                          <i class=\"fa fa-arrow-right mr-1\"></i>\r\n                          <i class=\"fa fa-ellipsis-v\"></i>\r\n                        </span>\r\n                      </p>\r\n\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </a>\r\n            </div>\r\n            <div [id]=\"messageDetail.messageId\" [ngbCollapse]=\"messageDetail.collapsed\">\r\n              <div class=\"card-content\">\r\n                <div class=\"email-app-text card-body\">\r\n                  <div class=\"email-app-message text-left\">\r\n                    <div [innerHTML]=\"messageDetail.body\">\r\n                    </div>\r\n                    <div *ngIf=\"messageDetail.hasAttachment\">\r\n                      <p class=\"primary\">Attachments:</p>\r\n                      <div *ngFor=\"let attachment of messageDetail.attachments\" class=\"float-left mr-2\">\r\n                        <img class=\"media-object width-100\" [src]=\"attachment.url\" alt=\"Generic placeholder image\">\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n            <div class=\"email-app-text-action card-body\">\r\n\r\n            </div>\r\n          </div>\r\n\r\n        </div>\r\n        <div class=\"email-app-mail-content-detail\" *ngIf=\"!isMessageSelected\">\r\n          <p class=\"primary text-center\">Select a message to read</p>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n  <ng-template #content let-c=\"close\" let-d=\"dismiss\">\r\n    <div class=\"modal-header px-4\">\r\n      <h4 class=\"modal-title\">Compose Email</h4>\r\n      <button type=\"button\" class=\"close\" aria-label=\"Close\" (click)=\"d('Cross click')\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n      </button>\r\n    </div>\r\n    <div class=\"modal-body px-4\">\r\n      <form role=\"form\" class=\"form form-horizontal\">\r\n        <div class=\"form-group row\">\r\n          <label class=\"col-md-2 label-control\" for=\"emailTo\">To </label>\r\n          <div class=\"col-md-10\">\r\n            <input type=\"text\" id=\"emailTo\" class=\"form-control\" name=\"emailTo\">\r\n          </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n          <label class=\"col-md-2 label-control\" for=\"emailCC\">Cc / Bcc </label>\r\n          <div class=\"col-md-10\">\r\n            <input type=\"text\" id=\"emailCC\" class=\"form-control\" name=\"emailCC\">\r\n          </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n          <label class=\"col-md-2 label-control\" for=\"emailSubject\">Subject </label>\r\n          <div class=\"col-md-10\">\r\n            <input type=\"text\" id=\"emailSubject\" class=\"form-control\" name=\"emailSubject\">\r\n          </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n          <label class=\"col-md-2 label-control\">Message</label>\r\n          <div class=\"col-md-10\">\r\n            <quill-editor [style]=\"{height: '200px'}\"></quill-editor>\r\n          </div>\r\n        </div>\r\n\r\n      </form>\r\n    </div>\r\n    <div class=\"modal-footer px-4\">\r\n      <i class=\"fa-paperclip fa font-large-1 mr-3\"></i>\r\n      <button type=\"button\" class=\"btn btn-outline-dark\" (click)=\"c('Close click')\">Cancel</button>\r\n      <button type=\"button\" class=\"btn btn-raised btn-danger\" (click)=\"c('Close click')\">Save as Draft</button>\r\n      <button type=\"button\" class=\"btn btn-raised btn-primary\" (click)=\"c('Close click')\">Send</button>\r\n    </div>\r\n  </ng-template>\r\n</div>\r\n"

/***/ }),

/***/ "./src/app/timesheets/timesheets.component.scss":
/*!******************************************************!*\
  !*** ./src/app/timesheets/timesheets.component.scss ***!
  \******************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = "\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3RpbWVzaGVldHMvdGltZXNoZWV0cy5jb21wb25lbnQuc2NzcyJ9 */"

/***/ }),

/***/ "./src/app/timesheets/timesheets.component.ts":
/*!****************************************************!*\
  !*** ./src/app/timesheets/timesheets.component.ts ***!
  \****************************************************/
/*! exports provided: TimesheetsComponent */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TimesheetsComponent", function() { return TimesheetsComponent; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var app_shared_services_layout_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! app/shared/services/layout.service */ "./src/app/shared/services/layout.service.ts");
/* harmony import */ var app_shared_services_config_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! app/shared/services/config.service */ "./src/app/shared/services/config.service.ts");
/* harmony import */ var _timesheets_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./timesheets.service */ "./src/app/timesheets/timesheets.service.ts");






// import { ConfigService } from '../services/config.service';
var TimesheetsComponent = /** @class */ (function () {
    function TimesheetsComponent(elRef, renderer, modalService, timesheetsService, layoutService, configService) {
        var _this = this;
        this.elRef = elRef;
        this.renderer = renderer;
        this.modalService = modalService;
        this.timesheetsService = timesheetsService;
        this.layoutService = layoutService;
        this.configService = configService;
        this.placement = 'bottom-right';
        this.config = {};
        this.searchQuery = '';
        this.selectedMailId = 4;
        this.isEmailImportant = false;
        this.isCollapsed = true;
        this.isCollapsed1 = false;
        this.isMessageSelected = true;
        this.timesheets = [];
        this.timesheetsService.getTimesheets();
        setTimeout(function () { _this.timesheets = _this.timesheetsService.timesheetsData; }, 1500);
        this.mail = this.timesheetsService.timesheets.filter(function (mail) { return mail.mailType === 'Inbox'; });
        this.message = this.timesheetsService.message.filter(function (message) { return message.mailId === _this.selectedMailId; })[0];
        this.markAsRead();
        this.checkEmailImportantStatus();
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
    TimesheetsComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.innerWidth = window.innerWidth;
        this.config = this.configService.templateConf;
        this.timesheetsService.getTimesheets();
        setTimeout(function () {
            _this.timesheets = _this.timesheetsService.timesheetsData;
            _this.selectedMailId = _this.timesheets[0].calendarTimeId;
        }, 1500);
        // this.timesheetsService.alltimesheets.subscribe(timesheets => {
        //   // tslint:disable-next-line:curly
        //   if (timesheets.length === 0) return;
        //   setTimeout(() => {
        //     this.timesheets = timesheets;
        //     }, 250);
        // });
        console.log(this.timesheets);
    };
    TimesheetsComponent.prototype.ngAfterViewInit = function () {
        if (this.innerWidth < 768) {
            this.renderer.addClass(this.content.nativeElement, 'hide-email-content');
        }
        if (this.config.layout.dir) {
            var dir = this.config.layout.dir;
            if (dir === 'rtl') {
                this.placement = 'bottom-left';
            }
            else if (dir === 'ltr') {
                this.placement = 'bottom-right';
            }
        }
    };
    TimesheetsComponent.prototype.ngOnDestroy = function () {
        if (this.layoutSub) {
            this.layoutSub.unsubscribe();
        }
    };
    TimesheetsComponent.prototype.markAsRead = function () {
        var _this = this;
        var updateItem = this.mail.find(function (item) { return item.mailId.toString() === _this.selectedMailId.toString(); });
        var index = this.mail.indexOf(updateItem);
        this.mail[index].isRead = true;
    };
    TimesheetsComponent.prototype.markAsUnread = function () {
        var _this = this;
        var updateItem = this.mail.find(function (item) { return item.mailId.toString() === _this.selectedMailId.toString(); });
        var index = this.mail.indexOf(updateItem);
        this.mail[index].isRead = false;
    };
    TimesheetsComponent.prototype.markAsImportant = function () {
        var _this = this;
        var updateItem = this.mail.find(function (item) { return item.mailId.toString() === _this.selectedMailId.toString(); });
        var index = this.mail.indexOf(updateItem);
        this.mail[index].isImportant = true;
        this.isEmailImportant = true;
    };
    TimesheetsComponent.prototype.markAsUnimportant = function () {
        var _this = this;
        var updateItem = this.mail.find(function (item) { return item.mailId.toString() === _this.selectedMailId.toString(); });
        var index = this.mail.indexOf(updateItem);
        this.mail[index].isImportant = false;
        this.isEmailImportant = false;
    };
    TimesheetsComponent.prototype.checkEmailImportantStatus = function () {
        var _this = this;
        var selectedEmail = this.mail.find(function (item) { return item.mailId.toString() === _this.selectedMailId.toString(); });
        this.isEmailImportant = selectedEmail.isImportant;
    };
    // timesheets user list click event function
    TimesheetsComponent.prototype.DisplayMessage = function (event, mailId) {
        this.selectedMailId = mailId;
        this.message = this.timesheetsService.message.filter(function (message) { return message.mailId.toString() === mailId.toString(); })[0];
        this.isMessageSelected = true;
        this.markAsRead();
        this.checkEmailImportantStatus();
        var hElement = this.elRef.nativeElement;
        // now you can simply get your elements with their class name
        var allAnchors = hElement.querySelectorAll('.users-list-padding > a.list-group-item');
        // do something with selected elements
        [].forEach.call(allAnchors, function (item) {
            item.setAttribute('class', 'list-group-item list-group-item-action no-border');
        });
        // set active class for selected item
        event.currentTarget.setAttribute('class', 'list-group-item list-group-item-action bg-blue-grey bg-lighten-5 border-right-primary border-right-2');
    };
    // compose popup start
    TimesheetsComponent.prototype.open = function (content) {
        var _this = this;
        this.modalService.open(content, { size: 'lg' }).result.then(function (result) {
            _this.closeResult = "Closed with: " + result;
        }, function (reason) {
            _this.closeResult = "Dismissed " + _this.getDismissReason(reason);
        });
    };
    TimesheetsComponent.prototype.getDismissReason = function (reason) {
        if (reason === _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__["ModalDismissReasons"].ESC) {
            return 'by pressing ESC';
        }
        else if (reason === _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__["ModalDismissReasons"].BACKDROP_CLICK) {
            return 'by clicking on a backdrop';
        }
        else {
            return "with: " + reason;
        }
    };
    // compose popup ends
    // timesheets labels click event function
    TimesheetsComponent.prototype.GetEmailsByLabel = function (event, labelType) {
        this.mail = this.timesheetsService.timesheets.filter(function (mail) { return mail.labelType === labelType; });
        this.SetItemActive(event);
    };
    // timesheets type click event function
    TimesheetsComponent.prototype.GetEmailsByType = function (event, type) {
        this.mail = this.timesheetsService.timesheets.filter(function (mail) { return mail.mailType === type; });
        this.SetItemActive(event);
    };
    // timesheets Starred click event function
    TimesheetsComponent.prototype.GetStarredEmails = function (event) {
        this.mail = this.timesheetsService.timesheets.filter(function (mail) { return mail.isImportant === true; });
        this.SetItemActive(event);
    };
    TimesheetsComponent.prototype.SetItemActive = function (event) {
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
    TimesheetsComponent.prototype.onResize = function (event) {
        this.innerWidth = window.innerWidth;
        if (this.innerWidth < 768) {
            this.renderer.addClass(this.content.nativeElement, 'hide-email-content');
        }
        if (this.innerWidth > 768) {
            this.renderer.removeClass(this.content.nativeElement, 'hide-email-content');
        }
    };
    TimesheetsComponent.prototype.onListItemClick = function () {
        this.renderer.removeClass(this.content.nativeElement, 'hide-email-content');
    };
    TimesheetsComponent.prototype.OnBackTotimesheets = function () {
        this.renderer.addClass(this.content.nativeElement, 'hide-email-content');
    };
    TimesheetsComponent.prototype.onSidebarToggle = function () {
        this.renderer.removeClass(this.sidebar.nativeElement, 'd-none');
        this.renderer.addClass(this.sidebar.nativeElement, 'd-block');
        this.renderer.addClass(this.overlay.nativeElement, 'show');
    };
    TimesheetsComponent.prototype.onContentOverlay = function () {
        this.renderer.removeClass(this.overlay.nativeElement, 'show');
        this.renderer.removeClass(this.sidebar.nativeElement, 'd-block');
        this.renderer.addClass(this.sidebar.nativeElement, 'd-none');
    };
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('emailSidebar'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], TimesheetsComponent.prototype, "sidebar", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('contentOverlay'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], TimesheetsComponent.prototype, "overlay", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["ViewChild"])('emailContent'),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", _angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"])
    ], TimesheetsComponent.prototype, "content", void 0);
    tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["HostListener"])('window:resize', ['$event']),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:type", Function),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [Object]),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:returntype", void 0)
    ], TimesheetsComponent.prototype, "onResize", null);
    TimesheetsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
            selector: 'app-timesheets',
            template: __webpack_require__(/*! ./timesheets.component.html */ "./src/app/timesheets/timesheets.component.html"),
            styles: [__webpack_require__(/*! ./timesheets.component.scss */ "./src/app/timesheets/timesheets.component.scss")]
        }),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__["ElementRef"], _angular_core__WEBPACK_IMPORTED_MODULE_1__["Renderer2"],
            _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_2__["NgbModal"], _timesheets_service__WEBPACK_IMPORTED_MODULE_5__["TimesheetsService"],
            app_shared_services_layout_service__WEBPACK_IMPORTED_MODULE_3__["LayoutService"], app_shared_services_config_service__WEBPACK_IMPORTED_MODULE_4__["ConfigService"]])
    ], TimesheetsComponent);
    return TimesheetsComponent;
}());



/***/ }),

/***/ "./src/app/timesheets/timesheets.model.ts":
/*!************************************************!*\
  !*** ./src/app/timesheets/timesheets.model.ts ***!
  \************************************************/
/*! exports provided: Mail, Message, TimesheetTotals, MessageDetail, Attachments */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Mail", function() { return Mail; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Message", function() { return Message; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TimesheetTotals", function() { return TimesheetTotals; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "MessageDetail", function() { return MessageDetail; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "Attachments", function() { return Attachments; });
var Mail = /** @class */ (function () {
    function Mail(mailId, mailFrom, subject, body, time, isRead, isImportant, hasAttachment, hasImage, imagePath, imageText, imageClass, mailType, hasLabel, labelType, labelClass, isDefault) {
        this.mailId = mailId;
        this.mailFrom = mailFrom;
        this.subject = subject;
        this.body = body;
        this.time = time;
        this.isRead = isRead;
        this.isImportant = isImportant;
        this.hasAttachment = hasAttachment;
        this.hasImage = hasImage;
        this.imagePath = imagePath;
        this.imageText = imageText;
        this.imageClass = imageClass;
        this.mailType = mailType;
        this.hasLabel = hasLabel;
        this.labelType = labelType;
        this.labelClass = labelClass;
        this.isDefault = isDefault;
    }
    return Mail;
}());

var Message = /** @class */ (function () {
    function Message(mailId, subject, messagesCount, messages) {
        this.mailId = mailId;
        this.subject = subject;
        this.messagesCount = messagesCount;
        this.messages = messages;
    }
    return Message;
}());

var TimesheetTotals = /** @class */ (function () {
    // public resourceTimesheets: MessageDetail[];
    function TimesheetTotals(calendarTimeId, totalBillableHours, totalNonBillableHours, totalHours, totalOvertimeBillableHours, totalOvertimeNonBillableHours, totalStandardDayBillableHours, totalStandardDayNonBillableHours, calendarTime
    // , resourceTimesheets: MessageDetail[]
    ) {
        this.calendarTimeId = calendarTimeId;
        this.totalBillableHours = totalBillableHours;
        this.totalNonBillableHours = totalNonBillableHours;
        this.totalHours = totalHours;
        this.totalOvertimeBillableHours = totalOvertimeBillableHours;
        this.totalOvertimeNonBillableHours = totalOvertimeNonBillableHours;
        this.totalStandardDayBillableHours = totalStandardDayBillableHours;
        this.totalStandardDayNonBillableHours = totalStandardDayNonBillableHours;
        this.calendarTime = calendarTime;
        // this.resourceTimesheets = resourceTimesheets;
    }
    return TimesheetTotals;
}());

var MessageDetail = /** @class */ (function () {
    function MessageDetail(messageId, mailFrom, mailTo, body, time, collapsed, hasAttachment, hasAvatar, avatarPath, avatarText, avatarClass, attachments) {
        this.messageId = messageId;
        this.mailFrom = mailFrom;
        this.mailTo = mailTo;
        this.body = body;
        this.time = time;
        this.collapsed = collapsed;
        this.hasAttachment = hasAttachment;
        this.hasAvatar = hasAvatar;
        this.avatarPath = avatarPath;
        this.avatarText = avatarText;
        this.avatarClass = avatarClass;
        this.attachments = attachments;
    }
    return MessageDetail;
}());

var Attachments = /** @class */ (function () {
    function Attachments(attachmentId, url) {
        this.attachmentId = attachmentId;
        this.url = url;
    }
    return Attachments;
}());



/***/ }),

/***/ "./src/app/timesheets/timesheets.module.ts":
/*!*************************************************!*\
  !*** ./src/app/timesheets/timesheets.module.ts ***!
  \*************************************************/
/*! exports provided: TimesheetsModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TimesheetsModule", function() { return TimesheetsModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm5/http.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "./node_modules/@angular/common/fesm5/common.js");
/* harmony import */ var _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @ng-bootstrap/ng-bootstrap */ "./node_modules/@ng-bootstrap/ng-bootstrap/fesm5/ng-bootstrap.js");
/* harmony import */ var ngx_quill__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ngx-quill */ "./node_modules/ngx-quill/fesm5/ngx-quill.js");
/* harmony import */ var ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ngx-perfect-scrollbar */ "./node_modules/ngx-perfect-scrollbar/dist/ngx-perfect-scrollbar.es5.js");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm5/forms.js");
/* harmony import */ var _timesheets_routing_module__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./timesheets-routing.module */ "./src/app/timesheets/timesheets-routing.module.ts");
/* harmony import */ var _timesheets_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./timesheets.component */ "./src/app/timesheets/timesheets.component.ts");
/* harmony import */ var app_inbox_inbox_module__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! app/inbox/inbox.module */ "./src/app/inbox/inbox.module.ts");
/* harmony import */ var _timesheets_service__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! ./timesheets.service */ "./src/app/timesheets/timesheets.service.ts");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");


// import { SearchPipe } from 'app/shared/pipes/search.pipe';











var TimesheetsModule = /** @class */ (function () {
    function TimesheetsModule() {
    }
    TimesheetsModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_3__["CommonModule"],
                _angular_common_http__WEBPACK_IMPORTED_MODULE_1__["HttpClientModule"],
                _angular_http__WEBPACK_IMPORTED_MODULE_12__["HttpModule"],
                _timesheets_routing_module__WEBPACK_IMPORTED_MODULE_8__["TimesheetsRoutingModule"],
                _ng_bootstrap_ng_bootstrap__WEBPACK_IMPORTED_MODULE_4__["NgbModule"],
                ngx_quill__WEBPACK_IMPORTED_MODULE_5__["QuillModule"],
                _angular_forms__WEBPACK_IMPORTED_MODULE_7__["FormsModule"],
                app_inbox_inbox_module__WEBPACK_IMPORTED_MODULE_10__["InboxModule"],
                ngx_perfect_scrollbar__WEBPACK_IMPORTED_MODULE_6__["PerfectScrollbarModule"]
            ],
            declarations: [
                _timesheets_component__WEBPACK_IMPORTED_MODULE_9__["TimesheetsComponent"],
            ],
            providers: [_timesheets_service__WEBPACK_IMPORTED_MODULE_11__["TimesheetsService"]]
        })
    ], TimesheetsModule);
    return TimesheetsModule;
}());



/***/ }),

/***/ "./src/app/timesheets/timesheets.service.ts":
/*!**************************************************!*\
  !*** ./src/app/timesheets/timesheets.service.ts ***!
  \**************************************************/
/*! exports provided: TimesheetsService */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "TimesheetsService", function() { return TimesheetsService; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm5/core.js");
/* harmony import */ var _timesheets_model__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./timesheets.model */ "./src/app/timesheets/timesheets.model.ts");
/* harmony import */ var _angular_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/http */ "./node_modules/@angular/http/fesm5/http.js");
/* harmony import */ var environments_environment__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! environments/environment */ "./src/environments/environment.ts");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm5/index.js");






var TimesheetsService = /** @class */ (function () {
    function TimesheetsService(http) {
        this.http = http;
        this.timesheets = [
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](1, 'Tonny Deep', 'PixInvent, I found you...', 'I would be good.', '4:14 AM', false, true, false, false, '', 'T', 'bg-info', 'Inbox', true, 'Family', 'badge badge-danger mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](2, 'Louis Welch', 'Thanks, Let us do it.', 'Can we connect today...', '2:15 AM', false, false, true, false, '', 'L', 'bg-danger', 'Inbox', false, '', '', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](3, 'Envato Market', 'You have new comment...', 'Hi Pixinvent...', '11:18 PM', false, false, false, false, '', 'E', 'bg-warning', 'Inbox', true, 'Work', 'badge badge-warning mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](4, 'Wayne Burton', 'Project ABC Status...', 'Andy, Let us...', 'Today', true, true, false, true, 'assets/img/portrait/small/avatar-s-7.png', '', '', 'Inbox', true, 'Private', 'badge badge-success mr-1', true),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](5, 'Sarah Montgomery', 'Your New UI.', 'Everything looks good.', 'Yesterday', true, true, false, true, 'assets/img/portrait/small/avatar-s-5.png', '', '', 'Inbox', true, 'Friends', 'badge badge-primary mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](6, 'Heather Howell', 'Thanks, Let us do it.', 'Can we connect today...', '15 July', true, false, true, false, '', 'H', 'bg-success', 'Inbox', false, '', '', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](7, 'Kelly Reyes', 'I paid it, Thanks.', 'Check once...', '12 July', false, false, true, true, 'assets/img/portrait/small/avatar-s-8.png', '', '', 'Inbox', true, 'Work', 'badge badge-warning mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](8, 'Vincent Nelson', 'Where are you John?', 'Party tonight ?', '11 July', true, false, false, false, '', 'V', 'bg-warning', 'Sent', true, 'Friends', 'badge badge-primary mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](9, 'Elizabeth Elliott', 'Okay, I will call you.', 'Here they are.', '8 July', true, false, false, false, '', 'E', 'bg-info', 'Sent', false, '', '', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](10, 'Sarah Montgomery', 'Your New UI.', 'Everything looks good.', 'Yesterday', true, true, true, true, 'assets/img/portrait/small/avatar-s-6.png', '', '', 'Sent', true, 'Work', 'badge badge-warning mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](11, 'Heather Howell', 'Thanks, Let us do it.', 'Can we connect today...', '15 July', true, true, false, false, '', 'H', 'bg-success', 'Sent', true, 'Private', 'badge badge-success mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](12, 'Kelly Reyes', 'I paid it, Thanks.', 'Check once...', '12 July', false, false, true, true, 'assets/img/portrait/small/avatar-s-8.png', '', '', 'Trash', true, 'Work', 'badge badge-warning mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](13, 'Vincent Nelson', 'Where are you John?', 'Party tonight ?', '11 July', true, false, false, false, '', 'V', 'bg-warning', 'Trash', true, 'Friends', 'badge badge-primary mr-1', false),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Mail"](14, 'Elizabeth Elliott', 'Okay, I will call you.', 'Here they are.', '8 July', true, false, false, false, '', 'E', 'bg-info', 'Trash', false, '', '', false),
        ];
        this.message = [
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](1, 'PixInvent, I found you...', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Tonny Deep', "<p>Hi Tonny,</p>\n                     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                     <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                     <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                     <p>Regards,<br/>John</p>", '12 July', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Tonny Deep', 'me', "<p>Hi John,</p>\n                     <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                     <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                     <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                     <p>Cheers~</p>", 'Today', false, false, false, '', 'T', 'bg-info', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](2, 'Thanks, Let us do it.', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Louis Welch', "<p>Hi Louis,</p>\n                    <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                    <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                    <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                    <p>Regards,<br/>John</p>", '15 April', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Louis Welch', 'me', "<p>Hi John,</p>\n                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                    <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                    <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                    <p>Cheers~</p>", '2:15 AM', false, true, false, '', 'L', 'bg-danger', [
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](1, 'assets/img/gallery/1.jpg'),
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](2, 'assets/img/gallery/3.jpg'),
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](3, 'assets/img/gallery/21.jpg')
                ]),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](3, 'You have a new comment...', 1, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'Envato Market', 'me', "<p>Hi John,</p>\n                     <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                     <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                     <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                     <p>Cheers~</p>", '11:18 PM', false, false, false, '', 'E', 'bg-warning', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](4, 'Project ABC Status Report', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Wayne Burton', "<p>Hi Wayne,</p>\n                    <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                    <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                    <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                    <p>Regards,<br/>John</p>", '12 July', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Wayne Burton', 'me', "<p>Hi John,</p>\n                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                    <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                    <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                    <p>Cheers~</p>", 'Today', false, false, true, 'assets/img/portrait/small/avatar-s-7.png', '', '', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](5, 'Your New UI', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Sarah Montgomery', "<p>Hi Sarah,</p>\n                     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                     <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                     <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                     <p>Regards,<br/>John</p>", '12 July', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Sarah Montgomery', 'me', "<p>Hi John,</p>\n                     <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                     <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                     <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                     <p>Cheers~</p>", 'Yesterday', false, false, true, 'assets/img/portrait/small/avatar-s-5.png', '', '', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](6, 'Thanks, Let us do it.', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Heather Howell', "<p>Hi Heather,</p>\n                    <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                    <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                    <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                    <p>Regards,<br/>John</p>", '13 May', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Heather Howell', 'me', "<p>Hi John,</p>\n                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                    <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                    <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                    <p>Cheers~</p>", '15 July', false, true, false, '', 'H', 'bg-success', [
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](1, 'assets/img/gallery/16.jpg'),
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](2, 'assets/img/gallery/17.jpg')
                ]),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](7, 'I paid it, Thanks.', 1, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'Kelly Reyes', 'me', "<p>Hi John,</p>\n                     <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                     <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                     <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                     <p>Cheers~</p>", '12 July', false, false, true, 'assets/img/portrait/small/avatar-s-8.png', '', '', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](8, 'Where are you John?', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Vincent Nelson', "<p>Hi Vincent,</p>\n                    <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                    <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                    <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                    <p>Regards,<br/>John</p>", '12 August', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Vincent Nelson', 'me', "<p>Hi John,</p>\n                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                    <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                    <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                    <p>Cheers~</p>", '11 July', false, false, false, '', 'V', 'bg-warning', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](9, 'Okay, I will call you.', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Elizabeth Elliott', "<p>Hi Elizabeth,</p>\n                     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                     <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                     <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                     <p>Regards,<br/>John</p>", '31 May', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Elizabeth Elliott', 'me', "<p>Hi John,</p>\n                     <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                     <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                     <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                     <p>Cheers~</p>", '8 July', false, false, false, '', 'E', 'bg-info', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](10, 'Your New UI.', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Sarah Montgomery', "<p>Hi Sarah,</p>\n                    <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                    <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                    <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                    <p>Regards,<br/>John</p>", '15 April', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Sarah Montgomery', 'me', "<p>Hi John,</p>\n                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                    <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                    <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                    <p>Cheers~</p>", 'Yesterday', false, true, true, 'assets/img/portrait/small/avatar-s-6.png', '', '', [
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](1, 'assets/img/gallery/1.jpg'),
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](2, 'assets/img/gallery/3.jpg'),
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](3, 'assets/img/gallery/21.jpg')
                ]),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](11, 'Thanks, Let us do it.', 1, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'Heather Howell', 'me', "<p>Hi John,</p>\n                     <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                     <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                     <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                     <p>Cheers~</p>", '15 July', false, false, false, '', 'H', 'bg-success', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](12, 'I paid it, Thanks.', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Kelly Reyes', "<p>Hi Kelly,</p>\n                    <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                    <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                    <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                    <p>Regards,<br/>John</p>", '12 July', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Kelly Reyes', 'me', "<p>Hi John,</p>\n                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                    <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                    <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                    <p>Cheers~</p>", 'Today', false, false, true, 'assets/img/portrait/small/avatar-s-8.png', '', '', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](13, 'Where are you John?', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Vincent Nelson', "<p>Hi Vincent,</p>\n                     <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                     <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                     <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                     <p>Regards,<br/>John</p>", '21 July', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Vincent Nelson', 'me', "<p>Hi John,</p>\n                     <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                     <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                     <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                     <p>Cheers~</p>", '11 July', false, false, false, '', 'V', 'bg-warning', []),
            ]),
            new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Message"](14, 'Okay, I will call you.', 2, [
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('1', 'John Doe', 'Elizabeth Elliott', "<p>Hi Elizabeth,</p>\n                    <p>Ut varius purus ut mi consectetur, sed hendrerit nisi facilisis. Sed vitae neque vitae urna mattis condimentum. Suspendisse eu blandit enim, sed semper quam. Vivamus sed convallis ex</p>\n                    <p>Curabitur a euismod dui. Vivamus ut luctus nisl. In tincidunt tellus vel lobortis hendrerit. Quisque odio tortor, accumsan vel hendrerit in, volutpat nec mi. Nulla imperdiet, nunc quis dictum dignissim, dolor ligula ultrices diam, non tristique magna ipsum ac metus</p>\n                    <p>Suspendisse vitae pharetra eros. Proin eu elit et diam ultricies efficitur.</p>\n                    <p>Regards,<br/>John</p>", '15 April', true, false, true, 'assets/img/portrait/small/avatar-s-1.png', '', '', []),
                new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["MessageDetail"]('2', 'Elizabeth Elliott', 'me', "<p>Hi John,</p>\n                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam urna quam, rhoncus vitae lacinia vitae, gravida eleifend urna. Sed mattis posuere urna, iaculis ornare mi ultrices rhoncus. Phasellus elementum suscipit ante eu consectetur</p>\n                    <p>Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris enim nisi, bibendum at tincidunt vel, aliquam a mi. Vivamus non interdum nisi, at bibendum arcu. Integer sagittis, erat in imperdiet aliquam, erat sem mollis enim, nec tincidunt lectus sapien a diam. Pellentesque pulvinar sit amet nunc ac mattis</p>\n                    <p>Ut sagittis dictum metus, dapibus faucibus risus facilisis sed. Vivamus scelerisque arcu vel dolor aliquet, vitae molestie risus dignissim. Donec id odio interdum, ornare nisl ac, mattis sem. Curabitur id magna nunc</p>\n                    <p>Cheers~</p>", '8 July', false, true, false, '', 'E', 'bg-info', [
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](1, 'assets/img/gallery/1.jpg'),
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](2, 'assets/img/gallery/3.jpg'),
                    new _timesheets_model__WEBPACK_IMPORTED_MODULE_2__["Attachments"](3, 'assets/img/gallery/21.jpg')
                ]),
            ])
        ];
        this.baseUrl = environments_environment__WEBPACK_IMPORTED_MODULE_4__["environment"].baseurl;
        this.timesheetsStore = { timesheets: [] };
        this._timesheets = new rxjs__WEBPACK_IMPORTED_MODULE_5__["BehaviorSubject"]([]);
    }
    Object.defineProperty(TimesheetsService.prototype, "alltimesheets", {
        get: function () { return this._timesheets.asObservable(); },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(TimesheetsService.prototype, "timesheetsData", {
        get: function () { return this.timesheetsStore.timesheets; },
        enumerable: true,
        configurable: true
    });
    TimesheetsService.prototype.forecastTaskById = function (id) { return this.timesheetsStore.timesheets.find(function (x) { return x.calendarTimeId === id; }); };
    TimesheetsService.prototype.getTimesheets = function () {
        return tslib__WEBPACK_IMPORTED_MODULE_0__["__awaiter"](this, void 0, void 0, function () {
            var resourceId, companyId;
            var _this = this;
            return tslib__WEBPACK_IMPORTED_MODULE_0__["__generator"](this, function (_a) {
                resourceId = '';
                companyId = '';
                return [2 /*return*/, this.http.get(this.baseUrl + '/api/timesheetsummary').subscribe(function (response) {
                        _this.timesheetsStore.timesheets = response.json();
                        _this._timesheets.next(Object.assign({}, _this.timesheetsStore).timesheets);
                        console.log(_this.timesheetsStore.timesheets);
                    }, function (error) {
                        console.log('Failed to fetch currentforecast');
                    })];
            });
        });
    };
    TimesheetsService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"]("design:paramtypes", [_angular_http__WEBPACK_IMPORTED_MODULE_3__["Http"]])
    ], TimesheetsService);
    return TimesheetsService;
}());



/***/ })

}]);
//# sourceMappingURL=timesheets-timesheets-module.js.map