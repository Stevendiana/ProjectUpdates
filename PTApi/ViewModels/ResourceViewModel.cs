using PTApi.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace PTApi.ViewModels
{
    public class ResourceViewModel: BaseEntity
    {
        [Key]
        public string ResourceId { get; set; }
        public string ResourceNumber { get; set; }
        [Required]
        public string ResourceEmailAddress { get; set; }
        public string EmployeeRef { get; set; }
        public DateTime? ResourceStartDate { get; set; }
        public DateTime? ResourceEndDate { get; set; }

        public string PlatformId { get; set; }
        public Platform Platform { get; set; }
        public string Agency { get; set; }
        public string Vendor { get; set; }
        public string LocationName { get; set; }
        public string Location { get; set; }
        public bool Billable { get; set; }
        public bool IsDisabled { get; set; }

        public string EmployeeJobTitle { get; set; }
        public string ResourceRateCardId { get; set; }
        public CompanyRateCard CompanyRateCard { get; set; }

        public decimal? ContractedHours { get; set; }
        public decimal? ResourceContractEffortInPercentage { get; set; }

        public string ResourceType { get; set; }
        public string EmployeeType { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
        public string ProjectId { get; set; }
        public Project Project { get; set; }
        public string ResourceManagerId { get; set; }
        //public string IdentityId { get; set; }
        //public ApplicationUser Identity { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageCaption { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public string ImageId { get; set; }
        public byte[] AvatarImage { get; set; }
       
        public string DisplayName { get; set; }

        public string Gender { get; set; }
        
        public decimal? TotalForecastHours { get; }
        
        public decimal? TotalForecastReconciledHours { get; }

        
        public int? TotalProjectsForecastCount { get; }
        
        public int? TotalCountProjects { get; }
        
        public int? TotalCountProjectsPermitted { get; }
        
        public int? TotalCountProgrammes { get; }
        
        public int? TotalCountProgrammesPermitted { get; }
        
        public int? TotalCountDomains { get; }
        
        public int? TotalCountDomainsPermitted { get; }
        
        public int? TotalCountPortfolios { get; }
        
        public int? TotalCountPortfoliosPermitted { get; }
        
        public int? TotalCountBusinessUnits { get; }
        
        public int? TotalCountBusinessUnitsPermitted { get; }


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

        public decimal? TotalUtilizationInDays { get; set; }

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
        public decimal? TotalAvailabilityBeforeHolidaysInDays { get; set; }

        
        public decimal? JanTotalHolidays { get; }
        
        public decimal? FebTotalHolidays { get; }
        
        public decimal? MarTotalHolidays { get; }
        
        public decimal? AprTotalHolidays { get; }
        
        public decimal? MayTotalHolidays { get; }
        
        public decimal? JunTotalHolidays { get; }
        
        public decimal? JulTotalHolidays { get; }
        
        public decimal? AugTotalHolidays { get; }
        
        public decimal? SepTotalHolidays { get; }
        
        public decimal? OctTotalHolidays { get; }
        
        public decimal? NovTotalHolidays { get; }
        
        public decimal? DecTotalHolidays { get; }

        public bool IsAppUser { get; set; }


        public ICollection<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }
        public ICollection<ResourceEffortSummary> ResourceEffortSummaries { get; set; }
        public ICollection<ResourceHolidayBooked> ResourceHolidaysBooked { get; set; }
        public ICollection<ForecastTask> ForecastTasks { get; set; }


        public ResourceViewModel()
        {

            ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();
            ResourceEffortSummaries = new Collection<ResourceEffortSummary>();
            ResourceHolidaysBooked = new Collection<ResourceHolidayBooked>();
            ForecastTasks = new Collection<ForecastTask>();
        }
    }
}
