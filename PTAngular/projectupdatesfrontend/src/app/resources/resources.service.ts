import { Injectable } from '@angular/core';
import { environment } from 'environments/environment';
import { BehaviorSubject, Observable } from 'rxjs';
import { IResource, IResourceList, Resource } from './resource';
import { Http, RequestOptions, ResponseContentType } from '@angular/http';
import { AuthService } from 'app/shared/auth/auth.service';
import { catchError, map } from 'rxjs/operators';
import {throwError as observableThrowError, of as observableOf} from 'rxjs';
import { Headers, Response } from '@angular/http';
import { KeyValuePair } from './keyvaluepair';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IRateCard } from './rate-card';

@Injectable()
export class ResourceService {

  private baseUrl = 'http://localhost:53956/api';
  // private baseUrl = environment.baseurl;
  errorMessage: string;
  deleteMessage: string;
  imageToShow: any;

  public _resources: BehaviorSubject<IResource[]>;
  public _resourcesandrates: BehaviorSubject<IResourceList[]>;
  public _rateCards: BehaviorSubject<IRateCard[]>;


  public resourceStore: {
    resources: IResource[]
  };
  public resourceListStore: {
    resourcesandrates: any[]
  };

  public rateCardStore: {
    rateCards: any[]
  };


  get rateCards(): Observable<IRateCard[]> {
    return this._rateCards.asObservable();
  }

  constructor(private http: Http,
              private auth: AuthService)  // tslint:disable-next-line:one-line
  {
    this.resourceStore = { resources: [] };
    this._resources = new BehaviorSubject<IResource[]>([]);
    this.resourceListStore = { resourcesandrates: [] };
    this._resourcesandrates = new BehaviorSubject<IResourceList[]>([]);
    this.rateCardStore = { rateCards: [] };
    this._rateCards = new BehaviorSubject<IRateCard[]>([]);

  }

  get resources(): Observable<IResource[]> {
    return this._resources.asObservable();
  }
  get resourcesandrates(): Observable<IResourceList[]> {
    return this._resourcesandrates.asObservable();
  }

  get resourcesData(): IResource[] {return this.resourceStore.resources; }

  get rateCardsData(): IRateCard[] {return this.rateCardStore.rateCards; }


  get returnedresources() {
    return this.resourceStore.resources;
  }
  rateCardById(id: string) {
    return this.rateCardStore.rateCards.find(x => x.companyRateCardId === id);
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

    this.http.get(this.baseUrl + '/resources/' + companyId, this.auth.tokenHeader.body ).subscribe(response => {
        this.resourceStore.resources = response.json();
        this._resources.next(Object.assign({}, this.resourceStore).resources);
    }, error => {
      console.log('Failed to fetch resources');
    });
  }

  async getResourcepool() {

    const companyId = this.auth.companyId;

    const options = new RequestOptions();
    options.headers = new Headers();
    options.headers.append('Authorization', 'Bearer ' + localStorage.getItem(this.auth.TOKEN_KEY));
    options.headers.append('Content-Type', 'application/json; charset=utf-8');
    options.headers.append('responseType', 'ResponseContentType.Blob');

    this.http.get(this.baseUrl + '/resources/' + companyId, options).subscribe(response => {
        this.resourceStore.resources = response.json();
        this._resources.next(Object.assign({}, this.resourceStore).resources);


    }, error => {
      console.log('Failed to fetch resources');
    });
  }

  downloadFile() {
    const options = new RequestOptions({responseType: ResponseContentType.Blob });
    return this.http.get(this.baseUrl + '/uploadactuals/export', options).pipe(
        map(res => res.blob()), );
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

    const headers = new Headers();
    headers.append('Authorization', 'Bearer ' + localStorage.getItem(this.auth.TOKEN_KEY));
    headers.append('Content-Type', 'application/json');

    const companyId = this.auth.companyId;
    console.log(this.auth.tokenHeader);
    console.log(companyId);


    this.http.get(this.baseUrl + '/resources/' + companyId, this.auth.tokenHeader).subscribe(response => {
      console.log(response);
        this.resourceListStore.resourcesandrates = response.json();
        this._resourcesandrates.next(Object.assign({}, this.resourceListStore).resourcesandrates);
    }, error => {
      console.log('Failed to fetch resources');
    });
  }

  async getRateCards() {

    const companyId = this.auth.companyId;

    this.http.get(this.baseUrl + '/companyratecards' + '/' + companyId, this.auth.tokenHeader).subscribe(response => {
        this.rateCardStore.rateCards = response.json();
        this._rateCards.next(Object.assign({}, this.rateCardStore).rateCards);
    }, error => {
      console.log('Failed to fetch rate cards');
    });
  }



  postResource(resource) {

    // tslint:disable-next-line:max-line-length
    return this.http.post(this.baseUrl + '/resources', resource, this.auth.tokenHeader).pipe(
                    map(res => {
                      res.json(),
                      this.resourceStore.resources .push(res.json());
                      this._resources.next(Object.assign({}, this.resourceStore).resources);
                      console.log(resource),
                      console.log(res.json()); }));
   }


  getResource(id: string): Observable<IResource> {
    // tslint:disable-next-line:prefer-const
    let companyId = this.auth.companyId;
    if (id === '') {
      return observableOf(this.initializeBusiness());

      }
    return this.http.get(this.baseUrl + '/resources' + '/' + companyId + '/' + id, this.auth.tokenHeader).pipe(map(res => res.json()));
  }

  saveResource(ResourceData) {
    console.log(ResourceData);

    // tslint:disable-next-line:max-line-length
    return this.http.post(this.baseUrl + '/resources/resource', ResourceData, this.auth.tokenHeaderWithType).pipe(
      map(res => { res.json(),
        this.resourceListStore.resourcesandrates.push(res.json());
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
    return this.http.delete(this.baseUrl + '/resources' + '/' + companyId + '/' + id, this.auth.tokenHeader).toPromise()
                    .then(() => {
                      this.getResources(),
                      this._resources.next(this.resourceStore.resources),
                      console.log(id);
                    }, error => console.log('Failed to fetch resources') );
    // .do(data => console.log('deleteProduct: ' + JSON.stringify(data))).catch(this.handleError);
  }

  GetGiveAccess(): Observable<KeyValuePair[]> {

    return this.http.get(this.baseUrl + '/dropdown/giveaccess', this.auth.tokenHeader).pipe(
    map(res => res.json()),
    catchError(this.handleError));
  }

  GetEmployeeTypes(): Observable<KeyValuePair[]> {

    return this.http.get(this.baseUrl + '/dropdown/employeeTypes', this.auth.tokenHeader).pipe(
    map(res => res.json()),
    catchError(this.handleError));
  }

  GetResourceTypes(): Observable<KeyValuePair[]> {

    return this.http.get(this.baseUrl + '/dropdown/resourcetypes', this.auth.tokenHeader).pipe(
    map(res => res.json()),
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
      resourceStartDate: '',
      resourceEndDate: '',
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
