

// export class ResourceList {

//   resourceId: string;
//   resourceEmailAddress: string;
//   employeeRef: string;
//   resourceStartDate: string;
//   resourceEndDate: string;

//   resourceNumber: string;
//   platformId: string;
//   domain: string;
//   businessUnit: string;
//   currentPlatform: string;
//   platformLead: string;
//   project: string;
//   companyRateCardId: string;

//   agency: string;
//   vendor: string;
//   locationName: string;
//   location: string;
//   billable: boolean;
//   isDisabled: boolean;
//   employeeJobTitle: string;

//   contractedHours: string;
//   resourceContractEffortInPercentage: string;
//   resourceType: string;
//   employeeType: string;
//   companyId: string;
//   appUserRole: string;
//   company: string;
//   resourceManagerId: string;
//   // identityId: string;
//   // identity: string;
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
//   totalForecastHours: string;
//   totalForecastReconciledHours:  string;
//   totalProjectsForecastCount:  string;
//   totalCountProjects:  string;
//   totalCountProjectsPermitted:  string;
//   totalCountProgrammes:  string;
//   totalCountProgrammesPermitted:  string;
//   totalCountDomains:  string;
//   totalCountDomainsPermitted:  string;
//   totalCountPortfolios: string;
//   totalCountPortfoliosPermitted:  string;
//   totalCountBusinessUnits:  string;
//   totalCountBusinessUnitsPermitted:  string;
//   // businessUnitsPermitted: any;
//   // domainsPermitted: any;
//   // portfoliosPermitted: any;
//   // programmesPermitted: any;
//   // projectsPermitted: any;
//   // resourceWorkTimesheets: any;

//   companyRateCard: {
//     dailyRate: string;
//     companyRateCardId: string;
//     companyRateCardCode: string;
//     companyId: string;
//     employeeJobTitleOrGradeOrBand: string;
//     locationForGradeOnshoreOffShore: string;
//     isContractor: boolean  ;
//     company: string;
//     dateCreated: string;
//     userCreatedId: string;
//     userCreatedResourceId: string;
//     userCreatedEmail: string;
//     dateModified: string;
//     userModifiedId: string;
//     userModifiedEmail: string;
//     userModifiedResourceId: string;
//   };

//   janResourceUtilizationInDays: string;
//   febResourceUtilizationInDays: string;
//   marResourceUtilizationInDays: string;
//   aprResourceUtilizationInDays: string;
//   mayResourceUtilizationInDays: string;
//   junResourceUtilizationInDays: string;
//   julResourceUtilizationInDays: string;
//   augResourceUtilizationInDays: string;
//   sepResourceUtilizationInDays: string;
//   octResourceUtilizationInDays: string;
//   novResourceUtilizationInDays: string;
//   decResourceUtilizationInDays: string;
//   totalUtilizationInDays: string;
//   janAvailabilityBeforeHolidaysInDays: string;
//   febAvailabilityBeforeHolidaysInDays: string;
//   marAvailabilityBeforeHolidaysInDays: string;
//   aprAvailabilityBeforeHolidaysInDays: string;
//   mayAvailabilityBeforeHolidaysInDays: string;
//   junAvailabilityBeforeHolidaysInDays: string;
//   julAvailabilityBeforeHolidaysInDays: string;
//   augAvailabilityBeforeHolidaysInDays: string;
//   sepAvailabilityBeforeHolidaysInDays: string;
//   octAvailabilityBeforeHolidaysInDays: string;
//   novAvailabilityBeforeHolidaysInDays: string;
//   decAvailabilityBeforeHolidaysInDays: string;
//   totalAvailabilityBeforeHolidaysInDays: string;
//   janTotalHolidays: string;
//   febTotalHolidays: string;
//   marTotalHolidays: string;
//   aprTotalHolidays: string;
//   mayTotalHolidays: string;
//   junTotalHolidays: string;
//   julTotalHolidays: string;
//   augTotalHolidays: string;
//   sepTotalHolidays: string;
//   octTotalHolidays: string;
//   novTotalHolidays: string;
//   decTotalHolidays: string;


//   dateCreated: string;
//   userCreatedId: string;
//   userCreatedResourceId: string;
//   userCreatedEmail: string;
//   dateModified: string;
//   userModifiedId: string;
//   userModifiedEmail: string;
//   userModifiedResourceId: string;

// }


// export interface IResource {

//   resourceId: string;
//   resourceNumber: string;
//   resourceEmailAddress: string;
//   employeeRef: string;
//   resourceStartDate: string;
//   resourceEndDate: string;

//   platformId: string;
//   imageUrl: string;

//   agency: string;
//   vendor: string;
//   locationName: string;
//   location: string;
//   billable: boolean;
//   isDisabled: boolean;
//   employeeJobTitle: string;
//   resourceRateCardId: string;
//   companyRateCard: string;
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
//   addedBy: string;


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
//   // domainsPermitted: any;
//   // portfoliosPermitted: any;
//   // programmesPermitted: any;
//   // projectsPermitted: any;
//   // resourceWorkTimesheets: any;
//   // dateCreated: Date;
//   // userCreatedId: string;
//   // userCreatedResourceId: string;
//   // userCreatedEmail: string;
//   // dateModified: Date;
//   // userModifiedId: string;
//   // userModifiedEmail: string;
//   // userModifiedResourceId: string;

// }
// export interface IResourceList {

//   resourceId: string;
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
//     companyRateCardId: string;
//     companyRateCardCode: string;
//     companyId: string;
//     employeeJobTitleOrGradeOrBand: string;
//     locationForGradeOnshoreOffShore: string;
//     isContractor: string;
//     company: string;
//     dateCreated: string;
//     userCreatedId: string;
//     userCreatedResourceId: string;
//     userCreatedEmail: string;
//     dateModified: string;
//     userModifiedId: string;
//     userModifiedEmail: string;
//     userModifiedResourceId: string;
//   };
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
//   imageName: string;
//   imageUrl: string;
//   imageId: string;

//   employeeGradeBand: string;
//   managerName: string;
//   resourceRate: string;
//   displayName: string;
//   searchCredential: string;
//   addedBy: string;
//   avatarImage: string;

//   gender:  string;
//   totalForecastHours: number;
//   totalForecastReconciledHours:  number;
//   totalProjectsForecastCount:  number;
//   totalCountProjects:  number;
//   totalCountProjectsPermitted:  number;
//   totalCountProgrammes:  number;
//   totalCountProgrammesPermitted:  number;
//   totalCountDomains:  number;
//   totalCountDomainsPermitted:  number;
//   totalCountPortfolios: number;
//   totalCountPortfoliosPermitted:  number;
//   totalCountBusinessUnits:  number;
//   totalCountBusinessUnitsPermitted:  number;
//   businessUnitsPermitted: any;
//   domainsPermitted: any;
//   portfoliosPermitted: any;
//   programmesPermitted: any;
//   projectsPermitted: any;
//   resourceWorkTimesheets: any;

//   janResourceUtilizationInDays: number;
//   febResourceUtilizationInDays: number;
//   marResourceUtilizationInDays: number;
//   aprResourceUtilizationInDays: number;
//   mayResourceUtilizationInDays: number;
//   junResourceUtilizationInDays: number;
//   julResourceUtilizationInDays: number;
//   augResourceUtilizationInDays: number;
//   sepResourceUtilizationInDays: number;
//   octResourceUtilizationInDays: number;
//   novResourceUtilizationInDays: number;
//   decResourceUtilizationInDays: number;
//   totalUtilizationInDays: number;
//   janAvailabilityBeforeHolidaysInDays: number;
//   febAvailabilityBeforeHolidaysInDays: number;
//   marAvailabilityBeforeHolidaysInDays: number;
//   aprAvailabilityBeforeHolidaysInDays: number;
//   mayAvailabilityBeforeHolidaysInDays: number;
//   junAvailabilityBeforeHolidaysInDays: number;
//   julAvailabilityBeforeHolidaysInDays: number;
//   augAvailabilityBeforeHolidaysInDays: number;
//   sepAvailabilityBeforeHolidaysInDays: number;
//   octAvailabilityBeforeHolidaysInDays: number;
//   novAvailabilityBeforeHolidaysInDays: number;
//   decAvailabilityBeforeHolidaysInDays: number;
//   totalAvailabilityBeforeHolidaysInDays: number;
//   janTotalHolidays: number;
//   febTotalHolidays: number;
//   marTotalHolidays: number;
//   aprTotalHolidays: number;
//   mayTotalHolidays: number;
//   junTotalHolidays: number;
//   julTotalHolidays: number;
//   augTotalHolidays: number;
//   sepTotalHolidays: number;
//   octTotalHolidays: number;
//   novTotalHolidays: number;
//   decTotalHolidays: number;


//   dateCreated: Date;
//   userCreatedId: string;
//   userCreatedResourceId: string;
//   userCreatedEmail: string;
//   dateModified: Date;
//   userModifiedId: string;
//   userModifiedEmail: string;
//   userModifiedResourceId: string;

// }

