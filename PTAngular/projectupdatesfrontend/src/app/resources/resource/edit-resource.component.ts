import { Component, OnInit, Input, ElementRef, ViewChildren } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';

import { map, debounceTime, merge } from 'rxjs/operators';
import { ResourcesComponent } from '../resources/resources.component';
// import 'rxjs/add/operator/debounceTime';
// import 'rxjs/add/observable/fromEvent';
// import 'rxjs/add/observable/merge';
import { Subscription } from 'rxjs/Subscription';
import { IResource } from '../resource';
import { ResourceService } from '../resources.service';
import { FormGroup, FormBuilder, Validators, FormControlName } from '@angular/forms';

import { Router } from '@angular/router';
import { GenericValidator } from 'app/shared/validator/generic-validator';
import { NGXToastrService } from 'app/shared/toastr.service';
import { KeyValuePair } from '../keyvaluepair';
import { IRateCard } from '../rate-card';
import { AuthService } from 'app/shared/auth/auth.service';
import { Resource } from '../resource';
// import { Observable } from 'rxjs';
export class RateCard {

  companyId: string;
  companyRateCardId: string;
  companyRateCardCode: string;
  employeeJobTitleOrGradeOrBand: string;
  locationForGradeOnshoreOffShore: string;
  isContractor: boolean;
  dailyRate: number;

}

@Component({
  selector: 'app-edit-resource',
  templateUrl: './edit-resource.component.html',
  styleUrls: ['./resource.component.scss']
})
export class EditResourceComponent implements OnInit {

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];

  @Input() id;
  res: IResource;
  resman: IResource;
  resource: Resource;
  ratecard: RateCard;
  selected = [];
  @Input() header;
  @Input() resources: IResource[] = [];
  @Input() ratecards: IRateCard[] = [];

  errorMessage: string;
  resourceManager$ = '';
  resourceRateCard$ = '';
  employeeTypes: KeyValuePair[];
  resourceTypes: KeyValuePair[];
  lastname$ = '';
  firstname$ = '';
  displayname = '';
  resourceForm: FormGroup;
  private sub: Subscription;

  // Use with the generic validation message class
  displayMessage: { [key: string]: string } = {};
  private validationMessages: { [key: string]: { [key: string]: string } };
  private genericValidator: GenericValidator;


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
      resourceEmailAddress: ['', [Validators.required, Validators.email]],
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
      employeeJobTitle: '',
      resourceRateCardId: '',
      companyRateCard: '',
      contractedHours: '',
      resourceContractEffortInPercentage: '',
      resourceType: '',
      employeeType: '',
      companyId: '',
      appUserRole: '',
      company: '',
      resourceManagerId: '',
      identityId: '',
      identity: '',

      employeeGradeBand: '',
      managerName: '',
      resourceRate: '',
      displayName: '',
      addedBy: '',

  });

    this.getResource(this.id);
    this.onChanges();

    this.resourceService.GetEmployeeTypes().subscribe(types => this.employeeTypes = types);
    this.resourceService.GetResourceTypes().subscribe(types => this.resourceTypes = types);


    console.log(this.ratecards);
    console.log(this.resources);
    console.log(this.res);
  }


  getResource(id: string): void {
    this.resourceService.getResource(id)
    .subscribe(
        (res: IResource) => {
          this.onResourceRetrieved(res);
          console.log(res);
          this.getManager(res);
        },
        (error: any) => this.errorMessage = <any>error
    );
  }

  getManager(res) {
    this.resourceService.resourcesandrates.subscribe(() => {
      setTimeout(() => {
        this.resman = this.resourceService.resourceById(res.resourceManagerId);
        this.resourceManager$ = this.resman.displayName;

        }, 250);

    });

  }


  onResourceRetrieved(res: IResource): void {
    if (this.resourceForm) {
        this.resourceForm.reset();
    }
    this.res = res;

    // Update the data on the form
    this.resourceForm.patchValue({

      resourceId: this.res.resourceId,
      resourceNumber: this.res.resourceNumber,
      resourceEmailAddress: this.res.resourceEmailAddress,
      employeeRef: this.res.employeeRef,
      resourceStartDate: this.res.resourceStartDate,
      resourceEndDate: this.res.resourceEndDate,
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

  onChanges(): void {

    this.resourceForm.get('lastName').valueChanges.subscribe(val => {
      this.lastname$ = val;
      this.displayname = this.firstname$ + ' ' + this.lastname$;
    });
    this.resourceForm.get('firstName').valueChanges.subscribe(val => {
      this.firstname$ = val;
      this.displayname = this.firstname$ + ' ' + this.lastname$;
    });

    // this.resourceForm.get('resourceManagerId').valueChanges.subscribe(val => {
    //   console.log(this.resourceManager$);
    //   setTimeout(() => {
    //    this.getOneResource(val);
    //   this.resourceManager$ = this.resman.displayName;

    //   }, 250);

    //   // console.log(this.resources.filter(r => r.resourceId === val)[0]);
    //   // this.resourceManager = this.resources.filter(r => r.resourceId === val)[0].displayName;
    //   // this.resource = new Resource();
    //   // this.resman  = this.resources.find(r => r.resourceId === val)[0];
    //   // this.resource  = this.resourceService.resourceById(val);
    //   console.log(this.resourceManager$);

    //   // this.resourceForm.controls['resourceManagerId'].setValue(this.resources.find(r => r.resourceId === val).resourceId);
    // });

    this.resourceForm.get('resourceRateCardId').valueChanges.subscribe(val => {
      this.ratecard = new RateCard();
      // this.ratecard = this.ratecards.filter(r => r.companyRateCardId === val)[0];
      this.ratecard = this.resourceService.rateCardById(val);
      console.log(this.ratecard);
      this.resourceRateCard$ = `${this.ratecard.employeeJobTitleOrGradeOrBand} - ${this.auth.reportingCurrencySys} ${this.ratecard.dailyRate}
      (${this.ratecard.locationForGradeOnshoreOffShore})`;
    });
    // this.resourceForm.get('resourceType').valueChanges.subscribe(val => {
    //   // this.res.resourceType = val;
    //   this.resourceForm.controls['resourceType']
    //  .setValue(val);
    // });
    // this.resourceForm.get('employeeType').valueChanges.subscribe(val => {
    //   // this.res.employeeType = val;
    //   this.resourceForm.controls['employeeType']
    //  .setValue(val);
    // });

  }

  getOneResource(id) {
   this.resourceService.getResource(id).subscribe(r => this.resman = r);
   console.log(this.resman);
  }

  onSelectResource(val: IResource) {

    this.resourceManager$ = val.displayName;
    this.resourceForm.controls['resourceManagerId'].setValue(val.resourceId);
    console.log(this.res.displayName);
    console.log(this.res.resourceId);
    console.log(val.displayName);
    console.log(val.resourceId);
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
        : this.ratecards.filter(v => v.employeeJobTitleOrGradeOrBand.toLowerCase().indexOf(rcterm.toLowerCase()) > -1).slice(0, 10))
  )

  onSelect($event, input) {
    $event.preventDefault();
    input.value = $event.item;
    const sample = [{Name: 'a', Age: 1}, {Name: 'b', Age: 2}, {Name: 'c', Age: 3}];
    const Names = sample.map(function(item) {return item.Name; });

    const resources = this.resources;
    const displaynames = resources.map(function(item) {return item.displayName; });
    const ids = resources.map(function(item) {return item.resourceId; });
    const id = this.resourceForm.controls['resourceManagerId'];

    this.selected.push($event.item);
    if (displaynames.includes(input.value)[0] || ids.includes(id.value)) {
      this.resourceForm.controls['resourceManagerId'].setValue(input.value);

    } else {

    }
    // this.resourceForm.controls['resourceManagerId'].setValue(this.resources.find(r => r.resourceId ===  input.value).resourceId);
  }

  formatter1 = (x: { displayName: string }) => x.displayName;
  formatter2 = (x: { employeeJobTitleOrGradeOrBand: string }) => x.employeeJobTitleOrGradeOrBand;

}

