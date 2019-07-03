using PTApi.Models;
using PTApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace PTApi.ViewModels
{


    public class ResourceAdminViewModel: BaseEntity
   {
        //private readonly IPermissionService _permissionService;
        private readonly IResourceService _resourceService;

        public string ResourceId { get; set; }
        public string ResourceNumber { get; set;}
        public string ResourceEmailAddress { get; set; }
        public string EmployeeRef { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string EmployeeGradeBand { get; set; }
        public DateTime? ResourceStartDate { get; set; }
        public DateTime? ResourceEndDate { get; set; }
        public string Domain { get; set; }
        public string BusinessUnit { get; set; }
        public string CurrentPlatform { get; set; }
        public string PlatformLead { get; set; }
        public string ManagerName { get; set; }
        public string ResourceManagerId { get; set; }
        public string Agency { get; set; }
        public string Vendor { get; set; }
        public string LocationName { get; set; }
        public bool Billable { get; set; }
        public string ContractedHours { get; set;}
        public decimal? ResourceRate { get; set; }
        public decimal? ResourceContractEffortInPercentage { get; set; }
        public string ResourceType { get; set; }
        public string EmployeeType { get; set; }
        public string Location {get;set;}
        public string ImageCaption { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public string ImageId { get; set; }
        public bool IsDisabled {get;set;}
        public string AvatarImage { get; set; }
        public string CompanyId { get; set; }
        public string AppUserRole {get;set;}

        public Company Company { get; set; }
        public Project Project { get; set; }
        public string CompanyRateCardId { get; set; }
        public CompanyRateCard CompanyRateCard { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName  {
            get { return LastName + "," + " " + FirstName; }
        }
        public string SearchCredential  {
            get { return LastName + "," + "  " + FirstName + " -" + ResourceEmailAddress; }
        }
        public string AddedBy { get; set; }
        public string Gender { get; set; }
        public decimal? TotalForecastHours { get; set; }
        public decimal? TotalForecastReconciledHours { get; set;}
        public int? TotalProjectsForecastCount { get; set;}
        public int? TotalCountProjects { get; set; }
        public int? TotalCountProjectsPermitted { get; set; }
        public int? TotalCountProgrammes { get; set; }
        public int? TotalCountProgrammesPermitted { get; set; }
        public int? TotalCountDomains { get; set; }
        public int? TotalCountDomainsPermitted { get; set; }
        public int? TotalCountPortfolios { get; set; }
        public int? TotalCountPortfoliosPermitted { get; set; }
        public int? TotalCountBusinessUnits { get; set; }
        public int? TotalCountBusinessUnitsPermitted { get; set; }


        public decimal? JanResourceUtilizationInDays { get; set; }
        public decimal? FebResourceUtilizationInDays { get; set; }
        public decimal? MarResourceUtilizationInDays { get; set; }
        public decimal? AprResourceUtilizationInDays { get; set; }
        public decimal? MayResourceUtilizationInDays { get; set; }
        public decimal? JunResourceUtilizationInDays { get; set; }
        public decimal? JulResourceUtilizationInDays { get; set; }
        public decimal? AugResourceUtilizationInDays { get; set; }
        public decimal? SepResourceUtilizationInDays { get; set; }
        public decimal? OctResourceUtilizationInDays { get; set; }
        public decimal? NovResourceUtilizationInDays { get; set; }
        public decimal? DecResourceUtilizationInDays { get; set; }

        // Schedule - Actual Days taken From ForecastTaskTimesheet

        public decimal? TotalUtilizationInDays
        {
            get{return JanResourceUtilizationInDays + FebResourceUtilizationInDays + MarResourceUtilizationInDays + AprResourceUtilizationInDays
                     + MayResourceUtilizationInDays + JunResourceUtilizationInDays +  JulResourceUtilizationInDays + AugResourceUtilizationInDays
                     + SepResourceUtilizationInDays + OctResourceUtilizationInDays +  NovResourceUtilizationInDays + DecResourceUtilizationInDays; }
        }

        //standard daily hours = 8hrs.


        public decimal? JanAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? FebAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? MarAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? AprAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? MayAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? JunAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? JulAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? AugAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? SepAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? OctAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? NovAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? DecAvailabilityBeforeHolidaysInDays { get; set; }
        public decimal? TotalAvailabilityBeforeHolidaysInDays
        {
            get{return JanAvailabilityBeforeHolidaysInDays + FebAvailabilityBeforeHolidaysInDays + MarAvailabilityBeforeHolidaysInDays + AprAvailabilityBeforeHolidaysInDays
                     + MayAvailabilityBeforeHolidaysInDays + JunAvailabilityBeforeHolidaysInDays +  JulAvailabilityBeforeHolidaysInDays + AugAvailabilityBeforeHolidaysInDays
                     + SepAvailabilityBeforeHolidaysInDays + OctAvailabilityBeforeHolidaysInDays +  NovAvailabilityBeforeHolidaysInDays + DecAvailabilityBeforeHolidaysInDays; }
        }

        public decimal? JanTotalHolidays { get; set; }
        public decimal? FebTotalHolidays { get; set; }
        public decimal? MarTotalHolidays { get; set; }
        public decimal? AprTotalHolidays { get; set; }
        public decimal? MayTotalHolidays { get; set; }
        public decimal? JunTotalHolidays { get; set; }
        public decimal? JulTotalHolidays { get; set; }
        public decimal? AugTotalHolidays { get; set; }
        public decimal? SepTotalHolidays { get; set; }
        public decimal? OctTotalHolidays { get; set; }
        public decimal? NovTotalHolidays { get; set; }
        public decimal? DecTotalHolidays { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }

        public ResourceAdminViewModel()
        {

        }

        public ResourceAdminViewModel(IResourceService resourceService)
        {

             //_permissionService = permissionService;
             _resourceService = resourceService;
            ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();
            Projects = new Collection<Project>();
        }
    }
}