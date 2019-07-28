import { IResourceUtilization } from './resource-utility';

export interface IResource {

  resourceId: string;
  resourceNumber: string;
  resourceEmailAddress: string;
  employeeRef: string;
  resourceStartDate: string;
  resourceEndDate: string;

  platformId: string;

  agency: string;
  vendor: string;
  locationName: string;
  location: string;
  billable: boolean;
  isDisabled: boolean;
  employeeJobTitle: string;
  resourceRateCardId: string;
  companyRateCard: string;
  contractedHours: number;
  resourceContractEffortInPercentage: number;
  resourceType: string;
  employeeType: string;
  companyId: string;
  // appUserRole: string;
  company: string;
  resourceManagerId: string;
  identityId: string;
  identity: string;
  firstName: string;
  lastName: string;
  imageUrl: string;
  employeeGradeBand: string;
  // managerName: string;
  resourceRate: string;
  displayName: string;
  addedBy: string;



}

export interface IResourceList {

  resourceId: string;
  resourceNumber: string;
  resourceEmailAddress: string;
  employeeRef: string;
  resourceStartDate: string;
  resourceEndDate: string;
  platformId: string;
  agency: string;
  vendor: string;
  locationName: string;
  location: string;
  billable: boolean
  isDisabled: boolean
  employeeJobTitle: string;
  resourceRateCardId: string;
  companyRateCard: {
    companyRateCardId: string;
    companyRateCardCode: string;
    companyId: string;
    employeeJobTitleOrGradeOrBand: string;
    locationForGradeOnshoreOffShore: string;
    isContractor: boolean;
    dailyRate: number;
  }
  contractedHours: number
  resourceContractEffortInPercentage: number
  resourceType: string;
  employeeType: string;
  companyId: string;
  company: string;
  resourceManagerId: string;
  resourceManager: {
    resourceId: string;
    resourceNumber: string;
    resourceEmailAddress: string;
    employeeRef: string;
    resourceStartDate: string;
    resourceEndDate: string;
    platformId: string;
    agency: string;
    vendor: string;
    locationName: string;
    location: string;
    billable: boolean
    isDisabled: boolean
    employeeJobTitle: string;
    resourceRateCardId: string;
    companyRateCard: {
      companyRateCardId: string;
      companyRateCardCode: string;
      companyId: string;
      employeeJobTitleOrGradeOrBand: string;
      locationForGradeOnshoreOffShore: string;
      isContractor: boolean;
      dailyRate: number;
    }
    contractedHours: number
    resourceContractEffortInPercentage: number
    resourceType: string;
    employeeType: string;
    companyId: string;
    company: string;
    resourceManagerId: string;
    firstName: string;
    lastName: string;
    imageCaption: string;
    imageName: string;
    imageUrl: string;
    imageId: string;
    avatarImage: any;
    displayName: string;
    gender: string;
    isAppUser: boolean;
  }
  firstName: string;
  lastName: string;
  imageCaption: string;
  imageName: string;
  imageUrl: string;
  imageId: string;
  avatarImage: any;
  displayName: string;
  gender: string;
  isAppUser: boolean;


  dateCreated: Date;
  userCreatedId: string;
  userCreatedResourceId: string;
  userCreatedEmail: string;
  dateModified: Date;
  userModifiedId: string;
  userModifiedEmail: string;
  userModifiedResourceId: string;
  resourceutilizationSummaries: IResourceUtilization[];

}

export class Resource {

  resourceId: string;
  resourceNumber: string;
  resourceEmailAddress: string;
  employeeRef: string;
  resourceStartDate: string;
  resourceEndDate: string;
  platformId: string;
  agency: string;
  vendor: string;
  locationName: string;
  location: string;
  billable: boolean
  isDisabled: boolean
  employeeJobTitle: string;
  resourceRateCardId: string;
  companyRateCard: {
    companyRateCardId: string;
    companyRateCardCode: string;
    companyId: string;
    employeeJobTitleOrGradeOrBand: string;
    locationForGradeOnshoreOffShore: string;
    isContractor: boolean;
    dailyRate: number;
  }
  contractedHours: number
  resourceContractEffortInPercentage: number
  resourceType: string;
  employeeType: string;
  companyId: string;
  company: string;
  resourceManagerId: string;
  resourceManager: {
    resourceId: string;
    resourceNumber: string;
    resourceEmailAddress: string;
    employeeRef: string;
    resourceStartDate: string;
    resourceEndDate: string;
    platformId: string;
    agency: string;
    vendor: string;
    locationName: string;
    location: string;
    billable: boolean
    isDisabled: boolean
    employeeJobTitle: string;
    resourceRateCardId: string;
    companyRateCard: {
      companyRateCardId: string;
      companyRateCardCode: string;
      companyId: string;
      employeeJobTitleOrGradeOrBand: string;
      locationForGradeOnshoreOffShore: string;
      isContractor: boolean;
      dailyRate: number;
    }
    contractedHours: number
    resourceContractEffortInPercentage: number
    resourceType: string;
    employeeType: string;
    companyId: string;
    company: string;
    resourceManagerId: string;
    firstName: string;
    lastName: string;
    imageCaption: string;
    imageName: string;
    imageUrl: string;
    imageId: string;
    avatarImage: any;
    displayName: string;
    gender: string;
    isAppUser: boolean;
  }
  firstName: string;
  lastName: string;
  imageCaption: string;
  imageName: string;
  imageUrl: string;
  imageId: string;
  avatarImage: any;
  displayName: string;
  gender: string;
  isAppUser: boolean;


  dateCreated: Date;
  userCreatedId: string;
  userCreatedResourceId: string;
  userCreatedEmail: string;
  dateModified: Date;
  userModifiedId: string;
  userModifiedEmail: string;
  userModifiedResourceId: string;

  resourceutilizationSummaries: IResourceUtilization[];


}

// resourceId: string;
//   resourceNumber: string;
//   resourceEmailAddress: string;
//   employeeRef: string;
//   resourceStartDate: string;
//   resourceEndDate: string;

//   platformId: string;

//   agency: string;
//   vendor: string;
//   locationName: string;
//   location: string;
//   billable: boolean;
//   isDisabled: boolean;
//   employeeJobTitle: string;
//   resourceRateCardId: string;
//   companyRateCard: {
//     dailyRate: number;
//   };
//   imageUrl: string;
//   contractedHours: number;
//   resourceContractEffortInPercentage: number;
//   resourceType: string;
//   employeeType: string;
//   companyId: string;
//   appUserRole: string;
//   company: string;
//   resourceManagerId: string;
//   identityId: string;
//   identity: string;
//   firstName: string;
//   lastName: string;
//   employeeGradeBand: string;
//   managerName: string;
//   resourceRate: string;
//   displayName: string;
//   searchCredential: string;
//   addedBy: string;
//   avatarImage: string;

//   gender:  string;
//   // totalForecastHours: number;
//   // totalForecastReconciledHours:  number;
//   // totalProjectsForecastCount:  number;
//   // totalCountProjects:  number;
//   // totalCountProjectsPermitted:  number;
//   // totalCountProgrammes:  number;
//   // totalCountProgrammesPermitted:  number;
//   // totalCountDomains:  number;
//   // totalCountDomainsPermitted:  number;
//   // totalCountPortfolios: number;
//   // totalCountPortfoliosPermitted:  number;
//   // totalCountBusinessUnits:  number;
//   // totalCountBusinessUnitsPermitted:  number;
//   // businessUnitsPermitted: any;
//   domainsPermitted: any;
//   portfoliosPermitted: any;
//   programmesPermitted: any;
//   projectsPermitted: any;
//   resourceWorkTimesheets: any;

//   // janResourceUtilizationInDays: number;
//   // febResourceUtilizationInDays: number;
//   // marResourceUtilizationInDays: number;
//   // aprResourceUtilizationInDays: number;
//   // mayResourceUtilizationInDays: number;
//   // junResourceUtilizationInDays: number;
//   // julResourceUtilizationInDays: number;
//   // augResourceUtilizationInDays: number;
//   // sepResourceUtilizationInDays: number;
//   // octResourceUtilizationInDays: number;
//   // novResourceUtilizationInDays: number;
//   // decResourceUtilizationInDays: number;
//   // totalUtilizationInDays: number;
//   // janAvailabilityBeforeHolidaysInDays: number;
//   // febAvailabilityBeforeHolidaysInDays: number;
//   // marAvailabilityBeforeHolidaysInDays: number;
//   // aprAvailabilityBeforeHolidaysInDays: number;
//   // mayAvailabilityBeforeHolidaysInDays: number;
//   // junAvailabilityBeforeHolidaysInDays: number;
//   // julAvailabilityBeforeHolidaysInDays: number;
//   // augAvailabilityBeforeHolidaysInDays: number;
//   // sepAvailabilityBeforeHolidaysInDays: number;
//   // octAvailabilityBeforeHolidaysInDays: number;
//   // novAvailabilityBeforeHolidaysInDays: number;
//   // decAvailabilityBeforeHolidaysInDays: number;
//   // totalAvailabilityBeforeHolidaysInDays: number;
//   // janTotalHolidays: number;
//   // febTotalHolidays: number;
//   // marTotalHolidays: number;
//   // aprTotalHolidays: number;
//   // mayTotalHolidays: number;
//   // junTotalHolidays: number;
//   // julTotalHolidays: number;
//   // augTotalHolidays: number;
//   // sepTotalHolidays: number;
//   // octTotalHolidays: number;
//   // novTotalHolidays: number;
//   // decTotalHolidays: number;
