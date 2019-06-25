using PTApi.Models;
using PTApi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PTApi.ViewModels
{
    public class ResourceViewModel: BaseEntity
    {
        public string ResourceId { get; set; }
        public string ResourceNumber { get; set;}
        [Required]
        public string ResourceEmailAddress { get; set; }
        public string EmployeeRef { get; set; }
        public DateTime? ResourceStartDate { get; set; }
        public DateTime? ResourceEndDate { get; set; }
        public string Domain { get; set; }
        public string BusinessUnit { get; set; }
        public string CurrentPlatform { get; set; }
        public string PlatformLead { get; set; }
        public string Agency { get; set; }
        public string Vendor { get; set; }
        public string LocationName { get; set; }
        public string Location {get;set;}
        public bool Billable { get; set; }
        public bool IsDisabled {get;set;}
        public string EmployeeJobTitle { get; set; }
        public string ResourceRateCardId { get; set; }
        public CompanyRateCard CompanyRateCard { get; set; }

        public decimal? ContractedHours { get; set;}
        public decimal? ResourceContractEffortInPercentage { get; set; }
        public string ResourceType { get; set; }
        public string EmployeeType { get; set; }
        public string ImageCaption { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public string ImageId { get; set; }

        public string AvatarImage { get; set; }
        // public IFormFile AvatarImage { get; set; }

        [Required]
        public string CompanyId { get; set; }
        [Required]
        public string AppUserRole {get;set;}
        public Company Company { get; set; }
        public string ResourceManagerId { get; set; }
        public string IdentityId { get; set; }
        public ApplicationUser Identity { get; set; }
         [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string EmployeeGradeBand { get; set; }
        public string ManagerName { get; set; }
        public decimal? ResourceRate { get; set; }
        public string DisplayName  {
            get { return LastName + "," + " " + FirstName; }
        }
        public string AddedBy { get; set; }
        public string Gender { get; set; }
        public int? TotalForecastHours { get; }
        public int? TotalForecastReconciledHours { get; }
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
       
        public ICollection<ProjectPermitted> ProjectsPermitted { get; set; }
        // public ICollection<Resource> Resources { get; set; }
        public ICollection<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }
        public ResourceViewModel()
        {

        }

        public ResourceViewModel(IPermissionService permissionService)
        {
            // Resources = new Collection<Resource>();
         
            ProjectsPermitted = new Collection<ProjectPermitted>();
            ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();
        }
    }
}
