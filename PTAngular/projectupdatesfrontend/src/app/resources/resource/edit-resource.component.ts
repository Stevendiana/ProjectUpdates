import { Component, OnInit, Input, ElementRef, ViewChildren } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Observable } from 'rxjs';

import { map, debounceTime, merge } from 'rxjs/operators';
import { ResourcesComponent } from '../resources/resources.component';
// import 'rxjs/add/operator/debounceTime';
// import 'rxjs/add/observable/fromEvent';
// import 'rxjs/add/observable/merge';
import { Subscription } from 'rxjs/Subscription';
import { IResource } from '../resourcelist';
import { ResourceService } from '../resources.service';
import { FormGroup, FormBuilder, Validators, FormControlName } from '@angular/forms';

import { Router } from '@angular/router';
import { GenericValidator } from 'app/shared/validator/generic-validator';
import { NGXToastrService } from 'app/shared/toastr.service';
import { KeyValuePair } from '../keyvaluepair';
// import { Observable } from 'rxjs';


@Component({
  selector: 'app-edit-resource',
  templateUrl: './edit-resource.component.html',
  styleUrls: ['./resource.component.scss']
})
export class EditResourceComponent implements OnInit {

  @ViewChildren(FormControlName, { read: ElementRef }) formInputElements: ElementRef[];

  @Input() id;
  res: IResource;
  @Input() header;
  @Input() resources;
  errorMessage: string;
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





  constructor(public activeModal: NgbActiveModal, private router: Router,
    private fb: FormBuilder, private resourceService: ResourceService, private toastr: NGXToastrService) {

    this.validationMessages = {
      productName: {
          required: 'Product name is required.',
          minlength: 'Product name must be at least three characters.',
          maxlength: 'Product name cannot exceed 50 characters.'
      },
      productCode: {
          required: 'Product code is required.'
      },
      starRating: {
          range: 'Rate the product between 1 (lowest) and 5 (highest).'
      }
    };
    // Define an instance of the validator for use with this form,
    // passing in this form's set of validation messages.
    this.genericValidator = new GenericValidator(this.validationMessages);
  }

  ngOnInit() {

    this.resourceForm = this.fb.group({

      firstName: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
      lastName: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(50)]],
      resourceId: [this.id, Validators.required],
      resourceNumber: ['', Validators.required],
      resourceEmailAddress: ['', Validators.required],
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
  }

  // tslint:disable-next-line: use-life-cycle-interface
  // ngAfterViewInit(): void {

  //   // Watch for the blur event from any input element on the form.
  //   const controlBlurs: Observable<any>[] = this.formInputElements
  //       .map((formControl: ElementRef) => Observable.fromEvent(formControl.nativeElement, 'blur'));

  //   // Merge the blur event observable with the valueChanges observable
  //   Observable.merge(this.resourceForm.valueChanges, ...controlBlurs).debounceTime(800).subscribe(value => {
  //       this.displayMessage = this.genericValidator.processMessages(this.resourceForm);
  //   });
  // }

  getResource(id: string): void {
    this.resourceService.getResource(id)
    .subscribe(
        (res: IResource) => {this.onResourceRetrieved(res); console.log(res); },
        (error: any) => this.errorMessage = <any>error
    );
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
      appUserRole: this.res.appUserRole,
      resourceManagerId: this.res.resourceManagerId,

      firstName: this.res.firstName,
      lastName: this.res.lastName,

      employeeGradeBand: this.res.employeeGradeBand,
      managerName: this.res.managerName,
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
  }

  formatter1 = (x: { name: string }) => x.name;

}
