import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { BehaviorSubject, Observable } from 'rxjs';
import { IResource, IResourceList } from './resource';
import { Http, RequestOptions, ResponseContentType } from '@angular/http';
import { AuthService } from 'app/shared/auth/auth.service';
import { catchError, map } from 'rxjs/operators';
import {throwError as observableThrowError, of as observableOf} from 'rxjs';
import { Headers, Response } from '@angular/http';
import { KeyValuePair } from './keyvaluepair';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IRateCard, RateCard } from './rate-card';
import { IResourceUtilization } from './resource-utility';

@Injectable()
export class ResourceService {

  // private baseUrl = 'http://localhost:53956/api';
  private baseUrl = environment.baseurl;
  errorMessage: string;
  deleteMessage: string;
  imageToShow: any;

  public _utils: BehaviorSubject<IResourceUtilization[]>;
  public _resources: BehaviorSubject<IResourceList[]>;
  public _resourcesandrates: BehaviorSubject<IResourceList[]>;
  public _rateCards: BehaviorSubject<IRateCard[]>;


  public resourceStore: {
    resources: any;
  };

  public utilStore: {
    utilities: any;
  };
  public resourceListStore: {
    resourcesandrates: any;
  };

  public rateCardStore: {
    rateCards: any;
  };


  get rateCards(): Observable<any[]> {
    return this._rateCards.asObservable();
  }
  get utils(): Observable<any[]> {
    return this._utils.asObservable();
  }

  constructor(private http: HttpClient,
              private auth: AuthService)  // tslint:disable-next-line:one-line
  {
    this.utilStore = { utilities: [] };
    this._utils = new BehaviorSubject<IResourceUtilization[]>([]);
    this.resourceStore = { resources: [] };
    this._resources = new BehaviorSubject<IResourceList[]>([]);
    this.resourceListStore = { resourcesandrates: [] };
    this._resourcesandrates = new BehaviorSubject<IResourceList[]>([]);
    this.rateCardStore = { rateCards: [] };
    this._rateCards = new BehaviorSubject<IRateCard[]>([]);

  }

  get resources(): Observable<IResourceList[]> {
    return this._resources.asObservable();
  }
  get resourcesandrates(): Observable<IResourceList[]> {
    return this._resourcesandrates.asObservable();
  }

  get utilitiesData(): IResource[] {return this.utilStore.utilities; }
  get resourcesData(): IResource[] {return this.resourceStore.resources; }

  get rateCardsData(): IRateCard[] {return this.rateCardStore.rateCards; }


  get returnedresources() {
    return this.resourceStore.resources;
  }
  rateCardById(id: string) {
    return this.rateCardStore.rateCards.find(x => x.companyRateCardId === id);
  }
  utilById(id: string) {
    return this.utilStore.utilities.find(x => x.resourceUtilizationSummaryId === id);
  }
  utilitiesByResourceIdAll(id: string) {
    return this.utilStore.utilities.find(x => x.resourceId === id);
  }
  utilitiesByResourceIdOneyear(id: string, year: any) {
    return this.utilStore.utilities.filter(x => x.resourceId === id && x.year === year );
  }

  error(error: string) {
    return error;
  }

  resourceById(id: string) {
    return this.resourceStore.resources.find(x => x.resourceId === id);
  }
  resourceandrateById(id: string) {
    return this.resourceListStore.resourcesandrates.find(x => x.resourceId === id);
  }

  async getResources() {

    const companyId = this.auth.companyId;

    this.http.get(this.baseUrl + '/resources/' + companyId, this.auth.tokenHttpClientHeader ).subscribe(response => {
        this.resourceStore.resources = response;
        this._resources.next(Object.assign({}, this.resourceStore).resources);
    }, error => {
      console.log('Failed to fetch resources');
    });
  }

  getResourcesUtilization() {

    const companyId = this.auth.companyId;

   return this.http.get(this.baseUrl + '/resources/allutilization/' + companyId, this.auth.tokenHttpClientHeader).subscribe(response => {
    this.utilStore.utilities = response;
    this._utils.next(Object.assign({}, this.utilStore).utilities);
    }, error => {
      console.log('Failed to fetch utilities');
    });
  }

  downloadFile() {
    const options = new RequestOptions({responseType: ResponseContentType.Blob });
    return this.http.get(this.baseUrl + '/uploadactuals/export', this.auth.tokenHttpClientHeader).pipe(
        map(res => res), );
        // .catch(this.handleError);
  }


  createImageFromBlob(image: Blob) {
    const reader = new FileReader();
    reader.addEventListener('load', () => {
        this.imageToShow = reader.result;
    }, false);

    if (image) {
        reader.readAsDataURL(image);
    }
  }

  async getResourcesAndRates() {

    const companyId = this.auth.companyId;

    this.http.get(this.baseUrl + '/resources/' + companyId, this.auth.tokenHttpClientHeader).subscribe(response => {
      console.log(response);
        this.resourceListStore.resourcesandrates = response;
        this._resourcesandrates.next(Object.assign({}, this.resourceListStore).resourcesandrates);
    }, error => {
      console.log('Failed to fetch resources');
    });
  }

  async getRateCards() {

    const companyId = this.auth.companyId;

    this.http.get(this.baseUrl + '/companyratecards' + '/' + companyId, this.auth.tokenHttpClientHeader).subscribe(response => {
        this.rateCardStore.rateCards = response;
        this._rateCards.next(Object.assign({}, this.rateCardStore).rateCards);
    }, error => {
      console.log('Failed to fetch rate cards');
    });
  }



  postResource(resource) {

    // tslint:disable-next-line:max-line-length
    return this.http.post(this.baseUrl + '/resources', resource, this.auth.tokenHttpClientHeader).pipe(
                    map(res => {
                      this.resourceStore.resources .push(res);
                      this._resources.next(Object.assign({}, this.resourceStore).resources);
                      console.log(resource),
                      console.log(res); }));
   }


  getResource(id: string): Observable<any> {
    // tslint:disable-next-line:prefer-const
    let companyId = this.auth.companyId;
    if (id === '') {
      return observableOf(this.initializeBusiness());
    }
    return this.http.get(
      this.baseUrl + '/resources' + '/' + companyId + '/' + id, this.auth.tokenHttpClientHeader).pipe(map(res => res));
  }

  saveResource(ResourceData) {
    console.log(ResourceData);

    // tslint:disable-next-line:max-line-length
    return this.http.post(this.baseUrl + '/resources/resource', ResourceData, this.auth.tokenHttpClientHeader).pipe(
      map(res => {
        this.resourceListStore.resourcesandrates.push(res);
        this._resourcesandrates.next(Object.assign({}, this.resourceListStore).resourcesandrates);
      }
      ));
  }

  // saveResource(ResourceData) {
  //   console.log(ResourceData);

  // // tslint:disable-next-line:max-line-length
  // return this.http.post(this.baseUrl + '/resources/resource',  ResourceData, this.auth.tokenHeader).map(res => res.json());
  // }



  deleteItem(id: string) {

    const companyId = this.auth.companyId;
    return this.http.delete(this.baseUrl + '/resources' + '/' + companyId + '/' + id, this.auth.tokenHttpClientHeader).toPromise()
                    .then(() => {
                      this.getResources(),
                      this._resources.next(this.resourceStore.resources),
                      console.log(id);
                    }, error => console.log('Failed to fetch resources') );
    // .do(data => console.log('deleteProduct: ' + JSON.stringify(data))).catch(this.handleError);
  }

  GetGiveAccess(): Observable<KeyValuePair[]> {

    return this.http.get(this.baseUrl + '/dropdown/giveaccess', this.auth.tokenHttpClientHeader).pipe(
    map(res => res),
    catchError(this.handleError));
  }

  GetEmployeeTypes(): Observable<KeyValuePair[]> {

    return this.http.get(this.baseUrl + '/dropdown/employeeTypes', this.auth.tokenHttpClientHeader).pipe(
    map(res => res),
    catchError(this.handleError));
  }

  GetResourceTypes(): Observable<KeyValuePair[]> {

    return this.http.get(this.baseUrl + '/dropdown/resourcetypes', this.auth.tokenHttpClientHeader).pipe(
    map(res => res),
    catchError(this.handleError));
  }


  private handleError(error: Response): Observable<any> {

    return observableThrowError('Something went wrong!');
  }



  initializeBusiness(): IResource {
    // Return an initialized object
    return {
      resourceId: '',
      resourceNumber: '',
      resourceEmailAddress: '',
      employeeRef: '',
      resourceStartDate: new Date().toISOString(),
      resourceEndDate: new Date().toISOString(),
      imageUrl: '',
      platformId: '',
      agency: '',
      vendor: '',
      locationName: '',
      location: '',
      billable: true,
      isDisabled: false,
      employeeJobTitle: '',
      resourceRateCardId: '',
      companyRateCard: '',
      contractedHours: 0,
      resourceContractEffortInPercentage: 100,
      resourceType: '',
      employeeType: '',
      company: '',
      resourceManagerId: '',
      identityId: '',
      identity: '',
      firstName: '',
      lastName: '',
      employeeGradeBand: '',
      resourceRate: '',
      displayName: '',
      addedBy: '',
      companyId: this.auth.companyId,

      // totalCountProjects:  0,
      // totalCountProjectsPermitted:  0,
      // totalCountProgrammes:  0,
      // totalCountProgrammesPermitted: 0,
      // totalCountDomains:  0,
      // totalCountDomainsPermitted: 0,
      // totalCountPortfolios: 0,
      // totalCountPortfoliosPermitted: 0,
      // totalCountBusinessUnits:  0,
      // totalCountBusinessUnitsPermitted:  0,

      // dateCreated: '',
      // userCreatedId: '',
      // userCreatedResourceId: '',
      // userCreatedEmail: '',
      // dateModified: '',
      // userModifiedId: '',
      // userModifiedEmail: '',
      // userModifiedResourceId: '',

    };
  }




  onSelect(event) {
    console.log(event);
  }
}
