import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { Injectable} from '@angular/core';
import {NgbDateAdapter, NgbDateStruct, NgbDateNativeAdapter} from '@ng-bootstrap/ng-bootstrap';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';
import { map, debounceTime, merge } from 'rxjs/operators';
import { ResourcesComponent } from '../resources/resources.component';
import { Subscription } from 'rxjs/Subscription';
import { IResource, IResourceList } from '../resource';
import { ResourceService } from '../resources.service';
import { FormGroup, FormBuilder, Validators, FormControlName, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { GenericValidator } from 'app/shared/validator/generic-validator';
import { NGXToastrService } from 'app/shared/toastr.service';
import { KeyValuePair } from '../keyvaluepair';
import { IRateCard, RateCard, IRateCardUI } from '../rate-card';
import { AuthService } from 'app/shared/auth/auth.service';
import { Resource } from '../resource';
import { DatePickerComponent } from 'app/shared/date-picker/date-picker.component';

const now = new Date();


@Component({
  selector: 'app-edit-resource',
  templateUrl: './edit-resource.component.html',
  styleUrls: ['./resource.component.scss']
})
export class EditResourceComponent implements OnInit {

  @ViewChild(DatePickerComponent) datepicker;

  date: any;
  today: NgbDateStruct;
  // selectedDate: any;
  disabled = false;
  @Input() id;
  res: IResource;
  resandman: IResourceList;
  resman: IResourceList;
  ratecard: IRateCardUI;
  selected = [];
  @Input() header;
  @Input() resources: IResourceList[] = [];
  @Input() ratecards: IRateCard[] = [];
  uiratecards: IRateCardUI[] = [];

  resourceEndDate$: Date;
  resourceStartDate$: Date;

  resourceManagerId = '';
  resourceRateCardId = '';
  resourceManagerDisplayname = '';
  resourceRatecardDisplayname = '';

  displayisvalid = true;
  errorMessage: string;
  sd: any;
  ed: any;

  employeeType$: string;
  employeeTypes: KeyValuePair[];
  resourceType$: string;
  resourceTypes: KeyValuePair[];

  lastname$ = '';
  firstname$ = '';
  displayname = '';
  resourceForm: FormGroup;
  private sub: Subscription;

  // convenience getter for easy access to form fields
  get f() { return this.resourceForm.controls; }


  constructor(public activeModal: NgbActiveModal, private router: Router, private auth: AuthService,
    private fb: FormBuilder, private resourceService: ResourceService, private toastr: NGXToastrService) {

  }

  ngOnInit() {

    this.resourceForm = this.fb.group({

    firstName: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
    lastName: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
    resourceId: [this.id, Validators.required],
    resourceNumber: ['', Validators.required],
    resourceEmailAddress: [{value: '' , disabled: this.id ? true : false}, [Validators.required,
      Validators.pattern('[^ @]*@[^ @]*'), emailExistValidator, emailDomainValidator ]],
    resourceStartDate: ['', Validators.required],
    resourceEndDate: ['', Validators.required],
    platformId: [''],
    agency: [''],
    vendor: [''],
    imageUrl: '',
    locationName: '',
    location: '',
    billable: '',
    isDisabled: '',
    employeeJobTitle: ['', Validators.required],
    resourceRateCardId: ['', Validators.required],
    contractedHours: '',
    resourceContractEffortInPercentage: ['', [Validators.required, Validators.min(0), Validators.max(100)]],
    resourceType: [{value: this.resourceType$ ? this.resourceType$ : 'default'}, Validators.required],
    employeeType: [{value: this.employeeType$ ? this.employeeType$ : 'default'}, Validators.required],
    companyId: [this.auth.companyId, Validators.required],
    resourceManagerId: ['', Validators.required],

    employeeGradeBand: '',
    managerName: '',
    resourceRate: '',
    displayName: '',
    addedBy: '',

    resourceManager$: new FormControl('', {
      validators: [Validators.required, checttypedstringmanager],
   }),
    resourceRateCard$: new FormControl('', {
      validators: [Validators.required, checttypedstringratecards],
      // updateOn: 'blur'
   }),

  });



    setTimeout(() => {

      this.getResource(this.id);
      this.resourceService.GetEmployeeTypes().subscribe((et) => {
        this.employeeTypes = et;
      });

      this.resourceService.GetResourceTypes().subscribe((rt) => {
        this.resourceTypes = rt;
      });

      // emailExistValidator(this.resources);

    }, 250);

    // checttypedstring;

  }

  // tslint:disable-next-line:use-life-cycle-interface
  ngAfterViewInit() {

    this.date = this.datepicker.selectedDate
  }


  getResource(id: string): void {
    this.resourceService.getResource(id)
    .subscribe(
        (res: IResource) => {
          this.onResourceRetrieved(res);
          console.log(res);
        },
        (error: any) => this.errorMessage = <any>error
    );
  }

  // Selects today's date
  selectToday() {

    this.today = {year: now.getFullYear(), month: now.getMonth() + 1, day: now.getDate()};
    return this.today;
  }

  onResourceRetrieved(res: IResource): void {
    if (this.resourceForm) {
        this.resourceForm.reset();
    }

    this.res = res;

    this.updateDropdowns();

    // Update the data on the form
    this.resourceForm.patchValue({

      resourceId: this.res.resourceId,
      resourceNumber: this.res.resourceNumber,
      resourceEmailAddress: this.res.resourceEmailAddress,
      employeeRef: this.res.employeeRef,
      resourceStartDate: new Date(this.res.resourceStartDate),
      resourceEndDate: new Date(this.res.resourceEndDate),
      platformId: this.res.platformId,
      imageUrl: this.res.imageUrl,
      agency: this.res.agency,
      vendor: this.res.vendor,
      locationName: this.res.locationName,
      location: this.res.location,
      billable: this.res.billable,
      isDisabled: this.res.isDisabled,
      employeeJobTitle: this.res.employeeJobTitle,
      resourceRateCardId: this.res.resourceRateCardId,
      contractedHours: this.res.contractedHours,
      resourceContractEffortInPercentage: this.res.resourceContractEffortInPercentage,
      resourceType: this.res.resourceType,
      employeeType: this.res.employeeType,
      companyId: this.res.companyId,
      resourceManagerId: this.res.resourceManagerId,

      firstName: this.res.firstName,
      lastName: this.res.lastName,

      employeeGradeBand: this.res.employeeGradeBand,
      resourceRate: this.res.resourceRate,
      displayName: this.res.displayName,
      addedBy: this.res.addedBy,

    });
  }

  saveResource(): void {
    if (this.resourceForm.dirty && this.resourceForm.valid) {
      // Copy the form values over the product object values
      const p = Object.assign({}, this.res, this.resourceForm.value);

      if (this.res.resourceId !== '' || this.res.resourceId !== null)  {
        this.resourceService.saveResource(p)
        .subscribe(
          () => {this.resourceService.getResourcesAndRates(); this.onSaveComplete(); this.toastr.onSuccessToastr('Resource'); },
          (error: any) => {this.errorMessage = <any>error, this.onSaveComplete(); this.toastr.onErrorToastr(); }
        );
      } else if (this.res.resourceId === '' || this.res.resourceId === null) {
        this.resourceService.postResource(p)
        .subscribe(
        () => {this.resourceService.getResourcesAndRates(); this.onSaveComplete(); this.toastr.onSuccessToastr('Resource'); },
        (error: any) => {this.errorMessage = <any>error, this.onSaveComplete(); this.toastr.onErrorToastr(); }
        );
      }

    } else if (!this.resourceForm.dirty) {
        this.onSaveComplete();
    }
}

  onSaveComplete(): void {
    // Reset the form to clear the flags
    this.resourceForm.reset();
    this.router.navigate(['/resources/resources']);
  }

  updateDropdowns() {

    this.resourceForm.get('lastName').valueChanges.subscribe(val => {
      this.lastname$ = val;
      this.displayname = this.firstname$ + ' ' + this.lastname$;
    });
    this.resourceForm.get('firstName').valueChanges.subscribe(val => {
      this.firstname$ = val;
      this.displayname = this.firstname$ + ' ' + this.lastname$;
    });


    if (this.id === '' || this.id === null) {
      this.resandman = null;
      this.resman = null;

    } else {

      this.resandman = this.resources.find(x => x.resourceId === this.id);
      this.resman = this.resources.find(x => x.resourceId === this.resandman.resourceManagerId);
    }

    const currency = this.auth.reportingCurrencySys;
    console.log(currency);

    this.uiratecards = this.ratecards.map(function(e) {
      return {
        companyId: e.companyId,
        companyRateCardId: e.companyRateCardId,
        companyRateCardCode: e.companyRateCardCode,
        employeeJobTitleOrGradeOrBand: e.employeeJobTitleOrGradeOrBand,
        locationForGradeOnshoreOffShore: e.locationForGradeOnshoreOffShore,
        isContractor: e.isContractor,
        dailyRate: e.dailyRate,
        resourceRatecardDisplayname: `${e.employeeJobTitleOrGradeOrBand} - ${currency}${e.dailyRate} (${e.locationForGradeOnshoreOffShore})`

      }
    })

    this.ratecard = this.uiratecards.find(x => x.companyRateCardId === this.resandman.resourceRateCardId);

    this.resourceManagerDisplayname = this.resman.displayName;
    this.resourceForm.patchValue({resourceManager$: `${this.resman.displayName}`});
    this.resourceManagerId = this.resman.resourceId;

    this.resourceRatecardDisplayname = this.ratecard.resourceRatecardDisplayname;
    this.resourceForm.patchValue({resourceRateCard$: `${this.resourceRatecardDisplayname}`});
    this.resourceRateCardId = this.res.resourceRateCardId;

    this.resourceEndDate$ = new Date(this.res.resourceEndDate ? this.res.resourceEndDate : new Date().toISOString());
    this.resourceStartDate$ = new Date(this.res.resourceStartDate ? this.res.resourceStartDate : new Date().toISOString());

    this.employeeType$ = this.res.employeeType;
    this.resourceType$ = this.res.resourceType;

    this.resourceForm.patchValue({employeeType: `${this.res.employeeType}`});
    this.resourceForm.patchValue({resourceType: `${this.res.resourceType}`});

    this.resourceForm.patchValue({resourceManagerId: `${this.resman.resourceId}`});
    this.resourceForm.patchValue({resourceRateCardId: `${this.res.resourceRateCardId}`});

    console.log(this.employeeTypes);
    console.log(this.resourceTypes);
    console.log(this.employeeType$);
    console.log(this.resourceType$);

    console.log(this.resourceEndDate$);

    // checttypedstring(this.resources);
    this.refreshManager(this.resources);
    this.refreshRatecards(this.uiratecards);


  }

  // updateDate() {
  //   this.resourceForm.get('resourceEndDate').valueChanges.subscribe(val => {
  //     console.log(val);

  //     // this.selectedDate = new Date(val);
  //     this.resourceForm.patchValue({resourceEndDate: val});
  //     // console.log(this.selectedDate);
  //     console.log(this.f['resourceEndDate'].value);
  //     console.log(this.res);
  //   });
  // }



  refreshRatecards(rates) {

    this.resourceForm.get('resourceRateCard$').valueChanges.subscribe(val => {

      if (typeof val === 'string') {
        val = val;
      } else {
        val = val.resourceRatecardDisplayname;
      }

      const displaynames = rates.map(function(item) {return item.resourceRatecardDisplayname; });

      // console.log(displaynames.indexOf(val) !== -1);

      if (!displaynames.includes(val) || val === '' || val === undefined || val === null) {

        return this.f['resourceRateCard$'].setErrors({ ratecarddisplayisvalid: true });
      } else {
        return this.f['resourceRateCard$'].setErrors(null);
      }
    });
  }

  refreshManager(resources) {

    this.resourceForm.get('resourceManager$').valueChanges.subscribe(val => {

      if (typeof val === 'string') {
        val = val;
      } else {
        val = val.displayName;
      }

      const displaynames = resources.map(function(item) {return item.displayName; });

      // console.log(displaynames.indexOf(val) !== -1);

      if (!displaynames.some(function(item) {return val === item; }) || val === '' || val === undefined || val === null) {

        return this.f['resourceManager$'].setErrors({ managerdisplayisvalid: true });
      } else {
        return this.f['resourceManager$'].setErrors(null);
      }
    });
  }



  // getOneResource(id) {
  //  this.resourceService.getResource(id).subscribe(r => this.resman = r);
  //  console.log(this.resman);
  // }

  onSelectResource(val: IResource) {

    console.log(val.displayName);
    this.resourceForm.patchValue({resourceManager$: `${val.displayName}`});
    this.resourceForm.patchValue({resourceManagerId: `${val.resourceId}`});
    return this.f['resourceManager$'].setErrors(null);
  }

  onSelectRateCard(rate: IRateCardUI) {

    // this.resourceRatecardDisplayname = `${rate.employeeJobTitleOrGradeOrBand} - ${this.auth.reportingCurrencySys}
    //   ${rate.dailyRate} (${rate.locationForGradeOnshoreOffShore})`;

    console.log(this.resourceRatecardDisplayname);

    this.resourceForm.patchValue({resourceRateCard$: `${rate.resourceRatecardDisplayname}`});
    this.resourceForm.patchValue({resourceRateCardId: `${rate.companyRateCardId}`});
    return this.f['resourceManager$'].setErrors(null);
  }



  resourcesearch = (text$: Observable<string>) =>
    text$.pipe(
      debounceTime(200),
      map(term => term === '' ? []
        : this.resources.filter(v => v.displayName.toLowerCase().indexOf(term.toLowerCase()) > -1).slice(0, 10))
  )

  ratecardsearch = (rctext$: Observable<string>) =>
    rctext$.pipe(
      debounceTime(200),
      map(rcterm => rcterm === '' ? []
        : this.uiratecards.filter(v => v.resourceRatecardDisplayname.toLowerCase().indexOf(rcterm.toLowerCase()) > -1).slice(0, 10))
  )


  // onDateFromChange($event) {


  //   this.resourceForm.get('resourceStartDate').valueChanges.subscribe(($event) => {
  //     const val = $event.target.value;

  //     this.resourceStartDate$ = val;
  //     this.resourceForm.patchValue({resourceStartDate: `${val.toString()}`});

  //   });
  // }

  // onDateToChange(val: Date) {
  //   this.resourceEndDate$ = val;
  //   this.resourceForm.controls['resourceEndDate'].setValue(val.toString());
  // }

  formatter1 = (x: { displayName: string }) => x.displayName;
  formatter2 = (x: { resourceRatecardDisplayname: string }) => x.resourceRatecardDisplayname;

}

function checttypedstringmanager(control: FormControl) {

  const manager = control.value;
  console.log(manager);

  // if (manager === '' || !istextfound || manager === undefined) {
  if (manager === '' || manager === undefined || manager === null) {

    const text = 'Please select from the dropdown list.';
    return { managerdisplayisvalid: { parseDisplay: manager }};
  }
  return null;

}

function checttypedstringratecards(control: FormControl) {

  const ratecard = control.value;
  console.log(ratecard);

  // if (manager === '' || !istextfound || manager === undefined) {
  if (ratecard === '' || ratecard === undefined || ratecard === null) {

    const text = 'Please select from the dropdown list.';
    return { ratecarddisplayisvalid: { parseDisplay: ratecard }};
  }
  return null;

}

function emailDomainValidator(control: FormControl) {
  const email = control.value;
  if (email && email.indexOf('@') !== -1) {
    const [_, domain] = email.split('@');
    if (domain !== 'yahoo.com') {
      return {
        emailDomain: {
          parsedDomain: domain
        }
      }
    }
  }
  return null;
}
function emailExistValidator(resources: IResourceList[]) {

  return control => {
    const email = control.value;
    const emails = resources.map(function(item) {return item.resourceEmailAddress; });

    if (!emails.some(function(item) {return item === control.value; })) {
      return { emailDontexist: true};
    }
    return { emailDontexist: false};

  }

}

