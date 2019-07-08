using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTApi.Models
{

    [Table("Resources")]
    public class Resource : BaseEntity
    {

        [Key]
        public string ResourceId { get; set; }
        public string ResourceNumber { get; set;}
        [Required]
        public string ResourceEmailAddress { get; set; }
        public string EmployeeRef { get; set; }
        public DateTime? ResourceStartDate { get; set; }
        public DateTime? ResourceEndDate { get; set; }
        
        public string PlatformId { get; set; }
        [ForeignKey("PlatformId")]
        public Platform Platform { get; set; }
        public string Agency { get; set; }
        public string Vendor { get; set; }
        public string LocationName { get; set; }
        public string Location {get;set;}
        public bool Billable { get; set; }
        public bool IsDisabled {get;set;}

        public string EmployeeJobTitle { get; set; }
        public string ResourceRateCardId { get; set; }
        [ForeignKey("ResourceRateCardId")]
        public CompanyRateCard CompanyRateCard { get; set; }

        public decimal? ContractedHours { get; set;}
        public decimal? ResourceContractEffortInPercentage { get; set; }

        public string ResourceType { get; set; }
        public string EmployeeType { get; set; }

        [Required]
        public string CompanyId { get; set; }
        
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        //public string ProjectId { get; set; }
        //public Project Project { get; set; }
        public string ResourceManagerId { get; set; }
        public string IdentityId { get; set; }
        [ForeignKey("IdentityId")]
        public ApplicationUser Identity { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageCaption { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
        public string ImageId { get; set; }
        public byte[] AvatarImage { get; set; }
        [NotMapped]
        public string DisplayName { get; set; }
       
        public string Gender { get; set; }
        [NotMapped]
        public decimal? TotalForecastHours { get; }
        [NotMapped]
        public decimal? TotalForecastReconciledHours { get; }

        [NotMapped]
        public int? TotalProjectsForecastCount { get; }
        [NotMapped]
        public int? TotalCountProjects { get; }
        [NotMapped]
        public int? TotalCountProjectsPermitted { get; }
        [NotMapped]
        public int? TotalCountProgrammes { get; }
        [NotMapped]
        public int? TotalCountProgrammesPermitted { get; }
        [NotMapped]
        public int? TotalCountDomains { get; }
        [NotMapped]
        public int? TotalCountDomainsPermitted { get; }
        [NotMapped]
        public int? TotalCountPortfolios { get; }
        [NotMapped]
        public int? TotalCountPortfoliosPermitted { get; }
        [NotMapped]
        public int? TotalCountBusinessUnits { get; }
        [NotMapped]
        public int? TotalCountBusinessUnitsPermitted { get; }


        //public decimal? JanResourceUtilizationInDays { get; set; }
        //public decimal? FebResourceUtilizationInDays { get; set; }
        //public decimal? MarResourceUtilizationInDays { get; set; }
        //public decimal? AprResourceUtilizationInDays { get; set; }
        //public decimal? MayResourceUtilizationInDays { get; set; }
        //public decimal? JunResourceUtilizationInDays { get; set; }
        //public decimal? JulResourceUtilizationInDays { get; set; }
        //public decimal? AugResourceUtilizationInDays { get; set; }
        //public decimal? SepResourceUtilizationInDays { get; set; }
        //public decimal? OctResourceUtilizationInDays { get; set; }
        //public decimal? NovResourceUtilizationInDays { get; set; }
        //public decimal? DecResourceUtilizationInDays { get; set; }

        //// Schedule - Actual Days taken From ForecastTaskTimesheet

        //public decimal? TotalUtilizationInDays { get; set; }

        //public decimal? JanAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? FebAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? MarAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? AprAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? MayAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? JunAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? JulAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? AugAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? SepAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? OctAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? NovAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? DecAvailabilityBeforeHolidaysInDays { get; set; }
        //public decimal? TotalAvailabilityBeforeHolidaysInDays { get; set; }

        //[NotMapped]
        //public decimal? JanTotalHolidays { get; }
        //[NotMapped]
        //public decimal? FebTotalHolidays { get; }
        //[NotMapped]
        //public decimal? MarTotalHolidays { get; }
        //[NotMapped]
        //public decimal? AprTotalHolidays { get; }
        //[NotMapped]
        //public decimal? MayTotalHolidays { get; }
        //[NotMapped]
        //public decimal? JunTotalHolidays { get; }
        //[NotMapped]
        //public decimal? JulTotalHolidays { get; }
        //[NotMapped]
        //public decimal? AugTotalHolidays { get; }
        //[NotMapped]
        //public decimal? SepTotalHolidays { get; }
        //[NotMapped]
        //public decimal? OctTotalHolidays { get; }
        //[NotMapped]
        //public decimal? NovTotalHolidays { get; }
        //[NotMapped]
        //public decimal? DecTotalHolidays { get; }

        public bool IsAppUser
        {
            get
            {
                if (IdentityId != null)
                    return true;
                return false;
            }
            private set { }
        }


        public ICollection<ResourceWorkTimesheet> ResourceWorkTimesheets { get; set; }
        public ICollection<ResourceEffortSummary> ResourceEffortSummaries { get; set; }
        public ICollection<ResourceHolidayBooked> ResourceHolidaysBooked { get; set; }
        public ICollection<ForecastTask> ForecastTasks { get; set; }
       

        public Resource()
        {

            ResourceWorkTimesheets = new Collection<ResourceWorkTimesheet>();
            ResourceEffortSummaries = new Collection<ResourceEffortSummary>();
            ResourceHolidaysBooked = new Collection<ResourceHolidayBooked>();
            ForecastTasks = new Collection<ForecastTask>();
        }

    }
}